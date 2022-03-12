using Dynamo.Graph.Nodes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using SolidWorks.Interop.sldworks;
using Autodesk.DesignScript.Runtime;
using ProtoCore.AST.AssociativeAST;
using Dynamo.Utilities;

namespace SldWorksNodesUI.Feature
{
    [NodeName(nameof(RefPlanes))]
    [NodeDescription("Lists all refplanes in active doc to select one")]
    [NodeCategory("SolidWorks.Selection")]
    [OutPortNames(Features.outputName)]
    [OutPortTypes("SldWorksNodes.SldWorksNodes.Feature.RefPlane")]
    [OutPortDescriptions("RefPlane")]
    [IsDesignScriptCompatible]
    public class RefPlanes : SwFeatureDropDown
    {
        public const string outputName = "RefPlane";

        public RefPlanes() : base(outputName)
        {

        }

        [JsonConstructor]
        public RefPlanes(IEnumerable<PortModel> inPorts, IEnumerable<PortModel> outPorts) : base(outputName, inPorts, outPorts)
        {

        }

        [IsVisibleInDynamoLibrary(false)]
        public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputAstNodes)
        {
            if (Items.Count == 0 ||
                SelectedIndex < 0)
            {
                return new[] { AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), AstFactory.BuildNullNode()) };
            }

            var name = AstFactory.BuildStringNode(Items[SelectedIndex].Name as string);
            var itemNode = AstFactory.BuildFunctionCall(
                new Func<string, SldWorksNodes.Feature.RefPlane>(SldWorksNodes.Feature.RefPlane.ByName),
                new List<AssociativeNode>() { name }
                );
            var assign = AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), itemNode);

            return new List<AssociativeNode> { assign };
        }

        protected override SelectionState PopulateItemsCore(string currentSelection)
        {
            Items.Clear();

            var items = GetNeededFeats(FeatTypeNameUtil.ProfileFeature);

            Items.AddRange(items);

            //SelectedIndex = 0;
            return SelectionState.Restore;
        }
    }
}
