using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMathUtilityObject
    {
        public IMathUtility IMathUtilityInstance { get; set; }
        public IMathUtilityObject(IMathUtility IMathUtilityinstance)
        {
            IMathUtilityInstance = IMathUtilityinstance;
        }
    }
    public static class IMathUtilityInterface
    {
        public static Object CreateTransform(IMathUtilityObject IMathUtilityinstance, Object ArrayDataIn)
        {
            return IMathUtilityinstance.IMathUtilityInstance.CreateTransform(ArrayDataIn);
        }
        //public static IMathTransformObject ICreateTransform(IMathUtilityObject IMathUtilityinstance, Double& ArrayDataIn)
        //{
        //    return new IMathTransformObject(IMathUtilityinstance.IMathUtilityInstance.ICreateTransform(ArrayDataIn));
        //}
        public static Object CreateTransformRotateAxis(IMathUtilityObject IMathUtilityinstance, Object PointObjIn, Object VectorObjIn, Double Angle)
        {
            return IMathUtilityinstance.IMathUtilityInstance.CreateTransformRotateAxis(PointObjIn, VectorObjIn, Angle);
        }
        public static IMathTransformObject ICreateTransformRotateAxis(IMathUtilityObject IMathUtilityinstance, IMathPointObject PointObjIn, IMathVectorObject VectorObjIn, Double Angle)
        {
            return new IMathTransformObject(IMathUtilityinstance.IMathUtilityInstance.ICreateTransformRotateAxis(PointObjIn.IMathPointInstance as MathPoint, VectorObjIn.IMathVectorInstance as MathVector, Angle));
        }
        public static Object CreatePoint(IMathUtilityObject IMathUtilityinstance, Object ArrayDataIn)
        {
            return IMathUtilityinstance.IMathUtilityInstance.CreatePoint(ArrayDataIn);
        }
        //public static IMathPointObject ICreatePoint(IMathUtilityObject IMathUtilityinstance, Double& ArrayDataIn)
        //{
        //    return new IMathPointObject(IMathUtilityinstance.IMathUtilityInstance.ICreatePoint(ArrayDataIn));
        //}
        public static Object CreateVector(IMathUtilityObject IMathUtilityinstance, Object ArrayDataIn)
        {
            return IMathUtilityinstance.IMathUtilityInstance.CreateVector(ArrayDataIn);
        }
        //public static IMathVectorObject ICreateVector(IMathUtilityObject IMathUtilityinstance, Double& ArrayDataIn)
        //{
        //    return new IMathVectorObject(IMathUtilityinstance.IMathUtilityInstance.ICreateVector(ArrayDataIn));
        //}
        public static IMathTransformObject ComposeTransform(IMathUtilityObject IMathUtilityinstance, IMathVectorObject XVec, IMathVectorObject YVec, IMathVectorObject ZVec, IMathVectorObject TransVec, Double Scale)
        {
            return new IMathTransformObject(IMathUtilityinstance.IMathUtilityInstance.ComposeTransform(XVec.IMathVectorInstance as MathVector, YVec.IMathVectorInstance as MathVector, ZVec.IMathVectorInstance as MathVector, TransVec.IMathVectorInstance as MathVector, Scale));
        }
    }
}