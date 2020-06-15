using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IWeldmentCutListAnnotationObject
    {
        public IWeldmentCutListAnnotation IWeldmentCutListAnnotationInstance { get; set; }
        public IWeldmentCutListAnnotationObject(IWeldmentCutListAnnotation IWeldmentCutListAnnotationinstance)
        {
            IWeldmentCutListAnnotationInstance = IWeldmentCutListAnnotationinstance;
        }
    }
    public static class IWeldmentCutListAnnotationInterface
    {
        public static String GetColumnCustomProperty(IWeldmentCutListAnnotationObject IWeldmentCutListAnnotationinstance, Int32 Index)
        {
            return IWeldmentCutListAnnotationinstance.IWeldmentCutListAnnotationInstance.GetColumnCustomProperty(Index);
        }
        public static Boolean SetColumnCustomProperty(IWeldmentCutListAnnotationObject IWeldmentCutListAnnotationinstance, Int32 Index, String CustomProp)
        {
            return IWeldmentCutListAnnotationinstance.IWeldmentCutListAnnotationInstance.SetColumnCustomProperty(Index, CustomProp);
        }
        public static Int32 GetAllCustomPropertiesCount(IWeldmentCutListAnnotationObject IWeldmentCutListAnnotationinstance)
        {
            return IWeldmentCutListAnnotationinstance.IWeldmentCutListAnnotationInstance.GetAllCustomPropertiesCount();
        }
        public static Object GetAllCustomProperties(IWeldmentCutListAnnotationObject IWeldmentCutListAnnotationinstance)
        {
            return IWeldmentCutListAnnotationinstance.IWeldmentCutListAnnotationInstance.GetAllCustomProperties();
        }
        public static String IGetAllCustomProperties(IWeldmentCutListAnnotationObject IWeldmentCutListAnnotationinstance, Int32 Count)
        {
            return IWeldmentCutListAnnotationinstance.IWeldmentCutListAnnotationInstance.IGetAllCustomProperties(Count);
        }
        public static Boolean Sort(IWeldmentCutListAnnotationObject IWeldmentCutListAnnotationinstance, Int32 ColumnIndex, Boolean SortAscending)
        {
            return IWeldmentCutListAnnotationinstance.IWeldmentCutListAnnotationInstance.Sort(ColumnIndex, SortAscending);
        }
        public static IWeldmentCutListFeatureObject WeldmentCutListFeature(IWeldmentCutListAnnotationObject IWeldmentCutListAnnotationinstance)
        {
            return new IWeldmentCutListFeatureObject(IWeldmentCutListAnnotationinstance.IWeldmentCutListAnnotationInstance.WeldmentCutListFeature);
        }
    }
}