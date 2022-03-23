using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Manager;
using SolidWorks.Interop.sldworks;
using System.Collections.Generic;
using System.Windows.Media;

namespace SldWorksNodes.Geometry
{
    /// <summary>
    /// A Curve with wire body
    /// </summary>
    public class Curve : SwBodyNode
    {
        private ICurve _swCurve;

        #region Ctor
        [IsVisibleInDynamoLibrary(false)]
        public Curve(ICurve curve)
        {
            SwCurve = curve;
        }

        internal Curve()
        {
            _color = Colors.Black;
        }
        #endregion

        #region Properties
        internal ICurve SwCurve
        {
            get => _swCurve; set
            {
                _swCurve = value;
            }
        }
        #endregion

        #region Query
        public Point3D StartPoint()
        {
            SwCurve.GetEndParams(
                out var start,
                out var end,
                out var isClosed,
                out var isPeriodic);

            var point = SwCurve.Evaluate(start) as double[];
            if (point != null)
            {
                return _swUnit.ConvertBackPoint(Point3D.ByCoordinates(point[0], point[1], point[2]));
            }
            else
                return null;
        }

        public Point3D EndPoint()
        {
            SwCurve.GetEndParams(
                out var start,
                out var end,
                out var isClosed,
                out var isPeriodic);

            var point = SwCurve.Evaluate(end) as double[];
            if (point != null)
            {
                return _swUnit.ConvertBackPoint(Point3D.ByCoordinates(point[0], point[1], point[2]));
            }
            else
                return null;
        }

        public bool IsClosed()
        {
            SwCurve.GetEndParams(
               out var start,
               out var end,
               out var isClosed,
               out var isPeriodic);

            return isClosed;
        }

        public bool IsPeriodic()
        {
            SwCurve.GetEndParams(
               out var start,
               out var end,
               out var isClosed,
               out var isPeriodic);

            return isClosed;
        }
        #endregion

        #region Action
        public static double StartParameter(Curve curve)
        {
            curve.SwCurve.GetEndParams(
               out var start,
               out var end,
               out var isClosed,
               out var isPeriodic);

            return start;
        }

        public static double EndParameter(Curve curve)
        {
            curve.SwCurve.GetEndParams(
               out var start,
               out var end,
               out var isClosed,
               out var isPeriodic);

            return end;
        }

        public static Point3D PointAtParameter(Curve curve,double parameter)
        {
            var swUnit = new UnitManager();

            var point = curve.SwCurve.Evaluate(parameter) as double[];
            if (point != null)
            {
                return swUnit.ConvertBackPoint(Point3D.ByCoordinates(point[0], point[1], point[2]));
            }
            else
                return null;
        }

        public static List<Point3D> PointsAtEqualChordLength(Curve curve,int divisions)
        {
            var swUnit = new UnitManager();

            curve.SwCurve.GetEndParams(
                out var start,
                out var end,
                out var isClosed,
                out var isPeriodic);

            List<Point3D> points = new List<Point3D>();

            var incr = (end - start) / (divisions - 1);
            for (int i = 0; i < divisions; i++)
            {
                var point = curve.SwCurve.Evaluate(start + i * incr) as double[];
                if (point != null)
                    points.Add(swUnit.ConvertBackPoint(Point3D.ByCoordinates(point[0], point[1], point[2])));
            }

            return points;
        }
        #endregion

        #region Methods
        internal List<Point3D> GetParamPoints()
        {
            SwCurve.GetEndParams(
                out var start,
                out var end,
                out var isClosed,
                out var isPeriodic);

            List<Point3D> points = new List<Point3D>();
            int num = 3;

            if (SwCurve.IsLine())
            {
                num = 2;
            }
            if (SwCurve.IsCircle())
            {
                num = 4;
            }

            var incr = (end - start) / (num - 1);
            for (int i = 0; i < num; i++)
            {
                var point = SwCurve.Evaluate(start + i * incr) as double[];
                if (point != null)
                    points.Add(Point3D.ByCoordinates(point[0], point[1], point[2]));
            }
            
            return points;
        }
        #endregion
    }
}
