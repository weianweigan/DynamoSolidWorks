using System;
using System.Collections.Generic;
using System.Linq;
using SldWorksNodes.Geometry;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SldWorksNodes.Sketch
{
    public class SketchSlot:SketchSegment<ISketchSlot>
    {
        #region Ctor
        internal SketchSlot(
            Point3D p1,
            Point3D p2, 
            Point3D p3,
            swSketchSlotCreationType_e type,
            double width = 0
            )
        {
            var nP1 = _swUnit.ConvertPoint(p1);
            var nP2 = _swUnit.ConvertPoint(p2);
            var nP3 = _swUnit.ConvertPoint(p3);

            switch (type)
            {
                case swSketchSlotCreationType_e.swSketchSlotCreationType_line:
                    CreateStrightSolt(nP1, nP2, nP3);
                    break;
                case swSketchSlotCreationType_e.swSketchSlotCreationType_center_line:
                    CreateStrightCenterSolt(nP1, nP2, nP3);
                    break;
                case swSketchSlotCreationType_e.swSketchSlotCreationType_arc:
                    if (width <= 0)
                        throw new ArgumentException($"{type} need width > 0");
                    CreateCenterArc(nP1, nP2, nP3, width);
                    break;
                case swSketchSlotCreationType_e.swSketchSlotCreationType_3pointarc:
                    if (width <= 0)
                        throw new ArgumentException($"{type} need width > 0");
                    Create3PointArc(nP1, nP2, nP3, width);
                    break;
            }
        }
        #endregion

        #region Create
        /// <summary>
        /// Straight(直槽口)
        /// </summary>
        public static SketchSlot By3PointStraight(
            Point3D p1,
            Point3D p2,
            Point3D p3)
        {
            if (p1 == null || p2 == null || p3 == null)
                return null;

            return new SketchSlot(p1, p2, p3,
                swSketchSlotCreationType_e.swSketchSlotCreationType_line);
        }

        /// <summary>
        /// Center Straight(中心槽口)
        /// </summary>
        public static SketchSlot By3PointCenterStraight(
            Point3D p1,
            Point3D p2,
            Point3D p3)
        {
            if (p1 == null || p2 == null || p3 == null)
                return null;

            return new SketchSlot(p1, p2, p3,
                swSketchSlotCreationType_e.swSketchSlotCreationType_center_line);
        }

        /// <summary>
        /// 三点圆弧槽口
        /// </summary>
        public static SketchSlot By3PointArc(
            Point3D p1,
            Point3D p2,
            Point3D p3,
            double width)
        {
            if (p1 == null || p2 == null || p3 == null)
                return null;

            return new SketchSlot(p1, p2, p3,
                swSketchSlotCreationType_e.swSketchSlotCreationType_3pointarc
                ,width);
        }

        /// <summary>
        /// 中心点圆弧槽口
        /// </summary>
        public static SketchSlot By3PointCenterArc(
            Point3D p1,
            Point3D p2,
            Point3D p3,
            double width)
        {
            if (p1 == null || p2 == null || p3 == null)
                return null;

            return new SketchSlot(p1, p2, p3,
                swSketchSlotCreationType_e.swSketchSlotCreationType_arc
                , width);
        }
        #endregion

        #region Query
        public SketchPoint CenterPoint()
        {
            var pt = SkeSegment?.GetCenterPointHandle() as ISketchPoint;
            return pt == null ? null : new SketchPoint(null,pt);
        }

        public double Width()
        {
            return SkeSegment.Width;
        }

        public double Length => SkeSegment.Length;

        public List<SketchPoint> Points()
        {
            var pts = SkeSegment?.GetSlotPoints() as Object[];
            if (pts == null)
                return null;

            return pts
                .Cast<ISketchPoint>()
                .Select(p => new SketchPoint(null, p))
                .ToList();
        }
        #endregion

        #region Action
        public bool SetWidth(double width)
        {
            SkeSegment.Width = width;
            return SkeSegment.Width == width;
        }
        #endregion

        #region Methods
        private void CreateStrightSolt(
            Point3D p1, 
            Point3D p2, 
            Point3D p3)
        {
            var skeMgr = GetSkeContext();

            SkeSegment = skeMgr.CreateSketchSlot(
                (int)swSketchSlotCreationType_e.swSketchSlotCreationType_line,
                (int)swSketchSlotLengthType_e.swSketchSlotLengthType_CenterCenter,
                0,
                p1.X, p1.Y, p1.Z,
                p2.X, p2.Y, p2.Z,
                p3.X, p3.Y, p3.Z,
                (short)1,
                false
                ) as ISketchSlot;
        }

        private void CreateStrightCenterSolt(
            Point3D p1,
            Point3D p2, 
            Point3D p3)
        {
            var skeMgr = GetSkeContext();

            SkeSegment = skeMgr.CreateSketchSlot(
                (int)swSketchSlotCreationType_e.swSketchSlotCreationType_center_line,
                (int)swSketchSlotLengthType_e.swSketchSlotLengthType_CenterCenter,
                0,
                p1.X, p1.Y, p1.Z,
                p2.X, p2.Y, p2.Z,
                p3.X, p3.Y, p3.Z,
                (short)1,
                false
                ) as ISketchSlot;
        }

        private void Create3PointArc(
            Point3D p1, 
            Point3D p2,
            Point3D p3, 
            double width)
        {
            var skeMgr = GetSkeContext();

            SkeSegment = skeMgr.CreateSketchSlot(
                (int)swSketchSlotCreationType_e.swSketchSlotCreationType_3pointarc,
                (int)swSketchSlotLengthType_e.swSketchSlotLengthType_CenterCenter,
                width,
                p1.X, p1.Y, p1.Z,
                p2.X, p2.Y, p2.Z,
                p3.X, p3.Y, p3.Z,
                (short)1,
                false
                ) as ISketchSlot;
        }

        private void CreateCenterArc(
            Point3D p1,
            Point3D p2,
            Point3D p3, 
            double width)
        {
            var skeMgr = GetSkeContext();

            SkeSegment = skeMgr.CreateSketchSlot(
                (int)swSketchSlotCreationType_e.swSketchSlotCreationType_arc,
                (int)swSketchSlotLengthType_e.swSketchSlotLengthType_CenterCenter,
                width,
                p1.X, p1.Y, p1.Z,
                p2.X, p2.Y, p2.Z,
                p3.X, p3.Y, p3.Z,
                (short)1,
                false
                ) as ISketchSlot;
        }

        public override string ToString()
        {
            return nameof(SketchSlot);
        }
        #endregion
    }
}
