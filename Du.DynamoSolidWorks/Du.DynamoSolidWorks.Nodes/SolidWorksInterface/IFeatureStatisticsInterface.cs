using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFeatureStatisticsObject
    {
        public IFeatureStatistics IFeatureStatisticsInstance { get; set; }
        public IFeatureStatisticsObject(IFeatureStatistics IFeatureStatisticsinstance)
        {
            IFeatureStatisticsInstance = IFeatureStatisticsinstance;
        }
    }
    public static class IFeatureStatisticsInterface
    {
        public static Boolean Refresh(IFeatureStatisticsObject IFeatureStatisticsinstance)
        {
            return IFeatureStatisticsinstance.IFeatureStatisticsInstance.Refresh();
        }
        public static String PartName(IFeatureStatisticsObject IFeatureStatisticsinstance)
        {
            return IFeatureStatisticsinstance.IFeatureStatisticsInstance.PartName;
        }
        public static Int32 FeatureCount(IFeatureStatisticsObject IFeatureStatisticsinstance)
        {
            return IFeatureStatisticsinstance.IFeatureStatisticsInstance.FeatureCount;
        }
        public static Int32 SolidBodiesCount(IFeatureStatisticsObject IFeatureStatisticsinstance)
        {
            return IFeatureStatisticsinstance.IFeatureStatisticsInstance.SolidBodiesCount;
        }
        public static Int32 SurfaceBodiesCount(IFeatureStatisticsObject IFeatureStatisticsinstance)
        {
            return IFeatureStatisticsinstance.IFeatureStatisticsInstance.SurfaceBodiesCount;
        }
        public static Double TotalRebuildTime(IFeatureStatisticsObject IFeatureStatisticsinstance)
        {
            return IFeatureStatisticsinstance.IFeatureStatisticsInstance.TotalRebuildTime;
        }
        public static Object FeatureNames(IFeatureStatisticsObject IFeatureStatisticsinstance)
        {
            return IFeatureStatisticsinstance.IFeatureStatisticsInstance.FeatureNames;
        }
        public static Object FeatureTypes(IFeatureStatisticsObject IFeatureStatisticsinstance)
        {
            return IFeatureStatisticsinstance.IFeatureStatisticsInstance.FeatureTypes;
        }
        public static Object Features(IFeatureStatisticsObject IFeatureStatisticsinstance)
        {
            return IFeatureStatisticsinstance.IFeatureStatisticsInstance.Features;
        }
        public static Object FeatureUpdateTimes(IFeatureStatisticsObject IFeatureStatisticsinstance)
        {
            return IFeatureStatisticsinstance.IFeatureStatisticsInstance.FeatureUpdateTimes;
        }
        public static Object FeatureUpdatePercentageTimes(IFeatureStatisticsObject IFeatureStatisticsinstance)
        {
            return IFeatureStatisticsinstance.IFeatureStatisticsInstance.FeatureUpdatePercentageTimes;
        }
    }
}