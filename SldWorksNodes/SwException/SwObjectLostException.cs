using Autodesk.DesignScript.Runtime;
using System;

namespace SldWorksNodes.SwException
{
    [IsVisibleInDynamoLibrary(false)]
    [SupressImportIntoVM()]
    public class SwObjectLostException : Exception
    {
        public SwObjectLostException(Type type):base($"Can not get {type.FullName} object,please check active doc changed")
        {

        }
    }
}
