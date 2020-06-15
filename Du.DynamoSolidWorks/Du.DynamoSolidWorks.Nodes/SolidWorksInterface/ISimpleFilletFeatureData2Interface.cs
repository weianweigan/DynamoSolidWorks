using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISimpleFilletFeatureData2Object
    {
        public ISimpleFilletFeatureData2 ISimpleFilletFeatureData2Instance { get; set; }
        public ISimpleFilletFeatureData2Object(ISimpleFilletFeatureData2 ISimpleFilletFeatureData2instance)
        {
            ISimpleFilletFeatureData2Instance = ISimpleFilletFeatureData2instance;
        }
    }
    public static class ISimpleFilletFeatureData2Interface
    {
        public static Object GetFilletItemAtIndex(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 Index)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.GetFilletItemAtIndex(Index);
        }
        public static Object IGetFilletItemAtIndex(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 Index)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.IGetFilletItemAtIndex(Index);
        }
        public static Double GetRadius(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Object PFilletItem)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.GetRadius(PFilletItem);
        }
        public static Double IGetRadius(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Object PFilletItem)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.IGetRadius(PFilletItem);
        }
        public static void SetRadius(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Object PFilletItem, Double Radius)
        {
            ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.SetRadius(PFilletItem, Radius);
        }
        public static void ISetRadius(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Object PFilletItem, Double Radius)
        {
            ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.ISetRadius(PFilletItem, Radius);
        }
        public static Boolean AccessSelections(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Object TopDoc, Object Component)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.ReleaseSelectionAccess();
        }
        public static Int32 GetEdgeCount(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.GetEdgeCount();
        }
        public static IEdgeObject IGetEdges(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 Count)
        {
            return new IEdgeObject(ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.IGetEdges(Count));
        }
        //public static void ISetEdges(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 Count, Edge&Object EdgeList)
        //{
        //    return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.ISetEdges(Count, EdgeList);
        //}
        public static Int32 GetFaceCount(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 WhichFaceList)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.GetFaceCount(WhichFaceList);
        }
        public static IFace2Object IGetFaces(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 WhichFaceList, Int32 Count)
        {
            return new IFace2Object(ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.IGetFaces(WhichFaceList, Count));
        }
        //public static void ISetFaces(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 WhichFaceList, Int32 Count, Face2&Object FaceList)
        //{
        //    return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.ISetFaces(WhichFaceList, Count, FaceList);
        //}
        public static Object GetFaces(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 WhichFaceList)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.GetFaces(WhichFaceList);
        }
        public static void SetFaces(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 WhichFaceList, Object FaceList)
        {
            ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.SetFaces(WhichFaceList, FaceList);
        }
        public static Int32 GetLoopCount(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.GetLoopCount();
        }
        public static ILoop2Object IGetLoops(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 Count)
        {
            return new ILoop2Object(ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.IGetLoops(Count));
        }
        //public static void ISetLoops(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 Count, Loop2&Object LoopList)
        //{
        //    return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.ISetLoops(Count, LoopList);
        //}
        public static Int32 GetFeatureCount(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.GetFeatureCount();
        }
        public static IFeatureObject IGetFeatures(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 Count)
        {
            return new IFeatureObject(ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.IGetFeatures(Count));
        }
        //public static void ISetFeatures(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 Count, Feature&Object FeatList)
        //{
        //    return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.ISetFeatures(Count, FeatList);
        //}
        public static Int32 GetHoldLineCount(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.GetHoldLineCount();
        }
        public static Object IGetHoldLines(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 Count)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.IGetHoldLines(Count);
        }
        //public static void ISetHoldLines(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 Count, Object& PList)
        //{
        //    return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.ISetHoldLines(Count, PList);
        //}
        public static Object GetSetbackVertices(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.GetSetbackVertices();
        }
        //public static Object GetSetbackVertexDistance(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Object Vtx, Object& EdgeVar)
        //{
        //    return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.GetSetbackVertexDistance(Vtx, EdgeVar);
        //}
        public static Boolean SetSetbackVertices(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Object VertVar)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.SetSetbackVertices(VertVar);
        }
        public static Boolean SetSetbackVertexDistance(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Object Vtx, Object EdgeVar, Object DistVar)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.SetSetbackVertexDistance(Vtx, EdgeVar, DistVar);
        }
        public static Int32 GetSetbackVerticesCount(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.GetSetbackVerticesCount();
        }
        public static IVertexObject IGetSetbackVertices(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 Count)
        {
            return new IVertexObject(ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.IGetSetbackVertices(Count));
        }
        //public static Int32 GetSetbackDistanceCount(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, VertexObject Vtx)
        //{
        //    return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.GetSetbackDistanceCount(Vtx);
        //}
        //public static Double IGetSetbackVertexDistance(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 Count, VertexObject Vtx, Edge&Object EdgeArr)
        //{
        //    return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.IGetSetbackVertexDistance(Count, Vtx, EdgeArr);
        //}
        //public static Boolean ISetSetbackVertices(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 Count, Vertex&Object VertArr)
        //{
        //    return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.ISetSetbackVertices(Count, VertArr);
        //}
        //public static Boolean ISetSetbackVertexDistance(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Int32 Count, VertexObject Vtx, Edge&Object EdgeArr, Double& DistArr)
        //{
        //    return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.ISetSetbackVertexDistance(Count, Vtx, EdgeArr, DistArr);
        //}
        public static Double GetConicRhoOrRadius(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Object PFilletItem)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.GetConicRhoOrRadius(PFilletItem);
        }
        public static Double IGetConicRhoOrRadius(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Object PFilletItem)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.IGetConicRhoOrRadius(PFilletItem);
        }
        public static void SetConicRhoOrRadius(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Object PFilletItem, Double ConicRhoVal)
        {
            ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.SetConicRhoOrRadius(PFilletItem, ConicRhoVal);
        }
        public static void ISetConicRhoOrRadius(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Object PFilletItem, Double ConicRhoVal)
        {
            ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.ISetConicRhoOrRadius(PFilletItem, ConicRhoVal);
        }
        public static Double GetDistance(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Object PFilletItem)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.GetDistance(PFilletItem);
        }
        public static void SetDistance(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, Object PFilletItem, Double Dist2)
        {
            ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.SetDistance(PFilletItem, Dist2);
        }
        public static Int32 Type(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.Type;
        }
        public static Double DefaultRadius(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.DefaultRadius;
        }
        public static Int32 OverflowType(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.OverflowType;
        }
        public static Boolean IsMultipleRadius(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.IsMultipleRadius;
        }
        public static Boolean RoundCorners(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.RoundCorners;
        }
        public static Boolean PropagateToTangentFaces(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.PropagateToTangentFaces;
        }
        public static Int32 FilletItemsCount(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.FilletItemsCount;
        }
        public static Boolean KeepFeatures(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.KeepFeatures;
        }
        public static Object Edges(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.Edges;
        }
        public static Object Loops(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.Loops;
        }
        public static Object Features(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.Features;
        }
        public static Object HoldLines(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.HoldLines;
        }
        public static Boolean CurvatureContinuous(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.CurvatureContinuous;
        }
        public static Object HelpPoint(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.HelpPoint;
        }
        public static Boolean OmitAttachedEdges(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.OmitAttachedEdges;
        }
        public static Boolean ConstantWidth(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.ConstantWidth;
        }
        public static Boolean ReverseFaceNormal(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance, int WhichFaceList)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.ReverseFaceNormal[WhichFaceList];
        }
        public static Int32 TrimAndAttachSurfaces(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.TrimAndAttachSurfaces;
        }
        public static Boolean PropagateFeatureToParts(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.PropagateFeatureToParts;
        }
        public static Int32 ConicTypeForCrossSectionProfile(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.ConicTypeForCrossSectionProfile;
        }
        public static Double DefaultConicRhoOrRadius(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.DefaultConicRhoOrRadius;
        }
        public static Boolean AsymmetricFillet(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.AsymmetricFillet;
        }
        public static Double DefaultDistance(ISimpleFilletFeatureData2Object ISimpleFilletFeatureData2instance)
        {
            return ISimpleFilletFeatureData2instance.ISimpleFilletFeatureData2Instance.DefaultDistance;
        }
    }
}