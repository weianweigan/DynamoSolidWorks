using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMouseObject
    {
        public IMouse IMouseInstance { get; set; }
        public IMouseObject(IMouse IMouseinstance)
        {
            IMouseInstance = IMouseinstance;
        }
    }
    public static class IMouseInterface
    {
        public static Boolean Move(IMouseObject IMouseinstance, Int32 X, Int32 Y, Int32 Flags)
        {
            return IMouseinstance.IMouseInstance.Move(X, Y, Flags);
        }
        public static Boolean MoveXYZ(IMouseObject IMouseinstance, Double X, Double Y, Double Z, Int32 Flags)
        {
            return IMouseinstance.IMouseInstance.MoveXYZ(X, Y, Z, Flags);
        }
        public static Boolean MouseWheelXYZ(IMouseObject IMouseinstance, Double X, Double Y, Double Z, Int32 Clicks, Int32 Flags)
        {
            return IMouseinstance.IMouseInstance.MouseWheelXYZ(X, Y, Z, Clicks, Flags);
        }
    }
}