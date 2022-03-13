using System;
using CoreNodeModels;
using Newtonsoft.Json;
using Dynamo.Graph.Nodes;
using System.Collections.Generic;
using SolidWorks.Interop.sldworks;
using Dynamo.Wpf;
using Dynamo.Controls;

namespace SldWorksNodesUI.Selection
{
    /// <summary>
    /// Select a Body in current doc in solidworks
    /// </summary>
    [NodeName(message)]
    [NodeCategory("SolidWorks.Selection")]
    [NodeDescription("Select Bodies in doc")]
    [IsDesignScriptCompatible]
    public class SelectBodies : SwObjectSelction<IBody2, SldWorksNodes.Geometry.Body>
    {
        #region Fields
        private const string message = "Select Bodies";
        private const string prefix = "Bodies";
        #endregion

        #region Ctor
        public SelectBodies() :
            base(SelectionType.Many,
                SelectionObjectType.None,
                message,
                prefix)
        {
        }

        #endregion

        #region Methods
        protected override IEnumerable<SldWorksNodes.Geometry.Body> ExtractSelectionResults(IBody2 selections)
        {
            if (selections == null)
                yield break;

            yield return new SldWorksNodes.Geometry.Body(selections);
        }

        protected override Func<string, SldWorksNodes.Geometry.Body> GetBuildFuncation() => 
            new Func<string, SldWorksNodes.Geometry.Body>(SldWorksNodes.Geometry.Body.ByPID);

        protected override string GetOutputPortName() => prefix;
        #endregion
    }

    public class SelectBodiesNodeModelView : INodeViewCustomization<SelectBodies>
    {
        public void CustomizeView(SelectBodies model, NodeView nodeView)
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
