using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class IModelDocObject
    {
        public IModelDoc IModelDocInstance { get; set; }
        public IModelDocObject(IModelDoc IModelDocinstance)
        {
            IModelDocInstance = IModelDocinstance;
        }
    }

    /*
     * ModelDoc inteface ,not use 
     */

    //public static class IModelDocInterface
    //{
    //    public static IPropertyManagerPageObject GetPropertyManagerPage(IModelDocObject IModelDocinstance, Int32 DialogId, String Title, Object Handler)
    //    {
    //        return new IPropertyManagerPageObject(IModelDocinstance.IModelDocInstance.GetPropertyManagerPage(DialogId, Title, Handler));
    //    }
    //    public static void AlignOrdinate(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AlignOrdinate();
    //    }
    //    public static void EditOrdinate(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditOrdinate();
    //    }
    //    public static Boolean ReattachOrdinate(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ReattachOrdinate();
    //    }
    //    public static Object EditBalloonProperties(IModelDocObject IModelDocinstance, Int32 Style, Int32 Size, Int32 UpperTextStyle, String UpperText, Int32 LowerTextStyle, String LowerText)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditBalloonProperties(Style, Size, UpperTextStyle, UpperText, LowerTextStyle, LowerText);
    //    }
    //    public static Boolean EditDimensionProperties2(IModelDocObject IModelDocinstance, Int32 TolType, Double TolMax, Double TolMin, String TolMaxFit, String TolMinFit, Boolean UseDocPrec, Int32 Precision, Int32 ArrowsIn, Boolean UseDocArrows, Int32 Arrow1, Int32 Arrow2, String PrefixText, String SuffixText, Boolean ShowValue, String CalloutText1, String CalloutText2, Boolean CenterText)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditDimensionProperties2(TolType, TolMax, TolMin, TolMaxFit, TolMinFit, UseDocPrec, Precision, ArrowsIn, UseDocArrows, Arrow1, Arrow2, PrefixText, SuffixText, ShowValue, CalloutText1, CalloutText2, CenterText);
    //    }
    //    public static void InsertSheetMetalClosedCorner(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSheetMetalClosedCorner();
    //    }
    //    public static Boolean SketchUseEdge2(IModelDocObject IModelDocinstance, Boolean Chain)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchUseEdge2(Chain);
    //    }
    //    public static Boolean SketchOffsetEntities2(IModelDocObject IModelDocinstance, Double Offset, Boolean BothDirections, Boolean Chain)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchOffsetEntities2(Offset, BothDirections, Chain);
    //    }
    //    public static Boolean SketchOffset2(IModelDocObject IModelDocinstance, Double Offset, Boolean BothDirections, Boolean Chain)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchOffset2(Offset, BothDirections, Chain);
    //    }
    //    public static Object AddDimension2(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddDimension2(X, Y, Z);
    //    }
    //    public static IDisplayDimensionObject IAddDimension2(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return new IDisplayDimensionObject(IModelDocinstance.IModelDocInstance.IAddDimension2(X, Y, Z));
    //    }
    //    public static Object AddHorizontalDimension2(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddHorizontalDimension2(X, Y, Z);
    //    }
    //    public static IDisplayDimensionObject IAddHorizontalDimension2(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return new IDisplayDimensionObject(IModelDocinstance.IModelDocInstance.IAddHorizontalDimension2(X, Y, Z));
    //    }
    //    public static Object AddVerticalDimension2(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddVerticalDimension2(X, Y, Z);
    //    }
    //    public static IDisplayDimensionObject IAddVerticalDimension2(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return new IDisplayDimensionObject(IModelDocinstance.IModelDocInstance.IAddVerticalDimension2(X, Y, Z));
    //    }
    //    public static Object AddRadialDimension2(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddRadialDimension2(X, Y, Z);
    //    }
    //    public static IDisplayDimensionObject IAddRadialDimension2(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return new IDisplayDimensionObject(IModelDocinstance.IModelDocInstance.IAddRadialDimension2(X, Y, Z));
    //    }
    //    public static Object AddDiameterDimension2(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddDiameterDimension2(X, Y, Z);
    //    }
    //    public static IDisplayDimensionObject IAddDiameterDimension2(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return new IDisplayDimensionObject(IModelDocinstance.IModelDocInstance.IAddDiameterDimension2(X, Y, Z));
    //    }
    //    public static Object GetUserUnit(IModelDocObject IModelDocinstance, Int32 UnitType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetUserUnit(UnitType);
    //    }
    //    public static IUserUnitObject IGetUserUnit(IModelDocObject IModelDocinstance, Int32 UnitType)
    //    {
    //        return new IUserUnitObject(IModelDocinstance.IModelDocInstance.IGetUserUnit(UnitType));
    //    }
    //    public static Object InsertWeldSymbol3(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertWeldSymbol3();
    //    }
    //    public static IWeldSymbolObject IInsertWeldSymbol3(IModelDocObject IModelDocinstance)
    //    {
    //        return new IWeldSymbolObject(IModelDocinstance.IModelDocInstance.IInsertWeldSymbol3());
    //    }
    //    public static Int32 SaveAs3(IModelDocObject IModelDocinstance, String NewName, Int32 SaveAsVersion, Int32 Options)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SaveAs3(NewName, SaveAsVersion, Options);
    //    }
    //    public static String GetUserPreferenceStringValue(IModelDocObject IModelDocinstance, Int32 UserPreference)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetUserPreferenceStringValue(UserPreference);
    //    }
    //    public static Boolean SetUserPreferenceStringValue(IModelDocObject IModelDocinstance, Int32 UserPreference, String Value)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetUserPreferenceStringValue(UserPreference, Value);
    //    }
    //    public static void DeleteDesignTable(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeleteDesignTable();
    //    }
    //    public static Boolean EditRebuild3(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditRebuild3();
    //    }
    //    public static Boolean ForceRebuild3(IModelDocObject IModelDocinstance, Boolean TopOnly)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ForceRebuild3(TopOnly);
    //    }
    //    public static Object GetDependencies2(IModelDocObject IModelDocinstance, Boolean Traverseflag, Boolean Searchflag, Boolean AddReadOnlyInfo)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetDependencies2(Traverseflag, Searchflag, AddReadOnlyInfo);
    //    }
    //    public static String IGetDependencies2(IModelDocObject IModelDocinstance, Boolean Traverseflag, Boolean Searchflag, Boolean AddReadOnlyInfo)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetDependencies2(Traverseflag, Searchflag, AddReadOnlyInfo);
    //    }
    //    public static Int32 IGetNumDependencies2(IModelDocObject IModelDocinstance, Boolean Traverseflag, Boolean Searchflag, Boolean AddReadOnlyInfo)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetNumDependencies2(Traverseflag, Searchflag, AddReadOnlyInfo);
    //    }
    //    public static void InsertScale(IModelDocObject IModelDocinstance, Double ScaleFactor_x, Double ScaleFactor_y, Double ScaleFactor_z, Boolean IsUniform, Int32 ScaleType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertScale(ScaleFactor_x, ScaleFactor_y, ScaleFactor_z, IsUniform, ScaleType);
    //    }
    //    public static void LockAllExternalReferences(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.LockAllExternalReferences();
    //    }
    //    public static void UnlockAllExternalReferences(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.UnlockAllExternalReferences();
    //    }
    //    public static void BreakAllExternalReferences(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.BreakAllExternalReferences();
    //    }
    //    public static Boolean EditDimensionProperties(IModelDocObject IModelDocinstance, Int32 TolType, Double TolMax, Double TolMin, String TolMaxFit, String TolMinFit, Boolean UseDocPrec, Int32 Precision, Int32 ArrowsIn, Boolean UseDocArrows, Int32 Arrow1, Int32 Arrow2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditDimensionProperties(TolType, TolMax, TolMin, TolMaxFit, TolMinFit, UseDocPrec, Precision, ArrowsIn, UseDocArrows, Arrow1, Arrow2);
    //    }
    //    public static Boolean SketchPolygon(IModelDocObject IModelDocinstance, Double XCenter, Double YCenter, Double XEdge, Double YEdge, Int32 NSides, Boolean BInscribed)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchPolygon(XCenter, YCenter, XEdge, YEdge, NSides, BInscribed);
    //    }
    //    public static Int32 GetBlockingState(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetBlockingState();
    //    }
    //    public static Object CreateFeatureMgrView3(IModelDocObject IModelDocinstance, Int32& Bitmap, String ToolTip, Int32 WhichPane)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateFeatureMgrView3(Bitmap, ToolTip, WhichPane);
    //    }
    //    public static IFeatMgrViewObject ICreateFeatureMgrView3(IModelDocObject IModelDocinstance, Int32& Bitmap, String ToolTip, Int32 WhichPane)
    //    {
    //        return new IFeatMgrViewObject(IModelDocinstance.IModelDocInstance.ICreateFeatureMgrView3(Bitmap, ToolTip, WhichPane));
    //    }
    //    public static Boolean AddFeatureMgrView3(IModelDocObject IModelDocinstance, Int32& Bitmap, Int32& AppView, String ToolTip, Int32 WhichPane)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddFeatureMgrView3(Bitmap, AppView, ToolTip, WhichPane);
    //    }
    //    public static Object CreatePlaneAtOffset2(IModelDocObject IModelDocinstance, Double Val, Boolean FlipDir)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreatePlaneAtOffset2(Val, FlipDir);
    //    }
    //    public static IRefPlaneObject ICreatePlaneAtOffset2(IModelDocObject IModelDocinstance, Double Val, Boolean FlipDir)
    //    {
    //        return new IRefPlaneObject(IModelDocinstance.IModelDocInstance.ICreatePlaneAtOffset2(Val, FlipDir));
    //    }
    //    public static Object CreatePlaneAtAngle2(IModelDocObject IModelDocinstance, Double Val, Boolean FlipDir)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreatePlaneAtAngle2(Val, FlipDir);
    //    }
    //    public static IRefPlaneObject ICreatePlaneAtAngle2(IModelDocObject IModelDocinstance, Double Val, Boolean FlipDir)
    //    {
    //        return new IRefPlaneObject(IModelDocinstance.IModelDocInstance.ICreatePlaneAtAngle2(Val, FlipDir));
    //    }
    //    public static Object CreatePlaneThru3Points2(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreatePlaneThru3Points2();
    //    }
    //    public static IRefPlaneObject ICreatePlaneThru3Points2(IModelDocObject IModelDocinstance)
    //    {
    //        return new IRefPlaneObject(IModelDocinstance.IModelDocInstance.ICreatePlaneThru3Points2());
    //    }
    //    public static Object CreatePlanePerCurveAndPassPoint2(IModelDocObject IModelDocinstance, Boolean OrigAtCurve)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreatePlanePerCurveAndPassPoint2(OrigAtCurve);
    //    }
    //    public static IRefPlaneObject ICreatePlanePerCurveAndPassPoint2(IModelDocObject IModelDocinstance, Boolean OrigAtCurve)
    //    {
    //        return new IRefPlaneObject(IModelDocinstance.IModelDocInstance.ICreatePlanePerCurveAndPassPoint2(OrigAtCurve));
    //    }
    //    public static Object CreatePlaneAtSurface2(IModelDocObject IModelDocinstance, Int32 InterIndex, Boolean ProjOpt, Boolean ReverseDir, Boolean NormalPlane, Double Angle)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreatePlaneAtSurface2(InterIndex, ProjOpt, ReverseDir, NormalPlane, Angle);
    //    }
    //    public static IRefPlaneObject ICreatePlaneAtSurface2(IModelDocObject IModelDocinstance, Int32 InterIndex, Boolean ProjOpt, Boolean ReverseDir, Boolean NormalPlane, Double Angle)
    //    {
    //        return new IRefPlaneObject(IModelDocinstance.IModelDocInstance.ICreatePlaneAtSurface2(InterIndex, ProjOpt, ReverseDir, NormalPlane, Angle));
    //    }
    //    public static Int32 GetUserPreferenceIntegerValue(IModelDocObject IModelDocinstance, Int32 UserPreferenceValue)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetUserPreferenceIntegerValue(UserPreferenceValue);
    //    }
    //    public static Boolean SetUserPreferenceIntegerValue(IModelDocObject IModelDocinstance, Int32 UserPreferenceValue, Int32 Value)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetUserPreferenceIntegerValue(UserPreferenceValue, Value);
    //    }
    //    public static Object GetUserPreferenceTextFormat(IModelDocObject IModelDocinstance, Int32 UserPreferenceValue)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetUserPreferenceTextFormat(UserPreferenceValue);
    //    }
    //    public static ITextFormatObject IGetUserPreferenceTextFormat(IModelDocObject IModelDocinstance, Int32 UserPreferenceValue)
    //    {
    //        return new ITextFormatObject(IModelDocinstance.IModelDocInstance.IGetUserPreferenceTextFormat(UserPreferenceValue));
    //    }
    //    public static Boolean SetUserPreferenceTextFormat(IModelDocObject IModelDocinstance, Int32 UserPreferenceValue, Object Value)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetUserPreferenceTextFormat(UserPreferenceValue, Value);
    //    }
    //    public static Boolean ISetUserPreferenceTextFormat(IModelDocObject IModelDocinstance, Int32 UserPreferenceValue, TextFormatObject Value)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ISetUserPreferenceTextFormat(UserPreferenceValue, Value);
    //    }
    //    public static void InsertRib2(IModelDocObject IModelDocinstance, Boolean Is2Sided, Boolean ReverseThicknessDir, Double Thickness, Int32 ReferenceEdgeIndex, Boolean ReverseMaterialDir, Boolean IsDrafted, Boolean DraftOutward, Double DraftAngle, Boolean IsNormToSketch)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertRib2(Is2Sided, ReverseThicknessDir, Thickness, ReferenceEdgeIndex, ReverseMaterialDir, IsDrafted, DraftOutward, DraftAngle, IsNormToSketch);
    //    }
    //    public static Boolean InsertObjectFromFile(IModelDocObject IModelDocinstance, String FilePath, Boolean CreateLink, Double Xx, Double Yy, Double Zz)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertObjectFromFile(FilePath, CreateLink, Xx, Yy, Zz);
    //    }
    //    public static void InspectCurvature(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InspectCurvature();
    //    }
    //    public static void RemoveInspectCurvature(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.RemoveInspectCurvature();
    //    }
    //    public static Object InsertDatumTag2(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertDatumTag2();
    //    }
    //    public static IDatumTagObject IInsertDatumTag2(IModelDocObject IModelDocinstance)
    //    {
    //        return new IDatumTagObject(IModelDocinstance.IModelDocInstance.IInsertDatumTag2());
    //    }
    //    public static Int32 ActivateFeatureMgrView(IModelDocObject IModelDocinstance, Int32& AppView)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ActivateFeatureMgrView(AppView);
    //    }
    //    public static void FeatureSketchDrivenPattern(IModelDocObject IModelDocinstance, Boolean UseCentroid)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureSketchDrivenPattern(UseCentroid);
    //    }
    //    public static void HideShowBodies(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.HideShowBodies();
    //    }
    //    public static void HideSolidBody(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.HideSolidBody();
    //    }
    //    public static void ShowSolidBody(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ShowSolidBody();
    //    }
    //    public static void InsertFramePoint(IModelDocObject IModelDocinstance, Double Xx, Double Yy, Double Zz)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertFramePoint(Xx, Yy, Zz);
    //    }
    //    public static void LockFramePoint(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.LockFramePoint();
    //    }
    //    public static void UnlockFramePoint(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.UnlockFramePoint();
    //    }
    //    public static Object InsertGtol(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertGtol();
    //    }
    //    public static IGtolObject IInsertGtol(IModelDocObject IModelDocinstance)
    //    {
    //        return new IGtolObject(IModelDocinstance.IModelDocInstance.IInsertGtol());
    //    }
    //    public static Boolean DeActivateFeatureMgrView(IModelDocObject IModelDocinstance, Int32& AppView)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeActivateFeatureMgrView(AppView);
    //    }
    //    public static Object InsertNote(IModelDocObject IModelDocinstance, String Text)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertNote(Text);
    //    }
    //    public static INoteObject IInsertNote(IModelDocObject IModelDocinstance, String Text)
    //    {
    //        return new INoteObject(IModelDocinstance.IModelDocInstance.IInsertNote(Text));
    //    }
    //    public static void SetSaveAsFileName(IModelDocObject IModelDocinstance, String FileName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetSaveAsFileName(FileName);
    //    }
    //    public static void ClosePrintPreview(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ClosePrintPreview();
    //    }
    //    public static void HideComponent2(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.HideComponent2();
    //    }
    //    public static void ShowComponent2(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ShowComponent2();
    //    }
    //    public static Boolean SaveBMP(IModelDocObject IModelDocinstance, String FileNameIn, Int32 WidthIn, Int32 HeightIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SaveBMP(FileNameIn, WidthIn, HeightIn);
    //    }
    //    public static void InsertSketch2(IModelDocObject IModelDocinstance, Boolean UpdateEditRebuild)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSketch2(UpdateEditRebuild);
    //    }
    //    public static void Insert3DSketch2(IModelDocObject IModelDocinstance, Boolean UpdateEditRebuild)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Insert3DSketch2(UpdateEditRebuild);
    //    }
    //    public static void InsertDeleteHole(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertDeleteHole();
    //    }
    //    public static void PreTrimSurface(IModelDocObject IModelDocinstance, Boolean BMutualTrimIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.PreTrimSurface(BMutualTrimIn);
    //    }
    //    public static void PostTrimSurface(IModelDocObject IModelDocinstance, Boolean BSewSurfaceIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.PostTrimSurface(BSewSurfaceIn);
    //    }
    //    public static void SketchConvertIsoCurves(IModelDocObject IModelDocinstance, Double PercentRatio, Boolean VORuDir, Boolean DoConstrain, Boolean SkipHoles)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchConvertIsoCurves(PercentRatio, VORuDir, DoConstrain, SkipHoles);
    //    }
    //    public static void SelectLoop(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectLoop();
    //    }
    //    public static void InsertSheetMetalBaseFlange(IModelDocObject IModelDocinstance, Double Thickness, Boolean ThickenDir, Double Radius, Double ExtrudeDist1, Double ExtrudeDist2, Boolean FlipExtruDir, Int32 EndCondition1, Int32 EndCondition2, Int32 DirToUse)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSheetMetalBaseFlange(Thickness, ThickenDir, Radius, ExtrudeDist1, ExtrudeDist2, FlipExtruDir, EndCondition1, EndCondition2, DirToUse);
    //    }
    //    public static void InsertSheetMetalFold(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSheetMetalFold();
    //    }
    //    public static void InsertSheetMetalUnfold(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSheetMetalUnfold();
    //    }
    //    public static void InsertSheetMetalMiterFlange(IModelDocObject IModelDocinstance, Boolean UseReliefRatio, Boolean UseDefaultGap, Boolean UseAutoRelief, Double GlobalRadius, Double RipGap, Double AutoReliefRatio, Double AutoReliefWidth, Double AutoReliefDepth, Int32 ReliefType, Int32 RipLocation, Boolean TrimSideBends)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSheetMetalMiterFlange(UseReliefRatio, UseDefaultGap, UseAutoRelief, GlobalRadius, RipGap, AutoReliefRatio, AutoReliefWidth, AutoReliefDepth, ReliefType, RipLocation, TrimSideBends);
    //    }
    //    public static void CreateGroup(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateGroup();
    //    }
    //    public static void RemoveItemsFromGroup(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.RemoveItemsFromGroup();
    //    }
    //    public static void RemoveGroups(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.RemoveGroups();
    //    }
    //    public static Object InsertBOMBalloon2(IModelDocObject IModelDocinstance, Int32 Style, Int32 Size, Int32 UpperTextStyle, String UpperText, Int32 LowerTextStyle, String LowerText)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertBOMBalloon2(Style, Size, UpperTextStyle, UpperText, LowerTextStyle, LowerText);
    //    }
    //    public static INoteObject IInsertBOMBalloon2(IModelDocObject IModelDocinstance, Int32 Style, Int32 Size, Int32 UpperTextStyle, String UpperText, Int32 LowerTextStyle, String LowerText)
    //    {
    //        return new INoteObject(IModelDocinstance.IModelDocInstance.IInsertBOMBalloon2(Style, Size, UpperTextStyle, UpperText, LowerTextStyle, LowerText));
    //    }
    //    public static void EditRedo(IModelDocObject IModelDocinstance, UInt32 NSteps)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditRedo(NSteps);
    //    }
    //    public static void InsertProtrusionBlend4(IModelDocObject IModelDocinstance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational, Double TessToleranceFactor, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertProtrusionBlend4(Closed, KeepTangency, ForceNonRational, TessToleranceFactor, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType);
    //    }
    //    public static void InsertCutBlend4(IModelDocObject IModelDocinstance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational, Double TessToleranceFactor, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCutBlend4(Closed, KeepTangency, ForceNonRational, TessToleranceFactor, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType);
    //    }
    //    public static void InsertProtrusionSwept4(IModelDocObject IModelDocinstance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertProtrusionSwept4(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType);
    //    }
    //    public static void InsertCutSwept4(IModelDocObject IModelDocinstance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCutSwept4(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType);
    //    }
    //    public static void SelectTangency(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectTangency();
    //    }
    //    public static Boolean InsertBendTableOpen(IModelDocObject IModelDocinstance, String FileName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertBendTableOpen(FileName);
    //    }
    //    public static Boolean InsertBendTableNew(IModelDocObject IModelDocinstance, String FileName, String Units, String Type)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertBendTableNew(FileName, Units, Type);
    //    }
    //    public static void InsertBendTableEdit(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertBendTableEdit();
    //    }
    //    public static void DeleteBendTable(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeleteBendTable();
    //    }
    //    public static void InsertSheetMetal3dBend(IModelDocObject IModelDocinstance, Double Angle, Double Radius, Boolean FlipDir, Int16 BendPos)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSheetMetal3dBend(Angle, Radius, FlipDir, BendPos);
    //    }
    //    public static Boolean CreateTangentArc2(IModelDocObject IModelDocinstance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z, Int32 ArcTypeIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateTangentArc2(P1x, P1y, P1z, P2x, P2y, P2z, ArcTypeIn);
    //    }
    //    public static Object GetMassProperties2(IModelDocObject IModelDocinstance, Int32& Status)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetMassProperties2(Status);
    //    }
    //    public static Double IGetMassProperties2(IModelDocObject IModelDocinstance, Int32& Status)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetMassProperties2(Status);
    //    }
    //    public static void SketchChamfer(IModelDocObject IModelDocinstance, Double AngleORdist, Double Dist1, Int32 Options)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchChamfer(AngleORdist, Dist1, Options);
    //    }
    //    public static void FeatureCut4(IModelDocObject IModelDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Int32 KeepPieceIndex, Boolean NormalCut)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureCut4(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, KeepPieceIndex, NormalCut);
    //    }
    //    public static Boolean GetAmbientLightProperties(IModelDocObject IModelDocinstance, String Name, Double& Ambient, Double& Diffuse, Double& Specular, Int32& Colour, Boolean& Enabled, Boolean& Fixed)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetAmbientLightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed);
    //    }
    //    public static Boolean SetPointLightProperties(IModelDocObject IModelDocinstance, String Name, Double Ambient, Double Diffuse, Double Specular, Int32 Colour, Boolean Enabled, Boolean Fixed, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetPointLightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed, X, Y, Z);
    //    }
    //    public static Boolean GetPointLightProperties(IModelDocObject IModelDocinstance, String Name, Double& Ambient, Double& Diffuse, Double& Specular, Int32& Colour, Boolean& Enabled, Boolean& Fixed, Double& X, Double& Y, Double& Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetPointLightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed, X, Y, Z);
    //    }
    //    public static Boolean SetDirectionLightProperties(IModelDocObject IModelDocinstance, String Name, Double Ambient, Double Diffuse, Double Specular, Int32 Colour, Boolean Enabled, Boolean Fixed, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetDirectionLightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed, X, Y, Z);
    //    }
    //    public static Boolean GetDirectionLightProperties(IModelDocObject IModelDocinstance, String Name, Double& Ambient, Double& Diffuse, Double& Specular, Int32& Colour, Boolean& Enabled, Boolean& Fixed, Double& X, Double& Y, Double& Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetDirectionLightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed, X, Y, Z);
    //    }
    //    public static Boolean SetSpotlightProperties(IModelDocObject IModelDocinstance, String Name, Double Ambient, Double Diffuse, Double Specular, Int32 Colour, Boolean Enabled, Boolean Fixed, Double Posx, Double Posy, Double Posz, Double Targetx, Double Targety, Double Targetz, Double ConeAngle)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetSpotlightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed, Posx, Posy, Posz, Targetx, Targety, Targetz, ConeAngle);
    //    }
    //    public static Boolean GetSpotlightProperties(IModelDocObject IModelDocinstance, String Name, Double& Ambient, Double& Diffuse, Double& Specular, Int32& Colour, Boolean& Enabled, Boolean& Fixed, Double& X, Double& Y, Double& Z, Double& Targetx, Double& Targety, Double& Targetz, Double& ConeAngle)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetSpotlightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed, X, Y, Z, Targetx, Targety, Targetz, ConeAngle);
    //    }
    //    public static void SplitOpenSegment(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SplitOpenSegment(X, Y, Z);
    //    }
    //    public static void AutoInferToggle(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AutoInferToggle();
    //    }
    //    public static void SketchRectangleAtAnyAngle(IModelDocObject IModelDocinstance, Double Val1, Double Val2, Double Z1, Double Val3, Double Val4, Double Z2, Double Val3x, Double Val3y, Double Z3, Boolean Val5)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchRectangleAtAnyAngle(Val1, Val2, Z1, Val3, Val4, Z2, Val3x, Val3y, Z3, Val5);
    //    }
    //    public static Boolean CreateCircularSketchStepAndRepeat(IModelDocObject IModelDocinstance, Double ArcRadius, Double ArcAngle, Int32 PatternNum, Double PatternSpacing, Boolean PatternRotate, String DeleteInstances)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateCircularSketchStepAndRepeat(ArcRadius, ArcAngle, PatternNum, PatternSpacing, PatternRotate, DeleteInstances);
    //    }
    //    public static void SplitClosedSegment(IModelDocObject IModelDocinstance, Double X0, Double Y0, Double Z0, Double X1, Double Y1, Double Z1)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SplitClosedSegment(X0, Y0, Z0, X1, Y1, Z1);
    //    }
    //    public static Boolean IsLightLockedToModel(IModelDocObject IModelDocinstance, Int32 LightId)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IsLightLockedToModel(LightId);
    //    }
    //    public static Boolean LockLightToModel(IModelDocObject IModelDocinstance, Int32 LightId, Boolean Fix)
    //    {
    //        return IModelDocinstance.IModelDocInstance.LockLightToModel(LightId, Fix);
    //    }
    //    public static Int32 FeatureFillet3(IModelDocObject IModelDocinstance, Double R1, Boolean Propagate, Int32 Ftyp, Boolean VarRadTyp, Int32 OverflowType, Int32 NRadii, Object Radii, Boolean UseHelpPoint, Boolean UseTangentHoldLine)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureFillet3(R1, Propagate, Ftyp, VarRadTyp, OverflowType, NRadii, Radii, UseHelpPoint, UseTangentHoldLine);
    //    }
    //    public static Int32 IFeatureFillet3(IModelDocObject IModelDocinstance, Double R1, Boolean Propagate, Int32 Ftyp, Boolean VarRadTyp, Int32 OverflowType, Int32 NRadii, Double& Radii, Boolean UseHelpPoint, Boolean UseTangentHoldLine)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IFeatureFillet3(R1, Propagate, Ftyp, VarRadTyp, OverflowType, NRadii, Radii, UseHelpPoint, UseTangentHoldLine);
    //    }
    //    public static void InsertConnectionPoint(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertConnectionPoint();
    //    }
    //    public static void InsertRoutePoint(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertRoutePoint();
    //    }
    //    public static void FeatureBossThicken2(IModelDocObject IModelDocinstance, Double Thickness, Int32 Direction, Int32 FaceIndex, Boolean FillVolume)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureBossThicken2(Thickness, Direction, FaceIndex, FillVolume);
    //    }
    //    public static void FeatureCutThicken2(IModelDocObject IModelDocinstance, Double Thickness, Int32 Direction, Int32 FaceIndex, Boolean FillVolume)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureCutThicken2(Thickness, Direction, FaceIndex, FillVolume);
    //    }
    //    public static Object GetConfigurationByName(IModelDocObject IModelDocinstance, String Name)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetConfigurationByName(Name);
    //    }
    //    public static IConfigurationObject IGetConfigurationByName(IModelDocObject IModelDocinstance, String Name)
    //    {
    //        return new IConfigurationObject(IModelDocinstance.IModelDocInstance.IGetConfigurationByName(Name));
    //    }
    //    public static Object CreatePoint2(IModelDocObject IModelDocinstance, Double PointX, Double PointY, Double PointZ)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreatePoint2(PointX, PointY, PointZ);
    //    }
    //    public static ISketchPointObject ICreatePoint2(IModelDocObject IModelDocinstance, Double PointX, Double PointY, Double PointZ)
    //    {
    //        return new ISketchPointObject(IModelDocinstance.IModelDocInstance.ICreatePoint2(PointX, PointY, PointZ));
    //    }
    //    public static Object CreateLine2(IModelDocObject IModelDocinstance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateLine2(P1x, P1y, P1z, P2x, P2y, P2z);
    //    }
    //    public static ISketchSegmentObject ICreateLine2(IModelDocObject IModelDocinstance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z)
    //    {
    //        return new ISketchSegmentObject(IModelDocinstance.IModelDocInstance.ICreateLine2(P1x, P1y, P1z, P2x, P2y, P2z));
    //    }
    //    public static Object GetActiveSketch2(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetActiveSketch2();
    //    }
    //    public static ISketchObject IGetActiveSketch2(IModelDocObject IModelDocinstance)
    //    {
    //        return new ISketchObject(IModelDocinstance.IModelDocInstance.IGetActiveSketch2());
    //    }
    //    public static void DrawLightIcons(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DrawLightIcons();
    //    }
    //    public static Object GetLayerManager(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetLayerManager();
    //    }
    //    public static ILayerMgrObject IGetLayerManager(IModelDocObject IModelDocinstance)
    //    {
    //        return new ILayerMgrObject(IModelDocinstance.IModelDocInstance.IGetLayerManager());
    //    }
    //    public static Object CreateCircle2(IModelDocObject IModelDocinstance, Double XC, Double YC, Double Zc, Double Xp, Double Yp, Double Zp)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateCircle2(XC, YC, Zc, Xp, Yp, Zp);
    //    }
    //    public static ISketchSegmentObject ICreateCircle2(IModelDocObject IModelDocinstance, Double XC, Double YC, Double Zc, Double Xp, Double Yp, Double Zp)
    //    {
    //        return new ISketchSegmentObject(IModelDocinstance.IModelDocInstance.ICreateCircle2(XC, YC, Zc, Xp, Yp, Zp));
    //    }
    //    public static Object CreateCircleByRadius2(IModelDocObject IModelDocinstance, Double XC, Double YC, Double Zc, Double Radius)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateCircleByRadius2(XC, YC, Zc, Radius);
    //    }
    //    public static ISketchSegmentObject ICreateCircleByRadius2(IModelDocObject IModelDocinstance, Double XC, Double YC, Double Zc, Double Radius)
    //    {
    //        return new ISketchSegmentObject(IModelDocinstance.IModelDocInstance.ICreateCircleByRadius2(XC, YC, Zc, Radius));
    //    }
    //    public static Object CreateArc2(IModelDocObject IModelDocinstance, Double XC, Double YC, Double Zc, Double Xp1, Double Yp1, Double Zp1, Double Xp2, Double Yp2, Double Zp2, Int16 Direction)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateArc2(XC, YC, Zc, Xp1, Yp1, Zp1, Xp2, Yp2, Zp2, Direction);
    //    }
    //    public static ISketchSegmentObject ICreateArc2(IModelDocObject IModelDocinstance, Double XC, Double YC, Double Zc, Double Xp1, Double Yp1, Double Zp1, Double Xp2, Double Yp2, Double Zp2, Int16 Direction)
    //    {
    //        return new ISketchSegmentObject(IModelDocinstance.IModelDocInstance.ICreateArc2(XC, YC, Zc, Xp1, Yp1, Zp1, Xp2, Yp2, Zp2, Direction));
    //    }
    //    public static Object CreateEllipse2(IModelDocObject IModelDocinstance, Double CenterX, Double CenterY, Double CenterZ, Double MajorX, Double MajorY, Double MajorZ, Double MinorX, Double MinorY, Double MinorZ)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateEllipse2(CenterX, CenterY, CenterZ, MajorX, MajorY, MajorZ, MinorX, MinorY, MinorZ);
    //    }
    //    public static ISketchSegmentObject ICreateEllipse2(IModelDocObject IModelDocinstance, Double CenterX, Double CenterY, Double CenterZ, Double MajorX, Double MajorY, Double MajorZ, Double MinorX, Double MinorY, Double MinorZ)
    //    {
    //        return new ISketchSegmentObject(IModelDocinstance.IModelDocInstance.ICreateEllipse2(CenterX, CenterY, CenterZ, MajorX, MajorY, MajorZ, MinorX, MinorY, MinorZ));
    //    }
    //    public static Object CreateEllipticalArc2(IModelDocObject IModelDocinstance, Double CenterX, Double CenterY, Double CenterZ, Double MajorX, Double MajorY, Double MajorZ, Double MinorX, Double MinorY, Double MinorZ, Double StartX, Double StartY, Double StartZ, Double EndX, Double EndY, Double EndZ)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateEllipticalArc2(CenterX, CenterY, CenterZ, MajorX, MajorY, MajorZ, MinorX, MinorY, MinorZ, StartX, StartY, StartZ, EndX, EndY, EndZ);
    //    }
    //    public static ISketchSegmentObject ICreateEllipticalArc2(IModelDocObject IModelDocinstance, Double CenterX, Double CenterY, Double CenterZ, Double MajorX, Double MajorY, Double MajorZ, Double MinorX, Double MinorY, Double MinorZ, Double StartX, Double StartY, Double StartZ, Double EndX, Double EndY, Double EndZ)
    //    {
    //        return new ISketchSegmentObject(IModelDocinstance.IModelDocInstance.ICreateEllipticalArc2(CenterX, CenterY, CenterZ, MajorX, MajorY, MajorZ, MinorX, MinorY, MinorZ, StartX, StartY, StartZ, EndX, EndY, EndZ));
    //    }
    //    public static Object CreateSpline(IModelDocObject IModelDocinstance, Object PointData)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateSpline(PointData);
    //    }
    //    public static ISketchSegmentObject ICreateSpline(IModelDocObject IModelDocinstance, Int32 PointCount, Double& PointData)
    //    {
    //        return new ISketchSegmentObject(IModelDocinstance.IModelDocInstance.ICreateSpline(PointCount, PointData));
    //    }
    //    public static void ViewZoomtofit2(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewZoomtofit2();
    //    }
    //    public static void SetInferenceMode(IModelDocObject IModelDocinstance, Boolean InferenceMode)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetInferenceMode(InferenceMode);
    //    }
    //    public static Boolean GetInferenceMode(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetInferenceMode();
    //    }
    //    public static Boolean SetTitle2(IModelDocObject IModelDocinstance, String NewTitle)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetTitle2(NewTitle);
    //    }
    //    public static Boolean SketchFillet2(IModelDocObject IModelDocinstance, Double Rad, Int16 ConstrainedCorners)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchFillet2(Rad, ConstrainedCorners);
    //    }
    //    public static Boolean IsTessellationValid(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IsTessellationValid();
    //    }
    //    public static void EditRoute(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditRoute();
    //    }
    //    public static void FileReload(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FileReload();
    //    }
    //    public static Object GetDesignTable(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetDesignTable();
    //    }
    //    public static IDesignTableObject IGetDesignTable(IModelDocObject IModelDocinstance)
    //    {
    //        return new IDesignTableObject(IModelDocinstance.IModelDocInstance.IGetDesignTable());
    //    }
    //    public static String GetEntityName(IModelDocObject IModelDocinstance, Object Entity)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetEntityName(Entity);
    //    }
    //    public static String IGetEntityName(IModelDocObject IModelDocinstance, EntityObject Entity)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetEntityName(Entity);
    //    }
    //    public static IModelDocObject IGetNext(IModelDocObject IModelDocinstance)
    //    {
    //        return new IModelDocObject(IModelDocinstance.IModelDocInstance.IGetNext());
    //    }
    //    public static Boolean ShowConfiguration2(IModelDocObject IModelDocinstance, String ConfigurationName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ShowConfiguration2(ConfigurationName);
    //    }
    //    public static Boolean AddConfiguration2(IModelDocObject IModelDocinstance, String Name, String Comment, String AlternateName, Boolean SuppressByDefault, Boolean HideByDefault, Boolean MinFeatureManager, Boolean InheritProperties, UInt32 Flags)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddConfiguration2(Name, Comment, AlternateName, SuppressByDefault, HideByDefault, MinFeatureManager, InheritProperties, Flags);
    //    }
    //    public static Boolean DeleteConfiguration2(IModelDocObject IModelDocinstance, String ConfigurationName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeleteConfiguration2(ConfigurationName);
    //    }
    //    public static Boolean EditConfiguration2(IModelDocObject IModelDocinstance, String Name, String NewName, String Comment, String AlternateName, Boolean SuppressByDefault, Boolean HideByDefault, Boolean MinFeatureManager, Boolean InheritProperties, UInt32 Flags)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditConfiguration2(Name, NewName, Comment, AlternateName, SuppressByDefault, HideByDefault, MinFeatureManager, InheritProperties, Flags);
    //    }
    //    public static Object CreateSplineByEqnParams(IModelDocObject IModelDocinstance, Object ParamsIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateSplineByEqnParams(ParamsIn);
    //    }
    //    public static ISketchSegmentObject ICreateSplineByEqnParams(IModelDocObject IModelDocinstance, Int32& PropArray, Double& KnotsArray, Double& CntrlPntCoordArray)
    //    {
    //        return new ISketchSegmentObject(IModelDocinstance.IModelDocInstance.ICreateSplineByEqnParams(PropArray, KnotsArray, CntrlPntCoordArray));
    //    }
    //    public static Object CreateFeatureMgrView2(IModelDocObject IModelDocinstance, Int32& Bitmap, String ToolTip)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateFeatureMgrView2(Bitmap, ToolTip);
    //    }
    //    public static IFeatMgrViewObject ICreateFeatureMgrView2(IModelDocObject IModelDocinstance, Int32& Bitmap, String ToolTip)
    //    {
    //        return new IFeatMgrViewObject(IModelDocinstance.IModelDocInstance.ICreateFeatureMgrView2(Bitmap, ToolTip));
    //    }
    //    public static Boolean AddFeatureMgrView2(IModelDocObject IModelDocinstance, Int32& Bitmap, Int32& AppView, String ToolTip)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddFeatureMgrView2(Bitmap, AppView, ToolTip);
    //    }
    //    public static void FeatureCut3(IModelDocObject IModelDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Int32 KeepPieceIndex)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureCut3(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, KeepPieceIndex);
    //    }
    //    public static Object GetFirstAnnotation2(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetFirstAnnotation2();
    //    }
    //    public static IAnnotationObject IGetFirstAnnotation2(IModelDocObject IModelDocinstance)
    //    {
    //        return new IAnnotationObject(IModelDocinstance.IModelDocInstance.IGetFirstAnnotation2());
    //    }
    //    public static void InsertExtendSurface(IModelDocObject IModelDocinstance, Boolean ExtendLinear, Int32 EndCondition, Double Distance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertExtendSurface(ExtendLinear, EndCondition, Distance);
    //    }
    //    public static void InsertTangencySurface(IModelDocObject IModelDocinstance, Boolean OneSide, Boolean IsFlip)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertTangencySurface(OneSide, IsFlip);
    //    }
    //    public static Object CreateSplinesByEqnParams(IModelDocObject IModelDocinstance, Object ParamsIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateSplinesByEqnParams(ParamsIn);
    //    }
    //    public static IEnumSketchSegmentsObject ICreateSplinesByEqnParams(IModelDocObject IModelDocinstance, Int32& PropArray, Double& KnotsArray, Double& CntrlPntCoordArray)
    //    {
    //        return new IEnumSketchSegmentsObject(IModelDocinstance.IModelDocInstance.ICreateSplinesByEqnParams(PropArray, KnotsArray, CntrlPntCoordArray));
    //    }
    //    public static Object CreateClippedSplines(IModelDocObject IModelDocinstance, Object ParamsIn, Double X1, Double Y1, Double X2, Double Y2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateClippedSplines(ParamsIn, X1, Y1, X2, Y2);
    //    }
    //    public static IEnumSketchSegmentsObject ICreateClippedSplines(IModelDocObject IModelDocinstance, Int32& PropArray, Double& KnotsArray, Double& CntrlPntCoordArray, Double X1, Double Y1, Double X2, Double Y2)
    //    {
    //        return new IEnumSketchSegmentsObject(IModelDocinstance.IModelDocInstance.ICreateClippedSplines(PropArray, KnotsArray, CntrlPntCoordArray, X1, Y1, X2, Y2));
    //    }
    //    public static Boolean EditSuppress2(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditSuppress2();
    //    }
    //    public static Boolean EditUnsuppress2(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditUnsuppress2();
    //    }
    //    public static Boolean EditUnsuppressDependent2(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditUnsuppressDependent2();
    //    }
    //    public static Boolean EditRollback2(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditRollback2();
    //    }
    //    public static void HideDimension(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.HideDimension();
    //    }
    //    public static void ShowFeatureDimensions(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ShowFeatureDimensions();
    //    }
    //    public static void HideFeatureDimensions(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.HideFeatureDimensions();
    //    }
    //    public static void Sketch3DIntersections(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Sketch3DIntersections();
    //    }
    //    public static Int32 FeatureFillet4(IModelDocObject IModelDocinstance, Double R1, Boolean Propagate, Boolean UniformRadius, Int32 Ftyp, Boolean VarRadTyp, Int32 OverflowType, Int32 NRadii, Object Radii, Boolean UseHelpPoint, Boolean UseTangentHoldLine, Boolean CornerType, Int32 SetbackDistCount, Object SetBackDistances)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureFillet4(R1, Propagate, UniformRadius, Ftyp, VarRadTyp, OverflowType, NRadii, Radii, UseHelpPoint, UseTangentHoldLine, CornerType, SetbackDistCount, SetBackDistances);
    //    }
    //    public static Int32 IFeatureFillet4(IModelDocObject IModelDocinstance, Double R1, Boolean Propagate, Boolean UniformRadius, Int32 Ftyp, Boolean VarRadTyp, Int32 OverflowType, Int32 NRadii, Double& Radii, Boolean UseHelpPoint, Boolean UseTangentHoldLine, Boolean CornerType, Int32 SetbackDistCount, Double& SetBackDistances)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IFeatureFillet4(R1, Propagate, UniformRadius, Ftyp, VarRadTyp, OverflowType, NRadii, Radii, UseHelpPoint, UseTangentHoldLine, CornerType, SetbackDistCount, SetBackDistances);
    //    }
    //    public static void InsertDeleteFace(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertDeleteFace();
    //    }
    //    public static Int32 SaveSilent(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SaveSilent();
    //    }
    //    public static Int32 SaveAsSilent(IModelDocObject IModelDocinstance, String NewName, Boolean SaveAsCopy)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SaveAsSilent(NewName, SaveAsCopy);
    //    }
    //    public static Boolean AddCustomInfo2(IModelDocObject IModelDocinstance, String FieldName, Int32 FieldType, String FieldValue)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddCustomInfo2(FieldName, FieldType, FieldValue);
    //    }
    //    public static Int32 GetCustomInfoType2(IModelDocObject IModelDocinstance, String FieldName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetCustomInfoType2(FieldName);
    //    }
    //    public static Boolean InsertRefPoint(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertRefPoint();
    //    }
    //    public static Int32 FeatureFillet2(IModelDocObject IModelDocinstance, Double R1, Boolean Propagate, Boolean Ftyp, Boolean VarRadTyp, Int32 OverflowType, Int32 NRadii, Object Radii)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureFillet2(R1, Propagate, Ftyp, VarRadTyp, OverflowType, NRadii, Radii);
    //    }
    //    public static Int32 IFeatureFillet2(IModelDocObject IModelDocinstance, Double R1, Boolean Propagate, Boolean Ftyp, Boolean VarRadTyp, Int32 OverflowType, Int32 NRadii, Double& Radii)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IFeatureFillet2(R1, Propagate, Ftyp, VarRadTyp, OverflowType, NRadii, Radii);
    //    }
    //    public static Object GetFirstAnnotation(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetFirstAnnotation();
    //    }
    //    public static IAnnotationObject IGetFirstAnnotation(IModelDocObject IModelDocinstance)
    //    {
    //        return new IAnnotationObject(IModelDocinstance.IModelDocInstance.IGetFirstAnnotation());
    //    }
    //    public static Boolean InsertCoordinateSystem(IModelDocObject IModelDocinstance, Boolean XFlippedIn, Boolean YFlippedIn, Boolean ZFlippedIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCoordinateSystem(XFlippedIn, YFlippedIn, ZFlippedIn);
    //    }
    //    public static Boolean GetToolbarVisibility(IModelDocObject IModelDocinstance, Int32 Toolbar)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetToolbarVisibility(Toolbar);
    //    }
    //    public static void SetToolbarVisibility(IModelDocObject IModelDocinstance, Int32 Toolbar, Boolean Visibility)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetToolbarVisibility(Toolbar, Visibility);
    //    }
    //    public static void ViewDispCoordinateSystems(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewDispCoordinateSystems();
    //    }
    //    public static void ViewDispTempRefaxes(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewDispTempRefaxes();
    //    }
    //    public static void ViewDispRefPoints(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewDispRefPoints();
    //    }
    //    public static void ViewDispOrigins(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewDispOrigins();
    //    }
    //    public static Object GetCoordinateSystemXformByName(IModelDocObject IModelDocinstance, String NameIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetCoordinateSystemXformByName(NameIn);
    //    }
    //    public static Double IGetCoordinateSystemXformByName(IModelDocObject IModelDocinstance, String NameIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetCoordinateSystemXformByName(NameIn);
    //    }
    //    public static String GetCurrentCoordinateSystemName(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetCurrentCoordinateSystemName();
    //    }
    //    public static IEnumModelViewsObject EnumModelViews(IModelDocObject IModelDocinstance)
    //    {
    //        return new IEnumModelViewsObject(IModelDocinstance.IModelDocInstance.EnumModelViews());
    //    }
    //    public static Boolean InsertCompositeCurve(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCompositeCurve();
    //    }
    //    public static void SketchParabola(IModelDocObject IModelDocinstance, Double Val1, Double Val2, Double Z1, Double Val3, Double Val4, Double Z2, Double Val5, Double Val6, Double Z3, Double Val7, Double Val8, Double Z4)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchParabola(Val1, Val2, Z1, Val3, Val4, Z2, Val5, Val6, Z3, Val7, Val8, Z4);
    //    }
    //    public static void InsertRadiateSurface(IModelDocObject IModelDocinstance, Double Distance, Boolean FlipDir, Boolean TangentPropagate)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertRadiateSurface(Distance, FlipDir, TangentPropagate);
    //    }
    //    public static void InsertSewRefSurface(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSewRefSurface();
    //    }
    //    public static Int32 InsertShape(IModelDocObject IModelDocinstance, Int32 PressureOn, Int32 TangentsOn, Double PressureGain, Double TangentGain, Double CurveSpringGain, Double Alpha, Double Beta, Double Gamma, Double Delta, Int32 Degree, Int32 Split, Int32 Tuning)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertShape(PressureOn, TangentsOn, PressureGain, TangentGain, CurveSpringGain, Alpha, Beta, Gamma, Delta, Degree, Split, Tuning);
    //    }
    //    public static void InsertMfDraft2(IModelDocObject IModelDocinstance, Double Angle, Boolean FlipDir, Boolean IsEdgeDraft, Int32 PropType, Boolean StepDraft)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertMfDraft2(Angle, FlipDir, IsEdgeDraft, PropType, StepDraft);
    //    }
    //    public static Int32 GetConfigurationCount(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetConfigurationCount();
    //    }
    //    public static Object GetConfigurationNames(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetConfigurationNames();
    //    }
    //    public static String IGetConfigurationNames(IModelDocObject IModelDocinstance, Int32& Count)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetConfigurationNames(Count);
    //    }
    //    public static void FeatureCut2(IModelDocObject IModelDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Int32 KeepPieceIndex)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureCut2(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, KeepPieceIndex);
    //    }
    //    public static void InsertCutSurface(IModelDocObject IModelDocinstance, Boolean Flip, Int32 KeepPieceIndex)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCutSurface(Flip, KeepPieceIndex);
    //    }
    //    public static Object GetDetailingDefaults(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetDetailingDefaults();
    //    }
    //    public static IDetailingDefaultsObject IGetDetailingDefaults(IModelDocObject IModelDocinstance)
    //    {
    //        return new IDetailingDefaultsObject(IModelDocinstance.IModelDocInstance.IGetDetailingDefaults());
    //    }
    //    public static Int32 ListExternalFileReferencesCount(IModelDocObject IModelDocinstance, Boolean UseSearchRules)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ListExternalFileReferencesCount(UseSearchRules);
    //    }
    //    public static Object ListExternalFileReferences(IModelDocObject IModelDocinstance, Boolean UseSearchRules)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ListExternalFileReferences(UseSearchRules);
    //    }
    //    public static String IListExternalFileReferences(IModelDocObject IModelDocinstance, Boolean UseSearchRules, Int32 NumRefs)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IListExternalFileReferences(UseSearchRules, NumRefs);
    //    }
    //    public static Boolean SketchSplineByEqnParams2(IModelDocObject IModelDocinstance, Object ParamsIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchSplineByEqnParams2(ParamsIn);
    //    }
    //    public static Object GetFirstModelView(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetFirstModelView();
    //    }
    //    public static IModelViewObject IGetFirstModelView(IModelDocObject IModelDocinstance)
    //    {
    //        return new IModelViewObject(IModelDocinstance.IModelDocInstance.IGetFirstModelView());
    //    }
    //    public static Boolean InsertPlanarRefSurface(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertPlanarRefSurface();
    //    }
    //    public static Object GetNext(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetNext();
    //    }
    //    public static Boolean GetSaveFlag(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetSaveFlag();
    //    }
    //    public static Boolean AddCustomInfo3(IModelDocObject IModelDocinstance, String Configuration, String FieldName, Int32 FieldType, String FieldValue)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddCustomInfo3(Configuration, FieldName, FieldType, FieldValue);
    //    }
    //    public static Boolean DeleteCustomInfo2(IModelDocObject IModelDocinstance, String Configuration, String FieldName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeleteCustomInfo2(Configuration, FieldName);
    //    }
    //    public static Int32 GetCustomInfoCount2(IModelDocObject IModelDocinstance, String Configuration)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetCustomInfoCount2(Configuration);
    //    }
    //    public static Object GetCustomInfoNames2(IModelDocObject IModelDocinstance, String Configuration)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetCustomInfoNames2(Configuration);
    //    }
    //    public static String IGetCustomInfoNames2(IModelDocObject IModelDocinstance, String Configuration)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetCustomInfoNames2(Configuration);
    //    }
    //    public static Int32 GetCustomInfoType3(IModelDocObject IModelDocinstance, String Configuration, String FieldName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetCustomInfoType3(Configuration, FieldName);
    //    }
    //    public static Boolean GetConsiderLeadersAsLines(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetConsiderLeadersAsLines();
    //    }
    //    public static Boolean SetConsiderLeadersAsLines(IModelDocObject IModelDocinstance, Boolean LeadersAsLines)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetConsiderLeadersAsLines(LeadersAsLines);
    //    }
    //    public static void InsertRevolvedRefSurface(IModelDocObject IModelDocinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertRevolvedRefSurface(Angle, ReverseDir, Angle2, RevType);
    //    }
    //    public static Int32 GetBendState(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetBendState();
    //    }
    //    public static Int32 SetBendState(IModelDocObject IModelDocinstance, Int32 BendState)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetBendState(BendState);
    //    }
    //    public static void ClearUndoList(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ClearUndoList();
    //    }
    //    public static Int32 GetFeatureManagerWidth(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetFeatureManagerWidth();
    //    }
    //    public static Int32 SetFeatureManagerWidth(IModelDocObject IModelDocinstance, Int32 Width)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetFeatureManagerWidth(Width);
    //    }
    //    public static Object InsertProjectedSketch2(IModelDocObject IModelDocinstance, Int32 Reverse)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertProjectedSketch2(Reverse);
    //    }
    //    public static IFeatureObject IInsertProjectedSketch2(IModelDocObject IModelDocinstance, Int32 Reverse)
    //    {
    //        return new IFeatureObject(IModelDocinstance.IModelDocInstance.IInsertProjectedSketch2(Reverse));
    //    }
    //    public static Int32 GetFeatureCount(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetFeatureCount();
    //    }
    //    public static Object FeatureByPositionReverse(IModelDocObject IModelDocinstance, Int32 Num)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureByPositionReverse(Num);
    //    }
    //    public static IFeatureObject IFeatureByPositionReverse(IModelDocObject IModelDocinstance, Int32 Num)
    //    {
    //        return new IFeatureObject(IModelDocinstance.IModelDocInstance.IFeatureByPositionReverse(Num));
    //    }
    //    public static Int32 RayIntersections(IModelDocObject IModelDocinstance, Object BodiesIn, Object BasePointsIn, Object VectorsIn, Int32 Options, Double HitRadius, Double Offset)
    //    {
    //        return IModelDocinstance.IModelDocInstance.RayIntersections(BodiesIn, BasePointsIn, VectorsIn, Options, HitRadius, Offset);
    //    }
    //    public static Int32 IRayIntersections(IModelDocObject IModelDocinstance, Body&Object BodiesIn, Int32 NumBodies, Double& BasePointsIn, Double& VectorsIn, Int32 NumRays, Int32 Options, Double HitRadius, Double Offset)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IRayIntersections(BodiesIn, NumBodies, BasePointsIn, VectorsIn, NumRays, Options, HitRadius, Offset);
    //    }
    //    public static Object GetRayIntersectionsPoints(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetRayIntersectionsPoints();
    //    }
    //    public static Double IGetRayIntersectionsPoints(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetRayIntersectionsPoints();
    //    }
    //    public static Object GetRayIntersectionsTopology(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetRayIntersectionsTopology();
    //    }
    //    public static Object IGetRayIntersectionsTopology(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetRayIntersectionsTopology();
    //    }
    //    public static void EditSeedFeat(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditSeedFeat();
    //    }
    //    public static Boolean EditSuppress(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditSuppress();
    //    }
    //    public static Boolean EditUnsuppress(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditUnsuppress();
    //    }
    //    public static Boolean EditUnsuppressDependent(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditUnsuppressDependent();
    //    }
    //    public static Boolean EditRollback(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditRollback();
    //    }
    //    public static Int32 Save2(IModelDocObject IModelDocinstance, Boolean Silent)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Save2(Silent);
    //    }
    //    public static Int32 SaveAs2(IModelDocObject IModelDocinstance, String NewName, Int32 SaveAsVersion, Boolean SaveAsCopy, Boolean Silent)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SaveAs2(NewName, SaveAsVersion, SaveAsCopy, Silent);
    //    }
    //    public static void SetPopupMenuMode(IModelDocObject IModelDocinstance, Int32 ModeIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetPopupMenuMode(ModeIn);
    //    }
    //    public static Int32 GetPopupMenuMode(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetPopupMenuMode();
    //    }
    //    public static void CloseFamilyTable(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CloseFamilyTable();
    //    }
    //    public static void CreatePlaneAtSurface(IModelDocObject IModelDocinstance, Int32 InterIndex, Boolean ProjOpt, Boolean ReverseDir, Boolean NormalPlane, Double Angle)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreatePlaneAtSurface(InterIndex, ProjOpt, ReverseDir, NormalPlane, Angle);
    //    }
    //    public static void SketchOffset(IModelDocObject IModelDocinstance, Double Offset, Boolean ContourMode)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchOffset(Offset, ContourMode);
    //    }
    //    public static Boolean CreateLinearSketchStepAndRepeat(IModelDocObject IModelDocinstance, Int32 NumX, Int32 NumY, Double SpacingX, Double SpacingY, Double AngleX, Double AngleY, String DeleteInstances)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateLinearSketchStepAndRepeat(NumX, NumY, SpacingX, SpacingY, AngleX, AngleY, DeleteInstances);
    //    }
    //    public static Boolean SetAmbientLightProperties(IModelDocObject IModelDocinstance, String Name, Double Ambient, Double Diffuse, Double Specular, Int32 Colour, Boolean Enabled, Boolean Fixed)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetAmbientLightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed);
    //    }
    //    public static void GraphicsRedraw2(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GraphicsRedraw2();
    //    }
    //    public static void InsertCosmeticThread(IModelDocObject IModelDocinstance, Int16 Type, Double Depth, Double Length, String Note)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCosmeticThread(Type, Depth, Length, Note);
    //    }
    //    public static void HideCosmeticThread(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.HideCosmeticThread();
    //    }
    //    public static void ShowCosmeticThread(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ShowCosmeticThread();
    //    }
    //    public static void SimpleHole2(IModelDocObject IModelDocinstance, Double Dia, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SimpleHole2(Dia, Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2);
    //    }
    //    public static void IRelease3rdPartyStorage(IModelDocObject IModelDocinstance, String StringIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IRelease3rdPartyStorage(StringIn);
    //    }
    //    public static Int32 FeatureRevolve2(IModelDocObject IModelDocinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType, Int32 Options)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureRevolve2(Angle, ReverseDir, Angle2, RevType, Options);
    //    }
    //    public static Int32 FeatureRevolveCut2(IModelDocObject IModelDocinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType, Int32 Options)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureRevolveCut2(Angle, ReverseDir, Angle2, RevType, Options);
    //    }
    //    public static void SetSaveFlag(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetSaveFlag();
    //    }
    //    public static String GetExternalReferenceName(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetExternalReferenceName();
    //    }
    //    public static Boolean SelectByRay(IModelDocObject IModelDocinstance, Object DoubleInfoIn, Int32 TypeWanted)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectByRay(DoubleInfoIn, TypeWanted);
    //    }
    //    public static Boolean ISelectByRay(IModelDocObject IModelDocinstance, Double& PointIn, Double& VectorIn, Double RadiusIn, Int32 TypeWanted)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ISelectByRay(PointIn, VectorIn, RadiusIn, TypeWanted);
    //    }
    //    public static void SetSceneBkgDIB(IModelDocObject IModelDocinstance, Int32 L_dib)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetSceneBkgDIB(L_dib);
    //    }
    //    public static void InsertBkgImage(IModelDocObject IModelDocinstance, String NewName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertBkgImage(NewName);
    //    }
    //    public static void DeleteBkgImage(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeleteBkgImage();
    //    }
    //    public static void InsertSplinePoint(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSplinePoint(X, Y, Z);
    //    }
    //    public static void InsertLoftRefSurface2(IModelDocObject IModelDocinstance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational, Double TessToleranceFactor, Int16 StartMatchingType, Int16 EndMatchingType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertLoftRefSurface2(Closed, KeepTangency, ForceNonRational, TessToleranceFactor, StartMatchingType, EndMatchingType);
    //    }
    //    public static void InsertProtrusionBlend3(IModelDocObject IModelDocinstance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational, Double TessToleranceFactor, Int16 StartMatchingType, Int16 EndMatchingType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertProtrusionBlend3(Closed, KeepTangency, ForceNonRational, TessToleranceFactor, StartMatchingType, EndMatchingType);
    //    }
    //    public static void InsertCutBlend3(IModelDocObject IModelDocinstance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational, Double TessToleranceFactor, Int16 StartMatchingType, Int16 EndMatchingType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCutBlend3(Closed, KeepTangency, ForceNonRational, TessToleranceFactor, StartMatchingType, EndMatchingType);
    //    }
    //    public static void AlignDimensions(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AlignDimensions();
    //    }
    //    public static void BreakDimensionAlignment(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.BreakDimensionAlignment();
    //    }
    //    public static void SketchFillet1(IModelDocObject IModelDocinstance, Double Rad)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchFillet1(Rad);
    //    }
    //    public static void FeatureChamferType(IModelDocObject IModelDocinstance, Int16 ChamferType, Double Width, Double Angle, Boolean Flip, Double OtherDist, Double VertexChamDist1, Double VertexChamDist2, Double VertexChamDist3)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureChamferType(ChamferType, Width, Angle, Flip, OtherDist, VertexChamDist1, VertexChamDist2, VertexChamDist3);
    //    }
    //    public static void FeatureCutThin(IModelDocObject IModelDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Double Thk1, Double Thk2, Double EndThk, Int32 RevThinDir, Int32 CapEnds, Boolean AddBends, Double BendRad)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureCutThin(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, Thk1, Thk2, EndThk, RevThinDir, CapEnds, AddBends, BendRad);
    //    }
    //    public static void FeatureBossThin(IModelDocObject IModelDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Double Thk1, Double Thk2, Double EndThk, Int32 RevThinDir, Int32 CapEnds, Boolean AddBends, Double BendRad)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureBossThin(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, Thk1, Thk2, EndThk, RevThinDir, CapEnds, AddBends, BendRad);
    //    }
    //    public static Boolean InsertDatumTargetSymbol(IModelDocObject IModelDocinstance, String Datum1, String Datum2, String Datum3, Int16 AreaStyle, Boolean AreaOutside, Double Value1, Double Value2, String ValueStr1, String ValueStr2, Boolean ArrowsSmart, Int16 ArrowStyle, Int16 LeaderLineStyle, Boolean LeaderBent, Boolean ShowArea, Boolean ShowSymbol)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertDatumTargetSymbol(Datum1, Datum2, Datum3, AreaStyle, AreaOutside, Value1, Value2, ValueStr1, ValueStr2, ArrowsSmart, ArrowStyle, LeaderLineStyle, LeaderBent, ShowArea, ShowSymbol);
    //    }
    //    public static Boolean EditDatumTargetSymbol(IModelDocObject IModelDocinstance, String Datum1, String Datum2, String Datum3, Int16 AreaStyle, Boolean AreaOutside, Double Value1, Double Value2, String ValueStr1, String ValueStr2, Boolean ArrowsSmart, Int16 ArrowStyle, Int16 LeaderLineStyle, Boolean LeaderBent, Boolean ShowArea, Boolean ShowSymbol)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditDatumTargetSymbol(Datum1, Datum2, Datum3, AreaStyle, AreaOutside, Value1, Value2, ValueStr1, ValueStr2, ArrowsSmart, ArrowStyle, LeaderLineStyle, LeaderBent, ShowArea, ShowSymbol);
    //    }
    //    public static void InsertBOMBalloon(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertBOMBalloon();
    //    }
    //    public static Object FeatureReferenceCurve(IModelDocObject IModelDocinstance, Int32 NumOfCurves, Object BaseCurves, Boolean Merge, String FromFileName, Int32& ErrorCode)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureReferenceCurve(NumOfCurves, BaseCurves, Merge, FromFileName, ErrorCode);
    //    }
    //    public static IReferenceCurveObject IFeatureReferenceCurve(IModelDocObject IModelDocinstance, Int32 NumOfCurves, IntPtr BaseCurves, Boolean Merge, String FromFileName, Int32& ErrorCode)
    //    {
    //        return new IReferenceCurveObject(IModelDocinstance.IModelDocInstance.IFeatureReferenceCurve(NumOfCurves, BaseCurves, Merge, FromFileName, ErrorCode));
    //    }
    //    public static void FontBold(IModelDocObject IModelDocinstance, Boolean Bold)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FontBold(Bold);
    //    }
    //    public static void FontItalic(IModelDocObject IModelDocinstance, Boolean Italic)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FontItalic(Italic);
    //    }
    //    public static void FontUnderline(IModelDocObject IModelDocinstance, Boolean Underline)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FontUnderline(Underline);
    //    }
    //    public static void FontFace(IModelDocObject IModelDocinstance, String Face)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FontFace(Face);
    //    }
    //    public static void FontPoints(IModelDocObject IModelDocinstance, Int16 Points)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FontPoints(Points);
    //    }
    //    public static void FontUnits(IModelDocObject IModelDocinstance, Double Units)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FontUnits(Units);
    //    }
    //    public static Boolean SketchSplineByEqnParams(IModelDocObject IModelDocinstance, Object ParamsIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchSplineByEqnParams(ParamsIn);
    //    }
    //    public static void AlignParallelDimensions(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AlignParallelDimensions();
    //    }
    //    public static void SetBlockingState(IModelDocObject IModelDocinstance, Int32 StateIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetBlockingState(StateIn);
    //    }
    //    public static void ResetBlockingState(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ResetBlockingState();
    //    }
    //    public static Int32 GetSceneBkgDIB(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetSceneBkgDIB();
    //    }
    //    public static void InsertHatchedFace(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertHatchedFace();
    //    }
    //    public static Object GetColorTable(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetColorTable();
    //    }
    //    public static IColorTableObject IGetColorTable(IModelDocObject IModelDocinstance)
    //    {
    //        return new IColorTableObject(IModelDocinstance.IModelDocInstance.IGetColorTable());
    //    }
    //    public static void InsertSweepRefSurface2(IModelDocObject IModelDocinstance, Boolean Propagate, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSweepRefSurface2(Propagate, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType);
    //    }
    //    public static void InsertProtrusionSwept3(IModelDocObject IModelDocinstance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertProtrusionSwept3(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType);
    //    }
    //    public static void InsertCutSwept3(IModelDocObject IModelDocinstance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCutSwept3(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType);
    //    }
    //    public static Boolean IsOpenedViewOnly(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IsOpenedViewOnly();
    //    }
    //    public static Boolean IsOpenedReadOnly(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IsOpenedReadOnly();
    //    }
    //    public static void ViewZoomToSelection(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewZoomToSelection();
    //    }
    //    public static void FeatureBossThicken(IModelDocObject IModelDocinstance, Double Thickness, Int32 Direction, Int32 FaceIndex)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureBossThicken(Thickness, Direction, FaceIndex);
    //    }
    //    public static void FeatureCutThicken(IModelDocObject IModelDocinstance, Double Thickness, Int32 Direction, Int32 FaceIndex)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureCutThicken(Thickness, Direction, FaceIndex);
    //    }
    //    public static Boolean InsertAxis(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertAxis();
    //    }
    //    public static void EditUndo(IModelDocObject IModelDocinstance, UInt32 NSteps)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditUndo(NSteps);
    //    }
    //    public static void SelectMidpoint(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectMidpoint();
    //    }
    //    public static Int32 ISketchSplineByEqnParams(IModelDocObject IModelDocinstance, Int32& PropArray, Double& KnotsArray, Double& CntrlPntCoordArray)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ISketchSplineByEqnParams(PropArray, KnotsArray, CntrlPntCoordArray);
    //    }
    //    public static Object VersionHistory(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.VersionHistory();
    //    }
    //    public static String IVersionHistory(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IVersionHistory();
    //    }
    //    public static Int32 IGetVersionHistoryCount(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetVersionHistoryCount();
    //    }
    //    public static void Rebuild(IModelDocObject IModelDocinstance, Int32 Options)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Rebuild(Options);
    //    }
    //    public static void InsertFeatureShellAddThickness(IModelDocObject IModelDocinstance, Double Thickness)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertFeatureShellAddThickness(Thickness);
    //    }
    //    public static void InsertOffsetSurface(IModelDocObject IModelDocinstance, Double Thickness, Boolean Reverse)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertOffsetSurface(Thickness, Reverse);
    //    }
    //    public static void SimplifySpline(IModelDocObject IModelDocinstance, Double ToleranceIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SimplifySpline(ToleranceIn);
    //    }
    //    public static Int32 GetCustomInfoCount(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetCustomInfoCount();
    //    }
    //    public static String GetCustomInfoType(IModelDocObject IModelDocinstance, String FieldName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetCustomInfoType(FieldName);
    //    }
    //    public static Object GetCustomInfoNames(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetCustomInfoNames();
    //    }
    //    public static String IGetCustomInfoNames(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetCustomInfoNames();
    //    }
    //    public static Boolean AddCustomInfo(IModelDocObject IModelDocinstance, String FieldName, String FieldType, String FieldValue)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddCustomInfo(FieldName, FieldType, FieldValue);
    //    }
    //    public static Boolean DeleteCustomInfo(IModelDocObject IModelDocinstance, String FieldName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeleteCustomInfo(FieldName);
    //    }
    //    public static void PrintOut2(IModelDocObject IModelDocinstance, Int32 FromPage, Int32 ToPage, Int32 NumCopies, Boolean Collate, String Printer, Double Scale, Boolean PrintToFile, String PtfName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.PrintOut2(FromPage, ToPage, NumCopies, Collate, Printer, Scale, PrintToFile, PtfName);
    //    }
    //    public static Boolean SetReadOnlyState(IModelDocObject IModelDocinstance, Boolean SetReadOnly)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetReadOnlyState(SetReadOnly);
    //    }
    //    public static Boolean InsertFamilyTableOpen(IModelDocObject IModelDocinstance, String FileName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertFamilyTableOpen(FileName);
    //    }
    //    public static Boolean MultiSelectByRay(IModelDocObject IModelDocinstance, Object DoubleInfoIn, Int32 TypeWanted, Boolean Append)
    //    {
    //        return IModelDocinstance.IModelDocInstance.MultiSelectByRay(DoubleInfoIn, TypeWanted, Append);
    //    }
    //    public static Boolean IMultiSelectByRay(IModelDocObject IModelDocinstance, Double& PointIn, Double& VectorIn, Double RadiusIn, Int32 TypeWanted, Boolean Append)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IMultiSelectByRay(PointIn, VectorIn, RadiusIn, TypeWanted, Append);
    //    }
    //    public static void InsertNewNote3(IModelDocObject IModelDocinstance, String UpperText, Boolean NoLeader, Boolean BentLeader, Int16 ArrowStyle, Int16 LeaderSide, Double Angle, Int16 BalloonStyle, Int16 BalloonFit, Boolean SmartArrow)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertNewNote3(UpperText, NoLeader, BentLeader, ArrowStyle, LeaderSide, Angle, BalloonStyle, BalloonFit, SmartArrow);
    //    }
    //    public static void InsertWeldSymbol2(IModelDocObject IModelDocinstance, String Dim1, String Symbol, String Dim2, Boolean Symmetric, Boolean FieldWeld, Boolean ShowOtherSide, Boolean DashOnTop, Boolean Peripheral, Boolean HasProcess, String ProcessValue)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertWeldSymbol2(Dim1, Symbol, Dim2, Symmetric, FieldWeld, ShowOtherSide, DashOnTop, Peripheral, HasProcess, ProcessValue);
    //    }
    //    public static Boolean InsertSurfaceFinishSymbol2(IModelDocObject IModelDocinstance, Int32 SymType, Int32 LeaderType, Double LocX, Double LocY, Double LocZ, Int32 LaySymbol, Int32 ArrowType, String MachAllowance, String OtherVals, String ProdMethod, String SampleLen, String MaxRoughness, String MinRoughness, String RoughnessSpacing)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSurfaceFinishSymbol2(SymType, LeaderType, LocX, LocY, LocZ, LaySymbol, ArrowType, MachAllowance, OtherVals, ProdMethod, SampleLen, MaxRoughness, MinRoughness, RoughnessSpacing);
    //    }
    //    public static void FeatureExtruRefSurface(IModelDocObject IModelDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureExtruRefSurface(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2);
    //    }
    //    public static Object IGet3rdPartyStorage(IModelDocObject IModelDocinstance, String StringIn, Boolean IsStoring)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGet3rdPartyStorage(StringIn, IsStoring);
    //    }
    //    public static void DeleteFeatureMgrView(IModelDocObject IModelDocinstance, Int32& AppView)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeleteFeatureMgrView(AppView);
    //    }
    //    public static Object GetMassProperties(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetMassProperties();
    //    }
    //    public static Boolean IGetMassProperties(IModelDocObject IModelDocinstance, Double& MPropsData)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetMassProperties(MPropsData);
    //    }
    //    public static Int32 GetLightSourceCount(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetLightSourceCount();
    //    }
    //    public static Int32 GetLightSourceIdFromName(IModelDocObject IModelDocinstance, String LightName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetLightSourceIdFromName(LightName);
    //    }
    //    public static void SetNextSelectionGroupId(IModelDocObject IModelDocinstance, Int32 ID)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetNextSelectionGroupId(ID);
    //    }
    //    public static void ISetNextSelectionGroupId(IModelDocObject IModelDocinstance, Int32 ID)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ISetNextSelectionGroupId(ID);
    //    }
    //    public static Object InsertMidSurfaceExt(IModelDocObject IModelDocinstance, Double Placement, Boolean KnitFlag)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertMidSurfaceExt(Placement, KnitFlag);
    //    }
    //    public static IMidSurfaceObject IInsertMidSurfaceExt(IModelDocObject IModelDocinstance, Double Placement, Boolean KnitFlag)
    //    {
    //        return new IMidSurfaceObject(IModelDocinstance.IModelDocInstance.IInsertMidSurfaceExt(Placement, KnitFlag));
    //    }
    //    public static void ICreatePlaneFixed(IModelDocObject IModelDocinstance, Double& P1, Double& P2, Double& P3, Boolean UseGlobal)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ICreatePlaneFixed(P1, P2, P3, UseGlobal);
    //    }
    //    public static Boolean SelectByMark(IModelDocObject IModelDocinstance, String SelID, String SelParams, Double X, Double Y, Double Z, Int32 Mark)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectByMark(SelID, SelParams, X, Y, Z, Mark);
    //    }
    //    public static Boolean AndSelectByMark(IModelDocObject IModelDocinstance, String SelID, String SelParams, Double X, Double Y, Double Z, Int32 Mark)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AndSelectByMark(SelID, SelParams, X, Y, Z, Mark);
    //    }
    //    public static Object GetDependencies(IModelDocObject IModelDocinstance, Int32 Traverseflag, Int32 Searchflag)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetDependencies(Traverseflag, Searchflag);
    //    }
    //    public static String IGetDependencies(IModelDocObject IModelDocinstance, Int32 Traverseflag, Int32 Searchflag)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetDependencies(Traverseflag, Searchflag);
    //    }
    //    public static Int32 GetNumDependencies(IModelDocObject IModelDocinstance, Int32 Traverseflag, Int32 Searchflag)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetNumDependencies(Traverseflag, Searchflag);
    //    }
    //    public static Int32 IGetNumDependencies(IModelDocObject IModelDocinstance, Int32 Traverseflag, Int32 Searchflag)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetNumDependencies(Traverseflag, Searchflag);
    //    }
    //    public static Object FirstFeature(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FirstFeature();
    //    }
    //    public static IFeatureObject IFirstFeature(IModelDocObject IModelDocinstance)
    //    {
    //        return new IFeatureObject(IModelDocinstance.IModelDocInstance.IFirstFeature());
    //    }
    //    public static void UnderiveSketch(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.UnderiveSketch();
    //    }
    //    public static void DeriveSketch(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeriveSketch();
    //    }
    //    public static Boolean IsExploded(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IsExploded();
    //    }
    //    public static Boolean DeleteSelection(IModelDocObject IModelDocinstance, Boolean ConfirmFlag)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeleteSelection(ConfirmFlag);
    //    }
    //    public static Boolean DeleteNamedView(IModelDocObject IModelDocinstance, String ViewName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeleteNamedView(ViewName);
    //    }
    //    public static Boolean SetLightSourceName(IModelDocObject IModelDocinstance, Int32 ID, String NewName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetLightSourceName(ID, NewName);
    //    }
    //    public static void Insert3DSplineCurve(IModelDocObject IModelDocinstance, Boolean CurveClosed)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Insert3DSplineCurve(CurveClosed);
    //    }
    //    public static Boolean SetLightSourcePropertyValuesVB(IModelDocObject IModelDocinstance, String IdName, Int32 LType, Double Diff, Int32 RgbColor, Double Dist, Double DirX, Double DirY, Double DirZ, Double SpotDirX, Double SpotDirY, Double SpotDirZ, Double SpotAngle, Double FallOff0, Double FallOff1, Double FallOff2, Double Ambient, Double Specular, Double SpotExponent, Boolean BDisable)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetLightSourcePropertyValuesVB(IdName, LType, Diff, RgbColor, Dist, DirX, DirY, DirZ, SpotDirX, SpotDirY, SpotDirZ, SpotAngle, FallOff0, FallOff1, FallOff2, Ambient, Specular, SpotExponent, BDisable);
    //    }
    //    public static IFeatMgrViewObject ICreateFeatureMgrView(IModelDocObject IModelDocinstance, Int32& Bitmap)
    //    {
    //        return new IFeatMgrViewObject(IModelDocinstance.IModelDocInstance.ICreateFeatureMgrView(Bitmap));
    //    }
    //    public static Boolean SelectedEdgeProperties(IModelDocObject IModelDocinstance, String EdgeName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectedEdgeProperties(EdgeName);
    //    }
    //    public static Boolean SelectedFaceProperties(IModelDocObject IModelDocinstance, Int32 RgbColor, Double Ambient, Double Diffuse, Double Specular, Double Shininess, Double Transparency, Double Emission, Boolean UsePartProps, String FaceName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectedFaceProperties(RgbColor, Ambient, Diffuse, Specular, Shininess, Transparency, Emission, UsePartProps, FaceName);
    //    }
    //    public static Boolean SelectedFeatureProperties(IModelDocObject IModelDocinstance, Int32 RgbColor, Double Ambient, Double Diffuse, Double Specular, Double Shininess, Double Transparency, Double Emission, Boolean UsePartProps, Boolean Suppressed, String FeatureName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectedFeatureProperties(RgbColor, Ambient, Diffuse, Specular, Shininess, Transparency, Emission, UsePartProps, Suppressed, FeatureName);
    //    }
    //    public static void InsertSplitLineSil(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSplitLineSil();
    //    }
    //    public static void InsertSplitLineProject(IModelDocObject IModelDocinstance, Boolean IsDirectional, Boolean FlipDir)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSplitLineProject(IsDirectional, FlipDir);
    //    }
    //    public static void InsertRib(IModelDocObject IModelDocinstance, Boolean Is2Sided, Boolean ReverseThicknessDir, Double Thickness, Int32 ReferenceEdgeIndex, Boolean ReverseMaterialDir, Boolean IsDrafted, Boolean DraftOutward, Double DraftAngle)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertRib(Is2Sided, ReverseThicknessDir, Thickness, ReferenceEdgeIndex, ReverseMaterialDir, IsDrafted, DraftOutward, DraftAngle);
    //    }
    //    public static Boolean AddRadialDimension(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddRadialDimension(X, Y, Z);
    //    }
    //    public static Boolean AddDiameterDimension(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddDiameterDimension(X, Y, Z);
    //    }
    //    public static Object GetModelViewNames(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetModelViewNames();
    //    }
    //    public static String IGetModelViewNames(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetModelViewNames();
    //    }
    //    public static Int32 GetModelViewCount(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetModelViewCount();
    //    }
    //    public static Double GetUserPreferenceDoubleValue(IModelDocObject IModelDocinstance, Int32 UserPreferenceValue)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetUserPreferenceDoubleValue(UserPreferenceValue);
    //    }
    //    public static Boolean SetUserPreferenceDoubleValue(IModelDocObject IModelDocinstance, Int32 UserPreferenceValue, Double Value)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetUserPreferenceDoubleValue(UserPreferenceValue, Value);
    //    }
    //    public static void ViewDisplayCurvature(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewDisplayCurvature();
    //    }
    //    public static void Scale(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Scale();
    //    }
    //    public static void AddIns(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddIns();
    //    }
    //    public static Boolean InsertCurveFile(IModelDocObject IModelDocinstance, String FileName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCurveFile(FileName);
    //    }
    //    public static void InsertCurveFileBegin(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCurveFileBegin();
    //    }
    //    public static Boolean InsertCurveFilePoint(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCurveFilePoint(X, Y, Z);
    //    }
    //    public static Boolean InsertCurveFileEnd(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCurveFileEnd();
    //    }
    //    public static Boolean ChangeSketchPlane(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ChangeSketchPlane();
    //    }
    //    public static void ViewOrientationUndo(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewOrientationUndo();
    //    }
    //    public static void PrintOut(IModelDocObject IModelDocinstance, Int32 FromPage, Int32 ToPage, Int32 NumCopies, Boolean Collate, String Printer, Double Scale, Boolean PrintToFile)
    //    {
    //        return IModelDocinstance.IModelDocInstance.PrintOut(FromPage, ToPage, NumCopies, Collate, Printer, Scale, PrintToFile);
    //    }
    //    public static void SketchOffsetEntities(IModelDocObject IModelDocinstance, Double Offset, Boolean Flip)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchOffsetEntities(Offset, Flip);
    //    }
    //    public static void InsertLibraryFeature(IModelDocObject IModelDocinstance, String LibFeatPartNameIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertLibraryFeature(LibFeatPartNameIn);
    //    }
    //    public static void SketchModifyTranslate(IModelDocObject IModelDocinstance, Double StartX, Double StartY, Double EndX, Double EndY)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchModifyTranslate(StartX, StartY, EndX, EndY);
    //    }
    //    public static void SketchModifyRotate(IModelDocObject IModelDocinstance, Double CenterX, Double CenterY, Double Angle)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchModifyRotate(CenterX, CenterY, Angle);
    //    }
    //    public static void SketchModifyFlip(IModelDocObject IModelDocinstance, Int32 AxisFlag)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchModifyFlip(AxisFlag);
    //    }
    //    public static Boolean SketchModifyScale(IModelDocObject IModelDocinstance, Double ScaleFactor)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchModifyScale(ScaleFactor);
    //    }
    //    public static Object GetActiveConfiguration(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetActiveConfiguration();
    //    }
    //    public static IConfigurationObject IGetActiveConfiguration(IModelDocObject IModelDocinstance)
    //    {
    //        return new IConfigurationObject(IModelDocinstance.IModelDocInstance.IGetActiveConfiguration());
    //    }
    //    public static Boolean GetUserPreferenceToggle(IModelDocObject IModelDocinstance, Int32 UserPreferenceToggle)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetUserPreferenceToggle(UserPreferenceToggle);
    //    }
    //    public static Boolean SetUserPreferenceToggle(IModelDocObject IModelDocinstance, Int32 UserPreferenceValue, Boolean OnFlag)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetUserPreferenceToggle(UserPreferenceValue, OnFlag);
    //    }
    //    public static void InsertSweepRefSurface(IModelDocObject IModelDocinstance, Boolean Propagate, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSweepRefSurface(Propagate, TwistCtrlOption, KeepTangency, ForceNonRational);
    //    }
    //    public static void InsertLoftRefSurface(IModelDocObject IModelDocinstance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertLoftRefSurface(Closed, KeepTangency, ForceNonRational);
    //    }
    //    public static void InsertProtrusionSwept2(IModelDocObject IModelDocinstance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertProtrusionSwept2(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational);
    //    }
    //    public static void InsertProtrusionBlend2(IModelDocObject IModelDocinstance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertProtrusionBlend2(Closed, KeepTangency, ForceNonRational);
    //    }
    //    public static void InsertCutSwept2(IModelDocObject IModelDocinstance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCutSwept2(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational);
    //    }
    //    public static void InsertCutBlend2(IModelDocObject IModelDocinstance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCutBlend2(Closed, KeepTangency, ForceNonRational);
    //    }
    //    public static Boolean IsEditingSelf(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IsEditingSelf();
    //    }
    //    public static void ShowNamedView2(IModelDocObject IModelDocinstance, String VName, Int32 ViewId)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ShowNamedView2(VName, ViewId);
    //    }
    //    public static void InsertDome(IModelDocObject IModelDocinstance, Double Height, Boolean ReverseDir, Boolean DoEllipticSurface)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertDome(Height, ReverseDir, DoEllipticSurface);
    //    }
    //    public static Int32 AddPropertyExtension(IModelDocObject IModelDocinstance, Object PropertyExtension)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddPropertyExtension(PropertyExtension);
    //    }
    //    public static Object GetPropertyExtension(IModelDocObject IModelDocinstance, Int32 ID)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetPropertyExtension(ID);
    //    }
    //    public static void ResetPropertyExtension(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ResetPropertyExtension();
    //    }
    //    public static Int32 GetUpdateStamp(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetUpdateStamp();
    //    }
    //    public static void ViewZoomTo2(IModelDocObject IModelDocinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewZoomTo2(X1, Y1, Z1, X2, Y2, Z2);
    //    }
    //    public static void ScreenRotate(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ScreenRotate();
    //    }
    //    public static void UnblankSketch(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.UnblankSketch();
    //    }
    //    public static void EditSketchOrSingleSketchFeature(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditSketchOrSingleSketchFeature();
    //    }
    //    public static void DebugCheckIgesGeom(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DebugCheckIgesGeom();
    //    }
    //    public static void BlankSketch(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.BlankSketch();
    //    }
    //    public static Double GetDefaultTextHeight(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetDefaultTextHeight();
    //    }
    //    public static Boolean IsActive(IModelDocObject IModelDocinstance, String CompStr)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IsActive(CompStr);
    //    }
    //    public static Boolean CreateEllipse(IModelDocObject IModelDocinstance, Object Center, Object Major, Object Minor)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateEllipse(Center, Major, Minor);
    //    }
    //    public static Boolean CreateEllipseVB(IModelDocObject IModelDocinstance, Double CenterX, Double CenterY, Double CenterZ, Double MajorX, Double MajorY, Double MajorZ, Double MinorX, Double MinorY, Double MinorZ)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateEllipseVB(CenterX, CenterY, CenterZ, MajorX, MajorY, MajorZ, MinorX, MinorY, MinorZ);
    //    }
    //    public static Boolean CreateEllipticalArcByCenter(IModelDocObject IModelDocinstance, Object Center, Object Major, Object Minor, Object Start, Object End)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateEllipticalArcByCenter(Center, Major, Minor, Start, End);
    //    }
    //    public static Boolean CreateEllipticalArcByCenterVB(IModelDocObject IModelDocinstance, Double CenterX, Double CenterY, Double CenterZ, Double MajorX, Double MajorY, Double MajorZ, Double MinorX, Double MinorY, Double MinorZ, Double StartX, Double StartY, Double StartZ, Double EndX, Double EndY, Double EndZ)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateEllipticalArcByCenterVB(CenterX, CenterY, CenterZ, MajorX, MajorY, MajorZ, MinorX, MinorY, MinorZ, StartX, StartY, StartZ, EndX, EndY, EndZ);
    //    }
    //    public static Object GetActiveSketch(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetActiveSketch();
    //    }
    //    public static ISketchObject IGetActiveSketch(IModelDocObject IModelDocinstance)
    //    {
    //        return new ISketchObject(IModelDocinstance.IModelDocInstance.IGetActiveSketch());
    //    }
    //    public static Int32 GetTessellationQuality(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetTessellationQuality();
    //    }
    //    public static void SetTessellationQuality(IModelDocObject IModelDocinstance, Int32 QualityNum)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetTessellationQuality(QualityNum);
    //    }
    //    public static Object Parameter(IModelDocObject IModelDocinstance, String StringIn)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Parameter(StringIn);
    //    }
    //    public static IDimensionObject IParameter(IModelDocObject IModelDocinstance, String StringIn)
    //    {
    //        return new IDimensionObject(IModelDocinstance.IModelDocInstance.IParameter(StringIn));
    //    }
    //    public static Boolean SelectByID(IModelDocObject IModelDocinstance, String SelID, String SelParams, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectByID(SelID, SelParams, X, Y, Z);
    //    }
    //    public static Boolean AndSelectByID(IModelDocObject IModelDocinstance, String SelID, String SelParams, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AndSelectByID(SelID, SelParams, X, Y, Z);
    //    }
    //    public static void Insert3DSketch(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Insert3DSketch();
    //    }
    //    public static String GetLightSourceName(IModelDocObject IModelDocinstance, Int32 ID)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetLightSourceName(ID);
    //    }
    //    public static Boolean AddLightSource(IModelDocObject IModelDocinstance, String IdName, Int32 LTyp, String UserName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddLightSource(IdName, LTyp, UserName);
    //    }
    //    public static Int32 AddLightSourceExtProperty(IModelDocObject IModelDocinstance, Int32 ID, Object PropertyExtension)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddLightSourceExtProperty(ID, PropertyExtension);
    //    }
    //    public static void ResetLightSourceExtProperty(IModelDocObject IModelDocinstance, Int32 ID)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ResetLightSourceExtProperty(ID);
    //    }
    //    public static void DeleteLightSource(IModelDocObject IModelDocinstance, Int32 ID)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeleteLightSource(ID);
    //    }
    //    public static Object GetLightSourceExtProperty(IModelDocObject IModelDocinstance, Int32 ID, Int32 PropertyId)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetLightSourceExtProperty(ID, PropertyId);
    //    }
    //    public static Int32 AddLightToScene(IModelDocObject IModelDocinstance, String LpszNewValue)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddLightToScene(LpszNewValue);
    //    }
    //    public static Int32 AddSceneExtProperty(IModelDocObject IModelDocinstance, Object PropertyExtension)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddSceneExtProperty(PropertyExtension);
    //    }
    //    public static void ResetSceneExtProperty(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ResetSceneExtProperty();
    //    }
    //    public static Object GetSceneExtProperty(IModelDocObject IModelDocinstance, Int32 PropertyId)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetSceneExtProperty(PropertyId);
    //    }
    //    public static void FileSummaryInfo(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FileSummaryInfo();
    //    }
    //    public static Object GetGridSettings(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetGridSettings();
    //    }
    //    public static void ToolsSketchTranslate(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ToolsSketchTranslate();
    //    }
    //    public static void ToolsDistance(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ToolsDistance();
    //    }
    //    public static void SkToolsAutoConstr(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SkToolsAutoConstr();
    //    }
    //    public static void ToolsSketchScale(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ToolsSketchScale();
    //    }
    //    public static void Paste(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Paste();
    //    }
    //    public static void ToolsConfiguration(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ToolsConfiguration();
    //    }
    //    public static void EntityProperties(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EntityProperties();
    //    }
    //    public static Boolean GetArcCentersDisplayed(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetArcCentersDisplayed();
    //    }
    //    public static void SetArcCentersDisplayed(IModelDocObject IModelDocinstance, Boolean Setting)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetArcCentersDisplayed(Setting);
    //    }
    //    public static void AutoSolveToggle(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AutoSolveToggle();
    //    }
    //    public static void Dummy7(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Dummy7();
    //    }
    //    public static Double IGetLines(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetLines();
    //    }
    //    public static Int32 GetLineCount(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetLineCount();
    //    }
    //    public static void ICreateEllipse(IModelDocObject IModelDocinstance, Double& Center, Double& Major, Double& Minor)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ICreateEllipse(Center, Major, Minor);
    //    }
    //    public static void ICreateEllipticalArcByCenter(IModelDocObject IModelDocinstance, Double& Center, Double& Major, Double& Minor, Double& Start, Double& End)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ICreateEllipticalArcByCenter(Center, Major, Minor, Start, End);
    //    }
    //    public static void InsertCutSwept(IModelDocObject IModelDocinstance, Boolean Propagate, Boolean Alignment, Boolean KeepNormalConstant)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCutSwept(Propagate, Alignment, KeepNormalConstant);
    //    }
    //    public static void InsertCutBlend(IModelDocObject IModelDocinstance, Boolean Closed)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertCutBlend(Closed);
    //    }
    //    public static void InsertHelix(IModelDocObject IModelDocinstance, Boolean Reversed, Boolean Clockwised, Boolean Tapered, Boolean Outward, Int32 Helixdef, Double Height, Double Pitch, Double Revolution, Double TaperAngle, Double Startangle)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertHelix(Reversed, Clockwised, Tapered, Outward, Helixdef, Height, Pitch, Revolution, TaperAngle, Startangle);
    //    }
    //    public static void ICreateLine(IModelDocObject IModelDocinstance, Double& P1, Double& P2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ICreateLine(P1, P2);
    //    }
    //    public static void ICreateCenterLine(IModelDocObject IModelDocinstance, Double& P1, Double& P2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ICreateCenterLine(P1, P2);
    //    }
    //    public static void ICreateArc(IModelDocObject IModelDocinstance, Double& P1, Double& P2, Double& P3, Int16 Dir)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ICreateArc(P1, P2, P3, Dir);
    //    }
    //    public static void ICreateCircleByRadius(IModelDocObject IModelDocinstance, Double& P1, Double Radius)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ICreateCircleByRadius(P1, Radius);
    //    }
    //    public static void GraphicsRedraw(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GraphicsRedraw();
    //    }
    //    public static Boolean GetVisibilityOfConstructPlanes(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetVisibilityOfConstructPlanes();
    //    }
    //    public static Boolean GetDisplayWhenAdded(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetDisplayWhenAdded();
    //    }
    //    public static void SetDisplayWhenAdded(IModelDocObject IModelDocinstance, Boolean Setting)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetDisplayWhenAdded(Setting);
    //    }
    //    public static Boolean GetAddToDB(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetAddToDB();
    //    }
    //    public static void SetAddToDB(IModelDocObject IModelDocinstance, Boolean Setting)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetAddToDB(Setting);
    //    }
    //    public static Boolean DeSelectByID(IModelDocObject IModelDocinstance, String SelID, String SelParams, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeSelectByID(SelID, SelParams, X, Y, Z);
    //    }
    //    public static void PrintDirect(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.PrintDirect();
    //    }
    //    public static void PrintPreview(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.PrintPreview();
    //    }
    //    public static void Quit(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Quit();
    //    }
    //    public static void CreatePlaneThru3Points(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreatePlaneThru3Points();
    //    }
    //    public static void ViewRotXPlusNinety(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewRotXPlusNinety();
    //    }
    //    public static Object GetUnits(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetUnits();
    //    }
    //    public static void SetAngularUnits(IModelDocObject IModelDocinstance, Int16 UType, Int16 FractBase, Int16 FractDenom, Int16 SigDigits)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetAngularUnits(UType, FractBase, FractDenom, SigDigits);
    //    }
    //    public static Object GetAngularUnits(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetAngularUnits();
    //    }
    //    public static Int16 IGetUnits(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetUnits();
    //    }
    //    public static void ISetAngularUnits(IModelDocObject IModelDocinstance, Int16 UType, Int16 FractBase, Int16 FractDenom, Int16 SigDigits)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ISetAngularUnits(UType, FractBase, FractDenom, SigDigits);
    //    }
    //    public static Int16 IGetAngularUnits(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetAngularUnits();
    //    }
    //    public static void ShowConfiguration(IModelDocObject IModelDocinstance, String ConfigurationName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ShowConfiguration(ConfigurationName);
    //    }
    //    public static void ResetConfiguration(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ResetConfiguration();
    //    }
    //    public static void AddConfiguration(IModelDocObject IModelDocinstance, String Name, String Comment, String AlternateName, Boolean SuppressByDefault, Boolean HideByDefault, Boolean MinFeatureManager, Boolean InheritProperties, UInt32 Flags)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddConfiguration(Name, Comment, AlternateName, SuppressByDefault, HideByDefault, MinFeatureManager, InheritProperties, Flags);
    //    }
    //    public static void DeleteConfiguration(IModelDocObject IModelDocinstance, String ConfigurationName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeleteConfiguration(ConfigurationName);
    //    }
    //    public static void EditConfiguration(IModelDocObject IModelDocinstance, String Name, String NewName, String Comment, String AlternateName, Boolean SuppressByDefault, Boolean HideByDefault, Boolean MinFeatureManager, Boolean InheritProperties, UInt32 Flags)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditConfiguration(Name, NewName, Comment, AlternateName, SuppressByDefault, HideByDefault, MinFeatureManager, InheritProperties, Flags);
    //    }
    //    public static void CreatePlanePerCurveAndPassPoint(IModelDocObject IModelDocinstance, Boolean OrigAtCurve)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreatePlanePerCurveAndPassPoint(OrigAtCurve);
    //    }
    //    public static Object CreateFeatureMgrView(IModelDocObject IModelDocinstance, Int32& Bitmap)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateFeatureMgrView(Bitmap);
    //    }
    //    public static Boolean AddFeatureMgrView(IModelDocObject IModelDocinstance, Int32& Bitmap, Int32& AppView)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddFeatureMgrView(Bitmap, AppView);
    //    }
    //    public static Object GetStandardViewRotation(IModelDocObject IModelDocinstance, Int32 ViewId)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetStandardViewRotation(ViewId);
    //    }
    //    public static Double IGetStandardViewRotation(IModelDocObject IModelDocinstance, Int32 ViewId)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IGetStandardViewRotation(ViewId);
    //    }
    //    public static Int32 GetType(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetType();
    //    }
    //    public static void InsertObject(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertObject();
    //    }
    //    public static void EditClearAll(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditClearAll();
    //    }
    //    public static void EditCopy(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditCopy();
    //    }
    //    public static void EditCut(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditCut();
    //    }
    //    public static void ObjectDisplayContent(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ObjectDisplayContent();
    //    }
    //    public static void ObjectDisplayAsIcon(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ObjectDisplayAsIcon();
    //    }
    //    public static void ObjectResetsize(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ObjectResetsize();
    //    }
    //    public static void WindowRedraw(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.WindowRedraw();
    //    }
    //    public static void Dummy3(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Dummy3();
    //    }
    //    public static void SetPickMode(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetPickMode();
    //    }
    //    public static void ViewRotateminusx(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewRotateminusx();
    //    }
    //    public static void ViewRotateminusy(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewRotateminusy();
    //    }
    //    public static void ViewRotateminusz(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewRotateminusz();
    //    }
    //    public static void ViewRotateplusx(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewRotateplusx();
    //    }
    //    public static void ViewRotateplusy(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewRotateplusy();
    //    }
    //    public static void ViewRotateplusz(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewRotateplusz();
    //    }
    //    public static void ViewTranslateminusx(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewTranslateminusx();
    //    }
    //    public static void ViewTranslateminusy(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewTranslateminusy();
    //    }
    //    public static void ViewTranslateplusx(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewTranslateplusx();
    //    }
    //    public static void ViewTranslateplusy(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewTranslateplusy();
    //    }
    //    public static void ViewRotXMinusNinety(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewRotXMinusNinety();
    //    }
    //    public static void ViewRotYMinusNinety(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewRotYMinusNinety();
    //    }
    //    public static void ViewRotYPlusNinety(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewRotYPlusNinety();
    //    }
    //    public static void ViewZoomin(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewZoomin();
    //    }
    //    public static void ViewZoomout(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewZoomout();
    //    }
    //    public static void ViewDisplayHiddenremoved(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewDisplayHiddenremoved();
    //    }
    //    public static void ViewDisplayWireframe(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewDisplayWireframe();
    //    }
    //    public static void ViewDisplayShaded(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewDisplayShaded();
    //    }
    //    public static void ViewRwShading(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewRwShading();
    //    }
    //    public static void ViewOglShading(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewOglShading();
    //    }
    //    public static void ViewZoomtofit(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewZoomtofit();
    //    }
    //    public static void ViewRotate(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewRotate();
    //    }
    //    public static void ViewTranslate(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewTranslate();
    //    }
    //    public static void ViewZoomto(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewZoomto();
    //    }
    //    public static void ViewDisplayHiddengreyed(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewDisplayHiddengreyed();
    //    }
    //    public static void ViewDisplayFaceted(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewDisplayFaceted();
    //    }
    //    public static void ViewConstraint(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewConstraint();
    //    }
    //    public static void UserFavors(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.UserFavors();
    //    }
    //    public static void FeatureCirPattern(IModelDocObject IModelDocinstance, Int32 Num, Double Spacing, Boolean FlipDir, String DName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureCirPattern(Num, Spacing, FlipDir, DName);
    //    }
    //    public static void EditSketch(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditSketch();
    //    }
    //    public static void FeatEdit(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatEdit();
    //    }
    //    public static void FeatEditDef(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatEditDef();
    //    }
    //    public static void InsertPoint(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertPoint();
    //    }
    //    public static void InsertFamilyTableNew(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertFamilyTableNew();
    //    }
    //    public static void Dummy1(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Dummy1();
    //    }
    //    public static void InsertFamilyTableEdit(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertFamilyTableEdit();
    //    }
    //    public static void Dummy2(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Dummy2();
    //    }
    //    public static void ToolsMacro(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ToolsMacro();
    //    }
    //    public static void ToolsGrid(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ToolsGrid();
    //    }
    //    public static void SketchCenterline(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchCenterline();
    //    }
    //    public static void SketchAlign(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchAlign();
    //    }
    //    public static void SketchArc(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchArc();
    //    }
    //    public static void SketchTangentArc(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchTangentArc();
    //    }
    //    public static void SketchCircle(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchCircle();
    //    }
    //    public static void SketchUndo(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchUndo();
    //    }
    //    public static void UserPreferences(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.UserPreferences();
    //    }
    //    public static void Lights(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Lights();
    //    }
    //    public static void SketchConstrainCoincident(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchConstrainCoincident();
    //    }
    //    public static void SketchConstrainConcentric(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchConstrainConcentric();
    //    }
    //    public static void SketchConstrainPerp(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchConstrainPerp();
    //    }
    //    public static void SketchConstrainTangent(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchConstrainTangent();
    //    }
    //    public static void SketchConstrainParallel(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchConstrainParallel();
    //    }
    //    public static void SketchUseEdge(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchUseEdge();
    //    }
    //    public static void SketchUseEdgeCtrline(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchUseEdgeCtrline();
    //    }
    //    public static void SketchMirror(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchMirror();
    //    }
    //    public static void Save(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Save();
    //    }
    //    public static void Close(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Close();
    //    }
    //    public static void ViewDispRefaxes(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewDispRefaxes();
    //    }
    //    public static void ViewDispRefplanes(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ViewDispRefplanes();
    //    }
    //    public static void InsertSketch(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertSketch();
    //    }
    //    public static void InsertProtrusionSwept(IModelDocObject IModelDocinstance, Boolean Propagate, Boolean Alignment, Boolean KeepNormalConstant)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertProtrusionSwept(Propagate, Alignment, KeepNormalConstant);
    //    }
    //    public static void InsertProtrusionBlend(IModelDocObject IModelDocinstance, Boolean Closed)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertProtrusionBlend(Closed);
    //    }
    //    public static void ToolsMassProps(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ToolsMassProps();
    //    }
    //    public static void PropertySheet(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.PropertySheet();
    //    }
    //    public static void BlankRefGeom(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.BlankRefGeom();
    //    }
    //    public static void UnBlankRefGeom(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.UnBlankRefGeom();
    //    }
    //    public static void EditDelete(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.EditDelete();
    //    }
    //    public static void InsertProjectedSketch(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertProjectedSketch();
    //    }
    //    public static Boolean CreatePlaneFixed(IModelDocObject IModelDocinstance, Object P1, Object P2, Object P3, Boolean UseGlobal)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreatePlaneFixed(P1, P2, P3, UseGlobal);
    //    }
    //    public static void Dummy5(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Dummy5();
    //    }
    //    public static void Dummy6(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Dummy6();
    //    }
    //    public static void DebugCheckBody(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DebugCheckBody();
    //    }
    //    public static void Dummy8(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Dummy8();
    //    }
    //    public static void DimPreferences(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DimPreferences();
    //    }
    //    public static void FeatureFillet(IModelDocObject IModelDocinstance, Double R1, Boolean Propagate, Boolean Ftyp, Boolean VarRadTyp, Int32 OverflowType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureFillet(R1, Propagate, Ftyp, VarRadTyp, OverflowType);
    //    }
    //    public static void GridOptions(IModelDocObject IModelDocinstance, Boolean DispGrid, Double GridSpacing, Boolean Snap, Boolean DotStyle, Int16 NMajor, Int16 NMinor, Boolean Align2edge, Boolean AngleSnap, Double AngleUnit, Boolean MinorAuto)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GridOptions(DispGrid, GridSpacing, Snap, DotStyle, NMajor, NMinor, Align2edge, AngleSnap, AngleUnit, MinorAuto);
    //    }
    //    public static void SetUnits(IModelDocObject IModelDocinstance, Int16 UType, Int16 FractBase, Int16 FractDenom, Int16 SigDigits, Boolean RoundToFraction)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetUnits(UType, FractBase, FractDenom, SigDigits, RoundToFraction);
    //    }
    //    public static void LBDownAt(IModelDocObject IModelDocinstance, Int32 Flags, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.LBDownAt(Flags, X, Y, Z);
    //    }
    //    public static void LBUpAt(IModelDocObject IModelDocinstance, Int32 Flags, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.LBUpAt(Flags, X, Y, Z);
    //    }
    //    public static void DragTo(IModelDocObject IModelDocinstance, Int32 Flags, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DragTo(Flags, X, Y, Z);
    //    }
    //    public static void SelectAt(IModelDocObject IModelDocinstance, Int32 Flags, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectAt(Flags, X, Y, Z);
    //    }
    //    public static void CreateLineVB(IModelDocObject IModelDocinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateLineVB(X1, Y1, Z1, X2, Y2, Z2);
    //    }
    //    public static Boolean CreateLine(IModelDocObject IModelDocinstance, Object P1, Object P2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateLine(P1, P2);
    //    }
    //    public static void CreateCenterLineVB(IModelDocObject IModelDocinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateCenterLineVB(X1, Y1, Z1, X2, Y2, Z2);
    //    }
    //    public static Boolean CreateCenterLine(IModelDocObject IModelDocinstance, Object P1, Object P2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateCenterLine(P1, P2);
    //    }
    //    public static void CreateArcVB(IModelDocObject IModelDocinstance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z, Double P3x, Double P3y, Double P3z, Int16 Dir)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateArcVB(P1x, P1y, P1z, P2x, P2y, P2z, P3x, P3y, P3z, Dir);
    //    }
    //    public static Boolean CreateArc(IModelDocObject IModelDocinstance, Object P1, Object P2, Object P3, Int16 Dir)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateArc(P1, P2, P3, Dir);
    //    }
    //    public static void CreateCircleVB(IModelDocObject IModelDocinstance, Double P1x, Double P1y, Double P1z, Double Radius)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateCircleVB(P1x, P1y, P1z, Radius);
    //    }
    //    public static Boolean CreateCircleByRadius(IModelDocObject IModelDocinstance, Object P1, Double Radius)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateCircleByRadius(P1, Radius);
    //    }
    //    public static Object GetLines(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetLines();
    //    }
    //    public static void SketchTrim(IModelDocObject IModelDocinstance, Int32 Op, Int32 SelEnd, Double X, Double Y)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchTrim(Op, SelEnd, X, Y);
    //    }
    //    public static void SketchOffsetEdges(IModelDocObject IModelDocinstance, Double Val)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchOffsetEdges(Val);
    //    }
    //    public static void SketchRectangle(IModelDocObject IModelDocinstance, Double Val1, Double Val2, Double Z1, Double Val3, Double Val4, Double Z2, Boolean Val5)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchRectangle(Val1, Val2, Z1, Val3, Val4, Z2, Val5);
    //    }
    //    public static void SketchPoint(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchPoint(X, Y, Z);
    //    }
    //    public static void FeatureCut(IModelDocObject IModelDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureCut(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2);
    //    }
    //    public static void FeatureBoss(IModelDocObject IModelDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureBoss(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2);
    //    }
    //    public static void SimpleHole(IModelDocObject IModelDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SimpleHole(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2);
    //    }
    //    public static void FeatureLinearPattern(IModelDocObject IModelDocinstance, Int32 Num1, Double Spacing1, Int32 Num2, Double Spacing2, Boolean FlipDir1, Boolean FlipDir2, String DName1, String DName2)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureLinearPattern(Num1, Spacing1, Num2, Spacing2, FlipDir1, FlipDir2, DName1, DName2);
    //    }
    //    public static void NameView(IModelDocObject IModelDocinstance, String VName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.NameView(VName);
    //    }
    //    public static void ShowNamedView(IModelDocObject IModelDocinstance, String VName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ShowNamedView(VName);
    //    }
    //    public static void CreatePlaneAtOffset(IModelDocObject IModelDocinstance, Double Val, Boolean FlipDir)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreatePlaneAtOffset(Val, FlipDir);
    //    }
    //    public static void Toolbars(IModelDocObject IModelDocinstance, Boolean M, Boolean Vw, Boolean SkMain, Boolean Sk, Boolean Feat, Boolean Constr, Boolean Macro)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Toolbars(M, Vw, SkMain, Sk, Feat, Constr, Macro);
    //    }
    //    public static void CreatePlaneAtAngle(IModelDocObject IModelDocinstance, Double Val, Boolean FlipDir)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreatePlaneAtAngle(Val, FlipDir);
    //    }
    //    public static void SetParamValue(IModelDocObject IModelDocinstance, Double Val)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SetParamValue(Val);
    //    }
    //    public static void AddRelation(IModelDocObject IModelDocinstance, String RelStr)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddRelation(RelStr);
    //    }
    //    public static void DeleteAllRelations(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.DeleteAllRelations();
    //    }
    //    public static void HoleWizard(IModelDocObject IModelDocinstance, Double Depth, Int16 EndType, Boolean Flip, Boolean Dir, Int32 HType, Double D1, Double D2, Double D3, Double D4, Double D5, Double D6, Double D7, Double D8, Double D9, Double D10, Double D11, Double D12)
    //    {
    //        return IModelDocinstance.IModelDocInstance.HoleWizard(Depth, EndType, Flip, Dir, HType, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12);
    //    }
    //    public static Boolean SaveAs(IModelDocObject IModelDocinstance, String NewName)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SaveAs(NewName);
    //    }
    //    public static void ActivateSelectedFeature(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ActivateSelectedFeature();
    //    }
    //    public static void SelectByName(IModelDocObject IModelDocinstance, Int32 Flags, String IdStr)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectByName(Flags, IdStr);
    //    }
    //    public static void SketchAddConstraints(IModelDocObject IModelDocinstance, String IdStr)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchAddConstraints(IdStr);
    //    }
    //    public static void SketchConstraintsDel(IModelDocObject IModelDocinstance, Int32 ConstrInd, String IdStr)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchConstraintsDel(ConstrInd, IdStr);
    //    }
    //    public static void SketchConstraintsDelAll(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchConstraintsDelAll();
    //    }
    //    public static void Lock(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Lock();
    //    }
    //    public static void UnLock(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.UnLock();
    //    }
    //    public static void InsertFeatureShell(IModelDocObject IModelDocinstance, Double Thickness, Boolean Outward)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertFeatureShell(Thickness, Outward);
    //    }
    //    public static void SketchFillet(IModelDocObject IModelDocinstance, Double Rad)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchFillet(Rad);
    //    }
    //    public static void FeatureChamfer(IModelDocObject IModelDocinstance, Double Width, Double Angle, Boolean Flip)
    //    {
    //        return IModelDocinstance.IModelDocInstance.FeatureChamfer(Width, Angle, Flip);
    //    }
    //    public static void InsertMfDraft(IModelDocObject IModelDocinstance, Double Angle, Boolean FlipDir, Boolean IsEdgeDraft, Int32 PropType)
    //    {
    //        return IModelDocinstance.IModelDocInstance.InsertMfDraft(Angle, FlipDir, IsEdgeDraft, PropType);
    //    }
    //    public static void ParentChildRelationship(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ParentChildRelationship();
    //    }
    //    public static void SketchSpline(IModelDocObject IModelDocinstance, Int32 MorePts, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SketchSpline(MorePts, X, Y, Z);
    //    }
    //    public static void SelectSketchPoint(IModelDocObject IModelDocinstance, Double X, Double Y, Int32 Incidence)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectSketchPoint(X, Y, Incidence);
    //    }
    //    public static void SelectSketchLine(IModelDocObject IModelDocinstance, Double X0, Double Y0, Int32 Inc0, Double X1, Double Y1, Int32 Inc1)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectSketchLine(X0, Y0, Inc0, X1, Y1, Inc1);
    //    }
    //    public static void SelectSketchArc(IModelDocObject IModelDocinstance, Double X0, Double Y0, Int32 Inc0, Double X1, Double Y1, Int32 Inc1, Double XC, Double YC, Int32 IncC, Int32 RotDir)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectSketchArc(X0, Y0, Inc0, X1, Y1, Inc1, XC, YC, IncC, RotDir);
    //    }
    //    public static void SelectSketchSpline(IModelDocObject IModelDocinstance, Int32 Size, Double X0, Double Y0, Int32 Inc0, Double X1, Double Y1, Int32 Inc1, Double XC, Double YC, Int32 IncC)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectSketchSpline(Size, X0, Y0, Inc0, X1, Y1, Inc1, XC, YC, IncC);
    //    }
    //    public static Boolean CreateTangentArc(IModelDocObject IModelDocinstance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateTangentArc(P1x, P1y, P1z, P2x, P2y, P2z);
    //    }
    //    public static Boolean Create3PointArc(IModelDocObject IModelDocinstance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z, Double P3x, Double P3y, Double P3z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Create3PointArc(P1x, P1y, P1z, P2x, P2y, P2z, P3x, P3y, P3z);
    //    }
    //    public static Boolean CreateArcByCenter(IModelDocObject IModelDocinstance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z, Double P3x, Double P3y, Double P3z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateArcByCenter(P1x, P1y, P1z, P2x, P2y, P2z, P3x, P3y, P3z);
    //    }
    //    public static Boolean CreateCircle(IModelDocObject IModelDocinstance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateCircle(P1x, P1y, P1z, P2x, P2y, P2z);
    //    }
    //    public static Boolean AddDimension(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddDimension(X, Y, Z);
    //    }
    //    public static Boolean AddHorizontalDimension(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddHorizontalDimension(X, Y, Z);
    //    }
    //    public static Boolean AddVerticalDimension(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AddVerticalDimension(X, Y, Z);
    //    }
    //    public static Boolean SelectSketchItem(IModelDocObject IModelDocinstance, Int32 SelOpt, String Name, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectSketchItem(SelOpt, Name, X, Y, Z);
    //    }
    //    public static void ClearSelection(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ClearSelection();
    //    }
    //    public static void Select(IModelDocObject IModelDocinstance, String SelID, String SelParams, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Select(SelID, SelParams, X, Y, Z);
    //    }
    //    public static void AndSelect(IModelDocObject IModelDocinstance, String SelID, String SelParams, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.AndSelect(SelID, SelParams, X, Y, Z);
    //    }
    //    public static Boolean CreatePoint(IModelDocObject IModelDocinstance, Double PointX, Double PointY, Double PointZ)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreatePoint(PointX, PointY, PointZ);
    //    }
    //    public static Boolean CreateLineDB(IModelDocObject IModelDocinstance, Double Sx, Double Sy, Double Sz, Double Ex, Double Ey, Double Ez)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateLineDB(Sx, Sy, Sz, Ex, Ey, Ez);
    //    }
    //    public static Boolean CreateArcDB(IModelDocObject IModelDocinstance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2, Double X3, Double Y3, Double Z3, Int16 Dir)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateArcDB(X1, Y1, Z1, X2, Y2, Z2, X3, Y3, Z3, Dir);
    //    }
    //    public static Boolean CreateCircleDB(IModelDocObject IModelDocinstance, Double Cx, Double Cy, Double Cz, Double Radius)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreateCircleDB(Cx, Cy, Cz, Radius);
    //    }
    //    public static Boolean CreatePointDB(IModelDocObject IModelDocinstance, Double X, Double Y, Double Z)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CreatePointDB(X, Y, Z);
    //    }
    //    public static String GetTitle(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetTitle();
    //    }
    //    public static String GetPathName(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.GetPathName();
    //    }
    //    public static Object SelectionManager(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SelectionManager;
    //    }
    //    public static ISelectionMgrObject ISelectionManager(IModelDocObject IModelDocinstance)
    //    {
    //        return new ISelectionMgrObject(IModelDocinstance.IModelDocInstance.ISelectionManager);
    //    }
    //    public static Object ActiveView(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ActiveView;
    //    }
    //    public static IModelViewObject IActiveView(IModelDocObject IModelDocinstance)
    //    {
    //        return new IModelViewObject(IModelDocinstance.IModelDocInstance.IActiveView);
    //    }
    //    public static Int32 LengthUnit(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.LengthUnit;
    //    }
    //    public static String LightSourceUserName(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.LightSourceUserName;
    //    }
    //    public static Object LightSourcePropertyValues(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.LightSourcePropertyValues;
    //    }
    //    public static String SceneName(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SceneName;
    //    }
    //    public static String SceneUserName(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SceneUserName;
    //    }
    //    public static Double ILightSourcePropertyValues(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ILightSourcePropertyValues;
    //    }
    //    public static Boolean Visible(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.Visible;
    //    }
    //    public static String MaterialUserName(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.MaterialUserName;
    //    }
    //    public static String MaterialIdName(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.MaterialIdName;
    //    }
    //    public static Object MaterialPropertyValues(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.MaterialPropertyValues;
    //    }
    //    public static Double IMaterialPropertyValues(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.IMaterialPropertyValues;
    //    }
    //    public static Int16 PrintSetup(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.PrintSetup;
    //    }
    //    public static String SceneBkgImageFileName(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SceneBkgImageFileName;
    //    }
    //    public static String SummaryInfo(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.SummaryInfo;
    //    }
    //    public static String CustomInfo(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CustomInfo;
    //    }
    //    public static String CustomInfo2(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.CustomInfo2;
    //    }
    //    public static Boolean ShowFeatureErrorDialog(IModelDocObject IModelDocinstance)
    //    {
    //        return IModelDocinstance.IModelDocInstance.ShowFeatureErrorDialog;
    //    }
    //}
}