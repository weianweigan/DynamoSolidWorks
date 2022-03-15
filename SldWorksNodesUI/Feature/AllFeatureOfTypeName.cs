using Dynamo.Graph.Nodes;
using Dynamo.Utilities;
using ProtoCore.AST.AssociativeAST;
using System;
using System.Collections.Generic;

namespace SldWorksNodesUI.Feature
{
    [NodeName("All Feat Of Typename")]
    [NodeDescription("Lists all features in active doc to select one")]
    [NodeCategory("SolidWorks.Selection")]
    [OutPortNames(Features.outputName)]
    [OutPortTypes("SldWorksNodes.SldWorksNodes.Feature.Feature")]
    [OutPortDescriptions("Feature")]
    [InPortNames("FeatureTypeName")]
    [InPortTypes("string")]
    [InPortDescriptions("Get features by FeatureTypeName")]
    [IsDesignScriptCompatible]
    public class AllFeatureOfTypeName : SwFeatureDropDown
    {
        public const string outputName = "Feature";

        public AllFeatureOfTypeName():base(outputName)
        {

        }

        protected override SelectionState PopulateItemsCore(string currentSelection)
        {
            Items.Clear();

            var featTypeName = InputNodes[0]?.Item2?.CachedValue?.StringData ?? "";
            var items = GetNeededFeats(featTypeName);

            Items.AddRange(items);

            return SelectionState.Restore;
        }

        public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputAstNodes)
        {
            if (Items.Count == 0 ||
    SelectedIndex < 0)
            {
                return new[] { AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), AstFactory.BuildNullNode()) };
            }

            var name = AstFactory.BuildStringNode(Items[SelectedIndex].Name as string);
            var itemNode = AstFactory.BuildFunctionCall(
                new Func<string, SldWorksNodes.Feature.Feature>(SldWorksNodes.Feature.Feature.ByName),
                new List<AssociativeNode>() { name }
                );
            var assign = AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), itemNode);

            return new List<AssociativeNode> { assign };
        }
    }
}
