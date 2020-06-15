using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IPlaneManipulatorObject
    {
        public IPlaneManipulator IPlaneManipulatorInstance { get; set; }
        public IPlaneManipulatorObject(IPlaneManipulator IPlaneManipulatorinstance)
        {
            IPlaneManipulatorInstance = IPlaneManipulatorinstance;
        }
    }
    public static class IPlaneManipulatorInterface
    {
        public static Boolean Update(IPlaneManipulatorObject IPlaneManipulatorinstance)
        {
            return IPlaneManipulatorinstance.IPlaneManipulatorInstance.Update();
        }
        public static IMathPointObject Origin(IPlaneManipulatorObject IPlaneManipulatorinstance)
        {
            return new IMathPointObject(IPlaneManipulatorinstance.IPlaneManipulatorInstance.Origin);
        }
        public static IMathVectorObject Normal(IPlaneManipulatorObject IPlaneManipulatorinstance)
        {
            return new IMathVectorObject(IPlaneManipulatorinstance.IPlaneManipulatorInstance.Normal);
        }
        public static Double Width(IPlaneManipulatorObject IPlaneManipulatorinstance)
        {
            return IPlaneManipulatorinstance.IPlaneManipulatorInstance.Width;
        }
        public static Double Height(IPlaneManipulatorObject IPlaneManipulatorinstance)
        {
            return IPlaneManipulatorinstance.IPlaneManipulatorInstance.Height;
        }
        public static Int32 Color(IPlaneManipulatorObject IPlaneManipulatorinstance)
        {
            return IPlaneManipulatorinstance.IPlaneManipulatorInstance.Color;
        }
        public static Double Distance(IPlaneManipulatorObject IPlaneManipulatorinstance)
        {
            return IPlaneManipulatorinstance.IPlaneManipulatorInstance.Distance;
        }
        public static Double XAngle(IPlaneManipulatorObject IPlaneManipulatorinstance)
        {
            return IPlaneManipulatorinstance.IPlaneManipulatorInstance.XAngle;
        }
        public static Double YAngle(IPlaneManipulatorObject IPlaneManipulatorinstance)
        {
            return IPlaneManipulatorinstance.IPlaneManipulatorInstance.YAngle;
        }
    }
}