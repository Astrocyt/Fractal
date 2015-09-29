
using System.Drawing;
using System.Drawing.Imaging;
namespace Fractal.Presenter.Interface
{
    public interface IPropertiesViewPresenter
    {
        void RenderFractal();
        void SaveFractalImage(ImageFormat imageFormat,string name);
    }
}
