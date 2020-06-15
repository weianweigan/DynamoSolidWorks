using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchEllipseObject
    {
        public ISketchEllipse ISketchEllipseInstance { get; set; }
        public ISketchEllipseObject(ISketchEllipse ISketchEllipseinstance)
        {
            ISketchEllipseInstance = ISketchEllipseinstance;
        }
    }
    public static class ISketchEllipseInterface
    {
        public static Object GetStartPoint(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.GetStartPoint();
        }
        public static Double IGetStartPoint(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.IGetStartPoint();
        }
        public static Object GetEndPoint(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.GetEndPoint();
        }
        public static Double IGetEndPoint(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.IGetEndPoint();
        }
        public static Object GetCenterPoint(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.GetCenterPoint();
        }
        public static Double IGetCenterPoint(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.IGetCenterPoint();
        }
        public static Object GetMajorPoint(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.GetMajorPoint();
        }
        public static Double IGetMajorPoint(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.IGetMajorPoint();
        }
        public static Object GetMinorPoint(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.GetMinorPoint();
        }
        public static Double IGetMinorPoint(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.IGetMinorPoint();
        }
        public static Object GetStartPoint2(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.GetStartPoint2();
        }
        public static ISketchPointObject IGetStartPoint2(ISketchEllipseObject ISketchEllipseinstance)
        {
            return new ISketchPointObject(ISketchEllipseinstance.ISketchEllipseInstance.IGetStartPoint2());
        }
        public static Object GetEndPoint2(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.GetEndPoint2();
        }
        public static ISketchPointObject IGetEndPoint2(ISketchEllipseObject ISketchEllipseinstance)
        {
            return new ISketchPointObject(ISketchEllipseinstance.ISketchEllipseInstance.IGetEndPoint2());
        }
        public static Object GetCenterPoint2(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.GetCenterPoint2();
        }
        public static ISketchPointObject IGetCenterPoint2(ISketchEllipseObject ISketchEllipseinstance)
        {
            return new ISketchPointObject(ISketchEllipseinstance.ISketchEllipseInstance.IGetCenterPoint2());
        }
        public static Object GetMajorPoint2(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.GetMajorPoint2();
        }
        public static ISketchPointObject IGetMajorPoint2(ISketchEllipseObject ISketchEllipseinstance)
        {
            return new ISketchPointObject(ISketchEllipseinstance.ISketchEllipseInstance.IGetMajorPoint2());
        }
        public static Object GetMinorPoint2(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.GetMinorPoint2();
        }
        public static ISketchPointObject IGetMinorPoint2(ISketchEllipseObject ISketchEllipseinstance)
        {
            return new ISketchPointObject(ISketchEllipseinstance.ISketchEllipseInstance.IGetMinorPoint2());
        }
        public static Int32 GetRotationDir(ISketchEllipseObject ISketchEllipseinstance)
        {
            return ISketchEllipseinstance.ISketchEllipseInstance.GetRotationDir();
        }
    }
}