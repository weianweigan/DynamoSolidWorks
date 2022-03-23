using SldWorksNodes.Util;
using System;

namespace SldWorksNodes.Geometry
{
    public class Arc : Curve
    {
        #region Ctor
        internal Arc(
            Point3D center,
            Vector3D axis, 
            double radius, 
            Point3D startPoint,
            Point3D endPoint)
        {
            var Center = _swUnit.ConvertPoint(center);
            var Radius = _swUnit.ConvertDouble(radius);
            var StartPoint = _swUnit.ConvertPoint(startPoint);
            var EndPoint = _swUnit.ConvertPoint(endPoint);

            CreateWireArc(center, axis, radius, startPoint, endPoint);
        }
        #endregion

        #region Create
        public static Arc ByCenterNormalRaduisAngle(
            Point3D center,
            Vector3D normal, 
            double radius,
            double startAngle,
            double endAngle)
        {
            if (radius <= 0 || startAngle == endAngle)
                return null;
            if (center == null || normal == null)
                return null;

            var xAxis = new Vector3D(1, 0, 0);
            if (!normal.IsZ())
            {
                xAxis = Vector3D.CrossProduct(
                    new Vector3D(normal.X + 0.1, normal.Y + 0.1, normal.Z + 0.1),
                    normal);
            }
            var yAxis = Vector3D.CrossProduct(xAxis, normal);
            var unitNorml = Vector3D.Normalized(normal);

            var orignSpt = center + unitNorml * radius;

            var startPoint = ApplyRotate(normal, startAngle, orignSpt);
            var endPoint = ApplyRotate(normal, endAngle, orignSpt);

            return new Arc(center, normal, radius, startPoint, endPoint);
        }

        public static Arc ByCenterNormalStartPointEndPoint(
            Point3D center,
            Vector3D normal,
            Point3D startPoint,
            Point3D endPoint)
        {
            var radius = (center.ToData() - startPoint.ToData()).Length;
            return new Arc(center, normal,Math.Abs(radius), startPoint, endPoint);
        }

        //public static Arc3D ByBestFitThroughPoints(List<Point3D> points)
        //{

        //}

        //public static Arc3D ByFillet(
        //    SwCurveBodyNode curve1,
        //    SwCurveBodyNode curve2)
        //{

        //}

        /// <summary>
        /// Create an arc by providing it's center point, radius, angle sweep
        /// </summary>
        /// <returns></returns>
        public static Arc ByCenterPointRadiusAngle(
            Point3D center,
            double radius,
            double startAngle,
            double endAngle)
        {
            return ByCenterNormalRaduisAngle(center,Vector3D.ZAxis,radius,startAngle,endAngle); 
        }

        //public Arc3D ByThreePoints(
        //    Point3D pt1,Point3D pt2,Point3D pt3)
        //{

        //}

        //public Arc3D ByStartPointEndPointStartTangent(
        //    Point3D startPoint, 
        //    Point3D endPoint,
        //    Vector3D startTangent)
        //{

        //}
        #endregion

        #region Query
    
        #endregion

        #region Methods
        private void CreateWireArc(
            Point3D center,
            Vector3D axis,
            double radius, 
            Point3D startPoint,
            Point3D endPoint)
        {

           SwCurve = Util.CurveBuilder.CreatedTrimmedArc(
               SldContextManager.Modeler,
               center, 
               axis,
               radius, 
               startPoint,
               endPoint);

            SwObject = SwCurve.CreateWireBody();

            if (SwObject != null)
            {
                DisplayBody();
            }
        }

        private static Point3D ApplyRotate(Vector3D normal, double startAngle, Point3D startPt)
        {
            var rotate = new System.Windows.Media.Media3D.AxisAngleRotation3D(normal.ToData(), startAngle);
            var trans = new System.Windows.Media.Media3D.RotateTransform3D(rotate);

            var startPointData = trans.Transform(startPt.ToData());
            var startPoint = Point3D.ByCoordinates(startPointData.X, startPointData.Y, startPointData.Z);
            return startPoint;
        }
        #endregion
    }
}
