using SldWorksNodes.Base;
using SolidWorks.Interop.sldworks;
using CoreNodeModels;
using System.Collections.Generic;
using Dynamo.Graph.Nodes;

namespace SldWorksNodes.Selection
{
    [IsDesignScriptCompatible]
    public class SelectFace : NodeModel//SldSelection<IFace2, Brep.Face>
    {
        public SelectFace() 
        {

        }

    }
}
