using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IReplaceFaceFeatureDataObject
    {
        public IReplaceFaceFeatureData IReplaceFaceFeatureDataInstance { get; set; }
        public IReplaceFaceFeatureDataObject(IReplaceFaceFeatureData IReplaceFaceFeatureDatainstance)
        {
            IReplaceFaceFeatureDataInstance = IReplaceFaceFeatureDatainstance;
        }
    }
    public static class IReplaceFaceFeatureDataInterface
    {
        public static Boolean IAccessSelections(IReplaceFaceFeatureDataObject IReplaceFaceFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IReplaceFaceFeatureDatainstance.IReplaceFaceFeatureDataInstance.IAccessSelections(TopDoc?.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance.CastObj<Component2>());
        }
        public static Boolean AccessSelections(IReplaceFaceFeatureDataObject IReplaceFaceFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IReplaceFaceFeatureDatainstance.IReplaceFaceFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(IReplaceFaceFeatureDataObject IReplaceFaceFeatureDatainstance)
        {
            IReplaceFaceFeatureDatainstance.IReplaceFaceFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetReplacementSurfacesCount(IReplaceFaceFeatureDataObject IReplaceFaceFeatureDatainstance)
        {
            return IReplaceFaceFeatureDatainstance.IReplaceFaceFeatureDataInstance.GetReplacementSurfacesCount();
        }
        public static IFeatureObject IGetReplacementSurfaces(IReplaceFaceFeatureDataObject IReplaceFaceFeatureDatainstance, Int32 Count)
        {
            return new IFeatureObject(IReplaceFaceFeatureDatainstance.IReplaceFaceFeatureDataInstance.IGetReplacementSurfaces(Count));
        }
        //public static void ISetReplacementSurfaces(IReplaceFaceFeatureDataObject IReplaceFaceFeatureDatainstance, Int32 Count, Feature&Object SurfDisp)
        //{
        //    return IReplaceFaceFeatureDatainstance.IReplaceFaceFeatureDataInstance.ISetReplacementSurfaces(Count, SurfDisp);
        //}
        public static Int32 GetFacesForReplacementCount(IReplaceFaceFeatureDataObject IReplaceFaceFeatureDatainstance)
        {
            return IReplaceFaceFeatureDatainstance.IReplaceFaceFeatureDataInstance.GetFacesForReplacementCount();
        }
        public static IFace2Object IGetFacesForReplacement(IReplaceFaceFeatureDataObject IReplaceFaceFeatureDatainstance, Int32 Count)
        {
            return new IFace2Object(IReplaceFaceFeatureDatainstance.IReplaceFaceFeatureDataInstance.IGetFacesForReplacement(Count));
        }
        //public static void ISetFacesForReplacement(IReplaceFaceFeatureDataObject IReplaceFaceFeatureDatainstance, Int32 Count, Face2&Object SurfDisp)
        //{
        //    return IReplaceFaceFeatureDatainstance.IReplaceFaceFeatureDataInstance.ISetFacesForReplacement(Count, SurfDisp);
        //}
        public static Object ReplacementSurfaces(IReplaceFaceFeatureDataObject IReplaceFaceFeatureDatainstance)
        {
            return IReplaceFaceFeatureDatainstance.IReplaceFaceFeatureDataInstance.ReplacementSurfaces;
        }
        public static Object FacesForReplacement(IReplaceFaceFeatureDataObject IReplaceFaceFeatureDatainstance)
        {
            return IReplaceFaceFeatureDatainstance.IReplaceFaceFeatureDataInstance.FacesForReplacement;
        }
    }
}