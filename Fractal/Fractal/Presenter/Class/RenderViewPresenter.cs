using Fractal.Model.Class;
using Fractal.Presenter.Interface;
using Fractal.View.Class;
using Fractal.View.Interface;
using FractalCreator.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal.Presenter.Class
{
    public class RenderViewPresenter : IRenderViewPresenter
    {
        public event PropertiesUpdate PropertiesUpdateCall;
        
        private Stack<FractInfo> _fractalsStack;
        private IRenderPreviewView _view;
        private RenderEngine _renderEngine;
        private Thread _renderViewThread;
        private RenderProperties _renderProperties;
        private RenderColors _renderColors;
        private FractInfo _lastRender;


        public RenderViewPresenter()
        {
            
            _fractalsStack = new Stack<FractInfo>();
            
            this._renderEngine = new RenderEngine();
            this._renderEngine.RenderCompleteCall += RenderComplete;
            this._renderEngine.RenderProgressCall += RenderIterationCall;
        }
        
        #region IRenderViewPresenter
        
        public event RenderComplete RenderCompleteCall;
        public event RenderProgress RenderProgressCall;
        public Image ActualFractalImage {get;private set;}

        public void ChangeFractalArea(Point start, Point end)
        {
           this._renderProperties.Area = GetNewArea(start,end);
            
           var image = _renderEngine.RenderFractal(_renderProperties,_renderColors);
            _view.ShowImage(image);
            
            _fractalsStack.Push(_lastRender);
            _lastRender = new FractInfo(){Image = image,Area = _renderProperties.Area};
            ActualFractalImage = _lastRender.Image;
        }

        public void ShowPreviewFractal()
        {
            if(_fractalsStack.Count > 0)
            {
                FractInfo info = _fractalsStack.Pop();
                this._renderProperties.Area = info.Area;
                this._view.ShowImage(info.Image);
            }
        }

        public void ShowFractal(RenderProperties properties, RenderColors colors)
        {
           Task.Factory.StartNew(()=>
               {
                   RenderAndSetFractal(properties,colors);
               });

        }

        public void UpdateProperties()
        {
            if(PropertiesUpdateCall != null)
            {
                PropertiesUpdateCall(_renderProperties);
            }
        }
       
        #endregion

        private void RenderAndSetFractal(RenderProperties properties,RenderColors colors)
        {
            this._renderColors = colors;
            this._renderProperties = properties;

            var i = _renderEngine.RenderFractal(properties, colors);
            if (_renderViewThread == null || !_renderViewThread.IsAlive)
            {
                CreateRenderViewThread(i);
                _fractalsStack.Clear();
            }
            else
            {
                _view.ShowImage(i);
            }
            _lastRender = new FractInfo() { Image = i, Area = properties.Area };
            ActualFractalImage = i;
        }

        private void RenderIterationCall(int iteration, int accuracy)
        {
            if(RenderProgressCall != null)
            {
                RenderProgressCall(iteration, accuracy);
            }
        }
            
        private void RenderComplete(TimeSpan span)
        {
            if(RenderCompleteCall != null)
                RenderCompleteCall(span);
        }

        private Area GetNewArea(Point p1,Point p2)
        {
            Point[] points = CreateAreaPoints(p1, p2);

            double xRatio = (_renderProperties.Area.End.X -
                _renderProperties.Area.Start.X) / _renderProperties.Width;

            double yRatio = (_renderProperties.Area.End.Y -
                _renderProperties.Area.Start.Y) / _renderProperties.Height;

            Area newArea = new Area
                (
                    new Area.Point(xRatio * points[0].X + _renderProperties.StartX,
                        yRatio * points[0].Y + _renderProperties.StartY),
                    new Area.Point(xRatio * points[1].X + _renderProperties.StartX,
                        yRatio * points[1].Y + _renderProperties.StartY)
                );
            return newArea;
        }

        //[0] = start, [1] = end
        private Point[] CreateAreaPoints(Point p1,Point p2)
        {
            if(p1.X > p2.X)
            {
                int x = p2.X;
                p2.X = p1.X;
                p1.X = x; 
            }
            if(p1.Y > p2.Y)
            {
                int y = p2.Y;
                p2.Y = p1.Y;
                p1.Y = y;
            }
            int xDifferent = p2.X - p1.X;
            int yDifferent = p2.Y - p1.Y;
            int sideSize = xDifferent > yDifferent ? xDifferent : yDifferent;
            
            return 
                new Point[]
            {
              p1,
              new Point(p1.X + sideSize,p1.Y+sideSize)
            };
        }
        
        private void CreateRenderViewThread(object image)
        {
            _renderViewThread = new Thread(new ParameterizedThreadStart(RunView));
            _renderViewThread.IsBackground = true;
            _renderViewThread.Start(image);
        }

        private void RunView(object image)
        {
            this._view = new RenderPreviewWindow();
            _view.AttachPresenter(this);
            _view.ShowImage(image as Image);
            Application.Run(_view as Form);
        } 
        
        private struct FractInfo
        {
            public Area Area;
            public Image Image;
        }
    }
}
