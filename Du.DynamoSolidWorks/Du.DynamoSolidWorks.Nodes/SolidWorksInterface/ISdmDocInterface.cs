using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class ISdmDocObject
    {
        public ISdmDoc ISdmDocInstance { get; set; }
        public ISdmDocObject(ISdmDoc ISdmDocinstance)
        {
            ISdmDocInstance = ISdmDocinstance;
        }
    }
    public static class ISdmDocInterface
    {
    }
}