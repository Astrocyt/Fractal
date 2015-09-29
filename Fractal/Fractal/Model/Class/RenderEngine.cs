
using FractalCreator.Data;
using FractalCreator.Data.Interface;
using FractalCreator.FractalClass;
using System.Drawing;
namespace Fractal.Model.Class
{
    public class RenderEngine
    {
        public event RenderComplete RenderCompleteCall;
        public event RenderProgress RenderProgressCall;

        public RenderEngine()
        {
            
        }
        
        public Image RenderFractal(RenderProperties properties, RenderColors colors)
        {
            IFractal fract =  GetFractal(properties,colors);
            fract.RenderComplete += RenderCompleteCall;
            fract.RenderProgress += RenderProgressCall;
            return fract.GenerateImage(new Size(properties.Width,properties.Height),properties.Area);      
        }

        private IFractal GetFractal(RenderProperties properties, RenderColors colors)
        {
            IFractal fractal = null;
            
            if(properties.Fractal == FractalType.Mandelbrot)
            {
                if(properties.SingleIteration)
                {
                    fractal = new MandelbrotSet(colors.FractalColor, colors.BackgroundColor, properties.Iterations);
                }
                else 
                {
                    fractal = new MandelbrotSet(colors.GetColorPalette(properties.Iterations),
                        properties.Iterations);
                }
            }
            else if(properties.Fractal == FractalType.Julia)
            {
                if(properties.SingleIteration)
                {
                    fractal = new JuliaSet(colors.FractalColor,
                        colors.BackgroundColor,
                        properties.RealConst,
                        properties.ImaginaryConst,
                        properties.Iterations);
                }
                else
                {
                     fractal = new JuliaSet(colors.GetColorPalette(properties.Iterations),
                         properties.RealConst,
                         properties.ImaginaryConst,
                         properties.Iterations);
                }
            }
            
            return fractal;
        }
    }
}
