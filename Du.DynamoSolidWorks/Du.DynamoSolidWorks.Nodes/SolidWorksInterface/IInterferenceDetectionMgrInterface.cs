using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IInterferenceDetectionMgrObject
    {
        public IInterferenceDetectionMgr IInterferenceDetectionMgrInstance { get; set; }
        public IInterferenceDetectionMgrObject(IInterferenceDetectionMgr IInterferenceDetectionMgrinstance)
        {
            IInterferenceDetectionMgrInstance = IInterferenceDetectionMgrinstance;
        }
    }
    public static class IInterferenceDetectionMgrInterface
    {
        public static Object GetInterferences(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance)
        {
            return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.GetInterferences();
        }
        public static Int32 GetInterferenceCount(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance)
        {
            return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.GetInterferenceCount();
        }
        public static InterferenceObject IGetInterferences(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance, Int32 InterfernceCount)
        {
            return new InterferenceObject(IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.IGetInterferences(InterfernceCount));
        }
        public static Object GetInterferenceComponents(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance)
        {
            return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.GetInterferenceComponents();
        }
        public static Int32 GetInterferenceComponentCount(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance)
        {
            return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.GetInterferenceComponentCount();
        }
        public static IComponent2Object IGetInterferenceComponents(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance, Int32 InterfernceComponentCount)
        {
            return new IComponent2Object(IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.IGetInterferenceComponents(InterfernceComponentCount));
        }
        public static void Done(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance)
        {
            IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.Done();
        }
        //public static Int32 GetComponentsTransformInterferenceCount(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance, Int32 NumOfComponent, Component2&Object Component, MathTransform&Object Transform)
        //{
        //    return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.GetComponentsTransformInterferenceCount(NumOfComponent, Component, Transform);
        //}
        //public static Boolean IGetComponentsTransformInterference(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance, Int32 NumOfComponent, Component2&Object Component, MathTransform&Object Transform, Int32 NumOfIntComponent, Component2&Object InterferingComponent)
        //{
        //    return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.IGetComponentsTransformInterference(NumOfComponent, Component, Transform, NumOfIntComponent, InterferingComponent);
        //}
        //public static Boolean GetComponentsTransformInterference(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance, Object Component, Object Transform, Object& InterferingComponent)
        //{
        //    return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.GetComponentsTransformInterference(Component, Transform, InterferingComponent);
        //}
        //public static Boolean GetComponentsAndTransforms(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance, Object& ComponentList, Object& TransformList)
        //{
        //    return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.GetComponentsAndTransforms(ComponentList, TransformList);
        //}
        public static Int32 SetComponentsAndTransforms(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance, Object ComponentList, Object TransformList)
        {
            return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.SetComponentsAndTransforms(ComponentList, TransformList);
        }
        public static Boolean TreatCoincidenceAsInterference(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance)
        {
            return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.TreatCoincidenceAsInterference;
        }
        public static Boolean ShowIgnoredInterferences(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance)
        {
            return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.ShowIgnoredInterferences;
        }
        public static Boolean TreatSubAssembliesAsComponents(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance)
        {
            return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.TreatSubAssembliesAsComponents;
        }
        public static Boolean IncludeMultibodyPartInterferences(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance)
        {
            return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.IncludeMultibodyPartInterferences;
        }
        public static Boolean MakeInterferingPartsTransparent(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance)
        {
            return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.MakeInterferingPartsTransparent;
        }
        public static Boolean CreateFastenersFolder(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance)
        {
            return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.CreateFastenersFolder;
        }
        public static Int32 NonInterferingComponentDisplay(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance)
        {
            return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.NonInterferingComponentDisplay;
        }
        public static Boolean IgnoreHiddenBodies(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance)
        {
            return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.IgnoreHiddenBodies;
        }
        public static Boolean UseTransform(IInterferenceDetectionMgrObject IInterferenceDetectionMgrinstance)
        {
            return IInterferenceDetectionMgrinstance.IInterferenceDetectionMgrInstance.UseTransform;
        }
    }
}