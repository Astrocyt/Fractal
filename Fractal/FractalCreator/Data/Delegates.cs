using System;
namespace FractalCreator.Data
{
    public delegate void RenderProgress(int iteration, int accuracy);
    public delegate void RenderComplete(TimeSpan renderTime);
}