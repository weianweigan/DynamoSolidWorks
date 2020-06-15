using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IIntersectFeatureDataObject
    {
        public IIntersectFeatureData IIntersectFeatureDataInstance { get; set; }
        public IIntersectFeatureDataObject(IIntersectFeatureData IIntersectFeatureDatainstance)
        {
            IIntersectFeatureDataInstance = IIntersectFeatureDatainstance;
        }
    }
    public static class IIntersectFeatureDataInterface
    {
        public static Boolean AccessSelections(IIntersectFeatureDataObject IIntersectFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IIntersectFeatureDatainstance.IIntersectFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IIntersectFeatureDataObject IIntersectFeatureDatainstance)
        {
            IIntersectFeatureDatainstance.IIntersectFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetIntersectionsToolsCount(IIntersectFeatureDataObject IIntersectFeatureDatainstance)
        {
            return IIntersectFeatureDatainstance.IIntersectFeatureDataInstance.GetIntersectionsToolsCount();
        }
        public static Object GetIntersectionsTools(IIntersectFeatureDataObject IIntersectFeatureDatainstance)
        {
            return IIntersectFeatureDatainstance.IIntersectFeatureDataInstance.GetIntersectionsTools();
        }
        public static void SetIntersectionsTools(IIntersectFeatureDataObject IIntersectFeatureDatainstance, Object Tools)
        {
            IIntersectFeatureDatainstance.IIntersectFeatureDataInstance.SetIntersectionsTools(Tools);
        }
        public static Int32 GetIntersectionsCount(IIntersectFeatureDataObject IIntersectFeatureDatainstance)
        {
            return IIntersectFeatureDatainstance.IIntersectFeatureDataInstance.GetIntersectionsCount();
        }
        //public static Object GetIntersections(IIntersectFeatureDataObject IIntersectFeatureDatainstance, Object& Excluded)
        //{
        //    return IIntersectFeatureDatainstance.IIntersectFeatureDataInstance.GetIntersections(Excluded);
        //}
        public static void SetIntersections(IIntersectFeatureDataObject IIntersectFeatureDatainstance, Object Intersections)
        {
            IIntersectFeatureDatainstance.IIntersectFeatureDataInstance.SetIntersections(Intersections);
        }
        public static Boolean CapPlanar(IIntersectFeatureDataObject IIntersectFeatureDatainstance)
        {
            return IIntersectFeatureDatainstance.IIntersectFeatureDataInstance.CapPlanar;
        }
        public static Boolean Merge(IIntersectFeatureDataObject IIntersectFeatureDatainstance)
        {
            return IIntersectFeatureDatainstance.IIntersectFeatureDataInstance.Merge;
        }
        public static Boolean Consume(IIntersectFeatureDataObject IIntersectFeatureDatainstance)
        {
            return IIntersectFeatureDatainstance.IIntersectFeatureDataInstance.Consume;
        }
    }
}