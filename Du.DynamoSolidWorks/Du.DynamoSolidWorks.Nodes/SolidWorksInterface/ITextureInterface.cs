using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ITextureObject
    {
        public ITexture ITextureInstance { get; set; }
        public ITextureObject(ITexture ITextureinstance)
        {
            ITextureInstance = ITextureinstance;
        }
    }
    public static class ITextureInterface
    {
        //public static String GetSystemTextureName(ITextureObject ITextureinstance, String FileNameIn, Boolean& Res)
        //{
        //    return ITextureinstance.ITextureInstance.GetSystemTextureName(FileNameIn, Res);
        //}
        public static String MaterialName(ITextureObject ITextureinstance)
        {
            return ITextureinstance.ITextureInstance.MaterialName;
        }
        public static Double ScaleFactor(ITextureObject ITextureinstance)
        {
            return ITextureinstance.ITextureInstance.ScaleFactor;
        }
        public static Double Angle(ITextureObject ITextureinstance)
        {
            return ITextureinstance.ITextureInstance.Angle;
        }
        public static Boolean BlendColor(ITextureObject ITextureinstance)
        {
            return ITextureinstance.ITextureInstance.BlendColor;
        }
        public static Double VScale(ITextureObject ITextureinstance)
        {
            return ITextureinstance.ITextureInstance.VScale;
        }
        public static Double UDir(ITextureObject ITextureinstance)
        {
            return ITextureinstance.ITextureInstance.UDir;
        }
        public static Double VDir(ITextureObject ITextureinstance)
        {
            return ITextureinstance.ITextureInstance.VDir;
        }
        public static Double TransX(ITextureObject ITextureinstance)
        {
            return ITextureinstance.ITextureInstance.TransX;
        }
        public static Double TransY(ITextureObject ITextureinstance)
        {
            return ITextureinstance.ITextureInstance.TransY;
        }
        public static Boolean DecalType(ITextureObject ITextureinstance)
        {
            return ITextureinstance.ITextureInstance.DecalType;
        }
        public static Boolean IgnoreColorMaterial(ITextureObject ITextureinstance)
        {
            return ITextureinstance.ITextureInstance.IgnoreColorMaterial;
        }
    }
}