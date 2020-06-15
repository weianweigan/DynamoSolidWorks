using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IStraightTapElementDataObject
    {
        public IStraightTapElementData IStraightTapElementDataInstance { get; set; }
        public IStraightTapElementDataObject(IStraightTapElementData IStraightTapElementDatainstance)
        {
            IStraightTapElementDataInstance = IStraightTapElementDatainstance;
        }
    }
    public static class IStraightTapElementDataInterface
    {
        public static Int32 CustomSizing(IStraightTapElementDataObject IStraightTapElementDatainstance)
        {
            return IStraightTapElementDatainstance.IStraightTapElementDataInstance.CustomSizing;
        }
        public static Int32 ThreadClass(IStraightTapElementDataObject IStraightTapElementDatainstance)
        {
            return IStraightTapElementDatainstance.IStraightTapElementDataInstance.ThreadClass;
        }
        public static Boolean ThreadClassOverride(IStraightTapElementDataObject IStraightTapElementDatainstance)
        {
            return IStraightTapElementDatainstance.IStraightTapElementDataInstance.ThreadClassOverride;
        }
        public static Int32 EndShape(IStraightTapElementDataObject IStraightTapElementDatainstance)
        {
            return IStraightTapElementDatainstance.IStraightTapElementDataInstance.EndShape;
        }
        public static Boolean DrillPointAngleOverride(IStraightTapElementDataObject IStraightTapElementDatainstance)
        {
            return IStraightTapElementDatainstance.IStraightTapElementDataInstance.DrillPointAngleOverride;
        }
        public static Double DrillPointAngle(IStraightTapElementDataObject IStraightTapElementDatainstance)
        {
            return IStraightTapElementDatainstance.IStraightTapElementDataInstance.DrillPointAngle;
        }
        public static Int32 Equation(IStraightTapElementDataObject IStraightTapElementDatainstance)
        {
            return IStraightTapElementDatainstance.IStraightTapElementDataInstance.Equation;
        }
    }
}