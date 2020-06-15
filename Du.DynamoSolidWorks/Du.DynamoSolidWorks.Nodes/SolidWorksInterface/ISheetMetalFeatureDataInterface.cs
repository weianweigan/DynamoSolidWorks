using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISheetMetalFeatureDataObject
    {
        public ISheetMetalFeatureData ISheetMetalFeatureDataInstance { get; set; }
        public ISheetMetalFeatureDataObject(ISheetMetalFeatureData ISheetMetalFeatureDatainstance)
        {
            ISheetMetalFeatureDataInstance = ISheetMetalFeatureDatainstance;
        }
    }
    public static class ISheetMetalFeatureDataInterface
    {
        public static Boolean AccessSelections(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        //public static Boolean IAccessSelections(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance, ModelDocObject TopDoc, ComponentObject Component)
        //{
        //    return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.IAccessSelections(TopDoc, Component);
        //}
        public static void ReleaseSelectionAccess(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance)
        {
            ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Boolean IAccessSelections2(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.IAccessSelections2(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static ICustomBendAllowanceObject GetCustomBendAllowance(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance)
        {
            return new ICustomBendAllowanceObject(ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.GetCustomBendAllowance());
        }
        //public static void SetCustomBendAllowance(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance, CustomBendAllowanceObject PBendData)
        //{
        //    return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.SetCustomBendAllowance(PBendData);
        //}
        //public static Int32 GetOverrideDefaultParameter(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance, Boolean& OverrideDefaultParameter)
        //{
        //    return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.GetOverrideDefaultParameter(OverrideDefaultParameter);
        //}
        public static Int32 SetOverrideDefaultParameter(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance, Boolean OverrideDefaultParameter)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.SetOverrideDefaultParameter(OverrideDefaultParameter);
        }
        //public static Int32 GetUseGaugeTable(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance, Boolean& UseGaugeTable, String& GaugeTableFile)
        //{
        //    return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.GetUseGaugeTable(UseGaugeTable, GaugeTableFile);
        //}
        public static Int32 SetUseGaugeTable(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance, Boolean UseGaugeTable, String GaugeTableFile)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.SetUseGaugeTable(UseGaugeTable, GaugeTableFile);
        }
        //public static Int32 GetOverrideDefaultParameter2(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance, Int32 Parameter, Boolean& OverrideDefaultParameter)
        //{
        //    return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.GetOverrideDefaultParameter2(Parameter, OverrideDefaultParameter);
        //}
        public static Int32 SetOverrideDefaultParameter2(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance, Int32 Parameter, Boolean OverrideDefaultParameter)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.SetOverrideDefaultParameter2(Parameter, OverrideDefaultParameter);
        }
        public static Double BendRadius(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.BendRadius;
        }
        public static Double Thickness(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.Thickness;
        }
        public static Object FixedReference(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.FixedReference;
        }
        public static Int32 BendAllowanceType(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.BendAllowanceType;
        }
        public static String BendTableFile(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.BendTableFile;
        }
        public static Double KFactor(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.KFactor;
        }
        public static Double BendAllowance(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.BendAllowance;
        }
        public static Boolean UseAutoRelief(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.UseAutoRelief;
        }
        public static Int32 AutoReliefType(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.AutoReliefType;
        }
        public static Double ReliefRatio(ISheetMetalFeatureDataObject ISheetMetalFeatureDatainstance)
        {
            return ISheetMetalFeatureDatainstance.ISheetMetalFeatureDataInstance.ReliefRatio;
        }
    }
}