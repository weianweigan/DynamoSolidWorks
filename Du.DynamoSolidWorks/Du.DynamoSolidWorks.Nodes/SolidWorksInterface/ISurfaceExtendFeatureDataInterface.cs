using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISurfaceExtendFeatureDataObject
    {
        public ISurfaceExtendFeatureData ISurfaceExtendFeatureDataInstance { get; set; }
        public ISurfaceExtendFeatureDataObject(ISurfaceExtendFeatureData ISurfaceExtendFeatureDatainstance)
        {
            ISurfaceExtendFeatureDataInstance = ISurfaceExtendFeatureDatainstance;
        }
    }
    public static class ISurfaceExtendFeatureDataInterface
    {
        public static Int32 GetItemsCount(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance)
        {
            return ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.GetItemsCount();
        }
        public static Object IGetItems(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance, Int32 Count)
        {
            return ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.IGetItems(Count);
        }
        //public static void ISetItems(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance, Int32 Count, Object& ItemArr)
        //{
        //    return ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.ISetItems(Count, ItemArr);
        //}
        public static Boolean AccessSelections(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance)
        {
            ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetPropagatingEdgesCount(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance)
        {
            return ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.GetPropagatingEdgesCount();
        }
        public static IEdgeObject IGetPropagatingEdges(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance, Int32 Count)
        {
            return new IEdgeObject(ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.IGetPropagatingEdges(Count));
        }
        //public static void ISetPropagatingEdges(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance, Int32 Count, Edge&Object EdgeArr)
        //{
        //    return ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.ISetPropagatingEdges(Count, EdgeArr);
        //}
        public static Object Items(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance)
        {
            return ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.Items;
        }
        public static Int32 EndCondition(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance)
        {
            return ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.EndCondition;
        }
        public static Object Face(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance)
        {
            return ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.Face;
        }
        public static IFace2Object IFace(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance)
        {
            return new IFace2Object(ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.IFace);
        }
        public static Object Vertex(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance)
        {
            return ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.Vertex;
        }
        public static IVertexObject IVertex(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance)
        {
            return new IVertexObject(ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.IVertex);
        }
        public static Double Distance(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance)
        {
            return ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.Distance;
        }
        public static Int32 Type(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance)
        {
            return ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.Type;
        }
        public static Object PropagatingEdges(ISurfaceExtendFeatureDataObject ISurfaceExtendFeatureDatainstance)
        {
            return ISurfaceExtendFeatureDatainstance.ISurfaceExtendFeatureDataInstance.PropagatingEdges;
        }
    }
}