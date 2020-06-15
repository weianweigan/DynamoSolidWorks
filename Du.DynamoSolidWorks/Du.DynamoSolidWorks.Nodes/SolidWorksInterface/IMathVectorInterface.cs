using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMathVectorObject
    {
        public IMathVector IMathVectorInstance { get; set; }
        public IMathVectorObject(IMathVector IMathVectorinstance)
        {
            IMathVectorInstance = IMathVectorinstance;
        }
    }
    public static class IMathVectorInterface
    {
        public static Object MultiplyTransform(IMathVectorObject IMathVectorinstance, Object TransformObjIn)
        {
            return IMathVectorinstance.IMathVectorInstance.MultiplyTransform(TransformObjIn);
        }
        public static IMathVectorObject IMultiplyTransform(IMathVectorObject IMathVectorinstance, IMathTransformObject TransformObjIn)
        {
            return new IMathVectorObject(IMathVectorinstance.IMathVectorInstance.IMultiplyTransform(TransformObjIn.IMathTransformInstance as MathTransform));
        }
        public static Object Add(IMathVectorObject IMathVectorinstance, Object VectorObjIn)
        {
            return IMathVectorinstance.IMathVectorInstance.Add(VectorObjIn);
        }
        public static IMathVectorObject IAdd(IMathVectorObject IMathVectorinstance, IMathVectorObject VectorObjIn)
        {
            return new IMathVectorObject(IMathVectorinstance.IMathVectorInstance.IAdd(VectorObjIn.IMathVectorInstance as MathVector));
        }
        public static Object Subtract(IMathVectorObject IMathVectorinstance, Object VectorObjIn)
        {
            return IMathVectorinstance.IMathVectorInstance.Subtract(VectorObjIn);
        }
        public static IMathVectorObject ISubtract(IMathVectorObject IMathVectorinstance, IMathVectorObject VectorObjIn)
        {
            return new IMathVectorObject(IMathVectorinstance.IMathVectorInstance.ISubtract(VectorObjIn.IMathVectorInstance as MathVector));
        }
        public static Object Scale(IMathVectorObject IMathVectorinstance, Double ValueIn)
        {
            return IMathVectorinstance.IMathVectorInstance.Scale(ValueIn);
        }
        public static IMathVectorObject IScale(IMathVectorObject IMathVectorinstance, Double ValueIn)
        {
            return new IMathVectorObject(IMathVectorinstance.IMathVectorInstance.IScale(ValueIn));
        }
        public static Double GetLength(IMathVectorObject IMathVectorinstance)
        {
            return IMathVectorinstance.IMathVectorInstance.GetLength();
        }
        public static Double Dot(IMathVectorObject IMathVectorinstance, Object VectorObjIn)
        {
            return IMathVectorinstance.IMathVectorInstance.Dot(VectorObjIn);
        }
        public static Double IDot(IMathVectorObject IMathVectorinstance, IMathVectorObject VectorObjIn)
        {
            return IMathVectorinstance.IMathVectorInstance.IDot(VectorObjIn.IMathVectorInstance as MathVector);
        }
        public static Object Cross(IMathVectorObject IMathVectorinstance, Object VectorObjIn)
        {
            return IMathVectorinstance.IMathVectorInstance.Cross(VectorObjIn);
        }
        public static IMathVectorObject ICross(IMathVectorObject IMathVectorinstance, IMathVectorObject VectorObjIn)
        {
            return new IMathVectorObject(IMathVectorinstance.IMathVectorInstance.ICross(VectorObjIn.IMathVectorInstance as MathVector));
        }
        public static Object ConvertToPoint(IMathVectorObject IMathVectorinstance)
        {
            return IMathVectorinstance.IMathVectorInstance.ConvertToPoint();
        }
        public static IMathPointObject IConvertToPoint(IMathVectorObject IMathVectorinstance)
        {
            return new IMathPointObject(IMathVectorinstance.IMathVectorInstance.IConvertToPoint());
        }
        public static IMathVectorObject Normalise(IMathVectorObject IMathVectorinstance)
        {
            return new IMathVectorObject(IMathVectorinstance.IMathVectorInstance.Normalise());
        }
        public static Object ArrayData(IMathVectorObject IMathVectorinstance)
        {
            return IMathVectorinstance.IMathVectorInstance.ArrayData;
        }
        public static double[] IArrayData(IMathVectorObject IMathVectorinstance)
        {
            return IMathVectorinstance.IMathVectorInstance.ArrayData as double[];
        }
    }
}