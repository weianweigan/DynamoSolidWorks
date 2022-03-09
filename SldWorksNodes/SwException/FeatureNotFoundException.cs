using Autodesk.DesignScript.Runtime;
using System;

namespace SldWorksNodes.SwException
{
    [IsVisibleInDynamoLibrary(false)]
    [SupressImportIntoVM()]
    public class FeatureNotFoundException : Exception
    {
        public FeatureNotFoundException(string name):base($"Feature:{name} Not Found")
        {

        }
    }
}
