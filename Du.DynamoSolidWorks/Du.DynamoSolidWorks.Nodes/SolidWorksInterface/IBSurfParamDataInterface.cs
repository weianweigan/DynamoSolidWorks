using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBSurfParamDataObject
    {
        public IBSurfParamData IBSurfParamDataInstance { get; set; }
        public IBSurfParamDataObject(IBSurfParamData IBSurfParamDatainstance)
        {
            IBSurfParamDataInstance = IBSurfParamDatainstance;
        }
    }
    public static class IBSurfParamDataInterface
    {
        public static Object GetControlPoints(IBSurfParamDataObject IBSurfParamDatainstance, Int32 Row, Int32 Column)
        {
            return IBSurfParamDatainstance.IBSurfParamDataInstance.GetControlPoints(Row, Column);
        }
        public static Double IGetControlPoints(IBSurfParamDataObject IBSurfParamDatainstance, Int32 Row, Int32 Column, Int32 Count)
        {
            return IBSurfParamDatainstance.IBSurfParamDataInstance.IGetControlPoints(Row, Column, Count);
        }
        public static Int32 UOrder(IBSurfParamDataObject IBSurfParamDatainstance)
        {
            return IBSurfParamDatainstance.IBSurfParamDataInstance.UOrder;
        }
        public static Int32 VOrder(IBSurfParamDataObject IBSurfParamDatainstance)
        {
            return IBSurfParamDatainstance.IBSurfParamDataInstance.VOrder;
        }
        public static Int32 ControlPointColumnCount(IBSurfParamDataObject IBSurfParamDatainstance)
        {
            return IBSurfParamDatainstance.IBSurfParamDataInstance.ControlPointColumnCount;
        }
        public static Int32 ControlPointRowCount(IBSurfParamDataObject IBSurfParamDatainstance)
        {
            return IBSurfParamDatainstance.IBSurfParamDataInstance.ControlPointRowCount;
        }
        public static Int32 ControlPointDimension(IBSurfParamDataObject IBSurfParamDatainstance)
        {
            return IBSurfParamDatainstance.IBSurfParamDataInstance.ControlPointDimension;
        }
        public static Boolean UPeriodicity(IBSurfParamDataObject IBSurfParamDatainstance)
        {
            return IBSurfParamDatainstance.IBSurfParamDataInstance.UPeriodicity;
        }
        public static Boolean VPeriodicity(IBSurfParamDataObject IBSurfParamDatainstance)
        {
            return IBSurfParamDatainstance.IBSurfParamDataInstance.VPeriodicity;
        }
        public static Object UKnots(IBSurfParamDataObject IBSurfParamDatainstance)
        {
            return IBSurfParamDatainstance.IBSurfParamDataInstance.UKnots;
        }
        public static Object VKnots(IBSurfParamDataObject IBSurfParamDatainstance)
        {
            return IBSurfParamDatainstance.IBSurfParamDataInstance.VKnots;
        }
    }
}