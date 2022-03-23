using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.DesignScript.Runtime;

namespace SldWorksNodes.Geometry
{
    [IsVisibleInDynamoLibrary(false)]
    public class Ellipse:Curve
    {

        public static Ellipse ByCenter2Raduis2Axis()
        {

            return new Ellipse();
        }
    }
}
