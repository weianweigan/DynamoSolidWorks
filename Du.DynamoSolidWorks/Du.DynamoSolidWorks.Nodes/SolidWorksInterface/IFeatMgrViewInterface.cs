using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFeatMgrViewObject
    {
        public IFeatMgrView IFeatMgrViewInstance { get; set; }
        public IFeatMgrViewObject(IFeatMgrView IFeatMgrViewinstance)
        {
            IFeatMgrViewInstance = IFeatMgrViewinstance;
        }
    }
    public static class IFeatMgrViewInterface
    {
        public static Int32 GetFeatMgrViewWnd(IFeatMgrViewObject IFeatMgrViewinstance)
        {
            return IFeatMgrViewinstance.IFeatMgrViewInstance.GetFeatMgrViewWnd();
        }
        public static Object GetControl(IFeatMgrViewObject IFeatMgrViewinstance)
        {
            return IFeatMgrViewinstance.IFeatMgrViewInstance.GetControl();
        }
        public static Object IGetControl(IFeatMgrViewObject IFeatMgrViewinstance)
        {
            return IFeatMgrViewinstance.IFeatMgrViewInstance.IGetControl();
        }
        public static Int32 ActivateView(IFeatMgrViewObject IFeatMgrViewinstance)
        {
            return IFeatMgrViewinstance.IFeatMgrViewInstance.ActivateView();
        }
        public static Boolean DeActivateView(IFeatMgrViewObject IFeatMgrViewinstance)
        {
            return IFeatMgrViewinstance.IFeatMgrViewInstance.DeActivateView();
        }
        public static Boolean DeleteView(IFeatMgrViewObject IFeatMgrViewinstance)
        {
            return IFeatMgrViewinstance.IFeatMgrViewInstance.DeleteView();
        }
        public static Int64 GetFeatMgrViewWndx64(IFeatMgrViewObject IFeatMgrViewinstance)
        {
            return IFeatMgrViewinstance.IFeatMgrViewInstance.GetFeatMgrViewWndx64();
        }
    }
}