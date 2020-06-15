using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;

namespace DynamoSolidWorks
{
    public class IAnnotationObject
    {
        public IAnnotation IAnnotationInstance { get; set; }
        public IAnnotationObject(IAnnotation IAnnotationinstance)
        {
            IAnnotationInstance = IAnnotationinstance;
        }
    }
    public static class IAnnotationInterface
    {
        public static Boolean IsDangling(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.IsDangling();
        }
        public static String GetStyleName(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetStyleName();
        }
        public static Boolean SetStyleName(IAnnotationObject IAnnotationinstance, String StyleName)
        {
            return IAnnotationinstance.IAnnotationInstance.SetStyleName(StyleName);
        }
        public static Boolean ApplyDefaultStyleAttributes(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.ApplyDefaultStyleAttributes();
        }
        public static Boolean AddOrUpdateStyle(IAnnotationObject IAnnotationinstance, String StyleName, Boolean BreakLinks)
        {
            return IAnnotationinstance.IAnnotationInstance.AddOrUpdateStyle(StyleName, BreakLinks);
        }
        public static Boolean DeleteStyle(IAnnotationObject IAnnotationinstance, String StyleName)
        {
            return IAnnotationinstance.IAnnotationInstance.DeleteStyle(StyleName);
        }
        public static Boolean SaveStyle(IAnnotationObject IAnnotationinstance, String StyleName, String PathName)
        {
            return IAnnotationinstance.IAnnotationInstance.SaveStyle(StyleName, PathName);
        }
        public static Boolean LoadStyle(IAnnotationObject IAnnotationinstance, String PathName)
        {
            return IAnnotationinstance.IAnnotationInstance.LoadStyle(PathName);
        }
        public static Boolean IsDimXpert(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.IsDimXpert();
        }
        public static Object GetDimXpertFeature(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetDimXpertFeature();
        }
        public static Boolean SetPosition2(IAnnotationObject IAnnotationinstance, Double X, Double Y, Double Z)
        {
            return IAnnotationinstance.IAnnotationInstance.SetPosition2(X, Y, Z);
        }
        public static Object GetPlane(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetPlane();
        }
        public static IMathTransformObject GetFlipPlaneTransform(IAnnotationObject IAnnotationinstance)
        {
            return new IMathTransformObject(IAnnotationinstance.IAnnotationInstance.GetFlipPlaneTransform());
        }
        public static Boolean CanShowInAnnotationView(IAnnotationObject IAnnotationinstance, String AnnotationViewName)
        {
            return IAnnotationinstance.IAnnotationInstance.CanShowInAnnotationView(AnnotationViewName);
        }
        public static Boolean CanShowInMultipleAnnotationViews(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.CanShowInMultipleAnnotationViews();
        }
        public static Object GetParagraphs(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetParagraphs();
        }
        public static String GetDimXpertName(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetDimXpertName();
        }
        public static Boolean SetLeaderAttachmentPointAtIndex(IAnnotationObject IAnnotationinstance, Int32 Index, Double X, Double Y, Double Z)
        {
            return IAnnotationinstance.IAnnotationInstance.SetLeaderAttachmentPointAtIndex(Index, X, Y, Z);
        }
        public static Object GetNext(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetNext();
        }
        public static IAnnotationObject IGetNext(IAnnotationObject IAnnotationinstance)
        {
            return new IAnnotationObject(IAnnotationinstance.IAnnotationInstance.IGetNext());
        }
        public static Object GetDisplayData(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetDisplayData();
        }
        public static IDisplayDataObject IGetDisplayData(IAnnotationObject IAnnotationinstance)
        {
            return new IDisplayDataObject(IAnnotationinstance.IAnnotationInstance.IGetDisplayData());
        }
        public static Int32 GetType(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetType();
        }
        public static Object GetSpecificAnnotation(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetSpecificAnnotation();
        }
        public static Object IGetSpecificAnnotation(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.IGetSpecificAnnotation();
        }
        public static Object GetPosition(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetPosition();
        }
        public static Double IGetPosition(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.IGetPosition();
        }
        public static Boolean SetPosition(IAnnotationObject IAnnotationinstance, Double X, Double Y, Double Z)
        {
            return IAnnotationinstance.IAnnotationInstance.SetPosition(X, Y, Z);
        }
        public static Int32 GetLeaderCount(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetLeaderCount();
        }
        public static Object GetLeaderPointsAtIndex(IAnnotationObject IAnnotationinstance, Int32 Index)
        {
            return IAnnotationinstance.IAnnotationInstance.GetLeaderPointsAtIndex(Index);
        }
        public static Double IGetLeaderPointsAtIndex(IAnnotationObject IAnnotationinstance, Int32 Index, Int32 PointCount)
        {
            return IAnnotationinstance.IAnnotationInstance.IGetLeaderPointsAtIndex(Index, PointCount);
        }
        public static Int32 GetArrowHeadStyleAtIndex(IAnnotationObject IAnnotationinstance, Int32 Index)
        {
            return IAnnotationinstance.IAnnotationInstance.GetArrowHeadStyleAtIndex(Index);
        }
        public static Int32 SetArrowHeadStyleAtIndex(IAnnotationObject IAnnotationinstance, Int32 Index, Int32 ArrowHeadStyle)
        {
            return IAnnotationinstance.IAnnotationInstance.SetArrowHeadStyleAtIndex(Index, ArrowHeadStyle);
        }
        public static Boolean GetLeader(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetLeader();
        }
        public static Boolean GetBentLeader(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetBentLeader();
        }
        public static Int32 GetLeaderSide(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetLeaderSide();
        }
        public static Boolean GetSmartArrowHeadStyle(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetSmartArrowHeadStyle();
        }
        public static Int32 SetLeader(IAnnotationObject IAnnotationinstance, Boolean Leader, Int32 LeaderSide, Boolean SmartArrowHeadStyle, Boolean BentLeader)
        {
            return IAnnotationinstance.IAnnotationInstance.SetLeader(Leader, LeaderSide, SmartArrowHeadStyle, BentLeader);
        }
        public static String GetName(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetName();
        }
        public static Boolean SetName(IAnnotationObject IAnnotationinstance, String NameIn)
        {
            return IAnnotationinstance.IAnnotationInstance.SetName(NameIn);
        }
        public static Object GetVisualProperties(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetVisualProperties();
        }
        public static Int32 IGetVisualProperties(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.IGetVisualProperties();
        }
        public static Int32 IGetAttachedEntityCount(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.IGetAttachedEntityCount();
        }
        public static Object GetAttachedEntities(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetAttachedEntities();
        }
        public static Object IGetAttachedEntities(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.IGetAttachedEntities();
        }
        public static Object GetAttachedEntityTypes(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetAttachedEntityTypes();
        }
        public static Int32 IGetAttachedEntityTypes(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.IGetAttachedEntityTypes();
        }
        public static Object GetNext2(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetNext2();
        }
        public static IAnnotationObject IGetNext2(IAnnotationObject IAnnotationinstance)
        {
            return new IAnnotationObject(IAnnotationinstance.IAnnotationInstance.IGetNext2());
        }
        public static Int32 GetTextFormatCount(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetTextFormatCount();
        }
        public static Boolean GetUseDocTextFormat(IAnnotationObject IAnnotationinstance, Int32 Index)
        {
            return IAnnotationinstance.IAnnotationInstance.GetUseDocTextFormat(Index);
        }
        public static Object GetTextFormat(IAnnotationObject IAnnotationinstance, Int32 Index)
        {
            return IAnnotationinstance.IAnnotationInstance.GetTextFormat(Index);
        }
        public static ITextFormatObject IGetTextFormat(IAnnotationObject IAnnotationinstance, Int32 Index)
        {
            return new ITextFormatObject(IAnnotationinstance.IAnnotationInstance.IGetTextFormat(Index));
        }
        public static Boolean SetTextFormat(IAnnotationObject IAnnotationinstance, Int32 Index, Boolean UseDoc, Object TextFormat)
        {
            return IAnnotationinstance.IAnnotationInstance.SetTextFormat(Index, UseDoc, TextFormat);
        }
        public static Boolean ISetTextFormat(IAnnotationObject IAnnotationinstance, Int32 Index, Boolean UseDoc, ITextFormatObject TextFormat)
        {
            return IAnnotationinstance.IAnnotationInstance.ISetTextFormat(Index, UseDoc, TextFormat.ITextFormatInstance as TextFormat);
        }
        public static Boolean GetLeaderPerpendicular(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetLeaderPerpendicular();
        }
        public static Boolean GetLeaderAllAround(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetLeaderAllAround();
        }
        public static Int32 SetLeader2(IAnnotationObject IAnnotationinstance, Boolean Leader, Int32 LeaderSide, Boolean SmartArrowHeadStyle, Boolean BentLeader, Boolean Perpendicular, Boolean AllAround)
        {
            return IAnnotationinstance.IAnnotationInstance.SetLeader2(Leader, LeaderSide, SmartArrowHeadStyle, BentLeader, Perpendicular, AllAround);
        }
        public static Boolean Select(IAnnotationObject IAnnotationinstance, Boolean AppendFlag)
        {
            return IAnnotationinstance.IAnnotationInstance.Select(AppendFlag);
        }
        public static Boolean SelectByMark(IAnnotationObject IAnnotationinstance, Boolean AppendFlag, Int32 Mark)
        {
            return IAnnotationinstance.IAnnotationInstance.SelectByMark(AppendFlag, Mark);
        }
        public static Boolean DeSelect(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.DeSelect();
        }
        public static Boolean Select2(IAnnotationObject IAnnotationinstance, Boolean Append, Int32 Mark)
        {
            return IAnnotationinstance.IAnnotationInstance.Select2(Append, Mark);
        }
        public static Boolean Select3(IAnnotationObject IAnnotationinstance, Boolean Append, ISelectDataObject Data)
        {
            return IAnnotationinstance.IAnnotationInstance.Select3(Append, Data.ISelectDataInstance as SelectData);
        }
        public static Int32 GetAttachedEntityCount2(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetAttachedEntityCount2();
        }
        public static Object GetAttachedEntities2(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetAttachedEntities2();
        }
        public static IAnnotationObject GetNext3(IAnnotationObject IAnnotationinstance)
        {
            return new IAnnotationObject(IAnnotationinstance.IAnnotationInstance.GetNext3());
        }
        public static Boolean GetDashedLeader(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetDashedLeader();
        }
        public static Int32 GetLeaderStyle(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetLeaderStyle();
        }
        public static Int32 SetLeader3(IAnnotationObject IAnnotationinstance, Int32 LeaderStyle, Int32 LeaderSide, Boolean SmartArrowHeadStyle, Boolean Perpendicular, Boolean AllAround, Boolean Dashed)
        {
            return IAnnotationinstance.IAnnotationInstance.SetLeader3(LeaderStyle, LeaderSide, SmartArrowHeadStyle, Perpendicular, AllAround, Dashed);
        }
        public static Boolean SetAttachedEntities(IAnnotationObject IAnnotationinstance, Object AttachedEnts)
        {
            return IAnnotationinstance.IAnnotationInstance.SetAttachedEntities(AttachedEnts);
        }

        [MultiReturn(SWValueConst.Result, SWValueConst.LpArr)]
        public static Dictionary<string, object> ISetAttachedEntities(IAnnotationObject IAnnotationinstance, Int32 Count, Object LpArr)
        {
            bool result = IAnnotationinstance.IAnnotationInstance.ISetAttachedEntities(Count, LpArr);
            return new Dictionary<string, object>() { { SWValueConst.Result, result }, { SWValueConst.LpArr, LpArr } };
        }
        public static Object CheckSpelling(IAnnotationObject IAnnotationinstance, Int32 Options, String Dictionary)
        {
            return IAnnotationinstance.IAnnotationInstance.CheckSpelling(Options, Dictionary);
        }
        public static Boolean ConvertToMultiJog(IAnnotationObject IAnnotationinstance, Int32 LeaderNumber, Int32 NumberOfPoints, Object PointsData)
        {
            return IAnnotationinstance.IAnnotationInstance.ConvertToMultiJog(LeaderNumber, NumberOfPoints, PointsData);
        }
        public static Int32 GetAttachedEntityCount3(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetAttachedEntityCount3();
        }
        public static Object GetAttachedEntities3(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetAttachedEntities3();
        }
        public static Int32 GetArrowHeadCount(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetArrowHeadCount();
        }



        [MultiReturn(SWValueConst.Result, SWValueConst.UseDoc, SWValueConst.Length, SWValueConst.Width, SWValueConst.Width)]
        public static Dictionary<string, object> GetArrowHeadSizeAtIndex(IAnnotationObject IAnnotationinstance, Int32 Index, Boolean UseDoc, Double Length, Double Width, Double Height)
        {
            bool result = IAnnotationinstance.IAnnotationInstance.GetArrowHeadSizeAtIndex(Index, ref UseDoc, ref Length, ref Width, ref Height);

            return new Dictionary<string, object>() { { SWValueConst.Result, result }, { SWValueConst.UseDoc, UseDoc }, { SWValueConst.Length, Length }, { SWValueConst.Width, Width }, { SWValueConst.Height, Height } };
        }
        public static Boolean SetArrowHeadSizeAtIndex(IAnnotationObject IAnnotationinstance, Int32 Index, Boolean UseDoc, Double Length, Double Width, Double Height)
        {
            return IAnnotationinstance.IAnnotationInstance.SetArrowHeadSizeAtIndex(Index, UseDoc, Length, Width, Height);
        }
        public static Int32 GetMultiJogLeaderCount(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetMultiJogLeaderCount();
        }
        public static Object GetMultiJogLeaders(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.GetMultiJogLeaders();
        }
        public static IMultiJogLeaderObject IGetMultiJogLeaders(IAnnotationObject IAnnotationinstance, Int32 Count)
        {
            return new IMultiJogLeaderObject(IAnnotationinstance.IAnnotationInstance.IGetMultiJogLeaders(Count));
        }
        public static String Layer(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.Layer;
        }
        public static Int32 LayerOverride(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.LayerOverride;
        }
        public static Int32 Color(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.Color;
        }
        public static Int32 Style(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.Style;
        }
        public static Int32 Width(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.Width;
        }
        public static Int32 Visible(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.Visible;
        }
        public static Object Owner(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.Owner;
        }
        public static Int32 OwnerType(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.OwnerType;
        }
        public static IAnnotationViewObject AnnotationView(IAnnotationObject IAnnotationinstance)
        {
            return new IAnnotationViewObject(IAnnotationinstance.IAnnotationInstance.AnnotationView);
        }
        public static Boolean UseDocDispFrame(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.UseDocDispFrame;
        }
        public static Int32 FrameThickness(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.FrameThickness;
        }
        public static Double FrameThicknessCustom(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.FrameThicknessCustom;
        }
        public static Int32 FrameLineStyle(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.FrameLineStyle;
        }
        public static Boolean UseDocDispLeader(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.UseDocDispLeader;
        }
        public static Int32 LeaderThickness(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.LeaderThickness;
        }
        public static Double LeaderThicknessCustom(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.LeaderThicknessCustom;
        }
        public static Int32 LeaderLineStyle(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.LeaderLineStyle;
        }
        public static Double BentLeaderLength(IAnnotationObject IAnnotationinstance)
        {
            return IAnnotationinstance.IAnnotationInstance.BentLeaderLength;
        }
    }
}