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
   public class IPropertyManagerPageTextboxObject
    {
         public IPropertyManagerPageTextbox IPropertyManagerPageTextboxInstance { get; set; }
        public IPropertyManagerPageTextboxObject(IPropertyManagerPageTextbox IPropertyManagerPageTextboxinstance)
        {
                IPropertyManagerPageTextboxInstance = IPropertyManagerPageTextboxinstance;
        }
    }
   public static class IPropertyManagerPageTextboxInterface
   {
  public static String Text(IPropertyManagerPageTextboxObject IPropertyManagerPageTextboxinstance)
      {
            return IPropertyManagerPageTextboxinstance.IPropertyManagerPageTextboxInstance.Text;
      }
  public static Int32 Style(IPropertyManagerPageTextboxObject IPropertyManagerPageTextboxinstance)
      {
            return IPropertyManagerPageTextboxinstance.IPropertyManagerPageTextboxInstance.Style;
      }
  public static Int16 Height(IPropertyManagerPageTextboxObject IPropertyManagerPageTextboxinstance)
      {
            return IPropertyManagerPageTextboxinstance.IPropertyManagerPageTextboxInstance.Height;
      }
    }
}