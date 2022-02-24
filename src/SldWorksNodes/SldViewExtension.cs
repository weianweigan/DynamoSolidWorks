using Dynamo.Wpf.Extensions;
using DynamoSldWorks;
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
            // Save a reference to your loaded parameters.
            // You'll need these later when you want to use
            // the supplied workspaces
            var sldContext = viewLoadedParams.DynamoWindow.DataContext as ISldWorksContext;
            
            _sampleMenuItem = new MenuItem { Header = "Show View Extension Sample Window" };
            _sampleMenuItem.Click += (sender, args) =>
            {
                //var viewModel = new SampleWindowViewModel(p);
                //var window = new SampleWindow
                //{
                //    // Set the data context for the main grid in the window.
                //    MainGrid = { DataContext = viewModel },

                //    // Set the owner of the window to the Dynamo window.
                //    Owner = p.DynamoWindow
                //};

                //window.Left = window.Owner.Left + 400;
                //window.Top = window.Owner.Top + 200;

                // Show a modeless window.
                //window.Show();
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