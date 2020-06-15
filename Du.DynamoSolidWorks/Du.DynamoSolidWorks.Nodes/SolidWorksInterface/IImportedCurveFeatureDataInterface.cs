using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IImportedCurveFeatureDataObject
    {
        public IImportedCurveFeatureData IImportedCurveFeatureDataInstance { get; set; }
        public IImportedCurveFeatureDataObject(IImportedCurveFeatureData IImportedCurveFeatureDatainstance)
        {
            IImportedCurveFeatureDataInstance = IImportedCurveFeatureDatainstance;
        }
    }
    public static class IImportedCurveFeatureDataInterface
    {
        public static Int32 GetCurveCount(IImportedCurveFeatureDataObject IImportedCurveFeatureDatainstance)
        {
            return IImportedCurveFeatureDatainstance.IImportedCurveFeatureDataInstance.GetCurveCount();
        }
        public static Object IGetCurves(IImportedCurveFeatureDataObject IImportedCurveFeatureDatainstance, Int32 Count)
        {
            return IImportedCurveFeatureDatainstance.IImportedCurveFeatureDataInstance.IGetCurves(Count);
        }
        //public static void ISetCurves(IImportedCurveFeatureDataObject IImportedCurveFeatureDatainstance, Int32 Count, Object& DispArr)
        //{
        //    return IImportedCurveFeatureDatainstance.IImportedCurveFeatureDataInstance.ISetCurves(Count, DispArr);
        //}
        //public static void SetBody(IImportedCurveFeatureDataObject IImportedCurveFeatureDatainstance, Body2Object DispBody)
        //{
        //    return IImportedCurveFeatureDatainstance.IImportedCurveFeatureDataInstance.SetBody(DispBody);
        //}
        public static Object Curves(IImportedCurveFeatureDataObject IImportedCurveFeatureDatainstance)
        {
            return IImportedCurveFeatureDatainstance.IImportedCurveFeatureDataInstance.Curves;
        }
    }
}