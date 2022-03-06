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
using System.Windows.Interop;
using System.Windows.Markup;
using Xarial.XCad.SolidWorks;

namespace DynamoSldWorks.View
{
    public class DynamoSetup
    {
        #region Field
        private readonly ISwApplication _swApplication;
        private string _commandFilePath;
        SldDynamoModel _model;
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
        public DynamoView View { get; private set; }
        #endregion

        #region Public Methods
        [DllImport("msvcrt.dll")]
        public static extern int _putenv(string env);

        public static DynamoSetup Create(ISwApplication application,string[] args = null)
        {
            var setup = new DynamoSetup(application,new string[] { });
            return setup;
        }

        public void Start(IntPtr windowHandle)
        {
            try
            {
                if (View != null)
                {
                    View.Activate();
                    return;
                }

                StartupUtils.ASMPreloadFailure += ASMPreloadFailureHandler;

                _model = SldDynamoModel.Start(_swApplication);

                var watch3DModel = HelixWatch3DViewModel.TryCreateHelixWatch3DViewModel
                        (
                            null,
                            new Watch3DViewModelStartupParams(_model),
                            _model.Logger
                        );
                watch3DModel.Active = false;

                ViewModel = DynamoViewModel.Start(
                    new DynamoViewModel.StartConfiguration()
                    {
                        DynamoModel = _model,
                        Watch3DViewModel = watch3DModel,
                        ShowLogin = true
                    });

                ViewModel.BackgroundPreviewViewModel.IsGridVisible = false;

                View = new DynamoView(ViewModel);
                View.Loaded += OnDynamoViewLoaded;
                View.Closed += View_Closed;

                if (windowHandle != IntPtr.Zero)
                {
                    var windowHelper = new WindowInteropHelper(View);
                    windowHelper.Owner = windowHandle;
                }

                View.Show();

                StartupUtils.ASMPreloadFailure -= ASMPreloadFailureHandler;
            }
            catch (Exception ex)
            {
                _swApplication.ShowMessageBox(ex.Message, Xarial.XCad.Base.Enums.MessageBoxIcon_e.Error);
            }   
        }

        public void OpenDoc(string pathName,IntPtr parent)
        {
            if (View == null)
                Start(parent);

            if (!File.Exists(pathName))
                throw new FileNotFoundException(pathName);

            ViewModel.OpenCommand.Execute(pathName);
            //_model.OpenFileFromPath(pathName);
        }
        #endregion

        #region Private Methods
        private void View_Closed(object sender, EventArgs e)
        {
            View.Closed -= View_Closed;

            _model=null;
            View = null;
            ViewModel = null;
        }

        private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
        }

        private void ASMPreloadFailureHandler(string failureMessage)
        {
            MessageBox.Show(failureMessage, "DynamoSldWorks", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void OnDynamoViewLoaded(object sender, System.Windows.RoutedEventArgs e)
        {
            UpdateLibraryLayoutSpec();
            View.Loaded -= OnDynamoViewLoaded;
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
