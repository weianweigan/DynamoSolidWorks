using SldWorksNodes.Geometry;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    public class SketchPoint:SketchElement<ISketchPoint>
    {
        private Point3D _point;

        internal SketchPoint(SwSketch sketch) : base(sketch) { }

        internal SketchPoint(
            SwSketch sketch,
            ISketchPoint sketchPoint) 
            : base(sketch)
        { 
            SwObject = sketchPoint;
        }

        #region Create
        public static SketchLine BySketch(SwSketch sketch)
        {
            if(sketch == null)  return null;
            return new SketchLine(sketch);
        }
        #endregion

        #region Action
        public bool Postion(Point3D point)
        {
            if (point == null)
                return false;

            _point = _swUnit.ConvertPoint(point);

            if (SwObject == null)
            {
                CreatePoint(_point);
            }
            else
            {
                return UpdatePoint(_point);
            }

            return SwObject != null;
        }
        #endregion

        #region Methods
        private bool UpdatePoint(Point3D point)
        {
            return SwObject.SetCoords(point.X,point.Y,point.Z);
        }

        private void CreatePoint(Point3D point)
        {
            var skeMgr = GetSkeContext();

            SwObject = skeMgr.CreatePoint(point.X,point.Y,point.Z);
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
