using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFeatureFolderObject
    {
        public IFeatureFolder IFeatureFolderInstance { get; set; }
        public IFeatureFolderObject(IFeatureFolder IFeatureFolderinstance)
        {
            IFeatureFolderInstance = IFeatureFolderinstance;
        }
    }
    public static class IFeatureFolderInterface
    {
        public static Int32 GetFeatureCount(IFeatureFolderObject IFeatureFolderinstance)
        {
            return IFeatureFolderinstance.IFeatureFolderInstance.GetFeatureCount();
        }
        public static Object GetFeatures(IFeatureFolderObject IFeatureFolderinstance)
        {
            return IFeatureFolderinstance.IFeatureFolderInstance.GetFeatures();
        }
        public static IFeatureObject IGetFeatures(IFeatureFolderObject IFeatureFolderinstance, Int32 NumOfFeatures)
        {
            return new IFeatureObject(IFeatureFolderinstance.IFeatureFolderInstance.IGetFeatures(NumOfFeatures));
        }
    }
}