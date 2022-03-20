using System.Linq;
using System.Collections.Generic;
using SldWorksNodes.Geometry;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    /// <summary>
    /// 多边形
    /// </summary>
    public class SketchPolygon:SketchSegment<List<ISketchLine>>
    {
        #region Ctor
        internal SketchPolygon(List<Point3D> points,bool close = false)
        {
            //TODO:创建直线
            var newPts = points
                .Select(p => _swUnit.ConvertPoint(p))
                .ToList();

            CreateLines(newPts,close);
        }
        #endregion

        #region Create
        public static SketchPolygon ByPoints(List<Point3D> points,bool close)
        {
            if (points?.Any() != true) return null;

            return new SketchPolygon(points,close);
        }
        #endregion

        #region Query
        public List<SketchSegment> Segments()
        {
            return ExtractSegments(
                SkeSegment
                .Cast<ISketchSegment>()
                .ToList());
        }

        #endregion

        #region Methods
        public override bool AsConstructionGeometry()
        {
            if(SkeSegment == null) return false;

            foreach (var seg in SkeSegment)
            {
                ((ISketchSegment)seg).ConstructionGeometry = true;
            }

            return true;
        }

        private void CreateLines(List<Point3D> newPts, bool close)
        {
            SkeSegment = new List<ISketchLine>();

            var skeMgr = GetSkeContext();

            skeMgr.WithDbState(() =>
            {
                for (int i = 0; i < newPts.Count - 1; i++)
                {
                    var line = skeMgr.CreateLine(
                        newPts[i].X, newPts[i].Y, newPts[i].Z,
                        newPts[i + 1].X, newPts[i + 1].Y, newPts[i + 1].Z)
                    as ISketchLine;
                    if (line != null)
                        SkeSegment.Add(line);
                }
                if (close)
                {
                    var count = SkeSegment.Count;
                    var line = skeMgr.CreateLine(
                        newPts[count].X, newPts[count].Y, newPts[count].Z,
                        newPts[0].X, newPts[0].Y, newPts[0].Z)
                    as ISketchLine;
                    if (line != null)
                        SkeSegment.Add(line);
                }

            });

        }

        #endregion
    }
}
