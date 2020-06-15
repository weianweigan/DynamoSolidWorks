using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMathTransformObject
    {
        public IMathTransform IMathTransformInstance { get; set; }
        public IMathTransformObject(IMathTransform IMathTransforminstance)
        {
            IMathTransformInstance = IMathTransforminstance;
        }
    }
    public static class IMathTransformInterface
    {
        public static Object Multiply(IMathTransformObject IMathTransforminstance, Object TransformObjIn)
        {
            return IMathTransforminstance.IMathTransformInstance.Multiply(TransformObjIn);
        }
        public static IMathTransformObject IMultiply(IMathTransformObject IMathTransforminstance, IMathTransformObject TransformObjIn)
        {
            return new IMathTransformObject(IMathTransforminstance.IMathTransformInstance.IMultiply(TransformObjIn.IMathTransformInstance as MathTransform));
        }
        //public static void GetData(IMathTransformObject IMathTransforminstance, Object& XAxisObjOut, Object& YAxisObjOut, Object& ZAxisObjOut, Object& TransformObjOut, Double& ScaleOut)
        //{
        //    return IMathTransforminstance.IMathTransformInstance.GetData(XAxisObjOut, YAxisObjOut, ZAxisObjOut, TransformObjOut, ScaleOut);
        //}
        //public static void IGetData(IMathTransformObject IMathTransforminstance, MathVector&Object XAxisObjOut, MathVector&Object YAxisObjOut, MathVector&Object ZAxisObjOut, MathVector&Object TransformObjOut, Double& ScaleOut)
        //{
        //    return IMathTransforminstance.IMathTransformInstance.IGetData(XAxisObjOut, YAxisObjOut, ZAxisObjOut, TransformObjOut, ScaleOut);
        //}
        public static void SetData(IMathTransformObject IMathTransforminstance, Object XAxisObjIn, Object YAxisObjIn, Object ZAxisObjIn, Object TransformObjIn, Double ScaleValIn)
        {
            IMathTransforminstance.IMathTransformInstance.SetData(XAxisObjIn, YAxisObjIn, ZAxisObjIn, TransformObjIn, ScaleValIn);
        }
        public static void ISetData(IMathTransformObject IMathTransforminstance, IMathVectorObject XAxisObjIn, IMathVectorObject YAxisObjIn, IMathVectorObject ZAxisObjIn, IMathVectorObject TransformObjIn, Double ScaleValIn)
        {
            IMathTransforminstance.IMathTransformInstance.ISetData(XAxisObjIn.IMathVectorInstance as MathVector, YAxisObjIn.IMathVectorInstance as MathVector, ZAxisObjIn.IMathVectorInstance as MathVector, TransformObjIn.IMathVectorInstance as MathVector, ScaleValIn);
        }
        public static Object Inverse(IMathTransformObject IMathTransforminstance)
        {
            return IMathTransforminstance.IMathTransformInstance.Inverse();
        }
        public static IMathTransformObject IInverse(IMathTransformObject IMathTransforminstance)
        {
            return new IMathTransformObject(IMathTransforminstance.IMathTransformInstance.IInverse());
        }
        //public static void GetData2(IMathTransformObject IMathTransforminstance, Object& XAxisObjOut, Object& YAxisObjOut, Object& ZAxisObjOut, Object& TransformObjOut, Double& ScaleOut)
        //{
        //    return IMathTransforminstance.IMathTransformInstance.GetData2(XAxisObjOut, YAxisObjOut, ZAxisObjOut, TransformObjOut, ScaleOut);
        //}
        //public static void IGetData2(IMathTransformObject IMathTransforminstance, MathVector&Object XAxisObjOut, MathVector&Object YAxisObjOut, MathVector&Object ZAxisObjOut, MathVector&Object TransformObjOut, Double& ScaleOut)
        //{
        //    return IMathTransforminstance.IMathTransformInstance.IGetData2(XAxisObjOut, YAxisObjOut, ZAxisObjOut, TransformObjOut, ScaleOut);
        //}
        public static Object ArrayData(IMathTransformObject IMathTransforminstance)
        {
            return IMathTransforminstance.IMathTransformInstance.ArrayData;
        }
        public static double[] IArrayData(IMathTransformObject IMathTransforminstance)
        {
            return IMathTransforminstance.IMathTransformInstance.ArrayData as double[];
        }
    }
}