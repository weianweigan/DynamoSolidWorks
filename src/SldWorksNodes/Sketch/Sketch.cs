using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SldWorksNodes.SwException;
using SolidWorks.Interop.sldworks;
using Autodesk.DesignScript.Runtime;

namespace SldWorksNodes.Sketch
{
    /// <summary>
    /// SolidWork Sketch
    /// </summary>
    public class Sketch:SwNodeModel<ISketch>
    {
        internal Sketch(ISketch sketch)
        {
            SwObject = sketch;
        }

        /// <summary>
        /// Create a sketch in solidworks.
        /// </summary>
        /// <param name="name">Sketch's Name</param>
        /// <returns>a sketch object</returns>
        public static Sketch ByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return null;

            IFeature existFeat = SwContextUtil.GetFeatureByName(name, FeatTypeNameUtil.ProfileFeature);

            var ske = existFeat.GetSpecificFeature2() as ISketch;

            return new Sketch(ske);
        }

        public static Sketch ByPID(string pid)
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();

            var feat = PIDUtil.GetObjectFromPID(pid, out var state) as IFeature;
            PIDUtil.AssertState(state);

            var ske = feat?.GetSpecificFeature2() as ISketch;

            if (ske != null)
                return new Sketch(ske);
            else
                throw new SwObjectLostException(typeof(IDisplayDimension));
        }

        [IsVisibleInDynamoLibrary(false)]
        public static Sketch CreateSketch(IFeature feat)
        {
            return null;
        }

        [IsVisibleInDynamoLibrary(false)]
        public static Sketch CreateSketch(Brep.Face face)
        {
            return null;
        }

        #region Properties
        /// <summary>
        /// Name of Sketch Feature
        /// </summary>
        public string Name => ((IFeature)SwObject)?.Name;
        #endregion

/// <summary>
        /// Pre-Select sketch feature,then create this node
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FeatureTypeNameErrorException"></exception>
        private static Sketch CurrentSelection()
        {
            var feature = SwContextUtil.GetCurrentSelectedFeature();

            if (feature.GetTypeName2() != FeatTypeNameUtil.ProfileFeature)
                throw new FeatureTypeNameErrorException(feature.Name, FeatTypeNameUtil.ProfileFeature);

            var ske = feature.GetSpecificFeature2() as ISketch;

            return new Sketch(ske);
        }

        /// <summary>
        /// SketchName
        /// </summary>
        [IsVisibleInDynamoLibrary(false)]
        public override string ToString()
        {
            return Name ?? base.ToString();
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
    }
}
