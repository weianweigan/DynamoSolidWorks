using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMiterFlangeFeatureDataObject
    {
        public IMiterFlangeFeatureData IMiterFlangeFeatureDataInstance { get; set; }
        public IMiterFlangeFeatureDataObject(IMiterFlangeFeatureData IMiterFlangeFeatureDatainstance)
        {
            IMiterFlangeFeatureDataInstance = IMiterFlangeFeatureDatainstance;
        }
    }
    public static class IMiterFlangeFeatureDataInterface
    {
        public static Boolean AccessSelections(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance?.CastObj<ModelDoc>(), Component?.IComponentInstance?.CastObj<Component>());
        }
        public static void ReleaseSelectionAccess(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 IGetEdgesCount(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.IGetEdgesCount();
        }
        public static Object IGetEdges(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.IGetEdges();
        }
        //public static void ISetEdges(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance, Int32 EdgeCount, Object& EdgeArray)
        //{
        //    return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.ISetEdges(EdgeCount, EdgeArray);
        //}
        public static Boolean IAccessSelections2(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.IAccessSelections2(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static ICustomBendAllowanceObject GetCustomBendAllowance(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return new ICustomBendAllowanceObject(IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.GetCustomBendAllowance());
        }
        public static void SetCustomBendAllowance(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance, ICustomBendAllowanceObject PBendData)
        {
            IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.SetCustomBendAllowance(PBendData.ICustomBendAllowanceInstance as CustomBendAllowance);
        }
        public static Object Edges(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.Edges;
        }
        public static Boolean UseDefaultBendRadius(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.UseDefaultBendRadius;
        }
        public static Double BendRadius(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.BendRadius;
        }
        public static Int32 PositionType(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.PositionType;
        }
        public static Boolean UsePositionTrimSideBends(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.UsePositionTrimSideBends;
        }
        public static Double GapDistance(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.GapDistance;
        }
        public static Double StartOffset(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.StartOffset;
        }
        public static Double EndOffset(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.EndOffset;
        }
        public static Int32 ReliefType(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.ReliefType;
        }
        public static Boolean UseReliefRatio(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.UseReliefRatio;
        }
        public static Double ReliefRatio(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.ReliefRatio;
        }
        public static Double ReliefWidth(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.ReliefWidth;
        }
        public static Double ReliefDepth(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.ReliefDepth;
        }
        public static Boolean UseDefaultBendAllowance(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.UseDefaultBendAllowance;
        }
        public static Boolean UseDefaultBendRelief(IMiterFlangeFeatureDataObject IMiterFlangeFeatureDatainstance)
        {
            return IMiterFlangeFeatureDatainstance.IMiterFlangeFeatureDataInstance.UseDefaultBendRelief;
        }
    }
}