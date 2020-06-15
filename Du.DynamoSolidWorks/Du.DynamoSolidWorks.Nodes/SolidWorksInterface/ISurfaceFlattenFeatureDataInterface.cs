using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISurfaceFlattenFeatureDataObject
    {
        public ISurfaceFlattenFeatureData ISurfaceFlattenFeatureDataInstance { get; set; }
        public ISurfaceFlattenFeatureDataObject(ISurfaceFlattenFeatureData ISurfaceFlattenFeatureDatainstance)
        {
            ISurfaceFlattenFeatureDataInstance = ISurfaceFlattenFeatureDatainstance;
        }
    }
    public static class ISurfaceFlattenFeatureDataInterface
    {
        public static Boolean AccessSelections(ISurfaceFlattenFeatureDataObject ISurfaceFlattenFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISurfaceFlattenFeatureDatainstance.ISurfaceFlattenFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISurfaceFlattenFeatureDataObject ISurfaceFlattenFeatureDatainstance)
        {
            ISurfaceFlattenFeatureDatainstance.ISurfaceFlattenFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Object Faces(ISurfaceFlattenFeatureDataObject ISurfaceFlattenFeatureDatainstance)
        {
            return ISurfaceFlattenFeatureDatainstance.ISurfaceFlattenFeatureDataInstance.Faces;
        }
        public static Object GuideEdges(ISurfaceFlattenFeatureDataObject ISurfaceFlattenFeatureDatainstance)
        {
            return ISurfaceFlattenFeatureDatainstance.ISurfaceFlattenFeatureDataInstance.GuideEdges;
        }
        public static Object FixPointVertex(ISurfaceFlattenFeatureDataObject ISurfaceFlattenFeatureDatainstance)
        {
            return ISurfaceFlattenFeatureDatainstance.ISurfaceFlattenFeatureDataInstance.FixPointVertex;
        }
        public static Int32 AccuracyFactor(ISurfaceFlattenFeatureDataObject ISurfaceFlattenFeatureDatainstance)
        {
            return ISurfaceFlattenFeatureDatainstance.ISurfaceFlattenFeatureDataInstance.AccuracyFactor;
        }
        public static Boolean KeepInternalControlCurves(ISurfaceFlattenFeatureDataObject ISurfaceFlattenFeatureDatainstance)
        {
            return ISurfaceFlattenFeatureDatainstance.ISurfaceFlattenFeatureDataInstance.KeepInternalControlCurves;
        }
        public static Object MapEdges(ISurfaceFlattenFeatureDataObject ISurfaceFlattenFeatureDatainstance)
        {
            return ISurfaceFlattenFeatureDatainstance.ISurfaceFlattenFeatureDataInstance.MapEdges;
        }
        public static Object TearEdges(ISurfaceFlattenFeatureDataObject ISurfaceFlattenFeatureDatainstance)
        {
            return ISurfaceFlattenFeatureDatainstance.ISurfaceFlattenFeatureDataInstance.TearEdges;
        }
        public static Boolean ShouldMakeTears(ISurfaceFlattenFeatureDataObject ISurfaceFlattenFeatureDatainstance)
        {
            return ISurfaceFlattenFeatureDatainstance.ISurfaceFlattenFeatureDataInstance.ShouldMakeTears;
        }
    }
}