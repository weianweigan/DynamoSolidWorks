using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ICommentFolderObject
    {
        public ICommentFolder ICommentFolderInstance { get; set; }
        public ICommentFolderObject(ICommentFolder ICommentFolderinstance)
        {
            ICommentFolderInstance = ICommentFolderinstance;
        }
    }
    public static class ICommentFolderInterface
    {
        public static IFeatureObject GetFeature(ICommentFolderObject ICommentFolderinstance)
        {
            return new IFeatureObject(ICommentFolderinstance.ICommentFolderInstance.GetFeature());
        }
        public static Int32 GetCommentCount(ICommentFolderObject ICommentFolderinstance)
        {
            return ICommentFolderinstance.ICommentFolderInstance.GetCommentCount();
        }
        public static Object GetComments(ICommentFolderObject ICommentFolderinstance)
        {
            return ICommentFolderinstance.ICommentFolderInstance.GetComments();
        }
        public static ICommentObject IGetComments(ICommentFolderObject ICommentFolderinstance, Int32 Count)
        {
            return new ICommentObject(ICommentFolderinstance.ICommentFolderInstance.IGetComments(Count));
        }
        public static ICommentObject AddComment(ICommentFolderObject ICommentFolderinstance, String Text)
        {
            return new ICommentObject(ICommentFolderinstance.ICommentFolderInstance.AddComment(Text));
        }
    }
}