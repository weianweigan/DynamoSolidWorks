using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IWeldmentCutListFeatureObject
    {
        public IWeldmentCutListFeature IWeldmentCutListFeatureInstance { get; set; }
        public IWeldmentCutListFeatureObject(IWeldmentCutListFeature IWeldmentCutListFeatureinstance)
        {
            IWeldmentCutListFeatureInstance = IWeldmentCutListFeatureinstance;
        }
    }
    public static class IWeldmentCutListFeatureInterface
    {
        public static IFeatureObject GetFeature(IWeldmentCutListFeatureObject IWeldmentCutListFeatureinstance)
        {
            return new IFeatureObject(IWeldmentCutListFeatureinstance.IWeldmentCutListFeatureInstance.GetFeature());
        }
        public static Int32 GetTableAnnotationCount(IWeldmentCutListFeatureObject IWeldmentCutListFeatureinstance)
        {
            return IWeldmentCutListFeatureinstance.IWeldmentCutListFeatureInstance.GetTableAnnotationCount();
        }
        public static Object GetTableAnnotations(IWeldmentCutListFeatureObject IWeldmentCutListFeatureinstance)
        {
            return IWeldmentCutListFeatureinstance.IWeldmentCutListFeatureInstance.GetTableAnnotations();
        }
        public static IWeldmentCutListAnnotationObject IGetTableAnnotations(IWeldmentCutListFeatureObject IWeldmentCutListFeatureinstance, Int32 Count)
        {
            return new IWeldmentCutListAnnotationObject(IWeldmentCutListFeatureinstance.IWeldmentCutListFeatureInstance.IGetTableAnnotations(Count));
        }
        public static Boolean KeepMissingItems(IWeldmentCutListFeatureObject IWeldmentCutListFeatureinstance)
        {
            return IWeldmentCutListFeatureinstance.IWeldmentCutListFeatureInstance.KeepMissingItems;
        }
        public static Boolean StrikeoutMissingItems(IWeldmentCutListFeatureObject IWeldmentCutListFeatureinstance)
        {
            return IWeldmentCutListFeatureinstance.IWeldmentCutListFeatureInstance.StrikeoutMissingItems;
        }
        public static Int32 SequenceStartNumber(IWeldmentCutListFeatureObject IWeldmentCutListFeatureinstance)
        {
            return IWeldmentCutListFeatureinstance.IWeldmentCutListFeatureInstance.SequenceStartNumber;
        }
        public static Boolean KeepCurrentItemNumbers(IWeldmentCutListFeatureObject IWeldmentCutListFeatureinstance)
        {
            return IWeldmentCutListFeatureinstance.IWeldmentCutListFeatureInstance.KeepCurrentItemNumbers;
        }
        public static String Configuration(IWeldmentCutListFeatureObject IWeldmentCutListFeatureinstance)
        {
            return IWeldmentCutListFeatureinstance.IWeldmentCutListFeatureInstance.Configuration;
        }
    }
}