using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchParabolaObject
    {
        public ISketchParabola ISketchParabolaInstance { get; set; }
        public ISketchParabolaObject(ISketchParabola ISketchParabolainstance)
        {
            ISketchParabolaInstance = ISketchParabolainstance;
        }
    }
    public static class ISketchParabolaInterface
    {
        public static Object GetStartPoint(ISketchParabolaObject ISketchParabolainstance)
        {
            return ISketchParabolainstance.ISketchParabolaInstance.GetStartPoint();
        }
        public static Double IGetStartPoint(ISketchParabolaObject ISketchParabolainstance)
        {
            return ISketchParabolainstance.ISketchParabolaInstance.IGetStartPoint();
        }
        public static Object GetEndPoint(ISketchParabolaObject ISketchParabolainstance)
        {
            return ISketchParabolainstance.ISketchParabolaInstance.GetEndPoint();
        }
        public static Double IGetEndPoint(ISketchParabolaObject ISketchParabolainstance)
        {
            return ISketchParabolainstance.ISketchParabolaInstance.IGetEndPoint();
        }
        public static Object GetFocalPoint(ISketchParabolaObject ISketchParabolainstance)
        {
            return ISketchParabolainstance.ISketchParabolaInstance.GetFocalPoint();
        }
        public static Double IGetFocalPoint(ISketchParabolaObject ISketchParabolainstance)
        {
            return ISketchParabolainstance.ISketchParabolaInstance.IGetFocalPoint();
        }
        public static Object GetApexPoint(ISketchParabolaObject ISketchParabolainstance)
        {
            return ISketchParabolainstance.ISketchParabolaInstance.GetApexPoint();
        }
        public static Double IGetApexPoint(ISketchParabolaObject ISketchParabolainstance)
        {
            return ISketchParabolainstance.ISketchParabolaInstance.IGetApexPoint();
        }
        public static Object GetStartPoint2(ISketchParabolaObject ISketchParabolainstance)
        {
            return ISketchParabolainstance.ISketchParabolaInstance.GetStartPoint2();
        }
        public static ISketchPointObject IGetStartPoint2(ISketchParabolaObject ISketchParabolainstance)
        {
            return new ISketchPointObject(ISketchParabolainstance.ISketchParabolaInstance.IGetStartPoint2());
        }
        public static Object GetEndPoint2(ISketchParabolaObject ISketchParabolainstance)
        {
            return ISketchParabolainstance.ISketchParabolaInstance.GetEndPoint2();
        }
        public static ISketchPointObject IGetEndPoint2(ISketchParabolaObject ISketchParabolainstance)
        {
            return new ISketchPointObject(ISketchParabolainstance.ISketchParabolaInstance.IGetEndPoint2());
        }
        public static Object GetFocalPoint2(ISketchParabolaObject ISketchParabolainstance)
        {
            return ISketchParabolainstance.ISketchParabolaInstance.GetFocalPoint2();
        }
        public static ISketchPointObject IGetFocalPoint2(ISketchParabolaObject ISketchParabolainstance)
        {
            return new ISketchPointObject(ISketchParabolainstance.ISketchParabolaInstance.IGetFocalPoint2());
        }
        public static Object GetApexPoint2(ISketchParabolaObject ISketchParabolainstance)
        {
            return ISketchParabolainstance.ISketchParabolaInstance.GetApexPoint2();
        }
        public static ISketchPointObject IGetApexPoint2(ISketchParabolaObject ISketchParabolainstance)
        {
            return new ISketchPointObject(ISketchParabolainstance.ISketchParabolaInstance.IGetApexPoint2());
        }
        public static Boolean SetPoints(ISketchParabolaObject ISketchParabolainstance, Double CenterX, Double CenterY, Double CenterZ, Double ApexX, Double ApexY, Double ApexZ, Double StartX, Double StartY, Double StartZ, Double EndX, Double EndY, Double EndZ)
        {
            return ISketchParabolainstance.ISketchParabolaInstance.SetPoints(CenterX, CenterY, CenterZ, ApexX, ApexY, ApexZ, StartX, StartY, StartZ, EndX, EndY, EndZ);
        }
    }
}