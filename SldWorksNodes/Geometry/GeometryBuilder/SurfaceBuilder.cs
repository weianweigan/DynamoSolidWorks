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
        public static IBody2 CreateSphereSurfaceSheet(
          IModeler modeler,
          Point3D point,
          double raduis
          )
        {
            var surface = modeler.CreateSphericalSurface2(
                point.ToArray(),
                new double[] { 1d, 0d, 0d },
                new double[] { 0d, 1d, 0d },
                raduis) as ISurface;

            var obj = new SolidWorks.Interop.sldworks.Curve[] { null,null,null};
            var body = surface.CreateTrimmedSheet4(obj, true) as IBody2;

            return body;
        }


        public static IBody2 CreateTrimmedCylindricalSheet(
                IModeler modeler,
                Point3D center,
                Vector3D direction,
                Vector3D refDirection,
                double raduis,
                double height)
        {
           
            var surface = modeler.CreateCylindricalSurface2(
                center.ToArray(),
                direction.ToArray(),
                refDirection.ToArray(),
                raduis) as ISurface;

            if (surface == null)
                return null;

            //裁剪
            var circle = CurveBuilder.CreateCircle(
                modeler, 
                center, direction,
                raduis);

            var normal = Vector3D.Normalized(direction);
            var endCenter = center + Vector3D.Multiply(direction, height);
            var circel2 = CurveBuilder.CreateCircle(
                modeler,
                endCenter,
                direction,
                raduis);

            var curves = new ICurve[] { circle,null, circel2};
            var body = surface.CreateTrimmedSheet4(
                curves,
                true) as IBody2;

            return body;
        }
    }
}
