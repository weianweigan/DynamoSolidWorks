using System;
using System.Linq;
using CoreNodeModels;
using Newtonsoft.Json;
using SldWorksNodes.Util;
using Dynamo.Graph.Nodes;
using SldWorksNodes.Base;
using System.Collections.Generic;
using ProtoCore.AST.AssociativeAST;
using Microsoft.Practices.Prism.Commands;

namespace SldWorksNodesUI.Selection
{
    public abstract class SwObjectSelction<TSelection, TResult> :
        SelectionBase<TSelection, TResult>
        where TSelection : class
        where TResult : class, IPID
    {
        #region Fields
        private DelegateCommand _selectCommand;
        #endregion

        #region Ctor
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
        #endregion

        #region Properties
        public DelegateCommand SelectCommand { get => _selectCommand ?? (_selectCommand = new DelegateCommand(TrySelect,CanBeginSelect));}

        public override bool CanSelect { get; set; } = true;

        public override IModelSelectionHelper<TSelection> SelectionHelper => new SwModelSelectionHelper<TSelection,TResult>(this);
        #endregion

        #region Methods
        protected abstract Func<string, TResult> GetBuildFuncation();

        private void TrySelect()
        {
            base.Select(null);
        }

        protected override string GetIdentifierFromModelObject(TSelection modelObject)
        {
            return PIDUtil.GetPID(modelObject);
        }

        protected override TSelection GetModelObjectFromIdentifer(string id)
        {
            return PIDUtil.GetObjectFromPID(SwContextUtil.GetActivDocContext(),id,out var state) as TSelection;
        }

        public override IEnumerable<AssociativeNode> BuildOutputAst(
            List<AssociativeNode> inputAstNodes)
        {
            AssociativeNode node;

            var results = SelectionResults.ToList();

            if (SelectionResults == null || !results.Any())
            {
                node = AstFactory.BuildNullNode();
            }
            else if (results.Count == 1)//单选
            {
                var el = results.First();

                // If there is only one object in the list,
                // return a single item.
                node = AstFactory.BuildFunctionCall(
                    GetBuildFuncation(),
                    new List<AssociativeNode>
                    {
                        AstFactory.BuildStringNode(el.PID)
                    });
            }
            else//多选
            {
                var newInputs =
                    results.Select(
                        el =>
                            AstFactory.BuildFunctionCall(
                                GetBuildFuncation(),
                                new List<AssociativeNode>
                                {
                                    AstFactory.BuildStringNode(el.PID),
                                })).ToList();

                node = AstFactory.BuildExprList(newInputs);
            }

            return new[] { AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0), node) };
        }
        #endregion
    }
}
