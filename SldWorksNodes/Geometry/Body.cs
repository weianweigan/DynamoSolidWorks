using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SldWorksNodes.Geometry
{
    public class Body : SwBodyNode
    {
        internal Body(IBody2 body,bool display = true)
        {
            SwObject=body;

            var doc = SwContextUtil.GetCurrentPartDocContext();
            if (SwObject != null)
                DisplayBody(doc, Color);
        }

        public List<Brep.Face> Faces()
        {
            if (SwObject == null)
                return null;

            var objs = SwObject.GetFaces() as object[];

            return objs
                .Cast<IFace2>()
                .Select(p => new Brep.Face(p))
                .ToList();
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
