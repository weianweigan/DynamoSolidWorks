using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISFSymbolObject
    {
        public ISFSymbol ISFSymbolInstance { get; set; }
        public ISFSymbolObject(ISFSymbol ISFSymbolinstance)
        {
            ISFSymbolInstance = ISFSymbolinstance;
        }
    }
    public static class ISFSymbolInterface
    {
        public static Object GetNext(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetNext();
        }
        public static ISFSymbolObject IGetNext(ISFSymbolObject ISFSymbolinstance)
        {
            return new ISFSymbolObject(ISFSymbolinstance.ISFSymbolInstance.IGetNext());
        }
        public static Int32 GetTextCount(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetTextCount();
        }
        public static String GetTextAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetTextAtIndex(Index);
        }
        public static Double GetTextHeightAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetTextHeightAtIndex(Index);
        }
        public static Object GetTextPositionAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetTextPositionAtIndex(Index);
        }
        public static Double IGetTextPositionAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.IGetTextPositionAtIndex(Index);
        }
        public static Double GetTextAngleAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetTextAngleAtIndex(Index);
        }
        public static Int32 GetLineCount(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetLineCount();
        }
        public static Object GetLineAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetLineAtIndex(Index);
        }
        public static Double IGetLineAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.IGetLineAtIndex(Index);
        }
        public static Int32 GetArcCount(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetArcCount();
        }
        public static Object GetArcAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetArcAtIndex(Index);
        }
        public static Double IGetArcAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.IGetArcAtIndex(Index);
        }
        public static Int32 GetArrowHeadCount(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetArrowHeadCount();
        }
        public static Object GetArrowHeadAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetArrowHeadAtIndex(Index);
        }
        public static Double IGetArrowHeadAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.IGetArrowHeadAtIndex(Index);
        }
        public static Int32 GetTextRefPositionAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetTextRefPositionAtIndex(Index);
        }
        public static Int32 GetTextInvertAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetTextInvertAtIndex(Index);
        }
        public static String GetTextFontAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetTextFontAtIndex(Index);
        }
        public static Int32 GetTriangleCount(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetTriangleCount();
        }
        public static Object GetTriangleAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetTriangleAtIndex(Index);
        }
        public static Double IGetTriangleAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.IGetTriangleAtIndex(Index);
        }
        public static Boolean IsAttached(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.IsAttached();
        }
        public static Boolean HasExtraLeader(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.HasExtraLeader();
        }
        public static Int32 GetLeaderCount(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetLeaderCount();
        }
        public static Object GetLeaderAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetLeaderAtIndex(Index);
        }
        //public static Double IGetLeaderAtIndex(ISFSymbolObject ISFSymbolinstance, Int32 Index, Int32& PointCount)
        //{
        //    return ISFSymbolinstance.ISFSymbolInstance.IGetLeaderAtIndex(Index, PointCount);
        //}
        public static Double IGetArrowHeadInfo(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.IGetArrowHeadInfo();
        }
        public static Object GetArrowHeadInfo(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetArrowHeadInfo();
        }
        public static Object GetAnnotation(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetAnnotation();
        }
        public static IAnnotationObject IGetAnnotation(ISFSymbolObject ISFSymbolinstance)
        {
            return new IAnnotationObject(ISFSymbolinstance.ISFSymbolInstance.IGetAnnotation());
        }
        public static Int32 GetSymbolType(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetSymbolType();
        }
        public static Boolean SetSymbolType(ISFSymbolObject ISFSymbolinstance, Int32 SymbolType)
        {
            return ISFSymbolinstance.ISFSymbolInstance.SetSymbolType(SymbolType);
        }
        public static Int32 GetDirectionOfLay(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetDirectionOfLay();
        }
        public static Boolean SetDirectionOfLay(ISFSymbolObject ISFSymbolinstance, Int32 Direction)
        {
            return ISFSymbolinstance.ISFSymbolInstance.SetDirectionOfLay(Direction);
        }
        public static String GetText(ISFSymbolObject ISFSymbolinstance, Int32 WhichOne)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetText(WhichOne);
        }
        public static Boolean SetText(ISFSymbolObject ISFSymbolinstance, Int32 WhichOne, String Text)
        {
            return ISFSymbolinstance.ISFSymbolInstance.SetText(WhichOne, Text);
        }
        public static Double GetAngle(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetAngle();
        }
        public static Boolean SetAngle(ISFSymbolObject ISFSymbolinstance, Double Angle)
        {
            return ISFSymbolinstance.ISFSymbolInstance.SetAngle(Angle);
        }
        public static Int32 GetSymbol(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetSymbol();
        }
        public static Int32 GetSymbolSurfaceTexture(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetSymbolSurfaceTexture();
        }
        public static Boolean GetSymbolAllAround(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GetSymbolAllAround();
        }
        public static Boolean SetSymbol(ISFSymbolObject ISFSymbolinstance, Int32 Symbol, Int32 SurfaceTexture, Boolean AllAround)
        {
            return ISFSymbolinstance.ISFSymbolInstance.SetSymbol(Symbol, SurfaceTexture, AllAround);
        }
        public static Boolean Rotated(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.Rotated;
        }
        public static Boolean Grinding(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.Grinding;
        }
        public static Int32 Orientation(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.Orientation;
        }
        public static Boolean GOSTNotation(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GOSTNotation;
        }
        public static Boolean GOSTDefaultSymbol(ISFSymbolObject ISFSymbolinstance)
        {
            return ISFSymbolinstance.ISFSymbolInstance.GOSTDefaultSymbol;
        }
    }
}