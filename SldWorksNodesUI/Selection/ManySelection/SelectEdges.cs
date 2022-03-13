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
    [NodeCategory("SolidWorks.Selection")]
    [NodeDescription("Select edges in doc")]
    [IsDesignScriptCompatible]
    public class SelectEdges:SwObjectSelction<IEdge,SldWorksNodes.Brep.Edge>
    {
        #region Fields
        private const string message = "Select Edges";
        private const string prefix = "Edges";
        #endregion

        #region Ctor
        public SelectEdges() :
            base(SelectionType.Many,
                SelectionObjectType.None,
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

        protected override string GetOutputPortName() => prefix;
        #endregion
    }

    public class SelectEdgesNodeModelView : INodeViewCustomization<SelectEdges>
    {
        public void CustomizeView(SelectEdges model, NodeView nodeView)
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
