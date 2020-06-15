using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchContourObject
    {
        public ISketchContour ISketchContourInstance { get; set; }
        public ISketchContourObject(ISketchContour ISketchContourinstance)
        {
            ISketchContourInstance = ISketchContourinstance;
        }
    }
    public static class ISketchContourInterface
    {
        public static Int32 GetEdgesCount(ISketchContourObject ISketchContourinstance)
        {
            return ISketchContourinstance.ISketchContourInstance.GetEdgesCount();
        }
        public static Object GetEdges(ISketchContourObject ISketchContourinstance)
        {
            return ISketchContourinstance.ISketchContourInstance.GetEdges();
        }
        public static IEdgeObject IGetEdges(ISketchContourObject ISketchContourinstance, Int32 Count)
        {
            return new IEdgeObject(ISketchContourinstance.ISketchContourInstance.IGetEdges(Count));
        }
        public static Int32 GetSketchSegmentsCount(ISketchContourObject ISketchContourinstance)
        {
            return ISketchContourinstance.ISketchContourInstance.GetSketchSegmentsCount();
        }
        public static Object GetSketchSegments(ISketchContourObject ISketchContourinstance)
        {
            return ISketchContourinstance.ISketchContourInstance.GetSketchSegments();
        }
        public static ISketchSegmentObject IGetSketchSegments(ISketchContourObject ISketchContourinstance, Int32 Count)
        {
            return new ISketchSegmentObject(ISketchContourinstance.ISketchContourInstance.IGetSketchSegments(Count));
        }
        public static Boolean Select(ISketchContourObject ISketchContourinstance, Boolean Append, Int32 Mark)
        {
            return ISketchContourinstance.ISketchContourInstance.Select(Append, Mark);
        }
        public static Boolean DeSelect(ISketchContourObject ISketchContourinstance)
        {
            return ISketchContourinstance.ISketchContourInstance.DeSelect();
        }

        public static Boolean Select2(ISketchContourObject ISketchContourinstance, Boolean Append, ISelectDataObject Data)
        {
            return ISketchContourinstance.ISketchContourInstance.Select2(Append, Data?.ISelectDataInstance?.CastObj<SelectData>());
        }
        public static Boolean IsClosed(ISketchContourObject ISketchContourinstance)
        {
            return ISketchContourinstance.ISketchContourInstance.IsClosed();
        }
        public static ISketchObject Sketch(ISketchContourObject ISketchContourinstance)
        {
            return new ISketchObject(ISketchContourinstance.ISketchContourInstance.Sketch);
        }
    }
}