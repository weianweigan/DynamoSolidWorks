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
   public class IPropertyManagerPageSliderObject
    {
         public IPropertyManagerPageSlider IPropertyManagerPageSliderInstance { get; set; }
        public IPropertyManagerPageSliderObject(IPropertyManagerPageSlider IPropertyManagerPageSliderinstance)
        {
                IPropertyManagerPageSliderInstance = IPropertyManagerPageSliderinstance;
        }
    }
   public static class IPropertyManagerPageSliderInterface
   {
  public static void GetRange(IPropertyManagerPageSliderObject IPropertyManagerPageSliderinstance,Int32& Min,Int32& Max)
     {
            return IPropertyManagerPageSliderinstance.IPropertyManagerPageSliderInstance.GetRange(Min,Max);
       }
  public static Boolean SetRange(IPropertyManagerPageSliderObject IPropertyManagerPageSliderinstance,Int32 Min,Int32 Max)
     {
            return IPropertyManagerPageSliderinstance.IPropertyManagerPageSliderInstance.SetRange(Min,Max);
       }
  public static Int32 Style(IPropertyManagerPageSliderObject IPropertyManagerPageSliderinstance)
      {
            return IPropertyManagerPageSliderinstance.IPropertyManagerPageSliderInstance.Style;
      }
  public static Int32 Position(IPropertyManagerPageSliderObject IPropertyManagerPageSliderinstance)
      {
            return IPropertyManagerPageSliderinstance.IPropertyManagerPageSliderInstance.Position;
      }
  public static Int32 TickFrequency(IPropertyManagerPageSliderObject IPropertyManagerPageSliderinstance)
      {
            return IPropertyManagerPageSliderinstance.IPropertyManagerPageSliderInstance.TickFrequency;
      }
  public static Int16 Height(IPropertyManagerPageSliderObject IPropertyManagerPageSliderinstance)
      {
            return IPropertyManagerPageSliderinstance.IPropertyManagerPageSliderInstance.Height;
      }
  public static Int32 LineSize(IPropertyManagerPageSliderObject IPropertyManagerPageSliderinstance)
      {
            return IPropertyManagerPageSliderinstance.IPropertyManagerPageSliderInstance.LineSize;
      }
  public static Int32 PageSize(IPropertyManagerPageSliderObject IPropertyManagerPageSliderinstance)
      {
            return IPropertyManagerPageSliderinstance.IPropertyManagerPageSliderInstance.PageSize;
      }
    }
}