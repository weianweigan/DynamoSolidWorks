using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ITablePatternFeatureDataObject
    {
        public ITablePatternFeatureData ITablePatternFeatureDataInstance { get; set; }
        public ITablePatternFeatureDataObject(ITablePatternFeatureData ITablePatternFeatureDatainstance)
        {
            ITablePatternFeatureDataInstance = ITablePatternFeatureDatainstance;
        }
    }
    public static class ITablePatternFeatureDataInterface
    {
        public static Boolean AccessSelections(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance?.CastObj<ModelDoc>(), Component?.IComponentInstance?.CastObj<Component>());
        }
        public static void ReleaseSelectionAccess(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetReferencePointType(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.GetReferencePointType();
        }
        public static Boolean SavePointsToFile(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance, String FileName)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.SavePointsToFile(FileName);
        }
        public static Boolean LoadPointsFromFile(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance, String FileName)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.LoadPointsFromFile(FileName);
        }
        public static Object GetBasePoint(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.GetBasePoint();
        }
        public static Double IGetBasePoint(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.IGetBasePoint();
        }
        public static Int32 GetPatternFeatureCount(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.GetPatternFeatureCount();
        }
        public static Object IGetPatternFeatureArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.IGetPatternFeatureArray();
        }
        //public static void ISetPatternFeatureArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance, Int32 FeatCount, Object& ArrayDataIn)
        //{
        //    return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.ISetPatternFeatureArray(FeatCount, ArrayDataIn);
        //}
        public static Int32 GetPointCount(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.GetPointCount();
        }
        public static Double IGetPointArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.IGetPointArray();
        }
        //public static void ISetPointArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance, Int32 FeatCount, Double& ArrayDataIn)
        //{
        //    return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.ISetPointArray(FeatCount, ArrayDataIn);
        //}
        //public static Boolean IAccessSelections2(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance, ModelDoc2Object TopDoc, Component2Object Component)
        //{
        //    return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.IAccessSelections2(TopDoc, Component);
        //}
        public static Int32 GetPatternFaceCount(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.GetPatternFaceCount();
        }
        public static Object IGetPatternFaceArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.IGetPatternFaceArray();
        }
        //public static void ISetPatternFaceArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance, Int32 FaceCount, Object& ArrayDataIn)
        //{
        //    return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.ISetPatternFaceArray(FaceCount, ArrayDataIn);
        //}
        public static Int32 GetPatternBodyCount(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.GetPatternBodyCount();
        }
        public static IBody2Object IGetPatternBodyArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return new IBody2Object(ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.IGetPatternBodyArray());
        }
        //public static void ISetPatternBodyArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance, Int32 BodyCount, Body2&Object ArrayDataIn)
        //{
        //    return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.ISetPatternBodyArray(BodyCount, ArrayDataIn);
        //}
        public static Int32 GetSkippedItemCount(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.GetSkippedItemCount();
        }
        public static Int32 IGetSkippedItemArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance, Int32 Count)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.IGetSkippedItemArray(Count);
        }
        //public static void ISetSkippedItemArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance, Int32 Count, Int32& ArrayDataIn)
        //{
        //    return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.ISetSkippedItemArray(Count, ArrayDataIn);
        //}
        public static IMathTransformObject GetTransform(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance, Int32 Instance)
        {
            return new IMathTransformObject(ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.GetTransform(Instance));
        }
        public static Object CoordinateSystem(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.CoordinateSystem;
        }
        public static Object ReferencePoint(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.ReferencePoint;
        }
        public static Boolean UseCentroid(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.UseCentroid;
        }
        public static Boolean GeometryPattern(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.GeometryPattern;
        }
        public static Object PatternFeatureArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.PatternFeatureArray;
        }
        public static Object PointArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.PointArray;
        }
        public static Object PatternFaceArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.PatternFaceArray;
        }
        public static Object PatternBodyArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.PatternBodyArray;
        }
        public static Object SkippedItemArray(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.SkippedItemArray;
        }
        public static Boolean PropagateVisualProperty(ITablePatternFeatureDataObject ITablePatternFeatureDatainstance)
        {
            return ITablePatternFeatureDatainstance.ITablePatternFeatureDataInstance.PropagateVisualProperty;
        }
    }
}