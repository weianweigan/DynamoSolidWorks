using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Feature
{
    public class RefPlane : SpecFeature<IRefPlane,IRefPlaneFeatureData>
    {
        [IsVisibleInDynamoLibrary(false)]
        internal RefPlane(IFeature feature) : base(feature)
        {

        }

        public static RefPlane ByName(string name)
        {
            var feat = ByName(name,FeatTypeNameUtil.RefPlane);
            
            return feat != null ? new RefPlane(feat) : null;
        }
    }
}
