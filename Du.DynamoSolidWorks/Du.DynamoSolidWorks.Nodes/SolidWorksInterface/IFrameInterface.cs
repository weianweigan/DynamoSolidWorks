using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFrameObject
    {
        public IFrame IFrameInstance { get; set; }
        public IFrameObject(IFrame IFrameinstance)
        {
            IFrameInstance = IFrameinstance;
        }
    }
    public static class IFrameInterface
    {
        public static Boolean AddMenuItem(IFrameObject IFrameinstance, String Menu, String Item, Int32 Position, String CallbackFcnAndModule)
        {
            return IFrameinstance.IFrameInstance.AddMenuItem(Menu, Item, Position, CallbackFcnAndModule);
        }
        public static Boolean AddMenu(IFrameObject IFrameinstance, String Menu, Int32 Position)
        {
            return IFrameinstance.IFrameInstance.AddMenu(Menu, Position);
        }
        public static void Dummy003(IFrameObject IFrameinstance)
        {
            IFrameinstance.IFrameInstance.Dummy003();
        }
        public static void Dummy004(IFrameObject IFrameinstance)
        {
            IFrameinstance.IFrameInstance.Dummy004();
        }
        public static Int32 GetMenuState(IFrameObject IFrameinstance, String MenuItemString)
        {
            return IFrameinstance.IFrameInstance.GetMenuState(MenuItemString);
        }
        public static void RenameMenu(IFrameObject IFrameinstance, String MenuItemString, String NewName)
        {
            IFrameinstance.IFrameInstance.RenameMenu(MenuItemString, NewName);
        }
        public static void RemoveMenu(IFrameObject IFrameinstance, String MenuItemString)
        {
            IFrameinstance.IFrameInstance.RemoveMenu(MenuItemString);
        }
        public static Boolean AddMenuPopupItem(IFrameObject IFrameinstance, Int32 DocType, Int32 SelectType, String Item, String CallbackFcnAndModule, String CustomNames, Int32 Unused)
        {
            return IFrameinstance.IFrameInstance.AddMenuPopupItem(DocType, SelectType, Item, CallbackFcnAndModule, CustomNames, Unused);
        }
        public static IStatusBarPaneObject GetStatusBarPane(IFrameObject IFrameinstance)
        {
            return new IStatusBarPaneObject(IFrameinstance.IFrameInstance.GetStatusBarPane());
        }
        public static void SetStatusBarText(IFrameObject IFrameinstance, String MessageString)
        {
            IFrameinstance.IFrameInstance.SetStatusBarText(MessageString);
        }
        public static Int32 GetHWnd(IFrameObject IFrameinstance)
        {
            return IFrameinstance.IFrameInstance.GetHWnd();
        }
        public static Int32 GetSubMenuCount(IFrameObject IFrameinstance, Int32 DocType, String FullMenuName)
        {
            return IFrameinstance.IFrameInstance.GetSubMenuCount(DocType, FullMenuName);
        }
        public static Object GetSubMenus(IFrameObject IFrameinstance, Int32 DocType, String FullMenuName)
        {
            return IFrameinstance.IFrameInstance.GetSubMenus(DocType, FullMenuName);
        }
        public static String IGetSubMenus(IFrameObject IFrameinstance, Int32 DocType, String FullMenuName, Int32 NumSubMenus)
        {
            return IFrameinstance.IFrameInstance.IGetSubMenus(DocType, FullMenuName, NumSubMenus);
        }
        public static Boolean AddMenuItem2(IFrameObject IFrameinstance, String Menu, String Item, Int32 Position, String CallbackFcnAndModule, String BitmapFileName)
        {
            return IFrameinstance.IFrameInstance.AddMenuItem2(Menu, Item, Position, CallbackFcnAndModule, BitmapFileName);
        }
        public static Int64 GetHWndx64(IFrameObject IFrameinstance)
        {
            return IFrameinstance.IFrameInstance.GetHWndx64();
        }
        public static Int32 GetModelWindowCount(IFrameObject IFrameinstance)
        {
            return IFrameinstance.IFrameInstance.GetModelWindowCount();
        }
        public static IModelWindowObject IGetModelWindows(IFrameObject IFrameinstance, Int32 ModelWindowCount)
        {
            return new IModelWindowObject(IFrameinstance.IFrameInstance.IGetModelWindows(ModelWindowCount));
        }
        public static void ShowModelWindow(IFrameObject IFrameinstance, IModelWindowObject LpModelWindow)
        {
            IFrameinstance.IFrameInstance.ShowModelWindow(LpModelWindow.IModelWindowInstance as ModelWindow);
        }
        public static Int32 GetMenu(IFrameObject IFrameinstance)
        {
            return IFrameinstance.IFrameInstance.GetMenu();
        }
        public static Int64 GetMenux64(IFrameObject IFrameinstance)
        {
            return IFrameinstance.IFrameInstance.GetMenux64();
        }
        public static Boolean AddMenuPopupItem2(IFrameObject IFrameinstance, Int32 DocType, Int32 SelectType, String Item, String CallbackFcnAndModule, String CustomNames, Int32 Unused, String BitmapFileName)
        {
            return IFrameinstance.IFrameInstance.AddMenuPopupItem2(DocType, SelectType, Item, CallbackFcnAndModule, CustomNames, Unused, BitmapFileName);
        }
        public static Boolean AddMenuPopupIcon(IFrameObject IFrameinstance, Int32 DocType, Int32 SelectType, String HintString, String CallbackFcnAndModule, String CustomNames, String BitmapFilePath)
        {
            return IFrameinstance.IFrameInstance.AddMenuPopupIcon(DocType, SelectType, HintString, CallbackFcnAndModule, CustomNames, BitmapFilePath);
        }
        public static Boolean RemoveMenuPopupIcon(IFrameObject IFrameinstance, Int32 Index, Int32 DocType, Int32 SelectType)
        {
            return IFrameinstance.IFrameInstance.RemoveMenuPopupIcon(Index, DocType, SelectType);
        }
        public static Boolean AddMenuPopupIcon2(IFrameObject IFrameinstance, Int32 DocType, Int32 SelectType, String HintString, Int32 Identifier, String CallbackFunction, String CallbackUpdateFunction, String CustomNames, String BitmapFilePath)
        {
            return IFrameinstance.IFrameInstance.AddMenuPopupIcon2(DocType, SelectType, HintString, Identifier, CallbackFunction, CallbackUpdateFunction, CustomNames, BitmapFilePath);
        }
        public static Boolean AddMenuPopupIcon3(IFrameObject IFrameinstance, Int32 DocType, Int32 SelectType, String HintString, Int32 Identifier, String CallbackFunction, String CallbackUpdateFunction, String CustomNames, Object ImageList)
        {
            return IFrameinstance.IFrameInstance.AddMenuPopupIcon3(DocType, SelectType, HintString, Identifier, CallbackFunction, CallbackUpdateFunction, CustomNames, ImageList);
        }
        public static Object ModelWindows(IFrameObject IFrameinstance)
        {
            return IFrameinstance.IFrameInstance.ModelWindows;
        }
        public static Boolean MenuPinned(IFrameObject IFrameinstance)
        {
            return IFrameinstance.IFrameInstance.MenuPinned;
        }
        public static Boolean KeepInvisible(IFrameObject IFrameinstance)
        {
            return IFrameinstance.IFrameInstance.KeepInvisible;
        }
    }
}