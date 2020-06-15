using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IToolingSplitFeatureDataObject
    {
        public IToolingSplitFeatureData IToolingSplitFeatureDataInstance { get; set; }
        public IToolingSplitFeatureDataObject(IToolingSplitFeatureData IToolingSplitFeatureDatainstance)
        {
            IToolingSplitFeatureDataInstance = IToolingSplitFeatureDatainstance;
        }
    }
    public static class IToolingSplitFeatureDataInterface
    {
        public static Boolean AccessSelections(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance)
        {
            IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetCoreSurfacesCount(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance)
        {
            return IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.GetCoreSurfacesCount();
        }
        public static IBody2Object IGetCoreSurfaces(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance, Int32 Count)
        {
            return new IBody2Object(IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.IGetCoreSurfaces(Count));
        }
        //public static void ISetCoreSurfaces(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance, Int32 Count, Body2&Object BodyArr)
        //{
        //    return IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.ISetCoreSurfaces(Count, BodyArr);
        //}
        public static Int32 GetCavitySurfacesCount(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance)
        {
            return IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.GetCavitySurfacesCount();
        }
        public static IBody2Object IGetCavitySurfaces(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance, Int32 Count)
        {
            return new IBody2Object(IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.IGetCavitySurfaces(Count));
        }
        //public static void ISetCavitySurfaces(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance, Int32 Count, Body2&Object BodyArr)
        //{
        //    return IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.ISetCavitySurfaces(Count, BodyArr);
        //}
        public static Int32 GetPartingSurfacesCount(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance)
        {
            return IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.GetPartingSurfacesCount();
        }
        public static IBody2Object IGetPartingSurfaces(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance, Int32 Count)
        {
            return new IBody2Object(IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.IGetPartingSurfaces(Count));
        }
        //public static void ISetPartingSurfaces(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance, Int32 Count, Body2&Object BodyArr)
        //{
        //    return IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.ISetPartingSurfaces(Count, BodyArr);
        //}
        public static Double Depth(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance, int Dir)
        {
            return IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.Depth[Dir];
        }
        public static Boolean InterlockSurface(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance)
        {
            return IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.InterlockSurface;
        }
        public static Double Angle(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance)
        {
            return IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.Angle;
        }
        public static Object CoreSurfaces(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance)
        {
            return IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.CoreSurfaces;
        }
        public static Object CavitySurfaces(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance)
        {
            return IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.CavitySurfaces;
        }
        public static Object PartingSurfaces(IToolingSplitFeatureDataObject IToolingSplitFeatureDatainstance)
        {
            return IToolingSplitFeatureDatainstance.IToolingSplitFeatureDataInstance.PartingSurfaces;
        }
    }
}