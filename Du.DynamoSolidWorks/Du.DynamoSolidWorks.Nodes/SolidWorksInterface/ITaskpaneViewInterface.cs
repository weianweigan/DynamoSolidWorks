using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ITaskpaneViewObject
    {
        public ITaskpaneView ITaskpaneViewInstance { get; set; }
        public ITaskpaneViewObject(ITaskpaneView ITaskpaneViewinstance)
        {
            ITaskpaneViewInstance = ITaskpaneViewinstance;
        }
    }
    public static class ITaskpaneViewInterface
    {
        public static Int32 GetTaskpaneViewWnd(ITaskpaneViewObject ITaskpaneViewinstance)
        {
            return ITaskpaneViewinstance.ITaskpaneViewInstance.GetTaskpaneViewWnd();
        }
        public static Object GetControl(ITaskpaneViewObject ITaskpaneViewinstance)
        {
            return ITaskpaneViewinstance.ITaskpaneViewInstance.GetControl();
        }
        public static Object IGetControl(ITaskpaneViewObject ITaskpaneViewinstance)
        {
            return ITaskpaneViewinstance.ITaskpaneViewInstance.IGetControl();
        }
        public static Object AddControl(ITaskpaneViewObject ITaskpaneViewinstance, String ClassName, String LicKey)
        {
            return ITaskpaneViewinstance.ITaskpaneViewInstance.AddControl(ClassName, LicKey);
        }
        public static Boolean ShowView(ITaskpaneViewObject ITaskpaneViewinstance)
        {
            return ITaskpaneViewinstance.ITaskpaneViewInstance.ShowView();
        }
        public static Boolean HideView(ITaskpaneViewObject ITaskpaneViewinstance)
        {
            return ITaskpaneViewinstance.ITaskpaneViewInstance.HideView();
        }
        public static Boolean DeleteView(ITaskpaneViewObject ITaskpaneViewinstance)
        {
            return ITaskpaneViewinstance.ITaskpaneViewInstance.DeleteView();
        }
        public static Boolean AddCustomButton(ITaskpaneViewObject ITaskpaneViewinstance, String BitmapPath, String ToolTip)
        {
            return ITaskpaneViewinstance.ITaskpaneViewInstance.AddCustomButton(BitmapPath, ToolTip);
        }
        public static Boolean AddStandardButton(ITaskpaneViewObject ITaskpaneViewinstance, Int32 BitmapOption, String ToolTip)
        {
            return ITaskpaneViewinstance.ITaskpaneViewInstance.AddStandardButton(BitmapOption, ToolTip);
        }
        public static Boolean GetButtonState(ITaskpaneViewObject ITaskpaneViewinstance, Int32 ButtonIndex)
        {
            return ITaskpaneViewinstance.ITaskpaneViewInstance.GetButtonState(ButtonIndex);
        }
        public static void SetButtonState(ITaskpaneViewObject ITaskpaneViewinstance, Int32 ButtonIndex, Boolean Enable)
        {
            ITaskpaneViewinstance.ITaskpaneViewInstance.SetButtonState(ButtonIndex, Enable);
        }
        public static Boolean DisplayWindowFromHandle(ITaskpaneViewObject ITaskpaneViewinstance, Int32 WindowHandle)
        {
            return ITaskpaneViewinstance.ITaskpaneViewInstance.DisplayWindowFromHandle(WindowHandle);
        }
        public static Boolean DisplayWindowFromHandlex64(ITaskpaneViewObject ITaskpaneViewinstance, Int64 WindowHandle)
        {
            return ITaskpaneViewinstance.ITaskpaneViewInstance.DisplayWindowFromHandlex64(WindowHandle);
        }
        public static Boolean AddCustomButton2(ITaskpaneViewObject ITaskpaneViewinstance, Object ImageList, String ToolTip)
        {
            return ITaskpaneViewinstance.ITaskpaneViewInstance.AddCustomButton2(ImageList, ToolTip);
        }
    }
}