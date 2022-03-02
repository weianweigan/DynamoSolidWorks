using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.swconst;
using System;

namespace SldWorksNodes.SwException
{
    [IsVisibleInDynamoLibrary(false)]
    public class PIDErrorException : Exception
    {
        public PIDErrorException(swPersistReferencedObjectStates_e state):base($"PIDError:{state}")
        {

        }
    }
}
