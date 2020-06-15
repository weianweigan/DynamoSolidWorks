using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISelectionSetItemObject
    {
        public ISelectionSetItem ISelectionSetItemInstance { get; set; }
        public ISelectionSetItemObject(ISelectionSetItem ISelectionSetIteminstance)
        {
            ISelectionSetItemInstance = ISelectionSetIteminstance;
        }
    }
    public static class ISelectionSetItemInterface
    {
        public static void RemoveFromSelectionSet(ISelectionSetItemObject ISelectionSetIteminstance)
        {
            ISelectionSetIteminstance.ISelectionSetItemInstance.RemoveFromSelectionSet();
        }
        public static Object GetCorrespondingItem(ISelectionSetItemObject ISelectionSetIteminstance)
        {
            return ISelectionSetIteminstance.ISelectionSetItemInstance.GetCorrespondingItem();
        }
    }
}