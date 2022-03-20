using SldWorksNodes.Util;

namespace SldWorksNodes.Geometry
{
    public class Sphere : Body
    {
        public Sphere(
            Point3D center, 
            double raduis):base(null)
        {
            var nCenter = _swUnit.ConvertPoint(center);
            var nRaduis = _swUnit.ConvertDouble(raduis);

            CreateSphere(nCenter, nRaduis);
        }

        #region Create
        public static Sphere ByCenterPointRaduis(
            Point3D center,
            double raduis)
        {
            if (center == null
                || raduis < 0)
                return null;

            return new Sphere(center, raduis);
        }
        #endregion

        #region Methods
        private void CreateSphere(Point3D center, double raduis)
        {
            SwObject = BodyBuilder.CreateSphere(center.ToData(), raduis);
            if (_display)
                DisplayBody();
        }
        #endregion
    }
}
 