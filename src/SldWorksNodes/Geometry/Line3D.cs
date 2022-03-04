using SldWorksNodes.Util;
using System.Windows.Media;

namespace SldWorksNodes.Geometry
{
    /// <summary>
    /// A line in SoildWorks
    /// </summary> 
    public class Line3D : SwCurveBodyNode
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
            var doc = SwContextUtil.GetCurrentPartDocContext();
            var curve = Util.CurveBuilder.CreatedTrimmedLine(SldContextManager.Modeler, startPoint.ToData(), endPoint.ToData());

            SwObject = curve.CreateWireBody();

            if (SwObject != null)
            {
                DisplayBody(doc, Color);
            }
        }
    }
}
