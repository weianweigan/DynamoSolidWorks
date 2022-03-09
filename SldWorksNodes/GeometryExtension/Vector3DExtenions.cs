
using Autodesk.DesignScript.Runtime;

namespace System.Windows.Media.Media3D
{
    [IsVisibleInDynamoLibrary(false)]
    public enum VectorStatus
    {
        /// <summary>
        /// 水平，沿着X+或者X-方向
        /// </summary>
        Hor,

        /// <summary>
        /// 竖直，沿着Y+或者Y-方向
        /// </summary>
        Vec,

        /// <summary>
        /// 竖直，沿着Z+或者Z-方向
        /// </summary>
        Normal,

        /// <summary>
        /// 倾斜
        /// </summary>
        Lean
    }

    [IsVisibleInDynamoLibrary(false)]
    public static class Vector3DExtenions
    {
        public static double AngleRadians(this Vector3D vector,Vector3D another)
        {
            vector.Normalize();
            another.Normalize();
            double num = Vector3D.DotProduct(vector, another);
            double radians = (!(num < 0.0)) ? (2.0 * Math.Asin((vector - another).Length / 2.0)) : (Math.PI - 2.0 * Math.Asin((-vector - another).Length / 2.0));
            
            return radians;
        }

        public static VectorStatus VectorStatus(this Vector3D vector,double eplison = 0.00001)
        {
            if (Math.Abs(Math.Abs(vector.X) - Math.Abs(vector.Length)) < eplison)
                return Media3D.VectorStatus.Hor;
            else if (Math.Abs(Math.Abs(vector.Y) - Math.Abs(vector.Length)) < eplison)
                return Media3D.VectorStatus.Vec;
            else if (Math.Abs(Math.Abs(vector.Z) - Math.Abs(vector.Length)) < eplison)
                return Media3D.VectorStatus.Normal;
            else
                return Media3D.VectorStatus.Lean;
        }

        /// <summary>
        /// 是否平行
        /// </summary>
        public static bool IsPara(this Vector3D vec,Vector3D another,double eplison = 0.00001)
        {
            var angle = Vector3D.AngleBetween(vec, another);
            return Math.Abs(angle) < eplison || Math.Abs(angle - 180) < eplison;
        }

        /// <summary>
        /// 两个相连是否同向
        /// </summary>
        public static bool IsSameDirection(this Vector3D vector,Vector3D another, double eplison = 0.00001)
        {
            var angle = Vector3D.AngleBetween(vector, another);

            return Math.Abs(angle) < eplison;
        }

        /// <summary>
        /// 是否垂直
        /// </summary>
        public static bool IsPerpendicular(this Vector3D vec,Vector3D another,double eplison = 0.00001)
        {
            var angle = Vector3D.AngleBetween(vec, another);
            return Math.Abs(angle - 90) < eplison || Math.Abs(angle - 270) < eplison;
        }

        /// <summary>
        /// 把当前向量投影到另外一个向量上
        /// </summary>
        /// <param name="vec">当前向量</param>
        /// <param name="another">另外一个向量</param>
        /// <returns>投影后的长度</returns>
        public static double Project(this Vector3D vec,Vector3D another)
        {
            return Vector3D.DotProduct(vec, another) / Vector3D.DotProduct(another, another);
        }

        public static Vector3D TransformBy(this Vector3D vec,Transform3D transform)
        {
            return transform.Transform(vec);
        }

        public static Vector ToVector2D(this Vector3D vector)
        {
            return new Vector(vector.X, vector.Y);
        }

        public  static Size3D ToSize3D(this Vector3D vector)
        {
            return new Size3D(vector.X, vector.Y, vector.Z);
        }

        public static bool IsX(this Vector3D vector)
        {
            return (Math.Abs(Math.Abs(vector.X) - vector.Length) < 0.00001);
        }

        public static bool IsY(this Vector3D vector)
        {
            return (Math.Abs(Math.Abs(vector.Y) - vector.Length) < 0.00001);
        }

        public static bool IsZ(this Vector3D vector)
        {
            return (Math.Abs(Math.Abs(vector.Z) - vector.Length) < 0.00001);
        }
    }
}
