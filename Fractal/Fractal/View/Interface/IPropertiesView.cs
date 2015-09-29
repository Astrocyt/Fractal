using Fractal.Model.Class;
using Fractal.Presenter.Interface;
using System;

namespace Fractal.View.Interface
{
    public interface IPropertiesView
    {
        RenderProperties GetRenderProperties();
        RenderColors GetRenderColors();

        void ChangeProgressBarValue(int value);
        void AttachPresenter(IPropertiesViewPresenter presenter);
        void SetRenderTime(TimeSpan time);
        void UpdateProperties(RenderProperties properties);
    }
}
