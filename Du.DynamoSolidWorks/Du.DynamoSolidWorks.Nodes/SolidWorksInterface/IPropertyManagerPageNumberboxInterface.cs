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
   public class IPropertyManagerPageNumberboxObject
    {
         public IPropertyManagerPageNumberbox IPropertyManagerPageNumberboxInstance { get; set; }
        public IPropertyManagerPageNumberboxObject(IPropertyManagerPageNumberbox IPropertyManagerPageNumberboxinstance)
        {
                IPropertyManagerPageNumberboxInstance = IPropertyManagerPageNumberboxinstance;
        }
    }
   public static class IPropertyManagerPageNumberboxInterface
   {
  public static void SetRange(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance,Int32 Units,Double Minimum,Double Maximum,Double Increment,Boolean Inclusive)
     {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.SetRange(Units,Minimum,Maximum,Increment,Inclusive);
       }
  public static void AddItems(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance,Object Texts)
     {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.AddItems(Texts);
       }
  public static void IAddItems(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance,Int16 TextCount,String& Texts)
     {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.IAddItems(TextCount,Texts);
       }
  public static void Clear(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance)
     {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.Clear();
       }
  public static Int16 InsertItem(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance,Int16 Item,String Text)
     {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.InsertItem(Item,Text);
       }
  public static Int16 DeleteItem(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance,Int16 Item)
     {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.DeleteItem(Item);
       }
  public static void SetRange2(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance,Int32 Units,Double Minimum,Double Maximum,Boolean Inclusive,Double Increment,Double FastIncr,Double SlowIncr)
     {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.SetRange2(Units,Minimum,Maximum,Inclusive,Increment,FastIncr,SlowIncr);
       }
  public static void SetSliderParameters(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance,Int32 PositionCount,Int32 DivisionCount)
     {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.SetSliderParameters(PositionCount,DivisionCount);
       }
  public static Double Value(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance)
      {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.Value;
      }
  public static Int32 Style(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance)
      {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.Style;
      }
  public static Int16 CurrentSelection(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance)
      {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.CurrentSelection;
      }
  public static Int16 Height(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance)
      {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.Height;
      }
  public static String ItemText(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance)
      {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.ItemText;
      }
  public static String Text(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance)
      {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.Text;
      }
  public static Int32 DisplayedUnit(IPropertyManagerPageNumberboxObject IPropertyManagerPageNumberboxinstance)
      {
            return IPropertyManagerPageNumberboxinstance.IPropertyManagerPageNumberboxInstance.DisplayedUnit;
      }
    }
}