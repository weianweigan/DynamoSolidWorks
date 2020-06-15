using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchObject
    {
        public ISketch ISketchInstance { get; set; }
        public ISketchObject(ISketch ISketchinstance)
        {
            ISketchInstance = ISketchinstance;
        }
    }
    public static class ISketchInterface
    {
        public static Int32 GetSketchPathCount(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchPathCount();
        }
        public static Int32 GetSketchPictureCount(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchPictureCount();
        }
        public static Object GetSketchPictures(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchPictures();
        }
        public static ISketchPictureObject IGetSketchPictures(ISketchObject ISketchinstance, Int32 Count)
        {
            return new ISketchPictureObject(ISketchinstance.ISketchInstance.IGetSketchPictures(Count));
        }
        public static Int32 GetSketchRegionCount(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchRegionCount();
        }
        public static Object GetSketchRegions(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchRegions();
        }
        public static ISketchRegionObject IGetSketchRegions(ISketchObject ISketchinstance, Int32 Count)
        {
            return new ISketchRegionObject(ISketchinstance.ISketchInstance.IGetSketchRegions(Count));
        }
        public static Int32 GetSketchContourCount(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchContourCount();
        }
        public static Object GetSketchContours(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchContours();
        }
        public static ISketchContourObject IGetSketchContours(ISketchObject ISketchinstance, Int32 Count)
        {
            return new ISketchContourObject(ISketchinstance.ISketchInstance.IGetSketchContours(Count));
        }
        public static Int32 GetSketchSlotCount(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchSlotCount();
        }
        public static Object GetSketchSlots(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchSlots();
        }
        public static ISketchSlotObject IGetSketchSlots(ISketchObject ISketchinstance, Int32 Count)
        {
            return new ISketchSlotObject(ISketchinstance.ISketchInstance.IGetSketchSlots(Count));
        }
        public static Boolean IsDerived(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IsDerived();
        }
        public static Boolean InsertRouteLine(ISketchObject ISketchinstance, Object ItemsToConnect, Object Reverse, Object AlternatePath, Object AlongXYZ)
        {
            return ISketchinstance.ISketchInstance.InsertRouteLine(ItemsToConnect, Reverse, AlternatePath, AlongXYZ);
        }
        public static Object GetSplineParams3(ISketchObject ISketchinstance, Boolean ForceNonPeriodic)
        {
            return ISketchinstance.ISketchInstance.GetSplineParams3(ForceNonPeriodic);
        }
        public static Double IGetSplineParams3(ISketchObject ISketchinstance, Boolean ForceNonPeriodic)
        {
            return ISketchinstance.ISketchInstance.IGetSplineParams3(ForceNonPeriodic);
        }
        //public static Int32 GetSplineParamsCount3(ISketchObject ISketchinstance, Boolean ForceNonPeriodic, Int32& Size)
        //{
        //    return ISketchinstance.ISketchInstance.GetSplineParamsCount3(ForceNonPeriodic, Size);
        //}
        public static Boolean IsBoundaryBoxSketch(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IsBoundaryBoxSketch();
        }
        public static ISplineParamDataObject GetSplineParams4(ISketchObject ISketchinstance, Boolean ForceNonPeriodic)
        {
            return new ISplineParamDataObject(ISketchinstance.ISketchInstance.GetSplineParams4(ForceNonPeriodic));
        }
        public static Object GetSplineParams5(ISketchObject ISketchinstance, Boolean ForceNonPeriodic, Int32 Index)
        {
            return ISketchinstance.ISketchInstance.GetSplineParams5(ForceNonPeriodic, Index);
        }
        public static Object GetLines(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetLines();
        }
        public static Double IGetLines(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IGetLines();
        }
        public static Int32 GetLineCount(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetLineCount();
        }
        public static Object GetArcs(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetArcs();
        }
        public static Double IGetArcs(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IGetArcs();
        }
        public static Int32 GetArcCount(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetArcCount();
        }
        public static Object GetPolylines(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetPolylines();
        }
        public static Double IGetPolylines(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IGetPolylines();
        }
        //public static Int32 GetPolyLineCount(ISketchObject ISketchinstance, Int32& PointCount)
        //{
        //    return ISketchinstance.ISketchInstance.GetPolyLineCount(PointCount);
        //}
        public static Object GetSplines(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSplines();
        }
        public static Double IGetSplines(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IGetSplines();
        }
        //public static Int32 GetSplineCount(ISketchObject ISketchinstance, Int32& PointCount)
        //{
        //    return ISketchinstance.ISketchInstance.GetSplineCount(PointCount);
        //}
        public static Object GetEllipses(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetEllipses();
        }
        public static Double IGetEllipses(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IGetEllipses();
        }
        public static Int32 GetEllipseCount(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetEllipseCount();
        }
        public static Object GetUserPoints(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetUserPoints();
        }
        public static Double IGetUserPoints(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IGetUserPoints();
        }
        public static Int32 GetUserPointsCount(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetUserPointsCount();
        }
        public static Object GetSplinesInterpolate(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSplinesInterpolate();
        }
        public static Double IGetSplinesInterpolate(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IGetSplinesInterpolate();
        }
        //public static Int32 GetSplineInterpolateCount(ISketchObject ISketchinstance, Int32& PointCount)
        //{
        //    return ISketchinstance.ISketchInstance.GetSplineInterpolateCount(PointCount);
        //}
        public static Boolean GetAutomaticSolve(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetAutomaticSolve();
        }
        public static Boolean SetAutomaticSolve(ISketchObject ISketchinstance, Boolean SolveFlag)
        {
            return ISketchinstance.ISketchInstance.SetAutomaticSolve(SolveFlag);
        }
        public static Int32 ConstrainAll(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.ConstrainAll();
        }
        public static Object GetSplineParams(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSplineParams();
        }
        public static Double IGetSplineParams(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IGetSplineParams();
        }
        //public static Int32 GetSplineParamsCount(ISketchObject ISketchinstance, Int32& Size)
        //{
        //    return ISketchinstance.ISketchInstance.GetSplineParamsCount(Size);
        //}
        public static Object GetParabolas(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetParabolas();
        }
        public static Double IGetParabolas(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IGetParabolas();
        }
        public static Int32 GetParabolaCount(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetParabolaCount();
        }
        public static Object GetEllipses2(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetEllipses2();
        }
        public static Double IGetEllipses2(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IGetEllipses2();
        }
        public static Object GetSketchPoints(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchPoints();
        }
        //public static IEnumSketchPointsObject IEnumSketchPoints(ISketchObject ISketchinstance)
        //{
        //    return new IEnumSketchPointsObject(ISketchinstance.ISketchInstance.IEnumSketchPoints());
        //}
        public static Object GetSketchSegments(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchSegments();
        }
        //public static IEnumSketchSegmentsObject IEnumSketchSegments(ISketchObject ISketchinstance)
        //{
        //    return new IEnumSketchSegmentsObject(ISketchinstance.ISketchInstance.IEnumSketchSegments());
        //}
        public static Boolean Is3D(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.Is3D();
        }
        public static Int32 GetSketchPointsCount(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchPointsCount();
        }
        public static Object GetSketchHatches(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchHatches();
        }
        //public static IEnumSketchHatchesObject IEnumSketchHatches(ISketchObject ISketchinstance)
        //{
        //    return new IEnumSketchHatchesObject(ISketchinstance.ISketchInstance.IEnumSketchHatches());
        //}
        public static Object GetSplineParams2(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSplineParams2();
        }
        public static Double IGetSplineParams2(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IGetSplineParams2();
        }
        //public static Int32 GetSplineParamsCount2(ISketchObject ISketchinstance, Int32& Size)
        //{
        //    return ISketchinstance.ISketchInstance.GetSplineParamsCount2(Size);
        //}
        public static Object GetSketchTextSegments(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchTextSegments();
        }
        //public static IEnumSketchSegmentsObject IEnumSketchTextSegments(ISketchObject ISketchinstance)
        //{
        //    return new IEnumSketchSegmentsObject(ISketchinstance.ISketchInstance.IEnumSketchTextSegments());
        //}
        public static Int32 GetConstrainedStatus(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetConstrainedStatus();
        }
        public static Boolean SetEntityCount(ISketchObject ISketchinstance, Int32 EntityType, Int32 EntityCount)
        {
            return ISketchinstance.ISketchInstance.SetEntityCount(EntityType, EntityCount);
        }
        //public static Int32 CheckFeatureUse(ISketchObject ISketchinstance, Int32 FeatureType, Int32& OpenCount, Int32& ClosedCount)
        //{
        //    return ISketchinstance.ISketchInstance.CheckFeatureUse(FeatureType, OpenCount, ClosedCount);
        //}
        public static Boolean MergePoints(ISketchObject ISketchinstance, Double Distance)
        {
            return ISketchinstance.ISketchInstance.MergePoints(Distance);
        }
        //public static Object GetReferenceEntity(ISketchObject ISketchinstance, Int32& LEntityType)
        //{
        //    return ISketchinstance.ISketchInstance.GetReferenceEntity(LEntityType);
        //}
        public static Int32 GetContourEdgeCount(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetContourEdgeCount();
        }
        public static Object GetContourEdges(ISketchObject ISketchinstance, Object Xform)
        {
            return ISketchinstance.ISketchInstance.GetContourEdges(Xform);
        }
        //public static IEdgeObject IGetContourEdges(ISketchObject ISketchinstance, Double& Xform, Int32 EdgeCount)
        //{
        //    return new IEdgeObject(ISketchinstance.ISketchInstance.IGetContourEdges(Xform, EdgeCount));
        //}
        public static Int32 AutoDimension(ISketchObject ISketchinstance, Int32 EntitiesToDimension, Int32 HorizontalScheme, Int32 HorizontalPlacement, Int32 VerticalScheme, Int32 VerticalPlacement)
        {
            return ISketchinstance.ISketchInstance.AutoDimension(EntitiesToDimension, HorizontalScheme, HorizontalPlacement, VerticalScheme, VerticalPlacement);
        }
        public static Int32 GetLineCount2(ISketchObject ISketchinstance, Int16 CrossHatchOption)
        {
            return ISketchinstance.ISketchInstance.GetLineCount2(CrossHatchOption);
        }
        public static Object GetLines2(ISketchObject ISketchinstance, Int16 CrossHatchOption)
        {
            return ISketchinstance.ISketchInstance.GetLines2(CrossHatchOption);
        }
        public static Double IGetLines2(ISketchObject ISketchinstance, Int16 CrossHatchOption, Int32 ArraySize)
        {
            return ISketchinstance.ISketchInstance.IGetLines2(CrossHatchOption, ArraySize);
        }
        public static Object GetArcs2(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetArcs2();
        }
        public static Double IGetArcs2(ISketchObject ISketchinstance, Int32 ArraySize)
        {
            return ISketchinstance.ISketchInstance.IGetArcs2(ArraySize);
        }
        public static Object GetUserPoints2(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetUserPoints2();
        }
        public static Double IGetUserPoints2(ISketchObject ISketchinstance, Int32 ArraySize)
        {
            return ISketchinstance.ISketchInstance.IGetUserPoints2(ArraySize);
        }
        public static Object GetEllipses3(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetEllipses3();
        }
        public static Double IGetEllipses3(ISketchObject ISketchinstance, Int32 ArraySize)
        {
            return ISketchinstance.ISketchInstance.IGetEllipses3(ArraySize);
        }
        public static Object GetParabolas2(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetParabolas2();
        }
        public static Double IGetParabolas2(ISketchObject ISketchinstance, Int32 ArraySize)
        {
            return ISketchinstance.ISketchInstance.IGetParabolas2(ArraySize);
        }
        public static Boolean IsShared(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IsShared();
        }
        public static Int32 AutoDimension2(ISketchObject ISketchinstance, Int32 EntitiesToDimension, Int32 HorizontalScheme, Int32 HorizontalPlacement, Int32 VerticalScheme, Int32 VerticalPlacement)
        {
            return ISketchinstance.ISketchInstance.AutoDimension2(EntitiesToDimension, HorizontalScheme, HorizontalPlacement, VerticalScheme, VerticalPlacement);
        }
        public static Boolean GetDetachSegmentOnDrag(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetDetachSegmentOnDrag();
        }
        public static Boolean SetDetachSegmentOnDrag(ISketchObject ISketchinstance, Boolean Detach)
        {
            return ISketchinstance.ISketchInstance.SetDetachSegmentOnDrag(Detach);
        }
        public static void AutoTraceSketchPicture(ISketchObject ISketchinstance)
        {
            ISketchinstance.ISketchInstance.AutoTraceSketchPicture();
        }
        public static Int32 GetSketchPointsCount2(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchPointsCount2();
        }
        public static Object GetSketchPoints2(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchPoints2();
        }
        public static ISketchPointObject IGetSketchPoints2(ISketchObject ISketchinstance, Int32 Count)
        {
            return new ISketchPointObject(ISketchinstance.ISketchInstance.IGetSketchPoints2(Count));
        }
        public static Int32 GetSketchBlockInstanceCount(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchBlockInstanceCount();
        }
        public static Object GetSketchBlockInstances(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchBlockInstances();
        }
        public static ISketchBlockInstanceObject IGetSketchBlockInstances(ISketchObject ISketchinstance, Int32 Count)
        {
            return new ISketchBlockInstanceObject(ISketchinstance.ISketchInstance.IGetSketchBlockInstances(Count));
        }
        public static Boolean SetWorkingPlaneOrientation(ISketchObject ISketchinstance, Double OriginX, Double OriginY, Double OriginZ, Double XAxisX, Double XAxisY, Double XAxisZ, Double YAxisX, Double YAxisY, Double YAxisZ, Double NormalX, Double NormalY, Double NormalZ)
        {
            return ISketchinstance.ISketchInstance.SetWorkingPlaneOrientation(OriginX, OriginY, OriginZ, XAxisX, XAxisY, XAxisZ, YAxisX, YAxisY, YAxisZ, NormalX, NormalY, NormalZ);
        }
        public static Object GetSketchPaths(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.GetSketchPaths();
        }
        public static ISketchPathObject IGetSketchPaths(ISketchObject ISketchinstance, Int32 Count)
        {
            return new ISketchPathObject(ISketchinstance.ISketchInstance.IGetSketchPaths(Count));
        }
        public static Object ModelToSketchXform(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.ModelToSketchXform;
        }
        public static Double IModelToSketchXform(ISketchObject ISketchinstance)
        {
            return ISketchinstance.ISketchInstance.IModelToSketchXform;
        }
        public static IMathTransformObject ModelToSketchTransform(ISketchObject ISketchinstance)
        {
            return new IMathTransformObject(ISketchinstance.ISketchInstance.ModelToSketchTransform);
        }
        public static ISketchRelationManagerObject RelationManager(ISketchObject ISketchinstance)
        {
            return new ISketchRelationManagerObject(ISketchinstance.ISketchInstance.RelationManager);
        }
    }
}