using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchArcObject
    {
        public ISketchArc ISketchArcInstance { get; set; }
        public ISketchArcObject(ISketchArc ISketchArcinstance)
        {
            ISketchArcInstance = ISketchArcinstance;
        }
    }
    public static class ISketchArcInterface
    {
        public static Object GetStartPoint(ISketchArcObject ISketchArcinstance)
        {
            return ISketchArcinstance.ISketchArcInstance.GetStartPoint();
        }
        public static Double IGetStartPoint(ISketchArcObject ISketchArcinstance)
        {
            return ISketchArcinstance.ISketchArcInstance.IGetStartPoint();
        }
        public static Object GetEndPoint(ISketchArcObject ISketchArcinstance)
        {
            return ISketchArcinstance.ISketchArcInstance.GetEndPoint();
        }
        public static Double IGetEndPoint(ISketchArcObject ISketchArcinstance)
        {
            return ISketchArcinstance.ISketchArcInstance.IGetEndPoint();
        }
        public static Object GetCenterPoint(ISketchArcObject ISketchArcinstance)
        {
            return ISketchArcinstance.ISketchArcInstance.GetCenterPoint();
        }
        public static Double IGetCenterPoint(ISketchArcObject ISketchArcinstance)
        {
            return ISketchArcinstance.ISketchArcInstance.IGetCenterPoint();
        }
        public static Int32 IsCircle(ISketchArcObject ISketchArcinstance)
        {
            return ISketchArcinstance.ISketchArcInstance.IsCircle();
        }
        public static Int32 GetRotationDir(ISketchArcObject ISketchArcinstance)
        {
            return ISketchArcinstance.ISketchArcInstance.GetRotationDir();
        }
        public static Object GetStartPoint2(ISketchArcObject ISketchArcinstance)
        {
            return ISketchArcinstance.ISketchArcInstance.GetStartPoint2();
        }
        public static ISketchPointObject IGetStartPoint2(ISketchArcObject ISketchArcinstance)
        {
            return new ISketchPointObject(ISketchArcinstance.ISketchArcInstance.IGetStartPoint2());
        }
        public static Object GetEndPoint2(ISketchArcObject ISketchArcinstance)
        {
            return ISketchArcinstance.ISketchArcInstance.GetEndPoint2();
        }
        public static ISketchPointObject IGetEndPoint2(ISketchArcObject ISketchArcinstance)
        {
            return new ISketchPointObject(ISketchArcinstance.ISketchArcInstance.IGetEndPoint2());
        }
        public static Object GetCenterPoint2(ISketchArcObject ISketchArcinstance)
        {
            return ISketchArcinstance.ISketchArcInstance.GetCenterPoint2();
        }
        public static ISketchPointObject IGetCenterPoint2(ISketchArcObject ISketchArcinstance)
        {
            return new ISketchPointObject(ISketchArcinstance.ISketchArcInstance.IGetCenterPoint2());
        }
        public static Double GetRadius(ISketchArcObject ISketchArcinstance)
        {
            return ISketchArcinstance.ISketchArcInstance.GetRadius();
        }
        public static Boolean SetRadius(ISketchArcObject ISketchArcinstance, Double Radius)
        {
            return ISketchArcinstance.ISketchArcInstance.SetRadius(Radius);
        }
        public static Object GetNormalVector(ISketchArcObject ISketchArcinstance)
        {
            return ISketchArcinstance.ISketchArcInstance.GetNormalVector();
        }
        public static Double IGetNormalVector(ISketchArcObject ISketchArcinstance)
        {
            return ISketchArcinstance.ISketchArcInstance.IGetNormalVector();
        }
    }
}