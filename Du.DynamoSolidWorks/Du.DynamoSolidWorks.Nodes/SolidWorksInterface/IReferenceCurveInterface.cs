using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IReferenceCurveObject
    {
        public IReferenceCurve IReferenceCurveInstance { get; set; }
        public IReferenceCurveObject(IReferenceCurve IReferenceCurveinstance)
        {
            IReferenceCurveInstance = IReferenceCurveinstance;
        }
    }
    public static class IReferenceCurveInterface
    {
        public static Int32 GetSegmentCount(IReferenceCurveObject IReferenceCurveinstance)
        {
            return IReferenceCurveinstance.IReferenceCurveInstance.GetSegmentCount();
        }
        public static Object GetFirstSegment(IReferenceCurveObject IReferenceCurveinstance)
        {
            return IReferenceCurveinstance.IReferenceCurveInstance.GetFirstSegment();
        }
        public static IEdgeObject IGetFirstSegment(IReferenceCurveObject IReferenceCurveinstance)
        {
            return new IEdgeObject(IReferenceCurveinstance.IReferenceCurveInstance.IGetFirstSegment());
        }
        public static Object GetNextSegment(IReferenceCurveObject IReferenceCurveinstance)
        {
            return IReferenceCurveinstance.IReferenceCurveInstance.GetNextSegment();
        }
        public static IEdgeObject IGetNextSegment(IReferenceCurveObject IReferenceCurveinstance)
        {
            return new IEdgeObject(IReferenceCurveinstance.IReferenceCurveInstance.IGetNextSegment());
        }
        public static Boolean SetColor(IReferenceCurveObject IReferenceCurveinstance, Int32 ColorIn)
        {
            return IReferenceCurveinstance.IReferenceCurveInstance.SetColor(ColorIn);
        }
        public static Boolean SetVisible(IReferenceCurveObject IReferenceCurveinstance, Boolean Visible)
        {
            return IReferenceCurveinstance.IReferenceCurveInstance.SetVisible(Visible);
        }
        public static Object GetSegments(IReferenceCurveObject IReferenceCurveinstance)
        {
            return IReferenceCurveinstance.IReferenceCurveInstance.GetSegments();
        }
        public static IEdgeObject IGetSegments(IReferenceCurveObject IReferenceCurveinstance, Int32 NumSegments)
        {
            return new IEdgeObject(IReferenceCurveinstance.IReferenceCurveInstance.IGetSegments(NumSegments));
        }
    }
}