using SldWorksNodes.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.Transform
{
    public class Transform
    {
        internal Transform(Point3D postion, Vector3D xAxis, Vector3D yAxis, Vector3D zAxis)
        {
            Postion = postion;
            XAxis = xAxis;
            YAxis = yAxis;
            ZAxis = zAxis;
        }

        public Point3D Postion { get; }
        public Vector3D XAxis { get; }
        public Vector3D YAxis { get; }
        public Vector3D ZAxis { get; }

        public static Transform ByPostionAndDirection(Point3D postion,Vector3D xAxis,Vector3D yAxis,Vector3D zAxis)
        {
            if(postion == null || xAxis == null || yAxis == null || zAxis == null)
                return null;

            return new Transform(postion, xAxis, yAxis, zAxis);
        }

        public static Transform ByPostion(Point3D postion)
        {
            if (postion == null)
                return null;

            return new Transform(postion, Vector3D.XAxis(), Vector3D.YAxis(), Vector3D.ZAxis());
        }

        public override string ToString()
        {
            return $"{Postion}-{XAxis}-{YAxis}-{ZAxis}";
        }
    }
}
