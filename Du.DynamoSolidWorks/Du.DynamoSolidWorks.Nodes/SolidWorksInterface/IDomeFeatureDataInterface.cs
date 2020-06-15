using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDomeFeatureDataObject
    {
        public IDomeFeatureData IDomeFeatureDataInstance { get; set; }
        public IDomeFeatureDataObject(IDomeFeatureData IDomeFeatureDatainstance)
        {
            IDomeFeatureDataInstance = IDomeFeatureDatainstance;
        }
    }
    public static class IDomeFeatureDataInterface
    {
        public static Boolean AccessSelections(IDomeFeatureDataObject IDomeFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IDomeFeatureDatainstance.IDomeFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IDomeFeatureDataObject IDomeFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IDomeFeatureDatainstance.IDomeFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static void ReleaseSelectionAccess(IDomeFeatureDataObject IDomeFeatureDatainstance)
        {
            IDomeFeatureDatainstance.IDomeFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Double Height(IDomeFeatureDataObject IDomeFeatureDatainstance)
        {
            return IDomeFeatureDatainstance.IDomeFeatureDataInstance.Height;
        }
        public static Boolean ReverseDir(IDomeFeatureDataObject IDomeFeatureDatainstance)
        {
            return IDomeFeatureDatainstance.IDomeFeatureDataInstance.ReverseDir;
        }
        public static Boolean Elliptical(IDomeFeatureDataObject IDomeFeatureDatainstance)
        {
            return IDomeFeatureDatainstance.IDomeFeatureDataInstance.Elliptical;
        }
        public static Object Face(IDomeFeatureDataObject IDomeFeatureDatainstance)
        {
            return IDomeFeatureDatainstance.IDomeFeatureDataInstance.Face;
        }
        public static IFaceObject IFace(IDomeFeatureDataObject IDomeFeatureDatainstance)
        {
            return new IFaceObject(IDomeFeatureDatainstance.IDomeFeatureDataInstance.IFace);
        }
    }
}