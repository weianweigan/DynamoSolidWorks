using SldWorksNodes.Util;
using System.Windows.Media;

namespace SldWorksNodes.Geometry
{
    /// <summary>
    /// A line in SoildWorks
    /// </summary> 
    public class Line3D : Curve
    {
        internal Line3D(Point3D startPoint, Point3D endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;

            CreateWireBody(startPoint, endPoint);
        }

        public Point3D StartPoint { get; }

        public Point3D EndPoint { get; }

        public static Line3D ByStartAndEnd(Point3D startPoint,Point3D endPoint)
        {
            return new Line3D(startPoint,endPoint);
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
