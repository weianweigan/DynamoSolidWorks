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
    [NodeCategory("SolidWorks.Selection")]
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
                SelectionObjectType.None,
                message,
                prefix)
        {
        }

        [JsonConstructor]
        public SelectFace(
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
        protected override IEnumerable<SldWorksNodes.Brep.Face> ExtractSelectionResults(IFace2 selections)
        {
            if (selections == null)
                return new SldWorksNodes.Brep.Face[] { };

            return new SldWorksNodes.Brep.Face[] { new SldWorksNodes.Brep.Face(selections) };
        }

        protected override Func<string, SldWorksNodes.Brep.Face> GetBuildFuncation()
        {
            return new Func<string, SldWorksNodes.Brep.Face>(SldWorksNodes.Brep.Face.ByPID);
        }

        protected override string GetOutputPortName() => prefix;
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
