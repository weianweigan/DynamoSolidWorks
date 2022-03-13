using System;
using Dynamo.Wpf;
using CoreNodeModels;
using Newtonsoft.Json;
using Dynamo.Controls;
using Dynamo.Graph.Nodes;
using System.Collections.Generic;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodesUI.Selection
{
    [NodeName("Select Features")]
    [NodeCategory("SolidWorks.Selection")]
    [NodeDescription("Select features in doc")]
    [IsDesignScriptCompatible]
    public class SelectFeatures : SwObjectSelction<IFeature, SldWorksNodes.Feature.Feature>
    {
        #region Fields
        private const string message = "Select Features";
        private const string prefix = "Features";
        #endregion

        #region Ctor
        public SelectFeatures() :
            base(SelectionType.Many,
                SelectionObjectType.None,
                message,
                prefix)
        { }

        #endregion

        #region Methods
        protected override IEnumerable<SldWorksNodes.Feature.Feature> ExtractSelectionResults(IFeature selections)
        {
            if (selections == null)
                yield break;

            yield return new SldWorksNodes.Feature.Feature(selections);
        }

        protected override Func<string, SldWorksNodes.Feature.Feature> GetBuildFuncation() =>
            new Func<string, SldWorksNodes.Feature.Feature>(SldWorksNodes.Feature.Feature.ByPID);

        protected override string GetOutputPortName() => prefix;

        #endregion
    }

    public class SelectFeaturesNodeModelView : INodeViewCustomization<SelectFeatures>
    {
        public void CustomizeView(SelectFeatures model, NodeView nodeView)
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
