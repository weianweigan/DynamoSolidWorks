using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IThickenFeatureDataObject
    {
        public IThickenFeatureData IThickenFeatureDataInstance { get; set; }
        public IThickenFeatureDataObject(IThickenFeatureData IThickenFeatureDatainstance)
        {
            IThickenFeatureDataInstance = IThickenFeatureDatainstance;
        }
    }
    public static class IThickenFeatureDataInterface
    {
        public static Boolean IAccessSelections(IThickenFeatureDataObject IThickenFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IThickenFeatureDatainstance.IThickenFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static Boolean AccessSelections(IThickenFeatureDataObject IThickenFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IThickenFeatureDatainstance.IThickenFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(IThickenFeatureDataObject IThickenFeatureDatainstance)
        {
            IThickenFeatureDatainstance.IThickenFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetFeatureScopeBodiesCount(IThickenFeatureDataObject IThickenFeatureDatainstance)
        {
            return IThickenFeatureDatainstance.IThickenFeatureDataInstance.GetFeatureScopeBodiesCount();
        }
        public static IBody2Object IGetFeatureScopeBodies(IThickenFeatureDataObject IThickenFeatureDatainstance, Int32 Count)
        {
            return new IBody2Object(IThickenFeatureDatainstance.IThickenFeatureDataInstance.IGetFeatureScopeBodies(Count));
        }
        //public static void ISetFeatureScopeBodies(IThickenFeatureDataObject IThickenFeatureDatainstance, Int32 Count, Body2&Object BodyArr)
        //{
        //    return IThickenFeatureDatainstance.IThickenFeatureDataInstance.ISetFeatureScopeBodies(Count, BodyArr);
        //}
        public static Boolean IsBossFeature(IThickenFeatureDataObject IThickenFeatureDatainstance)
        {
            return IThickenFeatureDatainstance.IThickenFeatureDataInstance.IsBossFeature();
        }
        public static Object Surface(IThickenFeatureDataObject IThickenFeatureDatainstance)
        {
            return IThickenFeatureDatainstance.IThickenFeatureDataInstance.Surface;
        }
        public static Double Thickness(IThickenFeatureDataObject IThickenFeatureDatainstance)
        {
            return IThickenFeatureDatainstance.IThickenFeatureDataInstance.Thickness;
        }
        public static Int16 ThicknessSide(IThickenFeatureDataObject IThickenFeatureDatainstance)
        {
            return IThickenFeatureDatainstance.IThickenFeatureDataInstance.ThicknessSide;
        }
        public static Boolean FillVolume(IThickenFeatureDataObject IThickenFeatureDatainstance)
        {
            return IThickenFeatureDatainstance.IThickenFeatureDataInstance.FillVolume;
        }
        public static Boolean Merge(IThickenFeatureDataObject IThickenFeatureDatainstance)
        {
            return IThickenFeatureDatainstance.IThickenFeatureDataInstance.Merge;
        }
        public static Boolean FeatureScope(IThickenFeatureDataObject IThickenFeatureDatainstance)
        {
            return IThickenFeatureDatainstance.IThickenFeatureDataInstance.FeatureScope;
        }
        public static Boolean AutoSelect(IThickenFeatureDataObject IThickenFeatureDatainstance)
        {
            return IThickenFeatureDatainstance.IThickenFeatureDataInstance.AutoSelect;
        }
        public static Object FeatureScopeBodies(IThickenFeatureDataObject IThickenFeatureDatainstance)
        {
            return IThickenFeatureDatainstance.IThickenFeatureDataInstance.FeatureScopeBodies;
        }
    }
}