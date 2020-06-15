using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ITitleBlockTableFeatureObject
    {
        public ITitleBlockTableFeature ITitleBlockTableFeatureInstance { get; set; }
        public ITitleBlockTableFeatureObject(ITitleBlockTableFeature ITitleBlockTableFeatureinstance)
        {
            ITitleBlockTableFeatureInstance = ITitleBlockTableFeatureinstance;
        }
    }
    public static class ITitleBlockTableFeatureInterface
    {
        public static IFeatureObject GetFeature(ITitleBlockTableFeatureObject ITitleBlockTableFeatureinstance)
        {
            return new IFeatureObject(ITitleBlockTableFeatureinstance.ITitleBlockTableFeatureInstance.GetFeature());
        }
        public static Int32 GetTableAnnotationCount(ITitleBlockTableFeatureObject ITitleBlockTableFeatureinstance)
        {
            return ITitleBlockTableFeatureinstance.ITitleBlockTableFeatureInstance.GetTableAnnotationCount();
        }
        public static Object GetTableAnnotations(ITitleBlockTableFeatureObject ITitleBlockTableFeatureinstance)
        {
            return ITitleBlockTableFeatureinstance.ITitleBlockTableFeatureInstance.GetTableAnnotations();
        }
        public static ITitleBlockTableAnnotationObject IGetTableAnnotations(ITitleBlockTableFeatureObject ITitleBlockTableFeatureinstance, Int32 Count)
        {
            return new ITitleBlockTableAnnotationObject(ITitleBlockTableFeatureinstance.ITitleBlockTableFeatureInstance.IGetTableAnnotations(Count));
        }
    }
}