using Fractal.Model.Class;
using Fractal.Presenter.Interface;
using Fractal.View.Class;
using Fractal.View.Interface;
using System;
using System.Drawing.Imaging;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal.Presenter.Class
{
    public class PropertiesViewPresenter : IPropertiesViewPresenter
    {
        private IPropertiesView _view;
        private IRenderViewPresenter _renderViewPresenter;

        public PropertiesViewPresenter(IPropertiesView view)
        {
            this._view = view;
            this._renderViewPresenter = new RenderViewPresenter();
            this._renderViewPresenter.RenderProgressCall += RenderProgress;
            this._renderViewPresenter.RenderCompleteCall += _view.SetRenderTime;
            this._renderViewPresenter.PropertiesUpdateCall += UpdateViewProperties;
        }

        private void UpdateViewProperties(RenderProperties newProperties)
        {
            _view.UpdateProperties(newProperties);
        }

        public void RenderFractal()
        {
            var prop = _view.GetRenderProperties();
            var col = _view.GetRenderColors();
           Task.Factory.StartNew(()=>
            _renderViewPresenter.ShowFractal(
               prop,
               col));
        }

        public void SaveFractalImage(ImageFormat format,string name)
        {
            if(_renderViewPresenter.ActualFractalImage != null)
            {
                FolderBrowserDialog d = new FolderBrowserDialog();
                if (d.ShowDialog() == DialogResult.OK)
                {
                    string savePath = string.Format("{0}\\{1}.{2}",
                        d.SelectedPath,
                        name,
                        format.ToString());
                    
                    _renderViewPresenter.ActualFractalImage.Save(savePath);
                }
            }
        }

        private void RenderProgress(int iteration, int accuracy)
        {
            this._view.ChangeProgressBarValue(
                (int)(100*iteration/accuracy));
        }

       
    }
}
