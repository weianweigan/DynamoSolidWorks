using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBomTableObject
    {
        public IBomTable IBomTableInstance { get; set; }
        public IBomTableObject(IBomTable IBomTableinstance)
        {
            IBomTableInstance = IBomTableinstance;
        }
    }
    public static class IBomTableInterface
    {
        public static Object GetExtent(IBomTableObject IBomTableinstance)
        {
            return IBomTableinstance.IBomTableInstance.GetExtent();
        }
        public static Double IGetExtent(IBomTableObject IBomTableinstance)
        {
            return IBomTableinstance.IBomTableInstance.IGetExtent();
        }
        public static Int32 GetRowCount(IBomTableObject IBomTableinstance)
        {
            return IBomTableinstance.IBomTableInstance.GetRowCount();
        }
        public static Int32 GetColumnCount(IBomTableObject IBomTableinstance)
        {
            return IBomTableinstance.IBomTableInstance.GetColumnCount();
        }
        public static String GetHeaderText(IBomTableObject IBomTableinstance, Int32 Col)
        {
            return IBomTableinstance.IBomTableInstance.GetHeaderText(Col);
        }
        public static String GetEntryText(IBomTableObject IBomTableinstance, Int32 Row, Int32 Col)
        {
            return IBomTableinstance.IBomTableInstance.GetEntryText(Row, Col);
        }
        public static void Attach(IBomTableObject IBomTableinstance)
        {
            IBomTableinstance.IBomTableInstance.Attach();
        }
        public static void Detach(IBomTableObject IBomTableinstance)
        {
            IBomTableinstance.IBomTableInstance.Detach();
        }
        public static Double GetColumnWidth(IBomTableObject IBomTableinstance, Int32 Col)
        {
            return IBomTableinstance.IBomTableInstance.GetColumnWidth(Col);
        }
        public static Double GetRowHeight(IBomTableObject IBomTableinstance, Int32 Row)
        {
            return IBomTableinstance.IBomTableInstance.GetRowHeight(Row);
        }
        public static Object GetEntryValue(IBomTableObject IBomTableinstance, Int32 Row, Int32 Col)
        {
            return IBomTableinstance.IBomTableInstance.GetEntryValue(Row, Col);
        }
        public static Boolean Attach2(IBomTableObject IBomTableinstance)
        {
            return IBomTableinstance.IBomTableInstance.Attach2();
        }
        public static Object GetDisplayData(IBomTableObject IBomTableinstance)
        {
            return IBomTableinstance.IBomTableInstance.GetDisplayData();
        }
        public static IDisplayDataObject IGetDisplayData(IBomTableObject IBomTableinstance)
        {
            return new IDisplayDataObject(IBomTableinstance.IBomTableInstance.IGetDisplayData());
        }
        public static Boolean IsVisible(IBomTableObject IBomTableinstance)
        {
            return IBomTableinstance.IBomTableInstance.IsVisible();
        }
        public static Boolean Attach3(IBomTableObject IBomTableinstance)
        {
            return IBomTableinstance.IBomTableInstance.Attach3();
        }
        public static Int32 GetTotalRowCount(IBomTableObject IBomTableinstance)
        {
            return IBomTableinstance.IBomTableInstance.GetTotalRowCount();
        }
        public static Int32 GetTotalColumnCount(IBomTableObject IBomTableinstance)
        {
            return IBomTableinstance.IBomTableInstance.GetTotalColumnCount();
        }
        public static Boolean Select(IBomTableObject IBomTableinstance, Boolean Append, Int32 Mark)
        {
            return IBomTableinstance.IBomTableInstance.Select(Append, Mark);
        }
        public static Boolean DeSelect(IBomTableObject IBomTableinstance)
        {
            return IBomTableinstance.IBomTableInstance.DeSelect();
        }
    }
}