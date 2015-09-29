using System.Drawing;

namespace FractalCreator.Data.Interface
{
    public interface IFractal
    {
        event RenderComplete RenderComplete;
        event RenderProgress RenderProgress;

        Image GenerateImage(Size size);
        Image GenerateImage(Size size, Area area);
    }
}
