using Autodesk.DesignScript.Runtime;

namespace SldWorksNodes.Base
{
    [IsVisibleInDynamoLibrary(false)]
    public interface ITempBody
    {
        void ClearBody();
        void DisplayBody();
        void SetTransparency(double value);
    }
}
