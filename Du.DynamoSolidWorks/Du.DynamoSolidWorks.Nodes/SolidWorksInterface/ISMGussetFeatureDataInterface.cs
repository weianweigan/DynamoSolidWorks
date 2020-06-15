using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISMGussetFeatureDataObject
    {
        public ISMGussetFeatureData ISMGussetFeatureDataInstance { get; set; }
        public ISMGussetFeatureDataObject(ISMGussetFeatureData ISMGussetFeatureDatainstance)
        {
            ISMGussetFeatureDataInstance = ISMGussetFeatureDatainstance;
        }
    }
    public static class ISMGussetFeatureDataInterface
    {
        public static Boolean AccessSelections(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Object SupportingFaces(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.SupportingFaces;
        }
        public static Object ReferenceLine(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.ReferenceLine;
        }
        public static Object ReferencePoint(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.ReferencePoint;
        }
        public static Boolean UseOffset(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.UseOffset;
        }
        public static Double OffsetDistance(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.OffsetDistance;
        }
        public static Boolean FlipOffset(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.FlipOffset;
        }
        public static Int32 ProfileDimensionScheme(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.ProfileDimensionScheme;
        }
        public static Double IndentDepth(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.IndentDepth;
        }
        public static Double ProfileLengthDim(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.ProfileLengthDim;
        }
        public static Boolean UseAngleDimForProfile(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.UseAngleDimForProfile;
        }
        public static Double ProfileHeightDim(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.ProfileHeightDim;
        }
        public static Double ProfileAngleDim(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.ProfileAngleDim;
        }
        public static Boolean FlipDimSides(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.FlipDimSides;
        }
        public static Double IndentWidth(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.IndentWidth;
        }
        public static Double GussetThickness(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.GussetThickness;
        }
        public static Boolean DraftSideFaces(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.DraftSideFaces;
        }
        public static Double DraftAngle(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.DraftAngle;
        }
        public static Boolean FilletOuterCorners(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.FilletOuterCorners;
        }
        public static Double OuterCornerFilletRadius(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.OuterCornerFilletRadius;
        }
        public static Boolean FilletInnerCorners(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.FilletInnerCorners;
        }
        public static Double InnerCornerFilletRadius(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.InnerCornerFilletRadius;
        }
        public static Boolean FilletGussetEdges(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.FilletGussetEdges;
        }
        public static Double EdgeFilletRadius(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.EdgeFilletRadius;
        }
        public static Int32 GussetType(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.GussetType;
        }
        public static Int32 ProfileType(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.ProfileType;
        }
        public static Boolean OverrideDocSettings(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.OverrideDocSettings;
        }
        public static Boolean ShowProfile(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.ShowProfile;
        }
        public static Boolean ShowCenter(ISMGussetFeatureDataObject ISMGussetFeatureDatainstance)
        {
            return ISMGussetFeatureDatainstance.ISMGussetFeatureDataInstance.ShowCenter;
        }
    }
}