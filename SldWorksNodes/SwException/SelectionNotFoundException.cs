using Autodesk.DesignScript.Runtime;
using System;

namespace SldWorksNodes.SwException
{
    [IsVisibleInDynamoLibrary(false)]
    [SupressImportIntoVM()]
    public class SelectionNotFoundException : Exception
    {
        public SelectionNotFoundException():base("Selection Not Found, Please pre-select a object in SolidWorks")
        {

        }
    }
}
