using Autodesk.DesignScript.Runtime;
using Dynamo.Graph.Nodes;
using Dynamo.Graph.Workspaces;
using Dynamo.Models;
using Dynamo.ViewModels;
using Dynamo.Wpf.Extensions;
using SldWorksNodes.Util;
using SldWorksService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace SldWorksNodes
{
    [IsVisibleInDynamoLibrary(false)]
    public class SldViewExtension : IViewExtension
    {
        private MenuItem _sampleMenuItem;
        private ViewLoadedParams _loadedParams;

        public string UniqueId => "C840CEE2-4506-4601-8D12-581C79740AEE";

        public string Name => "SldWorks";

        public void Dispose()
        {

        }

        public void Loaded(ViewLoadedParams viewLoadedParams)
        {
            _loadedParams= viewLoadedParams;

            //Init Context
            var vm = viewLoadedParams.DynamoWindow.DataContext as DynamoViewModel;
            var sldContext = vm.Model as ISldWorksContext;
            SldContextManager.Init(sldContext);
            SwContext.Init(sldContext);

            _sampleMenuItem = new MenuItem { Header = "SolidWorks Info" };

            _sampleMenuItem.Click += (sender, args) =>
            {
                var window = new View.SolidWorksInfoWindow();
                window.Topmost = true;
                window.Show();
            };

            viewLoadedParams.AddMenuItem(MenuBarType.View, _sampleMenuItem);
        }

        public void Shutdown()
        {}

        public void Startup(ViewStartupParams viewStartupParams)
        {}
    }

}