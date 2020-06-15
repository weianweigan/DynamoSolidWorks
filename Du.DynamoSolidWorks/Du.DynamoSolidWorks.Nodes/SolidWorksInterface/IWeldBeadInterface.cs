using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IWeldBeadObject
    {
        public IWeldBead IWeldBeadInstance { get; set; }
        public IWeldBeadObject(IWeldBead IWeldBeadinstance)
        {
            IWeldBeadInstance = IWeldBeadinstance;
        }
    }
    public static class IWeldBeadInterface
    {
        public static IWeldBeadObject GetNext(IWeldBeadObject IWeldBeadinstance)
        {
            return new IWeldBeadObject(IWeldBeadinstance.IWeldBeadInstance.GetNext());
        }
        public static IAnnotationObject GetAnnotation(IWeldBeadObject IWeldBeadinstance)
        {
            return new IAnnotationObject(IWeldBeadinstance.IWeldBeadInstance.GetAnnotation());
        }
        public static Boolean SolidFill(IWeldBeadObject IWeldBeadinstance)
        {
            return IWeldBeadinstance.IWeldBeadInstance.SolidFill;
        }
    }
}