using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDisplayStateSettingObject
    {
        public IDisplayStateSetting IDisplayStateSettingInstance { get; set; }
        public IDisplayStateSettingObject(IDisplayStateSetting IDisplayStateSettinginstance)
        {
            IDisplayStateSettingInstance = IDisplayStateSettinginstance;
        }
    }
    public static class IDisplayStateSettingInterface
    {
        public static Int32 GetNameCount(IDisplayStateSettingObject IDisplayStateSettinginstance)
        {
            return IDisplayStateSettinginstance.IDisplayStateSettingInstance.GetNameCount();
        }
        public static String IGetNames(IDisplayStateSettingObject IDisplayStateSettinginstance, Int32 DsNameCount)
        {
            return IDisplayStateSettinginstance.IDisplayStateSettingInstance.IGetNames(DsNameCount);
        }
        //public static void ISetNames(IDisplayStateSettingObject IDisplayStateSettinginstance, Int32 DsNameCount, String& DSNames)
        //{
        //    return IDisplayStateSettinginstance.IDisplayStateSettingInstance.ISetNames(DsNameCount, DSNames);
        //}
        public static Int32 GetEntityCount(IDisplayStateSettingObject IDisplayStateSettinginstance)
        {
            return IDisplayStateSettinginstance.IDisplayStateSettingInstance.GetEntityCount();
        }
        public static Object IGetEntities(IDisplayStateSettingObject IDisplayStateSettinginstance, Int32 EntityCount)
        {
            return IDisplayStateSettinginstance.IDisplayStateSettingInstance.IGetEntities(EntityCount);
        }
        //public static void ISetEntities(IDisplayStateSettingObject IDisplayStateSettinginstance, Int32 EntityCount, Object& Entities)
        //{
        //    return IDisplayStateSettinginstance.IDisplayStateSettingInstance.ISetEntities(EntityCount, Entities);
        //}
        public static Int32 Option(IDisplayStateSettingObject IDisplayStateSettinginstance)
        {
            return IDisplayStateSettinginstance.IDisplayStateSettingInstance.Option;
        }
        public static Object Names(IDisplayStateSettingObject IDisplayStateSettinginstance)
        {
            return IDisplayStateSettinginstance.IDisplayStateSettingInstance.Names;
        }
        public static Object Entities(IDisplayStateSettingObject IDisplayStateSettinginstance)
        {
            return IDisplayStateSettinginstance.IDisplayStateSettingInstance.Entities;
        }
        public static Boolean PartLevel(IDisplayStateSettingObject IDisplayStateSettinginstance)
        {
            return IDisplayStateSettinginstance.IDisplayStateSettingInstance.PartLevel;
        }
        public static Boolean RemoveAppearance(IDisplayStateSettingObject IDisplayStateSettinginstance)
        {
            return IDisplayStateSettinginstance.IDisplayStateSettingInstance.RemoveAppearance;
        }
    }
}