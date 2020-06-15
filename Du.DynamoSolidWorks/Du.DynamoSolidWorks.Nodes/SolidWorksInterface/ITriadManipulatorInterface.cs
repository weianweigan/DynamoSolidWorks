using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ITriadManipulatorObject
    {
        public ITriadManipulator ITriadManipulatorInstance { get; set; }
        public ITriadManipulatorObject(ITriadManipulator ITriadManipulatorinstance)
        {
            ITriadManipulatorInstance = ITriadManipulatorinstance;
        }
    }
    public static class ITriadManipulatorInterface
    {
        public static void UpdateScale(ITriadManipulatorObject ITriadManipulatorinstance, Double Scale)
        {
            ITriadManipulatorinstance.ITriadManipulatorInstance.UpdateScale(Scale);
        }
        public static Boolean UpdatePosition(ITriadManipulatorObject ITriadManipulatorinstance)
        {
            return ITriadManipulatorinstance.ITriadManipulatorInstance.UpdatePosition();
        }
        public static void SetColorRefAtIndex(ITriadManipulatorObject ITriadManipulatorinstance, Int32 Index, Int32 ColorRef)
        {
            ITriadManipulatorinstance.ITriadManipulatorInstance.SetColorRefAtIndex(Index, ColorRef);
        }
        public static Int32 DoNotShow(ITriadManipulatorObject ITriadManipulatorinstance)
        {
            return ITriadManipulatorinstance.ITriadManipulatorInstance.DoNotShow;
        }
        public static IMathPointObject Origin(ITriadManipulatorObject ITriadManipulatorinstance)
        {
            return new IMathPointObject(ITriadManipulatorinstance.ITriadManipulatorInstance.Origin);
        }
        public static IMathVectorObject XAxis(ITriadManipulatorObject ITriadManipulatorinstance)
        {
            return new IMathVectorObject(ITriadManipulatorinstance.ITriadManipulatorInstance.XAxis);
        }
        public static IMathVectorObject YAxis(ITriadManipulatorObject ITriadManipulatorinstance)
        {
            return new IMathVectorObject(ITriadManipulatorinstance.ITriadManipulatorInstance.YAxis);
        }
        public static IMathVectorObject ZAxis(ITriadManipulatorObject ITriadManipulatorinstance)
        {
            return new IMathVectorObject(ITriadManipulatorinstance.ITriadManipulatorInstance.ZAxis);
        }
        public static void SetCursor(ITriadManipulatorObject ITriadManipulatorinstance, int Cursor)
        {
            ITriadManipulatorinstance.ITriadManipulatorInstance.Cursor = Cursor;
        }
        public static IMathPointObject PreviousDragPoint(ITriadManipulatorObject ITriadManipulatorinstance)
        {
            return new IMathPointObject(ITriadManipulatorinstance.ITriadManipulatorInstance.PreviousDragPoint);
        }
    }
}