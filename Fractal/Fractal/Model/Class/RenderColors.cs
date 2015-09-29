using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal.Model.Class
{
    public class RenderColors
    {
        public Color FractalColor;
        public Color BackgroundColor;
        public byte RedStart;
        public byte RedEnd;
        public byte GreenStart;
        public byte GreenEnd;
        public byte BlueStart;
        public byte BlueEnd;


        public Color[] GetColorPalette(int iterations)
        {
            Color[] colors = new Color[iterations];
            int hueNumber = 20;


            double redStep = (double)(RedEnd-RedStart) /hueNumber;
            double greenStep = (double)(GreenEnd - GreenStart) /hueNumber;
            double blueStep = (double)(BlueEnd - BlueStart) /hueNumber;
            
            for (int i = 1; i <= iterations; i++)
            {
                colors[i - 1] = Color.FromArgb(255,
                    (byte)(RedStart + (int)(redStep*      ((double)hueNumber/iterations)*i)),
                    (byte)(GreenStart + (int)(greenStep * ((double)hueNumber / iterations) * i)),
                    (byte)(BlueStart + (int)(blueStep * ((double)hueNumber / iterations) * i)));
            }
            
            return colors;
        }
    }
}
