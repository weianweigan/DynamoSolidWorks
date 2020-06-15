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
   public class IPropertyManagerPageObject
    {
         public IPropertyManagerPage IPropertyManagerPageInstance { get; set; }
        public IPropertyManagerPageObject(IPropertyManagerPage IPropertyManagerPageinstance)
        {
                IPropertyManagerPageInstance = IPropertyManagerPageinstance;
        }
    }
   public static class IPropertyManagerPageInterface
   {
  public static Int32 SetButtons(IPropertyManagerPageObject IPropertyManagerPageinstance,Int32 ButtonTypes)
     {
            return IPropertyManagerPageinstance.IPropertyManagerPageInstance.SetButtons(ButtonTypes);
       }
  public static Int32 SetGroupRange(IPropertyManagerPageObject IPropertyManagerPageinstance,Int32 FirstGroupId,Int32 FirstCheckId,Int32 GroupCount)
     {
            return IPropertyManagerPageinstance.IPropertyManagerPageInstance.SetGroupRange(FirstGroupId,FirstCheckId,GroupCount);
       }
  public static Int32 Show(IPropertyManagerPageObject IPropertyManagerPageinstance)
     {
            return IPropertyManagerPageinstance.IPropertyManagerPageInstance.Show();
       }
  public static Int32 GetDialogWindow(IPropertyManagerPageObject IPropertyManagerPageinstance,Int32& Status)
     {
            return IPropertyManagerPageinstance.IPropertyManagerPageInstance.GetDialogWindow(Status);
       }
  public static Boolean GetGroupVisible(IPropertyManagerPageObject IPropertyManagerPageinstance,Int32 GroupID,Int32& Status)
     {
            return IPropertyManagerPageinstance.IPropertyManagerPageInstance.GetGroupVisible(GroupID,Status);
       }
  public static Int32 SetGroupVisible(IPropertyManagerPageObject IPropertyManagerPageinstance,Int32 GroupID,Boolean Visible)
     {
            return IPropertyManagerPageinstance.IPropertyManagerPageInstance.SetGroupVisible(GroupID,Visible);
       }
  public static Boolean GetGroupExpanded(IPropertyManagerPageObject IPropertyManagerPageinstance,Int32 GroupID,Int32& Status)
     {
            return IPropertyManagerPageinstance.IPropertyManagerPageInstance.GetGroupExpanded(GroupID,Status);
       }
  public static Int32 SetGroupExpanded(IPropertyManagerPageObject IPropertyManagerPageinstance,Int32 GroupID,Boolean Expanded)
     {
            return IPropertyManagerPageinstance.IPropertyManagerPageInstance.SetGroupExpanded(GroupID,Expanded);
       }
  public static Boolean GetAllowMultiSelect(IPropertyManagerPageObject IPropertyManagerPageinstance,Int32& Status)
     {
            return IPropertyManagerPageinstance.IPropertyManagerPageInstance.GetAllowMultiSelect(Status);
       }
  public static Int32 SetAllowMultiSelect(IPropertyManagerPageObject IPropertyManagerPageinstance,Boolean Allow)
     {
            return IPropertyManagerPageinstance.IPropertyManagerPageInstance.SetAllowMultiSelect(Allow);
       }
  public static Int64 GetDialogWindowx64(IPropertyManagerPageObject IPropertyManagerPageinstance,Int32& Status)
     {
            return IPropertyManagerPageinstance.IPropertyManagerPageInstance.GetDialogWindowx64(Status);
       }
  public static Boolean Pinned(IPropertyManagerPageObject IPropertyManagerPageinstance)
      {
            return IPropertyManagerPageinstance.IPropertyManagerPageInstance.Pinned;
      }
    }
}