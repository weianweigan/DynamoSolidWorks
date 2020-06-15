using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMBD3DPdfDataObject
    {
        public IMBD3DPdfData IMBD3DPdfDataInstance { get; set; }
        public IMBD3DPdfDataObject(IMBD3DPdfData IMBD3DPdfDatainstance)
        {
            IMBD3DPdfDataInstance = IMBD3DPdfDatainstance;
        }
    }
    public static class IMBD3DPdfDataInterface
    {
        public static void SetMoreViews(IMBD3DPdfDataObject IMBD3DPdfDatainstance, Object Values)
        {
            IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.SetMoreViews(Values);
        }
        public static Object GetMoreViews(IMBD3DPdfDataObject IMBD3DPdfDatainstance)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.GetMoreViews();
        }
        public static void SetStandardViews(IMBD3DPdfDataObject IMBD3DPdfDatainstance, Object Values)
        {
            IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.SetStandardViews(Values);
        }
        public static Object GetStandardViews(IMBD3DPdfDataObject IMBD3DPdfDatainstance)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.GetStandardViews();
        }
        public static Object GetTextAndCustomProperties(IMBD3DPdfDataObject IMBD3DPdfDatainstance)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.GetTextAndCustomProperties();
        }
        public static Int32 GetBomAreaCount(IMBD3DPdfDataObject IMBD3DPdfDatainstance)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.GetBomAreaCount();
        }
        public static Int32 SetBomTable(IMBD3DPdfDataObject IMBD3DPdfDatainstance, Int32 Index, String BomTableName, Object Columns)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.SetBomTable(Index, BomTableName, Columns);
        }
        public static Boolean SetIndependentViewPort(IMBD3DPdfDataObject IMBD3DPdfDatainstance, String ViewName)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.SetIndependentViewPort(ViewName);
        }
        public static void SetAttachments(IMBD3DPdfDataObject IMBD3DPdfDatainstance, Object Values)
        {
            IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.SetAttachments(Values);
        }
        public static Object GetAttachments(IMBD3DPdfDataObject IMBD3DPdfDatainstance)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.GetAttachments();
        }
        public static Boolean SetImportedNote(IMBD3DPdfDataObject IMBD3DPdfDatainstance, String Name, Object Note)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.SetImportedNote(Name, Note);
        }
        public static Object GetImportedNotes(IMBD3DPdfDataObject IMBD3DPdfDatainstance)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.GetImportedNotes();
        }
        public static String FilePath(IMBD3DPdfDataObject IMBD3DPdfDatainstance)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.FilePath;
        }
        public static String ThemeName(IMBD3DPdfDataObject IMBD3DPdfDatainstance)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.ThemeName;
        }
        public static Boolean ViewPdfAfterSaving(IMBD3DPdfDataObject IMBD3DPdfDatainstance)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.ViewPdfAfterSaving;
        }
        public static Boolean ExcludeFromAnnotationView(IMBD3DPdfDataObject IMBD3DPdfDatainstance)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.ExcludeFromAnnotationView;
        }
        public static Int32 Accuracy(IMBD3DPdfDataObject IMBD3DPdfDatainstance)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.Accuracy;
        }
        public static Boolean CompressLossyTessellation(IMBD3DPdfDataObject IMBD3DPdfDatainstance)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.CompressLossyTessellation;
        }
        public static Boolean CreateAttachSTEP242(IMBD3DPdfDataObject IMBD3DPdfDatainstance)
        {
            return IMBD3DPdfDatainstance.IMBD3DPdfDataInstance.CreateAttachSTEP242;
        }
    }
}