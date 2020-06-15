using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILocalCurvePatternFeatureDataObject
    {
        public ILocalCurvePatternFeatureData ILocalCurvePatternFeatureDataInstance { get; set; }
        public ILocalCurvePatternFeatureDataObject(ILocalCurvePatternFeatureData ILocalCurvePatternFeatureDatainstance)
        {
            ILocalCurvePatternFeatureDataInstance = ILocalCurvePatternFeatureDatainstance;
        }
    }
    public static class ILocalCurvePatternFeatureDataInterface
    {
        public static Boolean AccessSelections(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetPatternComponentCount(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.GetPatternComponentCount();
        }
        public static Int32 GetSkippedItemCount(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.GetSkippedItemCount();
        }
        public static IMathTransformObject GetTransform(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance, Int32 Instance)
        {
            return new IMathTransformObject(ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.GetTransform(Instance));
        }
        public static Int32 D1AlignmentMethod(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.D1AlignmentMethod;
        }
        public static Int32 D1CurveMethod(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.D1CurveMethod;
        }
        public static Object D1Direction(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.D1Direction;
        }
        public static Object D2Direction(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.D2Direction;
        }
        public static Int32 D1InstanceCount(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.D1InstanceCount;
        }
        public static Int32 D2InstanceCount(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.D2InstanceCount;
        }
        public static Boolean D1IsEqualSpaced(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.D1IsEqualSpaced;
        }
        public static Boolean D1ReverseDirection(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.D1ReverseDirection;
        }
        public static Double D1Spacing(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.D1Spacing;
        }
        public static Boolean D2IsEqualSpaced(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.D2IsEqualSpaced;
        }
        public static Boolean D2PatternSeedOnly(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.D2PatternSeedOnly;
        }
        public static Boolean D2ReverseDirection(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.D2ReverseDirection;
        }
        public static Double D2Spacing(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.D2Spacing;
        }
        public static Boolean Dir2Specified(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.Dir2Specified;
        }
        public static Object PatternComponentArray(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.PatternComponentArray;
        }
        public static Object SkippedItemArray(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.SkippedItemArray;
        }
        public static Int32 D1ReferencePoint(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.D1ReferencePoint;
        }
        public static Object SelectedPoint(ILocalCurvePatternFeatureDataObject ILocalCurvePatternFeatureDatainstance)
        {
            return ILocalCurvePatternFeatureDatainstance.ILocalCurvePatternFeatureDataInstance.SelectedPoint;
        }
    }
}