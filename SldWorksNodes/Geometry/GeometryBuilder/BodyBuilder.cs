using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Geometry;
using SldWorksNodes.Manager;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.Util
{
    [IsVisibleInDynamoLibrary(false)]
    public static class BodyBuilder
    {
        #region Base Geometry
        public static IBody2 CreateFromBox(
            IModeler modeler,
            Point3D downLeft,
            Point3D topRight)
        {
            var data = ToBodyBox(
                new double[] {
                downLeft.X, downLeft.Y, downLeft.Z,
                topRight.X, topRight.Y, topRight.Z });

            return modeler.CreateBodyFromBox(data) as IBody2;
        }

        public static IBody2 CreateCylinderBody(
            IModeler modeler,
            Point3D center,
            Vector3D axis,
            double raduis,
            double height)
        {
            return modeler.CreateBodyFromCyl(
               new double[]
            {
                center.X,center.Y,center.Z,
                axis.X,axis.Y,axis.Z,
                raduis,
                height
            }) as IBody2;
        }

        public static IBody2 CreateConeBody(
            Point3D center,
            Vector3D axis, 
            double bottomRaduis, 
            double topRadius,
            double height)
        {
            var data =
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
        #endregion

        #region ByModeler
        public static IBody2 Extrued(
                IModeler modeler,
                List<Geometry.Curve> curves,
                MathVector direction,
                double length)
        {
            var swUnit = new UnitManager();

            var nLength = swUnit.ConvertDouble(length);
            //取三点
            List<Point3D> points = new List<Point3D>();
            foreach (var curve in curves)
            {
                points.AddRange(curve.GetParamPoints());
                if (points.Count >= 3)
                    break;
            }

            //三点确定平面
            var xAxis = points[1] - points[0];
            var yAxis = points[2] - points[0];
            var zAxis = Vector3D.CrossProduct(xAxis, yAxis);

            var surface = modeler.CreatePlanarSurface2(
                points[0].ToArray(),
                zAxis.ToArray(),
                xAxis.ToArray()) as ISurface;

            if (surface == null)
                return null;

            var swCurves = curves.Select(p => p.SwCurve).ToArray();

            var sheetBody = surface.CreateTrimmedSheet4(
                swCurves,
                false) as Body2;
            if (sheetBody == null)
                return null;

            var body = modeler.CreateExtrudedBody(
                sheetBody,
                direction,
                nLength) as IBody2;

            return body;
        }
        
        //TODO 放样 旋转 扫描


        #endregion


        #region Private Methods
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
        #endregion
    }
}
