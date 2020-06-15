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
   public class IPropertyManagerPageLabelObject
    {
         public IPropertyManagerPageLabel IPropertyManagerPageLabelInstance { get; set; }
        public IPropertyManagerPageLabelObject(IPropertyManagerPageLabel IPropertyManagerPageLabelinstance)
        {
                IPropertyManagerPageLabelInstance = IPropertyManagerPageLabelinstance;
        }
    }
   public static class IPropertyManagerPageLabelInterface
   {
  public static String Caption(IPropertyManagerPageLabelObject IPropertyManagerPageLabelinstance)
      {
            return IPropertyManagerPageLabelinstance.IPropertyManagerPageLabelInstance.Caption;
      }
  public static Int32 Style(IPropertyManagerPageLabelObject IPropertyManagerPageLabelinstance)
      {
            return IPropertyManagerPageLabelinstance.IPropertyManagerPageLabelInstance.Style;
      }
  public static Int16 Height(IPropertyManagerPageLabelObject IPropertyManagerPageLabelinstance)
      {
            return IPropertyManagerPageLabelinstance.IPropertyManagerPageLabelInstance.Height;
      }
  public static Boolean Bold(IPropertyManagerPageLabelObject IPropertyManagerPageLabelinstance)
      {
            return IPropertyManagerPageLabelinstance.IPropertyManagerPageLabelInstance.Bold;
      }
  public static Boolean Italic(IPropertyManagerPageLabelObject IPropertyManagerPageLabelinstance)
      {
            return IPropertyManagerPageLabelinstance.IPropertyManagerPageLabelInstance.Italic;
      }
  public static Int32 Underline(IPropertyManagerPageLabelObject IPropertyManagerPageLabelinstance)
      {
            return IPropertyManagerPageLabelinstance.IPropertyManagerPageLabelInstance.Underline;
      }
  public static String Font(IPropertyManagerPageLabelObject IPropertyManagerPageLabelinstance)
      {
            return IPropertyManagerPageLabelinstance.IPropertyManagerPageLabelInstance.Font;
      }
  public static Double SizeRatio(IPropertyManagerPageLabelObject IPropertyManagerPageLabelinstance)
      {
            return IPropertyManagerPageLabelinstance.IPropertyManagerPageLabelInstance.SizeRatio;
      }
  public static Double LineOffset(IPropertyManagerPageLabelObject IPropertyManagerPageLabelinstance)
      {
            return IPropertyManagerPageLabelinstance.IPropertyManagerPageLabelInstance.LineOffset;
      }
  public static Int32 CharacterColor(IPropertyManagerPageLabelObject IPropertyManagerPageLabelinstance)
      {
            return IPropertyManagerPageLabelinstance.IPropertyManagerPageLabelInstance.CharacterColor;
      }
  public static Int32 CharacterBackgroundColor(IPropertyManagerPageLabelObject IPropertyManagerPageLabelinstance)
      {
            return IPropertyManagerPageLabelinstance.IPropertyManagerPageLabelInstance.CharacterBackgroundColor;
      }
    }
}