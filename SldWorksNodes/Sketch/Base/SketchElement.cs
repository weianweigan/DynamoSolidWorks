using System;
using System.Collections.Generic;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    [IsVisibleInDynamoLibrary(false)]
    public abstract class SketchElement<TSwType> : SwNodeModel<TSwType>
        where TSwType : class
    {
        private SwSketch _sketch;

        protected SketchElement(SwSketch sketch)
        {
            _sketch = sketch;
        }

        protected SketchManager GetSkeContext()
        {
            var doc = SwContextUtil.GetActivDocContext();

            if (doc.SketchManager.ActiveSketch == null && _sketch != null)
            {
                _sketch.SwObject.Select2(false, 0);
                doc.EditSketch();
            }

            if (doc.SketchManager.ActiveSketch == null)
            {
                throw new Exception("Cannot get sketch context");
            }

            return doc.SketchManager;
        }
    }

    //public static class SketchElementsManager
    //{
    //    private static List<ISketchPoint> Points = new List<ISketchPoint>();

    //    private static List<ISketchSegment> Segements= new List<ISketchSegment>();

    //    public static void Reset()
    //    {
    //        Points.Clear();
    //        Segements.Clear();
    //    }

    //    public static void Register(ISketchSegment sketchSegment)
    //    {
    //        if (sketchSegment == null)
    //            return;
    //        Segements.Add(sketchSegment);
    //    }

    //    public static void Register(ISketchPoint point)
    //    {
    //        if (point == null)
    //            return;
    //        Points.Add(point);
    //    }

    //    //public static ISketchPoint 
    //}
}
