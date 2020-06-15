using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class INoteObject
    {
        public INote INoteInstance { get; set; }
        public INoteObject(INote INoteinstance)
        {
            INoteInstance = INoteinstance;
        }
    }
    public static class INoteInterface
    {
        public static IAnnotationObject IGetAnnotation(INoteObject INoteinstance)
        {
            return new IAnnotationObject(INoteinstance.INoteInstance.IGetAnnotation());
        }
        public static Int32 GetBalloonStyle(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetBalloonStyle();
        }
        public static Int32 GetBalloonSize(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetBalloonSize();
        }
        public static Boolean SetBalloon(INoteObject INoteinstance, Int32 Style, Int32 Size)
        {
            return INoteinstance.INoteInstance.SetBalloon(Style, Size);
        }
        public static Int32 IGetTextTokenCount(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IGetTextTokenCount();
        }
        //public static Object GetTextTokens(INoteObject INoteinstance, Object& Positions, Object& Widths, Object& Heights)
        //{
        //    return INoteinstance.INoteInstance.GetTextTokens(Positions, Widths, Heights);
        //}
        //public static String IGetTextTokens(INoteObject INoteinstance, Double& Positions, Double& Widths, Double& Heights)
        //{
        //    return INoteinstance.INoteInstance.IGetTextTokens(Positions, Widths, Heights);
        //}
        public static Boolean IsBomBalloon(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IsBomBalloon();
        }
        public static Int32 GetBomBalloonTextStyle(INoteObject INoteinstance, Boolean WhichOne)
        {
            return INoteinstance.INoteInstance.GetBomBalloonTextStyle(WhichOne);
        }
        public static String GetBomBalloonText(INoteObject INoteinstance, Boolean WhichOne)
        {
            return INoteinstance.INoteInstance.GetBomBalloonText(WhichOne);
        }
        public static Boolean SetBomBalloonText(INoteObject INoteinstance, Int32 UpperTextStyle, String UpperText, Int32 LowerTextStyle, String LowerText)
        {
            return INoteinstance.INoteInstance.SetBomBalloonText(UpperTextStyle, UpperText, LowerTextStyle, LowerText);
        }
        public static Boolean IsAttribute(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IsAttribute();
        }
        public static Boolean IsStackedBalloon(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IsStackedBalloon();
        }
        public static Boolean IsStackedBalloonMaster(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IsStackedBalloonMaster();
        }
        public static IBalloonStackObject GetBalloonStack(INoteObject INoteinstance)
        {
            return new IBalloonStackObject(INoteinstance.INoteInstance.GetBalloonStack());
        }
        public static Object GetTextPoint2(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetTextPoint2();
        }
        public static IMathPointObject IGetTextPoint2(INoteObject INoteinstance)
        {
            return new IMathPointObject(INoteinstance.INoteInstance.IGetTextPoint2());
        }
        public static Int32 GetCompoundTextCount(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetCompoundTextCount();
        }
        public static String GetCompoundTextAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetCompoundTextAtIndex(Index);
        }
        //public static Boolean GetBendLineValues(INoteObject INoteinstance, Boolean& Up, Double& Angle, Double& Radius, MathPoint&Object StartPt, MathPoint&Object EndPt)
        //{
        //    return INoteinstance.INoteInstance.GetBendLineValues(Up, Angle, Radius, StartPt, EndPt);
        //}
        //public static Boolean GetBendLineValues2(INoteObject INoteinstance, Boolean& Up, Double& Angle, Double& Radius, Object& Points)
        //{
        //    return INoteinstance.INoteInstance.GetBendLineValues2(Up, Angle, Radius, Points);
        //}
        public static Int32 GetLeaderNumPointsAt(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetLeaderNumPointsAt(Index);
        }
        public static Int32 GetTextVerticalJustification(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetTextVerticalJustification();
        }
        public static void SetTextVerticalJustification(INoteObject INoteinstance, Int32 Justification)
        {
            INoteinstance.INoteInstance.SetTextVerticalJustification(Justification);
        }
        public static Double GetBalloonPadding(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetBalloonPadding();
        }
        public static Boolean SetBalloonPadding(INoteObject INoteinstance, Double Padding)
        {
            return INoteinstance.INoteInstance.SetBalloonPadding(Padding);
        }
        public static Object GetNext(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetNext();
        }
        public static INoteObject IGetNext(INoteObject INoteinstance)
        {
            return new INoteObject(INoteinstance.INoteInstance.IGetNext());
        }
        public static String GetText(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetText();
        }
        public static Double GetHeight(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetHeight();
        }
        public static Object GetAttachPos(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetAttachPos();
        }
        public static Object GetFontInfo(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetFontInfo();
        }
        public static Object GetLeaderInfo(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetLeaderInfo();
        }
        public static Boolean IsAttached(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IsAttached();
        }
        public static Boolean HasExtraLeader(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.HasExtraLeader();
        }
        public static Boolean HasBalloon(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.HasBalloon();
        }
        public static Object GetBalloonInfo(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetBalloonInfo();
        }
        public static Object GetTextPoint(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetTextPoint();
        }
        public static Object GetArrowHeadInfo(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetArrowHeadInfo();
        }
        public static Double IGetAttachPos(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IGetAttachPos();
        }
        public static Double IGetFontInfo(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IGetFontInfo();
        }
        //public static Double IGetLeaderInfo(INoteObject INoteinstance, Int32& PointCount)
        //{
        //    return INoteinstance.INoteInstance.IGetLeaderInfo(PointCount);
        //}
        public static Double IGetBalloonInfo(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IGetBalloonInfo();
        }
        public static Double IGetTextPoint(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IGetTextPoint();
        }
        public static Double IGetArrowHeadInfo(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IGetArrowHeadInfo();
        }
        public static Object GetUpperRight(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetUpperRight();
        }
        public static Double IGetUpperRight(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IGetUpperRight();
        }
        public static Object GetExtent(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetExtent();
        }
        public static Double IGetExtent(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IGetExtent();
        }
        public static Boolean IsCompoundNote(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IsCompoundNote();
        }
        public static Boolean AddText(INoteObject INoteinstance, String Txt, Double X, Double Y, Double Z)
        {
            return INoteinstance.INoteInstance.AddText(Txt, X, Y, Z);
        }
        public static Int32 GetTextCount(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetTextCount();
        }
        public static String GetTextAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetTextAtIndex(Index);
        }
        public static Double GetHeightAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetHeightAtIndex(Index);
        }
        public static Object GetTextOffsetAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetTextOffsetAtIndex(Index);
        }
        public static Double IGetTextOffsetAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.IGetTextOffsetAtIndex(Index);
        }
        public static void BeginSketchEdit(INoteObject INoteinstance)
        {
            INoteinstance.INoteInstance.BeginSketchEdit();
        }
        public static void EndSketchEdit(INoteObject INoteinstance)
        {
            INoteinstance.INoteInstance.EndSketchEdit();
        }
        public static Object GetExtentAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetExtentAtIndex(Index);
        }
        public static Double IGetExtentAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.IGetExtentAtIndex(Index);
        }
        public static void SetTextOffsetAtIndex(INoteObject INoteinstance, Int32 Index, Double X, Double Y, Double Z)
        {
            INoteinstance.INoteInstance.SetTextOffsetAtIndex(Index, X, Y, Z);
        }
        public static Object GetSketch(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetSketch();
        }
        public static ISketchObject IGetSketch(INoteObject INoteinstance)
        {
            return new ISketchObject(INoteinstance.INoteInstance.IGetSketch());
        }
        public static Boolean SetTextAtIndex(INoteObject INoteinstance, Int32 Index, String Txt)
        {
            return INoteinstance.INoteInstance.SetTextAtIndex(Index, Txt);
        }
        public static Boolean SetText(INoteObject INoteinstance, String Txt)
        {
            return INoteinstance.INoteInstance.SetText(Txt);
        }
        public static Boolean SetZeroLengthLeader(INoteObject INoteinstance, Boolean Flag)
        {
            return INoteinstance.INoteInstance.SetZeroLengthLeader(Flag);
        }
        public static void SetHeight(INoteObject INoteinstance, Double HeightIn)
        {
            INoteinstance.INoteInstance.SetHeight(HeightIn);
        }
        public static Int32 GetHeightInPoints(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetHeightInPoints();
        }
        public static void SetHeightInPoints(INoteObject INoteinstance, Int32 HeightIn)
        {
            INoteinstance.INoteInstance.SetHeightInPoints(HeightIn);
        }
        public static String GetName(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetName();
        }
        public static Boolean SetName(INoteObject INoteinstance, String NameIn)
        {
            return INoteinstance.INoteInstance.SetName(NameIn);
        }
        public static Double GetTextHeightAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetTextHeightAtIndex(Index);
        }
        public static Object GetTextPositionAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetTextPositionAtIndex(Index);
        }
        public static Double IGetTextPositionAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.IGetTextPositionAtIndex(Index);
        }
        public static Double GetTextAngleAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetTextAngleAtIndex(Index);
        }
        public static Int32 GetTextRefPositionAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetTextRefPositionAtIndex(Index);
        }
        public static Int32 GetTextInvertAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetTextInvertAtIndex(Index);
        }
        public static Int32 GetLineCount(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetLineCount();
        }
        public static Object GetLineAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetLineAtIndex(Index);
        }
        public static Double IGetLineAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.IGetLineAtIndex(Index);
        }
        public static Int32 GetArcCount(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetArcCount();
        }
        public static Object GetArcAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetArcAtIndex(Index);
        }
        public static Double IGetArcAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.IGetArcAtIndex(Index);
        }
        public static Int32 GetArrowHeadCount(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetArrowHeadCount();
        }
        public static Object GetArrowHeadAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetArrowHeadAtIndex(Index);
        }
        public static Double IGetArrowHeadAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.IGetArrowHeadAtIndex(Index);
        }
        public static Int32 GetTriangleCount(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetTriangleCount();
        }
        public static Object GetTriangleAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetTriangleAtIndex(Index);
        }
        public static Double IGetTriangleAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.IGetTriangleAtIndex(Index);
        }
        public static String GetTextFontAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetTextFontAtIndex(Index);
        }
        public static void SetTextPoint(INoteObject INoteinstance, Double X, Double Y, Double Z)
        {
            INoteinstance.INoteInstance.SetTextPoint(X, Y, Z);
        }
        public static Double GetTextLineSpacingAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetTextLineSpacingAtIndex(Index);
        }
        public static Int32 GetLeaderCount(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetLeaderCount();
        }
        public static Object GetLeaderAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetLeaderAtIndex(Index);
        }
        //public static Double IGetLeaderAtIndex(INoteObject INoteinstance, Int32 Index, Int32& PointCount)
        //{
        //    return INoteinstance.INoteInstance.IGetLeaderAtIndex(Index, PointCount);
        //}
        public static Object GetTextFormat(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetTextFormat();
        }
        public static ITextFormatObject IGetTextFormat(INoteObject INoteinstance)
        {
            return new ITextFormatObject(INoteinstance.INoteInstance.IGetTextFormat());
        }
        public static Boolean SetTextFormat(INoteObject INoteinstance, Int32 TextFormatType, Object TextFormat)
        {
            return INoteinstance.INoteInstance.SetTextFormat(TextFormatType, TextFormat);
        }
        public static Boolean ISetTextFormat(INoteObject INoteinstance, Int32 TextFormatType, ITextFormatObject TextFormat)
        {
            return INoteinstance.INoteInstance.ISetTextFormat(TextFormatType, TextFormat.ITextFormatInstance?.CastObj<TextFormat>());
        }
        public static Object GetTextFormatAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetTextFormatAtIndex(Index);
        }
        public static ITextFormatObject IGetTextFormatAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return new ITextFormatObject(INoteinstance.INoteInstance.IGetTextFormatAtIndex(Index));
        }
        public static void SetTextFormatAtIndex(INoteObject INoteinstance, Int32 Index, Object TextFormat)
        {
            INoteinstance.INoteInstance.SetTextFormatAtIndex(Index, TextFormat);
        }
        public static void ISetTextFormatAtIndex(INoteObject INoteinstance, Int32 Index, ITextFormatObject TextFormat)
        {
            INoteinstance.INoteInstance.ISetTextFormatAtIndex(Index, TextFormat?.CastObj<TextFormat>());
        }
        public static Int32 GetTextJustification(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetTextJustification();
        }
        public static void SetTextJustification(INoteObject INoteinstance, Int32 Justification)
        {
            INoteinstance.INoteInstance.SetTextJustification(Justification);
        }
        public static Int32 GetTextJustificationAtIndex(INoteObject INoteinstance, Int32 Index)
        {
            return INoteinstance.INoteInstance.GetTextJustificationAtIndex(Index);
        }
        public static void SetTextJustificationAtIndex(INoteObject INoteinstance, Int32 Index, Int32 Justification)
        {
            INoteinstance.INoteInstance.SetTextJustificationAtIndex(Index, Justification);
        }
        public static Boolean GetUseDocTextFormat(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetUseDocTextFormat();
        }
        public static String GetHyperlinkText(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetHyperlinkText();
        }
        public static Boolean SetHyperlinkText(INoteObject INoteinstance, String Text)
        {
            return INoteinstance.INoteInstance.SetHyperlinkText(Text);
        }
        public static Object GetAnnotation(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.GetAnnotation();
        }
        public static Double Angle(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.Angle;
        }
        public static Boolean ReadOnly(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.ReadOnly;
        }
        public static String PromptText(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.PromptText;
        }
        public static String TagName(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.TagName;
        }
        public static Boolean Visible(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.Visible;
        }
        public static String PropertyLinkedText(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.PropertyLinkedText;
        }
        public static Boolean TextRightToLeft(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.TextRightToLeft;
        }
        public static Boolean IsBendLineNote(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.IsBendLineNote;
        }
        public static Boolean HasMultipleFonts(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.HasMultipleFonts;
        }
        public static Boolean LockPosition(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.LockPosition;
        }
        public static Boolean BehindSheet(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.BehindSheet;
        }
        public static Boolean AllUpperCase(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.AllUpperCase;
        }
        public static Boolean ToBoundingBox(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.ToBoundingBox;
        }
        public static Boolean WatermarkNote(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.WatermarkNote;
        }
        public static Boolean WatermarkBehindGeometry(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.WatermarkBehindGeometry;
        }
        public static Double WatermarkTransparencyLevel(INoteObject INoteinstance)
        {
            return INoteinstance.INoteInstance.WatermarkTransparencyLevel;
        }
    }
}