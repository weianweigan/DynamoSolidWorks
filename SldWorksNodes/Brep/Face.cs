using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SldWorksNodes.Geometry;
using SldWorksNodes.SwException;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.Brep
{
    /// <summary>
    /// 
    /// </summary>
    public class Face:BrepNode<IFace2>
    {
        #region Ctor
        [IsVisibleInDynamoLibrary(false)]
        public Face(IFace2 face)
        {
            SwObject = face;
        }
        #endregion

        #region Create
        /// <summary>
        /// Get face object form pid
        /// </summary>
        /// <param name="pid"></param>
        /// <returns></returns>
        /// <exception cref="SwObjectLostException"></exception>
        public static Face ByPID(string pid)
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();

            var obj = PIDUtil.GetObjectFromPID(pid, out var state) as IFace2;
            PIDUtil.AssertState(state);

            if (obj != null)
                return new Face(obj);
            else
                throw new SwObjectLostException(typeof(IFace2));
        }
        #endregion

        #region Query
        public double Area => SwObject.GetArea();

        public List<Edge> Edges()
        {
            if (SwObject == null)
                return null;

            var edges = SwObject.GetEdges() as Object[];

            if (edges != null)
                return null;

            return edges
                .Cast<IEdge>()
                .Select(e => new Edge(e))
                .ToList();
        }

        public List<Loop> Loops()
        {
            if (SwObject == null)
                return null;

            var loops = SwObject.GetLoops() as Object[];

            if (loops != null)
                return null;

            return loops
                .Cast<ILoop2>()
                .Select(e => new Loop(e))
                .ToList();
        }

        public Geometry.Body ParentBody()
        {
            var body = SwObject?.GetBody() as IBody2;
            
            return body != null ?
                new Geometry.Body(body,false) :
                null;
        }

        public bool IsPlane()
        {
            return (SwObject.GetSurface() as Surface).IsPlane();
        }
        #endregion

        #region Action
        public Point3D ClosestPoint(Point3D point)
        {
            if (SwObject == null || point == null)
                return null;

            var res = SwObject.GetClosestPointOn(point.X, point.Y, point.Z) as object[];

            return new Point3D(
                (double)res[0],
                (double)res[1],
                (double)res[2]);
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return SwObject?.GetFaceId().ToString() ?? base.ToString();
        }
        #endregion
    }
}
