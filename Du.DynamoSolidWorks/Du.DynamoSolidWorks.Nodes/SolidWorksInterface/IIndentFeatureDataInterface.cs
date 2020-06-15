using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IIndentFeatureDataObject
    {
        public IIndentFeatureData IIndentFeatureDataInstance { get; set; }
        public IIndentFeatureDataObject(IIndentFeatureData IIndentFeatureDatainstance)
        {
            IIndentFeatureDataInstance = IIndentFeatureDatainstance;
        }
    }
    public static class IIndentFeatureDataInterface
    {
        public static Boolean AccessSelections(IIndentFeatureDataObject IIndentFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IIndentFeatureDatainstance.IIndentFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(IIndentFeatureDataObject IIndentFeatureDatainstance)
        {
            IIndentFeatureDatainstance.IIndentFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetBodiesCount(IIndentFeatureDataObject IIndentFeatureDatainstance)
        {
            return IIndentFeatureDatainstance.IIndentFeatureDataInstance.GetBodiesCount();
        }
        public static Object TargetBody(IIndentFeatureDataObject IIndentFeatureDatainstance)
        {
            return IIndentFeatureDatainstance.IIndentFeatureDataInstance.TargetBody;
        }
        public static Int32 SelectionState(IIndentFeatureDataObject IIndentFeatureDatainstance)
        {
            return IIndentFeatureDatainstance.IIndentFeatureDataInstance.SelectionState;
        }
        public static Boolean IsCut(IIndentFeatureDataObject IIndentFeatureDatainstance)
        {
            return IIndentFeatureDatainstance.IIndentFeatureDataInstance.IsCut;
        }
        public static Double Thickness(IIndentFeatureDataObject IIndentFeatureDatainstance)
        {
            return IIndentFeatureDatainstance.IIndentFeatureDataInstance.Thickness;
        }
        public static Double Clearance(IIndentFeatureDataObject IIndentFeatureDatainstance)
        {
            return IIndentFeatureDatainstance.IIndentFeatureDataInstance.Clearance;
        }
        public static Boolean ClearanceDirection(IIndentFeatureDataObject IIndentFeatureDatainstance)
        {
            return IIndentFeatureDatainstance.IIndentFeatureDataInstance.ClearanceDirection;
        }
        public static Object ToolBodyRegion(IIndentFeatureDataObject IIndentFeatureDatainstance)
        {
            return IIndentFeatureDatainstance.IIndentFeatureDataInstance.ToolBodyRegion;
        }
        public static Boolean CutDirection(IIndentFeatureDataObject IIndentFeatureDatainstance)
        {
            return IIndentFeatureDatainstance.IIndentFeatureDataInstance.CutDirection;
        }
    }
}