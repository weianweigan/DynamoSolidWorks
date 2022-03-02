using Autodesk.DesignScript.Runtime;
using System;

namespace SldWorksNodes.SwException
{
    [IsVisibleInDynamoLibrary(false)]
    public class FeatureNotFoundException : Exception
    {
        public FeatureNotFoundException(string name):base($"Feature:{name} Not Found")
        {

        }
    }

    [IsVisibleInDynamoLibrary(false)]
    public class FeatureTypeNameErrorException : Exception
    {
        public FeatureTypeNameErrorException(string featName,string typeName) : base($"Feature:{featName} Type({typeName}) Is Not Right")
        {

        }
    }
}
