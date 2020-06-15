using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IChamferFeatureData2Object
    {
        public IChamferFeatureData2 IChamferFeatureData2Instance { get; set; }
        public IChamferFeatureData2Object(IChamferFeatureData2 IChamferFeatureData2instance)
        {
            IChamferFeatureData2Instance = IChamferFeatureData2instance;
        }
    }
    public static class IChamferFeatureData2Interface
    {
        public static Double GetEdgeChamferDistance(IChamferFeatureData2Object IChamferFeatureData2instance, Int32 Side)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.GetEdgeChamferDistance(Side);
        }
        public static void SetEdgeChamferDistance(IChamferFeatureData2Object IChamferFeatureData2instance, Int32 Side, Double Distance)
        {
            IChamferFeatureData2instance.IChamferFeatureData2Instance.SetEdgeChamferDistance(Side, Distance);
        }
        public static Double GetVertexChamferDistance(IChamferFeatureData2Object IChamferFeatureData2instance, Int32 Side)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.GetVertexChamferDistance(Side);
        }
        public static void SetVertexChamferDistance(IChamferFeatureData2Object IChamferFeatureData2instance, Int32 Side, Double Distance)
        {
            IChamferFeatureData2instance.IChamferFeatureData2Instance.SetVertexChamferDistance(Side, Distance);
        }
        public static Boolean AccessSelections(IChamferFeatureData2Object IChamferFeatureData2instance, Object TopDoc, Object Component)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IChamferFeatureData2Object IChamferFeatureData2instance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            IChamferFeatureData2instance.IChamferFeatureData2Instance.ReleaseSelectionAccess();
        }
        public static Int32 GetFaceCount(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.GetFaceCount();
        }
        public static IFace2Object IGetFaces(IChamferFeatureData2Object IChamferFeatureData2instance, Int32 FaceCount)
        {
            return new IFace2Object(IChamferFeatureData2instance.IChamferFeatureData2Instance.IGetFaces(FaceCount));
        }
        //ref not solve
        public static void ISetFaces(IChamferFeatureData2Object IChamferFeatureData2instance, Int32 Count, IFace2Object FaceList)
        {
            IChamferFeatureData2instance.IChamferFeatureData2Instance.ISetFaces(Count, FaceList.IFace2Instance as Face2);
        }
        public static Int32 GetEdgeCount(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.GetEdgeCount();
        }
        public static IEdgeObject IGetEdges(IChamferFeatureData2Object IChamferFeatureData2instance, Int32 Count)
        {
            return new IEdgeObject(IChamferFeatureData2instance.IChamferFeatureData2Instance.IGetEdges(Count));
        }
        //ref not solve
        public static void ISetEdges(IChamferFeatureData2Object IChamferFeatureData2instance, Int32 Count, IEdgeObject EdgeList)
        {
            IChamferFeatureData2instance.IChamferFeatureData2Instance.ISetEdges(Count, EdgeList.IEdgeInstance as Edge);
        }
        public static ILoopObject IGetLoops(IChamferFeatureData2Object IChamferFeatureData2instance, Int32 Count)
        {
            return new ILoopObject(IChamferFeatureData2instance.IChamferFeatureData2Instance.IGetLoops(Count));
        }
        //ref not solve
        public static void ISetLoops(IChamferFeatureData2Object IChamferFeatureData2instance, Int32 Count, ILoopObject LoopList)
        {
            IChamferFeatureData2instance.IChamferFeatureData2Instance.ISetLoops(Count, LoopList.ILoopInstance as Loop);
        }
        public static Boolean GetIsFlipped(IChamferFeatureData2Object IChamferFeatureData2instance, Object Entity)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.GetIsFlipped(Entity);
        }
        public static void SetIsFlipped(IChamferFeatureData2Object IChamferFeatureData2instance, Object Entity, Boolean Flip)
        {
            IChamferFeatureData2instance.IChamferFeatureData2Instance.SetIsFlipped(Entity, Flip);
        }
        public static Int32 Type(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.Type;
        }
        public static Double EdgeChamferAngle(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.EdgeChamferAngle;
        }
        public static Object Faces(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.Faces;
        }
        public static Object Edges(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.Edges;
        }
        public static Object Vertex(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.Vertex;
        }
        public static Int32 LoopCount(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.LoopCount;
        }
        public static Object Loops(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.Loops;
        }
        public static Boolean EqualDistance(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.EqualDistance;
        }
        public static IVertexObject IVertex(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            return new IVertexObject(IChamferFeatureData2instance.IChamferFeatureData2Instance.IVertex);
        }
        public static Boolean KeepFeatures(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.KeepFeatures;
        }
        public static Boolean TangentPropagation(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.TangentPropagation;
        }
        public static Boolean PropagateFeatureToParts(IChamferFeatureData2Object IChamferFeatureData2instance)
        {
            return IChamferFeatureData2instance.IChamferFeatureData2Instance.PropagateFeatureToParts;
        }
    }
}