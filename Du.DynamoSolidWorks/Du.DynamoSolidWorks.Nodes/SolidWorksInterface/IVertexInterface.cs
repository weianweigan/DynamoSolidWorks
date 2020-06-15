using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IVertexObject
    {
        public IVertex IVertexInstance { get; set; }
        public IVertexObject(IVertex IVertexinstance)
        {
            IVertexInstance = IVertexinstance;
        }
    }
    public static class IVertexInterface
    {
        public static Object GetPoint(IVertexObject IVertexinstance)
        {
            return IVertexinstance.IVertexInstance.GetPoint();
        }
        public static Double IGetPoint(IVertexObject IVertexinstance)
        {
            return IVertexinstance.IVertexInstance.IGetPoint();
        }
        //public static IEnumEdgesObject EnumEdges(IVertexObject IVertexinstance)
        //{
        //    return new IEnumEdgesObject(IVertexinstance.IVertexInstance.EnumEdges());
        //}
        public static Object GetClosestPointOn(IVertexObject IVertexinstance, Double X, Double Y, Double Z)
        {
            return IVertexinstance.IVertexInstance.GetClosestPointOn(X, Y, Z);
        }
        public static Double IGetClosestPointOn(IVertexObject IVertexinstance, Double X, Double Y, Double Z)
        {
            return IVertexinstance.IVertexInstance.IGetClosestPointOn(X, Y, Z);
        }
        //public static IEnumEdgesObject EnumEdgesOriented(IVertexObject IVertexinstance)
        //{
        //    return new IEnumEdgesObject(IVertexinstance.IVertexInstance.EnumEdgesOriented());
        //}
        public static Object GetEdges(IVertexObject IVertexinstance)
        {
            return IVertexinstance.IVertexInstance.GetEdges();
        }
        public static Object GetEdgesOriented(IVertexObject IVertexinstance)
        {
            return IVertexinstance.IVertexInstance.GetEdgesOriented();
        }
        public static Object GetAdjacentFaces(IVertexObject IVertexinstance)
        {
            return IVertexinstance.IVertexInstance.GetAdjacentFaces();
        }
        public static Int32 IGetAdjacentFacesCount(IVertexObject IVertexinstance)
        {
            return IVertexinstance.IVertexInstance.IGetAdjacentFacesCount();
        }
        public static IFace2Object IGetAdjacentFaces(IVertexObject IVertexinstance, Int32 NFaceCount)
        {
            return new IFace2Object(IVertexinstance.IVertexInstance.IGetAdjacentFaces(NFaceCount));
        }
        public static void Display(IVertexObject IVertexinstance, IModelDoc2Object TopDoc, Int32 Color, Double Scale, Boolean HighlightState)
        {
            IVertexinstance.IVertexInstance.Display(TopDoc?.IModelDoc2Instance?.CastObj<ModelDoc2>(), Color, Scale, HighlightState);
        }
        //public static Int32 GetTrackingIDs(IVertexObject IVertexinstance, Int32 TrackingCookie, Object& TrackingIDs)
        //{
        //    return IVertexinstance.IVertexInstance.GetTrackingIDs(TrackingCookie, TrackingIDs);
        //}
        public static Int32 SetTrackingID(IVertexObject IVertexinstance, Int32 TrackingCookie, Int32 TrackingID)
        {
            return IVertexinstance.IVertexInstance.SetTrackingID(TrackingCookie, TrackingID);
        }
        public static Int32 RemoveTrackingID(IVertexObject IVertexinstance, Int32 TrackingCookie)
        {
            return IVertexinstance.IVertexInstance.RemoveTrackingID(TrackingCookie);
        }
        public static Int32 GetTrackingIDsCount(IVertexObject IVertexinstance, Int32 TrackingCookie)
        {
            return IVertexinstance.IVertexInstance.GetTrackingIDsCount(TrackingCookie);
        }
        //public static Int32 IGetTrackingIDs(IVertexObject IVertexinstance, Int32 TrackingCookie, Int32 Count, Int32& TrackingIDs)
        //{
        //    return IVertexinstance.IVertexInstance.IGetTrackingIDs(TrackingCookie, Count, TrackingIDs);
        //}
        //public static Boolean IsTolerant(IVertexObject IVertexinstance, Double& Tolerance)
        //{
        //    return IVertexinstance.IVertexInstance.IsTolerant(Tolerance);
        //}
    }
}