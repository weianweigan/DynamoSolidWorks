using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IShellFeatureDataObject
    {
        public IShellFeatureData IShellFeatureDataInstance { get; set; }
        public IShellFeatureDataObject(IShellFeatureData IShellFeatureDatainstance)
        {
            IShellFeatureDataInstance = IShellFeatureDatainstance;
        }
    }
    public static class IShellFeatureDataInterface
    {
        public static Boolean IAccessSelections(IShellFeatureDataObject IShellFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IShellFeatureDatainstance.IShellFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static Boolean AccessSelections(IShellFeatureDataObject IShellFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IShellFeatureDatainstance.IShellFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(IShellFeatureDataObject IShellFeatureDatainstance)
        {
            IShellFeatureDatainstance.IShellFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Object IGetFacesRemoved(IShellFeatureDataObject IShellFeatureDatainstance, Int32 Count)
        {
            return IShellFeatureDatainstance.IShellFeatureDataInstance.IGetFacesRemoved(Count);
        }
        //public static void ISetFacesRemoved(IShellFeatureDataObject IShellFeatureDatainstance, Int32 Count, Object& FaceArray)
        //{
        //    return IShellFeatureDatainstance.IShellFeatureDataInstance.ISetFacesRemoved(Count, FaceArray);
        //}
        public static Int32 GetMultipleThicknessFacesCount(IShellFeatureDataObject IShellFeatureDatainstance)
        {
            return IShellFeatureDatainstance.IShellFeatureDataInstance.GetMultipleThicknessFacesCount();
        }
        public static Object IGetMultipleThicknessFaces(IShellFeatureDataObject IShellFeatureDatainstance, Int32 Count)
        {
            return IShellFeatureDatainstance.IShellFeatureDataInstance.IGetMultipleThicknessFaces(Count);
        }
        //public static void ISetMultipleThicknessFaces(IShellFeatureDataObject IShellFeatureDatainstance, Int32 Count, Object& FaceArray)
        //{
        //    return IShellFeatureDatainstance.IShellFeatureDataInstance.ISetMultipleThicknessFaces(Count, FaceArray);
        //}
        public static Double GetMultipleThicknessAtIndex(IShellFeatureDataObject IShellFeatureDatainstance, Int32 Index)
        {
            return IShellFeatureDatainstance.IShellFeatureDataInstance.GetMultipleThicknessAtIndex(Index);
        }
        public static void SetMultipleThicknessAtIndex(IShellFeatureDataObject IShellFeatureDatainstance, Int32 Index, Double Thickness)
        {
            IShellFeatureDatainstance.IShellFeatureDataInstance.SetMultipleThicknessAtIndex(Index, Thickness);
        }
        public static Double Thickness(IShellFeatureDataObject IShellFeatureDatainstance)
        {
            return IShellFeatureDatainstance.IShellFeatureDataInstance.Thickness;
        }
        public static Int32 Direction(IShellFeatureDataObject IShellFeatureDatainstance)
        {
            return IShellFeatureDatainstance.IShellFeatureDataInstance.Direction;
        }
        public static Int32 FacesRemovedCount(IShellFeatureDataObject IShellFeatureDatainstance)
        {
            return IShellFeatureDatainstance.IShellFeatureDataInstance.FacesRemovedCount;
        }
        public static Object FacesRemoved(IShellFeatureDataObject IShellFeatureDatainstance)
        {
            return IShellFeatureDatainstance.IShellFeatureDataInstance.FacesRemoved;
        }
        public static Object MultipleThicknessFaces(IShellFeatureDataObject IShellFeatureDatainstance)
        {
            return IShellFeatureDatainstance.IShellFeatureDataInstance.MultipleThicknessFaces;
        }
    }
}