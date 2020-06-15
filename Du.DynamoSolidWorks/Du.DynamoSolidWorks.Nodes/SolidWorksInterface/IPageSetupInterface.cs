using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IPageSetupObject
    {
        public IPageSetup IPageSetupInstance { get; set; }
        public IPageSetupObject(IPageSetup IPageSetupinstance)
        {
            IPageSetupInstance = IPageSetupinstance;
        }
    }
    public static class IPageSetupInterface
    {
        public static Boolean SetHeader(IPageSetupObject IPageSetupinstance, String Left, String Center, String Right)
        {
            return IPageSetupinstance.IPageSetupInstance.SetHeader(Left, Center, Right);
        }
        public static Boolean SetFooter(IPageSetupObject IPageSetupinstance, String Left, String Center, String Right)
        {
            return IPageSetupinstance.IPageSetupInstance.SetFooter(Left, Center, Right);
        }
        public static String GetHeaderFooterString(IPageSetupObject IPageSetupinstance, Int32 WhichOne)
        {
            return IPageSetupinstance.IPageSetupInstance.GetHeaderFooterString(WhichOne);
        }
        public static Boolean GetUseDefaultResolution(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.GetUseDefaultResolution();
        }
        public static Int32 GetResolution(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.GetResolution();
        }
        public static Boolean SetResolution(IPageSetupObject IPageSetupinstance, Boolean UseDefault, Int32 DPI)
        {
            return IPageSetupinstance.IPageSetupInstance.SetResolution(UseDefault, DPI);
        }
        public static Boolean ScaleToFit(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.ScaleToFit;
        }
        public static Double Scale2(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.Scale2;
        }
        public static Int32 Orientation(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.Orientation;
        }
        public static String LeftHeader(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.LeftHeader;
        }
        public static String CenterHeader(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.CenterHeader;
        }
        public static String RightHeader(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.RightHeader;
        }
        public static String LeftFooter(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.LeftFooter;
        }
        public static String CenterFooter(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.CenterFooter;
        }
        public static String RightFooter(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.RightFooter;
        }
        public static ITextFormatObject HeaderTextFormat(IPageSetupObject IPageSetupinstance)
        {
            return new ITextFormatObject(IPageSetupinstance.IPageSetupInstance.HeaderTextFormat);
        }
        public static ITextFormatObject FooterTextFormat(IPageSetupObject IPageSetupinstance)
        {
            return new ITextFormatObject(IPageSetupinstance.IPageSetupInstance.FooterTextFormat);
        }
        public static Boolean UsePageSetupOnSheets(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.UsePageSetupOnSheets;
        }
        public static Int32 PrinterPaperSize(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.PrinterPaperSize;
        }
        public static Int32 PrinterPaperLength(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.PrinterPaperLength;
        }
        public static Int32 PrinterPaperWidth(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.PrinterPaperWidth;
        }
        public static Int32 PrinterPaperSource(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.PrinterPaperSource;
        }
        public static Boolean HighQuality(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.HighQuality;
        }
        public static Int32 DrawingColor(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.DrawingColor;
        }
        public static Boolean ScaleDraftEdges(IPageSetupObject IPageSetupinstance)
        {
            return IPageSetupinstance.IPageSetupInstance.ScaleDraftEdges;
        }
    }
}