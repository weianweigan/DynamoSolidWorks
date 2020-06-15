using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IHelixFeatureDataObject
    {
        public IHelixFeatureData IHelixFeatureDataInstance { get; set; }
        public IHelixFeatureDataObject(IHelixFeatureData IHelixFeatureDatainstance)
        {
            IHelixFeatureDataInstance = IHelixFeatureDatainstance;
        }
    }
    public static class IHelixFeatureDataInterface
    {
        public static Int32 SetRegionParameterAtIndex(IHelixFeatureDataObject IHelixFeatureDatainstance, Int32 Index, Int32 Parameter, Double PitchValue)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.SetRegionParameterAtIndex(Index, Parameter, PitchValue);
        }
        public static Double GetRegionParameterAtIndex(IHelixFeatureDataObject IHelixFeatureDatainstance, Int32 Index, Int32 RegionParameter)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.GetRegionParameterAtIndex(Index, RegionParameter);
        }
        public static Boolean InsertRecord(IHelixFeatureDataObject IHelixFeatureDatainstance, Int32 Index)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.InsertRecord(Index);
        }
        public static Boolean DeleteRecord(IHelixFeatureDataObject IHelixFeatureDatainstance, Object Indices)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.DeleteRecord(Indices);
        }
        public static Boolean AddLastRecord(IHelixFeatureDataObject IHelixFeatureDatainstance, Object HelixPointValue)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.AddLastRecord(HelixPointValue);
        }
        public static Int32 DefinedBy(IHelixFeatureDataObject IHelixFeatureDatainstance)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.DefinedBy;
        }
        public static Double Height(IHelixFeatureDataObject IHelixFeatureDatainstance)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.Height;
        }
        public static Double Pitch(IHelixFeatureDataObject IHelixFeatureDatainstance)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.Pitch;
        }
        public static Double Revolution(IHelixFeatureDataObject IHelixFeatureDatainstance)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.Revolution;
        }
        public static Double StartingAngle(IHelixFeatureDataObject IHelixFeatureDatainstance)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.StartingAngle;
        }
        public static Boolean ReverseDirection(IHelixFeatureDataObject IHelixFeatureDatainstance)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.ReverseDirection;
        }
        public static Boolean Clockwise(IHelixFeatureDataObject IHelixFeatureDatainstance)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.Clockwise;
        }
        public static Boolean Taper(IHelixFeatureDataObject IHelixFeatureDatainstance)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.Taper;
        }
        public static Double TaperAngle(IHelixFeatureDataObject IHelixFeatureDatainstance)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.TaperAngle;
        }
        public static Boolean TaperOutward(IHelixFeatureDataObject IHelixFeatureDatainstance)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.TaperOutward;
        }
        public static Boolean VariablePitch(IHelixFeatureDataObject IHelixFeatureDatainstance)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.VariablePitch;
        }
        public static Int32 PitchCount(IHelixFeatureDataObject IHelixFeatureDatainstance)
        {
            return IHelixFeatureDatainstance.IHelixFeatureDataInstance.PitchCount;
        }
    }
}