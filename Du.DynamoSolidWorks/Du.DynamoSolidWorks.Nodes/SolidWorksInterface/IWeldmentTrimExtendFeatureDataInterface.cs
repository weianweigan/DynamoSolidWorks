using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IWeldmentTrimExtendFeatureDataObject
    {
        public IWeldmentTrimExtendFeatureData IWeldmentTrimExtendFeatureDataInstance { get; set; }
        public IWeldmentTrimExtendFeatureDataObject(IWeldmentTrimExtendFeatureData IWeldmentTrimExtendFeatureDatainstance)
        {
            IWeldmentTrimExtendFeatureDataInstance = IWeldmentTrimExtendFeatureDatainstance;
        }
    }
    public static class IWeldmentTrimExtendFeatureDataInterface
    {
        public static Boolean AccessSelections(IWeldmentTrimExtendFeatureDataObject IWeldmentTrimExtendFeatureDatainstance, IModelDoc2Object PTopDoc, IComponent2Object PComponent)
        {
            return IWeldmentTrimExtendFeatureDatainstance.IWeldmentTrimExtendFeatureDataInstance.AccessSelections(PTopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), PComponent?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IWeldmentTrimExtendFeatureDataObject IWeldmentTrimExtendFeatureDatainstance)
        {
            IWeldmentTrimExtendFeatureDatainstance.IWeldmentTrimExtendFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetBodiesToBeTrimmedCount(IWeldmentTrimExtendFeatureDataObject IWeldmentTrimExtendFeatureDatainstance)
        {
            return IWeldmentTrimExtendFeatureDatainstance.IWeldmentTrimExtendFeatureDataInstance.GetBodiesToBeTrimmedCount();
        }
        public static IBody2Object IGetBodiesToBeTrimmed(IWeldmentTrimExtendFeatureDataObject IWeldmentTrimExtendFeatureDatainstance, Int32 Count)
        {
            return new IBody2Object(IWeldmentTrimExtendFeatureDatainstance.IWeldmentTrimExtendFeatureDataInstance.IGetBodiesToBeTrimmed(Count));
        }
        //public static void ISetBodiesToBeTrimmed(IWeldmentTrimExtendFeatureDataObject IWeldmentTrimExtendFeatureDatainstance, Int32 Count, Body2&Object BodiesIn)
        //{
        //    return IWeldmentTrimExtendFeatureDatainstance.IWeldmentTrimExtendFeatureDataInstance.ISetBodiesToBeTrimmed(Count, BodiesIn);
        //}
        public static Int32 GetTrimmingBoundaryCount(IWeldmentTrimExtendFeatureDataObject IWeldmentTrimExtendFeatureDatainstance)
        {
            return IWeldmentTrimExtendFeatureDatainstance.IWeldmentTrimExtendFeatureDataInstance.GetTrimmingBoundaryCount();
        }
        //public static Object GetTrimmingBoundary(IWeldmentTrimExtendFeatureDataObject IWeldmentTrimExtendFeatureDatainstance, Int32& Type)
        //{
        //    return IWeldmentTrimExtendFeatureDatainstance.IWeldmentTrimExtendFeatureDataInstance.GetTrimmingBoundary(Type);
        //}
        public static void SetTrimmingBoundary(IWeldmentTrimExtendFeatureDataObject IWeldmentTrimExtendFeatureDatainstance, Object TrimBoundVar)
        {
            IWeldmentTrimExtendFeatureDatainstance.IWeldmentTrimExtendFeatureDataInstance.SetTrimmingBoundary(TrimBoundVar);
        }
        //public static Object IGetTrimmingBoundary(IWeldmentTrimExtendFeatureDataObject IWeldmentTrimExtendFeatureDatainstance, Int32 Count, Int32& Type)
        //{
        //    return IWeldmentTrimExtendFeatureDatainstance.IWeldmentTrimExtendFeatureDataInstance.IGetTrimmingBoundary(Count, Type);
        //}
        //public static void ISetTrimmingBoundary(IWeldmentTrimExtendFeatureDataObject IWeldmentTrimExtendFeatureDatainstance, Int32 Count, Object& TrimBoundArr)
        //{
        //    return IWeldmentTrimExtendFeatureDatainstance.IWeldmentTrimExtendFeatureDataInstance.ISetTrimmingBoundary(Count, TrimBoundArr);
        //}
        public static Int32 CornerType(IWeldmentTrimExtendFeatureDataObject IWeldmentTrimExtendFeatureDatainstance)
        {
            return IWeldmentTrimExtendFeatureDatainstance.IWeldmentTrimExtendFeatureDataInstance.CornerType;
        }
        public static Object BodiesToBeTrimmed(IWeldmentTrimExtendFeatureDataObject IWeldmentTrimExtendFeatureDatainstance)
        {
            return IWeldmentTrimExtendFeatureDatainstance.IWeldmentTrimExtendFeatureDataInstance.BodiesToBeTrimmed;
        }
    }
}