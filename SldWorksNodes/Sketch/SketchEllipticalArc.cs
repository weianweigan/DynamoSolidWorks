using SldWorksNodes.Geometry;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    public class SketchEllipticalArc : SketchSegment<ISketchEllipse>
    {
        #region Ctor
        internal SketchEllipticalArc() {}

        internal SketchEllipticalArc(
            Point3D center, 
            Point3D major, 
            Point3D minor,
            Point3D startPt,
            Point3D endPt,
            bool clockWiseDirection)
        {
            var nCenter = _swUnit.ConvertPoint(center);
            var nMajor = _swUnit.ConvertPoint(major);
            var nMinor = _swUnit.ConvertPoint(minor);
            var nSpt = _swUnit.ConvertPoint(nCenter);
            var nePt = _swUnit.ConvertPoint(endPt);

            CreateEllipse(nCenter, nMajor, nMinor,startPt,endPt,clockWiseDirection);
        }

        public SketchEllipticalArc(ISketchEllipse skeSeg)
        {
            SkeSegment = skeSeg;
            SwObject = skeSeg as ISketchSegment;
        }
        #endregion

        #region Query
        /// <summary>
        /// Rotation direction (counterclockwise = true, clockwise = false)
        /// </summary>
        /// <remarks>
        /// This method determines the direction (counterclockwise or clockwise) that the sketch entity proceeds around the ellipse, beginning at its start point and ending at its ending point if the sketch entity is not a complete ellipse.
        /// </remarks>
        public bool RotationDirection()
        {
            return SkeSegment.GetRotationDir() > 0 ? true : false;
        }

        public SketchPoint CenterPoint()
        {
            var cPt = SkeSegment.GetCenterPoint2() as ISketchPoint;

            return cPt == null ? null : new SketchPoint(null,cPt);
        }

        public SketchPoint StartPoint()
        {
            var sPt = SkeSegment.GetStartPoint2() as ISketchPoint;

            return sPt == null ? null : new SketchPoint(null, sPt);
        }

        public SketchPoint EndPoint()
        {
            var ePt = SkeSegment.GetEndPoint2() as ISketchPoint;

            return ePt == null ? null : new SketchPoint(null, ePt);
        }

        public SketchPoint MajorPoint()
        {
            var mPt = SkeSegment.GetMajorPoint2() as ISketchPoint;

            return mPt == null ? null : new SketchPoint(null, mPt);
        }

        public SketchPoint MinPoint()
        {
            var mPt = SkeSegment.GetMinorPoint2() as ISketchPoint;

            return mPt == null ? null : new SketchPoint(null, mPt);
        }
        #endregion

        #region Create
        public static SketchEllipticalArc ByCenterMajorMinorAndStartEndPt(
            Point3D center,
            Point3D major,
            Point3D minor,
            Point3D startPt,
            Point3D endPt,
            bool clockWiseDirection)
        {
            if (center == null || major == null || minor == null
                || startPt == null || endPt == null) return null;

            return new SketchEllipticalArc(center, major, minor,startPt,endPt,clockWiseDirection);
        }
        #endregion

        #region Methods
        private void CreateEllipse(
            Point3D nCenter,
            Point3D nMajor,
            Point3D nMinor, 
            Point3D startPt,
            Point3D endPt,
            bool clockWiseDirection)
        {
            var skeMgr = GetSkeContext();

            skeMgr.WithDbState(() =>
            {
                SwObject = skeMgr.CreateEllipticalArc(
                    nCenter.X, nCenter.Y, nCenter.Z,
                    nMajor.X, nMajor.Y, nMajor.Z,
                    nMinor.X, nMinor.Y, nMinor.Z,
                    startPt.X,startPt.Y,startPt.Z,
                    endPt.X,endPt.Y,endPt.Z,
                    clockWiseDirection ? (short)1 : (short)-1);

                SkeSegment = SwObject as ISketchEllipse;
            });
        }
        #endregion
    }
}
