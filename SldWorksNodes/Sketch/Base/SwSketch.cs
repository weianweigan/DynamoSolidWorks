using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Feature;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    [IsVisibleInDynamoLibrary(false)]
    public abstract class SwSketch : SpecFeature<ISketch, string>
    {
        public SwSketch(IFeature feature) : base(feature)
        {
        }
    }
}
