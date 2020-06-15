using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;

namespace DynamoSolidWorks
{
    public class IAdvancedSelectionCriteriaObject
    {
        public IAdvancedSelectionCriteria IAdvancedSelectionCriteriaInstance { get; set; }
        public IAdvancedSelectionCriteriaObject(IAdvancedSelectionCriteria IAdvancedSelectionCriteriainstance)
        {
            IAdvancedSelectionCriteriaInstance = IAdvancedSelectionCriteriainstance;
        }
    }
    public static class IAdvancedSelectionCriteriaInterface
    {


        public static Int32 AddItem(IAdvancedSelectionCriteriaObject IAdvancedSelectionCriteriainstance, String Property, Int32 Condition, String Value, Boolean IsAnd)
        {
            return IAdvancedSelectionCriteriainstance.IAdvancedSelectionCriteriaInstance.AddItem(Property, Condition, Value, IsAnd);
        }
        public static Boolean DeleteItem(IAdvancedSelectionCriteriaObject IAdvancedSelectionCriteriainstance, Int32 Index)
        {
            return IAdvancedSelectionCriteriainstance.IAdvancedSelectionCriteriaInstance.DeleteItem(Index);
        }
        public static Boolean SaveCriteria(IAdvancedSelectionCriteriaObject IAdvancedSelectionCriteriainstance, String CriteriaFileName)
        {
            return IAdvancedSelectionCriteriainstance.IAdvancedSelectionCriteriaInstance.SaveCriteria(CriteriaFileName);
        }
        public static Boolean LoadCriteria(IAdvancedSelectionCriteriaObject IAdvancedSelectionCriteriainstance, String CriteriaFileName)
        {
            return IAdvancedSelectionCriteriainstance.IAdvancedSelectionCriteriaInstance.LoadCriteria(CriteriaFileName);
        }

        [MultiReturn(SWValueConst.Result, SWValueConst.Propert, SWValueConst.Condition, SWValueConst.Value, SWValueConst.IsAnd)]
        public static Dictionary<string, object> GetItem(IAdvancedSelectionCriteriaObject IAdvancedSelectionCriteriainstance, Int32 Index)
        {
            int result = IAdvancedSelectionCriteriainstance.IAdvancedSelectionCriteriaInstance.GetItem(Index, out string Property, out int Condition, out string Value, out bool IsAnd);
            return new Dictionary<string, object>() { { SWValueConst.Result, result }, { SWValueConst.Propert, Property }, { SWValueConst.Condition, Condition }, { SWValueConst.Value, Value }, { SWValueConst.IsAnd, IsAnd } };
        }
        public static Int32 GetItemCount(IAdvancedSelectionCriteriaObject IAdvancedSelectionCriteriainstance)
        {
            return IAdvancedSelectionCriteriainstance.IAdvancedSelectionCriteriaInstance.GetItemCount();
        }
        public static Boolean Select(IAdvancedSelectionCriteriaObject IAdvancedSelectionCriteriainstance)
        {
            return IAdvancedSelectionCriteriainstance.IAdvancedSelectionCriteriaInstance.Select();
        }
    }
}