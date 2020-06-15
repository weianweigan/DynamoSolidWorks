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
   public class IPropertyManagerPageBitmapObject
    {
         public IPropertyManagerPageBitmap IPropertyManagerPageBitmapInstance { get; set; }
        public IPropertyManagerPageBitmapObject(IPropertyManagerPageBitmap IPropertyManagerPageBitmapinstance)
        {
                IPropertyManagerPageBitmapInstance = IPropertyManagerPageBitmapinstance;
        }
    }
   public static class IPropertyManagerPageBitmapInterface
   {
  public static Boolean SetStandardBitmap(IPropertyManagerPageBitmapObject IPropertyManagerPageBitmapinstance,Int32 Bitmap)
     {
            return IPropertyManagerPageBitmapinstance.IPropertyManagerPageBitmapInstance.SetStandardBitmap(Bitmap);
       }
  public static Boolean SetBitmapByName(IPropertyManagerPageBitmapObject IPropertyManagerPageBitmapinstance,String ColorBitmap,String MaskBitmap)
     {
            return IPropertyManagerPageBitmapinstance.IPropertyManagerPageBitmapInstance.SetBitmapByName(ColorBitmap,MaskBitmap);
       }
    }
}