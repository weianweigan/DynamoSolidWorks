using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILoopObject
    {
        public ILoop ILoopInstance { get; set; }
        public ILoopObject(ILoop ILoopinstance)
        {
            ILoopInstance = ILoopinstance;
        }
    }
    public static class ILoopInterface
    {
        public static Object GetNext(ILoopObject ILoopinstance)
        {
            return ILoopinstance.ILoopInstance.GetNext();
        }
        public static ILoopObject IGetNext(ILoopObject ILoopinstance)
        {
            return new ILoopObject(ILoopinstance.ILoopInstance.IGetNext());
        }
        public static Object GetEdges(ILoopObject ILoopinstance)
        {
            return ILoopinstance.ILoopInstance.GetEdges();
        }
        public static IntPtr IGetEdges(ILoopObject ILoopinstance)
        {
            return ILoopinstance.ILoopInstance.IGetEdges();
        }
        public static Int32 GetEdgeCount(ILoopObject ILoopinstance)
        {
            return ILoopinstance.ILoopInstance.GetEdgeCount();
        }
        public static Boolean IsOuter(ILoopObject ILoopinstance)
        {
            return ILoopinstance.ILoopInstance.IsOuter();
        }
        public static Object GetFirstCoEdge(ILoopObject ILoopinstance)
        {
            return ILoopinstance.ILoopInstance.GetFirstCoEdge();
        }
        public static ICoEdgeObject IGetFirstCoEdge(ILoopObject ILoopinstance)
        {
            return new ICoEdgeObject(ILoopinstance.ILoopInstance.IGetFirstCoEdge());
        }
        //public static IEnumEdgesObject EnumEdges(ILoopObject ILoopinstance)
        //{
        //    return new IEnumEdgesObject(ILoopinstance.ILoopInstance.EnumEdges());
        //}
        //public static IEnumCoEdgesObject EnumCoEdges(ILoopObject ILoopinstance)
        //{
        //    return new IEnumCoEdgesObject(ILoopinstance.ILoopInstance.EnumCoEdges());
        //}
        public static Object GetFace(ILoopObject ILoopinstance)
        {
            return ILoopinstance.ILoopInstance.GetFace();
        }
        public static IFaceObject IGetFace(ILoopObject ILoopinstance)
        {
            return new IFaceObject(ILoopinstance.ILoopInstance.IGetFace());
        }
        public static Object SweepPlanarLoop(ILoopObject ILoopinstance, Double X, Double Y, Double Z, Double DraftAngle)
        {
            return ILoopinstance.ILoopInstance.SweepPlanarLoop(X, Y, Z, DraftAngle);
        }
        //public static IBodyObject ISweepPlanarLoop(ILoopObject ILoopinstance, Double X, Double Y, Double Z, Double DraftAngle, Face&Object StopFacesOut)
        //{
        //    return new IBodyObject(ILoopinstance.ILoopInstance.ISweepPlanarLoop(X, Y, Z, DraftAngle, StopFacesOut));
        //}
        public static void Dummy015(ILoopObject ILoopinstance)
        {
            ILoopinstance.ILoopInstance.Dummy015();
        }
        public static void Dummy016(ILoopObject ILoopinstance)
        {
            ILoopinstance.ILoopInstance.Dummy016();
        }
        public static Object RevolvePlanarLoop(ILoopObject ILoopinstance, Double X, Double Y, Double Z, Double Axisx, Double Axisy, Double Axisz, Double RevAngle)
        {
            return ILoopinstance.ILoopInstance.RevolvePlanarLoop(X, Y, Z, Axisx, Axisy, Axisz, RevAngle);
        }
        //public static IBodyObject IRevolvePlanarLoop(ILoopObject ILoopinstance, Double X, Double Y, Double Z, Double Axisx, Double Axisy, Double Axisz, Double RevAngle, Face&Object StopFacesOut)
        //{
        //    return new IBodyObject(ILoopinstance.ILoopInstance.IRevolvePlanarLoop(X, Y, Z, Axisx, Axisy, Axisz, RevAngle, StopFacesOut));
        //}
    }
}