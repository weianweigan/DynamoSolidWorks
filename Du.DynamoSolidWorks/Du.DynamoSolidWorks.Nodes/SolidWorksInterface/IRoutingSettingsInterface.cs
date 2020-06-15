using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRoutingSettingsObject
    {
        public IRoutingSettings IRoutingSettingsInstance { get; set; }
        public IRoutingSettingsObject(IRoutingSettings IRoutingSettingsinstance)
        {
            IRoutingSettingsInstance = IRoutingSettingsinstance;
        }
    }
    public static class IRoutingSettingsInterface
    {
        public static String GetRoutingUserPreferenceStringValue(IRoutingSettingsObject IRoutingSettingsinstance, Int32 UserPreference, Boolean UseDefaultVal)
        {
            return IRoutingSettingsinstance.IRoutingSettingsInstance.GetRoutingUserPreferenceStringValue(UserPreference, UseDefaultVal);
        }
        public static Boolean SetRoutingUserPreferenceStringValue(IRoutingSettingsObject IRoutingSettingsinstance, Int32 UserPreference, String Value)
        {
            return IRoutingSettingsinstance.IRoutingSettingsInstance.SetRoutingUserPreferenceStringValue(UserPreference, Value);
        }
        public static Boolean GetRoutingUserPreferenceToggle(IRoutingSettingsObject IRoutingSettingsinstance, Int32 UserPreferenceToggle)
        {
            return IRoutingSettingsinstance.IRoutingSettingsInstance.GetRoutingUserPreferenceToggle(UserPreferenceToggle);
        }
        public static void SetRoutingUserPreferenceToggle(IRoutingSettingsObject IRoutingSettingsinstance, Int32 UserPreferenceValue, Boolean OnFlag)
        {
            IRoutingSettingsinstance.IRoutingSettingsInstance.SetRoutingUserPreferenceToggle(UserPreferenceValue, OnFlag);
        }
        public static Double GetRoutingUserPreferenceDoubleValue(IRoutingSettingsObject IRoutingSettingsinstance, Int32 UserPreferenceValue)
        {
            return IRoutingSettingsinstance.IRoutingSettingsInstance.GetRoutingUserPreferenceDoubleValue(UserPreferenceValue);
        }
        public static Boolean SetRoutingUserPreferenceDoubleValue(IRoutingSettingsObject IRoutingSettingsinstance, Int32 UserPreferenceValue, Double Value)
        {
            return IRoutingSettingsinstance.IRoutingSettingsInstance.SetRoutingUserPreferenceDoubleValue(UserPreferenceValue, Value);
        }
        public static Int32 GetRoutingUserPreferenceIntegerValue(IRoutingSettingsObject IRoutingSettingsinstance, Int32 UserPreferenceValue)
        {
            return IRoutingSettingsinstance.IRoutingSettingsInstance.GetRoutingUserPreferenceIntegerValue(UserPreferenceValue);
        }
        public static Boolean SetRoutingUserPreferenceIntegerValue(IRoutingSettingsObject IRoutingSettingsinstance, Int32 UserPreferenceValue, Int32 Value)
        {
            return IRoutingSettingsinstance.IRoutingSettingsInstance.SetRoutingUserPreferenceIntegerValue(UserPreferenceValue, Value);
        }
        public static void LoadDefaultRoutingSettings(IRoutingSettingsObject IRoutingSettingsinstance)
        {
            IRoutingSettingsinstance.IRoutingSettingsInstance.LoadDefaultRoutingSettings();
        }
        public static Boolean LoadRoutingSettingsFromFile(IRoutingSettingsObject IRoutingSettingsinstance, String RoutingSettingsFilename)
        {
            return IRoutingSettingsinstance.IRoutingSettingsInstance.LoadRoutingSettingsFromFile(RoutingSettingsFilename);
        }
        public static Boolean SaveRoutingSettingsToFile(IRoutingSettingsObject IRoutingSettingsinstance, String RoutingSettingsFilename)
        {
            return IRoutingSettingsinstance.IRoutingSettingsInstance.SaveRoutingSettingsToFile(RoutingSettingsFilename);
        }
        public static Boolean SetFromToListHeaderDefinitions(IRoutingSettingsObject IRoutingSettingsinstance, String WireNameHdr, String FromRefHdr, String FromPinHdr, String FromPartnoHdr, String ToRefHdr, String ToPinHdr, String ToPartnoHdr, String CableNameHdr, String CoreNameHdr, String ColourHdr, String WireSpecHdr, String OtherAttribHdr)
        {
            return IRoutingSettingsinstance.IRoutingSettingsInstance.SetFromToListHeaderDefinitions(WireNameHdr, FromRefHdr, FromPinHdr, FromPartnoHdr, ToRefHdr, ToPinHdr, ToPartnoHdr, CableNameHdr, CoreNameHdr, ColourHdr, WireSpecHdr, OtherAttribHdr);
        }
        //public static Boolean GetFromToListHeaderDefinitions(IRoutingSettingsObject IRoutingSettingsinstance, String& WireNameHdr, String& FromRefHdr, String& FromPinHdr, String& FromPartnoHdr, String& ToRefHdr, String& ToPinHdr, String& ToPartnoHdr, String& CableNameHdr, String& CoreNameHdr, String& ColourHdr, String& WireSpecHdr, String& OtherAttribHdr)
        //{
        //    return IRoutingSettingsinstance.IRoutingSettingsInstance.GetFromToListHeaderDefinitions(WireNameHdr, FromRefHdr, FromPinHdr, FromPartnoHdr, ToRefHdr, ToPinHdr, ToPartnoHdr, CableNameHdr, CoreNameHdr, ColourHdr, WireSpecHdr, OtherAttribHdr);
        //}
    }
}