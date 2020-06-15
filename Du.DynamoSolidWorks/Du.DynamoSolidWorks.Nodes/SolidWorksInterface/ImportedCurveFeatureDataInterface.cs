using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class ImportedCurveFeatureDataObject
    {
        public ImportedCurveFeatureData ImportedCurveFeatureDataInstance { get; set; }
        public ImportedCurveFeatureDataObject(ImportedCurveFeatureData ImportedCurveFeatureDatainstance)
        {
            ImportedCurveFeatureDataInstance = ImportedCurveFeatureDatainstance;
        }
    }
    public static class ImportedCurveFeatureDataInterface
    {
    }
}