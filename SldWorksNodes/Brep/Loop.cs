using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SldWorksNodes.SwException;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SldWorksNodes.Brep
{
    public class Loop:BrepNode<ILoop2>
    {
        internal Loop(ILoop2 loop)
        {
            SwObject = loop;
        }

        public static Loop ByPID(string pid)
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();

            var obj = PIDUtil.GetObjectFromPID(pid, out var state) as ILoop2;
            PIDUtil.AssertState(state);

            if (obj != null)
                return new Loop(obj);
            else
                throw new SwObjectLostException(typeof(ILoop2));
        }

        public List<Edge> Edges()
        {
            if(SwObject == null)
                return null;

            var edges = SwObject.GetEdges() as Object[];

            if (edges != null)
                return null;

            return edges
                .Cast<IEdge>()
                .Select(e => new Edge(e))
                .ToList();
        }
    }
}
