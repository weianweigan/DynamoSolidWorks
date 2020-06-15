using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFaceDecalPropertiesObject
    {
        public IFaceDecalProperties IFaceDecalPropertiesInstance { get; set; }
        public IFaceDecalPropertiesObject(IFaceDecalProperties IFaceDecalPropertiesinstance)
        {
            IFaceDecalPropertiesInstance = IFaceDecalPropertiesinstance;
        }
    }
    public static class IFaceDecalPropertiesInterface
    {
        public static Double TextureTranslationX(IFaceDecalPropertiesObject IFaceDecalPropertiesinstance)
        {
            return IFaceDecalPropertiesinstance.IFaceDecalPropertiesInstance.TextureTranslationX;
        }
        public static Double TextureTranslationY(IFaceDecalPropertiesObject IFaceDecalPropertiesinstance)
        {
            return IFaceDecalPropertiesinstance.IFaceDecalPropertiesInstance.TextureTranslationY;
        }
        public static Double TextureUScale(IFaceDecalPropertiesObject IFaceDecalPropertiesinstance)
        {
            return IFaceDecalPropertiesinstance.IFaceDecalPropertiesInstance.TextureUScale;
        }
        public static Double TextureVScale(IFaceDecalPropertiesObject IFaceDecalPropertiesinstance)
        {
            return IFaceDecalPropertiesinstance.IFaceDecalPropertiesInstance.TextureVScale;
        }
        public static Double TextureAngle(IFaceDecalPropertiesObject IFaceDecalPropertiesinstance)
        {
            return IFaceDecalPropertiesinstance.IFaceDecalPropertiesInstance.TextureAngle;
        }
        public static String TextureFilename(IFaceDecalPropertiesObject IFaceDecalPropertiesinstance)
        {
            return IFaceDecalPropertiesinstance.IFaceDecalPropertiesInstance.TextureFilename;
        }
        public static Int32 TextureFilenameID(IFaceDecalPropertiesObject IFaceDecalPropertiesinstance)
        {
            return IFaceDecalPropertiesinstance.IFaceDecalPropertiesInstance.TextureFilenameID;
        }
        public static Int32 TextureRenderMode(IFaceDecalPropertiesObject IFaceDecalPropertiesinstance)
        {
            return IFaceDecalPropertiesinstance.IFaceDecalPropertiesInstance.TextureRenderMode;
        }
        public static Double TextureTranslationU(IFaceDecalPropertiesObject IFaceDecalPropertiesinstance)
        {
            return IFaceDecalPropertiesinstance.IFaceDecalPropertiesInstance.TextureTranslationU;
        }
        public static Double TextureTranslationV(IFaceDecalPropertiesObject IFaceDecalPropertiesinstance)
        {
            return IFaceDecalPropertiesinstance.IFaceDecalPropertiesInstance.TextureTranslationV;
        }
        public static Double TextureAngleUV(IFaceDecalPropertiesObject IFaceDecalPropertiesinstance)
        {
            return IFaceDecalPropertiesinstance.IFaceDecalPropertiesInstance.TextureAngleUV;
        }
        public static Boolean TextureMirrored(IFaceDecalPropertiesObject IFaceDecalPropertiesinstance)
        {
            return IFaceDecalPropertiesinstance.IFaceDecalPropertiesInstance.TextureMirrored;
        }
        public static Int32 TextureMapID(IFaceDecalPropertiesObject IFaceDecalPropertiesinstance)
        {
            return IFaceDecalPropertiesinstance.IFaceDecalPropertiesInstance.TextureMapID;
        }
        public static Int32 TextureID(IFaceDecalPropertiesObject IFaceDecalPropertiesinstance)
        {
            return IFaceDecalPropertiesinstance.IFaceDecalPropertiesInstance.TextureID;
        }
    }
}