using Autodesk.DesignScript.Runtime;
using SldWorksNodes.SwException;
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
        #region Ctor
        [IsVisibleInDynamoLibrary(false)]
        public Body(IBody2 body,bool display = true)
        {
            SwObject=body;

            var doc = SwContextUtil.GetCurrentPartDocContext();
            if (SwObject != null && display)
                DisplayBody(doc, Color);
        }
        #endregion

        #region Query
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
        #endregion

        #region Create
        public static Body ByPID(string pid)
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();

            var obj = PIDUtil.GetObjectFromPID(pid, out var state) as IBody2;
            PIDUtil.AssertState(state);

            if (obj != null)
                return new Body(obj);
            else
                throw new SwObjectLostException(typeof(IFace2));
        }
        #endregion

        #region Methods
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

        public Dictionary<string,Point3D> Box()
        {
            if (SwObject == null)
                return null;

            var box = SwObject.GetBodyBox() as double[];
            if (box == null)
                return null;

            return new Dictionary<string, Point3D>()
            {
                {"min",new Point3D(box[0],box[1],box[2]) },
                {"max",new Point3D(box[3],box[4],box[5]) },
            };
        }
        #endregion
    }
}
