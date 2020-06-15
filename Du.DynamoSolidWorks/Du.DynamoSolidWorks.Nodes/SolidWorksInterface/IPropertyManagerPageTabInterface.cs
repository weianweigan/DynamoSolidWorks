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
   public class IPropertyManagerPageTabObject
    {
         public IPropertyManagerPageTab IPropertyManagerPageTabInstance { get; set; }
        public IPropertyManagerPageTabObject(IPropertyManagerPageTab IPropertyManagerPageTabinstance)
        {
                IPropertyManagerPageTabInstance = IPropertyManagerPageTabinstance;
        }
    }
   public static class IPropertyManagerPageTabInterface
   {
  public static Object AddGroupBox(IPropertyManagerPageTabObject IPropertyManagerPageTabinstance,Int32 ID,String Caption,Int32 Options)
     {
            return IPropertyManagerPageTabinstance.IPropertyManagerPageTabInstance.AddGroupBox(ID,Caption,Options);
       }
  public static IPropertyManagerPageGroupObject IAddGroupBox(IPropertyManagerPageTabObject IPropertyManagerPageTabinstance,Int32 ID,String Caption,Int32 Options)
     {
            return new IPropertyManagerPageGroupObject(IPropertyManagerPageTabinstance.IPropertyManagerPageTabInstance.IAddGroupBox(ID,Caption,Options));
       }
  public static Object AddControl(IPropertyManagerPageTabObject IPropertyManagerPageTabinstance,Int32 ID,Int16 ControlType,String Caption,Int16 LeftAlign,Int32 Options,String Tip)
     {
            return IPropertyManagerPageTabinstance.IPropertyManagerPageTabInstance.AddControl(ID,ControlType,Caption,LeftAlign,Options,Tip);
       }
  public static IPropertyManagerPageControlObject IAddControl(IPropertyManagerPageTabObject IPropertyManagerPageTabinstance,Int32 ID,Int16 ControlType,String Caption,Int16 LeftAlign,Int32 Options,String Tip)
     {
            return new IPropertyManagerPageControlObject(IPropertyManagerPageTabinstance.IPropertyManagerPageTabInstance.IAddControl(ID,ControlType,Caption,LeftAlign,Options,Tip));
       }
  public static Boolean Activate(IPropertyManagerPageTabObject IPropertyManagerPageTabinstance)
     {
            return IPropertyManagerPageTabinstance.IPropertyManagerPageTabInstance.Activate();
       }
  public static Object AddControl2(IPropertyManagerPageTabObject IPropertyManagerPageTabinstance,Int32 ID,Int16 ControlType,String Caption,Int16 LeftAlign,Int32 Options,String Tip)
     {
            return IPropertyManagerPageTabinstance.IPropertyManagerPageTabInstance.AddControl2(ID,ControlType,Caption,LeftAlign,Options,Tip);
       }
  public static String Caption(IPropertyManagerPageTabObject IPropertyManagerPageTabinstance)
      {
            return IPropertyManagerPageTabinstance.IPropertyManagerPageTabInstance.Caption;
      }
    }
}