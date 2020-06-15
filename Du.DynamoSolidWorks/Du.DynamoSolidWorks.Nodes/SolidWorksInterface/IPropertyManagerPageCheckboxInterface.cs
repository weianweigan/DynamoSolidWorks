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
   public class IPropertyManagerPageCheckboxObject
    {
         public IPropertyManagerPageCheckbox IPropertyManagerPageCheckboxInstance { get; set; }
        public IPropertyManagerPageCheckboxObject(IPropertyManagerPageCheckbox IPropertyManagerPageCheckboxinstance)
        {
                IPropertyManagerPageCheckboxInstance = IPropertyManagerPageCheckboxinstance;
        }
    }
   public static class IPropertyManagerPageCheckboxInterface
   {
  public static Boolean Checked(IPropertyManagerPageCheckboxObject IPropertyManagerPageCheckboxinstance)
      {
            return IPropertyManagerPageCheckboxinstance.IPropertyManagerPageCheckboxInstance.Checked;
      }
  public static String Caption(IPropertyManagerPageCheckboxObject IPropertyManagerPageCheckboxinstance)
      {
            return IPropertyManagerPageCheckboxinstance.IPropertyManagerPageCheckboxInstance.Caption;
      }
  public static Int32 State(IPropertyManagerPageCheckboxObject IPropertyManagerPageCheckboxinstance)
      {
            return IPropertyManagerPageCheckboxinstance.IPropertyManagerPageCheckboxInstance.State;
      }
    }
}