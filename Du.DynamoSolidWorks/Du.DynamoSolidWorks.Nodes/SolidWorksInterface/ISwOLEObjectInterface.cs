using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISwOLEObjectObject
    {
        public ISwOLEObject ISwOLEObjectInstance { get; set; }
        public ISwOLEObjectObject(ISwOLEObject ISwOLEObjectinstance)
        {
            ISwOLEObjectInstance = ISwOLEObjectinstance;
        }
    }
    public static class ISwOLEObjectInterface
    {
        //public static void IGetBuffer(ISwOLEObjectObject ISwOLEObjectinstance, Int32 OleBufferSize, Byte& BOleData)
        //{
        //    return ISwOLEObjectinstance.ISwOLEObjectInstance.IGetBuffer(OleBufferSize, BOleData);
        //}
        //public static void IGetBoundaries(ISwOLEObjectObject ISwOLEObjectinstance, Double& Boundary)
        //{
        //    return ISwOLEObjectinstance.ISwOLEObjectInstance.IGetBoundaries(Boundary);
        //}
        //public static void ISetBoundaries(ISwOLEObjectObject ISwOLEObjectinstance, Double& Boundary)
        //{
        //    return ISwOLEObjectinstance.ISwOLEObjectInstance.ISetBoundaries(Boundary);
        //}
        public static Boolean Select(ISwOLEObjectObject ISwOLEObjectinstance, Boolean Append)
        {
            return ISwOLEObjectinstance.ISwOLEObjectInstance.Select(Append);
        }
        public static void Refresh(ISwOLEObjectObject ISwOLEObjectinstance)
        {
            ISwOLEObjectinstance.ISwOLEObjectInstance.Refresh();
        }
        public static Object SetActive(ISwOLEObjectObject ISwOLEObjectinstance, Boolean Active)
        {
            return ISwOLEObjectinstance.ISwOLEObjectInstance.SetActive(Active);
        }
        public static String FileName(ISwOLEObjectObject ISwOLEObjectinstance)
        {
            return ISwOLEObjectinstance.ISwOLEObjectInstance.FileName;
        }
        public static String Clsid(ISwOLEObjectObject ISwOLEObjectinstance)
        {
            return ISwOLEObjectinstance.ISwOLEObjectInstance.Clsid;
        }
        public static Boolean IsLinked(ISwOLEObjectObject ISwOLEObjectinstance)
        {
            return ISwOLEObjectinstance.ISwOLEObjectInstance.IsLinked;
        }
        public static Int32 BufferSize(ISwOLEObjectObject ISwOLEObjectinstance)
        {
            return ISwOLEObjectinstance.ISwOLEObjectInstance.BufferSize;
        }
        public static Object Buffer(ISwOLEObjectObject ISwOLEObjectinstance)
        {
            return ISwOLEObjectinstance.ISwOLEObjectInstance.Buffer;
        }
        public static Int32 Aspect(ISwOLEObjectObject ISwOLEObjectinstance)
        {
            return ISwOLEObjectinstance.ISwOLEObjectInstance.Aspect;
        }
        public static Object Boundaries(ISwOLEObjectObject ISwOLEObjectinstance)
        {
            return ISwOLEObjectinstance.ISwOLEObjectInstance.Boundaries;
        }
    }
}