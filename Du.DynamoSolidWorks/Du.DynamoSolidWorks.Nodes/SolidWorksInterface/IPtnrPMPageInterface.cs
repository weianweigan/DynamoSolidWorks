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
   public class IPtnrPMPageObject
    {
         public IPtnrPMPage IPtnrPMPageInstance { get; set; }
        public IPtnrPMPageObject(IPtnrPMPage IPtnrPMPageinstance)
        {
                IPtnrPMPageInstance = IPtnrPMPageinstance;
        }
    }
   public static class IPtnrPMPageInterface
   {
  public static Int32 SetButtons(IPtnrPMPageObject IPtnrPMPageinstance,Int32 ButtonTypes)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.SetButtons(ButtonTypes);
       }
  public static Int32 SetGroupRange(IPtnrPMPageObject IPtnrPMPageinstance,Int32 FirstGroupId,Int32 FirstCheckId,Int32 GroupCount)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.SetGroupRange(FirstGroupId,FirstCheckId,GroupCount);
       }
  public static Int32 Show(IPtnrPMPageObject IPtnrPMPageinstance)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.Show();
       }
  public static Int32 GetDialogWindow(IPtnrPMPageObject IPtnrPMPageinstance,Int32& Status)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.GetDialogWindow(Status);
       }
  public static Boolean GetGroupVisible(IPtnrPMPageObject IPtnrPMPageinstance,Int32 GroupID,Int32& Status)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.GetGroupVisible(GroupID,Status);
       }
  public static Int32 SetGroupVisible(IPtnrPMPageObject IPtnrPMPageinstance,Int32 GroupID,Boolean Visible)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.SetGroupVisible(GroupID,Visible);
       }
  public static Boolean GetGroupExpanded(IPtnrPMPageObject IPtnrPMPageinstance,Int32 GroupID,Int32& Status)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.GetGroupExpanded(GroupID,Status);
       }
  public static Int32 SetGroupExpanded(IPtnrPMPageObject IPtnrPMPageinstance,Int32 GroupID,Boolean Expanded)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.SetGroupExpanded(GroupID,Expanded);
       }
  public static Int32 SetToolTips(IPtnrPMPageObject IPtnrPMPageinstance,Int32 ControlAndToolTipCount,Int32& ControlAndToolTips)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.SetToolTips(ControlAndToolTipCount,ControlAndToolTips);
       }
  public static Int32 RecalculateVerticalSpacing(IPtnrPMPageObject IPtnrPMPageinstance)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.RecalculateVerticalSpacing();
       }
  public static Int32 ShowControl(IPtnrPMPageObject IPtnrPMPageinstance,Int32 ControlID,Int32 DividerID,Boolean Show)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.ShowControl(ControlID,DividerID,Show);
       }
  public static Int32 AddPage(IPtnrPMPageObject IPtnrPMPageinstance)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.AddPage();
       }
  public static Int32 CreatePage(IPtnrPMPageObject IPtnrPMPageinstance,Int32 HHandle)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.CreatePage(HHandle);
       }
  public static Int32 IsPageActive(IPtnrPMPageObject IPtnrPMPageinstance,Boolean& Active)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.IsPageActive(Active);
       }
  public static Int32 SetControlTip(IPtnrPMPageObject IPtnrPMPageinstance,Int32 ControlID,String TipString)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.SetControlTip(ControlID,TipString);
       }
  public static Int32 GetControlTip(IPtnrPMPageObject IPtnrPMPageinstance,Int32 ControlID,String& TipString)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.GetControlTip(ControlID,TipString);
       }
  public static Int32 SwitchPage(IPtnrPMPageObject IPtnrPMPageinstance,Int32 PageId)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.SwitchPage(PageId);
       }
  public static Int32 GetTotalNumberOfPages(IPtnrPMPageObject IPtnrPMPageinstance,Int32& NumberOfPages)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.GetTotalNumberOfPages(NumberOfPages);
       }
  public static Int32 GetPageIndex(IPtnrPMPageObject IPtnrPMPageinstance,Int32& PageIndex)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.GetPageIndex(PageIndex);
       }
  public static Int32 GetPageNumber(IPtnrPMPageObject IPtnrPMPageinstance,Int32& PageNumber)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.GetPageNumber(PageNumber);
       }
  public static Int32 SetPageNumber(IPtnrPMPageObject IPtnrPMPageinstance,Int32 PageNumber)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.SetPageNumber(PageNumber);
       }
  public static Int32 GetCurrentPageNumber(IPtnrPMPageObject IPtnrPMPageinstance,Int32& PageNumber)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.GetCurrentPageNumber(PageNumber);
       }
  public static Int32 SetButtonEnabled(IPtnrPMPageObject IPtnrPMPageinstance,Int32 ButtonType,Boolean BEnabled)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.SetButtonEnabled(ButtonType,BEnabled);
       }
  public static Int32 Redraw(IPtnrPMPageObject IPtnrPMPageinstance)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.Redraw();
       }
  public static Int64 GetDialogWindowx64(IPtnrPMPageObject IPtnrPMPageinstance,Int32& Status)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.GetDialogWindowx64(Status);
       }
  public static Int32 SetAllowProgressiveRender(IPtnrPMPageObject IPtnrPMPageinstance,Boolean Allow)
     {
            return IPtnrPMPageinstance.IPtnrPMPageInstance.SetAllowProgressiveRender(Allow);
       }
    }
}