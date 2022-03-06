using SldWorksNodes.Base;
using SldWorksNodes.SwException;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SldWorksNodes.Assembly
{
    public class Component:SwNodeModel<IComponent2>
    {
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
            if(parent ==null)
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
    }
}
