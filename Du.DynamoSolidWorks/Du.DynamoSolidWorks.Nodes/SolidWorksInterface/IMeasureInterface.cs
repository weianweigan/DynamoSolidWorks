using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMeasureObject
    {
        public IMeasure IMeasureInstance { get; set; }
        public IMeasureObject(IMeasure IMeasureinstance)
        {
            IMeasureInstance = IMeasureinstance;
        }
    }
    public static class IMeasureInterface
    {
        public static Boolean Calculate(IMeasureObject IMeasureinstance, Object Entities)
        {
            return IMeasureinstance.IMeasureInstance.Calculate(Entities);
        }
        public static Boolean SetProjectionEntity(IMeasureObject IMeasureinstance, Object Entity)
        {
            return IMeasureinstance.IMeasureInstance.SetProjectionEntity(Entity);
        }
        public static Double X(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.X;
        }
        public static Double Y(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.Y;
        }
        public static Double Z(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.Z;
        }
        public static Double DeltaX(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.DeltaX;
        }
        public static Double DeltaY(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.DeltaY;
        }
        public static Double DeltaZ(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.DeltaZ;
        }
        public static Double Length(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.Length;
        }
        public static Double Area(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.Area;
        }
        public static Double Perimeter(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.Perimeter;
        }
        public static Double Distance(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.Distance;
        }
        public static Double NormalDistance(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.NormalDistance;
        }
        public static Double Angle(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.Angle;
        }
        public static Double TotalArea(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.TotalArea;
        }
        public static Double TotalLength(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.TotalLength;
        }
        public static Double CenterDistance(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.CenterDistance;
        }
        public static Double Radius(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.Radius;
        }
        public static Double Diameter(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.Diameter;
        }
        public static Double ArcLength(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.ArcLength;
        }
        public static Double ChordLength(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.ChordLength;
        }
        public static Boolean IsParallel(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.IsParallel;
        }
        public static Boolean IsPerpendicular(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.IsPerpendicular;
        }
        public static Boolean IsIntersect(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.IsIntersect;
        }
        public static Double Normal(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.Normal;
        }
        public static Double Projection(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.Projection;
        }
        public static Int32 ArcOption(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.ArcOption;
        }
        public static Int32 ProjectionOption(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.ProjectionOption;
        }
        public static Double SpericalCenterDistance(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.SpericalCenterDistance;
        }
        public static Boolean IsConcentricSpheres(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.IsConcentricSpheres;
        }
        public static Int32 LengthDecimalPlaces(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.LengthDecimalPlaces;
        }
        public static Int32 AngleDecimalPlaces(IMeasureObject IMeasureinstance)
        {
            return IMeasureinstance.IMeasureInstance.AngleDecimalPlaces;
        }
    }
}