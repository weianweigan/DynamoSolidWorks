using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISimpleFilletFeatureDataObject
    {
        public ISimpleFilletFeatureData ISimpleFilletFeatureDataInstance { get; set; }
        public ISimpleFilletFeatureDataObject(ISimpleFilletFeatureData ISimpleFilletFeatureDatainstance)
        {
            ISimpleFilletFeatureDataInstance = ISimpleFilletFeatureDatainstance;
        }
    }
    public static class ISimpleFilletFeatureDataInterface
    {
        public static Object GetFilletItemAtIndex(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance, Int32 Index)
        {
            return ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.GetFilletItemAtIndex(Index);
        }
        public static Object IGetFilletItemAtIndex(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance, Int32 Index)
        {
            return ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.IGetFilletItemAtIndex(Index);
        }
        public static Double GetRadius(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance, Object PFilletItem)
        {
            return ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.GetRadius(PFilletItem);
        }
        public static Double IGetRadius(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance, Object PFilletItem)
        {
            return ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.IGetRadius(PFilletItem);
        }
        public static void SetRadius(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance, Object PFilletItem, Double Radius)
        {
            ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.SetRadius(PFilletItem, Radius);
        }
        public static void ISetRadius(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance, Object PFilletItem, Double Radius)
        {
            ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.ISetRadius(PFilletItem, Radius);
        }
        public static Boolean AccessSelections(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance?.CastObj<ModelDoc>(), Component?.IComponentInstance?.CastObj<Component>());
        }
        public static void ReleaseSelectionAccess(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance)
        {
            ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 Type(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance)
        {
            return ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.Type;
        }
        public static Double DefaultRadius(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance)
        {
            return ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.DefaultRadius;
        }
        public static Int32 OverflowType(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance)
        {
            return ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.OverflowType;
        }
        public static Boolean IsMultipleRadius(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance)
        {
            return ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.IsMultipleRadius;
        }
        public static Boolean RoundCorners(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance)
        {
            return ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.RoundCorners;
        }
        public static Boolean PropagateToTangentFaces(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance)
        {
            return ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.PropagateToTangentFaces;
        }
        public static Int32 FilletItemsCount(ISimpleFilletFeatureDataObject ISimpleFilletFeatureDatainstance)
        {
            return ISimpleFilletFeatureDatainstance.ISimpleFilletFeatureDataInstance.FilletItemsCount;
        }
    }
}