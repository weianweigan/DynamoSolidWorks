using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICalloutVariableObject
    {
        public ICalloutVariable ICalloutVariableInstance { get; set; }
        public ICalloutVariableObject(ICalloutVariable ICalloutVariableinstance)
        {
            ICalloutVariableInstance = ICalloutVariableinstance;
        }
    }
    public static class ICalloutVariableInterface
    {
        public static Int32 Type(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.Type;
        }
        public static Int32 VariableType(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.VariableType;
        }
        public static String VariableName(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.VariableName;
        }
        public static String UserReadableVariableName(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.UserReadableVariableName;
        }
        public static Int32 ToleranceType(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.ToleranceType;
        }
        public static Double ToleranceMax(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.ToleranceMax;
        }
        public static Double ToleranceMin(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.ToleranceMin;
        }
        public static Boolean FitUseTextScale(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.FitUseTextScale;
        }
        public static Double FitTextScale(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.FitTextScale;
        }
        public static Boolean ShowParenthesis(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.ShowParenthesis;
        }
        public static Int32 FitDisplayStyle(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.FitDisplayStyle;
        }
        public static Boolean UseTextScale(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.UseTextScale;
        }
        public static Double TextScale(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.TextScale;
        }
        public static Double TextHeight(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.TextHeight;
        }
        public static Double FitTextHeight(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.FitTextHeight;
        }
        public static String HoleFit(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.HoleFit;
        }
        public static String ShaftFit(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.ShaftFit;
        }
        public static Int32 FitType(ICalloutVariableObject ICalloutVariableinstance)
        {
            return ICalloutVariableinstance.ICalloutVariableInstance.FitType;
        }
    }
}