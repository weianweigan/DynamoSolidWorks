using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IGeneralToleranceTableFeatureObject
    {
        public IGeneralToleranceTableFeature IGeneralToleranceTableFeatureInstance { get; set; }
        public IGeneralToleranceTableFeatureObject(IGeneralToleranceTableFeature IGeneralToleranceTableFeatureinstance)
        {
            IGeneralToleranceTableFeatureInstance = IGeneralToleranceTableFeatureinstance;
        }
    }
    public static class IGeneralToleranceTableFeatureInterface
    {
        public static IFeatureObject GetFeature(IGeneralToleranceTableFeatureObject IGeneralToleranceTableFeatureinstance)
        {
            return new IFeatureObject(IGeneralToleranceTableFeatureinstance.IGeneralToleranceTableFeatureInstance.GetFeature());
        }
        public static Object GetTableAnnotations(IGeneralToleranceTableFeatureObject IGeneralToleranceTableFeatureinstance)
        {
            return IGeneralToleranceTableFeatureinstance.IGeneralToleranceTableFeatureInstance.GetTableAnnotations();
        }
    }
}