using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISelectionSetObject
    {
        public ISelectionSet ISelectionSetInstance { get; set; }
        public ISelectionSetObject(ISelectionSet ISelectionSetinstance)
        {
            ISelectionSetInstance = ISelectionSetinstance;
        }
    }
    public static class ISelectionSetInterface
    {
        public static Object GetSelectionSetItems(ISelectionSetObject ISelectionSetinstance)
        {
            return ISelectionSetinstance.ISelectionSetInstance.GetSelectionSetItems();
        }
        public static Boolean RemoveSelectionSet(ISelectionSetObject ISelectionSetinstance)
        {
            return ISelectionSetinstance.ISelectionSetInstance.RemoveSelectionSet();
        }
        public static Boolean Select(ISelectionSetObject ISelectionSetinstance)
        {
            return ISelectionSetinstance.ISelectionSetInstance.Select();
        }
        public static String GetName(ISelectionSetObject ISelectionSetinstance)
        {
            return ISelectionSetinstance.ISelectionSetInstance.GetName();
        }
        public static Object GetSelectionSetItemTypes(ISelectionSetObject ISelectionSetinstance)
        {
            return ISelectionSetinstance.ISelectionSetInstance.GetSelectionSetItemTypes();
        }
    }
}