using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.Geometry
{
    public class Ellipse:SwCurveBodyNode
    {

        public static Ellipse ByCenter2Raduis2Axis()
        {

            return new Ellipse();
        }
    }
}
