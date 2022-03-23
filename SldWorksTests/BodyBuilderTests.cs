using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SldWorksNodes.Geometry;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;

namespace SldWorksTests
{
    public class BodyBuilderTests
    {
        [Test]
        public void CreateFromBoxTest(ISldWorks app)
        {
            var modler = app.GetModeler() as Modeler;

            var body = BodyBuilder.CreateFromBox(modler,
                Point3D.ByCoordinates(0, 0, 0),
                Point3D.ByCoordinates(0.1, 0.1, 0.1)
                );

            Assert.NotNull(body);
        }

        [Test]
        public void CreateCylinderBodyTest(ISldWorks app)
        {
            var modler = app.GetModeler() as Modeler;

            var body = BodyBuilder.CreateCylinderBody(modler,
                Point3D.ByCoordinates(0, 0, 0),
                Vector3D.ByCoordinates(0,0,1),
                0.1,
                0.1
                );

            Assert.NotNull(body);
        }

    }
}
