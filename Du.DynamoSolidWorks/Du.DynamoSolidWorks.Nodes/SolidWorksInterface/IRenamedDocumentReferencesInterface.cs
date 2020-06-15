using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRenamedDocumentReferencesObject
    {
        public IRenamedDocumentReferences IRenamedDocumentReferencesInstance { get; set; }
        public IRenamedDocumentReferencesObject(IRenamedDocumentReferences IRenamedDocumentReferencesinstance)
        {
            IRenamedDocumentReferencesInstance = IRenamedDocumentReferencesinstance;
        }
    }
    public static class IRenamedDocumentReferencesInterface
    {
        public static void Search(IRenamedDocumentReferencesObject IRenamedDocumentReferencesinstance)
        {
            IRenamedDocumentReferencesinstance.IRenamedDocumentReferencesInstance.Search();
        }
        public static Object GetSearchPath(IRenamedDocumentReferencesObject IRenamedDocumentReferencesinstance)
        {
            return IRenamedDocumentReferencesinstance.IRenamedDocumentReferencesInstance.GetSearchPath();
        }
        public static Object ReferencesArray(IRenamedDocumentReferencesObject IRenamedDocumentReferencesinstance)
        {
            return IRenamedDocumentReferencesinstance.IRenamedDocumentReferencesInstance.ReferencesArray();
        }
        public static Boolean AddSearchFolder(IRenamedDocumentReferencesObject IRenamedDocumentReferencesinstance, String Folder)
        {
            return IRenamedDocumentReferencesinstance.IRenamedDocumentReferencesInstance.AddSearchFolder(Folder);
        }
        public static Boolean RemoveSearchFolder(IRenamedDocumentReferencesObject IRenamedDocumentReferencesinstance, String Folder)
        {
            return IRenamedDocumentReferencesinstance.IRenamedDocumentReferencesInstance.RemoveSearchFolder(Folder);
        }
        public static Boolean RemoveReference(IRenamedDocumentReferencesObject IRenamedDocumentReferencesinstance, String Reference)
        {
            return IRenamedDocumentReferencesinstance.IRenamedDocumentReferencesInstance.RemoveReference(Reference);
        }
        public static Int32 CompletionAction(IRenamedDocumentReferencesObject IRenamedDocumentReferencesinstance)
        {
            return IRenamedDocumentReferencesinstance.IRenamedDocumentReferencesInstance.CompletionAction;
        }
        public static Boolean UpdateWhereUsedReferences(IRenamedDocumentReferencesObject IRenamedDocumentReferencesinstance)
        {
            return IRenamedDocumentReferencesinstance.IRenamedDocumentReferencesInstance.UpdateWhereUsedReferences;
        }
        public static Boolean IncludeFileLocations(IRenamedDocumentReferencesObject IRenamedDocumentReferencesinstance)
        {
            return IRenamedDocumentReferencesinstance.IRenamedDocumentReferencesInstance.IncludeFileLocations;
        }
    }
}