using Fractal.Model.Class;
using FractalCreator.Data;
using System.Drawing;

namespace Fractal.Presenter.Interface
{
    public interface IRenderViewPresenter
    {
        event RenderComplete RenderCompleteCall;
        event RenderProgress RenderProgressCall;
        event PropertiesUpdate PropertiesUpdateCall;

        Image ActualFractalImage {get;}

        void ChangeFractalArea(Point start, Point end);
        void ShowFractal(RenderProperties properties,RenderColors colors);
        void UpdateProperties();
        void ShowPreviewFractal();
    }
}
