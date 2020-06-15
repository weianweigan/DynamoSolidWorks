using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILocalCircularPatternFeatureDataObject
    {
        public ILocalCircularPatternFeatureData ILocalCircularPatternFeatureDataInstance { get; set; }
        public ILocalCircularPatternFeatureDataObject(ILocalCircularPatternFeatureData ILocalCircularPatternFeatureDatainstance)
        {
            ILocalCircularPatternFeatureDataInstance = ILocalCircularPatternFeatureDatainstance;
        }
    }
    public static class ILocalCircularPatternFeatureDataInterface
    {
        public static Boolean AccessSelections(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static void ReleaseSelectionAccess(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance)
        {
            ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetAxisType(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance)
        {
            return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.GetAxisType();
        }
        public static Int32 GetSeedComponentCount(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance)
        {
            return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.GetSeedComponentCount();
        }
        public static Object IGetSeedComponentArray(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance)
        {
            return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.IGetSeedComponentArray();
        }
        //public static void ISetSeedComponentArray(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance, Int32 FeatCount, Object& ArrayDataIn)
        //{
        //    return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.ISetSeedComponentArray(FeatCount, ArrayDataIn);
        //}
        public static Int32 GetSkippedItemCount(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance)
        {
            return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.GetSkippedItemCount();
        }
        public static Int32 IGetSkippedItemArray(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance)
        {
            return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.IGetSkippedItemArray();
        }
        //public static void ISetSkippedItemArray(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance, Int32 FeatCount, Int32& ArrayDataIn)
        //{
        //    return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.ISetSkippedItemArray(FeatCount, ArrayDataIn);
        //}
        public static Boolean IAccessSelections2(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.IAccessSelections2(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static IMathTransformObject GetTransform(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance, Int32 Instance)
        {
            return new IMathTransformObject(ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.GetTransform(Instance));
        }
        public static Object Axis(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance)
        {
            return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.Axis;
        }
        public static Boolean ReverseDirection(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance)
        {
            return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.ReverseDirection;
        }
        public static Double Spacing(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance)
        {
            return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.Spacing;
        }
        public static Int32 TotalInstances(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance)
        {
            return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.TotalInstances;
        }
        public static Object SeedComponentArray(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance)
        {
            return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.SeedComponentArray;
        }
        public static Object SkippedItemArray(ILocalCircularPatternFeatureDataObject ILocalCircularPatternFeatureDatainstance)
        {
            return ILocalCircularPatternFeatureDatainstance.ILocalCircularPatternFeatureDataInstance.SkippedItemArray;
        }
    }
}