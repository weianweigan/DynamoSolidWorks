using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class IPunchTableAnnotationObject
    {
        public IPunchTableAnnotation IPunchTableAnnotationInstance { get; set; }
        public IPunchTableAnnotationObject(IPunchTableAnnotation IPunchTableAnnotationinstance)
        {
            IPunchTableAnnotationInstance = IPunchTableAnnotationinstance;
        }
    }
    public static class IPunchTableAnnotationInterface
    {
        public static IPunchTableObject PunchTable(IPunchTableAnnotationObject IPunchTableAnnotationinstance)
        {
            return new IPunchTableObject(IPunchTableAnnotationinstance.IPunchTableAnnotationInstance.PunchTable);
        }
    }
}