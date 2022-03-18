using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SldWorksNodes.Geometry;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    public class SketchArc : SketchSegment<ISketchArc>
    {
        #region Ctor
        internal SketchArc(Point3D p1, Point3D p2, Point3D p3)
        {
            var nP1 = _swUnit.ConvertPoint(p1);
            var nP2 = _swUnit.ConvertPoint(p2);
            var nP3 = _swUnit.ConvertPoint(p3);

            CreateArcBy3Pt(nP1, nP2, nP3);
        }

        internal SketchArc(Point3D center, Point3D sPt, Point3D ePt,bool direction) 
        {
            var nCenter  = _swUnit.ConvertPoint(center);
            var nSPt = _swUnit.ConvertPoint(sPt);
            var nEPt = _swUnit.ConvertPoint(ePt);

            CreateArc(nCenter, nSPt, nEPt,direction);
        }
        #endregion

        #region Create
        public static SketchArc ByThreePoints(Point3D p1, Point3D p2, Point3D p3)
        {
            if (p1 == null || p2 == null || p3 == null) return null;

            if (IsSameLine(p1, p2, p3))
                throw new Exception("Three Points Same Line");

            return new SketchArc(p1, p2, p3);
        }

        /// <summary>
        /// Create a arc by center,startpoint and endpoint with a direction
        /// </summary>
        /// <param name="center"></param>
        /// <param name="startPoint"></param>
        /// <param name="endPoint"></param>
        /// <param name="Direction">
        /// <see cref="true"/>: Go from the start point to the end point in a counter-clockwise direction 
        /// <see cref="false"/>:Go from the start point to the end point in a clockwise direction
        /// </param>
        /// <returns></returns>
        public static SketchArc ByCenterStartPointEndPoint(
            Point3D center,
            Point3D startPoint,
            Point3D endPoint,
            bool Direction)
        {
            if (center == null || startPoint == null || endPoint == null) return null;

            return new SketchArc(center, startPoint, endPoint, Direction);
        }
        #endregion

        #region Query

        public SketchPoint StartPoint { get; private set; }

        public SketchPoint EndPoint { get; private set; }

        public SketchPoint CenterPoint { get; private set; }

        public double Radius { get; private set; }
        #endregion

        #region Action

        #endregion

        #region Methods
        /// <summary>
        /// 确定三点是否共线
        /// </summary>
        private static bool IsSameLine(Point3D p1, Point3D p2, Point3D p3)
        {
            var vec = (p1 - p2);
            var vec2 = (p3 - p1);
            return Vector3D.IsPara(vec, vec2);
        }

        private void CreateArcBy3Pt(Point3D p1, Point3D p2, Point3D p3)
        {
            var skeMgr = GetSkeContext();

            skeMgr.WithDbState(() => 
            SwObject = skeMgr.Create3PointArc(
                p1.X, p1.Y, p1.Z,
                p2.X, p2.Y, p2.Z,
                p3.X, p3.Y, p3.Z
                ));

            SkeSegment = SwObject as ISketchArc;
            SolvePoints();
        }

        private void CreateArc(
            Point3D nCenter, 
            Point3D nSPt, 
            Point3D nEPt, 
            bool direction)
        {
            var skeMgr = GetSkeContext();

            skeMgr.WithDbState(() =>
            SwObject = skeMgr.CreateArc(
                nCenter.X, nCenter.Y, nCenter.Z,
                nSPt.X, nSPt.Y, nSPt.Z,
                nEPt.X, nEPt.Y, nEPt.Z,
                (short)(direction ? 1 : -1)));
        }

        private void SolvePoints()
        {
            if (SkeSegment == null)
            {
                return;
            }

            StartPoint = new SketchPoint(_sketch, SkeSegment.GetStartPoint2() as ISketchPoint);
            EndPoint = new SketchPoint(_sketch, SkeSegment.GetEndPoint2() as ISketchPoint);
            CenterPoint = new SketchPoint(_sketch, SkeSegment.GetCenterPoint2() as ISketchPoint);

            Radius = SkeSegment.GetRadius();
        }
        #endregion
    }

    public class SketchCircle
    {
        public static SketchArc ByCenterAndPointInCircle(
            Point3D point,
            Point3D pointInCircle)
        {

            //TODO

            return null;
        }
    }
}
