using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.Geometry
{
    public class BoundingBox:Curve
    {
        public BoundingBox(Point3D min, Point3D max)
        {
            Min = min;
            Max = max;
        }

        #region Create
        public static BoundingBox ByCorner(Point3D min,Point3D max)
        {
            return new BoundingBox(min, max);
        }

        public static BoundingBox ByGeometry(SolidBody body)
        {
            var box = body.Box();

            if (box == null)
                return null;

            return new BoundingBox(box["min"], box["max"]);
        }
        #endregion

        #region Action
        public bool Contain(Point3D point)
        {
            return
                (point.X > Min.X && point.X < Max.X) &&
                (point.Y > Min.Y && point.Y < Max.Y) &&
                (point.Z > Min.Z && point.Z < Max.Z);
        }

        public BoundingBox Intersection(BoundingBox other)
        {
            var currentBox = ToRect3D();
            var otherBox = other.ToRect3D();

            var intersec = System.Windows.Media.Media3D.
                Rect3D.Intersect(currentBox, otherBox);

            return new BoundingBox(new Point3D(
                intersec.Location.X,
                intersec.Location.Y,
                intersec.Location.Z),
                new Point3D(
                    intersec.X + intersec.Size.X,
                    intersec.Y + intersec.Size.Y,
                    intersec.Z + intersec.Size.Z));
        }

        public bool IsEmpty() => ToRect3D().IsEmpty;

        public Cuboid ToCuboid()
        {
            Cuboid cube;
            using (this)
            {
                cube = Cuboid.ByBox(Min, Max);
            }
            return cube;
        }

        //TODO: 生成薄片实体矩形
        #endregion

        #region Query
        public Point3D Min { get; }

        public Point3D Max { get; }
        #endregion

        #region Methods
        internal System.Windows.Media.Media3D.Rect3D ToRect3D() =>
    new System.Windows.Media.Media3D.Rect3D(
        Min.ToData(),
        (Max - Min).ToSize());
        #endregion
    }
}
