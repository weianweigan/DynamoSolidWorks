using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDisplayDataObject
    {
        public IDisplayData IDisplayDataInstance { get; set; }
        public IDisplayDataObject(IDisplayData IDisplayDatainstance)
        {
            IDisplayDataInstance = IDisplayDatainstance;
        }
    }
    public static class IDisplayDataInterface
    {
        public static Int32 GetTextCount(IDisplayDataObject IDisplayDatainstance)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetTextCount();
        }
        public static String GetTextAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetTextAtIndex(Index);
        }
        public static Double GetTextHeightAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetTextHeightAtIndex(Index);
        }
        public static Object GetTextPositionAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetTextPositionAtIndex(Index);
        }
        public static Double IGetTextPositionAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetTextPositionAtIndex(Index);
        }
        public static Double GetTextAngleAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetTextAngleAtIndex(Index);
        }
        public static Int32 GetTextRefPositionAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetTextRefPositionAtIndex(Index);
        }
        public static Int32 GetTextInvertAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetTextInvertAtIndex(Index);
        }
        public static String GetTextFontAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetTextFontAtIndex(Index);
        }
        public static Int32 GetLineCount(IDisplayDataObject IDisplayDatainstance)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetLineCount();
        }
        public static Object GetLineAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetLineAtIndex(Index);
        }
        public static Double IGetLineAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetLineAtIndex(Index);
        }
        public static Int32 GetArcCount(IDisplayDataObject IDisplayDatainstance)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetArcCount();
        }
        public static Object GetArcAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetArcAtIndex(Index);
        }
        public static Double IGetArcAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetArcAtIndex(Index);
        }
        public static Int32 GetArrowHeadCount(IDisplayDataObject IDisplayDatainstance)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetArrowHeadCount();
        }
        public static Object GetArrowHeadAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetArrowHeadAtIndex(Index);
        }
        public static Double IGetArrowHeadAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetArrowHeadAtIndex(Index);
        }
        public static Int32 GetTriangleCount(IDisplayDataObject IDisplayDatainstance)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetTriangleCount();
        }
        public static Object GetTriangleAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetTriangleAtIndex(Index);
        }
        public static Double IGetTriangleAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetTriangleAtIndex(Index);
        }
        public static Int32 GetPolyLineCount(IDisplayDataObject IDisplayDatainstance)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetPolyLineCount();
        }
        public static Int32 GetPolylineSizeAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetPolylineSizeAtIndex(Index);
        }
        public static Object GetPolylineAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetPolylineAtIndex(Index);
        }
        public static Double IGetPolylineAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetPolylineAtIndex(Index);
        }
        public static Int32 GetEllipseCount(IDisplayDataObject IDisplayDatainstance)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetEllipseCount();
        }
        public static Object GetEllipseAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetEllipseAtIndex(Index);
        }
        public static Double IGetEllipseAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetEllipseAtIndex(Index);
        }
        public static Double GetTextLineSpacingAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetTextLineSpacingAtIndex(Index);
        }
        public static Object GetLineAtIndex2(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetLineAtIndex2(Index);
        }
        public static Double IGetLineAtIndex2(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetLineAtIndex2(Index);
        }
        public static Object GetArcAtIndex2(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetArcAtIndex2(Index);
        }
        public static Double IGetArcAtIndex2(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetArcAtIndex2(Index);
        }
        public static Int32 GetPolylineSizeAtIndex2(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetPolylineSizeAtIndex2(Index);
        }
        public static Object GetPolylineAtIndex2(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetPolylineAtIndex2(Index);
        }
        public static Double IGetPolylineAtIndex2(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetPolylineAtIndex2(Index);
        }
        public static Object GetEllipseAtIndex2(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetEllipseAtIndex2(Index);
        }
        public static Double IGetEllipseAtIndex2(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetEllipseAtIndex2(Index);
        }
        public static void Dummy1(IDisplayDataObject IDisplayDatainstance)
        {
            IDisplayDatainstance.IDisplayDataInstance.Dummy1();
        }
        public static void Dummy2(IDisplayDataObject IDisplayDatainstance)
        {
            IDisplayDatainstance.IDisplayDataInstance.Dummy2();
        }
        public static void Dummy3(IDisplayDataObject IDisplayDatainstance)
        {
            IDisplayDatainstance.IDisplayDataInstance.Dummy3();
        }
        public static void Dummy4(IDisplayDataObject IDisplayDatainstance)
        {
            IDisplayDatainstance.IDisplayDataInstance.Dummy4();
        }
        public static Int32 GetParabolaCount(IDisplayDataObject IDisplayDatainstance)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetParabolaCount();
        }
        public static Object GetParabolaAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetParabolaAtIndex(Index);
        }
        public static Double IGetParabolaAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetParabolaAtIndex(Index);
        }
        public static Int32 GetPolygonCount(IDisplayDataObject IDisplayDatainstance)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetPolygonCount();
        }
        public static Int32 GetPolygonSizeAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetPolygonSizeAtIndex(Index);
        }
        public static Object GetPolygonAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetPolygonAtIndex(Index);
        }
        public static Double IGetPolygonAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetPolygonAtIndex(Index);
        }
        public static Int32 GetTextInBoxStyleAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetTextInBoxStyleAtIndex(Index);
        }
        public static Double GetTextInBoxWidthAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetTextInBoxWidthAtIndex(Index);
        }
        public static Double GetTextInBoxHeightAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetTextInBoxHeightAtIndex(Index);
        }
        public static Object GetLineAtIndex3(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetLineAtIndex3(Index);
        }
        public static Double IGetLineAtIndex3(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetLineAtIndex3(Index);
        }
        public static Int32 GetPointCount(IDisplayDataObject IDisplayDatainstance)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetPointCount();
        }
        public static Object GetPointAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetPointAtIndex(Index);
        }
        public static Double IGetPointAtIndex(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.IGetPointAtIndex(Index);
        }
        public static Object GetArrowHeadAtIndex2(IDisplayDataObject IDisplayDatainstance, Int32 Index)
        {
            return IDisplayDatainstance.IDisplayDataInstance.GetArrowHeadAtIndex2(Index);
        }
    }
}