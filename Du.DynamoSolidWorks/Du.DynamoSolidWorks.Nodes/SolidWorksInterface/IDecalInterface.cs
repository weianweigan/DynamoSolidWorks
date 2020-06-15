using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDecalObject
    {
        public IDecal IDecalInstance { get; set; }
        public IDecalObject(IDecal IDecalinstance)
        {
            IDecalInstance = IDecalinstance;
        }
    }
    public static class IDecalInterface
    {
        public static Int32 GetMaskExcludedColorsCount(IDecalObject IDecalinstance)
        {
            return IDecalinstance.IDecalInstance.GetMaskExcludedColorsCount();
        }
        public static Int32 IGetMaskExcludedColors(IDecalObject IDecalinstance, Int32 Count)
        {
            return IDecalinstance.IDecalInstance.IGetMaskExcludedColors(Count);
        }
        //public static void ISetMaskExcludedColors(IDecalObject IDecalinstance, Int32 Count, Int32& MaskColors)
        //{
        //    return IDecalinstance.IDecalInstance.ISetMaskExcludedColors(Count, MaskColors);
        //}
        public static Int32 DecalID(IDecalObject IDecalinstance)
        {
            return IDecalinstance.IDecalInstance.DecalID;
        }
        public static Boolean Hidden(IDecalObject IDecalinstance)
        {
            return IDecalinstance.IDecalInstance.Hidden;
        }
        public static Int32 MaskType(IDecalObject IDecalinstance)
        {
            return IDecalinstance.IDecalInstance.MaskType;
        }
        public static String MaskFilename(IDecalObject IDecalinstance)
        {
            return IDecalinstance.IDecalInstance.MaskFilename;
        }
        public static Boolean MaskInvert(IDecalObject IDecalinstance)
        {
            return IDecalinstance.IDecalInstance.MaskInvert;
        }
    }
}