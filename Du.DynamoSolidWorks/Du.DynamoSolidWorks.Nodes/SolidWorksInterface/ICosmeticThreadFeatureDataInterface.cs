using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICosmeticThreadFeatureDataObject
    {
        public ICosmeticThreadFeatureData ICosmeticThreadFeatureDataInstance { get; set; }
        public ICosmeticThreadFeatureDataObject(ICosmeticThreadFeatureData ICosmeticThreadFeatureDatainstance)
        {
            ICosmeticThreadFeatureDataInstance = ICosmeticThreadFeatureDatainstance;
        }
    }
    public static class ICosmeticThreadFeatureDataInterface
    {
        public static Boolean AccessSelections(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetPatternedTransformsCount(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.GetPatternedTransformsCount();
        }
        public static IMathTransformObject IGetPatternedTransforms(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance, Int32 Count)
        {
            return new IMathTransformObject(ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.IGetPatternedTransforms(Count));
        }
        public static Int32 ApplyThread(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.ApplyThread;
        }
        public static Double BlindDepth(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.BlindDepth;
        }
        public static Double Diameter(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.Diameter;
        }
        public static Int32 DiameterType(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.DiameterType;
        }
        public static String ThreadCallout(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.ThreadCallout;
        }
        public static IEdgeObject Edge(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return new IEdgeObject(ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.Edge);
        }
        public static Object PatternedTransforms(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.PatternedTransforms;
        }
        public static Object StartFromFacePlane(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.StartFromFacePlane;
        }
        public static Int32 Standard(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.Standard;
        }
        public static String StandardType(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.StandardType;
        }
        public static String Size(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.Size;
        }
        public static Int32 ConfigurationOption(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.ConfigurationOption;
        }
        public static Object ConfigurationNames(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.ConfigurationNames;
        }
        public static Int32 EndCondition(ICosmeticThreadFeatureDataObject ICosmeticThreadFeatureDatainstance)
        {
            return ICosmeticThreadFeatureDatainstance.ICosmeticThreadFeatureDataInstance.EndCondition;
        }
    }
}