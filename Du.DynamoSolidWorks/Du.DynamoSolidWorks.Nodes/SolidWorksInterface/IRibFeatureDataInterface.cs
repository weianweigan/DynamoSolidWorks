using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRibFeatureDataObject
    {
        public IRibFeatureData IRibFeatureDataInstance { get; set; }
        public IRibFeatureDataObject(IRibFeatureData IRibFeatureDatainstance)
        {
            IRibFeatureDataInstance = IRibFeatureDatainstance;
        }
    }
    public static class IRibFeatureDataInterface
    {
        public static Int32 NextReference(IRibFeatureDataObject IRibFeatureDatainstance)
        {
            return IRibFeatureDatainstance.IRibFeatureDataInstance.NextReference();
        }
        public static Boolean IsTwoSided(IRibFeatureDataObject IRibFeatureDatainstance)
        {
            return IRibFeatureDatainstance.IRibFeatureDataInstance.IsTwoSided;
        }
        public static Boolean ReverseThicknessDir(IRibFeatureDataObject IRibFeatureDatainstance)
        {
            return IRibFeatureDatainstance.IRibFeatureDataInstance.ReverseThicknessDir;
        }
        public static Double Thickness(IRibFeatureDataObject IRibFeatureDatainstance)
        {
            return IRibFeatureDatainstance.IRibFeatureDataInstance.Thickness;
        }
        public static Int32 RefSketchIndex(IRibFeatureDataObject IRibFeatureDatainstance)
        {
            return IRibFeatureDatainstance.IRibFeatureDataInstance.RefSketchIndex;
        }
        public static Boolean FlipSide(IRibFeatureDataObject IRibFeatureDatainstance)
        {
            return IRibFeatureDatainstance.IRibFeatureDataInstance.FlipSide;
        }
        public static Boolean EnableDraft(IRibFeatureDataObject IRibFeatureDatainstance)
        {
            return IRibFeatureDatainstance.IRibFeatureDataInstance.EnableDraft;
        }
        public static Boolean DraftOutward(IRibFeatureDataObject IRibFeatureDatainstance)
        {
            return IRibFeatureDatainstance.IRibFeatureDataInstance.DraftOutward;
        }
        public static Double DraftAngle(IRibFeatureDataObject IRibFeatureDatainstance)
        {
            return IRibFeatureDatainstance.IRibFeatureDataInstance.DraftAngle;
        }
    }
}