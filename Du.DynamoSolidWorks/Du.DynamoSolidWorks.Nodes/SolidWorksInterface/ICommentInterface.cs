using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICommentObject
    {
        public IComment ICommentInstance { get; set; }
        public ICommentObject(IComment ICommentinstance)
        {
            ICommentInstance = ICommentinstance;
        }
    }
    public static class ICommentInterface
    {
        public static Boolean Delete(ICommentObject ICommentinstance)
        {
            return ICommentinstance.ICommentInstance.Delete();
        }
        public static String Text(ICommentObject ICommentinstance)
        {
            return ICommentinstance.ICommentInstance.Text;
        }
        public static String Name(ICommentObject ICommentinstance)
        {
            return ICommentinstance.ICommentInstance.Name;
        }
        public static IFeatureObject FeatureOwner(ICommentObject ICommentinstance)
        {
            return new IFeatureObject(ICommentinstance.ICommentInstance.FeatureOwner);
        }
    }
}