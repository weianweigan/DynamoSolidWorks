using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICustomBendAllowanceObject
    {
        public ICustomBendAllowance ICustomBendAllowanceInstance { get; set; }
        public ICustomBendAllowanceObject(ICustomBendAllowance ICustomBendAllowanceinstance)
        {
            ICustomBendAllowanceInstance = ICustomBendAllowanceinstance;
        }
    }
    public static class ICustomBendAllowanceInterface
    {
        public static Int32 Type(ICustomBendAllowanceObject ICustomBendAllowanceinstance)
        {
            return ICustomBendAllowanceinstance.ICustomBendAllowanceInstance.Type;
        }
        public static String BendTableFile(ICustomBendAllowanceObject ICustomBendAllowanceinstance)
        {
            return ICustomBendAllowanceinstance.ICustomBendAllowanceInstance.BendTableFile;
        }
        public static Double KFactor(ICustomBendAllowanceObject ICustomBendAllowanceinstance)
        {
            return ICustomBendAllowanceinstance.ICustomBendAllowanceInstance.KFactor;
        }
        public static Double BendAllowance(ICustomBendAllowanceObject ICustomBendAllowanceinstance)
        {
            return ICustomBendAllowanceinstance.ICustomBendAllowanceInstance.BendAllowance;
        }
        public static Double BendDeduction(ICustomBendAllowanceObject ICustomBendAllowanceinstance)
        {
            return ICustomBendAllowanceinstance.ICustomBendAllowanceInstance.BendDeduction;
        }
    }
}