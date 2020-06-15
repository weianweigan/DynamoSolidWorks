using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchedBendFeatureDataObject
    {
        public ISketchedBendFeatureData ISketchedBendFeatureDataInstance { get; set; }
        public ISketchedBendFeatureDataObject(ISketchedBendFeatureData ISketchedBendFeatureDatainstance)
        {
            ISketchedBendFeatureDataInstance = ISketchedBendFeatureDatainstance;
        }
    }
    public static class ISketchedBendFeatureDataInterface
    {
        public static Boolean AccessSelections(ISketchedBendFeatureDataObject ISketchedBendFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISketchedBendFeatureDatainstance.ISketchedBendFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ISketchedBendFeatureDataObject ISketchedBendFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return ISketchedBendFeatureDatainstance.ISketchedBendFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance?.CastObj<ModelDoc>(), Component?.IComponentInstance?.CastObj<Component>());
        }
        public static void ReleaseSelectionAccess(ISketchedBendFeatureDataObject ISketchedBendFeatureDatainstance)
        {
            ISketchedBendFeatureDatainstance.ISketchedBendFeatureDataInstance.ReleaseSelectionAccess();
        }
        //public static Object GetFixedFace(ISketchedBendFeatureDataObject ISketchedBendFeatureDatainstance, Double& X, Double& Y, Double& Z)
        //{
        //    return ISketchedBendFeatureDatainstance.ISketchedBendFeatureDataInstance.GetFixedFace(X, Y, Z);
        //}
        public static void SetFixedFace(ISketchedBendFeatureDataObject ISketchedBendFeatureDatainstance, Double X, Double Y, Double Z, Object EdgeArray)
        {
            ISketchedBendFeatureDatainstance.ISketchedBendFeatureDataInstance.SetFixedFace(X, Y, Z, EdgeArray);
        }
        public static Boolean IAccessSelections2(ISketchedBendFeatureDataObject ISketchedBendFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISketchedBendFeatureDatainstance.ISketchedBendFeatureDataInstance.IAccessSelections2(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static ICustomBendAllowanceObject GetCustomBendAllowance(ISketchedBendFeatureDataObject ISketchedBendFeatureDatainstance)
        {
            return new ICustomBendAllowanceObject(ISketchedBendFeatureDatainstance.ISketchedBendFeatureDataInstance.GetCustomBendAllowance());
        }
        //public static void SetCustomBendAllowance(ISketchedBendFeatureDataObject ISketchedBendFeatureDatainstance, CustomBendAllowanceObject PBendData)
        //{
        //    return ISketchedBendFeatureDatainstance.ISketchedBendFeatureDataInstance.SetCustomBendAllowance(PBendData);
        //}
        public static Int32 PositionType(ISketchedBendFeatureDataObject ISketchedBendFeatureDatainstance)
        {
            return ISketchedBendFeatureDatainstance.ISketchedBendFeatureDataInstance.PositionType;
        }
        public static Boolean ReverseDirection(ISketchedBendFeatureDataObject ISketchedBendFeatureDatainstance)
        {
            return ISketchedBendFeatureDatainstance.ISketchedBendFeatureDataInstance.ReverseDirection;
        }
        public static Double BendAngle(ISketchedBendFeatureDataObject ISketchedBendFeatureDatainstance)
        {
            return ISketchedBendFeatureDatainstance.ISketchedBendFeatureDataInstance.BendAngle;
        }
        public static Boolean UseDefaultBendRadius(ISketchedBendFeatureDataObject ISketchedBendFeatureDatainstance)
        {
            return ISketchedBendFeatureDatainstance.ISketchedBendFeatureDataInstance.UseDefaultBendRadius;
        }
        public static Double BendRadius(ISketchedBendFeatureDataObject ISketchedBendFeatureDatainstance)
        {
            return ISketchedBendFeatureDatainstance.ISketchedBendFeatureDataInstance.BendRadius;
        }
        public static Boolean UseDefaultBendAllowance(ISketchedBendFeatureDataObject ISketchedBendFeatureDatainstance)
        {
            return ISketchedBendFeatureDatainstance.ISketchedBendFeatureDataInstance.UseDefaultBendAllowance;
        }
    }
}