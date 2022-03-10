using SldWorksNodes.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;
using SldWorksNodes.Util;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.SwException;

namespace SldWorksNodes.Feature
{
    /// <summary>
    /// Feature in SolidWorks
    /// </summary>
    public class Feature : SwNodeModel<IFeature>
    {
        internal Feature(IFeature feature)
        {
            SwObject = feature;
        }

        /// <summary>
        /// Get a feature from feature name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Feature ByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return null;

            IFeature existFeat = SwContextUtil.GetFeatureByName(name);

            return new Feature(existFeat);
        }
  
        public static Feature ByPID(string pid)
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();

            var obj = PIDUtil.GetObjectFromPID(pid, out var state) as IFeature;
            PIDUtil.AssertState(state);

            if (obj != null)
                return new Feature(obj);
            else
                throw new SwObjectLostException(typeof(IDisplayDimension));
        }
        
        public string Name => SwObject?.Name;

        /// <summary>
        /// Gets the name of the user who created the feature.  
        /// </summary>
        public string CreatedBy => SwObject?.CreatedBy;

        /// <summary>
        /// Gets or sets the description for this feature.  
        /// </summary>
        public string Description => SwObject?.Description;


        /// <summary>
        /// Get all dimensions belong to this feature
        /// </summary>
        /// <returns></returns>
        public List<Dimension.Dimension> Dimensions()
        {
            AssertSwObject();

            return SwObject
                .GetAllDimensions()
                .Select(p => new Dimension.Dimension(p))
                .ToList();
        }

        public void SetName(string name)
        {
            AssertSwObject();
            SwObject.Name = name;
        }

        /// <summary>
        /// Get Name
        /// </summary>
        [IsVisibleInDynamoLibrary(false)]
        public override string ToString()
        {
            return Name ?? base.ToString();
        }

        /// <summary>
        /// Get a feature from current selection
        /// </summary>
        /// <returns></returns>
        private static Feature CurrentSelection()
        {
            var feature = SwContextUtil.GetCurrentSelectedFeature();
            return new Feature(feature);
        }

        public List<Brep.Face> Faces()
        {
            if (SwObject == null)
                return null;

            var objs = SwObject.GetFaces() as object[];

            if (objs != null)
                return null;

            return objs
                .Cast<IFace2>()
                .Select(p => new Brep.Face(p))
                .ToList();
        }

    }
}
