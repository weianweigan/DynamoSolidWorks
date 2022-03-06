using Autodesk.DesignScript.Runtime;

namespace System.Windows.Media.Media3D
{
    [IsVisibleInDynamoLibrary(false)]
    internal static class Point3DExtension
    {
        public static double[] ToArray(this Point3D point,bool asMeter = false)
        {
            return asMeter ? new double[] { point.X/1000, point.Y/1000, point.Z /1000} : new double[] { point.X, point.Y, point.Z };
        }

        public static Point3D ToMeter(this Point3D point)
        {
            return new Point3D(point.X / 1000, point.Y / 1000,point.Z/1000);
        }

        public static bool ValueEquals(this Point3D point ,Point3D another,double eplision = 0.000001)
        {
            return Math.Abs(point.X - another.X) < eplision &&
                   Math.Abs(point.Y - another.Y) < eplision &&
                   Math.Abs(point.Z- another.Z) < eplision;
        }

        public static Vector3D AsVector(this Point3D point)
        {
            return new Vector3D(point.X, point.Y, point.Z);
        }

        public static Point ToPoint2D(this Point3D point)
        {
            return new Point(point.X, point.Y);
        }

    }

    public static class Vector3DExtension
    {
        public static double[] ToArray(this Vector3D vector3D,bool asMeter = false)
        {
            return asMeter ? new double[] { vector3D.X/1000, vector3D.Y/1000, vector3D.Z /1000} : new double[] { vector3D.X, vector3D.Y, vector3D.Z };
        }
    }


}
