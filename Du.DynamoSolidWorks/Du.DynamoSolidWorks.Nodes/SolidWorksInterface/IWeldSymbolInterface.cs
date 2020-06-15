using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IWeldSymbolObject
    {
        public IWeldSymbol IWeldSymbolInstance { get; set; }
        public IWeldSymbolObject(IWeldSymbol IWeldSymbolinstance)
        {
            IWeldSymbolInstance = IWeldSymbolinstance;
        }
    }
    public static class IWeldSymbolInterface
    {
        public static Object GetNext(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetNext();
        }
        public static IWeldSymbolObject IGetNext(IWeldSymbolObject IWeldSymbolinstance)
        {
            return new IWeldSymbolObject(IWeldSymbolinstance.IWeldSymbolInstance.IGetNext());
        }
        public static Int32 GetTextCount(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetTextCount();
        }
        public static String GetTextAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetTextAtIndex(Index);
        }
        public static Double GetTextHeightAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetTextHeightAtIndex(Index);
        }
        public static Object GetTextPositionAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetTextPositionAtIndex(Index);
        }
        public static Double IGetTextPositionAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.IGetTextPositionAtIndex(Index);
        }
        public static Double GetTextAngleAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetTextAngleAtIndex(Index);
        }
        public static Int32 GetTextRefPositionAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetTextRefPositionAtIndex(Index);
        }
        public static Int32 GetTextInvertAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetTextInvertAtIndex(Index);
        }
        public static Int32 GetLineCount(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetLineCount();
        }
        public static Object GetLineAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetLineAtIndex(Index);
        }
        public static Double IGetLineAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.IGetLineAtIndex(Index);
        }
        public static Int32 GetArcCount(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetArcCount();
        }
        public static Object GetArcAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetArcAtIndex(Index);
        }
        public static Double IGetArcAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.IGetArcAtIndex(Index);
        }
        public static Int32 GetArrowHeadCount(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetArrowHeadCount();
        }
        public static Object GetArrowHeadAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetArrowHeadAtIndex(Index);
        }
        public static Double IGetArrowHeadAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.IGetArrowHeadAtIndex(Index);
        }
        public static Int32 GetTriangleCount(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetTriangleCount();
        }
        public static Object GetTriangleAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetTriangleAtIndex(Index);
        }
        public static Double IGetTriangleAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.IGetTriangleAtIndex(Index);
        }
        public static Boolean IsAttached(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.IsAttached();
        }
        public static Boolean HasExtraLeader(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.HasExtraLeader();
        }
        public static Int32 GetLeaderCount(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetLeaderCount();
        }
        public static Object GetLeaderAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetLeaderAtIndex(Index);
        }
        //public static Double IGetLeaderAtIndex(IWeldSymbolObject IWeldSymbolinstance, Int32 Index, Int32& PointCount)
        //{
        //    return IWeldSymbolinstance.IWeldSymbolInstance.IGetLeaderAtIndex(Index, PointCount);
        //}
        public static Double IGetArrowHeadInfo(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.IGetArrowHeadInfo();
        }
        public static Object GetArrowHeadInfo(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetArrowHeadInfo();
        }
        public static Object GetAnnotation(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetAnnotation();
        }
        public static IAnnotationObject IGetAnnotation(IWeldSymbolObject IWeldSymbolinstance)
        {
            return new IAnnotationObject(IWeldSymbolinstance.IWeldSymbolInstance.IGetAnnotation());
        }
        public static String GetText(IWeldSymbolObject IWeldSymbolinstance, Int32 WhichText)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetText(WhichText);
        }
        public static Int32 GetContour(IWeldSymbolObject IWeldSymbolinstance, Boolean Top)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetContour(Top);
        }
        public static Int32 GetSymmetric(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetSymmetric();
        }
        public static Boolean GetPeripheral(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetPeripheral();
        }
        public static Int32 GetFieldWeld(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetFieldWeld();
        }
        public static Boolean GetProcess(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetProcess();
        }
        public static Boolean GetProcessReference(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetProcessReference();
        }
        public static Boolean GetStagger(IWeldSymbolObject IWeldSymbolinstance)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.GetStagger();
        }
        public static Boolean SetText(IWeldSymbolObject IWeldSymbolinstance, Boolean Top, String Left, String Symbol, String Right, String Stagger, Int32 Contour)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.SetText(Top, Left, Symbol, Right, Stagger, Contour);
        }
        public static Boolean SetSymmetric(IWeldSymbolObject IWeldSymbolinstance, Int32 Symmetric)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.SetSymmetric(Symmetric);
        }
        public static Boolean SetPeripheral(IWeldSymbolObject IWeldSymbolinstance, Boolean Peripheral)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.SetPeripheral(Peripheral);
        }
        public static Boolean SetFieldWeld(IWeldSymbolObject IWeldSymbolinstance, Int32 FieldWeld)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.SetFieldWeld(FieldWeld);
        }
        public static Boolean SetProcess(IWeldSymbolObject IWeldSymbolinstance, Boolean Process, String Text, Boolean Reference)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.SetProcess(Process, Text, Reference);
        }
        public static Boolean SetStagger(IWeldSymbolObject IWeldSymbolinstance, Boolean Stagger)
        {
            return IWeldSymbolinstance.IWeldSymbolInstance.SetStagger(Stagger);
        }
    }
}