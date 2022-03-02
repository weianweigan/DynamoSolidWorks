using Autodesk.DesignScript.Runtime;
using Dynamo.Graph.Nodes;

namespace SldWorksNodes.Base
{
    [IsVisibleInDynamoLibrary(false)]
    public abstract class SwNode
    {
        public string PID { get; set; }
    }
}
