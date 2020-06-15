using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class IntersectFeatureDataObject
    {
        public IntersectFeatureData IntersectFeatureDataInstance { get; set; }
        public IntersectFeatureDataObject(IntersectFeatureData IntersectFeatureDatainstance)
        {
            IntersectFeatureDataInstance = IntersectFeatureDatainstance;
        }
    }
    public static class IntersectFeatureDataInterface
    {
    }
}