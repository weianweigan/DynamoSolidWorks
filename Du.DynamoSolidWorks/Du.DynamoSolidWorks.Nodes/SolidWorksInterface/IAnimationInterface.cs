using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IAnimationObject
    {
        public IAnimation IAnimationInstance { get; set; }
        public IAnimationObject(IAnimation IAnimationinstance)
        {
            IAnimationInstance = IAnimationinstance;
        }
    }
    public static class IAnimationInterface
    {
        public static Boolean Play(IAnimationObject IAnimationinstance)
        {
            return IAnimationinstance.IAnimationInstance.Play();
        }
        public static Boolean Pause(IAnimationObject IAnimationinstance)
        {
            return IAnimationinstance.IAnimationInstance.Pause();
        }
        public static Boolean Stop(IAnimationObject IAnimationinstance)
        {
            return IAnimationinstance.IAnimationInstance.Stop();
        }
        public static Boolean Beginning(IAnimationObject IAnimationinstance)
        {
            return IAnimationinstance.IAnimationInstance.Beginning();
        }
        public static Boolean End(IAnimationObject IAnimationinstance)
        {
            return IAnimationinstance.IAnimationInstance.End();
        }
        public static Boolean Close(IAnimationObject IAnimationinstance)
        {
            return IAnimationinstance.IAnimationInstance.Close();
        }
        public static Double Duration(IAnimationObject IAnimationinstance)
        {
            return IAnimationinstance.IAnimationInstance.Duration;
        }
        public static Int32 Speed(IAnimationObject IAnimationinstance)
        {
            return IAnimationinstance.IAnimationInstance.Speed;
        }
        public static Int32 PlayMode(IAnimationObject IAnimationinstance)
        {
            return IAnimationinstance.IAnimationInstance.PlayMode;
        }
    }
}