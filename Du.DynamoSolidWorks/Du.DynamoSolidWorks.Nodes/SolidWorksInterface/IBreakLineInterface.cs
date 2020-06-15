using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBreakLineObject
    {
        public IBreakLine IBreakLineInstance { get; set; }
        public IBreakLineObject(IBreakLine IBreakLineinstance)
        {
            IBreakLineInstance = IBreakLineinstance;
        }
    }
    public static class IBreakLineInterface
    {
        public static IViewObject GetView(IBreakLineObject IBreakLineinstance)
        {
            return new IViewObject(IBreakLineinstance.IBreakLineInstance.GetView());
        }
        public static Double GetPosition(IBreakLineObject IBreakLineinstance, Int32 Index)
        {
            return IBreakLineinstance.IBreakLineInstance.GetPosition(Index);
        }
        public static Boolean SetPosition(IBreakLineObject IBreakLineinstance, Double Position1, Double Position2)
        {
            return IBreakLineinstance.IBreakLineInstance.SetPosition(Position1, Position2);
        }
        public static Boolean Select(IBreakLineObject IBreakLineinstance, Boolean Append, ISelectDataObject Data)
        {
            return IBreakLineinstance.IBreakLineInstance.Select(Append, Data.ISelectDataInstance as SelectData);
        }
        public static Int32 Style(IBreakLineObject IBreakLineinstance)
        {
            return IBreakLineinstance.IBreakLineInstance.Style;
        }
        public static String Layer(IBreakLineObject IBreakLineinstance)
        {
            return IBreakLineinstance.IBreakLineInstance.Layer;
        }
        public static Int32 Orientation(IBreakLineObject IBreakLineinstance)
        {
            return IBreakLineinstance.IBreakLineInstance.Orientation;
        }
        public static Int32 ShapeIntensity(IBreakLineObject IBreakLineinstance)
        {
            return IBreakLineinstance.IBreakLineInstance.ShapeIntensity;
        }
        public static Boolean BreakSketchBlocks(IBreakLineObject IBreakLineinstance)
        {
            return IBreakLineinstance.IBreakLineInstance.BreakSketchBlocks;
        }
    }
}