using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IGeneralTableFeatureObject
    {
        public IGeneralTableFeature IGeneralTableFeatureInstance { get; set; }
        public IGeneralTableFeatureObject(IGeneralTableFeature IGeneralTableFeatureinstance)
        {
            IGeneralTableFeatureInstance = IGeneralTableFeatureinstance;
        }
    }
    public static class IGeneralTableFeatureInterface
    {
        public static IFeatureObject GetFeature(IGeneralTableFeatureObject IGeneralTableFeatureinstance)
        {
            return new IFeatureObject(IGeneralTableFeatureinstance.IGeneralTableFeatureInstance.GetFeature());
        }
        public static Int32 GetTableAnnotationCount(IGeneralTableFeatureObject IGeneralTableFeatureinstance)
        {
            return IGeneralTableFeatureinstance.IGeneralTableFeatureInstance.GetTableAnnotationCount();
        }
        public static Object GetTableAnnotations(IGeneralTableFeatureObject IGeneralTableFeatureinstance)
        {
            return IGeneralTableFeatureinstance.IGeneralTableFeatureInstance.GetTableAnnotations();
        }
        public static ITableAnnotationObject IGetTableAnnotations(IGeneralTableFeatureObject IGeneralTableFeatureinstance, Int32 Count)
        {
            return new ITableAnnotationObject(IGeneralTableFeatureinstance.IGeneralTableFeatureInstance.IGetTableAnnotations(Count));
        }
    }
}