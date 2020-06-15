using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ITextAndCustomPropertyObject
    {
        public ITextAndCustomProperty ITextAndCustomPropertyInstance { get; set; }
        public ITextAndCustomPropertyObject(ITextAndCustomProperty ITextAndCustomPropertyinstance)
        {
            ITextAndCustomPropertyInstance = ITextAndCustomPropertyinstance;
        }
    }
    public static class ITextAndCustomPropertyInterface
    {
        public static String Name(ITextAndCustomPropertyObject ITextAndCustomPropertyinstance)
        {
            return ITextAndCustomPropertyinstance.ITextAndCustomPropertyInstance.Name;
        }
        public static String Description(ITextAndCustomPropertyObject ITextAndCustomPropertyinstance)
        {
            return ITextAndCustomPropertyinstance.ITextAndCustomPropertyInstance.Description;
        }
        public static Boolean IsCustomProperty(ITextAndCustomPropertyObject ITextAndCustomPropertyinstance)
        {
            return ITextAndCustomPropertyinstance.ITextAndCustomPropertyInstance.IsCustomProperty;
        }
        public static String CustomPropertyName(ITextAndCustomPropertyObject ITextAndCustomPropertyinstance)
        {
            return ITextAndCustomPropertyinstance.ITextAndCustomPropertyInstance.CustomPropertyName;
        }
        public static String Value(ITextAndCustomPropertyObject ITextAndCustomPropertyinstance)
        {
            return ITextAndCustomPropertyinstance.ITextAndCustomPropertyInstance.Value;
        }
    }
}