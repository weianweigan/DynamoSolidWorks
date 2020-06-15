using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ILoftedBendsFeatureDataObject
    {
        public ILoftedBendsFeatureData ILoftedBendsFeatureDataInstance { get; set; }
        public ILoftedBendsFeatureDataObject(ILoftedBendsFeatureData ILoftedBendsFeatureDatainstance)
        {
            ILoftedBendsFeatureDataInstance = ILoftedBendsFeatureDatainstance;
        }
    }
    public static class ILoftedBendsFeatureDataInterface
    {
        public static Boolean IAccessSelections(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static Boolean AccessSelections(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance, Object TopDoc, Object Component)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance)
        {
            ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetProfileCount(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.GetProfileCount();
        }
        public static Object IGetProfiles(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance, Int32 Count)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.IGetProfiles(Count);
        }
        //public static void ISetProfiles(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance, Int32 Count, Object& PDisp)
        //{
        //    return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.ISetProfiles(Count, PDisp);
        //}
        public static Boolean CanCreateBendLines(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.CanCreateBendLines();
        }
        public static Object Profiles(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.Profiles;
        }
        public static Double Thickness(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.Thickness;
        }
        public static Boolean Direction(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.Direction;
        }
        public static Int32 BendLineControlOption(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.BendLineControlOption;
        }
        public static Int32 NumberOfBendLines(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.NumberOfBendLines;
        }
        public static Double MaximumDeviation(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.MaximumDeviation;
        }
        public static Boolean ReferToEndPoint(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.ReferToEndPoint;
        }
        public static Int32 FacetingOption(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.FacetingOption;
        }
        public static Double FacetValue(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.FacetValue;
        }
        public static Boolean FormedMethod(ILoftedBendsFeatureDataObject ILoftedBendsFeatureDatainstance)
        {
            return ILoftedBendsFeatureDatainstance.ILoftedBendsFeatureDataInstance.FormedMethod;
        }
    }
}