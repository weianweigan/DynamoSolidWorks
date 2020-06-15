using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDesignTableObject
    {
        public IDesignTable IDesignTableInstance { get; set; }
        public IDesignTableObject(IDesignTable IDesignTableinstance)
        {
            IDesignTableInstance = IDesignTableinstance;
        }
    }
    public static class IDesignTableInterface
    {
        public static Int32 GetRowCount(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.GetRowCount();
        }
        public static Int32 GetColumnCount(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.GetColumnCount();
        }
        public static String GetHeaderText(IDesignTableObject IDesignTableinstance, Int32 Col)
        {
            return IDesignTableinstance.IDesignTableInstance.GetHeaderText(Col);
        }
        public static String GetEntryText(IDesignTableObject IDesignTableinstance, Int32 Row, Int32 Col)
        {
            return IDesignTableinstance.IDesignTableInstance.GetEntryText(Row, Col);
        }
        public static Boolean Attach(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.Attach();
        }
        public static void Detach(IDesignTableObject IDesignTableinstance)
        {
            IDesignTableinstance.IDesignTableInstance.Detach();
        }
        public static Object GetEntryValue(IDesignTableObject IDesignTableinstance, Int32 Row, Int32 Col)
        {
            return IDesignTableinstance.IDesignTableInstance.GetEntryValue(Row, Col);
        }
        public static String GetTitle(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.GetTitle();
        }
        public static Int32 GetTotalRowCount(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.GetTotalRowCount();
        }
        public static Int32 GetTotalColumnCount(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.GetTotalColumnCount();
        }
        public static Int32 GetVisibleRowCount(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.GetVisibleRowCount();
        }
        public static Int32 GetVisibleColumnCount(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.GetVisibleColumnCount();
        }
        public static void SetEntryText(IDesignTableObject IDesignTableinstance, Int32 Row, Int32 Col, String TextIn)
        {
            IDesignTableinstance.IDesignTableInstance.SetEntryText(Row, Col, TextIn);
        }
        public static Boolean AddRow(IDesignTableObject IDesignTableinstance, Object CellValues)
        {
            return IDesignTableinstance.IDesignTableInstance.AddRow(CellValues);
        }
        public static Boolean UpdateModel(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.UpdateModel();
        }
        public static Int32 GetStartRowNumber(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.GetStartRowNumber();
        }
        public static Int32 GetStartColumnNumber(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.GetStartColumnNumber();
        }
        public static Int32 GetVisibleTopRowNumber(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.GetVisibleTopRowNumber();
        }
        public static Int32 GetVisibleLeftColumnNumber(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.GetVisibleLeftColumnNumber();
        }
        public static void SetRowChanged(IDesignTableObject IDesignTableinstance, Int32 RowIndex)
        {
            IDesignTableinstance.IDesignTableInstance.SetRowChanged(RowIndex);
        }
        public static void EditFeature(IDesignTableObject IDesignTableinstance)
        {
            IDesignTableinstance.IDesignTableInstance.EditFeature();
        }
        public static void EditTable(IDesignTableObject IDesignTableinstance)
        {
            IDesignTableinstance.IDesignTableInstance.EditTable();
        }
        public static Boolean UpdateFeature(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.UpdateFeature();
        }
        public static Boolean UpdateTable(IDesignTableObject IDesignTableinstance, Int32 Type, Boolean Close)
        {
            return IDesignTableinstance.IDesignTableInstance.UpdateTable(Type, Close);
        }
        public static Boolean SaveAsExcelFile(IDesignTableObject IDesignTableinstance, String Value)
        {
            return IDesignTableinstance.IDesignTableInstance.SaveAsExcelFile(Value);
        }
        public static Boolean IsActive(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.IsActive();
        }
        public static void SetEntryValue(IDesignTableObject IDesignTableinstance, Int32 Row, Int32 Col, Boolean IsText, String Retval)
        {
            IDesignTableinstance.IDesignTableInstance.SetEntryValue(Row, Col, IsText, Retval);
        }
        public static Object EditTable2(IDesignTableObject IDesignTableinstance, Boolean NewWindow)
        {
            return IDesignTableinstance.IDesignTableInstance.EditTable2(NewWindow);
        }
        public static Boolean RowHidden(IDesignTableObject IDesignTableinstance, int col)
        {
            return IDesignTableinstance.IDesignTableInstance.RowHidden[col];
        }
        public static Boolean ColumnHidden(IDesignTableObject IDesignTableinstance, int col)
        {
            return IDesignTableinstance.IDesignTableInstance.ColumnHidden[col];
        }
        public static Int32 SourceType(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.SourceType;
        }
        public static Boolean Updatable(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.Updatable;
        }
        public static Boolean LinkToFile(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.LinkToFile;
        }
        public static Boolean AutoAddNewParams(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.AutoAddNewParams;
        }
        public static Boolean AutoAddNewConfigs(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.AutoAddNewConfigs;
        }
        public static Boolean Warn(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.Warn;
        }
        public static String FileName(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.FileName;
        }
        public static Object Worksheet(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.Worksheet;
        }
        public static Int32 LastError(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.LastError;
        }
        public static Boolean EnableCellDropdownLists(IDesignTableObject IDesignTableinstance)
        {
            return IDesignTableinstance.IDesignTableInstance.EnableCellDropdownLists;
        }
    }
}