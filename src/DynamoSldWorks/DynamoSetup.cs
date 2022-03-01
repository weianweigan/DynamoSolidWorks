using Dynamo.Applications;
using Dynamo.Controls;
using Dynamo.Models;
using Dynamo.ViewModels;
using Dynamo.Wpf.Interfaces;
using Dynamo.Wpf.ViewModels.Watch3D;
using DynamoSldWorks.Model;
using DynamoSldWorks.Util;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Markup;
using Xarial.XCad.SolidWorks;

namespace DynamoSldWorks.View
{
    public class DynamoSetup
    {
        #region Field
        private readonly ISwApplication _swApplication;
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

        SldDynamoModel _model;
        public void RunApp(IntPtr windowHandle)
        {
            try
            {
                //var migrationWindow = new SettingMigrationWindow();
                StartupUtils.ASMPreloadFailure += ASMPreloadFailureHandler;

                _model = SldDynamoModel.Start(_swApplication);

                ViewModel = DynamoViewModel.Start(
                    new DynamoViewModel.StartConfiguration()
                    {
                        DynamoModel = _model,
                        Watch3DViewModel = HelixWatch3DViewModel.TryCreateHelixWatch3DViewModel
                        (
                            null,
                            new Watch3DViewModelStartupParams(_model),
                            _model.Logger
                        ),
                        ShowLogin = true
                    });

                var view = new DynamoView(ViewModel);
                view.Loaded += OnDynamoViewLoaded;

                //var windowHelper = new WindowInteropHelper(view);
                //windowHelper.Owner = windowHandle;

                var app = Application.Current ?? ApplicationUtil.Create();
                if (app != null)
                {
                    app.DispatcherUnhandledException += App_DispatcherUnhandledException;
                    app.Run(view);
                }
                else
                {
                    //migrationWindow.Close();
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
            UpdateLibraryLayoutSpec();
        }

        private void CloseMigrationWindow()
        {
            //_migrationWindow?.Close();
            //_migrationWindow = null;
        }

        private  void UpdateLibraryLayoutSpec()
        {
             var customization = _model.ExtensionManager.Service<ILibraryViewCustomization>();
            if (customization == null) return;

            LayoutSpecification sldworksSpecs;
            var str = File.ReadAllText(SwAddin.DynamoCorePath + @"\Resources\LayoutSpecs.json");
            sldworksSpecs = LayoutSpecification.FromJSONString(str);

            //The steelSpec should have only one section, add all its child elements to the customization
            var elements = sldworksSpecs.sections.First().childElements;
            customization.AddElements(elements); //add all the elements to default section
            
        }
        #endregion
    }
}
