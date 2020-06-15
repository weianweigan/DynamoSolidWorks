using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IWizardHoleFeatureData2Object
    {
        public IWizardHoleFeatureData2 IWizardHoleFeatureData2Instance { get; set; }
        public IWizardHoleFeatureData2Object(IWizardHoleFeatureData2 IWizardHoleFeatureData2instance)
        {
            IWizardHoleFeatureData2Instance = IWizardHoleFeatureData2instance;
        }
    }
    public static class IWizardHoleFeatureData2Interface
    {
        //public static Object GetEndConditionReference(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance, Int32& ReferenceType)
        //{
        //    return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.GetEndConditionReference(ReferenceType);
        //}
        public static void SetEndConditionReference(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance, Object PDisp)
        {
            IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.SetEndConditionReference(PDisp);
        }
        public static Int32 GetSketchPointCount(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.GetSketchPointCount();
        }
        public static Object GetSketchPoints(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.GetSketchPoints();
        }
        public static ISketchPointObject IGetSketchPoints(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance, Int32 NCount)
        {
            return new ISketchPointObject(IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.IGetSketchPoints(NCount));
        }
        public static Boolean ChangeStandard(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance, Int32 Standard, Int32 FastenerType, String SSize)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.ChangeStandard(Standard, FastenerType, SSize);
        }
        public static void InitializeHole(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance, Int32 GenericHoleType, Int32 StdIndex, Int32 FastnerType, String SSize, Int32 EndType)
        {
            IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.InitializeHole(GenericHoleType, StdIndex, FastnerType, SSize, EndType);
        }
        public static Int32 GetFeatureScopeBodiesCount(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.GetFeatureScopeBodiesCount();
        }
        public static IBody2Object IGetFeatureScopeBodies(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance, Int32 Count)
        {
            return new IBody2Object(IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.IGetFeatureScopeBodies(Count));
        }
        //public static void ISetFeatureScopeBodies(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance, Int32 Count, Body2&Object BodyArr)
        //{
        //    return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.ISetFeatureScopeBodies(Count, BodyArr);
        //}
        public static Boolean AccessSelections(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance, Object TopDoc, Object Component)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.ReleaseSelectionAccess();
        }
        public static Int32 Type(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.Type;
        }
        public static Double Diameter(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.Diameter;
        }
        public static Double CounterBoreDiameter(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.CounterBoreDiameter;
        }
        public static Double CounterDrillDiameter(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.CounterDrillDiameter;
        }
        public static Double CounterSinkDiameter(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.CounterSinkDiameter;
        }
        public static Double MinorDiameter(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.MinorDiameter;
        }
        public static Double MajorDiameter(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.MajorDiameter;
        }
        public static Double HoleDiameter(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.HoleDiameter;
        }
        public static Double ThruHoleDiameter(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.ThruHoleDiameter;
        }
        public static Double TapDrillDiameter(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.TapDrillDiameter;
        }
        public static Double ThruTapDrillDiameter(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.ThruTapDrillDiameter;
        }
        public static Double NearCounterSinkDiameter(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.NearCounterSinkDiameter;
        }
        public static Double MidCounterSinkDiameter(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.MidCounterSinkDiameter;
        }
        public static Double FarCounterSinkDiameter(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.FarCounterSinkDiameter;
        }
        public static Double ThreadDiameter(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.ThreadDiameter;
        }
        public static Double Depth(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.Depth;
        }
        public static Double CounterBoreDepth(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.CounterBoreDepth;
        }
        public static Double CounterDrillDepth(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.CounterDrillDepth;
        }
        public static Double HoleDepth(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.HoleDepth;
        }
        public static Double ThruHoleDepth(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.ThruHoleDepth;
        }
        public static Double TapDrillDepth(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.TapDrillDepth;
        }
        public static Double ThruTapDrillDepth(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.ThruTapDrillDepth;
        }
        public static Double ThreadDepth(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.ThreadDepth;
        }
        public static Double CounterDrillAngle(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.CounterDrillAngle;
        }
        public static Double CounterSinkAngle(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.CounterSinkAngle;
        }
        public static Double DrillAngle(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.DrillAngle;
        }
        public static Double NearCounterSinkAngle(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.NearCounterSinkAngle;
        }
        public static Double MidCounterSinkAngle(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.MidCounterSinkAngle;
        }
        public static Double FarCounterSinkAngle(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.FarCounterSinkAngle;
        }
        public static Double ThreadAngle(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.ThreadAngle;
        }
        public static Double HeadClearance(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.HeadClearance;
        }
        public static Object Face(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.Face;
        }
        public static IFace2Object IFace(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return new IFace2Object(IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.IFace);
        }
        public static Object Vertex(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.Vertex;
        }
        public static IVertexObject IVertex(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return new IVertexObject(IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.IVertex);
        }
        public static Int32 EndCondition(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.EndCondition;
        }
        public static String Standard(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.Standard;
        }
        public static String FastenerType(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.FastenerType;
        }
        public static String FastenerSize(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.FastenerSize;
        }
        public static Int32 HeadClearanceType(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.HeadClearanceType;
        }
        public static Int32 CosmeticThreadType(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.CosmeticThreadType;
        }
        public static Int32 HoleFit(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.HoleFit;
        }
        public static Double OffsetDistance(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.OffsetDistance;
        }
        public static Int32 ThreadEndCondition(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.ThreadEndCondition;
        }
        public static Int32 TapType(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.TapType;
        }
        public static Boolean ReverseDirection(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.ReverseDirection;
        }
        public static String ThreadClass(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.ThreadClass;
        }
        public static Boolean FeatureScope(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.FeatureScope;
        }
        public static Boolean AutoSelect(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.AutoSelect;
        }
        public static Object FeatureScopeBodies(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.FeatureScopeBodies;
        }
        public static Int32 Standard2(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.Standard2;
        }
        public static Int32 FastenerType2(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.FastenerType2;
        }
        public static Boolean AssemblyFeatureScope(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.AssemblyFeatureScope;
        }
        public static Boolean AutoSelectComponents(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.AutoSelectComponents;
        }
        public static Boolean PropagateFeatureToParts(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.PropagateFeatureToParts;
        }
        public static Boolean NearSideCounterSink(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.NearSideCounterSink;
        }
        public static Boolean FarSideCounterSink(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.FarSideCounterSink;
        }
        public static Double Length(IWizardHoleFeatureData2Object IWizardHoleFeatureData2instance)
        {
            return IWizardHoleFeatureData2instance.IWizardHoleFeatureData2Instance.Length;
        }
    }
}