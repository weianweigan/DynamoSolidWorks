using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICurveParamDataObject
    {
        public ICurveParamData ICurveParamDataInstance { get; set; }
        public ICurveParamDataObject(ICurveParamData ICurveParamDatainstance)
        {
            ICurveParamDataInstance = ICurveParamDatainstance;
        }
    }
    public static class ICurveParamDataInterface
    {
        public static Object StartPoint(ICurveParamDataObject ICurveParamDatainstance)
        {
            return ICurveParamDatainstance.ICurveParamDataInstance.StartPoint;
        }
        public static Object EndPoint(ICurveParamDataObject ICurveParamDatainstance)
        {
            return ICurveParamDatainstance.ICurveParamDataInstance.EndPoint;
        }
        public static Double UMinValue(ICurveParamDataObject ICurveParamDatainstance)
        {
            return ICurveParamDatainstance.ICurveParamDataInstance.UMinValue;
        }
        public static Double UMaxValue(ICurveParamDataObject ICurveParamDatainstance)
        {
            return ICurveParamDatainstance.ICurveParamDataInstance.UMaxValue;
        }
        public static Int32 CurveType(ICurveParamDataObject ICurveParamDatainstance)
        {
            return ICurveParamDatainstance.ICurveParamDataInstance.CurveType;
        }
        public static Int32 CurveTag(ICurveParamDataObject ICurveParamDatainstance)
        {
            return ICurveParamDatainstance.ICurveParamDataInstance.CurveTag;
        }
        public static Boolean Sense(ICurveParamDataObject ICurveParamDatainstance)
        {
            return ICurveParamDatainstance.ICurveParamDataInstance.Sense;
        }
    }
}