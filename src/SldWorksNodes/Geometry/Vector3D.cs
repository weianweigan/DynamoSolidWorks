using Autodesk.DesignScript.Runtime;
using System;

namespace SldWorksNodes.Geometry
{
    public class Vector3D
    {
        internal Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector3D ByDirection(double x,double y,double z)
        {
            return new Vector3D(x,y,z);
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        internal double[] ToArray()
        {
            return new[] { X, Y, Z };
        }

        internal System.Windows.Media.Media3D.Vector3D ToData()
        {
            return new System.Windows.Media.Media3D.Vector3D(X, Y, Z);
        }
    }
}
