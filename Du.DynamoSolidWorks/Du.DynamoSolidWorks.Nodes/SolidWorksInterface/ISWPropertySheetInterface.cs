using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISWPropertySheetObject
    {
        public ISWPropertySheet ISWPropertySheetInstance { get; set; }
        public ISWPropertySheetObject(ISWPropertySheet ISWPropertySheetinstance)
        {
            ISWPropertySheetInstance = ISWPropertySheetinstance;
        }
    }
    public static class ISWPropertySheetInterface
    {
        public static Int32 AddPage(ISWPropertySheetObject ISWPropertySheetinstance, Int32 Page)
        {
            return ISWPropertySheetinstance.ISWPropertySheetInstance.AddPage(Page);
        }
        public static Int32 RemovePage(ISWPropertySheetObject ISWPropertySheetinstance, Int32 Page)
        {
            return ISWPropertySheetinstance.ISWPropertySheetInstance.RemovePage(Page);
        }
        public static Int32 AddActivePage(ISWPropertySheetObject ISWPropertySheetinstance, String Title, String ProgId, String LicenseKey)
        {
            return ISWPropertySheetinstance.ISWPropertySheetInstance.AddActivePage(Title, ProgId, LicenseKey);
        }
        public static Object GetControl(ISWPropertySheetObject ISWPropertySheetinstance, Int32 PageIndex)
        {
            return ISWPropertySheetinstance.ISWPropertySheetInstance.GetControl(PageIndex);
        }
        public static Int32 AddPagex64(ISWPropertySheetObject ISWPropertySheetinstance, Int64 Page)
        {
            return ISWPropertySheetinstance.ISWPropertySheetInstance.AddPagex64(Page);
        }
    }
}