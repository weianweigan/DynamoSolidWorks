using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SldWorksNodes.Base;
using SldWorksNodes.Geometry;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SldWorksNodes.Sketch
{
    public class SketchRectangle:SketchSegment<List<ISketchSegment>>
    {
        #region Ctor
        internal SketchRectangle(Point3D p1, Point3D p2, Point3D p3,bool isConrner = false)
        {
            var nP1 = _swUnit.ConvertPoint(p1);
            var nP2 = _swUnit.ConvertPoint(p2);
            var nP3 = _swUnit.ConvertPoint(p3);

            Create3PointCenterRectangle(nP1, nP2, nP3);
        }

        public SketchRectangle(Point3D center, Point3D corner)
        {
            var nCenter = _swUnit.ConvertPoint(center);
            var nCorner = _swUnit.ConvertPoint(corner);

            CreateCenterRectangle(nCenter, nCorner);
        }

        #endregion

        #region Create
        /// <summary>
        /// Creates a center rectangle. 
        /// </summary>
        public static SketchRectangle ByCenter(Point3D center,Point3D corner)
        {
            if (center == null || corner == null)
                return null;

            return new SketchRectangle(center, corner);
        }

        /// <summary>
        /// Creates a 3-point center rectangle at any angle. 
        /// </summary>
        public static SketchRectangle By3PointCenter(
            Point3D p1,
            Point3D p2,
            Point3D p3
            )
        {
            if (p1 == null || p2 == null || p3 == null)
                return null;

            return new SketchRectangle(p1, p2, p3);
        }

        /// <summary>
        /// Creates a 3-point corner rectangle at any angle.
        /// </summary>
        /// <returns>
        /// Array of sketch segments that represent the edges created for this corner rectangle
        /// </returns>
        public static SketchRectangle By3PointCenterCorner(
            Point3D p1,
            Point3D p2,
            Point3D p3
            )
        {
            if (p1 == null || p2 == null || p3 == null)
                return null;

            return new SketchRectangle(p1, p2, p3,true);
        }
        #endregion

        #region Query
        public List<SketchSegment> Segments()
        {
            return ExtractSegments(SkeSegment);
        }

        #endregion

        #region Methods
        private void Create3PointCenterRectangle(Point3D p1, Point3D p2, Point3D p3)
        {
            var skeMgr = GetSkeContext();

            skeMgr.WithDbState(() =>
            {
                var segs = skeMgr.Create3PointCenterRectangle(
                    p1.X, p1.Y, p1.Z,
                    p2.X, p2.Y, p2.Z,
                    p3.X, p3.Y, p3.Z
                    ) as Object[];
                if (segs != null)
                {
                    SkeSegment = segs
                    .Cast<ISketchSegment>()
                    .ToList();
                }
                else
                    SkeSegment = new List<ISketchSegment>();
            });
        }

        private void Create3PointCenterCornerRectangle(Point3D p1, Point3D p2, Point3D p3)
        {
            var skeMgr = GetSkeContext();

            skeMgr.WithDbState(() =>
            {
                var segs = skeMgr.Create3PointCornerRectangle(
                    p1.X, p1.Y, p1.Z,
                    p2.X, p2.Y, p2.Z,
                    p3.X, p3.Y, p3.Z
                    ) as Object[];
                if (segs != null)
                {
                    SkeSegment = segs
                    .Cast<ISketchSegment>()
                    .ToList();
                }
                else
                    SkeSegment = new List<ISketchSegment>();
            });
        }

        private void CreateCenterRectangle(Point3D p1, Point3D p2)
        {
            var skeMgr = GetSkeContext();

            skeMgr.WithDbState(() =>
            {
                var segs = skeMgr.CreateCenterRectangle(
                    p1.X, p1.Y, p1.Z,
                    p2.X, p2.Y, p2.Z
                    ) as Object[];
                if (segs != null)
                {
                    SkeSegment = segs
                    .Cast<ISketchSegment>()
                    .ToList();
                }
                else
                    SkeSegment = new List<ISketchSegment>();
            });
        }

        public override bool AsConstructionGeometry()
        {
            return BatchAsConstructGeometery(SkeSegment);
        }
        #endregion
    }
}
