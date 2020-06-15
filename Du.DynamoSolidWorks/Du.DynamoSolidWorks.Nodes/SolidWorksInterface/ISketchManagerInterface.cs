using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchManagerObject
    {
        public ISketchManager ISketchManagerInstance { get; set; }
        public ISketchManagerObject(ISketchManager ISketchManagerinstance)
        {
            ISketchManagerInstance = ISketchManagerinstance;
        }
    }
    public static class ISketchManagerInterface
    {
        public static IDisplayDimensionObject AddAlongXDimension(ISketchManagerObject ISketchManagerinstance, Double X, Double Y, Double Z)
        {
            return new IDisplayDimensionObject(ISketchManagerinstance.ISketchManagerInstance.AddAlongXDimension(X, Y, Z));
        }
        public static IDisplayDimensionObject AddAlongYDimension(ISketchManagerObject ISketchManagerinstance, Double X, Double Y, Double Z)
        {
            return new IDisplayDimensionObject(ISketchManagerinstance.ISketchManagerInstance.AddAlongYDimension(X, Y, Z));
        }
        public static IDisplayDimensionObject AddAlongZDimension(ISketchManagerObject ISketchManagerinstance, Double X, Double Y, Double Z)
        {
            return new IDisplayDimensionObject(ISketchManagerinstance.ISketchManagerInstance.AddAlongZDimension(X, Y, Z));
        }
        public static Boolean SketchUseEdge2(ISketchManagerObject ISketchManagerinstance, Boolean Chain)
        {
            return ISketchManagerinstance.ISketchManagerInstance.SketchUseEdge2(Chain);
        }
        public static ISplineParamDataObject CreateSplineParamData(ISketchManagerObject ISketchManagerinstance)
        {
            return new ISplineParamDataObject(ISketchManagerinstance.ISketchManagerInstance.CreateSplineParamData());
        }
        //public static Object CreateSplinesByEqnParams2(ISketchManagerObject ISketchManagerinstance, SplineParamDataObject ParamData)
        //{
        //    return ISketchManagerinstance.ISketchManagerInstance.CreateSplinesByEqnParams2(ParamData);
        //}
        public static ISketchSegmentObject CreateConic(ISketchManagerObject ISketchManagerinstance, Double XFocus, Double YFocus, Double ZFocus, Double XApex, Double YApex, Double ZApex, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateConic(XFocus, YFocus, ZFocus, XApex, YApex, ZApex, X1, Y1, Z1, X2, Y2, Z2));
        }
        public static Boolean SketchReplace(ISketchManagerObject ISketchManagerinstance, Boolean MakeConstruction)
        {
            return ISketchManagerinstance.ISketchManagerInstance.SketchReplace(MakeConstruction);
        }
        public static Boolean SketchUseEdge3(ISketchManagerObject ISketchManagerinstance, Boolean Chain, Boolean InnerLoops)
        {
            return ISketchManagerinstance.ISketchManagerInstance.SketchUseEdge3(Chain, InnerLoops);
        }
        public static Boolean SketchOffset2(ISketchManagerObject ISketchManagerinstance, Double Offset, Boolean BothDirections, Boolean Chain, Int32 CapEnds, Int32 MakeConstruction, Boolean AddDimensions)
        {
            return ISketchManagerinstance.ISketchManagerInstance.SketchOffset2(Offset, BothDirections, Chain, CapEnds, MakeConstruction, AddDimensions);
        }
        //public static Object CreateSpline3(ISketchManagerObject ISketchManagerinstance, Object PointData, Object Surfs, Object Direction, Boolean SimulateNaturalEnds, Object& Status)
        //{
        //    return ISketchManagerinstance.ISketchManagerInstance.CreateSpline3(PointData, Surfs, Direction, SimulateNaturalEnds, Status);
        //}
        public static Int32 ReverseEndPointTangent(ISketchManagerObject ISketchManagerinstance, Boolean ForceDeleteConstraints)
        {
            return ISketchManagerinstance.ISketchManagerInstance.ReverseEndPointTangent(ForceDeleteConstraints);
        }
        public static Boolean SketchOffset(ISketchManagerObject ISketchManagerinstance, Double Offset, Boolean BothDirections, Boolean Chain, Boolean CapEnds, Boolean MakeConstruction, Boolean AddDimensions)
        {
            return ISketchManagerinstance.ISketchManagerInstance.SketchOffset(Offset, BothDirections, Chain, CapEnds, MakeConstruction, AddDimensions);
        }
        public static Object PerimeterCircle(ISketchManagerObject ISketchManagerinstance, Double X1, Double Y1, Double X2, Double Y2, Double X3, Double Y3)
        {
            return ISketchManagerinstance.ISketchManagerInstance.PerimeterCircle(X1, Y1, X2, Y2, X3, Y3);
        }
        public static Boolean GetDynamicMirror(ISketchManagerObject ISketchManagerinstance)
        {
            return ISketchManagerinstance.ISketchManagerInstance.GetDynamicMirror();
        }
        public static Boolean SetDynamicMirror(ISketchManagerObject ISketchManagerinstance, Boolean DynamicMirror)
        {
            return ISketchManagerinstance.ISketchManagerInstance.SetDynamicMirror(DynamicMirror);
        }
        public static Boolean SketchUseEdge(ISketchManagerObject ISketchManagerinstance, Boolean Chain)
        {
            return ISketchManagerinstance.ISketchManagerInstance.SketchUseEdge(Chain);
        }
        public static Int32 GetSketchBlockDefinitionCount(ISketchManagerObject ISketchManagerinstance)
        {
            return ISketchManagerinstance.ISketchManagerInstance.GetSketchBlockDefinitionCount();
        }
        public static Object GetSketchBlockDefinitions(ISketchManagerObject ISketchManagerinstance)
        {
            return ISketchManagerinstance.ISketchManagerInstance.GetSketchBlockDefinitions();
        }
        public static ISketchBlockDefinitionObject IGetSketchBlockDefinitions(ISketchManagerObject ISketchManagerinstance, Int32 BlockDefCount)
        {
            return new ISketchBlockDefinitionObject(ISketchManagerinstance.ISketchManagerInstance.IGetSketchBlockDefinitions(BlockDefCount));
        }
        //public static ISketchBlockDefinitionObject MakeSketchBlockFromSelected(ISketchManagerObject ISketchManagerinstance, MathPointObject InsertionPoint)
        //{
        //    return new ISketchBlockDefinitionObject(ISketchManagerinstance.ISketchManagerInstance.MakeSketchBlockFromSelected(InsertionPoint));
        //}
        //public static ISketchBlockDefinitionObject MakeSketchBlockFromSketch(ISketchManagerObject ISketchManagerinstance, MathPointObject InsertionPoint, SketchObject Sketch)
        //{
        //    return new ISketchBlockDefinitionObject(ISketchManagerinstance.ISketchManagerInstance.MakeSketchBlockFromSketch(InsertionPoint, Sketch));
        //}
        //public static ISketchBlockDefinitionObject MakeSketchBlockFromFile(ISketchManagerObject ISketchManagerinstance, MathPointObject InsertionPoint, String FileName, Boolean LinkedToFile, Double Scale, Double Angle)
        //{
        //    return new ISketchBlockDefinitionObject(ISketchManagerinstance.ISketchManagerInstance.MakeSketchBlockFromFile(InsertionPoint, FileName, LinkedToFile, Scale, Angle));
        //}
        //public static ISketchBlockInstanceObject InsertSketchBlockInstance(ISketchManagerObject ISketchManagerinstance, SketchBlockDefinitionObject BlockDef, MathPointObject Position, Double Scale, Double Angle)
        //{
        //    return new ISketchBlockInstanceObject(ISketchManagerinstance.ISketchManagerInstance.InsertSketchBlockInstance(BlockDef, Position, Scale, Angle));
        //}
        public static void EditSketchBlock(ISketchManagerObject ISketchManagerinstance)
        {
            ISketchManagerinstance.ISketchManagerInstance.EditSketchBlock();
        }
        public static void EndEditSketchBlock(ISketchManagerObject ISketchManagerinstance, Boolean AcceptChanges)
        {
            ISketchManagerinstance.ISketchManagerInstance.EndEditSketchBlock(AcceptChanges);
        }
        //public static void ExplodeSketchBlockInstance(ISketchManagerObject ISketchManagerinstance, SketchBlockInstanceObject LpSketchBlockInstance)
        //{
        //    return ISketchManagerinstance.ISketchManagerInstance.ExplodeSketchBlockInstance(LpSketchBlockInstance);
        //}
        public static Boolean SketchTrim(ISketchManagerObject ISketchManagerinstance, Int32 Option, Double X, Double Y, Double Z)
        {
            return ISketchManagerinstance.ISketchManagerInstance.SketchTrim(Option, X, Y, Z);
        }
        public static Boolean SketchExtend(ISketchManagerObject ISketchManagerinstance, Double X, Double Y, Double Z)
        {
            return ISketchManagerinstance.ISketchManagerInstance.SketchExtend(X, Y, Z);
        }
        public static Boolean MakeSketchChain(ISketchManagerObject ISketchManagerinstance)
        {
            return ISketchManagerinstance.ISketchManagerInstance.MakeSketchChain();
        }
        public static Int32 FullyDefineSketch(ISketchManagerObject ISketchManagerinstance, Boolean EntitiesToFullyDefine, Boolean UseRelations, Int32 RelationsToApply, Boolean UseDimensions, Int32 HorizontalDimScheme, Object HorizontalDatumDisp, Int32 VerticalDimScheme, Object VerticalDatumDisp, Int32 HorizontalDimPlacement, Int32 VerticalDimPlacement)
        {
            return ISketchManagerinstance.ISketchManagerInstance.FullyDefineSketch(EntitiesToFullyDefine, UseRelations, RelationsToApply, UseDimensions, HorizontalDimScheme, HorizontalDatumDisp, VerticalDimScheme, VerticalDatumDisp, HorizontalDimPlacement, VerticalDimPlacement);
        }
        public static Boolean CreateSketchPlane(ISketchManagerObject ISketchManagerinstance, Int32 Relation1, Int32 Relation2, Int32 Relation3)
        {
            return ISketchManagerinstance.ISketchManagerInstance.CreateSketchPlane(Relation1, Relation2, Relation3);
        }
        public static Boolean CreateSketchBelt(ISketchManagerObject ISketchManagerinstance, Double Length, Double Thickness, Int32 Engage, Int32 PulleyCount, Int32 Side1, Int32 Side2, Int32 Side3, Int32 Side4, Int32 Side5, Int32 Side6, Int32 Side7, Int32 Side8, Int32 Side9, Int32 Side10, Int32 Side11, Int32 Side12)
        {
            return ISketchManagerinstance.ISketchManagerInstance.CreateSketchBelt(Length, Thickness, Engage, PulleyCount, Side1, Side2, Side3, Side4, Side5, Side6, Side7, Side8, Side9, Side10, Side11, Side12);
        }
        public static void InsertSketch(ISketchManagerObject ISketchManagerinstance, Boolean UpdateEditRebuild)
        {
            ISketchManagerinstance.ISketchManagerInstance.InsertSketch(UpdateEditRebuild);
        }
        public static ISketchPointObject CreatePoint(ISketchManagerObject ISketchManagerinstance, Double X, Double Y, Double Z)
        {
            return new ISketchPointObject(ISketchManagerinstance.ISketchManagerInstance.CreatePoint(X, Y, Z));
        }
        public static ISketchSegmentObject CreateLine(ISketchManagerObject ISketchManagerinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateLine(X1, Y1, Z1, X2, Y2, Z2));
        }
        public static ISketchSegmentObject CreateCenterLine(ISketchManagerObject ISketchManagerinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateCenterLine(X1, Y1, Z1, X2, Y2, Z2));
        }
        public static ISketchSegmentObject CreateCircle(ISketchManagerObject ISketchManagerinstance, Double XC, Double YC, Double Zc, Double Xp, Double Yp, Double Zp)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateCircle(XC, YC, Zc, Xp, Yp, Zp));
        }
        public static ISketchSegmentObject CreateCircleByRadius(ISketchManagerObject ISketchManagerinstance, Double XC, Double YC, Double Zc, Double Radius)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateCircleByRadius(XC, YC, Zc, Radius));
        }
        public static ISketchSegmentObject CreateArc(ISketchManagerObject ISketchManagerinstance, Double XC, Double YC, Double Zc, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2, Int16 Direction)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateArc(XC, YC, Zc, X1, Y1, Z1, X2, Y2, Z2, Direction));
        }
        public static ISketchSegmentObject Create3PointArc(ISketchManagerObject ISketchManagerinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2, Double X3, Double Y3, Double Z3)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.Create3PointArc(X1, Y1, Z1, X2, Y2, Z2, X3, Y3, Z3));
        }
        public static ISketchSegmentObject CreateTangentArc(ISketchManagerObject ISketchManagerinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2, Int32 ArcType)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateTangentArc(X1, Y1, Z1, X2, Y2, Z2, ArcType));
        }
        public static ISketchSegmentObject CreateEllipse(ISketchManagerObject ISketchManagerinstance, Double XC, Double YC, Double Zc, Double XMajor, Double YMajor, Double ZMajor, Double XMinor, Double YMinor, Double ZMinor)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateEllipse(XC, YC, Zc, XMajor, YMajor, ZMajor, XMinor, YMinor, ZMinor));
        }
        public static ISketchSegmentObject CreateEllipticalArc(ISketchManagerObject ISketchManagerinstance, Double XC, Double YC, Double Zc, Double XMajor, Double YMajor, Double ZMajor, Double XMinor, Double YMinor, Double ZMinor, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2, Int16 Direction)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateEllipticalArc(XC, YC, Zc, XMajor, YMajor, ZMajor, XMinor, YMinor, ZMinor, X1, Y1, Z1, X2, Y2, Z2, Direction));
        }
        public static ISketchSegmentObject CreateParabola(ISketchManagerObject ISketchManagerinstance, Double XFocus, Double YFocus, Double ZFocus, Double XApex, Double YApex, Double ZApex, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateParabola(XFocus, YFocus, ZFocus, XApex, YApex, ZApex, X1, Y1, Z1, X2, Y2, Z2));
        }
        public static ISketchSegmentObject CreateSpline(ISketchManagerObject ISketchManagerinstance, Object PointData)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateSpline(PointData));
        }
        //public static ISketchSegmentObject ICreateSpline(ISketchManagerObject ISketchManagerinstance, Int32 PointCount, Double& PointData)
        //{
        //    return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.ICreateSpline(PointCount, PointData));
        //}
        public static ISketchSegmentObject CreateSplineByEqnParams(ISketchManagerObject ISketchManagerinstance, Object Parameters)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateSplineByEqnParams(Parameters));
        }
        //public static ISketchSegmentObject ICreateSplineByEqnParams(ISketchManagerObject ISketchManagerinstance, Int32& Properties, Int32 KnotArrayCount, Double& Knots, Int32 ControlPointArrayCount, Double& ControlPoints)
        //{
        //    return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.ICreateSplineByEqnParams(Properties, KnotArrayCount, Knots, ControlPointArrayCount, ControlPoints));
        //}
        public static Object CreateSplinesByEqnParams(ISketchManagerObject ISketchManagerinstance, Object Parameters)
        {
            return ISketchManagerinstance.ISketchManagerInstance.CreateSplinesByEqnParams(Parameters);
        }
        //public static IEnumSketchSegmentsObject ICreateSplinesByEqnParams(ISketchManagerObject ISketchManagerinstance, Int32& Properties, Int32 KnotArrayCount, Double& Knots, Int32 ControlPointArrayCount, Double& ControlPoints)
        //{
        //    return new IEnumSketchSegmentsObject(ISketchManagerinstance.ISketchManagerInstance.ICreateSplinesByEqnParams(Properties, KnotArrayCount, Knots, ControlPointArrayCount, ControlPoints));
        //}
        public static ISketchPictureObject InsertSketchPicture(ISketchManagerObject ISketchManagerinstance, String FileName)
        {
            return new ISketchPictureObject(ISketchManagerinstance.ISketchManagerInstance.InsertSketchPicture(FileName));
        }
        public static Object CreateCornerRectangle(ISketchManagerObject ISketchManagerinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
        {
            return ISketchManagerinstance.ISketchManagerInstance.CreateCornerRectangle(X1, Y1, Z1, X2, Y2, Z2);
        }
        public static Object CreateCenterRectangle(ISketchManagerObject ISketchManagerinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
        {
            return ISketchManagerinstance.ISketchManagerInstance.CreateCenterRectangle(X1, Y1, Z1, X2, Y2, Z2);
        }
        public static Object Create3PointCornerRectangle(ISketchManagerObject ISketchManagerinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2, Double X3, Double Y3, Double Z3)
        {
            return ISketchManagerinstance.ISketchManagerInstance.Create3PointCornerRectangle(X1, Y1, Z1, X2, Y2, Z2, X3, Y3, Z3);
        }
        public static Object Create3PointCenterRectangle(ISketchManagerObject ISketchManagerinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2, Double X3, Double Y3, Double Z3)
        {
            return ISketchManagerinstance.ISketchManagerInstance.Create3PointCenterRectangle(X1, Y1, Z1, X2, Y2, Z2, X3, Y3, Z3);
        }
        public static Object CreateParallelogram(ISketchManagerObject ISketchManagerinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2, Double X3, Double Y3, Double Z3)
        {
            return ISketchManagerinstance.ISketchManagerInstance.CreateParallelogram(X1, Y1, Z1, X2, Y2, Z2, X3, Y3, Z3);
        }
        public static ISketchSegmentObject CreateChamfer(ISketchManagerObject ISketchManagerinstance, Int32 Type, Double Distance, Double AngleORdist)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateChamfer(Type, Distance, AngleORdist));
        }
        public static ISketchSegmentObject CreateFillet(ISketchManagerObject ISketchManagerinstance, Double Radius, Int32 ConstrainedCorners)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateFillet(Radius, ConstrainedCorners));
        }
        public static Object CreatePolygon(ISketchManagerObject ISketchManagerinstance, Double XC, Double YC, Double Zc, Double Xp, Double Yp, Double Zp, Int32 Sides, Boolean Inscribed)
        {
            return ISketchManagerinstance.ISketchManagerInstance.CreatePolygon(XC, YC, Zc, Xp, Yp, Zp, Sides, Inscribed);
        }
        public static void Insert3DSketch(ISketchManagerObject ISketchManagerinstance, Boolean UpdateEditRebuild)
        {
            ISketchManagerinstance.ISketchManagerInstance.Insert3DSketch(UpdateEditRebuild);
        }
        public static Object SplitOpenSegment(ISketchManagerObject ISketchManagerinstance, Double X, Double Y, Double Z)
        {
            return ISketchManagerinstance.ISketchManagerInstance.SplitOpenSegment(X, Y, Z);
        }
        public static Object SplitClosedSegment(ISketchManagerObject ISketchManagerinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
        {
            return ISketchManagerinstance.ISketchManagerInstance.SplitClosedSegment(X1, Y1, Z1, X2, Y2, Z2);
        }
        public static void SetGridOptions(ISketchManagerObject ISketchManagerinstance, Boolean Display, Double Spacing, Boolean Snap, Boolean DotStyle, Int16 NumMajor, Int16 NumMinor, Boolean AlignToEdge, Boolean AngleSnap, Double AngleUnit, Boolean MinorAuto)
        {
            ISketchManagerinstance.ISketchManagerInstance.SetGridOptions(Display, Spacing, Snap, DotStyle, NumMajor, NumMinor, AlignToEdge, AngleSnap, AngleUnit, MinorAuto);
        }
        public static Object CreateBoundaryHatch(ISketchManagerObject ISketchManagerinstance, Double Angle, Double Scale, Int32 Color, String Hatchname, String Layername)
        {
            return ISketchManagerinstance.ISketchManagerInstance.CreateBoundaryHatch(Angle, Scale, Color, Hatchname, Layername);
        }
        public static ISketchHatchObject CreateRegionHatch(ISketchManagerObject ISketchManagerinstance, Double X, Double Y, Double Z, Double Angle, Double Scale, Int32 Color, String Hatchname, String Layername)
        {
            return new ISketchHatchObject(ISketchManagerinstance.ISketchManagerInstance.CreateRegionHatch(X, Y, Z, Angle, Scale, Color, Hatchname, Layername));
        }
        public static ISketchSlotObject CreateSketchSlot(ISketchManagerObject ISketchManagerinstance, Int32 SlotCreationType, Int32 SlotLengthType, Double Width, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2, Double X3, Double Y3, Double Z3, Int32 CenterArcDirection, Boolean AddDimension)
        {
            return new ISketchSlotObject(ISketchManagerinstance.ISketchManagerInstance.CreateSketchSlot(SlotCreationType, SlotLengthType, Width, X1, Y1, Z1, X2, Y2, Z2, X3, Y3, Z3, CenterArcDirection, AddDimension));
        }
        public static void CreateConstructionGeometry(ISketchManagerObject ISketchManagerinstance)
        {
            ISketchManagerinstance.ISketchManagerInstance.CreateConstructionGeometry();
        }
        public static ISketchSplineObject CreateEquationSpline(ISketchManagerObject ISketchManagerinstance, String YExpression, Double RangeStart, Double RangeEnd, Boolean IsAngleRange, Double RotationAngle, Double XOffset, Double YOffset, Boolean LockStart, Boolean LockEnd)
        {
            return new ISketchSplineObject(ISketchManagerinstance.ISketchManagerInstance.CreateEquationSpline(YExpression, RangeStart, RangeEnd, IsAngleRange, RotationAngle, XOffset, YOffset, LockStart, LockEnd));
        }
        public static void ConvertEntities(ISketchManagerObject ISketchManagerinstance)
        {
            ISketchManagerinstance.ISketchManagerInstance.ConvertEntities();
        }
        public static void IntersectCurves(ISketchManagerObject ISketchManagerinstance)
        {
            ISketchManagerinstance.ISketchManagerInstance.IntersectCurves();
        }
        public static ISketchSegmentObject CreateSpline2(ISketchManagerObject ISketchManagerinstance, Object PointData, Boolean SimulateNaturalEnds)
        {
            return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.CreateSpline2(PointData, SimulateNaturalEnds));
        }
        //public static ISketchSegmentObject ICreateSpline2(ISketchManagerObject ISketchManagerinstance, Int32 PointCount, Double& PointData, Boolean SimulateNaturalEnds)
        //{
        //    return new ISketchSegmentObject(ISketchManagerinstance.ISketchManagerInstance.ICreateSpline2(PointCount, PointData, SimulateNaturalEnds));
        //}
        public static ISketchSplineObject CreateEquationSpline2(ISketchManagerObject ISketchManagerinstance, String XExpression, String YExpression, String ZExpression, String RangeStart, String RangeEnd, Boolean IsAngleRange, Double RotationAngle, Double XOffset, Double YOffset, Boolean LockStart, Boolean LockEnd)
        {
            return new ISketchSplineObject(ISketchManagerinstance.ISketchManagerInstance.CreateEquationSpline2(XExpression, YExpression, ZExpression, RangeStart, RangeEnd, IsAngleRange, RotationAngle, XOffset, YOffset, LockStart, LockEnd));
        }
        public static Boolean CreateLinearSketchStepAndRepeat(ISketchManagerObject ISketchManagerinstance, Int32 NumX, Int32 NumY, Double SpacingX, Double SpacingY, Double AngleX, Double AngleY, String DeleteInstances, Boolean XSpacingDim, Boolean YSpacingDim, Boolean AngleDim, Boolean CreateNumOfInstancesDimInXDir, Boolean CreateNumOfInstancesDimInYDir)
        {
            return ISketchManagerinstance.ISketchManagerInstance.CreateLinearSketchStepAndRepeat(NumX, NumY, SpacingX, SpacingY, AngleX, AngleY, DeleteInstances, XSpacingDim, YSpacingDim, AngleDim, CreateNumOfInstancesDimInXDir, CreateNumOfInstancesDimInYDir);
        }
        public static Boolean CreateCircularSketchStepAndRepeat(ISketchManagerObject ISketchManagerinstance, Double ArcRadius, Double ArcAngle, Int32 PatternNum, Double PatternSpacing, Boolean PatternRotate, String DeleteInstances, Boolean RadiusDim, Boolean AngleDim, Boolean CreateNumOfInstancesDim)
        {
            return ISketchManagerinstance.ISketchManagerInstance.CreateCircularSketchStepAndRepeat(ArcRadius, ArcAngle, PatternNum, PatternSpacing, PatternRotate, DeleteInstances, RadiusDim, AngleDim, CreateNumOfInstancesDim);
        }
        public static Boolean EditLinearSketchStepAndRepeat(ISketchManagerObject ISketchManagerinstance, Int32 NumX, Int32 NumY, Double SpacingX, Double SpacingY, Double AngleX, Double AngleY, String DeleteInstances, Boolean XSpacingDim, Boolean YSpacingDim, Boolean AngleDim, Boolean CreateNumOfInstancesDimInXDir, Boolean CreateNumOfInstancesDimInYDir, String Seeds)
        {
            return ISketchManagerinstance.ISketchManagerInstance.EditLinearSketchStepAndRepeat(NumX, NumY, SpacingX, SpacingY, AngleX, AngleY, DeleteInstances, XSpacingDim, YSpacingDim, AngleDim, CreateNumOfInstancesDimInXDir, CreateNumOfInstancesDimInYDir, Seeds);
        }
        public static Boolean EditCircularSketchStepAndRepeat(ISketchManagerObject ISketchManagerinstance, Double ArcRadius, Double ArcAngle, Int32 PatternNum, Double PatternSpacing, Boolean PatternRotate, String DeleteInstances, Boolean RadiusDim, Boolean AngleDim, Boolean CreateNumOfInstancesDim, String Seeds)
        {
            return ISketchManagerinstance.ISketchManagerInstance.EditCircularSketchStepAndRepeat(ArcRadius, ArcAngle, PatternNum, PatternSpacing, PatternRotate, DeleteInstances, RadiusDim, AngleDim, CreateNumOfInstancesDim, Seeds);
        }
        public static Boolean RotateOrCopy3DAboutXYZ(ISketchManagerObject ISketchManagerinstance, Boolean Copy, Int32 NumCopies, Boolean KeepRelations, Double BaseX, Double BaseY, Double BaseZ, Double AngleAboutXDir, Double AngleAboutYDir, Double AngleAboutZDir)
        {
            return ISketchManagerinstance.ISketchManagerInstance.RotateOrCopy3DAboutXYZ(Copy, NumCopies, KeepRelations, BaseX, BaseY, BaseZ, AngleAboutXDir, AngleAboutYDir, AngleAboutZDir);
        }
        public static Boolean RotateOrCopy3DAboutVector(ISketchManagerObject ISketchManagerinstance, Boolean Copy, Int32 NumCopies, Boolean KeepRelations, Double BaseX, Double BaseY, Double BaseZ, Double VectorXCoord, Double VectorYCoord, Double VectorZCoord, Double AngleAboutVector)
        {
            return ISketchManagerinstance.ISketchManagerInstance.RotateOrCopy3DAboutVector(Copy, NumCopies, KeepRelations, BaseX, BaseY, BaseZ, VectorXCoord, VectorYCoord, VectorZCoord, AngleAboutVector);
        }
        public static Boolean InsertExplodeLineSketch(ISketchManagerObject ISketchManagerinstance)
        {
            return ISketchManagerinstance.ISketchManagerInstance.InsertExplodeLineSketch();
        }
        public static IModelDoc2Object Document(ISketchManagerObject ISketchManagerinstance)
        {
            return new IModelDoc2Object(ISketchManagerinstance.ISketchManagerInstance.Document);
        }
        public static Double CurvatureScale(ISketchManagerObject ISketchManagerinstance)
        {
            return ISketchManagerinstance.ISketchManagerInstance.CurvatureScale;
        }
        public static Int32 CurvatureDensity(ISketchManagerObject ISketchManagerinstance)
        {
            return ISketchManagerinstance.ISketchManagerInstance.CurvatureDensity;
        }
        public static Boolean AutoSolve(ISketchManagerObject ISketchManagerinstance)
        {
            return ISketchManagerinstance.ISketchManagerInstance.AutoSolve;
        }
        public static Boolean AutoInference(ISketchManagerObject ISketchManagerinstance)
        {
            return ISketchManagerinstance.ISketchManagerInstance.AutoInference;
        }
        public static ISketchObject ActiveSketch(ISketchManagerObject ISketchManagerinstance)
        {
            return new ISketchObject(ISketchManagerinstance.ISketchManagerInstance.ActiveSketch);
        }
        public static Boolean AddToDB(ISketchManagerObject ISketchManagerinstance)
        {
            return ISketchManagerinstance.ISketchManagerInstance.AddToDB;
        }
        public static Boolean DisplayWhenAdded(ISketchManagerObject ISketchManagerinstance)
        {
            return ISketchManagerinstance.ISketchManagerInstance.DisplayWhenAdded;
        }
        public static Boolean InferenceMode(ISketchManagerObject ISketchManagerinstance)
        {
            return ISketchManagerinstance.ISketchManagerInstance.InferenceMode;
        }
    }
}