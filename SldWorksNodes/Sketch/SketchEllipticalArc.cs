using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SldWorksNodes.Geometry;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    public class SketchEllipticalArc:SketchSegment<ISketchEllipse>
    {
        #region Ctor
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
