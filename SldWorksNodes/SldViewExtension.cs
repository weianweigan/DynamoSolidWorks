using Autodesk.DesignScript.Runtime;
using Dynamo.Graph.Workspaces;
using Dynamo.ViewModels;
using Dynamo.Wpf.Extensions;
using SldWorksNodes.Util;
using SldWorksService;
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
            //Init Context
            var vm = viewLoadedParams.DynamoWindow.DataContext as DynamoViewModel;
            var sldContext = vm.Model as ISldWorksContext;
            SldContextManager.Init(sldContext);

            viewLoadedParams.CurrentWorkspaceChanged += ViewLoadedParams_CurrentWorkspaceChanged;

            _sampleMenuItem = new MenuItem { Header = "SolidWorks Info" };

            _sampleMenuItem.Click += (sender, args) =>
            {
                var version = typeof(SldViewExtension).Assembly.GetName().Version;
                var window = new View.SolidWorksInfoWindow();
                window.ShowDialog();
            };

            viewLoadedParams.AddMenuItem(MenuBarType.View, _sampleMenuItem);
        }

        private void ViewLoadedParams_CurrentWorkspaceChanged(IWorkspaceModel obj)
        {
            
        }

        public void Shutdown()
        {
            _loadedParams.CurrentWorkspaceChanged -= ViewLoadedParams_CurrentWorkspaceChanged;
        }

        public void Startup(ViewStartupParams viewStartupParams)
        {
        }
    }
}