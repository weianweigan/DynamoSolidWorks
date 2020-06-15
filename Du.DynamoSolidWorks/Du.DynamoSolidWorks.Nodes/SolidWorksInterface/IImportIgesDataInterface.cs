using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IImportIgesDataObject
    {
        public IImportIgesData IImportIgesDataInstance { get; set; }
        public IImportIgesDataObject(IImportIgesData IImportIgesDatainstance)
        {
            IImportIgesDataInstance = IImportIgesDatainstance;
        }
    }
    public static class IImportIgesDataInterface
    {
        public static Boolean SetLevels(IImportIgesDataObject IImportIgesDatainstance, Boolean All, Object Only)
        {
            return IImportIgesDatainstance.IImportIgesDataInstance.SetLevels(All, Only);
        }
        public static Boolean IncludeSurfaces(IImportIgesDataObject IImportIgesDatainstance)
        {
            return IImportIgesDatainstance.IImportIgesDataInstance.IncludeSurfaces;
        }
        public static Boolean IncludeCurves(IImportIgesDataObject IImportIgesDatainstance)
        {
            return IImportIgesDatainstance.IImportIgesDataInstance.IncludeCurves;
        }
        public static Boolean CurvesAsSketches(IImportIgesDataObject IImportIgesDatainstance)
        {
            return IImportIgesDatainstance.IImportIgesDataInstance.CurvesAsSketches;
        }
        public static Boolean ProcessByLevel(IImportIgesDataObject IImportIgesDatainstance)
        {
            return IImportIgesDatainstance.IImportIgesDataInstance.ProcessByLevel;
        }
        public static Boolean IncludeAllLevels(IImportIgesDataObject IImportIgesDatainstance)
        {
            return IImportIgesDatainstance.IImportIgesDataInstance.IncludeAllLevels;
        }
        public static Object IncludeOnlyLevels(IImportIgesDataObject IImportIgesDatainstance)
        {
            return IImportIgesDatainstance.IImportIgesDataInstance.IncludeOnlyLevels;
        }
    }
}