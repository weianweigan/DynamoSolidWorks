using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using System;

namespace SldWorksNodes.Geometry
{
    public class Cone : SolidBody
    {
        #region Ctor
        internal Cone(
            Point3D center, 
            Vector3D axis, 
            double bottomRaduis, 
            double topRadius, 
            double height)
        {
            var nCenter = _swUnit.ConvertPoint(center);
            var nBottomRaduis =_swUnit.ConvertDouble(bottomRaduis);
            var nTopRadius = _swUnit.ConvertDouble(topRadius);
            var nHeight = _swUnit.ConvertDouble(height);

            CreateCone(nCenter, axis, nBottomRaduis, nTopRadius, nHeight);
        }
        #endregion

        #region Query
        #endregion

        #region Create
        public static SolidBody ByCenterAxis2RaduisHeight(
            Point3D center, 
            Vector3D axis,
            double height, 
            double bottomRaduis, 
            double topRadius=0 )
        {
           
            var cone = new Cone(
                center,
                axis,
                bottomRaduis,
                topRadius,
                height);

            return cone;
        }

        public static SolidBody ByCenter2RaduisHeight(
            Point3D center,
            double height, 
            double bottomRaduis,
            double topRadius =0)
        { 
            return ByCenterAxis2RaduisHeight(
                (Point3D)center,
                Vector3D.ByCoordinates(0,0,1),
                bottomRaduis,
                topRadius,
                height);
        }
        #endregion

        #region Methods
        private void CreateCone(Point3D nCenter, Vector3D axis, double nBottomRaduis, double nTopRadius, double nHeight)
        {
            SwObject = BodyBuilder.CreateConeBody(
              nCenter,
              axis,
              nBottomRaduis,
              nTopRadius,
              nHeight);

            if (SwObject == null)
                throw new NullReferenceException("Create Body Error");

            DisplayBody();
        }
        #endregion
    }
}
