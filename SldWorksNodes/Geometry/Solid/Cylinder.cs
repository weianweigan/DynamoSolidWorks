using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using System;

namespace SldWorksNodes.Geometry
{
    public class Cylinder : SolidBody
    {
        #region Ctor
        public Cylinder( 
            Point3D center, 
            Vector3D axis, 
            double radius, 
            double height)
        {
            var nC = _swUnit.ConvertPoint(center);
            var nA = axis;
            var nR = _swUnit.ConvertDouble(radius);
            var nH = _swUnit.ConvertDouble( height);

            CreateCylinder(nC, nA, nR, nH);
        }

        private void CreateCylinder(
            Point3D center, 
            Vector3D axis, 
            double radius, 
            double height)
        {
            var body = BodyBuilder.CreateCylinderBody(
                SldContextManager.Modeler,
                center,
                axis,
                radius,
                height);

            if (body == null)
                throw new NullReferenceException("Create Body Error");

            DisplayBody();
        }
        #endregion

        #region Query
        #endregion

        #region Create
        public static SolidBody ByCenterAxisRaduisHeight(
            Point3D center,
            Vector3D axis, 
            double radius, 
            double height)
        {
            if (center == null || axis == null)
                return null;

            if (radius < 0)
                throw new ArgumentException("Raduis > 0");
            if (height < 0)
                throw new ArgumentException("Height > 0");

            return new Cylinder(center,axis,radius,height);
        }
        #endregion
    }
}
