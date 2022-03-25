using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Geometry
{
    public class Surface : SwBodyNode
    {
        #region Ctor
        [IsVisibleInDynamoLibrary(false)]
        public Surface()
        {

        }
        
        [IsVisibleInDynamoLibrary(false)]
        public Surface(IBody2 body, bool display = true)
        {
            SwObject = body;

            if (SwObject != null && display)
                DisplayBody();
        }
        #endregion

        public SolidBody Extruded(Vector3D normal,double length)
        {
            if (normal == null || length <= 0)
            {
                return null;
            }

            var axis = SldContextManager.MathUtility.
                CreateVector(new double[] { normal.X, normal.Y, normal.Z }) as MathVector;

            var nL = _swUnit.ConvertDouble(length);

            ClearBody(true);
            var newBody = SldContextManager.Modeler.CreateExtrudedBody((Body2)SwObject,axis,nL);
            if (newBody == null)
            {
                return null;
            }

            return new SolidBody(newBody);
        }
    }
}
