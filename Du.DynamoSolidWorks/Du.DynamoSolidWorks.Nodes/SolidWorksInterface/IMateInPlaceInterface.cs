using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMateInPlaceObject
    {
        public IMateInPlace IMateInPlaceInstance { get; set; }
        public IMateInPlaceObject(IMateInPlace IMateInPlaceinstance)
        {
            IMateInPlaceInstance = IMateInPlaceinstance;
        }
    }
    public static class IMateInPlaceInterface
    {
        public static Int32 GetMateEntityCount(IMateInPlaceObject IMateInPlaceinstance)
        {
            return IMateInPlaceinstance.IMateInPlaceInstance.GetMateEntityCount();
        }
        public static Object MateEntity(IMateInPlaceObject IMateInPlaceinstance, int NIndex)
        {
            return IMateInPlaceinstance.IMateInPlaceInstance.MateEntity[NIndex];
        }
        public static Int32 MateEntityType(IMateInPlaceObject IMateInPlaceinstance, int NIndex)
        {
            return IMateInPlaceinstance.IMateInPlaceInstance.MateEntityType[NIndex];
        }
        public static String MateComponentName(IMateInPlaceObject IMateInPlaceinstance, int NIndex)
        {
            return IMateInPlaceinstance.IMateInPlaceInstance.MateComponentName[NIndex];
        }
        public static IComponent2Object Component(IMateInPlaceObject IMateInPlaceinstance)
        {
            return new IComponent2Object(IMateInPlaceinstance.IMateInPlaceInstance.Component);
        }
    }
}