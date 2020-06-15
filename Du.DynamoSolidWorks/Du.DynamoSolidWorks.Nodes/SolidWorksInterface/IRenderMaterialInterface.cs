using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRenderMaterialObject
    {
        public IRenderMaterial IRenderMaterialInstance { get; set; }
        public IRenderMaterialObject(IRenderMaterial IRenderMaterialinstance)
        {
            IRenderMaterialInstance = IRenderMaterialinstance;
        }
    }
    public static class IRenderMaterialInterface
    {
        public static Boolean AddEntity(IRenderMaterialObject IRenderMaterialinstance, Object Entity)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.AddEntity(Entity);
        }
        //public static void RemoveAllEntities(IRenderMaterialObject IRenderMaterialinstance)
        //{
        //    return IRenderMaterialinstance.IRenderMaterialInstance.RemoveAllEntities();
        //}
        //public static void GetMaterialIds(IRenderMaterialObject IRenderMaterialinstance, Int32& PWMaterialId1, Int32& PWMaterialId2)
        //{
        //    return IRenderMaterialinstance.IRenderMaterialInstance.GetMaterialIds(PWMaterialId1, PWMaterialId2);
        //}
        //public static void GetUDirection2(IRenderMaterialObject IRenderMaterialinstance, Double& UDir_X, Double& UDir_Y, Double& UDir_Z)
        //{
        //    return IRenderMaterialinstance.IRenderMaterialInstance.GetUDirection2(UDir_X, UDir_Y, UDir_Z);
        //}
        //public static void SetUDirection2(IRenderMaterialObject IRenderMaterialinstance, Double UDir_X, Double UDir_Y, Double UDir_Z)
        //{
        //    return IRenderMaterialinstance.IRenderMaterialInstance.SetUDirection2(UDir_X, UDir_Y, UDir_Z);
        //}
        //public static void GetVDirection2(IRenderMaterialObject IRenderMaterialinstance, Double& VDir_X, Double& VDir_Y, Double& VDir_Z)
        //{
        //    return IRenderMaterialinstance.IRenderMaterialInstance.GetVDirection2(VDir_X, VDir_Y, VDir_Z);
        //}
        //public static void SetVDirection2(IRenderMaterialObject IRenderMaterialinstance, Double VDir_X, Double VDir_Y, Double VDir_Z)
        //{
        //    return IRenderMaterialinstance.IRenderMaterialInstance.SetVDirection2(VDir_X, VDir_Y, VDir_Z);
        //}
        //public static void GetCenterPoint2(IRenderMaterialObject IRenderMaterialinstance, Double& CenterPt_X, Double& CenterPt_Y, Double& CenterPt_Z)
        //{
        //    return IRenderMaterialinstance.IRenderMaterialInstance.GetCenterPoint2(CenterPt_X, CenterPt_Y, CenterPt_Z);
        //}
        //public static void SetCenterPoint2(IRenderMaterialObject IRenderMaterialinstance, Double CenterPt_X, Double CenterPt_Y, Double CenterPt_Z)
        //{
        //    return IRenderMaterialinstance.IRenderMaterialInstance.SetCenterPoint2(CenterPt_X, CenterPt_Y, CenterPt_Z);
        //}
        public static Object GetLinkedDisplayStates(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.GetLinkedDisplayStates();
        }
        public static Boolean SetLinkedDisplayStates(IRenderMaterialObject IRenderMaterialinstance, Int32 DisplayStateOption, Object DisplayStateNames)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.SetLinkedDisplayStates(DisplayStateOption, DisplayStateNames);
        }
        //public static void GetUDirection(IRenderMaterialObject IRenderMaterialinstance, Double& UDir)
        //{
        //    return IRenderMaterialinstance.IRenderMaterialInstance.GetUDirection(UDir);
        //}
        //public static void SetUDirection(IRenderMaterialObject IRenderMaterialinstance, Double& UDir)
        //{
        //    return IRenderMaterialinstance.IRenderMaterialInstance.SetUDirection(UDir);
        //}
        //public static void GetVDirection(IRenderMaterialObject IRenderMaterialinstance, Double& VDir)
        //{
        //    return IRenderMaterialinstance.IRenderMaterialInstance.GetVDirection(VDir);
        //}
        //public static void SetVDirection(IRenderMaterialObject IRenderMaterialinstance, Double& VDir)
        //{
        //    return IRenderMaterialinstance.IRenderMaterialInstance.SetVDirection(VDir);
        //}
        //public static void GetCenterPoint(IRenderMaterialObject IRenderMaterialinstance, Double& CenterPt)
        //{
        //    return IRenderMaterialinstance.IRenderMaterialInstance.GetCenterPoint(CenterPt);
        //}
        //public static void SetCenterPoint(IRenderMaterialObject IRenderMaterialinstance, Double& CenterPt)
        //{
        //    return IRenderMaterialinstance.IRenderMaterialInstance.SetCenterPoint(CenterPt);
        //}
        public static Int32 GetEntitiesCount(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.GetEntitiesCount();
        }
        public static Object GetEntities(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.GetEntities();
        }
        public static Object IGetEntities(IRenderMaterialObject IRenderMaterialinstance, Int32 Count)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.IGetEntities(Count);
        }
        public static Double Ambient(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.Ambient;
        }
        public static Double XPosition(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.XPosition;
        }
        public static Double YPosition(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.YPosition;
        }
        public static Double RotationAngle(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.RotationAngle;
        }
        public static Double Direction1RotationAngle(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.Direction1RotationAngle;
        }
        public static Double Direction2RotationAngle(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.Direction2RotationAngle;
        }
        public static Double Width(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.Width;
        }
        public static Double Height(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.Height;
        }
        public static Boolean WidthMirror(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.WidthMirror;
        }
        public static Boolean HeightMirror(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.HeightMirror;
        }
        public static Boolean FixedAspectRatio(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.FixedAspectRatio;
        }
        public static Boolean FitWidth(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.FitWidth;
        }
        public static Boolean FitHeight(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.FitHeight;
        }
        public static String FileName(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.FileName;
        }
        public static String TextureFilename(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.TextureFilename;
        }
        public static Double Diffuse(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.Diffuse;
        }
        public static Double Specular(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.Specular;
        }
        public static Double Transparency(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.Transparency;
        }
        public static Double Emission(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.Emission;
        }
        public static Int32 MappingType(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.MappingType;
        }
        public static Int32 ProjectionReference(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.ProjectionReference;
        }
        public static Int32 MaterialID(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.MaterialID;
        }
        public static Int32 IlluminationShaderType(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.IlluminationShaderType;
        }
        public static Int32 SpecularColor(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.SpecularColor;
        }
        public static Double Glossy(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.Glossy;
        }
        public static Double Roughness(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.Roughness;
        }
        public static Double Reflectivity(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.Reflectivity;
        }
        public static Double IndexOfRefraction(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.IndexOfRefraction;
        }
        public static Double Translucency(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.Translucency;
        }
        public static Double AnisotropicFloorHeight(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.AnisotropicFloorHeight;
        }
        public static Double AnisotropicCylinderDistance(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.AnisotropicCylinderDistance;
        }
        public static Double AnisotropicBias(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.AnisotropicBias;
        }
        public static Double MetallicMix(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.MetallicMix;
        }
        public static Double MetallicRoughness(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.MetallicRoughness;
        }
        public static Double MetallicScale(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.MetallicScale;
        }
        public static Double MetallicAmplitude(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.MetallicAmplitude;
        }
        public static Int32 MetallicFlakeMaterial(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.MetallicFlakeMaterial;
        }
        public static Boolean AccurateReflections(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.AccurateReflections;
        }
        public static Double BumpBlend(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.BumpBlend;
        }
        public static Int32 BumpMap(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.BumpMap;
        }
        public static Double BumpScale(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.BumpScale;
        }
        public static Double BumpRadius(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.BumpRadius;
        }
        public static Double BumpAmplitude(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.BumpAmplitude;
        }
        public static Int32 BumpDetail(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.BumpDetail;
        }
        public static Double BumpSharpness(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.BumpSharpness;
        }
        public static Double BumpRoughLow(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.BumpRoughLow;
        }
        public static Double BumpRoughHigh(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.BumpRoughHigh;
        }
        public static String BumpTextureFilename(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.BumpTextureFilename;
        }
        public static Double PatternScale(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.PatternScale;
        }
        public static Int32 PrimaryColor(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.PrimaryColor;
        }
        public static Int32 SecondaryColor(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.SecondaryColor;
        }
        public static Int32 TertiaryColor(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.TertiaryColor;
        }
        public static Int32 ColorForm(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.ColorForm;
        }
        public static Boolean LinkToFile(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.LinkToFile;
        }
        public static Boolean CausticsCast(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.CausticsCast;
        }
        public static Boolean CausticsReceive(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.CausticsReceive;
        }
        public static Boolean GlobalIlluminationCast(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.GlobalIlluminationCast;
        }
        public static Boolean GlobalIlluminationReceive(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.GlobalIlluminationReceive;
        }
        public static Boolean BumpUseMappingScale(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.BumpUseMappingScale;
        }
        public static Boolean IgnoreMissingFile(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.IgnoreMissingFile;
        }
        public static Double DensityOfHoles(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.DensityOfHoles;
        }
        public static Int32 TransparencyMappingShaderType(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.TransparencyMappingShaderType;
        }
        public static Double Brightness(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.Brightness;
        }
        public static Int32 ObjectAreaLight(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.ObjectAreaLight;
        }
        public static Double NSamples(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.NSamples;
        }
        public static String ToonShaderTextureFilename(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.ToonShaderTextureFilename;
        }
        public static Double RoundSharpEdges(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.RoundSharpEdges;
        }
        public static Boolean DoubleSided(IRenderMaterialObject IRenderMaterialinstance)
        {
            return IRenderMaterialinstance.IRenderMaterialInstance.DoubleSided;
        }
    }
}