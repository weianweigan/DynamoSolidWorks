using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMateObject
    {
        public IMate IMateInstance { get; set; }
        public IMateObject(IMate IMateinstance)
        {
            IMateInstance = IMateinstance;
        }
    }
    public static class IMateInterface
    {
        public static Object GetMateParams(IMateObject IMateinstance)
        {
            return IMateinstance.IMateInstance.GetMateParams();
        }
        //public static void IGetMateParams(IMateObject IMateinstance, Int32& MateType, Int32& AlignFlag, Int32& CanBeFlipped)
        //{
        //    return IMateinstance.IMateInstance.IGetMateParams(MateType, AlignFlag, CanBeFlipped);
        //}
        public static Object GetMateDimensionValue(IMateObject IMateinstance)
        {
            return IMateinstance.IMateInstance.GetMateDimensionValue();
        }
        public static Double IGetMateDimensionValue(IMateObject IMateinstance)
        {
            return IMateinstance.IMateInstance.IGetMateDimensionValue();
        }
        public static Object GetMateEntities(IMateObject IMateinstance)
        {
            return IMateinstance.IMateInstance.GetMateEntities();
        }
        //public static void IGetMateEntities(IMateObject IMateinstance, MateEntity&Object Entity1, MateEntity&Object Entity2)
        //{
        //    return IMateinstance.IMateInstance.IGetMateEntities(Entity1, Entity2);
        //}
        public static Object GetEntity(IMateObject IMateinstance, Int32 WhichOne)
        {
            return IMateinstance.IMateInstance.GetEntity(WhichOne);
        }
        public static IEntityObject IGetEntity(IMateObject IMateinstance, Int32 WhichOne)
        {
            return new IEntityObject(IMateinstance.IMateInstance.IGetEntity(WhichOne));
        }
    }
}