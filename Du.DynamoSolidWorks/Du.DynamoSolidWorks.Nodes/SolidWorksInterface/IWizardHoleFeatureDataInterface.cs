using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IWizardHoleFeatureDataObject
    {
        public IWizardHoleFeatureData IWizardHoleFeatureDataInstance { get; set; }
        public IWizardHoleFeatureDataObject(IWizardHoleFeatureData IWizardHoleFeatureDatainstance)
        {
            IWizardHoleFeatureDataInstance = IWizardHoleFeatureDatainstance;
        }
    }
    public static class IWizardHoleFeatureDataInterface
    {
        public static Boolean AccessSelections(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance?.CastObj<ModelDoc>(), Component?.IComponentInstance?.CastObj<Component>());
        }
        public static void ReleaseSelectionAccess(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 Type(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.Type;
        }
        public static Double Diameter(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.Diameter;
        }
        public static Double CounterBoreDiameter(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.CounterBoreDiameter;
        }
        public static Double CounterDrillDiameter(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.CounterDrillDiameter;
        }
        public static Double CounterSinkDiameter(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.CounterSinkDiameter;
        }
        public static Double MinorDiameter(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.MinorDiameter;
        }
        public static Double MajorDiameter(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.MajorDiameter;
        }
        public static Double HoleDiameter(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.HoleDiameter;
        }
        public static Double ThruHoleDiameter(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.ThruHoleDiameter;
        }
        public static Double TapDrillDiameter(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.TapDrillDiameter;
        }
        public static Double ThruTapDrillDiameter(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.ThruTapDrillDiameter;
        }
        public static Double NearCounterSinkDiameter(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.NearCounterSinkDiameter;
        }
        public static Double MidCounterSinkDiameter(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.MidCounterSinkDiameter;
        }
        public static Double FarCounterSinkDiameter(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.FarCounterSinkDiameter;
        }
        public static Double ThreadDiameter(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.ThreadDiameter;
        }
        public static Double Depth(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.Depth;
        }
        public static Double CounterBoreDepth(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.CounterBoreDepth;
        }
        public static Double CounterDrillDepth(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.CounterDrillDepth;
        }
        public static Double HoleDepth(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.HoleDepth;
        }
        public static Double ThruHoleDepth(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.ThruHoleDepth;
        }
        public static Double TapDrillDepth(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.TapDrillDepth;
        }
        public static Double ThruTapDrillDepth(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.ThruTapDrillDepth;
        }
        public static Double ThreadDepth(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.ThreadDepth;
        }
        public static Double CounterDrillAngle(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.CounterDrillAngle;
        }
        public static Double CounterSinkAngle(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.CounterSinkAngle;
        }
        public static Double DrillAngle(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.DrillAngle;
        }
        public static Double NearCounterSinkAngle(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.NearCounterSinkAngle;
        }
        public static Double MidCounterSinkAngle(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.MidCounterSinkAngle;
        }
        public static Double FarCounterSinkAngle(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.FarCounterSinkAngle;
        }
        public static Double ThreadAngle(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.ThreadAngle;
        }
        public static Double HeadClearance(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.HeadClearance;
        }
        public static Object Face(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.Face;
        }
        public static IFaceObject IFace(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return new IFaceObject(IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.IFace);
        }
        public static Object Vertex(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.Vertex;
        }
        public static IVertexObject IVertex(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return new IVertexObject(IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.IVertex);
        }
        public static Int32 EndCondition(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.EndCondition;
        }
        public static String Standard(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.Standard;
        }
        public static String FastenerType(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.FastenerType;
        }
        public static String FastenerSize(IWizardHoleFeatureDataObject IWizardHoleFeatureDatainstance)
        {
            return IWizardHoleFeatureDatainstance.IWizardHoleFeatureDataInstance.FastenerSize;
        }
    }
}