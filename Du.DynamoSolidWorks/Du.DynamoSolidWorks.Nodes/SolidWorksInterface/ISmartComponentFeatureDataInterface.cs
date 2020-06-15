using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISmartComponentFeatureDataObject
    {
        public ISmartComponentFeatureData ISmartComponentFeatureDataInstance { get; set; }
        public ISmartComponentFeatureDataObject(ISmartComponentFeatureData ISmartComponentFeatureDatainstance)
        {
            ISmartComponentFeatureDataInstance = ISmartComponentFeatureDatainstance;
        }
    }
    public static class ISmartComponentFeatureDataInterface
    {
        public static Boolean AccessSelections(ISmartComponentFeatureDataObject ISmartComponentFeatureDatainstance, Boolean ShowPMP)
        {
            return ISmartComponentFeatureDatainstance.ISmartComponentFeatureDataInstance.AccessSelections(ShowPMP);
        }
        public static void ReleaseSelectionAccess(ISmartComponentFeatureDataObject ISmartComponentFeatureDatainstance)
        {
            ISmartComponentFeatureDatainstance.ISmartComponentFeatureDataInstance.ReleaseSelectionAccess();
        }
    }
}