using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IParameterObject
    {
        public IParameter IParameterInstance { get; set; }
        public IParameterObject(IParameter IParameterinstance)
        {
            IParameterInstance = IParameterinstance;
        }
    }
    public static class IParameterInterface
    {
        public static Double GetDoubleValue(IParameterObject IParameterinstance)
        {
            return IParameterinstance.IParameterInstance.GetDoubleValue();
        }
        public static Boolean SetDoubleValue(IParameterObject IParameterinstance, Double Value)
        {
            return IParameterinstance.IParameterInstance.SetDoubleValue(Value);
        }
        public static Int32 GetType(IParameterObject IParameterinstance)
        {
            return IParameterinstance.IParameterInstance.GetType();
        }
        public static String GetName(IParameterObject IParameterinstance)
        {
            return IParameterinstance.IParameterInstance.GetName();
        }
        public static Int32 GetOption(IParameterObject IParameterinstance, Int32 WhichOption)
        {
            return IParameterinstance.IParameterInstance.GetOption(WhichOption);
        }
        public static Boolean SetOption(IParameterObject IParameterinstance, Int32 WhichOption, Int32 OptionValue)
        {
            return IParameterinstance.IParameterInstance.SetOption(WhichOption, OptionValue);
        }
        public static String GetStringValue(IParameterObject IParameterinstance)
        {
            return IParameterinstance.IParameterInstance.GetStringValue();
        }
        public static Boolean SetStringValue(IParameterObject IParameterinstance, String StringValue)
        {
            return IParameterinstance.IParameterInstance.SetStringValue(StringValue);
        }
        //public static void GetVector(IParameterObject IParameterinstance, Double& X, Double& Y, Double& Z)
        //{
        //    return IParameterinstance.IParameterInstance.GetVector(X, Y, Z);
        //}
        public static Boolean SetVector(IParameterObject IParameterinstance, Double X, Double Y, Double Z)
        {
            return IParameterinstance.IParameterInstance.SetVector(X, Y, Z);
        }
        public static Object GetVectorVB(IParameterObject IParameterinstance)
        {
            return IParameterinstance.IParameterInstance.GetVectorVB();
        }
        public static Boolean SetDoubleValue2(IParameterObject IParameterinstance, Double Value, Int32 ConfigurationOption, String ConfigurationName)
        {
            return IParameterinstance.IParameterInstance.SetDoubleValue2(Value, ConfigurationOption, ConfigurationName);
        }
        public static Boolean SetStringValue2(IParameterObject IParameterinstance, String StringValue, Int32 ConfigurationOption, String ConfigurationName)
        {
            return IParameterinstance.IParameterInstance.SetStringValue2(StringValue, ConfigurationOption, ConfigurationName);
        }
        public static Boolean SetVector2(IParameterObject IParameterinstance, Double X, Double Y, Double Z, Int32 ConfigurationOption, String ConfigurationName)
        {
            return IParameterinstance.IParameterInstance.SetVector2(X, Y, Z, ConfigurationOption, ConfigurationName);
        }
    }
}