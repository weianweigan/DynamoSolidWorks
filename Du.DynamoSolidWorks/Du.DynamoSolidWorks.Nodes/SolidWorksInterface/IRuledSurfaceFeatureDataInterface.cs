using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRuledSurfaceFeatureDataObject
    {
        public IRuledSurfaceFeatureData IRuledSurfaceFeatureDataInstance { get; set; }
        public IRuledSurfaceFeatureDataObject(IRuledSurfaceFeatureData IRuledSurfaceFeatureDatainstance)
        {
            IRuledSurfaceFeatureDataInstance = IRuledSurfaceFeatureDatainstance;
        }
    }
    public static class IRuledSurfaceFeatureDataInterface
    {
        public static Boolean AccessSelections(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance)
        {
            IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.ReleaseSelectionAccess();
        }
        //public static Int32 GetDirectionReference(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance, Object& Ref1, Int32& Type1, Object& Ref2, Int32& Type2)
        //{
        //    return IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.GetDirectionReference(Ref1, Type1, Ref2, Type2);
        //}
        public static void SetDirectionReference(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance, Object Ref1, Object Ref2)
        {
            IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.SetDirectionReference(Ref1, Ref2);
        }
        //public static void GetEdges(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance, Object& Edges, Object& SideFlags)
        //{
        //    return IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.GetEdges(Edges, SideFlags);
        //}
        public static void SetEdges(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance, Object Edges, Object SideFlags)
        {
            IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.SetEdges(Edges, SideFlags);
        }
        public static Int32 GetEdgesCount(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance)
        {
            return IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.GetEdgesCount();
        }
        //public static void IGetEdges(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance, Int32 Count, Object& Entities, Int32& SideFlags)
        //{
        //    return IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.IGetEdges(Count, Entities, SideFlags);
        //}
        //public static void ISetEdges(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance, Int32 Count, Object& Entities, Int32& SideFlags)
        //{
        //    return IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.ISetEdges(Count, Entities, SideFlags);
        //}
        public static Int32 Type(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance)
        {
            return IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.Type;
        }
        public static Double Distance(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance)
        {
            return IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.Distance;
        }
        public static Double Angle(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance)
        {
            return IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.Angle;
        }
        public static Boolean UseVector(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance)
        {
            return IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.UseVector;
        }
        public static Boolean TrimAndKnit(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance)
        {
            return IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.TrimAndKnit;
        }
        public static Boolean Connect(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance)
        {
            return IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.Connect;
        }
        public static IMathVectorObject DirectionVector(IRuledSurfaceFeatureDataObject IRuledSurfaceFeatureDatainstance)
        {
            return new IMathVectorObject(IRuledSurfaceFeatureDatainstance.IRuledSurfaceFeatureDataInstance.DirectionVector);
        }
    }
}