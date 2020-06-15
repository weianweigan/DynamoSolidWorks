using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICenterMarkObject
    {
        public ICenterMark ICenterMarkInstance { get; set; }
        public ICenterMarkObject(ICenterMark ICenterMarkinstance)
        {
            ICenterMarkInstance = ICenterMarkinstance;
        }
    }
    public static class ICenterMarkInterface
    {
        public static ICenterMarkObject GetNext(ICenterMarkObject ICenterMarkinstance)
        {
            return new ICenterMarkObject(ICenterMarkinstance.ICenterMarkInstance.GetNext());
        }
        public static IAnnotationObject GetAnnotation(ICenterMarkObject ICenterMarkinstance)
        {
            return new IAnnotationObject(ICenterMarkinstance.ICenterMarkInstance.GetAnnotation());
        }
        public static Double GetExtendedLength(ICenterMarkObject ICenterMarkinstance, Int32 GroupID, Int32 HandleID)
        {
            return ICenterMarkinstance.ICenterMarkInstance.GetExtendedLength(GroupID, HandleID);
        }
        public static Boolean SetExtendedLength(ICenterMarkObject ICenterMarkinstance, Int32 GroupID, Int32 HandleID, Double ExtendedLength)
        {
            return ICenterMarkinstance.ICenterMarkInstance.SetExtendedLength(GroupID, HandleID, ExtendedLength);
        }
        public static Boolean Select(ICenterMarkObject ICenterMarkinstance, Boolean Append, Object Data)
        {
            return ICenterMarkinstance.ICenterMarkInstance.Select(Append, Data);
        }
        public static Boolean AddToCenterMarkGroup(ICenterMarkObject ICenterMarkinstance)
        {
            return ICenterMarkinstance.ICenterMarkInstance.AddToCenterMarkGroup();
        }
        public static Boolean ReattachToCenterMarkGroup(ICenterMarkObject ICenterMarkinstance, Int32 Index)
        {
            return ICenterMarkinstance.ICenterMarkInstance.ReattachToCenterMarkGroup(Index);
        }
        public static Boolean HasDetachCenterMark(ICenterMarkObject ICenterMarkinstance)
        {
            return ICenterMarkinstance.ICenterMarkInstance.HasDetachCenterMark();
        }
        public static Boolean IsDetached(ICenterMarkObject ICenterMarkinstance, Int32 Index)
        {
            return ICenterMarkinstance.ICenterMarkInstance.IsDetached(Index);
        }
        public static Object GetPosition(ICenterMarkObject ICenterMarkinstance, Int32 Index)
        {
            return ICenterMarkinstance.ICenterMarkInstance.GetPosition(Index);
        }
        public static Boolean IsDeleted(ICenterMarkObject ICenterMarkinstance, Int32 Index)
        {
            return ICenterMarkinstance.ICenterMarkInstance.IsDeleted(Index);
        }
        public static Double RotationAngle(ICenterMarkObject ICenterMarkinstance)
        {
            return ICenterMarkinstance.ICenterMarkInstance.RotationAngle;
        }
        public static Boolean UseDocDisplaySettings(ICenterMarkObject ICenterMarkinstance)
        {
            return ICenterMarkinstance.ICenterMarkInstance.UseDocDisplaySettings;
        }
        public static Boolean ShowLines(ICenterMarkObject ICenterMarkinstance)
        {
            return ICenterMarkinstance.ICenterMarkInstance.ShowLines;
        }
        public static Double Size(ICenterMarkObject ICenterMarkinstance)
        {
            return ICenterMarkinstance.ICenterMarkInstance.Size;
        }
        public static Int32 Style(ICenterMarkObject ICenterMarkinstance)
        {
            return ICenterMarkinstance.ICenterMarkInstance.Style;
        }
        public static Int32 ConnectionLines(ICenterMarkObject ICenterMarkinstance)
        {
            return ICenterMarkinstance.ICenterMarkInstance.ConnectionLines;
        }
        public static Boolean CenterLineFont(ICenterMarkObject ICenterMarkinstance)
        {
            return ICenterMarkinstance.ICenterMarkInstance.CenterLineFont;
        }
        public static Boolean IsGrouped(ICenterMarkObject ICenterMarkinstance)
        {
            return ICenterMarkinstance.ICenterMarkInstance.IsGrouped;
        }
        public static Int32 GroupCount(ICenterMarkObject ICenterMarkinstance)
        {
            return ICenterMarkinstance.ICenterMarkInstance.GroupCount;
        }
        public static Double Gap(ICenterMarkObject ICenterMarkinstance)
        {
            return ICenterMarkinstance.ICenterMarkInstance.Gap;
        }
    }
}