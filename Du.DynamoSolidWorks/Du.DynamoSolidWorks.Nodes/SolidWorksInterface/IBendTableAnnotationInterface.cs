using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class IBendTableAnnotationObject
    {
        public IBendTableAnnotation IBendTableAnnotationInstance { get; set; }
        public IBendTableAnnotationObject(IBendTableAnnotation IBendTableAnnotationinstance)
        {
            IBendTableAnnotationInstance = IBendTableAnnotationinstance;
        }
    }
    public static class IBendTableAnnotationInterface
    {
        public static IBendTableObject BendTable(IBendTableAnnotationObject IBendTableAnnotationinstance)
        {
            return new IBendTableObject(IBendTableAnnotationinstance.IBendTableAnnotationInstance.BendTable);
        }
    }
}