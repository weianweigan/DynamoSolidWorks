using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.sldworks;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace SldWorksNodes.Util
{
    [IsVisibleInDynamoLibrary(false)]
    internal static class BodyBuilder
    {
        public static IBody2 CreateFromBox(IModeler modeler,Point3D downLeft,Point3D topRight)
        {
            var data = ToBodyBox(
                SwContextUtil.UseMM ?
                new double[] {
                downLeft.X/1000, downLeft.Y/1000, downLeft.Z/1000,
                topRight.X/1000, topRight.Y/1000, topRight.Z/1000 } :
                new double[] {
                downLeft.X, downLeft.Y, downLeft.Z,
                topRight.X, topRight.Y, topRight.Z });
            return modeler.CreateBodyFromBox(data) as IBody2;
        }

        public static IBody2 CreateCylinderBody(IModeler modeler,Point3D center,Vector3D axis,double raduis,double height)
        {
            return modeler.CreateBodyFromCyl(
                SwContextUtil.UseMM ?
                    new double[]
            {
                center.X/1000,center.Y/1000,center.Z/1000,
                axis.X/1000,axis.Y/1000,axis.Z/1000,
                raduis/1000,
                height/1000
            }
                :new double[]
            {
                center.X,center.Y,center.Z,
                axis.X,axis.Y,axis.Z,
                raduis,
                height
            }) as IBody2;
        }

        private static double[] ToBodyBox(double[] box)
        {
            if (box is null)
            {
                throw new ArgumentNullException(nameof(box));
            }

            if (box.Length < 6)
            {
                throw new ArgumentException($"{nameof(box)} Length Error");
            }

            var result = new double[] {
                //底面中心
                (box[0] + box[3])/2,
                (box[1]+box[4])/2,
                box[2],

                //轴向
                0d,0d,1d,

                //长宽高
                box[3] - box[0],
                box[4] - box[1],
                box[5] - box[2],
            };

            return result;
        }

        public static IBody2 CreateConeBody(
            Point3D center,
            Vector3D axis, 
            double bottomRaduis, 
            double topRadius,
            double height)
        {
            var data =
                SwContextUtil.UseMM ?
                new double[]
            {
                center.X/1000,center.Y/1000, center.Z/1000,
                axis.X/1000, axis.Y/1000, axis.Z/1000,
                bottomRaduis/1000,
                topRadius/1000,
                height/1000
            }:
                new double[]
            {
                center.X,center.Y, center.Z,
                axis.X, axis.Y, axis.Z,
                bottomRaduis,
                topRadius,
                height
            };

            return SldContextManager.Modeler.CreateBodyFromCone(data) as IBody2;
        }

        public static IBody2 CreateSphere(
            Point3D point,
            double raduis
            )
        {
            var surface = SldContextManager.Modeler.CreateSphericalSurface2(
                point.ToArray(),
                new double[] { 0,0,1},
                new double[] { 1, 0, 1 },
                raduis) as ISurface;

            var body = surface.CreateTrimmedSheet4(null,true) as IBody2;            

            return body;
        }
    }
}
