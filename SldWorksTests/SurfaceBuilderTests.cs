using NUnit.Framework;
using SldWorksNodes.Geometry;
using SldWorksNodes.Geometry.GeometryBuilder;
using SolidWorks.Interop.sldworks;

namespace SldWorksTests
{
    public class SurfaceBuilderTests
    {
        [Test]
        public void CreateTrimmedCylindricalSheetTest(ISldWorks app)
        {
            var modler = app.GetModeler() as Modeler;

            var cylinderSheet = SurfaceBuilder.CreateTrimmedCylindricalSheet(
                modler,
                Point3D.ByCoordinates(0, 0, 0),
                Vector3D.ZAxis,
                Vector3D.XAxis,
                0.1,
                0.2);

            Assert.NotNull(cylinderSheet);
        }

        [Test]
        public void CreateSphereTest(ISldWorks app)
        {
            var modler = app.GetModeler() as Modeler;

            var body = SurfaceBuilder.CreateSphereSurfaceSheet(
                modler,
                Point3D.ByCoordinates(0, 0, 0),
                0.1
                );

            Assert.NotNull(body);
        }
    }
}
