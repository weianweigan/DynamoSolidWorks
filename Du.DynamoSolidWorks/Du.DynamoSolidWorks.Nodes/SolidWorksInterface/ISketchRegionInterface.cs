using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchRegionObject
    {
        public ISketchRegion ISketchRegionInstance { get; set; }
        public ISketchRegionObject(ISketchRegion ISketchRegioninstance)
        {
            ISketchRegionInstance = ISketchRegioninstance;
        }
    }
    public static class ISketchRegionInterface
    {
        public static Int32 GetEdgesCount(ISketchRegionObject ISketchRegioninstance)
        {
            return ISketchRegioninstance.ISketchRegionInstance.GetEdgesCount();
        }
        public static Object GetEdges(ISketchRegionObject ISketchRegioninstance)
        {
            return ISketchRegioninstance.ISketchRegionInstance.GetEdges();
        }
        public static IEdgeObject IGetEdges(ISketchRegionObject ISketchRegioninstance, Int32 Count)
        {
            return new IEdgeObject(ISketchRegioninstance.ISketchRegionInstance.IGetEdges(Count));
        }
        public static Boolean Select(ISketchRegionObject ISketchRegioninstance, Boolean Append, Int32 Mark)
        {
            return ISketchRegioninstance.ISketchRegionInstance.Select(Append, Mark);
        }
        public static Boolean DeSelect(ISketchRegionObject ISketchRegioninstance)
        {
            return ISketchRegioninstance.ISketchRegionInstance.DeSelect();
        }
        public static Boolean Select2(ISketchRegionObject ISketchRegioninstance, Boolean Append, ISelectDataObject Data)
        {
            return ISketchRegioninstance.ISketchRegionInstance.Select2(Append, Data?.ISelectDataInstance?.CastObj<SelectData>());
        }
        public static ILoop2Object GetFirstLoop(ISketchRegionObject ISketchRegioninstance)
        {
            return new ILoop2Object(ISketchRegioninstance.ISketchRegionInstance.GetFirstLoop());
        }
        public static ISketchObject Sketch(ISketchRegionObject ISketchRegioninstance)
        {
            return new ISketchObject(ISketchRegioninstance.ISketchRegionInstance.Sketch);
        }
    }
}