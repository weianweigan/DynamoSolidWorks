using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMateFeatureDataObject
    {
        public IMateFeatureData IMateFeatureDataInstance { get; set; }
        public IMateFeatureDataObject(IMateFeatureData IMateFeatureDatainstance)
        {
            IMateFeatureDataInstance = IMateFeatureDatainstance;
        }
    }
    public static class IMateFeatureDataInterface
    {
        public static Int32 TypeName(IMateFeatureDataObject IMateFeatureDatainstance)
        {
            return IMateFeatureDatainstance.IMateFeatureDataInstance.TypeName;
        }
    }
}