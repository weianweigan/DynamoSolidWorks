using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISurfRevolveFeatureDataObject
    {
        public ISurfRevolveFeatureData ISurfRevolveFeatureDataInstance { get; set; }
        public ISurfRevolveFeatureDataObject(ISurfRevolveFeatureData ISurfRevolveFeatureDatainstance)
        {
            ISurfRevolveFeatureDataInstance = ISurfRevolveFeatureDatainstance;
        }
    }
    public static class ISurfRevolveFeatureDataInterface
    {
        public static Double GetRevolutionAngle(ISurfRevolveFeatureDataObject ISurfRevolveFeatureDatainstance, Boolean Forward)
        {
            return ISurfRevolveFeatureDatainstance.ISurfRevolveFeatureDataInstance.GetRevolutionAngle(Forward);
        }
        public static void SetRevolutionAngle(ISurfRevolveFeatureDataObject ISurfRevolveFeatureDatainstance, Boolean Forward, Double Angle)
        {
            ISurfRevolveFeatureDatainstance.ISurfRevolveFeatureDataInstance.SetRevolutionAngle(Forward, Angle);
        }
        public static Boolean AccessSelections(ISurfRevolveFeatureDataObject ISurfRevolveFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ISurfRevolveFeatureDatainstance.ISurfRevolveFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(ISurfRevolveFeatureDataObject ISurfRevolveFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISurfRevolveFeatureDatainstance.ISurfRevolveFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISurfRevolveFeatureDataObject ISurfRevolveFeatureDatainstance)
        {
            ISurfRevolveFeatureDatainstance.ISurfRevolveFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 Type(ISurfRevolveFeatureDataObject ISurfRevolveFeatureDatainstance)
        {
            return ISurfRevolveFeatureDatainstance.ISurfRevolveFeatureDataInstance.Type;
        }
        public static Boolean ReverseDirection(ISurfRevolveFeatureDataObject ISurfRevolveFeatureDatainstance)
        {
            return ISurfRevolveFeatureDatainstance.ISurfRevolveFeatureDataInstance.ReverseDirection;
        }
    }
}