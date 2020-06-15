using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICoEdgeObject
    {
        public ICoEdge ICoEdgeInstance { get; set; }
        public ICoEdgeObject(ICoEdge ICoEdgeinstance)
        {
            ICoEdgeInstance = ICoEdgeinstance;
        }
    }
    public static class ICoEdgeInterface
    {
        public static Object GetEdge(ICoEdgeObject ICoEdgeinstance)
        {
            return ICoEdgeinstance.ICoEdgeInstance.GetEdge();
        }
        public static IEdgeObject IGetEdge(ICoEdgeObject ICoEdgeinstance)
        {
            return new IEdgeObject(ICoEdgeinstance.ICoEdgeInstance.IGetEdge());
        }
        public static Object GetNext(ICoEdgeObject ICoEdgeinstance)
        {
            return ICoEdgeinstance.ICoEdgeInstance.GetNext();
        }
        public static ICoEdgeObject IGetNext(ICoEdgeObject ICoEdgeinstance)
        {
            return new ICoEdgeObject(ICoEdgeinstance.ICoEdgeInstance.IGetNext());
        }
        public static Object GetLoop(ICoEdgeObject ICoEdgeinstance)
        {
            return ICoEdgeinstance.ICoEdgeInstance.GetLoop();
        }
        public static ILoopObject IGetLoop(ICoEdgeObject ICoEdgeinstance)
        {
            return new ILoopObject(ICoEdgeinstance.ICoEdgeInstance.IGetLoop());
        }
        public static Boolean GetSense(ICoEdgeObject ICoEdgeinstance)
        {
            return ICoEdgeinstance.ICoEdgeInstance.GetSense();
        }
        public static Object GetPartner(ICoEdgeObject ICoEdgeinstance)
        {
            return ICoEdgeinstance.ICoEdgeInstance.GetPartner();
        }
        public static ICoEdgeObject IGetPartner(ICoEdgeObject ICoEdgeinstance)
        {
            return new ICoEdgeObject(ICoEdgeinstance.ICoEdgeInstance.IGetPartner());
        }
        public static Object GetCurveParams(ICoEdgeObject ICoEdgeinstance)
        {
            return ICoEdgeinstance.ICoEdgeInstance.GetCurveParams();
        }
        public static Object Evaluate(ICoEdgeObject ICoEdgeinstance, Double Param)
        {
            return ICoEdgeinstance.ICoEdgeInstance.Evaluate(Param);
        }
        public static Double IGetCurveParams(ICoEdgeObject ICoEdgeinstance)
        {
            return ICoEdgeinstance.ICoEdgeInstance.IGetCurveParams();
        }
        public static Double IEvaluate(ICoEdgeObject ICoEdgeinstance, Double Param)
        {
            return ICoEdgeinstance.ICoEdgeInstance.IEvaluate(Param);
        }
        public static Object GetCurve(ICoEdgeObject ICoEdgeinstance)
        {
            return ICoEdgeinstance.ICoEdgeInstance.GetCurve();
        }
        public static ICurveObject IGetCurve(ICoEdgeObject ICoEdgeinstance)
        {
            return new ICurveObject(ICoEdgeinstance.ICoEdgeInstance.IGetCurve());
        }
        public static ILoop2Object IGetLoop2(ICoEdgeObject ICoEdgeinstance)
        {
            return new ILoop2Object(ICoEdgeinstance.ICoEdgeInstance.IGetLoop2());
        }
        public static Object Evaluate2(ICoEdgeObject ICoEdgeinstance, Double Param, Int32 NumberOfDerivatives)
        {
            return ICoEdgeinstance.ICoEdgeInstance.Evaluate2(Param, NumberOfDerivatives);
        }
        public static Double IEvaluate2(ICoEdgeObject ICoEdgeinstance, Double Param, Int32 NumberOfDerivatives)
        {
            return ICoEdgeinstance.ICoEdgeInstance.IEvaluate2(Param, NumberOfDerivatives);
        }
    }
}