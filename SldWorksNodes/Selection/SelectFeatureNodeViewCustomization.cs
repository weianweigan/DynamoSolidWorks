using SolidWorks.Interop.sldworks;
using CoreNodeModelsWpf.Nodes;
using Dynamo.Wpf;
using Dynamo.Controls;
using System.Windows.Controls;
using Autodesk.DesignScript.Runtime;

namespace SldWorksNodes.Selection
{
    /// <summary>
    /// Select feature node
    /// </summary>
    [IsVisibleInDynamoLibrary(false)]
    public class SelectFeatureNodeViewCustomization : SelectionBaseNodeViewCustomization<IFeature, Feature.Feature>, INodeViewCustomization<SelectFeature>
    {
        public void CustomizeView(SelectFeature model, NodeView nodeView)
        {
            var btn = new Button() { Content = "Select" };
            btn.DataContext = model;
            nodeView.inputGrid.Children.Add(btn);
        }
    }
}
