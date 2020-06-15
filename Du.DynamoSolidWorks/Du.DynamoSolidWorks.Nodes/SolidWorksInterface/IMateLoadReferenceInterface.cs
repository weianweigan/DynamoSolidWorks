using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMateLoadReferenceObject
    {
        public IMateLoadReference IMateLoadReferenceInstance { get; set; }
        public IMateLoadReferenceObject(IMateLoadReference IMateLoadReferenceinstance)
        {
            IMateLoadReferenceInstance = IMateLoadReferenceinstance;
        }
    }
    public static class IMateLoadReferenceInterface
    {
        public static Object GetFaces(IMateLoadReferenceObject IMateLoadReferenceinstance, Int32 WhichOne)
        {
            return IMateLoadReferenceinstance.IMateLoadReferenceInstance.GetFaces(WhichOne);
        }
        public static Int32 GetFacesCount(IMateLoadReferenceObject IMateLoadReferenceinstance, Int32 WhichOne)
        {
            return IMateLoadReferenceinstance.IMateLoadReferenceInstance.GetFacesCount(WhichOne);
        }
        public static IFace2Object IGetFaces(IMateLoadReferenceObject IMateLoadReferenceinstance, Int32 WhichOne, Int32 FaceCount)
        {
            return new IFace2Object(IMateLoadReferenceinstance.IMateLoadReferenceInstance.IGetFaces(WhichOne, FaceCount));
        }
        public static Boolean Delete(IMateLoadReferenceObject IMateLoadReferenceinstance)
        {
            return IMateLoadReferenceinstance.IMateLoadReferenceInstance.Delete();
        }
        public static IMate2Object Mate(IMateLoadReferenceObject IMateLoadReferenceinstance)
        {
            return new IMate2Object(IMateLoadReferenceinstance.IMateLoadReferenceInstance.Mate);
        }
        public static String Name(IMateLoadReferenceObject IMateLoadReferenceinstance)
        {
            return IMateLoadReferenceinstance.IMateLoadReferenceInstance.Name;
        }
        public static IComponent2Object Component(IMateLoadReferenceObject IMateLoadReferenceinstance, int WhichOne)
        {
            return new IComponent2Object(IMateLoadReferenceinstance.IMateLoadReferenceInstance.Component[WhichOne]);
        }
    }
}