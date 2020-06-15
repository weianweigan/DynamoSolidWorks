using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDrawingDocObject
    {
        public IDrawingDoc IDrawingDocInstance { get; set; }
        public IDrawingDocObject(IDrawingDoc IDrawingDocinstance)
        {
            IDrawingDocInstance = IDrawingDocinstance;
        }
    }
    public static class IDrawingDocInterface
    {
        public static Boolean LoadLineStyles(IDrawingDocObject IDrawingDocinstance, String StyleFiles, Object StyleNameList, Boolean ReplaceExisting)
        {
            return IDrawingDocinstance.IDrawingDocInstance.LoadLineStyles(StyleFiles, StyleNameList, ReplaceExisting);
        }
        public static Boolean DeleteLineStyle(IDrawingDocObject IDrawingDocinstance, String StyleName, String ReplaceName)
        {
            return IDrawingDocinstance.IDrawingDocInstance.DeleteLineStyle(StyleName, ReplaceName);
        }
        public static Boolean AddLineStyle(IDrawingDocObject IDrawingDocinstance, String StyleName, String StyleDefinition)
        {
            return IDrawingDocinstance.IDrawingDocInstance.AddLineStyle(StyleName, StyleDefinition);
        }
        public static Boolean PasteSheet(IDrawingDocObject IDrawingDocinstance, Int32 InsertOption, Int32 RenameOption)
        {
            return IDrawingDocinstance.IDrawingDocInstance.PasteSheet(InsertOption, RenameOption);
        }
        public static Boolean InsertLinearNotePattern(IDrawingDocObject IDrawingDocinstance, Int32 NumX, Int32 NumY, Double SpacingX, Double SpacingY, Double AngleX, Double AngleY, String DeleteInstances)
        {
            return IDrawingDocinstance.IDrawingDocInstance.InsertLinearNotePattern(NumX, NumY, SpacingX, SpacingY, AngleX, AngleY, DeleteInstances);
        }
        public static Boolean InsertCircularNotePattern(IDrawingDocObject IDrawingDocinstance, Double ArcRadius, Double ArcAngle, Int32 PatternNum, Double PatternSpacing, Boolean PatternRotate, String DeleteInstances)
        {
            return IDrawingDocinstance.IDrawingDocInstance.InsertCircularNotePattern(ArcRadius, ArcAngle, PatternNum, PatternSpacing, PatternRotate, DeleteInstances);
        }
        public static IAutoBalloonOptionsObject CreateAutoBalloonOptions(IDrawingDocObject IDrawingDocinstance)
        {
            return new IAutoBalloonOptionsObject(IDrawingDocinstance.IDrawingDocInstance.CreateAutoBalloonOptions());
        }
        //public static Object AutoBalloon5(IDrawingDocObject IDrawingDocinstance, AutoBalloonOptionsObject BalloonOptions)
        //{
        //    return IDrawingDocinstance.IDrawingDocInstance.AutoBalloon5(BalloonOptions);
        //}
        public static void IsolateChangedDimensions(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.IsolateChangedDimensions();
        }
        public static Object InsertRevisionCloud(IDrawingDocObject IDrawingDocinstance, Int32 CloudShape)
        {
            return IDrawingDocinstance.IDrawingDocInstance.InsertRevisionCloud(CloudShape);
        }
        public static IRevisionCloudObject IInsertRevisionCloud(IDrawingDocObject IDrawingDocinstance, Int32 CloudShape)
        {
            return new IRevisionCloudObject(IDrawingDocinstance.IDrawingDocInstance.IInsertRevisionCloud(CloudShape));
        }
        public static Boolean AttachAnnotation(IDrawingDocObject IDrawingDocinstance, Int32 Option)
        {
            return IDrawingDocinstance.IDrawingDocInstance.AttachAnnotation(Option);
        }
        public static Boolean ReplaceViewModel(IDrawingDocObject IDrawingDocinstance, String NewModelPathName, Object Views, Object Instances)
        {
            return IDrawingDocinstance.IDrawingDocInstance.ReplaceViewModel(NewModelPathName, Views, Instances);
        }
        public static void InsertAngularRunningDim(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertAngularRunningDim();
        }
        public static Boolean CreateLayer2(IDrawingDocObject IDrawingDocinstance, String Layername, String LayerDesc, Int32 LayerColor, Int32 LayerStyle, Int32 LayerWidth, Boolean BOn, Boolean BPrint)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateLayer2(Layername, LayerDesc, LayerColor, LayerStyle, LayerWidth, BOn, BPrint);
        }
        public static Boolean NewSheet4(IDrawingDocObject IDrawingDocinstance, String Name, Int32 PaperSize, Int32 TemplateIn, Double Scale1, Double Scale2, Boolean FirstAngle, String TemplateName, Double Width, Double Height, String PropertyViewName, Double ZoneLeftMargin, Double ZoneRightMargin, Double ZoneTopMargin, Double ZoneBottomMargin, Int32 ZoneRow, Int32 ZoneCol)
        {
            return IDrawingDocinstance.IDrawingDocInstance.NewSheet4(Name, PaperSize, TemplateIn, Scale1, Scale2, FirstAngle, TemplateName, Width, Height, PropertyViewName, ZoneLeftMargin, ZoneRightMargin, ZoneTopMargin, ZoneBottomMargin, ZoneRow, ZoneCol);
        }
        public static Boolean SetupSheet6(IDrawingDocObject IDrawingDocinstance, String Name, Int32 PaperSize, Int32 TemplateIn, Double Scale1, Double Scale2, Boolean FirstAngle, String TemplateName, Double Width, Double Height, String PropertyViewName, Boolean RemoveModifiedNotes, Double ZoneLeftMargin, Double ZoneRightMargin, Double ZoneTopMargin, Double ZoneBottomMargin, Int32 ZoneRow, Int32 ZoneCol)
        {
            return IDrawingDocinstance.IDrawingDocInstance.SetupSheet6(Name, PaperSize, TemplateIn, Scale1, Scale2, FirstAngle, TemplateName, Width, Height, PropertyViewName, RemoveModifiedNotes, ZoneLeftMargin, ZoneRightMargin, ZoneTopMargin, ZoneBottomMargin, ZoneRow, ZoneCol);
        }
        public static void SetSheetsSelected(IDrawingDocObject IDrawingDocinstance, Object NewSheetList)
        {
            IDrawingDocinstance.IDrawingDocInstance.SetSheetsSelected(NewSheetList);
        }
        public static Object CreateDetailViewAt4(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, Int32 Style, Double Scale1, Double Scale2, String LabelIn, Int32 Showtype, Boolean FullOutline, Boolean JaggedOutline, Boolean NoOutline, Int32 ShapeIntensity)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateDetailViewAt4(X, Y, Z, Style, Scale1, Scale2, LabelIn, Showtype, FullOutline, JaggedOutline, NoOutline, ShapeIntensity);
        }
        public static Boolean ChangeRefConfigurationOfFlatPatternView(IDrawingDocObject IDrawingDocinstance, String ModelName, String ConfigName)
        {
            return IDrawingDocinstance.IDrawingDocInstance.ChangeRefConfigurationOfFlatPatternView(ModelName, ConfigName);
        }
        public static Object AddHoleCallout2(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z)
        {
            return IDrawingDocinstance.IDrawingDocInstance.AddHoleCallout2(X, Y, Z);
        }
        public static IDisplayDimensionObject IAddHoleCallout2(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z)
        {
            return new IDisplayDimensionObject(IDrawingDocinstance.IDrawingDocInstance.IAddHoleCallout2(X, Y, Z));
        }
        public static void EditCenterMarkProperties(IDrawingDocObject IDrawingDocinstance, Double Angle, Double Size, Boolean Lines, Boolean DocSettings)
        {
            IDrawingDocinstance.IDrawingDocInstance.EditCenterMarkProperties(Angle, Size, Lines, DocSettings);
        }
        public static Object InsertDowelSymbol(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.InsertDowelSymbol();
        }
        public static IDowelSymbolObject IInsertDowelSymbol(IDrawingDocObject IDrawingDocinstance)
        {
            return new IDowelSymbolObject(IDrawingDocinstance.IDrawingDocInstance.IInsertDowelSymbol());
        }
        public static void InsertMultiJogLeader(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertMultiJogLeader();
        }
        public static Object AddChamferDim(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z)
        {
            return IDrawingDocinstance.IDrawingDocInstance.AddChamferDim(X, Y, Z);
        }
        public static IDisplayDimensionObject IAddChamferDim(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z)
        {
            return new IDisplayDimensionObject(IDrawingDocinstance.IDrawingDocInstance.IAddChamferDim(X, Y, Z));
        }
        public static Object MakeCustomSymbol2(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.MakeCustomSymbol2();
        }
        public static ICustomSymbolObject IMakeCustomSymbol2(IDrawingDocObject IDrawingDocinstance)
        {
            return new ICustomSymbolObject(IDrawingDocinstance.IDrawingDocInstance.IMakeCustomSymbol2());
        }
        public static Object InsertCustomSymbol2(IDrawingDocObject IDrawingDocinstance, String FileName)
        {
            return IDrawingDocinstance.IDrawingDocInstance.InsertCustomSymbol2(FileName);
        }
        public static ICustomSymbolObject IInsertCustomSymbol2(IDrawingDocObject IDrawingDocinstance, String FileName)
        {
            return new ICustomSymbolObject(IDrawingDocinstance.IDrawingDocInstance.IInsertCustomSymbol2(FileName));
        }
        public static Object CreateCustomSymbol(IDrawingDocObject IDrawingDocinstance, Object Segments, Object Points, Object Notes)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateCustomSymbol(Segments, Points, Notes);
        }
        //public static ICustomSymbolObject ICreateCustomSymbol(IDrawingDocObject IDrawingDocinstance, Int32 SegmentCount, SketchSegment&Object Segments, Int32 PointCount, SketchPoint&Object Points, Int32 NoteCount, Note&Object Notes)
        //{
        //    return new ICustomSymbolObject(IDrawingDocinstance.IDrawingDocInstance.ICreateCustomSymbol(SegmentCount, Segments, PointCount, Points, NoteCount, Notes));
        //}
        public static void ViewDisplayShaded(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.ViewDisplayShaded();
        }
        public static void ChangeComponentLayer(IDrawingDocObject IDrawingDocinstance, String Layername, Boolean AllViews)
        {
            IDrawingDocinstance.IDrawingDocInstance.ChangeComponentLayer(Layername, AllViews);
        }
        public static ICenterMarkObject InsertCenterMark(IDrawingDocObject IDrawingDocinstance, Boolean UseDoc, Double Size, Boolean ShowLines, Double Angle)
        {
            return new ICenterMarkObject(IDrawingDocinstance.IDrawingDocInstance.InsertCenterMark(UseDoc, Size, ShowLines, Angle));
        }
        public static Boolean CreateFlatPatternViewFromModelView2(IDrawingDocObject IDrawingDocinstance, String ModelName, String ConfigName, Double LocX, Double LocY, Double LocZ, Boolean HideBendLines)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateFlatPatternViewFromModelView2(ModelName, ConfigName, LocX, LocY, LocZ, HideBendLines);
        }
        public static void ViewHlrQuality(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.ViewHlrQuality();
        }
        public static void ViewModelEdges(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.ViewModelEdges();
        }
        public static Int32 GetBlockDefinitionCount(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetBlockDefinitionCount();
        }
        public static Object GetBlockDefinitions(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetBlockDefinitions();
        }
        public static IBlockDefinitionObject IGetBlockDefinitions(IDrawingDocObject IDrawingDocinstance, Int32 Count)
        {
            return new IBlockDefinitionObject(IDrawingDocinstance.IDrawingDocInstance.IGetBlockDefinitions(Count));
        }
        public static IBlockDefinitionObject GetBlockDefinition(IDrawingDocObject IDrawingDocinstance, String Name)
        {
            return new IBlockDefinitionObject(IDrawingDocinstance.IDrawingDocInstance.GetBlockDefinition(Name));
        }
        public static IBlockDefinitionObject MakeBlockDefinition(IDrawingDocObject IDrawingDocinstance, String Name, String XRefFileName, Boolean Instance)
        {
            return new IBlockDefinitionObject(IDrawingDocinstance.IDrawingDocInstance.MakeBlockDefinition(Name, XRefFileName, Instance));
        }
        public static Object CreateBlockDefinition(IDrawingDocObject IDrawingDocinstance, String Name, String XRefFileName, Boolean Instance, Object Segments, Object Points, Object Notes, Object Dimensions, Object Blocks)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateBlockDefinition(Name, XRefFileName, Instance, Segments, Points, Notes, Dimensions, Blocks);
        }
        //public static IBlockDefinitionObject ICreateBlockDefinition(IDrawingDocObject IDrawingDocinstance, String Name, String XRefFileName, Boolean Instance, Int32 SegmentCount, SketchSegment&Object Segments, Int32 PointCount, SketchPoint&Object Points, Int32 NoteCount, Note&Object Notes, Int32 DimensionCount, DisplayDimension&Object Dimensions, Int32 BlockCount, BlockInstance&Object Blocks)
        //{
        //    return new IBlockDefinitionObject(IDrawingDocinstance.IDrawingDocInstance.ICreateBlockDefinition(Name, XRefFileName, Instance, SegmentCount, Segments, PointCount, Points, NoteCount, Notes, DimensionCount, Dimensions, BlockCount, Blocks));
        //}
        public static IBlockInstanceObject InsertBlock(IDrawingDocObject IDrawingDocinstance, String FileName, Double X, Double Y, Double Angle, Double Scale)
        {
            return new IBlockInstanceObject(IDrawingDocinstance.IDrawingDocInstance.InsertBlock(FileName, X, Y, Angle, Scale));
        }
        public static Boolean SaveBlock(IDrawingDocObject IDrawingDocinstance, String FileName)
        {
            return IDrawingDocinstance.IDrawingDocInstance.SaveBlock(FileName);
        }
        public static Boolean ExplodeBlockInstance(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.ExplodeBlockInstance();
        }
        public static ICenterMarkObject InsertCenterMark2(IDrawingDocObject IDrawingDocinstance, Int32 Style, Boolean Propagate)
        {
            return new ICenterMarkObject(IDrawingDocinstance.IDrawingDocInstance.InsertCenterMark2(Style, Propagate));
        }
        public static Boolean InsertCenterLine(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.InsertCenterLine();
        }
        public static Int32 AddOrdinateDimension2(IDrawingDocObject IDrawingDocinstance, Int32 DimType, Double LocX, Double LocY, Double LocZ)
        {
            return IDrawingDocinstance.IDrawingDocInstance.AddOrdinateDimension2(DimType, LocX, LocY, LocZ);
        }
        public static ITableAnnotationObject InsertTableAnnotation(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Int32 AnchorType, Int32 Rows, Int32 Columns)
        {
            return new ITableAnnotationObject(IDrawingDocinstance.IDrawingDocInstance.InsertTableAnnotation(X, Y, AnchorType, Rows, Columns));
        }
        public static Boolean InsertModelInPredefinedView(IDrawingDocObject IDrawingDocinstance, String ModelName)
        {
            return IDrawingDocinstance.IDrawingDocInstance.InsertModelInPredefinedView(ModelName);
        }
        public static INoteObject InsertRevisionSymbol(IDrawingDocObject IDrawingDocinstance, Double X, Double Y)
        {
            return new INoteObject(IDrawingDocinstance.IDrawingDocInstance.InsertRevisionSymbol(X, Y));
        }
        public static Object AutoBalloon(IDrawingDocObject IDrawingDocinstance, Int32 Layout)
        {
            return IDrawingDocinstance.IDrawingDocInstance.AutoBalloon(Layout);
        }
        public static IViewObject CreateSectionViewAt3(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, Boolean NotAligned, Boolean IsOffsetSection, String Label, Boolean Chgdirection, Boolean Scwithmodel, Boolean Partial, Boolean Dispsurfcut, Object ExcludedComponents)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.CreateSectionViewAt3(X, Y, Z, NotAligned, IsOffsetSection, Label, Chgdirection, Scwithmodel, Partial, Dispsurfcut, ExcludedComponents));
        }
        //public static IViewObject ICreateSectionViewAt3(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, Boolean NotAligned, Boolean IsOffsetSection, String Label, Boolean Chgdirection, Boolean Scwithmodel, Boolean Partial, Boolean Dispsurfcut, Int32 NumExcludedComponents, Object& PExcludedComponents)
        //{
        //    return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.ICreateSectionViewAt3(X, Y, Z, NotAligned, IsOffsetSection, Label, Chgdirection, Scwithmodel, Partial, Dispsurfcut, NumExcludedComponents, PExcludedComponents));
        //}
        public static Boolean InsertModelAnnotations2(IDrawingDocObject IDrawingDocinstance, Int32 Option, Boolean AllTypes, Int32 Types, Boolean AllViews, Boolean DuplicateDims, Boolean HiddenFeatureDims)
        {
            return IDrawingDocinstance.IDrawingDocInstance.InsertModelAnnotations2(Option, AllTypes, Types, AllViews, DuplicateDims, HiddenFeatureDims);
        }
        public static Boolean GetEditBlock(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetEditBlock();
        }
        public static ICenterLineObject InsertCenterLine2(IDrawingDocObject IDrawingDocinstance)
        {
            return new ICenterLineObject(IDrawingDocinstance.IDrawingDocInstance.InsertCenterLine2());
        }
        public static Object InsertMultiJogLeader2(IDrawingDocObject IDrawingDocinstance, Object Points)
        {
            return IDrawingDocinstance.IDrawingDocInstance.InsertMultiJogLeader2(Points);
        }
        //public static IMultiJogLeaderObject IInsertMultiJogLeader2(IDrawingDocObject IDrawingDocinstance, Int32 PointsCount, MathPoint&Object Points)
        //{
        //    return new IMultiJogLeaderObject(IDrawingDocinstance.IDrawingDocInstance.IInsertMultiJogLeader2(PointsCount, Points));
        //}
        public static Int32 AutoDimension(IDrawingDocObject IDrawingDocinstance, Int32 EntitiesToDimension, Int32 HorizontalScheme, Int32 HorizontalPlacement, Int32 VerticalScheme, Int32 VerticalPlacement)
        {
            return IDrawingDocinstance.IDrawingDocInstance.AutoDimension(EntitiesToDimension, HorizontalScheme, HorizontalPlacement, VerticalScheme, VerticalPlacement);
        }
        public static Object InsertModelAnnotations3(IDrawingDocObject IDrawingDocinstance, Int32 Option, Int32 Types, Boolean AllViews, Boolean DuplicateDims, Boolean HiddenFeatureDims, Boolean UsePlacementInSketch)
        {
            return IDrawingDocinstance.IDrawingDocInstance.InsertModelAnnotations3(Option, Types, AllViews, DuplicateDims, HiddenFeatureDims, UsePlacementInSketch);
        }
        public static IViewObject CreateUnfoldedViewAt3(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, Boolean NotAligned)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.CreateUnfoldedViewAt3(X, Y, Z, NotAligned));
        }
        public static IViewObject CreateDrawViewFromModelView2(IDrawingDocObject IDrawingDocinstance, String ModelName, String ViewName, Double LocX, Double LocY, Double LocZ)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.CreateDrawViewFromModelView2(ModelName, ViewName, LocX, LocY, LocZ));
        }
        public static IViewObject CreateSectionViewAt4(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, String SectionLabel, Int32 Options, Object ExcludedComponents)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.CreateSectionViewAt4(X, Y, Z, SectionLabel, Options, ExcludedComponents));
        }
        //public static IViewObject ICreateSectionViewAt4(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, String SectionLabel, Int32 Options, Int32 NumExcludedComponents, Object& ExcludedComponents)
        //{
        //    return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.ICreateSectionViewAt4(X, Y, Z, SectionLabel, Options, NumExcludedComponents, ExcludedComponents));
        //}
        public static Object AutoBalloon2(IDrawingDocObject IDrawingDocinstance, Int32 Layout, Boolean IgnoreMultiple)
        {
            return IDrawingDocinstance.IDrawingDocInstance.AutoBalloon2(Layout, IgnoreMultiple);
        }
        public static IViewObject CreateViewport3(IDrawingDocObject IDrawingDocinstance, Double LowerLeftX, Double LowerLeftY, Int16 SketchSize, Double Scale)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.CreateViewport3(LowerLeftX, LowerLeftY, SketchSize, Scale));
        }
        public static IViewObject CreateDrawViewFromModelView3(IDrawingDocObject IDrawingDocinstance, String ModelName, String ViewName, Double LocX, Double LocY, Double LocZ)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.CreateDrawViewFromModelView3(ModelName, ViewName, LocX, LocY, LocZ));
        }
        public static Object InsertMultiJogLeader3(IDrawingDocObject IDrawingDocinstance, Object Points, Int32 StartPointArrowStyle, Int32 EndPointArrowStyle)
        {
            return IDrawingDocinstance.IDrawingDocInstance.InsertMultiJogLeader3(Points, StartPointArrowStyle, EndPointArrowStyle);
        }
        //public static IMultiJogLeaderObject IInsertMultiJogLeader3(IDrawingDocObject IDrawingDocinstance, Int32 PointsCount, MathPoint&Object Points, Int32 StartPointArrowStyle, Int32 EndPointArrowStyle)
        //{
        //    return new IMultiJogLeaderObject(IDrawingDocinstance.IDrawingDocInstance.IInsertMultiJogLeader3(PointsCount, Points, StartPointArrowStyle, EndPointArrowStyle));
        //}
        public static ITableAnnotationObject InsertTableAnnotation2(IDrawingDocObject IDrawingDocinstance, Boolean UseAnchorPoint, Double X, Double Y, Int32 AnchorType, String TableTemplate, Int32 Rows, Int32 Columns)
        {
            return new ITableAnnotationObject(IDrawingDocinstance.IDrawingDocInstance.InsertTableAnnotation2(UseAnchorPoint, X, Y, AnchorType, TableTemplate, Rows, Columns));
        }
        public static Boolean ResolveOutOfDateLightWeightComponents(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.ResolveOutOfDateLightWeightComponents();
        }
        public static IViewObject CreateRelativeView(IDrawingDocObject IDrawingDocinstance, String ModelName, Double XPos, Double YPos, Int32 ViewDirFront, Int32 ViewDirRight)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.CreateRelativeView(ModelName, XPos, YPos, ViewDirFront, ViewDirRight));
        }
        public static Object AutoBalloon3(IDrawingDocObject IDrawingDocinstance, Int32 Layout, Boolean IgnoreMultiple, Int32 Style, Int32 Size, Int32 UpperTextContent, String UpperText, Int32 LowerTextContent, String LowerText, String Layername)
        {
            return IDrawingDocinstance.IDrawingDocInstance.AutoBalloon3(Layout, IgnoreMultiple, Style, Size, UpperTextContent, UpperText, LowerTextContent, LowerText, Layername);
        }
        public static IViewObject DropDrawingViewFromPalette(IDrawingDocObject IDrawingDocinstance, Int32 Layout, Double X, Double Y, Double Z)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.DropDrawingViewFromPalette(Layout, X, Y, Z));
        }
        public static Boolean ReorderSheets(IDrawingDocObject IDrawingDocinstance, Object NewSheetList)
        {
            return IDrawingDocinstance.IDrawingDocInstance.ReorderSheets(NewSheetList);
        }
        //public static Boolean IReorderSheets(IDrawingDocObject IDrawingDocinstance, Int32 SheetCount, String& NewSheetList)
        //{
        //    return IDrawingDocinstance.IDrawingDocInstance.IReorderSheets(SheetCount, NewSheetList);
        //}
        public static IViewObject DropDrawingViewFromPalette2(IDrawingDocObject IDrawingDocinstance, String PaletteViewName, Double X, Double Y, Double Z)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.DropDrawingViewFromPalette2(PaletteViewName, X, Y, Z));
        }
        public static Object GetDrawingPaletteViewNames(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetDrawingPaletteViewNames();
        }
        public static Boolean GenerateViewPaletteViews(IDrawingDocObject IDrawingDocinstance, String FileName)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GenerateViewPaletteViews(FileName);
        }
        public static IViewObject CreateFlatPatternViewFromModelView3(IDrawingDocObject IDrawingDocinstance, String ModelName, String ConfigName, Double LocX, Double LocY, Double LocZ, Boolean HideBendLines, Boolean FlipView)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.CreateFlatPatternViewFromModelView3(ModelName, ConfigName, LocX, LocY, LocZ, HideBendLines, FlipView));
        }
        public static Boolean SetupSheet5(IDrawingDocObject IDrawingDocinstance, String Name, Int32 PaperSize, Int32 TemplateIn, Double Scale1, Double Scale2, Boolean FirstAngle, String TemplateName, Double Width, Double Height, String PropertyViewName, Boolean RemoveModifiedNotes)
        {
            return IDrawingDocinstance.IDrawingDocInstance.SetupSheet5(Name, PaperSize, TemplateIn, Scale1, Scale2, FirstAngle, TemplateName, Width, Height, PropertyViewName, RemoveModifiedNotes);
        }
        public static void SetLineWidthCustom(IDrawingDocObject IDrawingDocinstance, Double Width)
        {
            IDrawingDocinstance.IDrawingDocInstance.SetLineWidthCustom(Width);
        }
        public static Object GetViews(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetViews();
        }
        public static Int32 GetViewCount(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetViewCount();
        }
        public static ICenterMarkObject InsertCenterMark3(IDrawingDocObject IDrawingDocinstance, Int32 Style, Boolean Propagate, Boolean Slot)
        {
            return new ICenterMarkObject(IDrawingDocinstance.IDrawingDocInstance.InsertCenterMark3(Style, Propagate, Slot));
        }
        public static void DeleteAllCosmeticThreads(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.DeleteAllCosmeticThreads();
        }
        public static IViewObject CreateSectionViewAt5(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, String SectionLabel, Int32 Options, Object ExcludedComponents, Double SectionDepth)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.CreateSectionViewAt5(X, Y, Z, SectionLabel, Options, ExcludedComponents, SectionDepth));
        }
        //public static IViewObject ICreateSectionViewAt5(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, String SectionLabel, Int32 Options, Int32 NumExcludedComponents, Object& ExcludedComponents, Double SectionDepth)
        //{
        //    return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.ICreateSectionViewAt5(X, Y, Z, SectionLabel, Options, NumExcludedComponents, ExcludedComponents, SectionDepth));
        //}
        public static Object AutoBalloon4(IDrawingDocObject IDrawingDocinstance, Int32 Layout, Boolean IgnoreMultiple, Int32 Style, Int32 Size, Int32 UpperTextContent, String UpperText, Int32 LowerTextContent, String LowerText, String Layername, Boolean BalloonsToFaces)
        {
            return IDrawingDocinstance.IDrawingDocInstance.AutoBalloon4(Layout, IgnoreMultiple, Style, Size, UpperTextContent, UpperText, LowerTextContent, LowerText, Layername, BalloonsToFaces);
        }
        //public static Boolean GetLineStyles(IDrawingDocObject IDrawingDocinstance, Object& StyleNameList, Object& StyleList)
        //{
        //    return IDrawingDocinstance.IDrawingDocInstance.GetLineStyles(StyleNameList, StyleList);
        //}
        public static Boolean SaveLineStyles(IDrawingDocObject IDrawingDocinstance, String StyleFiles, Object StyleNameList, Boolean ReplaceExisting)
        {
            return IDrawingDocinstance.IDrawingDocInstance.SaveLineStyles(StyleFiles, StyleNameList, ReplaceExisting);
        }
        public static void FlipSectionLine(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.FlipSectionLine();
        }
        public static Object FeatureByName(IDrawingDocObject IDrawingDocinstance, String Name)
        {
            return IDrawingDocinstance.IDrawingDocInstance.FeatureByName(Name);
        }
        public static IFeatureObject IFeatureByName(IDrawingDocObject IDrawingDocinstance, String Name)
        {
            return new IFeatureObject(IDrawingDocinstance.IDrawingDocInstance.IFeatureByName(Name));
        }
        public static Boolean NewSheet2(IDrawingDocObject IDrawingDocinstance, String Name, Int32 PaperSize, Int32 TemplateIn, Double Scale1, Double Scale2, Boolean FirstAngle, String TemplateName, Double Width, Double Height)
        {
            return IDrawingDocinstance.IDrawingDocInstance.NewSheet2(Name, PaperSize, TemplateIn, Scale1, Scale2, FirstAngle, TemplateName, Width, Height);
        }
        public static Boolean CreateLinearDim2(IDrawingDocObject IDrawingDocinstance, Object P0, Object P1, Object P2, Object P3, Object P4, Double Val, Int32 PrimPrec, String Text, Object TextPoint, Double Angle, Double TextHeight, String Prefix, String Suffix, String Callout1, String Callout2, Int32 TolType, String TolMin, String TolMax, Int32 TolPrec, Double ArrowSize, Int32 ArrowStyle, Int32 ArrowDir, Double WitnessGap, Double WitnessOvershoot, Boolean DualDisplay, Int32 DualPrec)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateLinearDim2(P0, P1, P2, P3, P4, Val, PrimPrec, Text, TextPoint, Angle, TextHeight, Prefix, Suffix, Callout1, Callout2, TolType, TolMin, TolMax, TolPrec, ArrowSize, ArrowStyle, ArrowDir, WitnessGap, WitnessOvershoot, DualDisplay, DualPrec);
        }
        //public static void ICreateLinearDim2(IDrawingDocObject IDrawingDocinstance, Double& P0, Double& P1, Double& P2, Double& P3, Double& P4, Double Val, Int32 PrimPrec, String Text, Double& TextPoint, Double Angle, Double TextHeight, String Prefix, String Suffix, String Callout1, String Callout2, Int32 TolType, String TolMin, String TolMax, Int32 TolPrec, Double ArrowSize, Int32 ArrowStyle, Int32 ArrowDir, Double WitnessGap, Double WitnessOvershoot, Boolean DualDisplay, Int32 DualPrecision)
        //{
        //    return IDrawingDocinstance.IDrawingDocInstance.ICreateLinearDim2(P0, P1, P2, P3, P4, Val, PrimPrec, Text, TextPoint, Angle, TextHeight, Prefix, Suffix, Callout1, Callout2, TolType, TolMin, TolMax, TolPrec, ArrowSize, ArrowStyle, ArrowDir, WitnessGap, WitnessOvershoot, DualDisplay, DualPrecision);
        //}
        public static Boolean CreateAngDim2(IDrawingDocObject IDrawingDocinstance, Object VP0, Object VP1, Object VP2, Object VP3, Object VP4, Object VP5, Object VP6, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot, Object VTextPoint)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateAngDim2(VP0, VP1, VP2, VP3, VP4, VP5, VP6, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot, VTextPoint);
        }
        //public static void ICreateAngDim2(IDrawingDocObject IDrawingDocinstance, Double& P0, Double& P1, Double& P2, Double& P3, Double& P4, Double& P5, Double& P6, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot, Double& TextPoint)
        //{
        //    return IDrawingDocinstance.IDrawingDocInstance.ICreateAngDim2(P0, P1, P2, P3, P4, P5, P6, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot, TextPoint);
        //}
        public static Boolean CreateDiamDim2(IDrawingDocObject IDrawingDocinstance, Double DimVal, Object VP0, Object VP1, Object VP2, Object VP3, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot, Object VTextPoint)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateDiamDim2(DimVal, VP0, VP1, VP2, VP3, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot, VTextPoint);
        }
        //public static void ICreateDiamDim2(IDrawingDocObject IDrawingDocinstance, Double DimValue, Double& P0, Double& P1, Double& P2, Double& P3, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot, Double& TextPoint)
        //{
        //    return IDrawingDocinstance.IDrawingDocInstance.ICreateDiamDim2(DimValue, P0, P1, P2, P3, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot, TextPoint);
        //}
        public static Boolean CreateOrdinateDim2(IDrawingDocObject IDrawingDocinstance, Object P0, Object P1, Object P2, Object P3, Object P4, Double Angle, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot, Object P5)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateOrdinateDim2(P0, P1, P2, P3, P4, Angle, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot, P5);
        }
        //public static void ICreateOrdinateDim2(IDrawingDocObject IDrawingDocinstance, Double& P0, Double& P1, Double& P2, Double& P3, Double& P4, Double Angle, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot, Double& P5)
        //{
        //    return IDrawingDocinstance.IDrawingDocInstance.ICreateOrdinateDim2(P0, P1, P2, P3, P4, Angle, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot, P5);
        //}
        public static void InsertNewNote2(IDrawingDocObject IDrawingDocinstance, String UpperText, String LowerText, Boolean NoLeader, Boolean BentLeader, Int16 ArrowStyle, Int16 LeaderSide, Double Angle, Int16 BalloonStyle, Int16 BalloonFit, Int16 UpperNoteContent, Int16 LowerNoteContent)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertNewNote2(UpperText, LowerText, NoLeader, BentLeader, ArrowStyle, LeaderSide, Angle, BalloonStyle, BalloonFit, UpperNoteContent, LowerNoteContent);
        }
        public static void DragModelDimension(IDrawingDocObject IDrawingDocinstance, String ViewName, Int16 DropEffect, Double X, Double Y, Double Z)
        {
            IDrawingDocinstance.IDrawingDocInstance.DragModelDimension(ViewName, DropEffect, X, Y, Z);
        }
        public static String CreateViewport2(IDrawingDocObject IDrawingDocinstance, Double LowerLeftX, Double LowerLeftY, Double UpperRightX, Double UpperRightY, Int16 SketchSize, Double Scale)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateViewport2(LowerLeftX, LowerLeftY, UpperRightX, UpperRightY, SketchSize, Scale);
        }
        public static void SetupSheet2(IDrawingDocObject IDrawingDocinstance, String Name, Int16 PaperSize, Int16 TemplateIn, Double Scale1, Double Scale2, Int32 SkPointsFlag)
        {
            IDrawingDocinstance.IDrawingDocInstance.SetupSheet2(Name, PaperSize, TemplateIn, Scale1, Scale2, SkPointsFlag);
        }
        public static void OnComponentProperties(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.OnComponentProperties();
        }
        public static Int32 GetLineFontCount2(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetLineFontCount2();
        }
        public static String GetLineFontName2(IDrawingDocObject IDrawingDocinstance, Int32 Index)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetLineFontName2(Index);
        }
        public static Object GetLineFontInfo2(IDrawingDocObject IDrawingDocinstance, Int32 Index)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetLineFontInfo2(Index);
        }
        public static void SetLineStyle(IDrawingDocObject IDrawingDocinstance, String StyleName)
        {
            IDrawingDocinstance.IDrawingDocInstance.SetLineStyle(StyleName);
        }
        public static void SetLineWidth(IDrawingDocObject IDrawingDocinstance, Int32 Width)
        {
            IDrawingDocinstance.IDrawingDocInstance.SetLineWidth(Width);
        }
        public static void SetLineColor(IDrawingDocObject IDrawingDocinstance, Int32 Color)
        {
            IDrawingDocinstance.IDrawingDocInstance.SetLineColor(Color);
        }
        public static void ShowEdge(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.ShowEdge();
        }
        public static void HideEdge(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.HideEdge();
        }
        public static void AddHoleCallout(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.AddHoleCallout();
        }
        public static Int32 GetPenCount(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetPenCount();
        }
        public static Object GetPenInfo(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetPenInfo();
        }
        public static Int32 IGetPenInfo(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.IGetPenInfo();
        }
        public static Int32 GetLineFontId(IDrawingDocObject IDrawingDocinstance, Int32 Index)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetLineFontId(Index);
        }
        public static Boolean CreateAuxiliaryViewAt(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, Boolean NotAligned)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateAuxiliaryViewAt(X, Y, Z, NotAligned);
        }
        public static Boolean CreateDetailViewAt(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateDetailViewAt(X, Y, Z);
        }
        public static Boolean CreateSectionViewAt(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, Boolean NotAligned, Boolean IsOffsetSection)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateSectionViewAt(X, Y, Z, NotAligned, IsOffsetSection);
        }
        public static Boolean CreateUnfoldedViewAt2(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, Boolean NotAligned)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateUnfoldedViewAt2(X, Y, Z, NotAligned);
        }
        public static Boolean SetupSheet3(IDrawingDocObject IDrawingDocinstance, String Name, Int32 PaperSize, Int32 TemplateIn, Double Scale1, Double Scale2, Boolean FirstAngle, String TemplateName, Double Width, Double Height)
        {
            return IDrawingDocinstance.IDrawingDocInstance.SetupSheet3(Name, PaperSize, TemplateIn, Scale1, Scale2, FirstAngle, TemplateName, Width, Height);
        }
        public static Boolean InsertModelAnnotations(IDrawingDocObject IDrawingDocinstance, Int32 Option, Boolean AllTypes, Int32 Types, Boolean AllViews)
        {
            return IDrawingDocinstance.IDrawingDocInstance.InsertModelAnnotations(Option, AllTypes, Types, AllViews);
        }
        public static void InsertCustomSymbol(IDrawingDocObject IDrawingDocinstance, String SymbolPath)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertCustomSymbol(SymbolPath);
        }
        public static Int32 GetSheetCount(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetSheetCount();
        }
        public static Object GetSheetNames(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetSheetNames();
        }
        //public static String IGetSheetNames(IDrawingDocObject IDrawingDocinstance, Int32& Count)
        //{
        //    return IDrawingDocinstance.IDrawingDocInstance.IGetSheetNames(Count);
        //}
        //public static Boolean ActivateSheet(IDrawingDocObject IDrawingDocinstance, String Name)
        //{
        //    return IDrawingDocinstance.IDrawingDocInstance.ActivateSheet(Name);
        //}
        public static Object CreateText2(IDrawingDocObject IDrawingDocinstance, String TextString, Double TextX, Double TextY, Double TextZ, Double TextHeight, Double TextAngle)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateText2(TextString, TextX, TextY, TextZ, TextHeight, TextAngle);
        }
        public static INoteObject ICreateText2(IDrawingDocObject IDrawingDocinstance, String TextString, Double TextX, Double TextY, Double TextZ, Double TextHeight, Double TextAngle)
        {
            return new INoteObject(IDrawingDocinstance.IDrawingDocInstance.ICreateText2(TextString, TextX, TextY, TextZ, TextHeight, TextAngle));
        }
        public static Boolean NewSheet3(IDrawingDocObject IDrawingDocinstance, String Name, Int32 PaperSize, Int32 TemplateIn, Double Scale1, Double Scale2, Boolean FirstAngle, String TemplateName, Double Width, Double Height, String PropertyViewName)
        {
            return IDrawingDocinstance.IDrawingDocInstance.NewSheet3(Name, PaperSize, TemplateIn, Scale1, Scale2, FirstAngle, TemplateName, Width, Height, PropertyViewName);
        }
        public static Boolean SetupSheet4(IDrawingDocObject IDrawingDocinstance, String Name, Int32 PaperSize, Int32 TemplateIn, Double Scale1, Double Scale2, Boolean FirstAngle, String TemplateName, Double Width, Double Height, String PropertyViewName)
        {
            return IDrawingDocinstance.IDrawingDocInstance.SetupSheet4(Name, PaperSize, TemplateIn, Scale1, Scale2, FirstAngle, TemplateName, Width, Height, PropertyViewName);
        }
        public static Object CreateLinearDim3(IDrawingDocObject IDrawingDocinstance, Object P0, Object P1, Object P2, Object P3, Object P4, Double Val, Int32 PrimPrec, String Text, Object TextPoint, Double Angle, Double TextHeight, String Prefix, String Suffix, String Callout1, String Callout2, Int32 TolType, String TolMin, String TolMax, Int32 TolPrec, Double ArrowSize, Int32 ArrowStyle, Int32 ArrowDir, Double WitnessGap, Double WitnessOvershoot, Boolean DualDisplay, Int32 DualPrec)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateLinearDim3(P0, P1, P2, P3, P4, Val, PrimPrec, Text, TextPoint, Angle, TextHeight, Prefix, Suffix, Callout1, Callout2, TolType, TolMin, TolMax, TolPrec, ArrowSize, ArrowStyle, ArrowDir, WitnessGap, WitnessOvershoot, DualDisplay, DualPrec);
        }
        //public static IDisplayDimensionObject ICreateLinearDim3(IDrawingDocObject IDrawingDocinstance, Double& P0, Double& P1, Double& P2, Double& P3, Double& P4, Double Val, Int32 PrimPrec, String Text, Double& TextPoint, Double Angle, Double TextHeight, String Prefix, String Suffix, String Callout1, String Callout2, Int32 TolType, String TolMin, String TolMax, Int32 TolPrec, Double ArrowSize, Int32 ArrowStyle, Int32 ArrowDir, Double WitnessGap, Double WitnessOvershoot, Boolean DualDisplay, Int32 DualPrecision)
        //{
        //    return new IDisplayDimensionObject(IDrawingDocinstance.IDrawingDocInstance.ICreateLinearDim3(P0, P1, P2, P3, P4, Val, PrimPrec, Text, TextPoint, Angle, TextHeight, Prefix, Suffix, Callout1, Callout2, TolType, TolMin, TolMax, TolPrec, ArrowSize, ArrowStyle, ArrowDir, WitnessGap, WitnessOvershoot, DualDisplay, DualPrecision));
        //}
        public static Object CreateAngDim3(IDrawingDocObject IDrawingDocinstance, Object VP0, Object VP1, Object VP2, Object VP3, Object VP4, Object VP5, Object VP6, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot, Object VTextPoint)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateAngDim3(VP0, VP1, VP2, VP3, VP4, VP5, VP6, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot, VTextPoint);
        }
        //public static IDisplayDimensionObject ICreateAngDim3(IDrawingDocObject IDrawingDocinstance, Double& P0, Double& P1, Double& P2, Double& P3, Double& P4, Double& P5, Double& P6, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot, Double& TextPoint)
        //{
        //    return new IDisplayDimensionObject(IDrawingDocinstance.IDrawingDocInstance.ICreateAngDim3(P0, P1, P2, P3, P4, P5, P6, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot, TextPoint));
        //}
        public static Object CreateDiamDim3(IDrawingDocObject IDrawingDocinstance, Double DimVal, Object VP0, Object VP1, Object VP2, Object VP3, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot, Object VTextPoint)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateDiamDim3(DimVal, VP0, VP1, VP2, VP3, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot, VTextPoint);
        }
        //public static IDisplayDimensionObject ICreateDiamDim3(IDrawingDocObject IDrawingDocinstance, Double DimValue, Double& P0, Double& P1, Double& P2, Double& P3, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot, Double& TextPoint)
        //{
        //    return new IDisplayDimensionObject(IDrawingDocinstance.IDrawingDocInstance.ICreateDiamDim3(DimValue, P0, P1, P2, P3, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot, TextPoint));
        //}
        public static Object CreateOrdinateDim3(IDrawingDocObject IDrawingDocinstance, Object P0, Object P1, Object P2, Object P3, Object P4, Double Angle, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot, Object P5)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateOrdinateDim3(P0, P1, P2, P3, P4, Angle, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot, P5);
        }
        //public static IDisplayDimensionObject ICreateOrdinateDim3(IDrawingDocObject IDrawingDocinstance, Double& P0, Double& P1, Double& P2, Double& P3, Double& P4, Double Angle, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot, Double& P5)
        //{
        //    return new IDisplayDimensionObject(IDrawingDocinstance.IDrawingDocInstance.ICreateOrdinateDim3(P0, P1, P2, P3, P4, Angle, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot, P5));
        //}
        public static void ForceRebuild(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.ForceRebuild();
        }
        public static Boolean AddOrdinateDimension(IDrawingDocObject IDrawingDocinstance, Int32 DimType, Double LocX, Double LocY, Double LocZ)
        {
            return IDrawingDocinstance.IDrawingDocInstance.AddOrdinateDimension(DimType, LocX, LocY, LocZ);
        }
        public static Boolean CreateLayer(IDrawingDocObject IDrawingDocinstance, String Layername, String LayerDesc, Int32 LayerColor, Int32 LayerStyle, Int32 LayerWidth, Boolean BOn)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateLayer(Layername, LayerDesc, LayerColor, LayerStyle, LayerWidth, BOn);
        }
        public static Boolean SetCurrentLayer(IDrawingDocObject IDrawingDocinstance, String Layername)
        {
            return IDrawingDocinstance.IDrawingDocInstance.SetCurrentLayer(Layername);
        }
        public static Boolean DrawingViewRotate(IDrawingDocObject IDrawingDocinstance, Double NewAngle)
        {
            return IDrawingDocinstance.IDrawingDocInstance.DrawingViewRotate(NewAngle);
        }
        public static Boolean CreateDetailViewAt2(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateDetailViewAt2(X, Y, Z);
        }
        public static void RestoreRotation(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.RestoreRotation();
        }
        public static Boolean GetEditSheet(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetEditSheet();
        }
        public static void TranslateDrawing(IDrawingDocObject IDrawingDocinstance, Double DeltaX, Double DeltaY)
        {
            IDrawingDocinstance.IDrawingDocInstance.TranslateDrawing(DeltaX, DeltaY);
        }
        public static Boolean Create1stAngleViews2(IDrawingDocObject IDrawingDocinstance, String ModelName)
        {
            return IDrawingDocinstance.IDrawingDocInstance.Create1stAngleViews2(ModelName);
        }
        public static Boolean Create3rdAngleViews2(IDrawingDocObject IDrawingDocinstance, String ModelName)
        {
            return IDrawingDocinstance.IDrawingDocInstance.Create3rdAngleViews2(ModelName);
        }
        public static void HideShowDimensions(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.HideShowDimensions();
        }
        public static Object CreateLinearDim4(IDrawingDocObject IDrawingDocinstance, Object P0, Object P1, Object P2, Object P3, Object P4, Object TextPoint, Double Val, Double Angle, Double TextHeight)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateLinearDim4(P0, P1, P2, P3, P4, TextPoint, Val, Angle, TextHeight);
        }
        //public static IDisplayDimensionObject ICreateLinearDim4(IDrawingDocObject IDrawingDocinstance, Double& P0, Double& P1, Double& P2, Double& P3, Double& P4, Double& TextPoint, Double Val, Double Angle, Double TextHeight)
        //{
        //    return new IDisplayDimensionObject(IDrawingDocinstance.IDrawingDocInstance.ICreateLinearDim4(P0, P1, P2, P3, P4, TextPoint, Val, Angle, TextHeight));
        //}
        public static Object CreateDiamDim4(IDrawingDocObject IDrawingDocinstance, Object P0, Object P1, Object P2, Object P3, Object TextPoint, Double Val, Double TextHeight)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateDiamDim4(P0, P1, P2, P3, TextPoint, Val, TextHeight);
        }
        //public static IDisplayDimensionObject ICreateDiamDim4(IDrawingDocObject IDrawingDocinstance, Double& P0, Double& P1, Double& P2, Double& P3, Double& TextPoint, Double Val, Double TextHeight)
        //{
        //    return new IDisplayDimensionObject(IDrawingDocinstance.IDrawingDocInstance.ICreateDiamDim4(P0, P1, P2, P3, TextPoint, Val, TextHeight));
        //}
        public static Object CreateOrdinateDim4(IDrawingDocObject IDrawingDocinstance, Object P0, Object P1, Object P2, Object P3, Object P4, Object P5, Double Val, Double Angle, Double TextHeight)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateOrdinateDim4(P0, P1, P2, P3, P4, P5, Val, Angle, TextHeight);
        }
        //public static IDisplayDimensionObject ICreateOrdinateDim4(IDrawingDocObject IDrawingDocinstance, Double& P0, Double& P1, Double& P2, Double& P3, Double& P4, Double& P5, Double Val, Double Angle, Double TextHeight)
        //{
        //    return new IDisplayDimensionObject(IDrawingDocinstance.IDrawingDocInstance.ICreateOrdinateDim4(P0, P1, P2, P3, P4, P5, Val, Angle, TextHeight));
        //}
        public static Object CreateAngDim4(IDrawingDocObject IDrawingDocinstance, Object P0, Object P1, Object P2, Object P3, Object P4, Object P5, Object P6, Object TextPoint, Double TextHeight)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateAngDim4(P0, P1, P2, P3, P4, P5, P6, TextPoint, TextHeight);
        }
        //public static IDisplayDimensionObject ICreateAngDim4(IDrawingDocObject IDrawingDocinstance, Double& P0, Double& P1, Double& P2, Double& P3, Double& P4, Double& P5, Double& P6, Double& TextPoint, Double TextHeight)
        //{
        //    return new IDisplayDimensionObject(IDrawingDocinstance.IDrawingDocInstance.ICreateAngDim4(P0, P1, P2, P3, P4, P5, P6, TextPoint, TextHeight));
        //}
        public static Object CreateDetailViewAt3(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, Int32 Style, Double Scale1, Double Scale2, String LabelIn, Int32 Showtype, Boolean FullOutline)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateDetailViewAt3(X, Y, Z, Style, Scale1, Scale2, LabelIn, Showtype, FullOutline);
        }
        public static IViewObject ICreateDetailViewAt3(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, Int32 Style, Double Scale1, Double Scale2, String LabelIn, Int32 Showtype, Boolean FullOutline)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.ICreateDetailViewAt3(X, Y, Z, Style, Scale1, Scale2, LabelIn, Showtype, FullOutline));
        }
        public static Object CreateSectionViewAt2(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, Boolean NotAligned, Boolean IsOffsetSection, String Label, Boolean Chgdirection, Boolean Scwithmodel, Boolean Partial, Boolean Dispsurfcut)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateSectionViewAt2(X, Y, Z, NotAligned, IsOffsetSection, Label, Chgdirection, Scwithmodel, Partial, Dispsurfcut);
        }
        public static IViewObject ICreateSectionViewAt2(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, Boolean NotAligned, Boolean IsOffsetSection, String Label, Boolean Chgdirection, Boolean Scwithmodel, Boolean Partial, Boolean Dispsurfcut)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.ICreateSectionViewAt2(X, Y, Z, NotAligned, IsOffsetSection, Label, Chgdirection, Scwithmodel, Partial, Dispsurfcut));
        }
        public static Object CreateAuxiliaryViewAt2(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, Boolean NotAligned, String Label, Boolean Showarrow, Boolean Flip)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateAuxiliaryViewAt2(X, Y, Z, NotAligned, Label, Showarrow, Flip);
        }
        public static IViewObject ICreateAuxiliaryViewAt2(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z, Boolean NotAligned, String Label, Boolean Showarrow, Boolean Flip)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.ICreateAuxiliaryViewAt2(X, Y, Z, NotAligned, Label, Showarrow, Flip));
        }
        public static void MakeCustomSymbol(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.MakeCustomSymbol();
        }
        public static void ExplodeCustomSymbol(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.ExplodeCustomSymbol();
        }
        public static void SaveCustomSymbol(IDrawingDocObject IDrawingDocinstance, String FileNameIn)
        {
            IDrawingDocinstance.IDrawingDocInstance.SaveCustomSymbol(FileNameIn);
        }
        public static Boolean CreateBreakOutSection(IDrawingDocObject IDrawingDocinstance, Double Depth)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateBreakOutSection(Depth);
        }
        public static void InsertThreadCallout(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertThreadCallout();
        }
        public static Boolean CreateFlatPatternViewFromModelView(IDrawingDocObject IDrawingDocinstance, String ModelName, String ConfigName, Double LocX, Double LocY, Double LocZ)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateFlatPatternViewFromModelView(ModelName, ConfigName, LocX, LocY, LocZ);
        }
        public static void NewNote(IDrawingDocObject IDrawingDocinstance, String Text, Double Height)
        {
            IDrawingDocinstance.IDrawingDocInstance.NewNote(Text, Height);
        }
        public static void NewSheet(IDrawingDocObject IDrawingDocinstance, String Name, Int16 PaperSize, Int16 TemplateIn, Double Scale1, Double Scale2)
        {
            IDrawingDocinstance.IDrawingDocInstance.NewSheet(Name, PaperSize, TemplateIn, Scale1, Scale2);
        }
        public static void SetupSheet(IDrawingDocObject IDrawingDocinstance, String Name, Int16 PaperSize, Int16 TemplateIn, Double Scale1, Double Scale2)
        {
            IDrawingDocinstance.IDrawingDocInstance.SetupSheet(Name, PaperSize, TemplateIn, Scale1, Scale2);
        }
        public static Object NewGtol(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.NewGtol();
        }
        public static IGtolObject INewGtol(IDrawingDocObject IDrawingDocinstance)
        {
            return new IGtolObject(IDrawingDocinstance.IDrawingDocInstance.INewGtol());
        }
        public static Object EditSelectedGtol(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.EditSelectedGtol();
        }
        public static IGtolObject IEditSelectedGtol(IDrawingDocObject IDrawingDocinstance)
        {
            return new IGtolObject(IDrawingDocinstance.IDrawingDocInstance.IEditSelectedGtol());
        }
        public static Boolean CreateLinearDim(IDrawingDocObject IDrawingDocinstance, Object P0, Object P1, Object P2, Object P3, Object P4, Double Angle, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateLinearDim(P0, P1, P2, P3, P4, Angle, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot);
        }
        public static Boolean CreateAngDim(IDrawingDocObject IDrawingDocinstance, Object VP0, Object VP1, Object VP2, Object VP3, Object VP4, Object VP5, Object VP6, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateAngDim(VP0, VP1, VP2, VP3, VP4, VP5, VP6, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot);
        }
        public static Boolean CreateDiamDim(IDrawingDocObject IDrawingDocinstance, Double DimVal, Object VP0, Object VP1, Object VP2, Object VP3, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateDiamDim(DimVal, VP0, VP1, VP2, VP3, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot);
        }
        public static String CreateViewport(IDrawingDocObject IDrawingDocinstance, Double LowerLeftX, Double LowerLeftY, Double UpperRightX, Double UpperRightY, Int16 SketchSize)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateViewport(LowerLeftX, LowerLeftY, UpperRightX, UpperRightY, SketchSize);
        }
        public static Boolean ActivateView(IDrawingDocObject IDrawingDocinstance, String ViewName)
        {
            return IDrawingDocinstance.IDrawingDocInstance.ActivateView(ViewName);
        }
        public static Boolean Create1stAngleViews(IDrawingDocObject IDrawingDocinstance, String ModelName)
        {
            return IDrawingDocinstance.IDrawingDocInstance.Create1stAngleViews(ModelName);
        }
        public static Boolean Create3rdAngleViews(IDrawingDocObject IDrawingDocinstance, String ModelName)
        {
            return IDrawingDocinstance.IDrawingDocInstance.Create3rdAngleViews(ModelName);
        }
        public static Boolean CreateDrawViewFromModelView(IDrawingDocObject IDrawingDocinstance, String ModelName, String ViewName, Double LocX, Double LocY, Double LocZ)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateDrawViewFromModelView(ModelName, ViewName, LocX, LocY, LocZ);
        }
        public static Boolean CreateUnfoldedViewAt(IDrawingDocObject IDrawingDocinstance, Double X, Double Y, Double Z)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateUnfoldedViewAt(X, Y, Z);
        }
        public static Boolean CreateText(IDrawingDocObject IDrawingDocinstance, String TextString, Double TextX, Double TextY, Double TextZ, Double TextHeight, Double TextAngle)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateText(TextString, TextX, TextY, TextZ, TextHeight, TextAngle);
        }
        public static void EditRebuild(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.EditRebuild();
        }
        public static void ViewFullPage(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.ViewFullPage();
        }
        public static void Dummy018(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.Dummy018();
        }
        public static void CreateSectionView(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.CreateSectionView();
        }
        public static void SheetNext(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.SheetNext();
        }
        public static void Dimensions(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.Dimensions();
        }
        public static void InsertGroup(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertGroup();
        }
        public static void SheetPrevious(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.SheetPrevious();
        }
        public static void AlignVert(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.AlignVert();
        }
        public static void AlignHorz(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.AlignHorz();
        }
        public static void InsertRefDim(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertRefDim();
        }
        public static void MakeSectionLine(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.MakeSectionLine();
        }
        public static void InsertBaseDim(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertBaseDim();
        }
        public static void EditSketch(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.EditSketch();
        }
        public static void CreateDetailView(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.CreateDetailView();
        }
        public static void CreateAuxiliaryView(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.CreateAuxiliaryView();
        }
        public static void StartDrawing(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.StartDrawing();
        }
        public static void EndDrawing(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.EndDrawing();
        }
        public static Object GetFirstView(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetFirstView();
        }
        public static IViewObject IGetFirstView(IDrawingDocObject IDrawingDocinstance)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.IGetFirstView());
        }
        public static Object GetInsertionPoint(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetInsertionPoint();
        }
        public static void AttachDimensions(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.AttachDimensions();
        }
        public static void InsertModelDimensions(IDrawingDocObject IDrawingDocinstance, Int32 Option)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertModelDimensions(Option);
        }
        public static void EditTemplate(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.EditTemplate();
        }
        public static void InsertOrdinate(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertOrdinate();
        }
        public static void UnsuppressView(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.UnsuppressView();
        }
        public static void HideShowDrawingViews(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.HideShowDrawingViews();
        }
        public static void SuppressView(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.SuppressView();
        }
        public static void AlignOrdinate(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.AlignOrdinate();
        }
        public static void SketchDim(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.SketchDim();
        }
        public static void CenterMark(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.CenterMark();
        }
        public static void EditSheet(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.EditSheet();
        }
        public static void InsertHorizontalOrdinate(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertHorizontalOrdinate();
        }
        public static void EditOrdinate(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.EditOrdinate();
        }
        public static void InsertVerticalOrdinate(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertVerticalOrdinate();
        }
        public static void ChangeOrdDir(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.ChangeOrdDir();
        }
        public static Int32 GetLineFontCount(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetLineFontCount();
        }
        public static String GetLineFontName(IDrawingDocObject IDrawingDocinstance, Int32 Index)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetLineFontName(Index);
        }
        public static Object GetLineFontInfo(IDrawingDocObject IDrawingDocinstance, Int32 Index)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetLineFontInfo(Index);
        }
        //public static void ICreateLinearDim(IDrawingDocObject IDrawingDocinstance, Double& P0, Double& P1, Double& P2, Double& P3, Double& P4, Double Angle, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot)
        //{
        //    return IDrawingDocinstance.IDrawingDocInstance.ICreateLinearDim(P0, P1, P2, P3, P4, Angle, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot);
        //}
        //public static void ICreateAngDim(IDrawingDocObject IDrawingDocinstance, Double& P0, Double& P1, Double& P2, Double& P3, Double& P4, Double& P5, Double& P6, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot)
        //{
        //    return IDrawingDocinstance.IDrawingDocInstance.ICreateAngDim(P0, P1, P2, P3, P4, P5, P6, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot);
        //}
        //public static void ICreateDiamDim(IDrawingDocObject IDrawingDocinstance, Double DimValue, Double& P0, Double& P1, Double& P2, Double& P3, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot)
        //{
        //    return IDrawingDocinstance.IDrawingDocInstance.ICreateDiamDim(DimValue, P0, P1, P2, P3, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot);
        //}
        public static Double IGetInsertionPoint(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.IGetInsertionPoint();
        }
        public static Object CreateCompoundNote(IDrawingDocObject IDrawingDocinstance, Double Height, Double X, Double Y, Double Z)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateCompoundNote(Height, X, Y, Z);
        }
        public static INoteObject ICreateCompoundNote(IDrawingDocObject IDrawingDocinstance, Double Height, Double X, Double Y, Double Z)
        {
            return new INoteObject(IDrawingDocinstance.IDrawingDocInstance.ICreateCompoundNote(Height, X, Y, Z));
        }
        public static Boolean CreateOrdinateDim(IDrawingDocObject IDrawingDocinstance, Object P0, Object P1, Object P2, Object P3, Object P4, Double Angle, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot)
        {
            return IDrawingDocinstance.IDrawingDocInstance.CreateOrdinateDim(P0, P1, P2, P3, P4, Angle, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot);
        }
        //public static void ICreateOrdinateDim(IDrawingDocObject IDrawingDocinstance, Double& P0, Double& P1, Double& P2, Double& P3, Double& P4, Double Angle, Double ArrowSize, String Text, Double TextHeight, Double WitnessGap, Double WitnessOvershoot)
        //{
        //    return IDrawingDocinstance.IDrawingDocInstance.ICreateOrdinateDim(P0, P1, P2, P3, P4, Angle, ArrowSize, Text, TextHeight, WitnessGap, WitnessOvershoot);
        //}
        public static void InsertNewNote(IDrawingDocObject IDrawingDocinstance, String Text, Boolean NoLeader, Boolean BalloonNote, Boolean BentLeader, Int16 ArrowStyle, Int16 LeaderSide)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertNewNote(Text, NoLeader, BalloonNote, BentLeader, ArrowStyle, LeaderSide);
        }
        public static Boolean AddCenterMark(IDrawingDocObject IDrawingDocinstance, Double CmSize, Boolean CmShowLines)
        {
            return IDrawingDocinstance.IDrawingDocInstance.AddCenterMark(CmSize, CmShowLines);
        }
        public static void InsertWeldSymbol(IDrawingDocObject IDrawingDocinstance, String Dim1, String Symbol, String Dim2, Boolean Symmetric, Boolean FieldWeld, Boolean ShowOtherSide, Boolean DashOnTop, Boolean Peripheral, Boolean HasProcess, String ProcessValue)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertWeldSymbol(Dim1, Symbol, Dim2, Symmetric, FieldWeld, ShowOtherSide, DashOnTop, Peripheral, HasProcess, ProcessValue);
        }
        public static Boolean InsertSurfaceFinishSymbol(IDrawingDocObject IDrawingDocinstance, Int32 SymType, Int32 LeaderType, Double LocX, Double LocY, Double LocZ, Int32 LaySymbol, Int32 ArrowType, String MachAllowance, String OtherVals, String ProdMethod, String SampleLen, String MaxRoughness, String MinRoughness, String RoughnessSpacing)
        {
            return IDrawingDocinstance.IDrawingDocInstance.InsertSurfaceFinishSymbol(SymType, LeaderType, LocX, LocY, LocZ, LaySymbol, ArrowType, MachAllowance, OtherVals, ProdMethod, SampleLen, MaxRoughness, MinRoughness, RoughnessSpacing);
        }
        public static Boolean ModifySurfaceFinishSymbol(IDrawingDocObject IDrawingDocinstance, Int32 SymType, Int32 LeaderType, Double LocX, Double LocY, Double LocZ, Int32 LaySymbol, Int32 ArrowType, String MachAllowance, String OtherVals, String ProdMethod, String SampleLen, String MaxRoughness, String MinRoughness, String RoughnessSpacing)
        {
            return IDrawingDocinstance.IDrawingDocInstance.ModifySurfaceFinishSymbol(SymType, LeaderType, LocX, LocY, LocZ, LaySymbol, ArrowType, MachAllowance, OtherVals, ProdMethod, SampleLen, MaxRoughness, MinRoughness, RoughnessSpacing);
        }
        public static Object GetCurrentSheet(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.GetCurrentSheet();
        }
        public static ISheetObject IGetCurrentSheet(IDrawingDocObject IDrawingDocinstance)
        {
            return new ISheetObject(IDrawingDocinstance.IDrawingDocInstance.IGetCurrentSheet());
        }
        public static void CreateConstructionGeometry(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.CreateConstructionGeometry();
        }
        public static void ViewDisplayHidden(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.ViewDisplayHidden();
        }
        public static void InsertBreakHorizontal(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertBreakHorizontal();
        }
        public static void ViewDisplayWireframe(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.ViewDisplayWireframe();
        }
        public static void BreakLineZigZagCut(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.BreakLineZigZagCut();
        }
        public static void BreakView(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.BreakView();
        }
        public static void ViewDisplayHiddengreyed(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.ViewDisplayHiddengreyed();
        }
        public static void ViewTangentEdges(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.ViewTangentEdges();
        }
        public static void BreakLineSplineCut(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.BreakLineSplineCut();
        }
        public static void InsertBreakVertical(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertBreakVertical();
        }
        public static void UnBreakView(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.UnBreakView();
        }
        public static void BreakLineStraightCut(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.BreakLineStraightCut();
        }
        public static void InsertDatumTag(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.InsertDatumTag();
        }
        public static void ToggleGrid(IDrawingDocObject IDrawingDocinstance)
        {
            IDrawingDocinstance.IDrawingDocInstance.ToggleGrid();
        }
        public static Boolean HiddenViewsVisible(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.HiddenViewsVisible;
        }
        public static Boolean AutomaticViewUpdate(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.AutomaticViewUpdate;
        }
        public static Object ActiveDrawingView(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.ActiveDrawingView;
        }
        public static IViewObject IActiveDrawingView(IDrawingDocObject IDrawingDocinstance)
        {
            return new IViewObject(IDrawingDocinstance.IDrawingDocInstance.IActiveDrawingView);
        }
        public static ISheetObject Sheet(IDrawingDocObject IDrawingDocinstance, string Name)
        {
            return new ISheetObject(IDrawingDocinstance.IDrawingDocInstance.Sheet[Name]);
        }
        public static Int32 BackgroundProcessingOption(IDrawingDocObject IDrawingDocinstance)
        {
            return IDrawingDocinstance.IDrawingDocInstance.BackgroundProcessingOption;
        }
    }
}