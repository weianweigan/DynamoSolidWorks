using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISensorObject
    {
        public ISensor ISensorInstance { get; set; }
        public ISensorObject(ISensor ISensorinstance)
        {
            ISensorInstance = ISensorinstance;
        }
    }
    public static class ISensorInterface
    {
        public static Object GetSensorFeatureData(ISensorObject ISensorinstance)
        {
            return ISensorinstance.ISensorInstance.GetSensorFeatureData();
        }
        public static Boolean UpdateSensor(ISensorObject ISensorinstance)
        {
            return ISensorinstance.ISensorInstance.UpdateSensor();
        }
        //public static Boolean GetSensorValue(ISensorObject ISensorinstance, Double& Value, String& Units)
        //{
        //    return ISensorinstance.ISensorInstance.GetSensorValue(Value, Units);
        //}
        public static Int32 SensorType(ISensorObject ISensorinstance)
        {
            return ISensorinstance.ISensorInstance.SensorType;
        }
        public static Boolean SensorAlertEnabled(ISensorObject ISensorinstance)
        {
            return ISensorinstance.ISensorInstance.SensorAlertEnabled;
        }
        public static Int32 SensorAlertType(ISensorObject ISensorinstance)
        {
            return ISensorinstance.ISensorInstance.SensorAlertType;
        }
        public static Double SensorAlertValue1(ISensorObject ISensorinstance)
        {
            return ISensorinstance.ISensorInstance.SensorAlertValue1;
        }
        public static Double SensorAlertValue2(ISensorObject ISensorinstance)
        {
            return ISensorinstance.ISensorInstance.SensorAlertValue2;
        }
        public static Boolean SensorAlertState(ISensorObject ISensorinstance)
        {
            return ISensorinstance.ISensorInstance.SensorAlertState;
        }
    }
}