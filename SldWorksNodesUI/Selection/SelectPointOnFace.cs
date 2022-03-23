using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SolidWorks.Interop.sldworks;
using System.Threading.Tasks;
using CoreNodeModels;
using SldWorksNodes.Geometry;
using Dynamo.Graph.Nodes;
using Dynamo.Wpf;
using Dynamo.Controls;

namespace SldWorksNodesUI.Selection
{
    [NodeName(message)]
    [NodeCategory(SwNodesCategory.SelectionCategory)]
    [NodeDescription("Select Point On Face")]
    [IsDesignScriptCompatible]
    public class SelectPointOnFace : SwObjectSelction<Point3D,Point3D>
    {
        #region Fields
        private const string message = "Select Point On Face";
        private const string prefix = "Point3D";
        #endregion

        #region Ctor
        public SelectPointOnFace() :
            base(SelectionType.One,
                SelectionObjectType.Face,
                message,
                prefix)
        {
        }
        #endregion

        #region Methods
        protected override string GetIdentifierFromModelObject(Point3D modelObject)
        {
            return modelObject.ToString();
        }

        protected override Point3D GetModelObjectFromIdentifer(string id)
        {
           return Point3D.Prase(id);
        }

        protected override IEnumerable<Point3D> ExtractSelectionResults(Point3D selections)
        {
            yield return selections;
        }

        protected override Func<string, Point3D> GetBuildFuncation() =>
            new Func<string, Point3D>(Point3D.Prase);

        protected override string GetOutputPortName() => "Point3D";
        #endregion
    }

    public class SelectPointOnFaceNodeModelView : INodeViewCustomization<SelectPointOnFace>
    {
        public void CustomizeView(SelectPointOnFace model, NodeView nodeView)
        {
            var control = new Control.SelectionBox();
            nodeView.inputGrid.Children.Add(control);
            control.DataContext = model;
        }

        public void Dispose()
        {
        }
    }
}
