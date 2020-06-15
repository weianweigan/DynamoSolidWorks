using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISurfaceObject
    {
        public ISurface ISurfaceInstance { get; set; }
        public ISurfaceObject(ISurface ISurfaceinstance)
        {
            ISurfaceInstance = ISurfaceinstance;
        }
    }
    public static class ISurfaceInterface
    {
        public static Boolean IsPlane(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IsPlane();
        }
        public static Boolean IsCylinder(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IsCylinder();
        }
        public static Boolean IsCone(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IsCone();
        }
        public static Int32 Identity(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.Identity();
        }
        public static Boolean IsSphere(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IsSphere();
        }
        public static Boolean IsTorus(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IsTorus();
        }
        public static Boolean IsParametric(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IsParametric();
        }
        public static Boolean IsBlending(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IsBlending();
        }
        public static Boolean IsOffset(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IsOffset();
        }
        public static Boolean IsSwept(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IsSwept();
        }
        public static Boolean IsRevolved(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IsRevolved();
        }
        public static Boolean IsForeign(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IsForeign();
        }
        public static Object Parameterization(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.Parameterization();
        }
        public static Object Evaluate(ISurfaceObject ISurfaceinstance, Double UParam, Double VParam, Int32 NumUDeriv, Int32 NumVDeriv)
        {
            return ISurfaceinstance.ISurfaceInstance.Evaluate(UParam, VParam, NumUDeriv, NumVDeriv);
        }
        public static Object GetBSurfParams(ISurfaceObject ISurfaceinstance, Boolean WantCubicRational, Object VP0)
        {
            return ISurfaceinstance.ISurfaceInstance.GetBSurfParams(WantCubicRational, VP0);
        }
        public static Boolean AddTrimmingLoop(ISurfaceObject ISurfaceinstance, Int32 NCrvs, Object VOrder, Object VDim, Object VPeriodic, Object VNumKnots, Object VNumCtrlPoints, Object VKnots, Object VCtrlPointDbls)
        {
            return ISurfaceinstance.ISurfaceInstance.AddTrimmingLoop(NCrvs, VOrder, VDim, VPeriodic, VNumKnots, VNumCtrlPoints, VKnots, VCtrlPointDbls);
        }
        public static Object CreateNewCurve(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.CreateNewCurve();
        }
        public static ICurveObject ICreateNewCurve(ISurfaceObject ISurfaceinstance)
        {
            return new ICurveObject(ISurfaceinstance.ISurfaceInstance.ICreateNewCurve());
        }
        public static Object GetRevsurfParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.GetRevsurfParams();
        }
        public static Object GetExtrusionsurfParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.GetExtrusionsurfParams();
        }
        public static Object GetProfileCurve(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.GetProfileCurve();
        }
        public static ICurveObject IGetProfileCurve(ISurfaceObject ISurfaceinstance)
        {
            return new ICurveObject(ISurfaceinstance.ISurfaceInstance.IGetProfileCurve());
        }
        public static Object ReverseEvaluate(ISurfaceObject ISurfaceinstance, Double PositionX, Double PositionY, Double PositionZ)
        {
            return ISurfaceinstance.ISurfaceInstance.ReverseEvaluate(PositionX, PositionY, PositionZ);
        }
        public static Double IReverseEvaluate(ISurfaceObject ISurfaceinstance, Double PositionX, Double PositionY, Double PositionZ)
        {
            return ISurfaceinstance.ISurfaceInstance.IReverseEvaluate(PositionX, PositionY, PositionZ);
        }
        public static Double IGetRevsurfParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IGetRevsurfParams();
        }
        public static Double IGetExtrusionsurfParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IGetExtrusionsurfParams();
        }
        public static Double IParameterization(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IParameterization();
        }
        public static Double IEvaluate(ISurfaceObject ISurfaceinstance, Double UParam, Double VParam, Int32 NumUDeriv, Int32 NumVDeriv)
        {
            return ISurfaceinstance.ISurfaceInstance.IEvaluate(UParam, VParam, NumUDeriv, NumVDeriv);
        }
        public static Double IGetBSurfParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IGetBSurfParams();
        }
        //public static Int32 IGetBSurfParamsSize(ISurfaceObject ISurfaceinstance, Boolean WantCubicRational, Double& Range)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IGetBSurfParamsSize(WantCubicRational, Range);
        //}
        //public static void IAddTrimmingLoop(ISurfaceObject ISurfaceinstance, Int32 CurveCount, Int32& Order, Int32& Dim, Int32& Periodic, Int32& NumKnots, Int32& NumCtrlPoints, Double& Knots, Double& CtrlPointDbls)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IAddTrimmingLoop(CurveCount, Order, Dim, Periodic, NumKnots, NumCtrlPoints, Knots, CtrlPointDbls);
        //}
        //public static Object EvaluateAtPoint(ISurfaceObject ISurfaceinstance, Double PositionX, Double PositionY, Double PositionZ)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.EvaluateAtPoint(PositionX, PositionY, PositionZ);
        //}
        public static Double IEvaluateAtPoint(ISurfaceObject ISurfaceinstance, Double PositionX, Double PositionY, Double PositionZ)
        {
            return ISurfaceinstance.ISurfaceInstance.IEvaluateAtPoint(PositionX, PositionY, PositionZ);
        }
        public static Double GetOffsetSurfParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.GetOffsetSurfParams();
        }
        //public static Int32 IGetBSurfParamsSize2(ISurfaceObject ISurfaceinstance, Boolean WantCubic, Boolean WantNonRational, Double& Range)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IGetBSurfParamsSize2(WantCubic, WantNonRational, Range);
        //}
        public static Object Copy(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.Copy();
        }
        public static ISurfaceObject ICopy(ISurfaceObject ISurfaceinstance)
        {
            return new ISurfaceObject(ISurfaceinstance.ISurfaceInstance.ICopy());
        }
        public static Object CreateTrimmedSheet(ISurfaceObject ISurfaceinstance, Object Curves)
        {
            return ISurfaceinstance.ISurfaceInstance.CreateTrimmedSheet(Curves);
        }
        //public static IBodyObject ICreateTrimmedSheet(ISurfaceObject ISurfaceinstance, Int32 NCurves, Curve&Object Curves)
        //{
        //    return new IBodyObject(ISurfaceinstance.ISurfaceInstance.ICreateTrimmedSheet(NCurves, Curves));
        //}
        public static Boolean AddTrimmingLoop2(ISurfaceObject ISurfaceinstance, Int32 NCrvs, Object VOrder, Object VDim, Object VPeriodic, Object VNumKnots, Object VNumCtrlPoints, Object VKnots, Object VCtrlPointDbls, Object UvRange)
        {
            return ISurfaceinstance.ISurfaceInstance.AddTrimmingLoop2(NCrvs, VOrder, VDim, VPeriodic, VNumKnots, VNumCtrlPoints, VKnots, VCtrlPointDbls, UvRange);
        }
        //public static void IAddTrimmingLoop2(ISurfaceObject ISurfaceinstance, Int32 CurveCount, Int32& Order, Int32& Dim, Int32& Periodic, Int32& NumKnots, Int32& NumCtrlPoints, Double& Knots, Double& CtrlPointDbls, Double& UvRange)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IAddTrimmingLoop2(CurveCount, Order, Dim, Periodic, NumKnots, NumCtrlPoints, Knots, CtrlPointDbls, UvRange);
        //}
        //public static Object GetBSurfParams2(ISurfaceObject ISurfaceinstance, Boolean WantCubic, Boolean WantNonRational, Object VP0, Double Tolerance, Boolean& Sense)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.GetBSurfParams2(WantCubic, WantNonRational, VP0, Tolerance, Sense);
        //}
        //public static Int32 IGetBSurfParamsSize3(ISurfaceObject ISurfaceinstance, Boolean WantCubic, Boolean WantNonRational, Double& Range, Double Tolerance, Boolean& Sense)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IGetBSurfParamsSize3(WantCubic, WantNonRational, Range, Tolerance, Sense);
        //}
        public static Object GetClosestPointOn(ISurfaceObject ISurfaceinstance, Double X, Double Y, Double Z)
        {
            return ISurfaceinstance.ISurfaceInstance.GetClosestPointOn(X, Y, Z);
        }
        public static Double IGetClosestPointOn(ISurfaceObject ISurfaceinstance, Double X, Double Y, Double Z)
        {
            return ISurfaceinstance.ISurfaceInstance.IGetClosestPointOn(X, Y, Z);
        }
        //public static Double GetOffsetSurfParams2(ISurfaceObject ISurfaceinstance, Object& BaseSurf, Boolean& Sense)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.GetOffsetSurfParams2(BaseSurf, Sense);
        //}
        //public static Double IGetOffsetSurfParams2(ISurfaceObject ISurfaceinstance, Surface&Object BaseSurf, Boolean& Sense)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IGetOffsetSurfParams2(BaseSurf, Sense);
        //}
        //public static Int32 GetIntersectSurfaceCount(ISurfaceObject ISurfaceinstance, SurfaceObject OtherSurface)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.GetIntersectSurfaceCount(OtherSurface);
        //}
        //public static Boolean IIntersectSurface(ISurfaceObject ISurfaceinstance, SurfaceObject OtherSurf, Int32 CurveCount, Curve&Object CurveArray, Double& BoundsArray)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IIntersectSurface(OtherSurf, CurveCount, CurveArray, BoundsArray);
        //}
        //public static Boolean IntersectSurface(ISurfaceObject ISurfaceinstance, Object OtherSurf, Object& CurveArray, Object& BoundsArray)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IntersectSurface(OtherSurf, CurveArray, BoundsArray);
        //}
        //public static Int32 GetIntersectCurveCount(ISurfaceObject ISurfaceinstance, CurveObject OtherCurve, Double& CurveBound)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.GetIntersectCurveCount(OtherCurve, CurveBound);
        //}
        //public static Boolean IIntersectCurve(ISurfaceObject ISurfaceinstance, CurveObject OtherCurve, Double& CurveBound, Int32 PointCount, Double& PointArray, Double& TArray, Double& UvArray)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IIntersectCurve(OtherCurve, CurveBound, PointCount, PointArray, TArray, UvArray);
        //}
        //public static Boolean IntersectCurve(ISurfaceObject ISurfaceinstance, Object OtherCurve, Object CurveBound, Object& PointArray, Object& TArray, Object& UvArray)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IntersectCurve(OtherCurve, CurveBound, PointArray, TArray, UvArray);
        //}
        public static Object MakeIsoCurve(ISurfaceObject ISurfaceinstance, Boolean UorV, Double UvValue)
        {
            return ISurfaceinstance.ISurfaceInstance.MakeIsoCurve(UorV, UvValue);
        }
        public static ICurveObject IMakeIsoCurve(ISurfaceObject ISurfaceinstance, Boolean UorV, Double UvValue)
        {
            return new ICurveObject(ISurfaceinstance.ISurfaceInstance.IMakeIsoCurve(UorV, UvValue));
        }
        //public static IBody2Object ICreateTrimmedSheet2(ISurfaceObject ISurfaceinstance, Int32 NCurves, Curve&Object Curves)
        //{
        //    return new IBody2Object(ISurfaceinstance.ISurfaceInstance.ICreateTrimmedSheet2(NCurves, Curves));
        //}
        //public static Boolean MakeIsoCurves(ISurfaceObject ISurfaceinstance, Object UvRange, Object Dir, Double Angle, Double Tol, Object& Curves, Object& CurveBounds)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.MakeIsoCurves(UvRange, Dir, Angle, Tol, Curves, CurveBounds);
        //}
        //public static Int32 IGetMakeIsoCurvesCount(ISurfaceObject ISurfaceinstance, Double& UvRange, Double& Dir, Double Angle, Double Tol)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IGetMakeIsoCurvesCount(UvRange, Dir, Angle, Tol);
        //}
        //public static Boolean IMakeIsoCurves(ISurfaceObject ISurfaceinstance, Double& UvRange, Double& Dir, Double Angle, Double Tol, Int32 CurveCount, Curve&Object Curves, Double& CurveBounds)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IMakeIsoCurves(UvRange, Dir, Angle, Tol, CurveCount, Curves, CurveBounds);
        //}
        //public static Int32 GetIntersectCurveCount2(ISurfaceObject ISurfaceinstance, CurveObject OtherCurve, Double& CurveBound)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.GetIntersectCurveCount2(OtherCurve, CurveBound);
        //}
        //public static Boolean IIntersectCurve2(ISurfaceObject ISurfaceinstance, CurveObject OtherCurve, Double& CurveBound, Int32 PointCount, Double& PointArray, Double& TArray, Double& UvArray)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IIntersectCurve2(OtherCurve, CurveBound, PointCount, PointArray, TArray, UvArray);
        //}
        //public static Boolean IntersectCurve2(ISurfaceObject ISurfaceinstance, Object OtherCurve, Object CurveBound, Object& PointArray, Object& TArray, Object& UvArray)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IntersectCurve2(OtherCurve, CurveBound, PointArray, TArray, UvArray);
        //}
        //public static IBody2Object ICreateTrimmedSheet3(ISurfaceObject ISurfaceinstance, Int32 NCurves, Curve&Object Curves)
        //{
        //    return new IBody2Object(ISurfaceinstance.ISurfaceInstance.ICreateTrimmedSheet3(NCurves, Curves));
        //}
        //public static IMathPointObject GetProjectedPointOn(ISurfaceObject ISurfaceinstance, MathPointObject Point, MathVectorObject Direction)
        //{
        //    return new IMathPointObject(ISurfaceinstance.ISurfaceInstance.GetProjectedPointOn(Point, Direction));
        //}
        public static Object CreateTrimmedSheet4(ISurfaceObject ISurfaceinstance, Object Curves, Boolean PreserveAnalyticCurves)
        {
            return ISurfaceinstance.ISurfaceInstance.CreateTrimmedSheet4(Curves, PreserveAnalyticCurves);
        }
        //public static IBodyObject ICreateTrimmedSheet4(ISurfaceObject ISurfaceinstance, Int32 NCurves, Curve&Object Curves, Boolean PreserveAnalyticCurves)
        //{
        //    return new IBodyObject(ISurfaceinstance.ISurfaceInstance.ICreateTrimmedSheet4(NCurves, Curves, PreserveAnalyticCurves));
        //}
        //public static Boolean FindMinimumRadius(ISurfaceObject ISurfaceinstance, Object UBound, Object VBound, Int32& NumOfRadius, Object& Radius, Object& Location, Object& UVParameter)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.FindMinimumRadius(UBound, VBound, NumOfRadius, Radius, Location, UVParameter);
        //}
        //public static Boolean IFindMinimumRadius(ISurfaceObject ISurfaceinstance, Double& UBound, Double& VBound, Int32& NumOfRadius, Object& Radius, Object& Location, Object& UVParameter)
        //{
        //    return ISurfaceinstance.ISurfaceInstance.IFindMinimumRadius(UBound, VBound, NumOfRadius, Radius, Location, UVParameter);
        //}
        //public static IBSurfParamDataObject GetBSurfParams3(ISurfaceObject ISurfaceinstance, Boolean WantCubic, Boolean WantNonRational, Object VP0, Double Tolerance, Boolean& Sense)
        //{
        //    return new IBSurfParamDataObject(ISurfaceinstance.ISurfaceInstance.GetBSurfParams3(WantCubic, WantNonRational, VP0, Tolerance, Sense));
        //}
        //public static ISurfaceParameterizationDataObject Parameterization2(ISurfaceObject ISurfaceinstance)
        //{
        //    return new ISurfaceParameterizationDataObject(ISurfaceinstance.ISurfaceInstance.Parameterization2());
        //}
        //public static ICurveObject MakeIsoCurve2(ISurfaceObject ISurfaceinstance, Boolean UorV, Double& UvValue)
        //{
        //    return new ICurveObject(ISurfaceinstance.ISurfaceInstance.MakeIsoCurve2(UorV, UvValue));
        //}
        public static Object CreateTrimmedSheet5(ISurfaceObject ISurfaceinstance, Object Curves, Boolean PreserveAnalyticCurves, Double Tolerance)
        {
            return ISurfaceinstance.ISurfaceInstance.CreateTrimmedSheet5(Curves, PreserveAnalyticCurves, Tolerance);
        }
        public static Object PlaneParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.PlaneParams;
        }
        public static Object CylinderParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.CylinderParams;
        }
        public static Object ConeParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.ConeParams;
        }
        public static Object SphereParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.SphereParams;
        }
        public static Object TorusParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.TorusParams;
        }
        public static Double IPlaneParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IPlaneParams;
        }
        public static Double ICylinderParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.ICylinderParams;
        }
        public static Double IConeParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.IConeParams;
        }
        public static Double ISphereParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.ISphereParams;
        }
        public static Double ITorusParams(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.ITorusParams;
        }
        public static Object ConeParams2(ISurfaceObject ISurfaceinstance)
        {
            return ISurfaceinstance.ISurfaceInstance.ConeParams2;
        }
    }
}