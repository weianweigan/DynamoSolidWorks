using SldWorksNodes.Base;
using SldWorksNodes.SwException;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SldWorksNodes.Assembly
{
    public class Component : SwNodeModel<IComponent2>
    {
        #region Ctor
        internal Component(IComponent2 comp)
        {
            SwObject = comp;
        }

        /// <summary>
        /// Get a feature from feature name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Component ByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return null;

            IFeature existFeat = SwContextUtil.GetFeatureByName(name);

            return ByFeature(existFeat);
        }

        private static Component ByFeature(IFeature feature)
        {
            if (feature.GetTypeName2() != FeatTypeNameUtil.Reference)
                throw new SwException.FeatureTypeNameErrorException(feature.Name, feature.GetTypeName2());

            return new Component(feature.GetSpecificFeature2() as IComponent2);
        }

        public static Component ByPID(string pid)
        {
            var doc = SwContextUtil.GetCurrentPartDocContext();

            var obj = PIDUtil.GetObjectFromPID(pid, out var state) as IComponent2;
            PIDUtil.AssertState(state);

            if (obj != null)
                return new Component(obj);
            else
                throw new SwObjectLostException(typeof(IComponent2));
        }
        #endregion

        #region Some Properties about component
        public int ID => SwObject.GetID();

        public bool IsFixed => SwObject.IsFixed();

        public bool IdHidden(bool considerSuppressed = false)
        {

            return SwObject.IsHidden(false);
        }

        public bool IsMirrored => SwObject.IsMirrored();

        public bool IsPatternInstance() => SwObject.IsPatternInstance();

        public bool IsRoot() => SwObject.IsRoot();

        public bool IsSmartComponent => SwObject.IsSmartComponent();

        public bool IsSuppressed => SwObject.IsSuppressed();
        #endregion

        #region Methods
        public void SetName(string newName)
        {
            SwObject.Name2 = newName;
        }

        public Feature.Feature FeatureByName(string name)
        {
            var feat = SwObject?.FeatureByName(name);

            if (feat == null)
                return null;

            return new Feature.Feature(feat);
        }

        public override string ToString()
        {
            return SwObject?.Name ?? base.ToString();
        }

        public string PathName()
        {
            return SwObject?.GetPathName();
        }

        public Component Parent()
        {
            var parent = SwObject?.GetParent() as IComponent2;
            if (parent == null)
                return null;

            return new Component(parent);
        }

        public List<Component> Children()
        {
            var children = SwObject?.GetChildren() as Object[];

            if (children == null)
                return null;

            return children
                .Cast<IComponent2>()
                .Select(c => new Component(c))
                .ToList();
        }

        public Document.Document Doc()
        {
            if (SwObject == null)
                return null;

            var doc = SwObject.GetModelDoc2() as IModelDoc2;

            return doc != null ? new Document.Document(doc) : null;
        }

        public string ReferencedConfiguration => SwObject?.ReferencedConfiguration;

        public List<Geometry.Body> Bodies()
        {
            var bodies = SwObject.GetBodies2((int)swBodyType_e.swAllBodies) as object[];

            if (bodies == null)
                return null;

            return bodies
                .Cast<IBody2>()
                .Select(p => new Geometry.Body(p))
                .ToList();
        }
        #endregion
    }
}
