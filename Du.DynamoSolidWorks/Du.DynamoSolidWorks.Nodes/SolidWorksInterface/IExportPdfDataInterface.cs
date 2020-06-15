using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IExportPdfDataObject
    {
        public IExportPdfData IExportPdfDataInstance { get; set; }
        public IExportPdfDataObject(IExportPdfData IExportPdfDatainstance)
        {
            IExportPdfDataInstance = IExportPdfDatainstance;
        }
    }
    public static class IExportPdfDataInterface
    {
        public static Int32 GetWhichSheets(IExportPdfDataObject IExportPdfDatainstance)
        {
            return IExportPdfDatainstance.IExportPdfDataInstance.GetWhichSheets();
        }
        public static Object GetSheets(IExportPdfDataObject IExportPdfDatainstance)
        {
            return IExportPdfDatainstance.IExportPdfDataInstance.GetSheets();
        }
        public static Boolean SetSheets(IExportPdfDataObject IExportPdfDatainstance, Int32 Which, Object Sheets)
        {
            return IExportPdfDatainstance.IExportPdfDataInstance.SetSheets(Which, Sheets);
        }
        public static Boolean ExportAs3D(IExportPdfDataObject IExportPdfDatainstance)
        {
            return IExportPdfDatainstance.IExportPdfDataInstance.ExportAs3D;
        }
        public static Boolean ViewPdfAfterSaving(IExportPdfDataObject IExportPdfDatainstance)
        {
            return IExportPdfDatainstance.IExportPdfDataInstance.ViewPdfAfterSaving;
        }
    }
}