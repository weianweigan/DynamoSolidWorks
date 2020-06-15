using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISheetMetalFolderObject
    {
        public ISheetMetalFolder ISheetMetalFolderInstance { get; set; }
        public ISheetMetalFolderObject(ISheetMetalFolder ISheetMetalFolderinstance)
        {
            ISheetMetalFolderInstance = ISheetMetalFolderinstance;
        }
    }
    public static class ISheetMetalFolderInterface
    {
        public static IFeatureObject GetFeature(ISheetMetalFolderObject ISheetMetalFolderinstance)
        {
            return new IFeatureObject(ISheetMetalFolderinstance.ISheetMetalFolderInstance.GetFeature());
        }
        public static Int32 GetSheetMetalCount(ISheetMetalFolderObject ISheetMetalFolderinstance)
        {
            return ISheetMetalFolderinstance.ISheetMetalFolderInstance.GetSheetMetalCount();
        }
        public static Object GetSheetMetals(ISheetMetalFolderObject ISheetMetalFolderinstance)
        {
            return ISheetMetalFolderinstance.ISheetMetalFolderInstance.GetSheetMetals();
        }
    }
}