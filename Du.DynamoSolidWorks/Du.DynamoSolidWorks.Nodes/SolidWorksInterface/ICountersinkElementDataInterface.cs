using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICountersinkElementDataObject
    {
        public ICountersinkElementData ICountersinkElementDataInstance { get; set; }
        public ICountersinkElementDataObject(ICountersinkElementData ICountersinkElementDatainstance)
        {
            ICountersinkElementDataInstance = ICountersinkElementDatainstance;
        }
    }
    public static class ICountersinkElementDataInterface
    {
        public static Boolean EndConditionOverride(ICountersinkElementDataObject ICountersinkElementDatainstance)
        {
            return ICountersinkElementDatainstance.ICountersinkElementDataInstance.EndConditionOverride;
        }
        public static Double Angle(ICountersinkElementDataObject ICountersinkElementDatainstance)
        {
            return ICountersinkElementDatainstance.ICountersinkElementDataInstance.Angle;
        }
        public static Boolean AngleOverride(ICountersinkElementDataObject ICountersinkElementDatainstance)
        {
            return ICountersinkElementDatainstance.ICountersinkElementDataInstance.AngleOverride;
        }
        public static Boolean UseStandardDepth(ICountersinkElementDataObject ICountersinkElementDatainstance)
        {
            return ICountersinkElementDatainstance.ICountersinkElementDataInstance.UseStandardDepth;
        }
    }
}