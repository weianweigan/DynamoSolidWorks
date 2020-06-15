using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRefPointFeatureDataObject
    {
        public IRefPointFeatureData IRefPointFeatureDataInstance { get; set; }
        public IRefPointFeatureDataObject(IRefPointFeatureData IRefPointFeatureDatainstance)
        {
            IRefPointFeatureDataInstance = IRefPointFeatureDatainstance;
        }
    }
    public static class IRefPointFeatureDataInterface
    {
        public static Boolean AccessSelections(IRefPointFeatureDataObject IRefPointFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IRefPointFeatureDatainstance.IRefPointFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IRefPointFeatureDataObject IRefPointFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IRefPointFeatureDatainstance.IRefPointFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IRefPointFeatureDataObject IRefPointFeatureDatainstance)
        {
            IRefPointFeatureDatainstance.IRefPointFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetSelectionsCount(IRefPointFeatureDataObject IRefPointFeatureDatainstance)
        {
            return IRefPointFeatureDatainstance.IRefPointFeatureDataInstance.GetSelectionsCount();
        }
        public static Object IGetSelections(IRefPointFeatureDataObject IRefPointFeatureDatainstance, Int32 Count)
        {
            return IRefPointFeatureDatainstance.IRefPointFeatureDataInstance.IGetSelections(Count);
        }
        //public static void ISetSelections(IRefPointFeatureDataObject IRefPointFeatureDatainstance, Int32 Count, Object& Entities)
        //{
        //    return IRefPointFeatureDatainstance.IRefPointFeatureDataInstance.ISetSelections(Count, Entities);
        //}
        public static Int32 Type(IRefPointFeatureDataObject IRefPointFeatureDatainstance)
        {
            return IRefPointFeatureDatainstance.IRefPointFeatureDataInstance.Type;
        }
        public static Int32 AlongCurveOption(IRefPointFeatureDataObject IRefPointFeatureDatainstance)
        {
            return IRefPointFeatureDatainstance.IRefPointFeatureDataInstance.AlongCurveOption;
        }
        public static Double Distance(IRefPointFeatureDataObject IRefPointFeatureDatainstance)
        {
            return IRefPointFeatureDatainstance.IRefPointFeatureDataInstance.Distance;
        }
        public static Object Selections(IRefPointFeatureDataObject IRefPointFeatureDatainstance)
        {
            return IRefPointFeatureDatainstance.IRefPointFeatureDataInstance.Selections;
        }
    }
}