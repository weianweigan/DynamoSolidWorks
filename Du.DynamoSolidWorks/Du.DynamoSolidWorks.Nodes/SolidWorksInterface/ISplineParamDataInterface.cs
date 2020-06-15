using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISplineParamDataObject
    {
        public ISplineParamData ISplineParamDataInstance { get; set; }
        public ISplineParamDataObject(ISplineParamData ISplineParamDatainstance)
        {
            ISplineParamDataInstance = ISplineParamDatainstance;
        }
    }
    public static class ISplineParamDataInterface
    {
        //public static Boolean GetControlPoints(ISplineParamDataObject ISplineParamDatainstance, Object& ControlPoints)
        //{
        //    return ISplineParamDatainstance.ISplineParamDataInstance.GetControlPoints(ControlPoints);
        //}
        //public static Boolean IGetControlPoints(ISplineParamDataObject ISplineParamDatainstance, Int32 Count, Double& ControlPoints)
        //{
        //    return ISplineParamDatainstance.ISplineParamDataInstance.IGetControlPoints(Count, ControlPoints);
        //}
        //public static Boolean GetKnotPoints(ISplineParamDataObject ISplineParamDatainstance, Object& KnotPoints)
        //{
        //    return ISplineParamDatainstance.ISplineParamDataInstance.GetKnotPoints(KnotPoints);
        //}
        //public static Boolean IGetKnotPoints(ISplineParamDataObject ISplineParamDatainstance, Int32 Count, Double& KnotPoints)
        //{
        //    return ISplineParamDatainstance.ISplineParamDataInstance.IGetKnotPoints(Count, KnotPoints);
        //}
        //public static Boolean GetSegments(ISplineParamDataObject ISplineParamDatainstance, Object& Segments)
        //{
        //    return ISplineParamDatainstance.ISplineParamDataInstance.GetSegments(Segments);
        //}
        //public static Boolean IGetSegments(ISplineParamDataObject ISplineParamDatainstance, Int32 Count, Double& Segments)
        //{
        //    return ISplineParamDatainstance.ISplineParamDataInstance.IGetSegments(Count, Segments);
        //}
        public static Boolean SetControlPoints(ISplineParamDataObject ISplineParamDatainstance, Object ControlPoints)
        {
            return ISplineParamDatainstance.ISplineParamDataInstance.SetControlPoints(ControlPoints);
        }
        public static Boolean SetKnotPoints(ISplineParamDataObject ISplineParamDatainstance, Object KnotPoints)
        {
            return ISplineParamDatainstance.ISplineParamDataInstance.SetKnotPoints(KnotPoints);
        }
        public static Int32 Dimension(ISplineParamDataObject ISplineParamDatainstance)
        {
            return ISplineParamDatainstance.ISplineParamDataInstance.Dimension;
        }
        public static Int32 Order(ISplineParamDataObject ISplineParamDatainstance)
        {
            return ISplineParamDatainstance.ISplineParamDataInstance.Order;
        }
        public static Int32 Periodic(ISplineParamDataObject ISplineParamDatainstance)
        {
            return ISplineParamDatainstance.ISplineParamDataInstance.Periodic;
        }
        public static Int32 ControlPointsCount(ISplineParamDataObject ISplineParamDatainstance)
        {
            return ISplineParamDatainstance.ISplineParamDataInstance.ControlPointsCount;
        }
        public static Int32 KnotPointsCount(ISplineParamDataObject ISplineParamDatainstance)
        {
            return ISplineParamDatainstance.ISplineParamDataInstance.KnotPointsCount;
        }
        public static Int32 SegmentCount(ISplineParamDataObject ISplineParamDatainstance)
        {
            return ISplineParamDatainstance.ISplineParamDataInstance.SegmentCount;
        }
        public static Int32 Reserved(ISplineParamDataObject ISplineParamDatainstance)
        {
            return ISplineParamDatainstance.ISplineParamDataInstance.Reserved;
        }
        public static Int32 Color(ISplineParamDataObject ISplineParamDatainstance)
        {
            return ISplineParamDatainstance.ISplineParamDataInstance.Color;
        }
        public static Int32 LineStyle(ISplineParamDataObject ISplineParamDatainstance)
        {
            return ISplineParamDatainstance.ISplineParamDataInstance.LineStyle;
        }
        public static Int32 LineWidth(ISplineParamDataObject ISplineParamDatainstance)
        {
            return ISplineParamDatainstance.ISplineParamDataInstance.LineWidth;
        }
        public static Int32 Layer(ISplineParamDataObject ISplineParamDatainstance)
        {
            return ISplineParamDatainstance.ISplineParamDataInstance.Layer;
        }
        public static Int32 LayerOverride(ISplineParamDataObject ISplineParamDatainstance)
        {
            return ISplineParamDatainstance.ISplineParamDataInstance.LayerOverride;
        }
    }
}