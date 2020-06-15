using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IModelerObject
    {
        public IModeler IModelerInstance { get; set; }
        public IModelerObject(IModeler IModelerinstance)
        {
            IModelerInstance = IModelerinstance;
        }
    }
    public static class IModelerInterface
    {
        public static Object CreateConicalSurface2(IModelerObject IModelerinstance, Object Center, Object Direction, Object RefDirection, Double Radius, Double SemiAngle)
        {
            return IModelerinstance.IModelerInstance.CreateConicalSurface2(Center, Direction, RefDirection, Radius, SemiAngle);
        }
        //public static ISurfaceObject ICreateConicalSurface2(IModelerObject IModelerinstance, Double& Center, Double& Direction, Double& RefDirection, Double Radius, Double SemiAngle)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreateConicalSurface2(Center, Direction, RefDirection, Radius, SemiAngle));
        //}
        public static Int32 CopyWizardHole(IModelerObject IModelerinstance, Object SourceHole, Object DestinationHole, Boolean RebuildOwner)
        {
            return IModelerinstance.IModelerInstance.CopyWizardHole(SourceHole, DestinationHole, RebuildOwner);
        }
        public static Int32 ICopyWizardHole(IModelerObject IModelerinstance, IFeatureObject SourceHole, IFeatureObject DestinationHole, Boolean RebuildOwner)
        {
            return IModelerinstance.IModelerInstance.ICopyWizardHole(SourceHole?.IFeatureInstance?.CastObj<Feature>(), DestinationHole?.IFeatureInstance.CastObj<Feature>(), RebuildOwner);
        }
        public static Boolean DeleteFacesFromSheetBody(IModelerObject IModelerinstance, Object FaceVar)
        {
            return IModelerinstance.IModelerInstance.DeleteFacesFromSheetBody(FaceVar);
        }
        //public static Boolean IDeleteFacesFromSheetBody(IModelerObject IModelerinstance, Int32 Count, Face2&Object FaceVar)
        //{
        //    return IModelerinstance.IModelerInstance.IDeleteFacesFromSheetBody(Count, FaceVar);
        //}
        public static IBody2Object CreateWireBody(IModelerObject IModelerinstance, Object EntVar, Int32 Option)
        {
            return new IBody2Object(IModelerinstance.IModelerInstance.CreateWireBody(EntVar, Option));
        }
        //public static IBody2Object ICreateWireBody(IModelerObject IModelerinstance, Int32 Count, Object& EntArr, Int32 Option)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.ICreateWireBody(Count, EntArr, Option));
        //}
        public static Object CreateBrepBody3(IModelerObject IModelerinstance, Int32 Type, Int32 NTopologies, Object Topologies, Object EdgeToleranceArray, Object VertexToleranceArray, Object PointArray, Object CurveArray1, Object CurveSurfaceArray1, Object CurveArray2, Object CurveSurfaceArray2, Object SurfaceArray, Int32 NRelations, Object Parents, Object Children, Object Senses, Int32 Option)
        {
            return IModelerinstance.IModelerInstance.CreateBrepBody3(Type, NTopologies, Topologies, EdgeToleranceArray, VertexToleranceArray, PointArray, CurveArray1, CurveSurfaceArray1, CurveArray2, CurveSurfaceArray2, SurfaceArray, NRelations, Parents, Children, Senses, Option);
        }
        //public static IBody2Object ICreateBrepBody3(IModelerObject IModelerinstance, Int32 Type, Int32 NTopologies, Int32& Topologies, Double& EdgeTolArray, Double& VertexTolArray, Double& PointArray, Curve&Object CurveArra1, Surface&Object CurveSurfaceArray1, Curve&Object CurveArray2, Surface&Object CurveSurfaceArray2, Surface&Object SurfaceArray, Int32 NRelations, Int32& Parents, Int32& Children, Int32& Senses, Int32 Option)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.ICreateBrepBody3(Type, NTopologies, Topologies, EdgeTolArray, VertexTolArray, PointArray, CurveArra1, CurveSurfaceArray1, CurveArray2, CurveSurfaceArray2, SurfaceArray, NRelations, Parents, Children, Senses, Option));
        //}
        public static IBody2Object CreateSheetFromFaces(IModelerObject IModelerinstance, Object FaceArr)
        {
            return new IBody2Object(IModelerinstance.IModelerInstance.CreateSheetFromFaces(FaceArr));
        }
        //public static IBody2Object ICreateSheetFromFaces(IModelerObject IModelerinstance, Int32 FaceCount, Face2&Object FaceArr)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.ICreateSheetFromFaces(FaceCount, FaceArr));
        //}
        public static ISpringObject CreateSpring(IModelerObject IModelerinstance)
        {
            return new ISpringObject(IModelerinstance.IModelerInstance.CreateSpring());
        }
        //public static Int32 GetBodyOutline(IModelerObject IModelerinstance, Object BodyVar, MathVectorObject Direction, Double Tolerance, Object& CurvesOut, Object& TopolEntities, Object& Outline)
        //{
        //    return IModelerinstance.IModelerInstance.GetBodyOutline(BodyVar, Direction, Tolerance, CurvesOut, TopolEntities, Outline);
        //}
        public static ICurveObject MergeCurves(IModelerObject IModelerinstance, Object CurveVar)
        {
            return new ICurveObject(IModelerinstance.IModelerInstance.MergeCurves(CurveVar));
        }
        //public static ICurveObject IMergeCurves(IModelerObject IModelerinstance, Int32 CurveCount, Curve&Object CurveArr)
        //{
        //    return new ICurveObject(IModelerinstance.IModelerInstance.IMergeCurves(CurveCount, CurveArr));
        //}
        //public static IBody2Object CreateSweptBody(IModelerObject IModelerinstance, ModelDoc2Object PModDoc, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean BAdvancedSmoothing, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType, Int16 PathAlign, Double TwistAngle, Boolean BMergeSmoothFaces)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.CreateSweptBody(PModDoc, Propagate, Alignment, TwistCtrlOption, KeepTangency, BAdvancedSmoothing, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType, PathAlign, TwistAngle, BMergeSmoothFaces));
        //}
        //public static Int32 GetManifoldBodiesCount(IModelerObject IModelerinstance, Body2Object NonManifoldIn)
        //{
        //    return IModelerinstance.IModelerInstance.GetManifoldBodiesCount(NonManifoldIn);
        //}
        //public static Object MakeManifoldBodies(IModelerObject IModelerinstance, Body2Object NonManifoldIn)
        //{
        //    return IModelerinstance.IModelerInstance.MakeManifoldBodies(NonManifoldIn);
        //}
        //public static IBody2Object IMakeManifoldBodies(IModelerObject IModelerinstance, Body2Object NonManifoldIn, Int32 Count)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.IMakeManifoldBodies(NonManifoldIn, Count));
        //}
        //public static ISurfaceObject CreateCoonsBSurface(IModelerObject IModelerinstance, CurveObject UCurve0, CurveObject UCurve1, CurveObject VCurve0, CurveObject VCurve1, Boolean IgnoreClosureReqt)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.CreateCoonsBSurface(UCurve0, UCurve1, VCurve0, VCurve1, IgnoreClosureReqt));
        //}
        //public static ISurfaceObject ICreateLoftSurface(IModelerObject IModelerinstance, Int32 NCurves, Curve&Object CurveArray, Boolean BBlendClosed, Boolean BForceCubic, Int32 NGuides, Curve&Object GuideCrvArray, Int32 StartMatchingType, Int32 EndMatchingType, MathVectorObject NormalAtStartSection, MathVectorObject NormalAtEndSection, Int32 NStartMatchingFaces, Face2&Object StartMatchingFaceList, Int32 NEndMatchingFaces, Face2&Object EndMatchingFaceList, Boolean DegeneratedStart, Boolean DegeneratedEnd, MathPointObject StartPointOfStartSection, MathPointObject StartPointOfEndSection, Int32 SectionIndexStart, Int32 SectionIndexEnd, Int32 GuideIndexStart, Int32 GuideIndexEnd)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreateLoftSurface(NCurves, CurveArray, BBlendClosed, BForceCubic, NGuides, GuideCrvArray, StartMatchingType, EndMatchingType, NormalAtStartSection, NormalAtEndSection, NStartMatchingFaces, StartMatchingFaceList, NEndMatchingFaces, EndMatchingFaceList, DegeneratedStart, DegeneratedEnd, StartPointOfStartSection, StartPointOfEndSection, SectionIndexStart, SectionIndexEnd, GuideIndexStart, GuideIndexEnd));
        //}
        public static Object CreateLoftSurface(IModelerObject IModelerinstance, Object CurveArray, Boolean BBlendClosed, Boolean BForceCubic, Object GuideCrvArray, Int32 StartMatchingType, Int32 EndMatchingType, Object NormalAtStartSection, Object NormalAtEndSection, Object StartMatchingFaceList, Object EndMatchingFaceList, Boolean DegeneratedStart, Boolean DegeneratedEnd, Object StartPointOfStartSection, Object StartPointOfEndSection, Int32 SectionIndexStart, Int32 SectionIndexEnd, Int32 GuideIndexStart, Int32 GuideIndexEnd)
        {
            return IModelerinstance.IModelerInstance.CreateLoftSurface(CurveArray, BBlendClosed, BForceCubic, GuideCrvArray, StartMatchingType, EndMatchingType, NormalAtStartSection, NormalAtEndSection, StartMatchingFaceList, EndMatchingFaceList, DegeneratedStart, DegeneratedEnd, StartPointOfStartSection, StartPointOfEndSection, SectionIndexStart, SectionIndexEnd, GuideIndexStart, GuideIndexEnd);
        }
        //public static ICurveObject ProjectCurveOnSurface(IModelerObject IModelerinstance, CurveObject CurveIn, SurfaceObject SurfaceIn, MathVectorObject ProjDir)
        //{
        //    return new ICurveObject(IModelerinstance.IModelerInstance.ProjectCurveOnSurface(CurveIn, SurfaceIn, ProjDir));
        //}
        //public static IBody2Object CreateExtrudedBody(IModelerObject IModelerinstance, Body2Object SheetBody, MathVectorObject Direction, Double Length)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.CreateExtrudedBody(SheetBody, Direction, Length));
        //}
        //public static Object CreateBodiesFromSheets2(IModelerObject IModelerinstance, Object Sheets, Int32 Options, Double KnittingTolerance, Int32& Error)
        //{
        //    return IModelerinstance.IModelerInstance.CreateBodiesFromSheets2(Sheets, Options, KnittingTolerance, Error);
        //}
        //public static Int32 ICreateBodiesFromSheets2(IModelerObject IModelerinstance, Int32 NSheets, Body2&Object Sheets, Int32 Options, Double KnittingTolerance, Int32& NResults, Body2&Object Results)
        //{
        //    return IModelerinstance.IModelerInstance.ICreateBodiesFromSheets2(NSheets, Sheets, Options, KnittingTolerance, NResults, Results);
        //}
        public static IBody2Object CreateBodyFromBox3(IModelerObject IModelerinstance, Object BoxDimArray)
        {
            return new IBody2Object(IModelerinstance.IModelerInstance.CreateBodyFromBox3(BoxDimArray));
        }
        //public static IBody2Object CreateLoftBody(IModelerObject IModelerinstance, ModelDoc2Object PModDoc, Boolean IsBlendClosed, Boolean KeepTangency, Boolean ForceNonRational, Boolean IsSolidBody, Double TessTolFactor, Int16 StartMatchingType, Int16 EndMatchingType)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.CreateLoftBody(PModDoc, IsBlendClosed, KeepTangency, ForceNonRational, IsSolidBody, TessTolFactor, StartMatchingType, EndMatchingType));
        //}
        //public static IBody2Object ThickenSheet(IModelerObject IModelerinstance, Body2Object Sheet, Double Thickness, Int32 Direction)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.ThickenSheet(Sheet, Thickness, Direction));
        //}
        //public static Boolean CheckInterference3(IModelerObject IModelerinstance, Object TargetBodies, Object ToolBodies, Int32 Options, Object& Body1InterferedFaceArray, Object& Body2InterferedFaceArray, Object& IntersectedBodyArray)
        //{
        //    return IModelerinstance.IModelerInstance.CheckInterference3(TargetBodies, ToolBodies, Options, Body1InterferedFaceArray, Body2InterferedFaceArray, IntersectedBodyArray);
        //}
        //public static Boolean ICheckInterference3(IModelerObject IModelerinstance, Face2&Object Body1InterferedFaceArray, Face2&Object Body2InterferedFaceArray, Body2&Object IntersectedBodyArray)
        //{
        //    return IModelerinstance.IModelerInstance.ICheckInterference3(Body1InterferedFaceArray, Body2InterferedFaceArray, IntersectedBodyArray);
        //}
        //public static Boolean ICheckInterferenceCount3(IModelerObject IModelerinstance, Int32 NumOfTargetBodies, Body2&Object TargetBodies, Int32 NumOfToolBodies, Body2&Object ToolBodies, Int32 Options, Int32& NumBody1InterferedFaceArray, Int32& NumBody2InterferedFaceArray, Int32& NumIntersectedBodyArray)
        //{
        //    return IModelerinstance.IModelerInstance.ICheckInterferenceCount3(NumOfTargetBodies, TargetBodies, NumOfToolBodies, ToolBodies, Options, NumBody1InterferedFaceArray, NumBody2InterferedFaceArray, NumIntersectedBodyArray);
        //}
        //public static Int32 CreateRuledSurfaceFromEdge(IModelerObject IModelerinstance, ModelDoc2Object ModDoc, Object Edges, Int32 Type, Double Length, Boolean FlipPullDir, Boolean FlipDir, Boolean TrimAndSew, Double Angle, Boolean CoordInput, Double X, Double Y, Double Z, Boolean BConnectSurface, Object& RuledSurface)
        //{
        //    return IModelerinstance.IModelerInstance.CreateRuledSurfaceFromEdge(ModDoc, Edges, Type, Length, FlipPullDir, FlipDir, TrimAndSew, Angle, CoordInput, X, Y, Z, BConnectSurface, RuledSurface);
        //}
        //public static Int32 ICreateRuledSurfaceFromEdge(IModelerObject IModelerinstance, ModelDoc2Object ModDoc, Int32 NumOfEdges, Edge&Object Edges, Int32 Type, Double Length, Boolean FlipPullDir, Boolean FlipDir, Boolean TrimAndSew, Double Angle, Boolean CoordInput, Double X, Double Y, Double Z, Boolean BConnectSurface, Body2&Object RuledSurface)
        //{
        //    return IModelerinstance.IModelerInstance.ICreateRuledSurfaceFromEdge(ModDoc, NumOfEdges, Edges, Type, Length, FlipPullDir, FlipDir, TrimAndSew, Angle, CoordInput, X, Y, Z, BConnectSurface, RuledSurface);
        //}
        //public static IBody2Object CreateLoftBody2(IModelerObject IModelerinstance, ModelDoc2Object PModDoc, Object Profile, Object GuideCurve, Object Centerline, Boolean IsThinBody, Int32 ThinType, Double Thickness1, Double Thickness2, Boolean FeatureScope, Boolean IsBlendClosed, Boolean KeepTangency, Boolean ForceNonRational, Boolean IsSolidBody, Double TessTolFactor, Double StartTangentLength, Double EndTangentLength, Boolean StartTangentDir, Boolean EndTangentDir, Int32 StartMatchingType, Int32 EndMatchingType, Boolean Merge)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.CreateLoftBody2(PModDoc, Profile, GuideCurve, Centerline, IsThinBody, ThinType, Thickness1, Thickness2, FeatureScope, IsBlendClosed, KeepTangency, ForceNonRational, IsSolidBody, TessTolFactor, StartTangentLength, EndTangentLength, StartTangentDir, EndTangentDir, StartMatchingType, EndMatchingType, Merge));
        //}
        //public static Int32 GetBodyOutline2(IModelerObject IModelerinstance, Object BodyList, MathVectorObject Direction, Double Tolerance, Boolean ProjectOnPlane, Object& Curves, Object& TopolEntities, Object& Outline)
        //{
        //    return IModelerinstance.IModelerInstance.GetBodyOutline2(BodyList, Direction, Tolerance, ProjectOnPlane, Curves, TopolEntities, Outline);
        //}
        public static Object CreateEllipse(IModelerObject IModelerinstance, Object Center, Double MajorRadius, Double MinorRadius, Object MajorAxis, Object MinorAxis)
        {
            return IModelerinstance.IModelerInstance.CreateEllipse(Center, MajorRadius, MinorRadius, MajorAxis, MinorAxis);
        }
        //public static ICurveObject ICreateEllipse(IModelerObject IModelerinstance, Double& Center, Double MajorRadius, Double MinorRadius, Double& MajorAxis, Double& MinorAxis)
        //{
        //    return new ICurveObject(IModelerinstance.IModelerInstance.ICreateEllipse(Center, MajorRadius, MinorRadius, MajorAxis, MinorAxis));
        //}
        //public static Boolean CheckInterferenceBetweenTwoBodies(IModelerObject IModelerinstance, Object Body1, Object Body2, Boolean CoincidentInterference, Object& Body1InterferedFaceArray, Object& Body2InterferedFaceArray, Object& IntersectedBodyArray)
        //{
        //    return IModelerinstance.IModelerInstance.CheckInterferenceBetweenTwoBodies(Body1, Body2, CoincidentInterference, Body1InterferedFaceArray, Body2InterferedFaceArray, IntersectedBodyArray);
        //}
        public static Object CreateBodyFromBox(IModelerObject IModelerinstance, Object BoxDimArray)
        {
            return IModelerinstance.IModelerInstance.CreateBodyFromBox(BoxDimArray);
        }
        //public static IBodyObject ICreateBodyFromBox(IModelerObject IModelerinstance, Double& BoxDimArray)
        //{
        //    return new IBodyObject(IModelerinstance.IModelerInstance.ICreateBodyFromBox(BoxDimArray));
        //}
        //public static Boolean SetTolerances(IModelerObject IModelerinstance, Int32& ToleranceIDArray, Double& ToleranceValueArray, Int32 NumTol)
        //{
        //    return IModelerinstance.IModelerInstance.SetTolerances(ToleranceIDArray, ToleranceValueArray, NumTol);
        //}
        //public static Boolean UnsetTolerances(IModelerObject IModelerinstance, Int32& ToleranceIDArray, Int32 NumTol)
        //{
        //    return IModelerinstance.IModelerInstance.UnsetTolerances(ToleranceIDArray, NumTol);
        //}
        public static Object Restore(IModelerObject IModelerinstance, Object StreamIn)
        {
            return IModelerinstance.IModelerInstance.Restore(StreamIn);
        }
        public static IBodyObject IRestore(IModelerObject IModelerinstance, Object StreamIn)
        {
            return new IBodyObject(IModelerinstance.IModelerInstance.IRestore(StreamIn));
        }
        public static Boolean SetInitKnitGapWidth(IModelerObject IModelerinstance, Double InitGapWidth)
        {
            return IModelerinstance.IModelerInstance.SetInitKnitGapWidth(InitGapWidth);
        }
        public static Double GetInitKnitGapWidth(IModelerObject IModelerinstance)
        {
            return IModelerinstance.IModelerInstance.GetInitKnitGapWidth();
        }
        public static Object CreateBodyFromCyl(IModelerObject IModelerinstance, Object CylDimArray)
        {
            return IModelerinstance.IModelerInstance.CreateBodyFromCyl(CylDimArray);
        }
        //public static IBodyObject ICreateBodyFromCyl(IModelerObject IModelerinstance, Double& CylDimArray)
        //{
        //    return new IBodyObject(IModelerinstance.IModelerInstance.ICreateBodyFromCyl(CylDimArray));
        //}
        public static Object CreateBodyFromCone(IModelerObject IModelerinstance, Object ConeDimArray)
        {
            return IModelerinstance.IModelerInstance.CreateBodyFromCone(ConeDimArray);
        }
        //public static IBodyObject ICreateBodyFromCone(IModelerObject IModelerinstance, Double& ConeDimArray)
        //{
        //    return new IBodyObject(IModelerinstance.IModelerInstance.ICreateBodyFromCone(ConeDimArray));
        //}
        public static Object CreateBrepBody(IModelerObject IModelerinstance, Int32 Type, Int32 NTopologies, Object Topologies, Object EdgeToleranceArray, Object VertexToleranceArray, Object PointArray, Object CurveArray, Object SurfaceArray, Int32 NRelations, Object Parents, Object Children, Object Senses)
        {
            return IModelerinstance.IModelerInstance.CreateBrepBody(Type, NTopologies, Topologies, EdgeToleranceArray, VertexToleranceArray, PointArray, CurveArray, SurfaceArray, NRelations, Parents, Children, Senses);
        }
        //public static IBodyObject ICreateBrepBody(IModelerObject IModelerinstance, Int32 Type, Int32 NTopologies, Int32& Topologies, Double& EdgeTolArray, Double& VertexTolArray, Double& PointArray, Curve&Object CurveArray, Surface&Object SurfaceArray, Int32 NRelations, Int32& Parents, Int32& Children, Int32& Senses)
        //{
        //    return new IBodyObject(IModelerinstance.IModelerInstance.ICreateBrepBody(Type, NTopologies, Topologies, EdgeTolArray, VertexTolArray, PointArray, CurveArray, SurfaceArray, NRelations, Parents, Children, Senses));
        //}
        public static Object CreatePlanarSurface(IModelerObject IModelerinstance, Object VRootPoint, Object VNormal)
        {
            return IModelerinstance.IModelerInstance.CreatePlanarSurface(VRootPoint, VNormal);
        }
        //public static ISurfaceObject ICreatePlanarSurface(IModelerObject IModelerinstance, Double& RootPoint, Double& Normal)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreatePlanarSurface(RootPoint, Normal));
        //}
        public static Object CreateExtrusionSurface(IModelerObject IModelerinstance, Object ProfileCurve, Object AxisDirection)
        {
            return IModelerinstance.IModelerInstance.CreateExtrusionSurface(ProfileCurve, AxisDirection);
        }
        //public static ISurfaceObject ICreateExtrusionSurface(IModelerObject IModelerinstance, CurveObject ProfileCurve, Double& AxisDirection)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreateExtrusionSurface(ProfileCurve, AxisDirection));
        //}
        public static Object CreateRevolutionSurface(IModelerObject IModelerinstance, Object ProfileCurve, Object AxisPoint, Object AxisDirection, Object ProfileEndPtParams)
        {
            return IModelerinstance.IModelerInstance.CreateRevolutionSurface(ProfileCurve, AxisPoint, AxisDirection, ProfileEndPtParams);
        }
        //public static ISurfaceObject ICreateRevolutionSurface(IModelerObject IModelerinstance, CurveObject ProfileCurve, Double& AxisPoint, Double& AxisDirection, Double& ProfileEndPtParams)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreateRevolutionSurface(ProfileCurve, AxisPoint, AxisDirection, ProfileEndPtParams));
        //}
        public static Object CreateBsplineSurface(IModelerObject IModelerinstance, Object Props, Object UKnots, Object VKnots, Object CtrlPtCoords)
        {
            return IModelerinstance.IModelerInstance.CreateBsplineSurface(Props, UKnots, VKnots, CtrlPtCoords);
        }
        //public static ISurfaceObject ICreateBsplineSurface(IModelerObject IModelerinstance, Int32& Properties, Double& UKnotArray, Double& VKnotArray, Double& ControlPointCoordArray)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreateBsplineSurface(Properties, UKnotArray, VKnotArray, ControlPointCoordArray));
        //}
        public static Object CreateOffsetSurface(IModelerObject IModelerinstance, Object SurfaceIn, Double Distance)
        {
            return IModelerinstance.IModelerInstance.CreateOffsetSurface(SurfaceIn, Distance);
        }
        //public static ISurfaceObject ICreateOffsetSurface(IModelerObject IModelerinstance, SurfaceObject SurfaceIn, Double Distance)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreateOffsetSurface(SurfaceIn, Distance));
        //}
        public static Object CreateLine(IModelerObject IModelerinstance, Object RootPoint, Object Direction)
        {
            return IModelerinstance.IModelerInstance.CreateLine(RootPoint, Direction);
        }
        //public static ICurveObject ICreateLine(IModelerObject IModelerinstance, Double& RootPoint, Double& Direction)
        //{
        //    return new ICurveObject(IModelerinstance.IModelerInstance.ICreateLine(RootPoint, Direction));
        //}
        public static Object CreateArc(IModelerObject IModelerinstance, Object Center, Object Axis, Double Radius, Object StartPoint, Object EndPoint)
        {
            return IModelerinstance.IModelerInstance.CreateArc(Center, Axis, Radius, StartPoint, EndPoint);
        }
        //public static ICurveObject ICreateArc(IModelerObject IModelerinstance, Double& Center, Double& Axis, Double Radius, Double& StartPoint, Double& EndPoint)
        //{
        //    return new ICurveObject(IModelerinstance.IModelerInstance.ICreateArc(Center, Axis, Radius, StartPoint, EndPoint));
        //}
        public static Object CreateBsplineCurve(IModelerObject IModelerinstance, Object Props, Object Knots, Object CtrlPtCoords)
        {
            return IModelerinstance.IModelerInstance.CreateBsplineCurve(Props, Knots, CtrlPtCoords);
        }
        //public static ICurveObject ICreateBsplineCurve(IModelerObject IModelerinstance, Int32& Properties, Double& KnotArray, Double& ControlPointCoordArray)
        //{
        //    return new ICurveObject(IModelerinstance.IModelerInstance.ICreateBsplineCurve(Properties, KnotArray, ControlPointCoordArray));
        //}
        public static Object CreatePCurve(IModelerObject IModelerinstance, Object Surface, Object Props, Object Knots, Object CtrlPtCoords)
        {
            return IModelerinstance.IModelerInstance.CreatePCurve(Surface, Props, Knots, CtrlPtCoords);
        }
        //public static ICurveObject ICreatePCurve(IModelerObject IModelerinstance, SurfaceObject Surface, Int32& Props, Double& Knots, Double& CtrlPtCoords)
        //{
        //    return new ICurveObject(IModelerinstance.IModelerInstance.ICreatePCurve(Surface, Props, Knots, CtrlPtCoords));
        //}
        //public static Object CreateBodiesFromSheets(IModelerObject IModelerinstance, Object Sheets, Int32 Options, Int32& Error)
        //{
        //    return IModelerinstance.IModelerInstance.CreateBodiesFromSheets(Sheets, Options, Error);
        //}
        //public static Int32 ICreateBodiesFromSheets(IModelerObject IModelerinstance, Int32 NSheets, Object& Sheets, Int32 Options, Int32& NResults, Object& Results)
        //{
        //    return IModelerinstance.IModelerInstance.ICreateBodiesFromSheets(NSheets, Sheets, Options, NResults, Results);
        //}
        //public static IBodyObject ICreateBodyFromFaces(IModelerObject IModelerinstance, Int32 NumOfFaces, Face&Object Faces, Boolean DoLocalCheck, Boolean& LocalCheckResult)
        //{
        //    return new IBodyObject(IModelerinstance.IModelerInstance.ICreateBodyFromFaces(NumOfFaces, Faces, DoLocalCheck, LocalCheckResult));
        //}
        public static Double FindTwoEdgeMaxDeviation(IModelerObject IModelerinstance, Object LpEdge1, Object LpEdge2)
        {
            return IModelerinstance.IModelerInstance.FindTwoEdgeMaxDeviation(LpEdge1, LpEdge2);
        }
        //public static Double IFindTwoEdgeMaxDeviation(IModelerObject IModelerinstance, EdgeObject PEdge1, EdgeObject PEdge2)
        //{
        //    return IModelerinstance.IModelerInstance.IFindTwoEdgeMaxDeviation(PEdge1, PEdge2);
        //}
        public static Object CreateConicalSurface(IModelerObject IModelerinstance, Object Center, Object Direction, Double Radius, Double SemiAngle)
        {
            return IModelerinstance.IModelerInstance.CreateConicalSurface(Center, Direction, Radius, SemiAngle);
        }
        //public static ISurfaceObject ICreateConicalSurface(IModelerObject IModelerinstance, Double& Center, Double& Direction, Double Radius, Double SemiAngle)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreateConicalSurface(Center, Direction, Radius, SemiAngle));
        //}
        public static Object CreateCylindricalSurface(IModelerObject IModelerinstance, Object Center, Object Direction, Double Radius)
        {
            return IModelerinstance.IModelerInstance.CreateCylindricalSurface(Center, Direction, Radius);
        }
        //public static ISurfaceObject ICreateCylindricalSurface(IModelerObject IModelerinstance, Double& Center, Double& Direction, Double Radius)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreateCylindricalSurface(Center, Direction, Radius));
        //}
        public static Object CreateSphericalSurface(IModelerObject IModelerinstance, Object Center, Double Radius)
        {
            return IModelerinstance.IModelerInstance.CreateSphericalSurface(Center, Radius);
        }
        //public static ISurfaceObject ICreateSphericalSurface(IModelerObject IModelerinstance, Double& Center, Double Radius)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreateSphericalSurface(Center, Radius));
        //}
        public static Object CreateToroidalSurface(IModelerObject IModelerinstance, Object Center, Object Axis, Object RefDirection, Double MajorRadius, Double MinorRadius)
        {
            return IModelerinstance.IModelerInstance.CreateToroidalSurface(Center, Axis, RefDirection, MajorRadius, MinorRadius);
        }
        //public static ISurfaceObject ICreateToroidalSurface(IModelerObject IModelerinstance, Double& Center, Double& Axis, Double& RefDirection, Double MajorRadius, Double MinorRadius)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreateToroidalSurface(Center, Axis, RefDirection, MajorRadius, MinorRadius));
        //}
        //public static Object CreateBodyFromFaces2(IModelerObject IModelerinstance, Int32 NumOfFaces, Object Faces, Int32 ActionType, Boolean DoLocalCheck, Boolean& LocalCheckResult)
        //{
        //    return IModelerinstance.IModelerInstance.CreateBodyFromFaces2(NumOfFaces, Faces, ActionType, DoLocalCheck, LocalCheckResult);
        //}
        //public static IBodyObject ICreateBodyFromFaces2(IModelerObject IModelerinstance, Int32 NumOfFaces, Face&Object Faces, Int32 ActionType, Boolean DoLocalCheck, Boolean& LocalCheckResult)
        //{
        //    return new IBodyObject(IModelerinstance.IModelerInstance.ICreateBodyFromFaces2(NumOfFaces, Faces, ActionType, DoLocalCheck, LocalCheckResult));
        //}
        public static Double SetToleranceValue(IModelerObject IModelerinstance, Int32 ToleranceID, Double NewToleranceValue)
        {
            return IModelerinstance.IModelerInstance.SetToleranceValue(ToleranceID, NewToleranceValue);
        }
        public static Double GetToleranceValue(IModelerObject IModelerinstance, Int32 ToleranceID)
        {
            return IModelerinstance.IModelerInstance.GetToleranceValue(ToleranceID);
        }
        public static Object CreateSheetFromSurface(IModelerObject IModelerinstance, Object SurfaceIn, Object UvRange)
        {
            return IModelerinstance.IModelerInstance.CreateSheetFromSurface(SurfaceIn, UvRange);
        }
        //public static IBodyObject ICreateSheetFromSurface(IModelerObject IModelerinstance, SurfaceObject SurfaceIn, Double& UvRange)
        //{
        //    return new IBodyObject(IModelerinstance.IModelerInstance.ICreateSheetFromSurface(SurfaceIn, UvRange));
        //}
        //public static Boolean ImprintingFaces(IModelerObject IModelerinstance, Object TargetFaceArray, Object ToolFaceArray, Int32 Options, Object& TargetEdges, Object& ToolEdges, Object& TargetVertices, Object& ToolVertices)
        //{
        //    return IModelerinstance.IModelerInstance.ImprintingFaces(TargetFaceArray, ToolFaceArray, Options, TargetEdges, ToolEdges, TargetVertices, ToolVertices);
        //}
        //public static void IImprintingFaces(IModelerObject IModelerinstance, Edge&Object TargetEdges, Edge&Object ToolEdges, Vertex&Object TargetVertices, Vertex&Object ToolVertices)
        //{
        //    return IModelerinstance.IModelerInstance.IImprintingFaces(TargetEdges, ToolEdges, TargetVertices, ToolVertices);
        //}
        //public static Boolean IImprintingFacesCount(IModelerObject IModelerinstance, Int32 NTargetFaces, Face&Object TargetFaceArray, Int32 NToolFaces, Face&Object ToolFaceArray, Int32 Options, Int32& NTargetEdges, Int32& NtoolEdges, Int32& NtargetVertices, Int32& ToolVertices)
        //{
        //    return IModelerinstance.IModelerInstance.IImprintingFacesCount(NTargetFaces, TargetFaceArray, NToolFaces, ToolFaceArray, Options, NTargetEdges, NtoolEdges, NtargetVertices, ToolVertices);
        //}
        public static Object CreateSweptSurface(IModelerObject IModelerinstance, Object CurveIn, Object Dir)
        {
            return IModelerinstance.IModelerInstance.CreateSweptSurface(CurveIn, Dir);
        }
        //public static ISurfaceObject ICreateSweptSurface(IModelerObject IModelerinstance, CurveObject CurveIn, Double& Dir)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreateSweptSurface(CurveIn, Dir));
        //}
        //public static Boolean ReplaceSurfaces(IModelerObject IModelerinstance, Int32 NFaces, Object FaceArray, Object NewSurfArray, Object SenseArray, Double Tolerance)
        //{
        //    return IModelerinstance.IModelerInstance.ReplaceSurfaces(NFaces, FaceArray, NewSurfArray, SenseArray, Tolerance);
        //}
        //public static Boolean IReplaceSurfaces(IModelerObject IModelerinstance, Int32 NFaces, Face&Object FaceArray, Surface&Object NewSurfArray, Int32& SenseArray, Double Tolerance)
        //{
        //    return IModelerinstance.IModelerInstance.IReplaceSurfaces(NFaces, FaceArray, NewSurfArray, SenseArray, Tolerance);
        //}
        //public static Object SplitFaceOnParam(IModelerObject IModelerinstance, Object Facedisp, Int32 UVFlag, Double Parameter, Boolean& Status)
        //{
        //    return IModelerinstance.IModelerInstance.SplitFaceOnParam(Facedisp, UVFlag, Parameter, Status);
        //}
        //public static Int32 ISplitFaceOnParamCount(IModelerObject IModelerinstance, FaceObject Facedisp, Int32 UVFlag, Double Parameter, Boolean& Status)
        //{
        //    return IModelerinstance.IModelerInstance.ISplitFaceOnParamCount(Facedisp, UVFlag, Parameter, Status);
        //}
        public static IFaceObject ISplitFaceOnParam(IModelerObject IModelerinstance)
        {
            return new IFaceObject(IModelerinstance.IModelerInstance.ISplitFaceOnParam());
        }
        //public static Boolean CheckInterference(IModelerObject IModelerinstance, Object Body1, Object Body2, Boolean CoincidentInterference, Object& Body1InterferedFaceArray, Object& Body2InterferedFaceArray, Object& IntersectedBodyArray)
        //{
        //    return IModelerinstance.IModelerInstance.CheckInterference(Body1, Body2, CoincidentInterference, Body1InterferedFaceArray, Body2InterferedFaceArray, IntersectedBodyArray);
        //}
        //public static Boolean ICheckInterferenceCount(IModelerObject IModelerinstance, BodyObject Body1, BodyObject Body2, Boolean CoincidentInterference, Int32& Body1InterferedFaceCount, Int32& Body2InterferedFaceCount, Int32& IntersectedBodyCount)
        //{
        //    return IModelerinstance.IModelerInstance.ICheckInterferenceCount(Body1, Body2, CoincidentInterference, Body1InterferedFaceCount, Body2InterferedFaceCount, IntersectedBodyCount);
        //}
        //public static void ICheckInterference(IModelerObject IModelerinstance, Face&Object Body1InterferedFaceArray, Face&Object Body2InterferedFaceArray, Body&Object IntersectedBodyArray)
        //{
        //    return IModelerinstance.IModelerInstance.ICheckInterference(Body1InterferedFaceArray, Body2InterferedFaceArray, IntersectedBodyArray);
        //}
        //public static Object CreateRuledSurface(IModelerObject IModelerinstance, Object Curve1In, Object Curve2In, Object Apex)
        //{
        //    return IModelerinstance.IModelerInstance.CreateRuledSurface(Curve1In, Curve2In, Apex);
        //}
        //public static ISurfaceObject ICreateRuledSurface(IModelerObject IModelerinstance, CurveObject Curve1In, CurveObject Curve2In, Double& Apex)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreateRuledSurface(Curve1In, Curve2In, Apex));
        //}
        public static Object CreateCylindricalSurface2(IModelerObject IModelerinstance, Object Center, Object Direction, Object RefDirection, Double Radius)
        {
            return IModelerinstance.IModelerInstance.CreateCylindricalSurface2(Center, Direction, RefDirection, Radius);
        }
        //public static ISurfaceObject ICreateCylindricalSurface2(IModelerObject IModelerinstance, Double& Center, Double& Direction, Double& RefDirection, Double Radius)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreateCylindricalSurface2(Center, Direction, RefDirection, Radius));
        //}
        public static Object CreateSphericalSurface2(IModelerObject IModelerinstance, Object Center, Object Axis, Object RefDir, Double Radius)
        {
            return IModelerinstance.IModelerInstance.CreateSphericalSurface2(Center, Axis, RefDir, Radius);
        }
        //public static ISurfaceObject ICreateSphericalSurface2(IModelerObject IModelerinstance, Double& Center, Double& Axis, Double& RefDir, Double Radius)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreateSphericalSurface2(Center, Axis, RefDir, Radius));
        //}
        //public static IBody2Object ICreateBodyFromBox2(IModelerObject IModelerinstance, Double& BoxDimArray)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.ICreateBodyFromBox2(BoxDimArray));
        //}
        public static IBody2Object IRestore2(IModelerObject IModelerinstance, Object StreamIn)
        {
            return new IBody2Object(IModelerinstance.IModelerInstance.IRestore2(StreamIn));
        }
        //public static IBody2Object ICreateBodyFromCyl2(IModelerObject IModelerinstance, Double& CylDimArray)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.ICreateBodyFromCyl2(CylDimArray));
        //}
        //public static IBody2Object ICreateBodyFromCone2(IModelerObject IModelerinstance, Double& ConeDimArray)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.ICreateBodyFromCone2(ConeDimArray));
        //}
        //public static IBody2Object ICreateBrepBody2(IModelerObject IModelerinstance, Int32 Type, Int32 NTopologies, Int32& Topologies, Double& EdgeTolArray, Double& VertexTolArray, Double& PointArray, Curve&Object CurveArray, Surface&Object SurfaceArray, Int32 NRelations, Int32& Parents, Int32& Children, Int32& Senses)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.ICreateBrepBody2(Type, NTopologies, Topologies, EdgeTolArray, VertexTolArray, PointArray, CurveArray, SurfaceArray, NRelations, Parents, Children, Senses));
        //}
        //public static IBody2Object ICreateSheetFromSurface2(IModelerObject IModelerinstance, SurfaceObject SurfaceIn, Double& UvRange)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.ICreateSheetFromSurface2(SurfaceIn, UvRange));
        //}
        //public static Boolean ICheckInterferenceCount2(IModelerObject IModelerinstance, Body2Object Body1, Body2Object Body2, Boolean CoincidentInterference, Int32& Body1InterferedFaceCount, Int32& Body2InterferedFaceCount, Int32& IntersectedBodyCount)
        //{
        //    return IModelerinstance.IModelerInstance.ICheckInterferenceCount2(Body1, Body2, CoincidentInterference, Body1InterferedFaceCount, Body2InterferedFaceCount, IntersectedBodyCount);
        //}
        //public static IBody2Object ICreateBodyFromFaces3(IModelerObject IModelerinstance, Int32 NumOfFaces, Face2&Object Faces, Int32 ActionType, Boolean DoLocalCheck, Boolean& LocalCheckResult)
        //{
        //    return new IBody2Object(IModelerinstance.IModelerInstance.ICreateBodyFromFaces3(NumOfFaces, Faces, ActionType, DoLocalCheck, LocalCheckResult));
        //}
        //public static Boolean IImprintingFacesCount2(IModelerObject IModelerinstance, Int32 NTargetFaces, Face2&Object TargetFaceArray, Int32 NToolFaces, Face2&Object ToolFaceArray, Int32 Options, Int32& NTargetEdges, Int32& NtoolEdges, Int32& NtargetVertices, Int32& ToolVertices)
        //{
        //    return IModelerinstance.IModelerInstance.IImprintingFacesCount2(NTargetFaces, TargetFaceArray, NToolFaces, ToolFaceArray, Options, NTargetEdges, NtoolEdges, NtargetVertices, ToolVertices);
        //}
        //public static Boolean IReplaceSurfaces2(IModelerObject IModelerinstance, Int32 NFaces, Face2&Object FaceArray, Surface&Object NewSurfArray, Int32& SenseArray, Double Tolerance)
        //{
        //    return IModelerinstance.IModelerInstance.IReplaceSurfaces2(NFaces, FaceArray, NewSurfArray, SenseArray, Tolerance);
        //}
        //public static Int32 ISplitFaceOnParamCount2(IModelerObject IModelerinstance, Face2Object Facedisp, Int32 UVFlag, Double Parameter, Boolean& Status)
        //{
        //    return IModelerinstance.IModelerInstance.ISplitFaceOnParamCount2(Facedisp, UVFlag, Parameter, Status);
        //}
        //public static IFace2Object ISplitFaceOnParam2(IModelerObject IModelerinstance)
        //{
        //    return new IFace2Object(IModelerinstance.IModelerInstance.ISplitFaceOnParam2());
        //}
        //public static void ICheckInterference2(IModelerObject IModelerinstance, Face2&Object Body1InterferedFaceArray, Face2&Object Body2InterferedFaceArray, Body2&Object IntersectedBodyArray)
        //{
        //    return IModelerinstance.IModelerInstance.ICheckInterference2(Body1InterferedFaceArray, Body2InterferedFaceArray, IntersectedBodyArray);
        //}
        public static Object CreatePlanarSurface2(IModelerObject IModelerinstance, Object VRootPoint, Object VNormal, Object VRef)
        {
            return IModelerinstance.IModelerInstance.CreatePlanarSurface2(VRootPoint, VNormal, VRef);
        }
        //public static ISurfaceObject ICreatePlanarSurface2(IModelerObject IModelerinstance, Double& RootPoint, Double& Normal, Double& Ref)
        //{
        //    return new ISurfaceObject(IModelerinstance.IModelerInstance.ICreatePlanarSurface2(RootPoint, Normal, Ref));
        //}
        public static Boolean GeneralTopology(IModelerObject IModelerinstance)
        {
            return IModelerinstance.IModelerInstance.GeneralTopology;
        }
    }
}