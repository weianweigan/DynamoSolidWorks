using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IChainPatternFeatureDataObject
    {
        public IChainPatternFeatureData IChainPatternFeatureDataInstance { get; set; }
        public IChainPatternFeatureDataObject(IChainPatternFeatureData IChainPatternFeatureDatainstance)
        {
            IChainPatternFeatureDataInstance = IChainPatternFeatureDatainstance;
        }
    }
    public static class IChainPatternFeatureDataInterface
    {
        public static Boolean AccessSelections(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Boolean SetEqualSpacing(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.SetEqualSpacing();
        }
        public static Boolean ClearGroup2Selections(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.ClearGroup2Selections();
        }
        public static Int32 PitchMethod(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.PitchMethod;
        }
        public static Object Path(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.Path;
        }
        public static Object PathPlaneReference(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.PathPlaneReference;
        }
        public static Boolean ReverseDirection(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.ReverseDirection;
        }
        public static Boolean FillPath(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.FillPath;
        }
        public static Int32 InstanceCount(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.InstanceCount;
        }
        public static Object Group1PatternComponent(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.Group1PatternComponent;
        }
        public static Double Spacing(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.Spacing;
        }
        public static Object Group1PathLink1(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.Group1PathLink1;
        }
        public static Object Group1PathLink2(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.Group1PathLink2;
        }
        public static Object Group1PathPlane(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.Group1PathPlane;
        }
        public static Int32 AlignMethod(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.AlignMethod;
        }
        public static Object Group2PatternComponent(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.Group2PatternComponent;
        }
        public static Object Group2PathLink1(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.Group2PathLink1;
        }
        public static Object Group2PathLink2(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.Group2PathLink2;
        }
        public static Object Group2PathPlane(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.Group2PathPlane;
        }
        public static Boolean Group2FlipPlane(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.Group2FlipPlane;
        }
        public static Int32 Options(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.Options;
        }
        public static Boolean Group1FlipPlane(IChainPatternFeatureDataObject IChainPatternFeatureDatainstance)
        {
            return IChainPatternFeatureDatainstance.IChainPatternFeatureDataInstance.Group1FlipPlane;
        }
    }
}