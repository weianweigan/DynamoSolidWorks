using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICommandGroupObject
    {
        public ICommandGroup ICommandGroupInstance { get; set; }
        public ICommandGroupObject(ICommandGroup ICommandGroupinstance)
        {
            ICommandGroupInstance = ICommandGroupinstance;
        }
    }
    public static class ICommandGroupInterface
    {
        public static Int32 AddCommandItem(ICommandGroupObject ICommandGroupinstance, String Name, Int32 Position, String HintString, String ToolTip, Int32 ImageListIndex, String CallbackFunction, String EnableMethod, Int32 UserID)
        {
            return ICommandGroupinstance.ICommandGroupInstance.AddCommandItem(Name, Position, HintString, ToolTip, ImageListIndex, CallbackFunction, EnableMethod, UserID);
        }
        public static Int32 AddSpacer(ICommandGroupObject ICommandGroupinstance, Int32 Position)
        {
            return ICommandGroupinstance.ICommandGroupInstance.AddSpacer(Position);
        }
        public static Boolean Activate(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.Activate();
        }
        public static void SetToolbarVisibility(ICommandGroupObject ICommandGroupinstance, Boolean Visible, Int32 Mask)
        {
            ICommandGroupinstance.ICommandGroupInstance.SetToolbarVisibility(Visible, Mask);
        }
        public static Int32 AddCommandItem2(ICommandGroupObject ICommandGroupinstance, String Name, Int32 Position, String HintString, String ToolTip, Int32 ImageListIndex, String CallbackFunction, String EnableMethod, Int32 UserID, Int32 MenuTBOption)
        {
            return ICommandGroupinstance.ICommandGroupInstance.AddCommandItem2(Name, Position, HintString, ToolTip, ImageListIndex, CallbackFunction, EnableMethod, UserID, MenuTBOption);
        }
        public static Int32 AddSpacer2(ICommandGroupObject ICommandGroupinstance, Int32 Position, Int32 MenuTBOption)
        {
            return ICommandGroupinstance.ICommandGroupInstance.AddSpacer2(Position, MenuTBOption);
        }
        public static Boolean GetToolbarVisibility(ICommandGroupObject ICommandGroupinstance, Int32 SwContext)
        {
            return ICommandGroupinstance.ICommandGroupInstance.GetToolbarVisibility(SwContext);
        }
        public static Int32 NumberOfGroupItems(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.NumberOfGroupItems;
        }
        public static String LargeMainIcon(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.LargeMainIcon;
        }
        public static String SmallMainIcon(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.SmallMainIcon;
        }
        public static String LargeIconList(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.LargeIconList;
        }
        public static String SmallIconList(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.SmallIconList;
        }
        public static Int32 ShowInDocumentType(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.ShowInDocumentType;
        }
        public static Int32 SelectType(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.SelectType;
        }
        public static Int32 DockingState(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.DockingState;
        }
        public static String CustomNames(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.CustomNames;
        }
        public static Boolean HasToolbar(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.HasToolbar;
        }
        public static Boolean HasMenu(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.HasMenu;
        }
        public static String Name(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.Name;
        }
        public static Int32 ToolbarId(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.ToolbarId;
        }
        public static Int32 CommandID(ICommandGroupObject ICommandGroupinstance, int CommandIndex)
        {
            return ICommandGroupinstance.ICommandGroupInstance.CommandID[CommandIndex];
        }
        public static Int32 MenuPosition(ICommandGroupObject ICommandGroupinstance, int CommandIndex)
        {
            return ICommandGroupinstance.ICommandGroupInstance.MenuPosition[CommandIndex];
        }
        public static Boolean HasEnabledButton(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.HasEnabledButton;
        }
        public static Object IconList(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.IconList;
        }
        public static Object MainIconList(ICommandGroupObject ICommandGroupinstance)
        {
            return ICommandGroupinstance.ICommandGroupInstance.MainIconList;
        }
    }
}