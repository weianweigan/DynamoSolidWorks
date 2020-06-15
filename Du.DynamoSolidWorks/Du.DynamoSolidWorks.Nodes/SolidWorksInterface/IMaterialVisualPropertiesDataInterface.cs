using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMaterialVisualPropertiesDataObject
    {
        public IMaterialVisualPropertiesData IMaterialVisualPropertiesDataInstance { get; set; }
        public IMaterialVisualPropertiesDataObject(IMaterialVisualPropertiesData IMaterialVisualPropertiesDatainstance)
        {
            IMaterialVisualPropertiesDataInstance = IMaterialVisualPropertiesDatainstance;
        }
    }
    public static class IMaterialVisualPropertiesDataInterface
    {
        public static Boolean AdvancedGraphics(IMaterialVisualPropertiesDataObject IMaterialVisualPropertiesDatainstance)
        {
            return IMaterialVisualPropertiesDatainstance.IMaterialVisualPropertiesDataInstance.AdvancedGraphics;
        }
        public static Boolean RealView(IMaterialVisualPropertiesDataObject IMaterialVisualPropertiesDatainstance)
        {
            return IMaterialVisualPropertiesDatainstance.IMaterialVisualPropertiesDataInstance.RealView;
        }
        public static Double Scale2(IMaterialVisualPropertiesDataObject IMaterialVisualPropertiesDatainstance)
        {
            return IMaterialVisualPropertiesDatainstance.IMaterialVisualPropertiesDataInstance.Scale2;
        }
        public static Double Angle(IMaterialVisualPropertiesDataObject IMaterialVisualPropertiesDatainstance)
        {
            return IMaterialVisualPropertiesDatainstance.IMaterialVisualPropertiesDataInstance.Angle;
        }
        public static Boolean BlendColor(IMaterialVisualPropertiesDataObject IMaterialVisualPropertiesDatainstance)
        {
            return IMaterialVisualPropertiesDatainstance.IMaterialVisualPropertiesDataInstance.BlendColor;
        }
        public static Boolean ApplyMaterialColorToPart(IMaterialVisualPropertiesDataObject IMaterialVisualPropertiesDatainstance)
        {
            return IMaterialVisualPropertiesDatainstance.IMaterialVisualPropertiesDataInstance.ApplyMaterialColorToPart;
        }
        public static Boolean ApplyMaterialHatchToSection(IMaterialVisualPropertiesDataObject IMaterialVisualPropertiesDatainstance)
        {
            return IMaterialVisualPropertiesDatainstance.IMaterialVisualPropertiesDataInstance.ApplyMaterialHatchToSection;
        }
        public static Boolean ApplyAppearance(IMaterialVisualPropertiesDataObject IMaterialVisualPropertiesDatainstance)
        {
            return IMaterialVisualPropertiesDatainstance.IMaterialVisualPropertiesDataInstance.ApplyAppearance;
        }
    }
}