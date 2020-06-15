using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IExtrudeFeatureDataObject
    {
        public IExtrudeFeatureData IExtrudeFeatureDataInstance { get; set; }
        public IExtrudeFeatureDataObject(IExtrudeFeatureData IExtrudeFeatureDatainstance)
        {
            IExtrudeFeatureDataInstance = IExtrudeFeatureDatainstance;
        }
    }
    public static class IExtrudeFeatureDataInterface
    {
        public static Int32 GetEndCondition(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.GetEndCondition(Forward);
        }
        public static void SetEndCondition(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward, Int32 EndCondition)
        {
            IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.SetEndCondition(Forward, EndCondition);
        }
        public static Double GetDepth(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.GetDepth(Forward);
        }
        public static void SetDepth(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward, Double Depth)
        {
            IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.SetDepth(Forward, Depth);
        }
        public static Double GetWallThickness(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.GetWallThickness(Forward);
        }
        public static void SetWallThickness(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward, Double WallThickness)
        {
            IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.SetWallThickness(Forward, WallThickness);
        }
        public static Boolean GetDraftWhileExtruding(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.GetDraftWhileExtruding(Forward);
        }
        public static void SetDraftWhileExtruding(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward, Boolean DraftWhileExtrude)
        {
            IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.SetDraftWhileExtruding(Forward, DraftWhileExtrude);
        }
        public static Boolean GetDraftOutward(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.GetDraftOutward(Forward);
        }
        public static void SetDraftOutward(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward, Boolean DraftOutward)
        {
            IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.SetDraftOutward(Forward, DraftOutward);
        }
        public static Double GetDraftAngle(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.GetDraftAngle(Forward);
        }
        public static void SetDraftAngle(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward, Double DraftAngle)
        {
            IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.SetDraftAngle(Forward, DraftAngle);
        }
        public static Boolean AccessSelections(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static void ReleaseSelectionAccess(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance)
        {
            IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Object GetFace(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.GetFace(Forward);
        }
        public static void SetFace(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward, Object Face)
        {
            IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.SetFace(Forward, Face);
        }
        public static IFaceObject IGetFace(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward)
        {
            return new IFaceObject(IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.IGetFace(Forward));
        }
        public static void ISetFace(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward, IFaceObject Face)
        {
            IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.ISetFace(Forward, Face.IFaceInstance as Face);
        }
        public static Object GetVertex(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.GetVertex(Forward);
        }
        public static void SetVertex(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward, Object Face)
        {
            IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.SetVertex(Forward, Face);
        }
        public static IVertexObject IGetVertex(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward)
        {
            return new IVertexObject(IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.IGetVertex(Forward));
        }
        public static void ISetVertex(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance, Boolean Forward, IVertexObject Face)
        {
            IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.ISetVertex(Forward, Face.IVertexInstance as Vertex);
        }
        public static Boolean IsBossFeature(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.IsBossFeature();
        }
        public static Boolean IsThinFeature(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.IsThinFeature();
        }
        public static Boolean IsBaseExtrude(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.IsBaseExtrude();
        }
        public static Boolean ReverseDirection(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.ReverseDirection;
        }
        public static Boolean BothDirections(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.BothDirections;
        }
        public static Boolean FlipSideToCut(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.FlipSideToCut;
        }
        public static Int32 ThinWallType(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.ThinWallType;
        }
        public static Boolean CapEnds(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.CapEnds;
        }
        public static Double CapThickness(IExtrudeFeatureDataObject IExtrudeFeatureDatainstance)
        {
            return IExtrudeFeatureDatainstance.IExtrudeFeatureDataInstance.CapThickness;
        }
    }
}