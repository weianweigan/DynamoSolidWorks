using SldWorksNodes.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SldWorksNodes.Geometry
{
    public class Arc3D : SwBodyNode
    {
        internal Arc3D(Point3D center, Vector3D axis, double radius, Point3D startPoint, Point3D endPoint)
        {
            Center = center;
            Axis = axis;
            Radius = radius;
            StartPoint = startPoint;
            EndPoint = endPoint;

            CreateWireArc();
        }

        public static Arc3D CreateArc(Point3D center, Vector3D axis, double radius, Point3D startPoint, Point3D endPoint)
        {
            return new Arc3D(center, axis, radius, startPoint, endPoint);
        }

        private void CreateWireArc()
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();
            var curve = Util.CurveBuilder.CreatedTrimmedArc(SldContextManager.Modeler, Center.ToData(), Axis.ToData(), Radius, StartPoint.ToData(), EndPoint.ToData());

            SwObject = curve.CreateWireBody();

            if (SwObject != null)
            {
                DisplayBody(doc, Color);
            }
        }

        public Point3D Center { get; }

        public Vector3D Axis { get; }

        public double Radius { get; }

        public Point3D StartPoint { get; }

        public Point3D EndPoint { get; }
    }
}
