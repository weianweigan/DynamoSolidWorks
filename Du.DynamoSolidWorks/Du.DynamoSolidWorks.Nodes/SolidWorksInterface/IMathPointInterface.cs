using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMathPointObject
    {
        public IMathPoint IMathPointInstance { get; set; }
        public IMathPointObject(IMathPoint IMathPointinstance)
        {
            IMathPointInstance = IMathPointinstance;
        }
    }
    public static class IMathPointInterface
    {
        public static Object MultiplyTransform(IMathPointObject IMathPointinstance, Object TransformObjIn)
        {
            return IMathPointinstance.IMathPointInstance.MultiplyTransform(TransformObjIn);
        }
        public static IMathPointObject IMultiplyTransform(IMathPointObject IMathPointinstance, IMathTransformObject TransformObjIn)
        {
            return new IMathPointObject(IMathPointinstance.IMathPointInstance.IMultiplyTransform(TransformObjIn.IMathTransformInstance as MathTransform));
        }
        public static Object AddVector(IMathPointObject IMathPointinstance, Object VectorObjIn)
        {
            return IMathPointinstance.IMathPointInstance.AddVector(VectorObjIn);
        }
        public static IMathPointObject IAddVector(IMathPointObject IMathPointinstance, IMathVectorObject VectorObjIn)
        {
            return new IMathPointObject(IMathPointinstance.IMathPointInstance.IAddVector(VectorObjIn.IMathVectorInstance as MathVector));
        }
        public static Object SubtractVector(IMathPointObject IMathPointinstance, Object VectorObjIn)
        {
            return IMathPointinstance.IMathPointInstance.SubtractVector(VectorObjIn);
        }
        public static IMathPointObject ISubtractVector(IMathPointObject IMathPointinstance, IMathVectorObject VectorObjIn)
        {
            return new IMathPointObject(IMathPointinstance.IMathPointInstance.ISubtractVector(VectorObjIn.IMathVectorInstance as MathVector));
        }
        public static Object Subtract(IMathPointObject IMathPointinstance, Object PointObjIn)
        {
            return IMathPointinstance.IMathPointInstance.Subtract(PointObjIn);
        }
        public static IMathVectorObject ISubtract(IMathPointObject IMathPointinstance, IMathPointObject PointObjIn)
        {
            return new IMathVectorObject(IMathPointinstance.IMathPointInstance.ISubtract(PointObjIn.IMathPointInstance as MathPoint));
        }
        public static Object Scale(IMathPointObject IMathPointinstance, Double ValueIn)
        {
            return IMathPointinstance.IMathPointInstance.Scale(ValueIn);
        }
        public static IMathPointObject IScale(IMathPointObject IMathPointinstance, Double ValueIn)
        {
            return new IMathPointObject(IMathPointinstance.IMathPointInstance.IScale(ValueIn));
        }
        public static Object ConvertToVector(IMathPointObject IMathPointinstance)
        {
            return IMathPointinstance.IMathPointInstance.ConvertToVector();
        }
        public static IMathVectorObject IConvertToVector(IMathPointObject IMathPointinstance)
        {
            return new IMathVectorObject(IMathPointinstance.IMathPointInstance.IConvertToVector());
        }
        public static Object ArrayData(IMathPointObject IMathPointinstance)
        {
            return IMathPointinstance.IMathPointInstance.ArrayData;
        }
        public static Double[] IArrayData(IMathPointObject IMathPointinstance)
        {
            return IMathPointinstance.IMathPointInstance.ArrayData as double[];
        }
    }
}