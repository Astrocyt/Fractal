using FractalCreator.Data;
using System;
using System.Drawing;
using System.Threading;
using FractalCreator.Data.Global;

namespace FractalCreator.FractalClass
{
    public abstract class FractalSet
    {
        /* Base for complex plain fractals */

        protected event RenderComplete RenderCompleteCall;
        protected event RenderProgress RenderProgressCall;

        private Color[] _iterationColors;
        private Color _fractalColor;
        private Color _backgroundColor;
        private bool _singleIterationMode;
        private int _accuracy;
        private double _widthRatio;
        private double _heightRatio;
        private int _renderAsyncIterations;
        //private int _threadNumber;

        public FractalSet(Color[] iterationsColors, int iterations)
        {
            this._iterationColors = iterationsColors;
            this._accuracy = iterations;
            this._singleIterationMode = false;
        }
        public FractalSet(Color fractalColor,Color backgroundColor,int accuracy)
        {
            this._fractalColor = fractalColor;
            this._backgroundColor = backgroundColor;
            this._accuracy = accuracy;
            this._singleIterationMode = true;
        }

        protected abstract bool Contains(double realPart,double imaginaryPart, int accuracy);

       
        protected Image RenderImage(Size size,Area area)
        {
            Image fractalImage;
            _widthRatio = (area.End.X - area.Start.X)/size.Width;
            _heightRatio = (area.End.Y - area.Start.Y)/size.Height;
            _renderAsyncIterations = 0;

            var startClock = DateTime.Now;

            if(_singleIterationMode)
            {
                fractalImage = SingleIterationRender(size,area);
            }
            else
            {
                fractalImage = CreateRenderThreads(size,area);
            }

            var renderTime = DateTime.Now - startClock;
            
            if(RenderCompleteCall != null)
                RenderCompleteCall(renderTime);

            return fractalImage;
        }

        private Image CreateRenderThreads(Size size,Area area)
        {
             Bitmap image = new Bitmap(size.Width,size.Height);
             BitmapEditor editor = new BitmapEditor(image);

             
             int[] ranges = GetRangesPixelsArray(size.Width,RenderSettings.NumberOfThreads);

             Thread[] threads = new Thread[RenderSettings.NumberOfThreads];
             
             editor.LockBits();
             for (int i = 0; i < RenderSettings.NumberOfThreads; i++)
             {
                 threads[i] = new Thread(new ParameterizedThreadStart(ProcessBitmapPart));
                 threads[i].IsBackground = true;
                 threads[i].Priority = RenderSettings.ThreadsPriority;
                 threads[i].Start(new ThreadData()
                 {
                    areaPlain = area,
                    imageSize = size,
                    widthStart = ranges[i],
                    widthEnd = ranges[i+1],
                    editorReference = editor
                 });
             }
             foreach (var t in threads)
             {
                 t.Join();
             }
             editor.UnlockBits();
             
            return image;
        }

        private int[] GetRangesPixelsArray(int width,int cores)
        {
            int[] ranges = new int[cores+1];
            ranges[0] = 0;
            int step = (int)(width/cores);

            for (int i = 1; i < cores; i++)
            {
                ranges[i] = step*i;
            }

            ranges[cores] = width;
            return ranges;
        }
        private void ProcessBitmapPart(object properties)
        {
            ThreadData td = (ThreadData)properties;
            double realPart,imaginaryPart;
            for(int a=0;a<_accuracy;a++)
            {
                for (int i = 0; i < td.imageSize.Height; i++)
                {
                    for (int r = td.widthStart; r < td.widthEnd; r++)
                    {
                        realPart = (_widthRatio * r) + td.areaPlain.Start.X;
                        imaginaryPart = (_heightRatio * i) + td.areaPlain.Start.Y;
                        if (Contains(realPart,imaginaryPart, a))
                        {
                            td.editorReference.SetPixel(r, i, _iterationColors[a]);
                        }
                    }
                }
                RenderAsyncIterationCall();
            }
        }

        private void RenderAsyncIterationCall()
        {
            Interlocked.Increment(ref _renderAsyncIterations);
            if(_renderAsyncIterations % RenderSettings.NumberOfThreads == 0 &&
                RenderProgressCall != null)
            {
                RenderProgressCall(
                    _renderAsyncIterations/RenderSettings.NumberOfThreads,
                    _accuracy);
            }

        }


        private Image SingleIterationRender(Size size,Area area)
        {
            Bitmap image = new Bitmap(size.Width,size.Height);
            Graphics.FromImage(image).FillRectangle(new SolidBrush(_backgroundColor),0,0,size.Width,size.Height);
            BitmapEditor editor = new BitmapEditor(image);
            double realPart,imaginaryPart;

            editor.LockBits();
            for (int i = 0; i < size.Height; i++)
            {
                for (int r = 0; r < size.Width; r++)
                {
                    realPart = (r*_widthRatio) + area.Start.X;
                    imaginaryPart = (i* _heightRatio) + area.Start.Y;

                    if(Contains(realPart,imaginaryPart,_accuracy))
                    {
                        editor.SetPixel(r,i,_fractalColor);
                    }
                }

                if(RenderProgressCall != null)
                {
                    RenderProgressCall(i,size.Height);
                }
            }
            editor.UnlockBits();
            return image;
        }

        private struct ThreadData
        {
            public Size imageSize;
            public Area areaPlain;
            public int widthStart;
            public int widthEnd;
            public BitmapEditor editorReference;
        }
    }
}
