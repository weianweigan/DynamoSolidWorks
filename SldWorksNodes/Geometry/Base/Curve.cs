using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.sldworks;
using System.Windows.Media;

namespace SldWorksNodes.Geometry
{
    /// <summary>
    /// A Curve with wire body
    /// </summary>
    public class Curve : SwBodyNode
    {
        private ICurve _swCurve;

        [IsVisibleInDynamoLibrary(false)]
        public Curve(ICurve curve)
        {
            SwCurve = curve;
        }

        internal Curve()
        {
            _color = Colors.Black;
        }

        internal ICurve SwCurve
        {
            get => _swCurve; set
            {
                _swCurve = value;
            }
        }
    }
}
