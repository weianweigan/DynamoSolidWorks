using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISurfaceOffsetFeatureDataObject
    {
        public ISurfaceOffsetFeatureData ISurfaceOffsetFeatureDataInstance { get; set; }
        public ISurfaceOffsetFeatureDataObject(ISurfaceOffsetFeatureData ISurfaceOffsetFeatureDatainstance)
        {
            ISurfaceOffsetFeatureDataInstance = ISurfaceOffsetFeatureDatainstance;
        }
    }
    public static class ISurfaceOffsetFeatureDataInterface
    {
        public static Int32 GetFacesCount(ISurfaceOffsetFeatureDataObject ISurfaceOffsetFeatureDatainstance)
        {
            return ISurfaceOffsetFeatureDatainstance.ISurfaceOffsetFeatureDataInstance.GetFacesCount();
        }
        public static IFace2Object IGetFaces(ISurfaceOffsetFeatureDataObject ISurfaceOffsetFeatureDatainstance, Int32 Count)
        {
            return new IFace2Object(ISurfaceOffsetFeatureDatainstance.ISurfaceOffsetFeatureDataInstance.IGetFaces(Count));
        }
        //public static void ISetFaces(ISurfaceOffsetFeatureDataObject ISurfaceOffsetFeatureDatainstance, Int32 Count, Face2&Object FaceArr)
        //{
        //    return ISurfaceOffsetFeatureDatainstance.ISurfaceOffsetFeatureDataInstance.ISetFaces(Count, FaceArr);
        //}
        public static Boolean AccessSelections(ISurfaceOffsetFeatureDataObject ISurfaceOffsetFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISurfaceOffsetFeatureDatainstance.ISurfaceOffsetFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ISurfaceOffsetFeatureDataObject ISurfaceOffsetFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISurfaceOffsetFeatureDatainstance.ISurfaceOffsetFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISurfaceOffsetFeatureDataObject ISurfaceOffsetFeatureDatainstance)
        {
            ISurfaceOffsetFeatureDatainstance.ISurfaceOffsetFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetEntitiesCount(ISurfaceOffsetFeatureDataObject ISurfaceOffsetFeatureDatainstance)
        {
            return ISurfaceOffsetFeatureDatainstance.ISurfaceOffsetFeatureDataInstance.GetEntitiesCount();
        }
        public static Object IGetEntities(ISurfaceOffsetFeatureDataObject ISurfaceOffsetFeatureDatainstance, Int32 Count)
        {
            return ISurfaceOffsetFeatureDatainstance.ISurfaceOffsetFeatureDataInstance.IGetEntities(Count);
        }
        //public static void ISetEntities(ISurfaceOffsetFeatureDataObject ISurfaceOffsetFeatureDatainstance, Int32 Count, Object& EntityArray)
        //{
        //    return ISurfaceOffsetFeatureDatainstance.ISurfaceOffsetFeatureDataInstance.ISetEntities(Count, EntityArray);
        //}
        public static Object Faces(ISurfaceOffsetFeatureDataObject ISurfaceOffsetFeatureDatainstance)
        {
            return ISurfaceOffsetFeatureDatainstance.ISurfaceOffsetFeatureDataInstance.Faces;
        }
        public static Double Distance(ISurfaceOffsetFeatureDataObject ISurfaceOffsetFeatureDatainstance)
        {
            return ISurfaceOffsetFeatureDatainstance.ISurfaceOffsetFeatureDataInstance.Distance;
        }
        public static Boolean Flip(ISurfaceOffsetFeatureDataObject ISurfaceOffsetFeatureDatainstance)
        {
            return ISurfaceOffsetFeatureDatainstance.ISurfaceOffsetFeatureDataInstance.Flip;
        }
        public static Object Entities(ISurfaceOffsetFeatureDataObject ISurfaceOffsetFeatureDatainstance)
        {
            return ISurfaceOffsetFeatureDatainstance.ISurfaceOffsetFeatureDataInstance.Entities;
        }
    }
}