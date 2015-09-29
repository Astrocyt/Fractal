using Fractal.Model.Class;
using Fractal.Presenter.Interface;
using Fractal.View.Interface;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;
using System.Linq;

namespace Fractal.View.Class
{
    public partial class PropertiesWindow : Form , IPropertiesView
    {
        private Color _fractalColor;
        private Color _backgroundColor;
        private IPropertiesViewPresenter _presenter;

        #region Color panels update fileds
       
        Graphics _redFillColorPanel;
        Graphics _greenFillColorPanel;
        Graphics _blueFillColorPanel;
        Graphics _fractalColorPanel;
        Graphics _backgroundColorPanel;
        
        Rectangle _colorFillStartRectangle;
        Rectangle _colorFillEndRectangle;
        Rectangle _staticColorRectangle;

        #endregion

        public PropertiesWindow()
        {
            InitializeComponent();
            
            _backgroundColor = Color.Black;
            _fractalColor = Color.White;

            #region Color panels files
            
            _redFillColorPanel = redStartEndPreviewPanel.CreateGraphics();
            _greenFillColorPanel = greenStartEndPreviewPanel.CreateGraphics();
            _blueFillColorPanel = blueStartEndPreviewPanel.CreateGraphics();
            _fractalColorPanel = fractalColorPreviewPanel.CreateGraphics();
            _backgroundColorPanel = baseColorPreviewPanel.CreateGraphics();

            _colorFillStartRectangle = new Rectangle(new Point(0,0),
                new Size(redStartEndPreviewPanel.Width/2,redStartEndPreviewPanel.Height));
            _colorFillEndRectangle = new Rectangle(new Point(redStartEndPreviewPanel.Width / 2, 0),
                new Size(redStartEndPreviewPanel.Width/2,redStartEndPreviewPanel.Height));
            _staticColorRectangle = new Rectangle(new Point(0,0),
                new Size(baseColorPreviewPanel.Width,baseColorPreviewPanel.Height));

            #endregion

            this.fractalTypeComboBox.Items.AddRange(Enum.GetNames(typeof(FractalType)));
            this.fractalTypeComboBox.SelectedIndex = 0;

            imageFormatComboBox.Items.AddRange(typeof(ImageFormat).
                GetProperties().Select((p)=>p.Name)
                .Except(new string[]{"Guid","MemoryBmp"})
                .ToArray());

            imageFormatComboBox.SelectedIndex = 0;

        }
        
        #region IPropertiesView
       
        public RenderProperties GetRenderProperties()
        {
            double[] startP = ParseStartPosition();
            FractalType fractType = (FractalType)(Enum.Parse(typeof(FractalType),
                fractalTypeComboBox.SelectedItem.ToString()));
            RenderProperties properties = new RenderProperties{

                Fractal = fractType,

                Width = int.Parse(imageWidthTextBox.Text),
                Height = int.Parse(imageHeightTextBox.Text),
                Iterations = iterationshScrollBar.Value,
                SideLenght = double.Parse(sideLenghtTextBox.Text,CultureInfo.InvariantCulture),
                SingleIteration = singleIterationMode.Checked,
                StartX = startP[0],
                StartY = startP[1],
                RealConst = double.Parse(realConstTextBox.Text,CultureInfo.InvariantCulture),
                ImaginaryConst = double.Parse(imaginaryConstTextBox.Text,CultureInfo.InvariantCulture)
            };

            return properties;
        }
        
        public RenderColors GetRenderColors()
        {
            RenderColors colorInfo = new RenderColors{
            
            RedStart = (byte)redStartvScrollBar.Value,
            RedEnd = (byte)redEndvScrollBar.Value,
            GreenStart = (byte)greenStartvScrollBar.Value,
            GreenEnd = (byte)greenEndvScrollBar.Value,
            BlueStart = (byte)blueStartvScrollBar.Value,
            BlueEnd = (byte)blueEndvScrollBar.Value,

            FractalColor = _fractalColor,
            BackgroundColor = _backgroundColor
            };

            return colorInfo;
        }
        
        public void ChangeProgressBarValue(int value)
        {
            this.Invoke((MethodInvoker)(()=>{
            
            this.renderProgressProgressBar.Value = value;
            
            }));
        }
        
        public void SetRenderTime(TimeSpan time)
        {
            this.Invoke((MethodInvoker)(()=>{
            
                this.renderTimeLabel.Text = string.Format("Time: {0}:{1}",
                    time.Seconds,
                    Math.Round((decimal)time.Milliseconds,4));
            
            }));
        }
        
        public void AttachPresenter(IPropertiesViewPresenter presenter)
        {
            this._presenter = presenter;
        }
        
        public void UpdateProperties(RenderProperties properties)
        {
            this.Invoke((MethodInvoker)(()=>{
                this.imageWidthTextBox.Text = properties.Width.ToString();
                this.imageHeightTextBox.Text = properties.Height.ToString();
                this.startPositionTextBox.Text = string.Format("{0}:{1}",
                    properties.StartX.ToString(CultureInfo.InvariantCulture),
                    properties.StartY.ToString(CultureInfo.InvariantCulture));

                this.sideLenghtTextBox.Text = properties.SideLenght.ToString(CultureInfo.InvariantCulture);
                this.realConstTextBox.Text = properties.RealConst.ToString(CultureInfo.InvariantCulture);
                this.imaginaryConstTextBox.Text = properties.ImaginaryConst.ToString(CultureInfo.InvariantCulture);
                this.iterationshScrollBar.Value = properties.Iterations;
            }));
        }

        #endregion

        private double[] ParseStartPosition()
        {
            string[] values = startPositionTextBox.Text.Split(':');
            double x = double.Parse(values[0], CultureInfo.InvariantCulture);
            double y = double.Parse(values[1], CultureInfo.InvariantCulture);
            return new double[]{x,y};
        }
        
        private void RenderFractal(object sender,EventArgs e)
        {
            _presenter.RenderFractal();
        }

        private void IterationsChanged(object sender, EventArgs e)
        {
            this.iterationsTextBox.Text = (sender as HScrollBar).Value.ToString();
        }

        private void ColorsFillValueChanged(object sender, EventArgs e)
        {
            SolidBrush redS = new SolidBrush(Color.FromArgb(255, redStartvScrollBar.Value, 0, 0));
            SolidBrush redE = new SolidBrush(Color.FromArgb(255, redEndvScrollBar.Value, 0, 0));
            SolidBrush greenS = new SolidBrush(Color.FromArgb(255, 0, greenStartvScrollBar.Value, 0));
            SolidBrush greenE = new SolidBrush(Color.FromArgb(255, 0, greenEndvScrollBar.Value, 0));
            SolidBrush blueS = new SolidBrush(Color.FromArgb(255, 0, 0, blueStartvScrollBar.Value));
            SolidBrush blueE = new SolidBrush(Color.FromArgb(255, 0, 0, blueEndvScrollBar.Value));

            _redFillColorPanel.FillRectangle(redS,_colorFillStartRectangle);
            _redFillColorPanel.FillRectangle(redE, _colorFillEndRectangle);
            _greenFillColorPanel.FillRectangle(greenS, _colorFillStartRectangle);
            _greenFillColorPanel.FillRectangle(greenE, _colorFillEndRectangle);
            _blueFillColorPanel.FillRectangle(blueS, _colorFillStartRectangle);
            _blueFillColorPanel.FillRectangle(blueE, _colorFillEndRectangle);

        }

        private void WindowShow(object sender, EventArgs e)
        {
            ColorsFillValueChanged(null,null);
        }

        private void FractalColorChange(object sender, EventArgs e)
        {
             ColorDialog colorD = new ColorDialog();
             DialogResult result = colorD.ShowDialog();
            
            if(result == DialogResult.OK)
            {
                _fractalColor = colorD.Color;
                _fractalColorPanel.FillRectangle(new SolidBrush(_fractalColor),
                    _staticColorRectangle);
            }
        }

        private void BackgroundColorChange(object sender, EventArgs e)
        {
            ColorDialog colorD = new ColorDialog();
            DialogResult result = colorD.ShowDialog();

            if (result == DialogResult.OK)
            {
                _backgroundColor = colorD.Color;
                _backgroundColorPanel.FillRectangle(new SolidBrush(colorD.Color),
                    _staticColorRectangle);
            }
        }

        private void SaveImage(object sender, EventArgs e)
        {

            var x = (ImageFormat)typeof(ImageFormat).
                GetProperty(imageFormatComboBox.SelectedItem.ToString()).GetValue(null);
            string imgName = string.Format("{0}_{1}",
                renderTimeLabel.Text.Split(':')[1],
                fractalTypeComboBox.SelectedItem.ToString());

            _presenter.SaveFractalImage(x,imgName);
        }

    }
}
