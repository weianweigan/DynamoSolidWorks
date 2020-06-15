using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFlatPatternFeatureDataObject
    {
        public IFlatPatternFeatureData IFlatPatternFeatureDataInstance { get; set; }
        public IFlatPatternFeatureDataObject(IFlatPatternFeatureData IFlatPatternFeatureDatainstance)
        {
            IFlatPatternFeatureDataInstance = IFlatPatternFeatureDatainstance;
        }
    }
    public static class IFlatPatternFeatureDataInterface
    {
        public static Boolean AccessSelections(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static void ReleaseSelectionAccess(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Boolean IAccessSelections2(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.IAccessSelections2(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        //public static Boolean GetAddCornerTrim(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance, Feature&Object PFeat)
        //{
        //    return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.GetAddCornerTrim(PFeat);
        //}
        public static void SetAddCornerTrim(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance, Boolean BCT)
        {
            IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.SetAddCornerTrim(BCT);
        }
        //public static Boolean GetBreakCorners(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance, Feature&Object PFeat)
        //{
        //    return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.GetBreakCorners(PFeat);
        //}
        public static void SetBreakCorners(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance, Boolean BBreakCorner)
        {
            IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.SetBreakCorners(BBreakCorner);
        }
        public static Int32 IGetExcludedFacesCount(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.IGetExcludedFacesCount();
        }
        public static Object IGetExcludedFaces(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.IGetExcludedFaces();
        }
        //public static void ISetExcludedFaces(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance, Int32 FaceCount, Object& FaceArray)
        //{
        //    return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.ISetExcludedFaces(FaceCount, FaceArray);
        //}
        public static Object FixedFace(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.FixedFace;
        }
        public static Boolean MergeFace(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.MergeFace;
        }
        public static Boolean CornerTreatment(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.CornerTreatment;
        }
        public static Int32 CornerTrimReliefType(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.CornerTrimReliefType;
        }
        public static Double CornerTrimReliefDistance(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.CornerTrimReliefDistance;
        }
        public static Int32 BreakCornerType(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.BreakCornerType;
        }
        public static Double BreakCornerRadius(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.BreakCornerRadius;
        }
        public static Double CornerTrimRatioToThickness(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.CornerTrimRatioToThickness;
        }
        public static Boolean UseRatioToThickness(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.UseRatioToThickness;
        }
        public static Boolean SimplifyBends(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.SimplifyBends;
        }
        public static Object ExcludedFaces(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.ExcludedFaces;
        }
        public static Object FixedFace2(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.FixedFace2;
        }
        public static Boolean ShowSlitInCornerRelief(IFlatPatternFeatureDataObject IFlatPatternFeatureDatainstance)
        {
            return IFlatPatternFeatureDatainstance.IFlatPatternFeatureDataInstance.ShowSlitInCornerRelief;
        }
    }
}