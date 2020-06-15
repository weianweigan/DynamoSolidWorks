using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IProjectionArrowObject
    {
        public IProjectionArrow IProjectionArrowInstance { get; set; }
        public IProjectionArrowObject(IProjectionArrow IProjectionArrowinstance)
        {
            IProjectionArrowInstance = IProjectionArrowinstance;
        }
    }
    public static class IProjectionArrowInterface
    {
        public static Object GetView(IProjectionArrowObject IProjectionArrowinstance)
        {
            return IProjectionArrowinstance.IProjectionArrowInstance.GetView();
        }
        public static IViewObject IGetView(IProjectionArrowObject IProjectionArrowinstance)
        {
            return new IViewObject(IProjectionArrowinstance.IProjectionArrowInstance.IGetView());
        }
        public static Object GetProjectedView(IProjectionArrowObject IProjectionArrowinstance)
        {
            return IProjectionArrowinstance.IProjectionArrowInstance.GetProjectedView();
        }
        public static IViewObject IGetProjectedView(IProjectionArrowObject IProjectionArrowinstance)
        {
            return new IViewObject(IProjectionArrowinstance.IProjectionArrowInstance.IGetProjectedView());
        }
        public static String GetLabel(IProjectionArrowObject IProjectionArrowinstance)
        {
            return IProjectionArrowinstance.IProjectionArrowInstance.GetLabel();
        }
        public static Boolean SetLabel(IProjectionArrowObject IProjectionArrowinstance, String Label)
        {
            return IProjectionArrowinstance.IProjectionArrowInstance.SetLabel(Label);
        }
        public static Boolean GetUseDocTextFormat(IProjectionArrowObject IProjectionArrowinstance)
        {
            return IProjectionArrowinstance.IProjectionArrowInstance.GetUseDocTextFormat();
        }
        public static Object GetTextFormat(IProjectionArrowObject IProjectionArrowinstance)
        {
            return IProjectionArrowinstance.IProjectionArrowInstance.GetTextFormat();
        }
        public static ITextFormatObject IGetTextFormat(IProjectionArrowObject IProjectionArrowinstance)
        {
            return new ITextFormatObject(IProjectionArrowinstance.IProjectionArrowInstance.IGetTextFormat());
        }
        public static Object GetCoordinates(IProjectionArrowObject IProjectionArrowinstance)
        {
            return IProjectionArrowinstance.IProjectionArrowInstance.GetCoordinates();
        }
        public static Double IGetCoordinates(IProjectionArrowObject IProjectionArrowinstance)
        {
            return IProjectionArrowinstance.IProjectionArrowInstance.IGetCoordinates();
        }
        public static Boolean Visible(IProjectionArrowObject IProjectionArrowinstance)
        {
            return IProjectionArrowinstance.IProjectionArrowInstance.Visible;
        }
    }
}