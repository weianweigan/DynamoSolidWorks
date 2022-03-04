using SldWorksNodes.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.Geometry
{
    public class Circle3D: SwCurveBodyNode
    {
       internal Circle3D(Point3D center, double radius, Vector3D axis)
        {
            Center = center;
            Radius = radius;
            Axis = axis;

            CreateWireCircle();
        }

        public static Circle3D ByCenterRadiusAixs(Point3D center, double radius, Vector3D axis)
        {
            return new Circle3D(center, radius, axis);
        }

        public static Circle3D ByCenterRadius(Point3D center, double radius)
        {
            return new Circle3D(center, radius, new Vector3D(0,0,1));
        }

        public Point3D Center { get; set; }

        public double Radius { get; set; }

        public Vector3D Axis { get; set; }

        private void CreateWireCircle()
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();
            var curve = Util.CurveBuilder.CreateCircle(SldContextManager.Modeler, Center.ToData(), Axis.ToData(), Radius);

            SwObject = curve.CreateWireBody();

            if (SwObject != null)
            {
                DisplayBody(doc, Color);
            }
        }
    }
}
