using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILayerObject
    {
        public ILayer ILayerInstance { get; set; }
        public ILayerObject(ILayer ILayerinstance)
        {
            ILayerInstance = ILayerinstance;
        }
    }
    public static class ILayerInterface
    {
        public static Int32 GetID(ILayerObject ILayerinstance)
        {
            return ILayerinstance.ILayerInstance.GetID();
        }
        public static Object GetItems(ILayerObject ILayerinstance, Int32 ItemType)
        {
            return ILayerinstance.ILayerInstance.GetItems(ItemType);
        }
        public static String Name(ILayerObject ILayerinstance)
        {
            return ILayerinstance.ILayerInstance.Name;
        }
        public static Int32 Color(ILayerObject ILayerinstance)
        {
            return ILayerinstance.ILayerInstance.Color;
        }
        public static Int32 Style(ILayerObject ILayerinstance)
        {
            return ILayerinstance.ILayerInstance.Style;
        }
        public static Int32 Width(ILayerObject ILayerinstance)
        {
            return ILayerinstance.ILayerInstance.Width;
        }
        public static Boolean Visible(ILayerObject ILayerinstance)
        {
            return ILayerinstance.ILayerInstance.Visible;
        }
        public static String Description(ILayerObject ILayerinstance)
        {
            return ILayerinstance.ILayerInstance.Description;
        }
        public static Boolean Printable(ILayerObject ILayerinstance)
        {
            return ILayerinstance.ILayerInstance.Printable;
        }
    }
}