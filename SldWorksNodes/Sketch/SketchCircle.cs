using SldWorksNodes.Geometry;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    public class SketchCircle:SketchArc
    {
        public SketchCircle(Point3D point, Point3D pointInCircle)
        {
            var nPt = _swUnit.ConvertPoint(point);
            var nPtCircle = _swUnit.ConvertPoint(pointInCircle);

            CreateCircle(nPt,nPtCircle);
        }

        private void CreateCircle(Point3D nPt, Point3D nPtCircle)
        {
            var skeMgr = GetSkeContext();

            skeMgr.WithDbState(() =>
            SwObject = skeMgr.CreateCircle(
                nPt.X,nPt.Y,nPt.Z,
                nPtCircle.X,nPtCircle.Y,nPtCircle.Z
                ));

            SkeSegment = SwObject as ISketchArc;
            SolvePoints();
        }

        public static SketchCircle ByCenterAndPointInCircle(
            Point3D point,
            Point3D pointInCircle)
        {

            if (point == null || pointInCircle == null)
                return null;

            return new SketchCircle(point, pointInCircle);
        }
    }
}
