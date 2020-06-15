using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRevolveFeatureDataObject
    {
        public IRevolveFeatureData IRevolveFeatureDataInstance { get; set; }
        public IRevolveFeatureDataObject(IRevolveFeatureData IRevolveFeatureDatainstance)
        {
            IRevolveFeatureDataInstance = IRevolveFeatureDatainstance;
        }
    }
    public static class IRevolveFeatureDataInterface
    {
        public static Double GetRevolutionAngle(IRevolveFeatureDataObject IRevolveFeatureDatainstance, Boolean Forward)
        {
            return IRevolveFeatureDatainstance.IRevolveFeatureDataInstance.GetRevolutionAngle(Forward);
        }
        public static void SetRevolutionAngle(IRevolveFeatureDataObject IRevolveFeatureDatainstance, Boolean Forward, Double Angle)
        {
            IRevolveFeatureDatainstance.IRevolveFeatureDataInstance.SetRevolutionAngle(Forward, Angle);
        }
        public static Double GetWallThickness(IRevolveFeatureDataObject IRevolveFeatureDatainstance, Boolean Forward)
        {
            return IRevolveFeatureDatainstance.IRevolveFeatureDataInstance.GetWallThickness(Forward);
        }
        public static void SetWallThickness(IRevolveFeatureDataObject IRevolveFeatureDatainstance, Boolean Forward, Double WallThickness)
        {
            IRevolveFeatureDatainstance.IRevolveFeatureDataInstance.SetWallThickness(Forward, WallThickness);
        }
        public static Boolean IsBossFeature(IRevolveFeatureDataObject IRevolveFeatureDatainstance)
        {
            return IRevolveFeatureDatainstance.IRevolveFeatureDataInstance.IsBossFeature();
        }
        public static Boolean IsThinFeature(IRevolveFeatureDataObject IRevolveFeatureDatainstance)
        {
            return IRevolveFeatureDatainstance.IRevolveFeatureDataInstance.IsThinFeature();
        }
        public static Int32 Type(IRevolveFeatureDataObject IRevolveFeatureDatainstance)
        {
            return IRevolveFeatureDatainstance.IRevolveFeatureDataInstance.Type;
        }
        public static Boolean ReverseDirection(IRevolveFeatureDataObject IRevolveFeatureDatainstance)
        {
            return IRevolveFeatureDatainstance.IRevolveFeatureDataInstance.ReverseDirection;
        }
    }
}