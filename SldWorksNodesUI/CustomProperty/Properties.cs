using CoreNodeModels;
using Dynamo.Graph.Nodes;
using Dynamo.Utilities;
using ProtoCore.AST.AssociativeAST;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SldWorksNodesUI.SwItems
{
    [NodeName("CustomProperties")]
    [NodeDescription("Lists all properties in active doc to select one")]
    [NodeCategory(SwNodesCategory.SelectionCategory)]
    [InPortNames("Configuation")]
    [InPortTypes("string")]
    [InPortDescriptions("Name of Configuation")]
    [IsDesignScriptCompatible]
    public class Properties : SwDropDownBase
    {
        public const string outputName = "CustomProperty";

        public Properties():base(outputName)
        {

        }

        protected override SelectionState PopulateItemsCore(string currentSelection)
        {
            Items.Clear();

            string config = "";
            if (InputNodes.Count > 0)
            {
                config = InputNodes.First().Value.Item2?.CachedValue?.StringData ?? "";
            }
            Items.AddRange(GetProperties(config));

            return SelectionState.Restore;
        }

        protected IEnumerable<DynamoDropDownItem> GetProperties(string config = "")
        {
            var propeties = SldWorksNodes.CustomProperty.CustomProperty.All(config);

            return propeties.Select(p => new DynamoDropDownItem(p.Name, p.Value()));
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
                new Func<string,string, SldWorksNodes.CustomProperty.CustomProperty>(SldWorksNodes.CustomProperty.CustomPropertyManager.Get),
                new List<AssociativeNode>() { name , inputAstNodes[0]}
                );
            var assign = AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), itemNode);

            return new List<AssociativeNode> { assign };
        }
    }
}
