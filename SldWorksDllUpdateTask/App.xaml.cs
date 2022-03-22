using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SldWorksDllUpdateTask
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static string OldInteractivity;
        public static string NewInteractivity;


        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var args = e.Args;
            if (args.Length == 2)
            {
                OldInteractivity = args[0];
                NewInteractivity = args[1];
            }
        }
    }
}
