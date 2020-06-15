using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRevisionTableAnnotationObject
    {
        public IRevisionTableAnnotation IRevisionTableAnnotationInstance { get; set; }
        public IRevisionTableAnnotationObject(IRevisionTableAnnotation IRevisionTableAnnotationinstance)
        {
            IRevisionTableAnnotationInstance = IRevisionTableAnnotationinstance;
        }
    }
    public static class IRevisionTableAnnotationInterface
    {
        public static ISheetObject GetSheet(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance)
        {
            return new ISheetObject(IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.GetSheet());
        }
        public static Int32 AddRevision(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance, String Revision)
        {
            return IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.AddRevision(Revision);
        }
        public static Boolean DeleteRevision(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance, Int32 RevisionId, Boolean DeleteSymbols)
        {
            return IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.DeleteRevision(RevisionId, DeleteSymbols);
        }
        public static String GetRevisionForId(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance, Int32 RevisionId)
        {
            return IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.GetRevisionForId(RevisionId);
        }
        public static Int32 GetRowNumberForId(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance, Int32 RevisionId)
        {
            return IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.GetRowNumberForId(RevisionId);
        }
        public static Int32 GetIdForRowNumber(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance, Int32 RowIndex)
        {
            return IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.GetIdForRowNumber(RowIndex);
        }
        public static Int32 GetRevisionSymbolCount(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance, Int32 RevisionId)
        {
            return IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.GetRevisionSymbolCount(RevisionId);
        }
        public static Object GetRevisionSymbols(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance, Int32 RevisionId)
        {
            return IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.GetRevisionSymbols(RevisionId);
        }
        public static INoteObject IGetRevisionSymbols(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance, Int32 RevisionId, Int32 Count)
        {
            return new INoteObject(IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.IGetRevisionSymbols(RevisionId, Count));
        }
        public static String GetColumnCustomProperty(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance, Int32 Index)
        {
            return IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.GetColumnCustomProperty(Index);
        }
        public static Boolean SetColumnCustomProperty(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance, Int32 Index, String CustomProp)
        {
            return IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.SetColumnCustomProperty(Index, CustomProp);
        }
        public static Int32 GetAllCustomPropertiesCount(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance)
        {
            return IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.GetAllCustomPropertiesCount();
        }
        public static Object GetAllCustomProperties(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance)
        {
            return IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.GetAllCustomProperties();
        }
        public static String IGetAllCustomProperties(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance, Int32 Count)
        {
            return IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.IGetAllCustomProperties(Count);
        }
        public static IRevisionTableFeatureObject RevisionTableFeature(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance)
        {
            return new IRevisionTableFeatureObject(IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.RevisionTableFeature);
        }
        public static String CurrentRevision(IRevisionTableAnnotationObject IRevisionTableAnnotationinstance)
        {
            return IRevisionTableAnnotationinstance.IRevisionTableAnnotationInstance.CurrentRevision;
        }
    }
}