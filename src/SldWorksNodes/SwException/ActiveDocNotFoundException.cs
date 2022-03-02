using Autodesk.DesignScript.Runtime;
using System;

namespace SldWorksNodes.SwException
{
    [IsVisibleInDynamoLibrary(false)]
    public class ActiveDocNotFoundException:Exception
    {
        public ActiveDocNotFoundException():base("No Active Doc In SolidWorks")
        {
            
        }
    }

    public class BodyOperationErrorException:Exception
    {
        public BodyOperationErrorException(SolidWorks.Interop.swconst.swBodyOperationError_e error):base($"Body boo operation error:{error}")
        {

        }
    }
}
