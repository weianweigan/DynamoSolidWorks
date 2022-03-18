using System;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    [IsVisibleInDynamoLibrary(false)]
    public abstract class SketchSegment<TSkeSegment> : 
        SwNodeModel<ISketchSegment>, 
        IDisposable
    {
        protected SwSketch _sketch;

        public TSkeSegment SkeSegment { get; protected set; }

        [IsVisibleInDynamoLibrary(false)]
        public SketchSegment()
        {
        }

        protected ISketchManager GetSkeContext()
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

        public virtual bool AsConstructionGeometry()
        {
            SwObject.ConstructionGeometry = true;
            return SwObject.ConstructionGeometry;
        }

        public void Dispose()
        {

        }
    }
}
