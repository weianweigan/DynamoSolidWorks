using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISplitBodyFeatureDataObject
    {
        public ISplitBodyFeatureData ISplitBodyFeatureDataInstance { get; set; }
        public ISplitBodyFeatureDataObject(ISplitBodyFeatureData ISplitBodyFeatureDatainstance)
        {
            ISplitBodyFeatureDataInstance = ISplitBodyFeatureDatainstance;
        }
    }
    public static class ISplitBodyFeatureDataInterface
    {
        public static Boolean AccessSelections(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance)
        {
            ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetTrimToolsCount(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance)
        {
            return ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.GetTrimToolsCount();
        }
        public static Object IGetTrimTools(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance, Int32 Count)
        {
            return ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.IGetTrimTools(Count);
        }
        //public static void ISetTrimTools(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance, Int32 Count, Object& DispArr)
        //{
        //    return ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.ISetTrimTools(Count, DispArr);
        //}
        //public static void GetSplitBodies(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance, Object& BodyVar, Object& PathVar, Object& FlagVar)
        //{
        //    return ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.GetSplitBodies(BodyVar, PathVar, FlagVar);
        //}
        public static void SetSplitBodies(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance, Object PathVar, Object FlagVar)
        {
            ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.SetSplitBodies(PathVar, FlagVar);
        }
        public static Int32 GetSplitBodiesCount(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance)
        {
            return ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.GetSplitBodiesCount();
        }
        //public static void IGetSplitBodies(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance, Int32 Count, Body2&Object BodyArr, String& PathArr, Boolean& FlagArr)
        //{
        //    return ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.IGetSplitBodies(Count, BodyArr, PathArr, FlagArr);
        //}
        //public static void ISetSplitBodies(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance, Int32 Count, String& PathArr, Boolean& FlagArr)
        //{
        //    return ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.ISetSplitBodies(Count, PathArr, FlagArr);
        //}
        public static void SetSplitBodies2(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance, Object PathVar, Object FlagVar, Object BodyOrigin)
        {
            ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.SetSplitBodies2(PathVar, FlagVar, BodyOrigin);
        }
        public static Object TrimTools(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance)
        {
            return ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.TrimTools;
        }
        public static Int32 State(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance)
        {
            return ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.State;
        }
        public static Boolean Consume(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance)
        {
            return ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.Consume;
        }
        public static String TemplatePath(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance)
        {
            return ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.TemplatePath;
        }
        public static Boolean OverrideDefaultTemplateSettings(ISplitBodyFeatureDataObject ISplitBodyFeatureDatainstance)
        {
            return ISplitBodyFeatureDatainstance.ISplitBodyFeatureDataInstance.OverrideDefaultTemplateSettings;
        }
    }
}