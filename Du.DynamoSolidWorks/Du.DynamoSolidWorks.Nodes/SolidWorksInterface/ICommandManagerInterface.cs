using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICommandManagerObject
    {
        public ICommandManager ICommandManagerInstance { get; set; }
        public ICommandManagerObject(ICommandManager ICommandManagerinstance)
        {
            ICommandManagerInstance = ICommandManagerinstance;
        }
    }
    public static class ICommandManagerInterface
    {
        public static ICommandGroupObject CreateCommandGroup(ICommandManagerObject ICommandManagerinstance, Int32 UserID, String Title, String ToolTip, String Hint, Int32 Position)
        {
            return new ICommandGroupObject(ICommandManagerinstance.ICommandManagerInstance.CreateCommandGroup(UserID, Title, ToolTip, Hint, Position));
        }
        public static Boolean RemoveCommandGroup(ICommandManagerObject ICommandManagerinstance, Int32 UserID)
        {
            return ICommandManagerinstance.ICommandManagerInstance.RemoveCommandGroup(UserID);
        }
        public static ICommandGroupObject GetCommandGroup(ICommandManagerObject ICommandManagerinstance, Int32 UserID)
        {
            return new ICommandGroupObject(ICommandManagerinstance.ICommandManagerInstance.GetCommandGroup(UserID));
        }
        public static IntPtr IGetGroups(ICommandManagerObject ICommandManagerinstance, Int32 Count)
        {
            return ICommandManagerinstance.ICommandManagerInstance.IGetGroups(Count);
        }
        public static Object GetGroups(ICommandManagerObject ICommandManagerinstance)
        {
            return ICommandManagerinstance.ICommandManagerInstance.GetGroups();
        }
        public static ICommandGroupObject AddContextMenu(ICommandManagerObject ICommandManagerinstance, Int32 UserID, String Title)
        {
            return new ICommandGroupObject(ICommandManagerinstance.ICommandManagerInstance.AddContextMenu(UserID, Title));
        }
        public static Int32 GetCommandTabCount(ICommandManagerObject ICommandManagerinstance, Int32 DocumentType)
        {
            return ICommandManagerinstance.ICommandManagerInstance.GetCommandTabCount(DocumentType);
        }
        public static Object CommandTabs(ICommandManagerObject ICommandManagerinstance, Int32 DocumentType)
        {
            return ICommandManagerinstance.ICommandManagerInstance.CommandTabs(DocumentType);
        }
        public static ICommandTabObject IGetCommandTabs(ICommandManagerObject ICommandManagerinstance, Int32 DocumentType, Int32 CommandTabCount)
        {
            return new ICommandTabObject(ICommandManagerinstance.ICommandManagerInstance.IGetCommandTabs(DocumentType, CommandTabCount));
        }
        public static ICommandTabObject GetCommandTab(ICommandManagerObject ICommandManagerinstance, Int32 DocumentType, String TabName)
        {
            return new ICommandTabObject(ICommandManagerinstance.ICommandManagerInstance.GetCommandTab(DocumentType, TabName));
        }
        public static ICommandTabObject AddCommandTab(ICommandManagerObject ICommandManagerinstance, Int32 DocumentType, String TabName)
        {
            return new ICommandTabObject(ICommandManagerinstance.ICommandManagerInstance.AddCommandTab(DocumentType, TabName));
        }
        //public static Boolean RemoveCommandTab(ICommandManagerObject ICommandManagerinstance, CommandTabObject TabToRemove)
        //{
        //    return ICommandManagerinstance.ICommandManagerInstance.RemoveCommandTab(TabToRemove);
        //}
        //public static ICommandGroupObject CreateCommandGroup2(ICommandManagerObject ICommandManagerinstance, Int32 UserID, String Title, String ToolTip, String Hint, Int32 Position, Boolean IgnorePreviousVersion, Int32& Errors)
        //{
        //    return new ICommandGroupObject(ICommandManagerinstance.ICommandManagerInstance.CreateCommandGroup2(UserID, Title, ToolTip, Hint, Position, IgnorePreviousVersion, Errors));
        //}
        public static Int32 RemoveCommandGroup2(ICommandManagerObject ICommandManagerinstance, Int32 UserID, Boolean RuntimeOnly)
        {
            return ICommandManagerinstance.ICommandManagerInstance.RemoveCommandGroup2(UserID, RuntimeOnly);
        }
        public static IFlyoutGroupObject CreateFlyoutGroup(ICommandManagerObject ICommandManagerinstance, Int32 UserID, String Title, String ToolTip, String Hint, String SmallIcon, String LargeIcon, String SmallImageList, String LargeImageList, String CallbackFunction, String UpdateCallbackFunction)
        {
            return new IFlyoutGroupObject(ICommandManagerinstance.ICommandManagerInstance.CreateFlyoutGroup(UserID, Title, ToolTip, Hint, SmallIcon, LargeIcon, SmallImageList, LargeImageList, CallbackFunction, UpdateCallbackFunction));
        }
        public static Object GetFlyoutGroups(ICommandManagerObject ICommandManagerinstance)
        {
            return ICommandManagerinstance.ICommandManagerInstance.GetFlyoutGroups();
        }
        public static IFlyoutGroupObject GetFlyoutGroup(ICommandManagerObject ICommandManagerinstance, Int32 UserID)
        {
            return new IFlyoutGroupObject(ICommandManagerinstance.ICommandManagerInstance.GetFlyoutGroup(UserID));
        }
        public static Boolean RemoveFlyoutGroup(ICommandManagerObject ICommandManagerinstance, Int32 UserID)
        {
            return ICommandManagerinstance.ICommandManagerInstance.RemoveFlyoutGroup(UserID);
        }
        //public static Boolean GetGroupDataFromRegistry(ICommandManagerObject ICommandManagerinstance, Int32 UserGroupId, Object& UserIDs)
        //{
        //    return ICommandManagerinstance.ICommandManagerInstance.GetGroupDataFromRegistry(UserGroupId, UserIDs);
        //}
        public static Int32 GetCommandIDsCount(ICommandManagerObject ICommandManagerinstance, Int32 UserGroupId)
        {
            return ICommandManagerinstance.ICommandManagerInstance.GetCommandIDsCount(UserGroupId);
        }
        //public static Boolean IGetGroupDataFromRegistry(ICommandManagerObject ICommandManagerinstance, Int32 UserGroupId, Int32 Count, Int32& UserIDs)
        //{
        //    return ICommandManagerinstance.ICommandManagerInstance.IGetGroupDataFromRegistry(UserGroupId, Count, UserIDs);
        //}
        public static IFlyoutGroupObject CreateFlyoutGroup2(ICommandManagerObject ICommandManagerinstance, Int32 UserID, String Title, String ToolTip, String Hint, Object MainIconList, Object IconList, String CallbackFunction, String UpdateCallbackFunction)
        {
            return new IFlyoutGroupObject(ICommandManagerinstance.ICommandManagerInstance.CreateFlyoutGroup2(UserID, Title, ToolTip, Hint, MainIconList, IconList, CallbackFunction, UpdateCallbackFunction));
        }
        public static Int32 NumberOfGroups(ICommandManagerObject ICommandManagerinstance)
        {
            return ICommandManagerinstance.ICommandManagerInstance.NumberOfGroups;
        }
        public static Int32 NumberOfFlyoutGroups(ICommandManagerObject ICommandManagerinstance)
        {
            return ICommandManagerinstance.ICommandManagerInstance.NumberOfFlyoutGroups;
        }
    }
}