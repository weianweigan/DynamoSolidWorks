using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.sldworks;
using System.Windows.Media;

namespace SldWorksNodes.Geometry
{
    /// <summary>
    /// A Curve with wire body
    /// </summary>
    public abstract class SwCurveBodyNode : SwBodyNode
    {
        private ICurve _swCurve;

        public SwCurveBodyNode()
        {
            _color = Colors.Black;
        }

        internal ICurve SwCurve
        {
            get => _swCurve; set
            {
                _swCurve = value;
                if(value != null)
                    Curve = new Curve(value);
            }
        }

        public Curve Curve { get;protected set; }
    }
}
