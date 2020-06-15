using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class IGeneralToleranceTableAnnotationObject
    {
        public IGeneralToleranceTableAnnotation IGeneralToleranceTableAnnotationInstance { get; set; }
        public IGeneralToleranceTableAnnotationObject(IGeneralToleranceTableAnnotation IGeneralToleranceTableAnnotationinstance)
        {
            IGeneralToleranceTableAnnotationInstance = IGeneralToleranceTableAnnotationinstance;
        }
    }
    public static class IGeneralToleranceTableAnnotationInterface
    {
        public static IGeneralToleranceTableFeatureObject GeneralToleranceTableFeature(IGeneralToleranceTableAnnotationObject IGeneralToleranceTableAnnotationinstance)
        {
            return new IGeneralToleranceTableFeatureObject(IGeneralToleranceTableAnnotationinstance.IGeneralToleranceTableAnnotationInstance.GeneralToleranceTableFeature);
        }
    }
}