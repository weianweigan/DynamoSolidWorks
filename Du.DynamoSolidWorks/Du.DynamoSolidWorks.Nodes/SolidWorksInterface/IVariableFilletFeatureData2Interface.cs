using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IVariableFilletFeatureData2Object
    {
        public IVariableFilletFeatureData2 IVariableFilletFeatureData2Instance { get; set; }
        public IVariableFilletFeatureData2Object(IVariableFilletFeatureData2 IVariableFilletFeatureData2instance)
        {
            IVariableFilletFeatureData2Instance = IVariableFilletFeatureData2instance;
        }
    }
    public static class IVariableFilletFeatureData2Interface
    {
        public static Object GetFilletEdgeAtIndex(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Int32 Index)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.GetFilletEdgeAtIndex(Index);
        }
        public static IEdgeObject IGetFilletEdgeAtIndex(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Int32 Index)
        {
            return new IEdgeObject(IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.IGetFilletEdgeAtIndex(Index));
        }
        public static Double GetRadius(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Object PFilletItem)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.GetRadius(PFilletItem);
        }
        //public static Double IGetRadius(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, VertexObject PFilletItem)
        //{
        //    return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.IGetRadius(PFilletItem);
        //}
        public static void SetRadius(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Object PFilletItem, Double Radius)
        {
            IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.SetRadius(PFilletItem, Radius);
        }
        //public static void ISetRadius(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, VertexObject PFilletItem, Double Radius)
        //{
        //    return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.ISetRadius(PFilletItem, Radius);
        //}
        public static Boolean AccessSelections(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Object TopDoc, Object Component)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.ReleaseSelectionAccess();
        }
        //public static Double GetRadius2(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, VertexObject PFilletItem, Boolean& IsAssigned)
        //{
        //    return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.GetRadius2(PFilletItem, IsAssigned);
        //}
        public static Int32 GetControlPointsCount(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.GetControlPointsCount();
        }
        //public static Double GetControlPointRadiusAtIndex(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Int32 Index, Double& Location, Edge&Object PEdge)
        //{
        //    return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.GetControlPointRadiusAtIndex(Index, Location, PEdge);
        //}
        public static void SetControlPointRadiusAtIndex(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Int32 Index, Double Location, Double Radius)
        {
            IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.SetControlPointRadiusAtIndex(Index, Location, Radius);
        }
        public static Object GetSetbackVertices(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.GetSetbackVertices();
        }
        //public static Object GetSetbackVertexDistance(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Object Vtx, Object& EdgeVar)
        //{
        //    return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.GetSetbackVertexDistance(Vtx, EdgeVar);
        //}
        public static Boolean SetSetbackVertices(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Object VertVar)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.SetSetbackVertices(VertVar);
        }
        public static Boolean SetSetbackVertexDistance(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Object Vtx, Object EdgeVar, Object DistVar)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.SetSetbackVertexDistance(Vtx, EdgeVar, DistVar);
        }
        public static Int32 GetSetbackVerticesCount(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.GetSetbackVerticesCount();
        }
        public static IVertexObject IGetSetbackVertices(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Int32 Count)
        {
            return new IVertexObject(IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.IGetSetbackVertices(Count));
        }
        //public static Int32 GetSetbackDistanceCount(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, VertexObject Vtx)
        //{
        //    return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.GetSetbackDistanceCount(Vtx);
        //}
        //public static Double IGetSetbackVertexDistance(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Int32 Count, VertexObject Vtx, Edge&Object EdgeArr)
        //{
        //    return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.IGetSetbackVertexDistance(Count, Vtx, EdgeArr);
        //}
        //public static Boolean ISetSetbackVertices(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Int32 Count, Vertex&Object VertArr)
        //{
        //    return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.ISetSetbackVertices(Count, VertArr);
        //}
        //public static Boolean ISetSetbackVertexDistance(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Int32 Count, VertexObject Vtx, Edge&Object EdgeArr, Double& DistArr)
        //{
        //    return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.ISetSetbackVertexDistance(Count, Vtx, EdgeArr, DistArr);
        //}
        public static Double GetConicRhoOrRadius(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Object PFilletItem)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.GetConicRhoOrRadius(PFilletItem);
        }
        //public static Double IGetConicRhoOrRadius(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, VertexObject PFilletItem)
        //{
        //    return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.IGetConicRhoOrRadius(PFilletItem);
        //}
        public static void SetConicRhoOrRadius(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Object PFilletItem, Double ConicRhoVal)
        {
            IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.SetConicRhoOrRadius(PFilletItem, ConicRhoVal);
        }
        //public static void ISetConicRhoOrRadius(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, VertexObject PFilletItem, Double ConicRhoVal)
        //{
        //    return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.ISetConicRhoOrRadius(PFilletItem, ConicRhoVal);
        //}
        //public static Double GetConicRhoOrRadius2(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, VertexObject PFilletItem, Boolean& IsAssigned)
        //{
        //    return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.GetConicRhoOrRadius2(PFilletItem, IsAssigned);
        //}
        public static Double GetControlPointConicRhoOrRadiusAtIndex(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Int32 Index)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.GetControlPointConicRhoOrRadiusAtIndex(Index);
        }
        public static void SetControlPointConicRhoOrRadiusAtIndex(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Int32 Index, Double ConicRhoVal)
        {
            IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.SetControlPointConicRhoOrRadiusAtIndex(Index, ConicRhoVal);
        }
        public static Double GetDistance(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Object PFilletItem)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.GetDistance(PFilletItem);
        }
        public static void SetDistance(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Object PFilletItem, Double Dist2)
        {
            IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.SetDistance(PFilletItem, Dist2);
        }
        public static Double GetControlPointDistanceAtIndex(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Int32 Index)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.GetControlPointDistanceAtIndex(Index);
        }
        public static void SetControlPointDistanceAtIndex(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance, Int32 Index, Double Dist2)
        {
            IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.SetControlPointDistanceAtIndex(Index, Dist2);
        }
        public static Double DefaultRadius(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.DefaultRadius;
        }
        public static Int32 OverflowType(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.OverflowType;
        }
        public static Int32 TransitionType(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.TransitionType;
        }
        public static Boolean PropagateToTangentFaces(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.PropagateToTangentFaces;
        }
        public static Int32 FilletEdgeCount(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.FilletEdgeCount;
        }
        public static Boolean PropagateFeatureToParts(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.PropagateFeatureToParts;
        }
        public static Int32 ConicTypeForCrossSectionProfile(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.ConicTypeForCrossSectionProfile;
        }
        public static Double DefaultConicRhoOrRadius(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.DefaultConicRhoOrRadius;
        }
        public static Boolean AsymmetricFillet(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.AsymmetricFillet;
        }
        public static Double DefaultDistance(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.DefaultDistance;
        }
        public static Boolean CurvatureContinuous(IVariableFilletFeatureData2Object IVariableFilletFeatureData2instance)
        {
            return IVariableFilletFeatureData2instance.IVariableFilletFeatureData2Instance.CurvatureContinuous;
        }
    }
}