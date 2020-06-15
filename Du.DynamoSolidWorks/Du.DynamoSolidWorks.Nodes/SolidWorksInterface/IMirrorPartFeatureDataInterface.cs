using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMirrorPartFeatureDataObject
    {
        public IMirrorPartFeatureData IMirrorPartFeatureDataInstance { get; set; }
        public IMirrorPartFeatureDataObject(IMirrorPartFeatureData IMirrorPartFeatureDatainstance)
        {
            IMirrorPartFeatureDataInstance = IMirrorPartFeatureDatainstance;
        }
    }
    public static class IMirrorPartFeatureDataInterface
    {
        public static IModelDoc2Object GetModelDoc(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return new IModelDoc2Object(IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.GetModelDoc());
        }
        public static Object GetMirrorPlane(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.GetMirrorPlane();
        }
        public static Int32 GetMirrorPlaneType(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.GetMirrorPlaneType();
        }
        public static Boolean AccessSelections(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static IMathTransformObject GetTransform(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return new IMathTransformObject(IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.GetTransform());
        }
        public static Boolean AbsorbedSketches(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.AbsorbedSketches;
        }
        public static Boolean Axes(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.Axes;
        }
        public static Boolean CoordinateSystems(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.CoordinateSystems;
        }
        public static Boolean CosmeticThreads(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.CosmeticThreads;
        }
        public static Boolean CustomProperties(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.CustomProperties;
        }
        public static Boolean HoleWizardData(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.HoleWizardData;
        }
        public static Boolean ModelDimensions(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.ModelDimensions;
        }
        public static Boolean Planes(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.Planes;
        }
        public static Boolean SolidBodies(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.SolidBodies;
        }
        public static Boolean SurfaceBodies(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.SurfaceBodies;
        }
        public static Boolean UnabsorbedSketches(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.UnabsorbedSketches;
        }
        public static String PathName(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.PathName;
        }
        public static Boolean CutListProperties(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.CutListProperties;
        }
        public static Boolean SheetMetalInformation(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.SheetMetalInformation;
        }
        public static Boolean UnlockedProperties(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.UnlockedProperties;
        }
        public static Boolean DimXpertAnnotations(IMirrorPartFeatureDataObject IMirrorPartFeatureDatainstance)
        {
            return IMirrorPartFeatureDatainstance.IMirrorPartFeatureDataInstance.DimXpertAnnotations;
        }
    }
}