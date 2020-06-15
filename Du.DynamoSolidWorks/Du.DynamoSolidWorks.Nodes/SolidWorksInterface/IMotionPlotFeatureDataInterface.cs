using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMotionPlotFeatureDataObject
    {
        public IMotionPlotFeatureData IMotionPlotFeatureDataInstance { get; set; }
        public IMotionPlotFeatureDataObject(IMotionPlotFeatureData IMotionPlotFeatureDatainstance)
        {
            IMotionPlotFeatureDataInstance = IMotionPlotFeatureDatainstance;
        }
    }
    public static class IMotionPlotFeatureDataInterface
    {
        public static IFeatureObject GetXAxis(IMotionPlotFeatureDataObject IMotionPlotFeatureDatainstance)
        {
            return new IFeatureObject(IMotionPlotFeatureDatainstance.IMotionPlotFeatureDataInstance.GetXAxis());
        }
        public static Object GetYAxis(IMotionPlotFeatureDataObject IMotionPlotFeatureDatainstance)
        {
            return IMotionPlotFeatureDatainstance.IMotionPlotFeatureDataInstance.GetYAxis();
        }
        public static IFeatureObject IGetYAxis(IMotionPlotFeatureDataObject IMotionPlotFeatureDatainstance, Int32 Count)
        {
            return new IFeatureObject(IMotionPlotFeatureDatainstance.IMotionPlotFeatureDataInstance.IGetYAxis(Count));
        }
        public static Boolean AddYAxis(IMotionPlotFeatureDataObject IMotionPlotFeatureDatainstance, IMotionPlotAxisFeatureDataObject YAxis)
        {
            return IMotionPlotFeatureDatainstance.IMotionPlotFeatureDataInstance.AddYAxis(YAxis.IMotionPlotAxisFeatureDataInstance?.CastObj<MotionPlotAxisFeatureData>());
        }
        public static Boolean Visibility(IMotionPlotFeatureDataObject IMotionPlotFeatureDatainstance)
        {
            return IMotionPlotFeatureDatainstance.IMotionPlotFeatureDataInstance.Visibility;
        }
    }
}