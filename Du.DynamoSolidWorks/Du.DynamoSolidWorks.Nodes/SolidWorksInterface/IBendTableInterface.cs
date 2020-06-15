using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBendTableObject
    {
        public IBendTable IBendTableInstance { get; set; }
        public IBendTableObject(IBendTable IBendTableinstance)
        {
            IBendTableInstance = IBendTableinstance;
        }
    }
    public static class IBendTableInterface
    {
        public static IFeatureObject GetFeature(IBendTableObject IBendTableinstance)
        {
            return new IFeatureObject(IBendTableinstance.IBendTableInstance.GetFeature());
        }
        public static Int32 GetTableAnnotationCount(IBendTableObject IBendTableinstance)
        {
            return IBendTableinstance.IBendTableInstance.GetTableAnnotationCount();
        }
        public static Object GetTableAnnotations(IBendTableObject IBendTableinstance)
        {
            return IBendTableinstance.IBendTableInstance.GetTableAnnotations();
        }
        public static IBendTableAnnotationObject IGetTableAnnotations(IBendTableObject IBendTableinstance, Int32 Count)
        {
            return new IBendTableAnnotationObject(IBendTableinstance.IBendTableInstance.IGetTableAnnotations(Count));
        }
        public static Int32 TagStyle(IBendTableObject IBendTableinstance)
        {
            return IBendTableinstance.IBendTableInstance.TagStyle;
        }
        public static String StartingValue(IBendTableObject IBendTableinstance)
        {
            return IBendTableinstance.IBendTableInstance.StartingValue;
        }
    }
}