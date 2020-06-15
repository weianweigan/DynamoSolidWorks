using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMirrorPatternFeatureDataObject
    {
        public IMirrorPatternFeatureData IMirrorPatternFeatureDataInstance { get; set; }
        public IMirrorPatternFeatureDataObject(IMirrorPatternFeatureData IMirrorPatternFeatureDatainstance)
        {
            IMirrorPatternFeatureDataInstance = IMirrorPatternFeatureDatainstance;
        }
    }
    public static class IMirrorPatternFeatureDataInterface
    {
        public static Boolean AccessSelections(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance?.CastObj<ModelDoc>(), Component?.IComponentInstance?.CastObj<Component>());
        }
        public static void ReleaseSelectionAccess(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance)
        {
            IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetMirrorPlaneType(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.GetMirrorPlaneType();
        }
        public static Int32 GetPatternFeatureCount(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.GetPatternFeatureCount();
        }
        public static Object IGetPatternFeatureArray(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.IGetPatternFeatureArray();
        }
        //public static void ISetPatternFeatureArray(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance, Int32 FeatCount, Object& ArrayDataIn)
        //{
        //    return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.ISetPatternFeatureArray(FeatCount, ArrayDataIn);
        //}
        public static Boolean IAccessSelections2(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.IAccessSelections2(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static Int32 GetMirrorFaceCount(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.GetMirrorFaceCount();
        }
        public static Object IGetMirrorFaceArray(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.IGetMirrorFaceArray();
        }
        //public static void ISetMirrorFaceArray(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance, Int32 FaceCount, Object& ArrayDataIn)
        //{
        //    return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.ISetMirrorFaceArray(FaceCount, ArrayDataIn);
        //}
        public static Int32 GetFeatureScopeBodiesCount(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.GetFeatureScopeBodiesCount();
        }
        public static IBody2Object IGetFeatureScopeBodies(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance, Int32 Count)
        {
            return new IBody2Object(IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.IGetFeatureScopeBodies(Count));
        }
        //public static void ISetFeatureScopeBodies(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance, Int32 Count, Body2&Object BodyArr)
        //{
        //    return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.ISetFeatureScopeBodies(Count, BodyArr);
        //}
        public static Object Plane(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.Plane;
        }
        public static Object PatternFeatureArray(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.PatternFeatureArray;
        }
        public static Boolean GeometryPattern(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.GeometryPattern;
        }
        public static Object MirrorFaceArray(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.MirrorFaceArray;
        }
        public static Boolean PropagateVisualProperty(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.PropagateVisualProperty;
        }
        public static Int32 FeatureScope(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.FeatureScope;
        }
        public static Object FeatureScopeBodies(IMirrorPatternFeatureDataObject IMirrorPatternFeatureDatainstance)
        {
            return IMirrorPatternFeatureDatainstance.IMirrorPatternFeatureDataInstance.FeatureScopeBodies;
        }
    }
}