using Autodesk.DesignScript.Runtime;
using System.Numerics;

namespace System.Windows.Media.Media3D
{
    [IsVisibleInDynamoLibrary(false)]
    public struct Line3D
    {
        public Line3D(Point3D startPoint, Point3D endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;

            IsFault = false;
        }

        public Point3D StartPoint { get; set; }

        public Point3D EndPoint { get; set; }

        public bool IsFault { get; set; }

        public PointDirection3D AsStartPointDirection()
        {
            return new PointDirection3D(StartPoint, EndPoint - StartPoint);
        }

        /// <summary>
        /// 某点到此直线上的最近的点
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public Point3D CloestPoint(Point3D point)
        {
            if (OnLine(point))
            {
                return point;
            }

            var projectpt = Project(point);

            if (OnLine(projectpt))
            {
                return projectpt;
            }
            else
            {
                var sl = Math.Abs((StartPoint - point).Length);
                var el = Math.Abs((EndPoint - point).Length);

                return sl > el ? EndPoint : StartPoint;
            }
        }

        public Line3D TransformBy(Transform3D transform)
        {
            return new Line3D(transform.Transform(StartPoint), transform.Transform(EndPoint));
        }

        /// <summary>
        /// Y坐标是否在这连个值之内
        /// </summary>
        /// <param name="min">最小值</param>
        /// <param name="max">最大值</param>
        /// <returns></returns>
        public bool YArrage(double min, double max)
        {
            if (max < min)
            {
                throw new ArgumentOutOfRangeException($"Max:{max} cannnot less then Min:{min}");
            }

            return
                StartPoint.Y < max && StartPoint.Y > min &&
                EndPoint.Y < max && EndPoint.Y > min;
        }

        /// <summary>
        /// 判断这两个直线是否相交
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        public bool Interect(Line3D line)
        {
            //退化情况-- Line2 终点在 Line1 上
            return IsIntersect2(this, line);
        }

        /// <summary>
        /// 三维空间内的直线是否相交
        /// https://www.it610.com/article/227198.htm
        /// </summary>
        /// <param name="line1"></param>
        /// <param name="line2"></param>
        /// <param name="eplision"></param>
        /// <returns></returns>
        public static bool IsIntersect2(Line3D line1, Line3D line2, double eplision = 0.000001)
        {
            //退化情况-- Line2 终点在 Line1 上
            var vec1 = line2.EndPoint - line1.StartPoint;
            var vec2 = line1.EndPoint - line2.EndPoint;

            //判断平行直线是否搭接
            var on1 = line1.OnLine(line2.StartPoint);
            var on2 = line1.OnLine(line2.EndPoint);

            var ron1 = line2.OnLine(line1.StartPoint);
            var ron2 = line2.OnLine(line1.EndPoint);

            if (on1 || on2 || ron1 || ron2)
            {
                return true;
            }

            var angle = Vector3D.AngleBetween(vec1, vec2);
            if (Math.Abs(angle) < eplision * 10 || Math.Abs(angle - 180) < eplision * 10)
            {
                return on1 || on2 || ron1 || ron2;
            }

            //使用二维平面组合来判断三维中直线是否相交
            var xy1 = line1.ToXY();
            var xy2 = line2.ToXY();

            bool xy = xy1.IsIntersect(xy2);

            var xz1 = line1.ToXZ();
            var xz2 = line2.ToXZ();

            var xz = xz1.IsIntersect(xz2);

            var yz1 = line1.ToYZ();
            var yz2 = line2.ToYZ();

            var yz = yz1.IsIntersect(yz2);

            if (xy && xz && yz)
            {
                
                var xyPoint = xy1.GetIntersectPoint(xy2);
                var xzPoint = xz1.GetIntersectPoint(xz2);
                var yzPoint = yz1.GetIntersectPoint(yz2);

                var interectPoint = new Point3D(xyPoint.X, yzPoint.X, xzPoint.Y);

                return line1.OnLine(interectPoint) && line2.OnLine(interectPoint);
            }
            else
            {
                return false;
            }
        }

        public Vector3D AsVector()
        {
            return EndPoint - StartPoint;
        }

        public double GetLength() => AsVector().Length;

        /// <summary>
        /// 将一点投影到此直线上,不在此直线范围内也能投影出结果
        /// </summary>
        /// <param name="point">需要投影的点</param>
        /// <returns>在此直线上的点</returns>
        public Point3D Project(Point3D point)
        {
            var lineVec = AsVector();

            var vec = point - StartPoint;

            var length = vec.Project(lineVec);

            return StartPoint + Vector3D.Multiply(lineVec, length);
        }

        /// <summary>
        /// 点是否在直线上，在直线范围外，返回false,如果<paramref name="asRay"/>为true，直线外也返回true
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public bool OnLine(Point3D point,bool asRay = false)
        {
            //和起点或者终点重合
            if (point.ValueEquals(StartPoint) || point.ValueEquals(EndPoint))
            {
                return true;
            }

            var vec = point - StartPoint;
            var negVec = EndPoint - point;

            var angle = Math.Abs(Vector3D.AngleBetween(vec, negVec));
            if (asRay)
            {
                return angle < 0.00001 || Math.Abs(180- angle) < 0.00001;
            }
            else
            {
                return angle < 0.00001;
            }
        }

        /// <summary>
        /// 判断当前直线是否沿着X，或者Y，或者Z
        /// </summary>
        public bool IsXYZ()
        {
            var vector = AsVector();
            var length = vector.Length;
            return (Math.Abs(Math.Abs(vector.X) - length) < 0.00001 ||
                Math.Abs(Math.Abs(vector.Y) - length) < 0.00001 ||
                Math.Abs(Math.Abs(vector.Z) - length) < 0.00001);
        }

        /// <summary>
        /// 当前直线是否沿着X方向
        /// </summary>
        public bool IsX()
        {
            var vector = AsVector();
            var length = vector.Length;
            return (Math.Abs(Math.Abs(vector.X) - length) < 0.00001);
        }

        /// <summary>
        /// 当前直线是否沿着Y方向
        /// </summary>
        public bool IsY()
        {
            var vector = AsVector();
            var length = vector.Length;
            return (Math.Abs(Math.Abs(vector.Y) - length) < 0.00001);
        }

        /// <summary>
        /// 当前直线是否沿着Z方向
        /// </summary>
        public bool IsZ()
        {
            var vector = AsVector();
            var length = vector.Length;
            return (Math.Abs(Math.Abs(vector.Z) - length) < 0.00001);
        }

        public Line3D Translate(double x,double y,double z)
        {
            return new Line3D(StartPoint.Translate(x, y, z), EndPoint.Translate(x, y, z));
        }

        public void Extend(double length,bool inverse = false)
        {
            var direc = inverse ? StartPoint - EndPoint : (EndPoint - StartPoint);
            direc.Normalize();

            if (inverse)
                StartPoint += Vector3D.Multiply(direc, length);
            else
                EndPoint += Vector3D.Multiply(direc,length);
            
        }

        public Point3D GetCenterPoint()
        {
            return new Point3D(
                (StartPoint.X + EndPoint.X) / 2,
                (StartPoint.Y + EndPoint.Y) / 2,
                (StartPoint.Z + EndPoint.Z) / 2);
        }

        public bool IsSamePostion(Line3D relativeLine,double eplison = 0.000001)
        {
            return StartPoint.ValueEquals(relativeLine.StartPoint, eplison)
                && EndPoint.ValueEquals(relativeLine.EndPoint, eplison);
        }

        public void Move(Vector3D vector)
        {
            StartPoint += vector;
            EndPoint += vector;
        }

        public Line2D ToXY()
        {
            return new Line2D(new Point(StartPoint.X, StartPoint.Y),
                new Point(EndPoint.X, EndPoint.Y));
        }

        public Line2D ToXZ()
        {
            return new Line2D(new Point(StartPoint.X, StartPoint.Z),
                new Point(EndPoint.X, EndPoint.Z));
        }

        public Line3D XYToXZ()
        {
            return new Line3D(new Point3D(StartPoint.X,0, StartPoint.Y),
    new Point3D(EndPoint.X, 0,EndPoint.Y));
        }

        public Line2D ToYZ()
        {
            return new Line2D(new Point(StartPoint.Y, StartPoint.Z),
                new Point(EndPoint.Y, EndPoint.Z));
        }
    }
}
