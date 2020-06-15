using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDetailingDefaultsObject
    {
        public IDetailingDefaults IDetailingDefaultsInstance { get; set; }
        public IDetailingDefaultsObject(IDetailingDefaults IDetailingDefaultsinstance)
        {
            IDetailingDefaultsInstance = IDetailingDefaultsinstance;
        }
    }
    public static class IDetailingDefaultsInterface
    {
        public static Object GetAllValues(IDetailingDefaultsObject IDetailingDefaultsinstance)
        {
            return IDetailingDefaultsinstance.IDetailingDefaultsInstance.GetAllValues();
        }
        public static Double IGetAllValues(IDetailingDefaultsObject IDetailingDefaultsinstance, Int32 Count)
        {
            return IDetailingDefaultsinstance.IDetailingDefaultsInstance.IGetAllValues(Count);
        }
        public static Object GetTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance)
        {
            return IDetailingDefaultsinstance.IDetailingDefaultsInstance.GetTextFormat();
        }
        public static ITextFormatObject IGetTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance)
        {
            return new ITextFormatObject(IDetailingDefaultsinstance.IDetailingDefaultsInstance.IGetTextFormat());
        }
        public static void SetTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance, Object TextFormat)
        {
            IDetailingDefaultsinstance.IDetailingDefaultsInstance.SetTextFormat(TextFormat);
        }
        public static void ISetTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance, ITextFormatObject TextFormat)
        {
            IDetailingDefaultsinstance.IDetailingDefaultsInstance.ISetTextFormat(TextFormat.ITextFormatInstance as TextFormat);
        }
        public static Object GetDimensionTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance)
        {
            return IDetailingDefaultsinstance.IDetailingDefaultsInstance.GetDimensionTextFormat();
        }
        public static ITextFormatObject IGetDimensionTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance)
        {
            return new ITextFormatObject(IDetailingDefaultsinstance.IDetailingDefaultsInstance.IGetDimensionTextFormat());
        }
        public static void SetDimensionTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance, Object TextFormat)
        {
            IDetailingDefaultsinstance.IDetailingDefaultsInstance.SetDimensionTextFormat(TextFormat);
        }
        public static void ISetDimensionTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance, ITextFormatObject TextFormat)
        {
            IDetailingDefaultsinstance.IDetailingDefaultsInstance.ISetDimensionTextFormat(TextFormat.ITextFormatInstance as TextFormat);
        }
        public static Object GetSectionTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance)
        {
            return IDetailingDefaultsinstance.IDetailingDefaultsInstance.GetSectionTextFormat();
        }
        public static ITextFormatObject IGetSectionTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance)
        {
            return new ITextFormatObject(IDetailingDefaultsinstance.IDetailingDefaultsInstance.IGetSectionTextFormat());
        }
        public static void SetSectionTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance, Object TextFormat)
        {
            IDetailingDefaultsinstance.IDetailingDefaultsInstance.SetSectionTextFormat(TextFormat);
        }
        public static void ISetSectionTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance, ITextFormatObject TextFormat)
        {
            IDetailingDefaultsinstance.IDetailingDefaultsInstance.ISetSectionTextFormat(TextFormat.ITextFormatInstance as TextFormat);
        }
        public static Object GetDetailTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance)
        {
            return IDetailingDefaultsinstance.IDetailingDefaultsInstance.GetDetailTextFormat();
        }
        public static ITextFormatObject IGetDetailTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance)
        {
            return new ITextFormatObject(IDetailingDefaultsinstance.IDetailingDefaultsInstance.IGetDetailTextFormat());
        }
        public static void SetDetailTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance, Object TextFormat)
        {
            IDetailingDefaultsinstance.IDetailingDefaultsInstance.SetDetailTextFormat(TextFormat);
        }
        public static void ISetDetailTextFormat(IDetailingDefaultsObject IDetailingDefaultsinstance, ITextFormatObject TextFormat)
        {
            IDetailingDefaultsinstance.IDetailingDefaultsInstance.ISetDetailTextFormat(TextFormat.ITextFormatInstance as TextFormat);
        }
    }
}