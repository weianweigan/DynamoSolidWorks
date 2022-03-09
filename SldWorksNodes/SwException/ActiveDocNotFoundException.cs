using Autodesk.DesignScript.Runtime;
using System;

namespace SldWorksNodes.SwException
{
    [IsVisibleInDynamoLibrary(false)]
    [SupressImportIntoVM()]
    public class ActiveDocNotFoundException:Exception
    {
        public ActiveDocNotFoundException():base("No Active Doc In SolidWorks")
        {
            
        }
    }
}
