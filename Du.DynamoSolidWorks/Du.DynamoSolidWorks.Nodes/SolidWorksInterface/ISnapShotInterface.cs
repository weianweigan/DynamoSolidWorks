using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISnapShotObject
    {
        public ISnapShot ISnapShotInstance { get; set; }
        public ISnapShotObject(ISnapShot ISnapShotinstance)
        {
            ISnapShotInstance = ISnapShotinstance;
        }
    }
    public static class ISnapShotInterface
    {
        public static Boolean Activate(ISnapShotObject ISnapShotinstance)
        {
            return ISnapShotinstance.ISnapShotInstance.Activate();
        }
        public static String Name(ISnapShotObject ISnapShotinstance)
        {
            return ISnapShotinstance.ISnapShotInstance.Name;
        }
        public static String Comment(ISnapShotObject ISnapShotinstance)
        {
            return ISnapShotinstance.ISnapShotInstance.Comment;
        }
        public static Int32 ViewId(ISnapShotObject ISnapShotinstance)
        {
            return ISnapShotinstance.ISnapShotInstance.ViewId;
        }
    }
}