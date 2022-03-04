/*
 * Created By WeiGan 2021.3.26
 */

using Autodesk.DesignScript.Runtime;

namespace System.Windows.Media.Media3D
{
    [IsVisibleInDynamoLibrary(false)]
    public static class Rect3DExtension
    {
        public static Point3D GetCenter(this Rect3D rect)
        {
            return new Point3D(
                rect.X + rect.SizeX/2,
                rect.Y+ rect.SizeY   / 2,
                rect.Z + rect.SizeZ / 2
                );
        }

        /// <summary>
        /// 获取除了Location另外一个极点
        /// </summary>
        /// <param name="rect"></param>
        /// <returns></returns>
        public static Point3D GetCorner(this Rect3D rect)
        {
            return new Point3D(
                rect.Location.X + rect.SizeX,
                rect.Location.Y + rect.SizeY,
                rect.Location.Z + rect.SizeZ
                );
        }

        /// <summary>
        /// 放大包围盒
        /// </summary>
        /// <remarks>
        /// 没有溢出检查，如果 offset 为负值并超过包围盒一般的大小，可能会导致反向错误
        /// </remarks>
        /// <param name="rect"></param>
        /// <param name="offset">偏移距离，各个方向都偏移那么多距离</param>
        /// <returns>偏移完成后的包围盒</returns>
        public static Rect3D Zoom(this Rect3D rect,double offset)
        {
            if (rect.IsEmpty)
                return rect;

            rect.Location = rect.Location.Translate(-offset, -offset, -offset);
            rect.SizeX += offset;
            rect.SizeY += offset;
            rect.SizeZ += offset;

            return rect;
        }

        /// <summary>
        /// 返回离 <see cref="Rect3D.Location"/> 或者 Corner 最近中的一个
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>
        public static Point3D ClosestPoint(this Rect3D rect,Point3D point)
        {
            var locDis = (point - rect.Location).Length;
            var cornerDis = (point - rect.GetCorner()).Length;

            return locDis > cornerDis ? rect.GetCorner() : rect.Location;
        }

        public static Rect TransformToRect(this Rect3D rect3D, Transform3D transform,double offsetDistance= 0)
        {
            var location = rect3D.Location.TransformBy(transform).ToPoint2D();

            var corner = rect3D.GetCorner().TransformBy(transform).ToPoint2D();

            var rect2D = new Rect(location, corner);

            location = rect2D.BottomLeft;
            corner = rect2D.TopRight;

            location.X -= offsetDistance;
            location.Y += offsetDistance;

            corner.X += offsetDistance;
            corner.Y -= offsetDistance;

            rect2D = new Rect(location, corner);

            return rect2D;
        }

        /// <summary>
        /// 转换为二维矩形
        /// </summary>
        /// <param name="rect3D"></param>
        /// <param name="offsetDistance">对矩形偏移的距离</param>
        /// <returns></returns>
        public static Rect ToRect2D(this Rect3D rect3D,double offsetDistance = 0)
        {
            var location = rect3D.Location.ToPoint2D();
            location.X -= offsetDistance;
            location.Y -= offsetDistance;

            var corner = rect3D.GetCorner().ToPoint2D();
            corner.X += offsetDistance;
            corner.Y += offsetDistance;

            var rect2D = new Rect(location, corner);

            return rect2D;
        }

        /// <summary>
        /// 和直线是否相交，并不可靠，慎用
        /// </summary>
        public static bool IntersectsWith(this Rect3D rect,Line3D line)
        {
            var center = rect.GetCenter();

            var projectPt = line.Project(center);

            return rect.In(projectPt);

        }

        /// <summary>
        /// 点是否在矩形内
        /// </summary>
        public static bool In(this Rect3D rect,Point3D point)
        {
            return point.X - rect.X < rect.SizeX &&
            point.Y - rect.Y < rect.SizeY &&
            point.Z - rect.Z < rect.SizeZ;

        }

        public static Rect3D Transform(this Rect3D rect,Transform3D transform)
        {
            var location = rect.Location.TransformBy(transform);
            var corner = rect.GetCorner().TransformBy(transform);

            return new Rect3D(location, (corner - location).ToSize3D());
        }

        public static Rect3D Move(this Rect3D rect,Vector3D direction)
        {
            var location = rect.Location.Translate(direction.X, direction.Y, direction.Z);
            var corner = rect.GetCorner().Translate(direction.X, direction.Y, direction.Z);
            return new Rect3D(location, (corner -location).ToSize3D());
        }
    }
}
