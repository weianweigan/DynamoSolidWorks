using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDraftFeatureDataObject
    {
        public IDraftFeatureData IDraftFeatureDataInstance { get; set; }
        public IDraftFeatureDataObject(IDraftFeatureData IDraftFeatureDatainstance)
        {
            IDraftFeatureDataInstance = IDraftFeatureDatainstance;
        }
    }
    public static class IDraftFeatureDataInterface
    {
        public static Int32 Type(IDraftFeatureDataObject IDraftFeatureDatainstance)
        {
            return IDraftFeatureDatainstance.IDraftFeatureDataInstance.Type;
        }
        public static Double Angle(IDraftFeatureDataObject IDraftFeatureDatainstance)
        {
            return IDraftFeatureDatainstance.IDraftFeatureDataInstance.Angle;
        }
        public static Boolean ReverseDirection(IDraftFeatureDataObject IDraftFeatureDatainstance)
        {
            return IDraftFeatureDatainstance.IDraftFeatureDataInstance.ReverseDirection;
        }
    }
}