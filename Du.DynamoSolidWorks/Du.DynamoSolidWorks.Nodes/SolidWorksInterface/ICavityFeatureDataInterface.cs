using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICavityFeatureDataObject
    {
        public ICavityFeatureData ICavityFeatureDataInstance { get; set; }
        public ICavityFeatureDataObject(ICavityFeatureData ICavityFeatureDatainstance)
        {
            ICavityFeatureDataInstance = ICavityFeatureDatainstance;
        }
    }
    public static class ICavityFeatureDataInterface
    {
        public static Boolean AccessSelections(ICavityFeatureDataObject ICavityFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ICavityFeatureDatainstance.ICavityFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(ICavityFeatureDataObject ICavityFeatureDatainstance)
        {
            ICavityFeatureDatainstance.ICavityFeatureDataInstance.ReleaseSelectionAccess();
        }
        //public static void GetScale(ICavityFeatureDataObject ICavityFeatureDatainstance, Double& Xscale, Double& YScale, Double& ZScale)
        //{
        //    return ICavityFeatureDatainstance.ICavityFeatureDataInstance.GetScale(Xscale, YScale, ZScale);
        //}
        public static void SetScale(ICavityFeatureDataObject ICavityFeatureDatainstance, Double Xscale, Double YScale, Double ZScale)
        {
            ICavityFeatureDatainstance.ICavityFeatureDataInstance.SetScale(Xscale, YScale, ZScale);
        }
        public static Int32 GetComponentsCount(ICavityFeatureDataObject ICavityFeatureDatainstance)
        {
            return ICavityFeatureDatainstance.ICavityFeatureDataInstance.GetComponentsCount();
        }
        //public static void IGetComponents(ICavityFeatureDataObject ICavityFeatureDatainstance, Int32 Count, Component2&Object Comps)
        //{
        //    return ICavityFeatureDatainstance.ICavityFeatureDataInstance.IGetComponents(Count, Comps);
        //}
        //public static void ISetComponents(ICavityFeatureDataObject ICavityFeatureDatainstance, Int32 Count, Component2&Object Comps)
        //{
        //    return ICavityFeatureDatainstance.ICavityFeatureDataInstance.ISetComponents(Count, Comps);
        //}
        public static Int32 ScaleType(ICavityFeatureDataObject ICavityFeatureDatainstance)
        {
            return ICavityFeatureDatainstance.ICavityFeatureDataInstance.ScaleType;
        }
        public static Double UniformScale(ICavityFeatureDataObject ICavityFeatureDatainstance)
        {
            return ICavityFeatureDatainstance.ICavityFeatureDataInstance.UniformScale;
        }
        public static Boolean UseUniformScale(ICavityFeatureDataObject ICavityFeatureDatainstance)
        {
            return ICavityFeatureDatainstance.ICavityFeatureDataInstance.UseUniformScale;
        }
        public static Object Components(ICavityFeatureDataObject ICavityFeatureDatainstance)
        {
            return ICavityFeatureDatainstance.ICavityFeatureDataInstance.Components;
        }
    }
}