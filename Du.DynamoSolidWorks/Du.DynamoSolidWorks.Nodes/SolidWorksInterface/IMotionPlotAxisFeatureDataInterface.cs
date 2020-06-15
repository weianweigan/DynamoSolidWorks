using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMotionPlotAxisFeatureDataObject
    {
        public IMotionPlotAxisFeatureData IMotionPlotAxisFeatureDataInstance { get; set; }
        public IMotionPlotAxisFeatureDataObject(IMotionPlotAxisFeatureData IMotionPlotAxisFeatureDatainstance)
        {
            IMotionPlotAxisFeatureDataInstance = IMotionPlotAxisFeatureDatainstance;
        }
    }
    public static class IMotionPlotAxisFeatureDataInterface
    {
        public static Int32 Type(IMotionPlotAxisFeatureDataObject IMotionPlotAxisFeatureDatainstance)
        {
            return IMotionPlotAxisFeatureDatainstance.IMotionPlotAxisFeatureDataInstance.Type;
        }
        public static Int32 Component(IMotionPlotAxisFeatureDataObject IMotionPlotAxisFeatureDatainstance)
        {
            return IMotionPlotAxisFeatureDatainstance.IMotionPlotAxisFeatureDataInstance.Component;
        }
        public static Object Entities(IMotionPlotAxisFeatureDataObject IMotionPlotAxisFeatureDatainstance)
        {
            return IMotionPlotAxisFeatureDatainstance.IMotionPlotAxisFeatureDataInstance.Entities;
        }
        public static IComponent2Object ReferencePart(IMotionPlotAxisFeatureDataObject IMotionPlotAxisFeatureDatainstance)
        {
            return new IComponent2Object(IMotionPlotAxisFeatureDatainstance.IMotionPlotAxisFeatureDataInstance.ReferencePart);
        }
    }
}