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
   public class IPropertyManagerPageGroupObject
    {
         public IPropertyManagerPageGroup IPropertyManagerPageGroupInstance { get; set; }
        public IPropertyManagerPageGroupObject(IPropertyManagerPageGroup IPropertyManagerPageGroupinstance)
        {
                IPropertyManagerPageGroupInstance = IPropertyManagerPageGroupinstance;
        }
    }
   public static class IPropertyManagerPageGroupInterface
   {
  public static Object AddControl(IPropertyManagerPageGroupObject IPropertyManagerPageGroupinstance,Int32 ID,Int16 ControlType,String Caption,Int16 LeftAlign,Int32 Options,String Tip)
     {
            return IPropertyManagerPageGroupinstance.IPropertyManagerPageGroupInstance.AddControl(ID,ControlType,Caption,LeftAlign,Options,Tip);
       }
  public static IPropertyManagerPageControlObject IAddControl(IPropertyManagerPageGroupObject IPropertyManagerPageGroupinstance,Int32 ID,Int16 ControlType,String Caption,Int16 LeftAlign,Int32 Options,String Tip)
     {
            return new IPropertyManagerPageControlObject(IPropertyManagerPageGroupinstance.IPropertyManagerPageGroupInstance.IAddControl(ID,ControlType,Caption,LeftAlign,Options,Tip));
       }
  public static Object AddControl2(IPropertyManagerPageGroupObject IPropertyManagerPageGroupinstance,Int32 ID,Int16 ControlType,String Caption,Int16 LeftAlign,Int32 Options,String Tip)
     {
            return IPropertyManagerPageGroupinstance.IPropertyManagerPageGroupInstance.AddControl2(ID,ControlType,Caption,LeftAlign,Options,Tip);
       }
  public static Boolean Visible(IPropertyManagerPageGroupObject IPropertyManagerPageGroupinstance)
      {
            return IPropertyManagerPageGroupinstance.IPropertyManagerPageGroupInstance.Visible;
      }
  public static Boolean Expanded(IPropertyManagerPageGroupObject IPropertyManagerPageGroupinstance)
      {
            return IPropertyManagerPageGroupinstance.IPropertyManagerPageGroupInstance.Expanded;
      }
  public static Boolean Checked(IPropertyManagerPageGroupObject IPropertyManagerPageGroupinstance)
      {
            return IPropertyManagerPageGroupinstance.IPropertyManagerPageGroupInstance.Checked;
      }
  public static String Caption(IPropertyManagerPageGroupObject IPropertyManagerPageGroupinstance)
      {
            return IPropertyManagerPageGroupinstance.IPropertyManagerPageGroupInstance.Caption;
      }
  public static Int32 BackgroundColor(IPropertyManagerPageGroupObject IPropertyManagerPageGroupinstance)
      {
            return IPropertyManagerPageGroupinstance.IPropertyManagerPageGroupInstance.BackgroundColor;
      }
    }
}