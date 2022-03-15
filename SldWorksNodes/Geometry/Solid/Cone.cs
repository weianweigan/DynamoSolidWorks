using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using System;

namespace SldWorksNodes.Geometry
{
    public class Cone : Body
    {
        #region Ctor
        internal Cone(
            IBody2 body,
            Point3D center, 
            Vector3D axis, 
            double bottomRaduis, 
            double topRadius, 
            double height):base(body)
        {
            Center = center;
            Axis = axis;
            BottomRaduis = bottomRaduis;
            TopRadius = topRadius;
            Height = height;
        }
        #endregion

        #region Query
        public Point3D Center { get; }

        public Vector3D Axis { get; }

        public double BottomRaduis { get; }

        public double TopRadius { get; }

        public double Height { get; }
        #endregion

        #region Create
        public static Body ByCenterAxis2RaduisHeight(
            Point3D center, 
            Vector3D axis,
            double height, 
            double bottomRaduis, 
            double topRadius=0 )
        {
            if (bottomRaduis < 0)
                return null;
            if (topRadius < 0)
                return null; 
            if (height < 0)
                return null;

            var body = BodyBuilder.CreateConeBody(
               center.ToData(),
               axis.ToData(),
               bottomRaduis,
               topRadius,
               height);

            if (body == null)
                throw new NullReferenceException("Create Body Error");

            var cone = new Cone(
                body,
                center,
                axis,
                bottomRaduis,
                topRadius,
                height);

            return cone;
        }

        public static Body ByCenter2RaduisHeight(
            Point3D center,
            double height, 
            double bottomRaduis,
            double topRadius =0)
        { 
            return ByCenterAxis2RaduisHeight((Point3D)center, Vector3D.ByCoordinates(0,0,1),bottomRaduis,topRadius,height);
        }
        #endregion
    }
}
