using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IAdvancedHoleFeatureDataObject
    {
        public IAdvancedHoleFeatureData IAdvancedHoleFeatureDataInstance { get; set; }
        public IAdvancedHoleFeatureDataObject(IAdvancedHoleFeatureData IAdvancedHoleFeatureDatainstance)
        {
            IAdvancedHoleFeatureDataInstance = IAdvancedHoleFeatureDatainstance;
        }
    }
    public static class IAdvancedHoleFeatureDataInterface
    {
        public static Boolean AccessSelections(IAdvancedHoleFeatureDataObject IAdvancedHoleFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IAdvancedHoleFeatureDatainstance.IAdvancedHoleFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(IAdvancedHoleFeatureDataObject IAdvancedHoleFeatureDatainstance)
        {
            IAdvancedHoleFeatureDatainstance.IAdvancedHoleFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Object GetNearSideElements(IAdvancedHoleFeatureDataObject IAdvancedHoleFeatureDatainstance)
        {
            return IAdvancedHoleFeatureDatainstance.IAdvancedHoleFeatureDataInstance.GetNearSideElements();
        }
        public static Object GetFarSideElements(IAdvancedHoleFeatureDataObject IAdvancedHoleFeatureDatainstance)
        {
            return IAdvancedHoleFeatureDatainstance.IAdvancedHoleFeatureDataInstance.GetFarSideElements();
        }
        public static void SetNearSideElements(IAdvancedHoleFeatureDataObject IAdvancedHoleFeatureDatainstance, Object ElmArray)
        {
            IAdvancedHoleFeatureDatainstance.IAdvancedHoleFeatureDataInstance.SetNearSideElements(ElmArray);
        }
        public static void SetFarSideElements(IAdvancedHoleFeatureDataObject IAdvancedHoleFeatureDatainstance, Object ElmArray)
        {
            IAdvancedHoleFeatureDatainstance.IAdvancedHoleFeatureDataInstance.SetFarSideElements(ElmArray);
        }
        public static Int32 NearSideElementsCount(IAdvancedHoleFeatureDataObject IAdvancedHoleFeatureDatainstance)
        {
            return IAdvancedHoleFeatureDatainstance.IAdvancedHoleFeatureDataInstance.NearSideElementsCount;
        }
        public static Int32 FarSideElementsCount(IAdvancedHoleFeatureDataObject IAdvancedHoleFeatureDatainstance)
        {
            return IAdvancedHoleFeatureDatainstance.IAdvancedHoleFeatureDataInstance.FarSideElementsCount;
        }
        public static Boolean CustomizeCallout(IAdvancedHoleFeatureDataObject IAdvancedHoleFeatureDatainstance)
        {
            return IAdvancedHoleFeatureDatainstance.IAdvancedHoleFeatureDataInstance.CustomizeCallout;
        }
        public static Boolean UseBaselineDimensions(IAdvancedHoleFeatureDataObject IAdvancedHoleFeatureDatainstance)
        {
            return IAdvancedHoleFeatureDatainstance.IAdvancedHoleFeatureDataInstance.UseBaselineDimensions;
        }
    }
}