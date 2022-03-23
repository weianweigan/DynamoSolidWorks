using System;
using System.Collections.Generic;
using System.Linq;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SldWorksNodes.Sketch
{
    public class SketchSegment :
        SwNodeModel<ISketchSegment>
    {
        #region Field
        protected SwSketch _sketch;
        #endregion

        #region Ctor
        [IsVisibleInDynamoLibrary(false)]
        public SketchSegment()
        {

        }
        #endregion

        #region Query
        public virtual bool AsConstructionGeometry()
        {
            SwObject.ConstructionGeometry = true;
            return SwObject.ConstructionGeometry;
        }

        public SldWorksNodes.Geometry.Curve AsCurve()
        {
            if (SwObject == null)
                throw new InvalidOperationException("Cannot get curve");

            return new Geometry.Curve(SwObject.GetCurve() as ICurve);
        }
        #endregion

        #region Action
        public bool SplitAsSegment(int num)
        {
           return EqualSegment(swSketchSegmentType_e.swSketchSegmentType_sketchsegments,num);
        }

        public bool SplitAsPoint(int num)
        {
            return EqualSegment(swSketchSegmentType_e.swSketchSegmentType_sketchpoints, num);
        }
        #endregion

        #region Methods
        private bool EqualSegment(
            swSketchSegmentType_e type,
            int num)
        {
            if (SwObject == null)
                throw new InvalidOperationException("Cannot Split");

            if (num < 2 || num > 100)
            {
                throw new InvalidOperationException("2 <= num < = 100");
            }

            return SwObject.EqualSegment(
                (int)type,
                num);
        }
        #endregion
    }

    [IsVisibleInDynamoLibrary(false)]
    public abstract class SketchSegment<TSkeSegment> :
        SketchSegment,
        IDisposable
    {
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
        protected List<SketchSegment> ExtractSegments(List<ISketchSegment> skeSegment)
        {
            List<SketchSegment> segments = new List<SketchSegment>();
            foreach (var seg in skeSegment)
            {
                var type = (swSketchSegments_e)seg.GetType();
                SketchSegment skeSeg = null;
                switch (type)
                {
                    case swSketchSegments_e.swSketchLINE:
                        skeSeg = new SketchLine((ISketchLine)skeSeg);
                        break;
                    case swSketchSegments_e.swSketchARC:
                        skeSeg = new SketchArc((ISketchArc)skeSeg);
                        break;
                    case swSketchSegments_e.swSketchELLIPSE:
                        skeSeg = new SketchEllipticalArc((ISketchEllipse)skeSeg);
                        break;
                    case swSketchSegments_e.swSketchSPLINE:
                        skeSeg = new SketchSpline((ISketchSpline)skeSeg);
                        break;
                    case swSketchSegments_e.swSketchTEXT:

                        break;
                    case swSketchSegments_e.swSketchPARABOLA:

                        break;
                }
                if (skeSeg != null)
                    segments.Add(skeSeg);
            }
            return segments;
        }

        public void Dispose()
        {

        }

        protected bool BatchAsConstructGeometery(List<ISketchSegment> skeSegment)
        {
            if (skeSegment?.Any() != true)
                return false;

            foreach (var seg in skeSegment)
            {
                seg.ConstructionGeometry = true;
            }

            return true;
        }

    }
}
