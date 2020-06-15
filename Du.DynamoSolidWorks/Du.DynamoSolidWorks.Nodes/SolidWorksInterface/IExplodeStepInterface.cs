using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IExplodeStepObject
    {
        public IExplodeStep IExplodeStepInstance { get; set; }
        public IExplodeStepObject(IExplodeStep IExplodeStepinstance)
        {
            IExplodeStepInstance = IExplodeStepinstance;
        }
    }
    public static class IExplodeStepInterface
    {
        public static Int32 GetNumOfComponents(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.GetNumOfComponents();
        }
        public static String GetComponentName(IExplodeStepObject IExplodeStepinstance, Int32 Index)
        {
            return IExplodeStepinstance.IExplodeStepInstance.GetComponentName(Index);
        }
        public static Object GetComponentXform(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.GetComponentXform();
        }
        public static Double IGetComponentXform(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.IGetComponentXform();
        }
        public static Object GetComponent(IExplodeStepObject IExplodeStepinstance, Int32 Index)
        {
            return IExplodeStepinstance.IExplodeStepInstance.GetComponent(Index);
        }
        public static IComponentObject IGetComponent(IExplodeStepObject IExplodeStepinstance, Int32 Index)
        {
            return new IComponentObject(IExplodeStepinstance.IExplodeStepInstance.IGetComponent(Index));
        }
        public static Boolean IsSubAssemblyRigid(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.IsSubAssemblyRigid();
        }
        public static void SetComponents(IExplodeStepObject IExplodeStepinstance, Object Components)
        {
            IExplodeStepinstance.IExplodeStepInstance.SetComponents(Components);
        }
        //public static Object GetExplodeDirection(IExplodeStepObject IExplodeStepinstance, Int32& ExplDirIndex)
        //{
        //    return IExplodeStepinstance.IExplodeStepInstance.GetExplodeDirection(ExplDirIndex);
        //}
        public static void SetExplodeDirection(IExplodeStepObject IExplodeStepinstance, Object ExplodeDirection, Int32 ExplDirIndex)
        {
            IExplodeStepinstance.IExplodeStepInstance.SetExplodeDirection(ExplodeDirection, ExplDirIndex);
        }
        //public static Object GetRotationAxis(IExplodeStepObject IExplodeStepinstance, Int32& RotAxisIndex)
        //{
        //    return IExplodeStepinstance.IExplodeStepInstance.GetRotationAxis(RotAxisIndex);
        //}
        public static void SetRotationAxis(IExplodeStepObject IExplodeStepinstance, Object RotationAxis, Int32 RotAxisIndex)
        {
            IExplodeStepinstance.IExplodeStepInstance.SetRotationAxis(RotationAxis, RotAxisIndex);
        }
        public static Object GetComponents(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.GetComponents();
        }
        public static Object GetSubAssemblyExplodeSteps(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.GetSubAssemblyExplodeSteps();
        }
        public static Object GetSpecificComponentXForm(IExplodeStepObject IExplodeStepinstance, Int32 Index)
        {
            return IExplodeStepinstance.IExplodeStepInstance.GetSpecificComponentXForm(Index);
        }
        public static String Name(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.Name;
        }
        public static Object DivergeDirection(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.DivergeDirection;
        }
        public static Int32 ExplodeStepType(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.ExplodeStepType;
        }
        public static Double ExplodeDistance(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.ExplodeDistance;
        }
        public static Boolean ReverseTranslationDirection(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.ReverseTranslationDirection;
        }
        public static Double RotationAngle(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.RotationAngle;
        }
        public static Boolean ReverseRotationDirection(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.ReverseRotationDirection;
        }
        public static Boolean DivergeFromAxis(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.DivergeFromAxis;
        }
        public static Boolean RotateAboutEachComponentOrigin(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.RotateAboutEachComponentOrigin;
        }
        public static Boolean AutoSpaceComponentsOnDrag(IExplodeStepObject IExplodeStepinstance)
        {
            return IExplodeStepinstance.IExplodeStepInstance.AutoSpaceComponentsOnDrag;
        }
    }
}