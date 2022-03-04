using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.swconst;
using System;

namespace SldWorksNodes.SwException
{
    [IsVisibleInDynamoLibrary(false)]
    public class SelectionTypeErrorException:Exception
    {
        public SelectionTypeErrorException(swSelectType_e needType):base($"Selection Type Error,You Need Select a {needType.ToString()}")
        {

        }
    }
}
