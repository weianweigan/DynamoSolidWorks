using CoreNodeModels;
using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using System.Collections.Generic;

namespace SldWorksNodes.Selection
{
    /// <summary>
    /// 
    /// </summary>
    public class SelectEdge : SelectionBase<IEdge, Brep.Edge>
    {
        public SelectEdge() : base(SelectionType.One, SelectionObjectType.Face, "Select Edge", "Edge")
        {

        }

        public override IModelSelectionHelper<IEdge> SelectionHelper => throw new System.NotImplementedException();

        protected override IEnumerable<Brep.Edge> ExtractSelectionResults(IEdge selections)
        {
            throw new System.NotImplementedException();
        }

        protected override string GetIdentifierFromModelObject(IEdge modelObject)
        {
            return PIDUtil.GetPID(SldContextManager.Sw.IActiveDoc2, modelObject);
        }

        protected override IEdge GetModelObjectFromIdentifer(string id)
        {
            var res = PIDUtil.GetObjectFromPID(SldContextManager.Sw.IActiveDoc2, id, out var state);
            return (IEdge)res;
        }
    }
}
