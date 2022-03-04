using Autodesk.DesignScript.Runtime;

namespace SldWorksNodes.Base
{
    [IsVisibleInDynamoLibrary(false)]
    public abstract class BrepNode<TBrepObject>:SwNodeModel<TBrepObject>
        where TBrepObject : class
    {

    }
}
