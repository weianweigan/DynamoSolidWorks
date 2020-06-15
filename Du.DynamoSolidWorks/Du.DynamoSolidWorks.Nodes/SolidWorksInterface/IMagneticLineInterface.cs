using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMagneticLineObject
    {
        public IMagneticLine IMagneticLineInstance { get; set; }
        public IMagneticLineObject(IMagneticLine IMagneticLineinstance)
        {
            IMagneticLineInstance = IMagneticLineinstance;
        }
    }
    public static class IMagneticLineInterface
    {
        public static Object GetNotes(IMagneticLineObject IMagneticLineinstance)
        {
            return IMagneticLineinstance.IMagneticLineInstance.GetNotes();
        }
        public static Int32 GetNotesCount(IMagneticLineObject IMagneticLineinstance)
        {
            return IMagneticLineinstance.IMagneticLineInstance.GetNotesCount();
        }
        public static INoteObject IGetNotes(IMagneticLineObject IMagneticLineinstance, Int32 Count)
        {
            return new INoteObject(IMagneticLineinstance.IMagneticLineInstance.IGetNotes(Count));
        }
        public static Boolean AddNote(IMagneticLineObject IMagneticLineinstance, INoteObject Note, Double Position)
        {
            return IMagneticLineinstance.IMagneticLineInstance.AddNote(Note.INoteInstance as Note, Position);
        }
        public static Boolean RemoveNote(IMagneticLineObject IMagneticLineinstance, INoteObject Note, IMathPointObject Location)
        {
            return IMagneticLineinstance.IMagneticLineInstance.RemoveNote(Note.INoteInstance as Note, Location.IMathPointInstance as MathPoint);
        }
        public static Double Length(IMagneticLineObject IMagneticLineinstance)
        {
            return IMagneticLineinstance.IMagneticLineInstance.Length;
        }
        public static Double Angle(IMagneticLineObject IMagneticLineinstance)
        {
            return IMagneticLineinstance.IMagneticLineInstance.Angle;
        }
        public static Boolean EqualSpacing(IMagneticLineObject IMagneticLineinstance)
        {
            return IMagneticLineinstance.IMagneticLineInstance.EqualSpacing;
        }
        public static IMathPointObject StartPoint(IMagneticLineObject IMagneticLineinstance)
        {
            return new IMathPointObject(IMagneticLineinstance.IMagneticLineInstance.StartPoint);
        }
        public static IMathPointObject EndPoint(IMagneticLineObject IMagneticLineinstance)
        {
            return new IMathPointObject(IMagneticLineinstance.IMagneticLineInstance.EndPoint);
        }
    }
}