using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFaceHatchObject
    {
        public IFaceHatch IFaceHatchInstance { get; set; }
        public IFaceHatchObject(IFaceHatch IFaceHatchinstance)
        {
            IFaceHatchInstance = IFaceHatchinstance;
        }
    }
    public static class IFaceHatchInterface
    {
        public static String Pattern(IFaceHatchObject IFaceHatchinstance)
        {
            return IFaceHatchinstance.IFaceHatchInstance.Pattern;
        }
        public static Double Scale(IFaceHatchObject IFaceHatchinstance)
        {
            return IFaceHatchinstance.IFaceHatchInstance.Scale;
        }
        public static Double Angle(IFaceHatchObject IFaceHatchinstance)
        {
            return IFaceHatchinstance.IFaceHatchInstance.Angle;
        }
        public static IFace2Object Face(IFaceHatchObject IFaceHatchinstance)
        {
            return new IFace2Object(IFaceHatchinstance.IFaceHatchInstance.Face);
        }
        public static String Layer(IFaceHatchObject IFaceHatchinstance)
        {
            return IFaceHatchinstance.IFaceHatchInstance.Layer;
        }
        public static Int32 Color(IFaceHatchObject IFaceHatchinstance)
        {
            return IFaceHatchinstance.IFaceHatchInstance.Color;
        }
        public static String Definition(IFaceHatchObject IFaceHatchinstance)
        {
            return IFaceHatchinstance.IFaceHatchInstance.Definition;
        }
        public static Boolean SolidFill(IFaceHatchObject IFaceHatchinstance)
        {
            return IFaceHatchinstance.IFaceHatchInstance.SolidFill;
        }
        public static Double Scale2(IFaceHatchObject IFaceHatchinstance)
        {
            return IFaceHatchinstance.IFaceHatchInstance.Scale2;
        }
        public static Int32 PatternId(IFaceHatchObject IFaceHatchinstance)
        {
            return IFaceHatchinstance.IFaceHatchInstance.PatternId;
        }
        public static Boolean UseMaterialHatch(IFaceHatchObject IFaceHatchinstance)
        {
            return IFaceHatchinstance.IFaceHatchInstance.UseMaterialHatch;
        }
    }
}