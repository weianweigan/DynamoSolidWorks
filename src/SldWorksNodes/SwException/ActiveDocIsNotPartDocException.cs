using Autodesk.DesignScript.Runtime;
using System;

namespace SldWorksNodes.SwException
{
    [IsVisibleInDynamoLibrary(false)]
    public class ActiveDocIsNotPartDocException : Exception
    {
        public ActiveDocIsNotPartDocException():base("ActiveDoc Is Not PartDoc")
        {

        }
    }
}
