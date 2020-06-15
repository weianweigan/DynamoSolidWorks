using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRefAxisFeatureDataObject
    {
        public IRefAxisFeatureData IRefAxisFeatureDataInstance { get; set; }
        public IRefAxisFeatureDataObject(IRefAxisFeatureData IRefAxisFeatureDatainstance)
        {
            IRefAxisFeatureDataInstance = IRefAxisFeatureDatainstance;
        }
    }
    public static class IRefAxisFeatureDataInterface
    {
        public static Boolean AccessSelections(IRefAxisFeatureDataObject IRefAxisFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IRefAxisFeatureDatainstance.IRefAxisFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IRefAxisFeatureDataObject IRefAxisFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IRefAxisFeatureDatainstance.IRefAxisFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component.IComponent2Instance.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IRefAxisFeatureDataObject IRefAxisFeatureDatainstance)
        {
            IRefAxisFeatureDatainstance.IRefAxisFeatureDataInstance.ReleaseSelectionAccess();
        }
        //public static Object GetSelections(IRefAxisFeatureDataObject IRefAxisFeatureDatainstance, Object& EntitiesTypeVar)
        //{
        //    return IRefAxisFeatureDatainstance.IRefAxisFeatureDataInstance.GetSelections(EntitiesTypeVar);
        //}
        public static Boolean SetSelections(IRefAxisFeatureDataObject IRefAxisFeatureDatainstance, Object EntitiesVar)
        {
            return IRefAxisFeatureDatainstance.IRefAxisFeatureDataInstance.SetSelections(EntitiesVar);
        }
        public static Int32 GetSelectionsCount(IRefAxisFeatureDataObject IRefAxisFeatureDatainstance)
        {
            return IRefAxisFeatureDatainstance.IRefAxisFeatureDataInstance.GetSelectionsCount();
        }
        //public static Object IGetSelections(IRefAxisFeatureDataObject IRefAxisFeatureDatainstance, Int32 Count, Int32& TypeArr)
        //{
        //    return IRefAxisFeatureDatainstance.IRefAxisFeatureDataInstance.IGetSelections(Count, TypeArr);
        //}
        //public static Boolean ISetSelections(IRefAxisFeatureDataObject IRefAxisFeatureDatainstance, Int32 Count, Object& EntArr)
        //{
        //    return IRefAxisFeatureDatainstance.IRefAxisFeatureDataInstance.ISetSelections(Count, EntArr);
        //}
        public static Int32 Type(IRefAxisFeatureDataObject IRefAxisFeatureDatainstance)
        {
            return IRefAxisFeatureDatainstance.IRefAxisFeatureDataInstance.Type;
        }
    }
}