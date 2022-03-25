using System;
using SldWorksNodes.Geometry.GeometryBuilder;
using SldWorksNodes.Util;

namespace SldWorksNodes.Geometry
{
    public class CylindricalSurface:Surface
    {
        internal CylindricalSurface(
            Point3D center, 
            Vector3D direction,
            Vector3D refDirection,
            double radius,
            double height)
        {
            var nCenter = _swUnit.ConvertPoint(center);
            var nDirection = direction;
            var nRefDirection = refDirection;
            var nRadius = _swUnit.ConvertDouble(radius);
            var nHeight = _swUnit.ConvertDouble(height);

            CreateCylinderSurface(nCenter,nDirection,nRefDirection,nRadius,nHeight);
        }

        private void CreateCylinderSurface(
            Point3D center, 
            Vector3D direction, 
            Vector3D refDirection, 
            double radius,
            double height)
        {

            SwObject  = SurfaceBuilder.CreateTrimmedCylindricalSheet(
                SldContextManager.Modeler,
                center,
                direction,
                refDirection,
                radius,
                height);

            if (SwObject == null)
                throw new Exception("Create Failded");

            DisplayBody();
        }

        #region Create
        /// <summary>
        /// Create a cylinder surface by center direction and raduis
        /// </summary>
        /// <param name="center">location of  the center of the bottom</param>
        /// <param name="direction">direction of the axis of the cylindrical surface</param>
        /// <param name="radius">Radius at the center</param>
        /// <param name="height">Height</param>
        /// <returns></returns>
        public static Surface ByCenterDirectionsRaduis(
            Point3D center,
            Vector3D direction,
            double radius,
            double height)
        {
            if(center == null || direction == null)
                return null;

            if (radius <= 0)
                return null;

            var temDirection = Vector3D.ByCoordinates(direction.X + 0.1,
                direction.Y + 0.1, direction.Z + 0.1);

            var refDirection = Vector3D.CrossProduct(direction, temDirection);

            return new CylindricalSurface(
                center, 
                direction,
                refDirection,
                radius,
                height);
        }
        #endregion
    }
}
