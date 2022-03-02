/*
 * Created By WeiGan 2021/3/20
 * 1.点法式数据，可以表示一个平面
 * 
 */

using Autodesk.DesignScript.Runtime;

namespace System.Windows.Media.Media3D
{
    public enum RayRelation
    {
        /// <summary>
        /// 未知
        /// </summary>
        UnKnown,

        /// <summary>
        /// 重合，同向
        /// </summary>
        CoinWithSameDirection,

        /// <summary>
        /// 重合 ，反向
        /// </summary>
        CoinWithOppsDirection,

        /// <summary>
        /// 垂直
        /// </summary>
        Vertical,

        /// <summary>
        /// 共面，并且有交点
        /// </summary>
        SameFace,

        /// <summary>
        /// 平行 同向
        /// </summary>
        ParallelWithSameDirection,

        /// <summary>
        /// 平行 反向
        /// </summary>
        ParallelWithOppsDirection,

        /// <summary>
        /// 异面 不平行，或者共面 无交点
        /// </summary>
        Interspace,
    }

    [IsVisibleInDynamoLibrary(false)]
    public struct PointDirection3D
    {
        public PointDirection3D(Point3D point, Vector3D direction)
        {
            Point = point;
            Direction = direction;
        }

        public Point3D Point { get; set; }

        public Vector3D Direction { get; set; }

        /// <summary>
        /// 点投影到此 面上得到的坐标
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public Point3D Project(Point3D point3)
        {
            return Project(Point, Direction, point3);
        }

        public Vector3D Project(Vector3D vector3)
        {
            var orgin = Project(new Point3D(0, 0, 0));
            var vec = Project(new Point3D(vector3.X, vector3.Y, vector3.Z));

            return vec - orgin;
        }

        public Point3D ClosetPoint(Point3D point)
        {
            return Project(point);
        }

        public static Point3D Project(Point3D pointOnFace, Vector3D normal, Point3D point)
        {
            normal.Normalize();
            //点在面上
            if (point.ValueEquals(pointOnFace))
                return point;

            //点面向量
            var pointFaceVec = new Vector3D(pointOnFace.X - point.X,
                                            pointOnFace.Y - point.Y,
                                            pointOnFace.Z - point.Z);

            //角度
            var angle = normal.AngleRadians(pointFaceVec);
            //长度
            var length = pointFaceVec.Length * Math.Cos(angle);

            //结果
            var resPoint = point + Vector3D.Multiply(normal, length);

            return resPoint;
        }

        /// <summary>
        /// 确定这两个射线是否相交,并计算交点
        /// </summary>
        /// <param name="ptDireTwo"></param>
        public bool Intersect(PointDirection3D ptDireTwo,out Point3D intersectPoint)
        {
            return GetRayRealtion(ptDireTwo, out intersectPoint) == RayRelation.SameFace;
        }

        public RayRelation GetRayRealtion(PointDirection3D ptDireTwo, out Point3D intersectPoint)
        {
            intersectPoint = default;

            //如果起点重合
            if (Point.ValueEquals(ptDireTwo.Point))
            {
                intersectPoint = Point;
                return RayRelation.SameFace;
            }

            //向量平行
            var direcAngle = Vector3D.AngleBetween(Direction, ptDireTwo.Direction);
            if (Math.Abs(direcAngle - 180) < 0.00001)
            {
                //计算在直线2上的中点
                var vecL = (Point - ptDireTwo.Point);
                var projectLength = Math.Cos(ptDireTwo.Direction.AngleRadians(vecL)) * vecL.Length;
                var direc2 = ptDireTwo.Direction;
                direc2.Normalize();
                intersectPoint = ptDireTwo.Point + Vector3D.Multiply(direc2, projectLength);

                //判断是否重合
                if ((ptDireTwo.Point - Point).IsPara(Direction))
                    return RayRelation.CoinWithOppsDirection;
                else
                    return RayRelation.ParallelWithOppsDirection;

            }else if(Math.Abs(direcAngle) < 0.00001)
            {
                //判断是否重合
                if ((ptDireTwo.Point - Point).IsPara(Direction))
                    return RayRelation.CoinWithSameDirection;
                else
                    return RayRelation.ParallelWithSameDirection;
            }

            var vec = ptDireTwo.Point - Point;
            var angle = Vector3D.AngleBetween(vec, Direction);
            var anotherAngle = Vector3D.AngleBetween(vec, ptDireTwo.Direction);

            if (Math.Abs(angle + 90 - anotherAngle) < 0.001)
            {
                intersectPoint = GetIntersecPoint(vec, angle);

                //垂直共面认为其垂直
                //return RayRelation.SameFace;
                return RayRelation.Vertical;
            }
            else
            {
                //是否垂直，移动一点距离后是否有交点
                //叉乘得到移动方向
                var vecAngle = Vector3D.AngleBetween(Direction, ptDireTwo.Direction);
                if (Math.Abs(vecAngle - 90) < 0.0001)
                {
                    //计算相交的点
                    //通过叉乘计算一个方向，然后沿着方向移动到参考点，求交点
                    var normal = Vector3D.CrossProduct(Direction, ptDireTwo.Direction);
                    //法向面
                    var face = new PointDirection3D(ptDireTwo.Point, normal);
                    //投影到法向量上
                    var pointInFace = face.Project(Point);

                    //求交点
                    vec = ptDireTwo.Point - pointInFace;
                    angle = Vector3D.AngleBetween(vec, Direction);
                    anotherAngle = Vector3D.AngleBetween(vec, ptDireTwo.Direction);

                    intersectPoint = GetIntersecPoint(vec, angle);

                    return RayRelation.Vertical;
                }
                else
                {
                    return RayRelation.Interspace;
                }
            }
        }

        /// <summary>
        /// 通过一个给定的长度，创建<see cref="Line3D"/>对象
        /// </summary>
        /// <param name="length">直线长度</param>
        /// <returns>新创建的<see cref="Line3D"/></returns>
        public Line3D ToLine3D(double length)
        {
            var vec = Direction;
            vec.Normalize();
            var endPoint = Point + Vector3D.Multiply(vec, length);

            return new Line3D(Point, endPoint);
        }

        private Point3D GetIntersecPoint(Vector3D vec, double angle)
        {
            Point3D intersectPoint;
            //计算交点
            var length = Math.Cos((angle / 180) * Math.PI) * vec.Length;
            //拷贝一个方向值
            var dire = Direction;
            dire.Normalize();
            intersectPoint = Point + Vector3D.Multiply(dire, length);
            return intersectPoint;
        }

        /// <summary>
        /// 点是否在此射线上，在射线反方向上也会返回true
        /// </summary>
        public bool IsOn(Point3D p)
        {
            //判断是否和起点重合
            if (p.ValueEquals(Point))
            {
                return true;
            }

            //判断方向
            var direc = p - Point;
            return direc.IsPara(Direction);
        }

        /// <summary>
        /// 转换成二维，点是否在此射线上，在射线反方向上也会返回true
        /// </summary>
        public bool IsOn2D(Point point)
        {
            if (point.ValueEquals(Point.ToPoint2D()))
            {
                return true;
            }

            var direc = point - Point.ToPoint2D();
            var angle = Math.Abs( Vector.AngleBetween(direc, Direction.ToVector2D()));

            return Math.Abs(angle - 180) < 0.01 || angle < 0.01;
        }

        public PointDirection3D TransformBy(Transform3D transform)
        {
            var newPt = Point.TransformBy(transform);
            var direction = Direction.TransformBy(transform);

            return new PointDirection3D(newPt, direction);
        }
    }
}
