using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFillPatternFeatureDataObject
    {
        public IFillPatternFeatureData IFillPatternFeatureDataInstance { get; set; }
        public IFillPatternFeatureDataObject(IFillPatternFeatureData IFillPatternFeatureDatainstance)
        {
            IFillPatternFeatureDataInstance = IFillPatternFeatureDatainstance;
        }
    }
    public static class IFillPatternFeatureDataInterface
    {
        public static Boolean AccessSelections(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 PatternLayoutType(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.PatternLayoutType;
        }
        public static Int32 LayoutSpacingType(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.LayoutSpacingType;
        }
        public static Double InstanceSpacing(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.InstanceSpacing;
        }
        public static Double StaggerAngle(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.StaggerAngle;
        }
        public static Double Margins(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.Margins;
        }
        public static Double LoopSpacing(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.LoopSpacing;
        }
        public static Int32 NoOfInstances(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.NoOfInstances;
        }
        public static Int32 PatternLayoutPolygonSides(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.PatternLayoutPolygonSides;
        }
        public static Int32 FeaturesToPatternType(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.FeaturesToPatternType;
        }
        public static Int32 CreateSeedCutType(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.CreateSeedCutType;
        }
        public static Double Diameter(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.Diameter;
        }
        public static Double Dimension(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.Dimension;
        }
        public static Double Rotation(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.Rotation;
        }
        public static Double Diagonal(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.Diagonal;
        }
        public static Int32 CreateSeedCutPolygonSides(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.CreateSeedCutPolygonSides;
        }
        public static Double OuterRadius(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.OuterRadius;
        }
        public static Double InnerRadius(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.InnerRadius;
        }
        public static Boolean SeedCutFlipShapeDirection(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.SeedCutFlipShapeDirection;
        }
        public static Boolean GeometryPattern(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.GeometryPattern;
        }
        public static Object PatternFillBoundaryArray(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.PatternFillBoundaryArray;
        }
        public static Object PatternDirection(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.PatternDirection;
        }
        public static Int32 PatternDirectionType(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.PatternDirectionType;
        }
        public static Boolean FeatureScope(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.FeatureScope;
        }
        public static Boolean AutoSelect(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.AutoSelect;
        }
        public static Object SkippedItemArray(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.SkippedItemArray;
        }
        public static Boolean PropagateVisualProperty(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.PropagateVisualProperty;
        }
        public static Object PatternFaceArray(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.PatternFaceArray;
        }
        public static Object PatternBodyArray(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.PatternBodyArray;
        }
        public static Object SeedFeatureCenter(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.SeedFeatureCenter;
        }
        public static Int32 SeedFeatureCenterType(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.SeedFeatureCenterType;
        }
        public static Object PatternFeatureArray(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.PatternFeatureArray;
        }
        public static Object FeatureScopeBodies(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.FeatureScopeBodies;
        }
        public static Int32 PatternElement(IFillPatternFeatureDataObject IFillPatternFeatureDatainstance)
        {
            return IFillPatternFeatureDatainstance.IFillPatternFeatureDataInstance.PatternElement;
        }
    }
}