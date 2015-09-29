using Fractal.Presenter.Interface;
using System.Drawing;

namespace Fractal.View.Interface
{
    public interface IRenderPreviewView
    {
        bool Exist {get;}
        void ShowImage(Image image);
        void AttachPresenter(IRenderViewPresenter presenter);
    }
}
