using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.sldworks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorks.Interop.sldworks
{
    [IsVisibleInDynamoLibrary(false)]
    public static class IFeatureExtension
    {
        /// <summary>
        /// 获取子特征
        /// </summary>
        public static IEnumerable<IFeature> GetAllSubFeatures(this IFeature feat)
        {
            var subFeat = feat.GetFirstSubFeature() as IFeature;

            while (subFeat != null)
            {

                var subsubFeats = subFeat.GetAllSubFeatures();

                foreach (var subsubFeat in subsubFeats)
                {
                    yield return subsubFeat;
                }

                yield return subFeat;

                subFeat = subFeat.GetNextSubFeature() as IFeature;
            }
        }

        /// <summary>
        /// 获取特征的所有尺寸
        /// </summary>
        public static IEnumerable<IDisplayDimension> GetAllDimensions(this IFeature feat)
        {
            var displayDimension = feat.GetFirstDisplayDimension() as IDisplayDimension;
            while (displayDimension != null)
            {
                yield return displayDimension;
                displayDimension = feat.GetNextDisplayDimension(displayDimension) as IDisplayDimension;
            }
        }
    }
}
