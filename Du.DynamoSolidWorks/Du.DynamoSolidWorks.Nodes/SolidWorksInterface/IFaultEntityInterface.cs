using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFaultEntityObject
    {
        public IFaultEntity IFaultEntityInstance { get; set; }
        public IFaultEntityObject(IFaultEntity IFaultEntityinstance)
        {
            IFaultEntityInstance = IFaultEntityinstance;
        }
    }
    public static class IFaultEntityInterface
    {
        public static Int32 Count(IFaultEntityObject IFaultEntityinstance)
        {
            return IFaultEntityinstance.IFaultEntityInstance.Count;
        }
        public static IEntityObject Entity(IFaultEntityObject IFaultEntityinstance, int Index)
        {
            return new IEntityObject(IFaultEntityinstance.IFaultEntityInstance.Entity[Index]);
        }
        public static Int32 ErrorCode(IFaultEntityObject IFaultEntityinstance, int Index)
        {
            return IFaultEntityinstance.IFaultEntityInstance.ErrorCode[Index];
        }
        public static Object Entity2(IFaultEntityObject IFaultEntityinstance, int Index)
        {
            return IFaultEntityinstance.IFaultEntityInstance.Entity2[Index];
        }
    }
}