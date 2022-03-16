using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SldWorksNodes.Feature;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    public abstract class SwSketch : SpecFeature<ISketch, string>
    {
        public SwSketch(IFeature feature) : base(feature)
        {
        }
    }
}
