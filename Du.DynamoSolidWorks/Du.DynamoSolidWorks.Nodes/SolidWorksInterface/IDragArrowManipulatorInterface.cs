using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDragArrowManipulatorObject
    {
        public IDragArrowManipulator IDragArrowManipulatorInstance { get; set; }
        public IDragArrowManipulatorObject(IDragArrowManipulator IDragArrowManipulatorinstance)
        {
            IDragArrowManipulatorInstance = IDragArrowManipulatorinstance;
        }
    }
    public static class IDragArrowManipulatorInterface
    {
        public static Boolean Update(IDragArrowManipulatorObject IDragArrowManipulatorinstance)
        {
            return IDragArrowManipulatorinstance.IDragArrowManipulatorInstance.Update();
        }
        public static IMathPointObject Origin(IDragArrowManipulatorObject IDragArrowManipulatorinstance)
        {
            return new IMathPointObject(IDragArrowManipulatorinstance.IDragArrowManipulatorInstance.Origin);
        }
        public static IMathVectorObject Direction(IDragArrowManipulatorObject IDragArrowManipulatorinstance)
        {
            return new IMathVectorObject(IDragArrowManipulatorinstance.IDragArrowManipulatorInstance.Direction);
        }
        public static Double Length(IDragArrowManipulatorObject IDragArrowManipulatorinstance)
        {
            return IDragArrowManipulatorinstance.IDragArrowManipulatorInstance.Length;
        }
        public static Double LengthOppositeDirection(IDragArrowManipulatorObject IDragArrowManipulatorinstance)
        {
            return IDragArrowManipulatorinstance.IDragArrowManipulatorInstance.LengthOppositeDirection;
        }
        public static Boolean ShowOppositeDirection(IDragArrowManipulatorObject IDragArrowManipulatorinstance)
        {
            return IDragArrowManipulatorinstance.IDragArrowManipulatorInstance.ShowOppositeDirection;
        }
        public static Boolean FixedLength(IDragArrowManipulatorObject IDragArrowManipulatorinstance)
        {
            return IDragArrowManipulatorinstance.IDragArrowManipulatorInstance.FixedLength;
        }
        public static Boolean ShowRuler(IDragArrowManipulatorObject IDragArrowManipulatorinstance)
        {
            return IDragArrowManipulatorinstance.IDragArrowManipulatorInstance.ShowRuler;
        }
        public static Boolean AllowFlip(IDragArrowManipulatorObject IDragArrowManipulatorinstance)
        {
            return IDragArrowManipulatorinstance.IDragArrowManipulatorInstance.AllowFlip;
        }
    }
}