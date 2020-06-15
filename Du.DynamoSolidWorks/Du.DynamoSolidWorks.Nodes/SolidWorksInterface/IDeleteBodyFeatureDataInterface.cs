using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDeleteBodyFeatureDataObject
    {
        public IDeleteBodyFeatureData IDeleteBodyFeatureDataInstance { get; set; }
        public IDeleteBodyFeatureDataObject(IDeleteBodyFeatureData IDeleteBodyFeatureDatainstance)
        {
            IDeleteBodyFeatureDataInstance = IDeleteBodyFeatureDatainstance;
        }
    }
    public static class IDeleteBodyFeatureDataInterface
    {
        public static Boolean AccessSelections(IDeleteBodyFeatureDataObject IDeleteBodyFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IDeleteBodyFeatureDatainstance.IDeleteBodyFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IDeleteBodyFeatureDataObject IDeleteBodyFeatureDatainstance)
        {
            IDeleteBodyFeatureDatainstance.IDeleteBodyFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetBodiesCount(IDeleteBodyFeatureDataObject IDeleteBodyFeatureDatainstance)
        {
            return IDeleteBodyFeatureDatainstance.IDeleteBodyFeatureDataInstance.GetBodiesCount();
        }
        public static IBody2Object IGetBodies(IDeleteBodyFeatureDataObject IDeleteBodyFeatureDatainstance, Int32 Count)
        {
            return new IBody2Object(IDeleteBodyFeatureDatainstance.IDeleteBodyFeatureDataInstance.IGetBodies(Count));
        }
        //public static void ISetBodies(IDeleteBodyFeatureDataObject IDeleteBodyFeatureDatainstance, Int32 Count, Body2&Object Bodies)
        //{
        //    return IDeleteBodyFeatureDatainstance.IDeleteBodyFeatureDataInstance.ISetBodies(Count, Bodies);
        //}
        public static Object Bodies(IDeleteBodyFeatureDataObject IDeleteBodyFeatureDatainstance)
        {
            return IDeleteBodyFeatureDatainstance.IDeleteBodyFeatureDataInstance.Bodies;
        }
        public static Boolean KeepBodies(IDeleteBodyFeatureDataObject IDeleteBodyFeatureDatainstance)
        {
            return IDeleteBodyFeatureDatainstance.IDeleteBodyFeatureDataInstance.KeepBodies;
        }
    }
}