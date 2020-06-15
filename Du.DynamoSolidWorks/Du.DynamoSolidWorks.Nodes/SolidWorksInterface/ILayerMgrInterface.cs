using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILayerMgrObject
    {
        public ILayerMgr ILayerMgrInstance { get; set; }
        public ILayerMgrObject(ILayerMgr ILayerMgrinstance)
        {
            ILayerMgrInstance = ILayerMgrinstance;
        }
    }
    public static class ILayerMgrInterface
    {
        public static Int32 AddLayer(ILayerMgrObject ILayerMgrinstance, String NameIn, String DescIn, Int32 ColorIn, Int32 StyleIn, Int32 WidthIn)
        {
            return ILayerMgrinstance.ILayerMgrInstance.AddLayer(NameIn, DescIn, ColorIn, StyleIn, WidthIn);
        }
        public static Int32 SetCurrentLayer(ILayerMgrObject ILayerMgrinstance, String NameIn)
        {
            return ILayerMgrinstance.ILayerMgrInstance.SetCurrentLayer(NameIn);
        }
        public static String GetCurrentLayer(ILayerMgrObject ILayerMgrinstance)
        {
            return ILayerMgrinstance.ILayerMgrInstance.GetCurrentLayer();
        }
        public static Object GetLayer(ILayerMgrObject ILayerMgrinstance, String NameIn)
        {
            return ILayerMgrinstance.ILayerMgrInstance.GetLayer(NameIn);
        }
        public static ILayerObject IGetLayer(ILayerMgrObject ILayerMgrinstance, String NameIn)
        {
            return new ILayerObject(ILayerMgrinstance.ILayerMgrInstance.IGetLayer(NameIn));
        }
        public static Int32 GetCount(ILayerMgrObject ILayerMgrinstance)
        {
            return ILayerMgrinstance.ILayerMgrInstance.GetCount();
        }
        public static Object GetLayerList(ILayerMgrObject ILayerMgrinstance)
        {
            return ILayerMgrinstance.ILayerMgrInstance.GetLayerList();
        }
        public static String IGetLayerList(ILayerMgrObject ILayerMgrinstance)
        {
            return ILayerMgrinstance.ILayerMgrInstance.IGetLayerList();
        }
        public static Object GetLayerById(ILayerMgrObject ILayerMgrinstance, Int16 LayerId)
        {
            return ILayerMgrinstance.ILayerMgrInstance.GetLayerById(LayerId);
        }
        public static ILayerObject IGetLayerById(ILayerMgrObject ILayerMgrinstance, Int16 LayerId)
        {
            return new ILayerObject(ILayerMgrinstance.ILayerMgrInstance.IGetLayerById(LayerId));
        }
        public static Boolean DeleteLayer(ILayerMgrObject ILayerMgrinstance, String Name)
        {
            return ILayerMgrinstance.ILayerMgrInstance.DeleteLayer(Name);
        }
    }
}