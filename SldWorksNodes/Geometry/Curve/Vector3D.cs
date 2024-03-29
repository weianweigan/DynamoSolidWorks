﻿using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Util;
using System;

namespace SldWorksNodes.Geometry
{
    public class Vector3D
    {
        private double _x;
        private double _y;
        private double _z;

        internal Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        #region Create
        public static Vector3D ByCoordinates(double x = 0, double y = 0, double z = 0)
        {
            return new Vector3D(x, y, z);
        }

        public static Vector3D ByCoordinates(double x, double y, double z, bool normalized)
        {
            if (normalized)
            {
                var vec = new System.Windows.Media.Media3D.Vector3D(x, y, z);
                vec.Normalize();
                return ByCoordinates(vec.X, vec.Y, vec.Z);
            }
            else
            {
                return ByCoordinates(x,y,z);
            }
        }

        public static Vector3D ByTwoPoints(Point3D startPoint,Point3D endPoint)
        {
            return (startPoint - endPoint);
        }

        public static Vector3D XAxis => new Vector3D(1, 0, 0);

        public static Vector3D YAxis => new Vector3D(0, 1, 0);

        public static Vector3D ZAxis => new Vector3D(0, 0, 1);

        #endregion

        #region Action
        public static Vector3D Add(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(
                vector1._x + vector2._x,
                vector1._y + vector2._y, 
                vector1._z + vector2._z);
        }

        public static Vector3D Subtract(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D(
                vector1._x - vector2._x,
                vector1._y - vector2._y, 
                vector1._z - vector2._z);
        }

        public static Point3D Add(Vector3D vector, Point3D point)
        {
            return new Point3D(
                vector._x + point.X,
                vector._y + point.Y,
                vector._z + point.Z);
        }

        public static Point3D Subtract(Vector3D vector, Point3D point)
        {
            return new Point3D(
                vector._x - point.X, 
                vector._y - point.Y, 
                vector._z - point.Z);
        }

        public static Vector3D CrossProduct(Vector3D vector1, Vector3D vector2)
        {
            var result = new Vector3D(0,0,0);
            result._x = vector1._y * vector2._z - vector1._z * vector2._y;
            result._y = vector1._z * vector2._x - vector1._x * vector2._z;
            result._z = vector1._x * vector2._y - vector1._y * vector2._x;
            return result;
        }

        public static Vector3D Multiply(Vector3D vector, double scalar)
        {
            return new Vector3D(
                vector._x * scalar, 
                vector._y * scalar,
                vector._z * scalar);
        }

        public static Vector3D Divide(Vector3D vector, double scalar)
        {
            return vector * (1.0 / scalar);
        }

        public static double DotProduct(Vector3D vector1, Vector3D vector2)
        {
            return DotProduct(ref vector1, ref vector2);
        }

        public static double AngleBetween(Vector3D vector1, Vector3D vector2)
        {
            return System.Windows.Media.Media3D.Vector3D.AngleBetween(
                vector1.ToData(),
                vector2.ToData());
        }

        /// <summary>
        /// 是否平行
        /// </summary>
        public static bool IsPara(Vector3D vec, Vector3D another)
        {
            double eplison = 0.00001;
            var angle = Vector3D.AngleBetween(vec, another);
            return Math.Abs(angle) < eplison || Math.Abs(angle - 180) < eplison;
        }

        public static Vector3D Normalized(Vector3D vector)
        {
            var vec = new System.Windows.Media.Media3D.Vector3D(
                vector.X, vector.Y, vector.Z);
            vec.Normalize();
            return ByCoordinates(vec.X, vec.Y, vec.Z);
        }

        #endregion

        #region Query
        public double X { get => _x; set => _x = value; }

        public double Y { get => _y; set => _y = value; }

        public double Z { get => _z; set => _z = value; }
        #endregion

        #region Methods

        internal static double DotProduct(
            ref Vector3D vector1,
            ref Vector3D vector2) =>
                vector1._x * vector2._x +
                vector1._y * vector2._y +
                vector1._z * vector2._z;

        internal double[] ToArray() => 
            new[] { X, Y, Z };

        internal System.Windows.Media.Media3D.Size3D ToSize() =>
            new System.Windows.Media.Media3D.Size3D(X, Y, Z);

        internal System.Windows.Media.Media3D.Vector3D ToData() =>
            new System.Windows.Media.Media3D.Vector3D(X, Y, Z);

        internal bool IsZ(double eplision = 0.00001)
        {
            return Math.Abs(X) < eplision && Math.Abs(Y) < eplision;
        }

        #endregion

        #region Operator

        public static Vector3D operator /(Vector3D vector, double scalar)
        {
            return vector * (1.0 / scalar);
        }

        public static Vector3D operator *(Vector3D vector, double scalar)
        {
            return new Vector3D(vector._x * scalar, vector._y * scalar, vector._z * scalar);
        }

        public static Vector3D operator *(double scalar, Vector3D vector)
        {
            return new Vector3D(vector._x * scalar, vector._y * scalar, vector._z * scalar);
        }

        [IsVisibleInDynamoLibrary(false)]
        public static bool Equals(Vector3D vector1, Vector3D vector2)
        {
            if (vector1.X.Equals(vector2.X) && vector1.Y.Equals(vector2.Y))
            {
                return vector1.Z.Equals(vector2.Z);
            }

            return false;
        }

        #endregion
    }
}
