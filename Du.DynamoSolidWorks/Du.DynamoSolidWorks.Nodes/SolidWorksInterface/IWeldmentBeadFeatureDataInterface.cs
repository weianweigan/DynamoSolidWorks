using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IWeldmentBeadFeatureDataObject
    {
        public IWeldmentBeadFeatureData IWeldmentBeadFeatureDataInstance { get; set; }
        public IWeldmentBeadFeatureDataObject(IWeldmentBeadFeatureData IWeldmentBeadFeatureDatainstance)
        {
            IWeldmentBeadFeatureDataInstance = IWeldmentBeadFeatureDatainstance;
        }
    }
    public static class IWeldmentBeadFeatureDataInterface
    {
        public static Boolean AccessSelections(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance, IModelDoc2Object PTopDoc, IComponent2Object PComponent)
        {
            return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.AccessSelections(PTopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), PComponent?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance)
        {
            IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.ReleaseSelectionAccess();
        }
        //public static void GetFaces(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance, Int32 Side, Object& FaceSet1, Object& FaceSet2)
        //{
        //    return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.GetFaces(Side, FaceSet1, FaceSet2);
        //}
        public static Boolean SetFaces(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance, Int32 Side, Object FaceSet1, Object FaceSet2)
        {
            return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.SetFaces(Side, FaceSet1, FaceSet2);
        }
        //public static void GetFacesCount(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance, Int32 Side, Int32& FaceSet1Count, Int32& FaceSet2Count)
        //{
        //    return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.GetFacesCount(Side, FaceSet1Count, FaceSet2Count);
        //}
        //public static void IGetFaces(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance, Int32 Side, Int32 Count1, Face2&Object FaceSet1, Int32 Count2, Face2&Object FaceSet2)
        //{
        //    return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.IGetFaces(Side, Count1, FaceSet1, Count2, FaceSet2);
        //}
        //public static Boolean ISetFaces(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance, Int32 Side, Int32 Count1, Face2&Object FaceSet1, Int32 Count2, Face2&Object FaceSet2)
        //{
        //    return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.ISetFaces(Side, Count1, FaceSet1, Count2, FaceSet2);
        //}
        public static Int32 GetVirtualEdgesCount(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance, Boolean FromFeature, Int32 Side)
        {
            return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.GetVirtualEdgesCount(FromFeature, Side);
        }
        public static Object GetVirtualEdges(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance, Boolean FromFeature, Int32 Side)
        {
            return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.GetVirtualEdges(FromFeature, Side);
        }
        public static void SetVirtualEdges(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance, Int32 Side, Object EdgesIn)
        {
            IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.SetVirtualEdges(Side, EdgesIn);
        }
        public static IEdgeObject IGetVirtualEdges(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance, Boolean FromFeature, Int32 Side, Int32 Count)
        {
            return new IEdgeObject(IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.IGetVirtualEdges(FromFeature, Side, Count));
        }
        //public static void ISetVirtualEdges(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance, Int32 Side, Int32 Count, Edge&Object EdgesIn)
        //{
        //    return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.ISetVirtualEdges(Side, Count, EdgesIn);
        //}
        //public static Int32 BeadType(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance)
        //{
        //    return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.BeadType;
        //}
        //public static Double BeadSize(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance)
        //{
        //    return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.BeadSize;
        //}
        //public static Double BeadLength(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance)
        //{
        //    return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.BeadLength;
        //}
        //public static Double BeadPitch(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance)
        //{
        //    return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.BeadPitch;
        //}
        public static Boolean TangentPropagation(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance)
        {
            return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.TangentPropagation;
        }
        public static Boolean UseOtherSide(IWeldmentBeadFeatureDataObject IWeldmentBeadFeatureDatainstance)
        {
            return IWeldmentBeadFeatureDatainstance.IWeldmentBeadFeatureDataInstance.UseOtherSide;
        }
    }
}