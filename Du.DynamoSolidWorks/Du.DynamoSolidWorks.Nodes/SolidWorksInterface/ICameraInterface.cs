using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICameraObject
    {
        public ICamera ICameraInstance { get; set; }
        public ICameraObject(ICamera ICamerainstance)
        {
            ICameraInstance = ICamerainstance;
        }
    }
    public static class ICameraInterface
    {
        public static IMathPointObject GetPosition(ICameraObject ICamerainstance)
        {
            return new IMathPointObject(ICamerainstance.ICameraInstance.GetPosition());
        }
        public static IMathVectorObject GetViewVector(ICameraObject ICamerainstance)
        {
            return new IMathVectorObject(ICamerainstance.ICameraInstance.GetViewVector());
        }
        public static IMathVectorObject GetUpVector(ICameraObject ICamerainstance)
        {
            return new IMathVectorObject(ICamerainstance.ICameraInstance.GetUpVector());
        }
        public static Double GetFocalDistance(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.GetFocalDistance();
        }
        public static Double GetPointOfInterestDistance(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.GetPointOfInterestDistance();
        }
        //public static Object GetTargetPointEntity(ICameraObject ICamerainstance, MathPoint&Object Point, Double& PercentTarget)
        //{
        //    return ICamerainstance.ICameraInstance.GetTargetPointEntity(Point, PercentTarget);
        //}
        //public static void SetTargetPointEntity(ICameraObject ICamerainstance, MathPointObject Point, Double PercentTarget, Object TargetPointEntity)
        //{
        //    return ICamerainstance.ICameraInstance.SetTargetPointEntity(Point, PercentTarget, TargetPointEntity);
        //}
        //public static Object GetPositionEntity(ICameraObject ICamerainstance, MathPoint&Object Point, Double& PercentPosition)
        //{
        //    return ICamerainstance.ICameraInstance.GetPositionEntity(Point, PercentPosition);
        //}
        //public static void SetPositionEntity(ICameraObject ICamerainstance, MathPointObject Point, Double PercentPosition, Object PositionEntity)
        //{
        //    return ICamerainstance.ICameraInstance.SetPositionEntity(Point, PercentPosition, PositionEntity);
        //}
        //public static void GetPositionCartesian(ICameraObject ICamerainstance, Double& X, Double& Y, Double& Z)
        //{
        //    return ICamerainstance.ICameraInstance.GetPositionCartesian(X, Y, Z);
        //}
        public static void SetPositionCartesian(ICameraObject ICamerainstance, Double X, Double Y, Double Z)
        {
            ICamerainstance.ICameraInstance.SetPositionCartesian(X, Y, Z);
        }
        //public static void GetPositionSpherical(ICameraObject ICamerainstance, Double& L, Double& A1, Double& A2)
        //{
        //     ICamerainstance.ICameraInstance.GetPositionSpherical(L, A1, A2);
        //}
        public static void SetPositionSpherical(ICameraObject ICamerainstance, Double L, Double A1, Double A2)
        {
            ICamerainstance.ICameraInstance.SetPositionSpherical(L, A1, A2);
        }
        public static Int32 ID(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.ID;
        }
        public static Boolean Perspective(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.Perspective;
        }
        public static Double FieldOfViewHeight(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.FieldOfViewHeight;
        }
        public static Double FieldOfViewDepth(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.FieldOfViewDepth;
        }
        public static Double FieldOfViewAngle(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.FieldOfViewAngle;
        }
        public static Boolean DepthOfFieldEnabled(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.DepthOfFieldEnabled;
        }
        public static Double DepthOfFieldOffset(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.DepthOfFieldOffset;
        }
        public static Double AspectRatio(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.AspectRatio;
        }
        public static Int32 Type(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.Type;
        }
        public static Boolean LockCameraPosition(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.LockCameraPosition;
        }
        public static Boolean TargetPointBySelection(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.TargetPointBySelection;
        }
        public static IMathPointObject TargetPointPosition(ICameraObject ICamerainstance)
        {
            return new IMathPointObject(ICamerainstance.ICameraInstance.TargetPointPosition);
        }
        public static Int32 PositionType(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.PositionType;
        }
        public static Object RotationRollEntity(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.RotationRollEntity;
        }
        public static Boolean RotationRollBySelection(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.RotationRollBySelection;
        }
        public static Double RotationRollAngle(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.RotationRollAngle;
        }
        public static Boolean RotationRollFlipDirection(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.RotationRollFlipDirection;
        }
        public static Double Yaw(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.Yaw;
        }
        public static Double Pitch(ICameraObject ICamerainstance)
        {
            return ICamerainstance.ICameraInstance.Pitch;
        }
    }
}