using SldWorksNodes.Util;
using System.Windows.Media;

namespace SldWorksNodes.Geometry
{
    /// <summary>
    /// A line in SoildWorks
    /// </summary> 
    public class Line : Curve
    {
        internal Line(Point3D startPoint, Point3D endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;

            CreateWireBody(startPoint, endPoint);
        }

        public Point3D StartPoint { get; }

        public Point3D EndPoint { get; }

        public static Line ByStartAndEnd(Point3D startPoint,Point3D endPoint)
        {
            return new Line(startPoint,endPoint);
        }

        private void CreateWireBody(Point3D startPoint, Point3D endPoint)
        {
            SwCurve = Util.CurveBuilder.CreatedTrimmedLine(
                SldContextManager.Modeler, 
                startPoint, 
                endPoint);

            SwObject = SwCurve.CreateWireBody();

            if (SwObject != null)
            {
                DisplayBody();
            }
        }
    }
}
