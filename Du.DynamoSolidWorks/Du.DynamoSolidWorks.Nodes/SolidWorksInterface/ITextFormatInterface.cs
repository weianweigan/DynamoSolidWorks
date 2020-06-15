using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ITextFormatObject
    {
        public ITextFormat ITextFormatInstance { get; set; }
        public ITextFormatObject(ITextFormat ITextFormatinstance)
        {
            ITextFormatInstance = ITextFormatinstance;
        }
    }
    public static class ITextFormatInterface
    {
        public static Object GetAllValues(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.GetAllValues();
        }
        public static Double IGetAllValues(ITextFormatObject ITextFormatinstance, Int32 Count)
        {
            return ITextFormatinstance.ITextFormatInstance.IGetAllValues(Count);
        }
        public static Boolean IsHeightSpecifiedInPts(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.IsHeightSpecifiedInPts();
        }
        public static Boolean Italic(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.Italic;
        }
        public static Boolean Underline(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.Underline;
        }
        public static Boolean Strikeout(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.Strikeout;
        }
        public static Boolean Bold(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.Bold;
        }
        public static Double Escapement(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.Escapement;
        }
        public static Double LineSpacing(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.LineSpacing;
        }
        public static Double CharHeight(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.CharHeight;
        }
        public static Int32 CharHeightInPts(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.CharHeightInPts;
        }
        public static String TypeFaceName(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.TypeFaceName;
        }
        public static Double WidthFactor(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.WidthFactor;
        }
        public static Double ObliqueAngle(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.ObliqueAngle;
        }
        public static Double LineLength(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.LineLength;
        }
        public static Boolean Vertical(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.Vertical;
        }
        public static Boolean BackWards(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.BackWards;
        }
        public static Boolean UpsideDown(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.UpsideDown;
        }
        public static Double CharSpacingFactor(ITextFormatObject ITextFormatinstance)
        {
            return ITextFormatinstance.ITextFormatInstance.CharSpacingFactor;
        }
    }
}