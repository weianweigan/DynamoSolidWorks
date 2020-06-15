using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IOneBendFeatureDataObject
    {
        public IOneBendFeatureData IOneBendFeatureDataInstance { get; set; }
        public IOneBendFeatureDataObject(IOneBendFeatureData IOneBendFeatureDatainstance)
        {
            IOneBendFeatureDataInstance = IOneBendFeatureDatainstance;
        }
    }
    public static class IOneBendFeatureDataInterface
    {
        public static Boolean AccessSelections(IOneBendFeatureDataObject IOneBendFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IOneBendFeatureDataObject IOneBendFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.IAccessSelections(TopDoc.IModelDocInstance.CastObj<ModelDoc>(), Component.IComponentInstance?.CastObj<Component>());
        }
        public static void ReleaseSelectionAccess(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Boolean IAccessSelections2(IOneBendFeatureDataObject IOneBendFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.IAccessSelections2(TopDoc?.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component.IComponent2Instance.CastObj<Component2>());
        }
        public static Int32 GetType(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.GetType();
        }
        public static ICustomBendAllowanceObject GetCustomBendAllowance(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return new ICustomBendAllowanceObject(IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.GetCustomBendAllowance());
        }
        public static void SetCustomBendAllowance(IOneBendFeatureDataObject IOneBendFeatureDatainstance, ICustomBendAllowanceObject PBendData)
        {
            IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.SetCustomBendAllowance(PBendData?.ICustomBendAllowanceInstance?.CastObj<CustomBendAllowance>());
        }
        public static Int32 GetFlatPatternSketchSegmentCount(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.GetFlatPatternSketchSegmentCount();
        }
        public static ISketchSegmentObject IFlatPatternSketchSegments(IOneBendFeatureDataObject IOneBendFeatureDatainstance, Int32 SegmentsCount)
        {
            return new ISketchSegmentObject(IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.IFlatPatternSketchSegments(SegmentsCount));
        }
        public static Int32 GetFlatPatternSketchSegmentCount2(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.GetFlatPatternSketchSegmentCount2();
        }
        public static ISketchSegmentObject IFlatPatternSketchSegments2(IOneBendFeatureDataObject IOneBendFeatureDatainstance, Int32 SegmentsCount)
        {
            return new ISketchSegmentObject(IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.IFlatPatternSketchSegments2(SegmentsCount));
        }
        public static Double BendRadius(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.BendRadius;
        }
        public static Int32 BendAllowanceType(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.BendAllowanceType;
        }
        public static String BendTableFile(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.BendTableFile;
        }
        public static Double KFactor(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.KFactor;
        }
        public static Double BendAllowance(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.BendAllowance;
        }
        public static Boolean UseAutoRelief(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.UseAutoRelief;
        }
        public static Int32 AutoReliefType(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.AutoReliefType;
        }
        public static Boolean UseDefaultBendRadius(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.UseDefaultBendRadius;
        }
        public static Boolean UseDefaultBendAllowance(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.UseDefaultBendAllowance;
        }
        public static Boolean UseDefaultBendRelief(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.UseDefaultBendRelief;
        }
        public static Boolean BendDown(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.BendDown;
        }
        public static Double BendAngle(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.BendAngle;
        }
        public static Int32 BendOrder(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.BendOrder;
        }
        public static Double ReliefWidth(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.ReliefWidth;
        }
        public static Double ReliefDepth(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.ReliefDepth;
        }
        public static Boolean SimplifyGeometry(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.SimplifyGeometry;
        }
        public static Boolean UseReliefRatio(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.UseReliefRatio;
        }
        public static Double ReliefRatio(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.ReliefRatio;
        }
        public static ISketchSegmentObject FlatPatternSketchSegment(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return new ISketchSegmentObject(IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.FlatPatternSketchSegment);
        }
        public static Object FlatPatternSketchSegments(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.FlatPatternSketchSegments;
        }
        public static Object FlatPatternSketchSegments2(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.FlatPatternSketchSegments2;
        }
        public static Int32 BendDirection(IOneBendFeatureDataObject IOneBendFeatureDatainstance)
        {
            return IOneBendFeatureDatainstance.IOneBendFeatureDataInstance.BendDirection;
        }
    }
}