using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICoreFeatureDataObject
    {
        public ICoreFeatureData ICoreFeatureDataInstance { get; set; }
        public ICoreFeatureDataObject(ICoreFeatureData ICoreFeatureDatainstance)
        {
            ICoreFeatureDataInstance = ICoreFeatureDatainstance;
        }
    }
    public static class ICoreFeatureDataInterface
    {
        public static Boolean AccessSelections(ICoreFeatureDataObject ICoreFeatureDatainstance, IModelDoc2Object PTopDoc, IComponent2Object PComponent)
        {
            return ICoreFeatureDatainstance.ICoreFeatureDataInstance.AccessSelections(PTopDoc.IModelDoc2Instance as ModelDoc2, PComponent.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(ICoreFeatureDataObject ICoreFeatureDatainstance)
        {
            ICoreFeatureDatainstance.ICoreFeatureDataInstance.ReleaseSelectionAccess();
        }
        //public static Int32 GetExtractionDirection(ICoreFeatureDataObject ICoreFeatureDatainstance, Int32& Type1, Object& PDir1, Int32& Type2, Object& PDir2)
        //{
        //    return ICoreFeatureDatainstance.ICoreFeatureDataInstance.GetExtractionDirection(Type1, PDir1, Type2, PDir2);
        //}
        public static Boolean SetExtractionDirection(ICoreFeatureDataObject ICoreFeatureDatainstance, Object PDir1, Object PDir2)
        {
            return ICoreFeatureDatainstance.ICoreFeatureDataInstance.SetExtractionDirection(PDir1, PDir2);
        }
        public static IFeatureObject BoundingSketch(ICoreFeatureDataObject ICoreFeatureDatainstance)
        {
            return new IFeatureObject(ICoreFeatureDatainstance.ICoreFeatureDataInstance.BoundingSketch);
        }
        public static Boolean ReverseDirection(ICoreFeatureDataObject ICoreFeatureDatainstance)
        {
            return ICoreFeatureDatainstance.ICoreFeatureDataInstance.ReverseDirection;
        }
        public static IBody2Object TargetBody(ICoreFeatureDataObject ICoreFeatureDatainstance)
        {
            return new IBody2Object(ICoreFeatureDatainstance.ICoreFeatureDataInstance.TargetBody);
        }
        public static Boolean UseDraft(ICoreFeatureDataObject ICoreFeatureDatainstance)
        {
            return ICoreFeatureDatainstance.ICoreFeatureDataInstance.UseDraft;
        }
        public static Double DraftAngle(ICoreFeatureDataObject ICoreFeatureDatainstance)
        {
            return ICoreFeatureDatainstance.ICoreFeatureDataInstance.DraftAngle;
        }
        public static Boolean DraftOutward(ICoreFeatureDataObject ICoreFeatureDatainstance)
        {
            return ICoreFeatureDatainstance.ICoreFeatureDataInstance.DraftOutward;
        }
        public static Int32 EndCondition(ICoreFeatureDataObject ICoreFeatureDatainstance, int Index)
        {
            return ICoreFeatureDatainstance.ICoreFeatureDataInstance.EndCondition[Index];
        }
        public static Double Depth(ICoreFeatureDataObject ICoreFeatureDatainstance, int Index)
        {
            return ICoreFeatureDatainstance.ICoreFeatureDataInstance.Depth[Index];
        }
        public static Boolean CapEnds(ICoreFeatureDataObject ICoreFeatureDatainstance)
        {
            return ICoreFeatureDatainstance.ICoreFeatureDataInstance.CapEnds;
        }
    }
}