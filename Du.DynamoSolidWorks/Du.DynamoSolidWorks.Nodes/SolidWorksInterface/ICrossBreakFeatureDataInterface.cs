using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICrossBreakFeatureDataObject
    {
        public ICrossBreakFeatureData ICrossBreakFeatureDataInstance { get; set; }
        public ICrossBreakFeatureDataObject(ICrossBreakFeatureData ICrossBreakFeatureDatainstance)
        {
            ICrossBreakFeatureDataInstance = ICrossBreakFeatureDatainstance;
        }
    }
    public static class ICrossBreakFeatureDataInterface
    {
        public static Boolean AccessSelections(ICrossBreakFeatureDataObject ICrossBreakFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ICrossBreakFeatureDatainstance.ICrossBreakFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(ICrossBreakFeatureDataObject ICrossBreakFeatureDatainstance)
        {
            ICrossBreakFeatureDatainstance.ICrossBreakFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Boolean ReverseDirection(ICrossBreakFeatureDataObject ICrossBreakFeatureDatainstance)
        {
            return ICrossBreakFeatureDatainstance.ICrossBreakFeatureDataInstance.ReverseDirection;
        }
        public static Double BreakAngle(ICrossBreakFeatureDataObject ICrossBreakFeatureDatainstance)
        {
            return ICrossBreakFeatureDatainstance.ICrossBreakFeatureDataInstance.BreakAngle;
        }
        public static Double BreakRadius(ICrossBreakFeatureDataObject ICrossBreakFeatureDatainstance)
        {
            return ICrossBreakFeatureDatainstance.ICrossBreakFeatureDataInstance.BreakRadius;
        }
        public static Object Face(ICrossBreakFeatureDataObject ICrossBreakFeatureDatainstance)
        {
            return ICrossBreakFeatureDatainstance.ICrossBreakFeatureDataInstance.Face;
        }
    }
}