using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICounterboreElementDataObject
    {
        public ICounterboreElementData ICounterboreElementDataInstance { get; set; }
        public ICounterboreElementDataObject(ICounterboreElementData ICounterboreElementDatainstance)
        {
            ICounterboreElementDataInstance = ICounterboreElementDatainstance;
        }
    }
    public static class ICounterboreElementDataInterface
    {
        public static Boolean EndConditionOverride(ICounterboreElementDataObject ICounterboreElementDatainstance)
        {
            return ICounterboreElementDatainstance.ICounterboreElementDataInstance.EndConditionOverride;
        }
        public static Boolean UseStandardDepth(ICounterboreElementDataObject ICounterboreElementDatainstance)
        {
            return ICounterboreElementDatainstance.ICounterboreElementDataInstance.UseStandardDepth;
        }
    }
}