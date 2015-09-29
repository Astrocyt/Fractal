using FractalCreator.Data;
using FractalCreator.Data.Interface;
using System;
using System.Drawing;

namespace FractalCreator.FractalClass
{
    public class JuliaSet : FractalSet,IFractal
    {
        public static Area DefaultArea 
        {
            get
            {
                return new Area(new Area.Point(-2,-1.25),new Area.Point(1,1.75));
            }
        }

        private double  _realConstant;
        private double  _imaginaryConstant;

        public JuliaSet(Color fractalColor, Color backgroundColor,
            double imaginaryConstant,double realConstatnt,int accuracy)
            :base(fractalColor,backgroundColor,accuracy)
        {
            base.RenderCompleteCall += RenderCompleteCalling;
            base.RenderProgressCall += ProgressCalling;

            this._imaginaryConstant = imaginaryConstant;
            this._realConstant = realConstatnt;
        }
        public JuliaSet(Color[] iterationsColor,double realConstant, double imaginaryConstant,int iterations)
            :base(iterationsColor, iterations)
        {
            base.RenderCompleteCall += RenderCompleteCalling;
            base.RenderProgressCall += ProgressCalling;

            this._imaginaryConstant = imaginaryConstant;
            this._realConstant = realConstant;
        }

        #region IFractal
        public event RenderComplete RenderComplete;
        public event RenderProgress RenderProgress;

        public Image GenerateImage(Size size)
        {
            return base.RenderImage(size,DefaultArea);
        }
        public Image GenerateImage(Size size, Data.Area area)
        {
            return base.RenderImage(size,area);
        }
        #endregion



        protected override bool Contains(double realPart,double imaginaryPart,int accuracy)
        {
            double real=realPart,imag=imaginaryPart,modulus=0;
            for (int i = 0; i < accuracy; i++)
            {
                if(modulus >= 4)
                    return false;
                else
                {
                    double x  = (real*real)-(imag*imag) + _realConstant;
                    double y  = (2*real*imag) + _imaginaryConstant;
                    real = x;
                    imag = y;
                    modulus = (real*real)+(imag*imag);
                }
            }
            return true;


            // double x=realPart,y=imaginaryPart,modulus=0;

            // for (int i = 0; i < accuracy; i++)
            // {
            //     if(modulus >= 4)
            //         return false;
            //     else
            //     {
            //        //double real = (x*x) - (y*y) + _realConstant;
            //        //double imag = (2*x*y) + _imaginaryConstant;
            //        //x = real;
            //        //y = imaginaryPart;
            //        //modulus = (x*x) + (y*y);
            //     }
            // }
            //return true;
        }

        private void ProgressCalling(int iteration, int accuracy)
        {
            if (RenderProgress != null)
            {
                RenderProgress(iteration, accuracy);
            }
        }
        private void RenderCompleteCalling(TimeSpan span)
        {
            if (RenderComplete != null)
            {
                RenderComplete(span);
            }
        }
    }
}
