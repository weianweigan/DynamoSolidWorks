/*
 * Created By WeiGan 2021.3.23
 * 1.添加对于 Transform3D类的变换向量的扩展方法
 * -----2021.3.26--------
 * 1.添加变换矩阵求逆
 * 
 * ---------2021.3.31 Modified By WeiGan-----
 * 1.添加获取各个轴向量方法
 * 
 * ---------2021.4.1 Modified By WeiGan------
 * 1.添加TransformLine3D方法
 * 
 */

using Autodesk.DesignScript.Runtime;

namespace System.Windows.Media.Media3D
{

    [IsVisibleInDynamoLibrary(false)]
    public static class Transform3DExtension
    {
        /// <summary>
        /// 使用此变换矩阵变换向量,<see cref="Transform3D.Transform(Vector3D)"/> 已经实现，不需要使用此方法
        /// </summary>
        /// <param name="vector">需要被变换的向量</param>
        /// <returns>变换结果</returns>
        [Obsolete("Transform3D.Transform(Vector3D)已经实现，不需要使用此方法")]
        public static Vector3D TransformVector(this Transform3D transform, Vector3D vector)
        {
            var orign = new Point3D(transform.Value.OffsetX, transform.Value.OffsetY, transform.Value.OffsetZ);

            var vectorRes = transform.Transform(new Point3D(vector.X, vector.Y, vector.Z));
            return vectorRes - orign;
        }

        /// <summary>
        /// 取逆矩阵
        /// </summary>
        /// <param name="transform"></param>
        /// <returns></returns>
        public static Transform3D Inverse(this Transform3D transform)
        {
            var matrix = transform.Value;
            matrix.Invert();
            return new MatrixTransform3D(matrix);
        }

        /// <summary>
        /// 获取X轴向量
        /// </summary>
        public static Vector3D GetXAxis(this Transform3D transform)
        {
            return new Vector3D(transform.Value.M11, transform.Value.M12, transform.Value.M13);
        }

        /// <summary>
        /// 获取Y轴向量
        /// </summary>
        public static Vector3D GetYAxis(this Transform3D transform)
        {
            return new Vector3D(transform.Value.M21, transform.Value.M22, transform.Value.M23);
        }

        /// <summary>
        /// 获取Z轴向量
        /// </summary>
        public static Vector3D GetZAxis(this Transform3D transform)
        {
            return new Vector3D(transform.Value.M31, transform.Value.M32, transform.Value.M33);
        }

        public static Point3D GetPostion(this Transform3D transform)
        {
            return new Point3D(transform.Value.OffsetX, transform.Value.OffsetY, transform.Value.OffsetZ);
        }

        /// <summary>
        /// 变换直线
        /// </summary>
        public static Line3D TransformLine3D(this Transform3D transform,Line3D line)
        {
            return new Line3D(transform.Transform(line.StartPoint), transform.Transform(line.EndPoint));
        }
    }
}
