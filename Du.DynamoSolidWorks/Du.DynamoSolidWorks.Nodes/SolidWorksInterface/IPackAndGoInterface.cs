using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IPackAndGoObject
    {
        public IPackAndGo IPackAndGoInstance { get; set; }
        public IPackAndGoObject(IPackAndGo IPackAndGoinstance)
        {
            IPackAndGoInstance = IPackAndGoinstance;
        }
    }
    public static class IPackAndGoInterface
    {
        //public static Boolean GetDocumentSaveToNames(IPackAndGoObject IPackAndGoinstance, Object& PathNameList, Object& DocumentStatusList)
        //{
        //    return IPackAndGoinstance.IPackAndGoInstance.GetDocumentSaveToNames(PathNameList, DocumentStatusList);
        //}
        public static Boolean SetDocumentSaveToNames(IPackAndGoObject IPackAndGoinstance, Object PathNameList)
        {
            return IPackAndGoinstance.IPackAndGoInstance.SetDocumentSaveToNames(PathNameList);
        }
        public static String GetSaveToName(IPackAndGoObject IPackAndGoinstance)
        {
            return IPackAndGoinstance.IPackAndGoInstance.GetSaveToName();
        }
        public static Boolean SetSaveToName(IPackAndGoObject IPackAndGoinstance, Boolean Override, String SaveToName)
        {
            return IPackAndGoinstance.IPackAndGoInstance.SetSaveToName(Override, SaveToName);
        }
        //public static Boolean IGetDocumentSaveToNames(IPackAndGoObject IPackAndGoinstance, Int32 NameCount, String& NameList, Int32& StatusList)
        //{
        //    return IPackAndGoinstance.IPackAndGoInstance.IGetDocumentSaveToNames(NameCount, NameList, StatusList);
        //}
        //public static Boolean ISetDocumentSaveToNames(IPackAndGoObject IPackAndGoinstance, Int32 NameCount, String& NameList)
        //{
        //    return IPackAndGoinstance.IPackAndGoInstance.ISetDocumentSaveToNames(NameCount, NameList);
        //}
        public static Boolean AddExternalDocuments(IPackAndGoObject IPackAndGoinstance, Object DocumentNames)
        {
            return IPackAndGoinstance.IPackAndGoInstance.AddExternalDocuments(DocumentNames);
        }
        //public static Boolean GetExternalDocuments(IPackAndGoObject IPackAndGoinstance, Object& DocumentNames)
        //{
        //    return IPackAndGoinstance.IPackAndGoInstance.GetExternalDocuments(DocumentNames);
        //}
        //public static Boolean GetDocumentNames(IPackAndGoObject IPackAndGoinstance, Object& DocumentNames)
        //{
        //    return IPackAndGoinstance.IPackAndGoInstance.GetDocumentNames(DocumentNames);
        //}
        public static Int32 GetDocumentNamesCount(IPackAndGoObject IPackAndGoinstance)
        {
            return IPackAndGoinstance.IPackAndGoInstance.GetDocumentNamesCount();
        }
        //public static Boolean IGetDocumentNames(IPackAndGoObject IPackAndGoinstance, Int32 Count, String& DocumentNames)
        //{
        //    return IPackAndGoinstance.IPackAndGoInstance.IGetDocumentNames(Count, DocumentNames);
        //}
        public static Boolean RemoveExternalDocuments(IPackAndGoObject IPackAndGoinstance, Object DocumentNames)
        {
            return IPackAndGoinstance.IPackAndGoInstance.RemoveExternalDocuments(DocumentNames);
        }
        public static Boolean IncludeDrawings(IPackAndGoObject IPackAndGoinstance)
        {
            return IPackAndGoinstance.IPackAndGoInstance.IncludeDrawings;
        }
        public static Boolean IncludeSimulationResults(IPackAndGoObject IPackAndGoinstance)
        {
            return IPackAndGoinstance.IPackAndGoInstance.IncludeSimulationResults;
        }
        public static String AddPrefix(IPackAndGoObject IPackAndGoinstance)
        {
            return IPackAndGoinstance.IPackAndGoInstance.AddPrefix;
        }
        public static String AddSuffix(IPackAndGoObject IPackAndGoinstance)
        {
            return IPackAndGoinstance.IPackAndGoInstance.AddSuffix;
        }
        public static Boolean FlattenToSingleFolder(IPackAndGoObject IPackAndGoinstance)
        {
            return IPackAndGoinstance.IPackAndGoInstance.FlattenToSingleFolder;
        }
        public static Boolean IncludeToolboxComponents(IPackAndGoObject IPackAndGoinstance)
        {
            return IPackAndGoinstance.IPackAndGoInstance.IncludeToolboxComponents;
        }
        public static Boolean IncludeSuppressed(IPackAndGoObject IPackAndGoinstance)
        {
            return IPackAndGoinstance.IPackAndGoInstance.IncludeSuppressed;
        }
    }
}