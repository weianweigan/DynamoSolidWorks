using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDimXpertManagerObject
    {
        public IDimXpertManager IDimXpertManagerInstance { get; set; }
        public IDimXpertManagerObject(IDimXpertManager IDimXpertManagerinstance)
        {
            IDimXpertManagerInstance = IDimXpertManagerinstance;
        }
    }
    public static class IDimXpertManagerInterface
    {
        public static Object DimXpertPart(IDimXpertManagerObject IDimXpertManagerinstance)
        {
            return IDimXpertManagerinstance.IDimXpertManagerInstance.DimXpertPart;
        }
        public static Int32 TreeDisplay(IDimXpertManagerObject IDimXpertManagerinstance)
        {
            return IDimXpertManagerinstance.IDimXpertManagerInstance.TreeDisplay;
        }
        public static String SchemaName(IDimXpertManagerObject IDimXpertManagerinstance)
        {
            return IDimXpertManagerinstance.IDimXpertManagerInstance.SchemaName;
        }
        public static String SchemaDescription(IDimXpertManagerObject IDimXpertManagerinstance)
        {
            return IDimXpertManagerinstance.IDimXpertManagerInstance.SchemaDescription;
        }
        public static String SchemaComment(IDimXpertManagerObject IDimXpertManagerinstance)
        {
            return IDimXpertManagerinstance.IDimXpertManagerInstance.SchemaComment;
        }
    }
}