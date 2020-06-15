using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILinearCouplerMateFeatureDataObject
    {
        public ILinearCouplerMateFeatureData ILinearCouplerMateFeatureDataInstance { get; set; }
        public ILinearCouplerMateFeatureDataObject(ILinearCouplerMateFeatureData ILinearCouplerMateFeatureDatainstance)
        {
            ILinearCouplerMateFeatureDataInstance = ILinearCouplerMateFeatureDatainstance;
        }
    }
    public static class ILinearCouplerMateFeatureDataInterface
    {
        public static Object MateEntity1(ILinearCouplerMateFeatureDataObject ILinearCouplerMateFeatureDatainstance)
        {
            return ILinearCouplerMateFeatureDatainstance.ILinearCouplerMateFeatureDataInstance.MateEntity1;
        }
        public static Object MateEntity2(ILinearCouplerMateFeatureDataObject ILinearCouplerMateFeatureDatainstance)
        {
            return ILinearCouplerMateFeatureDatainstance.ILinearCouplerMateFeatureDataInstance.MateEntity2;
        }
        public static Object ReferenceComponent1(ILinearCouplerMateFeatureDataObject ILinearCouplerMateFeatureDatainstance)
        {
            return ILinearCouplerMateFeatureDatainstance.ILinearCouplerMateFeatureDataInstance.ReferenceComponent1;
        }
        public static Object ReferenceComponent2(ILinearCouplerMateFeatureDataObject ILinearCouplerMateFeatureDatainstance)
        {
            return ILinearCouplerMateFeatureDatainstance.ILinearCouplerMateFeatureDataInstance.ReferenceComponent2;
        }
        public static Double CouplerRatioNumerator(ILinearCouplerMateFeatureDataObject ILinearCouplerMateFeatureDatainstance)
        {
            return ILinearCouplerMateFeatureDatainstance.ILinearCouplerMateFeatureDataInstance.CouplerRatioNumerator;
        }
        public static Double CouplerRatioDenominator(ILinearCouplerMateFeatureDataObject ILinearCouplerMateFeatureDatainstance)
        {
            return ILinearCouplerMateFeatureDatainstance.ILinearCouplerMateFeatureDataInstance.CouplerRatioDenominator;
        }
        public static Boolean Reverse(ILinearCouplerMateFeatureDataObject ILinearCouplerMateFeatureDatainstance)
        {
            return ILinearCouplerMateFeatureDatainstance.ILinearCouplerMateFeatureDataInstance.Reverse;
        }
    }
}