﻿using System;
using Dynamo.Wpf;
using CoreNodeModels;
using Newtonsoft.Json;
using Dynamo.Controls;
using Dynamo.Graph.Nodes;
using System.Collections.Generic;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodesUI.Selection
{
    [NodeName("Select Component")]
    [NodeCategory(SwNodesCategory.SelectionCategory)]
    [NodeDescription("Select a Component in doc")]
    [IsDesignScriptCompatible]
    public class SelectComponent : SwObjectSelction<IComponent2, SldWorksNodes.Assembly.Component>
    {
        #region Fields
        private const string message = "Select Component";
        private const string prefix = "Component";
        #endregion

        #region Ctor
        public SelectComponent() : 
            base(SelectionType.One,
                SelectionObjectType.None, 
                message, 
                prefix){}

        #endregion

        #region Methods
        protected override IEnumerable<SldWorksNodes.Assembly.Component> ExtractSelectionResults(IComponent2 selections)
        {
            if (selections == null)
                yield break;

            yield return new SldWorksNodes.Assembly.Component(selections);
        }

        protected override Func<string, SldWorksNodes.Assembly.Component> GetBuildFuncation() =>
            new Func<string, SldWorksNodes.Assembly.Component>(SldWorksNodes.Assembly.Component.ByPID);

        protected override string GetOutputPortName() => prefix;
        #endregion
    }

    public class SelectComponentNodeModelView : INodeViewCustomization<SelectComponent>
    {
        public void CustomizeView(SelectComponent model, NodeView nodeView)
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
