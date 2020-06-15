using Autodesk.DesignScript.Runtime;
using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;

namespace DynamoSolidWorks
{
    public class IBody2Object
    {
        public IBody2 IBody2Instance { get; set; }
        public IBody2Object(IBody2 IBody2instance)
        {
            IBody2Instance = IBody2instance;
        }
    }
    public static class IBody2Interface
    {
        //ref not solve
        public static IBody2Object IExtendSurface(IBody2Object IBody2instance, Int32 EdgeCount, IEdgeObject EdgesToExtend, Boolean ExtendLinear, Int32 EndCondition, Double Dist, IVertexObject PUpToVtx, IFaceObject PUpToFace)
        {
            Edge edge = EdgesToExtend.IEdgeInstance.CastObj<Edge>();
            return new IBody2Object(IBody2instance.IBody2Instance.IExtendSurface(EdgeCount, ref edge, ExtendLinear, EndCondition, Dist, PUpToVtx.IVertexInstance as Vertex, PUpToFace.IFaceInstance as Face));
        }
        public static IBody2Object OffsetPlanarWireBody(IBody2Object IBody2instance, Double Distance, IMathVectorObject Normal, Int32 Option)
        {
            return new IBody2Object(IBody2instance.IBody2Instance.OffsetPlanarWireBody(Distance, Normal.IMathVectorInstance as MathVector, Option));
        }
        public static Object AddConstantFillets(IBody2Object IBody2instance, Double Radius, Object EdgesToFillet)
        {
            return IBody2instance.IBody2Instance.AddConstantFillets(Radius, EdgesToFillet);
        }
        public static Boolean DraftBody2(IBody2Object IBody2instance, Int32 NumOfFaces, Object FaceList, Object EdgeList, Object BasePoint, Double DraftAngle, Object Dir)
        {
            return IBody2instance.IBody2Instance.DraftBody2(NumOfFaces, FaceList, EdgeList, BasePoint, DraftAngle, Dir);
        }
        //public static Boolean IDraftBody2(IBody2Object IBody2instance, Int32 NumOfFaces, Face2&Object FaceList, Edge&Object EdgeList, MathPointObject BasePoint, Double DraftAngle, Double& Dir)
        //{
        //    return IBody2instance.IBody2Instance.IDraftBody2(NumOfFaces, FaceList, EdgeList, BasePoint, DraftAngle, Dir);
        //}
        public static Boolean Negate(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.Negate();
        }
        public static Int32 Display3(IBody2Object IBody2instance, Object Component, Int32 Color, Int32 Option)
        {
            return IBody2instance.IBody2Instance.Display3(Component, Color, Option);
        }
        public static Double MinimumRadius(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.MinimumRadius();
        }
        public static void ResetEdgeTolerances(IBody2Object IBody2instance)
        {
            IBody2instance.IBody2Instance.ResetEdgeTolerances();
        }
        public static Boolean Select2(IBody2Object IBody2instance, Boolean Append, ISelectDataObject Data)
        {
            return IBody2instance.IBody2Instance.Select2(Append, Data.ISelectDataInstance as SelectData);
        }
        public static Int32 GetVertexCount(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetVertexCount();
        }
        public static Object GetVertices(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetVertices();
        }
        public static IVertexObject IGetVertices(IBody2Object IBody2instance, Int32 Count)
        {
            return new IVertexObject(IBody2instance.IBody2Instance.IGetVertices(Count));
        }
        //public static Boolean GetCoincidenceTransform(IBody2Object IBody2instance, Object BodyDispIn, MathTransform&Object Xform)
        //{
        //    return IBody2instance.IBody2Instance.GetCoincidenceTransform(BodyDispIn, Xform);
        //}
        public static Boolean IsPatternSeed(IBody2Object IBody2instance, Object BodyDispIn)
        {
            return IBody2instance.IBody2Instance.IsPatternSeed(BodyDispIn);
        }
        public static Boolean RemoveMaterialProperty(IBody2Object IBody2instance, Int32 Config_opt, Object Config_names)
        {
            return IBody2instance.IBody2Instance.RemoveMaterialProperty(Config_opt, Config_names);
        }
        //public static Boolean IRemoveMaterialProperty(IBody2Object IBody2instance, Int32 Config_opt, Int32 Config_count, String& Config_names)
        //{
        //    return IBody2instance.IBody2Instance.IRemoveMaterialProperty(Config_opt, Config_count, Config_names);
        //}
        //public static Object MatchedBoolean4(IBody2Object IBody2instance, Int32 OperationType, Object ToolBody, Int32 NumOfMatchingFaces, Object FaceList1, Object FaceList2, Double MatchingTolerance, Int32& ErrorCode)
        //{
        //    return IBody2instance.IBody2Instance.MatchedBoolean4(OperationType, ToolBody, NumOfMatchingFaces, FaceList1, FaceList2, MatchingTolerance, ErrorCode);
        //}
        //public static IEnumBodies2Object IMatchedBoolean4(IBody2Object IBody2instance, Int32 OperationType, Int32 ToolBodyCount, Body2&Object ToolBodyArr, Int32 NumOfMatchingFaces, Face2&Object FaceList1, Face2&Object FaceList2, Double MatchingTolerance, Int32& ErrorCode)
        //{
        //    return new IEnumBodies2Object(IBody2instance.IBody2Instance.IMatchedBoolean4(OperationType, ToolBodyCount, ToolBodyArr, NumOfMatchingFaces, FaceList1, FaceList2, MatchingTolerance, ErrorCode));
        //}
        public static Object GetFaces(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetFaces();
        }
        public static IFace2Object IGetFaces(IBody2Object IBody2instance, Int32 Count)
        {
            return new IFace2Object(IBody2instance.IBody2Instance.IGetFaces(Count));
        }
        public static Boolean IsSheetMetal(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.IsSheetMetal();
        }

        [MultiReturn(SWValueConst.Result, SWValueConst.TrackingIDs)]
        public static Dictionary<string, object> GetTrackingIDs(IBody2Object IBody2instance, Int32 TrackingCookie)
        {
            var result = IBody2instance.IBody2Instance.GetTrackingIDs(TrackingCookie, out object TrackingIDs);
            return new Dictionary<string, object>() { { SWValueConst.Result, result }, { SWValueConst.TrackingIDs, TrackingIDs } };
        }
        public static Int32 SetTrackingID(IBody2Object IBody2instance, Int32 TrackingCookie, Int32 TrackingID)
        {
            return IBody2instance.IBody2Instance.SetTrackingID(TrackingCookie, TrackingID);
        }
        public static Int32 RemoveTrackingID(IBody2Object IBody2instance, Int32 TrackingCookie)
        {
            return IBody2instance.IBody2Instance.RemoveTrackingID(TrackingCookie);
        }
        //public static Int32 GetMiddleSurface(IBody2Object IBody2instance, Double PlacementPercentage, Object& Face1List, Object& Face2List, Object& Thickness, Object& MiddleSurfaceBody)
        //{
        //    return IBody2instance.IBody2Instance.GetMiddleSurface(PlacementPercentage, Face1List, Face2List, Thickness, MiddleSurfaceBody);
        //}
        //public static Int32 IGetMiddleSurface(IBody2Object IBody2instance, Double PlacementPercentage, Object& Face1List, Object& Face2List, Object& Thickness, Body2&Object MiddleSurfaceBody)
        //{
        //    return IBody2instance.IBody2Instance.IGetMiddleSurface(PlacementPercentage, Face1List, Face2List, Thickness, MiddleSurfaceBody);
        //}
        public static Object GetSelectedFaces(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetSelectedFaces();
        }
        public static IFace2Object IGetSelectedFaces(IBody2Object IBody2instance, Int32 SelectedFaceCount)
        {
            return new IFace2Object(IBody2instance.IBody2Instance.IGetSelectedFaces(SelectedFaceCount));
        }
        //public static Boolean DeleteFaces4(IBody2Object IBody2instance, Object FaceList, Int32 Option, Boolean DoLocalCheck, Object& BodyList, Boolean& LocalCheckResult)
        //{
        //    return IBody2instance.IBody2Instance.DeleteFaces4(FaceList, Option, DoLocalCheck, BodyList, LocalCheckResult);
        //}
        public static Int32 GetUpdateStamp(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetUpdateStamp();
        }
        public static Int32 GetTrackingIDsCount(IBody2Object IBody2instance, Int32 TrackingCookie)
        {
            return IBody2instance.IBody2Instance.GetTrackingIDsCount(TrackingCookie);
        }
        //public static Int32 IGetTrackingIDs(IBody2Object IBody2instance, Int32 TrackingCookie, Int32 Count, Int32& TrackingIDs)
        //{
        //    return IBody2instance.IBody2Instance.IGetTrackingIDs(TrackingCookie, Count, TrackingIDs);
        //}
        //public static String GetMaterialPropertyName(IBody2Object IBody2instance, String ConfigName, String& Database)
        //{
        //    return IBody2instance.IBody2Instance.GetMaterialPropertyName(ConfigName, Database);
        //}
        //public static Boolean DeleteFaces5(IBody2Object IBody2instance, Object FaceList, Int32 HealAction, Int32 LoopProcessOption, Boolean DoLocalCheck, Object& BodyList, Boolean& LocalCheckResult)
        //{
        //    return IBody2instance.IBody2Instance.DeleteFaces5(FaceList, HealAction, LoopProcessOption, DoLocalCheck, BodyList, LocalCheckResult);
        //}
        public static Boolean DeleteBlends3(IBody2Object IBody2instance, Object FaceList, Boolean DoLocalCheck, Boolean UsePlanarCap)
        {
            return IBody2instance.IBody2Instance.DeleteBlends3(FaceList, DoLocalCheck, UsePlanarCap);
        }
        //public static Boolean IDeleteBlends3(IBody2Object IBody2instance, Int32 NumOfFaces, Face2&Object FaceList, Boolean DoLocalCheck, Boolean UsePlanarCap)
        //{
        //    return IBody2instance.IBody2Instance.IDeleteBlends3(NumOfFaces, FaceList, DoLocalCheck, UsePlanarCap);
        //}
        public static Int32 GetFeatureCount(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetFeatureCount();
        }
        public static Object GetFeatures(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetFeatures();
        }
        public static IFeatureObject IGetFeatures(IBody2Object IBody2instance, Int32 NumberOfFeatures)
        {
            return new IFeatureObject(IBody2instance.IBody2Instance.IGetFeatures(NumberOfFeatures));
        }
        public static Int32 SetMaterialProperty(IBody2Object IBody2instance, String ConfigName, String Database, String MaterialName)
        {
            return IBody2instance.IBody2Instance.SetMaterialProperty(ConfigName, Database, MaterialName);
        }
        //public static Boolean SetTextureByDisplayState(IBody2Object IBody2instance, String DisplayStateName, TextureObject TextureIn)
        //{
        //    return IBody2instance.IBody2Instance.SetTextureByDisplayState(DisplayStateName, TextureIn);
        //}
        public static Boolean RemoveTextureByDisplayState(IBody2Object IBody2instance, String DisplayStateName)
        {
            return IBody2instance.IBody2Instance.RemoveTextureByDisplayState(DisplayStateName);
        }
        //public static IBody2Object GetOriginalPatternedBody(IBody2Object IBody2instance, MathTransform&Object Xform)
        //{
        //    return new IBody2Object(IBody2instance.IBody2Instance.GetOriginalPatternedBody(Xform));
        //}
        //public static Boolean GetCoincidenceTransform2(IBody2Object IBody2instance, Object BodyDispIn, MathTransform&Object Xform)
        //{
        //    return IBody2instance.IBody2Instance.GetCoincidenceTransform2(BodyDispIn, Xform);
        //}
        public static Boolean HasMaterialPropertyValues(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.HasMaterialPropertyValues();
        }
        public static Boolean IsMeshBody(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.IsMeshBody();
        }
        //public static Int32 IOperations(IBody2Object IBody2instance, Int32 OperationType, Body2Object ToolBody, Int32 NumMaxSections, Body2&Object ResultingBodies)
        //{
        //    return IBody2instance.IBody2Instance.IOperations(OperationType, ToolBody, NumMaxSections, ResultingBodies);
        //}
        public static Object GetSheetBody(IBody2Object IBody2instance, Int32 Index)
        {
            return IBody2instance.IBody2Instance.GetSheetBody(Index);
        }
        public static IBody2Object IGetSheetBody(IBody2Object IBody2instance, Int32 Index)
        {
            return new IBody2Object(IBody2instance.IBody2Instance.IGetSheetBody(Index));
        }
        public static Object GetProcessedBody(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetProcessedBody();
        }
        public static IBody2Object IGetProcessedBody(IBody2Object IBody2instance)
        {
            return new IBody2Object(IBody2instance.IBody2Instance.IGetProcessedBody());
        }
        public static Object GetProcessedBodyWithSelFace(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetProcessedBodyWithSelFace();
        }
        public static IBody2Object IGetProcessedBodyWithSelFace(IBody2Object IBody2instance)
        {
            return new IBody2Object(IBody2instance.IBody2Instance.IGetProcessedBodyWithSelFace());
        }
        public static Int32 Check(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.Check();
        }
        public static Object GetExcessBodyArray(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetExcessBodyArray();
        }
        public static IBody2Object IGetExcessBodyArray(IBody2Object IBody2instance)
        {
            return new IBody2Object(IBody2instance.IBody2Instance.IGetExcessBodyArray());
        }
        public static Int32 IGetExcessBodyCount(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.IGetExcessBodyCount();
        }
        public static Boolean CreateBaseFeature(IBody2Object IBody2instance, Object BodyIn)
        {
            return IBody2instance.IBody2Instance.CreateBaseFeature(BodyIn);
        }
        //public static Boolean ICreateBaseFeature(IBody2Object IBody2instance, Body2Object BodyIn)
        //{
        //    return IBody2instance.IBody2Instance.ICreateBaseFeature(BodyIn);
        //}
        public static Int32 DeleteFaces2(IBody2Object IBody2instance, Int32 NumOfFaces, Object FaceList, Int32 Option)
        {
            return IBody2instance.IBody2Instance.DeleteFaces2(NumOfFaces, FaceList, Option);
        }
        //public static Int32 IDeleteFaces2(IBody2Object IBody2instance, Int32 NumOfFaces, Face2&Object FaceList, Int32 Option)
        //{
        //    return IBody2instance.IBody2Instance.IDeleteFaces2(NumOfFaces, FaceList, Option);
        //}
        //public static IVertexObject IAddVertexPoint(IBody2Object IBody2instance, Double& Point)
        //{
        //    return new IVertexObject(IBody2instance.IBody2Instance.IAddVertexPoint(Point));
        //}
        public static Object AddVertexPoint(IBody2Object IBody2instance, Object Point)
        {
            return IBody2instance.IBody2Instance.AddVertexPoint(Point);
        }

        [MultiReturn(SWValueConst.Result, SWValueConst.Outx, SWValueConst.Outy, SWValueConst.Outz)]
        public static Dictionary<string, object> GetExtremePoint(IBody2Object IBody2instance, Double X, Double Y, Double Z)
        {
            bool result = IBody2instance.IBody2Instance.GetExtremePoint(X, Y, Z, out double Outx, out double Outy, out double Outz);
            return new Dictionary<string, object>() { { SWValueConst.Result, Outx }, { SWValueConst.Outy, Outy }, { SWValueConst.Outz, Outz } };
        }
        public static Int32 GetType(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetType();
        }
        //public static void IDeleteFaces3(IBody2Object IBody2instance, Int32 NumOfFaces, Face2&Object FaceList, Int32 Option, Boolean DoLocalCheck, Boolean& LocalCheckResult)
        //{
        //    return IBody2instance.IBody2Instance.IDeleteFaces3(NumOfFaces, FaceList, Option, DoLocalCheck, LocalCheckResult);
        //}
        public static void SetCurrentSurface(IBody2Object IBody2instance, Object SurfaceIn)
        {
            IBody2instance.IBody2Instance.SetCurrentSurface(SurfaceIn);
        }
        public static void ISetCurrentSurface(IBody2Object IBody2instance, ISurfaceObject SurfaceIn)
        {
            IBody2instance.IBody2Instance.ISetCurrentSurface(SurfaceIn.ISurfaceInstance as Surface);
        }
        public static Boolean DraftBody(IBody2Object IBody2instance, Int32 NumOfFaces, Object FaceList, Object EdgeList, Double DraftAngle, Object Dir)
        {
            return IBody2instance.IBody2Instance.DraftBody(NumOfFaces, FaceList, EdgeList, DraftAngle, Dir);
        }
        //public static Boolean IDraftBody(IBody2Object IBody2instance, Int32 NumOfFaces, Face2&Object FaceList, Edge&Object EdgeList, Double DraftAngle, Double& Dir)
        //{
        //    return IBody2instance.IBody2Instance.IDraftBody(NumOfFaces, FaceList, EdgeList, DraftAngle, Dir);
        //}
        public static Boolean DeleteBlends(IBody2Object IBody2instance, Int32 NumOfFaces, Object FaceList)
        {
            return IBody2instance.IBody2Instance.DeleteBlends(NumOfFaces, FaceList);
        }
        //public static Boolean IDeleteBlends(IBody2Object IBody2instance, Int32 NumOfFaces, Face2&Object FaceList)
        //{
        //    return IBody2instance.IBody2Instance.IDeleteBlends(NumOfFaces, FaceList);
        //}
        //public static Object Operations2(IBody2Object IBody2instance, Int32 OperationType, Object ToolBody, Int32& ErrorCode)
        //{
        //    return IBody2instance.IBody2Instance.Operations2(OperationType, ToolBody, ErrorCode);
        //}
        //public static IEnumBodies2Object IOperations2(IBody2Object IBody2instance, Int32 OperationType, Body2Object ToolBody, Int32& ErrorCode)
        //{
        //    return new IEnumBodies2Object(IBody2instance.IBody2Instance.IOperations2(OperationType, ToolBody, ErrorCode));
        //}
        public static Object GetBodyBox(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetBodyBox();
        }
        public static Boolean DeleteBlends2(IBody2Object IBody2instance, Int32 NumOfFaces, Object FaceList, Boolean DoLocalCheck)
        {
            return IBody2instance.IBody2Instance.DeleteBlends2(NumOfFaces, FaceList, DoLocalCheck);
        }
        //public static Boolean IDeleteBlends2(IBody2Object IBody2instance, Int32 NumOfFaces, Face2&Object FaceList, Boolean DoLocalCheck)
        //{
        //    return IBody2instance.IBody2Instance.IDeleteBlends2(NumOfFaces, FaceList, DoLocalCheck);
        //}
        public static Object GetTessellation(IBody2Object IBody2instance, Object FaceList)
        {
            return IBody2instance.IBody2Instance.GetTessellation(FaceList);
        }
        //public static ITessellationObject IGetTessellation(IBody2Object IBody2instance, Int32 NumOfFaces, Face2&Object FaceList)
        //{
        //    return new ITessellationObject(IBody2instance.IBody2Instance.IGetTessellation(NumOfFaces, FaceList));
        //}
        //public static Object MatchedBoolean(IBody2Object IBody2instance, Int32 OperationType, Object ToolBody, Int32 NumOfMatchingFaces, Object FaceList1, Object FaceList2, Int32& ErrorCode)
        //{
        //    return IBody2instance.IBody2Instance.MatchedBoolean(OperationType, ToolBody, NumOfMatchingFaces, FaceList1, FaceList2, ErrorCode);
        //}
        //public static IEnumBodies2Object IMatchedBoolean(IBody2Object IBody2instance, Int32 OperationType, Body2Object ToolBody, Int32 NumOfMatchingFaces, Face2&Object FaceList1, Face2&Object FaceList2, Int32& ErrorCode)
        //{
        //    return new IEnumBodies2Object(IBody2instance.IBody2Instance.IMatchedBoolean(OperationType, ToolBody, NumOfMatchingFaces, FaceList1, FaceList2, ErrorCode));
        //}
        public static Int32 GetEdgeCount(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetEdgeCount();
        }
        public static Object CreateRuledSurface(IBody2Object IBody2instance, Object Curve1, Object Curve2, Object ApexPoint)
        {
            return IBody2instance.IBody2Instance.CreateRuledSurface(Curve1, Curve2, ApexPoint);
        }
        //public static ISurfaceObject ICreateRuledSurface(IBody2Object IBody2instance, CurveObject Curve1, CurveObject Curve2, Double& ApexPoint)
        //{
        //    return new ISurfaceObject(IBody2instance.IBody2Instance.ICreateRuledSurface(Curve1, Curve2, ApexPoint));
        //}
        public static Object AddProfileBsplineByPts(IBody2Object IBody2instance, Int32 NumPoints, Object PointArray)
        {
            return IBody2instance.IBody2Instance.AddProfileBsplineByPts(NumPoints, PointArray);
        }
        //public static ICurveObject IAddProfileBsplineByPts(IBody2Object IBody2instance, Int32 NumPoints, Double& PointArray)
        //{
        //    return new ICurveObject(IBody2instance.IBody2Instance.IAddProfileBsplineByPts(NumPoints, PointArray));
        //}
        public static Object GetEdges(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetEdges();
        }
        public static IEdgeObject IGetEdges(IBody2Object IBody2instance, Int32 Count)
        {
            return new IEdgeObject(IBody2instance.IBody2Instance.IGetEdges(Count));
        }
        public static Boolean ApplyTransform(IBody2Object IBody2instance, IMathTransformObject Xform)
        {
            return IBody2instance.IBody2Instance.ApplyTransform(Xform.IMathTransformInstance as MathTransform);
        }
        public static Boolean Select(IBody2Object IBody2instance, Boolean Append, Int32 Mark)
        {
            return IBody2instance.IBody2Instance.Select(Append, Mark);
        }
        public static Boolean DeSelect(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.DeSelect();
        }
        //public static Object MatchedBoolean2(IBody2Object IBody2instance, Int32 OperationType, Object ToolBody, Int32 NumOfMatchingFaces, Object FaceList1, Object FaceList2, Int32& ErrorCode)
        //{
        //    return IBody2instance.IBody2Instance.MatchedBoolean2(OperationType, ToolBody, NumOfMatchingFaces, FaceList1, FaceList2, ErrorCode);
        //}
        //public static IEnumBodies2Object IMatchedBoolean2(IBody2Object IBody2instance, Int32 OperationType, Int32 ToolBodyCount, Body2&Object ToolBodyArr, Int32 NumOfMatchingFaces, Face2&Object FaceList1, Face2&Object FaceList2, Int32& ErrorCode)
        //{
        //    return new IEnumBodies2Object(IBody2instance.IBody2Instance.IMatchedBoolean2(OperationType, ToolBodyCount, ToolBodyArr, NumOfMatchingFaces, FaceList1, FaceList2, ErrorCode));
        //}
        public static void HideBody(IBody2Object IBody2instance, Boolean BHide)
        {
            IBody2instance.IBody2Instance.HideBody(BHide);
        }
        public static IBody2Object GetSafeBody(IBody2Object IBody2instance)
        {
            return new IBody2Object(IBody2instance.IBody2Instance.GetSafeBody());
        }
        public static IBody2Object GetProcessedBody2(IBody2Object IBody2instance, Double MaxUAngle, Double MaxVAngle)
        {
            return new IBody2Object(IBody2instance.IBody2Instance.GetProcessedBody2(MaxUAngle, MaxVAngle));
        }
        public static IAttributeObject FindAttribute(IBody2Object IBody2instance, IAttributeDefObject AttributeDef, Int32 WhichOne)
        {
            return new IAttributeObject(IBody2instance.IBody2Instance.FindAttribute(AttributeDef.IAttributeDefInstance as AttributeDef, WhichOne));
        }
        //public static Object MatchedBoolean3(IBody2Object IBody2instance, Int32 OperationType, Object ToolBody, Int32 NumOfMatchingFaces, Object FaceList1, Object FaceList2, Int32& ErrorCode)
        //{
        //    return IBody2instance.IBody2Instance.MatchedBoolean3(OperationType, ToolBody, NumOfMatchingFaces, FaceList1, FaceList2, ErrorCode);
        //}
        //public static IEnumBodies2Object IMatchedBoolean3(IBody2Object IBody2instance, Int32 OperationType, Int32 ToolBodyCount, Body2&Object ToolBodyArr, Int32 NumOfMatchingFaces, Face2&Object FaceList1, Face2&Object FaceList2, Int32& ErrorCode)
        //{
        //    return new IEnumBodies2Object(IBody2instance.IBody2Instance.IMatchedBoolean3(OperationType, ToolBodyCount, ToolBodyArr, NumOfMatchingFaces, FaceList1, FaceList2, ErrorCode));
        //}
        public static String GetSelectionId(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetSelectionId();
        }
        public static Int32 AddPropertyExtension2(IBody2Object IBody2instance, Object PropertyExtension)
        {
            return IBody2instance.IBody2Instance.AddPropertyExtension2(PropertyExtension);
        }
        public static Object GetPropertyExtension2(IBody2Object IBody2instance, Int32 ID)
        {
            return IBody2instance.IBody2Instance.GetPropertyExtension2(ID);
        }
        public static void ResetPropertyExtension2(IBody2Object IBody2instance)
        {
            IBody2instance.IBody2Instance.ResetPropertyExtension2();
        }
        public static String GetMaterialIdName2(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetMaterialIdName2();
        }
        public static Boolean SetMaterialIdName2(IBody2Object IBody2instance, String Name)
        {
            return IBody2instance.IBody2Instance.SetMaterialIdName2(Name);
        }
        public static String GetMaterialUserName2(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetMaterialUserName2();
        }
        public static Boolean SetMaterialUserName2(IBody2Object IBody2instance, String Name)
        {
            return IBody2instance.IBody2Instance.SetMaterialUserName2(Name);
        }
        public static Double IGetMaterialPropertyValuesForFace(IBody2Object IBody2instance, Object FaceIn)
        {
            return IBody2instance.IBody2Instance.IGetMaterialPropertyValuesForFace(FaceIn);
        }
        public static void Display2(IBody2Object IBody2instance, IPartDocObject Part, Int32 Color, Int32 Option)
        {
            IBody2instance.IBody2Instance.Display2(Part.IPartDocInstance as PartDoc, Color, Option);
        }
        public static Boolean IsTemporaryBody(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.IsTemporaryBody();
        }
        public static Int32 Check2(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.Check2();
        }
        public static Boolean CreatePlanarTrimSurfaceDLL(IBody2Object IBody2instance, Object Points, Object Normal)
        {
            return IBody2instance.IBody2Instance.CreatePlanarTrimSurfaceDLL(Points, Normal);
        }
        //public static Boolean DeleteFaces3(IBody2Object IBody2instance, Object FaceList, Int32 Option, Boolean DoLocalCheck, Boolean& LocalCheckResult)
        //{
        //    return IBody2instance.IBody2Instance.DeleteFaces3(FaceList, Option, DoLocalCheck, LocalCheckResult);
        //}
        public static IDiagnoseResultObject Diagnose(IBody2Object IBody2instance)
        {
            return new IDiagnoseResultObject(IBody2instance.IBody2Instance.Diagnose());
        }
        public static Object DeleteFacesMakeSheetBodies(IBody2Object IBody2instance, Object FaceList)
        {
            return IBody2instance.IBody2Instance.DeleteFacesMakeSheetBodies(FaceList);
        }
        //public static Int32 IDeleteFacesMakeSheetBodiesCount(IBody2Object IBody2instance, Int32 FaceCount, Face2&Object FaceList)
        //{
        //    return IBody2instance.IBody2Instance.IDeleteFacesMakeSheetBodiesCount(FaceCount, FaceList);
        //}
        //public static IBody2Object IDeleteFacesMakeSheetBodies(IBody2Object IBody2instance, Int32 FaceCount, Face2&Object FaceList, Int32 SheetCount)
        //{
        //    return new IBody2Object(IBody2instance.IBody2Instance.IDeleteFacesMakeSheetBodies(FaceCount, FaceList, SheetCount));
        //}
        public static ITextureObject GetTexture(IBody2Object IBody2instance, String Config_name)
        {
            return new ITextureObject(IBody2instance.IBody2Instance.GetTexture(Config_name));
        }
        //public static Boolean SetTexture(IBody2Object IBody2instance, String Config_name, TextureObject TextureIn)
        //{
        //    return IBody2instance.IBody2Instance.SetTexture(Config_name, TextureIn);
        //}
        public static Boolean RemoveTexture(IBody2Object IBody2instance, String Config_name)
        {
            return IBody2instance.IBody2Instance.RemoveTexture(Config_name);
        }
        public static IBody2Object MakeOffset(IBody2Object IBody2instance, Double Distance, Boolean Direction)
        {
            return new IBody2Object(IBody2instance.IBody2Instance.MakeOffset(Distance, Direction));
        }
        //public static IBody2Object ExtendSurface(IBody2Object IBody2instance, Object EdgesToExtend, Boolean ExtendLinear, Int32 EndCondition, Double Dist, VertexObject PUpToVtx, FaceObject PUpToFace)
        //{
        //    return new IBody2Object(IBody2instance.IBody2Instance.ExtendSurface(EdgesToExtend, ExtendLinear, EndCondition, Dist, PUpToVtx, PUpToFace));
        //}
        public static Object GetFirstFace(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetFirstFace();
        }
        public static IFace2Object IGetFirstFace(IBody2Object IBody2instance)
        {
            return new IFace2Object(IBody2instance.IBody2Instance.IGetFirstFace());
        }
        public static Int32 GetFaceCount(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetFaceCount();
        }
        public static Object CreateNewSurface(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.CreateNewSurface();
        }
        public static ISurfaceObject ICreateNewSurface(IBody2Object IBody2instance)
        {
            return new ISurfaceObject(IBody2instance.IBody2Instance.ICreateNewSurface());
        }
        public static Boolean CreateBodyFromSurfaces(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.CreateBodyFromSurfaces();
        }
        public static Object CreatePlanarSurface(IBody2Object IBody2instance, Object VRootPoint, Object VNormal)
        {
            return IBody2instance.IBody2Instance.CreatePlanarSurface(VRootPoint, VNormal);
        }
        public static ISurfaceObject ICreatePlanarSurface(IBody2Object IBody2instance, Object VRootPoint, Object VNormal)
        {
            return new ISurfaceObject(IBody2instance.IBody2Instance.ICreatePlanarSurface(VRootPoint, VNormal));
        }
        public static Object CreateRevolutionSurface(IBody2Object IBody2instance, Object ProfileCurve, Object AxisPoint, Object AxisDirection, Object ProfileEndPtParams)
        {
            return IBody2instance.IBody2Instance.CreateRevolutionSurface(ProfileCurve, AxisPoint, AxisDirection, ProfileEndPtParams);
        }
        //public static ISurfaceObject ICreateRevolutionSurface(IBody2Object IBody2instance, CurveObject ProfileCurve, Object AxisPoint, Object AxisDirection, Object ProfileEndPtParams)
        //{
        //    return new ISurfaceObject(IBody2instance.IBody2Instance.ICreateRevolutionSurface(ProfileCurve, AxisPoint, AxisDirection, ProfileEndPtParams));
        //}
        public static Object CreateBsplineSurface(IBody2Object IBody2instance, Object Props, Object UKnots, Object VKnots, Object CtrlPtCoords)
        {
            return IBody2instance.IBody2Instance.CreateBsplineSurface(Props, UKnots, VKnots, CtrlPtCoords);
        }
        public static ISurfaceObject ICreateBsplineSurface(IBody2Object IBody2instance, Object Props, Object UKnots, Object VKnots, Object CtrlPtCoords)
        {
            return new ISurfaceObject(IBody2instance.IBody2Instance.ICreateBsplineSurface(Props, UKnots, VKnots, CtrlPtCoords));
        }
        public static Boolean CreateTrimmedSurface(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.CreateTrimmedSurface();
        }
        public static Object AddProfileLine(IBody2Object IBody2instance, Object RootPoint, Object Direction)
        {
            return IBody2instance.IBody2Instance.AddProfileLine(RootPoint, Direction);
        }
        public static ICurveObject IAddProfileLine(IBody2Object IBody2instance, Object RootPoint, Object Direction)
        {
            return new ICurveObject(IBody2instance.IBody2Instance.IAddProfileLine(RootPoint, Direction));
        }
        public static Object AddProfileArc(IBody2Object IBody2instance, Object Center, Object Axis, Double Radius, Object StartPoint, Object EndPoint)
        {
            return IBody2instance.IBody2Instance.AddProfileArc(Center, Axis, Radius, StartPoint, EndPoint);
        }
        public static ICurveObject IAddProfileArc(IBody2Object IBody2instance, Object Center, Object Axis, Double Radius, Object StartPoint, Object EndPoint)
        {
            return new ICurveObject(IBody2instance.IBody2Instance.IAddProfileArc(Center, Axis, Radius, StartPoint, EndPoint));
        }
        public static Object AddProfileBspline(IBody2Object IBody2instance, Object Props, Object Knots, Object CtrlPtCoords)
        {
            return IBody2instance.IBody2Instance.AddProfileBspline(Props, Knots, CtrlPtCoords);
        }
        public static ICurveObject IAddProfileBspline(IBody2Object IBody2instance, Object Props, Object Knots, Object CtrlPtCoords)
        {
            return new ICurveObject(IBody2instance.IBody2Instance.IAddProfileBspline(Props, Knots, CtrlPtCoords));
        }
        public static Object CreateExtrusionSurface(IBody2Object IBody2instance, Object ProfileCurve, Object AxisDirection)
        {
            return IBody2instance.IBody2Instance.CreateExtrusionSurface(ProfileCurve, AxisDirection);
        }
        //public static ISurfaceObject ICreateExtrusionSurface(IBody2Object IBody2instance, CurveObject ProfileCurve, Object AxisDirection)
        //{
        //    return new ISurfaceObject(IBody2instance.IBody2Instance.ICreateExtrusionSurface(ProfileCurve, AxisDirection));
        //}
        public static Object GetFirstSelectedFace(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetFirstSelectedFace();
        }
        public static IFace2Object IGetFirstSelectedFace(IBody2Object IBody2instance)
        {
            return new IFace2Object(IBody2instance.IBody2Instance.IGetFirstSelectedFace());
        }
        public static Object GetNextSelectedFace(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetNextSelectedFace();
        }
        public static IFace2Object IGetNextSelectedFace(IBody2Object IBody2instance)
        {
            return new IFace2Object(IBody2instance.IBody2Instance.IGetNextSelectedFace());
        }
        public static Int32 GetSelectedFaceCount(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetSelectedFaceCount();
        }
        public static Boolean CreateBoundedSurface(IBody2Object IBody2instance, Boolean UOpt, Boolean VOpt, Object UvParams)
        {
            return IBody2instance.IBody2Instance.CreateBoundedSurface(UOpt, VOpt, UvParams);
        }
        public static Int32 GetIgesErrorCount(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetIgesErrorCount();
        }
        public static Int32 GetIgesErrorCode(IBody2Object IBody2instance, Int32 Index)
        {
            return IBody2instance.IBody2Instance.GetIgesErrorCode(Index);
        }
        public static Object Copy(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.Copy();
        }
        public static IBody2Object ICopy(IBody2Object IBody2instance)
        {
            return new IBody2Object(IBody2instance.IBody2Instance.ICopy());
        }
        //public static IEnumFaces2Object EnumFaces(IBody2Object IBody2instance)
        //{
        //    return new IEnumFaces2Object(IBody2instance.IBody2Instance.EnumFaces());
        //}
        public static Object CreateBodyFromFaces(IBody2Object IBody2instance, Int32 NumOfFaces, Object FaceList)
        {
            return IBody2instance.IBody2Instance.CreateBodyFromFaces(NumOfFaces, FaceList);
        }
        public static IBody2Object ICreateBodyFromFaces(IBody2Object IBody2instance, Int32 NumOfFaces, Object FaceList)
        {
            return new IBody2Object(IBody2instance.IBody2Instance.ICreateBodyFromFaces(NumOfFaces, FaceList));
        }
        public static Boolean DeleteFaces(IBody2Object IBody2instance, Int32 NumOfFaces, Object FaceList)
        {
            return IBody2instance.IBody2Instance.DeleteFaces(NumOfFaces, FaceList);
        }
        public static void Display(IBody2Object IBody2instance, Object Part, Int32 Color)
        {
            IBody2instance.IBody2Instance.Display(Part, Color);
        }
        public static void IDisplay(IBody2Object IBody2instance, IPartDocObject Part, Int32 Color)
        {
            IBody2instance.IBody2Instance.IDisplay(Part.IPartDocInstance as PartDoc, Color);
        }
        public static void Hide(IBody2Object IBody2instance, Object Part)
        {
            IBody2instance.IBody2Instance.Hide(Part);
        }
        public static void IHide(IBody2Object IBody2instance, IPartDocObject Part)
        {
            IBody2instance.IBody2Instance.IHide(Part.IPartDocInstance as PartDoc);
        }
        //public static ISurfaceObject ICreatePlanarSurfaceDLL(IBody2Object IBody2instance, Double& RootPoint, Double& Normal)
        //{
        //    return new ISurfaceObject(IBody2instance.IBody2Instance.ICreatePlanarSurfaceDLL(RootPoint, Normal));
        //}
        //public static ISurfaceObject ICreateRevolutionSurfaceDLL(IBody2Object IBody2instance, CurveObject ProfileCurve, Double& AxisPoint, Double& AxisDirection, Double& ProfileEndPtParams)
        //{
        //    return new ISurfaceObject(IBody2instance.IBody2Instance.ICreateRevolutionSurfaceDLL(ProfileCurve, AxisPoint, AxisDirection, ProfileEndPtParams));
        //}
        //public static ICurveObject IAddProfileLineDLL(IBody2Object IBody2instance, Double& RootPoint, Double& Direction)
        //{
        //    return new ICurveObject(IBody2instance.IBody2Instance.IAddProfileLineDLL(RootPoint, Direction));
        //}
        //public static ICurveObject IAddProfileArcDLL(IBody2Object IBody2instance, Double& Center, Double& Axis, Double Radius, Double& StartPoint, Double& EndPoint)
        //{
        //    return new ICurveObject(IBody2instance.IBody2Instance.IAddProfileArcDLL(Center, Axis, Radius, StartPoint, EndPoint));
        //}
        //public static ISurfaceObject ICreateBsplineSurfaceDLL(IBody2Object IBody2instance, Int32& Properties, Double& UKnotArray, Double& VKnotArray, Double& ControlPointCoordArray)
        //{
        //    return new ISurfaceObject(IBody2instance.IBody2Instance.ICreateBsplineSurfaceDLL(Properties, UKnotArray, VKnotArray, ControlPointCoordArray));
        //}
        //public static ICurveObject IAddProfileBsplineDLL(IBody2Object IBody2instance, Int32& Properties, Double& KnotArray, Double& ControlPointCoordArray)
        //{
        //    return new ICurveObject(IBody2instance.IBody2Instance.IAddProfileBsplineDLL(Properties, KnotArray, ControlPointCoordArray));
        //}
        //public static ISurfaceObject ICreateExtrusionSurfaceDLL(IBody2Object IBody2instance, CurveObject ProfileCurve, Double& AxisDirection)
        //{
        //    return new ISurfaceObject(IBody2instance.IBody2Instance.ICreateExtrusionSurfaceDLL(ProfileCurve, AxisDirection));
        //}
        //public static void ICreateBoundedSurface(IBody2Object IBody2instance, Boolean UOpt, Boolean VOpt, Double& UvParams)
        //{
        //    return IBody2instance.IBody2Instance.ICreateBoundedSurface(UOpt, VOpt, UvParams);
        //}
        //public static void ICombineVolumes(IBody2Object IBody2instance, Body2Object ToolBody)
        //{
        //    return IBody2instance.IBody2Instance.ICombineVolumes(ToolBody);
        //}
        //public static Int32 ISectionBySheet(IBody2Object IBody2instance, Body2Object Sheet, Int32 NumMaxSections, Body2&Object SectionedBodies)
        //{
        //    return IBody2instance.IBody2Instance.ISectionBySheet(Sheet, NumMaxSections, SectionedBodies);
        //}
        //public static void IGetBodyBox(IBody2Object IBody2instance, Double& BoxCorners)
        //{
        //    return IBody2instance.IBody2Instance.IGetBodyBox(BoxCorners);
        //}
        public static void SetIgesInfo(IBody2Object IBody2instance, String SystemName, Double Granularity, Boolean AttemptKnitting)
        {
            IBody2instance.IBody2Instance.SetIgesInfo(SystemName, Granularity, AttemptKnitting);
        }
        public static void DisplayWireFrameXOR(IBody2Object IBody2instance, Object Part, Int32 Color)
        {
            IBody2instance.IBody2Instance.DisplayWireFrameXOR(Part, Color);
        }
        public static void IDisplayWireFrameXOR(IBody2Object IBody2instance, IPartDocObject Part, Int32 Color)
        {
            IBody2instance.IBody2Instance.IDisplayWireFrameXOR(Part.IPartDocInstance as PartDoc, Color);
        }
        public static void Save(IBody2Object IBody2instance, Object StreamIn)
        {
            IBody2instance.IBody2Instance.Save(StreamIn);
        }
        public static void ISave(IBody2Object IBody2instance, Object StreamIn)
        {
            IBody2instance.IBody2Instance.ISave(StreamIn);
        }
        public static Object CreateBlendSurface(IBody2Object IBody2instance, Object Surface1, Double Range1, Object Surface2, Double Range2, Object StartVec, Object EndVec, Int32 HaveHelpVec, Object HelpVec, Int32 HaveHelpBox, Object HelpBox)
        {
            return IBody2instance.IBody2Instance.CreateBlendSurface(Surface1, Range1, Surface2, Range2, StartVec, EndVec, HaveHelpVec, HelpVec, HaveHelpBox, HelpBox);
        }
        //public static ISurfaceObject ICreateBlendSurface(IBody2Object IBody2instance, SurfaceObject Surface1, Double Range1, SurfaceObject Surface2, Double Range2, Double& StartVec, Double& EndVec, Int32 HaveHelpVec, Double& HelpVec, Int32 HaveHelpBox, Double& HelpBox)
        //{
        //    return new ISurfaceObject(IBody2instance.IBody2Instance.ICreateBlendSurface(Surface1, Range1, Surface2, Range2, StartVec, EndVec, HaveHelpVec, HelpVec, HaveHelpBox, HelpBox));
        //}
        public static Object CreateOffsetSurface(IBody2Object IBody2instance, Object SurfaceIn, Double Distance)
        {
            return IBody2instance.IBody2Instance.CreateOffsetSurface(SurfaceIn, Distance);
        }
        //public static ISurfaceObject ICreateOffsetSurface(IBody2Object IBody2instance, SurfaceObject SurfaceIn, Double Distance)
        //{
        //    return new ISurfaceObject(IBody2instance.IBody2Instance.ICreateOffsetSurface(SurfaceIn, Distance));
        //}
        public static Boolean RemoveRedundantTopology(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.RemoveRedundantTopology();
        }
        public static Object GetIntersectionEdges(IBody2Object IBody2instance, Object ToolBodyIn)
        {
            return IBody2instance.IBody2Instance.GetIntersectionEdges(ToolBodyIn);
        }
        //public static IEdgeObject IGetIntersectionEdges(IBody2Object IBody2instance, Body2Object ToolBodyIn)
        //{
        //    return new IEdgeObject(IBody2instance.IBody2Instance.IGetIntersectionEdges(ToolBodyIn));
        //}
        public static Int32 IGetIntersectionEdgeCount(IBody2Object IBody2instance, IBody2Object ToolBodyIn)
        {
            return IBody2instance.IBody2Instance.IGetIntersectionEdgeCount(ToolBodyIn.IBody2Instance as Body2);
        }
        public static void RemoveFacesFromSheet(IBody2Object IBody2instance, Int32 NumOfFaces, Object FacesToRemove)
        {
            IBody2instance.IBody2Instance.RemoveFacesFromSheet(NumOfFaces, FacesToRemove);
        }

        //ref not solve Face
        public static void IRemoveFacesFromSheet(IBody2Object IBody2instance, Int32 NumOfFaces, IFace2Object FacesToRemove)
        {
            IBody2instance.IBody2Instance.IRemoveFacesFromSheet(NumOfFaces, FacesToRemove.IFace2Instance as Face2);
        }
        //public static void ICreatePlanarTrimSurfaceDLL(IBody2Object IBody2instance, Int32 VertexCount, Double& Points, Double& Normal)
        //{
        //    return IBody2instance.IBody2Instance.ICreatePlanarTrimSurfaceDLL(VertexCount, Points, Normal);
        //}
        public static Int32 AddPropertyExtension(IBody2Object IBody2instance, Object PropertyExtension)
        {
            return IBody2instance.IBody2Instance.AddPropertyExtension(PropertyExtension);
        }
        public static Object GetPropertyExtension(IBody2Object IBody2instance, Int32 ID)
        {
            return IBody2instance.IBody2Instance.GetPropertyExtension(ID);
        }
        public static void ResetPropertyExtension(IBody2Object IBody2instance)
        {
            IBody2instance.IBody2Instance.ResetPropertyExtension();
        }
        public static String GetMaterialIdName(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetMaterialIdName();
        }
        public static Boolean SetMaterialIdName(IBody2Object IBody2instance, String Name)
        {
            return IBody2instance.IBody2Instance.SetMaterialIdName(Name);
        }
        public static String GetMaterialUserName(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.GetMaterialUserName();
        }
        public static Boolean SetMaterialUserName(IBody2Object IBody2instance, String Name)
        {
            return IBody2instance.IBody2Instance.SetMaterialUserName(Name);
        }
        public static Object GetMassProperties(IBody2Object IBody2instance, Double Density)
        {
            return IBody2instance.IBody2Instance.GetMassProperties(Density);
        }
        public static Double IGetMassProperties(IBody2Object IBody2instance, Double Density)
        {
            return IBody2instance.IBody2Instance.IGetMassProperties(Density);
        }
        //public static ISurfaceObject ICreatePsplineSurfaceDLL(IBody2Object IBody2instance, Int32 Dim, Int32 UOrder, Int32 VOrder, Int32 Ncol, Int32 Nrow, Double& Coeffs, Int32 Basis, Double& Xform, Double ScaleFactor)
        //{
        //    return new ISurfaceObject(IBody2instance.IBody2Instance.ICreatePsplineSurfaceDLL(Dim, UOrder, VOrder, Ncol, Nrow, Coeffs, Basis, Xform, ScaleFactor));
        //}
        public static Boolean SetXform(IBody2Object IBody2instance, Object XformIn)
        {
            return IBody2instance.IBody2Instance.SetXform(XformIn);
        }

        //ref not solve
        public static Boolean ISetXform(IBody2Object IBody2instance, Double XformIn)
        {
            return IBody2instance.IBody2Instance.ISetXform(XformIn);
        }
        public static Object CreateTempBodyFromSurfaces(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.CreateTempBodyFromSurfaces();
        }
        public static IBody2Object ICreateTempBodyFromSurfaces(IBody2Object IBody2instance)
        {
            return new IBody2Object(IBody2instance.IBody2Instance.ICreateTempBodyFromSurfaces());
        }
        public static Object Operations(IBody2Object IBody2instance, Int32 OperationType, Object ToolBody, Int32 NumMaxSections)
        {
            return IBody2instance.IBody2Instance.Operations(OperationType, ToolBody, NumMaxSections);
        }
        public static Object MaterialPropertyValues(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.MaterialPropertyValues;
        }
        public static object IMaterialPropertyValues(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.MaterialPropertyValues;
        }
        public static Boolean Visible(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.Visible;
        }
        public static Boolean IsSafe(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.IsSafe;
        }
        public static Object MaterialPropertyValues2(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.MaterialPropertyValues2;
        }
        public static object IMaterialPropertyValues2(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.MaterialPropertyValues2;
        }
        public static IFaultEntityObject Check3(IBody2Object IBody2instance)
        {
            return new IFaultEntityObject(IBody2instance.IBody2Instance.Check3);
        }
        public static String Name(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.Name;
        }
        public static Boolean DisableDisplay(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.DisableDisplay;
        }
        public static Boolean DisableHighlight(IBody2Object IBody2instance)
        {
            return IBody2instance.IBody2Instance.DisableHighlight;
        }
    }
}