using System.Collections.Generic;
using System.Linq;

namespace SldWorksNodes.Geometry
{
    public class Polygon:Curve
    {
        private List<Line> _lines = new List<Line>();

        #region Ctor
        internal Polygon(List<Point3D> points, bool isClosed)
        {
            var nPts = points
                .Select(p => _swUnit.ConvertPoint(p))
                .ToList();

            CreatePolygon(points,isClosed);
        }

        #endregion

        #region Query
        public List<Line> Lines { get => _lines; set => _lines = value; }
        #endregion

        #region Create
        public static Polygon ByPoints(List<Point3D> points,bool isClosed)
        {
            if(points == null || points.Count <= 2)
                return null;

            return new Polygon(points, isClosed);
        }
        #endregion

        #region Methods
        private void CreatePolygon(List<Point3D> points, bool isClosed)
        {
            Lines.Clear();
            for (int i = 0; i < points.Count-1; i++)
            {
                var line = Line.ByStartAndEnd(points[i],points[i+1]);
                Lines.Add(line);
            }
            if (isClosed)
            {
                var line = Line.ByStartAndEnd(points.Last(), points.First());
                Lines.Add(line);
            }
        }
        #endregion
    }
}
