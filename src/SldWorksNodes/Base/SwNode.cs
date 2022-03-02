﻿using Autodesk.DesignScript.Runtime;
using Dynamo.Graph.Nodes;
using Newtonsoft.Json;

namespace SldWorksNodes.Base
{
    [IsVisibleInDynamoLibrary(false)]
    public abstract class SwNode
    {
        public string PID { get; set; }
    }
}
