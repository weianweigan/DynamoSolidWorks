using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICircularPatternFeatureDataObject
    {
        public ICircularPatternFeatureData ICircularPatternFeatureDataInstance { get; set; }
        public ICircularPatternFeatureDataObject(ICircularPatternFeatureData ICircularPatternFeatureDatainstance)
        {
            ICircularPatternFeatureDataInstance = ICircularPatternFeatureDatainstance;
        }
    }
    public static class ICircularPatternFeatureDataInterface
    {
        public static Boolean AccessSelections(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static void ReleaseSelectionAccess(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetAxisType(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.GetAxisType();
        }
        public static Int32 GetPatternFeatureCount(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.GetPatternFeatureCount();
        }
        public static Object IGetPatternFeatureArray(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.IGetPatternFeatureArray();
        }
        //ref not solve
        public static void ISetPatternFeatureArray(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance, Int32 FeatCount, Object ArrayDataIn)
        {
            ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.ISetPatternFeatureArray(FeatCount, ArrayDataIn);
        }
        public static Int32 GetSkippedItemCount(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.GetSkippedItemCount();
        }
        public static Int32 IGetSkippedItemArray(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.IGetSkippedItemArray();
        }
        //ref not solve
        public static void ISetSkippedItemArray(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance, Int32 FeatCount, Int32 ArrayDataIn)
        {
            ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.ISetSkippedItemArray(FeatCount, ArrayDataIn);
        }
        public static Boolean IAccessSelections2(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.IAccessSelections2(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static Int32 GetPatternFaceCount(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.GetPatternFaceCount();
        }
        public static Object IGetPatternFaceArray(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.IGetPatternFaceArray();
        }
        //ref not solve
        public static void ISetPatternFaceArray(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance, Int32 FaceCount, Object ArrayDataIn)
        {
            ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.ISetPatternFaceArray(FaceCount, ArrayDataIn);
        }
        public static Int32 GetPatternBodyCount(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.GetPatternBodyCount();
        }
        public static IBody2Object IGetPatternBodyArray(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return new IBody2Object(ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.IGetPatternBodyArray());
        }

        //ref not sovle
        public static void ISetPatternBodyArray(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance, Int32 BodyCount, IBody2Object ArrayDataIn)
        {
            ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.ISetPatternBodyArray(BodyCount, ArrayDataIn.IBody2Instance as Body2);
        }
        public static IMathTransformObject GetTransform(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance, Int32 Instance)
        {
            return new IMathTransformObject(ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.GetTransform(Instance));
        }
        public static Object Axis(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.Axis;
        }
        public static Boolean ReverseDirection(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.ReverseDirection;
        }
        public static Double Spacing(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.Spacing;
        }
        public static Int32 TotalInstances(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.TotalInstances;
        }
        public static Boolean EqualSpacing(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.EqualSpacing;
        }
        public static Boolean VarySketch(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.VarySketch;
        }
        public static Boolean GeometryPattern(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.GeometryPattern;
        }
        public static Object PatternFeatureArray(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.PatternFeatureArray;
        }
        public static Object SkippedItemArray(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.SkippedItemArray;
        }
        public static Object PatternFaceArray(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.PatternFaceArray;
        }
        public static Object PatternBodyArray(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.PatternBodyArray;
        }
        public static Boolean PropagateVisualProperty(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.PropagateVisualProperty;
        }
        public static Int32 PatternElement(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.PatternElement;
        }
        public static Boolean BodyPattern(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.BodyPattern;
        }
        public static Boolean Direction2(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.Direction2;
        }
        public static Boolean Symmetric(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.Symmetric;
        }
        public static Boolean EqualSpacing2(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.EqualSpacing2;
        }
        public static Double Spacing2(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.Spacing2;
        }
        public static Int32 TotalInstances2(ICircularPatternFeatureDataObject ICircularPatternFeatureDatainstance)
        {
            return ICircularPatternFeatureDatainstance.ICircularPatternFeatureDataInstance.TotalInstances2;
        }
    }
}