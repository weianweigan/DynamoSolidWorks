using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICurveObject
    {
        public ICurve ICurveInstance { get; set; }
        public ICurveObject(ICurve ICurveinstance)
        {
            ICurveInstance = ICurveinstance;
        }
    }
    public static class ICurveInterface
    {
        public static Int32 Identity(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.Identity();
        }
        public static Boolean IsCircle(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.IsCircle();
        }
        public static Boolean IsLine(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.IsLine();
        }
        public static Boolean IsBcurve(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.IsBcurve();
        }
        public static Object GetBCurveParams(ICurveObject ICurveinstance, Boolean WantCubicIn)
        {
            return ICurveinstance.ICurveInstance.GetBCurveParams(WantCubicIn);
        }
        public static Object ConvertLineToBcurve(ICurveObject ICurveinstance, Object StartPoint, Object EndPoint)
        {
            return ICurveinstance.ICurveInstance.ConvertLineToBcurve(StartPoint, EndPoint);
        }
        public static Object ConvertArcToBcurve(ICurveObject ICurveinstance, Object Center, Object Axis, Object Start, Object End)
        {
            return ICurveinstance.ICurveInstance.ConvertArcToBcurve(Center, Axis, Start, End);
        }
        public static Object ReverseCurve(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.ReverseCurve();
        }
        public static ICurveObject IReverseCurve(ICurveObject ICurveinstance)
        {
            return new ICurveObject(ICurveinstance.ICurveInstance.IReverseCurve());
        }
        public static Object GetPCurveParams(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.GetPCurveParams();
        }
        public static Double IGetBCurveParams(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.IGetBCurveParams();
        }
        public static Int32 IGetBCurveParamsSize(ICurveObject ICurveinstance, Boolean WantCubicIn)
        {
            return ICurveinstance.ICurveInstance.IGetBCurveParamsSize(WantCubicIn);
        }
        //public static Int32 IConvertLineToBcurveSize(ICurveObject ICurveinstance, Double& StartPoint, Double& EndPoint)
        //{
        //    return ICurveinstance.ICurveInstance.IConvertLineToBcurveSize(StartPoint, EndPoint);
        //}
        //public static Int32 IConvertArcToBcurveSize(ICurveObject ICurveinstance, Double& Center, Double& Axis, Double& Start, Double& End)
        //{
        //    return ICurveinstance.ICurveInstance.IConvertArcToBcurveSize(Center, Axis, Start, End);
        //}
        public static Double IGetPCurveParams(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.IGetPCurveParams();
        }
        public static Int32 IGetPCurveParamsSize(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.IGetPCurveParamsSize();
        }
        public static Double GetLength(ICurveObject ICurveinstance, Double StartParam, Double EndParam)
        {
            return ICurveinstance.ICurveInstance.GetLength(StartParam, EndParam);
        }
        //public static Int32 IConvertPcurveToBcurveSize(ICurveObject ICurveinstance, Int32 Dim, Int32 Order, Int32 Nsegs, Double& Coeffs, Int32 Basis, Double& Xform, Double ScaleFactor)
        //{
        //    return ICurveinstance.ICurveInstance.IConvertPcurveToBcurveSize(Dim, Order, Nsegs, Coeffs, Basis, Xform, ScaleFactor);
        //}
        public static Object GetSplinePts(ICurveObject ICurveinstance, Object ParamsArrayIn)
        {
            return ICurveinstance.ICurveInstance.GetSplinePts(ParamsArrayIn);
        }
        public static Double IGetSplinePts(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.IGetSplinePts();
        }
        //public static Int32 IGetSplinePtsSize(ICurveObject ICurveinstance, Int32& PropArray, Double& KnotsArray, Double& CntrlPntCoordArray)
        //{
        //    return ICurveinstance.ICurveInstance.IGetSplinePtsSize(PropArray, KnotsArray, CntrlPntCoordArray);
        //}
        public static Int32 IGetBCurveParamsSize2(ICurveObject ICurveinstance, Boolean WantCubic, Boolean WantNRational)
        {
            return ICurveinstance.ICurveInstance.IGetBCurveParamsSize2(WantCubic, WantNRational);
        }
        public static Object Copy(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.Copy();
        }
        public static ICurveObject ICopy(ICurveObject ICurveinstance)
        {
            return new ICurveObject(ICurveinstance.ICurveInstance.ICopy());
        }
        public static Object GetTessPts(ICurveObject ICurveinstance, Double ChordTolerance, Double LengthTolerance, Object StartPoint, Object EndPoint)
        {
            return ICurveinstance.ICurveInstance.GetTessPts(ChordTolerance, LengthTolerance, StartPoint, EndPoint);
        }
        //public static Double IGetTessPts(ICurveObject ICurveinstance, Double ChordTolerance, Double LengthTolerance, Double& StartPoint, Double& EndPoint)
        //{
        //    return ICurveinstance.ICurveInstance.IGetTessPts(ChordTolerance, LengthTolerance, StartPoint, EndPoint);
        //}
        //public static Int32 IGetTessPtsSize(ICurveObject ICurveinstance, Double ChordTolerance, Double LengthTolerance, Double& StartPoint, Double& EndPoint)
        //{
        //    return ICurveinstance.ICurveInstance.IGetTessPtsSize(ChordTolerance, LengthTolerance, StartPoint, EndPoint);
        //}
        public static Object IntersectCurve(ICurveObject ICurveinstance, Object OtherCurve, Object ThisStartPoint, Object ThisEndPoint, Object OtherStartPoint, Object OtherEndPoint)
        {
            return ICurveinstance.ICurveInstance.IntersectCurve(OtherCurve, ThisStartPoint, ThisEndPoint, OtherStartPoint, OtherEndPoint);
        }
        //public static Double IIntersectCurve(ICurveObject ICurveinstance, CurveObject OtherCurve, Double& ThisStartPoint, Double& ThisEndPoint, Double& OtherStartPoint, Double& OtherEndPoint)
        //{
        //    return ICurveinstance.ICurveInstance.IIntersectCurve(OtherCurve, ThisStartPoint, ThisEndPoint, OtherStartPoint, OtherEndPoint);
        //}
        //public static Int32 IIntersectCurveSize(ICurveObject ICurveinstance, CurveObject OtherCurve, Double& ThisStartPoint, Double& ThisEndPoint, Double& OtherStartPoint, Double& OtherEndPoint)
        //{
        //    return ICurveinstance.ICurveInstance.IIntersectCurveSize(OtherCurve, ThisStartPoint, ThisEndPoint, OtherStartPoint, OtherEndPoint);
        //}
        public static Object CreateTrimmedCurve(ICurveObject ICurveinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
        {
            return ICurveinstance.ICurveInstance.CreateTrimmedCurve(X1, Y1, Z1, X2, Y2, Z2);
        }
        //public static ICurveObject ICreateTrimmedCurve(ICurveObject ICurveinstance, Double& Start, Double& End)
        //{
        //    return new ICurveObject(ICurveinstance.ICurveInstance.ICreateTrimmedCurve(Start, End));
        //}
        public static Boolean IsEllipse(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.IsEllipse();
        }
        public static Object GetEllipseParams(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.GetEllipseParams();
        }
        //public static void IGetEllipseParams(ICurveObject ICurveinstance, Double& ParamArray)
        //{
        //    return ICurveinstance.ICurveInstance.IGetEllipseParams(ParamArray);
        //}
        public static Object Evaluate(ICurveObject ICurveinstance, Double Parameter)
        {
            return ICurveinstance.ICurveInstance.Evaluate(Parameter);
        }
        public static Double IEvaluate(ICurveObject ICurveinstance, Double Parameter)
        {
            return ICurveinstance.ICurveInstance.IEvaluate(Parameter);
        }
        public static Object GetClosestPointOn(ICurveObject ICurveinstance, Double X, Double Y, Double Z)
        {
            return ICurveinstance.ICurveInstance.GetClosestPointOn(X, Y, Z);
        }
        public static Double IGetClosestPointOn(ICurveObject ICurveinstance, Double X, Double Y, Double Z)
        {
            return ICurveinstance.ICurveInstance.IGetClosestPointOn(X, Y, Z);
        }
        //public static Boolean GetEndParams(ICurveObject ICurveinstance, Double& Start, Double& End, Boolean& IsClosed, Boolean& IsPeriodic)
        //{
        //    return ICurveinstance.ICurveInstance.GetEndParams(Start, End, IsClosed, IsPeriodic);
        //}
        public static Double GetLength2(ICurveObject ICurveinstance, Double StartParam, Double EndParam)
        {
            return ICurveinstance.ICurveInstance.GetLength2(StartParam, EndParam);
        }
        public static ICurveObject MakeBsplineCurve(ICurveObject ICurveinstance)
        {
            return new ICurveObject(ICurveinstance.ICurveInstance.MakeBsplineCurve());
        }
        public static IBody2Object CreateWireBody(ICurveObject ICurveinstance)
        {
            return new IBody2Object(ICurveinstance.ICurveInstance.CreateWireBody());
        }
        public static ICurveObject GetBaseCurve(ICurveObject ICurveinstance)
        {
            return new ICurveObject(ICurveinstance.ICurveInstance.GetBaseCurve());
        }
        public static Boolean IsTrimmedCurve(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.IsTrimmedCurve();
        }
        public static ICurveObject CreateTrimmedCurve2(ICurveObject ICurveinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
        {
            return new ICurveObject(ICurveinstance.ICurveInstance.CreateTrimmedCurve2(X1, Y1, Z1, X2, Y2, Z2));
        }
        //public static ICurveObject CreateSurfaceCurve(ICurveObject ICurveinstance, SurfaceObject Surf, Int32& Error)
        //{
        //    return new ICurveObject(ICurveinstance.ICurveInstance.CreateSurfaceCurve(Surf, Error));
        //}
        //public static void ApplyTransform(ICurveObject ICurveinstance, MathTransformObject Xform)
        //{
        //    return ICurveinstance.ICurveInstance.ApplyTransform(Xform);
        //}
        public static ICurveObject SimplifyBCurve(ICurveObject ICurveinstance, Double TolIn)
        {
            return new ICurveObject(ICurveinstance.ICurveInstance.SimplifyBCurve(TolIn));
        }
        public static ICurveObject ExtentCurve(ICurveObject ICurveinstance, Boolean AtStart, Double Length, Boolean LinearExt)
        {
            return new ICurveObject(ICurveinstance.ICurveInstance.ExtentCurve(AtStart, Length, LinearExt));
        }
        public static Object JoinCurves(ICurveObject ICurveinstance, Object Curves)
        {
            return ICurveinstance.ICurveInstance.JoinCurves(Curves);
        }
        //public static ICurveObject IJoinCurves(ICurveObject ICurveinstance, Int32 NCurves, Curve&Object Curves)
        //{
        //    return new ICurveObject(ICurveinstance.ICurveInstance.IJoinCurves(NCurves, Curves));
        //}
        public static Object Evaluate2(ICurveObject ICurveinstance, Double Parameter, Int32 NumberOfDerivatives)
        {
            return ICurveinstance.ICurveInstance.Evaluate2(Parameter, NumberOfDerivatives);
        }
        public static Double IEvaluate2(ICurveObject ICurveinstance, Double Parameter, Int32 NumberOfDerivatives)
        {
            return ICurveinstance.ICurveInstance.IEvaluate2(Parameter, NumberOfDerivatives);
        }
        public static Object GetBCurveParams3(ICurveObject ICurveinstance, Boolean WantCubicIn, Boolean WantNRational, Boolean ForceNonPeriodic)
        {
            return ICurveinstance.ICurveInstance.GetBCurveParams3(WantCubicIn, WantNRational, ForceNonPeriodic);
        }
        public static Double IGetBCurveParams3(ICurveObject ICurveinstance, Int32 ArraySize)
        {
            return ICurveinstance.ICurveInstance.IGetBCurveParams3(ArraySize);
        }
        public static Int32 IGetBCurveParamsSize3(ICurveObject ICurveinstance, Boolean WantCubicIn, Boolean WantNRational, Boolean ForceNonPeriodic)
        {
            return ICurveinstance.ICurveInstance.IGetBCurveParamsSize3(WantCubicIn, WantNRational, ForceNonPeriodic);
        }
        public static ICurveObject MakeBsplineCurve2(ICurveObject ICurveinstance)
        {
            return new ICurveObject(ICurveinstance.ICurveInstance.MakeBsplineCurve2());
        }
        public static Double GetLength3(ICurveObject ICurveinstance, Double StartParam, Double EndParam)
        {
            return ICurveinstance.ICurveInstance.GetLength3(StartParam, EndParam);
        }
        //public static Boolean FindMinimumRadius(ICurveObject ICurveinstance, Object Bound, Int32& NumOfRadius, Object& Radius, Object& Location, Object& Parameter)
        //{
        //    return ICurveinstance.ICurveInstance.FindMinimumRadius(Bound, NumOfRadius, Radius, Location, Parameter);
        //}
        //public static Boolean IFindMinimumRadius(ICurveObject ICurveinstance, Double& Bound, Int32& NumOfRadius, Object& Radius, Object& Location, Object& Parameter)
        //{
        //    return ICurveinstance.ICurveInstance.IFindMinimumRadius(Bound, NumOfRadius, Radius, Location, Parameter);
        //}
        public static Object GetBCurveParams4(ICurveObject ICurveinstance, Boolean WantCubicIn, Boolean WantNRational, Boolean ForceNonPeriodic, Boolean IsClosed)
        {
            return ICurveinstance.ICurveInstance.GetBCurveParams4(WantCubicIn, WantNRational, ForceNonPeriodic, IsClosed);
        }
        public static Double ReverseEvaluate(ICurveObject ICurveinstance, Double PositionX, Double PositionY, Double PositionZ)
        {
            return ICurveinstance.ICurveInstance.ReverseEvaluate(PositionX, PositionY, PositionZ);
        }
        public static ISplineParamDataObject GetBCurveParams5(ICurveObject ICurveinstance, Boolean WantCubicIn, Boolean WantNRational, Boolean ForceNonPeriodic, Boolean IsClosed)
        {
            return new ISplineParamDataObject(ICurveinstance.ICurveInstance.GetBCurveParams5(WantCubicIn, WantNRational, ForceNonPeriodic, IsClosed));
        }
        public static ISplineParamDataObject GetPCurveParams2(ICurveObject ICurveinstance)
        {
            return new ISplineParamDataObject(ICurveinstance.ICurveInstance.GetPCurveParams2());
        }
        public static Object LineParams(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.LineParams;
        }
        public static Object CircleParams(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.CircleParams;
        }
        public static Double ILineParams(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.ILineParams;
        }
        public static Double ICircleParams(ICurveObject ICurveinstance)
        {
            return ICurveinstance.ICurveInstance.ICircleParams;
        }
    }
}