using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ITessellationObject
    {
        public ITessellation ITessellationInstance { get; set; }
        public ITessellationObject(ITessellation ITessellationinstance)
        {
            ITessellationInstance = ITessellationinstance;
        }
    }
    public static class ITessellationInterface
    {
        public static Boolean Tessellate(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.Tessellate();
        }
        public static Int32 GetFacetCount(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.GetFacetCount();
        }
        public static Int32 GetFinCount(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.GetFinCount();
        }
        public static Int32 GetVertexCount(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.GetVertexCount();
        }
        public static Object GetFacetFins(ITessellationObject ITessellationinstance, Int32 FacetId)
        {
            return ITessellationinstance.ITessellationInstance.GetFacetFins(FacetId);
        }
        public static Int32 IGetFacetFinsCount(ITessellationObject ITessellationinstance, Int32 FacetId)
        {
            return ITessellationinstance.ITessellationInstance.IGetFacetFinsCount(FacetId);
        }
        public static Int32 IGetFacetFins(ITessellationObject ITessellationinstance, Int32 FacetId)
        {
            return ITessellationinstance.ITessellationInstance.IGetFacetFins(FacetId);
        }
        public static Int32 GetFinCoFin(ITessellationObject ITessellationinstance, Int32 FinId)
        {
            return ITessellationinstance.ITessellationInstance.GetFinCoFin(FinId);
        }
        public static Object GetFinVertices(ITessellationObject ITessellationinstance, Int32 FinId)
        {
            return ITessellationinstance.ITessellationInstance.GetFinVertices(FinId);
        }
        public static Int32 IGetFinVertices(ITessellationObject ITessellationinstance, Int32 FinId)
        {
            return ITessellationinstance.ITessellationInstance.IGetFinVertices(FinId);
        }
        public static Object GetVertexPoint(ITessellationObject ITessellationinstance, Int32 VertexId)
        {
            return ITessellationinstance.ITessellationInstance.GetVertexPoint(VertexId);
        }
        public static Double IGetVertexPoint(ITessellationObject ITessellationinstance, Int32 VertexId)
        {
            return ITessellationinstance.ITessellationInstance.IGetVertexPoint(VertexId);
        }
        public static Object GetVertexNormal(ITessellationObject ITessellationinstance, Int32 VertexId)
        {
            return ITessellationinstance.ITessellationInstance.GetVertexNormal(VertexId);
        }
        public static Double IGetVertexNormal(ITessellationObject ITessellationinstance, Int32 VertexId)
        {
            return ITessellationinstance.ITessellationInstance.IGetVertexNormal(VertexId);
        }
        public static Object GetVertexParams(ITessellationObject ITessellationinstance, Int32 VertexId)
        {
            return ITessellationinstance.ITessellationInstance.GetVertexParams(VertexId);
        }
        public static Double IGetVertexParams(ITessellationObject ITessellationinstance, Int32 VertexId)
        {
            return ITessellationinstance.ITessellationInstance.IGetVertexParams(VertexId);
        }
        public static Object GetFaceFacets(ITessellationObject ITessellationinstance, Object Facedisp)
        {
            return ITessellationinstance.ITessellationInstance.GetFaceFacets(Facedisp);
        }
        //public static Int32 IGetFaceFacetsCount(ITessellationObject ITessellationinstance, FaceObject FaceObj)
        //{
        //    return ITessellationinstance.ITessellationInstance.IGetFaceFacetsCount(FaceObj);
        //}
        //public static Int32 IGetFaceFacets(ITessellationObject ITessellationinstance, FaceObject FaceObj)
        //{
        //    return ITessellationinstance.ITessellationInstance.IGetFaceFacets(FaceObj);
        //}
        public static Object GetFacetFace(ITessellationObject ITessellationinstance, Int32 FacetId)
        {
            return ITessellationinstance.ITessellationInstance.GetFacetFace(FacetId);
        }
        public static IFaceObject IGetFacetFace(ITessellationObject ITessellationinstance, Int32 FacetId)
        {
            return new IFaceObject(ITessellationinstance.ITessellationInstance.IGetFacetFace(FacetId));
        }
        public static Object GetEdgeFins(ITessellationObject ITessellationinstance, Object EdgeDisp)
        {
            return ITessellationinstance.ITessellationInstance.GetEdgeFins(EdgeDisp);
        }
        //public static Int32 IGetEdgeFinsCount(ITessellationObject ITessellationinstance, EdgeObject EdgeObj)
        //{
        //    return ITessellationinstance.ITessellationInstance.IGetEdgeFinsCount(EdgeObj);
        //}
        //public static Int32 IGetEdgeFins(ITessellationObject ITessellationinstance, EdgeObject EdgeObj)
        //{
        //    return ITessellationinstance.ITessellationInstance.IGetEdgeFins(EdgeObj);
        //}
        public static Object GetFinEdge(ITessellationObject ITessellationinstance, Int32 FinId)
        {
            return ITessellationinstance.ITessellationInstance.GetFinEdge(FinId);
        }
        public static IEdgeObject IGetFinEdge(ITessellationObject ITessellationinstance, Int32 FinId)
        {
            return new IEdgeObject(ITessellationinstance.ITessellationInstance.IGetFinEdge(FinId));
        }
        //public static void GetErrorList(ITessellationObject ITessellationinstance, Object& FaceErrArray, Object& FacetErrArray, Object& VertexPointErrArray, Object& VertexNormalErrArray, Object& VertexParamsErrArray)
        //{
        //    return ITessellationinstance.ITessellationInstance.GetErrorList(FaceErrArray, FacetErrArray, VertexPointErrArray, VertexNormalErrArray, VertexParamsErrArray);
        //}
        //public static void IGetErrorListCount(ITessellationObject ITessellationinstance, Int32& FaceErrArrayCount, Int32& FacetErrArrayCount, Int32& VertexPointErrArrayCount, Int32& VertexNormalErrArrayCount, Int32& VertexParamsErrArrayCount)
        //{
        //    return ITessellationinstance.ITessellationInstance.IGetErrorListCount(FaceErrArrayCount, FacetErrArrayCount, VertexPointErrArrayCount, VertexNormalErrArrayCount, VertexParamsErrArrayCount);
        //}
        //public static void IGetErrorList(ITessellationObject ITessellationinstance, Face&Object FaceErrArray, Int32& FacetErrArray, Int32& VertexPointErrArray, Int32& VertexNormalErrArray, Int32& VertexParamsErrArray)
        //{
        //    return ITessellationinstance.ITessellationInstance.IGetErrorList(FaceErrArray, FacetErrArray, VertexPointErrArray, VertexNormalErrArray, VertexParamsErrArray);
        //}
        //public static Int32 IGetFaceFacetsCount2(ITessellationObject ITessellationinstance, Face2Object FaceObj)
        //{
        //    return ITessellationinstance.ITessellationInstance.IGetFaceFacetsCount2(FaceObj);
        //}
        //public static Int32 IGetFaceFacets2(ITessellationObject ITessellationinstance, Face2Object FaceObj)
        //{
        //    return ITessellationinstance.ITessellationInstance.IGetFaceFacets2(FaceObj);
        //}
        public static IFace2Object IGetFacetFace2(ITessellationObject ITessellationinstance, Int32 FacetId)
        {
            return new IFace2Object(ITessellationinstance.ITessellationInstance.IGetFacetFace2(FacetId));
        }
        //public static void IGetErrorList2(ITessellationObject ITessellationinstance, Face2&Object FaceErrArray, Int32& FacetErrArray, Int32& VertexPointErrArray, Int32& VertexNormalErrArray, Int32& VertexParamsErrArray)
        //{
        //    return ITessellationinstance.ITessellationInstance.IGetErrorList2(FaceErrArray, FacetErrArray, VertexPointErrArray, VertexNormalErrArray, VertexParamsErrArray);
        //}
        public static Double MaxFacetWidth(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.MaxFacetWidth;
        }
        public static Double CurveChordTolerance(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.CurveChordTolerance;
        }
        public static Double CurveChordAngleTolerance(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.CurveChordAngleTolerance;
        }
        public static Double SurfacePlaneTolerance(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.SurfacePlaneTolerance;
        }
        public static Double SurfacePlaneAngleTolerance(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.SurfacePlaneAngleTolerance;
        }
        public static Boolean NeedVertexNormal(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.NeedVertexNormal;
        }
        public static Boolean NeedVertexParams(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.NeedVertexParams;
        }
        public static Boolean NeedFaceFacetMap(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.NeedFaceFacetMap;
        }
        public static Boolean NeedEdgeFinMap(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.NeedEdgeFinMap;
        }
        public static Boolean NeedErrorList(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.NeedErrorList;
        }
        public static Double MinFacetWidth(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.MinFacetWidth;
        }
        public static Int32 MatchType(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.MatchType;
        }
        public static Boolean ImprovedQuality(ITessellationObject ITessellationinstance)
        {
            return ITessellationinstance.ITessellationInstance.ImprovedQuality;
        }
    }
}