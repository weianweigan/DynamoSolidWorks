using SolidWorks.Interop.sldworks;
using CoreNodeModelsWpf.Nodes;
using Dynamo.Wpf;
using Dynamo.Controls;

namespace SldWorksNodes.Selection
{
    public class SelectFaceNodeViewCustomization : SelectionBaseNodeViewCustomization<IFace2, Brep.Face>, INodeViewCustomization<SelectFace>
    {
        public void CustomizeView(SelectFace model, NodeView nodeView)
        {
            base.CustomizeView(model, nodeView);
        }
    }
}
