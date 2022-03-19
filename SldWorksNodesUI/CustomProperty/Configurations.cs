using CoreNodeModels;
using Dynamo.Graph.Nodes;
using Dynamo.Utilities;
using Newtonsoft.Json;
using ProtoCore.AST.AssociativeAST;
using System.Collections.Generic;
using System.Linq;

namespace SldWorksNodesUI.SwItems
{
    [NodeName(nameof(Configurations))]
    [NodeDescription("Lists all configuration in active doc to select one")]
    [NodeCategory("SolidWorks.Selection")]
    [IsDesignScriptCompatible]
    public class Configurations:SwDropDownBase
    {
        public const string outputName = "Cofiguration";

        public Configurations() : base(outputName)
        {

        }

        protected override SelectionState PopulateItemsCore(string currentSelection)
        {
            Items.Clear();

            var doc = SldWorksNodes.Util.SwContextUtil.GetActivDocContext();
            var configs = doc.GetConfigurationNames() as string[];
            if (configs != null)
            {
                Items.AddRange(configs
                    .Select(p => new DynamoDropDownItem(p, p)));
            }

            return SelectionState.Restore;
        }

        [JsonConstructor]
        public Configurations(string value,
            IEnumerable<PortModel> inPorts,
            IEnumerable<PortModel> outPorts) 
            : base(value, inPorts, outPorts)
        {
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
            var assign = AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), name);

            return new List<AssociativeNode> { assign };
        }
    }
}
