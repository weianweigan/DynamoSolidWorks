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
   public class IPropertyManagerPageSelectionboxObject
    {
         public IPropertyManagerPageSelectionbox IPropertyManagerPageSelectionboxInstance { get; set; }
        public IPropertyManagerPageSelectionboxObject(IPropertyManagerPageSelectionbox IPropertyManagerPageSelectionboxinstance)
        {
                IPropertyManagerPageSelectionboxInstance = IPropertyManagerPageSelectionboxinstance;
        }
    }
   public static class IPropertyManagerPageSelectionboxInterface
   {
  public static void SetSelectionFilters(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance,Object Filters)
     {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.SetSelectionFilters(Filters);
       }
  public static void ISetSelectionFilters(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance,Int16 FilterCount,Int32& Filters)
     {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.ISetSelectionFilters(FilterCount,Filters);
       }
  public static Boolean GetSelectionFocus(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
     {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.GetSelectionFocus();
       }
  public static void SetSelectionFocus(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
     {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.SetSelectionFocus();
       }
  public static Boolean SetSelectionColor(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance,Boolean Special,Int32 Color)
     {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.SetSelectionColor(Special,Color);
       }
  public static Boolean SetCalloutLabel(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance,String Label)
     {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.SetCalloutLabel(Label);
       }
  public static Boolean AddMenuPopupItem(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance,Int32 ID,String ItemText,Int32 DocumentType,String HintText)
     {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.AddMenuPopupItem(ID,ItemText,DocumentType,HintText);
       }
  public static Int32 GetSelectedItemsCount(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
     {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.GetSelectedItemsCount();
       }
  public static Object GetSelectedItems(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
     {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.GetSelectedItems();
       }
  public static Int16 IGetSelectedItems(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance,Int32 Count)
     {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.IGetSelectedItems(Count);
       }
  public static Boolean SetSelectedItem(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance,Int16 Item,Boolean Selected)
     {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.SetSelectedItem(Item,Selected);
       }
  public static Int16 Height(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
      {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.Height;
      }
  public static Int32 Mark(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
      {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.Mark;
      }
  public static Boolean SingleEntityOnly(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
      {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.SingleEntityOnly;
      }
  public static ICalloutObject Callout(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
      {
            return new ICalloutObject(IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.Callout);
      }
  public static Int32 Style(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
      {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.Style;
      }
  public static Int32 ItemCount(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
      {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.ItemCount;
      }
  public static Int32 CurrentSelection(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
      {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.CurrentSelection;
      }
  public static Int32 SelectionIndex(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
      {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.SelectionIndex;
      }
  public static Boolean AllowSelectInMultipleBoxes(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
      {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.AllowSelectInMultipleBoxes;
      }
  public static Boolean AllowMultipleSelectOfSameEntity(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
      {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.AllowMultipleSelectOfSameEntity;
      }
  public static String ItemText(IPropertyManagerPageSelectionboxObject IPropertyManagerPageSelectionboxinstance)
      {
            return IPropertyManagerPageSelectionboxinstance.IPropertyManagerPageSelectionboxInstance.ItemText;
      }
    }
}