using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISurfaceKnitFeatureDataObject
    {
        public ISurfaceKnitFeatureData ISurfaceKnitFeatureDataInstance { get; set; }
        public ISurfaceKnitFeatureDataObject(ISurfaceKnitFeatureData ISurfaceKnitFeatureDatainstance)
        {
            ISurfaceKnitFeatureDataInstance = ISurfaceKnitFeatureDatainstance;
        }
    }
    public static class ISurfaceKnitFeatureDataInterface
    {
        public static Boolean AccessSelections(ISurfaceKnitFeatureDataObject ISurfaceKnitFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISurfaceKnitFeatureDatainstance.ISurfaceKnitFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ISurfaceKnitFeatureDataObject ISurfaceKnitFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISurfaceKnitFeatureDatainstance.ISurfaceKnitFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISurfaceKnitFeatureDataObject ISurfaceKnitFeatureDatainstance)
        {
            ISurfaceKnitFeatureDatainstance.ISurfaceKnitFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetEntitiesCount(ISurfaceKnitFeatureDataObject ISurfaceKnitFeatureDatainstance)
        {
            return ISurfaceKnitFeatureDatainstance.ISurfaceKnitFeatureDataInstance.GetEntitiesCount();
        }
        public static Object IGetEntities(ISurfaceKnitFeatureDataObject ISurfaceKnitFeatureDatainstance, Int32 Count)
        {
            return ISurfaceKnitFeatureDatainstance.ISurfaceKnitFeatureDataInstance.IGetEntities(Count);
        }
        //public static void ISetEntities(ISurfaceKnitFeatureDataObject ISurfaceKnitFeatureDatainstance, Int32 Count, Object& FaceArr)
        //{
        //    return ISurfaceKnitFeatureDatainstance.ISurfaceKnitFeatureDataInstance.ISetEntities(Count, FaceArr);
        //}
        public static Object Entities(ISurfaceKnitFeatureDataObject ISurfaceKnitFeatureDatainstance)
        {
            return ISurfaceKnitFeatureDatainstance.ISurfaceKnitFeatureDataInstance.Entities;
        }
        public static Object SeedFace(ISurfaceKnitFeatureDataObject ISurfaceKnitFeatureDatainstance)
        {
            return ISurfaceKnitFeatureDatainstance.ISurfaceKnitFeatureDataInstance.SeedFace;
        }
        public static Boolean UseTryToFormSolid(ISurfaceKnitFeatureDataObject ISurfaceKnitFeatureDatainstance)
        {
            return ISurfaceKnitFeatureDatainstance.ISurfaceKnitFeatureDataInstance.UseTryToFormSolid;
        }
        public static Boolean UseGapFilters(ISurfaceKnitFeatureDataObject ISurfaceKnitFeatureDatainstance)
        {
            return ISurfaceKnitFeatureDatainstance.ISurfaceKnitFeatureDataInstance.UseGapFilters;
        }
        public static Boolean UseMergeEntities(ISurfaceKnitFeatureDataObject ISurfaceKnitFeatureDatainstance)
        {
            return ISurfaceKnitFeatureDatainstance.ISurfaceKnitFeatureDataInstance.UseMergeEntities;
        }
        public static Double KnitTolerance(ISurfaceKnitFeatureDataObject ISurfaceKnitFeatureDatainstance)
        {
            return ISurfaceKnitFeatureDatainstance.ISurfaceKnitFeatureDataInstance.KnitTolerance;
        }
        public static Double MaxValueForGapRange(ISurfaceKnitFeatureDataObject ISurfaceKnitFeatureDatainstance)
        {
            return ISurfaceKnitFeatureDatainstance.ISurfaceKnitFeatureDataInstance.MaxValueForGapRange;
        }
        public static Double MinValueForGapRange(ISurfaceKnitFeatureDataObject ISurfaceKnitFeatureDatainstance)
        {
            return ISurfaceKnitFeatureDatainstance.ISurfaceKnitFeatureDataInstance.MinValueForGapRange;
        }
    }
}