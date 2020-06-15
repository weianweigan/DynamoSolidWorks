using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICustomSymbolObject
    {
        public ICustomSymbol ICustomSymbolInstance { get; set; }
        public ICustomSymbolObject(ICustomSymbol ICustomSymbolinstance)
        {
            ICustomSymbolInstance = ICustomSymbolinstance;
        }
    }
    public static class ICustomSymbolInterface
    {
        public static Object GetNext(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetNext();
        }
        public static ICustomSymbolObject IGetNext(ICustomSymbolObject ICustomSymbolinstance)
        {
            return new ICustomSymbolObject(ICustomSymbolinstance.ICustomSymbolInstance.IGetNext());
        }
        public static Int32 GetTextCount(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetTextCount();
        }
        public static String GetTextAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetTextAtIndex(Index);
        }
        public static Double GetTextHeightAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetTextHeightAtIndex(Index);
        }
        public static Object GetTextPositionAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetTextPositionAtIndex(Index);
        }
        public static Double IGetTextPositionAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.IGetTextPositionAtIndex(Index);
        }
        public static Double GetTextAngleAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetTextAngleAtIndex(Index);
        }
        public static Int32 GetTextRefPositionAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetTextRefPositionAtIndex(Index);
        }
        public static Int32 GetTextInvertAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetTextInvertAtIndex(Index);
        }
        public static Int32 GetLineCount(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetLineCount();
        }
        public static Object GetLineAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetLineAtIndex(Index);
        }
        public static Double IGetLineAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.IGetLineAtIndex(Index);
        }
        public static Int32 GetArcCount(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetArcCount();
        }
        public static Object GetArcAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetArcAtIndex(Index);
        }
        public static Double IGetArcAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.IGetArcAtIndex(Index);
        }
        public static Int32 GetArrowHeadCount(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetArrowHeadCount();
        }
        public static Object GetArrowHeadAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetArrowHeadAtIndex(Index);
        }
        public static Double IGetArrowHeadAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.IGetArrowHeadAtIndex(Index);
        }
        public static Int32 GetTriangleCount(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetTriangleCount();
        }
        public static Object GetTriangleAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetTriangleAtIndex(Index);
        }
        public static Double IGetTriangleAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.IGetTriangleAtIndex(Index);
        }
        public static Object GetSketch(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetSketch();
        }
        public static ISketchObject IGetSketch(ICustomSymbolObject ICustomSymbolinstance)
        {
            return new ISketchObject(ICustomSymbolinstance.ICustomSymbolInstance.IGetSketch());
        }
        public static Object GetSketchPosition(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetSketchPosition();
        }
        public static Double IGetSketchPosition(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.IGetSketchPosition();
        }
        public static Boolean IsAttached(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.IsAttached();
        }
        public static Boolean HasExtraLeader(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.HasExtraLeader();
        }
        public static Int32 GetLeaderCount(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetLeaderCount();
        }
        public static Object GetLeaderAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetLeaderAtIndex(Index);
        }
        //public static Double IGetLeaderAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index, Int32& PointCount)
        //{
        //    return ICustomSymbolinstance.ICustomSymbolInstance.IGetLeaderAtIndex(Index, PointCount);
        //}
        public static Double IGetArrowHeadInfo(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.IGetArrowHeadInfo();
        }
        public static Object GetArrowHeadInfo(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetArrowHeadInfo();
        }
        public static Object GetAnnotation(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetAnnotation();
        }
        public static IAnnotationObject IGetAnnotation(ICustomSymbolObject ICustomSymbolinstance)
        {
            return new IAnnotationObject(ICustomSymbolinstance.ICustomSymbolInstance.IGetAnnotation());
        }
        public static String GetText(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetText(Index);
        }
        public static Boolean SetText(ICustomSymbolObject ICustomSymbolinstance, Int32 Index, String Text)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.SetText(Index, Text);
        }
        public static Int32 GetTextJustificationAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetTextJustificationAtIndex(Index);
        }
        public static void SetTextJustificationAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index, Int32 Justification)
        {
            ICustomSymbolinstance.ICustomSymbolInstance.SetTextJustificationAtIndex(Index, Justification);
        }
        public static Double GetTextLineSpacingAtIndex(ICustomSymbolObject ICustomSymbolinstance, Int32 Index)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetTextLineSpacingAtIndex(Index);
        }
        public static Int32 GetNoteCount(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetNoteCount();
        }
        public static Object GetNotes(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.GetNotes();
        }
        public static INoteObject IGetNotes(ICustomSymbolObject ICustomSymbolinstance, Int32 Count)
        {
            return new INoteObject(ICustomSymbolinstance.ICustomSymbolInstance.IGetNotes(Count));
        }
        public static Double Angle(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.Angle;
        }
        public static Double Scale2(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.Scale2;
        }
        public static Boolean TextVisible(ICustomSymbolObject ICustomSymbolinstance)
        {
            return ICustomSymbolinstance.ICustomSymbolInstance.TextVisible;
        }
    }
}