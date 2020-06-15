using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchLineObject
    {
        public ISketchLine ISketchLineInstance { get; set; }
        public ISketchLineObject(ISketchLine ISketchLineinstance)
        {
            ISketchLineInstance = ISketchLineinstance;
        }
    }
    public static class ISketchLineInterface
    {
        public static Object GetStartPoint(ISketchLineObject ISketchLineinstance)
        {
            return ISketchLineinstance.ISketchLineInstance.GetStartPoint();
        }
        public static Double IGetStartPoint(ISketchLineObject ISketchLineinstance)
        {
            return ISketchLineinstance.ISketchLineInstance.IGetStartPoint();
        }
        public static Object GetEndPoint(ISketchLineObject ISketchLineinstance)
        {
            return ISketchLineinstance.ISketchLineInstance.GetEndPoint();
        }
        public static Double IGetEndPoint(ISketchLineObject ISketchLineinstance)
        {
            return ISketchLineinstance.ISketchLineInstance.IGetEndPoint();
        }
        public static Object GetStartPoint2(ISketchLineObject ISketchLineinstance)
        {
            return ISketchLineinstance.ISketchLineInstance.GetStartPoint2();
        }
        public static ISketchPointObject IGetStartPoint2(ISketchLineObject ISketchLineinstance)
        {
            return new ISketchPointObject(ISketchLineinstance.ISketchLineInstance.IGetStartPoint2());
        }
        public static Object GetEndPoint2(ISketchLineObject ISketchLineinstance)
        {
            return ISketchLineinstance.ISketchLineInstance.GetEndPoint2();
        }
        public static ISketchPointObject IGetEndPoint2(ISketchLineObject ISketchLineinstance)
        {
            return new ISketchPointObject(ISketchLineinstance.ISketchLineInstance.IGetEndPoint2());
        }
        public static Boolean MakeInfinite(ISketchLineObject ISketchLineinstance)
        {
            return ISketchLineinstance.ISketchLineInstance.MakeInfinite();
        }
        public static Int32 GetBendLineDirection(ISketchLineObject ISketchLineinstance)
        {
            return ISketchLineinstance.ISketchLineInstance.GetBendLineDirection();
        }
        public static Boolean Infinite(ISketchLineObject ISketchLineinstance)
        {
            return ISketchLineinstance.ISketchLineInstance.Infinite;
        }
        public static Double Angle(ISketchLineObject ISketchLineinstance)
        {
            return ISketchLineinstance.ISketchLineInstance.Angle;
        }
    }
}