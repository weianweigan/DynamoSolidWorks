using Dynamo.Applications;
using Dynamo.Controls;
using Dynamo.Models;
using Dynamo.ViewModels;
using Dynamo.Wpf.ViewModels.Watch3D;
using DynamoSldWorks.Model;
using System;
using System.Runtime.InteropServices;
using System.Windows;
using Xarial.XCad.SolidWorks;

namespace DynamoSldWorks.View
{
    public class DynamoSetup
    {
        #region Field
        private readonly ISwApplication _swApplication;
        private SettingMigrationWindow _migrationWindow = new SettingMigrationWindow();
        private string _commandFilePath;
        #endregion

        #region Ctor
        public DynamoSetup(ISwApplication swApplication,string[] args)
        {
            this._swApplication = swApplication;

            var cmdLineArgs = StartupUtils.CommandLineArguments.Parse(args);
            var locale = StartupUtils.SetLocale(cmdLineArgs);
            _putenv(locale);
            _commandFilePath = cmdLineArgs.CommandFilePath;
            ASMPath = cmdLineArgs.ASMPath;
        }
        #endregion

        #region Properties
        public string ASMPath { get; }

        public DynamoViewModel ViewModel { get; private set; }
        #endregion

        #region Public Methods
        [DllImport("msvcrt.dll")]
        public static extern int _putenv(string env);

        public static DynamoSetup Create(ISwApplication application,string[] args = null)
        {
            var setup = new DynamoSetup(application,new string[] { });
            return setup;
        }

        public void RunApp(IntPtr windowHandle)
        {
            try
            {
                _migrationWindow.Show();
                SldDynamoModel model;
                StartupUtils.ASMPreloadFailure += ASMPreloadFailureHandler;

                model = SldDynamoModel.Start();

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

                //var windowHelper = new WindowInteropHelper(view);
                //windowHelper.Owner = windowHandle;

                var app = Application.Current ?? new Application();
                if (app != null)
                {
                    app.DispatcherUnhandledException += App_DispatcherUnhandledException;
                    app.Run(view);
                }
                else
                {
                    _migrationWindow.Close();
                    view.Show();
                }

                StartupUtils.ASMPreloadFailure -= ASMPreloadFailureHandler;

            }
            catch (Exception ex)
            {
                _swApplication.ShowMessageBox(ex.Message, Xarial.XCad.Base.Enums.MessageBoxIcon_e.Error);
            }   
        }
        #endregion

        #region Private Methods
        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
        }

        private void ASMPreloadFailureHandler(string failureMessage)
        {
            MessageBox.Show(failureMessage, "DynamoSldWorks", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void OnDynamoViewLoaded(object sender, System.Windows.RoutedEventArgs e)
        {
            CloseMigrationWindow();
        }

        private void CloseMigrationWindow()
        {
            _migrationWindow?.Close();
            _migrationWindow = null;
        }
        #endregion
    }
}
