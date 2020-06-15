using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFlyoutGroupObject
    {
        public IFlyoutGroup IFlyoutGroupInstance { get; set; }
        public IFlyoutGroupObject(IFlyoutGroup IFlyoutGroupinstance)
        {
            IFlyoutGroupInstance = IFlyoutGroupinstance;
        }
    }
    public static class IFlyoutGroupInterface
    {
        public static Int32 AddCommandItem(IFlyoutGroupObject IFlyoutGroupinstance, String Name, String HintString, Int32 ImageListIndex, String CallbackFunction, String UpdateCallbackFunction)
        {
            return IFlyoutGroupinstance.IFlyoutGroupInstance.AddCommandItem(Name, HintString, ImageListIndex, CallbackFunction, UpdateCallbackFunction);
        }
        public static void RemoveAllCommandItems(IFlyoutGroupObject IFlyoutGroupinstance)
        {
            IFlyoutGroupinstance.IFlyoutGroupInstance.RemoveAllCommandItems();
        }
        public static Boolean RemoveCommandItem(IFlyoutGroupObject IFlyoutGroupinstance, Int32 Position)
        {
            return IFlyoutGroupinstance.IFlyoutGroupInstance.RemoveCommandItem(Position);
        }
        public static Int32 ReplaceCommandItem(IFlyoutGroupObject IFlyoutGroupinstance, Int32 Position, String Name, String HintString, Int32 ImageListIndex, String CallbackFunction, String UpdateCallbackFunction)
        {
            return IFlyoutGroupinstance.IFlyoutGroupInstance.ReplaceCommandItem(Position, Name, HintString, ImageListIndex, CallbackFunction, UpdateCallbackFunction);
        }
        public static Boolean AddContextMenuFlyout(IFlyoutGroupObject IFlyoutGroupinstance, Int32 DocumentType, Int32 SelectionType)
        {
            return IFlyoutGroupinstance.IFlyoutGroupInstance.AddContextMenuFlyout(DocumentType, SelectionType);
        }
        public static String LargeMainIcon(IFlyoutGroupObject IFlyoutGroupinstance)
        {
            return IFlyoutGroupinstance.IFlyoutGroupInstance.LargeMainIcon;
        }
        public static String SmallMainIcon(IFlyoutGroupObject IFlyoutGroupinstance)
        {
            return IFlyoutGroupinstance.IFlyoutGroupInstance.SmallMainIcon;
        }
        public static String SmallIconList(IFlyoutGroupObject IFlyoutGroupinstance)
        {
            return IFlyoutGroupinstance.IFlyoutGroupInstance.SmallIconList;
        }
        public static String LargeIconList(IFlyoutGroupObject IFlyoutGroupinstance)
        {
            return IFlyoutGroupinstance.IFlyoutGroupInstance.LargeIconList;
        }
        public static Int32 ButtonCount(IFlyoutGroupObject IFlyoutGroupinstance)
        {
            return IFlyoutGroupinstance.IFlyoutGroupInstance.ButtonCount;
        }
        public static Int32 CmdID(IFlyoutGroupObject IFlyoutGroupinstance)
        {
            return IFlyoutGroupinstance.IFlyoutGroupInstance.CmdID;
        }
        public static Int32 FlyoutType(IFlyoutGroupObject IFlyoutGroupinstance)
        {
            return IFlyoutGroupinstance.IFlyoutGroupInstance.FlyoutType;
        }
        public static Object IconList(IFlyoutGroupObject IFlyoutGroupinstance)
        {
            return IFlyoutGroupinstance.IFlyoutGroupInstance.IconList;
        }
        public static Object MainIconList(IFlyoutGroupObject IFlyoutGroupinstance)
        {
            return IFlyoutGroupinstance.IFlyoutGroupInstance.MainIconList;
        }
    }
}