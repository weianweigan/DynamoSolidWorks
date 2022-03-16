using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Feature;
using SldWorksNodes.SwException;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    public class Sketch3D:SwSketch
    {
        #region Ctor
        internal Sketch3D(IFeature sketch) : base(sketch)
        {
        }
        #endregion

        #region Create
        /// <summary>
        /// get a sketch in solidworks.
        /// </summary>
        /// <param name="name">Sketch's Name</param>
        /// <returns>a sketch object</returns>
        public static Sketch ByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return null;

            IFeature existFeat = SwContextUtil.GetFeatureByName(name, FeatTypeNameUtil.ThreeDProfileFeature);

            if (existFeat == null)
                return null;

            return new Sketch(existFeat);
        }

        public static Sketch ByPID(string pid)
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();

            var feat = PIDUtil.GetObjectFromPID(pid, out var state) as IFeature;
            PIDUtil.AssertState(state);

            if (feat == null)
                return null;

            if (feat.GetTypeName2() != FeatTypeNameUtil.ThreeDProfileFeature)
                throw new FeatureTypeNameErrorException(feat.Name, FeatTypeNameUtil.ThreeDProfileFeature);

            return new Sketch(feat);
        }

        public static Sketch ByFeature(Feature.Feature skeFeature)
        {
            if (skeFeature == null)
                return null;

            if (skeFeature.SwObject.GetTypeName2() != FeatTypeNameUtil.ThreeDProfileFeature)
                throw new FeatureTypeNameErrorException(skeFeature.Name, FeatTypeNameUtil.ThreeDProfileFeature);

            return new Sketch(skeFeature.SwObject);
        }
        #endregion

        #region Query
        /// <summary>
        /// Name of Sketch Feature
        /// </summary>
        public string Name => ((IFeature)SwObject)?.Name;
        #endregion

        #region Action
        [IsVisibleInDynamoLibrary(false)]
        public static Sketch CreateSketch(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return null;

            var doc = SwContextUtil.GetActivDocContext();
            if (doc == null)
                return null;

            if (doc.SketchManager.ActiveSketch != null)
                doc.EditSketch();
            var feat = doc.FindFeat(name);

            if (feat != null)
            {
                if (feat.GetTypeName2() != FeatTypeNameUtil.ThreeDProfileFeature)
                    throw new InvalidOperationException($"{name} Exist and it's not a sketch");

                return new Sketch(feat);
            }

            //Create sketch
            doc.SketchManager.Insert3DSketch(true);
            if (doc.SketchManager.ActiveSketch != null)
            {
                var skeFeat = (doc.SketchManager.ActiveSketch as IFeature);
                skeFeat.Name = name;
                return new Sketch(skeFeat);
            }
            else
            {
                throw new Exception("Create Sketch failed");
            }

        }
        #endregion

    }
}
 