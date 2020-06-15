using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDrSectionObject
    {
        public IDrSection IDrSectionInstance { get; set; }
        public IDrSectionObject(IDrSection IDrSectioninstance)
        {
            IDrSectionInstance = IDrSectioninstance;
        }
    }
    public static class IDrSectionInterface
    {
        public static Object GetView(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetView();
        }
        public static IViewObject IGetView(IDrSectionObject IDrSectioninstance)
        {
            return new IViewObject(IDrSectioninstance.IDrSectionInstance.IGetView());
        }
        public static Object GetSectionView(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetSectionView();
        }
        public static IViewObject IGetSectionView(IDrSectionObject IDrSectioninstance)
        {
            return new IViewObject(IDrSectioninstance.IDrSectionInstance.IGetSectionView());
        }
        public static String GetLabel(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetLabel();
        }
        public static Boolean SetLabel(IDrSectionObject IDrSectioninstance, String Label)
        {
            return IDrSectioninstance.IDrSectionInstance.SetLabel(Label);
        }
        public static Boolean GetUseDocTextFormat(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetUseDocTextFormat();
        }
        public static Object GetTextFormat(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetTextFormat();
        }
        public static ITextFormatObject IGetTextFormat(IDrSectionObject IDrSectioninstance)
        {
            return new ITextFormatObject(IDrSectioninstance.IDrSectionInstance.IGetTextFormat());
        }
        public static Boolean SetTextFormat(IDrSectionObject IDrSectioninstance, Boolean UseDoc, Object TextFormat)
        {
            return IDrSectioninstance.IDrSectionInstance.SetTextFormat(UseDoc, TextFormat);
        }
        public static Boolean ISetTextFormat(IDrSectionObject IDrSectioninstance, Boolean UseDoc, ITextFormatObject TextFormat)
        {
            return IDrSectioninstance.IDrSectionInstance.ISetTextFormat(UseDoc, TextFormat.ITextFormatInstance as TextFormat);
        }
        public static Boolean GetReversedCutDirection(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetReversedCutDirection();
        }
        public static void SetReversedCutDirection(IDrSectionObject IDrSectioninstance, Boolean Reversed)
        {
            IDrSectioninstance.IDrSectionInstance.SetReversedCutDirection(Reversed);
        }
        public static Boolean GetScaleWithModelChanges(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetScaleWithModelChanges();
        }
        public static void SetScaleWithModelChanges(IDrSectionObject IDrSectioninstance, Boolean ScaleWithChanges)
        {
            IDrSectioninstance.IDrSectionInstance.SetScaleWithModelChanges(ScaleWithChanges);
        }
        public static Boolean GetPartialSection(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetPartialSection();
        }
        public static void SetPartialSection(IDrSectionObject IDrSectioninstance, Boolean Partial)
        {
            IDrSectioninstance.IDrSectionInstance.SetPartialSection(Partial);
        }
        public static Boolean GetDisplayOnlySurfaceCut(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetDisplayOnlySurfaceCut();
        }
        public static void SetDisplayOnlySurfaceCut(IDrSectionObject IDrSectioninstance, Boolean Display)
        {
            IDrSectioninstance.IDrSectionInstance.SetDisplayOnlySurfaceCut(Display);
        }
        public static Boolean IsAligned(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.IsAligned();
        }
        public static String GetName(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetName();
        }
        public static Object GetTextInfo(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetTextInfo();
        }
        public static Double IGetTextInfo(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.IGetTextInfo();
        }
        public static Object GetArrowInfo(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetArrowInfo();
        }
        public static Double IGetArrowInfo(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.IGetArrowInfo();
        }
        public static Object GetExcludedComponents(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetExcludedComponents();
        }
        //public static IEnumComponentsObject EnumExcludedComponents(IDrSectionObject IDrSectioninstance)
        //{
        //    return new IEnumComponentsObject(IDrSectioninstance.IDrSectionInstance.EnumExcludedComponents());
        //}
        public static Boolean GetAutoHatch(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetAutoHatch();
        }
        public static void SetAutoHatch(IDrSectionObject IDrSectioninstance, Boolean AutoHatch)
        {
            IDrSectioninstance.IDrSectionInstance.SetAutoHatch(AutoHatch);
        }
        public static Int32 IGetLineSegmentCount(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.IGetLineSegmentCount();
        }
        public static Object GetLineInfo(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetLineInfo();
        }
        public static Double IGetLineInfo(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.IGetLineInfo();
        }
        //public static IEnumComponents2Object EnumExcludedComponents2(IDrSectionObject IDrSectioninstance)
        //{
        //    return new IEnumComponents2Object(IDrSectioninstance.IDrSectionInstance.EnumExcludedComponents2());
        //}
        public static Int32 SetLabel2(IDrSectionObject IDrSectioninstance, String Label)
        {
            return IDrSectioninstance.IDrSectionInstance.SetLabel2(Label);
        }
        public static Boolean SetExcludedComponents(IDrSectionObject IDrSectioninstance, Object VComponents)
        {
            return IDrSectioninstance.IDrSectionInstance.SetExcludedComponents(VComponents);
        }
        //public static Boolean ISetExcludedComponents(IDrSectionObject IDrSectioninstance, Int32 Number, Component&Object LpComps)
        //{
        //    return IDrSectioninstance.IDrSectionInstance.ISetExcludedComponents(Number, LpComps);
        //}
        //public static Boolean GetDontCutAllInstances(IDrSectionObject IDrSectioninstance, ComponentObject LpComp)
        //{
        //    return IDrSectioninstance.IDrSectionInstance.GetDontCutAllInstances(LpComp);
        //}
        //public static Boolean SetDontCutAllInstances(IDrSectionObject IDrSectioninstance, ComponentObject LpComp, Boolean VbCut)
        //{
        //    return IDrSectioninstance.IDrSectionInstance.SetDontCutAllInstances(LpComp, VbCut);
        //}
        public static Boolean SetLineInfo(IDrSectionObject IDrSectioninstance, Object VLineInfo)
        {
            return IDrSectioninstance.IDrSectionInstance.SetLineInfo(VLineInfo);
        }
        //public static Boolean ISetLineInfo(IDrSectionObject IDrSectioninstance, Int32 Count, Double& PLineInfo)
        //{
        //    return IDrSectioninstance.IDrSectionInstance.ISetLineInfo(Count, PLineInfo);
        //}
        public static Boolean GetDisplayOnlySpeedPakBodies(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.GetDisplayOnlySpeedPakBodies();
        }
        public static void SetDisplayOnlySpeedPakBodies(IDrSectionObject IDrSectioninstance, Boolean Display)
        {
            IDrSectioninstance.IDrSectionInstance.SetDisplayOnlySpeedPakBodies(Display);
        }
        public static String Layer(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.Layer;
        }
        public static Boolean ExcludeFasteners(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.ExcludeFasteners;
        }
        public static Double SectionDepth(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.SectionDepth;
        }
        public static Boolean CutSurfaceBodies(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.CutSurfaceBodies;
        }
        public static Boolean ExcludeSliceSectionBodies(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.ExcludeSliceSectionBodies;
        }
        public static Boolean DisplaySurfaceBodies(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.DisplaySurfaceBodies;
        }
        public static Boolean ScaleHatchPattern(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.ScaleHatchPattern;
        }
        public static Boolean CuttingLineShoulders(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.CuttingLineShoulders;
        }
        public static Boolean RandomizeScale(IDrSectionObject IDrSectioninstance)
        {
            return IDrSectioninstance.IDrSectionInstance.RandomizeScale;
        }
    }
}