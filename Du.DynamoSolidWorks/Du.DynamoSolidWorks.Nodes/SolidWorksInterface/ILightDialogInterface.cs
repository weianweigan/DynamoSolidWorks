using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILightDialogObject
    {
        public ILightDialog ILightDialogInstance { get; set; }
        public ILightDialogObject(ILightDialog ILightDialoginstance)
        {
            ILightDialogInstance = ILightDialoginstance;
        }
    }
    public static class ILightDialogInterface
    {
        public static Boolean AddSubDialog(ILightDialogObject ILightDialoginstance, Int32 Page)
        {
            return ILightDialoginstance.ILightDialogInstance.AddSubDialog(Page);
        }
        public static Int32 GetLightId(ILightDialogObject ILightDialoginstance)
        {
            return ILightDialoginstance.ILightDialogInstance.GetLightId();
        }
    }
}