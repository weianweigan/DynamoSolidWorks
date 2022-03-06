using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using System;

namespace SldWorksNodes.Geometry
{
    public class Cylinder : Body
    {
        internal Cylinder(IBody2 body, bool display = true) : base(body, display)
        {

        }

        public static Body ByCenterAxisRaduisHeight(Point3D center, Vector3D axis, double radius, double height)
        {
            if (radius < 0)
                throw new ArgumentException("Raduis > 0");
            if (height < 0)
                throw new ArgumentException("Height > 0");

            var body = BodyBuilder.CreateCylinderBody(
                SldContextManager.Modeler,
                center.ToData(),
                axis.ToData(),
                radius,
                height);

            if (body == null)
                throw new NullReferenceException("Create Body Error");

            return new Body(body);
        }
    }
}
