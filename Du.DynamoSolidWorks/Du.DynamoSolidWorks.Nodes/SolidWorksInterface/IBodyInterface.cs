

using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class IBodyObject
    {
        public IBody IBodyInstance { get; set; }
        public IBodyObject(IBody IBodyinstance)
        {
            IBodyInstance = IBodyinstance;
        }
    }

}


/*
 * 
 * 
 * IBody Interface not Modify to Support
 * 
 * 
 */

//using SolidWorks.Interop.sldworks;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using SolidWorks.Interop.swconst;
//using DynamoSolidWorks;
//using Du.SolidWorks.Extension;
//using Autodesk.DesignScript.Runtime;
//using Du.DynamoSolidWorks.Nodes;

//namespace DynamoSolidWorks
//{
//    public class IBodyObject
//    {
//        public IBody IBodyInstance { get; set; }
//        public IBodyObject(IBody IBodyinstance)
//        {
//            IBodyInstance = IBodyinstance;
//        }
//    }
//    public static class IBodyInterface
//    {
//        public static Int32 IOperations(IBodyObject IBodyinstance, Int32 OperationType, BodyObject ToolBody, Int32 NumMaxSections, Body&Object ResultingBodies)
//        {
//            return IBodyinstance.IBodyInstance.IOperations(OperationType, ToolBody, NumMaxSections, ResultingBodies);
//        }
//        public static Object GetSheetBody(IBodyObject IBodyinstance, Int32 Index)
//        {
//            return IBodyinstance.IBodyInstance.GetSheetBody(Index);
//        }
//        public static IBodyObject IGetSheetBody(IBodyObject IBodyinstance, Int32 Index)
//        {
//            return new IBodyObject(IBodyinstance.IBodyInstance.IGetSheetBody(Index));
//        }
//        public static Object GetProcessedBody(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.GetProcessedBody();
//        }
//        public static IBodyObject IGetProcessedBody(IBodyObject IBodyinstance)
//        {
//            return new IBodyObject(IBodyinstance.IBodyInstance.IGetProcessedBody());
//        }
//        public static Object GetProcessedBodyWithSelFace(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.GetProcessedBodyWithSelFace();
//        }
//        public static IBodyObject IGetProcessedBodyWithSelFace(IBodyObject IBodyinstance)
//        {
//            return new IBodyObject(IBodyinstance.IBodyInstance.IGetProcessedBodyWithSelFace());
//        }
//        public static Int32 Check(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.Check();
//        }
//        public static Object GetExcessBodyArray(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.GetExcessBodyArray();
//        }
//        public static IntPtr IGetExcessBodyArray(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.IGetExcessBodyArray();
//        }
//        public static Int32 IGetExcessBodyCount(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.IGetExcessBodyCount();
//        }
//        public static Boolean CreateBaseFeature(IBodyObject IBodyinstance, Object BodyIn)
//        {
//            return IBodyinstance.IBodyInstance.CreateBaseFeature(BodyIn);
//        }
//        public static Boolean ICreateBaseFeature(IBodyObject IBodyinstance, BodyObject BodyIn)
//        {
//            return IBodyinstance.IBodyInstance.ICreateBaseFeature(BodyIn);
//        }
//        public static Int32 DeleteFaces2(IBodyObject IBodyinstance, Int32 NumOfFaces, Object FaceList, Int32 Option)
//        {
//            return IBodyinstance.IBodyInstance.DeleteFaces2(NumOfFaces, FaceList, Option);
//        }
//        public static Int32 IDeleteFaces2(IBodyObject IBodyinstance, Int32 NumOfFaces, Face&Object FaceList, Int32 Option)
//        {
//            return IBodyinstance.IBodyInstance.IDeleteFaces2(NumOfFaces, FaceList, Option);
//        }
//        public static IVertexObject IAddVertexPoint(IBodyObject IBodyinstance, Double& Point)
//        {
//            return new IVertexObject(IBodyinstance.IBodyInstance.IAddVertexPoint(Point));
//        }
//        public static Object AddVertexPoint(IBodyObject IBodyinstance, Object Point)
//        {
//            return IBodyinstance.IBodyInstance.AddVertexPoint(Point);
//        }
//        public static Boolean GetExtremePoint(IBodyObject IBodyinstance, Double X, Double Y, Double Z, Double& Outx, Double& Outy, Double& Outz)
//        {
//            return IBodyinstance.IBodyInstance.GetExtremePoint(X, Y, Z, Outx, Outy, Outz);
//        }
//        public static Int32 GetType(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.GetType();
//        }
//        public static void IDeleteFaces3(IBodyObject IBodyinstance, Int32 NumOfFaces, Face&Object FaceList, Int32 Option, Boolean DoLocalCheck, Boolean& LocalCheckResult)
//        {
//            return IBodyinstance.IBodyInstance.IDeleteFaces3(NumOfFaces, FaceList, Option, DoLocalCheck, LocalCheckResult);
//        }
//        public static void SetCurrentSurface(IBodyObject IBodyinstance, Object SurfaceIn)
//        {
//            return IBodyinstance.IBodyInstance.SetCurrentSurface(SurfaceIn);
//        }
//        public static void ISetCurrentSurface(IBodyObject IBodyinstance, SurfaceObject SurfaceIn)
//        {
//            return IBodyinstance.IBodyInstance.ISetCurrentSurface(SurfaceIn);
//        }
//        public static Boolean DraftBody(IBodyObject IBodyinstance, Int32 NumOfFaces, Object FaceList, Object EdgeList, Double DraftAngle, Object Dir)
//        {
//            return IBodyinstance.IBodyInstance.DraftBody(NumOfFaces, FaceList, EdgeList, DraftAngle, Dir);
//        }
//        public static Boolean IDraftBody(IBodyObject IBodyinstance, Int32 NumOfFaces, Face&Object FaceList, Edge&Object EdgeList, Double DraftAngle, Double& Dir)
//        {
//            return IBodyinstance.IBodyInstance.IDraftBody(NumOfFaces, FaceList, EdgeList, DraftAngle, Dir);
//        }
//        public static Boolean DeleteBlends(IBodyObject IBodyinstance, Int32 NumOfFaces, Object FaceList)
//        {
//            return IBodyinstance.IBodyInstance.DeleteBlends(NumOfFaces, FaceList);
//        }
//        public static Boolean IDeleteBlends(IBodyObject IBodyinstance, Int32 NumOfFaces, Face&Object FaceList)
//        {
//            return IBodyinstance.IBodyInstance.IDeleteBlends(NumOfFaces, FaceList);
//        }
//        public static Object Operations2(IBodyObject IBodyinstance, Int32 OperationType, Object ToolBody, Int32& ErrorCode)
//        {
//            return IBodyinstance.IBodyInstance.Operations2(OperationType, ToolBody, ErrorCode);
//        }
//        public static IEnumBodiesObject IOperations2(IBodyObject IBodyinstance, Int32 OperationType, BodyObject ToolBody, Int32& ErrorCode)
//        {
//            return new IEnumBodiesObject(IBodyinstance.IBodyInstance.IOperations2(OperationType, ToolBody, ErrorCode));
//        }
//        public static Object GetBodyBox(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.GetBodyBox();
//        }
//        public static Boolean DeleteBlends2(IBodyObject IBodyinstance, Int32 NumOfFaces, Object FaceList, Boolean DoLocalCheck)
//        {
//            return IBodyinstance.IBodyInstance.DeleteBlends2(NumOfFaces, FaceList, DoLocalCheck);
//        }
//        public static Boolean IDeleteBlends2(IBodyObject IBodyinstance, Int32 NumOfFaces, Face&Object FaceList, Boolean DoLocalCheck)
//        {
//            return IBodyinstance.IBodyInstance.IDeleteBlends2(NumOfFaces, FaceList, DoLocalCheck);
//        }
//        public static Object GetTessellation(IBodyObject IBodyinstance, Object FaceList)
//        {
//            return IBodyinstance.IBodyInstance.GetTessellation(FaceList);
//        }
//        public static ITessellationObject IGetTessellation(IBodyObject IBodyinstance, Int32 NumOfFaces, Face&Object FaceList)
//        {
//            return new ITessellationObject(IBodyinstance.IBodyInstance.IGetTessellation(NumOfFaces, FaceList));
//        }
//        public static Object MatchedBoolean(IBodyObject IBodyinstance, Int32 OperationType, Object ToolBody, Int32 NumOfMatchingFaces, Object FaceList1, Object FaceList2, Int32& ErrorCode)
//        {
//            return IBodyinstance.IBodyInstance.MatchedBoolean(OperationType, ToolBody, NumOfMatchingFaces, FaceList1, FaceList2, ErrorCode);
//        }
//        public static IEnumBodiesObject IMatchedBoolean(IBodyObject IBodyinstance, Int32 OperationType, BodyObject ToolBody, Int32 NumOfMatchingFaces, Face&Object FaceList1, Face&Object FaceList2, Int32& ErrorCode)
//        {
//            return new IEnumBodiesObject(IBodyinstance.IBodyInstance.IMatchedBoolean(OperationType, ToolBody, NumOfMatchingFaces, FaceList1, FaceList2, ErrorCode));
//        }
//        public static Int32 GetEdgeCount(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.GetEdgeCount();
//        }
//        public static Object GetFirstFace(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.GetFirstFace();
//        }
//        public static IFaceObject IGetFirstFace(IBodyObject IBodyinstance)
//        {
//            return new IFaceObject(IBodyinstance.IBodyInstance.IGetFirstFace());
//        }
//        public static Int32 GetFaceCount(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.GetFaceCount();
//        }
//        public static Object CreateNewSurface(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.CreateNewSurface();
//        }
//        public static ISurfaceObject ICreateNewSurface(IBodyObject IBodyinstance)
//        {
//            return new ISurfaceObject(IBodyinstance.IBodyInstance.ICreateNewSurface());
//        }
//        public static Boolean CreateBodyFromSurfaces(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.CreateBodyFromSurfaces();
//        }
//        public static Object CreatePlanarSurface(IBodyObject IBodyinstance, Object VRootPoint, Object VNormal)
//        {
//            return IBodyinstance.IBodyInstance.CreatePlanarSurface(VRootPoint, VNormal);
//        }
//        public static ISurfaceObject ICreatePlanarSurface(IBodyObject IBodyinstance, Object VRootPoint, Object VNormal)
//        {
//            return new ISurfaceObject(IBodyinstance.IBodyInstance.ICreatePlanarSurface(VRootPoint, VNormal));
//        }
//        public static Object CreateRevolutionSurface(IBodyObject IBodyinstance, Object ProfileCurve, Object AxisPoint, Object AxisDirection, Object ProfileEndPtParams)
//        {
//            return IBodyinstance.IBodyInstance.CreateRevolutionSurface(ProfileCurve, AxisPoint, AxisDirection, ProfileEndPtParams);
//        }
//        public static ISurfaceObject ICreateRevolutionSurface(IBodyObject IBodyinstance, CurveObject ProfileCurve, Object AxisPoint, Object AxisDirection, Object ProfileEndPtParams)
//        {
//            return new ISurfaceObject(IBodyinstance.IBodyInstance.ICreateRevolutionSurface(ProfileCurve, AxisPoint, AxisDirection, ProfileEndPtParams));
//        }
//        public static Object CreateBsplineSurface(IBodyObject IBodyinstance, Object Props, Object UKnots, Object VKnots, Object CtrlPtCoords)
//        {
//            return IBodyinstance.IBodyInstance.CreateBsplineSurface(Props, UKnots, VKnots, CtrlPtCoords);
//        }
//        public static ISurfaceObject ICreateBsplineSurface(IBodyObject IBodyinstance, Object Props, Object UKnots, Object VKnots, Object CtrlPtCoords)
//        {
//            return new ISurfaceObject(IBodyinstance.IBodyInstance.ICreateBsplineSurface(Props, UKnots, VKnots, CtrlPtCoords));
//        }
//        public static Boolean CreateTrimmedSurface(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.CreateTrimmedSurface();
//        }
//        public static Object AddProfileLine(IBodyObject IBodyinstance, Object RootPoint, Object Direction)
//        {
//            return IBodyinstance.IBodyInstance.AddProfileLine(RootPoint, Direction);
//        }
//        public static ICurveObject IAddProfileLine(IBodyObject IBodyinstance, Object RootPoint, Object Direction)
//        {
//            return new ICurveObject(IBodyinstance.IBodyInstance.IAddProfileLine(RootPoint, Direction));
//        }
//        public static Object AddProfileArc(IBodyObject IBodyinstance, Object Center, Object Axis, Double Radius, Object StartPoint, Object EndPoint)
//        {
//            return IBodyinstance.IBodyInstance.AddProfileArc(Center, Axis, Radius, StartPoint, EndPoint);
//        }
//        public static ICurveObject IAddProfileArc(IBodyObject IBodyinstance, Object Center, Object Axis, Double Radius, Object StartPoint, Object EndPoint)
//        {
//            return new ICurveObject(IBodyinstance.IBodyInstance.IAddProfileArc(Center, Axis, Radius, StartPoint, EndPoint));
//        }
//        public static Object AddProfileBspline(IBodyObject IBodyinstance, Object Props, Object Knots, Object CtrlPtCoords)
//        {
//            return IBodyinstance.IBodyInstance.AddProfileBspline(Props, Knots, CtrlPtCoords);
//        }
//        public static ICurveObject IAddProfileBspline(IBodyObject IBodyinstance, Object Props, Object Knots, Object CtrlPtCoords)
//        {
//            return new ICurveObject(IBodyinstance.IBodyInstance.IAddProfileBspline(Props, Knots, CtrlPtCoords));
//        }
//        public static Object CreateExtrusionSurface(IBodyObject IBodyinstance, Object ProfileCurve, Object AxisDirection)
//        {
//            return IBodyinstance.IBodyInstance.CreateExtrusionSurface(ProfileCurve, AxisDirection);
//        }
//        public static ISurfaceObject ICreateExtrusionSurface(IBodyObject IBodyinstance, CurveObject ProfileCurve, Object AxisDirection)
//        {
//            return new ISurfaceObject(IBodyinstance.IBodyInstance.ICreateExtrusionSurface(ProfileCurve, AxisDirection));
//        }
//        public static Object GetFirstSelectedFace(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.GetFirstSelectedFace();
//        }
//        public static IFaceObject IGetFirstSelectedFace(IBodyObject IBodyinstance)
//        {
//            return new IFaceObject(IBodyinstance.IBodyInstance.IGetFirstSelectedFace());
//        }
//        public static Object GetNextSelectedFace(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.GetNextSelectedFace();
//        }
//        public static IFaceObject IGetNextSelectedFace(IBodyObject IBodyinstance)
//        {
//            return new IFaceObject(IBodyinstance.IBodyInstance.IGetNextSelectedFace());
//        }
//        public static Int32 GetSelectedFaceCount(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.GetSelectedFaceCount();
//        }
//        public static Boolean CreateBoundedSurface(IBodyObject IBodyinstance, Boolean UOpt, Boolean VOpt, Object UvParams)
//        {
//            return IBodyinstance.IBodyInstance.CreateBoundedSurface(UOpt, VOpt, UvParams);
//        }
//        public static Int32 GetIgesErrorCount(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.GetIgesErrorCount();
//        }
//        public static Int32 GetIgesErrorCode(IBodyObject IBodyinstance, Int32 Index)
//        {
//            return IBodyinstance.IBodyInstance.GetIgesErrorCode(Index);
//        }
//        public static Object Copy(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.Copy();
//        }
//        public static IBodyObject ICopy(IBodyObject IBodyinstance)
//        {
//            return new IBodyObject(IBodyinstance.IBodyInstance.ICopy());
//        }
//        public static IEnumFacesObject EnumFaces(IBodyObject IBodyinstance)
//        {
//            return new IEnumFacesObject(IBodyinstance.IBodyInstance.EnumFaces());
//        }
//        public static Object CreateBodyFromFaces(IBodyObject IBodyinstance, Int32 NumOfFaces, Object FaceList)
//        {
//            return IBodyinstance.IBodyInstance.CreateBodyFromFaces(NumOfFaces, FaceList);
//        }
//        public static IBodyObject ICreateBodyFromFaces(IBodyObject IBodyinstance, Int32 NumOfFaces, Object FaceList)
//        {
//            return new IBodyObject(IBodyinstance.IBodyInstance.ICreateBodyFromFaces(NumOfFaces, FaceList));
//        }
//        public static Boolean DeleteFaces(IBodyObject IBodyinstance, Int32 NumOfFaces, Object FaceList)
//        {
//            return IBodyinstance.IBodyInstance.DeleteFaces(NumOfFaces, FaceList);
//        }
//        public static void Display(IBodyObject IBodyinstance, Object Part, Int32 Color)
//        {
//            return IBodyinstance.IBodyInstance.Display(Part, Color);
//        }
//        public static void IDisplay(IBodyObject IBodyinstance, PartDocObject Part, Int32 Color)
//        {
//            return IBodyinstance.IBodyInstance.IDisplay(Part, Color);
//        }
//        public static void Hide(IBodyObject IBodyinstance, Object Part)
//        {
//            return IBodyinstance.IBodyInstance.Hide(Part);
//        }
//        public static void IHide(IBodyObject IBodyinstance, PartDocObject Part)
//        {
//            return IBodyinstance.IBodyInstance.IHide(Part);
//        }
//        public static ISurfaceObject ICreatePlanarSurfaceDLL(IBodyObject IBodyinstance, Double& RootPoint, Double& Normal)
//        {
//            return new ISurfaceObject(IBodyinstance.IBodyInstance.ICreatePlanarSurfaceDLL(RootPoint, Normal));
//        }
//        public static ISurfaceObject ICreateRevolutionSurfaceDLL(IBodyObject IBodyinstance, CurveObject ProfileCurve, Double& AxisPoint, Double& AxisDirection, Double& ProfileEndPtParams)
//        {
//            return new ISurfaceObject(IBodyinstance.IBodyInstance.ICreateRevolutionSurfaceDLL(ProfileCurve, AxisPoint, AxisDirection, ProfileEndPtParams));
//        }
//        public static ICurveObject IAddProfileLineDLL(IBodyObject IBodyinstance, Double& RootPoint, Double& Direction)
//        {
//            return new ICurveObject(IBodyinstance.IBodyInstance.IAddProfileLineDLL(RootPoint, Direction));
//        }
//        public static ICurveObject IAddProfileArcDLL(IBodyObject IBodyinstance, Double& Center, Double& Axis, Double Radius, Double& StartPoint, Double& EndPoint)
//        {
//            return new ICurveObject(IBodyinstance.IBodyInstance.IAddProfileArcDLL(Center, Axis, Radius, StartPoint, EndPoint));
//        }
//        public static ISurfaceObject ICreateBsplineSurfaceDLL(IBodyObject IBodyinstance, Int32& Properties, Double& UKnotArray, Double& VKnotArray, Double& ControlPointCoordArray)
//        {
//            return new ISurfaceObject(IBodyinstance.IBodyInstance.ICreateBsplineSurfaceDLL(Properties, UKnotArray, VKnotArray, ControlPointCoordArray));
//        }
//        public static ICurveObject IAddProfileBsplineDLL(IBodyObject IBodyinstance, Int32& Properties, Double& KnotArray, Double& ControlPointCoordArray)
//        {
//            return new ICurveObject(IBodyinstance.IBodyInstance.IAddProfileBsplineDLL(Properties, KnotArray, ControlPointCoordArray));
//        }
//        public static ISurfaceObject ICreateExtrusionSurfaceDLL(IBodyObject IBodyinstance, CurveObject ProfileCurve, Double& AxisDirection)
//        {
//            return new ISurfaceObject(IBodyinstance.IBodyInstance.ICreateExtrusionSurfaceDLL(ProfileCurve, AxisDirection));
//        }
//        public static void ICreateBoundedSurface(IBodyObject IBodyinstance, Boolean UOpt, Boolean VOpt, Double& UvParams)
//        {
//            return IBodyinstance.IBodyInstance.ICreateBoundedSurface(UOpt, VOpt, UvParams);
//        }
//        public static void ICombineVolumes(IBodyObject IBodyinstance, BodyObject ToolBody)
//        {
//            return IBodyinstance.IBodyInstance.ICombineVolumes(ToolBody);
//        }
//        public static Int32 ISectionBySheet(IBodyObject IBodyinstance, BodyObject Sheet, Int32 NumMaxSections, Body&Object SectionedBodies)
//        {
//            return IBodyinstance.IBodyInstance.ISectionBySheet(Sheet, NumMaxSections, SectionedBodies);
//        }
//        public static void IGetBodyBox(IBodyObject IBodyinstance, Double& BoxCorners)
//        {
//            return IBodyinstance.IBodyInstance.IGetBodyBox(BoxCorners);
//        }
//        public static void SetIgesInfo(IBodyObject IBodyinstance, String SystemName, Double Granularity, Boolean AttemptKnitting)
//        {
//            return IBodyinstance.IBodyInstance.SetIgesInfo(SystemName, Granularity, AttemptKnitting);
//        }
//        public static void DisplayWireFrameXOR(IBodyObject IBodyinstance, Object Part, Int32 Color)
//        {
//            return IBodyinstance.IBodyInstance.DisplayWireFrameXOR(Part, Color);
//        }
//        public static void IDisplayWireFrameXOR(IBodyObject IBodyinstance, PartDocObject Part, Int32 Color)
//        {
//            return IBodyinstance.IBodyInstance.IDisplayWireFrameXOR(Part, Color);
//        }
//        public static void Save(IBodyObject IBodyinstance, Object StreamIn)
//        {
//            return IBodyinstance.IBodyInstance.Save(StreamIn);
//        }
//        public static void ISave(IBodyObject IBodyinstance, Object StreamIn)
//        {
//            return IBodyinstance.IBodyInstance.ISave(StreamIn);
//        }
//        public static Object CreateBlendSurface(IBodyObject IBodyinstance, Object Surface1, Double Range1, Object Surface2, Double Range2, Object StartVec, Object EndVec, Int32 HaveHelpVec, Object HelpVec, Int32 HaveHelpBox, Object HelpBox)
//        {
//            return IBodyinstance.IBodyInstance.CreateBlendSurface(Surface1, Range1, Surface2, Range2, StartVec, EndVec, HaveHelpVec, HelpVec, HaveHelpBox, HelpBox);
//        }
//        public static ISurfaceObject ICreateBlendSurface(IBodyObject IBodyinstance, SurfaceObject Surface1, Double Range1, SurfaceObject Surface2, Double Range2, Double& StartVec, Double& EndVec, Int32 HaveHelpVec, Double& HelpVec, Int32 HaveHelpBox, Double& HelpBox)
//        {
//            return new ISurfaceObject(IBodyinstance.IBodyInstance.ICreateBlendSurface(Surface1, Range1, Surface2, Range2, StartVec, EndVec, HaveHelpVec, HelpVec, HaveHelpBox, HelpBox));
//        }
//        public static Object CreateOffsetSurface(IBodyObject IBodyinstance, Object SurfaceIn, Double Distance)
//        {
//            return IBodyinstance.IBodyInstance.CreateOffsetSurface(SurfaceIn, Distance);
//        }
//        public static ISurfaceObject ICreateOffsetSurface(IBodyObject IBodyinstance, SurfaceObject SurfaceIn, Double Distance)
//        {
//            return new ISurfaceObject(IBodyinstance.IBodyInstance.ICreateOffsetSurface(SurfaceIn, Distance));
//        }
//        public static Boolean RemoveRedundantTopology(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.RemoveRedundantTopology();
//        }
//        public static Object GetIntersectionEdges(IBodyObject IBodyinstance, Object ToolBodyIn)
//        {
//            return IBodyinstance.IBodyInstance.GetIntersectionEdges(ToolBodyIn);
//        }
//        public static IntPtr IGetIntersectionEdges(IBodyObject IBodyinstance, BodyObject ToolBodyIn)
//        {
//            return IBodyinstance.IBodyInstance.IGetIntersectionEdges(ToolBodyIn);
//        }
//        public static Int32 IGetIntersectionEdgeCount(IBodyObject IBodyinstance, BodyObject ToolBodyIn)
//        {
//            return IBodyinstance.IBodyInstance.IGetIntersectionEdgeCount(ToolBodyIn);
//        }
//        public static void RemoveFacesFromSheet(IBodyObject IBodyinstance, Int32 NumOfFaces, Object FacesToRemove)
//        {
//            return IBodyinstance.IBodyInstance.RemoveFacesFromSheet(NumOfFaces, FacesToRemove);
//        }
//        public static void IRemoveFacesFromSheet(IBodyObject IBodyinstance, Int32 NumOfFaces, IntPtr FacesToRemove)
//        {
//            return IBodyinstance.IBodyInstance.IRemoveFacesFromSheet(NumOfFaces, FacesToRemove);
//        }
//        public static void ICreatePlanarTrimSurfaceDLL(IBodyObject IBodyinstance, Int32 VertexCount, Double& Points, Double& Normal)
//        {
//            return IBodyinstance.IBodyInstance.ICreatePlanarTrimSurfaceDLL(VertexCount, Points, Normal);
//        }
//        public static Int32 AddPropertyExtension(IBodyObject IBodyinstance, Object PropertyExtension)
//        {
//            return IBodyinstance.IBodyInstance.AddPropertyExtension(PropertyExtension);
//        }
//        public static Object GetPropertyExtension(IBodyObject IBodyinstance, Int32 ID)
//        {
//            return IBodyinstance.IBodyInstance.GetPropertyExtension(ID);
//        }
//        public static void ResetPropertyExtension(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.ResetPropertyExtension();
//        }
//        public static String GetMaterialIdName(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.GetMaterialIdName();
//        }
//        public static Boolean SetMaterialIdName(IBodyObject IBodyinstance, String Name)
//        {
//            return IBodyinstance.IBodyInstance.SetMaterialIdName(Name);
//        }
//        public static String GetMaterialUserName(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.GetMaterialUserName();
//        }
//        public static Boolean SetMaterialUserName(IBodyObject IBodyinstance, String Name)
//        {
//            return IBodyinstance.IBodyInstance.SetMaterialUserName(Name);
//        }
//        public static Object GetMassProperties(IBodyObject IBodyinstance, Double Density)
//        {
//            return IBodyinstance.IBodyInstance.GetMassProperties(Density);
//        }
//        public static Double IGetMassProperties(IBodyObject IBodyinstance, Double Density)
//        {
//            return IBodyinstance.IBodyInstance.IGetMassProperties(Density);
//        }
//        public static ISurfaceObject ICreatePsplineSurfaceDLL(IBodyObject IBodyinstance, Int32 Dim, Int32 UOrder, Int32 VOrder, Int32 Ncol, Int32 Nrow, Double& Coeffs, Int32 Basis, Double& Xform, Double ScaleFactor)
//        {
//            return new ISurfaceObject(IBodyinstance.IBodyInstance.ICreatePsplineSurfaceDLL(Dim, UOrder, VOrder, Ncol, Nrow, Coeffs, Basis, Xform, ScaleFactor));
//        }
//        public static Boolean SetXform(IBodyObject IBodyinstance, Object XformIn)
//        {
//            return IBodyinstance.IBodyInstance.SetXform(XformIn);
//        }
//        public static Boolean ISetXform(IBodyObject IBodyinstance, Double& XformIn)
//        {
//            return IBodyinstance.IBodyInstance.ISetXform(XformIn);
//        }
//        public static Object CreateTempBodyFromSurfaces(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.CreateTempBodyFromSurfaces();
//        }
//        public static IBodyObject ICreateTempBodyFromSurfaces(IBodyObject IBodyinstance)
//        {
//            return new IBodyObject(IBodyinstance.IBodyInstance.ICreateTempBodyFromSurfaces());
//        }
//        public static Object Operations(IBodyObject IBodyinstance, Int32 OperationType, Object ToolBody, Int32 NumMaxSections)
//        {
//            return IBodyinstance.IBodyInstance.Operations(OperationType, ToolBody, NumMaxSections);
//        }
//        public static Object MaterialPropertyValues(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.MaterialPropertyValues;
//        }
//        public static Double IMaterialPropertyValues(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.IMaterialPropertyValues;
//        }
//        public static Boolean Visible(IBodyObject IBodyinstance)
//        {
//            return IBodyinstance.IBodyInstance.Visible;
//        }
//    }
//}
