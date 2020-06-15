using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IEdgeObject
    {
        public IEdge IEdgeInstance { get; set; }
        public IEdgeObject(IEdge IEdgeinstance)
        {
            IEdgeInstance = IEdgeinstance;
        }
    }
    public static class IEdgeInterface
    {
        public static Object GetCurve(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.GetCurve();
        }
        public static ICurveObject IGetCurve(IEdgeObject IEdgeinstance)
        {
            return new ICurveObject(IEdgeinstance.IEdgeInstance.IGetCurve());
        }
        public static Object GetCurveParams(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.GetCurveParams();
        }
        public static Double IGetCurveParams(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.IGetCurveParams();
        }
        public static Object Evaluate(IEdgeObject IEdgeinstance, Double Parameter)
        {
            return IEdgeinstance.IEdgeInstance.Evaluate(Parameter);
        }
        public static Double IEvaluate(IEdgeObject IEdgeinstance, Double Parameter)
        {
            return IEdgeinstance.IEdgeInstance.IEvaluate(Parameter);
        }
        public static Object GetParameter(IEdgeObject IEdgeinstance, Double X, Double Y, Double Z)
        {
            return IEdgeinstance.IEdgeInstance.GetParameter(X, Y, Z);
        }
        public static Double IGetParameter(IEdgeObject IEdgeinstance, Double X, Double Y, Double Z)
        {
            return IEdgeinstance.IEdgeInstance.IGetParameter(X, Y, Z);
        }
        public static Boolean EdgeInFaceSense(IEdgeObject IEdgeinstance, Object Facedisp)
        {
            return IEdgeinstance.IEdgeInstance.EdgeInFaceSense(Facedisp);
        }
        public static Boolean IEdgeInFaceSense(IEdgeObject IEdgeinstance, IFaceObject Facedisp)
        {
            return IEdgeinstance.IEdgeInstance.IEdgeInFaceSense(Facedisp.IFaceInstance as Face);
        }
        public static Object GetTwoAdjacentFaces(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.GetTwoAdjacentFaces();
        }
        //public static void IGetTwoAdjacentFaces(IEdgeObject IEdgeinstance, Face&Object Face1, Face&Object Face2)
        //{
        //    return IEdgeinstance.IEdgeInstance.IGetTwoAdjacentFaces(Face1, Face2);
        //}
        //public static IEnumCoEdgesObject EnumCoEdges(IEdgeObject IEdgeinstance)
        //{
        //    return new IEnumCoEdgesObject(IEdgeinstance.IEdgeInstance.EnumCoEdges());
        //}
        public static Object GetStartVertex(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.GetStartVertex();
        }
        public static IVertexObject IGetStartVertex(IEdgeObject IEdgeinstance)
        {
            return new IVertexObject(IEdgeinstance.IEdgeInstance.IGetStartVertex());
        }
        public static Object GetEndVertex(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.GetEndVertex();
        }
        public static IVertexObject IGetEndVertex(IEdgeObject IEdgeinstance)
        {
            return new IVertexObject(IEdgeinstance.IEdgeInstance.IGetEndVertex());
        }
        public static Object GetClosestPointOn(IEdgeObject IEdgeinstance, Double X, Double Y, Double Z)
        {
            return IEdgeinstance.IEdgeInstance.GetClosestPointOn(X, Y, Z);
        }
        public static Double IGetClosestPointOn(IEdgeObject IEdgeinstance, Double X, Double Y, Double Z)
        {
            return IEdgeinstance.IEdgeInstance.IGetClosestPointOn(X, Y, Z);
        }
        public static Boolean RemoveRedundantTopology(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.RemoveRedundantTopology();
        }
        public static Int32 GetID(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.GetID();
        }
        public static void SetId(IEdgeObject IEdgeinstance, Int32 IdIn)
        {
            IEdgeinstance.IEdgeInstance.SetId(IdIn);
        }
        public static void RemoveId(IEdgeObject IEdgeinstance)
        {
            IEdgeinstance.IEdgeInstance.RemoveId();
        }
        public static Object GetCurveParams2(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.GetCurveParams2();
        }
        public static Double IGetCurveParams2(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.IGetCurveParams2();
        }
        public static Boolean IsParamReversed(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.IsParamReversed();
        }
        public static void Highlight(IEdgeObject IEdgeinstance, Boolean State)
        {
            IEdgeinstance.IEdgeInstance.Highlight(State);
        }
        public static Object GetCoEdges(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.GetCoEdges();
        }
        public static Boolean IEdgeInFaceSense2(IEdgeObject IEdgeinstance, IFace2Object Facedisp)
        {
            return IEdgeinstance.IEdgeInstance.IEdgeInFaceSense2(Facedisp.IFace2Instance as Face2);
        }
        public static Object GetTwoAdjacentFaces2(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.GetTwoAdjacentFaces2();
        }
        //public static void IGetTwoAdjacentFaces2(IEdgeObject IEdgeinstance, Face2&Object Face1, Face2&Object Face2)
        //{
        //    return IEdgeinstance.IEdgeInstance.IGetTwoAdjacentFaces2(Face1, Face2);
        //}
        public static void Display(IEdgeObject IEdgeinstance, Int32 Width, Double Red, Double Green, Double Blue, Boolean HighlightState)
        {
            IEdgeinstance.IEdgeInstance.Display(Width, Red, Green, Blue, HighlightState);
        }
        public static Int32 GetTangentEdgesCount(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.GetTangentEdgesCount();
        }
        public static IEdgeObject IGetTangentEdges(IEdgeObject IEdgeinstance, Int32 Count)
        {
            return new IEdgeObject(IEdgeinstance.IEdgeInstance.IGetTangentEdges(Count));
        }
        public static Object GetTangentEdges(IEdgeObject IEdgeinstance)
        {
            return IEdgeinstance.IEdgeInstance.GetTangentEdges();
        }
        public static IBody2Object CreateWireBody(IEdgeObject IEdgeinstance)
        {
            return new IBody2Object(IEdgeinstance.IEdgeInstance.CreateWireBody());
        }
        public static IBody2Object GetBody(IEdgeObject IEdgeinstance)
        {
            return new IBody2Object(IEdgeinstance.IEdgeInstance.GetBody());
        }
        public static Object Evaluate2(IEdgeObject IEdgeinstance, Double Parameter, Int32 NumberOfDerivatives)
        {
            return IEdgeinstance.IEdgeInstance.Evaluate2(Parameter, NumberOfDerivatives);
        }
        public static Double IEvaluate2(IEdgeObject IEdgeinstance, Double Parameter, Int32 NumberOfDerivatives)
        {
            return IEdgeinstance.IEdgeInstance.IEvaluate2(Parameter, NumberOfDerivatives);
        }
        //public static Int32 GetTrackingIDs(IEdgeObject IEdgeinstance, Int32 TrackingCookie, Object& TrackingIDs)
        //{
        //    return IEdgeinstance.IEdgeInstance.GetTrackingIDs(TrackingCookie, TrackingIDs);
        //}
        public static Int32 SetTrackingID(IEdgeObject IEdgeinstance, Int32 TrackingCookie, Int32 TrackingID)
        {
            return IEdgeinstance.IEdgeInstance.SetTrackingID(TrackingCookie, TrackingID);
        }
        public static Int32 RemoveTrackingID(IEdgeObject IEdgeinstance, Int32 TrackingCookie)
        {
            return IEdgeinstance.IEdgeInstance.RemoveTrackingID(TrackingCookie);
        }
        public static Int32 GetTrackingIDsCount(IEdgeObject IEdgeinstance, Int32 TrackingCookie)
        {
            return IEdgeinstance.IEdgeInstance.GetTrackingIDsCount(TrackingCookie);
        }
        //public static Int32 IGetTrackingIDs(IEdgeObject IEdgeinstance, Int32 TrackingCookie, Int32 Count, Int32& TrackingIDs)
        //{
        //    return IEdgeinstance.IEdgeInstance.IGetTrackingIDs(TrackingCookie, Count, TrackingIDs);
        //}
        //public static Boolean IsTolerant(IEdgeObject IEdgeinstance, Double& Tolerance)
        //{
        //    return IEdgeinstance.IEdgeInstance.IsTolerant(Tolerance);
        //}
        public static ICurveParamDataObject GetCurveParams3(IEdgeObject IEdgeinstance)
        {
            return new ICurveParamDataObject(IEdgeinstance.IEdgeInstance.GetCurveParams3());
        }
        public static IFaultEntityObject Check(IEdgeObject IEdgeinstance)
        {
            return new IFaultEntityObject(IEdgeinstance.IEdgeInstance.Check);
        }
    }
}