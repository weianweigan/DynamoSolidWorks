using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDerivedPatternFeatureDataObject
    {
        public IDerivedPatternFeatureData IDerivedPatternFeatureDataInstance { get; set; }
        public IDerivedPatternFeatureDataObject(IDerivedPatternFeatureData IDerivedPatternFeatureDatainstance)
        {
            IDerivedPatternFeatureDataInstance = IDerivedPatternFeatureDatainstance;
        }
    }
    public static class IDerivedPatternFeatureDataInterface
    {
        public static Boolean AccessSelections(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static void ReleaseSelectionAccess(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance)
        {
            IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetSeedComponentCount(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance)
        {
            return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.GetSeedComponentCount();
        }
        public static Object IGetSeedComponentArray(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance)
        {
            return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.IGetSeedComponentArray();
        }
        //public static void ISetSeedComponentArray(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance, Int32 FeatCount, Object& ArrayDataIn)
        //{
        //    return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.ISetSeedComponentArray(FeatCount, ArrayDataIn);
        //}
        public static Int32 GetSkippedItemCount(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance)
        {
            return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.GetSkippedItemCount();
        }
        public static Int32 IGetSkippedItemArray(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance)
        {
            return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.IGetSkippedItemArray();
        }
        //public static void ISetSkippedItemArray(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance, Int32 FeatCount, Int32& ArrayDataIn)
        //{
        //    return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.ISetSkippedItemArray(FeatCount, ArrayDataIn);
        //}
        //public static Boolean IAccessSelections2(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance, ModelDoc2Object TopDoc, Component2Object Component)
        //{
        //    return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.IAccessSelections2(TopDoc, Component);
        //}
        public static IMathTransformObject GetTransform(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance, Int32 Instance)
        {
            return new IMathTransformObject(IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.GetTransform(Instance));
        }
        public static Object PatternFeature(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance)
        {
            return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.PatternFeature;
        }
        public static Object SeedComponentArray(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance)
        {
            return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.SeedComponentArray;
        }
        public static Object SkippedItemArray(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance)
        {
            return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.SkippedItemArray;
        }
        public static Object DrivingFeatureSkippedItemArray(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance)
        {
            return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.DrivingFeatureSkippedItemArray;
        }
        public static Boolean PropagateVisualProperty(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance)
        {
            return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.PropagateVisualProperty;
        }
        public static Int32 SeedPosition(IDerivedPatternFeatureDataObject IDerivedPatternFeatureDatainstance)
        {
            return IDerivedPatternFeatureDatainstance.IDerivedPatternFeatureDataInstance.SeedPosition;
        }
    }
}