using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILocalLinearPatternFeatureDataObject
    {
        public ILocalLinearPatternFeatureData ILocalLinearPatternFeatureDataInstance { get; set; }
        public ILocalLinearPatternFeatureDataObject(ILocalLinearPatternFeatureData ILocalLinearPatternFeatureDatainstance)
        {
            ILocalLinearPatternFeatureDataInstance = ILocalLinearPatternFeatureDatainstance;
        }
    }
    public static class ILocalLinearPatternFeatureDataInterface
    {
        public static Boolean AccessSelections(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static void ReleaseSelectionAccess(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetD1AxisType(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.GetD1AxisType();
        }
        public static Int32 GetD2AxisType(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.GetD2AxisType();
        }
        public static Int32 GetSeedComponentCount(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.GetSeedComponentCount();
        }
        public static Object IGetSeedComponentArray(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.IGetSeedComponentArray();
        }
        //public static void ISetSeedComponentArray(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance, Int32 FeatCount, Object& ArrayDataIn)
        //{
        //    return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.ISetSeedComponentArray(FeatCount, ArrayDataIn);
        //}
        public static Int32 GetSkippedItemCount(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.GetSkippedItemCount();
        }
        public static Int32 IGetSkippedItemArray(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.IGetSkippedItemArray();
        }
        //public static void ISetSkippedItemArray(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance, Int32 FeatCount, Int32& ArrayDataIn)
        //{
        //    return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.ISetSkippedItemArray(FeatCount, ArrayDataIn);
        //}
        public static Boolean IAccessSelections2(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.IAccessSelections2(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static IMathTransformObject GetTransform(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance, Int32 Instance)
        {
            return new IMathTransformObject(ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.GetTransform(Instance));
        }
        public static Object D1Axis(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.D1Axis;
        }
        public static Object D2Axis(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.D2Axis;
        }
        public static Boolean D1ReverseDirection(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.D1ReverseDirection;
        }
        public static Boolean D2ReverseDirection(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.D2ReverseDirection;
        }
        public static Double D1Spacing(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.D1Spacing;
        }
        public static Double D2Spacing(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.D2Spacing;
        }
        public static Int32 D1TotalInstances(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.D1TotalInstances;
        }
        public static Int32 D2TotalInstances(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.D2TotalInstances;
        }
        public static Object SeedComponentArray(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.SeedComponentArray;
        }
        public static Object SkippedItemArray(ILocalLinearPatternFeatureDataObject ILocalLinearPatternFeatureDatainstance)
        {
            return ILocalLinearPatternFeatureDatainstance.ILocalLinearPatternFeatureDataInstance.SkippedItemArray;
        }
    }
}