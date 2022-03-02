/*
 * Created By WeiGan 2021.3.26
 */

using Autodesk.DesignScript.Runtime;

namespace System.Windows.Media.Media3D
{
    [IsVisibleInDynamoLibrary(false)]
    public static class RectExtensin
    {
        public static Point ClosestPoint(this Rect rect, Point point)
        {
            var locDis = (point - rect.BottomLeft).Length;
            var cornerDis = (point - rect.TopRight).Length;

            return locDis > cornerDis ? rect.TopRight : rect.Location;
        }
    }
}
