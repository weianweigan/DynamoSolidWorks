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
   public class IPropertyManagerPage2Object
    {
         public IPropertyManagerPage2 IPropertyManagerPage2Instance { get; set; }
        public IPropertyManagerPage2Object(IPropertyManagerPage2 IPropertyManagerPage2instance)
        {
                IPropertyManagerPage2Instance = IPropertyManagerPage2instance;
        }
    }
   public static class IPropertyManagerPage2Interface
   {
  public static Boolean SetTitleBitmap(IPropertyManagerPage2Object IPropertyManagerPage2instance,Int32 ModuleHandle,Int32 Identifier)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.SetTitleBitmap(ModuleHandle,Identifier);
       }
  public static Object AddGroupBox(IPropertyManagerPage2Object IPropertyManagerPage2instance,Int32 ID,String Caption,Int32 Options)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.AddGroupBox(ID,Caption,Options);
       }
  public static IPropertyManagerPageGroupObject IAddGroupBox(IPropertyManagerPage2Object IPropertyManagerPage2instance,Int32 ID,String Caption,Int32 Options)
     {
            return new IPropertyManagerPageGroupObject(IPropertyManagerPage2instance.IPropertyManagerPage2Instance.IAddGroupBox(ID,Caption,Options));
       }
  public static Object AddControl(IPropertyManagerPage2Object IPropertyManagerPage2instance,Int32 ID,Int16 ControlType,String Caption,Int16 LeftAlign,Int32 Options,String Tip)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.AddControl(ID,ControlType,Caption,LeftAlign,Options,Tip);
       }
  public static IPropertyManagerPageControlObject IAddControl(IPropertyManagerPage2Object IPropertyManagerPage2instance,Int32 ID,Int16 ControlType,String Caption,Int16 LeftAlign,Int32 Options,String Tip)
     {
            return new IPropertyManagerPageControlObject(IPropertyManagerPage2instance.IPropertyManagerPage2Instance.IAddControl(ID,ControlType,Caption,LeftAlign,Options,Tip));
       }
  public static Boolean SetMessage(IPropertyManagerPage2Object IPropertyManagerPage2instance,String Message,Int32 Visibility)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.SetMessage(Message,Visibility);
       }
  public static Int32 Show(IPropertyManagerPage2Object IPropertyManagerPage2instance)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.Show();
       }
  public static void Close(IPropertyManagerPage2Object IPropertyManagerPage2instance,Boolean Okay)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.Close(Okay);
       }
  public static Boolean EnableButton(IPropertyManagerPage2Object IPropertyManagerPage2instance,Int32 WhichOne,Boolean Enable)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.EnableButton(WhichOne,Enable);
       }
  public static void SetTitleBitmap2(IPropertyManagerPage2Object IPropertyManagerPage2instance,String FilePathName)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.SetTitleBitmap2(FilePathName);
       }
  public static IPropertyManagerPageTabObject AddTab(IPropertyManagerPage2Object IPropertyManagerPage2instance,Int32 ID,String Caption,String Bitmap,Int32 Options)
     {
            return new IPropertyManagerPageTabObject(IPropertyManagerPage2instance.IPropertyManagerPage2Instance.AddTab(ID,Caption,Bitmap,Options));
       }
  public static Boolean SetMessage2(IPropertyManagerPage2Object IPropertyManagerPage2instance,String Message,Int32 Visibility,String Caption)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.SetMessage2(Message,Visibility,Caption);
       }
  public static Int32 Show2(IPropertyManagerPage2Object IPropertyManagerPage2instance,Int32 Options)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.Show2(Options);
       }
  public static Boolean AddMenuPopupItem(IPropertyManagerPage2Object IPropertyManagerPage2instance,Int32 ID,String ItemText,Int32 DocumentType,String HintText)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.AddMenuPopupItem(ID,ItemText,DocumentType,HintText);
       }
  public static Boolean SetMessage3(IPropertyManagerPage2Object IPropertyManagerPage2instance,String Message,Int32 Visibility,Int32 Expanded,String Caption)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.SetMessage3(Message,Visibility,Expanded,Caption);
       }
  public static void SetExitConfirmationCursor(IPropertyManagerPage2Object IPropertyManagerPage2instance,Boolean Enable)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.SetExitConfirmationCursor(Enable);
       }
  public static void SetCursor(IPropertyManagerPage2Object IPropertyManagerPage2instance,Int32 Mode)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.SetCursor(Mode);
       }
  public static Int32 GetFocus(IPropertyManagerPage2Object IPropertyManagerPage2instance)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.GetFocus();
       }
  public static Boolean SetFocus(IPropertyManagerPage2Object IPropertyManagerPage2instance,Int32 ID)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.SetFocus(ID);
       }
  public static Boolean SetTitleBitmapx64(IPropertyManagerPage2Object IPropertyManagerPage2instance,Int64 ModuleHandle,Int32 Identifier)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.SetTitleBitmapx64(ModuleHandle,Identifier);
       }
  public static Object AddControl2(IPropertyManagerPage2Object IPropertyManagerPage2instance,Int32 ID,Int16 ControlType,String Caption,Int16 LeftAlign,Int32 Options,String Tip)
     {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.AddControl2(ID,ControlType,Caption,LeftAlign,Options,Tip);
       }
  public static Boolean Pinned(IPropertyManagerPage2Object IPropertyManagerPage2instance)
      {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.Pinned;
      }
  public static String Title(IPropertyManagerPage2Object IPropertyManagerPage2instance)
      {
            return IPropertyManagerPage2instance.IPropertyManagerPage2Instance.Title;
      }
    }
}