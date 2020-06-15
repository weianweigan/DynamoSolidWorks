using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDimensionSensorDataObject
    {
        public IDimensionSensorData IDimensionSensorDataInstance { get; set; }
        public IDimensionSensorDataObject(IDimensionSensorData IDimensionSensorDatainstance)
        {
            IDimensionSensorDataInstance = IDimensionSensorDatainstance;
        }
    }
    public static class IDimensionSensorDataInterface
    {
        public static IDisplayDimensionObject GetDisplayDimension(IDimensionSensorDataObject IDimensionSensorDatainstance)
        {
            return new IDisplayDimensionObject(IDimensionSensorDatainstance.IDimensionSensorDataInstance.GetDisplayDimension());
        }
        public static Double SensorValue(IDimensionSensorDataObject IDimensionSensorDatainstance)
        {
            return IDimensionSensorDatainstance.IDimensionSensorDataInstance.SensorValue;
        }
    }
}