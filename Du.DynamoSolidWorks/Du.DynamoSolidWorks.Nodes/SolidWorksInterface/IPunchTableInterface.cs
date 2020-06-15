using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IPunchTableObject
    {
        public IPunchTable IPunchTableInstance { get; set; }
        public IPunchTableObject(IPunchTable IPunchTableinstance)
        {
            IPunchTableInstance = IPunchTableinstance;
        }
    }
    public static class IPunchTableInterface
    {
        public static IFeatureObject GetFeature(IPunchTableObject IPunchTableinstance)
        {
            return new IFeatureObject(IPunchTableinstance.IPunchTableInstance.GetFeature());
        }
        public static Int32 GetTableAnnotationCount(IPunchTableObject IPunchTableinstance)
        {
            return IPunchTableinstance.IPunchTableInstance.GetTableAnnotationCount();
        }
        public static Object GetTableAnnotations(IPunchTableObject IPunchTableinstance)
        {
            return IPunchTableinstance.IPunchTableInstance.GetTableAnnotations();
        }
        public static IPunchTableAnnotationObject IGetTableAnnotations(IPunchTableObject IPunchTableinstance, Int32 Count)
        {
            return new IPunchTableAnnotationObject(IPunchTableinstance.IPunchTableInstance.IGetTableAnnotations(Count));
        }
        public static Int32 TagStyle(IPunchTableObject IPunchTableinstance)
        {
            return IPunchTableinstance.IPunchTableInstance.TagStyle;
        }
        public static String StartingValue(IPunchTableObject IPunchTableinstance)
        {
            return IPunchTableinstance.IPunchTableInstance.StartingValue;
        }
        public static Boolean CombineTags(IPunchTableObject IPunchTableinstance)
        {
            return IPunchTableinstance.IPunchTableInstance.CombineTags;
        }
        public static Boolean CombineSameSize(IPunchTableObject IPunchTableinstance)
        {
            return IPunchTableinstance.IPunchTableInstance.CombineSameSize;
        }
        public static Boolean DualDimensions(IPunchTableObject IPunchTableinstance)
        {
            return IPunchTableinstance.IPunchTableInstance.DualDimensions;
        }
        public static Boolean ShowUnits(IPunchTableObject IPunchTableinstance)
        {
            return IPunchTableinstance.IPunchTableInstance.ShowUnits;
        }
    }
}