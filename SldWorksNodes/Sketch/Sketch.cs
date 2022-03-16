using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SldWorksNodes.SwException;
using SolidWorks.Interop.sldworks;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Feature;
using System;

namespace SldWorksNodes.Sketch
{
    /// <summary>
    /// SolidWork Sketch
    /// </summary>
    public class Sketch : SpecFeature<ISketch, string>
    {
        #region Ctor
        internal Sketch(IFeature sketch) : base(sketch)
        {
        }
        #endregion

        #region Creation
        /// <summary>
        /// get a sketch in solidworks.
        /// </summary>
        /// <param name="name">Sketch's Name</param>
        /// <returns>a sketch object</returns>
        public static Sketch ByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return null;

            IFeature existFeat = SwContextUtil.GetFeatureByName(name, FeatTypeNameUtil.ProfileFeature);

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

            if (feat.GetTypeName2() != FeatTypeNameUtil.ProfileFeature)
                throw new FeatureTypeNameErrorException(feat.Name, FeatTypeNameUtil.ProfileFeature);

            return new Sketch(feat);
        }

        public static Sketch ByFeature(Feature.Feature skeFeature)
        {
            if (skeFeature == null)
                return null;

            if (skeFeature.SwObject.GetTypeName2() != FeatTypeNameUtil.ProfileFeature)
                throw new FeatureTypeNameErrorException(skeFeature.Name, FeatTypeNameUtil.ProfileFeature);

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
        public static Sketch CreateSketch(Feature.Feature refPlaneFeat, string name)
        {
            if (refPlaneFeat == null || string.IsNullOrWhiteSpace(name))
                return null;

            if(refPlaneFeat.SwObject.GetTypeName2() != FeatTypeNameUtil.RefPlane)
                throw new FeatureTypeNameErrorException(refPlaneFeat.Name, FeatTypeNameUtil.RefPlane);

            var doc = SwContextUtil.GetActivDocContext();
            if (doc == null)
                return null;

            if (doc.SketchManager.ActiveSketch != null)
                doc.EditSketch();
            var feat = doc.FindFeat(name);

            if (feat != null)
            {
                if (feat.GetTypeName2() != FeatTypeNameUtil.ProfileFeature)
                    throw new InvalidOperationException($"{name} Exist and it's not a sketch");

                return new Sketch(feat);
            }

            //Create sketch
            (refPlaneFeat.SwObject).Select2(false, 0);
            doc.SketchManager.InsertSketch(true);
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

            return null;
        }

        public static Sketch CreateSketch(Brep.Face face, string name)
        {
            if (face == null || string.IsNullOrWhiteSpace(name))
                return null;

            if (!face.IsPlane())
                throw new Exception("Current face is not a plane");

            var doc = SwContextUtil.GetActivDocContext();
            if (doc == null)
                return null;

            if (doc.SketchManager.ActiveSketch != null)
                doc.EditSketch();
            var feat = doc.FindFeat(name);

            if (feat != null)
            {
                if (feat.GetTypeName2() != FeatTypeNameUtil.ProfileFeature)
                    throw new InvalidOperationException($"{name} Exist and it's not a sketch");

                return new Sketch(feat);
            }

            //Create sketch
            ((Entity)face.SwObject).Select2(false, 0);
            doc.SketchManager.InsertSketch(true);
            if(doc.SketchManager.ActiveSketch != null)
            {
                var skeFeat =(doc.SketchManager.ActiveSketch as IFeature);
                skeFeat.Name = name;
                return new Sketch(skeFeat);
            }
            else
            {
                throw new Exception("Create Sketch failed");
            }

        }
   
        /// <summary>
        /// Set Sketch Name
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            var feat = SwObject as IFeature;
            if (feat != null)
                feat.Name = name;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return Name ?? base.ToString();
        }
        #endregion
    }
}
