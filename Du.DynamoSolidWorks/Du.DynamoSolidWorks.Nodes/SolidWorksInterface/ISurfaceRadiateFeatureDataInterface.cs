using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISurfaceRadiateFeatureDataObject
    {
        public ISurfaceRadiateFeatureData ISurfaceRadiateFeatureDataInstance { get; set; }
        public ISurfaceRadiateFeatureDataObject(ISurfaceRadiateFeatureData ISurfaceRadiateFeatureDatainstance)
        {
            ISurfaceRadiateFeatureDataInstance = ISurfaceRadiateFeatureDatainstance;
        }
    }
    public static class ISurfaceRadiateFeatureDataInterface
    {
        public static Boolean AccessSelections(ISurfaceRadiateFeatureDataObject ISurfaceRadiateFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISurfaceRadiateFeatureDatainstance.ISurfaceRadiateFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ISurfaceRadiateFeatureDataObject ISurfaceRadiateFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISurfaceRadiateFeatureDatainstance.ISurfaceRadiateFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISurfaceRadiateFeatureDataObject ISurfaceRadiateFeatureDatainstance)
        {
            ISurfaceRadiateFeatureDatainstance.ISurfaceRadiateFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetRadiatedEntitiesCount(ISurfaceRadiateFeatureDataObject ISurfaceRadiateFeatureDatainstance)
        {
            return ISurfaceRadiateFeatureDatainstance.ISurfaceRadiateFeatureDataInstance.GetRadiatedEntitiesCount();
        }
        public static Object IGetRadiatedEntities(ISurfaceRadiateFeatureDataObject ISurfaceRadiateFeatureDatainstance, Int32 Count)
        {
            return ISurfaceRadiateFeatureDatainstance.ISurfaceRadiateFeatureDataInstance.IGetRadiatedEntities(Count);
        }
        //public static void ISetRadiatedEntities(ISurfaceRadiateFeatureDataObject ISurfaceRadiateFeatureDatainstance, Int32 Count, Object& DispArr)
        //{
        //    return ISurfaceRadiateFeatureDatainstance.ISurfaceRadiateFeatureDataInstance.ISetRadiatedEntities(Count, DispArr);
        //}
        public static Object DirectionReference(ISurfaceRadiateFeatureDataObject ISurfaceRadiateFeatureDatainstance)
        {
            return ISurfaceRadiateFeatureDatainstance.ISurfaceRadiateFeatureDataInstance.DirectionReference;
        }
        public static Boolean Flip(ISurfaceRadiateFeatureDataObject ISurfaceRadiateFeatureDatainstance)
        {
            return ISurfaceRadiateFeatureDatainstance.ISurfaceRadiateFeatureDataInstance.Flip;
        }
        public static Boolean PropagateToTangentFaces(ISurfaceRadiateFeatureDataObject ISurfaceRadiateFeatureDatainstance)
        {
            return ISurfaceRadiateFeatureDatainstance.ISurfaceRadiateFeatureDataInstance.PropagateToTangentFaces;
        }
        public static Double Distance(ISurfaceRadiateFeatureDataObject ISurfaceRadiateFeatureDatainstance)
        {
            return ISurfaceRadiateFeatureDatainstance.ISurfaceRadiateFeatureDataInstance.Distance;
        }
        public static Object RadiatedEntities(ISurfaceRadiateFeatureDataObject ISurfaceRadiateFeatureDatainstance)
        {
            return ISurfaceRadiateFeatureDatainstance.ISurfaceRadiateFeatureDataInstance.RadiatedEntities;
        }
    }
}