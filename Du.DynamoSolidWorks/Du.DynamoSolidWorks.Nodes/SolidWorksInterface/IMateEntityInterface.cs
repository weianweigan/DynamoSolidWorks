using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMateEntityObject
    {
        public IMateEntity IMateEntityInstance { get; set; }
        public IMateEntityObject(IMateEntity IMateEntityinstance)
        {
            IMateEntityInstance = IMateEntityinstance;
        }
    }
    public static class IMateEntityInterface
    {
        public static Object GetMember(IMateEntityObject IMateEntityinstance)
        {
            return IMateEntityinstance.IMateEntityInstance.GetMember();
        }
        public static IMemberObject IGetMember(IMateEntityObject IMateEntityinstance)
        {
            return new IMemberObject(IMateEntityinstance.IMateEntityInstance.IGetMember());
        }
        public static Int32 GetEntityType(IMateEntityObject IMateEntityinstance)
        {
            return IMateEntityinstance.IMateEntityInstance.GetEntityType();
        }
        public static Object GetEntityParams(IMateEntityObject IMateEntityinstance)
        {
            return IMateEntityinstance.IMateEntityInstance.GetEntityParams();
        }
        public static Double IGetEntityParams(IMateEntityObject IMateEntityinstance)
        {
            return IMateEntityinstance.IMateEntityInstance.IGetEntityParams();
        }
        public static Object GetComponent(IMateEntityObject IMateEntityinstance)
        {
            return IMateEntityinstance.IMateEntityInstance.GetComponent();
        }
        public static IComponentObject IGetComponent(IMateEntityObject IMateEntityinstance)
        {
            return new IComponentObject(IMateEntityinstance.IMateEntityInstance.IGetComponent());
        }
        public static String GetComponentName(IMateEntityObject IMateEntityinstance)
        {
            return IMateEntityinstance.IMateEntityInstance.GetComponentName();
        }
        public static IComponent2Object IGetComponent2(IMateEntityObject IMateEntityinstance)
        {
            return new IComponent2Object(IMateEntityinstance.IMateEntityInstance.IGetComponent2());
        }
    }
}