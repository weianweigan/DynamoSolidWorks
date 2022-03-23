using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SldWorksNodes.Geometry;
using SldWorksNodes.SwException;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Brep
{
    /// <summary>
    /// 
    /// </summary>
    public class Vertex:BrepNode<IVertex>
    {
        internal Vertex(IVertex vertex)
        {
            SwObject = vertex;
        }

        public static Vertex ByPID(string pid)
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();

            var obj = PIDUtil.GetObjectFromPID(pid, out var state) as IVertex;
            PIDUtil.AssertState(state);

            if (obj != null)
                return new Vertex(obj);
            else
                throw new SwObjectLostException(typeof(IVertex));
        }

        public Point3D Postion()
        {
            if (SwObject == null)
                return null;

            var postion = SwObject.GetPoint() as object[];

            return new Point3D(
                (double)postion[0],
                (double)postion[1],
                (double)postion[2]
                );
        }

        public override string ToString()
        {
            return "Vertex" ?? base.ToString();
        }
    }
}
