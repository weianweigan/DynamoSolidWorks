/*
 * Created By WeiGan 2021.3.27 
 * 1.描述一个2D的直线
 * 
 */

using Autodesk.DesignScript.Runtime;

namespace System.Windows.Media.Media3D
{
    [IsVisibleInDynamoLibrary(false)]
    public struct Line2D
    {
        public Line2D(Point3D startPoint,Point3D endPoint)
        {
            StartPoint = new Point(startPoint.X, startPoint.Y);
            EndPoint = new Point(endPoint.X, endPoint.Y);
        }

        public Line2D(Point startPoint,Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }

        public Line2D(double x1, double y1, double x2, double y2)
        {
            StartPoint = new Point(x1, y1);
            EndPoint = new Point(x2, y2);
        }

        public static Line2D Create(double x1,double y1,double x2,double y2)
        {
            return new Line2D(new Point(x1, y1),new Point(x2, y2));
        }

        public Point StartPoint { get; set; }

        public Point EndPoint { get; set; }

        public Vector Direction => EndPoint - StartPoint;


        #region Public Methods

        /// <summary>
        /// 是否相交
        /// </summary>
        /// <param name="another">另外一根直线</param>
        /// <returns>是否相交</returns>
        public bool IsIntersect(Line2D another)
        {
            return IsIntersect(this, another,out _);
        }

        /// <summary>
        /// 转换为<see cref="Line3D"/> X Y拷贝 Z值为0
        /// </summary>
        /// <param name="mmToMeter">是否从mm转换为m</param>
        /// <returns>创建的Line3D</returns>
        public Line3D ToLine3D(bool mmToMeter = false)
        {
            return new Line3D(StartPoint.ToPoint3D(mmToMeter), EndPoint.ToPoint3D(mmToMeter));
        }

        /// <summary>
        /// 延长
        /// </summary>
        /// <param name="length">EndPoint往外延长</param>
        /// <param name="oppLength">反向长度</param>
        public void Extend(double length,double oppLength)
        {
            var vector = EndPoint - StartPoint;
            vector.Normalize();
            EndPoint += Vector.Multiply(vector, length);
            StartPoint += Vector.Multiply(vector, -oppLength);
        }

        #endregion

        #region Static Methods

        /// 通过跨立试验 判断平面两直线是否相交 不计算Z
        /// https://www.cnblogs.com/NDKY9/p/7451976.html
        /// </summary>
        public static bool IsIntersect(Line2D line1,Line2D line2,out Vector scale,double eplision = 0.01)
        {
            //退化情况-- Line2 终点在 Line1 上
            bool result = false;
            var vec1 = line2.EndPoint - line1.StartPoint;
            var vec2 = line1.EndPoint - line2.EndPoint;

            var angle = Vector.AngleBetween(vec1, vec2);
            if (Math.Abs(angle) < eplision * 10)
            {
                result = true;
                //line2.Extend(0.1, 0);
            }

            var ac = line2.StartPoint - line1.StartPoint;
            var ad = line2.EndPoint - line1.StartPoint;
            var ab = line1.EndPoint - line1.StartPoint;

            var ca = line1.StartPoint - line2.StartPoint;
            var cb = line1.EndPoint - line2.StartPoint;
            var cd = line2.EndPoint - line2.StartPoint;

            var d1 = Vector.CrossProduct(ac, ab);
            var d2 = Vector.CrossProduct(ad, ab);

            scale = new Vector(d1, d2);

            var res1 = d1 * d2;

            var res2 = (Vector.CrossProduct(ca, cd) *
                    Vector.CrossProduct(cb, cd));

            return result || ( res1 <= eplision && res2 <= eplision);
        }

        /// <summary>
        /// 通过跨立试验 判断平面两直线是否相交 不计算Z
        /// https://www.cnblogs.com/NDKY9/p/7451976.html
        /// </summary>
        public static Point GetIntersectPoint(Point lineFirstStar, Point lineFirstEnd, Point lineSecondStar, Point lineSecondEnd)
        {
            var line = new Line2D(lineFirstStar, lineFirstEnd);
            var another = new Line2D(lineSecondStar, lineSecondEnd);

            return line.GetIntersectPoint(another);
        }

        /// <summary>
        /// https://www.pianshen.com/article/2374576/
        /// </summary>
        /// <param name="another"></param>
        /// <returns></returns>
        public Point GetIntersectPoint(Line2D another)
        {
            if (!IsIntersect(this, another,out var scale))
                throw new InvalidOperationException($"当前两条直线不相交");

            var abLength = this.Direction.Length;

            var length = Math.Abs(scale.X/abLength) / (Math.Abs(scale.X/ abLength) + Math.Abs(scale.Y/ abLength))*another.Direction.Length;

            var vec = another.Direction;
            vec.Normalize();
            vec = Vector.Multiply(vec, length);

            var result = another.StartPoint + vec;

            return result;
        }

        public bool OnLine(Point3D pt)
        {
            var pt2D = pt.ToPoint2D();

            if (StartPoint.ValueEquals(pt2D) || EndPoint.ValueEquals(pt2D))
                return true;

            var x = (StartPoint - pt2D);
            var y = (pt2D - EndPoint);
            x.Normalize();y.Normalize();

            return Math.Abs(x.X - y.X) < 0.00001 && Math.Abs(x.Y - y.Y) < 0.00001;
        }

        [Obsolete]
        public static Point GetIntersectPoint2D(Point3D lineFirstStar, Point3D lineFirstEnd, Point3D lineSecondStar, Point3D lineSecondEnd)
        {
            //if (!IsIntersect(this, another))
              //  throw new InvalidOperationException($"当前两条直线不相交");

            double a = (lineFirstEnd.Y - lineFirstStar.Y) / (lineFirstEnd.X - lineFirstStar.X);
            double b = (lineSecondEnd.Y - lineSecondStar.Y) / (lineSecondEnd.X - lineSecondStar.X);

            double x = (a * lineFirstStar.X - b * lineSecondStar.X - lineFirstStar.Y + lineSecondStar.Y) / (a - b);
            double y = a * x - a * lineFirstStar.X + lineFirstStar.Y;

            return new Point(x, y);
        }

        public Line2D Translate(double x, double y)
        {
            return new Line2D(StartPoint.Translate(x, y), EndPoint.Translate(x, y));
        }
        #endregion
    }


}
