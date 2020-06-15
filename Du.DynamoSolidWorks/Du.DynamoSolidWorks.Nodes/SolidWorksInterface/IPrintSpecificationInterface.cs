using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IPrintSpecificationObject
    {
        public IPrintSpecification IPrintSpecificationInstance { get; set; }
        public IPrintSpecificationObject(IPrintSpecification IPrintSpecificationinstance)
        {
            IPrintSpecificationInstance = IPrintSpecificationinstance;
        }
    }
    public static class IPrintSpecificationInterface
    {
        public static void AddPrintRange(IPrintSpecificationObject IPrintSpecificationinstance, Int32 FirstPage, Int32 LastPage)
        {
            IPrintSpecificationinstance.IPrintSpecificationInstance.AddPrintRange(FirstPage, LastPage);
        }
        public static void ResetPrintRange(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            IPrintSpecificationinstance.IPrintSpecificationInstance.ResetPrintRange();
        }
        public static void RestoreDefaults(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            IPrintSpecificationinstance.IPrintSpecificationInstance.RestoreDefaults();
        }
        public static Int32 ScaleMethod(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.ScaleMethod;
        }
        public static Object PrintRange(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.PrintRange;
        }
        public static Double FromScale(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.FromScale;
        }
        public static Double ToScale(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.ToScale;
        }
        public static Double XOrigin(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.XOrigin;
        }
        public static Double YOrigin(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.YOrigin;
        }
        public static String PrintFile(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.PrintFile;
        }
        public static String PrinterQueue(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.PrinterQueue;
        }
        public static Int32 NumberOfCopies(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.NumberOfCopies;
        }
        public static Boolean ConvertToHighQuality(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.ConvertToHighQuality;
        }
        public static Boolean PrintCrossHatchOnOutOfDateViews(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.PrintCrossHatchOnOutOfDateViews;
        }
        public static Boolean PrintBackground(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.PrintBackground;
        }
        public static Boolean PrintWhiteItemsBlack(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.PrintWhiteItemsBlack;
        }
        public static Boolean Collate(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.Collate;
        }
        public static Int32 SheetCount(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.SheetCount;
        }
        public static Int32 CurrentSheet(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.CurrentSheet;
        }
        public static Boolean PrintToFile(IPrintSpecificationObject IPrintSpecificationinstance)
        {
            return IPrintSpecificationinstance.IPrintSpecificationInstance.PrintToFile;
        }
    }
}