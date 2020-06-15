using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IEndCapFeatureDataObject
    {
        public IEndCapFeatureData IEndCapFeatureDataInstance { get; set; }
        public IEndCapFeatureDataObject(IEndCapFeatureData IEndCapFeatureDatainstance)
        {
            IEndCapFeatureDataInstance = IEndCapFeatureDatainstance;
        }
    }
    public static class IEndCapFeatureDataInterface
    {
        public static Boolean AccessSelections(IEndCapFeatureDataObject IEndCapFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IEndCapFeatureDatainstance.IEndCapFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IEndCapFeatureDataObject IEndCapFeatureDatainstance)
        {
            IEndCapFeatureDatainstance.IEndCapFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static IFace2Object Face(IEndCapFeatureDataObject IEndCapFeatureDatainstance)
        {
            return new IFace2Object(IEndCapFeatureDatainstance.IEndCapFeatureDataInstance.Face);
        }
        public static Double Thickness(IEndCapFeatureDataObject IEndCapFeatureDatainstance)
        {
            return IEndCapFeatureDatainstance.IEndCapFeatureDataInstance.Thickness;
        }
        public static Boolean UseThicknessRatioForOffset(IEndCapFeatureDataObject IEndCapFeatureDatainstance)
        {
            return IEndCapFeatureDatainstance.IEndCapFeatureDataInstance.UseThicknessRatioForOffset;
        }
        public static Double ThicknessRatioForOffset(IEndCapFeatureDataObject IEndCapFeatureDatainstance)
        {
            return IEndCapFeatureDatainstance.IEndCapFeatureDataInstance.ThicknessRatioForOffset;
        }
        public static Double OffsetDistance(IEndCapFeatureDataObject IEndCapFeatureDatainstance)
        {
            return IEndCapFeatureDatainstance.IEndCapFeatureDataInstance.OffsetDistance;
        }
        public static Boolean UseChamferCorners(IEndCapFeatureDataObject IEndCapFeatureDatainstance)
        {
            return IEndCapFeatureDatainstance.IEndCapFeatureDataInstance.UseChamferCorners;
        }
        public static Double ChamferDistance(IEndCapFeatureDataObject IEndCapFeatureDatainstance)
        {
            return IEndCapFeatureDatainstance.IEndCapFeatureDataInstance.ChamferDistance;
        }
        public static Boolean UseCornerTreatment(IEndCapFeatureDataObject IEndCapFeatureDatainstance)
        {
            return IEndCapFeatureDatainstance.IEndCapFeatureDataInstance.UseCornerTreatment;
        }
        public static Double DepthDistance(IEndCapFeatureDataObject IEndCapFeatureDatainstance)
        {
            return IEndCapFeatureDatainstance.IEndCapFeatureDataInstance.DepthDistance;
        }
        public static Boolean UseReverse(IEndCapFeatureDataObject IEndCapFeatureDatainstance)
        {
            return IEndCapFeatureDatainstance.IEndCapFeatureDataInstance.UseReverse;
        }
        public static Int32 IsEndCapInward(IEndCapFeatureDataObject IEndCapFeatureDatainstance)
        {
            return IEndCapFeatureDatainstance.IEndCapFeatureDataInstance.IsEndCapInward;
        }
    }
}