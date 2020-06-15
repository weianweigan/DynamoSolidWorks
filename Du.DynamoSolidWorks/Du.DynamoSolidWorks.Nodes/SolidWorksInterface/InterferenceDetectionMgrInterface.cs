using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class InterferenceDetectionMgrObject
    {
        public InterferenceDetectionMgr InterferenceDetectionMgrInstance { get; set; }
        public InterferenceDetectionMgrObject(InterferenceDetectionMgr InterferenceDetectionMgrinstance)
        {
            InterferenceDetectionMgrInstance = InterferenceDetectionMgrinstance;
        }
    }
    public static class InterferenceDetectionMgrInterface
    {
    }
}