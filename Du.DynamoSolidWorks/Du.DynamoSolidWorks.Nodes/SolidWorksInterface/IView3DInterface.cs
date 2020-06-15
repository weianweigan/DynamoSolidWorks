using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IView3DObject
    {
        public IView3D IView3DInstance { get; set; }
        public IView3DObject(IView3D IView3Dinstance)
        {
            IView3DInstance = IView3Dinstance;
        }
    }
    public static class IView3DInterface
    {
        public static void Activate(IView3DObject IView3Dinstance, Boolean SaveLastState)
        {
            IView3Dinstance.IView3DInstance.Activate(SaveLastState);
        }
        public static void Deactivate(IView3DObject IView3Dinstance)
        {
            IView3Dinstance.IView3DInstance.Deactivate();
        }
        public static String Name(IView3DObject IView3Dinstance)
        {
            return IView3Dinstance.IView3DInstance.Name;
        }
        public static Object AnnotationViews(IView3DObject IView3Dinstance)
        {
            return IView3Dinstance.IView3DInstance.AnnotationViews;
        }
        public static IMathTransformObject Rotation(IView3DObject IView3Dinstance)
        {
            return new IMathTransformObject(IView3Dinstance.IView3DInstance.Rotation);
        }
        public static IMathVectorObject Translation(IView3DObject IView3Dinstance)
        {
            return new IMathVectorObject(IView3Dinstance.IView3DInstance.Translation);
        }
        public static Double Scale(IView3DObject IView3Dinstance)
        {
            return IView3Dinstance.IView3DInstance.Scale;
        }
        public static String ConfigurationName(IView3DObject IView3Dinstance)
        {
            return IView3Dinstance.IView3DInstance.ConfigurationName;
        }
        public static String DisplayState(IView3DObject IView3Dinstance)
        {
            return IView3Dinstance.IView3DInstance.DisplayState;
        }
        public static Int32 DisplayMode(IView3DObject IView3Dinstance)
        {
            return IView3Dinstance.IView3DInstance.DisplayMode;
        }
        public static String ModelBreakViewName(IView3DObject IView3Dinstance)
        {
            return IView3Dinstance.IView3DInstance.ModelBreakViewName;
        }
    }
}