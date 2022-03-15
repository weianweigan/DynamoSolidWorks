using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SldWorksNodes.Geometry.GeometryBuilder;

namespace SldWorksNodes.Geometry
{
    public class CylindricalSurface:SurfaceBody
    {
        public CylindricalSurface(
            SolidWorks.Interop.sldworks.IBody2 body,
            Point3D center, 
            Vector3D direction,
            Vector3D refDirection,
            double radius):base(body)
        {
            Center = center;
            Direction = direction;
            RefDirection = refDirection;
            Radius = radius;
        }

        public Point3D Center { get; }
        public Vector3D Direction { get; }
        public Vector3D RefDirection { get; }
        public double Radius { get; }
        #region Create
        /// <summary>
        /// 
        /// </summary>
        /// <param name="center">location of  the center of the bottom</param>
        /// <param name="direction">direction of the axis of the cylindrical surface</param>
        /// <param name="refDirection">direction of the axis of the cylindrical surface</param>
        /// <param name="radius">Radius at the center</param>
        /// <returns></returns>
        public SurfaceBody ByCenterPointDirectionsAndRaduis(
            Point3D center,
            Vector3D direction,
            Vector3D refDirection,
            double radius)
        {
            if (radius <= 0)
                return null;

            var body = SurfaceBuilder.CreateTrimmedCylindricalSurface(
                center,
                direction,
                refDirection,
                radius, 
                _swUnit);

            if (body == null)
                return null;

            return new CylindricalSurface(
                body, 
                center, 
                direction,
                refDirection,
                radius);
        }
        #endregion
    }
}
