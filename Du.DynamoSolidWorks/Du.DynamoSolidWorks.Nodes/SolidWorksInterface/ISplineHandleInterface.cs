using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISplineHandleObject
    {
        public ISplineHandle ISplineHandleInstance { get; set; }
        public ISplineHandleObject(ISplineHandle ISplineHandleinstance)
        {
            ISplineHandleInstance = ISplineHandleinstance;
        }
    }
    public static class ISplineHandleInterface
    {
        public static void Reset(ISplineHandleObject ISplineHandleinstance)
        {
            ISplineHandleinstance.ISplineHandleInstance.Reset();
        }
        public static Boolean Select(ISplineHandleObject ISplineHandleinstance, Boolean AppendFlag)
        {
            return ISplineHandleinstance.ISplineHandleInstance.Select(AppendFlag);
        }
        public static Int32 SplinePointNumber(ISplineHandleObject ISplineHandleinstance)
        {
            return ISplineHandleinstance.ISplineHandleInstance.SplinePointNumber;
        }
        public static Double X(ISplineHandleObject ISplineHandleinstance)
        {
            return ISplineHandleinstance.ISplineHandleInstance.X;
        }
        public static Double Y(ISplineHandleObject ISplineHandleinstance)
        {
            return ISplineHandleinstance.ISplineHandleInstance.Y;
        }
        public static Double Z(ISplineHandleObject ISplineHandleinstance)
        {
            return ISplineHandleinstance.ISplineHandleInstance.Z;
        }
        public static Double TangentMagnitude(ISplineHandleObject ISplineHandleinstance, int WhichDrection)
        {
            return ISplineHandleinstance.ISplineHandleInstance.TangentMagnitude[WhichDrection];
        }
        public static Double TangentRadialDirection(ISplineHandleObject ISplineHandleinstance)
        {
            return ISplineHandleinstance.ISplineHandleInstance.TangentRadialDirection;
        }
        public static Double TangentPolarDirection(ISplineHandleObject ISplineHandleinstance)
        {
            return ISplineHandleinstance.ISplineHandleInstance.TangentPolarDirection;
        }
        public static Double Curvature(ISplineHandleObject ISplineHandleinstance)
        {
            return ISplineHandleinstance.ISplineHandleInstance.Curvature;
        }
        public static Double RadiusOfCurvature(ISplineHandleObject ISplineHandleinstance)
        {
            return ISplineHandleinstance.ISplineHandleInstance.RadiusOfCurvature;
        }
        public static Boolean TangentDriving(ISplineHandleObject ISplineHandleinstance)
        {
            return ISplineHandleinstance.ISplineHandleInstance.TangentDriving;
        }
        public static Boolean CurvatureControlled(ISplineHandleObject ISplineHandleinstance)
        {
            return ISplineHandleinstance.ISplineHandleInstance.CurvatureControlled;
        }
        public static Double Parameter(ISplineHandleObject ISplineHandleinstance)
        {
            return ISplineHandleinstance.ISplineHandleInstance.Parameter;
        }
        public static Boolean Editable(ISplineHandleObject ISplineHandleinstance)
        {
            return ISplineHandleinstance.ISplineHandleInstance.Editable;
        }
    }
}