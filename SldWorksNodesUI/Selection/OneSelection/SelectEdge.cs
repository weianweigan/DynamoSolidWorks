using System.Text;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System.Threading.Tasks;
using CoreNodeModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using Dynamo.Graph.Nodes;
using System;
using Dynamo.Wpf;
using Dynamo.Controls;

namespace SldWorksNodesUI.Selection
{
    /// <summary>
    /// Select a edge from current doc in solidworks
    /// </summary>
    [NodeName(message)]
    [NodeCategory(SwNodesCategory.SelectionCategory)]
    [NodeDescription("Select a edge in doc")]
    [IsDesignScriptCompatible]
    public class SelectEdge:SwObjectSelction<IEdge,SldWorksNodes.Brep.Edge>
    {
        #region Fields
        private const string message = "Select Edge";
        private const string prefix = "Edge";
        #endregion

        #region Ctor
        public SelectEdge() :
            base(SelectionType.One,
                SelectionObjectType.Edge,
                message,
                prefix)
        {
        }
      
        #endregion

        #region Methods    
        protected override IEnumerable<SldWorksNodes.Brep.Edge> ExtractSelectionResults(IEdge selections)
        {
            if (selections == null)
                yield break;

            yield return new SldWorksNodes.Brep.Edge(selections);
        }

        protected override Func<string, SldWorksNodes.Brep.Edge> GetBuildFuncation() => 
            new Func<string, SldWorksNodes.Brep.Edge>(SldWorksNodes.Brep.Edge.ByPID);
        #endregion
    }

    public class SelectEdgeNodeModelView : INodeViewCustomization<SelectEdge>
    {
        public void CustomizeView(SelectEdge model, NodeView nodeView)
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
