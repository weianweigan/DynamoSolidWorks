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
   public class IPropertyManagerPageOptionObject
    {
         public IPropertyManagerPageOption IPropertyManagerPageOptionInstance { get; set; }
        public IPropertyManagerPageOptionObject(IPropertyManagerPageOption IPropertyManagerPageOptioninstance)
        {
                IPropertyManagerPageOptionInstance = IPropertyManagerPageOptioninstance;
        }
    }
   public static class IPropertyManagerPageOptionInterface
   {
  public static Boolean Checked(IPropertyManagerPageOptionObject IPropertyManagerPageOptioninstance)
      {
            return IPropertyManagerPageOptioninstance.IPropertyManagerPageOptionInstance.Checked;
      }
  public static String Caption(IPropertyManagerPageOptionObject IPropertyManagerPageOptioninstance)
      {
            return IPropertyManagerPageOptioninstance.IPropertyManagerPageOptionInstance.Caption;
      }
  public static Int32 Style(IPropertyManagerPageOptionObject IPropertyManagerPageOptioninstance)
      {
            return IPropertyManagerPageOptioninstance.IPropertyManagerPageOptionInstance.Style;
      }
    }
}