using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Magic_8_Ball
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        [STAThread]
        static void Main()
        {
            App app = new App();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Title = "Magic Ball";
            
            IModel model = new Ball();
            Presenter presenter = new Presenter(model, mainWindow);

            app.Run(mainWindow);
        }
    }
}
