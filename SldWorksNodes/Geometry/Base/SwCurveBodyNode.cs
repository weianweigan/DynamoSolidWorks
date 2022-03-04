using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.sldworks;
using System.Windows.Media;

namespace SldWorksNodes.Geometry
{
    /// <summary>
    /// A Curve with wire body
    /// </summary>
    [IsVisibleInDynamoLibrary(false)]
    public abstract class SwCurveBodyNode : SwBodyNode
    {
        public SwCurveBodyNode()
        {
            _color = Colors.Black;
        }

        public ICurve Curve { get;protected set; }

    }
}
