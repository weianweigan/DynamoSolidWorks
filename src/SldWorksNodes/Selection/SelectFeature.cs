using SldWorksNodes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;
using Autodesk.DesignScript.Runtime;
using CoreNodeModels;
using Dynamo.Graph.Nodes;

namespace SldWorksNodes.Selection
{
    /// <summary>
    /// Node to select feature in modeldoc
    /// </summary>
    [IsDesignScriptCompatible]
    public class SelectFeature : NodeModel// SldSelection<IFeature, Feature.Feature>
    {
        public SelectFeature()
        {

        }

         
    }
}
