using FractalCreator.Data.Interface;
using FractalCreator.Data;
using System;
using System.Drawing;

namespace FractalCreator.FractalClass
{
    public class MandelbrotSet : FractalSet,IFractal
    {

        public MandelbrotSet(Color fractalColor, Color backgroundColor, int accuracy)
            : base(fractalColor,backgroundColor,accuracy)
        {
            base.RenderCompleteCall += RenderCompleteCalling;
            base.RenderProgressCall += ProgressCalling;
        }
        public MandelbrotSet(Color[] iterationsColor, int iterations)
            : base(iterationsColor, iterations)
        {
            base.RenderCompleteCall += RenderCompleteCalling;
            base.RenderProgressCall += ProgressCalling;
        }


        #region IFractal
        public event RenderComplete RenderComplete;
        public event RenderProgress RenderProgress;

        public Image GenerateImage(System.Drawing.Size size)
        {
            return base.RenderImage(size,new Area(new Area.Point(-2,-1.25),new Area.Point(0.5,1.25)));
        }
        public Image GenerateImage(System.Drawing.Size size, Data.Area area)
        {
            return base.RenderImage(size,area);
        }
        #endregion

        protected override bool Contains(double realPart,double imaginaryPart,int accuracy)
        {
            double real=0,imag=0,modulus=0;
            for (int i = 0; i < accuracy; i++)
            {
                if(modulus >= 4)
                    return false;
                else
                {
                    double x  = (real*real)-(imag*imag) + realPart;
                    double y  = (2*real*imag)+ imaginaryPart;
                    real = x;
                    imag = y;
                    modulus = (real*real)+(imag*imag);
                }
            }
            return true;
        }


        private void ProgressCalling(int iteration,int accuracy)
        {
            if(RenderProgress != null)
            {
                RenderProgress(iteration,accuracy);
            }
        }
        private void RenderCompleteCalling(TimeSpan span)
        {
            if(RenderComplete != null)
            {
                RenderComplete(span);
            }
        }
    }
}
