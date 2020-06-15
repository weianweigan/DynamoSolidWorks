using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDatumTargetSymObject
    {
        public IDatumTargetSym IDatumTargetSymInstance { get; set; }
        public IDatumTargetSymObject(IDatumTargetSym IDatumTargetSyminstance)
        {
            IDatumTargetSymInstance = IDatumTargetSyminstance;
        }
    }
    public static class IDatumTargetSymInterface
    {
        public static Object GetNext(IDatumTargetSymObject IDatumTargetSyminstance)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetNext();
        }
        public static IDatumTargetSymObject IGetNext(IDatumTargetSymObject IDatumTargetSyminstance)
        {
            return new IDatumTargetSymObject(IDatumTargetSyminstance.IDatumTargetSymInstance.IGetNext());
        }
        public static Int32 GetTextCount(IDatumTargetSymObject IDatumTargetSyminstance)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetTextCount();
        }
        public static String GetTextAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetTextAtIndex(Index);
        }
        public static Double GetTextHeightAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetTextHeightAtIndex(Index);
        }
        public static Object GetTextPositionAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetTextPositionAtIndex(Index);
        }
        public static Double IGetTextPositionAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.IGetTextPositionAtIndex(Index);
        }
        public static Double GetTextAngleAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetTextAngleAtIndex(Index);
        }
        public static Int32 GetTextRefPositionAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetTextRefPositionAtIndex(Index);
        }
        public static Int32 GetTextInvertAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetTextInvertAtIndex(Index);
        }
        public static Int32 GetLineCount(IDatumTargetSymObject IDatumTargetSyminstance)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetLineCount();
        }
        public static Object GetLineAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetLineAtIndex(Index);
        }
        public static Double IGetLineAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.IGetLineAtIndex(Index);
        }
        public static Int32 GetArcCount(IDatumTargetSymObject IDatumTargetSyminstance)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetArcCount();
        }
        public static Object GetArcAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetArcAtIndex(Index);
        }
        public static Double IGetArcAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.IGetArcAtIndex(Index);
        }
        public static Int32 GetArrowHeadCount(IDatumTargetSymObject IDatumTargetSyminstance)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetArrowHeadCount();
        }
        public static Object GetArrowHeadAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetArrowHeadAtIndex(Index);
        }
        public static Double IGetArrowHeadAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.IGetArrowHeadAtIndex(Index);
        }
        public static Int32 GetTriangleCount(IDatumTargetSymObject IDatumTargetSyminstance)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetTriangleCount();
        }
        public static Object GetTriangleAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetTriangleAtIndex(Index);
        }
        public static Double IGetTriangleAtIndex(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Index)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.IGetTriangleAtIndex(Index);
        }
        public static Object GetAnnotation(IDatumTargetSymObject IDatumTargetSyminstance)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetAnnotation();
        }
        public static IAnnotationObject IGetAnnotation(IDatumTargetSymObject IDatumTargetSyminstance)
        {
            return new IAnnotationObject(IDatumTargetSyminstance.IDatumTargetSymInstance.IGetAnnotation());
        }
        public static Int32 GetTargetShape(IDatumTargetSymObject IDatumTargetSyminstance)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetTargetShape();
        }
        public static String GetTargetAreaSize(IDatumTargetSymObject IDatumTargetSyminstance, Int32 WhichOne)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetTargetAreaSize(WhichOne);
        }
        public static Boolean SetTargetArea(IDatumTargetSymObject IDatumTargetSyminstance, Int32 Shape, String Size1, String Size2)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.SetTargetArea(Shape, Size1, Size2);
        }
        public static Boolean GetDisplaySymbol(IDatumTargetSymObject IDatumTargetSyminstance)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetDisplaySymbol();
        }
        public static Boolean GetDisplayTargetArea(IDatumTargetSymObject IDatumTargetSyminstance)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetDisplayTargetArea();
        }
        public static Boolean GetDisplaySizeOutside(IDatumTargetSymObject IDatumTargetSyminstance)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetDisplaySizeOutside();
        }
        public static Boolean SetDisplay(IDatumTargetSymObject IDatumTargetSyminstance, Boolean Symbol, Boolean TargetArea, Boolean SizeOutside)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.SetDisplay(Symbol, TargetArea, SizeOutside);
        }
        public static String GetDatumReferenceLabel(IDatumTargetSymObject IDatumTargetSyminstance, Int32 WhichOne)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.GetDatumReferenceLabel(WhichOne);
        }
        public static Boolean SetDatumReferenceLabel(IDatumTargetSymObject IDatumTargetSyminstance, Int32 WhichOne, String Text)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.SetDatumReferenceLabel(WhichOne, Text);
        }
        public static Boolean SetDatumTargetHorizontal(IDatumTargetSymObject IDatumTargetSyminstance, Int32 MoveableDatumDirection, Boolean LockLeader, Double LockLeaderAngle)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.SetDatumTargetHorizontal(MoveableDatumDirection, LockLeader, LockLeaderAngle);
        }
        //public static Boolean SetDatumTargetRotational(IDatumTargetSymObject IDatumTargetSyminstance, Int32 MoveableDatumDirection, Boolean LockLeader, Double LockLeaderAngle, Boolean GeometryRef, Int32& RefGeometryError)
        //{
        //    return IDatumTargetSyminstance.IDatumTargetSymInstance.SetDatumTargetRotational(MoveableDatumDirection, LockLeader, LockLeaderAngle, GeometryRef, RefGeometryError);
        //}
        public static Boolean SetDatumTargetNotMoveable(IDatumTargetSymObject IDatumTargetSyminstance)
        {
            return IDatumTargetSyminstance.IDatumTargetSymInstance.SetDatumTargetNotMoveable();
        }
    }
}