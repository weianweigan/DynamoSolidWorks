using Autodesk.DesignScript.Runtime;
using System;

namespace SldWorksNodes.SwException
{
    [IsVisibleInDynamoLibrary(false)]
    [SupressImportIntoVM()]
    public class SwApiException : Exception
    {
        public SwApiException(string message) : base(message)
        {
        }
    }
}
