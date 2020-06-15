using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IStackedBalloonOptionsObject
    {
        public IStackedBalloonOptions IStackedBalloonOptionsInstance { get; set; }
        public IStackedBalloonOptionsObject(IStackedBalloonOptions IStackedBalloonOptionsinstance)
        {
            IStackedBalloonOptionsInstance = IStackedBalloonOptionsinstance;
        }
    }
    public static class IStackedBalloonOptionsInterface
    {
        public static Int32 Style(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.Style;
        }
        public static Int32 Size(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.Size;
        }
        public static Double CustomSize(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.CustomSize;
        }
        public static Int32 UpperTextContent(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.UpperTextContent;
        }
        public static String UpperText(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.UpperText;
        }
        public static Int32 LowerTextContent(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.LowerTextContent;
        }
        public static String LowerText(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.LowerText;
        }
        public static Int32 BalloonsPerLine(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.BalloonsPerLine;
        }
        public static Boolean ShowQuantity(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.ShowQuantity;
        }
        public static Int32 QuantityPlacement(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.QuantityPlacement;
        }
        public static String QuantityDenotationText(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.QuantityDenotationText;
        }
        public static Boolean QuantityOverride(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.QuantityOverride;
        }
        public static String QuantityOverrideValue(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.QuantityOverrideValue;
        }
        public static Int32 StackDirection(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.StackDirection;
        }
        public static Int32 ItemNumberStart(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.ItemNumberStart;
        }
        public static Int32 ItemNumberIncrement(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.ItemNumberIncrement;
        }
        public static Int32 ItemOrder(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.ItemOrder;
        }
        public static String Layername(IStackedBalloonOptionsObject IStackedBalloonOptionsinstance)
        {
            return IStackedBalloonOptionsinstance.IStackedBalloonOptionsInstance.Layername;
        }
    }
}