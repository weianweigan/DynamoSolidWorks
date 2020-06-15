using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IClosedCornerFeatureDataObject
    {
        public IClosedCornerFeatureData IClosedCornerFeatureDataInstance { get; set; }
        public IClosedCornerFeatureDataObject(IClosedCornerFeatureData IClosedCornerFeatureDatainstance)
        {
            IClosedCornerFeatureDataInstance = IClosedCornerFeatureDatainstance;
        }
    }
    public static class IClosedCornerFeatureDataInterface
    {
        public static Boolean AccessSelections(IClosedCornerFeatureDataObject IClosedCornerFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IClosedCornerFeatureDatainstance.IClosedCornerFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IClosedCornerFeatureDataObject IClosedCornerFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IClosedCornerFeatureDatainstance.IClosedCornerFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static void ReleaseSelectionAccess(IClosedCornerFeatureDataObject IClosedCornerFeatureDatainstance)
        {
            IClosedCornerFeatureDatainstance.IClosedCornerFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 IGetFacesCount(IClosedCornerFeatureDataObject IClosedCornerFeatureDatainstance)
        {
            return IClosedCornerFeatureDatainstance.IClosedCornerFeatureDataInstance.IGetFacesCount();
        }
        public static Object IGetFaces(IClosedCornerFeatureDataObject IClosedCornerFeatureDatainstance)
        {
            return IClosedCornerFeatureDatainstance.IClosedCornerFeatureDataInstance.IGetFaces();
        }
        //ref not solve
        public static void ISetFaces(IClosedCornerFeatureDataObject IClosedCornerFeatureDatainstance, Int32 FaceCount, Object FaceArray)
        {
            IClosedCornerFeatureDatainstance.IClosedCornerFeatureDataInstance.ISetFaces(FaceCount, FaceArray);
        }
        public static Boolean IAccessSelections2(IClosedCornerFeatureDataObject IClosedCornerFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IClosedCornerFeatureDatainstance.IClosedCornerFeatureDataInstance.IAccessSelections2(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static Object Faces(IClosedCornerFeatureDataObject IClosedCornerFeatureDatainstance)
        {
            return IClosedCornerFeatureDatainstance.IClosedCornerFeatureDataInstance.Faces;
        }
        public static Int32 CornerType(IClosedCornerFeatureDataObject IClosedCornerFeatureDatainstance)
        {
            return IClosedCornerFeatureDatainstance.IClosedCornerFeatureDataInstance.CornerType;
        }
        public static Double GapDistance(IClosedCornerFeatureDataObject IClosedCornerFeatureDatainstance)
        {
            return IClosedCornerFeatureDatainstance.IClosedCornerFeatureDataInstance.GapDistance;
        }
        public static Double OverlapUnderlapRatio(IClosedCornerFeatureDataObject IClosedCornerFeatureDatainstance)
        {
            return IClosedCornerFeatureDatainstance.IClosedCornerFeatureDataInstance.OverlapUnderlapRatio;
        }
        public static Boolean OpenBendRegion(IClosedCornerFeatureDataObject IClosedCornerFeatureDatainstance)
        {
            return IClosedCornerFeatureDatainstance.IClosedCornerFeatureDataInstance.OpenBendRegion;
        }
    }
}