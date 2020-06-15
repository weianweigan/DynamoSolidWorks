using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRevisionCloudObject
    {
        public IRevisionCloud IRevisionCloudInstance { get; set; }
        public IRevisionCloudObject(IRevisionCloud IRevisionCloudinstance)
        {
            IRevisionCloudInstance = IRevisionCloudinstance;
        }
    }
    public static class IRevisionCloudInterface
    {
        public static Object GetNext(IRevisionCloudObject IRevisionCloudinstance)
        {
            return IRevisionCloudinstance.IRevisionCloudInstance.GetNext();
        }
        public static IRevisionCloudObject IGetNext(IRevisionCloudObject IRevisionCloudinstance)
        {
            return new IRevisionCloudObject(IRevisionCloudinstance.IRevisionCloudInstance.IGetNext());
        }
        public static Object GetAnnotation(IRevisionCloudObject IRevisionCloudinstance)
        {
            return IRevisionCloudinstance.IRevisionCloudInstance.GetAnnotation();
        }
        public static IAnnotationObject IGetAnnotation(IRevisionCloudObject IRevisionCloudinstance)
        {
            return new IAnnotationObject(IRevisionCloudinstance.IRevisionCloudInstance.IGetAnnotation());
        }
        public static Int32 GetPathPointCount(IRevisionCloudObject IRevisionCloudinstance)
        {
            return IRevisionCloudinstance.IRevisionCloudInstance.GetPathPointCount();
        }
        public static Object GetPathPointAtIndex(IRevisionCloudObject IRevisionCloudinstance, Int32 Index)
        {
            return IRevisionCloudinstance.IRevisionCloudInstance.GetPathPointAtIndex(Index);
        }
        public static Double IGetPathPointAtIndex(IRevisionCloudObject IRevisionCloudinstance, Int32 Index)
        {
            return IRevisionCloudinstance.IRevisionCloudInstance.IGetPathPointAtIndex(Index);
        }
        public static Boolean SetPathPointAtIndex(IRevisionCloudObject IRevisionCloudinstance, Int32 Index, Double X, Double Y, Double Z)
        {
            return IRevisionCloudinstance.IRevisionCloudInstance.SetPathPointAtIndex(Index, X, Y, Z);
        }
        public static Boolean Finalize(IRevisionCloudObject IRevisionCloudinstance)
        {
            return IRevisionCloudinstance.IRevisionCloudInstance.Finalize();
        }
        public static Int32 Shape(IRevisionCloudObject IRevisionCloudinstance)
        {
            return IRevisionCloudinstance.IRevisionCloudInstance.Shape;
        }
        public static Double ArcRadius(IRevisionCloudObject IRevisionCloudinstance)
        {
            return IRevisionCloudinstance.IRevisionCloudInstance.ArcRadius;
        }
        public static Double Angle(IRevisionCloudObject IRevisionCloudinstance)
        {
            return IRevisionCloudinstance.IRevisionCloudInstance.Angle;
        }
    }
}