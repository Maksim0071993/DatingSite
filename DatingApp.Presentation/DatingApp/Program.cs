using DatingApp.Presentation.Services;
using DatingApp.Presentation.WindowsForm;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatingApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var container = DependencyInjectionService.Bootstrap();
            Application.Run(container.GetInstance<RegistrationForm>());
        }
    }
}
