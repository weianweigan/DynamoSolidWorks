﻿using Dynamo.Applications;
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
using Xarial.XCad.Base.Enums;
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

            //var cmdLineArgs = StartupUtils.CommandLineArguments.Parse(args);
            //var locale = StartupUtils.SetLocale(cmdLineArgs);
            //_putenv(locale);
            //_commandFilePath = cmdLineArgs.CommandFilePath;
            //ASMPath = Path.Combine(SwAddin.DynamoCorePath, "libg_227_0_0");
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
                if (!CheckInteractivity())
                {
                    return;
                }

                if (View != null)
                {
                    View.Activate();
                    return;
                }

                //StartupUtils.ASMPreloadFailure += ASMPreloadFailureHandler;

                _model = SldDynamoModel.Make(_swApplication);
                _model.UpdateManager.UpdateInfo = null;//Close Update
                _model.UpdateManager.ForceUpdate = false;

                var watch3DModel = HelixWatch3DViewModel.TryCreateHelixWatch3DViewModel
                        (
#if V1_2_0
#else
                            null,
#endif
                            new Watch3DViewModelStartupParams(_model),
                            _model.Logger
                        );
                watch3DModel.Active = false;

                ViewModel = DynamoViewModel.Start(
                    new DynamoViewModel.StartConfiguration()
                    {
                        DynamoModel = _model,
                        Watch3DViewModel = watch3DModel,
                        ShowLogin = true,
                    });

                //ViewModel.BackgroundPreviewViewModel.IsGridVisible = false;

                View = new DynamoView(ViewModel);
                View.Loaded += OnDynamoViewLoaded;
                View.Closed += View_Closed;

                if (windowHandle != IntPtr.Zero)
                {
                    var windowHelper = new WindowInteropHelper(View);
                    windowHelper.Owner = windowHandle;
                }

                //var app = Application.Current ?? new Application();

                if (Application.Current == null)
                    View.Show();
                else
                    Application.Current.Run(View);

                //StartupUtils.ASMPreloadFailure -= ASMPreloadFailureHandler;
            }
            catch (Exception ex)
            {
                _swApplication.ShowMessageBox(ex.Message, Xarial.XCad.Base.Enums.MessageBoxIcon_e.Error);
            }   
        }

        private const string _interactivityName = "System.Windows.Interactivity.dll";
        private bool CheckInteractivity()
        {
            var swLocation = AppDomain.CurrentDomain.BaseDirectory;
            var olderFile = Path.Combine(swLocation, _interactivityName);

            var fileInfo = new FileInfo(olderFile);

            if (!fileInfo.Exists)
            {
                throw new FileNotFoundException(olderFile);
            }

            FileVersionInfo version = FileVersionInfo.GetVersionInfo(olderFile);
            if(version.FileMajorPart < 3)
            {
                //提醒用户更新版本
                //replace older version dll in solidworks
                //find solidworks install dir
                var newFile = Path.Combine(SwAddin.DynamoCorePath, _interactivityName);

                var tools = Path.Combine(SwAddin.DynamoCorePath, $"{nameof(SldWorksDllUpdateTask)}.exe");

                var res = _swApplication.ShowMessageBox(
                     Properties.Resources.StartNewVersionNeedReplaceDll, 
                     MessageBoxIcon_e.Question, 
                     MessageBoxButtons_e.YesNo);

                if (res == Xarial.XCad.Base.Enums.MessageBoxResult_e.Yes)
                {
                    Process.Start(newFile,$"{olderFile} {newFile}");
                    Environment.Exit(0);
                }

                return false;
            }
            else
            {
                return true;
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
#if V1_2_0

#else
            var customization = _model.ExtensionManager.Service<ILibraryViewCustomization>();
            if (customization == null) return;

            //Register the icon resource
            //using (var fs = new FileStream(SwAddin.DynamoCorePath + @"\Resources\Category.SolidWorks.png", FileMode.Open))
            //{
            //    customization.RegisterResourceStream("/icons/Category.SolidWorks.png",fs);
            //}            
            
            LayoutSpecification sldworksSpecs;
            var str = File.ReadAllText(SwAddin.DynamoCorePath + @"\Resources\LayoutSpecs.json");
            sldworksSpecs = LayoutSpecification.FromJSONString(str);

            //The steelSpec should have only one section, add all its child elements to the customization
            var elements = sldworksSpecs.sections.First().childElements;
            customization.AddElements(elements); //add all the elements to default section
#endif
        }
            #endregion
    }
}
