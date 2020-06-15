using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICalloutAngleVariableObject
    {
        public ICalloutAngleVariable ICalloutAngleVariableInstance { get; set; }
        public ICalloutAngleVariableObject(ICalloutAngleVariable ICalloutAngleVariableinstance)
        {
            ICalloutAngleVariableInstance = ICalloutAngleVariableinstance;
        }
    }
    public static class ICalloutAngleVariableInterface
    {
        public static Double Angle(ICalloutAngleVariableObject ICalloutAngleVariableinstance)
        {
            return ICalloutAngleVariableinstance.ICalloutAngleVariableInstance.Angle;
        }
    }
}