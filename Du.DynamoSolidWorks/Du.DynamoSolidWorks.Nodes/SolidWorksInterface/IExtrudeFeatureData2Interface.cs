using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IExtrudeFeatureData2Object
    {
        public IExtrudeFeatureData2 IExtrudeFeatureData2Instance { get; set; }
        public IExtrudeFeatureData2Object(IExtrudeFeatureData2 IExtrudeFeatureData2instance)
        {
            IExtrudeFeatureData2Instance = IExtrudeFeatureData2instance;
        }
    }
    public static class IExtrudeFeatureData2Interface
    {
        public static Int32 GetEndCondition(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetEndCondition(Forward);
        }
        public static void SetEndCondition(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward, Int32 EndCondition)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetEndCondition(Forward, EndCondition);
        }
        public static Double GetDepth(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetDepth(Forward);
        }
        public static void SetDepth(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward, Double Depth)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetDepth(Forward, Depth);
        }
        public static Double GetWallThickness(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetWallThickness(Forward);
        }
        public static void SetWallThickness(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward, Double WallThickness)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetWallThickness(Forward, WallThickness);
        }
        public static Boolean GetDraftWhileExtruding(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetDraftWhileExtruding(Forward);
        }
        public static void SetDraftWhileExtruding(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward, Boolean DraftWhileExtrude)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetDraftWhileExtruding(Forward, DraftWhileExtrude);
        }
        public static Boolean GetDraftOutward(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetDraftOutward(Forward);
        }
        public static void SetDraftOutward(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward, Boolean DraftOutward)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetDraftOutward(Forward, DraftOutward);
        }
        public static Double GetDraftAngle(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetDraftAngle(Forward);
        }
        public static void SetDraftAngle(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward, Double DraftAngle)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetDraftAngle(Forward, DraftAngle);
        }
        public static Boolean AccessSelections(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Object TopDoc, Object Component)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.ReleaseSelectionAccess();
        }
        public static Object GetFace(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetFace(Forward);
        }
        public static void SetFace(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward, Object Face)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetFace(Forward, Face);
        }
        public static IFace2Object IGetFace(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward)
        {
            return new IFace2Object(IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.IGetFace(Forward));
        }
        public static void ISetFace(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward, IFace2Object Face)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.ISetFace(Forward, Face.IFace2Instance as Face2);
        }
        public static Object GetVertex(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetVertex(Forward);
        }
        public static void SetVertex(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward, Object Face)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetVertex(Forward, Face);
        }
        public static IVertexObject IGetVertex(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward)
        {
            return new IVertexObject(IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.IGetVertex(Forward));
        }
        public static void ISetVertex(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward, IVertexObject Face)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.ISetVertex(Forward, Face.IVertexInstance as Vertex);
        }
        public static Boolean IsBossFeature(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.IsBossFeature();
        }
        public static Boolean IsThinFeature(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.IsThinFeature();
        }
        public static Boolean IsBaseExtrude(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.IsBaseExtrude();
        }
        public static Int32 GetFeatureScopeBodiesCount(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetFeatureScopeBodiesCount();
        }
        public static IBody2Object IGetFeatureScopeBodies(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Int32 Count)
        {
            return new IBody2Object(IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.IGetFeatureScopeBodies(Count));
        }
        //public static void ISetFeatureScopeBodies(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Int32 Count, Body2&Object BodyArr)
        //{
        //    return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.ISetFeatureScopeBodies(Count, BodyArr);
        //}
        public static Boolean GetReverseOffset(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Fwd)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetReverseOffset(Fwd);
        }
        public static void SetReverseOffset(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Fwd, Boolean ValIn)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetReverseOffset(Fwd, ValIn);
        }
        public static Boolean GetTranslateSurface(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Fwd)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetTranslateSurface(Fwd);
        }
        public static void SetTranslateSurface(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Fwd, Boolean ValIn)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetTranslateSurface(Fwd, ValIn);
        }
        //public static Object GetEndConditionReference(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward, Int32& ReferenceType)
        //{
        //    return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetEndConditionReference(Forward, ReferenceType);
        //}
        public static void SetEndConditionReference(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean Forward, Object PDisp)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetEndConditionReference(Forward, PDisp);
        }
        public static Int32 GetContoursCount(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetContoursCount();
        }
        public static Object IGetContours(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Int32 Count)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.IGetContours(Count);
        }
        //public static void ISetContours(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Int32 Count, Object& Contours)
        //{
        //    return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.ISetContours(Count, Contours);
        //}
        //public static Int32 GetDirectionReference(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Object& Ref1, Int32& Type1, Object& Ref2, Int32& Type2)
        //{
        //    return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetDirectionReference(Ref1, Type1, Ref2, Type2);
        //}
        public static void SetDirectionReference(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Object Ref1, Object Ref2)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetDirectionReference(Ref1, Ref2);
        }
        public static Boolean GetAutoFilletCorners(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetAutoFilletCorners();
        }
        public static Double GetAutoFilletRadius(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetAutoFilletRadius();
        }
        public static Boolean SetAutoFillet(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Boolean AutoFillet, Double Radius)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetAutoFillet(AutoFillet, Radius);
        }
        //public static void GetFromEntity(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Object& FromEntity, Int32& Type)
        //{
        //    return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.GetFromEntity(FromEntity, Type);
        //}
        public static void SetFromEntity(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Object FromEntity)
        {
            IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetFromEntity(FromEntity);
        }
        public static Boolean SetChangeToConfigurations(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Int32 Config_opt, Object Config_names)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.SetChangeToConfigurations(Config_opt, Config_names);
        }
        //public static Boolean ISetChangeToConfigurations(IExtrudeFeatureData2Object IExtrudeFeatureData2instance, Int32 Config_opt, Int32 Config_count, String& Config_names)
        //{
        //    return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.ISetChangeToConfigurations(Config_opt, Config_count, Config_names);
        //}
        public static Boolean ReverseDirection(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.ReverseDirection;
        }
        public static Boolean BothDirections(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.BothDirections;
        }
        public static Boolean FlipSideToCut(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.FlipSideToCut;
        }
        public static Int32 ThinWallType(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.ThinWallType;
        }
        public static Boolean CapEnds(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.CapEnds;
        }
        public static Double CapThickness(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.CapThickness;
        }
        public static Boolean Merge(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.Merge;
        }
        public static Boolean FeatureScope(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.FeatureScope;
        }
        public static Boolean AutoSelect(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.AutoSelect;
        }
        public static Object FeatureScopeBodies(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.FeatureScopeBodies;
        }
        public static Object Contours(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.Contours;
        }
        public static Int32 FromType(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.FromType;
        }
        public static Double FromOffsetDistance(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.FromOffsetDistance;
        }
        public static Boolean FromOffsetReverse(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.FromOffsetReverse;
        }
        public static Boolean LinkToThickness(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.LinkToThickness;
        }
        public static Boolean AssemblyFeatureScope(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.AssemblyFeatureScope;
        }
        public static Boolean AutoSelectComponents(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.AutoSelectComponents;
        }
        public static Boolean PropagateFeatureToParts(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.PropagateFeatureToParts;
        }
        public static Boolean NormalCut(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.NormalCut;
        }
        public static Boolean OptimizeGeometry(IExtrudeFeatureData2Object IExtrudeFeatureData2instance)
        {
            return IExtrudeFeatureData2instance.IExtrudeFeatureData2Instance.OptimizeGeometry;
        }
    }
}