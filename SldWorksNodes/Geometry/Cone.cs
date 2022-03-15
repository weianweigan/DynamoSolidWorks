using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using System;

namespace SldWorksNodes.Geometry
{
    public class Cone : Body
    {
        internal Cone(IBody2 body, bool display = true) : base(body, display)
        {
        }

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

            return new Cone(body);
        }

        public static Body ByCenter2RaduisHeight(
            Point3D center,
            double height, 
            double bottomRaduis,
            double topRadius =0)
        { 
            return ByCenterAxis2RaduisHeight((Point3D)center, Vector3D.ByCoordinates(0,0,1),bottomRaduis,topRadius,height);
        }
    }
}
