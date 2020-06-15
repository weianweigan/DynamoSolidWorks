using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IInterferenceObject
    {
        public IInterference IInterferenceInstance { get; set; }
        public IInterferenceObject(IInterference IInterferenceinstance)
        {
            IInterferenceInstance = IInterferenceinstance;
        }
    }
    public static class IInterferenceInterface
    {
        public static Int32 GetComponentCount(IInterferenceObject IInterferenceinstance)
        {
            return IInterferenceinstance.IInterferenceInstance.GetComponentCount();
        }
        public static IComponent2Object IGetComponents(IInterferenceObject IInterferenceinstance, Int32 ComponentCount)
        {
            return new IComponent2Object(IInterferenceinstance.IInterferenceInstance.IGetComponents(ComponentCount));
        }
        public static Object GetInterferenceBody(IInterferenceObject IInterferenceinstance)
        {
            return IInterferenceinstance.IInterferenceInstance.GetInterferenceBody();
        }
        public static Boolean Ignore(IInterferenceObject IInterferenceinstance)
        {
            return IInterferenceinstance.IInterferenceInstance.Ignore;
        }
        public static Double Volume(IInterferenceObject IInterferenceinstance)
        {
            return IInterferenceinstance.IInterferenceInstance.Volume;
        }
        public static Object Components(IInterferenceObject IInterferenceinstance)
        {
            return IInterferenceinstance.IInterferenceInstance.Components;
        }
        public static Boolean IsPossibleInterference(IInterferenceObject IInterferenceinstance)
        {
            return IInterferenceinstance.IInterferenceInstance.IsPossibleInterference;
        }
        public static Boolean IsFastener(IInterferenceObject IInterferenceinstance)
        {
            return IInterferenceinstance.IInterferenceInstance.IsFastener;
        }
    }
}