using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class ImportStepDataObject
    {
        public ImportStepData ImportStepDataInstance { get; set; }
        public ImportStepDataObject(ImportStepData ImportStepDatainstance)
        {
            ImportStepDataInstance = ImportStepDatainstance;
        }
    }
    public static class ImportStepDataInterface
    {
    }
}