using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISpringObject
    {
        public ISpring ISpringInstance { get; set; }
        public ISpringObject(ISpring ISpringinstance)
        {
            ISpringInstance = ISpringinstance;
        }
    }
    public static class ISpringInterface
    {
        public static IBody2Object GetSpringBody(ISpringObject ISpringinstance)
        {
            return new IBody2Object(ISpringinstance.ISpringInstance.GetSpringBody());
        }
        public static Object GetProfilePoints(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.GetProfilePoints();
        }
        public static Int32 SpringType(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.SpringType;
        }
        public static Double Revolution(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.Revolution;
        }
        public static Double StartingEndLength(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.StartingEndLength;
        }
        public static Double EndingEndLength(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.EndingEndLength;
        }
        public static Double StartingRevolution(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.StartingRevolution;
        }
        public static Double EndingRevolution(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.EndingRevolution;
        }
        public static Double StartingPitch(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.StartingPitch;
        }
        public static Double EndingPitch(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.EndingPitch;
        }
        public static Double Tolerance(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.Tolerance;
        }
        public static Double Pitch(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.Pitch;
        }
        public static Int32 ProfileType(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.ProfileType;
        }
        public static Object ProfileParameters(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.ProfileParameters;
        }
        public static Int32 StartingEndType(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.StartingEndType;
        }
        public static Int32 EndingEndType(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.EndingEndType;
        }
        public static Boolean Clockwise(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.Clockwise;
        }
        public static Boolean ReverseDirection(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.ReverseDirection;
        }
        public static Int32 GroundType(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.GroundType;
        }
        public static IBody2Object BaseProfile(ISpringObject ISpringinstance)
        {
            return new IBody2Object(ISpringinstance.ISpringInstance.BaseProfile);
        }
        public static IBody2Object SectionProfile(ISpringObject ISpringinstance)
        {
            return new IBody2Object(ISpringinstance.ISpringInstance.SectionProfile);
        }
        public static Double TaperAngle(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.TaperAngle;
        }
        public static Boolean TaperOutward(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.TaperOutward;
        }
        public static IMathPointObject SectionProfileCenter(ISpringObject ISpringinstance)
        {
            return new IMathPointObject(ISpringinstance.ISpringInstance.SectionProfileCenter);
        }
        public static Double Height(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.Height;
        }
        public static Int32 DefineType(ISpringObject ISpringinstance)
        {
            return ISpringinstance.ISpringInstance.DefineType;
        }
    }
}