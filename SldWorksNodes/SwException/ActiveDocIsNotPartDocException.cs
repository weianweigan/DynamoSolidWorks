using Autodesk.DesignScript.Runtime;
using System;

namespace SldWorksNodes.SwException
{
    [IsVisibleInDynamoLibrary(false)]
    [SupressImportIntoVM()]
    public class ActiveDocIsNotPartDocException : Exception
    {
        public ActiveDocIsNotPartDocException():base("ActiveDoc Is Not PartDoc")
        {

        }
    }

    [IsVisibleInDynamoLibrary(false)]
    public class ActiveDocIsNotDrawingDocException : Exception
    {
        public ActiveDocIsNotDrawingDocException() : base("ActiveDoc Is Not DrawingDoc")
        {

        }
    }

    [IsVisibleInDynamoLibrary(false)]
    public class ActiveDocIsNotAssemblyDocException : Exception
    {
        public ActiveDocIsNotAssemblyDocException() : base("ActiveDoc Is Not AssemblyDoc")
        {

        }
    }
}
