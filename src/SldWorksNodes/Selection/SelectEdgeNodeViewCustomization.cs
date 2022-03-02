using Autodesk.DesignScript.Runtime;
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
    [IsVisibleInDynamoLibrary(false)]
    public class SelectEdgeNodeViewCustomization : INodeViewCustomization<SelectEdge>
    {
        public void CustomizeView(SelectEdge model, NodeView nodeView)
        {
            var btn = new Button() { Content = "Select" };
            btn.DataContext = model;
            nodeView.inputGrid.Children.Add(btn);
        }

        public void Dispose()
        {

        }
    }
}
