using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRefPlaneObject
    {
        public IRefPlane IRefPlaneInstance { get; set; }
        public IRefPlaneObject(IRefPlane IRefPlaneinstance)
        {
            IRefPlaneInstance = IRefPlaneinstance;
        }
    }
    public static class IRefPlaneInterface
    {
        public static Object GetRefPlaneParams(IRefPlaneObject IRefPlaneinstance)
        {
            return IRefPlaneinstance.IRefPlaneInstance.GetRefPlaneParams();
        }
        public static Double IGetRefPlaneParams(IRefPlaneObject IRefPlaneinstance)
        {
            return IRefPlaneinstance.IRefPlaneInstance.IGetRefPlaneParams();
        }
        public static IMathPointObject IGetBoundingBox(IRefPlaneObject IRefPlaneinstance)
        {
            return new IMathPointObject(IRefPlaneinstance.IRefPlaneInstance.IGetBoundingBox());
        }
        public static IMathPointObject IGetCornerPoints(IRefPlaneObject IRefPlaneinstance)
        {
            return new IMathPointObject(IRefPlaneinstance.IRefPlaneInstance.IGetCornerPoints());
        }
        public static IMathTransformObject Transform(IRefPlaneObject IRefPlaneinstance)
        {
            return new IMathTransformObject(IRefPlaneinstance.IRefPlaneInstance.Transform);
        }
        public static Object BoundingBox(IRefPlaneObject IRefPlaneinstance)
        {
            return IRefPlaneinstance.IRefPlaneInstance.BoundingBox;
        }
        public static Object CornerPoints(IRefPlaneObject IRefPlaneinstance)
        {
            return IRefPlaneinstance.IRefPlaneInstance.CornerPoints;
        }
    }
}