using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRefAxisObject
    {
        public IRefAxis IRefAxisInstance { get; set; }
        public IRefAxisObject(IRefAxis IRefAxisinstance)
        {
            IRefAxisInstance = IRefAxisinstance;
        }
    }
    public static class IRefAxisInterface
    {
        public static Object GetRefAxisParams(IRefAxisObject IRefAxisinstance)
        {
            return IRefAxisinstance.IRefAxisInstance.GetRefAxisParams();
        }
        public static Double IGetRefAxisParams(IRefAxisObject IRefAxisinstance)
        {
            return IRefAxisinstance.IRefAxisInstance.IGetRefAxisParams();
        }
        public static Boolean IsTempAxis(IRefAxisObject IRefAxisinstance)
        {
            return IRefAxisinstance.IRefAxisInstance.IsTempAxis();
        }
        public static Object GetTempAxisReferenceFace(IRefAxisObject IRefAxisinstance)
        {
            return IRefAxisinstance.IRefAxisInstance.GetTempAxisReferenceFace();
        }
    }
}