using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISurfaceTrimFeatureDataObject
    {
        public ISurfaceTrimFeatureData ISurfaceTrimFeatureDataInstance { get; set; }
        public ISurfaceTrimFeatureDataObject(ISurfaceTrimFeatureData ISurfaceTrimFeatureDatainstance)
        {
            ISurfaceTrimFeatureDataInstance = ISurfaceTrimFeatureDatainstance;
        }
    }
    public static class ISurfaceTrimFeatureDataInterface
    {
        public static Boolean AccessSelections(ISurfaceTrimFeatureDataObject ISurfaceTrimFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISurfaceTrimFeatureDatainstance.ISurfaceTrimFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ISurfaceTrimFeatureDataObject ISurfaceTrimFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISurfaceTrimFeatureDatainstance.ISurfaceTrimFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISurfaceTrimFeatureDataObject ISurfaceTrimFeatureDatainstance)
        {
            ISurfaceTrimFeatureDatainstance.ISurfaceTrimFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetType(ISurfaceTrimFeatureDataObject ISurfaceTrimFeatureDatainstance)
        {
            return ISurfaceTrimFeatureDatainstance.ISurfaceTrimFeatureDataInstance.GetType();
        }
        public static Int32 GetTrimToolsCount(ISurfaceTrimFeatureDataObject ISurfaceTrimFeatureDatainstance)
        {
            return ISurfaceTrimFeatureDatainstance.ISurfaceTrimFeatureDataInstance.GetTrimToolsCount();
        }
        public static Object IGetTrimTools(ISurfaceTrimFeatureDataObject ISurfaceTrimFeatureDatainstance, Int32 Count)
        {
            return ISurfaceTrimFeatureDatainstance.ISurfaceTrimFeatureDataInstance.IGetTrimTools(Count);
        }
        //public static void ISetTrimTools(ISurfaceTrimFeatureDataObject ISurfaceTrimFeatureDatainstance, Int32 Count, Object& DispArr)
        //{
        //    return ISurfaceTrimFeatureDatainstance.ISurfaceTrimFeatureDataInstance.ISetTrimTools(Count, DispArr);
        //}
        public static Int32 GetPiecesToKeepCount(ISurfaceTrimFeatureDataObject ISurfaceTrimFeatureDatainstance)
        {
            return ISurfaceTrimFeatureDatainstance.ISurfaceTrimFeatureDataInstance.GetPiecesToKeepCount();
        }
        public static IBody2Object IGetPiecesToKeep(ISurfaceTrimFeatureDataObject ISurfaceTrimFeatureDatainstance, Int32 Count)
        {
            return new IBody2Object(ISurfaceTrimFeatureDatainstance.ISurfaceTrimFeatureDataInstance.IGetPiecesToKeep(Count));
        }
        //public static void ISetPiecesToKeep(ISurfaceTrimFeatureDataObject ISurfaceTrimFeatureDatainstance, Int32 Count, Body2&Object BodyArr)
        //{
        //    return ISurfaceTrimFeatureDatainstance.ISurfaceTrimFeatureDataInstance.ISetPiecesToKeep(Count, BodyArr);
        //}
        public static Object TrimTools(ISurfaceTrimFeatureDataObject ISurfaceTrimFeatureDatainstance)
        {
            return ISurfaceTrimFeatureDatainstance.ISurfaceTrimFeatureDataInstance.TrimTools;
        }
        public static Object PiecesToKeep(ISurfaceTrimFeatureDataObject ISurfaceTrimFeatureDatainstance)
        {
            return ISurfaceTrimFeatureDatainstance.ISurfaceTrimFeatureDataInstance.PiecesToKeep;
        }
    }
}