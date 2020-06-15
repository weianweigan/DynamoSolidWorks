using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICurveDrivenPatternFeatureDataObject
    {
        public ICurveDrivenPatternFeatureData ICurveDrivenPatternFeatureDataInstance { get; set; }
        public ICurveDrivenPatternFeatureDataObject(ICurveDrivenPatternFeatureData ICurveDrivenPatternFeatureDatainstance)
        {
            ICurveDrivenPatternFeatureDataInstance = ICurveDrivenPatternFeatureDatainstance;
        }
    }
    public static class ICurveDrivenPatternFeatureDataInterface
    {
        public static Boolean AccessSelections(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetSkippedItemCount(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.GetSkippedItemCount();
        }
        public static Int32 IGetSkippedItemArray(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.IGetSkippedItemArray();
        }
        //public static void ISetSkippedItemArray(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance, Int32 FeatCount, Int32& ArrayDataIn)
        //{
        //    return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.ISetSkippedItemArray(FeatCount, ArrayDataIn);
        //}
        public static Int32 GetPatternFeatureCount(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.GetPatternFeatureCount();
        }
        public static Object IGetPatternFeatureArray(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.IGetPatternFeatureArray();
        }
        //public static void ISetPatternFeatureArray(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance, Int32 FeatCount, Object& ArrayDataIn)
        //{
        //    return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.ISetPatternFeatureArray(FeatCount, ArrayDataIn);
        //}
        public static Int32 GetPatternFaceCount(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.GetPatternFaceCount();
        }
        public static Object IGetPatternFaceArray(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.IGetPatternFaceArray();
        }
        //public static void ISetPatternFaceArray(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance, Int32 FaceCount, Object& ArrayDataIn)
        //{
        //    return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.ISetPatternFaceArray(FaceCount, ArrayDataIn);
        //}
        public static Int32 GetPatternBodyCount(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.GetPatternBodyCount();
        }
        public static IBody2Object IGetPatternBodyArray(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return new IBody2Object(ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.IGetPatternBodyArray());
        }
        //public static void ISetPatternBodyArray(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance, Int32 BodyCount, Body2&Object ArrayDataIn)
        //{
        //    return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.ISetPatternBodyArray(BodyCount, ArrayDataIn);
        //}
        public static IMathTransformObject GetTransform(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance, Int32 Instance)
        {
            return new IMathTransformObject(ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.GetTransform(Instance));
        }
        public static Object D1Direction(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.D1Direction;
        }
        public static Object D2Direction(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.D2Direction;
        }
        public static Boolean D1ReverseDirection(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.D1ReverseDirection;
        }
        public static Boolean D2ReverseDirection(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.D2ReverseDirection;
        }
        public static Int32 D1InstanceCount(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.D1InstanceCount;
        }
        public static Int32 D2InstanceCount(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.D2InstanceCount;
        }
        public static Boolean D1IsEqualSpaced(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.D1IsEqualSpaced;
        }
        public static Boolean D2IsEqualSpaced(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.D2IsEqualSpaced;
        }
        public static Double D1Spacing(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.D1Spacing;
        }
        public static Double D2Spacing(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.D2Spacing;
        }
        public static Boolean Dir2Specified(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.Dir2Specified;
        }
        public static Boolean D2PatternSeedOnly(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.D2PatternSeedOnly;
        }
        public static Int32 D1CurveMethod(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.D1CurveMethod;
        }
        public static Int32 D1AlignmentMethod(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.D1AlignmentMethod;
        }
        public static Object SkippedItemArray(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.SkippedItemArray;
        }
        public static Object PatternFeatureArray(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.PatternFeatureArray;
        }
        public static Boolean GeometryPattern(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.GeometryPattern;
        }
        public static Boolean VarySketch(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.VarySketch;
        }
        public static Object PatternFaceArray(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.PatternFaceArray;
        }
        public static Object PatternBodyArray(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.PatternBodyArray;
        }
        public static Boolean PropagateVisualProperty(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.PropagateVisualProperty;
        }
        public static Int32 PatternElement(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.PatternElement;
        }
        public static Boolean BodyPattern(ICurveDrivenPatternFeatureDataObject ICurveDrivenPatternFeatureDatainstance)
        {
            return ICurveDrivenPatternFeatureDatainstance.ICurveDrivenPatternFeatureDataInstance.BodyPattern;
        }
    }
}