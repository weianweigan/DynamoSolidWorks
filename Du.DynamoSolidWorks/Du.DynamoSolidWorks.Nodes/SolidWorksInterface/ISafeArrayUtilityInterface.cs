using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISafeArrayUtilityObject
    {
        public ISafeArrayUtility ISafeArrayUtilityInstance { get; set; }
        public ISafeArrayUtilityObject(ISafeArrayUtility ISafeArrayUtilityinstance)
        {
            ISafeArrayUtilityInstance = ISafeArrayUtilityinstance;
        }
    }
    public static class ISafeArrayUtilityInterface
    {
        //public static void PackVariant(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object& VariantArray, Int32 Count, Int32 Type, Int32& Data)
        //{
        //    return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.PackVariant(VariantArray, Count, Type, Data);
        //}
        public static Int32 UnPackVariant(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object VariantArray, Int32 Count)
        {
            return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.UnPackVariant(VariantArray, Count);
        }
        //public static void GetInfo(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object VariantArray, Int32& Count, Int32& Type)
        //{
        //    return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.GetInfo(VariantArray, Count, Type);
        //}
        //public static void PutLongLong(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object& VariantArray, Int32 Index, Int64 Value)
        //{
        //    return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.PutLongLong(VariantArray, Index, Value);
        //}
        //public static void PutDispatch(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object& VariantArray, Int32 Index, Object Value)
        //{
        //    return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.PutDispatch(VariantArray, Index, Value);
        //}
        //public static void PutBstr(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object& VariantArray, Int32 Index, String Value)
        //{
        //    return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.PutBstr(VariantArray, Index, Value);
        //}
        //public static void PutBoolean(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object& VariantArray, Int32 Index, Boolean Value)
        //{
        //    return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.PutBoolean(VariantArray, Index, Value);
        //}
        //public static void PutByte(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object& VariantArray, Int32 Index, Byte Value)
        //{
        //    return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.PutByte(VariantArray, Index, Value);
        //}
        //public static void PutLong(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object& VariantArray, Int32 Index, Int32 Value)
        //{
        //    return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.PutLong(VariantArray, Index, Value);
        //}
        //public static void PutDouble(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object& VariantArray, Int32 Index, Double Value)
        //{
        //    return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.PutDouble(VariantArray, Index, Value);
        //}
        //public static void PutShort(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object& VariantArray, Int32 Index, Int16 Value)
        //{
        //    return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.PutShort(VariantArray, Index, Value);
        //}
        //public static void PutUNKNOWN(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object& VariantArray, Int32 Index, Object Value)
        //{
        //    return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.PutUNKNOWN(VariantArray, Index, Value);
        //}
        public static Object GetUNKNOWN(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object VariantArray, Int32 Index)
        {
            return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.GetUNKNOWN(VariantArray, Index);
        }
        public static Int64 GetLongLong(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object VariantArray, Int32 Index)
        {
            return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.GetLongLong(VariantArray, Index);
        }
        public static Object GetDispatch(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object VariantArray, Int32 Index)
        {
            return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.GetDispatch(VariantArray, Index);
        }
        public static String GetBstr(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object VariantArray, Int32 Index)
        {
            return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.GetBstr(VariantArray, Index);
        }
        public static Boolean GetBoolean(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object VariantArray, Int32 Index)
        {
            return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.GetBoolean(VariantArray, Index);
        }
        public static Byte GetByte(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object VariantArray, Int32 Index)
        {
            return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.GetByte(VariantArray, Index);
        }
        public static Int32 GetLong(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object VariantArray, Int32 Index)
        {
            return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.GetLong(VariantArray, Index);
        }
        public static Double GetDouble(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object VariantArray, Int32 Index)
        {
            return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.GetDouble(VariantArray, Index);
        }
        public static Int16 GetShort(ISafeArrayUtilityObject ISafeArrayUtilityinstance, Object VariantArray, Int32 Index)
        {
            return ISafeArrayUtilityinstance.ISafeArrayUtilityInstance.GetShort(VariantArray, Index);
        }
    }
}