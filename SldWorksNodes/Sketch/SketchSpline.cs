using System.Collections.Generic;
using System.Linq;
using SldWorksNodes.Geometry;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    public class SketchSpline:SketchSegment<ISketchSpline>
    {
        #region Ctor
        internal SketchSpline(List<Point3D> points)
        {
            var nPts = points
                .Select(p => _swUnit.ConvertPoint(p))
                .ToList();

            CreateSpline(nPts);
        }

        internal SketchSpline(ISketchSpline skeSeg)
        {
            SkeSegment = skeSeg;
            SwObject = skeSeg as ISketchSegment;
        }

        internal SketchSpline(List<Point3D> points, List<Vector3D> directions, bool simulateNaturalEnds) : this(points)
        {

        }

        #endregion

        #region Create
        //public static SketchSpline By2DPointsAndDirections(
        //    List<Point3D> points,
        //    List<Vector3D> directions,
        //    bool SimulateNaturalEnds = true)
        //{
        //    return new SketchSpline(points, directions, SimulateNaturalEnds);
        //}

        public static SketchSpline ByPoints(List<Point3D> points)
        {
            if (points?.Count < 2)
            {
                return null;
            }

            return new SketchSpline(points);
        }
        #endregion

        #region Methods
        private void CreateSpline(List<Point3D> nPts)
        {
            var skeMgr = GetSkeContext();

            var ptArray = new double[nPts.Count * 3];
            for (int i = 0; i < nPts.Count; i++)
            {
                ptArray[i * 3] = nPts[i].X;
                ptArray[i * 3+1] = nPts[i].X;
                ptArray[i * 3+2] = nPts[i].X;

            }
            

            skeMgr.WithDbState(() =>
            {                
                SwObject = skeMgr.CreateSpline3(
                    ptArray,
                    null,
                    null,
                    true,
                    out var status
                    ) as ISketchSegment;

                SkeSegment = SwObject as ISketchSpline;
            });
        }
        #endregion
    }
}
