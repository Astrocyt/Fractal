using Fractal.Presenter.Interface;
using Fractal.View.Interface;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Fractal.View.Class
{
    public partial class RenderPreviewWindow : Form, IRenderPreviewView
    {
        IRenderViewPresenter _presenter;
        Thread _createThread;
        private Point _newAreaStartPosition;
        private Point _newAreaEndPosition;
        private bool _mouseClicked;
        private Panel _zoomRectangle;
        private ContextMenu _contextMenu;

        public RenderPreviewWindow()
        {
            InitializeComponent();
            _createThread = Thread.CurrentThread;
            _mouseClicked = false;
            //zoom Panel
            _zoomRectangle = new Panel();
            _zoomRectangle.BackColor = Color.FromArgb(30,255,255,255);
            _zoomRectangle.Size = new Size(0,0);
            previewPictureBox.Controls.Add(_zoomRectangle);
            //Context menu initialization
            _contextMenu = new ContextMenu();
            MenuItem[] menuItems = new MenuItem[]
            {
                new MenuItem("Back",new EventHandler(ShowPreviewFractal)),
                new MenuItem("Update Coordinates",new EventHandler(UpdateCoordinates))
            };
            _contextMenu.MenuItems.AddRange(menuItems);
        }
        
        #region IRenderPreviewView

        public void ShowImage(Image image)
        {
            if(Thread.CurrentThread.Equals(_createThread))
            {
                this.previewPictureBox.Location = new Point(0,0);
                this.previewPictureBox.Image = image;
                this.previewPictureBox.Size = image.Size;
                this.Width = image.Width + 15;
                this.Height = image.Height + 25;
            }
            else
            {
                this.Invoke((MethodInvoker)(()=>
                {
                this.previewPictureBox.Size = image.Size;
                this.previewPictureBox.Image = image;
                this.Width = image.Width + 20;
                this.Height = image.Height + 20;
                }));
            }
        }

        public void AttachPresenter(IRenderViewPresenter presenter)
        {
            this._presenter =  presenter;
        }

        #endregion 
    
        public bool Exist
        {
            get { return this.IsDisposed; }
        }

        private void ChangeArea(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.None)
            {
                if(_mouseClicked)
                {
                    _presenter.ChangeFractalArea(_newAreaStartPosition,_newAreaEndPosition);
                    _mouseClicked = false;
                    _zoomRectangle.Size = new Size(0,0);
                }
                else
                {
                    _newAreaStartPosition = e.Location;
                }
            }
            else if(e.Button == MouseButtons.Left)
            {
                _mouseClicked = true;
                _newAreaEndPosition = e.Location;
                ShowZoomPanel(_newAreaStartPosition,e.Location);
            }
        }

        private void ShowZoomPanel(Point p1,Point p2)
        {
            int x = p1.X < p2.X ? p1.X : p2.X;
            int y = p1.Y < p2.Y ? p1.Y : p2.Y;
            
            _zoomRectangle.Location = new Point(x,y);
            _zoomRectangle.Size = new Size(Math.Abs(p1.X - p2.X),Math.Abs(p1.Y-p2.Y));

        }

        private void HandleMouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                _contextMenu.Show(previewPictureBox,e.Location);
            }
        }

        // MenuItem click handling
        private void UpdateCoordinates(object sender,EventArgs e)
        {
            _presenter.UpdateProperties();
        }
        
        private void ShowPreviewFractal(object sender,EventArgs e)
        {
            _presenter.ShowPreviewFractal();
        }
    }
}
