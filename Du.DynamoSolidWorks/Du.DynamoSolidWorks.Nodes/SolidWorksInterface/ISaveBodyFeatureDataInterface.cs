using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISaveBodyFeatureDataObject
    {
        public ISaveBodyFeatureData ISaveBodyFeatureDataInstance { get; set; }
        public ISaveBodyFeatureDataObject(ISaveBodyFeatureData ISaveBodyFeatureDatainstance)
        {
            ISaveBodyFeatureDataInstance = ISaveBodyFeatureDatainstance;
        }
    }
    public static class ISaveBodyFeatureDataInterface
    {
        public static Boolean AccessSelections(ISaveBodyFeatureDataObject ISaveBodyFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISaveBodyFeatureDatainstance.ISaveBodyFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISaveBodyFeatureDataObject ISaveBodyFeatureDatainstance)
        {
            ISaveBodyFeatureDatainstance.ISaveBodyFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetSaveBodiesCount(ISaveBodyFeatureDataObject ISaveBodyFeatureDatainstance)
        {
            return ISaveBodyFeatureDatainstance.ISaveBodyFeatureDataInstance.GetSaveBodiesCount();
        }
        //public static void GetSaveBodies(ISaveBodyFeatureDataObject ISaveBodyFeatureDatainstance, Object& Bodies, Object& FilePaths, Object& Flags)
        //{
        //    return ISaveBodyFeatureDatainstance.ISaveBodyFeatureDataInstance.GetSaveBodies(Bodies, FilePaths, Flags);
        //}
        public static Boolean AddSaveBodies(ISaveBodyFeatureDataObject ISaveBodyFeatureDatainstance, Object Bodies, Object FilePaths)
        {
            return ISaveBodyFeatureDatainstance.ISaveBodyFeatureDataInstance.AddSaveBodies(Bodies, FilePaths);
        }
        public static Boolean RemoveSaveBodies(ISaveBodyFeatureDataObject ISaveBodyFeatureDatainstance, Object Bodies)
        {
            return ISaveBodyFeatureDatainstance.ISaveBodyFeatureDataInstance.RemoveSaveBodies(Bodies);
        }
        public static Boolean ConsumeBody(ISaveBodyFeatureDataObject ISaveBodyFeatureDatainstance)
        {
            return ISaveBodyFeatureDatainstance.ISaveBodyFeatureDataInstance.ConsumeBody;
        }
        public static Boolean CopyCustomProperties(ISaveBodyFeatureDataObject ISaveBodyFeatureDatainstance)
        {
            return ISaveBodyFeatureDatainstance.ISaveBodyFeatureDataInstance.CopyCustomProperties;
        }
        public static String AssemblyPath(ISaveBodyFeatureDataObject ISaveBodyFeatureDatainstance)
        {
            return ISaveBodyFeatureDatainstance.ISaveBodyFeatureDataInstance.AssemblyPath;
        }
    }
}