using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchSplineObject
    {
        public ISketchSpline ISketchSplineInstance { get; set; }
        public ISketchSplineObject(ISketchSpline ISketchSplineinstance)
        {
            ISketchSplineInstance = ISketchSplineinstance;
        }
    }
    public static class ISketchSplineInterface
    {
        public static Int32 GetPointCount(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.GetPointCount();
        }
        public static Object GetPoints(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.GetPoints();
        }
        public static Double IGetPoints(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.IGetPoints();
        }
        public static Object GetPoints2(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.GetPoints2();
        }
        //public static IEnumSketchPointsObject IEnumPoints(ISketchSplineObject ISketchSplineinstance)
        //{
        //    return new IEnumSketchPointsObject(ISketchSplineinstance.ISketchSplineInstance.IEnumPoints());
        //}
        public static ISplineHandleObject AddTangencyControl(ISketchSplineObject ISketchSplineinstance, Double XPos, Double YPos, Double ZPos)
        {
            return new ISplineHandleObject(ISketchSplineinstance.ISketchSplineInstance.AddTangencyControl(XPos, YPos, ZPos));
        }
        public static ISplineHandleObject AddCurvatureControl(ISketchSplineObject ISketchSplineinstance, Double XPos, Double YPos, Double ZPos)
        {
            return new ISplineHandleObject(ISketchSplineinstance.ISketchSplineInstance.AddCurvatureControl(XPos, YPos, ZPos));
        }
        public static Object GetSplineHandles(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.GetSplineHandles();
        }
        public static ISplineHandleObject IGetSplineHandles(ISketchSplineObject ISketchSplineinstance, Int32 Count)
        {
            return new ISplineHandleObject(ISketchSplineinstance.ISketchSplineInstance.IGetSplineHandles(Count));
        }
        public static void ResetAllHandles(ISketchSplineObject ISketchSplineinstance)
        {
            ISketchSplineinstance.ISketchSplineInstance.ResetAllHandles();
        }
        public static void RelaxSpline(ISketchSplineObject ISketchSplineinstance)
        {
            ISketchSplineinstance.ISketchSplineInstance.RelaxSpline();
        }
        public static void Simplify(ISketchSplineObject ISketchSplineinstance, Double ToleranceIn)
        {
            ISketchSplineinstance.ISketchSplineInstance.Simplify(ToleranceIn);
        }
        public static Int32 GetSplineHandleCount(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.GetSplineHandleCount();
        }
        public static Boolean InsertPoint(ISketchSplineObject ISketchSplineinstance, Double X, Double Y, Double Z)
        {
            return ISketchSplineinstance.ISketchSplineInstance.InsertPoint(X, Y, Z);
        }
        //public static Boolean DeletePoint(ISketchSplineObject ISketchSplineinstance, SketchPointObject Point)
        //{
        //    return ISketchSplineinstance.ISketchSplineInstance.DeletePoint(Point);
        //}
        //public static Boolean GetEquationParameters(ISketchSplineObject ISketchSplineinstance, String& YExpression, Double& RangeStart, Double& RangeEnd, Boolean& IsAngleRange, Double& RotationAngle, Double& XOffset, Double& YOffset, Boolean& LockStart, Boolean& LockEnd)
        //{
        //    return ISketchSplineinstance.ISketchSplineInstance.GetEquationParameters(YExpression, RangeStart, RangeEnd, IsAngleRange, RotationAngle, XOffset, YOffset, LockStart, LockEnd);
        //}
        //public static Boolean SetEquationParameters(ISketchSplineObject ISketchSplineinstance, String YExpression, Double RangeStart, Double RangeEnd, Boolean IsAngleRange, Double RotationAngle, Double XOffset, Double YOffset, Boolean LockStart, Boolean LockEnd)
        //{
        //    return ISketchSplineinstance.ISketchSplineInstance.SetEquationParameters(YExpression, RangeStart, RangeEnd, IsAngleRange, RotationAngle, XOffset, YOffset, LockStart, LockEnd);
        //}
        //public static Boolean GetEquationParameters2(ISketchSplineObject ISketchSplineinstance, String& XExpression, String& YExpression, String& ZExpression, Double& RangeStart, Double& RangeEnd, Boolean& IsAngleRange, Double& RotationAngle, Double& XOffset, Double& YOffset, Boolean& LockStart, Boolean& LockEnd)
        //{
        //    return ISketchSplineinstance.ISketchSplineInstance.GetEquationParameters2(XExpression, YExpression, ZExpression, RangeStart, RangeEnd, IsAngleRange, RotationAngle, XOffset, YOffset, LockStart, LockEnd);
        //}
        public static Boolean SetEquationParameters2(ISketchSplineObject ISketchSplineinstance, String XExpression, String YExpression, String ZExpression, Double RangeStart, Double RangeEnd, Boolean IsAngleRange, Double RotationAngle, Double XOffset, Double YOffset, Boolean LockStart, Boolean LockEnd)
        {
            return ISketchSplineinstance.ISketchSplineInstance.SetEquationParameters2(XExpression, YExpression, ZExpression, RangeStart, RangeEnd, IsAngleRange, RotationAngle, XOffset, YOffset, LockStart, LockEnd);
        }
        public static Boolean ModifyControlPoint(ISketchSplineObject ISketchSplineinstance, Int32 Index, Double X, Double Y, Double Z)
        {
            return ISketchSplineinstance.ISketchSplineInstance.ModifyControlPoint(Index, X, Y, Z);
        }
        public static Boolean ModifyKnot(ISketchSplineObject ISketchSplineinstance, Int32 Index, Double DKnot)
        {
            return ISketchSplineinstance.ISketchSplineInstance.ModifyKnot(Index, DKnot);
        }
        public static Boolean ShowSplineHandles(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.ShowSplineHandles;
        }
        public static Boolean DisplayControlPolygon(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.DisplayControlPolygon;
        }
        public static Boolean ShowInflectionPoints(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.ShowInflectionPoints;
        }
        public static Boolean ShowMinimumRadius(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.ShowMinimumRadius;
        }
        public static Boolean ShowCurvatureCombs(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.ShowCurvatureCombs;
        }
        public static Boolean Proportional(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.Proportional;
        }
        public static Int32 CurveType(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.CurveType;
        }
        public static Int32 CurveDegree(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.CurveDegree;
        }
        public static Boolean IsStyleSpline(ISketchSplineObject ISketchSplineinstance)
        {
            return ISketchSplineinstance.ISketchSplineInstance.IsStyleSpline;
        }
    }
}