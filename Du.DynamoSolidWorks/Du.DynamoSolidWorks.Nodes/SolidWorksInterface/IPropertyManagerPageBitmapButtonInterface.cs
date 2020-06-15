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
   public class IPropertyManagerPageBitmapButtonObject
    {
         public IPropertyManagerPageBitmapButton IPropertyManagerPageBitmapButtonInstance { get; set; }
        public IPropertyManagerPageBitmapButtonObject(IPropertyManagerPageBitmapButton IPropertyManagerPageBitmapButtoninstance)
        {
                IPropertyManagerPageBitmapButtonInstance = IPropertyManagerPageBitmapButtoninstance;
        }
    }
   public static class IPropertyManagerPageBitmapButtonInterface
   {
  public static Boolean SetBitmaps(IPropertyManagerPageBitmapButtonObject IPropertyManagerPageBitmapButtoninstance,Int32 ModuleHandle,Int32 BitmapUp,Int32 BitmapDown,Int32 BitmapDisabled)
     {
            return IPropertyManagerPageBitmapButtoninstance.IPropertyManagerPageBitmapButtonInstance.SetBitmaps(ModuleHandle,BitmapUp,BitmapDown,BitmapDisabled);
       }
  public static Boolean SetStandardBitmaps(IPropertyManagerPageBitmapButtonObject IPropertyManagerPageBitmapButtoninstance,Int32 Bitmap)
     {
            return IPropertyManagerPageBitmapButtoninstance.IPropertyManagerPageBitmapButtonInstance.SetStandardBitmaps(Bitmap);
       }
  public static Boolean SetBitmapsByName(IPropertyManagerPageBitmapButtonObject IPropertyManagerPageBitmapButtoninstance,String BitmapUp,String BitmapDown,String BitmapDisabled)
     {
            return IPropertyManagerPageBitmapButtoninstance.IPropertyManagerPageBitmapButtonInstance.SetBitmapsByName(BitmapUp,BitmapDown,BitmapDisabled);
       }
  public static Boolean SetBitmapsByName2(IPropertyManagerPageBitmapButtonObject IPropertyManagerPageBitmapButtoninstance,String BitmapOrig,String BitmapMaskOrig)
     {
            return IPropertyManagerPageBitmapButtoninstance.IPropertyManagerPageBitmapButtonInstance.SetBitmapsByName2(BitmapOrig,BitmapMaskOrig);
       }
  public static Boolean SetBitmapsx64(IPropertyManagerPageBitmapButtonObject IPropertyManagerPageBitmapButtoninstance,Int64 ModuleHandle,Int32 BitmapUp,Int32 BitmapDown,Int32 BitmapDisabled)
     {
            return IPropertyManagerPageBitmapButtoninstance.IPropertyManagerPageBitmapButtonInstance.SetBitmapsx64(ModuleHandle,BitmapUp,BitmapDown,BitmapDisabled);
       }
  public static Boolean SetBitmapsByName3(IPropertyManagerPageBitmapButtonObject IPropertyManagerPageBitmapButtoninstance,Object ImageList,Object MaskImageList)
     {
            return IPropertyManagerPageBitmapButtoninstance.IPropertyManagerPageBitmapButtonInstance.SetBitmapsByName3(ImageList,MaskImageList);
       }
  public static Boolean Checked(IPropertyManagerPageBitmapButtonObject IPropertyManagerPageBitmapButtoninstance)
      {
            return IPropertyManagerPageBitmapButtoninstance.IPropertyManagerPageBitmapButtonInstance.Checked;
      }
  public static Boolean IsCheckable(IPropertyManagerPageBitmapButtonObject IPropertyManagerPageBitmapButtoninstance)
      {
            return IPropertyManagerPageBitmapButtoninstance.IPropertyManagerPageBitmapButtonInstance.IsCheckable;
      }
    }
}