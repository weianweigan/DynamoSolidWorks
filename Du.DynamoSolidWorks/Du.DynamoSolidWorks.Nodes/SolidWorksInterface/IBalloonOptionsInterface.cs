using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IBalloonOptionsObject
    {
        public IBalloonOptions IBalloonOptionsInstance { get; set; }
        public IBalloonOptionsObject(IBalloonOptions IBalloonOptionsinstance)
        {
            IBalloonOptionsInstance = IBalloonOptionsinstance;
        }
    }
    public static class IBalloonOptionsInterface
    {
        public static Int32 Style(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.Style;
        }
        public static Int32 Size(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.Size;
        }
        public static Double CustomSize(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.CustomSize;
        }
        public static Int32 UpperTextContent(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.UpperTextContent;
        }
        public static String UpperText(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.UpperText;
        }
        public static Int32 LowerTextContent(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.LowerTextContent;
        }
        public static String LowerText(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.LowerText;
        }
        public static Boolean ShowQuantity(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.ShowQuantity;
        }
        public static Int32 QuantityPlacement(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.QuantityPlacement;
        }
        public static String QuantityDenotationText(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.QuantityDenotationText;
        }
        public static Boolean QuantityOverride(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.QuantityOverride;
        }
        public static String QuantityOverrideValue(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.QuantityOverrideValue;
        }
        public static Int32 ItemNumberStart(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.ItemNumberStart;
        }
        public static Int32 ItemNumberIncrement(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.ItemNumberIncrement;
        }
        public static Int32 ItemOrder(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.ItemOrder;
        }
        public static String Layername(IBalloonOptionsObject IBalloonOptionsinstance)
        {
            return IBalloonOptionsinstance.IBalloonOptionsInstance.Layername;
        }
    }
}