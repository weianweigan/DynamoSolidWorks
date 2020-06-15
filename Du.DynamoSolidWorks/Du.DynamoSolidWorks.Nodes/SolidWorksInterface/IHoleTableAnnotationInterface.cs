using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IHoleTableAnnotationObject
    {
        public IHoleTableAnnotation IHoleTableAnnotationInstance { get; set; }
        public IHoleTableAnnotationObject(IHoleTableAnnotation IHoleTableAnnotationinstance)
        {
            IHoleTableAnnotationInstance = IHoleTableAnnotationinstance;
        }
    }
    public static class IHoleTableAnnotationInterface
    {
        public static Boolean Sort(IHoleTableAnnotationObject IHoleTableAnnotationinstance, Int32 ColumnIndex, Boolean SortAscending)
        {
            return IHoleTableAnnotationinstance.IHoleTableAnnotationInstance.Sort(ColumnIndex, SortAscending);
        }
        public static IHoleTableObject HoleTable(IHoleTableAnnotationObject IHoleTableAnnotationinstance)
        {
            return new IHoleTableObject(IHoleTableAnnotationinstance.IHoleTableAnnotationInstance.HoleTable);
        }
    }
}