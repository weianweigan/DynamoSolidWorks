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

namespace SldWorksNodesUI.Selection
{
    [NodeName("Select Feature")]
    [NodeCategory("SolidWorks.Selection")]
    [NodeDescription("Select a feature in doc")]
    //[OutPortNames("Feature")]
    //[OutPortTypes("SldWorksNodes.SldWorksNodes.Feature.Feature")]
    //[OutPortDescriptions("Feature")]
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

        public override IModelSelectionHelper<IFeature> SelectionHelper => new SwModelSelectionHelper<IFeature>();

        public override IEnumerable<AssociativeNode> BuildOutputAst(
            List<AssociativeNode> inputAstNodes)
        {
            AssociativeNode node;

            var results = SelectionResults.ToList();
            Func<string, bool, SldWorksNodes.Feature.Feature> func = Function;

            if (SelectionResults == null || !results.Any())
            {
                node = AstFactory.BuildNullNode();
            }
            else if (results.Count == 1)
            {
                var el = results.First();

                // If there is only one object in the list,
                // return a single item.
                node = AstFactory.BuildFunctionCall(
                    func,
                    new List<AssociativeNode>
                    {
                        AstFactory.BuildStringNode(el.PID),
                        AstFactory.BuildBooleanNode(true)
                    });
            }
            else
            {
                var newInputs =
                    results.Select(
                        el =>
                            AstFactory.BuildFunctionCall(
                                func,
                                new List<AssociativeNode>
                                {
                                    AstFactory.BuildStringNode(el.PID),
                                    AstFactory.BuildBooleanNode(true)
                                })).ToList();

                node = AstFactory.BuildExprList(newInputs);
            }

            return new[] { AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), node) };
        }

        protected override IEnumerable<SldWorksNodes.Feature.Feature> ExtractSelectionResults(IFeature selections)
        {
            if (selections == null)
                return new SldWorksNodes.Feature.Feature[] {};

            return new SldWorksNodes.Feature.Feature[] { new SldWorksNodes.Feature.Feature(selections) };
        }

        protected override string GetIdentifierFromModelObject(IFeature modelObject)
        {
            return PIDUtil.GetPID(modelObject);
        }

        protected override IFeature GetModelObjectFromIdentifer(string id)
        {
            return PIDUtil.GetObjectFromPID(SwContextUtil.GetActivePartDocContext(),id,out var state) as IFeature;
        }

        private SldWorksNodes.Feature.Feature Function(string id,bool flag)
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

        protected override string GetOutputPortName()
        {
            return "Feature";
        }
    }

    
}
