using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IJoinFeatureDataObject
    {
        public IJoinFeatureData IJoinFeatureDataInstance { get; set; }
        public IJoinFeatureDataObject(IJoinFeatureData IJoinFeatureDatainstance)
        {
            IJoinFeatureDataInstance = IJoinFeatureDatainstance;
        }
    }
    public static class IJoinFeatureDataInterface
    {
        public static Boolean AccessSelections(IJoinFeatureDataObject IJoinFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IJoinFeatureDatainstance.IJoinFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IJoinFeatureDataObject IJoinFeatureDatainstance)
        {
            IJoinFeatureDatainstance.IJoinFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetJoinedPartsCount(IJoinFeatureDataObject IJoinFeatureDatainstance)
        {
            return IJoinFeatureDatainstance.IJoinFeatureDataInstance.GetJoinedPartsCount();
        }
        public static IComponent2Object IGetJoinedParts(IJoinFeatureDataObject IJoinFeatureDatainstance, Int32 Count)
        {
            return new IComponent2Object(IJoinFeatureDatainstance.IJoinFeatureDataInstance.IGetJoinedParts(Count));
        }
        //public static void ISetJoinedParts(IJoinFeatureDataObject IJoinFeatureDatainstance, Int32 Count, Component2&Object Parts)
        //{
        //    return IJoinFeatureDatainstance.IJoinFeatureDataInstance.ISetJoinedParts(Count, Parts);
        //}
        public static Object JoinedParts(IJoinFeatureDataObject IJoinFeatureDatainstance)
        {
            return IJoinFeatureDatainstance.IJoinFeatureDataInstance.JoinedParts;
        }
        public static Boolean HideParts(IJoinFeatureDataObject IJoinFeatureDatainstance)
        {
            return IJoinFeatureDatainstance.IJoinFeatureDataInstance.HideParts;
        }
        public static Boolean ForceSurfaceContact(IJoinFeatureDataObject IJoinFeatureDatainstance)
        {
            return IJoinFeatureDatainstance.IJoinFeatureDataInstance.ForceSurfaceContact;
        }
    }
}