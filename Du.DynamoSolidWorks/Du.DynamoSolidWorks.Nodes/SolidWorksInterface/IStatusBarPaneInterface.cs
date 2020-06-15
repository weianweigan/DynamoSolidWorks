using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IStatusBarPaneObject
    {
        public IStatusBarPane IStatusBarPaneInstance { get; set; }
        public IStatusBarPaneObject(IStatusBarPane IStatusBarPaneinstance)
        {
            IStatusBarPaneInstance = IStatusBarPaneinstance;
        }
    }
    public static class IStatusBarPaneInterface
    {
        public static Boolean Visible(IStatusBarPaneObject IStatusBarPaneinstance)
        {
            return IStatusBarPaneinstance.IStatusBarPaneInstance.Visible;
        }
        public static String Text(IStatusBarPaneObject IStatusBarPaneinstance)
        {
            return IStatusBarPaneinstance.IStatusBarPaneInstance.Text;
        }
    }
}