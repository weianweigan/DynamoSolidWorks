using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFoldsFeatureDataObject
    {
        public IFoldsFeatureData IFoldsFeatureDataInstance { get; set; }
        public IFoldsFeatureDataObject(IFoldsFeatureData IFoldsFeatureDatainstance)
        {
            IFoldsFeatureDataInstance = IFoldsFeatureDatainstance;
        }
    }
    public static class IFoldsFeatureDataInterface
    {
        public static Boolean AccessSelections(IFoldsFeatureDataObject IFoldsFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IFoldsFeatureDatainstance.IFoldsFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IFoldsFeatureDataObject IFoldsFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IFoldsFeatureDatainstance.IFoldsFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static void ReleaseSelectionAccess(IFoldsFeatureDataObject IFoldsFeatureDatainstance)
        {
            IFoldsFeatureDatainstance.IFoldsFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 IGetBendsCount(IFoldsFeatureDataObject IFoldsFeatureDatainstance)
        {
            return IFoldsFeatureDatainstance.IFoldsFeatureDataInstance.IGetBendsCount();
        }
        public static Object IGetBends(IFoldsFeatureDataObject IFoldsFeatureDatainstance)
        {
            return IFoldsFeatureDatainstance.IFoldsFeatureDataInstance.IGetBends();
        }
        //public static void ISetBends(IFoldsFeatureDataObject IFoldsFeatureDatainstance, Int32 FaceCount, Object& FaceArray)
        //{
        //    return IFoldsFeatureDatainstance.IFoldsFeatureDataInstance.ISetBends(FaceCount, FaceArray);
        //}
        //public static Boolean IAccessSelections2(IFoldsFeatureDataObject IFoldsFeatureDatainstance, ModelDoc2Object TopDoc, Component2Object Component)
        //{
        //    return IFoldsFeatureDatainstance.IFoldsFeatureDataInstance.IAccessSelections2(TopDoc, Component);
        //}
        public static Object FixedFace(IFoldsFeatureDataObject IFoldsFeatureDatainstance)
        {
            return IFoldsFeatureDatainstance.IFoldsFeatureDataInstance.FixedFace;
        }
        public static Object Bends(IFoldsFeatureDataObject IFoldsFeatureDatainstance)
        {
            return IFoldsFeatureDatainstance.IFoldsFeatureDataInstance.Bends;
        }
    }
}