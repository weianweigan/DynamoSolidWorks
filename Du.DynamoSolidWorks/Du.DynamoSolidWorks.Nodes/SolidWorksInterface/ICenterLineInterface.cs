using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class ICenterLineObject
    {
        public ICenterLine ICenterLineInstance { get; set; }
        public ICenterLineObject(ICenterLine ICenterLineinstance)
        {
            ICenterLineInstance = ICenterLineinstance;
        }
    }
    public static class ICenterLineInterface
    {
        public static ICenterLineObject GetNext(ICenterLineObject ICenterLineinstance)
        {
            return new ICenterLineObject(ICenterLineinstance.ICenterLineInstance.GetNext());
        }
        public static IAnnotationObject GetAnnotation(ICenterLineObject ICenterLineinstance)
        {
            return new IAnnotationObject(ICenterLineinstance.ICenterLineInstance.GetAnnotation());
        }
    }
}