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
            var nStartPoint = _swUnit.ConvertPoint(startPoint);
            var nEndPoint = _swUnit.ConvertPoint(endPoint);

            CreateWireBody(nStartPoint, nEndPoint);
        }

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
