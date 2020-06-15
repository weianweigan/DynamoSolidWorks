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
   public class IPropertyManagerPageWindowFromHandleObject
    {
         public IPropertyManagerPageWindowFromHandle IPropertyManagerPageWindowFromHandleInstance { get; set; }
        public IPropertyManagerPageWindowFromHandleObject(IPropertyManagerPageWindowFromHandle IPropertyManagerPageWindowFromHandleinstance)
        {
                IPropertyManagerPageWindowFromHandleInstance = IPropertyManagerPageWindowFromHandleinstance;
        }
    }
   public static class IPropertyManagerPageWindowFromHandleInterface
   {
  public static Boolean SetWindowHandle(IPropertyManagerPageWindowFromHandleObject IPropertyManagerPageWindowFromHandleinstance,Int32 WindowHandle)
     {
            return IPropertyManagerPageWindowFromHandleinstance.IPropertyManagerPageWindowFromHandleInstance.SetWindowHandle(WindowHandle);
       }
  public static Boolean SetWindowHandlex64(IPropertyManagerPageWindowFromHandleObject IPropertyManagerPageWindowFromHandleinstance,Int64 WindowHandle)
     {
            return IPropertyManagerPageWindowFromHandleinstance.IPropertyManagerPageWindowFromHandleInstance.SetWindowHandlex64(WindowHandle);
       }
  public static Int32 Height(IPropertyManagerPageWindowFromHandleObject IPropertyManagerPageWindowFromHandleinstance)
      {
            return IPropertyManagerPageWindowFromHandleinstance.IPropertyManagerPageWindowFromHandleInstance.Height;
      }
    }
}