using CoreNodeModelsWpf.Nodes;
using Dynamo.Controls;
using Dynamo.Wpf;
using SolidWorks.Interop.sldworks;
using System.Windows.Controls;

namespace SldWorksNodes.Selection
{
    /// <summary>
    /// Select Edge node
    /// </summary>
    public class SelectEdgeNodeViewCustomization : INodeViewCustomization<SelectEdge>
    {
        public void CustomizeView(SelectEdge model, NodeView nodeView)
        {
            var btn = new Button();
            btn.Click += Btn_Click;
            nodeView.inputGrid.Children.Add(btn);
        }

        private void Btn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            
        }

        public void Dispose()
        {

        }
    }
}
