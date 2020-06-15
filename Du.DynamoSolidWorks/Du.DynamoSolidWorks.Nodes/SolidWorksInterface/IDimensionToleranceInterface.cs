using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDimensionToleranceObject
    {
        public IDimensionTolerance IDimensionToleranceInstance { get; set; }
        public IDimensionToleranceObject(IDimensionTolerance IDimensionToleranceinstance)
        {
            IDimensionToleranceInstance = IDimensionToleranceinstance;
        }
    }
    public static class IDimensionToleranceInterface
    {
        public static Double GetMinValue(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.GetMinValue();
        }
        public static Double GetMaxValue(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.GetMaxValue();
        }
        public static Boolean SetValues(IDimensionToleranceObject IDimensionToleranceinstance, Double MinValue, Double MaxValue)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.SetValues(MinValue, MaxValue);
        }
        public static Boolean GetFontUseDimension(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.GetFontUseDimension();
        }
        public static Boolean GetFontUseScale(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.GetFontUseScale();
        }
        public static Double GetFontScale(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.GetFontScale();
        }
        public static Double GetFontHeight(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.GetFontHeight();
        }
        public static Boolean SetFont(IDimensionToleranceObject IDimensionToleranceinstance, Boolean UseDimension, Boolean UseScale, Double Value)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.SetFont(UseDimension, UseScale, Value);
        }
        public static String GetHoleFitValue(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.GetHoleFitValue();
        }
        public static String GetShaftFitValue(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.GetShaftFitValue();
        }
        public static Boolean SetFitValues(IDimensionToleranceObject IDimensionToleranceinstance, String HoleFit, String ShaftFit)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.SetFitValues(HoleFit, ShaftFit);
        }
        public static Boolean GetFitFontUseDimension(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.GetFitFontUseDimension();
        }
        public static Boolean GetFitFontUseScale(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.GetFitFontUseScale();
        }
        public static Double GetFitFontScale(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.GetFitFontScale();
        }
        public static Double GetFitFontHeight(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.GetFitFontHeight();
        }
        public static Boolean SetFitFont(IDimensionToleranceObject IDimensionToleranceinstance, Boolean UseDimension, Boolean UseScale, Double Value)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.SetFitFont(UseDimension, UseScale, Value);
        }
        public static Boolean SetValues2(IDimensionToleranceObject IDimensionToleranceinstance, Double MinValue, Double MaxValue, Int32 WhichConfigurations, Object Config_names)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.SetValues2(MinValue, MaxValue, WhichConfigurations, Config_names);
        }
        //public static Int32 GetMaxValue2(IDimensionToleranceObject IDimensionToleranceinstance, Double& ToleranceValue)
        //{
        //    return IDimensionToleranceinstance.IDimensionToleranceInstance.GetMaxValue2(ToleranceValue);
        //}
        //public static Int32 GetMinValue2(IDimensionToleranceObject IDimensionToleranceinstance, Double& ToleranceValue)
        //{
        //    return IDimensionToleranceinstance.IDimensionToleranceInstance.GetMinValue2(ToleranceValue);
        //}
        public static Int32 Type(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.Type;
        }
        public static Boolean ShowParenthesis(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.ShowParenthesis;
        }
        public static Int32 FitDisplayStyle(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.FitDisplayStyle;
        }
        public static Int32 FitType(IDimensionToleranceObject IDimensionToleranceinstance)
        {
            return IDimensionToleranceinstance.IDimensionToleranceInstance.FitType;
        }
    }
}