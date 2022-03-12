using Autodesk.DesignScript.Runtime;
using CoreNodeModels;
using Dynamo.Graph.Nodes;
using Dynamo.Utilities;
using Newtonsoft.Json;
using ProtoCore.AST.AssociativeAST;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SldWorksNodesUI.Feature
{
    [NodeName(nameof(Features))]
    [NodeDescription("Lists all features in active doc to select one")]
    [NodeCategory("SolidWorks.Selection")]
    [OutPortNames(Features.outputName)]
    [OutPortTypes("SldWorksNodes.SldWorksNodes.Feature.Feature")]
    [OutPortDescriptions("Feature")]
    [IsDesignScriptCompatible]
    public class Features : SwFeatureDropDown
    {
        public const string outputName = "Feature";

        public Features() : base(outputName)
        {

        }

        [JsonConstructor]
        public Features(IEnumerable<PortModel> inPorts, IEnumerable<PortModel> outPorts) : base(outputName, inPorts, outPorts)
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
                new Func<string, SldWorksNodes.Feature.Feature>(SldWorksNodes.Feature.Feature.ByName),
                new List<AssociativeNode>() { name }
                );
            var assign = AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), itemNode);

            return new List<AssociativeNode> { assign };
        }

        protected override SelectionState PopulateItemsCore(string currentSelection)
        {
            Items.Clear();

            var items = GetNeededFeats(string.Empty);

            Items.AddRange(items);

            //SelectedIndex = 0;
            return SelectionState.Restore;
        }
    }
}
