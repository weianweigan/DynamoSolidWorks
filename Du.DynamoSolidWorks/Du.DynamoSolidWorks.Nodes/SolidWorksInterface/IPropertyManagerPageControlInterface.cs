using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using SolidWorks.Interop.swconst;
using DynamoSolidWorks;
using Du.SolidWorks.Extension;
using Autodesk.DesignScript.Runtime;
using Du.DynamoSolidWorks.Nodes;

namespace DynamoSolidWorks
{
   public class IPropertyManagerPageControlObject
    {
         public IPropertyManagerPageControl IPropertyManagerPageControlInstance { get; set; }
        public IPropertyManagerPageControlObject(IPropertyManagerPageControl IPropertyManagerPageControlinstance)
        {
                IPropertyManagerPageControlInstance = IPropertyManagerPageControlinstance;
        }
    }
   public static class IPropertyManagerPageControlInterface
   {
  public static Boolean SetStandardPictureLabel(IPropertyManagerPageControlObject IPropertyManagerPageControlinstance,Int32 Bitmap)
     {
            return IPropertyManagerPageControlinstance.IPropertyManagerPageControlInstance.SetStandardPictureLabel(Bitmap);
       }
  public static Boolean SetPictureLabelByName(IPropertyManagerPageControlObject IPropertyManagerPageControlinstance,String ColorBitmap,String MaskBitmap)
     {
            return IPropertyManagerPageControlinstance.IPropertyManagerPageControlInstance.SetPictureLabelByName(ColorBitmap,MaskBitmap);
       }
  public static IPropertyManagerPageGroupObject GetGroupBox(IPropertyManagerPageControlObject IPropertyManagerPageControlinstance)
     {
            return new IPropertyManagerPageGroupObject(IPropertyManagerPageControlinstance.IPropertyManagerPageControlInstance.GetGroupBox());
       }
  public static void ShowBubbleTooltip(IPropertyManagerPageControlObject IPropertyManagerPageControlinstance,String Title,String Message,String BmpFile)
     {
            return IPropertyManagerPageControlinstance.IPropertyManagerPageControlInstance.ShowBubbleTooltip(Title,Message,BmpFile);
       }
  public static Boolean Visible(IPropertyManagerPageControlObject IPropertyManagerPageControlinstance)
      {
            return IPropertyManagerPageControlinstance.IPropertyManagerPageControlInstance.Visible;
      }
  public static Boolean Enabled(IPropertyManagerPageControlObject IPropertyManagerPageControlinstance)
      {
            return IPropertyManagerPageControlinstance.IPropertyManagerPageControlInstance.Enabled;
      }
  public static String Tip(IPropertyManagerPageControlObject IPropertyManagerPageControlinstance)
      {
            return IPropertyManagerPageControlinstance.IPropertyManagerPageControlInstance.Tip;
      }
  public static Int16 Left(IPropertyManagerPageControlObject IPropertyManagerPageControlinstance)
      {
            return IPropertyManagerPageControlinstance.IPropertyManagerPageControlInstance.Left;
      }
  public static Int16 Width(IPropertyManagerPageControlObject IPropertyManagerPageControlinstance)
      {
            return IPropertyManagerPageControlinstance.IPropertyManagerPageControlInstance.Width;
      }
  public static Int16 Top(IPropertyManagerPageControlObject IPropertyManagerPageControlinstance)
      {
            return IPropertyManagerPageControlinstance.IPropertyManagerPageControlInstance.Top;
      }
  public static Int32 TextColor(IPropertyManagerPageControlObject IPropertyManagerPageControlinstance)
      {
            return IPropertyManagerPageControlinstance.IPropertyManagerPageControlInstance.TextColor;
      }
  public static Int32 BackgroundColor(IPropertyManagerPageControlObject IPropertyManagerPageControlinstance)
      {
            return IPropertyManagerPageControlinstance.IPropertyManagerPageControlInstance.BackgroundColor;
      }
  public static Int32 OptionsForResize(IPropertyManagerPageControlObject IPropertyManagerPageControlinstance)
      {
            return IPropertyManagerPageControlinstance.IPropertyManagerPageControlInstance.OptionsForResize;
      }
    }
}