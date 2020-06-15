using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBomTableAnnotationObject
    {
        public IBomTableAnnotation IBomTableAnnotationInstance { get; set; }
        public IBomTableAnnotationObject(IBomTableAnnotation IBomTableAnnotationinstance)
        {
            IBomTableAnnotationInstance = IBomTableAnnotationinstance;
        }
    }
    public static class IBomTableAnnotationInterface
    {
        public static Boolean GetColumnUseTitleAsPartNumber(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 Index)
        {
            return IBomTableAnnotationinstance.IBomTableAnnotationInstance.GetColumnUseTitleAsPartNumber(Index);
        }
        public static Boolean SetColumnUseTitleAsPartNumber(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 Index, Boolean UseTitle)
        {
            return IBomTableAnnotationinstance.IBomTableAnnotationInstance.SetColumnUseTitleAsPartNumber(Index, UseTitle);
        }
        public static String GetColumnCustomProperty(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 Index)
        {
            return IBomTableAnnotationinstance.IBomTableAnnotationInstance.GetColumnCustomProperty(Index);
        }
        public static Boolean SetColumnCustomProperty(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 Index, String CustomProp)
        {
            return IBomTableAnnotationinstance.IBomTableAnnotationInstance.SetColumnCustomProperty(Index, CustomProp);
        }
        public static Int32 GetAllCustomPropertiesCount(IBomTableAnnotationObject IBomTableAnnotationinstance)
        {
            return IBomTableAnnotationinstance.IBomTableAnnotationInstance.GetAllCustomPropertiesCount();
        }
        public static Object GetAllCustomProperties(IBomTableAnnotationObject IBomTableAnnotationinstance)
        {
            return IBomTableAnnotationinstance.IBomTableAnnotationInstance.GetAllCustomProperties();
        }
        public static String IGetAllCustomProperties(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 Count)
        {
            return IBomTableAnnotationinstance.IBomTableAnnotationInstance.IGetAllCustomProperties(Count);
        }
        public static Int32 GetComponentsCount(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 RowIndex)
        {
            return IBomTableAnnotationinstance.IBomTableAnnotationInstance.GetComponentsCount(RowIndex);
        }
        public static Object GetComponents(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 RowIndex)
        {
            return IBomTableAnnotationinstance.IBomTableAnnotationInstance.GetComponents(RowIndex);
        }
        public static IComponent2Object IGetComponents(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 RowIndex, Int32 Count)
        {
            return new IComponent2Object(IBomTableAnnotationinstance.IBomTableAnnotationInstance.IGetComponents(RowIndex, Count));
        }
        public static Int32 GetModelPathNamesCount(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 RowIndex)
        {
            return IBomTableAnnotationinstance.IBomTableAnnotationInstance.GetModelPathNamesCount(RowIndex);
        }
        //public static Object GetModelPathNames(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 RowIndex, String& ItemNumber, String& PartNumber)
        //{
        //    return IBomTableAnnotationinstance.IBomTableAnnotationInstance.GetModelPathNames(RowIndex, ItemNumber, PartNumber);
        //}
        //public static String IGetModelPathNames(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 RowIndex, Int32 Count, String& ItemNumber, String& PartNumber)
        //{
        //    return IBomTableAnnotationinstance.IBomTableAnnotationInstance.IGetModelPathNames(RowIndex, Count, ItemNumber, PartNumber);
        //}
        //public static Int32 GetComponentsCount2(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 RowIndex, String Configuration, String& ItemNumber, String& PartNumber)
        //{
        //    return IBomTableAnnotationinstance.IBomTableAnnotationInstance.GetComponentsCount2(RowIndex, Configuration, ItemNumber, PartNumber);
        //}
        public static Object GetComponents2(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 RowIndex, String Configuration)
        {
            return IBomTableAnnotationinstance.IBomTableAnnotationInstance.GetComponents2(RowIndex, Configuration);
        }
        public static IComponent2Object IGetComponents2(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 RowIndex, String Configuration, Int32 Count)
        {
            return new IComponent2Object(IBomTableAnnotationinstance.IBomTableAnnotationInstance.IGetComponents2(RowIndex, Configuration, Count));
        }
        public static IBomTableSortDataObject GetBomTableSortData(IBomTableAnnotationObject IBomTableAnnotationinstance)
        {
            return new IBomTableSortDataObject(IBomTableAnnotationinstance.IBomTableAnnotationInstance.GetBomTableSortData());
        }
        //public static Boolean Sort(IBomTableAnnotationObject IBomTableAnnotationinstance, BomTableSortDataObject SortData)
        //{
        //    return IBomTableAnnotationinstance.IBomTableAnnotationInstance.Sort(SortData);
        //}
        public static Boolean Dissolve(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 RowIndex)
        {
            return IBomTableAnnotationinstance.IBomTableAnnotationInstance.Dissolve(RowIndex);
        }
        public static Boolean RestoreRestructuredComponents(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 RowIndex)
        {
            return IBomTableAnnotationinstance.IBomTableAnnotationInstance.RestoreRestructuredComponents(RowIndex);
        }
        public static Boolean ApplySavedSortScheme(IBomTableAnnotationObject IBomTableAnnotationinstance, IBomTableSortDataObject SortData)
        {
            return IBomTableAnnotationinstance.IBomTableAnnotationInstance.ApplySavedSortScheme(SortData.IBomTableSortDataInstance as BomTableSortData);
        }
        public static void Expand(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 ExpandType, Int32 Index)
        {
            IBomTableAnnotationinstance.IBomTableAnnotationInstance.Expand(ExpandType, Index);
        }
        public static void Collapse(IBomTableAnnotationObject IBomTableAnnotationinstance, Int32 CollapseType, Int32 Index)
        {
            IBomTableAnnotationinstance.IBomTableAnnotationInstance.Collapse(CollapseType, Index);
        }
        public static IBomFeatureObject BomFeature(IBomTableAnnotationObject IBomTableAnnotationinstance)
        {
            return new IBomFeatureObject(IBomTableAnnotationinstance.IBomTableAnnotationInstance.BomFeature);
        }
    }
}