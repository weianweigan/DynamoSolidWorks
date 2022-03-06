using SldWorksNodes.Base;
using System;
using SolidWorks.Interop.sldworks;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Util;
using SldWorksNodes.SwException;
using SldWorksNodes.Geometry;

namespace SldWorksNodes.Brep
{
    /// <summary>
    /// 
    /// </summary>
    public class Edge:BrepNode<IEdge>
    {
        internal Edge(IEdge edge)
        {
            SwObject = edge;
        }

        public static Edge ByPID(string pid)
        {
            if(string.IsNullOrWhiteSpace(pid))
                return null;

            var doc = SwContextUtil.GetCurrentPartDocContext();

            var obj = PIDUtil.GetObjectFromPID(pid, out var state) as IEdge;
            PIDUtil.AssertState(state);

            if (obj != null)
                return new Edge(obj);
            else
                throw new SwObjectLostException(typeof(IEdge));
        }

        public Vertex StartVertex()
        {
            if(SwObject == null)
                return null;

            var vertex = SwObject.GetStartVertex() as IVertex;

            return new Vertex(vertex);
        }

        public Vertex EndVertex()
        {
            if (SwObject == null)
                return null;

            var vertex = SwObject.GetEndVertex() as IVertex;

            return new Vertex(vertex);
        }

        public Point3D ClosestPoint(Point3D point)
        {
            if (SwObject == null || point == null)
                return null;

            var res = SwObject.GetClosestPointOn(point.X, point.Y, point.Z) as Object[];

            return new Point3D(
                (double)res[0],
                (double)res[1],
                (double)res[2]);
        }
    }
}
