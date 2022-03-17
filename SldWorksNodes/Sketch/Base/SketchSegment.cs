using System;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    [IsVisibleInDynamoLibrary(false)]
    public abstract class SketchSegment<TSkeSegment> : SwNodeModel<ISketchSegment>
    {
        protected SwSketch _sketch;
        public TSkeSegment SkeSegment { get;protected set; }

        public SketchSegment(SwSketch swSketch)
        {
            _sketch = swSketch;
        }

        protected ISketchManager GetSkeContext()
        {
            var doc = SwContextUtil.GetActivDocContext();

            if (doc.SketchManager.ActiveSketch == null ||
                ((IFeature)doc.SketchManager.ActiveSketch).Name != _sketch.SwObject.Name)
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
}
