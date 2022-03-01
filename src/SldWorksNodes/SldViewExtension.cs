using Dynamo.ViewModels;
using Dynamo.Wpf.Extensions;
using SldWorksNodes.Util;
using SldWorksService;
using System.Windows.Controls;

namespace SldWorksNodes
{
    public class SldViewExtension : IViewExtension
    {
        private MenuItem _sampleMenuItem;

        public string UniqueId => "";

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
            
            _sampleMenuItem = new MenuItem { Header = "SolidWorks Info" };

            _sampleMenuItem.Click += (sender, args) =>
            {
                
            };

            viewLoadedParams.AddMenuItem(MenuBarType.View, _sampleMenuItem);
        }

        public void Shutdown()
        {
        }

        public void Startup(ViewStartupParams viewStartupParams)
        {
        }
    }
}