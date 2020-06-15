using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IGeneralTableAnnotationObject
    {
        public IGeneralTableAnnotation IGeneralTableAnnotationInstance { get; set; }
        public IGeneralTableAnnotationObject(IGeneralTableAnnotation IGeneralTableAnnotationinstance)
        {
            IGeneralTableAnnotationInstance = IGeneralTableAnnotationinstance;
        }
    }
    public static class IGeneralTableAnnotationInterface
    {
        public static Boolean Sort(IGeneralTableAnnotationObject IGeneralTableAnnotationinstance, Int32 ColumnIndex, Boolean SortAscending)
        {
            return IGeneralTableAnnotationinstance.IGeneralTableAnnotationInstance.Sort(ColumnIndex, SortAscending);
        }
        public static IGeneralTableFeatureObject GeneralTable(IGeneralTableAnnotationObject IGeneralTableAnnotationinstance)
        {
            return new IGeneralTableFeatureObject(IGeneralTableAnnotationinstance.IGeneralTableAnnotationInstance.GeneralTable);
        }
    }
}