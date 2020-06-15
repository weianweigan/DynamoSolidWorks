using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class ImportIgesDataObject
    {
        public ImportIgesData ImportIgesDataInstance { get; set; }
        public ImportIgesDataObject(ImportIgesData ImportIgesDatainstance)
        {
            ImportIgesDataInstance = ImportIgesDatainstance;
        }
    }
    public static class ImportIgesDataInterface
    {
    }
}