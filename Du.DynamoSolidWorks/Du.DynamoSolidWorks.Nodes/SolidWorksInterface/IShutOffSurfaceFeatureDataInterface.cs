using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IShutOffSurfaceFeatureDataObject
    {
        public IShutOffSurfaceFeatureData IShutOffSurfaceFeatureDataInstance { get; set; }
        public IShutOffSurfaceFeatureDataObject(IShutOffSurfaceFeatureData IShutOffSurfaceFeatureDatainstance)
        {
            IShutOffSurfaceFeatureDataInstance = IShutOffSurfaceFeatureDatainstance;
        }
    }
    public static class IShutOffSurfaceFeatureDataInterface
    {
        public static Boolean AccessSelections(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance)
        {
            IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetEdgeCount(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance)
        {
            return IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.GetEdgeCount();
        }
        public static IEdgeObject IGetEdges(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance, Int32 Count)
        {
            return new IEdgeObject(IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.IGetEdges(Count));
        }
        //public static void ISetEdges(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance, Int32 Count, Edge&Object EdgeArr)
        //{
        //    return IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.ISetEdges(Count, EdgeArr);
        //}
        public static Int32 GetLoopCount(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance)
        {
            return IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.GetLoopCount();
        }
        public static Int32 GetLoopEdgeCount(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance, Int32 Index)
        {
            return IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.GetLoopEdgeCount(Index);
        }
        public static IEdgeObject IGetLoopEdges(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance, Int32 Index, Int32 Count)
        {
            return new IEdgeObject(IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.IGetLoopEdges(Index, Count));
        }
        public static IFace2Object GetFaceTangentTo(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance, Int32 Index)
        {
            return new IFace2Object(IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.GetFaceTangentTo(Index));
        }
        public static void FlipFaceTangentTo(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance, Int32 Index)
        {
            IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.FlipFaceTangentTo(Index);
        }
        public static Int32 Status(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance)
        {
            return IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.Status();
        }
        public static void SetAllPatchTypes(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance, Int32 Type)
        {
            IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.SetAllPatchTypes(Type);
        }
        public static Object Edges(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance)
        {
            return IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.Edges;
        }
        public static Object LoopEdges(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance, int Index)
        {
            return IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.LoopEdges[Index];
        }
        public static Int32 LoopPatchType(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance, int Index)
        {
            return IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.LoopPatchType[Index];
        }
        public static Boolean Knit(IShutOffSurfaceFeatureDataObject IShutOffSurfaceFeatureDatainstance)
        {
            return IShutOffSurfaceFeatureDatainstance.IShutOffSurfaceFeatureDataInstance.Knit;
        }
    }
}