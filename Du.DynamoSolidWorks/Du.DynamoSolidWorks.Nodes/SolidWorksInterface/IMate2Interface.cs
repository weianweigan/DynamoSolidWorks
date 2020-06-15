using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMate2Object
    {
        public IMate2 IMate2Instance { get; set; }
        public IMate2Object(IMate2 IMate2instance)
        {
            IMate2Instance = IMate2instance;
        }
    }
    public static class IMate2Interface
    {
        public static Int32 GetMateEntityCount(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.GetMateEntityCount();
        }
        public static IMateEntity2Object MateEntity(IMate2Object IMate2instance, Int32 Index)
        {
            return new IMateEntity2Object(IMate2instance.IMate2Instance.MateEntity(Index));
        }
        //public static IMathVectorObject GetForce(IMate2Object IMate2instance, Double& Magnitude)
        //{
        //    return new IMathVectorObject(IMate2instance.IMate2Instance.GetForce(Magnitude));
        //}
        public static Boolean SetForce(IMate2Object IMate2instance, Double Magnitude, IMathVectorObject Direction)
        {
            return IMate2instance.IMate2Instance.SetForce(Magnitude, Direction.IMathVectorInstance as MathVector);
        }
        //public static IMathVectorObject GetTorque(IMate2Object IMate2instance, Double& Angle)
        //{
        //    return new IMathVectorObject(IMate2instance.IMate2Instance.GetTorque(Angle));
        //}
        public static Boolean SetTorque(IMate2Object IMate2instance, Double Angle, IMathVectorObject Axis)
        {
            return IMate2instance.IMate2Instance.SetTorque(Angle, Axis.IMathVectorInstance as MathVector);
        }
        public static Object GetSupplementalFaces(IMate2Object IMate2instance, Int32 WhichOne)
        {
            return IMate2instance.IMate2Instance.GetSupplementalFaces(WhichOne);
        }
        public static IFace2Object IGetSupplementalFaces(IMate2Object IMate2instance, Int32 WhichOne, Int32 FaceCount)
        {
            return new IFace2Object(IMate2instance.IMate2Instance.IGetSupplementalFaces(WhichOne, FaceCount));
        }
        public static Object GetLinkedMate(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.GetLinkedMate();
        }
        public static void SetUseMisalignedDeviationDocumentProperty(IMate2Object IMate2instance, Boolean UseDocumentProperty)
        {
            IMate2instance.IMate2Instance.SetUseMisalignedDeviationDocumentProperty(UseDocumentProperty);
        }
        public static Boolean GetUseMisalignedDeviationDocumentProperty(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.GetUseMisalignedDeviationDocumentProperty();
        }
        public static Double GetCurrentMisalignedDeviation(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.GetCurrentMisalignedDeviation();
        }
        public static void SetConcentricAlignmentType(IMate2Object IMate2instance, Int32 PositionType)
        {
            IMate2instance.IMate2Instance.SetConcentricAlignmentType(PositionType);
        }
        public static Int32 GetConcentricAlignmentType(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.GetConcentricAlignmentType();
        }
        public static void SetMaximumMisalignedDeviation(IMate2Object IMate2instance, Double MaximumDeviation)
        {
            IMate2instance.IMate2Instance.SetMaximumMisalignedDeviation(MaximumDeviation);
        }
        public static Double GetMaximumMisalignedDeviation(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.GetMaximumMisalignedDeviation();
        }
        public static Boolean RemoveMisalignment(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.RemoveMisalignment();
        }
        public static Boolean ForceMisalignment(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.ForceMisalignment();
        }
        public static Int32 Type(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.Type;
        }
        public static Int32 Alignment(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.Alignment;
        }
        public static Boolean CanBeFlipped(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.CanBeFlipped;
        }
        public static IDisplayDimensionObject DisplayDimension(IMate2Object IMate2instance)
        {
            return new IDisplayDimensionObject(IMate2instance.IMate2Instance.DisplayDimension);
        }
        public static Double MaximumVariation(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.MaximumVariation;
        }
        public static Double MinimumVariation(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.MinimumVariation;
        }
        public static Boolean Flipped(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.Flipped;
        }
        public static IDisplayDimensionObject DisplayDimension2(IMate2Object IMate2instance, int Index)
        {
            return new IDisplayDimensionObject(IMate2instance.IMate2Instance.DisplayDimension2[Index]);
        }
        public static IMateLoadReferenceObject MateLoadReference(IMate2Object IMate2instance)
        {
            return new IMateLoadReferenceObject(IMate2instance.IMate2Instance.MateLoadReference);
        }
        public static Boolean HasTreatInterferenceAsShrinkFit(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.HasTreatInterferenceAsShrinkFit;
        }
        public static Boolean IsLoadBearingFacesBonded(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.IsLoadBearingFacesBonded;
        }
        public static Boolean HasLoadBearingFaces(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.HasLoadBearingFaces;
        }
        public static Int32 DistanceFirstArcCondition(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.DistanceFirstArcCondition;
        }
        public static Int32 DistanceSecondArcCondition(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.DistanceSecondArcCondition;
        }
        public static Boolean LockMagneticMate(IMate2Object IMate2instance)
        {
            return IMate2instance.IMate2Instance.LockMagneticMate;
        }
    }
}