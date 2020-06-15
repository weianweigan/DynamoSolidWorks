using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchSlotObject
    {
        public ISketchSlot ISketchSlotInstance { get; set; }
        public ISketchSlotObject(ISketchSlot ISketchSlotinstance)
        {
            ISketchSlotInstance = ISketchSlotinstance;
        }
    }
    public static class ISketchSlotInterface
    {
        public static IMathPointObject GetCenterPoint(ISketchSlotObject ISketchSlotinstance)
        {
            return new IMathPointObject(ISketchSlotinstance.ISketchSlotInstance.GetCenterPoint());
        }
        public static ISketchPointObject GetCenterPointHandle(ISketchSlotObject ISketchSlotinstance)
        {
            return new ISketchPointObject(ISketchSlotinstance.ISketchSlotInstance.GetCenterPointHandle());
        }
        public static Object GetSlotPoints(ISketchSlotObject ISketchSlotinstance)
        {
            return ISketchSlotinstance.ISketchSlotInstance.GetSlotPoints();
        }
        public static Int32 LengthType(ISketchSlotObject ISketchSlotinstance)
        {
            return ISketchSlotinstance.ISketchSlotInstance.LengthType;
        }
        public static Double Width(ISketchSlotObject ISketchSlotinstance)
        {
            return ISketchSlotinstance.ISketchSlotInstance.Width;
        }
        public static Double Length(ISketchSlotObject ISketchSlotinstance)
        {
            return ISketchSlotinstance.ISketchSlotInstance.Length;
        }
        public static Int32 CenterArcDirection(ISketchSlotObject ISketchSlotinstance)
        {
            return ISketchSlotinstance.ISketchSlotInstance.CenterArcDirection;
        }
        public static Int32 CreationType(ISketchSlotObject ISketchSlotinstance)
        {
            return ISketchSlotinstance.ISketchSlotInstance.CreationType;
        }
    }
}