using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Geometry
{
    [IsVisibleInDynamoLibrary(false)]
    public abstract class SurfaceBody : SwBodyNode
    {
        public SurfaceBody(IBody2 body, bool display = true)
        {
            SwObject = body;

            var doc = SwContextUtil.GetCurrentPartDocContext();
            if (SwObject != null && display)
                DisplayBody(doc, Color);
        }
    }
}
