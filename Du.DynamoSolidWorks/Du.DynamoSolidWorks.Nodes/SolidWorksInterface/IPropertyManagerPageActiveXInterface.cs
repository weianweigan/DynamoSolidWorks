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
   public class IPropertyManagerPageActiveXObject
    {
         public IPropertyManagerPageActiveX IPropertyManagerPageActiveXInstance { get; set; }
        public IPropertyManagerPageActiveXObject(IPropertyManagerPageActiveX IPropertyManagerPageActiveXinstance)
        {
                IPropertyManagerPageActiveXInstance = IPropertyManagerPageActiveXinstance;
        }
    }
   public static class IPropertyManagerPageActiveXInterface
   {
  public static Boolean SetClass(IPropertyManagerPageActiveXObject IPropertyManagerPageActiveXinstance,String ClassID,String LicenseKey)
     {
            return IPropertyManagerPageActiveXinstance.IPropertyManagerPageActiveXInstance.SetClass(ClassID,LicenseKey);
       }
  public static Object GetControl(IPropertyManagerPageActiveXObject IPropertyManagerPageActiveXinstance)
     {
            return IPropertyManagerPageActiveXinstance.IPropertyManagerPageActiveXInstance.GetControl();
       }
  public static Object IGetControl(IPropertyManagerPageActiveXObject IPropertyManagerPageActiveXinstance)
     {
            return IPropertyManagerPageActiveXinstance.IPropertyManagerPageActiveXInstance.IGetControl();
       }
  public static Int16 Height(IPropertyManagerPageActiveXObject IPropertyManagerPageActiveXinstance)
      {
            return IPropertyManagerPageActiveXinstance.IPropertyManagerPageActiveXInstance.Height;
      }
    }
}