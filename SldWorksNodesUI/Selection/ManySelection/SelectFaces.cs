using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodesUI.Selection
{
    using System;
    using Dynamo.Wpf;
    using CoreNodeModels;
    using Dynamo.Controls;
    using Newtonsoft.Json;
    using Dynamo.Graph.Nodes;
    using System.Collections.Generic;
    using SolidWorks.Interop.sldworks;

    namespace SldWorksNodesUI.Selection
    {
        /// <summary>
        /// Select a face in current doc in solidworks
        /// </summary>
        [NodeName(message)]
        [NodeCategory(SwNodesCategory.SelectionCategory)]
        [NodeDescription("Select faces in doc")]
        [IsDesignScriptCompatible]
        public class SelectFaces : SwObjectSelction<IFace2, SldWorksNodes.Brep.Face>
        {
            #region Fields
            private const string message = "Select Faces";
            private const string prefix = "Faces";

            #endregion

            #region Ctor
            public SelectFaces() :
                base(SelectionType.Many,
                    SelectionObjectType.None,
                    message,
                    prefix)
            {
            }
            #endregion

            #region Methods
            protected override IEnumerable<SldWorksNodes.Brep.Face> ExtractSelectionResults(IFace2 selections)
            {
                if (selections == null)
                    yield break;

                yield return new SldWorksNodes.Brep.Face(selections);
            }

            protected override Func<string, SldWorksNodes.Brep.Face> GetBuildFuncation() =>
                new Func<string, SldWorksNodes.Brep.Face>(SldWorksNodes.Brep.Face.ByPID);

            protected override string GetOutputPortName() => prefix;
            #endregion
        }

        public class SelectFacesNodeModelView : INodeViewCustomization<SelectFaces>
        {
            public void CustomizeView(SelectFaces model, NodeView nodeView)
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

}
