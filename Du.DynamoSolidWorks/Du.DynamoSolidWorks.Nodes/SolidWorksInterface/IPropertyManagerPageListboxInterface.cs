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
   public class IPropertyManagerPageListboxObject
    {
         public IPropertyManagerPageListbox IPropertyManagerPageListboxInstance { get; set; }
        public IPropertyManagerPageListboxObject(IPropertyManagerPageListbox IPropertyManagerPageListboxinstance)
        {
                IPropertyManagerPageListboxInstance = IPropertyManagerPageListboxinstance;
        }
    }
   public static class IPropertyManagerPageListboxInterface
   {
  public static void AddItems(IPropertyManagerPageListboxObject IPropertyManagerPageListboxinstance,Object Texts)
     {
            return IPropertyManagerPageListboxinstance.IPropertyManagerPageListboxInstance.AddItems(Texts);
       }
  public static void IAddItems(IPropertyManagerPageListboxObject IPropertyManagerPageListboxinstance,Int16 TextCount,String& Texts)
     {
            return IPropertyManagerPageListboxinstance.IPropertyManagerPageListboxInstance.IAddItems(TextCount,Texts);
       }
  public static void Clear(IPropertyManagerPageListboxObject IPropertyManagerPageListboxinstance)
     {
            return IPropertyManagerPageListboxinstance.IPropertyManagerPageListboxInstance.Clear();
       }
  public static Int16 InsertItem(IPropertyManagerPageListboxObject IPropertyManagerPageListboxinstance,Int16 Item,String Text)
     {
            return IPropertyManagerPageListboxinstance.IPropertyManagerPageListboxInstance.InsertItem(Item,Text);
       }
  public static Int16 DeleteItem(IPropertyManagerPageListboxObject IPropertyManagerPageListboxinstance,Int16 Item)
     {
            return IPropertyManagerPageListboxinstance.IPropertyManagerPageListboxInstance.DeleteItem(Item);
       }
  public static Int32 GetSelectedItemsCount(IPropertyManagerPageListboxObject IPropertyManagerPageListboxinstance)
     {
            return IPropertyManagerPageListboxinstance.IPropertyManagerPageListboxInstance.GetSelectedItemsCount();
       }
  public static Object GetSelectedItems(IPropertyManagerPageListboxObject IPropertyManagerPageListboxinstance)
     {
            return IPropertyManagerPageListboxinstance.IPropertyManagerPageListboxInstance.GetSelectedItems();
       }
  public static Int16 IGetSelectedItems(IPropertyManagerPageListboxObject IPropertyManagerPageListboxinstance,Int32 Count)
     {
            return IPropertyManagerPageListboxinstance.IPropertyManagerPageListboxInstance.IGetSelectedItems(Count);
       }
  public static Boolean SetSelectedItem(IPropertyManagerPageListboxObject IPropertyManagerPageListboxinstance,Int16 Item,Boolean Selected)
     {
            return IPropertyManagerPageListboxinstance.IPropertyManagerPageListboxInstance.SetSelectedItem(Item,Selected);
       }
  public static Int16 CurrentSelection(IPropertyManagerPageListboxObject IPropertyManagerPageListboxinstance)
      {
            return IPropertyManagerPageListboxinstance.IPropertyManagerPageListboxInstance.CurrentSelection;
      }
  public static Int16 Height(IPropertyManagerPageListboxObject IPropertyManagerPageListboxinstance)
      {
            return IPropertyManagerPageListboxinstance.IPropertyManagerPageListboxInstance.Height;
      }
  public static String ItemText(IPropertyManagerPageListboxObject IPropertyManagerPageListboxinstance)
      {
            return IPropertyManagerPageListboxinstance.IPropertyManagerPageListboxInstance.ItemText;
      }
  public static Int32 Style(IPropertyManagerPageListboxObject IPropertyManagerPageListboxinstance)
      {
            return IPropertyManagerPageListboxinstance.IPropertyManagerPageListboxInstance.Style;
      }
  public static Int32 ItemCount(IPropertyManagerPageListboxObject IPropertyManagerPageListboxinstance)
      {
            return IPropertyManagerPageListboxinstance.IPropertyManagerPageListboxInstance.ItemCount;
      }
    }
}