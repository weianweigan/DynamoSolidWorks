using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IColorTableObject
    {
        public IColorTable IColorTableInstance { get; set; }
        public IColorTableObject(IColorTable IColorTableinstance)
        {
            IColorTableInstance = IColorTableinstance;
        }
    }
    public static class IColorTableInterface
    {
        public static Int32 GetCount(IColorTableObject IColorTableinstance)
        {
            return IColorTableinstance.IColorTableInstance.GetCount();
        }
        public static String GetNameAtIndex(IColorTableObject IColorTableinstance, Int32 Index)
        {
            return IColorTableinstance.IColorTableInstance.GetNameAtIndex(Index);
        }
        public static Int32 GetColorRefAtIndex(IColorTableObject IColorTableinstance, Int32 Index)
        {
            return IColorTableinstance.IColorTableInstance.GetColorRefAtIndex(Index);
        }
        public static Int32 GetStandardCount(IColorTableObject IColorTableinstance)
        {
            return IColorTableinstance.IColorTableInstance.GetStandardCount();
        }
        public static void SetColorRefAtIndex(IColorTableObject IColorTableinstance, Int32 Index, Int32 ColorRef, Int32 ApplyTo)
        {
            IColorTableinstance.IColorTableInstance.SetColorRefAtIndex(Index, ColorRef, ApplyTo);
        }
        public static Int32 GetBasicColorCount(IColorTableObject IColorTableinstance)
        {
            return IColorTableinstance.IColorTableInstance.GetBasicColorCount();
        }
        public static Object GetBasicColors(IColorTableObject IColorTableinstance)
        {
            return IColorTableinstance.IColorTableInstance.GetBasicColors();
        }
        public static Int32 IGetBasicColors(IColorTableObject IColorTableinstance, Int32 ColorCount)
        {
            return IColorTableinstance.IColorTableInstance.IGetBasicColors(ColorCount);
        }
        public static Int32 GetCustomColorCount(IColorTableObject IColorTableinstance)
        {
            return IColorTableinstance.IColorTableInstance.GetCustomColorCount();
        }
        public static Object GetCustomColors(IColorTableObject IColorTableinstance)
        {
            return IColorTableinstance.IColorTableInstance.GetCustomColors();
        }
        public static Int32 IGetCustomColors(IColorTableObject IColorTableinstance, Int32 ColorCount)
        {
            return IColorTableinstance.IColorTableInstance.IGetCustomColors(ColorCount);
        }
        public static Boolean SetCustomColor(IColorTableObject IColorTableinstance, Int32 Index, Int32 ColorRef)
        {
            return IColorTableinstance.IColorTableInstance.SetCustomColor(Index, ColorRef);
        }
    }
}