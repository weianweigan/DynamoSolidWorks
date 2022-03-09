using Autodesk.DesignScript.Runtime;
using System;

namespace SldWorksNodes.SwException
{
    [IsVisibleInDynamoLibrary(false)]
    [SupressImportIntoVM()]
    public class FeatureTypeNameErrorException : Exception
    {
        public FeatureTypeNameErrorException(string featName,string typeName) : base($"Feature:{featName} Type({typeName}) Is Not Right")
        {

        }
    }
}
