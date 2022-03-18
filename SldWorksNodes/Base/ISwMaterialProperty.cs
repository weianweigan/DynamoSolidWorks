using Autodesk.DesignScript.Runtime;

namespace SldWorksNodes.Base
{
    [IsVisibleInDynamoLibrary(false)]
    public interface ISwMaterialProperty
    {
        MaterialProperty MaterialProperty();
        void SetMaterialProperty(MaterialProperty materialProperty);
    }
}
