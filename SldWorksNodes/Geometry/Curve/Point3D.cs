using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Util;
using System;

namespace SldWorksNodes.Geometry
{
    public class Point3D
    {
        internal Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        public static Point3D ByCoordinate(double x,double y,double z)
        {
            return new Point3D(x, y, z);
        }

        public static Point3D Orign => new Point3D(0,0,0);

        public override string ToString()
        {
            return $"{X},{Y},{Z}";
        }

        internal System.Windows.Media.Media3D.Point3D ToData()
        {
            return  
                SwContextUtil.UseMM ?
                new System.Windows.Media.Media3D.Point3D(X/1000,Y/1000,Z/1000) :
            new System.Windows.Media.Media3D.Point3D(X,Y,Z);
        }
    }
}
