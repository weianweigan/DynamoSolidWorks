using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IProjectionCurveFeatureDataObject
    {
        public IProjectionCurveFeatureData IProjectionCurveFeatureDataInstance { get; set; }
        public IProjectionCurveFeatureDataObject(IProjectionCurveFeatureData IProjectionCurveFeatureDatainstance)
        {
            IProjectionCurveFeatureDataInstance = IProjectionCurveFeatureDatainstance;
        }
    }
    public static class IProjectionCurveFeatureDataInterface
    {
        public static Boolean AccessSelections(IProjectionCurveFeatureDataObject IProjectionCurveFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IProjectionCurveFeatureDatainstance.IProjectionCurveFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IProjectionCurveFeatureDataObject IProjectionCurveFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IProjectionCurveFeatureDatainstance.IProjectionCurveFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance?.CastObj<ModelDoc>(), Component?.IComponentInstance?.CastObj<Component>());
        }
        public static void ReleaseSelectionAccess(IProjectionCurveFeatureDataObject IProjectionCurveFeatureDatainstance)
        {
            IProjectionCurveFeatureDatainstance.IProjectionCurveFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetFaceArrayCount(IProjectionCurveFeatureDataObject IProjectionCurveFeatureDatainstance)
        {
            return IProjectionCurveFeatureDatainstance.IProjectionCurveFeatureDataInstance.GetFaceArrayCount();
        }
        public static Object IGetFaceArray(IProjectionCurveFeatureDataObject IProjectionCurveFeatureDatainstance, Int32 FaceCount)
        {
            return IProjectionCurveFeatureDatainstance.IProjectionCurveFeatureDataInstance.IGetFaceArray(FaceCount);
        }
        //public static void ISetFaceArray(IProjectionCurveFeatureDataObject IProjectionCurveFeatureDatainstance, Int32 FaceCount, Object& ArrayDataIn)
        //{
        //    return IProjectionCurveFeatureDatainstance.IProjectionCurveFeatureDataInstance.ISetFaceArray(FaceCount, ArrayDataIn);
        //}
        public static Boolean IAccessSelections2(IProjectionCurveFeatureDataObject IProjectionCurveFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IProjectionCurveFeatureDatainstance.IProjectionCurveFeatureDataInstance.IAccessSelections2(TopDoc?.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static Boolean Reverse(IProjectionCurveFeatureDataObject IProjectionCurveFeatureDatainstance)
        {
            return IProjectionCurveFeatureDatainstance.IProjectionCurveFeatureDataInstance.Reverse;
        }
        public static Object FaceArray(IProjectionCurveFeatureDataObject IProjectionCurveFeatureDatainstance)
        {
            return IProjectionCurveFeatureDatainstance.IProjectionCurveFeatureDataInstance.FaceArray;
        }
        public static Object Sketch(IProjectionCurveFeatureDataObject IProjectionCurveFeatureDatainstance)
        {
            return IProjectionCurveFeatureDatainstance.IProjectionCurveFeatureDataInstance.Sketch;
        }
    }
}