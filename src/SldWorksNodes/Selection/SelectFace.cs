using SldWorksNodes.Base;
using SolidWorks.Interop.sldworks;
using CoreNodeModels;
using System.Collections.Generic;

namespace SldWorksNodes.Selection
{
    public class SelectFace : SelectionBase<IFace2, Brep.Face>
    {
        public SelectFace() : base(SelectionType.One,SelectionObjectType.None, "Select Face","Face" )
        {
        }

        public override IModelSelectionHelper<IFace2> SelectionHelper => throw new System.NotImplementedException();

        protected override IEnumerable<Brep.Face> ExtractSelectionResults(IFace2 selections)
        {
            throw new System.NotImplementedException();
        }

        protected override string GetIdentifierFromModelObject(IFace2 modelObject)
        {
            throw new System.NotImplementedException();
        }

        protected override IFace2 GetModelObjectFromIdentifer(string id)
        {
            throw new System.NotImplementedException();
        }
    }
}
