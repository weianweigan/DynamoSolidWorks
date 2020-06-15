using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILinearPatternFeatureDataObject
    {
        public ILinearPatternFeatureData ILinearPatternFeatureDataInstance { get; set; }
        public ILinearPatternFeatureDataObject(ILinearPatternFeatureData ILinearPatternFeatureDatainstance)
        {
            ILinearPatternFeatureDataInstance = ILinearPatternFeatureDatainstance;
        }
    }
    public static class ILinearPatternFeatureDataInterface
    {
        public static Boolean AccessSelections(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static void ReleaseSelectionAccess(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetD1AxisType(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.GetD1AxisType();
        }
        public static Int32 GetD2AxisType(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.GetD2AxisType();
        }
        public static Int32 GetPatternFeatureCount(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.GetPatternFeatureCount();
        }
        public static Object IGetPatternFeatureArray(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.IGetPatternFeatureArray();
        }
        //public static void ISetPatternFeatureArray(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance, Int32 FeatCount, Object& ArrayDataIn)
        //{
        //    return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.ISetPatternFeatureArray(FeatCount, ArrayDataIn);
        //}
        public static Int32 GetSkippedItemCount(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.GetSkippedItemCount();
        }
        public static Int32 IGetSkippedItemArray(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.IGetSkippedItemArray();
        }
        //public static void ISetSkippedItemArray(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance, Int32 FeatCount, Int32& ArrayDataIn)
        //{
        //    return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.ISetSkippedItemArray(FeatCount, ArrayDataIn);
        //}
        //public static Boolean IAccessSelections2(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance, ModelDoc2Object TopDoc, Component2Object Component)
        //{
        //    return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.IAccessSelections2(TopDoc, Component);
        //}
        public static Int32 GetPatternFaceCount(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.GetPatternFaceCount();
        }
        public static Object IGetPatternFaceArray(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.IGetPatternFaceArray();
        }
        //public static void ISetPatternFaceArray(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance, Int32 FaceCount, Object& ArrayDataIn)
        //{
        //    return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.ISetPatternFaceArray(FaceCount, ArrayDataIn);
        //}
        public static Boolean IsDirection2Specified(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.IsDirection2Specified();
        }
        public static Int32 GetPatternBodyCount(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.GetPatternBodyCount();
        }
        public static IBody2Object IGetPatternBodyArray(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return new IBody2Object(ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.IGetPatternBodyArray());
        }
        //public static void ISetPatternBodyArray(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance, Int32 BodyCount, Body2&Object ArrayDataIn)
        //{
        //    return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.ISetPatternBodyArray(BodyCount, ArrayDataIn);
        //}
        public static IMathTransformObject GetTransform(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance, Int32 Instance)
        {
            return new IMathTransformObject(ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.GetTransform(Instance));
        }
        public static Object D1Axis(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.D1Axis;
        }
        public static Object D2Axis(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.D2Axis;
        }
        public static Boolean D1ReverseDirection(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.D1ReverseDirection;
        }
        public static Boolean D2ReverseDirection(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.D2ReverseDirection;
        }
        public static Double D1Spacing(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.D1Spacing;
        }
        public static Double D2Spacing(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.D2Spacing;
        }
        public static Int32 D1TotalInstances(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.D1TotalInstances;
        }
        public static Int32 D2TotalInstances(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.D2TotalInstances;
        }
        public static Boolean VarySketch(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.VarySketch;
        }
        public static Boolean GeometryPattern(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.GeometryPattern;
        }
        public static Object PatternFeatureArray(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.PatternFeatureArray;
        }
        public static Object SkippedItemArray(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.SkippedItemArray;
        }
        public static Object PatternFaceArray(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.PatternFaceArray;
        }
        public static Boolean D2PatternSeedOnly(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.D2PatternSeedOnly;
        }
        public static Object PatternBodyArray(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.PatternBodyArray;
        }
        public static Boolean PropagateVisualProperty(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.PropagateVisualProperty;
        }
        public static Int32 PatternElement(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.PatternElement;
        }
        public static Boolean BodyPattern(ILinearPatternFeatureDataObject ILinearPatternFeatureDatainstance)
        {
            return ILinearPatternFeatureDatainstance.ILinearPatternFeatureDataInstance.BodyPattern;
        }
    }
}