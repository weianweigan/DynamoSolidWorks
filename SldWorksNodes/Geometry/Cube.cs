using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.Geometry
{
    /// <summary>
    /// Present a cube geometry
    /// </summary>
    public class Cube : Body
    {
        internal Cube(IBody2 body) : base(body)
        {

        }

        public static Cube ByBox(Point3D LeftDown, Point3D TopRight)
        {
            var body = BodyBuilder.CreateFromBox(
                SldContextManager.Modeler,
                LeftDown.ToData(),
                TopRight.ToData());
            if (body == null)
                throw new NullReferenceException("Create Body Error");

            return new Cube(body);
        }

        /// <summary>
        /// Create a Cube from length width and height.
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        public static Cube ByLengthWidthHeight(double length,double width,double height)
        {
            if (length < 0 || width < 0 || height < 0)
                throw new ArgumentException("Value cannot < 0");

            var body = BodyBuilder.CreateFromBox(
                        SldContextManager.Modeler,
                        new System.Windows.Media.Media3D.Point3D(0,0,0),
                        new System.Windows.Media.Media3D.Point3D(length,width,height));
            if (body == null)
                throw new NullReferenceException("Create Body Error");

            return new Cube(body);
        }
    }
}
