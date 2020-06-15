using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBomTableSortDataObject
    {
        public IBomTableSortData IBomTableSortDataInstance { get; set; }
        public IBomTableSortDataObject(IBomTableSortData IBomTableSortDatainstance)
        {
            IBomTableSortDataInstance = IBomTableSortDatainstance;
        }
    }
    public static class IBomTableSortDataInterface
    {
        public static Int32 ColumnIndex(IBomTableSortDataObject IBomTableSortDatainstance, int SortOrderIndex)
        {
            return IBomTableSortDatainstance.IBomTableSortDataInstance.ColumnIndex[SortOrderIndex];
        }
        public static Boolean Ascending(IBomTableSortDataObject IBomTableSortDatainstance, int SortOrderIndex)
        {
            return IBomTableSortDatainstance.IBomTableSortDataInstance.Ascending[SortOrderIndex];
        }
        public static Object ItemGroups(IBomTableSortDataObject IBomTableSortDatainstance)
        {
            return IBomTableSortDatainstance.IBomTableSortDataInstance.ItemGroups;
        }
        public static Boolean DoNotChangeItemNumber(IBomTableSortDataObject IBomTableSortDatainstance)
        {
            return IBomTableSortDatainstance.IBomTableSortDataInstance.DoNotChangeItemNumber;
        }
        public static Boolean SaveCurrentSortParameters(IBomTableSortDataObject IBomTableSortDatainstance)
        {
            return IBomTableSortDatainstance.IBomTableSortDataInstance.SaveCurrentSortParameters;
        }
        public static Int32 SortMethod(IBomTableSortDataObject IBomTableSortDatainstance)
        {
            return IBomTableSortDatainstance.IBomTableSortDataInstance.SortMethod;
        }
    }
}