using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBrokenOutSectionFeatureDataObject
    {
        public IBrokenOutSectionFeatureData IBrokenOutSectionFeatureDataInstance { get; set; }
        public IBrokenOutSectionFeatureDataObject(IBrokenOutSectionFeatureData IBrokenOutSectionFeatureDatainstance)
        {
            IBrokenOutSectionFeatureDataInstance = IBrokenOutSectionFeatureDatainstance;
        }
    }
    public static class IBrokenOutSectionFeatureDataInterface
    {
        public static Boolean AccessSelections(IBrokenOutSectionFeatureDataObject IBrokenOutSectionFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IBrokenOutSectionFeatureDatainstance.IBrokenOutSectionFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IBrokenOutSectionFeatureDataObject IBrokenOutSectionFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IBrokenOutSectionFeatureDatainstance.IBrokenOutSectionFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IBrokenOutSectionFeatureDataObject IBrokenOutSectionFeatureDatainstance)
        {
            IBrokenOutSectionFeatureDatainstance.IBrokenOutSectionFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetSketchSegmentCount(IBrokenOutSectionFeatureDataObject IBrokenOutSectionFeatureDatainstance)
        {
            return IBrokenOutSectionFeatureDatainstance.IBrokenOutSectionFeatureDataInstance.GetSketchSegmentCount();
        }
        public static ISketchSegmentObject IGetSketchSegment(IBrokenOutSectionFeatureDataObject IBrokenOutSectionFeatureDatainstance, Int32 Count)
        {
            return new ISketchSegmentObject(IBrokenOutSectionFeatureDatainstance.IBrokenOutSectionFeatureDataInstance.IGetSketchSegment(Count));
        }
        public static Double Depth(IBrokenOutSectionFeatureDataObject IBrokenOutSectionFeatureDatainstance)
        {
            return IBrokenOutSectionFeatureDatainstance.IBrokenOutSectionFeatureDataInstance.Depth;
        }
        public static IEntityObject DepthReference(IBrokenOutSectionFeatureDataObject IBrokenOutSectionFeatureDatainstance)
        {
            return new IEntityObject(IBrokenOutSectionFeatureDatainstance.IBrokenOutSectionFeatureDataInstance.DepthReference);
        }
        public static Boolean EditSketch(IBrokenOutSectionFeatureDataObject IBrokenOutSectionFeatureDatainstance)
        {
            return IBrokenOutSectionFeatureDatainstance.IBrokenOutSectionFeatureDataInstance.EditSketch;
        }
        public static Object SketchSegment(IBrokenOutSectionFeatureDataObject IBrokenOutSectionFeatureDatainstance)
        {
            return IBrokenOutSectionFeatureDatainstance.IBrokenOutSectionFeatureDataInstance.SketchSegment;
        }
    }
}