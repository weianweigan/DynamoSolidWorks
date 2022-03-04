using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace SldWorksNodes.Util
{
    [IsVisibleInDynamoLibrary(false)]
    internal static class CurveBuilder
    {
        /// <summary>
        /// 创建剪裁后的直线
        /// </summary>
        /// <param name="modeler">造型接口</param>
        /// <param name="startPoint">起点：<see cref="Point3D"/></param>
        /// <param name="endPoint">终点：<see cref="Point3D"/></param>
        /// <returns>创建完成的Curve对象</returns>
        public static ICurve CreatedTrimmedLine(this IModeler modeler, Point3D startPoint, Point3D endPoint)
        {
            if (startPoint.Equals(endPoint))
                throw new ArgumentException($"{startPoint} == {endPoint}");

            var curve = (ICurve)modeler.CreateLine(startPoint.ToArray(), (endPoint - startPoint).ToArray());

            curve = curve.CreateTrimmedCurve2(startPoint.X, startPoint.Y, startPoint.Z, endPoint.X, endPoint.Y, endPoint.Z);

            return curve;
        }

        /// <summary>
        /// 创建裁剪后的圆弧
        /// </summary>
        /// <param name="modeler">造型接口</param>
        /// <param name="center">圆心</param>
        /// <param name="axis">轴</param>
        /// <param name="radius">半径</param>
        /// <param name="startPoint">起点</param>
        /// <param name="endPoint">终点</param>
        /// <returns>创建完成的Curve对象</returns>
        public static ICurve CreatedTrimmedArc(this IModeler modeler, Point3D center, Vector3D axis, double radius, Point3D startPoint, Point3D endPoint)
        {
            var arc = (ICurve)modeler.CreateArc(center.ToArray(), axis.ToArray(), radius, startPoint.ToArray(), endPoint.ToArray());

            arc = arc.CreateTrimmedCurve2(startPoint.X, startPoint.Y, startPoint.Z,
                endPoint.X, endPoint.Y, endPoint.Z);

            return arc;
        }

        public static ICurve CreateCircle(this IModeler modeler, Point3D center, Vector3D axis, double radius)
        {
            var planeAxis = axis;
            planeAxis.X += 0.1; planeAxis.Y += 0.1; planeAxis.Z += 0.1;
            var direction = Vector3D.CrossProduct(axis, planeAxis);
            direction.Normalize();
            var startPoint = center + Vector3D.Multiply(direction, radius);

            return CreatedTrimmedArc(modeler, center, axis, radius, startPoint, startPoint);
        }

        public static IEnumerable<ICurve> CreateBox(this IModeler modeler, Rect3D box)
        {
            var location = box.Location;
            var line1 = new Line3D(location, location + new Vector3D(box.SizeX, 0, 0));
            var line2 = new Line3D(location, location + new Vector3D(0, box.SizeY, 0));
            var line3 = new Line3D(location, location + new Vector3D(0, 0, box.SizeZ));


            var maxPoint = box.Location + new Vector3D(box.SizeX, box.SizeY, box.SizeZ);
            var line4 = new Line3D(maxPoint, maxPoint + new Vector3D(-box.SizeX, 0, 0));
            var line5 = new Line3D(maxPoint, maxPoint + new Vector3D(0, -box.SizeY, 0));
            var line6 = new Line3D(maxPoint, maxPoint + new Vector3D(0, 0, -box.SizeZ));

            var line7 = new Line3D(line1.EndPoint, line5.EndPoint);
            var line8 = new Line3D(line1.EndPoint, line6.EndPoint);

            var line9 = new Line3D(line2.EndPoint, line4.EndPoint);
            var line10 = new Line3D(line2.EndPoint, line6.EndPoint);

            var line11 = new Line3D(line3.EndPoint, line4.EndPoint);
            var line12 = new Line3D(line3.EndPoint, line5.EndPoint);

            var array = new Line3D[] { line1, line2, line3, line4, line5, line6, line7, line8, line9, line10, line11, line12 };

            foreach (var line in array)
            {
                var curve = modeler.CreatedTrimmedLine(line.StartPoint, line.EndPoint);
                yield return curve;
            }
        }
    }

}
