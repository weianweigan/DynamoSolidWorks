using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICThreadObject
    {
        public ICThread ICThreadInstance { get; set; }
        public ICThreadObject(ICThread ICThreadinstance)
        {
            ICThreadInstance = ICThreadinstance;
        }
    }
    public static class ICThreadInterface
    {
        public static Object GetNext(ICThreadObject ICThreadinstance)
        {
            return ICThreadinstance.ICThreadInstance.GetNext();
        }
        public static ICThreadObject IGetNext(ICThreadObject ICThreadinstance)
        {
            return new ICThreadObject(ICThreadinstance.ICThreadInstance.IGetNext());
        }
        public static Object GetDisplayData(ICThreadObject ICThreadinstance)
        {
            return ICThreadinstance.ICThreadInstance.GetDisplayData();
        }
        public static IDisplayDataObject IGetDisplayData(ICThreadObject ICThreadinstance)
        {
            return new IDisplayDataObject(ICThreadinstance.ICThreadInstance.IGetDisplayData());
        }
        public static Object GetAnnotation(ICThreadObject ICThreadinstance)
        {
            return ICThreadinstance.ICThreadInstance.GetAnnotation();
        }
        public static IAnnotationObject IGetAnnotation(ICThreadObject ICThreadinstance)
        {
            return new IAnnotationObject(ICThreadinstance.ICThreadInstance.IGetAnnotation());
        }
        public static Int32 GetPatternedTransformsCount(ICThreadObject ICThreadinstance)
        {
            return ICThreadinstance.ICThreadInstance.GetPatternedTransformsCount();
        }
        public static IMathTransformObject IGetPatternedTransforms(ICThreadObject ICThreadinstance, Int32 Count)
        {
            return new IMathTransformObject(ICThreadinstance.ICThreadInstance.IGetPatternedTransforms(Count));
        }
        public static INoteObject ThreadCallout(ICThreadObject ICThreadinstance)
        {
            return new INoteObject(ICThreadinstance.ICThreadInstance.ThreadCallout);
        }
        public static Object PatternedTransforms(ICThreadObject ICThreadinstance)
        {
            return ICThreadinstance.ICThreadInstance.PatternedTransforms;
        }
    }
}