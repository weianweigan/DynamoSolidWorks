using SldWorksNodes.Base;
using SldWorksNodes.Util;
using SldWorksNodes.SwException;
using SolidWorks.Interop.sldworks;

namespace SldWorksNodes.Sketch
{
    /// <summary>
    /// SolidWork Sketch
    /// </summary>
    public class Sketch:SwNodeModel<ISketch>
    {
        internal Sketch(string sketchName)
        {
            SketchName = sketchName;
            SolveSketch();
        }

        #region Properties
        /// <summary>
        /// Name of Sketch Feature
        /// </summary>
        public string SketchName { get; set; }
        #endregion

        #region Public Static Methods
        /// <summary>
        /// Create a sketch in solidworks.
        /// </summary>
        /// <param name="name">Sketch's Name</param>
        /// <returns></returns>
        public static Sketch ByName(string name)
        {
            return new Sketch(name);
        }
        #endregion

        #region Private Methods
        private void SolveSketch()
        {
            var doc = SldContextManager.Sw.IActiveDoc2;
            if (doc == null) throw new ActiveDocNotFoundException();

            if (!doc.IsPartDocContext(out var currentDoc))
            {
                throw new ActiveDocIsNotPartDocException();
            }
            var existFeat = currentDoc.FindFeat(SketchName);
            if (existFeat == null)
            {
                throw new FeatureNotFoundException(SketchName);
            }

            if (existFeat.GetTypeName2() != FeatTypeNameUtil.ProfileFeature)
            {
                throw new FeatureTypeNameErrorException(existFeat.Name,existFeat.GetTypeName2());
            }

            SwObject = existFeat.GetSpecificFeature2() as ISketch;
        }
        #endregion
    }
}
