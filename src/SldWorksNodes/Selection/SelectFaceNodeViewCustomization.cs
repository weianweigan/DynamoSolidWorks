using SolidWorks.Interop.sldworks;
using CoreNodeModelsWpf.Nodes;
using Dynamo.Wpf;
using Dynamo.Controls;
using System.Windows.Controls;
using Autodesk.DesignScript.Runtime;

namespace SldWorksNodes.Selection
{
    [IsVisibleInDynamoLibrary(false)]
    public class SelectFaceNodeViewCustomization : INodeViewCustomization<SelectFace>
    {
        public void CustomizeView(SelectFace model, NodeView nodeView)
        {
            var btn = new Button() { Content = "Select"};
            btn.DataContext = model;
            nodeView.inputGrid.Children.Add(btn);
        }

        public void Dispose()
        {
        }
    }
}
