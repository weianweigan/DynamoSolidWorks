using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISMNormalCutFeatureDataObject
    {
        public ISMNormalCutFeatureData ISMNormalCutFeatureDataInstance { get; set; }
        public ISMNormalCutFeatureDataObject(ISMNormalCutFeatureData ISMNormalCutFeatureDatainstance)
        {
            ISMNormalCutFeatureDataInstance = ISMNormalCutFeatureDatainstance;
        }
    }
    public static class ISMNormalCutFeatureDataInterface
    {
        public static Boolean AccessSelections(ISMNormalCutFeatureDataObject ISMNormalCutFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISMNormalCutFeatureDatainstance.ISMNormalCutFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(ISMNormalCutFeatureDataObject ISMNormalCutFeatureDatainstance)
        {
            ISMNormalCutFeatureDatainstance.ISMNormalCutFeatureDataInstance.ReleaseSelectionAccess();
        }
        //public static void AddAGroupOfFaces(ISMNormalCutFeatureDataObject ISMNormalCutFeatureDatainstance, Object FaceArray, Int32& Error)
        //{
        //    return ISMNormalCutFeatureDatainstance.ISMNormalCutFeatureDataInstance.AddAGroupOfFaces(FaceArray, Error);
        //}
        public static Int32 GetNumberOfFaceGroups(ISMNormalCutFeatureDataObject ISMNormalCutFeatureDatainstance)
        {
            return ISMNormalCutFeatureDatainstance.ISMNormalCutFeatureDataInstance.GetNumberOfFaceGroups();
        }
        public static Int32 RemoveAGroupOfFaces(ISMNormalCutFeatureDataObject ISMNormalCutFeatureDatainstance)
        {
            return ISMNormalCutFeatureDatainstance.ISMNormalCutFeatureDataInstance.RemoveAGroupOfFaces();
        }
        public static Double Offset(ISMNormalCutFeatureDataObject ISMNormalCutFeatureDatainstance)
        {
            return ISMNormalCutFeatureDatainstance.ISMNormalCutFeatureDataInstance.Offset;
        }
    }
}