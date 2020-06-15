using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IModelViewManagerObject
    {
        public IModelViewManager IModelViewManagerInstance { get; set; }
        public IModelViewManagerObject(IModelViewManager IModelViewManagerinstance)
        {
            IModelViewManagerInstance = IModelViewManagerinstance;
        }
    }
    public static class IModelViewManagerInterface
    {
        public static Object AddControl(IModelViewManagerObject IModelViewManagerinstance, String Name, String ControlName, String BstrLicKey)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.AddControl(Name, ControlName, BstrLicKey);
        }
        public static Object GetControl(IModelViewManagerObject IModelViewManagerinstance, String Name)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.GetControl(Name);
        }
        public static Object IGetControl(IModelViewManagerObject IModelViewManagerinstance, String Name)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.IGetControl(Name);
        }
        public static Boolean DeleteControlTab(IModelViewManagerObject IModelViewManagerinstance, String Name)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.DeleteControlTab(Name);
        }
        public static Boolean ActivateControlTab(IModelViewManagerObject IModelViewManagerinstance, String Name)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.ActivateControlTab(Name);
        }
        public static Boolean ActivateModelTab(IModelViewManagerObject IModelViewManagerinstance)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.ActivateModelTab();
        }
        public static Boolean IsControlTabActive(IModelViewManagerObject IModelViewManagerinstance, String Name)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.IsControlTabActive(Name);
        }
        public static Boolean IsModelTabActive(IModelViewManagerObject IModelViewManagerinstance)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.IsModelTabActive();
        }
        public static IFeatMgrViewObject CreateFeatureMgrView(IModelViewManagerObject IModelViewManagerinstance, Object PPicture, String ToolTip, Int32 WhichPane)
        {
            return new IFeatMgrViewObject(IModelViewManagerinstance.IModelViewManagerInstance.CreateFeatureMgrView(PPicture, ToolTip, WhichPane));
        }
        public static IFeatMgrViewObject CreateFeatureMgrControl(IModelViewManagerObject IModelViewManagerinstance, Object PPicture, String Class, String LicKey, String ToolTip, Int32 WhichPane)
        {
            return new IFeatMgrViewObject(IModelViewManagerinstance.IModelViewManagerInstance.CreateFeatureMgrControl(PPicture, Class, LicKey, ToolTip, WhichPane));
        }
        public static IFeatMgrViewObject CreateFeatureMgrView2(IModelViewManagerObject IModelViewManagerinstance, String BitMapFile, String ToolTip, Int32 WhichPane)
        {
            return new IFeatMgrViewObject(IModelViewManagerinstance.IModelViewManagerInstance.CreateFeatureMgrView2(BitMapFile, ToolTip, WhichPane));
        }
        public static IFeatMgrViewObject CreateFeatureMgrControl2(IModelViewManagerObject IModelViewManagerinstance, String BitMapFile, String Class, String LicKey, String ToolTip, Int32 WhichPane)
        {
            return new IFeatMgrViewObject(IModelViewManagerinstance.IModelViewManagerInstance.CreateFeatureMgrControl2(BitMapFile, Class, LicKey, ToolTip, WhichPane));
        }
        public static Int32 GetFeatureMgrViewHWnd(IModelViewManagerObject IModelViewManagerinstance, Int32 FeatMgrViewPane)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.GetFeatureMgrViewHWnd(FeatMgrViewPane);
        }
        public static IManipulatorObject CreateManipulator(IModelViewManagerObject IModelViewManagerinstance, Int32 Type, Object PHandler)
        {
            return new IManipulatorObject(IModelViewManagerinstance.IModelViewManagerInstance.CreateManipulator(Type, PHandler));
        }
        public static Object AddControl2(IModelViewManagerObject IModelViewManagerinstance, String Name, String ControlName, String BstrLicKey)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.AddControl2(Name, ControlName, BstrLicKey);
        }
        public static IFeatMgrViewObject CreateFeatureMgrControl3(IModelViewManagerObject IModelViewManagerinstance, String BitMapFile, String Class, String LicKey, String ToolTip, Int32 WhichPane)
        {
            return new IFeatMgrViewObject(IModelViewManagerinstance.IModelViewManagerInstance.CreateFeatureMgrControl3(BitMapFile, Class, LicKey, ToolTip, WhichPane));
        }
        public static Int64 GetFeatureMgrViewHWndx64(IModelViewManagerObject IModelViewManagerinstance, Int32 FeatMgrViewPane)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.GetFeatureMgrViewHWndx64(FeatMgrViewPane);
        }
        public static Object AddControl3(IModelViewManagerObject IModelViewManagerinstance, String Name, String ControlName, String BstrLicKey, Boolean SplitWindow)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.AddControl3(Name, ControlName, BstrLicKey, SplitWindow);
        }
        public static Boolean CreateSectionView(IModelViewManagerObject IModelViewManagerinstance, ISectionViewDataObject SectionData)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.CreateSectionView(SectionData?.ISectionViewDataInstance?.CastObj<SectionViewData>());
        }
        public static Boolean RemoveSectionView(IModelViewManagerObject IModelViewManagerinstance)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.RemoveSectionView();
        }
        public static ISectionViewDataObject CreateSectionViewData(IModelViewManagerObject IModelViewManagerinstance)
        {
            return new ISectionViewDataObject(IModelViewManagerinstance.IModelViewManagerInstance.CreateSectionViewData());
        }
        public static ISectionViewDataObject GetSectionViewData(IModelViewManagerObject IModelViewManagerinstance, String ViewName)
        {
            return new ISectionViewDataObject(IModelViewManagerinstance.IModelViewManagerInstance.GetSectionViewData(ViewName));
        }
        public static Boolean DisplayWindowFromHandle(IModelViewManagerObject IModelViewManagerinstance, String Name, Int32 WindowHandle, Boolean SplitWindow)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.DisplayWindowFromHandle(Name, WindowHandle, SplitWindow);
        }
        public static Boolean DisplayWindowFromHandlex64(IModelViewManagerObject IModelViewManagerinstance, String Name, Int64 WindowHandle, Boolean SplitWindow)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.DisplayWindowFromHandlex64(Name, WindowHandle, SplitWindow);
        }
        public static IFeatMgrViewObject CreateFeatureMgrWindowFromHandle(IModelViewManagerObject IModelViewManagerinstance, String BitMapFile, Int32 WindowHandle, String ToolTip, Int32 WhichPane)
        {
            return new IFeatMgrViewObject(IModelViewManagerinstance.IModelViewManagerInstance.CreateFeatureMgrWindowFromHandle(BitMapFile, WindowHandle, ToolTip, WhichPane));
        }
        public static IFeatMgrViewObject CreateFeatureMgrWindowFromHandlex64(IModelViewManagerObject IModelViewManagerinstance, String BitMapFile, Int64 WindowHandle, String ToolTip, Int32 WhichPane)
        {
            return new IFeatMgrViewObject(IModelViewManagerinstance.IModelViewManagerInstance.CreateFeatureMgrWindowFromHandlex64(BitMapFile, WindowHandle, ToolTip, WhichPane));
        }
        public static ISnapShotObject AddSnapShot(IModelViewManagerObject IModelViewManagerinstance, String SnapShotName)
        {
            return new ISnapShotObject(IModelViewManagerinstance.IModelViewManagerInstance.AddSnapShot(SnapShotName));
        }
        public static ISnapShotObject GetSnapShot(IModelViewManagerObject IModelViewManagerinstance, String SnapShotName)
        {
            return new ISnapShotObject(IModelViewManagerinstance.IModelViewManagerInstance.GetSnapShot(SnapShotName));
        }
        public static Object GetSnapShots(IModelViewManagerObject IModelViewManagerinstance)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.GetSnapShots();
        }
        public static Boolean DeleteSnapShot(IModelViewManagerObject IModelViewManagerinstance, String SnapShotName)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.DeleteSnapShot(SnapShotName);
        }
        public static Object GetFeatureManagerTabs(IModelViewManagerObject IModelViewManagerinstance)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.GetFeatureManagerTabs();
        }
        public static Int32 GetConfigurationManagerTabIndex(IModelViewManagerObject IModelViewManagerinstance)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.GetConfigurationManagerTabIndex();
        }
        public static Int32 GetPropertyManagerTabIndex(IModelViewManagerObject IModelViewManagerinstance)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.GetPropertyManagerTabIndex();
        }
        public static Int32 GetDimXpertManagerTabIndex(IModelViewManagerObject IModelViewManagerinstance)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.GetDimXpertManagerTabIndex();
        }
        public static Int32 GetDisplayManagerTabIndex(IModelViewManagerObject IModelViewManagerinstance)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.GetDisplayManagerTabIndex();
        }
        public static Int32 GetFeatureManagerTreeTabIndex(IModelViewManagerObject IModelViewManagerinstance)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.GetFeatureManagerTreeTabIndex();
        }
        public static IModelDoc2Object Document(IModelViewManagerObject IModelViewManagerinstance)
        {
            return new IModelDoc2Object(IModelViewManagerinstance.IModelViewManagerInstance.Document);
        }
        public static Boolean LinkedViews(IModelViewManagerObject IModelViewManagerinstance)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.LinkedViews;
        }
        public static void Set_ViewportDisplay(IModelViewManagerObject IModelViewManagerinstance, int Setting)
        {
            IModelViewManagerinstance.IModelViewManagerInstance.ViewportDisplay = Setting;
        }
        public static Int32 ActiveFeatureManagerTabIndex(IModelViewManagerObject IModelViewManagerinstance)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.ActiveFeatureManagerTabIndex;
        }
        public static Boolean FeatureManagerTabsVisible(IModelViewManagerObject IModelViewManagerinstance)
        {
            return IModelViewManagerinstance.IModelViewManagerInstance.FeatureManagerTabsVisible;
        }
    }
}