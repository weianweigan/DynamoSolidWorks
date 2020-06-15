using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRevisionTableFeatureObject
    {
        public IRevisionTableFeature IRevisionTableFeatureInstance { get; set; }
        public IRevisionTableFeatureObject(IRevisionTableFeature IRevisionTableFeatureinstance)
        {
            IRevisionTableFeatureInstance = IRevisionTableFeatureinstance;
        }
    }
    public static class IRevisionTableFeatureInterface
    {
        public static IFeatureObject GetFeature(IRevisionTableFeatureObject IRevisionTableFeatureinstance)
        {
            return new IFeatureObject(IRevisionTableFeatureinstance.IRevisionTableFeatureInstance.GetFeature());
        }
        public static Int32 GetTableAnnotationCount(IRevisionTableFeatureObject IRevisionTableFeatureinstance)
        {
            return IRevisionTableFeatureinstance.IRevisionTableFeatureInstance.GetTableAnnotationCount();
        }
        public static Object GetTableAnnotations(IRevisionTableFeatureObject IRevisionTableFeatureinstance)
        {
            return IRevisionTableFeatureinstance.IRevisionTableFeatureInstance.GetTableAnnotations();
        }
        public static IRevisionTableAnnotationObject IGetTableAnnotations(IRevisionTableFeatureObject IRevisionTableFeatureinstance, Int32 Count)
        {
            return new IRevisionTableAnnotationObject(IRevisionTableFeatureinstance.IRevisionTableFeatureInstance.IGetTableAnnotations(Count));
        }
    }
}