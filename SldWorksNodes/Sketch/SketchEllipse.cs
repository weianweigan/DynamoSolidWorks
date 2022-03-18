using System;
using SldWorksNodes.Geometry;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    public class SketchEllipse: SketchSegment<ISketchEllipse>
    {
        #region Ctor
        internal SketchEllipse(Point3D center, Point3D major, Point3D minor)
        {
            var nCenter = _swUnit.ConvertPoint(center);
            var nMajor = _swUnit.ConvertPoint(major);
            var nMinor = _swUnit.ConvertPoint(minor);

            CreateEllipse(nCenter, nMajor, nMinor);
        }
        #endregion

        #region Create
        public static SketchEllipse ByCenterMajorAndMinor(
            Point3D center,
            Point3D major,
            Point3D minor)
        {
            if(center == null || major == null || minor == null) return null;

            return new SketchEllipse(center, major, minor);
        }
        #endregion

        #region Methods
        private void CreateEllipse(Point3D nCenter, Point3D nMajor, Point3D nMinor)
        {
            var skeMgr = GetSkeContext();

            skeMgr.WithDbState(() =>
            {
                SwObject = skeMgr.CreateEllipse(
                    nCenter.X, nCenter.Y, nCenter.Z,
                    nMajor.X, nMajor.Y, nMajor.Z,
                    nMinor.X, nMinor.Y, nMinor.Z);

                SkeSegment = SwObject as ISketchEllipse;
            });
        }
        #endregion
    }
}
