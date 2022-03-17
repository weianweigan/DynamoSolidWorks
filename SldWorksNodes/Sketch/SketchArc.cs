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
        private Point3D _p1;
        private Point3D _p2;
        private Point3D _p3;

        internal SketchArc(SwSketch swSketch) : base(swSketch)
        {
        }

        #region Create
        public static SketchArc BySketch(SwSketch swSketch)
        {
            if (swSketch == null) return null;
            return new SketchArc(swSketch);
        }
        #endregion

        #region Query

        public SketchPoint StartPoint { get;private set; }

        public SketchPoint EndPoint { get; private set; }

        public SketchPoint CenterPoint { get; private set; }

        public double Radius { get; private set; }

        #endregion

        #region Action
        public bool ByThreePoints(Point3D p1, Point3D p2, Point3D p3)
        {
            if (p1 == null || p2 == null || p3 == null) return false;

            if (IsSameLine(p1, p2, p3))
                throw new Exception("Three Points Same Line");

            _p1 = _swUnit.ConvertPoint(p1);
            _p2 = _swUnit.ConvertPoint(p2);
            _p3 = _swUnit.ConvertPoint(p3);

            if (SwObject == null)
            {
                CreateArc(_p1,_p2,_p3);
            }
            else
            {
                UpdateArc(_p1, _p2, _p3);
            }

            return SwObject != null;
        }
        #endregion

        /// <summary>
        /// 确定三点是否共线
        /// </summary>
        private bool IsSameLine(Point3D p1,Point3D p2,Point3D p3)
        {
            var vec = (p1 - p2);
            var vec2 = (p3 - p1);
            return Vector3D.IsPara(vec, vec2);            
        }

        private void UpdateArc(Point3D p1, Point3D p2, Point3D p3)
        {
            //TODO:计算三点圆弧
        }

        private void CreateArc(Point3D p1, Point3D p2, Point3D p3)
        {
            var skeMgr = GetSkeContext();

            SwObject = skeMgr.Create3PointArc(
                p1.X, p1.Y, p1.Z,
                p2.X, p2.Y, p2.Z,
                p3.X, p3.Y, p3.Z
                );

            SkeSegment = SwObject as ISketchArc;

            StartPoint = new SketchPoint(_sketch, SkeSegment.GetStartPoint2() as ISketchPoint);
            EndPoint = new SketchPoint(_sketch, SkeSegment.GetEndPoint2() as ISketchPoint);
            CenterPoint = new SketchPoint(_sketch, SkeSegment.GetCenterPoint2() as ISketchPoint);

            Radius = SkeSegment.GetRadius();
        }
    }
}
