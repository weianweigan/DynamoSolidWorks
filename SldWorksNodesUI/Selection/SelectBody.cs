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
    [NodeDescription("Select a Body in doc")]
    [IsDesignScriptCompatible]
    public class SelectBody : SwObjectSelction<IBody2, SldWorksNodes.Geometry.Body>
    {
        #region Fields
        private const string message = "Select Body";
        private const string prefix = "Body";
        #endregion

        #region Ctor
        public SelectBody() :
            base(SelectionType.One,
                SelectionObjectType.None,
                message,
                prefix)
        {
        }

        [JsonConstructor]
        public SelectBody(
            SelectionType selectionType,
            SelectionObjectType selectionObjectType,
            string message,
            string prefix,
            IEnumerable<string> selectionIdentifier,
            IEnumerable<PortModel> inPorts,
            IEnumerable<PortModel> outPorts)
            : base(
                selectionType,
                selectionObjectType,
                message,
                prefix,
                selectionIdentifier,
                inPorts,
                outPorts)
        { }
        #endregion

        #region Methods
        protected override IEnumerable<SldWorksNodes.Geometry.Body> ExtractSelectionResults(IBody2 selections)
        {
            if (selections == null)
                return new SldWorksNodes.Geometry.Body[] { };

            return new SldWorksNodes.Geometry.Body[] { new SldWorksNodes.Geometry.Body(selections) };
        }

        protected override Func<string, SldWorksNodes.Geometry.Body> GetBuildFuncation()
        {
            return new Func<string, SldWorksNodes.Geometry.Body>(SldWorksNodes.Geometry.Body.ByPID);
        }

        protected override string GetOutputPortName() => prefix;
        #endregion
    }

    public class SelectBodyNodeModelView : INodeViewCustomization<SelectBody>
    {
        public void CustomizeView(SelectBody model, NodeView nodeView)
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
