using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDistanceMateFeatureDataObject
    {
        public IDistanceMateFeatureData IDistanceMateFeatureDataInstance { get; set; }
        public IDistanceMateFeatureDataObject(IDistanceMateFeatureData IDistanceMateFeatureDatainstance)
        {
            IDistanceMateFeatureDataInstance = IDistanceMateFeatureDatainstance;
        }
    }
    public static class IDistanceMateFeatureDataInterface
    {
        public static Object EntitiesToMate(IDistanceMateFeatureDataObject IDistanceMateFeatureDatainstance)
        {
            return IDistanceMateFeatureDatainstance.IDistanceMateFeatureDataInstance.EntitiesToMate;
        }
        public static Double Distance(IDistanceMateFeatureDataObject IDistanceMateFeatureDatainstance)
        {
            return IDistanceMateFeatureDatainstance.IDistanceMateFeatureDataInstance.Distance;
        }
        public static Double MaximumDistance(IDistanceMateFeatureDataObject IDistanceMateFeatureDatainstance)
        {
            return IDistanceMateFeatureDatainstance.IDistanceMateFeatureDataInstance.MaximumDistance;
        }
        public static Double MinimumDistance(IDistanceMateFeatureDataObject IDistanceMateFeatureDatainstance)
        {
            return IDistanceMateFeatureDatainstance.IDistanceMateFeatureDataInstance.MinimumDistance;
        }
        public static Boolean FlipDimension(IDistanceMateFeatureDataObject IDistanceMateFeatureDatainstance)
        {
            return IDistanceMateFeatureDatainstance.IDistanceMateFeatureDataInstance.FlipDimension;
        }
        public static Int32 MateAlignment(IDistanceMateFeatureDataObject IDistanceMateFeatureDatainstance)
        {
            return IDistanceMateFeatureDatainstance.IDistanceMateFeatureDataInstance.MateAlignment;
        }
    }
}