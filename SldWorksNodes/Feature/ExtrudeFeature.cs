using Autodesk.DesignScript.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.Feature
{
    public partial class Feature
    {
        [IsVisibleInDynamoLibrary(false)]
        public static bool ExtrudeFeatureData(
            Feature feature,
            bool? AssemblyFeatureScope,
            bool? AutoSelect,
            bool? BothDirection,
            bool? CapEnds
            
            )
        {
            return true;
        }

    }
}
