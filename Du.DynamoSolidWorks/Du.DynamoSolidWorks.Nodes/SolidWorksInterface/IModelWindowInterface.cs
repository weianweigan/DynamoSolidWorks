using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IModelWindowObject
    {
        public IModelWindow IModelWindowInstance { get; set; }
        public IModelWindowObject(IModelWindow IModelWindowinstance)
        {
            IModelWindowInstance = IModelWindowinstance;
        }
    }
    public static class IModelWindowInterface
    {
        public static void Activate(IModelWindowObject IModelWindowinstance)
        {
            IModelWindowinstance.IModelWindowInstance.Activate();
        }
        public static Int32 HWnd(IModelWindowObject IModelWindowinstance)
        {
            return IModelWindowinstance.IModelWindowInstance.HWnd;
        }
        public static String Title(IModelWindowObject IModelWindowinstance)
        {
            return IModelWindowinstance.IModelWindowInstance.Title;
        }
        public static IModelDoc2Object ModelDoc(IModelWindowObject IModelWindowinstance)
        {
            return new IModelDoc2Object(IModelWindowinstance.IModelWindowInstance.ModelDoc);
        }
        public static Int64 HWndx64(IModelWindowObject IModelWindowinstance)
        {
            return IModelWindowinstance.IModelWindowInstance.HWndx64;
        }
    }
}