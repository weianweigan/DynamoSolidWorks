using CoreNodeModels;
using Dynamo.Graph.Nodes;
using Dynamo.Utilities;
using ProtoCore.AST.AssociativeAST;
using SldWorksNodes.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodesUI.CustomProperty
{
    [NodeName("CustomProperties")]
    [NodeDescription("Lists all properties in active doc to select one")]
    [NodeCategory("SolidWorks.Selection")]
    //[OutPortNames("CustomProperty")]
    //[OutPortTypes("SldWorksNodes.SldWorksNodes.CustomProperty.CustomProperty")]
    //[OutPortDescriptions("CustomProperty")]
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

            var config = InputNodes[0]?.Item2?.CachedValue?.StringData ?? "";
            Items.AddRange(GetProperties(config));

            return SelectionState.Restore;
        }

        protected IEnumerable<DynamoDropDownItem> GetProperties(string config = "")
        {
            var propeties = SldWorksNodes.CustomProperty.CustomPropertyManager.GetAll(config);

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
