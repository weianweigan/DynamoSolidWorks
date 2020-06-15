using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMemberObject
    {
        public IMember IMemberInstance { get; set; }
        public IMemberObject(IMember IMemberinstance)
        {
            IMemberInstance = IMemberinstance;
        }
    }
    public static class IMemberInterface
    {
        public static void Dummy002(IMemberObject IMemberinstance)
        {
            IMemberinstance.IMemberInstance.Dummy002();
        }
        public static void Dummy007(IMemberObject IMemberinstance)
        {
            IMemberinstance.IMemberInstance.Dummy007();
        }
        public static void Dummy003(IMemberObject IMemberinstance)
        {
            IMemberinstance.IMemberInstance.Dummy003();
        }
        public static void Dummy004(IMemberObject IMemberinstance)
        {
            IMemberinstance.IMemberInstance.Dummy004();
        }
        public static void Dummy008(IMemberObject IMemberinstance)
        {
            IMemberinstance.IMemberInstance.Dummy008();
        }
        public static void Dummy005(IMemberObject IMemberinstance)
        {
            IMemberinstance.IMemberInstance.Dummy005();
        }
        public static void Dummy006(IMemberObject IMemberinstance)
        {
            IMemberinstance.IMemberInstance.Dummy006();
        }
        public static void Dummy009(IMemberObject IMemberinstance)
        {
            IMemberinstance.IMemberInstance.Dummy009();
        }
        public static void Dummy010(IMemberObject IMemberinstance)
        {
            IMemberinstance.IMemberInstance.Dummy010();
        }
        public static void Dummy011(IMemberObject IMemberinstance)
        {
            IMemberinstance.IMemberInstance.Dummy011();
        }
        public static String Dummy001(IMemberObject IMemberinstance)
        {
            return IMemberinstance.IMemberInstance.Dummy001;
        }
    }
}