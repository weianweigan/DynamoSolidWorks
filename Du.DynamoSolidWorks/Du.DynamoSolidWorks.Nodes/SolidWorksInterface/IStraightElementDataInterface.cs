using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IStraightElementDataObject
    {
        public IStraightElementData IStraightElementDataInstance { get; set; }
        public IStraightElementDataObject(IStraightElementData IStraightElementDatainstance)
        {
            IStraightElementDataInstance = IStraightElementDatainstance;
        }
    }
    public static class IStraightElementDataInterface
    {
        public static Int32 FitType(IStraightElementDataObject IStraightElementDatainstance)
        {
            return IStraightElementDatainstance.IStraightElementDataInstance.FitType;
        }
        public static Int32 ClassificationType(IStraightElementDataObject IStraightElementDatainstance)
        {
            return IStraightElementDatainstance.IStraightElementDataInstance.ClassificationType;
        }
        public static String HoleFit(IStraightElementDataObject IStraightElementDatainstance)
        {
            return IStraightElementDatainstance.IStraightElementDataInstance.HoleFit;
        }
        public static String ShaftFit(IStraightElementDataObject IStraightElementDatainstance)
        {
            return IStraightElementDatainstance.IStraightElementDataInstance.ShaftFit;
        }
        public static Int32 Filter(IStraightElementDataObject IStraightElementDatainstance)
        {
            return IStraightElementDatainstance.IStraightElementDataInstance.Filter;
        }
        public static Int32 EndShape(IStraightElementDataObject IStraightElementDatainstance)
        {
            return IStraightElementDatainstance.IStraightElementDataInstance.EndShape;
        }
        public static Boolean DrillPointAngleOverride(IStraightElementDataObject IStraightElementDatainstance)
        {
            return IStraightElementDatainstance.IStraightElementDataInstance.DrillPointAngleOverride;
        }
        public static Double DrillPointAngle(IStraightElementDataObject IStraightElementDatainstance)
        {
            return IStraightElementDatainstance.IStraightElementDataInstance.DrillPointAngle;
        }
    }
}