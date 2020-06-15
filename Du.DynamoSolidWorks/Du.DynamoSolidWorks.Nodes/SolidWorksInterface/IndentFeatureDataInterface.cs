using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class IndentFeatureDataObject
    {
        public IndentFeatureData IndentFeatureDataInstance { get; set; }
        public IndentFeatureDataObject(IndentFeatureData IndentFeatureDatainstance)
        {
            IndentFeatureDataInstance = IndentFeatureDatainstance;
        }
    }
    public static class IndentFeatureDataInterface
    {
    }
}