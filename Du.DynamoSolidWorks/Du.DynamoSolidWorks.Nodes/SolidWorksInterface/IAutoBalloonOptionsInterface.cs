using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IAutoBalloonOptionsObject
    {
        public IAutoBalloonOptions IAutoBalloonOptionsInstance { get; set; }
        public IAutoBalloonOptionsObject(IAutoBalloonOptions IAutoBalloonOptionsinstance)
        {
            IAutoBalloonOptionsInstance = IAutoBalloonOptionsinstance;
        }
    }
    public static class IAutoBalloonOptionsInterface
    {
        public static Int32 Layout(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.Layout;
        }
        public static Boolean ReverseDirection(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.ReverseDirection;
        }
        public static Boolean IgnoreMultiple(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.IgnoreMultiple;
        }
        public static Boolean LeaderAttachmentToFaces(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.LeaderAttachmentToFaces;
        }
        public static Int32 Style(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.Style;
        }
        public static Int32 Size(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.Size;
        }
        public static Double CustomSize(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.CustomSize;
        }
        public static Int32 UpperTextContent(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.UpperTextContent;
        }
        public static String UpperText(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.UpperText;
        }
        public static Int32 LowerTextContent(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.LowerTextContent;
        }
        public static String LowerText(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.LowerText;
        }
        public static String Layername(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.Layername;
        }
        public static Int32 ItemNumberStart(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.ItemNumberStart;
        }
        public static Int32 ItemNumberIncrement(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.ItemNumberIncrement;
        }
        public static Int32 ItemOrder(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.ItemOrder;
        }
        public static Object FirstItem(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.FirstItem;
        }
        public static Boolean InsertMagneticLine(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.InsertMagneticLine;
        }
        public static Boolean EditBalloons(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.EditBalloons;
        }
        public static Int32 EditBalloonOption(IAutoBalloonOptionsObject IAutoBalloonOptionsinstance)
        {
            return IAutoBalloonOptionsinstance.IAutoBalloonOptionsInstance.EditBalloonOption;
        }
    }
}