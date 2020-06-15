using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ITaperedTapElementDataObject
    {
        public ITaperedTapElementData ITaperedTapElementDataInstance { get; set; }
        public ITaperedTapElementDataObject(ITaperedTapElementData ITaperedTapElementDatainstance)
        {
            ITaperedTapElementDataInstance = ITaperedTapElementDatainstance;
        }
    }
    public static class ITaperedTapElementDataInterface
    {
        public static Int32 CustomSizing(ITaperedTapElementDataObject ITaperedTapElementDatainstance)
        {
            return ITaperedTapElementDatainstance.ITaperedTapElementDataInstance.CustomSizing;
        }
        public static Boolean EndConditionOverride(ITaperedTapElementDataObject ITaperedTapElementDatainstance)
        {
            return ITaperedTapElementDatainstance.ITaperedTapElementDataInstance.EndConditionOverride;
        }
        public static Int32 ThreadClass(ITaperedTapElementDataObject ITaperedTapElementDatainstance)
        {
            return ITaperedTapElementDatainstance.ITaperedTapElementDataInstance.ThreadClass;
        }
        public static Boolean ThreadClassOverride(ITaperedTapElementDataObject ITaperedTapElementDatainstance)
        {
            return ITaperedTapElementDatainstance.ITaperedTapElementDataInstance.ThreadClassOverride;
        }
        public static Boolean UseStandardDepth(ITaperedTapElementDataObject ITaperedTapElementDatainstance)
        {
            return ITaperedTapElementDatainstance.ITaperedTapElementDataInstance.UseStandardDepth;
        }
    }
}