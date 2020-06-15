using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISldHotfixObject
    {
        public ISldHotfix ISldHotfixInstance { get; set; }
        public ISldHotfixObject(ISldHotfix ISldHotfixinstance)
        {
            ISldHotfixInstance = ISldHotfixinstance;
        }
    }
    public static class ISldHotfixInterface
    {
        public static Int32 IsSupported(ISldHotfixObject ISldHotfixinstance, String IdStr)
        {
            return ISldHotfixinstance.ISldHotfixInstance.IsSupported(IdStr);
        }
        public static Object Command(ISldHotfixObject ISldHotfixinstance, Int32 CmdID, Object Args)
        {
            return ISldHotfixinstance.ISldHotfixInstance.Command(CmdID, Args);
        }
    }
}