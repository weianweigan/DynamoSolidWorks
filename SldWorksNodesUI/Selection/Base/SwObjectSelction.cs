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

namespace SldWorksNodesUI.Selection
{
    public abstract class SwObjectSelction<TSelection, TResult> : SelectionBase<TSelection, TResult>
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

        public override bool CanSelect { get; set; } = true;
    }

    public class SelectionNodeModelView : INodeViewCustomization<SelectFeature>
    {
        public void CustomizeView(SelectFeature model, NodeView nodeView)
        {
            var control = new Control.SelectionBox();
            nodeView.inputGrid.Children.Add(control);
            control.DataContext = model;
        }

        public void Dispose()
        {
        }
    }
}
