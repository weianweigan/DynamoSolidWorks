using Dynamo.Applications;
using Dynamo.Controls;
using Dynamo.Models;
using Dynamo.ViewModels;
using Dynamo.Wpf.ViewModels.Watch3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;

namespace DynamoSldWorks.View
{
    public class DynamoSetup
    {
        private static string _commandFilePath;
        private static string ASMPath;
        //private SettingsMigrationWindow migrationWindow;

        [DllImport("msvcrt.dll")]
        public static extern int _putenv(string env);

        public DynamoViewModel ViewModel { get; private set; }

        public static DynamoSetup Create(string[] args = null)
        {
            if (args == null)
            {
                args = new string[] { "" };
            }
            var cmdLineArgs = StartupUtils.CommandLineArguments.Parse(args);
            var locale = StartupUtils.SetLocale(cmdLineArgs);
            _putenv(locale);
            _commandFilePath = cmdLineArgs.CommandFilePath;
            ASMPath = cmdLineArgs.ASMPath;
            var setup = new DynamoSetup();
            return setup;
        }

        public void RunApp(IntPtr windowHandle)
        {
            try
            {
                
                DynamoModel model;
                StartupUtils.ASMPreloadFailure += ASMPreloadFailureHandler;

                if (!String.IsNullOrEmpty(ASMPath))
                {
                    model = StartupUtils.MakeModel(false, ASMPath);
                }
                else
                {
                    model = StartupUtils.MakeModel(false);
                }

                ViewModel = DynamoViewModel.Start(
                    new DynamoViewModel.StartConfiguration()
                    {
                        DynamoModel = model,
                        Watch3DViewModel = HelixWatch3DViewModel.TryCreateHelixWatch3DViewModel
                        (
                            null,
                            new Watch3DViewModelStartupParams(model),
                            model.Logger
                        ),
                        ShowLogin = true
                    });

                var view = new DynamoView(ViewModel);
                view.Loaded += OnDynamoViewLoaded;

                var windowHelper = new WindowInteropHelper(view);
                windowHelper.Owner = windowHandle;

                var app = Application.Current;
                if (app != null)
                {
                    app.Run(view);
                }
                else
                {
                    //view.Owner
                    view.Show();
                }

                StartupUtils.ASMPreloadFailure -= ASMPreloadFailureHandler;

            }
            catch (Exception ex)
            {
                
                //throw;
            }   
        }

        private void ASMPreloadFailureHandler(string failureMessage)
        {
            MessageBox.Show(failureMessage, "DynamoSandbox", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void OnDynamoViewLoaded(object sender, System.Windows.RoutedEventArgs e)
        {
            CloseMigrationWindow();
        }

        private void CloseMigrationWindow()
        {
            //if (migrationWindow == null)
            //    return;

            //migrationWindow.Close();
            //migrationWindow = null;
        }
    }
}
