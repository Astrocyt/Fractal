
namespace FractalCreator.Data
{
    public class Area
    {
        public Point Start;
        public Point End;

        public Area(Point start, Point end)
        {
            this.Start = start;
            this.End = end;
        }

        public struct Point
        {
            public double X;
            public double Y;

            public Point(double x, double y)
            {
                this.X = x;
                this.Y = y;
            }
        }
    }
}
