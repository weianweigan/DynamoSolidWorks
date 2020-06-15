using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IGussetFeatureDataObject
    {
        public IGussetFeatureData IGussetFeatureDataInstance { get; set; }
        public IGussetFeatureDataObject(IGussetFeatureData IGussetFeatureDatainstance)
        {
            IGussetFeatureDataInstance = IGussetFeatureDatainstance;
        }
    }
    public static class IGussetFeatureDataInterface
    {
        public static Boolean AccessSelections(IGussetFeatureDataObject IGussetFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            IGussetFeatureDatainstance.IGussetFeatureDataInstance.ReleaseSelectionAccess();
        }
        //public static Boolean GetSupportingFaces(IGussetFeatureDataObject IGussetFeatureDatainstance, Face2&Object PFace1, Face2&Object PFace2)
        //{
        //    return IGussetFeatureDatainstance.IGussetFeatureDataInstance.GetSupportingFaces(PFace1, PFace2);
        //}
        public static Boolean SetSupportingFaces(IGussetFeatureDataObject IGussetFeatureDatainstance, IFace2Object PFace1, IFace2Object PFace2)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.SetSupportingFaces(PFace1.IFace2Instance as Face2, PFace2.IFace2Instance as Face2);
        }
        public static Boolean FlipProfileDistanceParameters(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.FlipProfileDistanceParameters;
        }
        public static Int32 ProfileType(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.ProfileType;
        }
        public static Double ProfileDistance1(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.ProfileDistance1;
        }
        public static Double ProfileDistance2(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.ProfileDistance2;
        }
        public static Double ProfileDistance3(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.ProfileDistance3;
        }
        public static Double ProfileDistance4(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.ProfileDistance4;
        }
        public static Double ProfileAngle(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.ProfileAngle;
        }
        public static Int32 ThicknessType(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.ThicknessType;
        }
        public static Double Thickness(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.Thickness;
        }
        public static Int32 ProfileLocation(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.ProfileLocation;
        }
        public static Boolean OffsetUsed(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.OffsetUsed;
        }
        public static Double ProfileOffsetDistance(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.ProfileOffsetDistance;
        }
        public static Boolean FlipOffsetDirection(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.FlipOffsetDirection;
        }
        public static Boolean UseAngle(IGussetFeatureDataObject IGussetFeatureDatainstance)
        {
            return IGussetFeatureDatainstance.IGussetFeatureDataInstance.UseAngle;
        }
    }
}