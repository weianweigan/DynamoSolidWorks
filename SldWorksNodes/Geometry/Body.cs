using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;

namespace SldWorksNodes.Geometry
{
    public class Body : SwBodyNode
    {
        internal Body(IBody2 body)
        {
            SwObject=body;

            var doc = SwContextUtil.GetCurrentPartDocContext();
            if (SwObject != null)
                DisplayBody(doc, Color);
        }
      
        public static Body ByClinder(Point3D center,Vector3D axis,double radius,double height)
        {
            if (radius <= 0)
                throw new ArgumentException("Raduis > 0");
            if (height <= 0)
                throw new ArgumentException("Height > 0");

            var body = BodyBuilder.CreateCylinderBody(
                SldContextManager.Modeler,
                center.ToData(),
                axis.ToData(),
                radius,
                height);

            if (body == null)
                throw new NullReferenceException("Create Body Error");

            return new Body(body);
        }

        public static Body ByCone(Point3D center,Vector3D axis,double bottomRaduis,double topRadius,double height)
        {
            if (bottomRaduis < 0)
                throw new ArgumentException("bottomRaduis >= 0");
            if (topRadius < 0)
                throw new ArgumentException("topRadius >= 0");
            if (height <= 0)
                throw new ArgumentException("Height > 0");
            if (topRadius == 0 && bottomRaduis ==0)
                throw new ArgumentException("Radius cannot all zero");

            var body= BodyBuilder.CreateConeBody(center.ToData(),axis.ToData(),bottomRaduis,topRadius,height);

            if (body == null)
                throw new NullReferenceException("Create Body Error");

            return new Body(body);
        }

        /// <summary>
        /// Save body file to feature
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="NullReferenceException"></exception>
        public Feature.Feature SaveToFeature(string featureName)
        {
            if (SwObject == null)
                throw new ArgumentException("No body to save");

            var doc = SwContextUtil.GetCurrentPartDocContext();

            var oldFeat = doc.FindFeat(featureName);
            if (oldFeat != null)
            {
                oldFeat.Select2(false, 0);
                doc.DeleteSelection(false);
            }

            var feat = ((IPartDoc)doc).CreateFeatureFromBody3(SwObject, false, (int)swCreateFeatureBodyOpts_e.swCreateFeatureBodySimplify) as IFeature;

            if (feat == null)
                throw new NullReferenceException("Save Fail");

            feat.Name = featureName;
            return new Feature.Feature(feat);
        }
    }
}
