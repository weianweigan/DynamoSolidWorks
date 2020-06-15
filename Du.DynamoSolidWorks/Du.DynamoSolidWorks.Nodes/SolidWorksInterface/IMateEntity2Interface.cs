using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMateEntity2Object
    {
        public IMateEntity2 IMateEntity2Instance { get; set; }
        public IMateEntity2Object(IMateEntity2 IMateEntity2instance)
        {
            IMateEntity2Instance = IMateEntity2instance;
        }
    }
    public static class IMateEntity2Interface
    {
        public static Int32 GetEntityParamsSize(IMateEntity2Object IMateEntity2instance)
        {
            return IMateEntity2instance.IMateEntity2Instance.GetEntityParamsSize();
        }
        public static Double IGetEntityParams(IMateEntity2Object IMateEntity2instance, Int32 NParamsSize)
        {
            return IMateEntity2instance.IMateEntity2Instance.IGetEntityParams(NParamsSize);
        }
        public static Object EntityParams(IMateEntity2Object IMateEntity2instance)
        {
            return IMateEntity2instance.IMateEntity2Instance.EntityParams;
        }
        public static Object Reference(IMateEntity2Object IMateEntity2instance)
        {
            return IMateEntity2instance.IMateEntity2Instance.Reference;
        }
        public static Int32 ReferenceType(IMateEntity2Object IMateEntity2instance)
        {
            return IMateEntity2instance.IMateEntity2Instance.ReferenceType;
        }
        public static IComponent2Object ReferenceComponent(IMateEntity2Object IMateEntity2instance)
        {
            return new IComponent2Object(IMateEntity2instance.IMateEntity2Instance.ReferenceComponent);
        }
        public static Int32 ReferenceType2(IMateEntity2Object IMateEntity2instance)
        {
            return IMateEntity2instance.IMateEntity2Instance.ReferenceType2;
        }
    }
}