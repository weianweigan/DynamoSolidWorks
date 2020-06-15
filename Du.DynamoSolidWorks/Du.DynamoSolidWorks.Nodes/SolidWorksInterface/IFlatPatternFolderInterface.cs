using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFlatPatternFolderObject
    {
        public IFlatPatternFolder IFlatPatternFolderInstance { get; set; }
        public IFlatPatternFolderObject(IFlatPatternFolder IFlatPatternFolderinstance)
        {
            IFlatPatternFolderInstance = IFlatPatternFolderinstance;
        }
    }
    public static class IFlatPatternFolderInterface
    {
        public static IFeatureObject GetFeature(IFlatPatternFolderObject IFlatPatternFolderinstance)
        {
            return new IFeatureObject(IFlatPatternFolderinstance.IFlatPatternFolderInstance.GetFeature());
        }
        public static Int32 GetFlatPatternCount(IFlatPatternFolderObject IFlatPatternFolderinstance)
        {
            return IFlatPatternFolderinstance.IFlatPatternFolderInstance.GetFlatPatternCount();
        }
        public static Object GetFlatPatterns(IFlatPatternFolderObject IFlatPatternFolderinstance)
        {
            return IFlatPatternFolderinstance.IFlatPatternFolderInstance.GetFlatPatterns();
        }
    }
}