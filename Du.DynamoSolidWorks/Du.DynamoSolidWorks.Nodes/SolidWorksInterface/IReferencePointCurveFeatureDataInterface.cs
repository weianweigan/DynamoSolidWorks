using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IReferencePointCurveFeatureDataObject
    {
        public IReferencePointCurveFeatureData IReferencePointCurveFeatureDataInstance { get; set; }
        public IReferencePointCurveFeatureDataObject(IReferencePointCurveFeatureData IReferencePointCurveFeatureDatainstance)
        {
            IReferencePointCurveFeatureDataInstance = IReferencePointCurveFeatureDatainstance;
        }
    }
    public static class IReferencePointCurveFeatureDataInterface
    {
        public static Boolean AccessSelections(IReferencePointCurveFeatureDataObject IReferencePointCurveFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IReferencePointCurveFeatureDatainstance.IReferencePointCurveFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component.IComponent2Instance.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IReferencePointCurveFeatureDataObject IReferencePointCurveFeatureDatainstance)
        {
            IReferencePointCurveFeatureDatainstance.IReferencePointCurveFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetThroughPointCount(IReferencePointCurveFeatureDataObject IReferencePointCurveFeatureDatainstance)
        {
            return IReferencePointCurveFeatureDatainstance.IReferencePointCurveFeatureDataInstance.GetThroughPointCount();
        }
        //public static Object GetThroughPoints(IReferencePointCurveFeatureDataObject IReferencePointCurveFeatureDatainstance, Object& Type)
        //{
        //    return IReferencePointCurveFeatureDatainstance.IReferencePointCurveFeatureDataInstance.GetThroughPoints(Type);
        //}
        public static void SetThroughPoints(IReferencePointCurveFeatureDataObject IReferencePointCurveFeatureDatainstance, Object Pts)
        {
            IReferencePointCurveFeatureDatainstance.IReferencePointCurveFeatureDataInstance.SetThroughPoints(Pts);
        }
        //public static Object IGetThroughPoints(IReferencePointCurveFeatureDataObject IReferencePointCurveFeatureDatainstance, Int32 Count, Int32& Type)
        //{
        //    return IReferencePointCurveFeatureDatainstance.IReferencePointCurveFeatureDataInstance.IGetThroughPoints(Count, Type);
        //}
        //public static void ISetThroughPoints(IReferencePointCurveFeatureDataObject IReferencePointCurveFeatureDatainstance, Int32 Count, Object& Pts)
        //{
        //    return IReferencePointCurveFeatureDatainstance.IReferencePointCurveFeatureDataInstance.ISetThroughPoints(Count, Pts);
        //}
        public static Boolean ClosedCurve(IReferencePointCurveFeatureDataObject IReferencePointCurveFeatureDatainstance)
        {
            return IReferencePointCurveFeatureDatainstance.IReferencePointCurveFeatureDataInstance.ClosedCurve;
        }
    }
}