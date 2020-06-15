using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDimensionObject
    {
        public IDimension IDimensionInstance { get; set; }
        public IDimensionObject(IDimension IDimensioninstance)
        {
            IDimensionInstance = IDimensioninstance;
        }
    }
    public static class IDimensionInterface
    {
        public static Double GetUserValueIn(IDimensionObject IDimensioninstance, Object Doc)
        {
            return IDimensioninstance.IDimensionInstance.GetUserValueIn(Doc);
        }
        public static Double IGetUserValueIn(IDimensionObject IDimensioninstance, IModelDocObject Doc)
        {
            return IDimensioninstance.IDimensionInstance.IGetUserValueIn(Doc.IModelDocInstance as ModelDoc);
        }
        public static void SetUserValueIn(IDimensionObject IDimensioninstance, Object Doc, Double NewValue)
        {
            IDimensioninstance.IDimensionInstance.SetUserValueIn(Doc, NewValue);
        }
        public static void ISetUserValueIn(IDimensionObject IDimensioninstance, IModelDocObject Doc, Double NewValue)
        {
            IDimensioninstance.IDimensionInstance.ISetUserValueIn(Doc.IModelDocInstance as ModelDoc, NewValue);
        }
        public static Int32 GetToleranceType(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.GetToleranceType();
        }
        public static Boolean SetToleranceType(IDimensionObject IDimensioninstance, Int32 NewType)
        {
            return IDimensioninstance.IDimensionInstance.SetToleranceType(NewType);
        }
        public static Object GetToleranceValues(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.GetToleranceValues();
        }
        public static Double IGetToleranceValues(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.IGetToleranceValues();
        }
        public static Boolean SetToleranceValues(IDimensionObject IDimensioninstance, Double TolMin, Double TolMax)
        {
            return IDimensioninstance.IDimensionInstance.SetToleranceValues(TolMin, TolMax);
        }
        public static Object GetToleranceFontInfo(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.GetToleranceFontInfo();
        }
        public static Double IGetToleranceFontInfo(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.IGetToleranceFontInfo();
        }
        public static Boolean SetToleranceFontInfo(IDimensionObject IDimensioninstance, Int32 UseFontScale, Double TolScale, Double TolHeight)
        {
            return IDimensioninstance.IDimensionInstance.SetToleranceFontInfo(UseFontScale, TolScale, TolHeight);
        }
        public static String GetToleranceFitValues(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.GetToleranceFitValues();
        }
        public static Boolean SetToleranceFitValues(IDimensionObject IDimensioninstance, String NewLValue, String NewUValue)
        {
            return IDimensioninstance.IDimensionInstance.SetToleranceFitValues(NewLValue, NewUValue);
        }
        public static Boolean IsReference(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.IsReference();
        }
        public static Boolean IsAppliedToAllConfigurations(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.IsAppliedToAllConfigurations();
        }
        public static Int32 SetSystemValue2(IDimensionObject IDimensioninstance, Double NewValue, Int32 WhichConfigurations)
        {
            return IDimensioninstance.IDimensionInstance.SetSystemValue2(NewValue, WhichConfigurations);
        }
        public static Int32 SetValue2(IDimensionObject IDimensioninstance, Double NewValue, Int32 WhichConfigurations)
        {
            return IDimensioninstance.IDimensionInstance.SetValue2(NewValue, WhichConfigurations);
        }
        public static Int32 SetUserValueIn2(IDimensionObject IDimensioninstance, Object Doc, Double NewValue, Int32 WhichConfigurations)
        {
            return IDimensioninstance.IDimensionInstance.SetUserValueIn2(Doc, NewValue, WhichConfigurations);
        }
        public static Int32 ISetUserValueIn2(IDimensionObject IDimensioninstance, IModelDocObject Doc, Double NewValue, Int32 WhichConfigurations)
        {
            return IDimensioninstance.IDimensionInstance.ISetUserValueIn2(Doc.IModelDocInstance as ModelDoc, NewValue, WhichConfigurations);
        }
        public static Int32 GetArcEndCondition(IDimensionObject IDimensioninstance, Int32 Index)
        {
            return IDimensioninstance.IDimensionInstance.GetArcEndCondition(Index);
        }
        public static Int32 SetArcEndCondition(IDimensionObject IDimensioninstance, Int32 Index, Int32 Condition)
        {
            return IDimensioninstance.IDimensionInstance.SetArcEndCondition(Index, Condition);
        }
        public static Double GetValue2(IDimensionObject IDimensioninstance, String ConfigName)
        {
            return IDimensioninstance.IDimensionInstance.GetValue2(ConfigName);
        }
        public static Double GetSystemValue2(IDimensionObject IDimensioninstance, String ConfigName)
        {
            return IDimensioninstance.IDimensionInstance.GetSystemValue2(ConfigName);
        }
        public static Double IGetUserValueIn2(IDimensionObject IDimensioninstance, IModelDoc2Object Doc)
        {
            return IDimensioninstance.IDimensionInstance.IGetUserValueIn2(Doc.IModelDoc2Instance as ModelDoc2);
        }
        public static Int32 ISetUserValueIn3(IDimensionObject IDimensioninstance, IModelDoc2Object Doc, Double NewValue, Int32 WhichConfigurations)
        {
            return IDimensioninstance.IDimensionInstance.ISetUserValueIn3(Doc.IModelDoc2Instance as ModelDoc2, NewValue, WhichConfigurations);
        }
        public static Int32 GetType(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.GetType();
        }
        //public static Int32 ISetValue3(IDimensionObject IDimensioninstance, Double NewValue, Int32 WhichConfigurations, Int32 Config_count, String& Config_names)
        //{
        //    return IDimensioninstance.IDimensionInstance.ISetValue3(NewValue, WhichConfigurations, Config_count, Config_names);
        //}
        public static Int32 SetValue3(IDimensionObject IDimensioninstance, Double NewValue, Int32 WhichConfigurations, Object Config_names)
        {
            return IDimensioninstance.IDimensionInstance.SetValue3(NewValue, WhichConfigurations, Config_names);
        }
        //public static Double IGetValue3(IDimensionObject IDimensioninstance, Int32 WhichConfigurations, Int32 Config_count, String& Config_names)
        //{
        //    return IDimensioninstance.IDimensionInstance.IGetValue3(WhichConfigurations, Config_count, Config_names);
        //}
        public static Object GetValue3(IDimensionObject IDimensioninstance, Int32 WhichConfigurations, Object Config_names)
        {
            return IDimensioninstance.IDimensionInstance.GetValue3(WhichConfigurations, Config_names);
        }
        public static Int32 GetReferencePointsCount(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.GetReferencePointsCount();
        }
        public static IMathPointObject IGetReferencePoints(IDimensionObject IDimensioninstance, Int32 PointsCount)
        {
            return new IMathPointObject(IDimensioninstance.IDimensionInstance.IGetReferencePoints(PointsCount));
        }
        //public static void ISetReferencePoints(IDimensionObject IDimensioninstance, Int32 PointsCount, MathPoint&Object RefPoints)
        //{
        //    return IDimensioninstance.IDimensionInstance.ISetReferencePoints(PointsCount, RefPoints);
        //}
        public static Int32 SetSystemValue3(IDimensionObject IDimensioninstance, Double NewValue, Int32 WhichConfigurations, Object Config_names)
        {
            return IDimensioninstance.IDimensionInstance.SetSystemValue3(NewValue, WhichConfigurations, Config_names);
        }
        //public static Int32 ISetSystemValue3(IDimensionObject IDimensioninstance, Double NewValue, Int32 WhichConfigurations, Int32 Config_count, String& Config_names)
        //{
        //    return IDimensioninstance.IDimensionInstance.ISetSystemValue3(NewValue, WhichConfigurations, Config_count, Config_names);
        //}
        public static Object GetSystemValue3(IDimensionObject IDimensioninstance, Int32 WhichConfigurations, Object Config_names)
        {
            return IDimensioninstance.IDimensionInstance.GetSystemValue3(WhichConfigurations, Config_names);
        }
        //public static Double IGetSystemValue3(IDimensionObject IDimensioninstance, Int32 WhichConfigurations, Int32 Config_count, String& Config_names)
        //{
        //    return IDimensioninstance.IDimensionInstance.IGetSystemValue3(WhichConfigurations, Config_count, Config_names);
        //}
        public static IFeatureObject GetFeatureOwner(IDimensionObject IDimensioninstance)
        {
            return new IFeatureObject(IDimensioninstance.IDimensionInstance.GetFeatureOwner());
        }
        //public static Boolean GetSystemChamferValues(IDimensionObject IDimensioninstance, Double& Length, Double& Angle)
        //{
        //    return IDimensioninstance.IDimensionInstance.GetSystemChamferValues(Length, Angle);
        //}
        public static Boolean IsDesignTableDimension(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.IsDesignTableDimension();
        }
        public static String GetNameForSelection(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.GetNameForSelection();
        }
        public static Double Value(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.Value;
        }
        public static Double SystemValue(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.SystemValue;
        }
        public static String Name(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.Name;
        }
        public static Boolean ReadOnly(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.ReadOnly;
        }
        public static String FullName(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.FullName;
        }
        public static Int32 DrivenState(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.DrivenState;
        }
        public static IMathVectorObject DimensionLineDirection(IDimensionObject IDimensioninstance)
        {
            return new IMathVectorObject(IDimensioninstance.IDimensionInstance.DimensionLineDirection);
        }
        public static IMathVectorObject ExtensionLineDirection(IDimensionObject IDimensioninstance)
        {
            return new IMathVectorObject(IDimensioninstance.IDimensionInstance.ExtensionLineDirection);
        }
        public static Object ReferencePoints(IDimensionObject IDimensioninstance)
        {
            return IDimensioninstance.IDimensionInstance.ReferencePoints;
        }
        public static IDimensionToleranceObject Tolerance(IDimensionObject IDimensioninstance)
        {
            return new IDimensionToleranceObject(IDimensioninstance.IDimensionInstance.Tolerance);
        }
    }
}