using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IConfigurationManagerObject
    {
        public IConfigurationManager IConfigurationManagerInstance { get; set; }
        public IConfigurationManagerObject(IConfigurationManager IConfigurationManagerinstance)
        {
            IConfigurationManagerInstance = IConfigurationManagerinstance;
        }
    }
    public static class IConfigurationManagerInterface
    {
        //public static Boolean GetConfigurationParams(IConfigurationManagerObject IConfigurationManagerinstance, String ConfigName, Object& Params, Object& Values)
        //{
        //    return IConfigurationManagerinstance.IConfigurationManagerInstance.GetConfigurationParams(ConfigName, Params, Values);
        //}
        //public static Boolean IGetConfigurationParams(IConfigurationManagerObject IConfigurationManagerinstance, String ConfigName, Int32 ParamCount, String& ParamNames, String& ParamValues)
        //{
        //    return IConfigurationManagerinstance.IConfigurationManagerInstance.IGetConfigurationParams(ConfigName, ParamCount, ParamNames, ParamValues);
        //}
        public static Int32 GetConfigurationParamsCount(IConfigurationManagerObject IConfigurationManagerinstance, String ConfigName)
        {
            return IConfigurationManagerinstance.IConfigurationManagerInstance.GetConfigurationParamsCount(ConfigName);
        }
        public static IConfigurationObject AddConfiguration(IConfigurationManagerObject IConfigurationManagerinstance, String Name, String Comment, String AlternateName, Int32 Options, String ParentConfigName, String Description)
        {
            return new IConfigurationObject(IConfigurationManagerinstance.IConfigurationManagerInstance.AddConfiguration(Name, Comment, AlternateName, Options, ParentConfigName, Description));
        }
        //public static Boolean SetConfigurationParams(IConfigurationManagerObject IConfigurationManagerinstance, String ConfigName, Object& ParamNames, Object& ParamValues)
        //{
        //    return IConfigurationManagerinstance.IConfigurationManagerInstance.SetConfigurationParams(ConfigName, ParamNames, ParamValues);
        //}
        //public static Boolean ISetConfigurationParams(IConfigurationManagerObject IConfigurationManagerinstance, String ConfigName, Int32 ParamCount, String& ParamNames, String& ParamValues)
        //{
        //    return IConfigurationManagerinstance.IConfigurationManagerInstance.ISetConfigurationParams(ConfigName, ParamCount, ParamNames, ParamValues);
        //}
        public static Object AddSpeedPak(IConfigurationManagerObject IConfigurationManagerinstance, Int32 Type, Double PartThreshold, Double FaceThreshold)
        {
            return IConfigurationManagerinstance.IConfigurationManagerInstance.AddSpeedPak(Type, PartThreshold, FaceThreshold);
        }
        public static Object AddSpeedPak2(IConfigurationManagerObject IConfigurationManagerinstance, Int32 Type, Double PartThreshold)
        {
            return IConfigurationManagerinstance.IConfigurationManagerInstance.AddSpeedPak2(Type, PartThreshold);
        }
        public static void SortConfigurationTree(IConfigurationManagerObject IConfigurationManagerinstance, Int32 InSelType)
        {
            IConfigurationManagerinstance.IConfigurationManagerInstance.SortConfigurationTree(InSelType);
        }
        public static void SetExpanded(IConfigurationManagerObject IConfigurationManagerinstance, Int32 WhichPane, Boolean Expand)
        {
            IConfigurationManagerinstance.IConfigurationManagerInstance.SetExpanded(WhichPane, Expand);
        }
        public static Boolean AddRebuildSaveMark(IConfigurationManagerObject IConfigurationManagerinstance, Int32 WhichConfigurations, Object ConfigNames)
        {
            return IConfigurationManagerinstance.IConfigurationManagerInstance.AddRebuildSaveMark(WhichConfigurations, ConfigNames);
        }
        public static Boolean RemoveMarkForAllConfigurations(IConfigurationManagerObject IConfigurationManagerinstance)
        {
            return IConfigurationManagerinstance.IConfigurationManagerInstance.RemoveMarkForAllConfigurations();
        }
        public static IConfigurationObject AddConfiguration2(IConfigurationManagerObject IConfigurationManagerinstance, String Name, String Comment, String AlternateName, Int32 Options, String ParentConfigName, String Description, Boolean Rebuild)
        {
            return new IConfigurationObject(IConfigurationManagerinstance.IConfigurationManagerInstance.AddConfiguration2(Name, Comment, AlternateName, Options, ParentConfigName, Description, Rebuild));
        }
        public static IModelDoc2Object Document(IConfigurationManagerObject IConfigurationManagerinstance)
        {
            return new IModelDoc2Object(IConfigurationManagerinstance.IConfigurationManagerInstance.Document);
        }
        public static IConfigurationObject ActiveConfiguration(IConfigurationManagerObject IConfigurationManagerinstance)
        {
            return new IConfigurationObject(IConfigurationManagerinstance.IConfigurationManagerInstance.ActiveConfiguration);
        }
        public static Boolean EnableConfigurationTree(IConfigurationManagerObject IConfigurationManagerinstance)
        {
            return IConfigurationManagerinstance.IConfigurationManagerInstance.EnableConfigurationTree;
        }
        public static Boolean LinkDisplayStatesToConfigurations(IConfigurationManagerObject IConfigurationManagerinstance)
        {
            return IConfigurationManagerinstance.IConfigurationManagerInstance.LinkDisplayStatesToConfigurations;
        }
        public static Boolean ShowConfigurationNames(IConfigurationManagerObject IConfigurationManagerinstance)
        {
            return IConfigurationManagerinstance.IConfigurationManagerInstance.ShowConfigurationNames;
        }
        public static Boolean ShowConfigurationDescriptions(IConfigurationManagerObject IConfigurationManagerinstance)
        {
            return IConfigurationManagerinstance.IConfigurationManagerInstance.ShowConfigurationDescriptions;
        }
        public static Boolean ShowPreview(IConfigurationManagerObject IConfigurationManagerinstance)
        {
            return IConfigurationManagerinstance.IConfigurationManagerInstance.ShowPreview;
        }
    }
}