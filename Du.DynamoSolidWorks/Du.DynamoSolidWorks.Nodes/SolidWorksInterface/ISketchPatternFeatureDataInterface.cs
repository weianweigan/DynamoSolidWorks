using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchPatternFeatureDataObject
    {
        public ISketchPatternFeatureData ISketchPatternFeatureDataInstance { get; set; }
        public ISketchPatternFeatureDataObject(ISketchPatternFeatureData ISketchPatternFeatureDatainstance)
        {
            ISketchPatternFeatureDataInstance = ISketchPatternFeatureDatainstance;
        }
    }
    public static class ISketchPatternFeatureDataInterface
    {
        public static Boolean AccessSelections(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance?.CastObj<ModelDoc>(), Component?.IComponentInstance?.CastObj<Component>());
        }
        public static void ReleaseSelectionAccess(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetReferencePointType(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.GetReferencePointType();
        }
        public static Object GetBasePoint(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.GetBasePoint();
        }
        public static Double IGetBasePoint(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.IGetBasePoint();
        }
        public static Int32 GetPatternFeatureCount(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.GetPatternFeatureCount();
        }
        public static Object IGetPatternFeatureArray(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.IGetPatternFeatureArray();
        }
        //public static void ISetPatternFeatureArray(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance, Int32 FeatCount, Object& ArrayDataIn)
        //{
        //    return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.ISetPatternFeatureArray(FeatCount, ArrayDataIn);
        //}
        public static Boolean IAccessSelections2(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.IAccessSelections2(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static Int32 GetPatternFaceCount(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.GetPatternFaceCount();
        }
        public static Object IGetPatternFaceArray(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.IGetPatternFaceArray();
        }
        //public static void ISetPatternFaceArray(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance, Int32 FaceCount, Object& ArrayDataIn)
        //{
        //    return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.ISetPatternFaceArray(FaceCount, ArrayDataIn);
        //}
        public static Int32 GetPatternBodyCount(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.GetPatternBodyCount();
        }
        public static IBody2Object IGetPatternBodyArray(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return new IBody2Object(ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.IGetPatternBodyArray());
        }
        //public static void ISetPatternBodyArray(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance, Int32 BodyCount, Body2&Object ArrayDataIn)
        //{
        //    return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.ISetPatternBodyArray(BodyCount, ArrayDataIn);
        //}
        public static IMathTransformObject GetTransform(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance, Int32 Instance)
        {
            return new IMathTransformObject(ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.GetTransform(Instance));
        }
        public static Object Sketch(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.Sketch;
        }
        public static Object ReferencePoint(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.ReferencePoint;
        }
        public static Boolean UseCentroid(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.UseCentroid;
        }
        public static Boolean GeometryPattern(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.GeometryPattern;
        }
        public static Object PatternFeatureArray(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.PatternFeatureArray;
        }
        public static Object PatternFaceArray(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.PatternFaceArray;
        }
        public static Object PatternBodyArray(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.PatternBodyArray;
        }
        public static Boolean PropagateVisualProperty(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.PropagateVisualProperty;
        }
        public static Int32 PatternElement(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.PatternElement;
        }
        public static Boolean BodyPattern(ISketchPatternFeatureDataObject ISketchPatternFeatureDatainstance)
        {
            return ISketchPatternFeatureDatainstance.ISketchPatternFeatureDataInstance.BodyPattern;
        }
    }
}