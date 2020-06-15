using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBoundaryBossFeatureDataObject
    {
        public IBoundaryBossFeatureData IBoundaryBossFeatureDataInstance { get; set; }
        public IBoundaryBossFeatureDataObject(IBoundaryBossFeatureData IBoundaryBossFeatureDatainstance)
        {
            IBoundaryBossFeatureDataInstance = IBoundaryBossFeatureDatainstance;
        }
    }
    public static class IBoundaryBossFeatureDataInterface
    {
        public static Boolean AccessSelections(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetCurvesCount(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.GetCurvesCount(Direction);
        }
        public static Boolean IsThinFeature(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.IsThinFeature();
        }
        public static Double GetDraftAngle(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.GetDraftAngle(Direction, GuideIndex);
        }
        public static void SetDraftAngle(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex, Double DraftAngle)
        {
            IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.SetDraftAngle(Direction, GuideIndex, DraftAngle);
        }
        public static Boolean GetDraftAngleReverseDirection(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.GetDraftAngleReverseDirection(Direction, GuideIndex);
        }
        public static void SetDraftAngleReverseDirection(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex, Boolean IsFlipped)
        {
            IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.SetDraftAngleReverseDirection(Direction, GuideIndex, IsFlipped);
        }
        public static Double GetTangentLength(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.GetTangentLength(Direction, GuideIndex);
        }
        public static void SetTangentLength(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex, Double Length)
        {
            IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.SetTangentLength(Direction, GuideIndex, Length);
        }
        public static Boolean GetTangentDirectionReversed(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.GetTangentDirectionReversed(Direction, GuideIndex);
        }
        public static void SetTangentDirectionReversed(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex, Boolean Flip)
        {
            IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.SetTangentDirectionReversed(Direction, GuideIndex, Flip);
        }
        public static Double GetTangentInfluence(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.GetTangentInfluence(Direction, GuideIndex);
        }
        public static Boolean GetTangentApplyToAll(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.GetTangentApplyToAll(Direction, GuideIndex);
        }
        public static void SetTangentApplyToAll(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex, Boolean Apply)
        {
            IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.SetTangentApplyToAll(Direction, GuideIndex, Apply);
        }
        public static Object GetDirectionVector(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.GetDirectionVector(Direction, GuideIndex);
        }
        public static void SetDirectionVector(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex, Object DirectionVector)
        {
            IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.SetDirectionVector(Direction, GuideIndex, DirectionVector);
        }
        public static Int32 GetGuideTangencyType(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.GetGuideTangencyType(Direction, GuideIndex);
        }
        public static void SetGuideTangencyType(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex, Int32 TangType)
        {
            IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.SetGuideTangencyType(Direction, GuideIndex, TangType);
        }
        public static Int32 GetAlignmentType(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.GetAlignmentType(Direction, GuideIndex);
        }
        public static void SetAlignmentType(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex, Int32 AlignmentType)
        {
            IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.SetAlignmentType(Direction, GuideIndex, AlignmentType);
        }
        public static void SetTangentInfluence(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, Int32 Direction, Int32 GuideIndex, Double Influence)
        {
            IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.SetTangentInfluence(Direction, GuideIndex, Influence);
        }
        public static Object D1Curves(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.D1Curves;
        }
        public static Int32 D1CurveInfluence(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.D1CurveInfluence;
        }
        public static Boolean TrimByD1(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.TrimByD1;
        }
        public static Object D2Curves(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.D2Curves;
        }
        public static Boolean MergeTangentFaces(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.MergeTangentFaces;
        }
        public static Boolean MergeResult(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.MergeResult;
        }
        public static Boolean FeatureScope(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.FeatureScope;
        }
        public static Boolean AutoSelect(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.AutoSelect;
        }
        public static Object FeatureScopeBodies(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.FeatureScopeBodies;
        }
        public static Int32 FeatureScopeBodiesCount(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.FeatureScopeBodiesCount;
        }
        public static Int32 ThinFeatureType(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.ThinFeatureType;
        }
        public static Double ThinFeatureThickness(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance, bool ThicknessDirection)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.ThinFeatureThickness[ThicknessDirection];
        }
        public static Int32 D2CurveInfluence(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.D2CurveInfluence;
        }
        public static Boolean ThinFeatureReversed(IBoundaryBossFeatureDataObject IBoundaryBossFeatureDatainstance)
        {
            return IBoundaryBossFeatureDatainstance.IBoundaryBossFeatureDataInstance.ThinFeatureReversed;
        }
    }
}