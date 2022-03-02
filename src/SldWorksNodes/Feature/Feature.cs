using SldWorksNodes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Feature
{
    /// <summary>
    /// Feature in SolidWorks
    /// </summary>
    public class Feature:SwNodeModel<IFeature>
    {
        internal Feature()
        {

        }

        /// <summary>
        /// 特征名称
        /// </summary>
        public string FeatureName => SwObject?.Name;

        public static string Test(string a)
        {
            return "a";
        }
    }
}
