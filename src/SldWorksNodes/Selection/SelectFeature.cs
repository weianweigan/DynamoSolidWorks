using SldWorksNodes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;
using Autodesk.DesignScript.Runtime;
using CoreNodeModels;

namespace SldWorksNodes.Selection
{
    /// <summary>
    /// Node to select feature in modeldoc
    /// </summary>
    public class SelectFeature : SelectionBase<IFeature, Feature.Feature>
    {
        public SelectFeature() : base(SelectionType.One, SelectionObjectType.Face, "Select Face", "Face")
        {
        }

        public override IModelSelectionHelper<IFeature> SelectionHelper => throw new NotImplementedException();

        public override void Select()
        {

        }

        protected override IEnumerable<Feature.Feature> ExtractSelectionResults(IFeature selections)
        {
            throw new NotImplementedException();
        }

        protected override string GetIdentifierFromModelObject(IFeature modelObject)
        {
            throw new NotImplementedException();
        }

        protected override IFeature GetModelObjectFromIdentifer(string id)
        {
            throw new NotImplementedException();
        }
    }
}
