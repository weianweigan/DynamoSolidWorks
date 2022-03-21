using Autodesk.DesignScript.Interfaces;
using SldWorksNodes.Util;

namespace SldWorksNodes.Geometry
{
    public class Circle3D: Curve
    {
        #region Ctor
        internal Circle3D(Point3D center, double radius, Vector3D axis)
        {
            Center = center;
            Radius = radius;
            Axis = axis;

            CreateWireCircle();
        }
        #endregion

        #region Create
        public static Circle3D ByCenterPointRadiusNormal(
            Point3D center, 
            double radius, 
            Vector3D normal)
        {
            return new Circle3D(center, radius, normal);
        }

        public static Circle3D ByCenterPointRadius(
            Point3D center, 
            double radius)
        {
            return new Circle3D(center, radius, new Vector3D(0,0,1));
        }

        //TODO:三点圆弧
        //public static Circle3D ByThreePoints(
        //    Point3D p1,
        //    Point3D p2,
        //    Point3D p3)
        //{

        //}
        #endregion

        #region Query
        public Point3D Center { get; set; }

        public double Radius { get; set; }

        public Vector3D Axis { get; set; }
        #endregion

        #region Methods
        private void CreateWireCircle()
        {
            SwCurve = Util.CurveBuilder.CreateCircle(
                SldContextManager.Modeler, 
                Center, Axis, Radius);

            SwObject = SwCurve.CreateWireBody();

            if (SwObject != null)
            {
                DisplayBody();
            }
        }
        #endregion
    }
}
