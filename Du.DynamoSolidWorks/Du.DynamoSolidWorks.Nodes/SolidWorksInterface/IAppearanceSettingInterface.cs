using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IAppearanceSettingObject
    {
        public IAppearanceSetting IAppearanceSettingInstance { get; set; }
        public IAppearanceSettingObject(IAppearanceSetting IAppearanceSettinginstance)
        {
            IAppearanceSettingInstance = IAppearanceSettinginstance;
        }
    }
    public static class IAppearanceSettingInterface
    {
        public static Int32 Color(IAppearanceSettingObject IAppearanceSettinginstance)
        {
            return IAppearanceSettinginstance.IAppearanceSettingInstance.Color;
        }
        public static Double Diffuse(IAppearanceSettingObject IAppearanceSettinginstance)
        {
            return IAppearanceSettinginstance.IAppearanceSettingInstance.Diffuse;
        }
        public static Double Specular(IAppearanceSettingObject IAppearanceSettinginstance)
        {
            return IAppearanceSettinginstance.IAppearanceSettingInstance.Specular;
        }
        public static Int32 SpecularColor(IAppearanceSettingObject IAppearanceSettinginstance)
        {
            return IAppearanceSettinginstance.IAppearanceSettingInstance.SpecularColor;
        }
        public static Double SpecularSpread(IAppearanceSettingObject IAppearanceSettinginstance)
        {
            return IAppearanceSettinginstance.IAppearanceSettingInstance.SpecularSpread;
        }
        public static Double Reflection(IAppearanceSettingObject IAppearanceSettinginstance)
        {
            return IAppearanceSettinginstance.IAppearanceSettingInstance.Reflection;
        }
        public static Boolean BlurryReflection(IAppearanceSettingObject IAppearanceSettinginstance)
        {
            return IAppearanceSettinginstance.IAppearanceSettingInstance.BlurryReflection;
        }
        public static Double Transparent(IAppearanceSettingObject IAppearanceSettinginstance)
        {
            return IAppearanceSettinginstance.IAppearanceSettingInstance.Transparent;
        }
        public static Double Luminous(IAppearanceSettingObject IAppearanceSettinginstance)
        {
            return IAppearanceSettinginstance.IAppearanceSettingInstance.Luminous;
        }
        public static Double RoundSharpEdges(IAppearanceSettingObject IAppearanceSettinginstance)
        {
            return IAppearanceSettinginstance.IAppearanceSettingInstance.RoundSharpEdges;
        }
        public static Boolean DoubleSided(IAppearanceSettingObject IAppearanceSettinginstance)
        {
            return IAppearanceSettinginstance.IAppearanceSettingInstance.DoubleSided;
        }
    }
}