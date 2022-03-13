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
    [NodeName("Select Feature")]
    [NodeCategory("SolidWorks.Selection")]
    [NodeDescription("Select a feature in doc")]
    [IsDesignScriptCompatible]
    public class SelectFeature : SwObjectSelction<IFeature, SldWorksNodes.Feature.Feature>
    {
        #region Fields
        private const string message = "Select Feature";
        private const string prefix = "Feature";
        #endregion

        #region Ctor
        public SelectFeature() : 
            base(SelectionType.One,
                SelectionObjectType.None, 
                message, 
                prefix){}

        [JsonConstructor]
        public SelectFeature(
            SelectionType selectionType,
            SelectionObjectType selectionObjectType, 
            string message, 
            string prefix,
            IEnumerable<string> selectionIdentifier, 
            IEnumerable<PortModel> inPorts, 
            IEnumerable<PortModel> outPorts)
    :       base(
                selectionType, 
                selectionObjectType, 
                message, 
                prefix, 
                selectionIdentifier, 
                inPorts, 
                outPorts) {}
        #endregion

        #region Methods
        protected override string GetOutputPortName() => prefix;

        protected override IEnumerable<SldWorksNodes.Feature.Feature> ExtractSelectionResults(IFeature selections)
        {
            if (selections == null)
                return new SldWorksNodes.Feature.Feature[] { };

            return new SldWorksNodes.Feature.Feature[] { new SldWorksNodes.Feature.Feature(selections) };
        }

        protected override Func<string, SldWorksNodes.Feature.Feature> GetBuildFuncation() =>
            new Func<string, SldWorksNodes.Feature.Feature>(SldWorksNodes.Feature.Feature.ByPID);

        #endregion
    }

    public class SelectFeatureNodeModelView : INodeViewCustomization<SelectFeature>
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
