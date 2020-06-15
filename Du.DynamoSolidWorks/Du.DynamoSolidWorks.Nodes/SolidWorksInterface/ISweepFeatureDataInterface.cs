using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISweepFeatureDataObject
    {
        public ISweepFeatureData ISweepFeatureDataInstance { get; set; }
        public ISweepFeatureDataObject(ISweepFeatureData ISweepFeatureDatainstance)
        {
            ISweepFeatureDataInstance = ISweepFeatureDatainstance;
        }
    }
    public static class ISweepFeatureDataInterface
    {
        public static Boolean IAccessSelections(ISweepFeatureDataObject ISweepFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static Boolean AccessSelections(ISweepFeatureDataObject ISweepFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            ISweepFeatureDatainstance.ISweepFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Object IGetGuideCurves(ISweepFeatureDataObject ISweepFeatureDatainstance, Int16 Count)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.IGetGuideCurves(Count);
        }
        //public static void ISetGuideCurves(ISweepFeatureDataObject ISweepFeatureDatainstance, Int16 Count, Object& PDisp)
        //{
        //    return ISweepFeatureDatainstance.ISweepFeatureDataInstance.ISetGuideCurves(Count, PDisp);
        //}
        public static Boolean IsThinFeature(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.IsThinFeature();
        }
        public static Double GetWallThickness(ISweepFeatureDataObject ISweepFeatureDatainstance, Boolean Forward)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.GetWallThickness(Forward);
        }
        public static void SetWallThickness(ISweepFeatureDataObject ISweepFeatureDatainstance, Boolean Forward, Double WallThickness)
        {
            ISweepFeatureDatainstance.ISweepFeatureDataInstance.SetWallThickness(Forward, WallThickness);
        }
        public static Int16 GetGuideCurvesCount(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.GetGuideCurvesCount();
        }
        public static Boolean IsBossFeature(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.IsBossFeature();
        }
        public static Int32 GetPathType(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.GetPathType();
        }
        public static Object GetGuideCurvesType(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.GetGuideCurvesType();
        }
        public static Int32 IGetGuideCurvesType(ISweepFeatureDataObject ISweepFeatureDatainstance, Int32 Count)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.IGetGuideCurvesType(Count);
        }
        public static Int32 GetFeatureScopeBodiesCount(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.GetFeatureScopeBodiesCount();
        }
        public static IBody2Object IGetFeatureScopeBodies(ISweepFeatureDataObject ISweepFeatureDatainstance, Int32 Count)
        {
            return new IBody2Object(ISweepFeatureDatainstance.ISweepFeatureDataInstance.IGetFeatureScopeBodies(Count));
        }
        //public static void ISetFeatureScopeBodies(ISweepFeatureDataObject ISweepFeatureDatainstance, Int32 Count, Body2&Object BodyArr)
        //{
        //    return ISweepFeatureDatainstance.ISweepFeatureDataInstance.ISetFeatureScopeBodies(Count, BodyArr);
        //}
        public static Double GetTwistAngle(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.GetTwistAngle();
        }
        public static void SetTwistAngle(ISweepFeatureDataObject ISweepFeatureDatainstance, Double Angle)
        {
            ISweepFeatureDatainstance.ISweepFeatureDataInstance.SetTwistAngle(Angle);
        }
        //public static Object GetPathAlignmentDirectionVector(ISweepFeatureDataObject ISweepFeatureDatainstance, Int32& Type)
        //{
        //    return ISweepFeatureDatainstance.ISweepFeatureDataInstance.GetPathAlignmentDirectionVector(Type);
        //}
        public static void SetPathAlignmentDirectionVector(ISweepFeatureDataObject ISweepFeatureDatainstance, Object Dir)
        {
            ISweepFeatureDatainstance.ISweepFeatureDataInstance.SetPathAlignmentDirectionVector(Dir);
        }
        public static Int32 GetCutSweepOption(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.GetCutSweepOption();
        }
        public static Int32 GetProfileType(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.GetProfileType();
        }
        public static Double GetD2TwistAngle(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.GetD2TwistAngle();
        }
        public static void SetD2TwistAngle(ISweepFeatureDataObject ISweepFeatureDatainstance, Double Angle)
        {
            ISweepFeatureDatainstance.ISweepFeatureDataInstance.SetD2TwistAngle(Angle);
        }
        public static Object Profile(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.Profile;
        }
        public static Object Path(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.Path;
        }
        public static Int16 TwistControlType(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.TwistControlType;
        }
        public static Boolean MaintainTangency(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.MaintainTangency;
        }
        public static Boolean AdvancedSmoothing(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.AdvancedSmoothing;
        }
        public static Boolean AlignWithEndFaces(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.AlignWithEndFaces;
        }
        public static Object GuideCurves(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.GuideCurves;
        }
        public static Int16 StartTangencyType(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.StartTangencyType;
        }
        public static Int16 EndTangencyType(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.EndTangencyType;
        }
        public static Int16 ThinWallType(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.ThinWallType;
        }
        public static Object StartDirectionVector(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.StartDirectionVector;
        }
        public static Object EndDirectionVector(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.EndDirectionVector;
        }
        public static Boolean TangentPropagation(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.TangentPropagation;
        }
        public static Boolean Merge(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.Merge;
        }
        public static Boolean FeatureScope(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.FeatureScope;
        }
        public static Boolean AutoSelect(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.AutoSelect;
        }
        public static Object FeatureScopeBodies(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.FeatureScopeBodies;
        }
        public static Boolean MergeSmoothFaces(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.MergeSmoothFaces;
        }
        public static Int32 PathAlignmentType(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.PathAlignmentType;
        }
        public static Boolean AssemblyFeatureScope(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.AssemblyFeatureScope;
        }
        public static Boolean AutoSelectComponents(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.AutoSelectComponents;
        }
        public static Boolean PropagateFeatureToParts(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.PropagateFeatureToParts;
        }
        public static Boolean CircularProfile(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.CircularProfile;
        }
        public static Double CircularProfileDiameter(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.CircularProfileDiameter;
        }
        public static Int32 Direction(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.Direction;
        }
        public static Int32 SweepType(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.SweepType;
        }
        public static Boolean D1ReverseTwistDir(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.D1ReverseTwistDir;
        }
        public static Boolean D2ReverseTwistDir(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.D2ReverseTwistDir;
        }
        public static Boolean ThinFeature(ISweepFeatureDataObject ISweepFeatureDatainstance)
        {
            return ISweepFeatureDatainstance.ISweepFeatureDataInstance.ThinFeature;
        }
    }
}