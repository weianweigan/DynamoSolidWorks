using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IProfileCenterMateFeatureDataObject
    {
        public IProfileCenterMateFeatureData IProfileCenterMateFeatureDataInstance { get; set; }
        public IProfileCenterMateFeatureDataObject(IProfileCenterMateFeatureData IProfileCenterMateFeatureDatainstance)
        {
            IProfileCenterMateFeatureDataInstance = IProfileCenterMateFeatureDatainstance;
        }
    }
    public static class IProfileCenterMateFeatureDataInterface
    {
        public static Object EntitiesToMate(IProfileCenterMateFeatureDataObject IProfileCenterMateFeatureDatainstance)
        {
            return IProfileCenterMateFeatureDatainstance.IProfileCenterMateFeatureDataInstance.EntitiesToMate;
        }
        public static Double OffsetDistance(IProfileCenterMateFeatureDataObject IProfileCenterMateFeatureDatainstance)
        {
            return IProfileCenterMateFeatureDatainstance.IProfileCenterMateFeatureDataInstance.OffsetDistance;
        }
        public static Boolean FlipDimension(IProfileCenterMateFeatureDataObject IProfileCenterMateFeatureDatainstance)
        {
            return IProfileCenterMateFeatureDatainstance.IProfileCenterMateFeatureDataInstance.FlipDimension;
        }
        public static Boolean LockRotation(IProfileCenterMateFeatureDataObject IProfileCenterMateFeatureDatainstance)
        {
            return IProfileCenterMateFeatureDatainstance.IProfileCenterMateFeatureDataInstance.LockRotation;
        }
        public static Int32 MateAlignment(IProfileCenterMateFeatureDataObject IProfileCenterMateFeatureDatainstance)
        {
            return IProfileCenterMateFeatureDatainstance.IProfileCenterMateFeatureDataInstance.MateAlignment;
        }
    }
}