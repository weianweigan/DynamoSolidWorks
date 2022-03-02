using Autodesk.DesignScript.Runtime;
using Dynamo.Graph.Nodes;

namespace SldWorksNodes.Base
{
    [IsVisibleInDynamoLibrary(false)]
    public abstract class SwNodeModel<TSwType>:SwNode
    {
        public TSwType SwObject { get; set; }
    }
}
