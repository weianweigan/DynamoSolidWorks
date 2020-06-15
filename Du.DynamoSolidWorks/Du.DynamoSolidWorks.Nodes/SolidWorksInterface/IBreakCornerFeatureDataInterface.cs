using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBreakCornerFeatureDataObject
    {
        public IBreakCornerFeatureData IBreakCornerFeatureDataInstance { get; set; }
        public IBreakCornerFeatureDataObject(IBreakCornerFeatureData IBreakCornerFeatureDatainstance)
        {
            IBreakCornerFeatureDataInstance = IBreakCornerFeatureDatainstance;
        }
    }
    public static class IBreakCornerFeatureDataInterface
    {
        public static Boolean AccessSelections(IBreakCornerFeatureDataObject IBreakCornerFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IBreakCornerFeatureDatainstance.IBreakCornerFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IBreakCornerFeatureDataObject IBreakCornerFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IBreakCornerFeatureDatainstance.IBreakCornerFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IBreakCornerFeatureDataObject IBreakCornerFeatureDatainstance)
        {
            IBreakCornerFeatureDatainstance.IBreakCornerFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetEntitiesCount(IBreakCornerFeatureDataObject IBreakCornerFeatureDatainstance)
        {
            return IBreakCornerFeatureDatainstance.IBreakCornerFeatureDataInstance.GetEntitiesCount();
        }
        public static Object IGetEntities(IBreakCornerFeatureDataObject IBreakCornerFeatureDatainstance, Int32 Count)
        {
            return IBreakCornerFeatureDatainstance.IBreakCornerFeatureDataInstance.IGetEntities(Count);
        }
        //ref not solve
        public static void ISetEntities(IBreakCornerFeatureDataObject IBreakCornerFeatureDatainstance, Int32 EntCount, Object EntArray)
        {
            IBreakCornerFeatureDatainstance.IBreakCornerFeatureDataInstance.ISetEntities(EntCount, EntArray);
        }
        public static Object Entities(IBreakCornerFeatureDataObject IBreakCornerFeatureDatainstance)
        {
            return IBreakCornerFeatureDatainstance.IBreakCornerFeatureDataInstance.Entities;
        }
        public static Int32 BreakType(IBreakCornerFeatureDataObject IBreakCornerFeatureDatainstance)
        {
            return IBreakCornerFeatureDatainstance.IBreakCornerFeatureDataInstance.BreakType;
        }
        public static Double Distance(IBreakCornerFeatureDataObject IBreakCornerFeatureDatainstance)
        {
            return IBreakCornerFeatureDatainstance.IBreakCornerFeatureDataInstance.Distance;
        }
        public static Boolean CenteredOnBendLines(IBreakCornerFeatureDataObject IBreakCornerFeatureDatainstance)
        {
            return IBreakCornerFeatureDatainstance.IBreakCornerFeatureDataInstance.CenteredOnBendLines;
        }
        public static Boolean InternalCornersOnly(IBreakCornerFeatureDataObject IBreakCornerFeatureDatainstance)
        {
            return IBreakCornerFeatureDatainstance.IBreakCornerFeatureDataInstance.InternalCornersOnly;
        }
    }
}