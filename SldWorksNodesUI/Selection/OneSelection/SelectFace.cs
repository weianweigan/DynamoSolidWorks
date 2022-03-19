using System;
using Dynamo.Wpf;
using CoreNodeModels;
using Dynamo.Controls;
using Newtonsoft.Json;
using Dynamo.Graph.Nodes;
using System.Collections.Generic;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodesUI.Selection
{
    /// <summary>
    /// Select a face in current doc in solidworks
    /// </summary>
    [NodeName(message)]
    [NodeCategory(SwNodesCategory.SelectionCategory)]
    [NodeDescription("Select a face in doc")]
    [IsDesignScriptCompatible]
    public class SelectFace : SwObjectSelction<IFace2, SldWorksNodes.Brep.Face>
    {
        #region Fields
        private const string message = "Select Face";
        private const string prefix = "Face";
        #endregion

        #region Ctor
        public SelectFace() :
            base(SelectionType.One,
                SelectionObjectType.Face,
                message,
                prefix)
        {
        }
        #endregion

        #region Methods
        protected override IEnumerable<SldWorksNodes.Brep.Face> ExtractSelectionResults(IFace2 selections)
        {
            if (selections == null)
                yield break;

            yield return new SldWorksNodes.Brep.Face(selections);
        }

        protected override Func<string, SldWorksNodes.Brep.Face> GetBuildFuncation() => 
            new Func<string, SldWorksNodes.Brep.Face>(SldWorksNodes.Brep.Face.ByPID);

        #endregion
    }

    public class SelectFaceNodeModelView : INodeViewCustomization<SelectFace>
    {
        public void CustomizeView(SelectFace model, NodeView nodeView)
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
