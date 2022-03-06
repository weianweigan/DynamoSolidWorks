using Autodesk.DesignScript.Runtime;
using CoreNodeModels;
using Dynamo.Graph.Nodes;
using Dynamo.Utilities;
using Newtonsoft.Json;
using ProtoCore.AST.AssociativeAST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodesUI
{
    [NodeName(nameof(Features))]
    [NodeDescription("Lists all feature in active doc")]
    [NodeCategory("SldWorksNodes.Feature")]
    [OutPortNames(Features.outputName)]
    [OutPortTypes("string")]
    [OutPortDescriptions("Feature Name")]
    [IsDesignScriptCompatible]
    public class Features : SwDropDownBase
    {
        public const string outputName = "Feature";

        public Features() : base(outputName)
        {
            InPorts.Clear();
            OutPorts.Clear();

            RegisterAllPorts();
        }

        [JsonConstructor]
        public Features(IEnumerable<PortModel> inPorts, IEnumerable<PortModel> outPorts) : base(outputName, inPorts, outPorts)
        {

        }

        protected override SelectionState PopulateItemsCore(string currentSelection)
        {
            Items.Clear();

            var newItems = new List<DynamoDropDownItem>()
            {
                new DynamoDropDownItem("A","A"),
                new DynamoDropDownItem("b","b"),
            };

            Items.AddRange(newItems);

            SelectedIndex = 0;
            return SelectionState.Restore;
        }

        [IsVisibleInDynamoLibrary(false)]
        public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputAstNodes)
        {
            if (Items.Count == 0 ||
                Items[SelectedIndex].Name == "Select Hole Type..." ||
                SelectedIndex < 0)
            {
                return new[] { AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), AstFactory.BuildNullNode()) };
            }

            var intNode = AstFactory.BuildStringNode((string)Items[SelectedIndex].Item);
            var assign = AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), intNode);

            return new List<AssociativeNode> { assign };
        }
    }
}
