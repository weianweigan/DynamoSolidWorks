using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDerivedPartFeatureDataObject
    {
        public IDerivedPartFeatureData IDerivedPartFeatureDataInstance { get; set; }
        public IDerivedPartFeatureDataObject(IDerivedPartFeatureData IDerivedPartFeatureDatainstance)
        {
            IDerivedPartFeatureDataInstance = IDerivedPartFeatureDatainstance;
        }
    }
    public static class IDerivedPartFeatureDataInterface
    {
        public static IFeatureObject GetMoveFeature(IDerivedPartFeatureDataObject IDerivedPartFeatureDatainstance)
        {
            return new IFeatureObject(IDerivedPartFeatureDatainstance.IDerivedPartFeatureDataInstance.GetMoveFeature());
        }
        public static Boolean IAccessSelections(IDerivedPartFeatureDataObject IDerivedPartFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IDerivedPartFeatureDatainstance.IDerivedPartFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static Boolean AccessSelections(IDerivedPartFeatureDataObject IDerivedPartFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IDerivedPartFeatureDatainstance.IDerivedPartFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(IDerivedPartFeatureDataObject IDerivedPartFeatureDatainstance)
        {
            IDerivedPartFeatureDatainstance.IDerivedPartFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static IModelDoc2Object GetModelDoc(IDerivedPartFeatureDataObject IDerivedPartFeatureDatainstance)
        {
            return new IModelDoc2Object(IDerivedPartFeatureDatainstance.IDerivedPartFeatureDataInstance.GetModelDoc());
        }
        public static Boolean ImportPlane(IDerivedPartFeatureDataObject IDerivedPartFeatureDatainstance)
        {
            return IDerivedPartFeatureDatainstance.IDerivedPartFeatureDataInstance.ImportPlane;
        }
        public static Boolean ImportAxis(IDerivedPartFeatureDataObject IDerivedPartFeatureDatainstance)
        {
            return IDerivedPartFeatureDatainstance.IDerivedPartFeatureDataInstance.ImportAxis;
        }
        public static Boolean ImportCThread(IDerivedPartFeatureDataObject IDerivedPartFeatureDatainstance)
        {
            return IDerivedPartFeatureDatainstance.IDerivedPartFeatureDataInstance.ImportCThread;
        }
        public static Boolean ImportSurf(IDerivedPartFeatureDataObject IDerivedPartFeatureDatainstance)
        {
            return IDerivedPartFeatureDatainstance.IDerivedPartFeatureDataInstance.ImportSurf;
        }
        public static Boolean ImportAbsorbedSketches(IDerivedPartFeatureDataObject IDerivedPartFeatureDatainstance)
        {
            return IDerivedPartFeatureDatainstance.IDerivedPartFeatureDataInstance.ImportAbsorbedSketches;
        }
        public static Boolean ImportUnAbsorbedSketches(IDerivedPartFeatureDataObject IDerivedPartFeatureDatainstance)
        {
            return IDerivedPartFeatureDatainstance.IDerivedPartFeatureDataInstance.ImportUnAbsorbedSketches;
        }
        public static String PathName(IDerivedPartFeatureDataObject IDerivedPartFeatureDatainstance)
        {
            return IDerivedPartFeatureDatainstance.IDerivedPartFeatureDataInstance.PathName;
        }
    }
}