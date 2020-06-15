using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISelectionSetFolderObject
    {
        public ISelectionSetFolder ISelectionSetFolderInstance { get; set; }
        public ISelectionSetFolderObject(ISelectionSetFolder ISelectionSetFolderinstance)
        {
            ISelectionSetFolderInstance = ISelectionSetFolderinstance;
        }
    }
    public static class ISelectionSetFolderInterface
    {
        public static Object GetSelectionSets(ISelectionSetFolderObject ISelectionSetFolderinstance)
        {
            return ISelectionSetFolderinstance.ISelectionSetFolderInstance.GetSelectionSets();
        }
        public static Object GetSelectionSetByName(ISelectionSetFolderObject ISelectionSetFolderinstance, String Name)
        {
            return ISelectionSetFolderinstance.ISelectionSetFolderInstance.GetSelectionSetByName(Name);
        }
    }
}