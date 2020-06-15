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
   public class IPropertyManagerPageComboboxObject
    {
         public IPropertyManagerPageCombobox IPropertyManagerPageComboboxInstance { get; set; }
        public IPropertyManagerPageComboboxObject(IPropertyManagerPageCombobox IPropertyManagerPageComboboxinstance)
        {
                IPropertyManagerPageComboboxInstance = IPropertyManagerPageComboboxinstance;
        }
    }
   public static class IPropertyManagerPageComboboxInterface
   {
  public static void AddItems(IPropertyManagerPageComboboxObject IPropertyManagerPageComboboxinstance,Object Texts)
     {
            return IPropertyManagerPageComboboxinstance.IPropertyManagerPageComboboxInstance.AddItems(Texts);
       }
  public static void IAddItems(IPropertyManagerPageComboboxObject IPropertyManagerPageComboboxinstance,Int16 TextCount,String& Texts)
     {
            return IPropertyManagerPageComboboxinstance.IPropertyManagerPageComboboxInstance.IAddItems(TextCount,Texts);
       }
  public static void Clear(IPropertyManagerPageComboboxObject IPropertyManagerPageComboboxinstance)
     {
            return IPropertyManagerPageComboboxinstance.IPropertyManagerPageComboboxInstance.Clear();
       }
  public static Int16 InsertItem(IPropertyManagerPageComboboxObject IPropertyManagerPageComboboxinstance,Int16 Item,String Text)
     {
            return IPropertyManagerPageComboboxinstance.IPropertyManagerPageComboboxInstance.InsertItem(Item,Text);
       }
  public static Int16 DeleteItem(IPropertyManagerPageComboboxObject IPropertyManagerPageComboboxinstance,Int16 Item)
     {
            return IPropertyManagerPageComboboxinstance.IPropertyManagerPageComboboxInstance.DeleteItem(Item);
       }
  public static Int16 CurrentSelection(IPropertyManagerPageComboboxObject IPropertyManagerPageComboboxinstance)
      {
            return IPropertyManagerPageComboboxinstance.IPropertyManagerPageComboboxInstance.CurrentSelection;
      }
  public static Int16 Height(IPropertyManagerPageComboboxObject IPropertyManagerPageComboboxinstance)
      {
            return IPropertyManagerPageComboboxinstance.IPropertyManagerPageComboboxInstance.Height;
      }
  public static String ItemText(IPropertyManagerPageComboboxObject IPropertyManagerPageComboboxinstance)
      {
            return IPropertyManagerPageComboboxinstance.IPropertyManagerPageComboboxInstance.ItemText;
      }
  public static Int32 Style(IPropertyManagerPageComboboxObject IPropertyManagerPageComboboxinstance)
      {
            return IPropertyManagerPageComboboxinstance.IPropertyManagerPageComboboxInstance.Style;
      }
  public static String EditText(IPropertyManagerPageComboboxObject IPropertyManagerPageComboboxinstance)
      {
            return IPropertyManagerPageComboboxinstance.IPropertyManagerPageComboboxInstance.EditText;
      }
    }
}