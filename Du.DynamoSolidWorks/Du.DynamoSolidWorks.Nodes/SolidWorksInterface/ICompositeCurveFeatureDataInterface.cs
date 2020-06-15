using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICompositeCurveFeatureDataObject
    {
        public ICompositeCurveFeatureData ICompositeCurveFeatureDataInstance { get; set; }
        public ICompositeCurveFeatureDataObject(ICompositeCurveFeatureData ICompositeCurveFeatureDatainstance)
        {
            ICompositeCurveFeatureDataInstance = ICompositeCurveFeatureDatainstance;
        }
    }
    public static class ICompositeCurveFeatureDataInterface
    {
        public static Boolean AccessSelections(ICompositeCurveFeatureDataObject ICompositeCurveFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ICompositeCurveFeatureDatainstance.ICompositeCurveFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(ICompositeCurveFeatureDataObject ICompositeCurveFeatureDatainstance)
        {
            ICompositeCurveFeatureDatainstance.ICompositeCurveFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetEntitiesToJoinCount(ICompositeCurveFeatureDataObject ICompositeCurveFeatureDatainstance)
        {
            return ICompositeCurveFeatureDatainstance.ICompositeCurveFeatureDataInstance.GetEntitiesToJoinCount();
        }
        //public static Object GetEntitiesToJoin(ICompositeCurveFeatureDataObject ICompositeCurveFeatureDatainstance, Object& Type)
        //{
        //    return ICompositeCurveFeatureDatainstance.ICompositeCurveFeatureDataInstance.GetEntitiesToJoin(Type);
        //}
        public static void SetEntitiesToJoin(ICompositeCurveFeatureDataObject ICompositeCurveFeatureDatainstance, Object EntVar)
        {
            ICompositeCurveFeatureDatainstance.ICompositeCurveFeatureDataInstance.SetEntitiesToJoin(EntVar);
        }
        //public static Object IGetEntitiesToJoin(ICompositeCurveFeatureDataObject ICompositeCurveFeatureDatainstance, Int32 Count, Int32& Type)
        //{
        //    return ICompositeCurveFeatureDatainstance.ICompositeCurveFeatureDataInstance.IGetEntitiesToJoin(Count, Type);
        //}
        //public static void ISetEntitiesToJoin(ICompositeCurveFeatureDataObject ICompositeCurveFeatureDatainstance, Int32 Count, Object& Ents)
        //{
        //    return ICompositeCurveFeatureDatainstance.ICompositeCurveFeatureDataInstance.ISetEntitiesToJoin(Count, Ents);
        //}
    }
}