using CoreNodeModels;
using System.Collections.Generic;
using Dynamo.Graph.Nodes;
using Newtonsoft.Json;
using Dynamo.Wpf;
using Dynamo.Controls;
using System.Windows.Controls;
using Microsoft.Practices.Prism.Commands;
using System;
using Dynamo.Logging;
using SolidWorks.Interop.sldworks;
using SldWorksNodes.Util;
using System.Linq;
using ProtoCore.AST.AssociativeAST;
using SldWorksNodes.Base;

namespace SldWorksNodesUI.Selection
{
    public abstract class SwObjectSelction<TSelection, TResult> : SelectionBase<TSelection, TResult>
        where TSelection : class
        where TResult : SwNodeModel<TSelection>
    {
        private DelegateCommand _selectCommand;

        protected SwObjectSelction(
            SelectionType selectionType,
            SelectionObjectType selectionObjectType,
            string message,
            string prefix)
            : base(selectionType,
            selectionObjectType,
            message,
            prefix)
        {

        }

        [JsonConstructor]
        protected SwObjectSelction(
            SelectionType selectionType,
            SelectionObjectType selectionObjectType,
            string message,
            string prefix,
            IEnumerable<string> selectionIdentifier,
            IEnumerable<PortModel> inPorts,
            IEnumerable<PortModel> outPorts)
            : base(
                  selectionType,
                  selectionObjectType,
                  message,
                  prefix,
                  selectionIdentifier,
                  inPorts,
                  outPorts)
        { }

        public DelegateCommand SelectCommand { get => _selectCommand ?? (_selectCommand = new DelegateCommand(TrySelect,CanBeginSelect));}

        private void TrySelect()
        {
            base.Select(null);
        }

        protected abstract TResult BuildFunction(string id, bool flag);

        protected override string GetIdentifierFromModelObject(TSelection modelObject)
        {
            return PIDUtil.GetPID(modelObject);
        }

        protected override TSelection GetModelObjectFromIdentifer(string id)
        {
            return PIDUtil.GetObjectFromPID(SwContextUtil.GetActivePartDocContext(),id,out var state) as TSelection;
        }

        public override IEnumerable<AssociativeNode> BuildOutputAst(
            List<AssociativeNode> inputAstNodes)
        {
            AssociativeNode node;

            var results = SelectionResults.ToList();
            Func<string, bool, TResult> func = BuildFunction;

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

        public override bool CanSelect { get; set; } = true;

        public override IModelSelectionHelper<TSelection> SelectionHelper => new SwModelSelectionHelper<TSelection>();
    }
}
