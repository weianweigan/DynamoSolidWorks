using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICalloutStringVariableObject
    {
        public ICalloutStringVariable ICalloutStringVariableInstance { get; set; }
        public ICalloutStringVariableObject(ICalloutStringVariable ICalloutStringVariableinstance)
        {
            ICalloutStringVariableInstance = ICalloutStringVariableinstance;
        }
    }
    public static class ICalloutStringVariableInterface
    {
        public static String String(ICalloutStringVariableObject ICalloutStringVariableinstance)
        {
            return ICalloutStringVariableinstance.ICalloutStringVariableInstance.String;
        }
    }
}