using Fractal.Presenter.Class;
using Fractal.View.Class;
using FractalCreator.Data;
using FractalCreator.Data.Interface;
using FractalCreator.FractalClass;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal
{
    static class Start
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var view = new PropertiesWindow();
            var presenter = new PropertiesViewPresenter(view);
            view.AttachPresenter(presenter);

            Application.Run(view); 
        }
       
    }
}
