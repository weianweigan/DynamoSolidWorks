using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IUserProgressBarObject
    {
        public IUserProgressBar IUserProgressBarInstance { get; set; }
        public IUserProgressBarObject(IUserProgressBar IUserProgressBarinstance)
        {
            IUserProgressBarInstance = IUserProgressBarinstance;
        }
    }
    public static class IUserProgressBarInterface
    {
        public static Boolean Start(IUserProgressBarObject IUserProgressBarinstance, Int32 LowerBound, Int32 UpperBound, String ProgressBarTitle)
        {
            return IUserProgressBarinstance.IUserProgressBarInstance.Start(LowerBound, UpperBound, ProgressBarTitle);
        }
        public static Int32 UpdateProgress(IUserProgressBarObject IUserProgressBarinstance, Int32 Position)
        {
            return IUserProgressBarinstance.IUserProgressBarInstance.UpdateProgress(Position);
        }
        public static Boolean UpdateTitle(IUserProgressBarObject IUserProgressBarinstance, String ProgressBarTitle)
        {
            return IUserProgressBarinstance.IUserProgressBarInstance.UpdateTitle(ProgressBarTitle);
        }
        public static Boolean End(IUserProgressBarObject IUserProgressBarinstance)
        {
            return IUserProgressBarinstance.IUserProgressBarInstance.End();
        }
    }
}