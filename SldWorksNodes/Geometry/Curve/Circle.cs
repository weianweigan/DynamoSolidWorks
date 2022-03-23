using Autodesk.DesignScript.Interfaces;
using SldWorksNodes.Util;

namespace SldWorksNodes.Geometry
{
    public class Circle: Curve
    {
        #region Ctor
        internal Circle(Point3D center, double radius, Vector3D axis)
        {
            var nCenter = _swUnit.ConvertPoint(center);
            var nRadius = _swUnit.ConvertDouble(radius);

            CreateWireCircle(nCenter,nRadius,axis);
        }
        #endregion

        #region Create
        public static Circle ByCenterPointRadiusNormal(
            Point3D center, 
            double radius, 
            Vector3D normal)
        {
            return new Circle(center, radius, normal);
        }

        public static Circle ByCenterPointRadius(
            Point3D center, 
            double radius)
        {
            return new Circle(center, radius, new Vector3D(0,0,1));
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
        #endregion

        #region Methods
        private void CreateWireCircle(Point3D center, double radius, Vector3D axis)
        {
            SwCurve = Util.CurveBuilder.CreateCircle(
                SldContextManager.Modeler, 
                center, axis, radius);

            SwObject = SwCurve.CreateWireBody();

            if (SwObject != null)
            {
                DisplayBody();
            }
        }
        #endregion
    }
}
