using SldWorksNodes.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace SldWorksNodes.Geometry
{
    public class Arc3D : SwCurveBodyNode
    {
        #region Ctor
        internal Arc3D(Point3D center, Vector3D axis, double radius, Point3D startPoint, Point3D endPoint)
        {
            Center = center;
            Axis = axis;
            Radius = radius;
            StartPoint = startPoint;
            EndPoint = endPoint;

            CreateWireArc();
        }
        #endregion

        //public static Arc3D ByCenterAxisRaduisAngle(Point3D center, Vector3D axis, double radius, double startAngle, double endAngle)
        //{
        //    if (radius <= 0)
        //        return null;

        //    var hor = new System.Windows.Media.Media3D.Vector3D(1, 0, 0);
        //    if (!axis.ToData().IsZ())
        //    {
        //        hor = System.Windows.Media.Media3D.Vector3D.CrossProduct(new System.Windows.Media.Media3D.Vector3D(0, 0, 1), axis.ToData());
        //    }

        //    return CreateArc(center, axis, radius, startPoint, endPoint);
        //}

        #region Create
        public static Arc3D ByCenterPointStartPointEndPoint(
            Point3D center,
            Vector3D normal,
            Point3D startPoint,
            Point3D endPoint)
        {
            var radius = (center.ToData() - startPoint.ToData()).Length;
            return new Arc3D(center, normal,Math.Abs(radius), startPoint, endPoint);
        }

        //public static Arc3D ByBestFitThroughPoints(List<Point3D> points)
        //{

        //}

        //public static Arc3D ByFillet(
        //    SwCurveBodyNode curve1,
        //    SwCurveBodyNode curve2)
        //{

        //}

        ///// <summary>
        ///// Create an arc by providing it's center point, radius, angle sweep, and normal vector
        ///// </summary>
        ///// <returns></returns>
        //public static Arc3D ByCenterPointRadiusAngle(
        //    Point3D center,
        //    double radius,
        //    double startAngle,
        //    double endAngle,
        //    Vector3D normal)
        //{


        //}

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
        public Point3D Center { get; }

        public Vector3D Axis { get; }

        public double Radius { get; }

        public Point3D StartPoint { get; }

        public Point3D EndPoint { get; }
        #endregion

        #region Methods
        private void CreateWireArc()
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();
            SwCurve = Util.CurveBuilder.CreatedTrimmedArc(SldContextManager.Modeler, Center.ToData(), Axis.ToData(), Radius, StartPoint.ToData(), EndPoint.ToData());

            SwObject = SwCurve.CreateWireBody();

            if (SwObject != null)
            {
                DisplayBody(doc, Color);
            }
        }
        #endregion
    }
}
