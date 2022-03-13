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
        [NodeCategory("SolidWorks.Selection")]
        [NodeDescription("Select faces in doc")]
        [IsDesignScriptCompatible]
        public class SelectFaces : SelectFace
        {
            #region Fields
            private const string message = "Select Faces";
            private const string prefix = "Faces";

            #endregion


            protected override string GetOutputPortName() => prefix;
        
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
