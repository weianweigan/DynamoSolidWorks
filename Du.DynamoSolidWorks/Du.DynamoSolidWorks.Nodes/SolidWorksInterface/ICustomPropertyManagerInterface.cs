using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICustomPropertyManagerObject
    {
        public ICustomPropertyManager ICustomPropertyManagerInstance { get; set; }
        public ICustomPropertyManagerObject(ICustomPropertyManager ICustomPropertyManagerinstance)
        {
            ICustomPropertyManagerInstance = ICustomPropertyManagerinstance;
        }
    }
    public static class ICustomPropertyManagerInterface
    {
        public static Object GetNames(ICustomPropertyManagerObject ICustomPropertyManagerinstance)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.GetNames();
        }
        public static String IGetNames(ICustomPropertyManagerObject ICustomPropertyManagerinstance, Int32 Count)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.IGetNames(Count);
        }
        public static String GetType(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.GetType(FieldName);
        }
        public static String Get(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Get(FieldName);
        }
        public static Int32 Set(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName, String FieldValue)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Set(FieldName, FieldValue);
        }
        public static Int32 Add(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName, String FieldType, String FieldValue)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Add(FieldName, FieldType, FieldValue);
        }
        public static Int32 Delete(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Delete(FieldName);
        }
        //public static void Get2(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName, String& ValOut, String& ReesolvedValOut)
        //{
        //    return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Get2(FieldName, ValOut, ReesolvedValOut);
        //}
        public static Int32 GetType2(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.GetType2(FieldName);
        }
        public static Int32 Add2(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName, Int32 FieldType, String FieldValue)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Add2(FieldName, FieldType, FieldValue);
        }
        //public static Int32 GetAll(ICustomPropertyManagerObject ICustomPropertyManagerinstance, Object& PropNames, Object& PropTypes, Object& PropValues)
        //{
        //    return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.GetAll(PropNames, PropTypes, PropValues);
        //}
        //public static void IGetAll(ICustomPropertyManagerObject ICustomPropertyManagerinstance, Int32 Count, String& PropNames, Int32& PropTypes, String& PropValues)
        //{
        //    return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.IGetAll(Count, PropNames, PropTypes, PropValues);
        //}
        //public static Boolean Get3(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName, Boolean UseCached, String& ValOut, String& ResolvedValOut)
        //{
        //    return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Get3(FieldName, UseCached, ValOut, ResolvedValOut);
        //}
        //public static Boolean Get4(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName, Boolean UseCached, String& ValOut, String& ResolvedValOut)
        //{
        //    return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Get4(FieldName, UseCached, ValOut, ResolvedValOut);
        //}
        //public static Int32 Get5(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName, Boolean UseCached, String& ValOut, String& ResolvedValOut, Boolean& WasResolved)
        //{
        //    return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Get5(FieldName, UseCached, ValOut, ResolvedValOut, WasResolved);
        //}
        public static Int32 Add3(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName, Int32 FieldType, String FieldValue, Int32 OverwriteExisting)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Add3(FieldName, FieldType, FieldValue, OverwriteExisting);
        }
        //public static Int32 GetAll2(ICustomPropertyManagerObject ICustomPropertyManagerinstance, Object& PropNames, Object& PropTypes, Object& PropValues, Object& Resolved)
        //{
        //    return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.GetAll2(PropNames, PropTypes, PropValues, Resolved);
        //}
        public static Int32 Delete2(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Delete2(FieldName);
        }
        public static Int32 Set2(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName, String FieldValue)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Set2(FieldName, FieldValue);
        }
        public static Boolean IsCustomPropertyEditable(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String PropertyName, String ConfigurationName)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.IsCustomPropertyEditable(PropertyName, ConfigurationName);
        }
        //public static Int32 Get6(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName, Boolean UseCached, String& ValOut, String& ResolvedValOut, Boolean& WasResolved, Boolean& LinkToProperty)
        //{
        //    return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Get6(FieldName, UseCached, ValOut, ResolvedValOut, WasResolved, LinkToProperty);
        //}
        //public static Int32 GetAll3(ICustomPropertyManagerObject ICustomPropertyManagerinstance, Object& PropNames, Object& PropTypes, Object& PropValues, Object& Resolved, Object& PropLink)
        //{
        //    return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.GetAll3(PropNames, PropTypes, PropValues, Resolved, PropLink);
        //}
        public static Int32 LinkProperty(ICustomPropertyManagerObject ICustomPropertyManagerinstance, String FieldName, Boolean FieldLink)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.LinkProperty(FieldName, FieldLink);
        }
        public static Object Owner(ICustomPropertyManagerObject ICustomPropertyManagerinstance)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Owner;
        }
        public static Int32 Count(ICustomPropertyManagerObject ICustomPropertyManagerinstance)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.Count;
        }
        public static Boolean LinkAll(ICustomPropertyManagerObject ICustomPropertyManagerinstance)
        {
            return ICustomPropertyManagerinstance.ICustomPropertyManagerInstance.LinkAll;
        }
    }
}