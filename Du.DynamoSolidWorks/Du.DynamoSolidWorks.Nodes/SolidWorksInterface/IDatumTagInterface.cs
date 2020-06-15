using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDatumTagObject
    {
        public IDatumTag IDatumTagInstance { get; set; }
        public IDatumTagObject(IDatumTag IDatumTaginstance)
        {
            IDatumTagInstance = IDatumTaginstance;
        }
    }
    public static class IDatumTagInterface
    {
        public static Object GetNext(IDatumTagObject IDatumTaginstance)
        {
            return IDatumTaginstance.IDatumTagInstance.GetNext();
        }
        public static IDatumTagObject IGetNext(IDatumTagObject IDatumTaginstance)
        {
            return new IDatumTagObject(IDatumTaginstance.IDatumTagInstance.IGetNext());
        }
        public static Int32 GetTextCount(IDatumTagObject IDatumTaginstance)
        {
            return IDatumTaginstance.IDatumTagInstance.GetTextCount();
        }
        public static String GetTextAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.GetTextAtIndex(Index);
        }
        public static Double GetTextHeightAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.GetTextHeightAtIndex(Index);
        }
        public static Object GetTextPositionAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.GetTextPositionAtIndex(Index);
        }
        public static Double IGetTextPositionAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.IGetTextPositionAtIndex(Index);
        }
        public static Double GetTextAngleAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.GetTextAngleAtIndex(Index);
        }
        public static Int32 GetTextRefPositionAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.GetTextRefPositionAtIndex(Index);
        }
        public static Int32 GetTextInvertAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.GetTextInvertAtIndex(Index);
        }
        public static Int32 GetLineCount(IDatumTagObject IDatumTaginstance)
        {
            return IDatumTaginstance.IDatumTagInstance.GetLineCount();
        }
        public static Object GetLineAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.GetLineAtIndex(Index);
        }
        public static Double IGetLineAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.IGetLineAtIndex(Index);
        }
        public static Int32 GetArcCount(IDatumTagObject IDatumTaginstance)
        {
            return IDatumTaginstance.IDatumTagInstance.GetArcCount();
        }
        public static Object GetArcAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.GetArcAtIndex(Index);
        }
        public static Double IGetArcAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.IGetArcAtIndex(Index);
        }
        public static Int32 GetArrowHeadCount(IDatumTagObject IDatumTaginstance)
        {
            return IDatumTaginstance.IDatumTagInstance.GetArrowHeadCount();
        }
        public static Object GetArrowHeadAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.GetArrowHeadAtIndex(Index);
        }
        public static Double IGetArrowHeadAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.IGetArrowHeadAtIndex(Index);
        }
        public static Int32 GetTriangleCount(IDatumTagObject IDatumTaginstance)
        {
            return IDatumTaginstance.IDatumTagInstance.GetTriangleCount();
        }
        public static Object GetTriangleAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.GetTriangleAtIndex(Index);
        }
        public static Double IGetTriangleAtIndex(IDatumTagObject IDatumTaginstance, Int32 Index)
        {
            return IDatumTaginstance.IDatumTagInstance.IGetTriangleAtIndex(Index);
        }
        public static Object GetAnnotation(IDatumTagObject IDatumTaginstance)
        {
            return IDatumTaginstance.IDatumTagInstance.GetAnnotation();
        }
        public static IAnnotationObject IGetAnnotation(IDatumTagObject IDatumTaginstance)
        {
            return new IAnnotationObject(IDatumTaginstance.IDatumTagInstance.IGetAnnotation());
        }
        public static String GetLabel(IDatumTagObject IDatumTaginstance)
        {
            return IDatumTaginstance.IDatumTagInstance.GetLabel();
        }
        public static Boolean SetLabel(IDatumTagObject IDatumTaginstance, String Label)
        {
            return IDatumTaginstance.IDatumTagInstance.SetLabel(Label);
        }
        public static Boolean GetUseDocDisplayStyle(IDatumTagObject IDatumTaginstance)
        {
            return IDatumTaginstance.IDatumTagInstance.GetUseDocDisplayStyle();
        }
        public static Int32 GetDisplayStyle(IDatumTagObject IDatumTaginstance)
        {
            return IDatumTaginstance.IDatumTagInstance.GetDisplayStyle();
        }
        public static Boolean SetDisplayStyle(IDatumTagObject IDatumTaginstance, Boolean UseDoc, Int32 Style)
        {
            return IDatumTaginstance.IDatumTagInstance.SetDisplayStyle(UseDoc, Style);
        }
        public static Boolean SetText(IDatumTagObject IDatumTaginstance, Int32 WhichText, String Text)
        {
            return IDatumTaginstance.IDatumTagInstance.SetText(WhichText, Text);
        }
        public static Boolean FilledTriangle(IDatumTagObject IDatumTaginstance)
        {
            return IDatumTaginstance.IDatumTagInstance.FilledTriangle;
        }
        public static Boolean Shoulder(IDatumTagObject IDatumTaginstance)
        {
            return IDatumTaginstance.IDatumTagInstance.Shoulder;
        }
        public static Boolean ForcedShoulder(IDatumTagObject IDatumTaginstance)
        {
            return IDatumTaginstance.IDatumTagInstance.ForcedShoulder;
        }
        public static Int32 LeaderOrientation(IDatumTagObject IDatumTaginstance)
        {
            return IDatumTaginstance.IDatumTagInstance.LeaderOrientation;
        }
    }
}