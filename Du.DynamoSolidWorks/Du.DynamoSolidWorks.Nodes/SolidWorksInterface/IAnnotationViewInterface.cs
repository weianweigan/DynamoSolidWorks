using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IAnnotationViewObject
    {
        public IAnnotationView IAnnotationViewInstance { get; set; }
        public IAnnotationViewObject(IAnnotationView IAnnotationViewinstance)
        {
            IAnnotationViewInstance = IAnnotationViewinstance;
        }
    }
    public static class IAnnotationViewInterface
    {
        public static IAnnotationObject IGetAnnotations(IAnnotationViewObject IAnnotationViewinstance, Int32 AnnotationCount)
        {
            return new IAnnotationObject(IAnnotationViewinstance.IAnnotationViewInstance.IGetAnnotations(AnnotationCount));
        }
        public static Boolean Activate(IAnnotationViewObject IAnnotationViewinstance)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.Activate();
        }
        public static Boolean ActivateAndReorient(IAnnotationViewObject IAnnotationViewinstance)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.ActivateAndReorient();
        }
        public static Boolean Show(IAnnotationViewObject IAnnotationViewinstance)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.Show();
        }
        public static Boolean Hide(IAnnotationViewObject IAnnotationViewinstance)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.Hide();
        }
        public static Boolean MoveAnnotations(IAnnotationViewObject IAnnotationViewinstance, Object AnnotationsToMove)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.MoveAnnotations(AnnotationsToMove);
        }
        public static Boolean Orient(IAnnotationViewObject IAnnotationViewinstance)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.Orient();
        }
        public static Object GetViewRotation(IAnnotationViewObject IAnnotationViewinstance)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.GetViewRotation();
        }
        public static Double IGetViewRotation(IAnnotationViewObject IAnnotationViewinstance)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.IGetViewRotation();
        }
        public static Boolean IsShown(IAnnotationViewObject IAnnotationViewinstance)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.IsShown();
        }
        public static Object GetAnnotations2(IAnnotationViewObject IAnnotationViewinstance, Boolean DimXpertOnly, Boolean UnassignedInPlane)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.GetAnnotations2(DimXpertOnly, UnassignedInPlane);
        }
        public static Int32 AnnotationCount(IAnnotationViewObject IAnnotationViewinstance)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.AnnotationCount;
        }
        public static Object Annotations(IAnnotationViewObject IAnnotationViewinstance)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.Annotations;
        }
        public static Double AngleMadeWithViewHorizontal(IAnnotationViewObject IAnnotationViewinstance)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.AngleMadeWithViewHorizontal;
        }
        public static Boolean Always2D(IAnnotationViewObject IAnnotationViewinstance)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.Always2D;
        }
        public static Boolean UnassignedView(IAnnotationViewObject IAnnotationViewinstance)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.UnassignedView;
        }
        public static Boolean FlatPatternView(IAnnotationViewObject IAnnotationViewinstance)
        {
            return IAnnotationViewinstance.IAnnotationViewInstance.FlatPatternView;
        }
    }
}