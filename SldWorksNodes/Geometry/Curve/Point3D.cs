using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Util;
using System;

namespace SldWorksNodes.Geometry
{
    public class Point3D
    {
        #region Fields
        private double _x;
        private double _y;
        private double _z;
        #endregion

        #region Ctor
        internal Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        #endregion

        #region Query
        public double X { get => _x; set => _x = value; }

        public double Y { get => _y; set => _y = value; }

        public double Z { get => _z; set => _z = value; }
        #endregion

        #region Create
        public static Point3D ByCoordinates(double x, double y, double z)
        {
            return new Point3D(x, y, z);
        }

        public static Point3D Orign => new Point3D(0, 0, 0);
        #endregion

        #region Action
        public Point3D Add(Point3D point) =>
            new Point3D(
                _x + point.X,
                _y + point.Y,
                _z + point.Z);

        public Vector3D AsVector() =>
            new Vector3D(X, Y, Z);

        /// <summary>
        /// Subtract a vector from a point. 
        /// </summary>
        /// <returns></returns>
        public Vector3D Subtract(Point3D point) =>
            this - point;
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{X},{Y},{Z}";
        }

        internal System.Windows.Media.Media3D.Point3D ToData() =>
            new System.Windows.Media.Media3D.Point3D(X, Y, Z);

        internal double[] ToArray() => new double[] { _x, _y, _z };
        #endregion

        #region Operator
        public static Vector3D operator -(Point3D point1, Point3D point2)
        {
            return new Vector3D(
                point1.X - point2.X,
                point1.Y - point2.Y, 
                point1.Z - point2.Z);
        }

        public static Vector3D operator +(Point3D point1, Point3D point2)
        {
            return new Vector3D(
                point1.X - point2.X, 
                point1.Y - point2.Y,
                point1.Z - point2.Z);
        }

        public static Point3D operator +(Point3D point, Vector3D vector)
        {
            return new Point3D(
                point._x + vector.X,
                point._y + vector.Y, 
                point._z + vector.Z);
        }

        public static Point3D Add(Point3D point, Vector3D vector)
        {
            return new Point3D(
                point._x + vector.X, 
                point._y + vector.Y, 
                point._z + vector.Z);
        }

        public static Point3D operator -(Point3D point, Vector3D vector)
        {
            return new Point3D(
                point._x - vector.X, 
                point._y - vector.Y, 
                point._z - vector.Z);
        }
        #endregion
    }
}
