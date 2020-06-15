using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILightObject
    {
        public ILight ILightInstance { get; set; }
        public ILightObject(ILight ILightinstance)
        {
            ILightInstance = ILightinstance;
        }
    }
    public static class ILightInterface
    {
        public static Int32 GetID(ILightObject ILightinstance)
        {
            return ILightinstance.ILightInstance.GetID();
        }
    }
}