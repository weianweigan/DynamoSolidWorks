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
    public class Cuboid : SolidBody
    {
        #region Ctor
        internal Cuboid(Point3D leftDown, Point3D topRight)
        {
            var nL = _swUnit.ConvertPoint(leftDown);
            var nR = _swUnit.ConvertPoint(topRight);

            SwObject = BodyBuilder.CreateFromBox(
                SldContextManager.Modeler,
                nL,
                nR);
            if (SwObject == null)
                throw new NullReferenceException("Create Body Error");
            DisplayBody();
        }

        internal Cuboid(IBody2 body)
        {

        }

        internal Cuboid(double length, double width, double height)
        {
            var nL = _swUnit.ConvertDouble(length);
            var nW = _swUnit.ConvertDouble(width);
            var nH = _swUnit.ConvertDouble(height);

            SwObject = BodyBuilder.CreateFromBox(
                       SldContextManager.Modeler,
                       new Point3D(0, 0, 0),
                       new Point3D(nL, nW, nH));
            if (SwObject == null)
                throw new NullReferenceException("Create Body Error");

            DisplayBody();
        }
        #endregion

        #region Create
        public static Cuboid ByBox(Point3D LeftDown, Point3D TopRight)
        {
            if(LeftDown == null || TopRight == null)
                return null;

            return new Cuboid(LeftDown, TopRight);
            
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
        public static Cuboid ByLengthWidthHeight(
            double length,
            double width,
            double height)
        {
            if (length < 0 || width < 0 || height < 0)
                throw new ArgumentException("Value cannot < 0");

            return new Cuboid(length, width, height);
           
        }
        #endregion
    }
}
