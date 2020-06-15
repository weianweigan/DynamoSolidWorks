using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBlockInstanceObject
    {
        public IBlockInstance IBlockInstanceInstance { get; set; }
        public IBlockInstanceObject(IBlockInstance IBlockInstanceinstance)
        {
            IBlockInstanceInstance = IBlockInstanceinstance;
        }
    }
    public static class IBlockInstanceInterface
    {
        public static IBlockInstanceObject GetNext(IBlockInstanceObject IBlockInstanceinstance)
        {
            return new IBlockInstanceObject(IBlockInstanceinstance.IBlockInstanceInstance.GetNext());
        }
        public static IAnnotationObject GetAnnotation(IBlockInstanceObject IBlockInstanceinstance)
        {
            return new IAnnotationObject(IBlockInstanceinstance.IBlockInstanceInstance.GetAnnotation());
        }
        public static Int32 GetAttributeCount(IBlockInstanceObject IBlockInstanceinstance)
        {
            return IBlockInstanceinstance.IBlockInstanceInstance.GetAttributeCount();
        }
        public static Object GetAttributes(IBlockInstanceObject IBlockInstanceinstance)
        {
            return IBlockInstanceinstance.IBlockInstanceInstance.GetAttributes();
        }
        public static INoteObject IGetAttributes(IBlockInstanceObject IBlockInstanceinstance, Int32 NumAttribs)
        {
            return new INoteObject(IBlockInstanceinstance.IBlockInstanceInstance.IGetAttributes(NumAttribs));
        }
        public static String GetAttributeValue(IBlockInstanceObject IBlockInstanceinstance, String TagName)
        {
            return IBlockInstanceinstance.IBlockInstanceInstance.GetAttributeValue(TagName);
        }
        public static Boolean SetAttributeValue(IBlockInstanceObject IBlockInstanceinstance, String TagName, String Value)
        {
            return IBlockInstanceinstance.IBlockInstanceInstance.SetAttributeValue(TagName, Value);
        }
        public static IBlockDefinitionObject Definition(IBlockInstanceObject IBlockInstanceinstance)
        {
            return new IBlockDefinitionObject(IBlockInstanceinstance.IBlockInstanceInstance.Definition);
        }
        public static Double Angle(IBlockInstanceObject IBlockInstanceinstance)
        {
            return IBlockInstanceinstance.IBlockInstanceInstance.Angle;
        }
        public static Double Scale2(IBlockInstanceObject IBlockInstanceinstance)
        {
            return IBlockInstanceinstance.IBlockInstanceInstance.Scale2;
        }
        public static Int32 TextDisplay(IBlockInstanceObject IBlockInstanceinstance)
        {
            return IBlockInstanceinstance.IBlockInstanceInstance.TextDisplay;
        }
    }
}