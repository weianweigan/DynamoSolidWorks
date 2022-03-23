using System;
using System.Linq;
using System.Collections.Generic;
using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SldWorksNodes.SwException;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Brep
{
    public class Loop:BrepNode<ILoop2>
    {
        #region Ctor
        internal Loop(ILoop2 loop)
        {
            SwObject = loop;
        }
        #endregion

        #region Create
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
        #endregion

        #region Query
        public bool IsOuter() => SwObject.IsOuter();

        public bool IsSingular() => SwObject.IsSingular();

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
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Loop";
        }
        #endregion
    }
}
