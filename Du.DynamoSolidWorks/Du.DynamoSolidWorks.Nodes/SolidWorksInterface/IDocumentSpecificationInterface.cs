using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDocumentSpecificationObject
    {
        public IDocumentSpecification IDocumentSpecificationInstance { get; set; }
        public IDocumentSpecificationObject(IDocumentSpecification IDocumentSpecificationinstance)
        {
            IDocumentSpecificationInstance = IDocumentSpecificationinstance;
        }
    }
    public static class IDocumentSpecificationInterface
    {
        public static String FileName(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.FileName;
        }
        public static Int32 DocumentType(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.DocumentType;
        }
        public static String ConfigurationName(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.ConfigurationName;
        }
        public static Boolean Silent(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.Silent;
        }
        public static Boolean ReadOnly(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.ReadOnly;
        }
        public static Boolean ViewOnly(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.ViewOnly;
        }
        public static Boolean Selective(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.Selective;
        }
        public static Boolean LoadModel(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.LoadModel;
        }
        public static Boolean AutoMissingConfig(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.AutoMissingConfig;
        }
        public static Object ComponentList(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.ComponentList;
        }
        public static String DisplayState(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.DisplayState;
        }
        public static Boolean LightWeight(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.LightWeight;
        }
        public static Boolean IgnoreHiddenComponents(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.IgnoreHiddenComponents;
        }
        public static Boolean UseLightWeightDefault(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.UseLightWeightDefault;
        }
        public static Int32 Warning(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.Warning;
        }
        public static Int32 Error(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.Error;
        }
        public static Boolean InteractiveComponentSelection(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.InteractiveComponentSelection;
        }
        public static String SheetName(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.SheetName;
        }
        public static Boolean InteractiveAdvancedOpen(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.InteractiveAdvancedOpen;
        }
        public static Boolean Query(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.Query;
        }
        public static Boolean UseSpeedPak(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.UseSpeedPak;
        }
        public static Boolean AutoRepair(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.AutoRepair;
        }
        public static Boolean CriticalDataRepair(IDocumentSpecificationObject IDocumentSpecificationinstance)
        {
            return IDocumentSpecificationinstance.IDocumentSpecificationInstance.CriticalDataRepair;
        }
    }
}