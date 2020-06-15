using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISurfExtrudeFeatureDataObject
    {
        public ISurfExtrudeFeatureData ISurfExtrudeFeatureDataInstance { get; set; }
        public ISurfExtrudeFeatureDataObject(ISurfExtrudeFeatureData ISurfExtrudeFeatureDatainstance)
        {
            ISurfExtrudeFeatureDataInstance = ISurfExtrudeFeatureDatainstance;
        }
    }
    public static class ISurfExtrudeFeatureDataInterface
    {
        public static Boolean AccessSelections(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance)
        {
            ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetEndCondition(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Forward)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.GetEndCondition(Forward);
        }
        public static void SetEndCondition(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Forward, Int32 EndCondition)
        {
            ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.SetEndCondition(Forward, EndCondition);
        }
        public static Double GetDepth(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Forward)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.GetDepth(Forward);
        }
        public static void SetDepth(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Forward, Double Depth)
        {
            ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.SetDepth(Forward, Depth);
        }
        public static Object GetFace(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Forward)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.GetFace(Forward);
        }
        public static void SetFace(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Forward, Object Face)
        {
            ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.SetFace(Forward, Face);
        }
        public static IFace2Object IGetFace(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Forward)
        {
            return new IFace2Object(ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.IGetFace(Forward));
        }
        public static void ISetFace(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Forward, IFace2Object Face)
        {
            ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.ISetFace(Forward, Face?.IFace2Instance.CastObj<Face2>());
        }
        public static Object GetVertex(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Forward)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.GetVertex(Forward);
        }
        public static void SetVertex(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Forward, Object Vtx)
        {
            ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.SetVertex(Forward, Vtx);
        }
        public static IVertexObject IGetVertex(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Forward)
        {
            return new IVertexObject(ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.IGetVertex(Forward));
        }
        public static void ISetVertex(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Forward, IVertexObject Vtx)
        {
            ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.ISetVertex(Forward, Vtx.IVertexInstance.CastObj<Vertex>());
        }
        public static Boolean GetReverseOffset(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Fwd)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.GetReverseOffset(Fwd);
        }
        public static void SetReverseOffset(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Fwd, Boolean RevOffset)
        {
            ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.SetReverseOffset(Fwd, RevOffset);
        }
        public static Boolean GetTranslateSurface(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Fwd)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.GetTranslateSurface(Fwd);
        }
        public static void SetTranslateSurface(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance, Boolean Fwd, Boolean Trans)
        {
            ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.SetTranslateSurface(Fwd, Trans);
        }
        public static Boolean ReverseDirection(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.ReverseDirection;
        }
        public static Boolean BothDirections(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.BothDirections;
        }
        public static Boolean D1DraftOn(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.D1DraftOn;
        }
        public static Boolean D2DraftOn(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.D2DraftOn;
        }
        public static Double D1DraftAngle(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.D1DraftAngle;
        }
        public static Double D2DraftAngle(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.D2DraftAngle;
        }
        public static Boolean D1DraftOutward(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.D1DraftOutward;
        }
        public static Boolean D2DraftOutward(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.D2DraftOutward;
        }
        public static Boolean D1CapEnd(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.D1CapEnd;
        }
        public static Boolean D2CapEnd(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.D2CapEnd;
        }
        public static Boolean DeleteOriginalFace(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.DeleteOriginalFace;
        }
        public static Boolean KnitResult(ISurfExtrudeFeatureDataObject ISurfExtrudeFeatureDatainstance)
        {
            return ISurfExtrudeFeatureDatainstance.ISurfExtrudeFeatureDataInstance.KnitResult;
        }
    }
}