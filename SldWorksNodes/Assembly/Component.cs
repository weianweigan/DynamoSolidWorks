using System;
using System.Collections.Generic;
using System.Linq;
using Autodesk.DesignScript.Runtime;
using SldWorksNodes.Base;
using SldWorksNodes.Geometry;
using SldWorksNodes.Manager;
using SldWorksNodes.SwException;
using SldWorksNodes.Util;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace SldWorksNodes.Assembly
{
    public class Component : SwNodeModel<IComponent2>,ISwMaterialProperty
    {
        #region Ctor
        [IsVisibleInDynamoLibrary(false)]
        public Component(IComponent2 comp)
        {
            SwObject = comp;
        }
        #endregion

        #region Creation
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
            var doc = SwContextUtil.GetActivDocContext();

            var obj = PIDUtil.GetObjectFromPID(pid, out var state) as IComponent2;
            PIDUtil.AssertState(state);

            if (obj != null)
                return new Component(obj);
            else
                throw new SwObjectLostException(typeof(IComponent2));
        }
        #endregion

        #region Query
        public int ID => SwObject.GetID();

        public bool IsFixed => SwObject.IsFixed();

        public bool IsHidden(bool considerSuppressed = false)
        {

            return SwObject.IsHidden(false);
        }

        public bool IsMirrored => SwObject.IsMirrored();

        public bool IsPatternInstance() => SwObject.IsPatternInstance();

        public bool IsRoot() => SwObject.IsRoot();

        public bool IsSmartComponent => SwObject.IsSmartComponent();

        public bool IsSuppressed => SwObject.IsSuppressed();

        public Feature.Feature FeatureByName(string name)
        {
            var feat = SwObject?.FeatureByName(name);

            if (feat == null)
                return null;

            return new Feature.Feature(feat);
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

        public Transform.SwCoordiateSystem CompCoordiate()
        {
            var data = SwObject.Transform2.ArrayData as double[];
            return Transform.SwCoordiateSystem.ByMatrix(data);
        }

        public Transform.SwCoordiateSystem CompPresentationCoordiate()
        {
            var data = SwObject.PresentationTransform.ArrayData as double[];
            return Transform.SwCoordiateSystem.ByMatrix(data);
        }
        #endregion

        #region Action
        public void SetName(string newName)
        {
            SwObject.Name2 = newName;
        }

        /// <summary>
        /// Set component's postion in assembly
        /// </summary>
        /// <param name="point">Postion of this component</param>
        public bool SetPostion(Point3D point)
        {
            var data = SwObject.Transform2.ArrayData as double[];

            var newPoint = _swUnit.ConvertPoint(point);
            data[9] = newPoint.X;
            data[10] = newPoint.Y;
            data[11] = newPoint.Z;

            var trans = Transform.SwCoordiateSystem.ByMatrix(data);
            SwObject.Transform2 = trans.ToSwTransform(null);

            return true;
        }

        public bool SetCoordiateSystem(Transform.SwCoordiateSystem coordiateSystem)
        {
            var swTrans = coordiateSystem.ToSwTransform(_swUnit);
            SwObject.Transform2 = swTrans;
            
            SwContextUtil.GetActivDocContext()?.GraphicsRedraw2();

            return true;
        }

        public bool SetPresentationCoordiate(Transform.SwCoordiateSystem coordiateSystem)
        {
            var swTrans = coordiateSystem.ToSwTransform(_swUnit);
            SwObject.PresentationTransform = swTrans;

            SwContextUtil.GetActivDocContext()?.GraphicsRedraw2();

            return true;
        }

        public CustomProperty.CustomProperty CustomProperty(string name,string configuration = "")
        {
            return SldWorksNodes.CustomProperty.CustomPropertyManager.Get(Doc().SwObject,name,configuration);
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return SwObject?.Name ?? base.ToString();
        }

        public MaterialProperty MaterialProperty()
        {
            var data = SwObject.MaterialPropertyValues as double[];
            return SldWorksNodes.MaterialProperty.ByArrary(data);
        }

        public void SetMaterialProperty(MaterialProperty materialProperty)
        {
            SwObject.MaterialPropertyValues = materialProperty.ToArray();
        }
        #endregion
    }
}
