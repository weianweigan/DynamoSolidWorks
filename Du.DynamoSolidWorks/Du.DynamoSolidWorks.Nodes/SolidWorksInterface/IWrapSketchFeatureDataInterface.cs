using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IWrapSketchFeatureDataObject
    {
        public IWrapSketchFeatureData IWrapSketchFeatureDataInstance { get; set; }
        public IWrapSketchFeatureDataObject(IWrapSketchFeatureData IWrapSketchFeatureDatainstance)
        {
            IWrapSketchFeatureDataInstance = IWrapSketchFeatureDatainstance;
        }
    }
    public static class IWrapSketchFeatureDataInterface
    {
        public static Boolean AccessSelections(IWrapSketchFeatureDataObject IWrapSketchFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IWrapSketchFeatureDatainstance.IWrapSketchFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IWrapSketchFeatureDataObject IWrapSketchFeatureDatainstance)
        {
            IWrapSketchFeatureDatainstance.IWrapSketchFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 Type(IWrapSketchFeatureDataObject IWrapSketchFeatureDatainstance)
        {
            return IWrapSketchFeatureDatainstance.IWrapSketchFeatureDataInstance.Type;
        }
        public static IFace2Object Face(IWrapSketchFeatureDataObject IWrapSketchFeatureDatainstance)
        {
            return new IFace2Object(IWrapSketchFeatureDatainstance.IWrapSketchFeatureDataInstance.Face);
        }
        public static Double Thickness(IWrapSketchFeatureDataObject IWrapSketchFeatureDatainstance)
        {
            return IWrapSketchFeatureDatainstance.IWrapSketchFeatureDataInstance.Thickness;
        }
        public static Boolean ReverseDirection(IWrapSketchFeatureDataObject IWrapSketchFeatureDatainstance)
        {
            return IWrapSketchFeatureDatainstance.IWrapSketchFeatureDataInstance.ReverseDirection;
        }
        public static Object PullDirection(IWrapSketchFeatureDataObject IWrapSketchFeatureDatainstance)
        {
            return IWrapSketchFeatureDatainstance.IWrapSketchFeatureDataInstance.PullDirection;
        }
        public static ISketchObject SourceSketch(IWrapSketchFeatureDataObject IWrapSketchFeatureDatainstance)
        {
            return new ISketchObject(IWrapSketchFeatureDatainstance.IWrapSketchFeatureDataInstance.SourceSketch);
        }
    }
}