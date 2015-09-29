using FractalCreator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractal.Model.Class
{
    public class RenderProperties
    {
        public Area Area
        {
            get
            {
                return new Area(new Area.Point(StartX,StartY),
                    new Area.Point(StartX + SideLenght,StartY + SideLenght));
            }
            set
            {
                StartX = value.Start.X;
                StartY = value.Start.Y;
                SideLenght = value.End.X - value.Start.X;
            }
        }

        public FractalType Fractal;
        public bool SingleIteration;
        public int Width;
        public int Height;
        public int Iterations;
        public double StartX;
        public double StartY;
        public double SideLenght;
        public double RealConst;
        public double ImaginaryConst;
    }
}
