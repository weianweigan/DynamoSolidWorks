using SldWorksNodes.Base;
using SolidWorks.Interop.sldworks;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Util;

namespace SldWorksNodes.Feature
{
    [IsVisibleInDynamoLibrary(false)]
    public abstract class SpecFeature<TSpecFeature,TFeatureData>:SwNodeModel<IFeature>
        where TSpecFeature : class
        where TFeatureData : class
    {
        internal SpecFeature(IFeature feature)
        {
            SwObject = feature;

            SpecificFeature = feature.GetSpecificFeature2() as TSpecFeature;

            FeatureData=feature.GetDefinition() as TFeatureData;
        }

        public TSpecFeature SpecificFeature { get; }

        public TFeatureData FeatureData { get; }

        public static IFeature ByName(string name,string featTypeName)
        {
            if (string.IsNullOrWhiteSpace(name)) return null;

            IFeature existFeat = SwContextUtil.GetFeatureByName(name);

            if (existFeat.GetTypeName2() != featTypeName)
                return null;

            return existFeat;
        }
    }
}
