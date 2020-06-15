using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILocalSketchPatternFeatureDataObject
    {
        public ILocalSketchPatternFeatureData ILocalSketchPatternFeatureDataInstance { get; set; }
        public ILocalSketchPatternFeatureDataObject(ILocalSketchPatternFeatureData ILocalSketchPatternFeatureDatainstance)
        {
            ILocalSketchPatternFeatureDataInstance = ILocalSketchPatternFeatureDatainstance;
        }
    }
    public static class ILocalSketchPatternFeatureDataInterface
    {
        public static Boolean AccessSelections(ILocalSketchPatternFeatureDataObject ILocalSketchPatternFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ILocalSketchPatternFeatureDatainstance.ILocalSketchPatternFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(ILocalSketchPatternFeatureDataObject ILocalSketchPatternFeatureDatainstance)
        {
            ILocalSketchPatternFeatureDatainstance.ILocalSketchPatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Object GetBasePoint(ILocalSketchPatternFeatureDataObject ILocalSketchPatternFeatureDatainstance)
        {
            return ILocalSketchPatternFeatureDatainstance.ILocalSketchPatternFeatureDataInstance.GetBasePoint();
        }
        public static Int32 GetPatternComponentCount(ILocalSketchPatternFeatureDataObject ILocalSketchPatternFeatureDatainstance)
        {
            return ILocalSketchPatternFeatureDatainstance.ILocalSketchPatternFeatureDataInstance.GetPatternComponentCount();
        }
        public static Int32 GetSkippedItemCount(ILocalSketchPatternFeatureDataObject ILocalSketchPatternFeatureDatainstance)
        {
            return ILocalSketchPatternFeatureDatainstance.ILocalSketchPatternFeatureDataInstance.GetSkippedItemCount();
        }
        public static Int32 GetReferencePointType(ILocalSketchPatternFeatureDataObject ILocalSketchPatternFeatureDatainstance)
        {
            return ILocalSketchPatternFeatureDatainstance.ILocalSketchPatternFeatureDataInstance.GetReferencePointType();
        }
        public static IMathTransformObject GetTransform(ILocalSketchPatternFeatureDataObject ILocalSketchPatternFeatureDatainstance, Int32 Instance)
        {
            return new IMathTransformObject(ILocalSketchPatternFeatureDatainstance.ILocalSketchPatternFeatureDataInstance.GetTransform(Instance));
        }
        public static Object Sketch(ILocalSketchPatternFeatureDataObject ILocalSketchPatternFeatureDatainstance)
        {
            return ILocalSketchPatternFeatureDatainstance.ILocalSketchPatternFeatureDataInstance.Sketch;
        }
        public static Object SkippedItemArray(ILocalSketchPatternFeatureDataObject ILocalSketchPatternFeatureDatainstance)
        {
            return ILocalSketchPatternFeatureDatainstance.ILocalSketchPatternFeatureDataInstance.SkippedItemArray;
        }
        public static Int32 ReferencePoint(ILocalSketchPatternFeatureDataObject ILocalSketchPatternFeatureDatainstance)
        {
            return ILocalSketchPatternFeatureDatainstance.ILocalSketchPatternFeatureDataInstance.ReferencePoint;
        }
        public static Object PatternComponentArray(ILocalSketchPatternFeatureDataObject ILocalSketchPatternFeatureDatainstance)
        {
            return ILocalSketchPatternFeatureDatainstance.ILocalSketchPatternFeatureDataInstance.PatternComponentArray;
        }
        public static ISketchPointObject SelectedPoint(ILocalSketchPatternFeatureDataObject ILocalSketchPatternFeatureDatainstance)
        {
            return new ISketchPointObject(ILocalSketchPatternFeatureDatainstance.ILocalSketchPatternFeatureDataInstance.SelectedPoint);
        }
    }
}