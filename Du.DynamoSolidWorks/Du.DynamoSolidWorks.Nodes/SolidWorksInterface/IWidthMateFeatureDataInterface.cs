using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IWidthMateFeatureDataObject
    {
        public IWidthMateFeatureData IWidthMateFeatureDataInstance { get; set; }
        public IWidthMateFeatureDataObject(IWidthMateFeatureData IWidthMateFeatureDatainstance)
        {
            IWidthMateFeatureDataInstance = IWidthMateFeatureDatainstance;
        }
    }
    public static class IWidthMateFeatureDataInterface
    {
        public static Object WidthSelection(IWidthMateFeatureDataObject IWidthMateFeatureDatainstance)
        {
            return IWidthMateFeatureDatainstance.IWidthMateFeatureDataInstance.WidthSelection;
        }
        public static Object TabSelection(IWidthMateFeatureDataObject IWidthMateFeatureDatainstance)
        {
            return IWidthMateFeatureDatainstance.IWidthMateFeatureDataInstance.TabSelection;
        }
        public static Int32 ConstraintType(IWidthMateFeatureDataObject IWidthMateFeatureDatainstance)
        {
            return IWidthMateFeatureDatainstance.IWidthMateFeatureDataInstance.ConstraintType;
        }
        public static Double PercentDistanceFromEnd(IWidthMateFeatureDataObject IWidthMateFeatureDatainstance)
        {
            return IWidthMateFeatureDatainstance.IWidthMateFeatureDataInstance.PercentDistanceFromEnd;
        }
        public static Double DistanceFromEnd(IWidthMateFeatureDataObject IWidthMateFeatureDatainstance)
        {
            return IWidthMateFeatureDatainstance.IWidthMateFeatureDataInstance.DistanceFromEnd;
        }
        public static Boolean FlipDimension(IWidthMateFeatureDataObject IWidthMateFeatureDatainstance)
        {
            return IWidthMateFeatureDatainstance.IWidthMateFeatureDataInstance.FlipDimension;
        }
    }
}