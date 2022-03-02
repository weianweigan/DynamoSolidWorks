using SolidWorks.Interop.sldworks;
using CoreNodeModelsWpf.Nodes;
using Dynamo.Wpf;
using Dynamo.Controls;

namespace SldWorksNodes.Selection
{
    /// <summary>
    /// Select feature node
    /// </summary>
    public class SelectFeatureNodeViewCustomization : SelectionBaseNodeViewCustomization<IFeature, Feature.Feature>, INodeViewCustomization<SelectFeature>
    {
        public void CustomizeView(SelectFeature model, NodeView nodeView)
        {
            base.CustomizeView(model, nodeView);
        }
    }
}
