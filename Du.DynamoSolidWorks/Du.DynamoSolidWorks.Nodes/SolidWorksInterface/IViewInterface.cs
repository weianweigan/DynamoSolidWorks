using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IViewObject
    {
        public IView IViewInstance { get; set; }
        public IViewObject(IView IViewinstance)
        {
            IViewInstance = IViewinstance;
        }
    }
    public static class IViewInterface
    {
        public static Int32 GetBreakOutSectionCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetBreakOutSectionCount();
        }
        public static IFeatureObject IGetBreakOutSections(IViewObject IViewinstance, Int32 Count)
        {
            return new IFeatureObject(IViewinstance.IViewInstance.IGetBreakOutSections(Count));
        }
        public static Object GetFirstRevisionCloud(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstRevisionCloud();
        }
        public static IRevisionCloudObject IGetFirstRevisionCloud(IViewObject IViewinstance)
        {
            return new IRevisionCloudObject(IViewinstance.IViewInstance.IGetFirstRevisionCloud());
        }
        public static Int32 GetRevisionCloudCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetRevisionCloudCount();
        }
        public static Object GetRevisionClouds(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetRevisionClouds();
        }
        public static IRevisionCloudObject IGetRevisionClouds(IViewObject IViewinstance, Int32 NumRevClouds)
        {
            return new IRevisionCloudObject(IViewinstance.IViewInstance.IGetRevisionClouds(NumRevClouds));
        }
        public static IBomTableAnnotationObject InsertBomTable4(IViewObject IViewinstance, Boolean UseAnchorPoint, Double X, Double Y, Int32 AnchorType, Int32 BomType, String Configuration, String TableTemplate, Boolean Hidden, Int32 IndentedNumberingType, Boolean DetailedCutList)
        {
            return new IBomTableAnnotationObject(IViewinstance.IViewInstance.InsertBomTable4(UseAnchorPoint, X, Y, AnchorType, BomType, Configuration, TableTemplate, Hidden, IndentedNumberingType, DetailedCutList));
        }
        public static String GetUniqueName(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetUniqueName();
        }
        public static Boolean MergeBendTags(IViewObject IViewinstance, Boolean Merge, Object BendNotes)
        {
            return IViewinstance.IViewInstance.MergeBendTags(Merge, BendNotes);
        }
        public static String GetBendNoteAttributeString(IViewObject IViewinstance, Int32 Attribute)
        {
            return IViewinstance.IViewInstance.GetBendNoteAttributeString(Attribute);
        }
        public static String GetBendNoteTextFormat(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetBendNoteTextFormat();
        }
        public static Boolean SetBendNoteTextFormat(IViewObject IViewinstance, String Format)
        {
            return IViewinstance.IViewInstance.SetBendNoteTextFormat(Format);
        }
        public static void InsertCutListPropertyNote(IViewObject IViewinstance, Double X, Double Y, Double Z)
        {
            IViewinstance.IViewInstance.InsertCutListPropertyNote(X, Y, Z);
        }
        public static Object GetFirstCenterOfMass(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstCenterOfMass();
        }
        public static ICenterOfMassObject IGetFirstCenterOfMass(IViewObject IViewinstance)
        {
            return new ICenterOfMassObject(IViewinstance.IViewInstance.IGetFirstCenterOfMass());
        }
        public static Boolean ReplaceViewWithSketch(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.ReplaceViewWithSketch();
        }
        //public static Boolean ReplaceViewWithBlock(IViewObject IViewinstance, MathPointObject InsertionPoint)
        //{
        //    return IViewinstance.IViewInstance.ReplaceViewWithBlock(InsertionPoint);
        //}
        //public static Boolean InsertViewAsBlock(IViewObject IViewinstance, MathPointObject InsertionPoint, MathPointObject Position)
        //{
        //    return IViewinstance.IViewInstance.InsertViewAsBlock(InsertionPoint, Position);
        //}
        //public static Int32 GetVisibleEntityCount2(IViewObject IViewinstance, Component2Object LpViewComponent, Int32 EntityType)
        //{
        //    return IViewinstance.IViewInstance.GetVisibleEntityCount2(LpViewComponent, EntityType);
        //}
        //public static Object GetVisibleEntities2(IViewObject IViewinstance, Component2Object LpViewComponent, Int32 EntityType)
        //{
        //    return IViewinstance.IViewInstance.GetVisibleEntities2(LpViewComponent, EntityType);
        //}
        //public static IEntityObject IGetVisibleEntities2(IViewObject IViewinstance, Component2Object LpViewComponent, Int32 EntityType, Int32 ViewEntityCount)
        //{
        //    return new IEntityObject(IViewinstance.IViewInstance.IGetVisibleEntities2(LpViewComponent, EntityType, ViewEntityCount));
        //}
        public static Boolean AlignDrawingView(IViewObject IViewinstance, Int32 AlignViewType)
        {
            return IViewinstance.IViewInstance.AlignDrawingView(AlignViewType);
        }
        public static Boolean ShowModelBreakState(IViewObject IViewinstance, Boolean ShowIt, String BreakName)
        {
            return IViewinstance.IViewInstance.ShowModelBreakState(ShowIt, BreakName);
        }
        public static Boolean IsModelBreakState(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IsModelBreakState();
        }
        public static Boolean AutoInsertCenterMarks2(IViewObject IViewinstance, Int32 InsertType, Int32 InsertOption, Boolean LinearSlotCenter, Boolean ArcSlotCenter, Boolean UseDocumentDefaults, Double Size, Double Gap, Boolean ExtendedLines, Boolean CenterLineFont, Double Angle)
        {
            return IViewinstance.IViewInstance.AutoInsertCenterMarks2(InsertType, InsertOption, LinearSlotCenter, ArcSlotCenter, UseDocumentDefaults, Size, Gap, ExtendedLines, CenterLineFont, Angle);
        }
        public static IBreakLineObject InsertBreak2(IViewObject IViewinstance, Int32 Orientation, Double Position1, Double Position2, Int32 Style, Int32 ShapeIntensity)
        {
            return new IBreakLineObject(IViewinstance.IViewInstance.InsertBreak2(Orientation, Position1, Position2, Style, ShapeIntensity));
        }
        public static Boolean SetMirrorViewOrientation(IViewObject IViewinstance, Boolean BSetIsMirrorView, Int32 BMirrorVieworientation)
        {
            return IViewinstance.IViewInstance.SetMirrorViewOrientation(BSetIsMirrorView, BMirrorVieworientation);
        }
        //public static Boolean GetMirrorViewOrientation(IViewObject IViewinstance, Boolean& BIsMirrorView, Int32& LMirrorViewOrientation)
        //{
        //    return IViewinstance.IViewInstance.GetMirrorViewOrientation(BIsMirrorView, LMirrorViewOrientation);
        //}
        public static Int32 Crop2(IViewObject IViewinstance, Boolean JaggedOutline, Boolean NoOutline, Int32 ShapeIntensity)
        {
            return IViewinstance.IViewInstance.Crop2(JaggedOutline, NoOutline, ShapeIntensity);
        }
        public static Object GetCorresponding(IViewObject IViewinstance, Object InputObject)
        {
            return IViewinstance.IViewInstance.GetCorresponding(InputObject);
        }
        public static Object GetCorrespondingEntity(IViewObject IViewinstance, Object Entity)
        {
            return IViewinstance.IViewInstance.GetCorrespondingEntity(Entity);
        }
        public static Object InsertBreak3(IViewObject IViewinstance, Int32 Orientation, Double Position1, Double Position2, Int32 Style, Int32 ShapeIntensity, Boolean BreakSketchBlocks)
        {
            return IViewinstance.IViewInstance.InsertBreak3(Orientation, Position1, Position2, Style, ShapeIntensity, BreakSketchBlocks);
        }
        public static Object GetProjectionLines(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetProjectionLines();
        }
        public static IProjectionArrowObject IGetProjectionLines(IViewObject IViewinstance, Int32 Count)
        {
            return new IProjectionArrowObject(IViewinstance.IViewInstance.IGetProjectionLines(Count));
        }
        public static String GetOrientationName(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetOrientationName();
        }
        //public static Object GetPolylines7(IViewObject IViewinstance, Int16 CrossHatchOption, Object& Polylines)
        //{
        //    return IViewinstance.IViewInstance.GetPolylines7(CrossHatchOption, Polylines);
        //}
        //public static Object IGetPolylines7(IViewObject IViewinstance, Int16 CrossHatchOption, Int32 ArraySize, Double& Polylines, Int32 EdgeArraySize)
        //{
        //    return IViewinstance.IViewInstance.IGetPolylines7(CrossHatchOption, ArraySize, Polylines, EdgeArraySize);
        //}
        public static Object GetNotes(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetNotes();
        }
        public static Int32 GetNoteCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetNoteCount();
        }
        public static INoteObject IGetNotes(IViewObject IViewinstance, Int32 NumberOfNotes)
        {
            return new INoteObject(IViewinstance.IViewInstance.IGetNotes(NumberOfNotes));
        }
        public static Int32 GetDatumTargetSymCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDatumTargetSymCount();
        }
        public static Object GetDatumTargetSyms(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDatumTargetSyms();
        }
        public static IDatumTargetSymObject IGetDatumTargetSyms(IViewObject IViewinstance, Int32 NumDatumTargetSym)
        {
            return new IDatumTargetSymObject(IViewinstance.IViewInstance.IGetDatumTargetSyms(NumDatumTargetSym));
        }
        public static Int32 GetDowelSymbolCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDowelSymbolCount();
        }
        public static Object GetDowelSymbols(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDowelSymbols();
        }
        public static IDowelSymbolObject IGetDowelSymbols(IViewObject IViewinstance, Int32 NumDowelSymbol)
        {
            return new IDowelSymbolObject(IViewinstance.IViewInstance.IGetDowelSymbols(NumDowelSymbol));
        }
        public static Int32 GetMultiJogLeaderCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetMultiJogLeaderCount();
        }
        public static Object GetMultiJogLeaders(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetMultiJogLeaders();
        }
        public static IMultiJogLeaderObject IGetMultiJogLeaders(IViewObject IViewinstance, Int32 NumMultiJogLeader)
        {
            return new IMultiJogLeaderObject(IViewinstance.IViewInstance.IGetMultiJogLeaders(NumMultiJogLeader));
        }
        public static Int32 GetGTolCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetGTolCount();
        }
        public static Object GetGTols(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetGTols();
        }
        public static IGtolObject IGetGTols(IViewObject IViewinstance, Int32 NumGTol)
        {
            return new IGtolObject(IViewinstance.IViewInstance.IGetGTols(NumGTol));
        }
        public static Int32 GetDatumOriginCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDatumOriginCount();
        }
        public static Object GetDatumOrigins(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDatumOrigins();
        }
        public static IDatumOriginObject IGetDatumOrigins(IViewObject IViewinstance, Int32 NumDatumOrigin)
        {
            return new IDatumOriginObject(IViewinstance.IViewInstance.IGetDatumOrigins(NumDatumOrigin));
        }
        public static Int32 GetCenterLineCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetCenterLineCount();
        }
        public static Object GetCenterLines(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetCenterLines();
        }
        //public static ICenterlineObject IGetCenterLines(IViewObject IViewinstance, Int32 NumCenterLine)
        //{
        //    return new ICenterlineObject(IViewinstance.IViewInstance.IGetCenterLines(NumCenterLine));
        //}
        public static Int32 GetCThreadCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetCThreadCount();
        }
        public static Object GetCThreads(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetCThreads();
        }
        public static ICThreadObject IGetCThreads(IViewObject IViewinstance, Int32 NumCThread)
        {
            return new ICThreadObject(IViewinstance.IViewInstance.IGetCThreads(NumCThread));
        }
        public static Int32 GetSFSymbolCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSFSymbolCount();
        }
        public static Object GetSFSymbols(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSFSymbols();
        }
        public static ISFSymbolObject IGetSFSymbols(IViewObject IViewinstance, Int32 NumSFSymbol)
        {
            return new ISFSymbolObject(IViewinstance.IViewInstance.IGetSFSymbols(NumSFSymbol));
        }
        public static Int32 GetDatumTagCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDatumTagCount();
        }
        public static Object GetDatumTags(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDatumTags();
        }
        public static IDatumTagObject IGetDatumTags(IViewObject IViewinstance, Int32 NumDatumTag)
        {
            return new IDatumTagObject(IViewinstance.IViewInstance.IGetDatumTags(NumDatumTag));
        }
        public static Int32 GetWeldSymbolCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetWeldSymbolCount();
        }
        public static Object GetWeldSymbols(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetWeldSymbols();
        }
        public static IWeldSymbolObject IGetWeldSymbols(IViewObject IViewinstance, Int32 NumWeldSymbol)
        {
            return new IWeldSymbolObject(IViewinstance.IViewInstance.IGetWeldSymbols(NumWeldSymbol));
        }
        public static Int32 GetWeldBeadCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetWeldBeadCount();
        }
        public static Object GetWeldBeads(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetWeldBeads();
        }
        public static IWeldBeadObject IGetWeldBeads(IViewObject IViewinstance, Int32 NumWeldBead)
        {
            return new IWeldBeadObject(IViewinstance.IViewInstance.IGetWeldBeads(NumWeldBead));
        }
        public static Int32 GetTableAnnotationCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetTableAnnotationCount();
        }
        public static Object GetTableAnnotations(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetTableAnnotations();
        }
        public static ITableAnnotationObject IGetTableAnnotations(IViewObject IViewinstance, Int32 NumTableAnnotation)
        {
            return new ITableAnnotationObject(IViewinstance.IViewInstance.IGetTableAnnotations(NumTableAnnotation));
        }
        public static Int32 GetDisplayDimensionCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDisplayDimensionCount();
        }
        public static Object GetDisplayDimensions(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDisplayDimensions();
        }
        public static IDisplayDimensionObject IGetDisplayDimensions(IViewObject IViewinstance, Int32 NumDisplayDim)
        {
            return new IDisplayDimensionObject(IViewinstance.IViewInstance.IGetDisplayDimensions(NumDisplayDim));
        }
        public static Boolean IsFlatPatternView(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IsFlatPatternView();
        }
        public static Int32 GetRelatedTangentEdgeCount(IViewObject IViewinstance, Object BendLine)
        {
            return IViewinstance.IViewInstance.GetRelatedTangentEdgeCount(BendLine);
        }
        public static Object GetRelatedTangentEdges(IViewObject IViewinstance, Object BendLine)
        {
            return IViewinstance.IViewInstance.GetRelatedTangentEdges(BendLine);
        }
        //public static IEdgeObject IGetRelatedTangentEdges(IViewObject IViewinstance, SketchSegmentObject BendLine, Int32 NumOfTangentEdges)
        //{
        //    return new IEdgeObject(IViewinstance.IViewInstance.IGetRelatedTangentEdges(BendLine, NumOfTangentEdges));
        //}
        //public static Int32 GetSolidHatchCount(IViewObject IViewinstance, Int32& ArraySize)
        //{
        //    return IViewinstance.IViewInstance.GetSolidHatchCount(ArraySize);
        //}
        public static Object GetSolidHatchInfo(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSolidHatchInfo();
        }
        public static Double IGetSolidHatchInfo(IViewObject IViewinstance, Int32 ArraySize)
        {
            return IViewinstance.IViewInstance.IGetSolidHatchInfo(ArraySize);
        }
        public static Object GetBendLines(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetBendLines();
        }
        public static ISketchSegmentObject IGetBendLines(IViewObject IViewinstance, Int32 NumberOfBendLine)
        {
            return new ISketchSegmentObject(IViewinstance.IViewInstance.IGetBendLines(NumberOfBendLine));
        }
        public static Int32 GetBendLineCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetBendLineCount();
        }
        public static Int32 GetSketchPictureCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSketchPictureCount();
        }
        public static Object GetSketchPictures(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSketchPictures();
        }
        public static ISketchPictureObject IGetSketchPictures(IViewObject IViewinstance, Int32 Count)
        {
            return new ISketchPictureObject(IViewinstance.IViewInstance.IGetSketchPictures(Count));
        }
        public static IBomTableAnnotationObject InsertBomTable3(IViewObject IViewinstance, Boolean UseAnchorPoint, Double X, Double Y, Int32 AnchorType, Int32 BomType, String Configuration, String TableTemplate, Boolean Hidden)
        {
            return new IBomTableAnnotationObject(IViewinstance.IViewInstance.InsertBomTable3(UseAnchorPoint, X, Y, AnchorType, BomType, Configuration, TableTemplate, Hidden));
        }
        public static Int32 GetBodiesCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetBodiesCount();
        }
        public static IBody2Object IGetBodies(IViewObject IViewinstance, Int32 Count)
        {
            return new IBody2Object(IViewinstance.IViewInstance.IGetBodies(Count));
        }
        //public static void ISetBodies(IViewObject IViewinstance, Int32 Count, Body2&Object BodyArray)
        //{
        //    return IViewinstance.IViewInstance.ISetBodies(Count, BodyArray);
        //}
        public static Object GetSMBoundaryBoxDisplayData(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSMBoundaryBoxDisplayData();
        }
        public static IDisplayDataObject IGetSMBoundaryBoxDisplayData(IViewObject IViewinstance)
        {
            return new IDisplayDataObject(IViewinstance.IViewInstance.IGetSMBoundaryBoxDisplayData());
        }
        public static Boolean InsertWeldTable(IViewObject IViewinstance, Boolean UseAnchorPoint, Boolean IncludeAnnotations, Boolean CombineSameType, Double X, Double Y, Int32 AnchorType, String Configuration, String TableTemplate)
        {
            return IViewinstance.IViewInstance.InsertWeldTable(UseAnchorPoint, IncludeAnnotations, CombineSameType, X, Y, AnchorType, Configuration, TableTemplate);
        }
        public static Object GetBreakLineInfo2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetBreakLineInfo2();
        }
        public static Double IGetBreakLineInfo2(IViewObject IViewinstance, Int32 ArraySize)
        {
            return IViewinstance.IViewInstance.IGetBreakLineInfo2(ArraySize);
        }
        //public static Int32 GetBreakLineCount2(IViewObject IViewinstance, Int32& Size)
        //{
        //    return IViewinstance.IViewInstance.GetBreakLineCount2(Size);
        //}
        public static void ResetSketchVisibility(IViewObject IViewinstance)
        {
            IViewinstance.IViewInstance.ResetSketchVisibility();
        }
        public static IHoleTableAnnotationObject InsertHoleTable2(IViewObject IViewinstance, Boolean UseAnchorPoint, Double X, Double Y, Int32 AnchorType, String StartValue, String TableTemplate)
        {
            return new IHoleTableAnnotationObject(IViewinstance.IViewInstance.InsertHoleTable2(UseAnchorPoint, X, Y, AnchorType, StartValue, TableTemplate));
        }
        public static Boolean AutoInsertCenterMarks(IViewObject IViewinstance, Int32 InsertType, Int32 InsertOption, Boolean LinearSlotCenter, Boolean ArcSlotCenter, Boolean UseDocumentDefaults, Double Size, Boolean ExtendedLines, Boolean CenterLineFont, Double Angle)
        {
            return IViewinstance.IViewInstance.AutoInsertCenterMarks(InsertType, InsertOption, LinearSlotCenter, ArcSlotCenter, UseDocumentDefaults, Size, ExtendedLines, CenterLineFont, Angle);
        }
        public static Object GetWitnessGeomInfo(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetWitnessGeomInfo();
        }
        public static Double IGetWitnessGeomInfo(IViewObject IViewinstance, Int32 ArraySize)
        {
            return IViewinstance.IViewInstance.IGetWitnessGeomInfo(ArraySize);
        }
        //public static Int32 GetWitnessEntitiesCount(IViewObject IViewinstance, Int32& Size)
        //{
        //    return IViewinstance.IViewInstance.GetWitnessEntitiesCount(Size);
        //}
        public static IBendTableAnnotationObject InsertBendTable(IViewObject IViewinstance, Boolean UseAnchorPoint, Double X, Double Y, Int32 AnchorType, String StartValue, String TableTemplate)
        {
            return new IBendTableAnnotationObject(IViewinstance.IViewInstance.InsertBendTable(UseAnchorPoint, X, Y, AnchorType, StartValue, TableTemplate));
        }
        public static IPunchTableAnnotationObject InsertPunchTable(IViewObject IViewinstance, Boolean UseAnchorPoint, Double X, Double Y, Int32 AnchorType, String StartValue, String TableTemplate)
        {
            return new IPunchTableAnnotationObject(IViewinstance.IViewInstance.InsertPunchTable(UseAnchorPoint, X, Y, AnchorType, StartValue, TableTemplate));
        }
        public static Object GetBreakOutSections(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetBreakOutSections();
        }
        public static Double IGetBreakLineInfo(IViewObject IViewinstance, Int32 ArraySize)
        {
            return IViewinstance.IViewInstance.IGetBreakLineInfo(ArraySize);
        }
        public static Int32 GetFaceHatchCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFaceHatchCount();
        }
        public static Object GetFaceHatches(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFaceHatches();
        }
        public static IFaceHatchObject IGetFaceHatches(IViewObject IViewinstance, Int32 NumFacesHatches)
        {
            return new IFaceHatchObject(IViewinstance.IViewInstance.IGetFaceHatches(NumFacesHatches));
        }
        //public static Int32 GetCenterMarkCount2(IViewObject IViewinstance, Int32& Size)
        //{
        //    return IViewinstance.IViewInstance.GetCenterMarkCount2(Size);
        //}
        public static Object GetCenterMarks(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetCenterMarks();
        }
        public static ICenterMarkObject IGetCenterMarks(IViewObject IViewinstance, Int32 Count)
        {
            return new ICenterMarkObject(IViewinstance.IViewInstance.IGetCenterMarks(Count));
        }
        public static ICenterMarkObject GetFirstCenterMark(IViewObject IViewinstance)
        {
            return new ICenterMarkObject(IViewinstance.IViewInstance.GetFirstCenterMark());
        }
        public static ISketchObject GetCenterLineSketch(IViewObject IViewinstance)
        {
            return new ISketchObject(IViewinstance.IViewInstance.GetCenterLineSketch());
        }
        public static Int32 GetDimensionDisplayInfoSize(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionDisplayInfoSize();
        }
        public static Object GetDimensionDisplayInfo4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionDisplayInfo4();
        }
        public static Double IGetDimensionDisplayInfo4(IViewObject IViewinstance, Int32 ArraySize)
        {
            return IViewinstance.IViewInstance.IGetDimensionDisplayInfo4(ArraySize);
        }
        //public static ICenterlineObject GetFirstCenterLine(IViewObject IViewinstance)
        //{
        //    return new ICenterlineObject(IViewinstance.IViewInstance.GetFirstCenterLine());
        //}
        public static IDisplayDimensionObject GetFirstDisplayDimension4(IViewObject IViewinstance)
        {
            return new IDisplayDimensionObject(IViewinstance.IViewInstance.GetFirstDisplayDimension4());
        }
        public static ITableAnnotationObject GetFirstTableAnnotation(IViewObject IViewinstance)
        {
            return new ITableAnnotationObject(IViewinstance.IViewInstance.GetFirstTableAnnotation());
        }
        public static IHoleTableAnnotationObject InsertHoleTable(IViewObject IViewinstance, Boolean UseAnchorPoint, Double X, Double Y, Int32 AnchorType, String TableTemplate)
        {
            return new IHoleTableAnnotationObject(IViewinstance.IViewInstance.InsertHoleTable(UseAnchorPoint, X, Y, AnchorType, TableTemplate));
        }
        public static IBomTableAnnotationObject InsertBomTable2(IViewObject IViewinstance, Boolean UseAnchorPoint, Double X, Double Y, Int32 AnchorType, Int32 BomType, String Configuration, String TableTemplate)
        {
            return new IBomTableAnnotationObject(IViewinstance.IViewInstance.InsertBomTable2(UseAnchorPoint, X, Y, AnchorType, BomType, Configuration, TableTemplate));
        }
        public static IDatumOriginObject GetFirstDatumOrigin(IViewObject IViewinstance)
        {
            return new IDatumOriginObject(IViewinstance.IViewInstance.GetFirstDatumOrigin());
        }
        public static Boolean GetUseParentDisplayMode(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetUseParentDisplayMode();
        }
        public static Boolean SetDisplayMode3(IViewObject IViewinstance, Boolean UseParent, Int32 Mode, Boolean Facetted, Boolean Edges)
        {
            return IViewinstance.IViewInstance.SetDisplayMode3(UseParent, Mode, Facetted, Edges);
        }
        //public static Boolean AlignWithView(IViewObject IViewinstance, Int32 AlignType, ViewObject BaseView)
        //{
        //    return IViewinstance.IViewInstance.AlignWithView(AlignType, BaseView);
        //}
        public static Int32 Crop(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.Crop();
        }
        public static Boolean IsPerspectiveView(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IsPerspectiveView();
        }
        public static Int32 GetAnnotationCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetAnnotationCount();
        }
        public static Object GetAnnotations(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetAnnotations();
        }
        public static IAnnotationObject IGetAnnotations(IViewObject IViewinstance, Int32 NumAnnotations)
        {
            return new IAnnotationObject(IViewinstance.IViewInstance.IGetAnnotations(NumAnnotations));
        }
        public static Int32 GetDimensionCount4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionCount4();
        }
        public static Int32 GetDimensionDisplayInfoSize2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionDisplayInfoSize2();
        }
        public static Object GetDimensionDisplayInfo5(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionDisplayInfo5();
        }
        public static Double IGetDimensionDisplayInfo5(IViewObject IViewinstance, Int32 ArraySize)
        {
            return IViewinstance.IViewInstance.IGetDimensionDisplayInfo5(ArraySize);
        }
        public static Object GetDimensionDisplayString4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionDisplayString4();
        }
        public static String IGetDimensionDisplayString4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionDisplayString4();
        }
        public static Object GetDimensionIds4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionIds4();
        }
        public static String IGetDimensionIds4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionIds4();
        }
        public static Object GetDimensionInfo6(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionInfo6();
        }
        public static Double IGetDimensionInfo6(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionInfo6();
        }
        public static Object GetDimensionString4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionString4();
        }
        public static String IGetDimensionString4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionString4();
        }
        public static IDisplayDimensionObject GetFirstDisplayDimension5(IViewObject IViewinstance)
        {
            return new IDisplayDimensionObject(IViewinstance.IViewInstance.GetFirstDisplayDimension5());
        }
        public static IAnnotationObject GetFirstAnnotation3(IViewObject IViewinstance)
        {
            return new IAnnotationObject(IViewinstance.IViewInstance.GetFirstAnnotation3());
        }
        public static Boolean IsLightweight(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IsLightweight();
        }
        public static void SetResolvedToLightweight(IViewObject IViewinstance)
        {
            IViewinstance.IViewInstance.SetResolvedToLightweight();
        }
        public static void SetLightweightToResolved(IViewObject IViewinstance)
        {
            IViewinstance.IViewInstance.SetLightweightToResolved();
        }
        public static IWeldBeadObject GetFirstWeldBead(IViewObject IViewinstance)
        {
            return new IWeldBeadObject(IViewinstance.IViewInstance.GetFirstWeldBead());
        }
        public static String GetName2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetName2();
        }
        public static Boolean SetName2(IViewObject IViewinstance, String Name)
        {
            return IViewinstance.IViewInstance.SetName2(Name);
        }
        public static Int32 GetHiddenEdgeCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetHiddenEdgeCount();
        }
        public static IEdgeObject IGetHiddenEdges(IViewObject IViewinstance, Int32 HiddenEdgeCount)
        {
            return new IEdgeObject(IViewinstance.IViewInstance.IGetHiddenEdges(HiddenEdgeCount));
        }
        //public static void ISetHiddenEdges(IViewObject IViewinstance, Int32 HiddenEdgeCount, Edge&Object EdgeList)
        //{
        //    return IViewinstance.IViewInstance.ISetHiddenEdges(HiddenEdgeCount, EdgeList);
        //}
        public static Int32 GetVisibleComponentCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetVisibleComponentCount();
        }
        public static Object GetVisibleComponents(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetVisibleComponents();
        }
        public static IComponent2Object IGetVisibleComponents(IViewObject IViewinstance, Int32 ViewComponentCount)
        {
            return new IComponent2Object(IViewinstance.IViewInstance.IGetVisibleComponents(ViewComponentCount));
        }
        //public static Int32 GetVisibleEntityCount(IViewObject IViewinstance, Component2Object LpViewComponent, Int32 EntityType)
        //{
        //    return IViewinstance.IViewInstance.GetVisibleEntityCount(LpViewComponent, EntityType);
        //}
        //public static Object GetVisibleEntities(IViewObject IViewinstance, Component2Object LpViewComponent, Int32 EntityType)
        //{
        //    return IViewinstance.IViewInstance.GetVisibleEntities(LpViewComponent, EntityType);
        //}
        //public static IEntityObject IGetVisibleEntities(IViewObject IViewinstance, Component2Object LpViewComponent, Int32 EntityType, Int32 ViewEntityCount)
        //{
        //    return new IEntityObject(IViewinstance.IViewInstance.IGetVisibleEntities(LpViewComponent, EntityType, ViewEntityCount));
        //}
        public static Object GetPolyLinesAndCurves(IViewObject IViewinstance, Int16 CrossHatchOption)
        {
            return IViewinstance.IViewInstance.GetPolyLinesAndCurves(CrossHatchOption);
        }
        public static Double IGetPolyLinesAndCurves(IViewObject IViewinstance, Int16 CrossHatchOption, Int32 ArraySize)
        {
            return IViewinstance.IViewInstance.IGetPolyLinesAndCurves(CrossHatchOption, ArraySize);
        }
        //public static Int32 GetPolyLinesAndCurvesCount(IViewObject IViewinstance, Int16 CrossHatchOption, Int32& PointCount)
        //{
        //    return IViewinstance.IViewInstance.GetPolyLinesAndCurvesCount(CrossHatchOption, PointCount);
        //}
        public static Int32 GetDependentViewCount(IViewObject IViewinstance, Boolean AllViews, Int32 SpecificViewType)
        {
            return IViewinstance.IViewInstance.GetDependentViewCount(AllViews, SpecificViewType);
        }
        public static Object GetDependentViews(IViewObject IViewinstance, Boolean AllViews, Int32 SpecificViewType)
        {
            return IViewinstance.IViewInstance.GetDependentViews(AllViews, SpecificViewType);
        }
        public static IViewObject IGetDependentViews(IViewObject IViewinstance, Boolean AllViews, Int32 SpecificViewType, Int32 DependentViewCount)
        {
            return new IViewObject(IViewinstance.IViewInstance.IGetDependentViews(AllViews, SpecificViewType, DependentViewCount));
        }
        public static Boolean GetKeepLinkedToBOM(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetKeepLinkedToBOM();
        }
        public static String GetKeepLinkedToBOMName(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetKeepLinkedToBOMName();
        }
        public static Boolean SetKeepLinkedToBOM(IViewObject IViewinstance, Boolean Linked, String Name)
        {
            return IViewinstance.IViewInstance.SetKeepLinkedToBOM(Linked, Name);
        }
        //public static Object GetPolylines6(IViewObject IViewinstance, Int16 CrossHatchOption, Object& Polylines)
        //{
        //    return IViewinstance.IViewInstance.GetPolylines6(CrossHatchOption, Polylines);
        //}
        //public static IEdgeObject IGetPolylines6(IViewObject IViewinstance, Int16 CrossHatchOption, Int32 ArraySize, Double& Polylines, Int32 EdgeArraySize)
        //{
        //    return new IEdgeObject(IViewinstance.IViewInstance.IGetPolylines6(CrossHatchOption, ArraySize, Polylines, EdgeArraySize));
        //}
        public static IWeldmentCutListAnnotationObject InsertWeldmentTable(IViewObject IViewinstance, Boolean UseAnchorPoint, Double X, Double Y, Int32 AnchorType, String Configuration, String TableTemplate)
        {
            return new IWeldmentCutListAnnotationObject(IViewinstance.IViewInstance.InsertWeldmentTable(UseAnchorPoint, X, Y, AnchorType, Configuration, TableTemplate));
        }
        public static IViewObject InsertAlternateView(IViewObject IViewinstance, String ConfigurationName)
        {
            return new IViewObject(IViewinstance.IViewInstance.InsertAlternateView(ConfigurationName));
        }
        public static Int32 GetTemporaryAxesCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetTemporaryAxesCount();
        }
        public static Object GetTemporaryAxes(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetTemporaryAxes();
        }
        public static Double IGetTemporaryAxes(IViewObject IViewinstance, Int32 TempAxesCount)
        {
            return IViewinstance.IViewInstance.IGetTemporaryAxes(TempAxesCount);
        }
        public static Int32 GetProjectionLineCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetProjectionLineCount();
        }
        public static Object GetDimensionIds2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionIds2();
        }
        public static String IGetDimensionIds2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionIds2();
        }
        public static Object GetDimensionDisplayInfo2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionDisplayInfo2();
        }
        public static Double IGetDimensionDisplayInfo2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionDisplayInfo2();
        }
        public static Object GetDimensionDisplayString2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionDisplayString2();
        }
        public static String IGetDimensionDisplayString2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionDisplayString2();
        }
        public static Object GetFirstDisplayDimension2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstDisplayDimension2();
        }
        public static IDisplayDimensionObject IGetFirstDisplayDimension2(IViewObject IViewinstance)
        {
            return new IDisplayDimensionObject(IViewinstance.IViewInstance.IGetFirstDisplayDimension2());
        }
        public static Object GetPolylines4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetPolylines4();
        }
        public static Double IGetPolylines4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetPolylines4();
        }
        //public static Int32 GetPolyLineCount4(IViewObject IViewinstance, Int32& PointCount)
        //{
        //    return IViewinstance.IViewInstance.GetPolyLineCount4(PointCount);
        //}
        public static Boolean IsModelLoaded(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IsModelLoaded();
        }
        public static Int32 LoadModel(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.LoadModel();
        }
        public static Int32 GetDisplayTangentEdges2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDisplayTangentEdges2();
        }
        public static void SetDisplayTangentEdges2(IViewObject IViewinstance, Int32 DisplayIn)
        {
            IViewinstance.IViewInstance.SetDisplayTangentEdges2(DisplayIn);
        }
        public static Object GetSectionLines(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSectionLines();
        }
        public static IDrSectionObject IGetSectionLines(IViewObject IViewinstance)
        {
            return new IDrSectionObject(IViewinstance.IViewInstance.IGetSectionLines());
        }
        public static Object GetSection(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSection();
        }
        public static IDrSectionObject IGetSection(IViewObject IViewinstance)
        {
            return new IDrSectionObject(IViewinstance.IViewInstance.IGetSection());
        }
        public static Object GetHiddenComponents(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetHiddenComponents();
        }
        //public static IEnumComponentsObject EnumHiddenComponents(IViewObject IViewinstance)
        //{
        //    return new IEnumComponentsObject(IViewinstance.IViewInstance.EnumHiddenComponents());
        //}
        //public static IEnumDrSectionsObject EnumSectionLines(IViewObject IViewinstance)
        //{
        //    return new IEnumDrSectionsObject(IViewinstance.IViewInstance.EnumSectionLines());
        //}
        public static Object GetDisplayData3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDisplayData3();
        }
        public static IDisplayDataObject IGetDisplayData3(IViewObject IViewinstance)
        {
            return new IDisplayDataObject(IViewinstance.IViewInstance.IGetDisplayData3());
        }
        public static Int32 GetDimensionCount3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionCount3();
        }
        public static Object GetDimensionInfo5(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionInfo5();
        }
        public static Double IGetDimensionInfo5(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionInfo5();
        }
        public static Object GetDimensionString3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionString3();
        }
        public static String IGetDimensionString3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionString3();
        }
        public static Object GetDimensionIds3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionIds3();
        }
        public static String IGetDimensionIds3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionIds3();
        }
        public static Object GetDimensionDisplayInfo3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionDisplayInfo3();
        }
        public static Double IGetDimensionDisplayInfo3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionDisplayInfo3();
        }
        public static Object GetDimensionDisplayString3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionDisplayString3();
        }
        public static String IGetDimensionDisplayString3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionDisplayString3();
        }
        public static Object GetFirstDisplayDimension3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstDisplayDimension3();
        }
        public static IDisplayDimensionObject IGetFirstDisplayDimension3(IViewObject IViewinstance)
        {
            return new IDisplayDimensionObject(IViewinstance.IViewInstance.IGetFirstDisplayDimension3());
        }
        public static Boolean IsCropped(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IsCropped();
        }
        public static Object GetDetailCircles(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDetailCircles();
        }
        public static IDetailCircleObject IGetDetailCircles(IViewObject IViewinstance, Int32 NumDetailCircles)
        {
            return new IDetailCircleObject(IViewinstance.IViewInstance.IGetDetailCircles(NumDetailCircles));
        }
        public static Object GetProjectionArrow(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetProjectionArrow();
        }
        public static IProjectionArrowObject IGetProjectionArrow(IViewObject IViewinstance)
        {
            return new IProjectionArrowObject(IViewinstance.IViewInstance.IGetProjectionArrow());
        }
        public static Object GetDetail(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDetail();
        }
        public static IDetailCircleObject IGetDetail(IViewObject IViewinstance)
        {
            return new IDetailCircleObject(IViewinstance.IViewInstance.IGetDetail());
        }
        public static Object GetBaseView(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetBaseView();
        }
        public static IViewObject IGetBaseView(IViewObject IViewinstance)
        {
            return new IViewObject(IViewinstance.IViewInstance.IGetBaseView());
        }
        //public static IEnumComponents2Object EnumHiddenComponents2(IViewObject IViewinstance)
        //{
        //    return new IEnumComponents2Object(IViewinstance.IViewInstance.EnumHiddenComponents2());
        //}
        public static Object GetFirstMultiJogLeader(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstMultiJogLeader();
        }
        public static IMultiJogLeaderObject IGetFirstMultiJogLeader(IViewObject IViewinstance)
        {
            return new IMultiJogLeaderObject(IViewinstance.IViewInstance.IGetFirstMultiJogLeader());
        }
        public static Boolean GetVisible(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetVisible();
        }
        public static void SetVisible(IViewObject IViewinstance, Boolean Visible, Boolean DependentsToo)
        {
            IViewinstance.IViewInstance.SetVisible(Visible, DependentsToo);
        }
        public static Object GetFirstDowelSymbol(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstDowelSymbol();
        }
        public static IDowelSymbolObject IGetFirstDowelSymbol(IViewObject IViewinstance)
        {
            return new IDowelSymbolObject(IViewinstance.IViewInstance.IGetFirstDowelSymbol());
        }
        //public static Object InsertBomTable(IViewObject IViewinstance, String Template, Double Xloc, Double Yloc, Int32& Errors)
        //{
        //    return IViewinstance.IViewInstance.InsertBomTable(Template, Xloc, Yloc, Errors);
        //}
        //public static IBomTableObject IInsertBomTable(IViewObject IViewinstance, String Template, Double Xloc, Double Yloc, Int32& Errors)
        //{
        //    return new IBomTableObject(IViewinstance.IViewInstance.IInsertBomTable(Template, Xloc, Yloc, Errors));
        //}
        public static Boolean SelectEntity(IViewObject IViewinstance, Object Entity, Boolean AppendFlag)
        {
            return IViewinstance.IViewInstance.SelectEntity(Entity, AppendFlag);
        }
        //public static Boolean ISelectEntity(IViewObject IViewinstance, EntityObject Entity, Boolean AppendFlag)
        //{
        //    return IViewinstance.IViewInstance.ISelectEntity(Entity, AppendFlag);
        //}
        public static Boolean IsModelOutOfDate(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IsModelOutOfDate();
        }
        public static Int32 GetDisplayMode2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDisplayMode2();
        }
        public static Boolean GetFacettedHlrDisplay(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFacettedHlrDisplay();
        }
        public static Boolean GetDisplayEdgesInShadedMode(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDisplayEdgesInShadedMode();
        }
        public static Boolean SetDisplayMode2(IViewObject IViewinstance, Int32 Mode, Boolean Facetted, Boolean Edges)
        {
            return IViewinstance.IViewInstance.SetDisplayMode2(Mode, Facetted, Edges);
        }
        public static Object GetPolylines5(IViewObject IViewinstance, Int16 CrossHatchOption)
        {
            return IViewinstance.IViewInstance.GetPolylines5(CrossHatchOption);
        }
        public static Double IGetPolylines5(IViewObject IViewinstance, Int16 CrossHatchOption, Int32 ArraySize)
        {
            return IViewinstance.IViewInstance.IGetPolylines5(CrossHatchOption, ArraySize);
        }
        //public static Int32 GetPolyLineCount5(IViewObject IViewinstance, Int16 CrossHatchOption, Int32& PointCount)
        //{
        //    return IViewinstance.IViewInstance.GetPolyLineCount5(CrossHatchOption, PointCount);
        //}
        public static Int32 GetLineCount2(IViewObject IViewinstance, Int16 CrossHatchOption)
        {
            return IViewinstance.IViewInstance.GetLineCount2(CrossHatchOption);
        }
        public static Object GetLines4(IViewObject IViewinstance, Int16 CrossHatchOption)
        {
            return IViewinstance.IViewInstance.GetLines4(CrossHatchOption);
        }
        public static Double IGetLines4(IViewObject IViewinstance, Int16 CrossHatchOption, Int32 ArraySize)
        {
            return IViewinstance.IViewInstance.IGetLines4(CrossHatchOption, ArraySize);
        }
        public static IBlockInstanceObject GetFirstBlockInstance(IViewObject IViewinstance)
        {
            return new IBlockInstanceObject(IViewinstance.IViewInstance.GetFirstBlockInstance());
        }
        //public static Int32 GetSectionLineCount2(IViewObject IViewinstance, Int32& Size)
        //{
        //    return IViewinstance.IViewInstance.GetSectionLineCount2(Size);
        //}
        public static Object GetSectionLineInfo2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSectionLineInfo2();
        }
        public static Double IGetSectionLineInfo2(IViewObject IViewinstance, Int32 ArraySize)
        {
            return IViewinstance.IViewInstance.IGetSectionLineInfo2(ArraySize);
        }
        //public static Int32 GetDetailCircleCount2(IViewObject IViewinstance, Int32& Size)
        //{
        //    return IViewinstance.IViewInstance.GetDetailCircleCount2(Size);
        //}
        public static Object GetDetailCircleInfo2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDetailCircleInfo2();
        }
        public static Double IGetDetailCircleInfo2(IViewObject IViewinstance, Int32 ArraySize)
        {
            return IViewinstance.IViewInstance.IGetDetailCircleInfo2(ArraySize);
        }
        public static Boolean IsBroken(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IsBroken();
        }
        //public static Int32 GetBreakLineCount(IViewObject IViewinstance, Int32& Size)
        //{
        //    return IViewinstance.IViewInstance.GetBreakLineCount(Size);
        //}
        public static Object GetBreakLines(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetBreakLines();
        }
        public static IBreakLineObject IGetBreakLines(IViewObject IViewinstance, Int32 Count)
        {
            return new IBreakLineObject(IViewinstance.IViewInstance.IGetBreakLines(Count));
        }
        public static IBreakLineObject InsertBreak(IViewObject IViewinstance, Int32 Orientation, Double Position1, Double Position2, Int32 Style)
        {
            return new IBreakLineObject(IViewinstance.IViewInstance.InsertBreak(Orientation, Position1, Position2, Style));
        }
        public static Object GetBreakLineInfo(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetBreakLineInfo();
        }
        public static Boolean ShowExploded(IViewObject IViewinstance, Boolean ShowIt)
        {
            return IViewinstance.IViewInstance.ShowExploded(ShowIt);
        }
        public static Boolean IsExploded(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IsExploded();
        }
        public static Object GetFirstCThread(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstCThread();
        }
        public static ICThreadObject IGetFirstCThread(IViewObject IViewinstance)
        {
            return new ICThreadObject(IViewinstance.IViewInstance.IGetFirstCThread());
        }
        public static Boolean CreateViewArrow(IViewObject IViewinstance, String DrawingViewNameIn, String ArrowNameIn)
        {
            return IViewinstance.IViewInstance.CreateViewArrow(DrawingViewNameIn, ArrowNameIn);
        }
        public static void ModifyViewArrow(IViewObject IViewinstance, String DrawingViewNameIn, String ArrowNameIn)
        {
            IViewinstance.IViewInstance.ModifyViewArrow(DrawingViewNameIn, ArrowNameIn);
        }
        public static void MoveViewArrow(IViewObject IViewinstance, String DrawingViewNameIn, Double Dx, Double Dy, Double Dz)
        {
            IViewinstance.IViewInstance.MoveViewArrow(DrawingViewNameIn, Dx, Dy, Dz);
        }
        public static Object GetPolylines3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetPolylines3();
        }
        public static Double IGetPolylines3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetPolylines3();
        }
        //public static Int32 GetPolyLineCount3(IViewObject IViewinstance, Int32& PointCount)
        //{
        //    return IViewinstance.IViewInstance.GetPolyLineCount3(PointCount);
        //}
        public static Object GetFirstDisplayDimension(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstDisplayDimension();
        }
        public static IDisplayDimensionObject IGetFirstDisplayDimension(IViewObject IViewinstance)
        {
            return new IDisplayDimensionObject(IViewinstance.IViewInstance.IGetFirstDisplayDimension());
        }
        public static Object GetSketch(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSketch();
        }
        public static ISketchObject IGetSketch(IViewObject IViewinstance)
        {
            return new ISketchObject(IViewinstance.IViewInstance.IGetSketch());
        }
        public static Object GetLines2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetLines2();
        }
        public static Double IGetLines2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetLines2();
        }
        public static Object GetSplines2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSplines2();
        }
        public static Double IGetSplines2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetSplines2();
        }
        public static Object GetArcs3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetArcs3();
        }
        public static Double IGetArcs3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetArcs3();
        }
        public static Object GetEllipses3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetEllipses3();
        }
        public static Double IGetEllipses3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetEllipses3();
        }
        public static Object GetBomTable(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetBomTable();
        }
        public static IBomTableObject IGetBomTable(IViewObject IViewinstance)
        {
            return new IBomTableObject(IViewinstance.IViewInstance.IGetBomTable());
        }
        public static Boolean SetXform(IViewObject IViewinstance, Object Transform)
        {
            return IViewinstance.IViewInstance.SetXform(Transform);
        }
        //public static Boolean ISetXform(IViewObject IViewinstance, Double& Transform)
        //{
        //    return IViewinstance.IViewInstance.ISetXform(Transform);
        //}
        public static Int32 GetAlignment(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetAlignment();
        }
        public static String GetReferencedModelName(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetReferencedModelName();
        }
        public static Object GetFirstAnnotation(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstAnnotation();
        }
        public static IAnnotationObject IGetFirstAnnotation(IViewObject IViewinstance)
        {
            return new IAnnotationObject(IViewinstance.IViewInstance.IGetFirstAnnotation());
        }
        public static Object GetFirstCustomSymbol(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstCustomSymbol();
        }
        public static ICustomSymbolObject IGetFirstCustomSymbol(IViewObject IViewinstance)
        {
            return new ICustomSymbolObject(IViewinstance.IViewInstance.IGetFirstCustomSymbol());
        }
        public static Object GetDimensionInfo2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionInfo2();
        }
        public static Double IGetDimensionInfo2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionInfo2();
        }
        public static Object GetParabolas(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetParabolas();
        }
        public static Double IGetParabolas(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetParabolas();
        }
        public static Int32 GetParabolaCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetParabolaCount();
        }
        public static Object GetEllipses4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetEllipses4();
        }
        public static Double IGetEllipses4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetEllipses4();
        }
        public static Object GetLines3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetLines3();
        }
        public static Double IGetLines3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetLines3();
        }
        public static Object GetArcs4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetArcs4();
        }
        public static Double IGetArcs4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetArcs4();
        }
        public static Object GetSplines3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSplines3();
        }
        public static Double IGetSplines3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetSplines3();
        }
        public static Object GetEllipses5(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetEllipses5();
        }
        public static Double IGetEllipses5(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetEllipses5();
        }
        public static Object GetParabolas2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetParabolas2();
        }
        public static Double IGetParabolas2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetParabolas2();
        }
        public static Object GetUserPoints2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetUserPoints2();
        }
        public static Double IGetUserPoints2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetUserPoints2();
        }
        public static Object GetDimensionInfo3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionInfo3();
        }
        public static Double IGetDimensionInfo3(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionInfo3();
        }
        public static Object GetDatumPoints2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDatumPoints2();
        }
        public static Double IGetDatumPoints2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDatumPoints2();
        }
        public static Boolean HasDesignTable(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.HasDesignTable();
        }
        public static Object GetDesignTableExtent(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDesignTableExtent();
        }
        public static Double IGetDesignTableExtent(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDesignTableExtent();
        }
        public static Object GetDisplayData2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDisplayData2();
        }
        public static IDisplayDataObject IGetDisplayData2(IViewObject IViewinstance)
        {
            return new IDisplayDataObject(IViewinstance.IViewInstance.IGetDisplayData2());
        }
        public static Object GetFirstAnnotation2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstAnnotation2();
        }
        public static IAnnotationObject IGetFirstAnnotation2(IViewObject IViewinstance)
        {
            return new IAnnotationObject(IViewinstance.IViewInstance.IGetFirstAnnotation2());
        }
        public static Int32 GetDimensionCount2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionCount2();
        }
        public static Object GetDimensionInfo4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionInfo4();
        }
        public static Double IGetDimensionInfo4(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionInfo4();
        }
        public static Object GetDimensionString2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionString2();
        }
        public static String IGetDimensionString2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionString2();
        }
        public static Object GetNextView(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetNextView();
        }
        public static IViewObject IGetNextView(IViewObject IViewinstance)
        {
            return new IViewObject(IViewinstance.IViewInstance.IGetNextView());
        }
        public static Object GetLines(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetLines();
        }
        public static Object GetOutline(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetOutline();
        }
        public static Object GetXform(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetXform();
        }
        public static Object GetArcs(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetArcs();
        }
        public static Object GetUserPoints(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetUserPoints();
        }
        public static Object GetPolylines(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetPolylines();
        }
        public static Object GetSplines(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSplines();
        }
        public static Object GetDimensionInfo(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionInfo();
        }
        public static Object GetDimensionString(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionString();
        }
        public static Object GetFirstNote(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstNote();
        }
        public static INoteObject IGetFirstNote(IViewObject IViewinstance)
        {
            return new INoteObject(IViewinstance.IViewInstance.IGetFirstNote());
        }
        public static Object GetFirstGTOL(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstGTOL();
        }
        public static IGtolObject IGetFirstGTOL(IViewObject IViewinstance)
        {
            return new IGtolObject(IViewinstance.IViewInstance.IGetFirstGTOL());
        }
        public static Double IGetLines(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetLines();
        }
        public static Double IGetOutline(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetOutline();
        }
        public static Double IGetXform(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetXform();
        }
        public static Double IGetArcs(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetArcs();
        }
        public static Double IGetUserPoints(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetUserPoints();
        }
        public static Double IGetPolylines(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetPolylines();
        }
        public static Double IGetSplines(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetSplines();
        }
        public static Double IGetDimensionInfo(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionInfo();
        }
        public static String IGetDimensionString(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionString();
        }
        public static Int32 GetLineCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetLineCount();
        }
        public static Int32 GetArcCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetArcCount();
        }
        public static Int32 GetUserPointsCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetUserPointsCount();
        }
        //public static Int32 GetPolyLineCount(IViewObject IViewinstance, Int32& PointCount)
        //{
        //    return IViewinstance.IViewInstance.GetPolyLineCount(PointCount);
        //}
        //public static Int32 GetSplineCount(IViewObject IViewinstance, Int32& PointCount)
        //{
        //    return IViewinstance.IViewInstance.GetSplineCount(PointCount);
        //}
        public static Int32 GetDimensionCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionCount();
        }
        public static Object GetEllipses(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetEllipses();
        }
        public static Double IGetEllipses(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetEllipses();
        }
        public static Int32 GetEllipseCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetEllipseCount();
        }
        public static Int32 GetDisplayMode(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDisplayMode();
        }
        public static void SetDisplayMode(IViewObject IViewinstance, Int32 DisplayIn)
        {
            IViewinstance.IViewInstance.SetDisplayMode(DisplayIn);
        }
        public static Boolean GetDisplayTangentEdges(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDisplayTangentEdges();
        }
        public static void SetDisplayTangentEdges(IViewObject IViewinstance, Boolean DisplayIn)
        {
            IViewinstance.IViewInstance.SetDisplayTangentEdges(DisplayIn);
        }
        public static Int32 GetCenterMarkCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetCenterMarkCount();
        }
        public static Object GetCenterMarkInfo(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetCenterMarkInfo();
        }
        public static Double IGetCenterMarkInfo(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetCenterMarkInfo();
        }
        //public static Int32 GetSectionLineCount(IViewObject IViewinstance, Int32& Size)
        //{
        //    return IViewinstance.IViewInstance.GetSectionLineCount(Size);
        //}
        public static Object GetSectionLineInfo(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSectionLineInfo();
        }
        public static Object GetSectionLineStrings(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetSectionLineStrings();
        }
        public static Double IGetSectionLineInfo(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetSectionLineInfo();
        }
        public static String IGetSectionLineStrings(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetSectionLineStrings();
        }
        public static void UpdateViewDisplayGeometry(IViewObject IViewinstance)
        {
            IViewinstance.IViewInstance.UpdateViewDisplayGeometry();
        }
        public static Int32 GetDetailCircleCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDetailCircleCount();
        }
        public static Object GetDetailCircleInfo(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDetailCircleInfo();
        }
        public static Double IGetDetailCircleInfo(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDetailCircleInfo();
        }
        public static Object GetDetailCircleStrings(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDetailCircleStrings();
        }
        public static String IGetDetailCircleStrings(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDetailCircleStrings();
        }
        public static Object GetDimensionIds(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionIds();
        }
        public static String IGetDimensionIds(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionIds();
        }
        public static Object GetDimensionDisplayInfo(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionDisplayInfo();
        }
        public static Double IGetDimensionDisplayInfo(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionDisplayInfo();
        }
        public static Object GetDimensionDisplayString(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDimensionDisplayString();
        }
        public static String IGetDimensionDisplayString(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDimensionDisplayString();
        }
        public static Object GetArcs2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetArcs2();
        }
        public static Double IGetArcs2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetArcs2();
        }
        public static Object GetEllipses2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetEllipses2();
        }
        public static Double IGetEllipses2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetEllipses2();
        }
        public static Object GetViewXform(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetViewXform();
        }
        public static Double IGetViewXform(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetViewXform();
        }
        public static Object GetFirstSFSymbol(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstSFSymbol();
        }
        public static ISFSymbolObject IGetFirstSFSymbol(IViewObject IViewinstance)
        {
            return new ISFSymbolObject(IViewinstance.IViewInstance.IGetFirstSFSymbol());
        }
        public static Object GetFirstDatumTag(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstDatumTag();
        }
        public static IDatumTagObject IGetFirstDatumTag(IViewObject IViewinstance)
        {
            return new IDatumTagObject(IViewinstance.IViewInstance.IGetFirstDatumTag());
        }
        public static Object GetFirstDatumTargetSym(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstDatumTargetSym();
        }
        public static IDatumTargetSymObject IGetFirstDatumTargetSym(IViewObject IViewinstance)
        {
            return new IDatumTargetSymObject(IViewinstance.IViewInstance.IGetFirstDatumTargetSym());
        }
        public static Object GetFirstWeldSymbol(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetFirstWeldSymbol();
        }
        public static IWeldSymbolObject IGetFirstWeldSymbol(IViewObject IViewinstance)
        {
            return new IWeldSymbolObject(IViewinstance.IViewInstance.IGetFirstWeldSymbol());
        }
        public static Int32 GetDatumPointsCount(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDatumPointsCount();
        }
        public static Object GetDatumPoints(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDatumPoints();
        }
        public static Double IGetDatumPoints(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetDatumPoints();
        }
        public static void UseDefaultAlignment(IViewObject IViewinstance)
        {
            IViewinstance.IViewInstance.UseDefaultAlignment();
        }
        public static void RemoveAlignment(IViewObject IViewinstance)
        {
            IViewinstance.IViewInstance.RemoveAlignment();
        }
        public static void AlignVerticalTo(IViewObject IViewinstance, String ViewNameIn)
        {
            IViewinstance.IViewInstance.AlignVerticalTo(ViewNameIn);
        }
        public static void AlignHorizontalTo(IViewObject IViewinstance, String ViewNameIn)
        {
            IViewinstance.IViewInstance.AlignHorizontalTo(ViewNameIn);
        }
        public static Object GetDisplayData(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetDisplayData();
        }
        public static IDisplayDataObject IGetDisplayData(IViewObject IViewinstance)
        {
            return new IDisplayDataObject(IViewinstance.IViewInstance.IGetDisplayData());
        }
        //public static Int32 GetPolyLineCount2(IViewObject IViewinstance, Int32& PointCount)
        //{
        //    return IViewinstance.IViewInstance.GetPolyLineCount2(PointCount);
        //}
        public static Object GetPolylines2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.GetPolylines2();
        }
        public static Double IGetPolylines2(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.IGetPolylines2();
        }
        public static Int32 SuppressState(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.SuppressState;
        }
        public static String ReferencedConfiguration(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.ReferencedConfiguration;
        }
        public static Int32 UseSheetScale(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.UseSheetScale;
        }
        public static Double ScaleDecimal(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.ScaleDecimal;
        }
        public static Object ScaleRatio(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.ScaleRatio;
        }
        public static object IScaleRatio(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.ScaleRatio;
        }
        public static Object Position(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.Position;
        }
        public static object IPosition(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.Position;
        }
        public static String Name(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.Name;
        }
        public static Int32 Type(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.Type;
        }
        public static Boolean ProjectedDimensions(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.ProjectedDimensions;
        }
        public static Double Angle(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.Angle;
        }
        public static IMathTransformObject ModelToViewTransform(IViewObject IViewinstance)
        {
            return new IMathTransformObject(IViewinstance.IViewInstance.ModelToViewTransform);
        }
        public static IDrawingComponentObject RootDrawingComponent(IViewObject IViewinstance)
        {
            return new IDrawingComponentObject(IViewinstance.IViewInstance.RootDrawingComponent);
        }
        public static IModelDoc2Object ReferencedDocument(IViewObject IViewinstance)
        {
            return new IModelDoc2Object(IViewinstance.IViewInstance.ReferencedDocument);
        }
        public static Boolean UseParentScale(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.UseParentScale;
        }
        public static Boolean FocusLocked(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.FocusLocked;
        }
        public static Object HiddenEdges(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.HiddenEdges;
        }
        public static Boolean ShowSheetMetalBendNotes(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.ShowSheetMetalBendNotes;
        }
        public static ISheetObject Sheet(IViewObject IViewinstance)
        {
            return new ISheetObject(IViewinstance.IViewInstance.Sheet);
        }
        public static Double BreakLineGap(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.BreakLineGap;
        }
        public static Boolean FlipView(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.FlipView;
        }
        public static Object Bodies(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.Bodies;
        }
        public static Boolean LinkParentConfiguration(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.LinkParentConfiguration;
        }
        public static Boolean PositionLocked(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.PositionLocked;
        }
        public static String DisplayState(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.DisplayState;
        }
        public static Int32 ReferencedConfigurationID(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.ReferencedConfigurationID;
        }
        public static Boolean ScaleHatchPattern(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.ScaleHatchPattern;
        }
        public static Boolean EmphasizeOutline(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.EmphasizeOutline;
        }
        public static Boolean CropViewJaggedOutline(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.CropViewJaggedOutline;
        }
        public static Boolean CropViewNoOutline(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.CropViewNoOutline;
        }
        public static Int32 CropViewJaggedShapeIntensity(IViewObject IViewinstance)
        {
            return IViewinstance.IViewInstance.CropViewJaggedShapeIntensity;
        }
    }
}