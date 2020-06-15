using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMirrorSolidFeatureDataObject
    {
        public IMirrorSolidFeatureData IMirrorSolidFeatureDataInstance { get; set; }
        public IMirrorSolidFeatureDataObject(IMirrorSolidFeatureData IMirrorSolidFeatureDatainstance)
        {
            IMirrorSolidFeatureDataInstance = IMirrorSolidFeatureDatainstance;
        }
    }
    public static class IMirrorSolidFeatureDataInterface
    {
        public static Boolean AccessSelections(IMirrorSolidFeatureDataObject IMirrorSolidFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IMirrorSolidFeatureDatainstance.IMirrorSolidFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IMirrorSolidFeatureDataObject IMirrorSolidFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IMirrorSolidFeatureDatainstance.IMirrorSolidFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static void ReleaseSelectionAccess(IMirrorSolidFeatureDataObject IMirrorSolidFeatureDatainstance)
        {
            IMirrorSolidFeatureDatainstance.IMirrorSolidFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Boolean IAccessSelections2(IMirrorSolidFeatureDataObject IMirrorSolidFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IMirrorSolidFeatureDatainstance.IMirrorSolidFeatureDataInstance.IAccessSelections2(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static Int32 GetPatternBodyCount(IMirrorSolidFeatureDataObject IMirrorSolidFeatureDatainstance)
        {
            return IMirrorSolidFeatureDatainstance.IMirrorSolidFeatureDataInstance.GetPatternBodyCount();
        }
        public static IBody2Object IGetPatternBodyArray(IMirrorSolidFeatureDataObject IMirrorSolidFeatureDatainstance)
        {
            return new IBody2Object(IMirrorSolidFeatureDatainstance.IMirrorSolidFeatureDataInstance.IGetPatternBodyArray());
        }
        //public static void ISetPatternBodyArray(IMirrorSolidFeatureDataObject IMirrorSolidFeatureDatainstance, Int32 BodyCount, Body2&Object ArrayDataIn)
        //{
        //    return IMirrorSolidFeatureDatainstance.IMirrorSolidFeatureDataInstance.ISetPatternBodyArray(BodyCount, ArrayDataIn);
        //}
        public static IMathTransformObject GetTransform(IMirrorSolidFeatureDataObject IMirrorSolidFeatureDatainstance)
        {
            return new IMathTransformObject(IMirrorSolidFeatureDatainstance.IMirrorSolidFeatureDataInstance.GetTransform());
        }
        public static Object Face(IMirrorSolidFeatureDataObject IMirrorSolidFeatureDatainstance)
        {
            return IMirrorSolidFeatureDatainstance.IMirrorSolidFeatureDataInstance.Face;
        }
        public static Object PatternBodyArray(IMirrorSolidFeatureDataObject IMirrorSolidFeatureDatainstance)
        {
            return IMirrorSolidFeatureDatainstance.IMirrorSolidFeatureDataInstance.PatternBodyArray;
        }
        public static Boolean Merge(IMirrorSolidFeatureDataObject IMirrorSolidFeatureDatainstance)
        {
            return IMirrorSolidFeatureDatainstance.IMirrorSolidFeatureDataInstance.Merge;
        }
        public static Boolean KnitSurface(IMirrorSolidFeatureDataObject IMirrorSolidFeatureDatainstance)
        {
            return IMirrorSolidFeatureDatainstance.IMirrorSolidFeatureDataInstance.KnitSurface;
        }
        public static Boolean PropagateVisualProperty(IMirrorSolidFeatureDataObject IMirrorSolidFeatureDatainstance)
        {
            return IMirrorSolidFeatureDatainstance.IMirrorSolidFeatureDataInstance.PropagateVisualProperty;
        }
    }
}