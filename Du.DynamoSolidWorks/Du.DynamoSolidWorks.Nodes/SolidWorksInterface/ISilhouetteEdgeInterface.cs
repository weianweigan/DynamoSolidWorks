using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISilhouetteEdgeObject
    {
        public ISilhouetteEdge ISilhouetteEdgeInstance { get; set; }
        public ISilhouetteEdgeObject(ISilhouetteEdge ISilhouetteEdgeinstance)
        {
            ISilhouetteEdgeInstance = ISilhouetteEdgeinstance;
        }
    }
    public static class ISilhouetteEdgeInterface
    {
        public static IMathPointObject GetStartPoint(ISilhouetteEdgeObject ISilhouetteEdgeinstance)
        {
            return new IMathPointObject(ISilhouetteEdgeinstance.ISilhouetteEdgeInstance.GetStartPoint());
        }
        public static IMathPointObject GetEndPoint(ISilhouetteEdgeObject ISilhouetteEdgeinstance)
        {
            return new IMathPointObject(ISilhouetteEdgeinstance.ISilhouetteEdgeInstance.GetEndPoint());
        }
        public static IFace2Object GetFace(ISilhouetteEdgeObject ISilhouetteEdgeinstance)
        {
            return new IFace2Object(ISilhouetteEdgeinstance.ISilhouetteEdgeInstance.GetFace());
        }
        public static Boolean Select(ISilhouetteEdgeObject ISilhouetteEdgeinstance, Boolean Append, ISelectDataObject Data)
        {
            return ISilhouetteEdgeinstance.ISilhouetteEdgeInstance.Select(Append, Data?.ISelectDataInstance?.CastObj<SelectData>());
        }
        public static IViewObject GetView(ISilhouetteEdgeObject ISilhouetteEdgeinstance)
        {
            return new IViewObject(ISilhouetteEdgeinstance.ISilhouetteEdgeInstance.GetView());
        }
        public static ICurveObject GetCurve(ISilhouetteEdgeObject ISilhouetteEdgeinstance)
        {
            return new ICurveObject(ISilhouetteEdgeinstance.ISilhouetteEdgeInstance.GetCurve());
        }
        public static Boolean Select2(ISilhouetteEdgeObject ISilhouetteEdgeinstance, Boolean Append, ISelectDataObject Data)
        {
            return ISilhouetteEdgeinstance.ISilhouetteEdgeInstance.Select2(Append, Data?.ISelectDataInstance?.CastObj<SelectData>());
        }
    }
}