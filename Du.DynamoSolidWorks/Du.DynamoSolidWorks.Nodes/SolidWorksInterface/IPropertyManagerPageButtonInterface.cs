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
   public class IPropertyManagerPageButtonObject
    {
         public IPropertyManagerPageButton IPropertyManagerPageButtonInstance { get; set; }
        public IPropertyManagerPageButtonObject(IPropertyManagerPageButton IPropertyManagerPageButtoninstance)
        {
                IPropertyManagerPageButtonInstance = IPropertyManagerPageButtoninstance;
        }
    }
   public static class IPropertyManagerPageButtonInterface
   {
  public static String Caption(IPropertyManagerPageButtonObject IPropertyManagerPageButtoninstance)
      {
            return IPropertyManagerPageButtoninstance.IPropertyManagerPageButtonInstance.Caption;
      }
    }
}