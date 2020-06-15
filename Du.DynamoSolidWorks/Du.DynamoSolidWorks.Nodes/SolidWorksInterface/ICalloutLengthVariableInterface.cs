using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICalloutLengthVariableObject
    {
        public ICalloutLengthVariable ICalloutLengthVariableInstance { get; set; }
        public ICalloutLengthVariableObject(ICalloutLengthVariable ICalloutLengthVariableinstance)
        {
            ICalloutLengthVariableInstance = ICalloutLengthVariableinstance;
        }
    }
    public static class ICalloutLengthVariableInterface
    {
        public static Double Length(ICalloutLengthVariableObject ICalloutLengthVariableinstance)
        {
            return ICalloutLengthVariableinstance.ICalloutLengthVariableInstance.Length;
        }
        public static Int32 TolerancePrecision(ICalloutLengthVariableObject ICalloutLengthVariableinstance)
        {
            return ICalloutLengthVariableinstance.ICalloutLengthVariableInstance.TolerancePrecision;
        }
        public static Int32 Precision(ICalloutLengthVariableObject ICalloutLengthVariableinstance)
        {
            return ICalloutLengthVariableinstance.ICalloutLengthVariableInstance.Precision;
        }
    }
}