using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.Geometry
{
    public class Ellipse3D:SwCurveBodyNode
    {

        public static Ellipse3D ByCenter2Raduis2Axis()
        {

            return new Ellipse3D();
        }
    }
}
