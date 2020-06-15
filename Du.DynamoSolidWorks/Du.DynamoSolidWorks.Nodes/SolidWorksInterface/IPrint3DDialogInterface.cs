using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IPrint3DDialogObject
    {
        public IPrint3DDialog IPrint3DDialogInstance { get; set; }
        public IPrint3DDialogObject(IPrint3DDialog IPrint3DDialoginstance)
        {
            IPrint3DDialogInstance = IPrint3DDialoginstance;
        }
    }
    public static class IPrint3DDialogInterface
    {
        public static Boolean UpdateDialog(IPrint3DDialogObject IPrint3DDialoginstance)
        {
            return IPrint3DDialoginstance.IPrint3DDialogInstance.UpdateDialog();
        }
    }
}