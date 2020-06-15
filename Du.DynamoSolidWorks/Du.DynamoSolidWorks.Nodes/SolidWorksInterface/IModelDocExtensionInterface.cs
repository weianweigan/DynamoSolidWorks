using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IModelDocExtensionObject
    {
        public IModelDocExtension IModelDocExtensionInstance { get; set; }
        public IModelDocExtensionObject(IModelDocExtension IModelDocExtensioninstance)
        {
            IModelDocExtensionInstance = IModelDocExtensioninstance;
        }
    }
    public static class IModelDocExtensionInterface
    {
        public static Object GetCommandTabs(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetCommandTabs();
        }
        public static Boolean Rebuild(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Options)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.Rebuild(Options);
        }
        //public static Boolean GetSunLightSourcePropertyValues(IModelDocExtensionObject IModelDocExtensioninstance, MathVector&Object NorthDirection, Double& NorthLatitude, Double& EastLongitude, Double& TimeZone, String& DateTime)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetSunLightSourcePropertyValues(NorthDirection, NorthLatitude, EastLongitude, TimeZone, DateTime);
        //}
        public static Boolean SetSunLightSourcePropertyValues(IModelDocExtensionObject IModelDocExtensioninstance, IMathVectorObject NorthDirection, Double NorthLatitude, Double EastLongitude, Double TimeZone, String DateTime)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SetSunLightSourcePropertyValues(NorthDirection?.IMathVectorInstance?.CastObj<MathVector>(), NorthLatitude, EastLongitude, TimeZone, DateTime);
        }
        public static Boolean UpdateStandardViews(IModelDocExtensionObject IModelDocExtensioninstance, String ViewName, Int32 ViewId)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.UpdateStandardViews(ViewName, ViewId);
        }
        public static Boolean ResetStandardViews(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ResetStandardViews();
        }
        public static ITableAnnotationObject InsertGeneralTableAnnotation(IModelDocExtensionObject IModelDocExtensioninstance, Boolean UseAnchorPoint, Double X, Double Y, Int32 AnchorType, String TableTemplate, Int32 Rows, Int32 Columns)
        {
            return new ITableAnnotationObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertGeneralTableAnnotation(UseAnchorPoint, X, Y, AnchorType, TableTemplate, Rows, Columns));
        }
        public static Boolean EditDimensionProperties(IModelDocExtensionObject IModelDocExtensioninstance, Int32 TolType, Double TolMax, Double TolMin, String TolMaxFit, String TolMinFit, Boolean UseDocPrec, Int32 Precision, Int32 ArrowsIn, Boolean UseDocArrows, Int32 Arrow1, Int32 Arrow2, String PrefixText, String SuffixText, Boolean ShowValue, String CalloutText1, String CalloutText2, String DimensionLowerText, Boolean CenterText, Int32 ConfigOption, Object ConfigNames)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.EditDimensionProperties(TolType, TolMax, TolMin, TolMaxFit, TolMinFit, UseDocPrec, Precision, ArrowsIn, UseDocArrows, Arrow1, Arrow2, PrefixText, SuffixText, ShowValue, CalloutText1, CalloutText2, DimensionLowerText, CenterText, ConfigOption, ConfigNames);
        }
        //public static Boolean IEditDimensionProperties(IModelDocExtensionObject IModelDocExtensioninstance, Int32 TolType, Double TolMax, Double TolMin, String TolMaxFit, String TolMinFit, Boolean UseDocPrec, Int32 Precision, Int32 ArrowsIn, Boolean UseDocArrows, Int32 Arrow1, Int32 Arrow2, String PrefixText, String SuffixText, Boolean ShowValue, String CalloutText1, String CalloutText2, String DimensionLowerText, Boolean CenterText, Int32 ConfigOption, Int32 Count, String& ConfigNames)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IEditDimensionProperties(TolType, TolMax, TolMin, TolMaxFit, TolMinFit, UseDocPrec, Precision, ArrowsIn, UseDocArrows, Arrow1, Arrow2, PrefixText, SuffixText, ShowValue, CalloutText1, CalloutText2, DimensionLowerText, CenterText, ConfigOption, Count, ConfigNames);
        //}
        //public static Object AddAngularRunningDim(IModelDocExtensionObject IModelDocExtensioninstance, Boolean DisplayAsChain, Boolean RunBidirectionally, Boolean ExtensionLineExtendsFromCenterOfSet, Double LocX, Double LocY, Double LocZ, Int32& Retval)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.AddAngularRunningDim(DisplayAsChain, RunBidirectionally, ExtensionLineExtendsFromCenterOfSet, LocX, LocY, LocZ, Retval);
        //}
        public static void AlignRunningDimension(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.AlignRunningDimension();
        }
        public static void ReJogRunningDimension(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.ReJogRunningDimension();
        }
        public static Object AddPathLengthDim(IModelDocExtensionObject IModelDocExtensioninstance, Double X, Double Y, Double Z)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.AddPathLengthDim(X, Y, Z);
        }
        public static Object EditBalloonProperties2(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Style, Int32 Size, Int32 UpperTextStyle, String UpperText, Int32 LowerTextStyle, String LowerText, Double CustomSize, Boolean ShowQuantity, Int16 QuantityPlacement, String QuantityDenotationText, Double QuantityDistance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.EditBalloonProperties2(Style, Size, UpperTextStyle, UpperText, LowerTextStyle, LowerText, CustomSize, ShowQuantity, QuantityPlacement, QuantityDenotationText, QuantityDistance);
        }
        public static Int32 GetObjectId(IModelDocExtensionObject IModelDocExtensioninstance, IAnnotationObject Annotation)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetObjectId(Annotation?.IAnnotationInstance.CastObj<Annotation>());
        }
        public static Boolean IsAbbreviatedViewActive(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.IsAbbreviatedViewActive();
        }
        public static Boolean ReorderFeature(IModelDocExtensionObject IModelDocExtensioninstance, String FeatureToMove, String TargetFeature, Int32 MoveLocation)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ReorderFeature(FeatureToMove, TargetFeature, MoveLocation);
        }
        public static IView3DObject Capture3DView(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return new IView3DObject(IModelDocExtensioninstance.IModelDocExtensionInstance.Capture3DView());
        }
        public static IView3DObject Get3DView(IModelDocExtensionObject IModelDocExtensioninstance, String Name)
        {
            return new IView3DObject(IModelDocExtensioninstance.IModelDocExtensionInstance.Get3DView(Name));
        }
        public static Object Get3DViews(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.Get3DViews();
        }
        public static void Refresh3DViews(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.Refresh3DViews();
        }
        public static Object GetPrintSpecification(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetPrintSpecification();
        }
        public static void PrintOut4(IModelDocExtensionObject IModelDocExtensioninstance, String Printer, String PrintFileName, Object PrintSpecification)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.PrintOut4(Printer, PrintFileName, PrintSpecification);
        }
        public static Int32 GetRenderMaterialsCount2(IModelDocExtensionObject IModelDocExtensioninstance, Int32 DisplayStateOption, Object DisplayStateNames)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetRenderMaterialsCount2(DisplayStateOption, DisplayStateNames);
        }
        public static Object GetRenderMaterials2(IModelDocExtensionObject IModelDocExtensioninstance, Int32 DisplayStateOption, Object DisplayStateNames)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetRenderMaterials2(DisplayStateOption, DisplayStateNames);
        }
        public static Object GetScanto3D(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetScanto3D();
        }
        public static Boolean HasMaterialPropertyValues(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.HasMaterialPropertyValues();
        }
        //public static Boolean GetSunLightAdvancedPropertyValues(IModelDocExtensionObject IModelDocExtensioninstance, Double& Haze, Double& SunDiameter, Int32& GroundAlbedo, Double& SkyGamma)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetSunLightAdvancedPropertyValues(Haze, SunDiameter, GroundAlbedo, SkyGamma);
        //}
        public static Boolean SetSunLightAdvancedPropertyValues(IModelDocExtensionObject IModelDocExtensioninstance, Double Haze, Double SunDiameter, Int32 GroundAlbedo, Double SkyGamma)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SetSunLightAdvancedPropertyValues(Haze, SunDiameter, GroundAlbedo, SkyGamma);
        }
        public static Boolean UpdateSunLight(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.UpdateSunLight();
        }
        public static Object Get3DViewNames(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.Get3DViewNames();
        }
        public static Int32 Get3DViewCount(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.Get3DViewCount();
        }
        public static Object AddDimension(IModelDocExtensionObject IModelDocExtensioninstance, Double X, Double Y, Double Z, Int32 Direction)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.AddDimension(X, Y, Z, Direction);
        }
        //public static Int32 GetModelBreakViewNames(IModelDocExtensionObject IModelDocExtensioninstance, Object& Views)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetModelBreakViewNames(Views);
        //}
        public static Boolean ShowModelBreakView(IModelDocExtensionObject IModelDocExtensioninstance, Boolean ShowView, String ViewName)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ShowModelBreakView(ShowView, ViewName);
        }
        public static Object AddSymmetricDimension(IModelDocExtensionObject IModelDocExtensioninstance, Double X, Double Y, Double Z)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.AddSymmetricDimension(X, Y, Z);
        }
        public static ITableAnnotationObject GetGeneralTableAnnotation(IModelDocExtensionObject IModelDocExtensioninstance, Boolean UseAnchorPoint, Double X, Double Y, Int32 AnchorType, String TableTemplate, Int32 Rows, Int32 Columns)
        {
            return new ITableAnnotationObject(IModelDocExtensioninstance.IModelDocExtensionInstance.GetGeneralTableAnnotation(UseAnchorPoint, X, Y, AnchorType, TableTemplate, Rows, Columns));
        }
        public static Int32 PublishTo3DPDF(IModelDocExtensionObject IModelDocExtensioninstance, Object MBDPdfData)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.PublishTo3DPDF(MBDPdfData);
        }
        //public static Object GetMassProperties2(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Accuracy, Int32& Status, Boolean UseSelected)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetMassProperties2(Accuracy, Status, UseSelected);
        //}
        public static Object GetMBD3DPdfData(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetMBD3DPdfData();
        }
        public static Int32 RenameDocument(IModelDocExtensionObject IModelDocExtensioninstance, String NewName)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.RenameDocument(NewName);
        }
        public static Boolean HasRenamedDocuments(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.HasRenamedDocuments();
        }
        //public static Boolean IsExploded(IModelDocExtensionObject IModelDocExtensioninstance, String& ViewName)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IsExploded(ViewName);
        //}
        public static void ViewZoomToSheet(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.ViewZoomToSheet();
        }
        public static Boolean SketchOffsetOnSurface(IModelDocExtensionObject IModelDocExtensioninstance, Double Offset, Boolean Reverse, Boolean UseFront, Boolean MakeConstruct)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SketchOffsetOnSurface(Offset, Reverse, UseFront, MakeConstruct);
        }
        //public static Object SaveSelection(IModelDocExtensionObject IModelDocExtensioninstance, Int32& Status)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.SaveSelection(Status);
        //}
        public static Boolean EditRebuildAll(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.EditRebuildAll();
        }
        public static Boolean ForceRebuildAll(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ForceRebuildAll();
        }
        public static Int32 PublishSTEP242File(IModelDocExtensionObject IModelDocExtensioninstance, String Path)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.PublishSTEP242File(Path);
        }
        public static Boolean SelectByRay(IModelDocExtensionObject IModelDocExtensioninstance, Double WorldX, Double WorldY, Double WorldZ, Double RayVecX, Double RayVecY, Double RayVecZ, Double RayRadius, Int32 TypeWanted, Boolean Append, Int32 Mark, Int32 Option)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SelectByRay(WorldX, WorldY, WorldZ, RayVecX, RayVecY, RayVecZ, RayRadius, TypeWanted, Append, Mark, Option);
        }
        public static Boolean Compare3DPMI(IModelDocExtensionObject IModelDocExtensioninstance, String ReferenceDocument, String ModifiedDocument, String ReportName, String ReportFolderPath, Int32 ReportSaveOptions)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.Compare3DPMI(ReferenceDocument, ModifiedDocument, ReportName, ReportFolderPath, ReportSaveOptions);
        }
        public static Object CreateAdvancedHoleElementData(IModelDocExtensionObject IModelDocExtensioninstance, Int32 ElmType)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.CreateAdvancedHoleElementData(ElmType);
        }
        //public static Object AddSpecificDimension(IModelDocExtensionObject IModelDocExtensioninstance, Double X, Double Y, Double Z, Int32 DimensionType, Int32& Error)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.AddSpecificDimension(X, Y, Z, DimensionType, Error);
        //}
        public static IGeneralToleranceTableAnnotationObject InsertGeneralToleranceTableAnnotation(IModelDocExtensionObject IModelDocExtensioninstance, String TemplateName, Int32 X, Int32 Y)
        {
            return new IGeneralToleranceTableAnnotationObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertGeneralToleranceTableAnnotation(TemplateName, X, Y));
        }
        public static String GetCalloutVariableString(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Variable)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetCalloutVariableString(Variable);
        }
        public static Object GetCorresponding2(IModelDocExtensionObject IModelDocExtensioninstance, Object InputObject)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetCorresponding2(InputObject);
        }
        public static Object GetCorrespondingEntity2(IModelDocExtensionObject IModelDocExtensioninstance, Object Entity)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetCorrespondingEntity2(Entity);
        }
        public static Object GetDependencies(IModelDocExtensionObject IModelDocExtensioninstance, Boolean Traverseflag, Boolean Searchflag, Boolean AddReadOnlyInfo, Boolean ListBrokenRefs, Boolean AppendImportedPaths)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetDependencies(Traverseflag, Searchflag, AddReadOnlyInfo, ListBrokenRefs, AppendImportedPaths);
        }
        public static IDatumTargetSymObject InsertDatumTargetSymbol3(IModelDocExtensionObject IModelDocExtensioninstance, String Datum1, String Datum2, String Datum3, Int32 AreaStyle, Boolean AreaOutside, Double Value1, Double Value2, String ValueStr1, String ValueStr2, Boolean ArrowsSmart, Int32 ArrowStyle, Int32 LeaderLineStyle, Boolean LeaderBent, Boolean ShowArea, Boolean ShowSymbol, Int32 MoveableDatumStyle)
        {
            return new IDatumTargetSymObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertDatumTargetSymbol3(Datum1, Datum2, Datum3, AreaStyle, AreaOutside, Value1, Value2, ValueStr1, ValueStr2, ArrowsSmart, ArrowStyle, LeaderLineStyle, LeaderBent, ShowArea, ShowSymbol, MoveableDatumStyle));
        }
        public static Boolean SetTopLevelTransparency(IModelDocExtensionObject IModelDocExtensioninstance, Boolean InValue)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SetTopLevelTransparency(InValue);
        }
        public static Int32 RayIntersections(IModelDocExtensionObject IModelDocExtensioninstance, Object BodiesIn, Object BasePointsIn, Object VectorsIn, Int32 Options, Double HitRadius, Double Offset, Boolean HighPrecision)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.RayIntersections(BodiesIn, BasePointsIn, VectorsIn, Options, HitRadius, Offset, HighPrecision);
        }
        public static void ShowSmartMessage(IModelDocExtensionObject IModelDocExtensioninstance, String Name, Int32 TimeInMillSec, Boolean ShowInStatusBar, Boolean RemoveDefaultTip)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.ShowSmartMessage(Name, TimeInMillSec, ShowInStatusBar, RemoveDefaultTip);
        }
        public static void ApplyFormatPainterToAll(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.ApplyFormatPainterToAll();
        }
        public static IBomTableAnnotationObject InsertBomTable(IModelDocExtensionObject IModelDocExtensioninstance, String TemplateName, Int32 X, Int32 Y, Int32 BomType, String ConfigurationName)
        {
            return new IBomTableAnnotationObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertBomTable(TemplateName, X, Y, BomType, ConfigurationName));
        }
        public static Object GetDraftingStandardNames(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetDraftingStandardNames();
        }
        public static Boolean LoadDraftingStandard(IModelDocExtensionObject IModelDocExtensioninstance, String FileName)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.LoadDraftingStandard(FileName);
        }
        public static Boolean SaveDraftingStandard(IModelDocExtensionObject IModelDocExtensioninstance, String FileName)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SaveDraftingStandard(FileName);
        }
        public static Boolean RenameDraftingStandard(IModelDocExtensionObject IModelDocExtensioninstance, String Name)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.RenameDraftingStandard(Name);
        }
        public static Boolean CopyDraftingStandard(IModelDocExtensionObject IModelDocExtensioninstance, String Name)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.CopyDraftingStandard(Name);
        }
        public static Boolean DeleteDraftingStandard(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.DeleteDraftingStandard();
        }
        public static Boolean IsConverted(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.IsConverted();
        }
        public static Int32 GetLicenseType(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetLicenseType();
        }
        public static Int32 GetModelViewCount(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetModelViewCount();
        }
        public static Object GetModelViews(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetModelViews();
        }
        public static IModelViewObject IGetModelViews(IModelDocExtensionObject IModelDocExtensioninstance, Int32 NumModelViews)
        {
            return new IModelViewObject(IModelDocExtensioninstance.IModelDocExtensionInstance.IGetModelViews(NumModelViews));
        }
        public static Object FindTrackedObjects(IModelDocExtensionObject IModelDocExtensioninstance, Int32 TrackingCookie, Object SearchObject, Object TypesFilter, Object TrackingIDs)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.FindTrackedObjects(TrackingCookie, SearchObject, TypesFilter, TrackingIDs);
        }
        public static Int32 GetWhatsWrongCount(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetWhatsWrongCount();
        }
        //public static Boolean GetWhatsWrong(IModelDocExtensionObject IModelDocExtensioninstance, Object& Features, Object& ErrorCodes, Object& Warnings)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetWhatsWrong(Features, ErrorCodes, Warnings);
        //}
        public static Object GetFlattenSheetMetalPersistReference(IModelDocExtensionObject IModelDocExtensioninstance, Object DispObj)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetFlattenSheetMetalPersistReference(DispObj);
        }
        public static Byte IGetFlattenSheetMetalPersistReference(IModelDocExtensionObject IModelDocExtensioninstance, Object DispObj, Int32 Count)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetFlattenSheetMetalPersistReference(DispObj, Count);
        }
        //public static Object GetSheetMetalObjectsByPersistReference(IModelDocExtensionObject IModelDocExtensioninstance, Object PersistId, Int32& ErrorCode)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetSheetMetalObjectsByPersistReference(PersistId, ErrorCode);
        //}
        //public static Object IGetSheetMetalObjectsByPersistReference(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Count, Byte& PersistId, Int32& ErrorCode)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetSheetMetalObjectsByPersistReference(Count, PersistId, ErrorCode);
        //}
        public static Boolean SketchBoxSelect(IModelDocExtensionObject IModelDocExtensioninstance, Double FirstPtX, Double FirstPtY, Double FirstPtZ, Double SecondPtX, Double SecondPtY, Double SecondPtZ)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SketchBoxSelect(FirstPtX, FirstPtY, FirstPtZ, SecondPtX, SecondPtY, SecondPtZ);
        }
        public static Object InsertBOMBalloon(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Style, Int32 Size, Int32 UpperTextStyle, String UpperText, Int32 LowerTextStyle, String LowerText, Double CustomSize, Boolean ShowQuantity, Int16 QuantityPlacement, String QuantityDenotationText)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.InsertBOMBalloon(Style, Size, UpperTextStyle, UpperText, LowerTextStyle, LowerText, CustomSize, ShowQuantity, QuantityPlacement, QuantityDenotationText);
        }
        public static INoteObject InsertStackedBalloon(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Style, Int32 Size, Int32 UpperTextStyle, String UpperText, Int32 LowerTextStyle, String LowerText, Double CustomSize, Boolean ShowQuantity, Int16 QuantityPlacement, String QuantityDenotationText)
        {
            return new INoteObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertStackedBalloon(Style, Size, UpperTextStyle, UpperText, LowerTextStyle, LowerText, CustomSize, ShowQuantity, QuantityPlacement, QuantityDenotationText));
        }
        public static Object EditBalloonProperties(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Style, Int32 Size, Int32 UpperTextStyle, String UpperText, Int32 LowerTextStyle, String LowerText, Double CustomSize, Boolean ShowQuantity, Int16 QuantityPlacement, String QuantityDenotationText)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.EditBalloonProperties(Style, Size, UpperTextStyle, UpperText, LowerTextStyle, LowerText, CustomSize, ShowQuantity, QuantityPlacement, QuantityDenotationText);
        }
        public static Int32 IsSamePersistentID(IModelDocExtensionObject IModelDocExtensioninstance, Object PersistentID1, Object PersistentID2)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.IsSamePersistentID(PersistentID1, PersistentID2);
        }
        public static Boolean PurgeDisplayState(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.PurgeDisplayState();
        }
        public static ITitleBlockTableAnnotationObject InsertTitleBlockTable(IModelDocExtensionObject IModelDocExtensioninstance, String TemplateName, Int32 X, Int32 Y)
        {
            return new ITitleBlockTableAnnotationObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertTitleBlockTable(TemplateName, X, Y));
        }
        public static Boolean SaveDeFeaturedFile(IModelDocExtensionObject IModelDocExtensioninstance, String FileName)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SaveDeFeaturedFile(FileName);
        }
        public static Boolean InsertDeleteFace(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Option)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.InsertDeleteFace(Option);
        }
        public static IBomTableAnnotationObject InsertBomTable2(IModelDocExtensionObject IModelDocExtensioninstance, String TemplateName, Int32 X, Int32 Y, Int32 BomType, String ConfigurationName, Boolean Hidden)
        {
            return new IBomTableAnnotationObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertBomTable2(TemplateName, X, Y, BomType, ConfigurationName, Hidden));
        }
        public static Boolean SetTextureByDisplayState(IModelDocExtensionObject IModelDocExtensioninstance, String DisplayStateName, ITextureObject TextureIn)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SetTextureByDisplayState(DisplayStateName, TextureIn?.ITextureInstance?.CastObj<Texture>());
        }
        public static Boolean RemoveTextureByDisplayState(IModelDocExtensionObject IModelDocExtensioninstance, String DisplayStateName)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.RemoveTextureByDisplayState(DisplayStateName);
        }
        public static void PrintOut3(IModelDocExtensionObject IModelDocExtensioninstance, Object PageArray, Int32 Copies, Boolean Collate, String Printer, String PrintFileName, Boolean ConvertToHighQuality)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.PrintOut3(PageArray, Copies, Collate, Printer, PrintFileName, ConvertToHighQuality);
        }
        //public static void IPrintOut3(IModelDocExtensionObject IModelDocExtensioninstance, Int32 ArraySize, Int32& PageArray, Int32 Copies, Boolean Collate, String Printer, String PrintFileName, Boolean ConvertToHighQuality)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IPrintOut3(ArraySize, PageArray, Copies, Collate, Printer, PrintFileName, ConvertToHighQuality);
        //}
        public static IPackAndGoObject GetPackAndGo(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return new IPackAndGoObject(IModelDocExtensioninstance.IModelDocExtensionInstance.GetPackAndGo());
        }
        public static Object SavePackAndGo(IModelDocExtensionObject IModelDocExtensioninstance, IPackAndGoObject PackAndGo)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SavePackAndGo(PackAndGo?.IPackAndGoInstance?.CastObj<PackAndGo>());
        }
        //public static Boolean AddDisplayStateSpecificRenderMaterial(IModelDocExtensionObject IModelDocExtensioninstance, RenderMaterialObject PRenderMaterial, Int32 DisplayStateOption, Object DisplayStateNames, Int32& PWMaterialId1, Int32& PWMaterialId2)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.AddDisplayStateSpecificRenderMaterial(PRenderMaterial, DisplayStateOption, DisplayStateNames, PWMaterialId1, PWMaterialId2);
        //}
        //public static Boolean IAddDisplayStateSpecificRenderMaterial(IModelDocExtensionObject IModelDocExtensioninstance, RenderMaterialObject PRenderMaterial, Int32 DisplayStateOption, Int32 DisplayStateCount, String& DisplayStateNames, Int32& PWMaterialId1, Int32& PWMaterialId2)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IAddDisplayStateSpecificRenderMaterial(PRenderMaterial, DisplayStateOption, DisplayStateCount, DisplayStateNames, PWMaterialId1, PWMaterialId2);
        //}
        public static Boolean DeleteDisplayStateSpecificRenderMaterial(IModelDocExtensionObject IModelDocExtensioninstance, Object PWMaterialId1, Object PWMaterialId2)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.DeleteDisplayStateSpecificRenderMaterial(PWMaterialId1, PWMaterialId2);
        }
        //public static Boolean IDeleteDisplayStateSpecificRenderMaterial(IModelDocExtensionObject IModelDocExtensioninstance, Int32 IdCount, Int32& PWMaterialId1, Int32& PWMaterialId2)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IDeleteDisplayStateSpecificRenderMaterial(IdCount, PWMaterialId1, PWMaterialId2);
        //}
        public static void CreatePresentation2(IModelDocExtensionObject IModelDocExtensioninstance, String PathName, String ThemeXML, Int32 Options, Object NamedViewArray, Object TextNameArray, Object TextArray)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.CreatePresentation2(PathName, ThemeXML, Options, NamedViewArray, TextNameArray, TextArray);
        }
        public static String GetActivePropertyManagerPage(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetActivePropertyManagerPage();
        }
        public static Object GetRenderCustomReferences(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetRenderCustomReferences();
        }
        public static Object GetRenderStockReferences(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetRenderStockReferences();
        }
        public static Object GetRoutingComponentManager(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetRoutingComponentManager();
        }
        public static Boolean HideFeatureManager(IModelDocExtensionObject IModelDocExtensioninstance, Boolean Hide)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.HideFeatureManager(Hide);
        }
        public static Boolean AlignDimensions(IModelDocExtensionObject IModelDocExtensioninstance, Int32 AlignType, Double SpaceValue)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.AlignDimensions(AlignType, SpaceValue);
        }
        public static IStackedBalloonOptionsObject CreateStackedBalloonOptions(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return new IStackedBalloonOptionsObject(IModelDocExtensioninstance.IModelDocExtensionInstance.CreateStackedBalloonOptions());
        }
        public static INoteObject InsertStackedBalloon2(IModelDocExtensionObject IModelDocExtensioninstance, IStackedBalloonOptionsObject BalloonOptions)
        {
            return new INoteObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertStackedBalloon2(BalloonOptions?.IStackedBalloonOptionsInstance?.CastObj<StackedBalloonOptions>()));
        }
        public static IBalloonOptionsObject CreateBalloonOptions(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return new IBalloonOptionsObject(IModelDocExtensioninstance.IModelDocExtensionInstance.CreateBalloonOptions());
        }
        public static INoteObject InsertBOMBalloon2(IModelDocExtensionObject IModelDocExtensioninstance, IBalloonOptionsObject BalloonOptions)
        {
            return new INoteObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertBOMBalloon2(BalloonOptions?.IBalloonOptionsInstance?.CastObj<BalloonOptions>()));
        }
        public static IDisplayStateSettingObject GetDisplayStateSetting(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Option)
        {
            return new IDisplayStateSettingObject(IModelDocExtensioninstance.IModelDocExtensionInstance.GetDisplayStateSetting(Option));
        }
        public static IAppearanceSettingObject GetAppearanceSetting(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return new IAppearanceSettingObject(IModelDocExtensioninstance.IModelDocExtensionInstance.GetAppearanceSetting());
        }
        public static Int32 UpdateFrozenFeatures(IModelDocExtensionObject IModelDocExtensioninstance, Boolean UpdateAllConfigs)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.UpdateFrozenFeatures(UpdateAllConfigs);
        }
        public static void SelectAll(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.SelectAll();
        }
        public static Int32 MultiSelect2(IModelDocExtensionObject IModelDocExtensioninstance, Object Objects, Boolean AppendFlag, Object Data)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.MultiSelect2(Objects, AppendFlag, Data);
        }
        public static Boolean IsFutureVersion(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.IsFutureVersion();
        }
        public static Boolean FinishRecordingUndoObject2(IModelDocExtensionObject IModelDocExtensioninstance, String UndoObjectName, Boolean MakeHidden)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.FinishRecordingUndoObject2(UndoObjectName, MakeHidden);
        }
        public static IBomTableAnnotationObject InsertBomTable3(IModelDocExtensionObject IModelDocExtensioninstance, String TemplateName, Int32 X, Int32 Y, Int32 BomType, String ConfigurationName, Boolean Hidden, Int32 IndentedNumberingType, Boolean DetailedCutList)
        {
            return new IBomTableAnnotationObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertBomTable3(TemplateName, X, Y, BomType, ConfigurationName, Hidden, IndentedNumberingType, DetailedCutList));
        }
        public static Object GetCostingManager(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetCostingManager();
        }
        public static Object GetSustainability(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetSustainability();
        }
        public static Object GetTemplateSheetMetal(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetTemplateSheetMetal();
        }
        public static void Create3DBoundingBox(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.Create3DBoundingBox();
        }
        public static Boolean RunCommand(IModelDocExtensionObject IModelDocExtensioninstance, Int32 CommandID, String NewTitle)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.RunCommand(CommandID, NewTitle);
        }
        public static void StartRecordingUndoObject(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.StartRecordingUndoObject();
        }
        public static Boolean FinishRecordingUndoObject(IModelDocExtensionObject IModelDocExtensioninstance, String UndoObjectName)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.FinishRecordingUndoObject(UndoObjectName);
        }
        public static void SetVisibleBox(IModelDocExtensionObject IModelDocExtensioninstance, IMathPointObject UpperLeft, IMathPointObject LowerRight)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.SetVisibleBox(UpperLeft?.IMathPointInstance?.CastObj<MathPoint>(), LowerRight.IMathPointInstance.CastObj<MathPoint>());
        }
        //public static Boolean GetVisibleBox(IModelDocExtensionObject IModelDocExtensioninstance, MathPoint&Object UpperLeft, MathPoint&Object LowerRight)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetVisibleBox(UpperLeft, LowerRight);
        //}
        public static void RemoveVisibleBox(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.RemoveVisibleBox();
        }
        public static ICameraObject GetCameraDefinition(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return new ICameraObject(IModelDocExtensioninstance.IModelDocExtensionInstance.GetCameraDefinition());
        }
        public static Int32 AddOrdinateDimension(IModelDocExtensionObject IModelDocExtensioninstance, Int32 DimType, Double LocX, Double LocY, Double LocZ)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.AddOrdinateDimension(DimType, LocX, LocY, LocZ);
        }
        //public static Int32 GetUserPreferenceDoubleValueRange(IModelDocExtensionObject IModelDocExtensioninstance, Int32 UserPref, Double& Value, Double& MinValue, Double& MaxValue)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetUserPreferenceDoubleValueRange(UserPref, Value, MinValue, MaxValue);
        //}
        //public static Boolean SaveAs(IModelDocExtensionObject IModelDocExtensioninstance, String Name, Int32 Version, Int32 Options, Object ExportData, Int32& Errors, Int32& Warnings)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.SaveAs(Name, Version, Options, ExportData, Errors, Warnings);
        //}
        public static Object GetCorrespondingEntity(IModelDocExtensionObject IModelDocExtensioninstance, Object Entity)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetCorrespondingEntity(Entity);
        }
        public static Object GetCorresponding(IModelDocExtensionObject IModelDocExtensioninstance, Object InputObject)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetCorresponding(InputObject);
        }
        public static IPrint3DDialogObject GetPrint3DDialog(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return new IPrint3DDialogObject(IModelDocExtensioninstance.IModelDocExtensionInstance.GetPrint3DDialog());
        }
        //public static void DeleteFeatureMgrViewx64(IModelDocExtensionObject IModelDocExtensioninstance, Int64& AppView)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.DeleteFeatureMgrViewx64(AppView);
        //}
        public static Object GetPersistReference3(IModelDocExtensionObject IModelDocExtensioninstance, Object DispObj)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetPersistReference3(DispObj);
        }
        public static Int32 GetPersistReferenceCount3(IModelDocExtensionObject IModelDocExtensioninstance, Object DispObj)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetPersistReferenceCount3(DispObj);
        }
        public static Byte IGetPersistReference3(IModelDocExtensionObject IModelDocExtensioninstance, Object DipsObj, Int32 Count)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetPersistReference3(DipsObj, Count);
        }
        //public static Object GetObjectByPersistReference3(IModelDocExtensionObject IModelDocExtensioninstance, Object PersistId, Int32& ErrorCode)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetObjectByPersistReference3(PersistId, ErrorCode);
        //}
        //public static Object IGetObjectByPersistReference3(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Count, Byte& PersistId, Int32& ErrorCode)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetObjectByPersistReference3(Count, PersistId, ErrorCode);
        //}
        public static Boolean SetApiUndoObject(IModelDocExtensionObject IModelDocExtensioninstance, Object PHandler, String DisplayName)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SetApiUndoObject(PHandler, DisplayName);
        }
        public static Boolean AddOrUpdateSearchData(IModelDocExtensionObject IModelDocExtensioninstance, String AppName, String AppKeyword, String AppValue)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.AddOrUpdateSearchData(AppName, AppKeyword, AppValue);
        }
        public static IAnnotationViewObject InsertAnnotationView(IModelDocExtensionObject IModelDocExtensioninstance, Int32 AnnotationViewingDirection, Object DirectionReference, Boolean FlipDirection, Object HorizontalDirectionReference, Int32 AngleMadeWithHorizontal)
        {
            return new IAnnotationViewObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertAnnotationView(AnnotationViewingDirection, DirectionReference, FlipDirection, HorizontalDirectionReference, AngleMadeWithHorizontal));
        }
        public static IAnnotationViewObject IGetAnnotationViews(IModelDocExtensionObject IModelDocExtensioninstance, Int32 AnnotationViewCount)
        {
            return new IAnnotationViewObject(IModelDocExtensioninstance.IModelDocExtensionInstance.IGetAnnotationViews(AnnotationViewCount));
        }
        public static IMeasureObject CreateMeasure(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return new IMeasureObject(IModelDocExtensioninstance.IModelDocExtensionInstance.CreateMeasure());
        }
        public static void BreakAllExternalFileReferences2(IModelDocExtensionObject IModelDocExtensioninstance, Boolean InsertFeatures)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.BreakAllExternalFileReferences2(InsertFeatures);
        }
        public static Boolean InsertScene(IModelDocExtensionObject IModelDocExtensioninstance, String SceneDefinitionFile)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.InsertScene(SceneDefinitionFile);
        }
        public static IModelViewObject GetModelView(IModelDocExtensionObject IModelDocExtensioninstance, Int32 WindowID, Int32 Row, Int32 Col)
        {
            return new IModelViewObject(IModelDocExtensioninstance.IModelDocExtensionInstance.GetModelView(WindowID, Row, Col));
        }
        public static Int32 GetDecalsCount(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetDecalsCount();
        }
        public static Object GetDecals(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetDecals();
        }
        public static IDecalObject IGetDecals(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Count)
        {
            return new IDecalObject(IModelDocExtensioninstance.IModelDocExtensionInstance.IGetDecals(Count));
        }
        public static IDecalObject CreateDecal(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return new IDecalObject(IModelDocExtensioninstance.IModelDocExtensionInstance.CreateDecal());
        }
        //public static Boolean AddDecal(IModelDocExtensionObject IModelDocExtensioninstance, DecalObject PDecal, Int32& DecalID)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.AddDecal(PDecal, DecalID);
        //}
        public static Boolean DeleteDecal(IModelDocExtensionObject IModelDocExtensioninstance, Int32 DecalID, Boolean BReassignIdsAndInvalidate)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.DeleteDecal(DecalID, BReassignIdsAndInvalidate);
        }
        public static Boolean HideDecal(IModelDocExtensionObject IModelDocExtensioninstance, Int32 DecalID, Boolean Hide)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.HideDecal(DecalID, Hide);
        }
        public static Boolean DeleteAllDecals(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.DeleteAllDecals();
        }
        public static Boolean MoveDecal(IModelDocExtensionObject IModelDocExtensioninstance, Int32 DecalID, Boolean MoveUp)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.MoveDecal(DecalID, MoveUp);
        }
        public static Boolean ReverseDecalsOrder(IModelDocExtensionObject IModelDocExtensioninstance, Int32 DecalID)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ReverseDecalsOrder(DecalID);
        }
        public static Int32 GetRenderMaterialsCount(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetRenderMaterialsCount();
        }
        public static Object GetRenderMaterials(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetRenderMaterials();
        }
        public static IRenderMaterialObject IGetRenderMaterials(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Count)
        {
            return new IRenderMaterialObject(IModelDocExtensioninstance.IModelDocExtensionInstance.IGetRenderMaterials(Count));
        }
        public static IRenderMaterialObject CreateRenderMaterial(IModelDocExtensionObject IModelDocExtensioninstance, String PathName)
        {
            return new IRenderMaterialObject(IModelDocExtensioninstance.IModelDocExtensionInstance.CreateRenderMaterial(PathName));
        }
        //public static Boolean AddRenderMaterial(IModelDocExtensionObject IModelDocExtensioninstance, RenderMaterialObject PRenderMaterial, Int32& PwMaterialId)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.AddRenderMaterial(PRenderMaterial, PwMaterialId);
        //}
        public static Boolean DeleteRenderMaterial(IModelDocExtensionObject IModelDocExtensioninstance, Int32 PwMaterialId, Boolean BReassignIdsAndInvalidate)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.DeleteRenderMaterial(PwMaterialId, BReassignIdsAndInvalidate);
        }
        public static void UpdateRenderMaterialsInSceneGraph(IModelDocExtensionObject IModelDocExtensioninstance, Boolean AddToSG)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.UpdateRenderMaterialsInSceneGraph(AddToSG);
        }
        //public static void GetAdvancedSpotLightProperties(IModelDocExtensionObject IModelDocExtensioninstance, String Name, Double& Exponent, Double& AttenuationConst, Double& AttenuationLinear, Double& AttenuationQuad)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetAdvancedSpotLightProperties(Name, Exponent, AttenuationConst, AttenuationLinear, AttenuationQuad);
        //}
        public static void SetAdvancedSpotLightProperties(IModelDocExtensionObject IModelDocExtensioninstance, String Name, Double Exponent, Double AttenuationConst, Double AttenuationLinear, Double AttenuationQuad)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.SetAdvancedSpotLightProperties(Name, Exponent, AttenuationConst, AttenuationLinear, AttenuationQuad);
        }
        public static IDecalObject GetDecal(IModelDocExtensionObject IModelDocExtensioninstance, Int32 ID, String Configuration)
        {
            return new IDecalObject(IModelDocExtensioninstance.IModelDocExtensionInstance.GetDecal(ID, Configuration));
        }
        public static IRenderMaterialObject GetMaterial(IModelDocExtensionObject IModelDocExtensioninstance, Int32 ID, String Configuration)
        {
            return new IRenderMaterialObject(IModelDocExtensioninstance.IModelDocExtensionInstance.GetMaterial(ID, Configuration));
        }
        public static void SetKeepLightInRenderScene(IModelDocExtensionObject IModelDocExtensioninstance, Int32 ID, Boolean Val)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.SetKeepLightInRenderScene(ID, Val);
        }
        public static Boolean GetKeepLightInRenderScene(IModelDocExtensionObject IModelDocExtensioninstance, Int32 ID)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetKeepLightInRenderScene(ID);
        }
        //public static Boolean AddDefaultRenderMaterial(IModelDocExtensionObject IModelDocExtensioninstance, RenderMaterialObject PRenderMaterial, Int32& PwMaterialId)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.AddDefaultRenderMaterial(PRenderMaterial, PwMaterialId);
        //}
        public static void SetLightEnabledInRender(IModelDocExtensionObject IModelDocExtensioninstance, Int32 ID, Boolean Val)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.SetLightEnabledInRender(ID, Val);
        }
        public static Boolean GetLightEnabledInRender(IModelDocExtensionObject IModelDocExtensioninstance, Int32 ID)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetLightEnabledInRender(ID);
        }
        public static void DeleteScene(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.DeleteScene();
        }
        public static Object GetMotionStudyManager(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetMotionStudyManager();
        }
        public static Int32 GetSearchDataCount(IModelDocExtensionObject IModelDocExtensioninstance, String AppName)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetSearchDataCount(AppName);
        }
        //public static Int32 GetSearchData(IModelDocExtensionObject IModelDocExtensioninstance, String AppName, Object& AppNames, Object& NodeNames, Object& NodeValues)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetSearchData(AppName, AppNames, NodeNames, NodeValues);
        //}
        //public static void IGetSearchData(IModelDocExtensionObject IModelDocExtensioninstance, String AppName, Int32 Count, String& AppNames, String& NodeNames, String& NodeValues)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetSearchData(AppName, Count, AppNames, NodeNames, NodeValues);
        //}
        public static Boolean DeleteSearchData(IModelDocExtensionObject IModelDocExtensioninstance, String AppName)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.DeleteSearchData(AppName);
        }
        public static String IsVirtualComponent(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.IsVirtualComponent();
        }
        public static Object IsVirtualComponent2(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.IsVirtualComponent2();
        }
        //public static Boolean IsVirtualComponent3(IModelDocExtensionObject IModelDocExtensioninstance, Object& PathChain, Object& TitleChain)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IsVirtualComponent3(PathChain, TitleChain);
        //}
        public static Boolean ChangeSketchPlane(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Config_opt, Object Config_names)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ChangeSketchPlane(Config_opt, Config_names);
        }
        //public static Boolean IChangeSketchPlane(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Config_opt, Int32 Config_count, String& Config_names)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IChangeSketchPlane(Config_opt, Config_count, Config_names);
        //}
        public static ICalloutObject CreateCallout(IModelDocExtensionObject IModelDocExtensioninstance, Int32 NumberOfRows, Object Handler)
        {
            return new ICalloutObject(IModelDocExtensioninstance.IModelDocExtensionInstance.CreateCallout(NumberOfRows, Handler));
        }
        public static Boolean CreatePresentation(IModelDocExtensionObject IModelDocExtensioninstance, String PathName, String ThemeXML, Int32 Options, Object TextNameArray, Object TextArray, Object TextureArray)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.CreatePresentation(PathName, ThemeXML, Options, TextNameArray, TextArray, TextureArray);
        }
        public static void Stretch(IModelDocExtensionObject IModelDocExtensioninstance, Boolean KeepRelations, Double BaseX, Double BaseY, Double DestX, Double DestY)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.Stretch(KeepRelations, BaseX, BaseY, DestX, DestY);
        }
        public static void StartFormatPainter(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.StartFormatPainter();
        }
        public static void StopFormatPainter(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.StopFormatPainter();
        }
        public static Boolean JogDimension(IModelDocExtensionObject IModelDocExtensioninstance, Boolean Jog, Int16 WitnessIndex)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.JogDimension(Jog, WitnessIndex);
        }
        public static Object GetNamedViewRotation(IModelDocExtensionObject IModelDocExtensioninstance, String Name)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetNamedViewRotation(Name);
        }
        public static Double IGetNamedViewRotation(IModelDocExtensionObject IModelDocExtensioninstance, String Name)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetNamedViewRotation(Name);
        }
        public static Boolean GetUserPreferenceToggle(IModelDocExtensionObject IModelDocExtensioninstance, Int32 UserPref, Int32 UserPrefOption)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetUserPreferenceToggle(UserPref, UserPrefOption);
        }
        public static Boolean SetUserPreferenceToggle(IModelDocExtensionObject IModelDocExtensioninstance, Int32 UserPref, Int32 UserPrefOption, Boolean Value)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SetUserPreferenceToggle(UserPref, UserPrefOption, Value);
        }
        public static Int32 GetUserPreferenceInteger(IModelDocExtensionObject IModelDocExtensioninstance, Int32 UserPref, Int32 UserPrefOption)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetUserPreferenceInteger(UserPref, UserPrefOption);
        }
        public static Boolean SetUserPreferenceInteger(IModelDocExtensionObject IModelDocExtensioninstance, Int32 UserPref, Int32 UserPrefOption, Int32 Value)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SetUserPreferenceInteger(UserPref, UserPrefOption, Value);
        }
        public static Double GetUserPreferenceDouble(IModelDocExtensionObject IModelDocExtensioninstance, Int32 UserPref, Int32 UserPrefOption)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetUserPreferenceDouble(UserPref, UserPrefOption);
        }
        public static Boolean SetUserPreferenceDouble(IModelDocExtensionObject IModelDocExtensioninstance, Int32 UserPref, Int32 UserPrefOption, Double Value)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SetUserPreferenceDouble(UserPref, UserPrefOption, Value);
        }
        public static String GetUserPreferenceString(IModelDocExtensionObject IModelDocExtensioninstance, Int32 UserPref, Int32 UserPrefOption)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetUserPreferenceString(UserPref, UserPrefOption);
        }
        public static Boolean SetUserPreferenceString(IModelDocExtensionObject IModelDocExtensioninstance, Int32 UserPref, Int32 UserPrefOption, String Value)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SetUserPreferenceString(UserPref, UserPrefOption, Value);
        }
        public static ITextFormatObject GetUserPreferenceTextFormat(IModelDocExtensionObject IModelDocExtensioninstance, Int32 UserPref, Int32 UserPrefOption)
        {
            return new ITextFormatObject(IModelDocExtensioninstance.IModelDocExtensionInstance.GetUserPreferenceTextFormat(UserPref, UserPrefOption));
        }
        public static Boolean SetUserPreferenceTextFormat(IModelDocExtensionObject IModelDocExtensioninstance, Int32 UserPref, Int32 UserPrefOption, ITextFormatObject Value)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SetUserPreferenceTextFormat(UserPref, UserPrefOption, Value?.ITextFormatInstance?.CastObj<TextFormat>());
        }
        //public static Object GetMassProperties(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Accuracy, Int32& Status)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetMassProperties(Accuracy, Status);
        //}
        //public static Double IGetMassProperties(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Accuracy, Int32& Status)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetMassProperties(Accuracy, Status);
        //}
        public static Boolean InsertDwgOrDxfFile(IModelDocExtensionObject IModelDocExtensioninstance, String FileName)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.InsertDwgOrDxfFile(FileName);
        }
        public static void PrintOut(IModelDocExtensionObject IModelDocExtensioninstance, Int32 FromPage, Int32 ToPage, Int32 Copies, Boolean Collate, String Printer, String PrintFileName)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.PrintOut(FromPage, ToPage, Copies, Collate, Printer, PrintFileName);
        }
        public static Boolean SelectByID(IModelDocExtensionObject IModelDocExtensioninstance, String Name, String Type, Double X, Double Y, Double Z, Boolean Append, Int32 Mark, ICalloutObject Callout)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SelectByID(Name, Type, X, Y, Z, Append, Mark, Callout?.ICalloutInstance?.CastObj<Callout>());
        }
        public static Object IGet3rdPartyStorageStore(IModelDocExtensionObject IModelDocExtensioninstance, String SubStorageName, Boolean IsStoring)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.IGet3rdPartyStorageStore(SubStorageName, IsStoring);
        }
        public static Boolean IRelease3rdPartyStorageStore(IModelDocExtensionObject IModelDocExtensioninstance, String SubStorageName)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.IRelease3rdPartyStorageStore(SubStorageName);
        }
        public static Object GetSectionProperties(IModelDocExtensionObject IModelDocExtensioninstance, Object Sections)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetSectionProperties(Sections);
        }
        //public static Double IGetSectionProperties(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Count, Object& Sections)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetSectionProperties(Count, Sections);
        //}
        public static IMassPropertyObject CreateMassProperty(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return new IMassPropertyObject(IModelDocExtensioninstance.IModelDocExtensionInstance.CreateMassProperty());
        }
        public static IMathTransformObject GetCoordinateSystemTransformByName(IModelDocExtensionObject IModelDocExtensioninstance, String NameIn)
        {
            return new IMathTransformObject(IModelDocExtensioninstance.IModelDocExtensionInstance.GetCoordinateSystemTransformByName(NameIn));
        }
        public static void SetMaterialPropertyValues(IModelDocExtensionObject IModelDocExtensioninstance, Object Material_property_values, Int32 Config_opt, Object Config_names)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.SetMaterialPropertyValues(Material_property_values, Config_opt, Config_names);
        }
        //public static void ISetMaterialPropertyValues(IModelDocExtensionObject IModelDocExtensioninstance, Double& Material_values, Int32 Config_opt, Int32 Config_count, String& Config_names)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.ISetMaterialPropertyValues(Material_values, Config_opt, Config_count, Config_names);
        //}
        public static Object GetMaterialPropertyValues(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Config_opt, Object Config_names)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetMaterialPropertyValues(Config_opt, Config_names);
        }
        //public static Double IGetMaterialPropertyValues(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Config_opt, Int32 Config_count, String& Config_names)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetMaterialPropertyValues(Config_opt, Config_count, Config_names);
        //}
        public static void PrintOut2(IModelDocExtensionObject IModelDocExtensioninstance, Object PageArray, Int32 Copies, Boolean Collate, String Printer, String PrintFileName)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.PrintOut2(PageArray, Copies, Collate, Printer, PrintFileName);
        }
        //public static void IPrintOut2(IModelDocExtensionObject IModelDocExtensioninstance, Int32 ArraySize, Int32& PageArray, Int32 Copies, Boolean Collate, String Printer, String PrintFileName)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IPrintOut2(ArraySize, PageArray, Copies, Collate, Printer, PrintFileName);
        //}
        public static Object GetPersistReference(IModelDocExtensionObject IModelDocExtensioninstance, Object DispObj)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetPersistReference(DispObj);
        }
        public static Int32 GetPersistReferenceCount(IModelDocExtensionObject IModelDocExtensioninstance, Object DispObj)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetPersistReferenceCount(DispObj);
        }
        public static Byte IGetPersistReference(IModelDocExtensionObject IModelDocExtensioninstance, Object DipsObj, Int32 Count)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetPersistReference(DipsObj, Count);
        }
        public static Object GetObjectByPersistReference(IModelDocExtensionObject IModelDocExtensioninstance, Object PersistId)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetObjectByPersistReference(PersistId);
        }
        //public static Object IGetObjectByPersistReference(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Count, Byte& PersistId)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetObjectByPersistReference(Count, PersistId);
        //}
        //public static Object GetStream(IModelDocExtensionObject IModelDocExtensioninstance, Int32 StreamType, Boolean& ReadOnly)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetStream(StreamType, ReadOnly);
        //}
        public static Boolean ReleaseStream(IModelDocExtensionObject IModelDocExtensioninstance, Int32 StreamType)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ReleaseStream(StreamType);
        }
        public static IFeatureObject GetLastFeatureAdded(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return new IFeatureObject(IModelDocExtensioninstance.IModelDocExtensionInstance.GetLastFeatureAdded());
        }
        //public static Int32 IMultiSelect(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Count, Object& Objects, Boolean AppendFlag, SelectDataObject Data)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IMultiSelect(Count, Objects, AppendFlag, Data);
        //}
        public static Int32 MultiSelect(IModelDocExtensionObject IModelDocExtensioninstance, Object Objects, Boolean AppendFlag, Object Data)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.MultiSelect(Objects, AppendFlag, Data);
        }
        public static Double GetParameterValue(IModelDocExtensionObject IModelDocExtensioninstance, String DimName, Int32 Reserved)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetParameterValue(DimName, Reserved);
        }
        public static Int32 SetParameterValue(IModelDocExtensionObject IModelDocExtensioninstance, String DimName, Double Value, Int32 Reserved)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SetParameterValue(DimName, Value, Reserved);
        }
        public static void MoveOrCopy(IModelDocExtensionObject IModelDocExtensioninstance, Boolean Copy, Int32 NumCopies, Boolean KeepRelations, Double BaseX, Double BaseY, Double BaseZ, Double DestX, Double DestY, Double DestZ)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.MoveOrCopy(Copy, NumCopies, KeepRelations, BaseX, BaseY, BaseZ, DestX, DestY, DestZ);
        }
        public static void RotateOrCopy(IModelDocExtensionObject IModelDocExtensioninstance, Boolean Copy, Int32 NumCopies, Boolean KeepRelations, Double BaseX, Double BaseY, Double BaseZ, Double DestX, Double DestY, Double DestZ, Double Angle)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.RotateOrCopy(Copy, NumCopies, KeepRelations, BaseX, BaseY, BaseZ, DestX, DestY, DestZ, Angle);
        }
        public static void ScaleOrCopy(IModelDocExtensionObject IModelDocExtensioninstance, Boolean Copy, Int32 NumCopies, Double BaseX, Double BaseY, Double BaseZ, Double Scale)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.ScaleOrCopy(Copy, NumCopies, BaseX, BaseY, BaseZ, Scale);
        }
        public static Boolean ApplyTexture(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Scale, Double Angle, String TextureFilename, Boolean BlendColor)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ApplyTexture(Scale, Angle, TextureFilename, BlendColor);
        }
        public static Boolean RemoveTexture(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.RemoveTexture();
        }
        public static Boolean RemoveMaterialProperty(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Config_opt, Object Config_names)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.RemoveMaterialProperty(Config_opt, Config_names);
        }
        //public static Boolean IRemoveMaterialProperty(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Config_opt, Int32 Config_count, String& Config_names)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IRemoveMaterialProperty(Config_opt, Config_count, Config_names);
        //}
        public static void RemoveModelColorizer(IModelDocExtensionObject IModelDocExtensioninstance, Object PInterface)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.RemoveModelColorizer(PInterface);
        }
        public static void InstallModelColorizer(IModelDocExtensionObject IModelDocExtensioninstance, Object PInterface)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.InstallModelColorizer(PInterface);
        }
        public static Boolean HasDesignTable(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.HasDesignTable();
        }
        //public static void ListExternalFileReferences(IModelDocExtensionObject IModelDocExtensioninstance, Object& ModelPathName, Object& ComponentPathName, Object& Feature, Object& DataType, Object& Status, Object& RefEntity, Object& FeatCom, Int32& ConfigOption, String& ConfigName)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.ListExternalFileReferences(ModelPathName, ComponentPathName, Feature, DataType, Status, RefEntity, FeatCom, ConfigOption, ConfigName);
        //}
        public static Int32 ListExternalFileReferencesCount(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ListExternalFileReferencesCount();
        }
        //public static void IListExternalFileReferences(IModelDocExtensionObject IModelDocExtensioninstance, Int32 NumRefs, String& ModelPathName, String& CompPathName, String& Feature, String& DataType, Int32& Status, String& RefEntity, String& FeatComp, Int32& ConfigOption, String& ConfigName)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IListExternalFileReferences(NumRefs, ModelPathName, CompPathName, Feature, DataType, Status, RefEntity, FeatComp, ConfigOption, ConfigName);
        //}
        public static void UpdateExternalFileReferences(IModelDocExtensionObject IModelDocExtensioninstance, Int32 ConfigOption, String ConfigName, Int32 UpdateStatus)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.UpdateExternalFileReferences(ConfigOption, ConfigName, UpdateStatus);
        }
        public static ISFSymbolObject InsertSurfaceFinishSymbol3(IModelDocExtensionObject IModelDocExtensioninstance, Int32 SymType, Int32 LeaderType, Double LocX, Double LocY, Double LocZ, Int32 LaySymbol, Int32 ArrowType, String MachAllowance, String OtherVals, String ProdMethod, String SampleLen, String MaxRoughness, String MinRoughness, String RoughnessSpacing)
        {
            return new ISFSymbolObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertSurfaceFinishSymbol3(SymType, LeaderType, LocX, LocY, LocZ, LaySymbol, ArrowType, MachAllowance, OtherVals, ProdMethod, SampleLen, MaxRoughness, MinRoughness, RoughnessSpacing));
        }
        public static IDatumTargetSymObject InsertDatumTargetSymbol2(IModelDocExtensionObject IModelDocExtensioninstance, String Datum1, String Datum2, String Datum3, Int16 AreaStyle, Boolean AreaOutside, Double Value1, Double Value2, String ValueStr1, String ValueStr2, Boolean ArrowsSmart, Int16 ArrowStyle, Int16 LeaderLineStyle, Boolean LeaderBent, Boolean ShowArea, Boolean ShowSymbol)
        {
            return new IDatumTargetSymObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertDatumTargetSymbol2(Datum1, Datum2, Datum3, AreaStyle, AreaOutside, Value1, Value2, ValueStr1, ValueStr2, ArrowsSmart, ArrowStyle, LeaderLineStyle, LeaderBent, ShowArea, ShowSymbol));
        }
        public static ITextureObject GetTexture(IModelDocExtensionObject IModelDocExtensioninstance, String Config_name)
        {
            return new ITextureObject(IModelDocExtensioninstance.IModelDocExtensionInstance.GetTexture(Config_name));
        }
        public static Boolean SetTexture(IModelDocExtensionObject IModelDocExtensioninstance, String Config_name, ITextureObject TextureIn)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SetTexture(Config_name, TextureIn?.ITextureInstance?.CastObj<Texture>());
        }
        public static Boolean RemoveTexture2(IModelDocExtensionObject IModelDocExtensioninstance, String Config_name)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.RemoveTexture2(Config_name);
        }
        public static ITextureObject CreateTexture(IModelDocExtensionObject IModelDocExtensioninstance, String MatName, Double Scale, Double Angle, Boolean Blend)
        {
            return new ITextureObject(IModelDocExtensioninstance.IModelDocExtensionInstance.CreateTexture(MatName, Scale, Angle, Blend));
        }
        //public static Object GetObjectByPersistReference2(IModelDocExtensionObject IModelDocExtensioninstance, Object PersistId, Int32& ErrorCode)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetObjectByPersistReference2(PersistId, ErrorCode);
        //}
        //public static Object IGetObjectByPersistReference2(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Count, Byte& PersistId, Int32& ErrorCode)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetObjectByPersistReference2(Count, PersistId, ErrorCode);
        //}
        public static Int32 GetAnnotationCount(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetAnnotationCount();
        }
        public static Object GetAnnotations(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetAnnotations();
        }
        public static IAnnotationObject IGetAnnotations(IModelDocExtensionObject IModelDocExtensioninstance, Int32 NumAnnotations)
        {
            return new IAnnotationObject(IModelDocExtensioninstance.IModelDocExtensionInstance.IGetAnnotations(NumAnnotations));
        }
        public static IAnnotationObject InsertAnnotationFavorite(IModelDocExtensionObject IModelDocExtensioninstance, String BstrFileName, Double X, Double Y, Double Z)
        {
            return new IAnnotationObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertAnnotationFavorite(BstrFileName, X, Y, Z));
        }
        public static Boolean InsertAttachment(IModelDocExtensionObject IModelDocExtensioninstance, String FileName, Boolean Linked)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.InsertAttachment(FileName, Linked);
        }
        public static Boolean DeleteAttachment(IModelDocExtensionObject IModelDocExtensioninstance, String FileName)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.DeleteAttachment(FileName);
        }
        public static Int32 GetAttachmentCount(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetAttachmentCount();
        }
        //public static Object GetAttachments(IModelDocExtensionObject IModelDocExtensioninstance, Object& LinkedVar)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.GetAttachments(LinkedVar);
        //}
        //public static String IGetAttachments(IModelDocExtensionObject IModelDocExtensioninstance, Int32 NumAttachments, Boolean& LinkedArr)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetAttachments(NumAttachments, LinkedArr);
        //}
        public static Object GetSectionProperties2(IModelDocExtensionObject IModelDocExtensioninstance, Object Sections)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetSectionProperties2(Sections);
        }
        //public static Double IGetSectionProperties2(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Count, Object& Sections)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetSectionProperties2(Count, Sections);
        //}
        public static Boolean SelectByID2(IModelDocExtensionObject IModelDocExtensioninstance, String Name, String Type, Double X, Double Y, Double Z, Boolean Append, Int32 Mark, ICalloutObject Callout, Int32 SelectOption)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SelectByID2(Name, Type, X, Y, Z, Append, Mark, Callout?.ICalloutInstance?.CastObj<Callout>(), SelectOption);
        }
        //public static ISwOLEObjectObject CreateOLEObject(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Aspect, Object Position, Object Buffer, Int32& ErrorCode)
        //{
        //    return new ISwOLEObjectObject(IModelDocExtensioninstance.IModelDocExtensionInstance.CreateOLEObject(Aspect, Position, Buffer, ErrorCode));
        //}
        //public static ISwOLEObjectObject ICreateOLEObject(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Aspect, Double& Position, Int32 ByteCount, Byte& Buffer, Int32& ErrorCode)
        //{
        //    return new ISwOLEObjectObject(IModelDocExtensioninstance.IModelDocExtensionInstance.ICreateOLEObject(Aspect, Position, ByteCount, Buffer, ErrorCode));
        //}
        public static Int32 GetOLEObjectCount(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Options)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetOLEObjectCount(Options);
        }
        public static Object GetOLEObjects(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Options)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetOLEObjects(Options);
        }
        //public static void IGetOLEObjects(IModelDocExtensionObject IModelDocExtensioninstance, Int32 Options, Int32 OleObjectCount, SwOLEObject&Object LpOleObjects)
        //{
        //    return IModelDocExtensioninstance.IModelDocExtensionInstance.IGetOLEObjects(Options, OleObjectCount, LpOleObjects);
        //}
        public static ICameraObject InsertCamera(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return new ICameraObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertCamera());
        }
        public static Int32 GetCameraCount(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetCameraCount();
        }
        public static ICameraObject GetCameraById(IModelDocExtensionObject IModelDocExtensioninstance, Int32 CameraId)
        {
            return new ICameraObject(IModelDocExtensioninstance.IModelDocExtensionInstance.GetCameraById(CameraId));
        }
        public static ISwOLEObjectObject InsertObjectFromFile(IModelDocExtensionObject IModelDocExtensioninstance, String FilePath, Boolean CreateLink, Int32 Aspect, Double XPos, Double YPos, Double ZPos)
        {
            return new ISwOLEObjectObject(IModelDocExtensioninstance.IModelDocExtensionInstance.InsertObjectFromFile(FilePath, CreateLink, Aspect, XPos, YPos, ZPos));
        }
        public static ICommentObject AddComment(IModelDocExtensionObject IModelDocExtensioninstance, String Text)
        {
            return new ICommentObject(IModelDocExtensioninstance.IModelDocExtensionInstance.AddComment(Text));
        }
        public static Boolean DeleteSelection2(IModelDocExtensionObject IModelDocExtensioninstance, Int32 DeleteOptions)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.DeleteSelection2(DeleteOptions);
        }
        public static void SetSceneBkgDIBx64(IModelDocExtensionObject IModelDocExtensioninstance, Int64 L_dib)
        {
            IModelDocExtensioninstance.IModelDocExtensionInstance.SetSceneBkgDIBx64(L_dib);
        }
        public static Int64 GetSceneBkgDIBx64(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.GetSceneBkgDIBx64();
        }
        public static IModelDoc2Object Document(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return new IModelDoc2Object(IModelDocExtensioninstance.IModelDocExtensionInstance.Document);
        }
        public static Int32 UsePageSetup(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.UsePageSetup;
        }
        public static IPageSetupObject AppPageSetup(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return new IPageSetupObject(IModelDocExtensioninstance.IModelDocExtensionInstance.AppPageSetup);
        }
        public static Boolean NeedsRebuild(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.NeedsRebuild;
        }
        public static Boolean ViewDisplayRealView(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ViewDisplayRealView;
        }
        public static Boolean ClearLastActiveConfigModel(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ClearLastActiveConfigModel;
        }
        public static ICustomPropertyManagerObject CustomPropertyManager(IModelDocExtensionObject IModelDocExtensioninstance, string ConfigName)
        {
            return new ICustomPropertyManagerObject(IModelDocExtensioninstance.IModelDocExtensionInstance.CustomPropertyManager[ConfigName]);
        }
        public static Int32 AnnotationViewCount(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.AnnotationViewCount;
        }
        public static Object AnnotationViews(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.AnnotationViews;
        }
        public static String FeatureManagerFilterString(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.FeatureManagerFilterString;
        }
        public static Boolean IncludeMassPropertiesOfHiddenBodies(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.IncludeMassPropertiesOfHiddenBodies;
        }
        public static IDimXpertManagerObject DimXpertManager(IModelDocExtensionObject IModelDocExtensioninstance, string Configuration, bool CreateScheam)
        {
            return new IDimXpertManagerObject(IModelDocExtensioninstance.IModelDocExtensionInstance.DimXpertManager[Configuration, CreateScheam]);
        }
        public static Boolean LinkedDisplayState(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.LinkedDisplayState;
        }
        public static Object DisplayMode(IModelDocExtensionObject IModelDocExtensioninstance, IDisplayStateSettingObject Setting)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.DisplayMode[Setting.IDisplayStateSettingInstance as DisplayStateSetting];
        }
        public static Object Visibility(IModelDocExtensionObject IModelDocExtensioninstance, IDisplayStateSettingObject Setting)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.Visibility[Setting.IDisplayStateSettingInstance as DisplayStateSetting];
        }
        public static Object Transparency(IModelDocExtensionObject IModelDocExtensioninstance, IDisplayStateSettingObject Setting)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.Transparency[Setting.IDisplayStateSettingInstance as DisplayStateSetting];
        }
        public static Object DisplayStateSpecMaterialPropertyValues(IModelDocExtensionObject IModelDocExtensioninstance, IDisplayStateSettingObject Setting)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.DisplayStateSpecMaterialPropertyValues[Setting.IDisplayStateSettingInstance as DisplayStateSetting];
        }
        public static Int32 NeedsRebuild2(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.NeedsRebuild2;
        }
        public static Int32 FlyoutFeatureTreeVisibility(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.FlyoutFeatureTreeVisibility;
        }
        public static Int32 ToolboxPartType(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ToolboxPartType;
        }
        public static String ActiveCommandTab(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ActiveCommandTab;
        }
        public static Int32 ActiveCommandTabIndex(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ActiveCommandTabIndex;
        }
        public static Boolean CommandTabVisible(IModelDocExtensionObject IModelDocExtensioninstance, int TabIndex)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.CommandTabVisible[TabIndex];
        }
        public static Boolean ShowPartRebuildIndicators(IModelDocExtensionObject IModelDocExtensioninstance)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.ShowPartRebuildIndicators;
        }
        public static Double SunLightInformation(IModelDocExtensionObject IModelDocExtensioninstance, int Type)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.SunLightInformation[Type];
        }
        public static String CustomPropertyBuilderTemplate(IModelDocExtensionObject IModelDocExtensioninstance, bool WeldmentTempalte)
        {
            return IModelDocExtensioninstance.IModelDocExtensionInstance.CustomPropertyBuilderTemplate[WeldmentTempalte];
        }
    }
}