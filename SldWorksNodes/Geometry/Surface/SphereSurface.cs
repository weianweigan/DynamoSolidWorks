using SldWorksNodes.Geometry.GeometryBuilder;
using SldWorksNodes.Util;

namespace SldWorksNodes.Geometry
{
    public class SphereSurface:SurfaceBody
    {
        #region Ctor
        internal SphereSurface(Point3D center, double raduis)
        {
            var nCenter = _swUnit.ConvertPoint(center);
            var nR =_swUnit.ConvertDouble(raduis);

            CreateSphereSurface(nCenter, nR);
        }
        #endregion

        #region Create
        public static SurfaceBody ByCenterRadius(
            Point3D center,
            double raduis)
        {
            if (center == null || raduis <= 0)
            {
                return null;
            }

            return new SphereSurface(center, raduis);
        }
        #endregion

        #region Methods
        private void CreateSphereSurface(Point3D center, double radius)
        {
            SwObject = SurfaceBuilder.CreateSphereSurfaceSheet(
                SldContextManager.Modeler,
                center, radius);
        }
        #endregion
    }
}
