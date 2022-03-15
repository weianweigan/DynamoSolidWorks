using Autodesk.DesignScript.Runtime;

namespace SldWorksNodes.Base
{
    [IsVisibleInDynamoLibrary(false)]
    public interface IPID
    {
        string PID { get; set; }
    }
}
