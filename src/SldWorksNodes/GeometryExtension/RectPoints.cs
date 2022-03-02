/*
 * Created By WeiGan 2021/4/23 NJ.Touch.Ltd
 * 1.用来描述平面上的四个点的矩形
 */

using Autodesk.DesignScript.Runtime;
using System.Linq;

namespace System.Windows.Media.Media3D
{
    [IsVisibleInDynamoLibrary(false)]
    public struct RectPoints
    {
        #region Properties
        public Point LeftDown { get; set; }

        public Point LeftTop { get; set; }

        public Point RightTop { get; set; }

        public Point RightDown { get; set; }

        public double Width { get
            {
                return Point.Subtract(LeftDown, RightDown).Length;
            } }

        public double Height { get
            {
                return Point.Subtract(RightDown, RightTop).Length;
            } }

        public Point CenterPoint { get
            {
                return new Point(
                    (LeftDown.X + RightTop.X) / 2,
                    (LeftDown.Y + RightTop.Y) / 2);
            }
        }
        #endregion

        public RectPoints(Point[] points)
        {
            if (points is null)
            {
                throw new ArgumentNullException(nameof(points));
            }
            if (points.Length < 4)
            {
                throw new ArgumentException("参数长度太少，无法构建矩形");
            }

            var lefts = points
                .OrderBy(p => p.X)
                .Take(2)
                .OrderBy(p => p.Y)
                .ToArray();

            LeftDown = lefts[0];
            LeftTop = lefts[1];

            var rights = points
                .OrderByDescending(p => p.X)
                .Take(2)
                .OrderBy(p => p.Y)
                .ToArray();

            RightDown = rights[0];
            RightTop = rights[1];
        }
    }

}
