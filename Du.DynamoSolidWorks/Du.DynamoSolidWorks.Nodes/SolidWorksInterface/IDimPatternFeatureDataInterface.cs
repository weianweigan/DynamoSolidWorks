using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDimPatternFeatureDataObject
    {
        public IDimPatternFeatureData IDimPatternFeatureDataInstance { get; set; }
        public IDimPatternFeatureDataObject(IDimPatternFeatureData IDimPatternFeatureDatainstance)
        {
            IDimPatternFeatureDataInstance = IDimPatternFeatureDatainstance;
        }
    }
    public static class IDimPatternFeatureDataInterface
    {
        public static Boolean AccessSelections(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance)
        {
            IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetInstanceCount(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.GetInstanceCount();
        }
        public static Int32 GetControllingDimensionCount(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.GetControllingDimensionCount();
        }
        public static String GetControllingDimensionName(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, Int32 Index)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.GetControllingDimensionName(Index);
        }
        public static String GetInstanceDimensionName(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, String InstanceName, String ControllingDimName)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.GetInstanceDimensionName(InstanceName, ControllingDimName);
        }
        public static Boolean GetInstanceSuppressStateByName(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, String InstanceName)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.GetInstanceSuppressStateByName(InstanceName);
        }
        public static Boolean GetInstanceSuppressStateByIndex(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, Int32 TableRowIndex)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.GetInstanceSuppressStateByIndex(TableRowIndex);
        }
        public static String SetInstanceSuppressStateByName(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, String InstanceName, Boolean SuppressState)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.SetInstanceSuppressStateByName(InstanceName, SuppressState);
        }
        public static String SetInstanceSuppressStateByIndex(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, Int32 TableRowIndex, Boolean SuppressState)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.SetInstanceSuppressStateByIndex(TableRowIndex, SuppressState);
        }
        public static Int32 GetTableRowIndex(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, String InstanceName)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.GetTableRowIndex(InstanceName);
        }
        public static Int32 GetInstanceIndex(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, String InstanceName)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.GetInstanceIndex(InstanceName);
        }
        public static String SetInstanceDimensionValue(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, Int32 TableRowIndex, String ControlDimName, Double NewValue)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.SetInstanceDimensionValue(TableRowIndex, ControlDimName, NewValue);
        }
        public static String GetInstanceNameByIndex(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, Int32 TableRowIndex)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.GetInstanceNameByIndex(TableRowIndex);
        }
        public static Boolean AddInstanceAt(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, Boolean IsSuppressed, Int32 Index)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.AddInstanceAt(IsSuppressed, Index);
        }
        public static Boolean DeleteInstanceAt(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, Int32 Index)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.DeleteInstanceAt(Index);
        }
        public static Boolean AddDimension(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.AddDimension();
        }
        public static Boolean DeleteDimension(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, String DimensionColumnName)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.DeleteDimension(DimensionColumnName);
        }
        public static Int32 ImportFromExcel(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, String ExcelFile)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.ImportFromExcel(ExcelFile);
        }
        public static Int32 ExportToExcel(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance, String ExcelFile, Boolean Overwrite)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.ExportToExcel(ExcelFile, Overwrite);
        }
        public static Boolean PropagateVisualProperties(IDimPatternFeatureDataObject IDimPatternFeatureDatainstance)
        {
            return IDimPatternFeatureDatainstance.IDimPatternFeatureDataInstance.PropagateVisualProperties;
        }
    }
}