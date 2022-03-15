using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Manager;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Geometry.GeometryBuilder
{
    [IsVisibleInDynamoLibrary(false)]
    public static class SurfaceBuilder
    {
        public static ISurface CreateCylindricalSurface(
            Point3D center,
            Vector3D direction,
            Vector3D refDirection,
            double raduis,UnitManager unitManager)
        {
            var newCenter = unitManager.ConvertPoint(center);
            raduis = unitManager.ConvertDouble(raduis);

            return SldContextManager.Modeler.CreateCylindricalSurface2(
                newCenter.ToArray(),
                direction.ToArray(),
                refDirection.ToArray(),
                raduis) as ISurface;
        }

        public static IBody2 CreateTrimmedCylindricalSurface(
                Point3D center,
                Vector3D direction,
                Vector3D refDirection,
                double raduis, UnitManager unitManager)
        {
            var newCenter = unitManager.ConvertPoint(center);
            raduis = unitManager.ConvertDouble(raduis);

            var surface = SldContextManager.Modeler.CreateCylindricalSurface2(
                newCenter.ToArray(),
                direction.ToArray(),
                refDirection.ToArray(),
                raduis) as ISurface;

            if (surface == null)
                return null;

            //裁剪
            var dPt = new double[] { 0, raduis, 0 };
            var curve = SldContextManager.Modeler.CreateArc(
                center.ToArray(),
                direction.ToArray(),
                raduis, 
                dPt, 
                dPt);

            dPt = new double[] { 0, raduis, raduis * 2 };
            var curve2 = SldContextManager.Modeler.CreateArc(
                new double[] { 0, 0, raduis * 2 },
                direction.ToArray(),
                raduis,
                dPt, dPt
                );

            var body = surface.CreateTrimmedSheet4(
                new object[] { curve, curve2 },
                true) as IBody2;

            return body;
        }
    }
}
