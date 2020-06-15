using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISurfaceParameterizationDataObject
    {
        public ISurfaceParameterizationData ISurfaceParameterizationDataInstance { get; set; }
        public ISurfaceParameterizationDataObject(ISurfaceParameterizationData ISurfaceParameterizationDatainstance)
        {
            ISurfaceParameterizationDataInstance = ISurfaceParameterizationDatainstance;
        }
    }
    public static class ISurfaceParameterizationDataInterface
    {
        public static Double UMin(ISurfaceParameterizationDataObject ISurfaceParameterizationDatainstance)
        {
            return ISurfaceParameterizationDatainstance.ISurfaceParameterizationDataInstance.UMin;
        }
        public static Double UMax(ISurfaceParameterizationDataObject ISurfaceParameterizationDatainstance)
        {
            return ISurfaceParameterizationDatainstance.ISurfaceParameterizationDataInstance.UMax;
        }
        public static Double VMin(ISurfaceParameterizationDataObject ISurfaceParameterizationDatainstance)
        {
            return ISurfaceParameterizationDatainstance.ISurfaceParameterizationDataInstance.VMin;
        }
        public static Double VMax(ISurfaceParameterizationDataObject ISurfaceParameterizationDatainstance)
        {
            return ISurfaceParameterizationDatainstance.ISurfaceParameterizationDataInstance.VMax;
        }
        public static Int32 UMinBoundType(ISurfaceParameterizationDataObject ISurfaceParameterizationDatainstance)
        {
            return ISurfaceParameterizationDatainstance.ISurfaceParameterizationDataInstance.UMinBoundType;
        }
        public static Int32 UMaxBoundType(ISurfaceParameterizationDataObject ISurfaceParameterizationDatainstance)
        {
            return ISurfaceParameterizationDatainstance.ISurfaceParameterizationDataInstance.UMaxBoundType;
        }
        public static Int32 VMinBoundType(ISurfaceParameterizationDataObject ISurfaceParameterizationDatainstance)
        {
            return ISurfaceParameterizationDatainstance.ISurfaceParameterizationDataInstance.VMinBoundType;
        }
        public static Int32 VMaxBoundType(ISurfaceParameterizationDataObject ISurfaceParameterizationDatainstance)
        {
            return ISurfaceParameterizationDatainstance.ISurfaceParameterizationDataInstance.VMaxBoundType;
        }
        public static Int32 UPropertyNumber(ISurfaceParameterizationDataObject ISurfaceParameterizationDatainstance)
        {
            return ISurfaceParameterizationDatainstance.ISurfaceParameterizationDataInstance.UPropertyNumber;
        }
        public static Object UProperties(ISurfaceParameterizationDataObject ISurfaceParameterizationDatainstance)
        {
            return ISurfaceParameterizationDatainstance.ISurfaceParameterizationDataInstance.UProperties;
        }
        public static Int32 VPropertyNumber(ISurfaceParameterizationDataObject ISurfaceParameterizationDatainstance)
        {
            return ISurfaceParameterizationDatainstance.ISurfaceParameterizationDataInstance.VPropertyNumber;
        }
        public static Object VProperties(ISurfaceParameterizationDataObject ISurfaceParameterizationDatainstance)
        {
            return ISurfaceParameterizationDatainstance.ISurfaceParameterizationDataInstance.VProperties;
        }
    }
}