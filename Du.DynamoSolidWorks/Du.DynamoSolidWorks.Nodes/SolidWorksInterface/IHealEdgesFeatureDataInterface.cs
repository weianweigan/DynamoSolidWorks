using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IHealEdgesFeatureDataObject
    {
        public IHealEdgesFeatureData IHealEdgesFeatureDataInstance { get; set; }
        public IHealEdgesFeatureDataObject(IHealEdgesFeatureData IHealEdgesFeatureDatainstance)
        {
            IHealEdgesFeatureDataInstance = IHealEdgesFeatureDatainstance;
        }
    }
    public static class IHealEdgesFeatureDataInterface
    {
        public static Boolean AccessSelections(IHealEdgesFeatureDataObject IHealEdgesFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IHealEdgesFeatureDatainstance.IHealEdgesFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IHealEdgesFeatureDataObject IHealEdgesFeatureDatainstance)
        {
            IHealEdgesFeatureDatainstance.IHealEdgesFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetFacesCount(IHealEdgesFeatureDataObject IHealEdgesFeatureDatainstance)
        {
            return IHealEdgesFeatureDatainstance.IHealEdgesFeatureDataInstance.GetFacesCount();
        }
        public static IFace2Object IGetFaces(IHealEdgesFeatureDataObject IHealEdgesFeatureDatainstance, Int32 Count)
        {
            return new IFace2Object(IHealEdgesFeatureDatainstance.IHealEdgesFeatureDataInstance.IGetFaces(Count));
        }
        //public static void ISetFaces(IHealEdgesFeatureDataObject IHealEdgesFeatureDatainstance, Int32 Count, Face2&Object EntIn)
        //{
        //    return IHealEdgesFeatureDatainstance.IHealEdgesFeatureDataInstance.ISetFaces(Count, EntIn);
        //}
        public static void HealEdges(IHealEdgesFeatureDataObject IHealEdgesFeatureDatainstance)
        {
            IHealEdgesFeatureDatainstance.IHealEdgesFeatureDataInstance.HealEdges();
        }
        //public static void GetEdgeInformation(IHealEdgesFeatureDataObject IHealEdgesFeatureDatainstance, Int32& EdgeCountBefore, Int32& EdgeCountAfter)
        //{
        //    return IHealEdgesFeatureDatainstance.IHealEdgesFeatureDataInstance.GetEdgeInformation(EdgeCountBefore, EdgeCountAfter);
        //}
        public static Object Faces(IHealEdgesFeatureDataObject IHealEdgesFeatureDatainstance)
        {
            return IHealEdgesFeatureDatainstance.IHealEdgesFeatureDataInstance.Faces;
        }
        public static Double AngularTolerance(IHealEdgesFeatureDataObject IHealEdgesFeatureDatainstance)
        {
            return IHealEdgesFeatureDatainstance.IHealEdgesFeatureDataInstance.AngularTolerance;
        }
        public static Double EdgeLengthTolerance(IHealEdgesFeatureDataObject IHealEdgesFeatureDatainstance)
        {
            return IHealEdgesFeatureDatainstance.IHealEdgesFeatureDataInstance.EdgeLengthTolerance;
        }
    }
}