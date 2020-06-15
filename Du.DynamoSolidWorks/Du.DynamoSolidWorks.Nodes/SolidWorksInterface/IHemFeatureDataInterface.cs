using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IHemFeatureDataObject
    {
        public IHemFeatureData IHemFeatureDataInstance { get; set; }
        public IHemFeatureDataObject(IHemFeatureData IHemFeatureDatainstance)
        {
            IHemFeatureDataInstance = IHemFeatureDatainstance;
        }
    }
    public static class IHemFeatureDataInterface
    {
        public static Boolean AccessSelections(IHemFeatureDataObject IHemFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IHemFeatureDatainstance.IHemFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IHemFeatureDataObject IHemFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IHemFeatureDatainstance.IHemFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IHemFeatureDataObject IHemFeatureDatainstance)
        {
            IHemFeatureDatainstance.IHemFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetEdgesCount(IHemFeatureDataObject IHemFeatureDatainstance)
        {
            return IHemFeatureDatainstance.IHemFeatureDataInstance.GetEdgesCount();
        }
        public static Object IGetEdges(IHemFeatureDataObject IHemFeatureDatainstance, Int32 EdgeCount)
        {
            return IHemFeatureDatainstance.IHemFeatureDataInstance.IGetEdges(EdgeCount);
        }
        //public static void ISetEdges(IHemFeatureDataObject IHemFeatureDatainstance, Int32 EdgeCount, Object& EdgeArr)
        //{
        //    return IHemFeatureDatainstance.IHemFeatureDataInstance.ISetEdges(EdgeCount, EdgeArr);
        //}
        public static ICustomBendAllowanceObject GetCustomBendAllowance(IHemFeatureDataObject IHemFeatureDatainstance)
        {
            return new ICustomBendAllowanceObject(IHemFeatureDatainstance.IHemFeatureDataInstance.GetCustomBendAllowance());
        }
        public static void SetCustomBendAllowance(IHemFeatureDataObject IHemFeatureDatainstance, ICustomBendAllowanceObject PBendData)
        {
            IHemFeatureDatainstance.IHemFeatureDataInstance.SetCustomBendAllowance(PBendData.ICustomBendAllowanceInstance as CustomBendAllowance);
        }
        public static Object Edges(IHemFeatureDataObject IHemFeatureDatainstance)
        {
            return IHemFeatureDatainstance.IHemFeatureDataInstance.Edges;
        }
        public static Double MiterGap(IHemFeatureDataObject IHemFeatureDatainstance)
        {
            return IHemFeatureDatainstance.IHemFeatureDataInstance.MiterGap;
        }
        public static Boolean ReverseDirection(IHemFeatureDataObject IHemFeatureDatainstance)
        {
            return IHemFeatureDatainstance.IHemFeatureDataInstance.ReverseDirection;
        }
        public static Int32 BendPosition(IHemFeatureDataObject IHemFeatureDatainstance)
        {
            return IHemFeatureDatainstance.IHemFeatureDataInstance.BendPosition;
        }
        public static Int32 Type(IHemFeatureDataObject IHemFeatureDatainstance)
        {
            return IHemFeatureDatainstance.IHemFeatureDataInstance.Type;
        }
        public static Double Length(IHemFeatureDataObject IHemFeatureDatainstance)
        {
            return IHemFeatureDatainstance.IHemFeatureDataInstance.Length;
        }
        public static Double GapDistance(IHemFeatureDataObject IHemFeatureDatainstance)
        {
            return IHemFeatureDatainstance.IHemFeatureDataInstance.GapDistance;
        }
        public static Double Angle(IHemFeatureDataObject IHemFeatureDatainstance)
        {
            return IHemFeatureDatainstance.IHemFeatureDataInstance.Angle;
        }
        public static Double Radius(IHemFeatureDataObject IHemFeatureDatainstance)
        {
            return IHemFeatureDatainstance.IHemFeatureDataInstance.Radius;
        }
        public static Boolean UseDefaultBendAllowance(IHemFeatureDataObject IHemFeatureDatainstance)
        {
            return IHemFeatureDatainstance.IHemFeatureDataInstance.UseDefaultBendAllowance;
        }
    }
}