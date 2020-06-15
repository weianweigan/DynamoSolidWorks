using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDeleteFaceFeatureDataObject
    {
        public IDeleteFaceFeatureData IDeleteFaceFeatureDataInstance { get; set; }
        public IDeleteFaceFeatureDataObject(IDeleteFaceFeatureData IDeleteFaceFeatureDatainstance)
        {
            IDeleteFaceFeatureDataInstance = IDeleteFaceFeatureDatainstance;
        }
    }
    public static class IDeleteFaceFeatureDataInterface
    {
        public static Boolean IAccessSelections(IDeleteFaceFeatureDataObject IDeleteFaceFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IDeleteFaceFeatureDatainstance.IDeleteFaceFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static Boolean AccessSelections(IDeleteFaceFeatureDataObject IDeleteFaceFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IDeleteFaceFeatureDatainstance.IDeleteFaceFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(IDeleteFaceFeatureDataObject IDeleteFaceFeatureDatainstance)
        {
            IDeleteFaceFeatureDatainstance.IDeleteFaceFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetDeletedFacesCount(IDeleteFaceFeatureDataObject IDeleteFaceFeatureDatainstance)
        {
            return IDeleteFaceFeatureDatainstance.IDeleteFaceFeatureDataInstance.GetDeletedFacesCount();
        }
        public static IFace2Object IGetDeletedFaces(IDeleteFaceFeatureDataObject IDeleteFaceFeatureDatainstance, Int32 Count)
        {
            return new IFace2Object(IDeleteFaceFeatureDatainstance.IDeleteFaceFeatureDataInstance.IGetDeletedFaces(Count));
        }
        public static Object GetDeletedFaces(IDeleteFaceFeatureDataObject IDeleteFaceFeatureDatainstance)
        {
            return IDeleteFaceFeatureDatainstance.IDeleteFaceFeatureDataInstance.GetDeletedFaces();
        }
        //public static Boolean ISetDeletedFaces(IDeleteFaceFeatureDataObject IDeleteFaceFeatureDatainstance, Int32 Count, Face2&Object Facedisp)
        //{
        //    return IDeleteFaceFeatureDatainstance.IDeleteFaceFeatureDataInstance.ISetDeletedFaces(Count, Facedisp);
        //}
        public static Boolean SetDeletedFaces(IDeleteFaceFeatureDataObject IDeleteFaceFeatureDatainstance, Object Faces)
        {
            return IDeleteFaceFeatureDatainstance.IDeleteFaceFeatureDataInstance.SetDeletedFaces(Faces);
        }
        public static Int32 Options(IDeleteFaceFeatureDataObject IDeleteFaceFeatureDatainstance)
        {
            return IDeleteFaceFeatureDatainstance.IDeleteFaceFeatureDataInstance.Options;
        }
    }
}