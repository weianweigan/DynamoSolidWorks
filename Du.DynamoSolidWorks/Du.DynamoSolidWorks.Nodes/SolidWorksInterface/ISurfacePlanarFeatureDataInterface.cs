using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISurfacePlanarFeatureDataObject
    {
        public ISurfacePlanarFeatureData ISurfacePlanarFeatureDataInstance { get; set; }
        public ISurfacePlanarFeatureDataObject(ISurfacePlanarFeatureData ISurfacePlanarFeatureDatainstance)
        {
            ISurfacePlanarFeatureDataInstance = ISurfacePlanarFeatureDatainstance;
        }
    }
    public static class ISurfacePlanarFeatureDataInterface
    {
        public static Boolean AccessSelections(ISurfacePlanarFeatureDataObject ISurfacePlanarFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISurfacePlanarFeatureDatainstance.ISurfacePlanarFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ISurfacePlanarFeatureDataObject ISurfacePlanarFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISurfacePlanarFeatureDatainstance.ISurfacePlanarFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISurfacePlanarFeatureDataObject ISurfacePlanarFeatureDatainstance)
        {
            ISurfacePlanarFeatureDatainstance.ISurfacePlanarFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetBoundingEntitiesCount(ISurfacePlanarFeatureDataObject ISurfacePlanarFeatureDatainstance)
        {
            return ISurfacePlanarFeatureDatainstance.ISurfacePlanarFeatureDataInstance.GetBoundingEntitiesCount();
        }
        public static Object IGetBoundingEntities(ISurfacePlanarFeatureDataObject ISurfacePlanarFeatureDatainstance, Int32 Count)
        {
            return ISurfacePlanarFeatureDatainstance.ISurfacePlanarFeatureDataInstance.IGetBoundingEntities(Count);
        }
        public static Object ISetBoundingEntities(ISurfacePlanarFeatureDataObject ISurfacePlanarFeatureDatainstance, Int32 Count)
        {
            return ISurfacePlanarFeatureDatainstance.ISurfacePlanarFeatureDataInstance.ISetBoundingEntities(Count);
        }
        public static Object BoundingEntities(ISurfacePlanarFeatureDataObject ISurfacePlanarFeatureDatainstance)
        {
            return ISurfacePlanarFeatureDatainstance.ISurfacePlanarFeatureDataInstance.BoundingEntities;
        }
    }
}