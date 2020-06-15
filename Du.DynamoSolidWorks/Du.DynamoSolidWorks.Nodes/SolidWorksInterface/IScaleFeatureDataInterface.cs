using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IScaleFeatureDataObject
    {
        public IScaleFeatureData IScaleFeatureDataInstance { get; set; }
        public IScaleFeatureDataObject(IScaleFeatureData IScaleFeatureDatainstance)
        {
            IScaleFeatureDataInstance = IScaleFeatureDatainstance;
        }
    }
    public static class IScaleFeatureDataInterface
    {
        //public static void GetScale(IScaleFeatureDataObject IScaleFeatureDatainstance, Double& X, Double& Y, Double& Z, Boolean& Uniform)
        //{
        //    return IScaleFeatureDatainstance.IScaleFeatureDataInstance.GetScale(X, Y, Z, Uniform);
        //}
        public static void SetScale(IScaleFeatureDataObject IScaleFeatureDatainstance, Double X, Double Y, Double Z, Boolean Uniform)
        {
            IScaleFeatureDatainstance.IScaleFeatureDataInstance.SetScale(X, Y, Z, Uniform);
        }
        public static Boolean IAccessSelections(IScaleFeatureDataObject IScaleFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IScaleFeatureDatainstance.IScaleFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static Boolean AccessSelections(IScaleFeatureDataObject IScaleFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IScaleFeatureDatainstance.IScaleFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(IScaleFeatureDataObject IScaleFeatureDatainstance)
        {
            IScaleFeatureDatainstance.IScaleFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetBodiesCount(IScaleFeatureDataObject IScaleFeatureDatainstance)
        {
            return IScaleFeatureDatainstance.IScaleFeatureDataInstance.GetBodiesCount();
        }
        public static IBody2Object IGetBodies(IScaleFeatureDataObject IScaleFeatureDatainstance, Int32 Count)
        {
            return new IBody2Object(IScaleFeatureDatainstance.IScaleFeatureDataInstance.IGetBodies(Count));
        }
        //public static void ISetBodies(IScaleFeatureDataObject IScaleFeatureDatainstance, Int32 Count, Body2&Object BodyArr)
        //{
        //    return IScaleFeatureDatainstance.IScaleFeatureDataInstance.ISetBodies(Count, BodyArr);
        //}
        public static Double ScaleX(IScaleFeatureDataObject IScaleFeatureDatainstance)
        {
            return IScaleFeatureDatainstance.IScaleFeatureDataInstance.ScaleX;
        }
        public static Double ScaleY(IScaleFeatureDataObject IScaleFeatureDatainstance)
        {
            return IScaleFeatureDatainstance.IScaleFeatureDataInstance.ScaleY;
        }
        public static Double ScaleZ(IScaleFeatureDataObject IScaleFeatureDatainstance)
        {
            return IScaleFeatureDatainstance.IScaleFeatureDataInstance.ScaleZ;
        }
        public static Int32 Type(IScaleFeatureDataObject IScaleFeatureDatainstance)
        {
            return IScaleFeatureDatainstance.IScaleFeatureDataInstance.Type;
        }
        public static Boolean IsUniform(IScaleFeatureDataObject IScaleFeatureDatainstance)
        {
            return IScaleFeatureDatainstance.IScaleFeatureDataInstance.IsUniform;
        }
        public static Object CoordinateSystem(IScaleFeatureDataObject IScaleFeatureDatainstance)
        {
            return IScaleFeatureDatainstance.IScaleFeatureDataInstance.CoordinateSystem;
        }
        public static Object Bodies(IScaleFeatureDataObject IScaleFeatureDatainstance)
        {
            return IScaleFeatureDatainstance.IScaleFeatureDataInstance.Bodies;
        }
        public static Double ScaleUniform(IScaleFeatureDataObject IScaleFeatureDatainstance)
        {
            return IScaleFeatureDatainstance.IScaleFeatureDataInstance.ScaleUniform;
        }
    }
}