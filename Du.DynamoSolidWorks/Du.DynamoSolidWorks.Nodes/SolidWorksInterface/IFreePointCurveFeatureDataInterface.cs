using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFreePointCurveFeatureDataObject
    {
        public IFreePointCurveFeatureData IFreePointCurveFeatureDataInstance { get; set; }
        public IFreePointCurveFeatureDataObject(IFreePointCurveFeatureData IFreePointCurveFeatureDatainstance)
        {
            IFreePointCurveFeatureDataInstance = IFreePointCurveFeatureDatainstance;
        }
    }
    public static class IFreePointCurveFeatureDataInterface
    {
        public static Int32 GetPointCount(IFreePointCurveFeatureDataObject IFreePointCurveFeatureDatainstance)
        {
            return IFreePointCurveFeatureDatainstance.IFreePointCurveFeatureDataInstance.GetPointCount();
        }
        public static Double IGetPointArray(IFreePointCurveFeatureDataObject IFreePointCurveFeatureDatainstance)
        {
            return IFreePointCurveFeatureDatainstance.IFreePointCurveFeatureDataInstance.IGetPointArray();
        }
        //public static void ISetPointArray(IFreePointCurveFeatureDataObject IFreePointCurveFeatureDatainstance, Int32 FeatCount, Double& ArrayDataIn)
        //{
        //    return IFreePointCurveFeatureDatainstance.IFreePointCurveFeatureDataInstance.ISetPointArray(FeatCount, ArrayDataIn);
        //}
        public static Boolean SavePointsToFile(IFreePointCurveFeatureDataObject IFreePointCurveFeatureDatainstance, String FileName)
        {
            return IFreePointCurveFeatureDatainstance.IFreePointCurveFeatureDataInstance.SavePointsToFile(FileName);
        }
        public static Boolean LoadPointsFromFile(IFreePointCurveFeatureDataObject IFreePointCurveFeatureDatainstance, String FileName)
        {
            return IFreePointCurveFeatureDatainstance.IFreePointCurveFeatureDataInstance.LoadPointsFromFile(FileName);
        }
        public static Object PointArray(IFreePointCurveFeatureDataObject IFreePointCurveFeatureDatainstance)
        {
            return IFreePointCurveFeatureDatainstance.IFreePointCurveFeatureDataInstance.PointArray;
        }
    }
}