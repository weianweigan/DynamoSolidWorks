using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IUserUnitObject
    {
        public IUserUnit IUserUnitInstance { get; set; }
        public IUserUnitObject(IUserUnit IUserUnitinstance)
        {
            IUserUnitInstance = IUserUnitinstance;
        }
    }
    public static class IUserUnitInterface
    {
        public static Double GetConversionFactor(IUserUnitObject IUserUnitinstance)
        {
            return IUserUnitinstance.IUserUnitInstance.GetConversionFactor();
        }
        public static Boolean IsMetric(IUserUnitObject IUserUnitinstance)
        {
            return IUserUnitinstance.IUserUnitInstance.IsMetric();
        }
        public static String GetFullUnitName(IUserUnitObject IUserUnitinstance, Boolean Plural)
        {
            return IUserUnitinstance.IUserUnitInstance.GetFullUnitName(Plural);
        }
        public static String ConvertToUserUnit(IUserUnitObject IUserUnitinstance, Double ValueIn, Boolean ShowUsernames, Boolean NameInEnglish)
        {
            return IUserUnitinstance.IUserUnitInstance.ConvertToUserUnit(ValueIn, ShowUsernames, NameInEnglish);
        }
        //public static Boolean ConvertToSystemValue(IUserUnitObject IUserUnitinstance, String UnitText, Double& ComputedValue)
        //{
        //    return IUserUnitinstance.IUserUnitInstance.ConvertToSystemValue(UnitText, ComputedValue);
        //}
        public static Double ConvertDoubleToSystemValue(IUserUnitObject IUserUnitinstance, Double UserValue)
        {
            return IUserUnitinstance.IUserUnitInstance.ConvertDoubleToSystemValue(UserValue);
        }
        public static String GetUnitsString(IUserUnitObject IUserUnitinstance, Boolean InEnglish)
        {
            return IUserUnitinstance.IUserUnitInstance.GetUnitsString(InEnglish);
        }
        public static Double GetUserAngleTolerance(IUserUnitObject IUserUnitinstance)
        {
            return IUserUnitinstance.IUserUnitInstance.GetUserAngleTolerance();
        }
        public static Int32 FractionBase(IUserUnitObject IUserUnitinstance)
        {
            return IUserUnitinstance.IUserUnitInstance.FractionBase;
        }
        public static Int32 FractionValue(IUserUnitObject IUserUnitinstance)
        {
            return IUserUnitinstance.IUserUnitInstance.FractionValue;
        }
        public static Boolean RoundToFraction(IUserUnitObject IUserUnitinstance)
        {
            return IUserUnitinstance.IUserUnitInstance.RoundToFraction;
        }
        public static Int32 SignificantDigits(IUserUnitObject IUserUnitinstance)
        {
            return IUserUnitinstance.IUserUnitInstance.SignificantDigits;
        }
        public static Boolean DisplayLeadingZero(IUserUnitObject IUserUnitinstance)
        {
            return IUserUnitinstance.IUserUnitInstance.DisplayLeadingZero;
        }
        public static Boolean PadZero(IUserUnitObject IUserUnitinstance)
        {
            return IUserUnitinstance.IUserUnitInstance.PadZero;
        }
        public static String SeparatorCharacter(IUserUnitObject IUserUnitinstance)
        {
            return IUserUnitinstance.IUserUnitInstance.SeparatorCharacter;
        }
        public static Int32 UnitType(IUserUnitObject IUserUnitinstance)
        {
            return IUserUnitinstance.IUserUnitInstance.UnitType;
        }
        public static Int32 SpecificUnitType(IUserUnitObject IUserUnitinstance)
        {
            return IUserUnitinstance.IUserUnitInstance.SpecificUnitType;
        }
    }
}