using DynamoServices;
using SldWorksNodes.Geometry;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    public class SketchPoint:SketchElement<ISketchPoint>
    {
        #region Fields
        private Point3D _point;
        #endregion

        #region Ctor
        internal SketchPoint(
            Point3D point):base(null)
        {
            _point = _swUnit.ConvertPoint(point);

            if (SwObject == null)
            {
                CreatePoint(_point);
            }
            else
            {
                UpdatePoint(_point);
            }
        }

        internal SketchPoint(SwSketch sketch, ISketchPoint sketchPoint) : base(sketch)
        {
            SwObject = sketchPoint;
        }
        #endregion

        #region Create
        public static SketchPoint ByPostion(Point3D point)
        {
            if (point == null)
                return null;

            return new SketchPoint(point);
        }
        #endregion

        #region Action

        public bool UpdatePoint(Point3D point)
        {
            return SwObject.SetCoords(point.X,point.Y,point.Z);
        }
        #endregion

        #region Methods

        private void CreatePoint(Point3D point)
        {
            var skeMgr = GetSkeContext();

            skeMgr.WithDbState(() =>
            {
                SwObject = skeMgr.CreatePoint(point.X, point.Y, point.Z);
            });
        }

        public override string ToString()
        {
            if (SwObject == null)
                return "Use Postion Action To CreatePoint";
            else
                return _point.ToString();
        }
        #endregion
    }
}
