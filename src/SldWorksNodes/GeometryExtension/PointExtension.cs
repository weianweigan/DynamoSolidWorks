using Autodesk.DesignScript.Runtime;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Media.Media3D;

namespace System.Windows
{
    [IsVisibleInDynamoLibrary(false)]
    public static class PointExtension
    {
        public static double[] ToArray(this Point point)
        {
            return new double[] { point.X, point.Y };
        }

        public static double[] ToArray3(this Point point, bool toMeter = false)
        {
            return toMeter ? new double[] { point.X / 1000, point.Y / 1000, 0 } : new double[] { point.X, point.Y, 0 };
        }

        public static Point Translate(this Point pt,double x,double y)
        {
            return new Point(pt.X + x, pt.Y + y);
        }

        public static Point Scale(this Point pt,double scale)
        {
            return new Point(scale * pt.X , scale* pt.Y );
        }

        public static Point3D ToPoint3D(this Point point, bool toMeter = false)
        {
            return toMeter ? new Point3D(point.X / 1000, point.Y / 1000, 0) : new Point3D(point.X, point.Y, 0);
        }

        public static bool ValueEquals(this Point point,Point another,double eplision = 0.00001)
        {
            return Math.Abs(point.X - another.X) < eplision &&
                   Math.Abs(point.Y - another.Y) < eplision;
        }

        public static Point ToMeter(this Point point)
        {
            return new Point(point.X / 1000, point.Y / 1000);
        }
    }

    public static class PointsExtension
    {
        public static IEnumerable<Point3D> XYToX_Z(this IEnumerable<Point> points,bool toMeter = false)
        {
            foreach (var point in points)
            {
               yield  return toMeter ? new Point3D(point.X / 1000, 0, -point.Y / 1000) : new Point3D(point.X, 0, -point.Y);
            }
        }

        public static Point3D XYToX_Z(this Point point,bool toMeter = false)
        {
            return toMeter ? new Point3D(point.X / 1000, 0, -point.Y / 1000) : new Point3D(point.X, 0, -point.Y);
        }

        public static IEnumerable<Point3D> Transform(this IEnumerable<Point3D> points,GeneralTransform3D transform)
        {
            foreach (var point in points)
            {
                yield return transform.Transform(point);
            }
        }

        public static IEnumerable<Point3D> Translate(this IEnumerable<Point3D> points,double x,double y,double z)
        {
            foreach (var point in points)
            {
                yield return new Point3D(point.X + x, point.Y + y, point.Z + z);
            }
        }

        public static Point3D Translate(this Point3D point,double x ,double y,double z)
        {
            return new Point3D(point.X + x, point.Y + y, point.Z + z);
        }

        public static Point3D TransformBy(this Point3D point, Transform3D transform)
        {
            return transform.Transform(point);
        }
    }
}
