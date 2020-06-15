using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IVariableFilletFeatureDataObject
    {
        public IVariableFilletFeatureData IVariableFilletFeatureDataInstance { get; set; }
        public IVariableFilletFeatureDataObject(IVariableFilletFeatureData IVariableFilletFeatureDatainstance)
        {
            IVariableFilletFeatureDataInstance = IVariableFilletFeatureDatainstance;
        }
    }
    public static class IVariableFilletFeatureDataInterface
    {
        public static Object GetFilletEdgeAtIndex(IVariableFilletFeatureDataObject IVariableFilletFeatureDatainstance, Int32 Index)
        {
            return IVariableFilletFeatureDatainstance.IVariableFilletFeatureDataInstance.GetFilletEdgeAtIndex(Index);
        }
        public static IEdgeObject IGetFilletEdgeAtIndex(IVariableFilletFeatureDataObject IVariableFilletFeatureDatainstance, Int32 Index)
        {
            return new IEdgeObject(IVariableFilletFeatureDatainstance.IVariableFilletFeatureDataInstance.IGetFilletEdgeAtIndex(Index));
        }
        public static Double GetRadius(IVariableFilletFeatureDataObject IVariableFilletFeatureDatainstance, Object PFilletItem)
        {
            return IVariableFilletFeatureDatainstance.IVariableFilletFeatureDataInstance.GetRadius(PFilletItem);
        }
        //public static Double IGetRadius(IVariableFilletFeatureDataObject IVariableFilletFeatureDatainstance, VertexObject PFilletItem)
        //{
        //    return IVariableFilletFeatureDatainstance.IVariableFilletFeatureDataInstance.IGetRadius(PFilletItem);
        //}
        public static void SetRadius(IVariableFilletFeatureDataObject IVariableFilletFeatureDatainstance, Object PFilletItem, Double Radius)
        {
            IVariableFilletFeatureDatainstance.IVariableFilletFeatureDataInstance.SetRadius(PFilletItem, Radius);
        }
        //public static void ISetRadius(IVariableFilletFeatureDataObject IVariableFilletFeatureDatainstance, VertexObject PFilletItem, Double Radius)
        //{
        //    return IVariableFilletFeatureDatainstance.IVariableFilletFeatureDataInstance.ISetRadius(PFilletItem, Radius);
        //}
        public static Boolean AccessSelections(IVariableFilletFeatureDataObject IVariableFilletFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IVariableFilletFeatureDatainstance.IVariableFilletFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IVariableFilletFeatureDataObject IVariableFilletFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IVariableFilletFeatureDatainstance.IVariableFilletFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance?.CastObj<ModelDoc>(), Component?.IComponentInstance?.CastObj<Component>());
        }
        public static void ReleaseSelectionAccess(IVariableFilletFeatureDataObject IVariableFilletFeatureDatainstance)
        {
            IVariableFilletFeatureDatainstance.IVariableFilletFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Double DefaultRadius(IVariableFilletFeatureDataObject IVariableFilletFeatureDatainstance)
        {
            return IVariableFilletFeatureDatainstance.IVariableFilletFeatureDataInstance.DefaultRadius;
        }
        public static Int32 OverflowType(IVariableFilletFeatureDataObject IVariableFilletFeatureDatainstance)
        {
            return IVariableFilletFeatureDatainstance.IVariableFilletFeatureDataInstance.OverflowType;
        }
        public static Int32 TransitionType(IVariableFilletFeatureDataObject IVariableFilletFeatureDatainstance)
        {
            return IVariableFilletFeatureDatainstance.IVariableFilletFeatureDataInstance.TransitionType;
        }
        public static Boolean PropagateToTangentFaces(IVariableFilletFeatureDataObject IVariableFilletFeatureDatainstance)
        {
            return IVariableFilletFeatureDatainstance.IVariableFilletFeatureDataInstance.PropagateToTangentFaces;
        }
        public static Int32 FilletEdgeCount(IVariableFilletFeatureDataObject IVariableFilletFeatureDatainstance)
        {
            return IVariableFilletFeatureDatainstance.IVariableFilletFeatureDataInstance.FilletEdgeCount;
        }
    }
}