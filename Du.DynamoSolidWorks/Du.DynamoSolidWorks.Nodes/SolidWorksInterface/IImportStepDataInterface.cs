using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IImportStepDataObject
    {
        public IImportStepData IImportStepDataInstance { get; set; }
        public IImportStepDataObject(IImportStepData IImportStepDatainstance)
        {
            IImportStepDataInstance = IImportStepDatainstance;
        }
    }
    public static class IImportStepDataInterface
    {
        public static Boolean MapConfigurationData(IImportStepDataObject IImportStepDatainstance)
        {
            return IImportStepDatainstance.IImportStepDataInstance.MapConfigurationData;
        }
    }
}