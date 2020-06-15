using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILoop2Object
    {
        public ILoop2 ILoop2Instance { get; set; }
        public ILoop2Object(ILoop2 ILoop2instance)
        {
            ILoop2Instance = ILoop2instance;
        }
    }
    public static class ILoop2Interface
    {
        public static Object GetNext(ILoop2Object ILoop2instance)
        {
            return ILoop2instance.ILoop2Instance.GetNext();
        }
        public static ILoop2Object IGetNext(ILoop2Object ILoop2instance)
        {
            return new ILoop2Object(ILoop2instance.ILoop2Instance.IGetNext());
        }
        public static Object GetEdges(ILoop2Object ILoop2instance)
        {
            return ILoop2instance.ILoop2Instance.GetEdges();
        }
        public static IEdgeObject IGetEdges(ILoop2Object ILoop2instance)
        {
            return new IEdgeObject(ILoop2instance.ILoop2Instance.IGetEdges());
        }
        public static Int32 GetEdgeCount(ILoop2Object ILoop2instance)
        {
            return ILoop2instance.ILoop2Instance.GetEdgeCount();
        }
        public static Boolean IsOuter(ILoop2Object ILoop2instance)
        {
            return ILoop2instance.ILoop2Instance.IsOuter();
        }
        public static Object GetFirstCoEdge(ILoop2Object ILoop2instance)
        {
            return ILoop2instance.ILoop2Instance.GetFirstCoEdge();
        }
        public static ICoEdgeObject IGetFirstCoEdge(ILoop2Object ILoop2instance)
        {
            return new ICoEdgeObject(ILoop2instance.ILoop2Instance.IGetFirstCoEdge());
        }
        //public static IEnumEdgesObject EnumEdges(ILoop2Object ILoop2instance)
        //{
        //    return new IEnumEdgesObject(ILoop2instance.ILoop2Instance.EnumEdges());
        //}
        //public static IEnumCoEdgesObject EnumCoEdges(ILoop2Object ILoop2instance)
        //{
        //    return new IEnumCoEdgesObject(ILoop2instance.ILoop2Instance.EnumCoEdges());
        //}
        public static Object GetFace(ILoop2Object ILoop2instance)
        {
            return ILoop2instance.ILoop2Instance.GetFace();
        }
        public static IFace2Object IGetFace(ILoop2Object ILoop2instance)
        {
            return new IFace2Object(ILoop2instance.ILoop2Instance.IGetFace());
        }
        public static Object SweepPlanarLoop(ILoop2Object ILoop2instance, Double X, Double Y, Double Z, Double DraftAngle)
        {
            return ILoop2instance.ILoop2Instance.SweepPlanarLoop(X, Y, Z, DraftAngle);
        }
        //public static IBody2Object ISweepPlanarLoop(ILoop2Object ILoop2instance, Double X, Double Y, Double Z, Double DraftAngle, Face2&Object StopFacesOut)
        //{
        //    return new IBody2Object(ILoop2instance.ILoop2Instance.ISweepPlanarLoop(X, Y, Z, DraftAngle, StopFacesOut));
        //}
        public static void Dummy015(ILoop2Object ILoop2instance)
        {
            ILoop2instance.ILoop2Instance.Dummy015();
        }
        public static void Dummy016(ILoop2Object ILoop2instance)
        {
            ILoop2instance.ILoop2Instance.Dummy016();
        }
        public static Object RevolvePlanarLoop(ILoop2Object ILoop2instance, Double X, Double Y, Double Z, Double Axisx, Double Axisy, Double Axisz, Double RevAngle)
        {
            return ILoop2instance.ILoop2Instance.RevolvePlanarLoop(X, Y, Z, Axisx, Axisy, Axisz, RevAngle);
        }
        //public static IBody2Object IRevolvePlanarLoop(ILoop2Object ILoop2instance, Double X, Double Y, Double Z, Double Axisx, Double Axisy, Double Axisz, Double RevAngle, Face2&Object StopFacesOut)
        //{
        //    return new IBody2Object(ILoop2instance.ILoop2Instance.IRevolvePlanarLoop(X, Y, Z, Axisx, Axisy, Axisz, RevAngle, StopFacesOut));
        //}
        public static Boolean IsSingular(ILoop2Object ILoop2instance)
        {
            return ILoop2instance.ILoop2Instance.IsSingular();
        }
        public static Int32 GetVertexCount(ILoop2Object ILoop2instance)
        {
            return ILoop2instance.ILoop2Instance.GetVertexCount();
        }
        public static Object GetVertices(ILoop2Object ILoop2instance)
        {
            return ILoop2instance.ILoop2Instance.GetVertices();
        }
        //public static void IGetVertices(ILoop2Object ILoop2instance, Int32 NumVertices, Vertex&Object Vertices)
        //{
        //    return ILoop2instance.ILoop2Instance.IGetVertices(NumVertices, Vertices);
        //}
        //public static Int32 GetTrackingIDs(ILoop2Object ILoop2instance, Int32 TrackingCookie, Object& TrackingIDs)
        //{
        //    return ILoop2instance.ILoop2Instance.GetTrackingIDs(TrackingCookie, TrackingIDs);
        //}
        public static Int32 SetTrackingID(ILoop2Object ILoop2instance, Int32 TrackingCookie, Int32 TrackingID)
        {
            return ILoop2instance.ILoop2Instance.SetTrackingID(TrackingCookie, TrackingID);
        }
        public static Int32 RemoveTrackingID(ILoop2Object ILoop2instance, Int32 TrackingCookie)
        {
            return ILoop2instance.ILoop2Instance.RemoveTrackingID(TrackingCookie);
        }
        public static Int32 GetTrackingIDsCount(ILoop2Object ILoop2instance, Int32 TrackingCookie)
        {
            return ILoop2instance.ILoop2Instance.GetTrackingIDsCount(TrackingCookie);
        }
        //public static Int32 IGetTrackingIDs(ILoop2Object ILoop2instance, Int32 TrackingCookie, Int32 Count, Int32& TrackingIDs)
        //{
        //    return ILoop2instance.ILoop2Instance.IGetTrackingIDs(TrackingCookie, Count, TrackingIDs);
        //}
        public static Boolean Select(ILoop2Object ILoop2instance, Object Edge, Boolean Append, Object SelectionData)
        {
            return ILoop2instance.ILoop2Instance.Select(Edge, Append, SelectionData);
        }
        public static Int32 GetCoEdgeCount(ILoop2Object ILoop2instance)
        {
            return ILoop2instance.ILoop2Instance.GetCoEdgeCount();
        }
        public static Object GetCoEdges(ILoop2Object ILoop2instance)
        {
            return ILoop2instance.ILoop2Instance.GetCoEdges();
        }
        public static ICoEdgeObject IGetCoEdges(ILoop2Object ILoop2instance, Int32 NumCoEdges)
        {
            return new ICoEdgeObject(ILoop2instance.ILoop2Instance.IGetCoEdges(NumCoEdges));
        }
    }
}