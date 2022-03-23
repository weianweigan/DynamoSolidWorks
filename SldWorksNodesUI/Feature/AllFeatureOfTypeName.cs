using Autodesk.DesignScript.Runtime;
using Dynamo.Graph.Nodes;
using Dynamo.Utilities;
using ProtoCore.AST.AssociativeAST;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SldWorksNodesUI.Feature
{
    [NodeName("All Feat Of TypeName")]
    [NodeDescription("Lists all features in active doc to select one")]
    [NodeCategory(SwNodesCategory.SelectionCategory)]
    [InPortNames("FeatureTypeName")]
    [InPortTypes("string")]
    [InPortDescriptions("Get features by FeatureTypeName")]
    //[OutPortNames(Features.outputName)]
    //[OutPortTypes("SldWorksNodes.SldWorksNodes.Feature.Feature")]
    //[OutPortDescriptions("Feature")]
    [IsDesignScriptCompatible]
    [IsVisibleInDynamoLibrary(false)]
    [Obsolete]
    public class AllFeatureOfTypeName : SwDropDownBase
    {
        public const string outputName = "Feature";

        public AllFeatureOfTypeName():base(outputName)
        {

        }

        protected override SelectionState PopulateItemsCore(string currentSelection)
        {
            Items.Clear();

            if (InputNodes.Count > 0)
            {
                var featTypeName = InputNodes.First().Value.Item2?.CachedValue?.StringData ?? "";
                var items = SwFeatureDropDown.GetNeededFeats(featTypeName);

                Items.AddRange(items);
            }

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
