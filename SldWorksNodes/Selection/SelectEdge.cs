using CoreNodeModels;
using Dynamo.Graph.Nodes;
using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using System.Collections.Generic;

namespace SldWorksNodes.Selection
{
    /// <summary>
    /// Select Edge
    /// </summary>
    [IsDesignScriptCompatible]
    public class SelectEdge : NodeModel//SldSelection<IEdge, Brep.Edge>
    {
        public SelectEdge()
        {

        }

    }
}
