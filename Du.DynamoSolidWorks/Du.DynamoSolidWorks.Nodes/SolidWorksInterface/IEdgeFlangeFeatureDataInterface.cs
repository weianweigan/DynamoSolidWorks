using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IEdgeFlangeFeatureDataObject
    {
        public IEdgeFlangeFeatureData IEdgeFlangeFeatureDataInstance { get; set; }
        public IEdgeFlangeFeatureDataObject(IEdgeFlangeFeatureData IEdgeFlangeFeatureDatainstance)
        {
            IEdgeFlangeFeatureDataInstance = IEdgeFlangeFeatureDatainstance;
        }
    }
    public static class IEdgeFlangeFeatureDataInterface
    {
        public static Boolean AccessSelections(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static void ReleaseSelectionAccess(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetPositionReferenceType(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.GetPositionReferenceType();
        }
        public static Boolean IAccessSelections2(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.IAccessSelections2(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static ICustomBendAllowanceObject GetCustomBendAllowance(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return new ICustomBendAllowanceObject(IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.GetCustomBendAllowance());
        }
        public static void SetCustomBendAllowance(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance, ICustomBendAllowanceObject PBendData)
        {
            IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.SetCustomBendAllowance(PBendData.ICustomBendAllowanceInstance as CustomBendAllowance);
        }
        public static Int32 GetEdgeCount(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.GetEdgeCount();
        }
        public static Object IGetEdges(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance, Int32 EdgeCount)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.IGetEdges(EdgeCount);
        }
        //public static void ISetEdges(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance, Int32 EdgeCount, Object& EdgeArray)
        //{
        //    return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.ISetEdges(EdgeCount, EdgeArray);
        //}
        public static Int32 AddEdges(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance, Object EdgeArray, Object SketchArray)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.AddEdges(EdgeArray, SketchArray);
        }
        public static Int32 RemoveEdges(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance, Object EdgeArray)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.RemoveEdges(EdgeArray);
        }
        public static Object Edge(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.Edge;
        }
        public static Boolean UseDefaultBendRadius(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.UseDefaultBendRadius;
        }
        public static Double BendRadius(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.BendRadius;
        }
        public static Double BendAngle(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.BendAngle;
        }
        public static Int32 OffsetType(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.OffsetType;
        }
        public static Object OffsetReference(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.OffsetReference;
        }
        public static Boolean ReverseOffset(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.ReverseOffset;
        }
        public static Double OffsetDistance(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.OffsetDistance;
        }
        public static Int32 OffsetDimType(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.OffsetDimType;
        }
        public static Int32 PositionType(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.PositionType;
        }
        public static Boolean UsePositionTrimSideBends(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.UsePositionTrimSideBends;
        }
        public static Boolean UsePositionOffset(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.UsePositionOffset;
        }
        public static Int32 PositionOffsetType(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.PositionOffsetType;
        }
        public static Object PositionOffsetReference(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.PositionOffsetReference;
        }
        public static Double PositionOffsetDistance(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.PositionOffsetDistance;
        }
        public static Boolean ReversePositionOffset(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.ReversePositionOffset;
        }
        public static Int32 AutoReliefType(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.AutoReliefType;
        }
        public static Boolean UseReliefRatio(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.UseReliefRatio;
        }
        public static Double ReliefRatio(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.ReliefRatio;
        }
        public static Double ReliefWidth(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.ReliefWidth;
        }
        public static Double ReliefDepth(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.ReliefDepth;
        }
        public static Int32 ReliefTearType(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.ReliefTearType;
        }
        public static Boolean UseDefaultBendAllowance(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.UseDefaultBendAllowance;
        }
        public static Boolean UseDefaultBendRelief(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.UseDefaultBendRelief;
        }
        public static Object Edges(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.Edges;
        }
        public static Double GapDistance(IEdgeFlangeFeatureDataObject IEdgeFlangeFeatureDatainstance)
        {
            return IEdgeFlangeFeatureDatainstance.IEdgeFlangeFeatureDataInstance.GapDistance;
        }
    }
}