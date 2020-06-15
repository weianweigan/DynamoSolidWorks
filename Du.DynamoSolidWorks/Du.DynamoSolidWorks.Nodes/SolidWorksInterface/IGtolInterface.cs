using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IGtolObject
    {
        public IGtol IGtolInstance { get; set; }
        public IGtolObject(IGtol IGtolinstance)
        {
            IGtolInstance = IGtolinstance;
        }
    }
    public static class IGtolInterface
    {
        public static Object GetFrameDiameterSymbols(IGtolObject IGtolinstance, Int16 FrameNumber)
        {
            return IGtolinstance.IGtolInstance.GetFrameDiameterSymbols(FrameNumber);
        }
        public static Boolean IGetFrameDiameterSymbols(IGtolObject IGtolinstance, Int16 FrameNumber)
        {
            return IGtolinstance.IGtolInstance.IGetFrameDiameterSymbols(FrameNumber);
        }
        public static Int16 GetFrameCount(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetFrameCount();
        }
        public static Object GetLeaderAtIndex2(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.GetLeaderAtIndex2(Index);
        }
        //public static Double IGetLeaderAtIndex2(IGtolObject IGtolinstance, Int32 Index, Int32& PointCount)
        //{
        //    return IGtolinstance.IGtolInstance.IGetLeaderAtIndex2(Index, PointCount);
        //}
        public static Object GetWitnessLine(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetWitnessLine();
        }
        public static Double IGetWitnessLine(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.IGetWitnessLine();
        }
        public static Boolean SetText(IGtolObject IGtolinstance, Int32 WhichText, String Text)
        {
            return IGtolinstance.IGtolInstance.SetText(WhichText, Text);
        }
        public static Boolean GetCompositeFrame2(IGtolObject IGtolinstance, Int16 FrameNum)
        {
            return IGtolinstance.IGtolInstance.GetCompositeFrame2(FrameNum);
        }
        public static void SetCompositeFrame2(IGtolObject IGtolinstance, Boolean Composite, Int16 FrameNum)
        {
            IGtolinstance.IGtolInstance.SetCompositeFrame2(Composite, FrameNum);
        }
        public static Boolean SetFrameValues2(IGtolObject IGtolinstance, Int16 FrameNumber, String Tol1, String Tol2, String Datum1, String Datum2, String Datum3)
        {
            return IGtolinstance.IGtolInstance.SetFrameValues2(FrameNumber, Tol1, Tol2, Datum1, Datum2, Datum3);
        }
        public static Object GetFrameSymbols3(IGtolObject IGtolinstance, Int32 FrameNumber)
        {
            return IGtolinstance.IGtolInstance.GetFrameSymbols3(FrameNumber);
        }
        //public static Boolean GetPTZHeight2(IGtolObject IGtolinstance, Int32 FrameNumber, Int32 TolNumber, Boolean& PtzDisplay, String& PtzHt)
        //{
        //    return IGtolinstance.IGtolInstance.GetPTZHeight2(FrameNumber, TolNumber, PtzDisplay, PtzHt);
        //}
        public static Boolean SetPTZHeight2(IGtolObject IGtolinstance, Int32 FrameNumber, Int32 TolNumber, Boolean PtzDisplay, String PtzHt)
        {
            return IGtolinstance.IGtolInstance.SetPTZHeight2(FrameNumber, TolNumber, PtzDisplay, PtzHt);
        }
        public static void SetAllAroundThisSide(IGtolObject IGtolinstance, Boolean AllAroundTS)
        {
            IGtolinstance.IGtolInstance.SetAllAroundThisSide(AllAroundTS);
        }
        public static Boolean GetAllAroundThisSide(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetAllAroundThisSide();
        }
        public static void SetAllOverThisSide(IGtolObject IGtolinstance, Boolean AllOverTS)
        {
            IGtolinstance.IGtolInstance.SetAllOverThisSide(AllOverTS);
        }
        public static Boolean GetAllOverThisSide(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetAllOverThisSide();
        }
        public static String GetText(IGtolObject IGtolinstance, Int32 WhichText)
        {
            return IGtolinstance.IGtolInstance.GetText(WhichText);
        }
        public static String GetBelowFrameTextAt(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.GetBelowFrameTextAt(Index);
        }
        public static Int32 GetBelowFrameTextLineCount(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetBelowFrameTextLineCount();
        }
        public static Boolean DeleteBelowFrameTextAt(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.DeleteBelowFrameTextAt(Index);
        }
        public static Boolean InsertBelowFrameTextAt(IGtolObject IGtolinstance, Int32 Index, String Text)
        {
            return IGtolinstance.IGtolInstance.InsertBelowFrameTextAt(Index, Text);
        }
        public static Boolean SetBelowFrameTextAt(IGtolObject IGtolinstance, Int32 Index, String Text, Boolean Overwrite)
        {
            return IGtolinstance.IGtolInstance.SetBelowFrameTextAt(Index, Text, Overwrite);
        }
        public static void SetFrameValues(IGtolObject IGtolinstance, Int16 FrameNumber, String Tol1, String Tol2, String Datum1, String Datum2, String Datum3)
        {
            IGtolinstance.IGtolInstance.SetFrameValues(FrameNumber, Tol1, Tol2, Datum1, Datum2, Datum3);
        }
        public static void SetFrameSymbols(IGtolObject IGtolinstance, Int16 FrameNumber, Int16 GCS, Boolean TolDia1, Int16 TolMC1, Boolean TolDia2, Int16 TolMC2, Int16 DatumMC1, Int16 DatumMC2, Int16 DatumMC3)
        {
            IGtolinstance.IGtolInstance.SetFrameSymbols(FrameNumber, GCS, TolDia1, TolMC1, TolDia2, TolMC2, DatumMC1, DatumMC2, DatumMC3);
        }
        public static void SetPTZHeight(IGtolObject IGtolinstance, String PtzHt, Boolean DisplayIn)
        {
            IGtolinstance.IGtolInstance.SetPTZHeight(PtzHt, DisplayIn);
        }
        public static void SetDatumIdentifier(IGtolObject IGtolinstance, String DatumIdentifier)
        {
            IGtolinstance.IGtolInstance.SetDatumIdentifier(DatumIdentifier);
        }
        public static Object GetNextGTOL(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetNextGTOL();
        }
        public static IGtolObject IGetNextGTOL(IGtolObject IGtolinstance)
        {
            return new IGtolObject(IGtolinstance.IGtolInstance.IGetNextGTOL());
        }
        public static Object GetFrameValues(IGtolObject IGtolinstance, Int16 FrameNumber)
        {
            return IGtolinstance.IGtolInstance.GetFrameValues(FrameNumber);
        }
        public static Object GetFrameSymbols(IGtolObject IGtolinstance, Int16 FrameNumber)
        {
            return IGtolinstance.IGtolInstance.GetFrameSymbols(FrameNumber);
        }
        public static String GetPTZHeight(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetPTZHeight();
        }
        public static String GetDatumIdentifier(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetDatumIdentifier();
        }
        public static Double GetHeight(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetHeight();
        }
        public static Object GetAttachPos(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetAttachPos();
        }
        public static Object GetFontInfo(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetFontInfo();
        }
        public static Object GetLeaderInfo(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetLeaderInfo();
        }
        public static Boolean IsAttached(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.IsAttached();
        }
        public static Boolean HasExtraLeader(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.HasExtraLeader();
        }
        public static void Dummy1(IGtolObject IGtolinstance)
        {
            IGtolinstance.IGtolInstance.Dummy1();
        }
        public static void Dummy2(IGtolObject IGtolinstance)
        {
            IGtolinstance.IGtolInstance.Dummy2();
        }
        public static Object GetTextPoint(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetTextPoint();
        }
        public static Object GetArrowHeadInfo(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetArrowHeadInfo();
        }
        public static Double IGetAttachPos(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.IGetAttachPos();
        }
        public static Double IGetFontInfo(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.IGetFontInfo();
        }
        //public static Double IGetLeaderInfo(IGtolObject IGtolinstance, Int32& PointCount)
        //{
        //    return IGtolinstance.IGtolInstance.IGetLeaderInfo(PointCount);
        //}
        public static void Dummy3(IGtolObject IGtolinstance)
        {
            IGtolinstance.IGtolInstance.Dummy3();
        }
        public static Double IGetTextPoint(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.IGetTextPoint();
        }
        public static Double IGetArrowHeadInfo(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.IGetArrowHeadInfo();
        }
        public static String GetSymName(IGtolObject IGtolinstance, Int16 SymIdx)
        {
            return IGtolinstance.IGtolInstance.GetSymName(SymIdx);
        }
        public static String GetSymDesc(IGtolObject IGtolinstance, Int16 SymIdx)
        {
            return IGtolinstance.IGtolInstance.GetSymDesc(SymIdx);
        }
        public static Object GetSymText(IGtolObject IGtolinstance, Int16 SymIdx)
        {
            return IGtolinstance.IGtolInstance.GetSymText(SymIdx);
        }
        public static Object GetSymEdgeCounts(IGtolObject IGtolinstance, Int16 SymIdx)
        {
            return IGtolinstance.IGtolInstance.GetSymEdgeCounts(SymIdx);
        }
        public static Object GetSymLines(IGtolObject IGtolinstance, Int16 SymIdx)
        {
            return IGtolinstance.IGtolInstance.GetSymLines(SymIdx);
        }
        public static Object GetSymArcs(IGtolObject IGtolinstance, Int16 SymIdx)
        {
            return IGtolinstance.IGtolInstance.GetSymArcs(SymIdx);
        }
        public static Object GetSymCircles(IGtolObject IGtolinstance, Int16 SymIdx)
        {
            return IGtolinstance.IGtolInstance.GetSymCircles(SymIdx);
        }
        public static Object GetSymTextPoints(IGtolObject IGtolinstance, Int16 SymIdx)
        {
            return IGtolinstance.IGtolInstance.GetSymTextPoints(SymIdx);
        }
        public static Int16 IGetSymEdgeCounts(IGtolObject IGtolinstance, Int16 SymIdx)
        {
            return IGtolinstance.IGtolInstance.IGetSymEdgeCounts(SymIdx);
        }
        public static Double IGetSymLines(IGtolObject IGtolinstance, Int16 SymIdx)
        {
            return IGtolinstance.IGtolInstance.IGetSymLines(SymIdx);
        }
        public static Double IGetSymArcs(IGtolObject IGtolinstance, Int16 SymIdx)
        {
            return IGtolinstance.IGtolInstance.IGetSymArcs(SymIdx);
        }
        public static Double IGetSymCircles(IGtolObject IGtolinstance, Int16 SymIdx)
        {
            return IGtolinstance.IGtolInstance.IGetSymCircles(SymIdx);
        }
        public static Double IGetSymTextPoints(IGtolObject IGtolinstance, Int16 SymIdx)
        {
            return IGtolinstance.IGtolInstance.IGetSymTextPoints(SymIdx);
        }
        public static Int32 GetTextCount(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetTextCount();
        }
        public static String GetTextAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.GetTextAtIndex(Index);
        }
        public static Double GetTextHeightAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.GetTextHeightAtIndex(Index);
        }
        public static Object GetTextPositionAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.GetTextPositionAtIndex(Index);
        }
        public static Double IGetTextPositionAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.IGetTextPositionAtIndex(Index);
        }
        public static Double GetTextAngleAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.GetTextAngleAtIndex(Index);
        }
        public static Int32 GetTextRefPositionAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.GetTextRefPositionAtIndex(Index);
        }
        public static Int32 GetTextInvertAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.GetTextInvertAtIndex(Index);
        }
        public static Int32 GetLineCount(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetLineCount();
        }
        public static Object GetLineAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.GetLineAtIndex(Index);
        }
        public static Double IGetLineAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.IGetLineAtIndex(Index);
        }
        public static Int32 GetArcCount(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetArcCount();
        }
        public static Object GetArcAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.GetArcAtIndex(Index);
        }
        public static Double IGetArcAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.IGetArcAtIndex(Index);
        }
        public static Int32 GetArrowHeadCount(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetArrowHeadCount();
        }
        public static Object GetArrowHeadAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.GetArrowHeadAtIndex(Index);
        }
        public static Double IGetArrowHeadAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.IGetArrowHeadAtIndex(Index);
        }
        public static Int32 GetTriangleCount(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetTriangleCount();
        }
        public static Object GetTriangleAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.GetTriangleAtIndex(Index);
        }
        public static Double IGetTriangleAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.IGetTriangleAtIndex(Index);
        }
        public static String IGetFrameValues(IGtolObject IGtolinstance, Int16 FrameNumber)
        {
            return IGtolinstance.IGtolInstance.IGetFrameValues(FrameNumber);
        }
        public static Int16 IGetFrameSymbols(IGtolObject IGtolinstance, Int16 FrameNumber)
        {
            return IGtolinstance.IGtolInstance.IGetFrameSymbols(FrameNumber);
        }
        public static String IGetSymText(IGtolObject IGtolinstance, Int16 SymIdx)
        {
            return IGtolinstance.IGtolInstance.IGetSymText(SymIdx);
        }
        public static void SetFrameSymbols2(IGtolObject IGtolinstance, Int16 FrameNumber, String GCS, Boolean TolDia1, String TolMC1, Boolean TolDia2, String TolMC2, String DatumMC1, String DatumMC2, String DatumMC3)
        {
            IGtolinstance.IGtolInstance.SetFrameSymbols2(FrameNumber, GCS, TolDia1, TolMC1, TolDia2, TolMC2, DatumMC1, DatumMC2, DatumMC3);
        }
        public static String GetTextFont(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetTextFont();
        }
        public static Int32 GetLeaderCount(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetLeaderCount();
        }
        public static Object GetLeaderAtIndex(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.GetLeaderAtIndex(Index);
        }
        //public static Double IGetLeaderAtIndex(IGtolObject IGtolinstance, Int32 Index, Int32& PointCount)
        //{
        //    return IGtolinstance.IGtolInstance.IGetLeaderAtIndex(Index, PointCount);
        //}
        public static void SetPosition(IGtolObject IGtolinstance, Double X, Double Y, Double Z)
        {
            IGtolinstance.IGtolInstance.SetPosition(X, Y, Z);
        }
        public static Boolean GetUseDocTextFormat(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetUseDocTextFormat();
        }
        public static Object GetTextFormat(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetTextFormat();
        }
        public static ITextFormatObject IGetTextFormat(IGtolObject IGtolinstance)
        {
            return new ITextFormatObject(IGtolinstance.IGtolInstance.IGetTextFormat());
        }
        public static Boolean SetTextFormat(IGtolObject IGtolinstance, Int32 TextFormatType, Object TextFormat)
        {
            return IGtolinstance.IGtolInstance.SetTextFormat(TextFormatType, TextFormat);
        }
        public static Boolean ISetTextFormat(IGtolObject IGtolinstance, Int32 TextFormatType, ITextFormatObject TextFormat)
        {
            return IGtolinstance.IGtolInstance.ISetTextFormat(TextFormatType, TextFormat.ITextFormatInstance as TextFormat);
        }
        public static Boolean GetCompositeFrame(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetCompositeFrame();
        }
        public static void SetCompositeFrame(IGtolObject IGtolinstance, Boolean Composite)
        {
            IGtolinstance.IGtolInstance.SetCompositeFrame(Composite);
        }
        public static Boolean GetBetweenTwoPoints(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetBetweenTwoPoints();
        }
        public static String GetBetweenTwoPointsText(IGtolObject IGtolinstance, Int32 Index)
        {
            return IGtolinstance.IGtolInstance.GetBetweenTwoPointsText(Index);
        }
        public static void SetBetweenTwoPoints(IGtolObject IGtolinstance, Boolean Between, String TextFrom, String TextTo)
        {
            IGtolinstance.IGtolInstance.SetBetweenTwoPoints(Between, TextFrom, TextTo);
        }
        public static Boolean GetAllAround(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetAllAround();
        }
        public static Int32 GetLeaderSide(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetLeaderSide();
        }
        public static void SetLeader(IGtolObject IGtolinstance, Boolean Leader, Int32 LeaderSide, Boolean BentLeader, Boolean AllAround)
        {
            IGtolinstance.IGtolInstance.SetLeader(Leader, LeaderSide, BentLeader, AllAround);
        }
        public static Object GetAnnotation(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.GetAnnotation();
        }
        public static IAnnotationObject IGetAnnotation(IGtolObject IGtolinstance)
        {
            return new IAnnotationObject(IGtolinstance.IGtolInstance.IGetAnnotation());
        }
        public static Object GetFrameSymbols2(IGtolObject IGtolinstance, Int16 FrameNumber)
        {
            return IGtolinstance.IGtolInstance.GetFrameSymbols2(FrameNumber);
        }
        public static String IGetFrameSymbols2(IGtolObject IGtolinstance, Int16 FrameNumber)
        {
            return IGtolinstance.IGtolInstance.IGetFrameSymbols2(FrameNumber);
        }
        public static Double Angle(IGtolObject IGtolinstance)
        {
            return IGtolinstance.IGtolInstance.Angle;
        }
    }
}