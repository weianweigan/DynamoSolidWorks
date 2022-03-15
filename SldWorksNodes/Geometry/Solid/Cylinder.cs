using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using System;

namespace SldWorksNodes.Geometry
{
    public class Cylinder : Body
    {
        #region Ctor
        public Cylinder(
            IBody2 body, 
            Point3D center, 
            Vector3D axis, 
            double radius, 
            double height):base(body)
        {
            Body = body;
            Center = center;
            Axis = axis;
            Radius = radius;
            Height = height;
        }
        #endregion

        #region Query
        public IBody2 Body { get; }

        public Point3D Center { get; }

        public Vector3D Axis { get; }

        public double Radius { get; }

        public double Height { get; }
        #endregion

        #region Create
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

            return new Cylinder(body,center,axis,radius,height);
        }
        #endregion
    }
}
