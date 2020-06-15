using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRipFeatureDataObject
    {
        public IRipFeatureData IRipFeatureDataInstance { get; set; }
        public IRipFeatureDataObject(IRipFeatureData IRipFeatureDatainstance)
        {
            IRipFeatureDataInstance = IRipFeatureDatainstance;
        }
    }
    public static class IRipFeatureDataInterface
    {
        public static Boolean AccessSelections(IRipFeatureDataObject IRipFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IRipFeatureDatainstance.IRipFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IRipFeatureDataObject IRipFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IRipFeatureDatainstance.IRipFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IRipFeatureDataObject IRipFeatureDatainstance)
        {
            IRipFeatureDatainstance.IRipFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetEdgesCount(IRipFeatureDataObject IRipFeatureDatainstance)
        {
            return IRipFeatureDatainstance.IRipFeatureDataInstance.GetEdgesCount();
        }
        public static Object IGetEdges(IRipFeatureDataObject IRipFeatureDatainstance, Int32 EdgeCount)
        {
            return IRipFeatureDatainstance.IRipFeatureDataInstance.IGetEdges(EdgeCount);
        }
        //public static void ISetEdges(IRipFeatureDataObject IRipFeatureDatainstance, Int32 EdgeCount, Object& EdgeArr)
        //{
        //    return IRipFeatureDatainstance.IRipFeatureDataInstance.ISetEdges(EdgeCount, EdgeArr);
        //}
        public static Int32 GetDirection(IRipFeatureDataObject IRipFeatureDatainstance, Object Edge)
        {
            return IRipFeatureDatainstance.IRipFeatureDataInstance.GetDirection(Edge);
        }
        public static void SetDirection(IRipFeatureDataObject IRipFeatureDatainstance, Object Edge, Int32 Dir)
        {
            IRipFeatureDatainstance.IRipFeatureDataInstance.SetDirection(Edge, Dir);
        }
        public static Object Edges(IRipFeatureDataObject IRipFeatureDatainstance)
        {
            return IRipFeatureDatainstance.IRipFeatureDataInstance.Edges;
        }
        public static Double Gap(IRipFeatureDataObject IRipFeatureDatainstance)
        {
            return IRipFeatureDatainstance.IRipFeatureDataInstance.Gap;
        }
    }
}