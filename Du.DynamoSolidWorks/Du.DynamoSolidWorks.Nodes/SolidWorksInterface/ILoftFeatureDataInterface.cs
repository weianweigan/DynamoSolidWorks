using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILoftFeatureDataObject
    {
        public ILoftFeatureData ILoftFeatureDataInstance { get; set; }
        public ILoftFeatureDataObject(ILoftFeatureData ILoftFeatureDatainstance)
        {
            ILoftFeatureDataInstance = ILoftFeatureDatainstance;
        }
    }
    public static class ILoftFeatureDataInterface
    {
        public static Boolean IAccessSelections(ILoftFeatureDataObject ILoftFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static Boolean AccessSelections(ILoftFeatureDataObject ILoftFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            ILoftFeatureDatainstance.ILoftFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int16 GetProfileCount(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.GetProfileCount();
        }
        public static Object IGetProfiles(ILoftFeatureDataObject ILoftFeatureDatainstance, Int16 Count)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.IGetProfiles(Count);
        }
        //public static void ISetProfiles(ILoftFeatureDataObject ILoftFeatureDatainstance, Int16 Count, Object& PDisp)
        //{
        //    return ILoftFeatureDatainstance.ILoftFeatureDataInstance.ISetProfiles(Count, PDisp);
        //}
        public static Int16 GetGuideTangencyType(ILoftFeatureDataObject ILoftFeatureDatainstance, Int16 GuideIndex)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.GetGuideTangencyType(GuideIndex);
        }
        public static void SetGuideTangencyType(ILoftFeatureDataObject ILoftFeatureDatainstance, Int16 GuideIndex, Int16 TangType)
        {
            ILoftFeatureDatainstance.ILoftFeatureDataInstance.SetGuideTangencyType(GuideIndex, TangType);
        }
        public static Int16 GetGuideCurvesCount(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.GetGuideCurvesCount();
        }
        public static Object IGetGuideCurves(ILoftFeatureDataObject ILoftFeatureDatainstance, Int16 Count)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.IGetGuideCurves(Count);
        }
        //public static void ISetGuideCurves(ILoftFeatureDataObject ILoftFeatureDatainstance, Int16 Count, Object& PDisp)
        //{
        //    return ILoftFeatureDatainstance.ILoftFeatureDataInstance.ISetGuideCurves(Count, PDisp);
        //}
        public static Boolean IsThinFeature(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.IsThinFeature();
        }
        public static Double GetWallThickness(ILoftFeatureDataObject ILoftFeatureDatainstance, Boolean Forward)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.GetWallThickness(Forward);
        }
        public static void SetWallThickness(ILoftFeatureDataObject ILoftFeatureDatainstance, Boolean Forward, Double WallThickness)
        {
            ILoftFeatureDatainstance.ILoftFeatureDataInstance.SetWallThickness(Forward, WallThickness);
        }
        public static Boolean IsBossFeature(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.IsBossFeature();
        }
        public static Object GetGuideCurvesType(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.GetGuideCurvesType();
        }
        public static Int32 IGetGuideCurvesType(ILoftFeatureDataObject ILoftFeatureDatainstance, Int32 Count)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.IGetGuideCurvesType(Count);
        }
        public static Int32 GetFeatureScopeBodiesCount(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.GetFeatureScopeBodiesCount();
        }
        public static IBody2Object IGetFeatureScopeBodies(ILoftFeatureDataObject ILoftFeatureDatainstance, Int32 Count)
        {
            return new IBody2Object(ILoftFeatureDatainstance.ILoftFeatureDataInstance.IGetFeatureScopeBodies(Count));
        }
        //public static void ISetFeatureScopeBodies(ILoftFeatureDataObject ILoftFeatureDatainstance, Int32 Count, Body2&Object BodyArr)
        //{
        //    return ILoftFeatureDatainstance.ILoftFeatureDataInstance.ISetFeatureScopeBodies(Count, BodyArr);
        //}
        public static Object Profiles(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.Profiles;
        }
        public static Boolean MaintainTangency(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.MaintainTangency;
        }
        public static Boolean AdvancedSmoothing(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.AdvancedSmoothing;
        }
        public static Boolean Close(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.Close;
        }
        public static Object GuideCurves(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.GuideCurves;
        }
        public static Int16 StartTangencyType(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.StartTangencyType;
        }
        public static Int16 EndTangencyType(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.EndTangencyType;
        }
        public static Int16 ThinWallType(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.ThinWallType;
        }
        public static Object StartDirectionVector(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.StartDirectionVector;
        }
        public static Double StartTangentLength(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.StartTangentLength;
        }
        public static Boolean ReverseStartTangentDirection(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.ReverseStartTangentDirection;
        }
        public static Object EndDirectionVector(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.EndDirectionVector;
        }
        public static Double EndTangentLength(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.EndTangentLength;
        }
        public static Boolean ReverseEndTangentDirection(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.ReverseEndTangentDirection;
        }
        public static Object Centerline(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.Centerline;
        }
        public static Boolean Merge(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.Merge;
        }
        public static Boolean FeatureScope(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.FeatureScope;
        }
        public static Boolean AutoSelect(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.AutoSelect;
        }
        public static Object FeatureScopeBodies(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.FeatureScopeBodies;
        }
        public static Double NumberOfSections(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.NumberOfSections;
        }
        public static Boolean StartConstraintApplyToAll(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.StartConstraintApplyToAll;
        }
        public static Boolean EndConstraintApplyToAll(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.EndConstraintApplyToAll;
        }
        public static Int32 GuideCurveInfluence(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.GuideCurveInfluence;
        }
        public static Double StartConstraintDraftAngle(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.StartConstraintDraftAngle;
        }
        public static Boolean StartConstraintDraftAngleDirection(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.StartConstraintDraftAngleDirection;
        }
        public static Double EndConstraintDraftAngle(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.EndConstraintDraftAngle;
        }
        public static Boolean EndConstraintDraftAngleDirection(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.EndConstraintDraftAngleDirection;
        }
        public static Object PickPoints(ILoftFeatureDataObject ILoftFeatureDatainstance)
        {
            return ILoftFeatureDatainstance.ILoftFeatureDataInstance.PickPoints;
        }
    }
}