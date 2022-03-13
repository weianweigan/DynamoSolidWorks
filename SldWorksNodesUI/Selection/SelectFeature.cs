using CoreNodeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using SolidWorks.Interop.sldworks;
using Dynamo.Graph.Nodes;
using Newtonsoft.Json;
using ProtoCore.AST.AssociativeAST;
using SldWorksNodes.Util;
using SldWorksNodesUI.Selection;
using Autodesk.DesignScript.Runtime;
using Dynamo.Wpf;
using Dynamo.Controls;

namespace SldWorksNodesUI.Selection
{
    [NodeName("Select Feature")]
    [NodeCategory("SolidWorks.Selection")]
    [NodeDescription("Select a feature in doc")]
    [IsDesignScriptCompatible]
    public class SelectFeature : SwObjectSelction<IFeature, SldWorksNodes.Feature.Feature>
    {
        private const string message = "Select Feature";
        private const string prefix = "Feature";

        public SelectFeature() : 
            base(SelectionType.One,
                SelectionObjectType.None, 
                message, 
                prefix)
        {
        }

        [JsonConstructor]
        public SelectFeature(
            SelectionType selectionType,
            SelectionObjectType selectionObjectType, 
            string message, 
            string prefix,
            IEnumerable<string> selectionIdentifier, 
            IEnumerable<PortModel> inPorts, 
            IEnumerable<PortModel> outPorts)
    :       base(
                selectionType, 
                selectionObjectType, 
                message, 
                prefix, 
                selectionIdentifier, 
                inPorts, 
                outPorts) { }

        protected override IEnumerable<SldWorksNodes.Feature.Feature> ExtractSelectionResults(IFeature selections)
        {
            if (selections == null)
                return new SldWorksNodes.Feature.Feature[] { };

            return new SldWorksNodes.Feature.Feature[] { new SldWorksNodes.Feature.Feature(selections) };
        }

        protected override SldWorksNodes.Feature.Feature BuildFunction(string id, bool flag)
        {

            if (flag)
            {
                return SldWorksNodes.Feature.Feature.ByPID(id);
            }
            else
            {
                return null;
            }
        }

        protected override string GetOutputPortName() => "Feature";
    }

    public class SelectFeatureNodeModelView : INodeViewCustomization<SelectFeature>
    {
        public void CustomizeView(SelectFeature model, NodeView nodeView)
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
