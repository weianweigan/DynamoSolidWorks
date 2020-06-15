using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICombineBodiesFeatureDataObject
    {
        public ICombineBodiesFeatureData ICombineBodiesFeatureDataInstance { get; set; }
        public ICombineBodiesFeatureDataObject(ICombineBodiesFeatureData ICombineBodiesFeatureDatainstance)
        {
            ICombineBodiesFeatureDataInstance = ICombineBodiesFeatureDatainstance;
        }
    }
    public static class ICombineBodiesFeatureDataInterface
    {
        public static Boolean AccessSelections(ICombineBodiesFeatureDataObject ICombineBodiesFeatureDatainstance, IModelDoc2Object PTopDoc, IComponent2Object PComponent)
        {
            return ICombineBodiesFeatureDatainstance.ICombineBodiesFeatureDataInstance.AccessSelections(PTopDoc.IModelDoc2Instance as ModelDoc2, PComponent.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(ICombineBodiesFeatureDataObject ICombineBodiesFeatureDatainstance)
        {
            ICombineBodiesFeatureDatainstance.ICombineBodiesFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetBodiesToCombineCount(ICombineBodiesFeatureDataObject ICombineBodiesFeatureDatainstance)
        {
            return ICombineBodiesFeatureDatainstance.ICombineBodiesFeatureDataInstance.GetBodiesToCombineCount();
        }
        public static IBody2Object IGetBodiesToCombine(ICombineBodiesFeatureDataObject ICombineBodiesFeatureDatainstance, Int32 NCount)
        {
            return new IBody2Object(ICombineBodiesFeatureDatainstance.ICombineBodiesFeatureDataInstance.IGetBodiesToCombine(NCount));
        }

        //ref not solve
        public static void ISetBodiesToCombine(ICombineBodiesFeatureDataObject ICombineBodiesFeatureDatainstance, Int32 NCount, IBody2Object PBodiesToCombine)
        {
            ICombineBodiesFeatureDatainstance.ICombineBodiesFeatureDataInstance.ISetBodiesToCombine(NCount, PBodiesToCombine.IBody2Instance as Body2);
        }
        public static IBody2Object MainBody(ICombineBodiesFeatureDataObject ICombineBodiesFeatureDatainstance)
        {
            return new IBody2Object(ICombineBodiesFeatureDatainstance.ICombineBodiesFeatureDataInstance.MainBody);
        }
        public static Object BodiesToCombine(ICombineBodiesFeatureDataObject ICombineBodiesFeatureDatainstance)
        {
            return ICombineBodiesFeatureDatainstance.ICombineBodiesFeatureDataInstance.BodiesToCombine;
        }
        public static Int32 OperationType(ICombineBodiesFeatureDataObject ICombineBodiesFeatureDatainstance)
        {
            return ICombineBodiesFeatureDatainstance.ICombineBodiesFeatureDataInstance.OperationType;
        }
    }
}