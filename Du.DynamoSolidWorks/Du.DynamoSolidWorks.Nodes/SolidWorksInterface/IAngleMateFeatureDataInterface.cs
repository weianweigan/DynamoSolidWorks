using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IAngleMateFeatureDataObject
    {
        public IAngleMateFeatureData IAngleMateFeatureDataInstance { get; set; }
        public IAngleMateFeatureDataObject(IAngleMateFeatureData IAngleMateFeatureDatainstance)
        {
            IAngleMateFeatureDataInstance = IAngleMateFeatureDatainstance;
        }
    }
    public static class IAngleMateFeatureDataInterface
    {
        public static Object EntitiesToMate(IAngleMateFeatureDataObject IAngleMateFeatureDatainstance)
        {
            return IAngleMateFeatureDatainstance.IAngleMateFeatureDataInstance.EntitiesToMate;
        }
        public static Double Angle(IAngleMateFeatureDataObject IAngleMateFeatureDatainstance)
        {
            return IAngleMateFeatureDatainstance.IAngleMateFeatureDataInstance.Angle;
        }
        public static Double MaximumAngle(IAngleMateFeatureDataObject IAngleMateFeatureDatainstance)
        {
            return IAngleMateFeatureDatainstance.IAngleMateFeatureDataInstance.MaximumAngle;
        }
        public static Double MinimumAngle(IAngleMateFeatureDataObject IAngleMateFeatureDatainstance)
        {
            return IAngleMateFeatureDatainstance.IAngleMateFeatureDataInstance.MinimumAngle;
        }
        public static Boolean FlipDimension(IAngleMateFeatureDataObject IAngleMateFeatureDatainstance)
        {
            return IAngleMateFeatureDatainstance.IAngleMateFeatureDataInstance.FlipDimension;
        }
        public static Int32 MateAlignment(IAngleMateFeatureDataObject IAngleMateFeatureDatainstance)
        {
            return IAngleMateFeatureDatainstance.IAngleMateFeatureDataInstance.MateAlignment;
        }
        public static Object ReferenceEntity(IAngleMateFeatureDataObject IAngleMateFeatureDatainstance)
        {
            return IAngleMateFeatureDatainstance.IAngleMateFeatureDataInstance.ReferenceEntity;
        }
    }
}