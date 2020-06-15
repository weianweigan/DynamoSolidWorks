using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDetailCircleObject
    {
        public IDetailCircle IDetailCircleInstance { get; set; }
        public IDetailCircleObject(IDetailCircle IDetailCircleinstance)
        {
            IDetailCircleInstance = IDetailCircleinstance;
        }
    }
    public static class IDetailCircleInterface
    {
        public static IViewObject GetView(IDetailCircleObject IDetailCircleinstance)
        {
            return new IViewObject(IDetailCircleinstance.IDetailCircleInstance.GetView());
        }
        public static IViewObject GetDetailView(IDetailCircleObject IDetailCircleinstance)
        {
            return new IViewObject(IDetailCircleinstance.IDetailCircleInstance.GetDetailView());
        }
        public static String GetLabel(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.GetLabel();
        }
        public static ITextFormatObject GetTextFormat(IDetailCircleObject IDetailCircleinstance)
        {
            return new ITextFormatObject(IDetailCircleinstance.IDetailCircleInstance.GetTextFormat());
        }
        public static String GetName(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.GetName();
        }
        public static Object GetArrowInfo(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.GetArrowInfo();
        }
        public static Double IGetArrowInfo(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.IGetArrowInfo();
        }
        public static Int32 GetStyle(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.GetStyle();
        }
        public static Int32 GetDisplay(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.GetDisplay();
        }
        public static Object GetConnectingLine(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.GetConnectingLine();
        }
        public static Double IGetConnectingLine(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.IGetConnectingLine();
        }
        public static Boolean HasFullOutline(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.HasFullOutline();
        }
        public static Object GetLeaderInfo(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.GetLeaderInfo();
        }
        public static Double IGetLeaderInfo(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.IGetLeaderInfo();
        }
        public static Boolean GetUseDocTextFormat(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.GetUseDocTextFormat();
        }
        public static Boolean SetTextFormat(IDetailCircleObject IDetailCircleinstance, Boolean UseDoc, ITextFormatObject TextFormat)
        {
            return IDetailCircleinstance.IDetailCircleInstance.SetTextFormat(UseDoc, TextFormat.ITextFormatInstance as TextFormat);
        }
        public static Boolean SetLabel(IDetailCircleObject IDetailCircleinstance, String Label)
        {
            return IDetailCircleinstance.IDetailCircleInstance.SetLabel(Label);
        }
        public static Boolean SetName(IDetailCircleObject IDetailCircleinstance, String Name)
        {
            return IDetailCircleinstance.IDetailCircleInstance.SetName(Name);
        }
        public static Boolean SetStyle(IDetailCircleObject IDetailCircleinstance, Int32 Style)
        {
            return IDetailCircleinstance.IDetailCircleInstance.SetStyle(Style);
        }
        public static Boolean SetDisplay(IDetailCircleObject IDetailCircleinstance, Int32 Display)
        {
            return IDetailCircleinstance.IDetailCircleInstance.SetDisplay(Display);
        }
        public static Boolean SetFullOutline(IDetailCircleObject IDetailCircleinstance, Boolean FullOutline)
        {
            return IDetailCircleinstance.IDetailCircleInstance.SetFullOutline(FullOutline);
        }
        public static Boolean Select(IDetailCircleObject IDetailCircleinstance, Boolean Append, ISelectDataObject Data)
        {
            return IDetailCircleinstance.IDetailCircleInstance.Select(Append, Data.ISelectDataInstance as SelectData);
        }
        public static Boolean SetParameters(IDetailCircleObject IDetailCircleinstance, Double XPosition, Double YPosition, Double Radius)
        {
            return IDetailCircleinstance.IDetailCircleInstance.SetParameters(XPosition, YPosition, Radius);
        }
        public static Int32 GetProfileItemsCount(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.GetProfileItemsCount();
        }
        public static Object GetProfileItems(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.GetProfileItems();
        }
        public static ISketchSegmentObject IGetProfileItems(IDetailCircleObject IDetailCircleinstance, Int32 Count)
        {
            return new ISketchSegmentObject(IDetailCircleinstance.IDetailCircleInstance.IGetProfileItems(Count));
        }
        public static void SetLabelPosition(IDetailCircleObject IDetailCircleinstance, Double XPosition, Double YPosition)
        {
            IDetailCircleinstance.IDetailCircleInstance.SetLabelPosition(XPosition, YPosition);
        }
        //public static void GetLabelPosition(IDetailCircleObject IDetailCircleinstance, Double& XPosition, Double& YPosition)
        //{
        //    return IDetailCircleinstance.IDetailCircleInstance.GetLabelPosition(XPosition, YPosition);
        //}
        public static String Layer(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.Layer;
        }
        public static Boolean PinPosition(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.PinPosition;
        }
        public static Boolean ScaleHatchPattern(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.ScaleHatchPattern;
        }
        public static Boolean JaggedOutline(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.JaggedOutline;
        }
        public static Boolean NoOutline(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.NoOutline;
        }
        public static Int32 ShapeIntensity(IDetailCircleObject IDetailCircleinstance)
        {
            return IDetailCircleinstance.IDetailCircleInstance.ShapeIntensity;
        }
    }
}