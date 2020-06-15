using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class ITitleBlockTableAnnotationObject
    {
        public ITitleBlockTableAnnotation ITitleBlockTableAnnotationInstance { get; set; }
        public ITitleBlockTableAnnotationObject(ITitleBlockTableAnnotation ITitleBlockTableAnnotationinstance)
        {
            ITitleBlockTableAnnotationInstance = ITitleBlockTableAnnotationinstance;
        }
    }
    public static class ITitleBlockTableAnnotationInterface
    {
        public static ITitleBlockTableFeatureObject TitleBlockTableFeature(ITitleBlockTableAnnotationObject ITitleBlockTableAnnotationinstance)
        {
            return new ITitleBlockTableFeatureObject(ITitleBlockTableAnnotationinstance.ITitleBlockTableAnnotationInstance.TitleBlockTableFeature);
        }
    }
}