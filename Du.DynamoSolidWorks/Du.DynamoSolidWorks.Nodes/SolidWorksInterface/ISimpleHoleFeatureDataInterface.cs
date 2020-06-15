using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISimpleHoleFeatureDataObject
    {
        public ISimpleHoleFeatureData ISimpleHoleFeatureDataInstance { get; set; }
        public ISimpleHoleFeatureDataObject(ISimpleHoleFeatureData ISimpleHoleFeatureDatainstance)
        {
            ISimpleHoleFeatureDataInstance = ISimpleHoleFeatureDatainstance;
        }
    }
    public static class ISimpleHoleFeatureDataInterface
    {
        public static Boolean AccessSelections(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance?.CastObj<ModelDoc>(), Component?.IComponentInstance?.CastObj<Component>());
        }
        public static void ReleaseSelectionAccess(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance)
        {
            ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Boolean ReverseDirection(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance)
        {
            return ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.ReverseDirection;
        }
        public static Boolean DraftWhileExtruding(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance)
        {
            return ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.DraftWhileExtruding;
        }
        public static Boolean DraftOutward(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance)
        {
            return ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.DraftOutward;
        }
        public static Boolean ReverseOffset(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance)
        {
            return ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.ReverseOffset;
        }
        public static Int32 Type(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance)
        {
            return ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.Type;
        }
        public static Double Diameter(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance)
        {
            return ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.Diameter;
        }
        public static Double Depth(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance)
        {
            return ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.Depth;
        }
        public static Double DraftAngle(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance)
        {
            return ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.DraftAngle;
        }
        public static Double SurfaceOffset(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance)
        {
            return ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.SurfaceOffset;
        }
        public static Object Face(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance)
        {
            return ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.Face;
        }
        public static IFaceObject IFace(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance)
        {
            return new IFaceObject(ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.IFace);
        }
        public static Object Vertex(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance)
        {
            return ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.Vertex;
        }
        public static IVertexObject IVertex(ISimpleHoleFeatureDataObject ISimpleHoleFeatureDatainstance)
        {
            return new IVertexObject(ISimpleHoleFeatureDatainstance.ISimpleHoleFeatureDataInstance.IVertex);
        }
    }
}