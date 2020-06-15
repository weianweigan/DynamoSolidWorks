using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IModelDoc2Object
    {
        public IModelDoc2 IModelDoc2Instance { get; set; }
        public IModelDoc2Object(IModelDoc2 IModelDoc2instance)
        {
            IModelDoc2Instance = IModelDoc2instance;
        }
    }
    public static class IModelDoc2Interface
    {
        public static Object AddConfiguration3(IModelDoc2Object IModelDoc2instance, String Name, String Comment, String AlternateName, Int32 Options)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddConfiguration3(Name, Comment, AlternateName, Options);
        }
        public static IConfigurationObject IAddConfiguration3(IModelDoc2Object IModelDoc2instance, String Name, String Comment, String AlternateName, Int32 Options)
        {
            return new IConfigurationObject(IModelDoc2instance.IModelDoc2Instance.IAddConfiguration3(Name, Comment, AlternateName, Options));
        }
        public static Boolean EditConfiguration3(IModelDoc2Object IModelDoc2instance, String Name, String NewName, String Comment, String AlternateName, Int32 Options)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditConfiguration3(Name, NewName, Comment, AlternateName, Options);
        }
        public static IEquationMgrObject GetEquationMgr(IModelDoc2Object IModelDoc2instance)
        {
            return new IEquationMgrObject(IModelDoc2instance.IModelDoc2Instance.GetEquationMgr());
        }
        //public static Double ClosestDistance(IModelDoc2Object IModelDoc2instance, Object Object1, Object Object2, Object& Point1, Object& Point2)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.ClosestDistance(Object1, Object2, Point1, Point2);
        //}
        //public static Double IClosestDistance(IModelDoc2Object IModelDoc2instance, Object Object1, Object Object2, Double& Point1, Double& Point2)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IClosestDistance(Object1, Object2, Point1, Point2);
        //}
        public static Int32 ReloadOrReplace(IModelDoc2Object IModelDoc2instance, Boolean ReadOnly, String ReplaceFileName, Boolean DiscardChanges)
        {
            return IModelDoc2instance.IModelDoc2Instance.ReloadOrReplace(ReadOnly, ReplaceFileName, DiscardChanges);
        }
        public static String GetCustomInfoValue(IModelDoc2Object IModelDoc2instance, String Configuration, String FieldName)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetCustomInfoValue(Configuration, FieldName);
        }
        public static INoteObject InsertStackedBalloon(IModelDoc2Object IModelDoc2instance, Int32 Style, Int32 Size, Int32 UpperTextStyle, String UpperText, Int32 LowerTextStyle, String LowerText)
        {
            return new INoteObject(IModelDoc2instance.IModelDoc2Instance.InsertStackedBalloon(Style, Size, UpperTextStyle, UpperText, LowerTextStyle, LowerText));
        }
        //public static Boolean SaveAs4(IModelDoc2Object IModelDoc2instance, String Name, Int32 Version, Int32 Options, Int32& Errors, Int32& Warnings)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.SaveAs4(Name, Version, Options, Errors, Warnings);
        //}
        //public static Boolean Save3(IModelDoc2Object IModelDoc2instance, Int32 Options, Int32& Errors, Int32& Warnings)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.Save3(Options, Errors, Warnings);
        //}
        public static Object CreatePlaneFixed2(IModelDoc2Object IModelDoc2instance, Object P1, Object P2, Object P3, Boolean UseGlobal)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePlaneFixed2(P1, P2, P3, UseGlobal);
        }
        //public static IRefPlaneObject ICreatePlaneFixed2(IModelDoc2Object IModelDoc2instance, Double& P1, Double& P2, Double& P3, Boolean UseGlobal)
        //{
        //    return new IRefPlaneObject(IModelDoc2instance.IModelDoc2Instance.ICreatePlaneFixed2(P1, P2, P3, UseGlobal));
        //}
        public static Int32 AddOrEditConfiguration(IModelDoc2Object IModelDoc2instance, String ConfigName, Object Params, Object Values)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddOrEditConfiguration(ConfigName, Params, Values);
        }
        //public static Int32 IAddOrEditConfiguration(IModelDoc2Object IModelDoc2instance, String ConfigName, Int32 ParamCount, String& ParamNames, String& ParamValues)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IAddOrEditConfiguration(ConfigName, ParamCount, ParamNames, ParamValues);
        //}
        public static Int32 ForceReleaseLocks(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.ForceReleaseLocks();
        }
        public static Boolean EditDimensionProperties3(IModelDoc2Object IModelDoc2instance, Int32 TolType, Double TolMax, Double TolMin, String TolMaxFit, String TolMinFit, Boolean UseDocPrec, Int32 Precision, Int32 ArrowsIn, Boolean UseDocArrows, Int32 Arrow1, Int32 Arrow2, String PrefixText, String SuffixText, Boolean ShowValue, String CalloutText1, String CalloutText2, Boolean CenterText, Int32 ConfigOption, Object ConfigNames)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditDimensionProperties3(TolType, TolMax, TolMin, TolMaxFit, TolMinFit, UseDocPrec, Precision, ArrowsIn, UseDocArrows, Arrow1, Arrow2, PrefixText, SuffixText, ShowValue, CalloutText1, CalloutText2, CenterText, ConfigOption, ConfigNames);
        }
        //public static Boolean IEditDimensionProperties3(IModelDoc2Object IModelDoc2instance, Int32 TolType, Double TolMax, Double TolMin, String TolMaxFit, String TolMinFit, Boolean UseDocPrec, Int32 Precision, Int32 ArrowsIn, Boolean UseDocArrows, Int32 Arrow1, Int32 Arrow2, String PrefixText, String SuffixText, Boolean ShowValue, String CalloutText1, String CalloutText2, Boolean CenterText, Int32 ConfigOption, Int32 Count, String& ConfigNames)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IEditDimensionProperties3(TolType, TolMax, TolMin, TolMaxFit, TolMinFit, UseDocPrec, Precision, ArrowsIn, UseDocArrows, Arrow1, Arrow2, PrefixText, SuffixText, ShowValue, CalloutText1, CalloutText2, CenterText, ConfigOption, Count, ConfigNames);
        //}
        public static void InsertSketchPictureDatax64(IModelDoc2Object IModelDoc2instance, Int32 Width, Int32 Height, Int64 PDataIn)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSketchPictureDatax64(Width, Height, PDataIn);
        }
        //public static IPropertyManagerPageObject GetPropertyManagerPage(IModelDoc2Object IModelDoc2instance, Int32 DialogId, String Title, Object Handler)
        //{
        //    return new IPropertyManagerPageObject(IModelDoc2instance.IModelDoc2Instance.GetPropertyManagerPage(DialogId, Title, Handler));
        //}
        public static void AlignOrdinate(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.AlignOrdinate();
        }
        public static void EditOrdinate(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.EditOrdinate();
        }
        public static Boolean ReattachOrdinate(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.ReattachOrdinate();
        }
        public static Object EditBalloonProperties(IModelDoc2Object IModelDoc2instance, Int32 Style, Int32 Size, Int32 UpperTextStyle, String UpperText, Int32 LowerTextStyle, String LowerText)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditBalloonProperties(Style, Size, UpperTextStyle, UpperText, LowerTextStyle, LowerText);
        }
        public static Boolean EditDimensionProperties2(IModelDoc2Object IModelDoc2instance, Int32 TolType, Double TolMax, Double TolMin, String TolMaxFit, String TolMinFit, Boolean UseDocPrec, Int32 Precision, Int32 ArrowsIn, Boolean UseDocArrows, Int32 Arrow1, Int32 Arrow2, String PrefixText, String SuffixText, Boolean ShowValue, String CalloutText1, String CalloutText2, Boolean CenterText)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditDimensionProperties2(TolType, TolMax, TolMin, TolMaxFit, TolMinFit, UseDocPrec, Precision, ArrowsIn, UseDocArrows, Arrow1, Arrow2, PrefixText, SuffixText, ShowValue, CalloutText1, CalloutText2, CenterText);
        }
        public static void InsertSheetMetalClosedCorner(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSheetMetalClosedCorner();
        }
        public static Boolean SketchUseEdge2(IModelDoc2Object IModelDoc2instance, Boolean Chain)
        {
            return IModelDoc2instance.IModelDoc2Instance.SketchUseEdge2(Chain);
        }
        public static Boolean SketchOffsetEntities2(IModelDoc2Object IModelDoc2instance, Double Offset, Boolean BothDirections, Boolean Chain)
        {
            return IModelDoc2instance.IModelDoc2Instance.SketchOffsetEntities2(Offset, BothDirections, Chain);
        }
        public static Boolean SketchOffset2(IModelDoc2Object IModelDoc2instance, Double Offset, Boolean BothDirections, Boolean Chain)
        {
            return IModelDoc2instance.IModelDoc2Instance.SketchOffset2(Offset, BothDirections, Chain);
        }
        public static Object AddDimension2(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddDimension2(X, Y, Z);
        }
        public static IDisplayDimensionObject IAddDimension2(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return new IDisplayDimensionObject(IModelDoc2instance.IModelDoc2Instance.IAddDimension2(X, Y, Z));
        }
        public static Object AddHorizontalDimension2(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddHorizontalDimension2(X, Y, Z);
        }
        public static IDisplayDimensionObject IAddHorizontalDimension2(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return new IDisplayDimensionObject(IModelDoc2instance.IModelDoc2Instance.IAddHorizontalDimension2(X, Y, Z));
        }
        public static Object AddVerticalDimension2(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddVerticalDimension2(X, Y, Z);
        }
        public static IDisplayDimensionObject IAddVerticalDimension2(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return new IDisplayDimensionObject(IModelDoc2instance.IModelDoc2Instance.IAddVerticalDimension2(X, Y, Z));
        }
        public static Object AddRadialDimension2(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddRadialDimension2(X, Y, Z);
        }
        public static IDisplayDimensionObject IAddRadialDimension2(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return new IDisplayDimensionObject(IModelDoc2instance.IModelDoc2Instance.IAddRadialDimension2(X, Y, Z));
        }
        public static Object AddDiameterDimension2(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddDiameterDimension2(X, Y, Z);
        }
        public static IDisplayDimensionObject IAddDiameterDimension2(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return new IDisplayDimensionObject(IModelDoc2instance.IModelDoc2Instance.IAddDiameterDimension2(X, Y, Z));
        }
        public static Object GetUserUnit(IModelDoc2Object IModelDoc2instance, Int32 UnitType)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetUserUnit(UnitType);
        }
        public static IUserUnitObject IGetUserUnit(IModelDoc2Object IModelDoc2instance, Int32 UnitType)
        {
            return new IUserUnitObject(IModelDoc2instance.IModelDoc2Instance.IGetUserUnit(UnitType));
        }
        public static Object InsertWeldSymbol3(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertWeldSymbol3();
        }
        public static IWeldSymbolObject IInsertWeldSymbol3(IModelDoc2Object IModelDoc2instance)
        {
            return new IWeldSymbolObject(IModelDoc2instance.IModelDoc2Instance.IInsertWeldSymbol3());
        }
        public static Int32 SaveAs3(IModelDoc2Object IModelDoc2instance, String NewName, Int32 SaveAsVersion, Int32 Options)
        {
            return IModelDoc2instance.IModelDoc2Instance.SaveAs3(NewName, SaveAsVersion, Options);
        }
        public static String GetUserPreferenceStringValue(IModelDoc2Object IModelDoc2instance, Int32 UserPreference)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetUserPreferenceStringValue(UserPreference);
        }
        public static Boolean SetUserPreferenceStringValue(IModelDoc2Object IModelDoc2instance, Int32 UserPreference, String Value)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetUserPreferenceStringValue(UserPreference, Value);
        }
        public static void DeleteDesignTable(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.DeleteDesignTable();
        }
        public static Boolean EditRebuild3(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditRebuild3();
        }
        public static Boolean ForceRebuild3(IModelDoc2Object IModelDoc2instance, Boolean TopOnly)
        {
            return IModelDoc2instance.IModelDoc2Instance.ForceRebuild3(TopOnly);
        }
        public static Int32 FeatureFillet5(IModelDoc2Object IModelDoc2instance, Int32 Options, Double R1, Int32 Ftyp, Int32 OverflowType, Object Radii, Object SetBackDistances, Object PointRadiusArray)
        {
            return IModelDoc2instance.IModelDoc2Instance.FeatureFillet5(Options, R1, Ftyp, OverflowType, Radii, SetBackDistances, PointRadiusArray);
        }
        //public static Int32 IFeatureFillet5(IModelDoc2Object IModelDoc2instance, Int32 Options, Double R1, Int32 Ftyp, Int32 OverflowType, Int32 NRadii, Double& Radii, Int32 SetbackDistCount, Double& SetBackDistances, Int32 PointCount, Double& PointRadiusArray)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IFeatureFillet5(Options, R1, Ftyp, OverflowType, NRadii, Radii, SetbackDistCount, SetBackDistances, PointCount, PointRadiusArray);
        //}
        public static void InsertSheetMetalBreakCorner(IModelDoc2Object IModelDoc2instance, Int32 Type, Double Distance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSheetMetalBreakCorner(Type, Distance);
        }
        public static void InsertSheetMetalHem(IModelDoc2Object IModelDoc2instance, Int32 Type, Int32 Position, Boolean Reverse, Double DLength, Double DGap, Double DAngle, Double DRad, Double DMiterGap)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSheetMetalHem(Type, Position, Reverse, DLength, DGap, DAngle, DRad, DMiterGap);
        }
        public static Object CreatePlaneAtOffset3(IModelDoc2Object IModelDoc2instance, Double Val, Boolean FlipDir, Boolean AutoSize)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePlaneAtOffset3(Val, FlipDir, AutoSize);
        }
        public static IRefPlaneObject ICreatePlaneAtOffset3(IModelDoc2Object IModelDoc2instance, Double Val, Boolean FlipDir, Boolean AutoSize)
        {
            return new IRefPlaneObject(IModelDoc2instance.IModelDoc2Instance.ICreatePlaneAtOffset3(Val, FlipDir, AutoSize));
        }
        public static Object CreatePlaneAtAngle3(IModelDoc2Object IModelDoc2instance, Double Val, Boolean FlipDir, Boolean AutoSize)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePlaneAtAngle3(Val, FlipDir, AutoSize);
        }
        public static IRefPlaneObject ICreatePlaneAtAngle3(IModelDoc2Object IModelDoc2instance, Double Val, Boolean FlipDir, Boolean AutoSize)
        {
            return new IRefPlaneObject(IModelDoc2instance.IModelDoc2Instance.ICreatePlaneAtAngle3(Val, FlipDir, AutoSize));
        }
        public static Object CreatePlaneThru3Points3(IModelDoc2Object IModelDoc2instance, Boolean AutoSize)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePlaneThru3Points3(AutoSize);
        }
        public static IRefPlaneObject ICreatePlaneThru3Points3(IModelDoc2Object IModelDoc2instance, Boolean AutoSize)
        {
            return new IRefPlaneObject(IModelDoc2instance.IModelDoc2Instance.ICreatePlaneThru3Points3(AutoSize));
        }
        public static Object CreatePlaneThruPtParallelToPlane(IModelDoc2Object IModelDoc2instance, Boolean AutoSize)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePlaneThruPtParallelToPlane(AutoSize);
        }
        public static IRefPlaneObject ICreatePlaneThruPtParallelToPlane(IModelDoc2Object IModelDoc2instance, Boolean AutoSize)
        {
            return new IRefPlaneObject(IModelDoc2instance.IModelDoc2Instance.ICreatePlaneThruPtParallelToPlane(AutoSize));
        }
        public static Object CreatePlaneThruLineAndPt(IModelDoc2Object IModelDoc2instance, Boolean AutoSize)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePlaneThruLineAndPt(AutoSize);
        }
        public static IRefPlaneObject ICreatePlaneThruLineAndPt(IModelDoc2Object IModelDoc2instance, Boolean AutoSize)
        {
            return new IRefPlaneObject(IModelDoc2instance.IModelDoc2Instance.ICreatePlaneThruLineAndPt(AutoSize));
        }
        public static Object CreatePlanePerCurveAndPassPoint3(IModelDoc2Object IModelDoc2instance, Boolean OrigAtCurve, Boolean AutoSize)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePlanePerCurveAndPassPoint3(OrigAtCurve, AutoSize);
        }
        public static IRefPlaneObject ICreatePlanePerCurveAndPassPoint3(IModelDoc2Object IModelDoc2instance, Boolean OrigAtCurve, Boolean AutoSize)
        {
            return new IRefPlaneObject(IModelDoc2instance.IModelDoc2Instance.ICreatePlanePerCurveAndPassPoint3(OrigAtCurve, AutoSize));
        }
        public static Object CreatePlaneAtSurface3(IModelDoc2Object IModelDoc2instance, Int16 InterIndex, Boolean ProjOpt, Boolean ReverseDir, Boolean NormalPlane, Double Angle, Boolean AutoSize)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePlaneAtSurface3(InterIndex, ProjOpt, ReverseDir, NormalPlane, Angle, AutoSize);
        }
        public static IRefPlaneObject ICreatePlaneAtSurface3(IModelDoc2Object IModelDoc2instance, Int16 InterIndex, Boolean ProjOpt, Boolean ReverseDir, Boolean NormalPlane, Double Angle, Boolean AutoSize)
        {
            return new IRefPlaneObject(IModelDoc2instance.IModelDoc2Instance.ICreatePlaneAtSurface3(InterIndex, ProjOpt, ReverseDir, NormalPlane, Angle, AutoSize));
        }
        public static Boolean InsertAxis2(IModelDoc2Object IModelDoc2instance, Boolean AutoSize)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertAxis2(AutoSize);
        }
        public static Boolean InsertSketchPicture(IModelDoc2Object IModelDoc2instance, String FileName)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertSketchPicture(FileName);
        }
        //public static void GetZebraStripeData(IModelDoc2Object IModelDoc2instance, Double& Size, Double& Ratio, Int32& Color1, Int32& Color2)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.GetZebraStripeData(Size, Ratio, Color1, Color2);
        //}
        public static void SetZebraStripeData(IModelDoc2Object IModelDoc2instance, Double Size, Double Ratio, Int32 Color1, Int32 Color2)
        {
            IModelDoc2instance.IModelDoc2Instance.SetZebraStripeData(Size, Ratio, Color1, Color2);
        }
        public static void InsertSketchPictureData(IModelDoc2Object IModelDoc2instance, Int16 Width, Int16 Height, Int32 PDataIn)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSketchPictureData(Width, Height, PDataIn);
        }
        public static void FeatureCurvePattern(IModelDoc2Object IModelDoc2instance, Int32 Num1, Double Spacing1, Int32 Num2, Double Spacing2, Boolean FlipDir1, Boolean FlipDir2, Boolean EqualSpacing1, Boolean EqualSpacing2, Boolean UseCentroid, Boolean AlignToSeed, Boolean OffsetCurve, Boolean PatternSeedOnly)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureCurvePattern(Num1, Spacing1, Num2, Spacing2, FlipDir1, FlipDir2, EqualSpacing1, EqualSpacing2, UseCentroid, AlignToSeed, OffsetCurve, PatternSeedOnly);
        }
        public static void InsertFeatureReplaceFace(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertFeatureReplaceFace();
        }
        public static void InsertRip(IModelDoc2Object IModelDoc2instance, Double Gap)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertRip(Gap);
        }
        public static Object InsertSheetMetalEdgeFlange(IModelDoc2Object IModelDoc2instance, Object FlangeEdge, Object SketchFeat, Int32 BooleanOptions, Double DAngle, Double DRadius, Int32 BendPosition, Double DOffsetDist, Int32 ReliefType, Double DReliefRatio, Double DReliefWidth, Double DReliefDepth)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertSheetMetalEdgeFlange(FlangeEdge, SketchFeat, BooleanOptions, DAngle, DRadius, BendPosition, DOffsetDist, ReliefType, DReliefRatio, DReliefWidth, DReliefDepth);
        }
        public static IFeatureObject IInsertSheetMetalEdgeFlange(IModelDoc2Object IModelDoc2instance, IEdgeObject FlangeEdge, IFeatureObject SketchFeat, Int32 BooleanOptions, Double DAngle, Double DRadius, Int32 BendPosition, Double DOffsetDist, Int32 ReliefType, Double DReliefRatio, Double DReliefWidth, Double DReliefDepth)
        {
            return new IFeatureObject(IModelDoc2instance.IModelDoc2Instance.IInsertSheetMetalEdgeFlange(FlangeEdge.IEdgeInstance as Edge, SketchFeat.IFeatureInstance as Feature, BooleanOptions, DAngle, DRadius, BendPosition, DOffsetDist, ReliefType, DReliefRatio, DReliefWidth, DReliefDepth));
        }
        public static Object InsertSketchText(IModelDoc2Object IModelDoc2instance, Double Ptx, Double Pty, Double Ptz, String Text, Int32 Alignment, Int32 FlipDirection, Int32 HorizontalMirror, Int32 WidthFactor, Int32 SpaceBetweenChars)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertSketchText(Ptx, Pty, Ptz, Text, Alignment, FlipDirection, HorizontalMirror, WidthFactor, SpaceBetweenChars);
        }
        public static ISketchTextObject IInsertSketchText(IModelDoc2Object IModelDoc2instance, Double Ptx, Double Pty, Double Ptz, String Text, Int32 Alignment, Int32 FlipDirection, Int32 HorizontalMirror, Int32 WidthFactor, Int32 SpaceBetweenChars)
        {
            return new ISketchTextObject(IModelDoc2instance.IModelDoc2Instance.IInsertSketchText(Ptx, Pty, Ptz, Text, Alignment, FlipDirection, HorizontalMirror, WidthFactor, SpaceBetweenChars));
        }
        public static void DissolveSketchText(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.DissolveSketchText();
        }
        public static void MoldDraftAnalysis(IModelDoc2Object IModelDoc2instance, Double Angle, Int32 Options, Object Colors, Int32 Shows)
        {
            IModelDoc2instance.IModelDoc2Instance.MoldDraftAnalysis(Angle, Options, Colors, Shows);
        }
        public static void InsertSheetMetalJog(IModelDoc2Object IModelDoc2instance, Double Angle, Double Radius, Double OffsetDist, Boolean FlipDir, Boolean FixProjLen, Int16 DimPos, Int16 BendPos)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSheetMetalJog(Angle, Radius, OffsetDist, FlipDir, FixProjLen, DimPos, BendPos);
        }
        public static Object InsertSketchForEdgeFlange(IModelDoc2Object IModelDoc2instance, Object FlangeEdge, Double DAngle, Boolean FlipDir)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertSketchForEdgeFlange(FlangeEdge, DAngle, FlipDir);
        }
        public static IFeatureObject IInsertSketchForEdgeFlange(IModelDoc2Object IModelDoc2instance, IEdgeObject FlangeEdge, Double DAngle, Boolean FlipDir)
        {
            return new IFeatureObject(IModelDoc2instance.IModelDoc2Instance.IInsertSketchForEdgeFlange(FlangeEdge.IEdgeInstance as Edge, DAngle, FlipDir));
        }
        public static void ClearSelection2(IModelDoc2Object IModelDoc2instance, Boolean All)
        {
            IModelDoc2instance.IModelDoc2Instance.ClearSelection2(All);
        }
        //public static void ListExternalFileReferences2(IModelDoc2Object IModelDoc2instance, Object& ModelPathName, Object& ComponentPathName, Object& Feature, Object& DataType, Object& Status, Object& RefEntity, Object& FeatCom)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.ListExternalFileReferences2(ModelPathName, ComponentPathName, Feature, DataType, Status, RefEntity, FeatCom);
        //}
        public static Int32 ListExternalFileReferencesCount2(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.ListExternalFileReferencesCount2();
        }
        //public static void IListExternalFileReferences2(IModelDoc2Object IModelDoc2instance, Int32 NumRefs, String& ModelPathName, String& CompPathName, String& Feature, String& DataType, Int32& Status, String& RefEntity, String& FeatComp)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IListExternalFileReferences2(NumRefs, ModelPathName, CompPathName, Feature, DataType, Status, RefEntity, FeatComp);
        //}
        public static Boolean InsertDeleteFace2(IModelDoc2Object IModelDoc2instance, Int32 Refill)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertDeleteFace2(Refill);
        }
        public static void AddLoftSection(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.AddLoftSection();
        }
        public static Object InsertMacroFeature(IModelDoc2Object IModelDoc2instance, String CmdFile, String CmdModule, String CmdProcedure, Object ParamNames, Object ParamTypes, Object ParamValues, String PmFile, String PmModule, String PmProcedure)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertMacroFeature(CmdFile, CmdModule, CmdProcedure, ParamNames, ParamTypes, ParamValues, PmFile, PmModule, PmProcedure);
        }
        //public static IFeatureObject IInsertMacroFeature(IModelDoc2Object IModelDoc2instance, String CmdFile, String CmdModule, String CmdProcedure, Int32 ParamCount, String& ParamNames, Int32& ParamTypes, String& ParamValues, String PmFile, String PmModule, String PmProcedure)
        //{
        //    return new IFeatureObject(IModelDoc2instance.IModelDoc2Instance.IInsertMacroFeature(CmdFile, CmdModule, CmdProcedure, ParamCount, ParamNames, ParamTypes, ParamValues, PmFile, PmModule, PmProcedure));
        //}
        //public static void ListAuxiliaryExternalFileReferences(IModelDoc2Object IModelDoc2instance, Object& Feature, Object& ExternalFileName)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.ListAuxiliaryExternalFileReferences(Feature, ExternalFileName);
        //}
        public static Int32 ListAuxiliaryExternalFileReferencesCount(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.ListAuxiliaryExternalFileReferencesCount();
        }
        //public static void IListAuxiliaryExternalFileReferences(IModelDoc2Object IModelDoc2instance, Int32 NumRefs, String& Feature, String& ExternalFileName)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IListAuxiliaryExternalFileReferences(NumRefs, Feature, ExternalFileName);
        //}
        public static void FeatureCut5(IModelDoc2Object IModelDoc2instance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Int32 KeepPieceIndex, Boolean NormalCut)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureCut5(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, KeepPieceIndex, NormalCut);
        }
        public static void FeatureBoss2(IModelDoc2Object IModelDoc2instance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureBoss2(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2);
        }
        public static Boolean DissolveLibraryFeature(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.DissolveLibraryFeature();
        }
        public static void FeatureExtruRefSurface2(IModelDoc2Object IModelDoc2instance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureExtruRefSurface2(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2);
        }
        public static void FeatureCutThin2(IModelDoc2Object IModelDoc2instance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Double Thk1, Double Thk2, Double EndThk, Int32 RevThinDir, Int32 CapEnds, Boolean AddBends, Double BendRad)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureCutThin2(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, Thk1, Thk2, EndThk, RevThinDir, CapEnds, AddBends, BendRad);
        }
        public static void FeatureBossThin2(IModelDoc2Object IModelDoc2instance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Double Thk1, Double Thk2, Double EndThk, Int32 RevThinDir, Int32 CapEnds, Boolean AddBends, Double BendRad)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureBossThin2(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, Thk1, Thk2, EndThk, RevThinDir, CapEnds, AddBends, BendRad);
        }
        public static void SimpleHole3(IModelDoc2Object IModelDoc2instance, Double Dia, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2)
        {
            IModelDoc2instance.IModelDoc2Instance.SimpleHole3(Dia, Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2);
        }
        public static void EditUndo2(IModelDoc2Object IModelDoc2instance, Int32 Steps)
        {
            IModelDoc2instance.IModelDoc2Instance.EditUndo2(Steps);
        }
        public static void EditRedo2(IModelDoc2Object IModelDoc2instance, Int32 Steps)
        {
            IModelDoc2instance.IModelDoc2Instance.EditRedo2(Steps);
        }
        public static Object GetDependencies2(IModelDoc2Object IModelDoc2instance, Boolean Traverseflag, Boolean Searchflag, Boolean AddReadOnlyInfo)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetDependencies2(Traverseflag, Searchflag, AddReadOnlyInfo);
        }
        public static String IGetDependencies2(IModelDoc2Object IModelDoc2instance, Boolean Traverseflag, Boolean Searchflag, Boolean AddReadOnlyInfo)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetDependencies2(Traverseflag, Searchflag, AddReadOnlyInfo);
        }
        public static Int32 IGetNumDependencies2(IModelDoc2Object IModelDoc2instance, Boolean Traverseflag, Boolean Searchflag, Boolean AddReadOnlyInfo)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetNumDependencies2(Traverseflag, Searchflag, AddReadOnlyInfo);
        }
        public static void InsertScale(IModelDoc2Object IModelDoc2instance, Double ScaleFactor_x, Double ScaleFactor_y, Double ScaleFactor_z, Boolean IsUniform, Int32 ScaleType)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertScale(ScaleFactor_x, ScaleFactor_y, ScaleFactor_z, IsUniform, ScaleType);
        }
        public static void LockAllExternalReferences(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.LockAllExternalReferences();
        }
        public static void UnlockAllExternalReferences(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.UnlockAllExternalReferences();
        }
        public static void BreakAllExternalReferences(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.BreakAllExternalReferences();
        }
        public static Boolean EditDimensionProperties(IModelDoc2Object IModelDoc2instance, Int32 TolType, Double TolMax, Double TolMin, String TolMaxFit, String TolMinFit, Boolean UseDocPrec, Int32 Precision, Int32 ArrowsIn, Boolean UseDocArrows, Int32 Arrow1, Int32 Arrow2)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditDimensionProperties(TolType, TolMax, TolMin, TolMaxFit, TolMinFit, UseDocPrec, Precision, ArrowsIn, UseDocArrows, Arrow1, Arrow2);
        }
        public static Boolean SketchPolygon(IModelDoc2Object IModelDoc2instance, Double XCenter, Double YCenter, Double XEdge, Double YEdge, Int32 NSides, Boolean BInscribed)
        {
            return IModelDoc2instance.IModelDoc2Instance.SketchPolygon(XCenter, YCenter, XEdge, YEdge, NSides, BInscribed);
        }
        public static Int32 GetBlockingState(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetBlockingState();
        }
        //public static Object CreateFeatureMgrView3(IModelDoc2Object IModelDoc2instance, Int32& Bitmap, String ToolTip, Int32 WhichPane)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.CreateFeatureMgrView3(Bitmap, ToolTip, WhichPane);
        //}
        //public static IFeatMgrViewObject ICreateFeatureMgrView3(IModelDoc2Object IModelDoc2instance, Int32& Bitmap, String ToolTip, Int32 WhichPane)
        //{
        //    return new IFeatMgrViewObject(IModelDoc2instance.IModelDoc2Instance.ICreateFeatureMgrView3(Bitmap, ToolTip, WhichPane));
        //}
        //public static Boolean AddFeatureMgrView3(IModelDoc2Object IModelDoc2instance, Int32& Bitmap, Int32& AppView, String ToolTip, Int32 WhichPane)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.AddFeatureMgrView3(Bitmap, AppView, ToolTip, WhichPane);
        //}
        public static Object CreatePlaneAtOffset2(IModelDoc2Object IModelDoc2instance, Double Val, Boolean FlipDir)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePlaneAtOffset2(Val, FlipDir);
        }
        public static IRefPlaneObject ICreatePlaneAtOffset2(IModelDoc2Object IModelDoc2instance, Double Val, Boolean FlipDir)
        {
            return new IRefPlaneObject(IModelDoc2instance.IModelDoc2Instance.ICreatePlaneAtOffset2(Val, FlipDir));
        }
        public static Object CreatePlaneAtAngle2(IModelDoc2Object IModelDoc2instance, Double Val, Boolean FlipDir)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePlaneAtAngle2(Val, FlipDir);
        }
        public static IRefPlaneObject ICreatePlaneAtAngle2(IModelDoc2Object IModelDoc2instance, Double Val, Boolean FlipDir)
        {
            return new IRefPlaneObject(IModelDoc2instance.IModelDoc2Instance.ICreatePlaneAtAngle2(Val, FlipDir));
        }
        public static Object CreatePlaneThru3Points2(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePlaneThru3Points2();
        }
        public static IRefPlaneObject ICreatePlaneThru3Points2(IModelDoc2Object IModelDoc2instance)
        {
            return new IRefPlaneObject(IModelDoc2instance.IModelDoc2Instance.ICreatePlaneThru3Points2());
        }
        public static Object CreatePlanePerCurveAndPassPoint2(IModelDoc2Object IModelDoc2instance, Boolean OrigAtCurve)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePlanePerCurveAndPassPoint2(OrigAtCurve);
        }
        public static IRefPlaneObject ICreatePlanePerCurveAndPassPoint2(IModelDoc2Object IModelDoc2instance, Boolean OrigAtCurve)
        {
            return new IRefPlaneObject(IModelDoc2instance.IModelDoc2Instance.ICreatePlanePerCurveAndPassPoint2(OrigAtCurve));
        }
        public static Object CreatePlaneAtSurface2(IModelDoc2Object IModelDoc2instance, Int32 InterIndex, Boolean ProjOpt, Boolean ReverseDir, Boolean NormalPlane, Double Angle)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePlaneAtSurface2(InterIndex, ProjOpt, ReverseDir, NormalPlane, Angle);
        }
        public static IRefPlaneObject ICreatePlaneAtSurface2(IModelDoc2Object IModelDoc2instance, Int32 InterIndex, Boolean ProjOpt, Boolean ReverseDir, Boolean NormalPlane, Double Angle)
        {
            return new IRefPlaneObject(IModelDoc2instance.IModelDoc2Instance.ICreatePlaneAtSurface2(InterIndex, ProjOpt, ReverseDir, NormalPlane, Angle));
        }
        public static Int32 GetUserPreferenceIntegerValue(IModelDoc2Object IModelDoc2instance, Int32 UserPreferenceValue)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetUserPreferenceIntegerValue(UserPreferenceValue);
        }
        public static Boolean SetUserPreferenceIntegerValue(IModelDoc2Object IModelDoc2instance, Int32 UserPreferenceValue, Int32 Value)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetUserPreferenceIntegerValue(UserPreferenceValue, Value);
        }
        public static Object GetUserPreferenceTextFormat(IModelDoc2Object IModelDoc2instance, Int32 UserPreferenceValue)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetUserPreferenceTextFormat(UserPreferenceValue);
        }
        public static ITextFormatObject IGetUserPreferenceTextFormat(IModelDoc2Object IModelDoc2instance, Int32 UserPreferenceValue)
        {
            return new ITextFormatObject(IModelDoc2instance.IModelDoc2Instance.IGetUserPreferenceTextFormat(UserPreferenceValue));
        }
        public static Boolean SetUserPreferenceTextFormat(IModelDoc2Object IModelDoc2instance, Int32 UserPreferenceValue, Object Value)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetUserPreferenceTextFormat(UserPreferenceValue, Value);
        }
        public static Boolean ISetUserPreferenceTextFormat(IModelDoc2Object IModelDoc2instance, Int32 UserPreferenceValue, ITextFormatObject Value)
        {
            return IModelDoc2instance.IModelDoc2Instance.ISetUserPreferenceTextFormat(UserPreferenceValue, Value.ITextFormatInstance as TextFormat);
        }
        public static void InsertRib2(IModelDoc2Object IModelDoc2instance, Boolean Is2Sided, Boolean ReverseThicknessDir, Double Thickness, Int32 ReferenceEdgeIndex, Boolean ReverseMaterialDir, Boolean IsDrafted, Boolean DraftOutward, Double DraftAngle, Boolean IsNormToSketch)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertRib2(Is2Sided, ReverseThicknessDir, Thickness, ReferenceEdgeIndex, ReverseMaterialDir, IsDrafted, DraftOutward, DraftAngle, IsNormToSketch);
        }
        public static Boolean InsertObjectFromFile(IModelDoc2Object IModelDoc2instance, String FilePath, Boolean CreateLink, Double Xx, Double Yy, Double Zz)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertObjectFromFile(FilePath, CreateLink, Xx, Yy, Zz);
        }
        public static void InspectCurvature(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InspectCurvature();
        }
        public static void RemoveInspectCurvature(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.RemoveInspectCurvature();
        }
        public static Object InsertDatumTag2(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertDatumTag2();
        }
        public static IDatumTagObject IInsertDatumTag2(IModelDoc2Object IModelDoc2instance)
        {
            return new IDatumTagObject(IModelDoc2instance.IModelDoc2Instance.IInsertDatumTag2());
        }
        //public static Int32 ActivateFeatureMgrView(IModelDoc2Object IModelDoc2instance, Int32& AppView)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.ActivateFeatureMgrView(AppView);
        //}
        public static void FeatureSketchDrivenPattern(IModelDoc2Object IModelDoc2instance, Boolean UseCentroid)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureSketchDrivenPattern(UseCentroid);
        }
        public static void HideShowBodies(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.HideShowBodies();
        }
        public static void HideSolidBody(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.HideSolidBody();
        }
        public static void ShowSolidBody(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ShowSolidBody();
        }
        public static void InsertFramePoint(IModelDoc2Object IModelDoc2instance, Double Xx, Double Yy, Double Zz)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertFramePoint(Xx, Yy, Zz);
        }
        public static void LockFramePoint(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.LockFramePoint();
        }
        public static void UnlockFramePoint(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.UnlockFramePoint();
        }
        public static Object InsertGtol(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertGtol();
        }
        public static IGtolObject IInsertGtol(IModelDoc2Object IModelDoc2instance)
        {
            return new IGtolObject(IModelDoc2instance.IModelDoc2Instance.IInsertGtol());
        }
        //public static Boolean DeActivateFeatureMgrView(IModelDoc2Object IModelDoc2instance, Int32& AppView)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.DeActivateFeatureMgrView(AppView);
        //}
        public static Object InsertNote(IModelDoc2Object IModelDoc2instance, String Text)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertNote(Text);
        }
        public static INoteObject IInsertNote(IModelDoc2Object IModelDoc2instance, String Text)
        {
            return new INoteObject(IModelDoc2instance.IModelDoc2Instance.IInsertNote(Text));
        }
        public static void SetSaveAsFileName(IModelDoc2Object IModelDoc2instance, String FileName)
        {
            IModelDoc2instance.IModelDoc2Instance.SetSaveAsFileName(FileName);
        }
        public static void ClosePrintPreview(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ClosePrintPreview();
        }
        public static void HideComponent2(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.HideComponent2();
        }
        public static void ShowComponent2(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ShowComponent2();
        }
        public static Boolean SaveBMP(IModelDoc2Object IModelDoc2instance, String FileNameIn, Int32 WidthIn, Int32 HeightIn)
        {
            return IModelDoc2instance.IModelDoc2Instance.SaveBMP(FileNameIn, WidthIn, HeightIn);
        }
        public static void InsertSketch2(IModelDoc2Object IModelDoc2instance, Boolean UpdateEditRebuild)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSketch2(UpdateEditRebuild);
        }
        public static void Insert3DSketch2(IModelDoc2Object IModelDoc2instance, Boolean UpdateEditRebuild)
        {
            IModelDoc2instance.IModelDoc2Instance.Insert3DSketch2(UpdateEditRebuild);
        }
        public static void InsertDeleteHole(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertDeleteHole();
        }
        public static void PreTrimSurface(IModelDoc2Object IModelDoc2instance, Boolean BMutualTrimIn)
        {
            IModelDoc2instance.IModelDoc2Instance.PreTrimSurface(BMutualTrimIn);
        }
        public static void PostTrimSurface(IModelDoc2Object IModelDoc2instance, Boolean BSewSurfaceIn)
        {
            IModelDoc2instance.IModelDoc2Instance.PostTrimSurface(BSewSurfaceIn);
        }
        public static void SketchConvertIsoCurves(IModelDoc2Object IModelDoc2instance, Double PercentRatio, Boolean VORuDir, Boolean DoConstrain, Boolean SkipHoles)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchConvertIsoCurves(PercentRatio, VORuDir, DoConstrain, SkipHoles);
        }
        public static void SelectLoop(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SelectLoop();
        }
        public static void InsertSheetMetalBaseFlange(IModelDoc2Object IModelDoc2instance, Double Thickness, Boolean ThickenDir, Double Radius, Double ExtrudeDist1, Double ExtrudeDist2, Boolean FlipExtruDir, Int32 EndCondition1, Int32 EndCondition2, Int32 DirToUse)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSheetMetalBaseFlange(Thickness, ThickenDir, Radius, ExtrudeDist1, ExtrudeDist2, FlipExtruDir, EndCondition1, EndCondition2, DirToUse);
        }
        public static void InsertSheetMetalFold(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSheetMetalFold();
        }
        public static void InsertSheetMetalUnfold(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSheetMetalUnfold();
        }
        public static void InsertSheetMetalMiterFlange(IModelDoc2Object IModelDoc2instance, Boolean UseReliefRatio, Boolean UseDefaultGap, Boolean UseAutoRelief, Double GlobalRadius, Double RipGap, Double AutoReliefRatio, Double AutoReliefWidth, Double AutoReliefDepth, Int32 ReliefType, Int32 RipLocation, Boolean TrimSideBends)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSheetMetalMiterFlange(UseReliefRatio, UseDefaultGap, UseAutoRelief, GlobalRadius, RipGap, AutoReliefRatio, AutoReliefWidth, AutoReliefDepth, ReliefType, RipLocation, TrimSideBends);
        }
        public static void CreateGroup(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.CreateGroup();
        }
        public static void RemoveItemsFromGroup(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.RemoveItemsFromGroup();
        }
        public static void RemoveGroups(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.RemoveGroups();
        }
        public static Object InsertBOMBalloon2(IModelDoc2Object IModelDoc2instance, Int32 Style, Int32 Size, Int32 UpperTextStyle, String UpperText, Int32 LowerTextStyle, String LowerText)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertBOMBalloon2(Style, Size, UpperTextStyle, UpperText, LowerTextStyle, LowerText);
        }
        public static INoteObject IInsertBOMBalloon2(IModelDoc2Object IModelDoc2instance, Int32 Style, Int32 Size, Int32 UpperTextStyle, String UpperText, Int32 LowerTextStyle, String LowerText)
        {
            return new INoteObject(IModelDoc2instance.IModelDoc2Instance.IInsertBOMBalloon2(Style, Size, UpperTextStyle, UpperText, LowerTextStyle, LowerText));
        }
        public static void EditRedo(IModelDoc2Object IModelDoc2instance, UInt32 NSteps)
        {
            IModelDoc2instance.IModelDoc2Instance.EditRedo(NSteps);
        }
        public static void InsertProtrusionBlend4(IModelDoc2Object IModelDoc2instance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational, Double TessToleranceFactor, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertProtrusionBlend4(Closed, KeepTangency, ForceNonRational, TessToleranceFactor, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType);
        }
        public static void InsertCutBlend4(IModelDoc2Object IModelDoc2instance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational, Double TessToleranceFactor, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertCutBlend4(Closed, KeepTangency, ForceNonRational, TessToleranceFactor, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType);
        }
        public static void InsertProtrusionSwept4(IModelDoc2Object IModelDoc2instance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertProtrusionSwept4(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType);
        }
        public static void InsertCutSwept4(IModelDoc2Object IModelDoc2instance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertCutSwept4(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType);
        }
        public static void SelectTangency(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SelectTangency();
        }
        public static Boolean InsertBendTableOpen(IModelDoc2Object IModelDoc2instance, String FileName)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertBendTableOpen(FileName);
        }
        public static Boolean InsertBendTableNew(IModelDoc2Object IModelDoc2instance, String FileName, String Units, String Type)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertBendTableNew(FileName, Units, Type);
        }
        public static void InsertBendTableEdit(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertBendTableEdit();
        }
        public static void DeleteBendTable(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.DeleteBendTable();
        }
        public static void InsertSheetMetal3dBend(IModelDoc2Object IModelDoc2instance, Double Angle, Double Radius, Boolean FlipDir, Int16 BendPos)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSheetMetal3dBend(Angle, Radius, FlipDir, BendPos);
        }
        public static Boolean CreateTangentArc2(IModelDoc2Object IModelDoc2instance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z, Int32 ArcTypeIn)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateTangentArc2(P1x, P1y, P1z, P2x, P2y, P2z, ArcTypeIn);
        }
        //public static Object GetMassProperties2(IModelDoc2Object IModelDoc2instance, Int32& Status)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.GetMassProperties2(Status);
        //}
        //public static Double IGetMassProperties2(IModelDoc2Object IModelDoc2instance, Int32& Status)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IGetMassProperties2(Status);
        //}
        public static void SketchChamfer(IModelDoc2Object IModelDoc2instance, Double AngleORdist, Double Dist1, Int32 Options)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchChamfer(AngleORdist, Dist1, Options);
        }
        public static void FeatureCut4(IModelDoc2Object IModelDoc2instance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Int32 KeepPieceIndex, Boolean NormalCut)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureCut4(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, KeepPieceIndex, NormalCut);
        }
        //public static Boolean GetAmbientLightProperties(IModelDoc2Object IModelDoc2instance, String Name, Double& Ambient, Double& Diffuse, Double& Specular, Int32& Colour, Boolean& Enabled, Boolean& Fixed)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.GetAmbientLightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed);
        //}
        public static Boolean SetPointLightProperties(IModelDoc2Object IModelDoc2instance, String Name, Double Ambient, Double Diffuse, Double Specular, Int32 Colour, Boolean Enabled, Boolean Fixed, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetPointLightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed, X, Y, Z);
        }
        //public static Boolean GetPointLightProperties(IModelDoc2Object IModelDoc2instance, String Name, Double& Ambient, Double& Diffuse, Double& Specular, Int32& Colour, Boolean& Enabled, Boolean& Fixed, Double& X, Double& Y, Double& Z)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.GetPointLightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed, X, Y, Z);
        //}
        public static Boolean SetDirectionLightProperties(IModelDoc2Object IModelDoc2instance, String Name, Double Ambient, Double Diffuse, Double Specular, Int32 Colour, Boolean Enabled, Boolean Fixed, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetDirectionLightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed, X, Y, Z);
        }
        //public static Boolean GetDirectionLightProperties(IModelDoc2Object IModelDoc2instance, String Name, Double& Ambient, Double& Diffuse, Double& Specular, Int32& Colour, Boolean& Enabled, Boolean& Fixed, Double& X, Double& Y, Double& Z)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.GetDirectionLightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed, X, Y, Z);
        //}
        public static Boolean SetSpotlightProperties(IModelDoc2Object IModelDoc2instance, String Name, Double Ambient, Double Diffuse, Double Specular, Int32 Colour, Boolean Enabled, Boolean Fixed, Double Posx, Double Posy, Double Posz, Double Targetx, Double Targety, Double Targetz, Double ConeAngle)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetSpotlightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed, Posx, Posy, Posz, Targetx, Targety, Targetz, ConeAngle);
        }
        //public static Boolean GetSpotlightProperties(IModelDoc2Object IModelDoc2instance, String Name, Double& Ambient, Double& Diffuse, Double& Specular, Int32& Colour, Boolean& Enabled, Boolean& Fixed, Double& X, Double& Y, Double& Z, Double& Targetx, Double& Targety, Double& Targetz, Double& ConeAngle)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.GetSpotlightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed, X, Y, Z, Targetx, Targety, Targetz, ConeAngle);
        //}
        public static void SplitOpenSegment(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            IModelDoc2instance.IModelDoc2Instance.SplitOpenSegment(X, Y, Z);
        }
        public static void AutoInferToggle(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.AutoInferToggle();
        }
        public static void SketchRectangleAtAnyAngle(IModelDoc2Object IModelDoc2instance, Double Val1, Double Val2, Double Z1, Double Val3, Double Val4, Double Z2, Double Val3x, Double Val3y, Double Z3, Boolean Val5)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchRectangleAtAnyAngle(Val1, Val2, Z1, Val3, Val4, Z2, Val3x, Val3y, Z3, Val5);
        }
        public static Boolean CreateCircularSketchStepAndRepeat(IModelDoc2Object IModelDoc2instance, Double ArcRadius, Double ArcAngle, Int32 PatternNum, Double PatternSpacing, Boolean PatternRotate, String DeleteInstances)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateCircularSketchStepAndRepeat(ArcRadius, ArcAngle, PatternNum, PatternSpacing, PatternRotate, DeleteInstances);
        }
        public static void SplitClosedSegment(IModelDoc2Object IModelDoc2instance, Double X0, Double Y0, Double Z0, Double X1, Double Y1, Double Z1)
        {
            IModelDoc2instance.IModelDoc2Instance.SplitClosedSegment(X0, Y0, Z0, X1, Y1, Z1);
        }
        public static Boolean IsLightLockedToModel(IModelDoc2Object IModelDoc2instance, Int32 LightId)
        {
            return IModelDoc2instance.IModelDoc2Instance.IsLightLockedToModel(LightId);
        }
        public static Boolean LockLightToModel(IModelDoc2Object IModelDoc2instance, Int32 LightId, Boolean Fix)
        {
            return IModelDoc2instance.IModelDoc2Instance.LockLightToModel(LightId, Fix);
        }
        public static Int32 FeatureFillet3(IModelDoc2Object IModelDoc2instance, Double R1, Boolean Propagate, Int32 Ftyp, Boolean VarRadTyp, Int32 OverflowType, Int32 NRadii, Object Radii, Boolean UseHelpPoint, Boolean UseTangentHoldLine)
        {
            return IModelDoc2instance.IModelDoc2Instance.FeatureFillet3(R1, Propagate, Ftyp, VarRadTyp, OverflowType, NRadii, Radii, UseHelpPoint, UseTangentHoldLine);
        }
        //public static Int32 IFeatureFillet3(IModelDoc2Object IModelDoc2instance, Double R1, Boolean Propagate, Int32 Ftyp, Boolean VarRadTyp, Int32 OverflowType, Int32 NRadii, Double& Radii, Boolean UseHelpPoint, Boolean UseTangentHoldLine)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IFeatureFillet3(R1, Propagate, Ftyp, VarRadTyp, OverflowType, NRadii, Radii, UseHelpPoint, UseTangentHoldLine);
        //}
        public static void InsertConnectionPoint(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertConnectionPoint();
        }
        public static void InsertRoutePoint(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertRoutePoint();
        }
        public static void FeatureBossThicken2(IModelDoc2Object IModelDoc2instance, Double Thickness, Int32 Direction, Int32 FaceIndex, Boolean FillVolume)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureBossThicken2(Thickness, Direction, FaceIndex, FillVolume);
        }
        public static void FeatureCutThicken2(IModelDoc2Object IModelDoc2instance, Double Thickness, Int32 Direction, Int32 FaceIndex, Boolean FillVolume)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureCutThicken2(Thickness, Direction, FaceIndex, FillVolume);
        }
        public static Object GetConfigurationByName(IModelDoc2Object IModelDoc2instance, String Name)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetConfigurationByName(Name);
        }
        public static IConfigurationObject IGetConfigurationByName(IModelDoc2Object IModelDoc2instance, String Name)
        {
            return new IConfigurationObject(IModelDoc2instance.IModelDoc2Instance.IGetConfigurationByName(Name));
        }
        public static Object CreatePoint2(IModelDoc2Object IModelDoc2instance, Double PointX, Double PointY, Double PointZ)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePoint2(PointX, PointY, PointZ);
        }
        public static ISketchPointObject ICreatePoint2(IModelDoc2Object IModelDoc2instance, Double PointX, Double PointY, Double PointZ)
        {
            return new ISketchPointObject(IModelDoc2instance.IModelDoc2Instance.ICreatePoint2(PointX, PointY, PointZ));
        }
        public static Object CreateLine2(IModelDoc2Object IModelDoc2instance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateLine2(P1x, P1y, P1z, P2x, P2y, P2z);
        }
        public static ISketchSegmentObject ICreateLine2(IModelDoc2Object IModelDoc2instance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z)
        {
            return new ISketchSegmentObject(IModelDoc2instance.IModelDoc2Instance.ICreateLine2(P1x, P1y, P1z, P2x, P2y, P2z));
        }
        public static Object GetActiveSketch2(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetActiveSketch2();
        }
        public static ISketchObject IGetActiveSketch2(IModelDoc2Object IModelDoc2instance)
        {
            return new ISketchObject(IModelDoc2instance.IModelDoc2Instance.IGetActiveSketch2());
        }
        public static void DrawLightIcons(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.DrawLightIcons();
        }
        public static Object GetLayerManager(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetLayerManager();
        }
        public static ILayerMgrObject IGetLayerManager(IModelDoc2Object IModelDoc2instance)
        {
            return new ILayerMgrObject(IModelDoc2instance.IModelDoc2Instance.IGetLayerManager());
        }
        public static Object CreateCircle2(IModelDoc2Object IModelDoc2instance, Double XC, Double YC, Double Zc, Double Xp, Double Yp, Double Zp)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateCircle2(XC, YC, Zc, Xp, Yp, Zp);
        }
        public static ISketchSegmentObject ICreateCircle2(IModelDoc2Object IModelDoc2instance, Double XC, Double YC, Double Zc, Double Xp, Double Yp, Double Zp)
        {
            return new ISketchSegmentObject(IModelDoc2instance.IModelDoc2Instance.ICreateCircle2(XC, YC, Zc, Xp, Yp, Zp));
        }
        public static Object CreateCircleByRadius2(IModelDoc2Object IModelDoc2instance, Double XC, Double YC, Double Zc, Double Radius)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateCircleByRadius2(XC, YC, Zc, Radius);
        }
        public static ISketchSegmentObject ICreateCircleByRadius2(IModelDoc2Object IModelDoc2instance, Double XC, Double YC, Double Zc, Double Radius)
        {
            return new ISketchSegmentObject(IModelDoc2instance.IModelDoc2Instance.ICreateCircleByRadius2(XC, YC, Zc, Radius));
        }
        public static Object CreateArc2(IModelDoc2Object IModelDoc2instance, Double XC, Double YC, Double Zc, Double Xp1, Double Yp1, Double Zp1, Double Xp2, Double Yp2, Double Zp2, Int16 Direction)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateArc2(XC, YC, Zc, Xp1, Yp1, Zp1, Xp2, Yp2, Zp2, Direction);
        }
        public static ISketchSegmentObject ICreateArc2(IModelDoc2Object IModelDoc2instance, Double XC, Double YC, Double Zc, Double Xp1, Double Yp1, Double Zp1, Double Xp2, Double Yp2, Double Zp2, Int16 Direction)
        {
            return new ISketchSegmentObject(IModelDoc2instance.IModelDoc2Instance.ICreateArc2(XC, YC, Zc, Xp1, Yp1, Zp1, Xp2, Yp2, Zp2, Direction));
        }
        public static Object CreateEllipse2(IModelDoc2Object IModelDoc2instance, Double CenterX, Double CenterY, Double CenterZ, Double MajorX, Double MajorY, Double MajorZ, Double MinorX, Double MinorY, Double MinorZ)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateEllipse2(CenterX, CenterY, CenterZ, MajorX, MajorY, MajorZ, MinorX, MinorY, MinorZ);
        }
        public static ISketchSegmentObject ICreateEllipse2(IModelDoc2Object IModelDoc2instance, Double CenterX, Double CenterY, Double CenterZ, Double MajorX, Double MajorY, Double MajorZ, Double MinorX, Double MinorY, Double MinorZ)
        {
            return new ISketchSegmentObject(IModelDoc2instance.IModelDoc2Instance.ICreateEllipse2(CenterX, CenterY, CenterZ, MajorX, MajorY, MajorZ, MinorX, MinorY, MinorZ));
        }
        public static Object CreateEllipticalArc2(IModelDoc2Object IModelDoc2instance, Double CenterX, Double CenterY, Double CenterZ, Double MajorX, Double MajorY, Double MajorZ, Double MinorX, Double MinorY, Double MinorZ, Double StartX, Double StartY, Double StartZ, Double EndX, Double EndY, Double EndZ)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateEllipticalArc2(CenterX, CenterY, CenterZ, MajorX, MajorY, MajorZ, MinorX, MinorY, MinorZ, StartX, StartY, StartZ, EndX, EndY, EndZ);
        }
        public static ISketchSegmentObject ICreateEllipticalArc2(IModelDoc2Object IModelDoc2instance, Double CenterX, Double CenterY, Double CenterZ, Double MajorX, Double MajorY, Double MajorZ, Double MinorX, Double MinorY, Double MinorZ, Double StartX, Double StartY, Double StartZ, Double EndX, Double EndY, Double EndZ)
        {
            return new ISketchSegmentObject(IModelDoc2instance.IModelDoc2Instance.ICreateEllipticalArc2(CenterX, CenterY, CenterZ, MajorX, MajorY, MajorZ, MinorX, MinorY, MinorZ, StartX, StartY, StartZ, EndX, EndY, EndZ));
        }
        public static Object CreateSpline(IModelDoc2Object IModelDoc2instance, Object PointData)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateSpline(PointData);
        }
        //public static ISketchSegmentObject ICreateSpline(IModelDoc2Object IModelDoc2instance, Int32 PointCount, Double& PointData)
        //{
        //    return new ISketchSegmentObject(IModelDoc2instance.IModelDoc2Instance.ICreateSpline(PointCount, PointData));
        //}
        public static void ViewZoomtofit2(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewZoomtofit2();
        }
        public static void SetInferenceMode(IModelDoc2Object IModelDoc2instance, Boolean InferenceMode)
        {
            IModelDoc2instance.IModelDoc2Instance.SetInferenceMode(InferenceMode);
        }
        public static Boolean GetInferenceMode(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetInferenceMode();
        }
        public static Boolean SetTitle2(IModelDoc2Object IModelDoc2instance, String NewTitle)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetTitle2(NewTitle);
        }
        public static Boolean SketchFillet2(IModelDoc2Object IModelDoc2instance, Double Rad, Int16 ConstrainedCorners)
        {
            return IModelDoc2instance.IModelDoc2Instance.SketchFillet2(Rad, ConstrainedCorners);
        }
        public static Boolean IsTessellationValid(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.IsTessellationValid();
        }
        public static void EditRoute(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.EditRoute();
        }
        public static void FileReload(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.FileReload();
        }
        public static Object GetDesignTable(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetDesignTable();
        }
        public static IDesignTableObject IGetDesignTable(IModelDoc2Object IModelDoc2instance)
        {
            return new IDesignTableObject(IModelDoc2instance.IModelDoc2Instance.IGetDesignTable());
        }
        public static String GetEntityName(IModelDoc2Object IModelDoc2instance, Object Entity)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetEntityName(Entity);
        }
        //public static String IGetEntityName(IModelDoc2Object IModelDoc2instance, EntityObject Entity)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IGetEntityName(Entity);
        //}
        public static IModelDoc2Object IGetNext(IModelDoc2Object IModelDoc2instance)
        {
            return new IModelDoc2Object(IModelDoc2instance.IModelDoc2Instance.IGetNext());
        }
        public static Boolean ShowConfiguration2(IModelDoc2Object IModelDoc2instance, String ConfigurationName)
        {
            return IModelDoc2instance.IModelDoc2Instance.ShowConfiguration2(ConfigurationName);
        }
        public static Boolean AddConfiguration2(IModelDoc2Object IModelDoc2instance, String Name, String Comment, String AlternateName, Boolean SuppressByDefault, Boolean HideByDefault, Boolean MinFeatureManager, Boolean InheritProperties, UInt32 Flags)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddConfiguration2(Name, Comment, AlternateName, SuppressByDefault, HideByDefault, MinFeatureManager, InheritProperties, Flags);
        }
        public static Boolean DeleteConfiguration2(IModelDoc2Object IModelDoc2instance, String ConfigurationName)
        {
            return IModelDoc2instance.IModelDoc2Instance.DeleteConfiguration2(ConfigurationName);
        }
        public static Boolean EditConfiguration2(IModelDoc2Object IModelDoc2instance, String Name, String NewName, String Comment, String AlternateName, Boolean SuppressByDefault, Boolean HideByDefault, Boolean MinFeatureManager, Boolean InheritProperties, UInt32 Flags)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditConfiguration2(Name, NewName, Comment, AlternateName, SuppressByDefault, HideByDefault, MinFeatureManager, InheritProperties, Flags);
        }
        public static Object CreateSplineByEqnParams(IModelDoc2Object IModelDoc2instance, Object ParamsIn)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateSplineByEqnParams(ParamsIn);
        }
        //public static ISketchSegmentObject ICreateSplineByEqnParams(IModelDoc2Object IModelDoc2instance, Int32& PropArray, Double& KnotsArray, Double& CntrlPntCoordArray)
        //{
        //    return new ISketchSegmentObject(IModelDoc2instance.IModelDoc2Instance.ICreateSplineByEqnParams(PropArray, KnotsArray, CntrlPntCoordArray));
        //}
        //public static Object CreateFeatureMgrView2(IModelDoc2Object IModelDoc2instance, Int32& Bitmap, String ToolTip)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.CreateFeatureMgrView2(Bitmap, ToolTip);
        //}
        //public static IFeatMgrViewObject ICreateFeatureMgrView2(IModelDoc2Object IModelDoc2instance, Int32& Bitmap, String ToolTip)
        //{
        //    return new IFeatMgrViewObject(IModelDoc2instance.IModelDoc2Instance.ICreateFeatureMgrView2(Bitmap, ToolTip));
        //}
        //public static Boolean AddFeatureMgrView2(IModelDoc2Object IModelDoc2instance, Int32& Bitmap, Int32& AppView, String ToolTip)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.AddFeatureMgrView2(Bitmap, AppView, ToolTip);
        //}
        public static void FeatureCut3(IModelDoc2Object IModelDoc2instance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Int32 KeepPieceIndex)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureCut3(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, KeepPieceIndex);
        }
        public static Object GetFirstAnnotation2(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetFirstAnnotation2();
        }
        public static IAnnotationObject IGetFirstAnnotation2(IModelDoc2Object IModelDoc2instance)
        {
            return new IAnnotationObject(IModelDoc2instance.IModelDoc2Instance.IGetFirstAnnotation2());
        }
        public static void InsertExtendSurface(IModelDoc2Object IModelDoc2instance, Boolean ExtendLinear, Int32 EndCondition, Double Distance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertExtendSurface(ExtendLinear, EndCondition, Distance);
        }
        public static void InsertTangencySurface(IModelDoc2Object IModelDoc2instance, Boolean OneSide, Boolean IsFlip)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertTangencySurface(OneSide, IsFlip);
        }
        public static Object CreateSplinesByEqnParams(IModelDoc2Object IModelDoc2instance, Object ParamsIn)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateSplinesByEqnParams(ParamsIn);
        }
        //public static IEnumSketchSegmentsObject ICreateSplinesByEqnParams(IModelDoc2Object IModelDoc2instance, Int32& PropArray, Double& KnotsArray, Double& CntrlPntCoordArray)
        //{
        //    return new IEnumSketchSegmentsObject(IModelDoc2instance.IModelDoc2Instance.ICreateSplinesByEqnParams(PropArray, KnotsArray, CntrlPntCoordArray));
        //}
        public static Object CreateClippedSplines(IModelDoc2Object IModelDoc2instance, Object ParamsIn, Double X1, Double Y1, Double X2, Double Y2)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateClippedSplines(ParamsIn, X1, Y1, X2, Y2);
        }
        //public static IEnumSketchSegmentsObject ICreateClippedSplines(IModelDoc2Object IModelDoc2instance, Int32& PropArray, Double& KnotsArray, Double& CntrlPntCoordArray, Double X1, Double Y1, Double X2, Double Y2)
        //{
        //    return new IEnumSketchSegmentsObject(IModelDoc2instance.IModelDoc2Instance.ICreateClippedSplines(PropArray, KnotsArray, CntrlPntCoordArray, X1, Y1, X2, Y2));
        //}
        public static Boolean EditSuppress2(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditSuppress2();
        }
        public static Boolean EditUnsuppress2(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditUnsuppress2();
        }
        public static Boolean EditUnsuppressDependent2(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditUnsuppressDependent2();
        }
        public static Boolean EditRollback2(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditRollback2();
        }
        public static void HideDimension(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.HideDimension();
        }
        public static void ShowFeatureDimensions(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ShowFeatureDimensions();
        }
        public static void HideFeatureDimensions(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.HideFeatureDimensions();
        }
        public static void Sketch3DIntersections(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Sketch3DIntersections();
        }
        public static Int32 FeatureFillet4(IModelDoc2Object IModelDoc2instance, Double R1, Boolean Propagate, Boolean UniformRadius, Int32 Ftyp, Boolean VarRadTyp, Int32 OverflowType, Int32 NRadii, Object Radii, Boolean UseHelpPoint, Boolean UseTangentHoldLine, Boolean CornerType, Int32 SetbackDistCount, Object SetBackDistances)
        {
            return IModelDoc2instance.IModelDoc2Instance.FeatureFillet4(R1, Propagate, UniformRadius, Ftyp, VarRadTyp, OverflowType, NRadii, Radii, UseHelpPoint, UseTangentHoldLine, CornerType, SetbackDistCount, SetBackDistances);
        }
        //public static Int32 IFeatureFillet4(IModelDoc2Object IModelDoc2instance, Double R1, Boolean Propagate, Boolean UniformRadius, Int32 Ftyp, Boolean VarRadTyp, Int32 OverflowType, Int32 NRadii, Double& Radii, Boolean UseHelpPoint, Boolean UseTangentHoldLine, Boolean CornerType, Int32 SetbackDistCount, Double& SetBackDistances)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IFeatureFillet4(R1, Propagate, UniformRadius, Ftyp, VarRadTyp, OverflowType, NRadii, Radii, UseHelpPoint, UseTangentHoldLine, CornerType, SetbackDistCount, SetBackDistances);
        //}
        public static void InsertDeleteFace(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertDeleteFace();
        }
        public static Int32 SaveSilent(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.SaveSilent();
        }
        public static Int32 SaveAsSilent(IModelDoc2Object IModelDoc2instance, String NewName, Boolean SaveAsCopy)
        {
            return IModelDoc2instance.IModelDoc2Instance.SaveAsSilent(NewName, SaveAsCopy);
        }
        public static Boolean AddCustomInfo2(IModelDoc2Object IModelDoc2instance, String FieldName, Int32 FieldType, String FieldValue)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddCustomInfo2(FieldName, FieldType, FieldValue);
        }
        public static Int32 GetCustomInfoType2(IModelDoc2Object IModelDoc2instance, String FieldName)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetCustomInfoType2(FieldName);
        }
        public static Boolean InsertRefPoint(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertRefPoint();
        }
        public static Int32 FeatureFillet2(IModelDoc2Object IModelDoc2instance, Double R1, Boolean Propagate, Boolean Ftyp, Boolean VarRadTyp, Int32 OverflowType, Int32 NRadii, Object Radii)
        {
            return IModelDoc2instance.IModelDoc2Instance.FeatureFillet2(R1, Propagate, Ftyp, VarRadTyp, OverflowType, NRadii, Radii);
        }
        //public static Int32 IFeatureFillet2(IModelDoc2Object IModelDoc2instance, Double R1, Boolean Propagate, Boolean Ftyp, Boolean VarRadTyp, Int32 OverflowType, Int32 NRadii, Double& Radii)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IFeatureFillet2(R1, Propagate, Ftyp, VarRadTyp, OverflowType, NRadii, Radii);
        //}
        public static Object GetFirstAnnotation(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetFirstAnnotation();
        }
        public static IAnnotationObject IGetFirstAnnotation(IModelDoc2Object IModelDoc2instance)
        {
            return new IAnnotationObject(IModelDoc2instance.IModelDoc2Instance.IGetFirstAnnotation());
        }
        public static Boolean InsertCoordinateSystem(IModelDoc2Object IModelDoc2instance, Boolean XFlippedIn, Boolean YFlippedIn, Boolean ZFlippedIn)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertCoordinateSystem(XFlippedIn, YFlippedIn, ZFlippedIn);
        }
        public static Boolean GetToolbarVisibility(IModelDoc2Object IModelDoc2instance, Int32 Toolbar)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetToolbarVisibility(Toolbar);
        }
        public static void SetToolbarVisibility(IModelDoc2Object IModelDoc2instance, Int32 Toolbar, Boolean Visibility)
        {
            IModelDoc2instance.IModelDoc2Instance.SetToolbarVisibility(Toolbar, Visibility);
        }
        public static void ViewDispCoordinateSystems(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewDispCoordinateSystems();
        }
        public static void ViewDispTempRefaxes(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewDispTempRefaxes();
        }
        public static void ViewDispRefPoints(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewDispRefPoints();
        }
        public static void ViewDispOrigins(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewDispOrigins();
        }
        public static Object GetCoordinateSystemXformByName(IModelDoc2Object IModelDoc2instance, String NameIn)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetCoordinateSystemXformByName(NameIn);
        }
        public static Double IGetCoordinateSystemXformByName(IModelDoc2Object IModelDoc2instance, String NameIn)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetCoordinateSystemXformByName(NameIn);
        }
        public static String GetCurrentCoordinateSystemName(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetCurrentCoordinateSystemName();
        }
        //public static IEnumModelViewsObject EnumModelViews(IModelDoc2Object IModelDoc2instance)
        //{
        //    return new IEnumModelViewsObject(IModelDoc2instance.IModelDoc2Instance.EnumModelViews());
        //}
        public static Boolean InsertCompositeCurve(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertCompositeCurve();
        }
        public static void SketchParabola(IModelDoc2Object IModelDoc2instance, Double Val1, Double Val2, Double Z1, Double Val3, Double Val4, Double Z2, Double Val5, Double Val6, Double Z3, Double Val7, Double Val8, Double Z4)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchParabola(Val1, Val2, Z1, Val3, Val4, Z2, Val5, Val6, Z3, Val7, Val8, Z4);
        }
        public static void InsertRadiateSurface(IModelDoc2Object IModelDoc2instance, Double Distance, Boolean FlipDir, Boolean TangentPropagate)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertRadiateSurface(Distance, FlipDir, TangentPropagate);
        }
        public static void InsertSewRefSurface(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSewRefSurface();
        }
        public static Int32 InsertShape(IModelDoc2Object IModelDoc2instance, Int32 PressureOn, Int32 TangentsOn, Double PressureGain, Double TangentGain, Double CurveSpringGain, Double Alpha, Double Beta, Double Gamma, Double Delta, Int32 Degree, Int32 Split, Int32 Tuning)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertShape(PressureOn, TangentsOn, PressureGain, TangentGain, CurveSpringGain, Alpha, Beta, Gamma, Delta, Degree, Split, Tuning);
        }
        public static void InsertMfDraft2(IModelDoc2Object IModelDoc2instance, Double Angle, Boolean FlipDir, Boolean IsEdgeDraft, Int32 PropType, Boolean StepDraft)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertMfDraft2(Angle, FlipDir, IsEdgeDraft, PropType, StepDraft);
        }
        public static Int32 GetConfigurationCount(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetConfigurationCount();
        }
        public static Object GetConfigurationNames(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetConfigurationNames();
        }
        //public static String IGetConfigurationNames(IModelDoc2Object IModelDoc2instance, Int32& Count)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IGetConfigurationNames(Count);
        //}
        public static void FeatureCut2(IModelDoc2Object IModelDoc2instance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Int32 KeepPieceIndex)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureCut2(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, KeepPieceIndex);
        }
        public static void InsertCutSurface(IModelDoc2Object IModelDoc2instance, Boolean Flip, Int32 KeepPieceIndex)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertCutSurface(Flip, KeepPieceIndex);
        }
        public static Object GetDetailingDefaults(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetDetailingDefaults();
        }
        public static IDetailingDefaultsObject IGetDetailingDefaults(IModelDoc2Object IModelDoc2instance)
        {
            return new IDetailingDefaultsObject(IModelDoc2instance.IModelDoc2Instance.IGetDetailingDefaults());
        }
        public static Int32 ListExternalFileReferencesCount(IModelDoc2Object IModelDoc2instance, Boolean UseSearchRules)
        {
            return IModelDoc2instance.IModelDoc2Instance.ListExternalFileReferencesCount(UseSearchRules);
        }
        public static Object ListExternalFileReferences(IModelDoc2Object IModelDoc2instance, Boolean UseSearchRules)
        {
            return IModelDoc2instance.IModelDoc2Instance.ListExternalFileReferences(UseSearchRules);
        }
        public static String IListExternalFileReferences(IModelDoc2Object IModelDoc2instance, Boolean UseSearchRules, Int32 NumRefs)
        {
            return IModelDoc2instance.IModelDoc2Instance.IListExternalFileReferences(UseSearchRules, NumRefs);
        }
        public static Boolean SketchSplineByEqnParams2(IModelDoc2Object IModelDoc2instance, Object ParamsIn)
        {
            return IModelDoc2instance.IModelDoc2Instance.SketchSplineByEqnParams2(ParamsIn);
        }
        public static Object GetFirstModelView(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetFirstModelView();
        }
        public static IModelViewObject IGetFirstModelView(IModelDoc2Object IModelDoc2instance)
        {
            return new IModelViewObject(IModelDoc2instance.IModelDoc2Instance.IGetFirstModelView());
        }
        public static Boolean InsertPlanarRefSurface(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertPlanarRefSurface();
        }
        public static Object GetNext(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetNext();
        }
        public static Boolean GetSaveFlag(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetSaveFlag();
        }
        public static Boolean AddCustomInfo3(IModelDoc2Object IModelDoc2instance, String Configuration, String FieldName, Int32 FieldType, String FieldValue)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddCustomInfo3(Configuration, FieldName, FieldType, FieldValue);
        }
        public static Boolean DeleteCustomInfo2(IModelDoc2Object IModelDoc2instance, String Configuration, String FieldName)
        {
            return IModelDoc2instance.IModelDoc2Instance.DeleteCustomInfo2(Configuration, FieldName);
        }
        public static Int32 GetCustomInfoCount2(IModelDoc2Object IModelDoc2instance, String Configuration)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetCustomInfoCount2(Configuration);
        }
        public static Object GetCustomInfoNames2(IModelDoc2Object IModelDoc2instance, String Configuration)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetCustomInfoNames2(Configuration);
        }
        public static String IGetCustomInfoNames2(IModelDoc2Object IModelDoc2instance, String Configuration)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetCustomInfoNames2(Configuration);
        }
        public static Int32 GetCustomInfoType3(IModelDoc2Object IModelDoc2instance, String Configuration, String FieldName)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetCustomInfoType3(Configuration, FieldName);
        }
        public static Boolean GetConsiderLeadersAsLines(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetConsiderLeadersAsLines();
        }
        public static Boolean SetConsiderLeadersAsLines(IModelDoc2Object IModelDoc2instance, Boolean LeadersAsLines)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetConsiderLeadersAsLines(LeadersAsLines);
        }
        public static void InsertRevolvedRefSurface(IModelDoc2Object IModelDoc2instance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertRevolvedRefSurface(Angle, ReverseDir, Angle2, RevType);
        }
        public static Int32 GetBendState(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetBendState();
        }
        public static Int32 SetBendState(IModelDoc2Object IModelDoc2instance, Int32 BendState)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetBendState(BendState);
        }
        public static void ClearUndoList(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ClearUndoList();
        }
        public static Int32 GetFeatureManagerWidth(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetFeatureManagerWidth();
        }
        public static Int32 SetFeatureManagerWidth(IModelDoc2Object IModelDoc2instance, Int32 Width)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetFeatureManagerWidth(Width);
        }
        public static Object InsertProjectedSketch2(IModelDoc2Object IModelDoc2instance, Int32 Reverse)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertProjectedSketch2(Reverse);
        }
        public static IFeatureObject IInsertProjectedSketch2(IModelDoc2Object IModelDoc2instance, Int32 Reverse)
        {
            return new IFeatureObject(IModelDoc2instance.IModelDoc2Instance.IInsertProjectedSketch2(Reverse));
        }
        public static Int32 GetFeatureCount(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetFeatureCount();
        }
        public static Object FeatureByPositionReverse(IModelDoc2Object IModelDoc2instance, Int32 Num)
        {
            return IModelDoc2instance.IModelDoc2Instance.FeatureByPositionReverse(Num);
        }
        public static IFeatureObject IFeatureByPositionReverse(IModelDoc2Object IModelDoc2instance, Int32 Num)
        {
            return new IFeatureObject(IModelDoc2instance.IModelDoc2Instance.IFeatureByPositionReverse(Num));
        }
        public static Int32 RayIntersections(IModelDoc2Object IModelDoc2instance, Object BodiesIn, Object BasePointsIn, Object VectorsIn, Int32 Options, Double HitRadius, Double Offset)
        {
            return IModelDoc2instance.IModelDoc2Instance.RayIntersections(BodiesIn, BasePointsIn, VectorsIn, Options, HitRadius, Offset);
        }
        //public static Int32 IRayIntersections(IModelDoc2Object IModelDoc2instance, Body2&Object BodiesIn, Int32 NumBodies, Double& BasePointsIn, Double& VectorsIn, Int32 NumRays, Int32 Options, Double HitRadius, Double Offset)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IRayIntersections(BodiesIn, NumBodies, BasePointsIn, VectorsIn, NumRays, Options, HitRadius, Offset);
        //}
        public static Object GetRayIntersectionsPoints(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetRayIntersectionsPoints();
        }
        public static Double IGetRayIntersectionsPoints(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetRayIntersectionsPoints();
        }
        public static Object GetRayIntersectionsTopology(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetRayIntersectionsTopology();
        }
        public static Object IGetRayIntersectionsTopology(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetRayIntersectionsTopology();
        }
        public static void EditSeedFeat(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.EditSeedFeat();
        }
        public static Boolean EditSuppress(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditSuppress();
        }
        public static Boolean EditUnsuppress(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditUnsuppress();
        }
        public static Boolean EditUnsuppressDependent(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditUnsuppressDependent();
        }
        public static Boolean EditRollback(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditRollback();
        }
        public static Int32 Save2(IModelDoc2Object IModelDoc2instance, Boolean Silent)
        {
            return IModelDoc2instance.IModelDoc2Instance.Save2(Silent);
        }
        public static Int32 SaveAs2(IModelDoc2Object IModelDoc2instance, String NewName, Int32 SaveAsVersion, Boolean SaveAsCopy, Boolean Silent)
        {
            return IModelDoc2instance.IModelDoc2Instance.SaveAs2(NewName, SaveAsVersion, SaveAsCopy, Silent);
        }
        public static void SetPopupMenuMode(IModelDoc2Object IModelDoc2instance, Int32 ModeIn)
        {
            IModelDoc2instance.IModelDoc2Instance.SetPopupMenuMode(ModeIn);
        }
        public static Int32 GetPopupMenuMode(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetPopupMenuMode();
        }
        public static void CloseFamilyTable(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.CloseFamilyTable();
        }
        public static void CreatePlaneAtSurface(IModelDoc2Object IModelDoc2instance, Int32 InterIndex, Boolean ProjOpt, Boolean ReverseDir, Boolean NormalPlane, Double Angle)
        {
            IModelDoc2instance.IModelDoc2Instance.CreatePlaneAtSurface(InterIndex, ProjOpt, ReverseDir, NormalPlane, Angle);
        }
        public static void SketchOffset(IModelDoc2Object IModelDoc2instance, Double Offset, Boolean ContourMode)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchOffset(Offset, ContourMode);
        }
        public static Boolean CreateLinearSketchStepAndRepeat(IModelDoc2Object IModelDoc2instance, Int32 NumX, Int32 NumY, Double SpacingX, Double SpacingY, Double AngleX, Double AngleY, String DeleteInstances)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateLinearSketchStepAndRepeat(NumX, NumY, SpacingX, SpacingY, AngleX, AngleY, DeleteInstances);
        }
        public static Boolean SetAmbientLightProperties(IModelDoc2Object IModelDoc2instance, String Name, Double Ambient, Double Diffuse, Double Specular, Int32 Colour, Boolean Enabled, Boolean Fixed)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetAmbientLightProperties(Name, Ambient, Diffuse, Specular, Colour, Enabled, Fixed);
        }
        public static void GraphicsRedraw2(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.GraphicsRedraw2();
        }
        public static void InsertCosmeticThread(IModelDoc2Object IModelDoc2instance, Int16 Type, Double Depth, Double Length, String Note)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertCosmeticThread(Type, Depth, Length, Note);
        }
        public static void HideCosmeticThread(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.HideCosmeticThread();
        }
        public static void ShowCosmeticThread(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ShowCosmeticThread();
        }
        public static void SimpleHole2(IModelDoc2Object IModelDoc2instance, Double Dia, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2)
        {
            IModelDoc2instance.IModelDoc2Instance.SimpleHole2(Dia, Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2);
        }
        public static void IRelease3rdPartyStorage(IModelDoc2Object IModelDoc2instance, String StringIn)
        {
            IModelDoc2instance.IModelDoc2Instance.IRelease3rdPartyStorage(StringIn);
        }
        public static Int32 FeatureRevolve2(IModelDoc2Object IModelDoc2instance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType, Int32 Options)
        {
            return IModelDoc2instance.IModelDoc2Instance.FeatureRevolve2(Angle, ReverseDir, Angle2, RevType, Options);
        }
        public static Int32 FeatureRevolveCut2(IModelDoc2Object IModelDoc2instance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType, Int32 Options)
        {
            return IModelDoc2instance.IModelDoc2Instance.FeatureRevolveCut2(Angle, ReverseDir, Angle2, RevType, Options);
        }
        public static void SetSaveFlag(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SetSaveFlag();
        }
        public static String GetExternalReferenceName(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetExternalReferenceName();
        }
        public static Boolean SelectByRay(IModelDoc2Object IModelDoc2instance, Object DoubleInfoIn, Int32 TypeWanted)
        {
            return IModelDoc2instance.IModelDoc2Instance.SelectByRay(DoubleInfoIn, TypeWanted);
        }
        //public static Boolean ISelectByRay(IModelDoc2Object IModelDoc2instance, Double& PointIn, Double& VectorIn, Double RadiusIn, Int32 TypeWanted)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.ISelectByRay(PointIn, VectorIn, RadiusIn, TypeWanted);
        //}
        public static void SetSceneBkgDIB(IModelDoc2Object IModelDoc2instance, Int32 L_dib)
        {
            IModelDoc2instance.IModelDoc2Instance.SetSceneBkgDIB(L_dib);
        }
        public static void InsertBkgImage(IModelDoc2Object IModelDoc2instance, String NewName)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertBkgImage(NewName);
        }
        public static void DeleteBkgImage(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.DeleteBkgImage();
        }
        public static void InsertSplinePoint(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSplinePoint(X, Y, Z);
        }
        public static void InsertLoftRefSurface2(IModelDoc2Object IModelDoc2instance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational, Double TessToleranceFactor, Int16 StartMatchingType, Int16 EndMatchingType)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertLoftRefSurface2(Closed, KeepTangency, ForceNonRational, TessToleranceFactor, StartMatchingType, EndMatchingType);
        }
        public static void InsertProtrusionBlend3(IModelDoc2Object IModelDoc2instance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational, Double TessToleranceFactor, Int16 StartMatchingType, Int16 EndMatchingType)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertProtrusionBlend3(Closed, KeepTangency, ForceNonRational, TessToleranceFactor, StartMatchingType, EndMatchingType);
        }
        public static void InsertCutBlend3(IModelDoc2Object IModelDoc2instance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational, Double TessToleranceFactor, Int16 StartMatchingType, Int16 EndMatchingType)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertCutBlend3(Closed, KeepTangency, ForceNonRational, TessToleranceFactor, StartMatchingType, EndMatchingType);
        }
        public static void AlignDimensions(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.AlignDimensions();
        }
        public static void BreakDimensionAlignment(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.BreakDimensionAlignment();
        }
        public static void SketchFillet1(IModelDoc2Object IModelDoc2instance, Double Rad)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchFillet1(Rad);
        }
        public static void FeatureChamferType(IModelDoc2Object IModelDoc2instance, Int16 ChamferType, Double Width, Double Angle, Boolean Flip, Double OtherDist, Double VertexChamDist1, Double VertexChamDist2, Double VertexChamDist3)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureChamferType(ChamferType, Width, Angle, Flip, OtherDist, VertexChamDist1, VertexChamDist2, VertexChamDist3);
        }
        public static void FeatureCutThin(IModelDoc2Object IModelDoc2instance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Double Thk1, Double Thk2, Double EndThk, Int32 RevThinDir, Int32 CapEnds, Boolean AddBends, Double BendRad)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureCutThin(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, Thk1, Thk2, EndThk, RevThinDir, CapEnds, AddBends, BendRad);
        }
        public static void FeatureBossThin(IModelDoc2Object IModelDoc2instance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Double Thk1, Double Thk2, Double EndThk, Int32 RevThinDir, Int32 CapEnds, Boolean AddBends, Double BendRad)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureBossThin(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, Thk1, Thk2, EndThk, RevThinDir, CapEnds, AddBends, BendRad);
        }
        public static Boolean InsertDatumTargetSymbol(IModelDoc2Object IModelDoc2instance, String Datum1, String Datum2, String Datum3, Int16 AreaStyle, Boolean AreaOutside, Double Value1, Double Value2, String ValueStr1, String ValueStr2, Boolean ArrowsSmart, Int16 ArrowStyle, Int16 LeaderLineStyle, Boolean LeaderBent, Boolean ShowArea, Boolean ShowSymbol)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertDatumTargetSymbol(Datum1, Datum2, Datum3, AreaStyle, AreaOutside, Value1, Value2, ValueStr1, ValueStr2, ArrowsSmart, ArrowStyle, LeaderLineStyle, LeaderBent, ShowArea, ShowSymbol);
        }
        public static Boolean EditDatumTargetSymbol(IModelDoc2Object IModelDoc2instance, String Datum1, String Datum2, String Datum3, Int16 AreaStyle, Boolean AreaOutside, Double Value1, Double Value2, String ValueStr1, String ValueStr2, Boolean ArrowsSmart, Int16 ArrowStyle, Int16 LeaderLineStyle, Boolean LeaderBent, Boolean ShowArea, Boolean ShowSymbol)
        {
            return IModelDoc2instance.IModelDoc2Instance.EditDatumTargetSymbol(Datum1, Datum2, Datum3, AreaStyle, AreaOutside, Value1, Value2, ValueStr1, ValueStr2, ArrowsSmart, ArrowStyle, LeaderLineStyle, LeaderBent, ShowArea, ShowSymbol);
        }
        public static void InsertBOMBalloon(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertBOMBalloon();
        }
        //public static Object FeatureReferenceCurve(IModelDoc2Object IModelDoc2instance, Int32 NumOfCurves, Object BaseCurves, Boolean Merge, String FromFileName, Int32& ErrorCode)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.FeatureReferenceCurve(NumOfCurves, BaseCurves, Merge, FromFileName, ErrorCode);
        //}
        //public static IReferenceCurveObject IFeatureReferenceCurve(IModelDoc2Object IModelDoc2instance, Int32 NumOfCurves, Curve&Object BaseCurves, Boolean Merge, String FromFileName, Int32& ErrorCode)
        //{
        //    return new IReferenceCurveObject(IModelDoc2instance.IModelDoc2Instance.IFeatureReferenceCurve(NumOfCurves, BaseCurves, Merge, FromFileName, ErrorCode));
        //}
        public static void FontBold(IModelDoc2Object IModelDoc2instance, Boolean Bold)
        {
            IModelDoc2instance.IModelDoc2Instance.FontBold(Bold);
        }
        public static void FontItalic(IModelDoc2Object IModelDoc2instance, Boolean Italic)
        {
            IModelDoc2instance.IModelDoc2Instance.FontItalic(Italic);
        }
        public static void FontUnderline(IModelDoc2Object IModelDoc2instance, Boolean Underline)
        {
            IModelDoc2instance.IModelDoc2Instance.FontUnderline(Underline);
        }
        public static void FontFace(IModelDoc2Object IModelDoc2instance, String Face)
        {
            IModelDoc2instance.IModelDoc2Instance.FontFace(Face);
        }
        public static void FontPoints(IModelDoc2Object IModelDoc2instance, Int16 Points)
        {
            IModelDoc2instance.IModelDoc2Instance.FontPoints(Points);
        }
        public static void FontUnits(IModelDoc2Object IModelDoc2instance, Double Units)
        {
            IModelDoc2instance.IModelDoc2Instance.FontUnits(Units);
        }
        public static Boolean SketchSplineByEqnParams(IModelDoc2Object IModelDoc2instance, Object ParamsIn)
        {
            return IModelDoc2instance.IModelDoc2Instance.SketchSplineByEqnParams(ParamsIn);
        }
        public static void AlignParallelDimensions(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.AlignParallelDimensions();
        }
        public static void SetBlockingState(IModelDoc2Object IModelDoc2instance, Int32 StateIn)
        {
            IModelDoc2instance.IModelDoc2Instance.SetBlockingState(StateIn);
        }
        public static void ResetBlockingState(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ResetBlockingState();
        }
        public static Int32 GetSceneBkgDIB(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetSceneBkgDIB();
        }
        public static void InsertHatchedFace(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertHatchedFace();
        }
        public static Object GetColorTable(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetColorTable();
        }
        public static IColorTableObject IGetColorTable(IModelDoc2Object IModelDoc2instance)
        {
            return new IColorTableObject(IModelDoc2instance.IModelDoc2Instance.IGetColorTable());
        }
        public static void InsertSweepRefSurface2(IModelDoc2Object IModelDoc2instance, Boolean Propagate, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSweepRefSurface2(Propagate, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType);
        }
        public static void InsertProtrusionSwept3(IModelDoc2Object IModelDoc2instance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertProtrusionSwept3(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType);
        }
        public static void InsertCutSwept3(IModelDoc2Object IModelDoc2instance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertCutSwept3(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType);
        }
        public static Boolean IsOpenedViewOnly(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.IsOpenedViewOnly();
        }
        public static Boolean IsOpenedReadOnly(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.IsOpenedReadOnly();
        }
        public static void ViewZoomToSelection(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewZoomToSelection();
        }
        public static void FeatureBossThicken(IModelDoc2Object IModelDoc2instance, Double Thickness, Int32 Direction, Int32 FaceIndex)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureBossThicken(Thickness, Direction, FaceIndex);
        }
        public static void FeatureCutThicken(IModelDoc2Object IModelDoc2instance, Double Thickness, Int32 Direction, Int32 FaceIndex)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureCutThicken(Thickness, Direction, FaceIndex);
        }
        public static Boolean InsertAxis(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertAxis();
        }
        public static void EditUndo(IModelDoc2Object IModelDoc2instance, UInt32 NSteps)
        {
            IModelDoc2instance.IModelDoc2Instance.EditUndo(NSteps);
        }
        public static void SelectMidpoint(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SelectMidpoint();
        }
        //public static Int32 ISketchSplineByEqnParams(IModelDoc2Object IModelDoc2instance, Int32& PropArray, Double& KnotsArray, Double& CntrlPntCoordArray)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.ISketchSplineByEqnParams(PropArray, KnotsArray, CntrlPntCoordArray);
        //}
        public static Object VersionHistory(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.VersionHistory();
        }
        public static String IVersionHistory(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.IVersionHistory();
        }
        public static Int32 IGetVersionHistoryCount(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetVersionHistoryCount();
        }
        public static void Rebuild(IModelDoc2Object IModelDoc2instance, Int32 Options)
        {
            IModelDoc2instance.IModelDoc2Instance.Rebuild(Options);
        }
        public static void InsertFeatureShellAddThickness(IModelDoc2Object IModelDoc2instance, Double Thickness)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertFeatureShellAddThickness(Thickness);
        }
        public static void InsertOffsetSurface(IModelDoc2Object IModelDoc2instance, Double Thickness, Boolean Reverse)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertOffsetSurface(Thickness, Reverse);
        }
        public static void SimplifySpline(IModelDoc2Object IModelDoc2instance, Double ToleranceIn)
        {
            IModelDoc2instance.IModelDoc2Instance.SimplifySpline(ToleranceIn);
        }
        public static Int32 GetCustomInfoCount(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetCustomInfoCount();
        }
        public static String GetCustomInfoType(IModelDoc2Object IModelDoc2instance, String FieldName)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetCustomInfoType(FieldName);
        }
        public static Object GetCustomInfoNames(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetCustomInfoNames();
        }
        public static String IGetCustomInfoNames(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetCustomInfoNames();
        }
        public static Boolean AddCustomInfo(IModelDoc2Object IModelDoc2instance, String FieldName, String FieldType, String FieldValue)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddCustomInfo(FieldName, FieldType, FieldValue);
        }
        public static Boolean DeleteCustomInfo(IModelDoc2Object IModelDoc2instance, String FieldName)
        {
            return IModelDoc2instance.IModelDoc2Instance.DeleteCustomInfo(FieldName);
        }
        public static void PrintOut2(IModelDoc2Object IModelDoc2instance, Int32 FromPage, Int32 ToPage, Int32 NumCopies, Boolean Collate, String Printer, Double Scale, Boolean PrintToFile, String PtfName)
        {
            IModelDoc2instance.IModelDoc2Instance.PrintOut2(FromPage, ToPage, NumCopies, Collate, Printer, Scale, PrintToFile, PtfName);
        }
        public static Boolean SetReadOnlyState(IModelDoc2Object IModelDoc2instance, Boolean SetReadOnly)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetReadOnlyState(SetReadOnly);
        }
        public static Boolean InsertFamilyTableOpen(IModelDoc2Object IModelDoc2instance, String FileName)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertFamilyTableOpen(FileName);
        }
        public static Boolean MultiSelectByRay(IModelDoc2Object IModelDoc2instance, Object DoubleInfoIn, Int32 TypeWanted, Boolean Append)
        {
            return IModelDoc2instance.IModelDoc2Instance.MultiSelectByRay(DoubleInfoIn, TypeWanted, Append);
        }
        //public static Boolean IMultiSelectByRay(IModelDoc2Object IModelDoc2instance, Double& PointIn, Double& VectorIn, Double RadiusIn, Int32 TypeWanted, Boolean Append)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IMultiSelectByRay(PointIn, VectorIn, RadiusIn, TypeWanted, Append);
        //}
        public static void InsertNewNote3(IModelDoc2Object IModelDoc2instance, String UpperText, Boolean NoLeader, Boolean BentLeader, Int16 ArrowStyle, Int16 LeaderSide, Double Angle, Int16 BalloonStyle, Int16 BalloonFit, Boolean SmartArrow)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertNewNote3(UpperText, NoLeader, BentLeader, ArrowStyle, LeaderSide, Angle, BalloonStyle, BalloonFit, SmartArrow);
        }
        public static void InsertWeldSymbol2(IModelDoc2Object IModelDoc2instance, String Dim1, String Symbol, String Dim2, Boolean Symmetric, Boolean FieldWeld, Boolean ShowOtherSide, Boolean DashOnTop, Boolean Peripheral, Boolean HasProcess, String ProcessValue)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertWeldSymbol2(Dim1, Symbol, Dim2, Symmetric, FieldWeld, ShowOtherSide, DashOnTop, Peripheral, HasProcess, ProcessValue);
        }
        public static Boolean InsertSurfaceFinishSymbol2(IModelDoc2Object IModelDoc2instance, Int32 SymType, Int32 LeaderType, Double LocX, Double LocY, Double LocZ, Int32 LaySymbol, Int32 ArrowType, String MachAllowance, String OtherVals, String ProdMethod, String SampleLen, String MaxRoughness, String MinRoughness, String RoughnessSpacing)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertSurfaceFinishSymbol2(SymType, LeaderType, LocX, LocY, LocZ, LaySymbol, ArrowType, MachAllowance, OtherVals, ProdMethod, SampleLen, MaxRoughness, MinRoughness, RoughnessSpacing);
        }
        public static void FeatureExtruRefSurface(IModelDoc2Object IModelDoc2instance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureExtruRefSurface(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2);
        }
        public static Object IGet3rdPartyStorage(IModelDoc2Object IModelDoc2instance, String StringIn, Boolean IsStoring)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGet3rdPartyStorage(StringIn, IsStoring);
        }
        //public static void DeleteFeatureMgrView(IModelDoc2Object IModelDoc2instance, Int32& AppView)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.DeleteFeatureMgrView(AppView);
        //}
        public static Object GetMassProperties(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetMassProperties();
        }
        //public static Boolean IGetMassProperties(IModelDoc2Object IModelDoc2instance, Double& MPropsData)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.IGetMassProperties(MPropsData);
        //}
        public static Int32 GetLightSourceCount(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetLightSourceCount();
        }
        public static Int32 GetLightSourceIdFromName(IModelDoc2Object IModelDoc2instance, String LightName)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetLightSourceIdFromName(LightName);
        }
        public static void SetNextSelectionGroupId(IModelDoc2Object IModelDoc2instance, Int32 ID)
        {
            IModelDoc2instance.IModelDoc2Instance.SetNextSelectionGroupId(ID);
        }
        public static void ISetNextSelectionGroupId(IModelDoc2Object IModelDoc2instance, Int32 ID)
        {
            IModelDoc2instance.IModelDoc2Instance.ISetNextSelectionGroupId(ID);
        }
        public static Object InsertMidSurfaceExt(IModelDoc2Object IModelDoc2instance, Double Placement, Boolean KnitFlag)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertMidSurfaceExt(Placement, KnitFlag);
        }
        public static IMidSurface2Object IInsertMidSurfaceExt(IModelDoc2Object IModelDoc2instance, Double Placement, Boolean KnitFlag)
        {
            return new IMidSurface2Object(IModelDoc2instance.IModelDoc2Instance.IInsertMidSurfaceExt(Placement, KnitFlag));
        }
        //public static void ICreatePlaneFixed(IModelDoc2Object IModelDoc2instance, Double& P1, Double& P2, Double& P3, Boolean UseGlobal)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.ICreatePlaneFixed(P1, P2, P3, UseGlobal);
        //}
        public static Boolean SelectByMark(IModelDoc2Object IModelDoc2instance, String SelID, String SelParams, Double X, Double Y, Double Z, Int32 Mark)
        {
            return IModelDoc2instance.IModelDoc2Instance.SelectByMark(SelID, SelParams, X, Y, Z, Mark);
        }
        public static Boolean AndSelectByMark(IModelDoc2Object IModelDoc2instance, String SelID, String SelParams, Double X, Double Y, Double Z, Int32 Mark)
        {
            return IModelDoc2instance.IModelDoc2Instance.AndSelectByMark(SelID, SelParams, X, Y, Z, Mark);
        }
        public static Object GetDependencies(IModelDoc2Object IModelDoc2instance, Int32 Traverseflag, Int32 Searchflag)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetDependencies(Traverseflag, Searchflag);
        }
        public static String IGetDependencies(IModelDoc2Object IModelDoc2instance, Int32 Traverseflag, Int32 Searchflag)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetDependencies(Traverseflag, Searchflag);
        }
        public static Int32 GetNumDependencies(IModelDoc2Object IModelDoc2instance, Int32 Traverseflag, Int32 Searchflag)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetNumDependencies(Traverseflag, Searchflag);
        }
        public static Int32 IGetNumDependencies(IModelDoc2Object IModelDoc2instance, Int32 Traverseflag, Int32 Searchflag)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetNumDependencies(Traverseflag, Searchflag);
        }
        public static Object FirstFeature(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.FirstFeature();
        }
        public static IFeatureObject IFirstFeature(IModelDoc2Object IModelDoc2instance)
        {
            return new IFeatureObject(IModelDoc2instance.IModelDoc2Instance.IFirstFeature());
        }
        public static void UnderiveSketch(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.UnderiveSketch();
        }
        public static void DeriveSketch(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.DeriveSketch();
        }
        public static Boolean IsExploded(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.IsExploded();
        }
        public static Boolean DeleteSelection(IModelDoc2Object IModelDoc2instance, Boolean ConfirmFlag)
        {
            return IModelDoc2instance.IModelDoc2Instance.DeleteSelection(ConfirmFlag);
        }
        public static Boolean DeleteNamedView(IModelDoc2Object IModelDoc2instance, String ViewName)
        {
            return IModelDoc2instance.IModelDoc2Instance.DeleteNamedView(ViewName);
        }
        public static Boolean SetLightSourceName(IModelDoc2Object IModelDoc2instance, Int32 ID, String NewName)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetLightSourceName(ID, NewName);
        }
        public static void Insert3DSplineCurve(IModelDoc2Object IModelDoc2instance, Boolean CurveClosed)
        {
            IModelDoc2instance.IModelDoc2Instance.Insert3DSplineCurve(CurveClosed);
        }
        public static Boolean SetLightSourcePropertyValuesVB(IModelDoc2Object IModelDoc2instance, String IdName, Int32 LType, Double Diff, Int32 RgbColor, Double Dist, Double DirX, Double DirY, Double DirZ, Double SpotDirX, Double SpotDirY, Double SpotDirZ, Double SpotAngle, Double FallOff0, Double FallOff1, Double FallOff2, Double Ambient, Double Specular, Double SpotExponent, Boolean BDisable)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetLightSourcePropertyValuesVB(IdName, LType, Diff, RgbColor, Dist, DirX, DirY, DirZ, SpotDirX, SpotDirY, SpotDirZ, SpotAngle, FallOff0, FallOff1, FallOff2, Ambient, Specular, SpotExponent, BDisable);
        }
        //public static IFeatMgrViewObject ICreateFeatureMgrView(IModelDoc2Object IModelDoc2instance, Int32& Bitmap)
        //{
        //    return new IFeatMgrViewObject(IModelDoc2instance.IModelDoc2Instance.ICreateFeatureMgrView(Bitmap));
        //}
        public static Boolean SelectedEdgeProperties(IModelDoc2Object IModelDoc2instance, String EdgeName)
        {
            return IModelDoc2instance.IModelDoc2Instance.SelectedEdgeProperties(EdgeName);
        }
        public static Boolean SelectedFaceProperties(IModelDoc2Object IModelDoc2instance, Int32 RgbColor, Double Ambient, Double Diffuse, Double Specular, Double Shininess, Double Transparency, Double Emission, Boolean UsePartProps, String FaceName)
        {
            return IModelDoc2instance.IModelDoc2Instance.SelectedFaceProperties(RgbColor, Ambient, Diffuse, Specular, Shininess, Transparency, Emission, UsePartProps, FaceName);
        }
        public static Boolean SelectedFeatureProperties(IModelDoc2Object IModelDoc2instance, Int32 RgbColor, Double Ambient, Double Diffuse, Double Specular, Double Shininess, Double Transparency, Double Emission, Boolean UsePartProps, Boolean Suppressed, String FeatureName)
        {
            return IModelDoc2instance.IModelDoc2Instance.SelectedFeatureProperties(RgbColor, Ambient, Diffuse, Specular, Shininess, Transparency, Emission, UsePartProps, Suppressed, FeatureName);
        }
        public static void InsertSplitLineSil(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSplitLineSil();
        }
        public static void InsertSplitLineProject(IModelDoc2Object IModelDoc2instance, Boolean IsDirectional, Boolean FlipDir)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSplitLineProject(IsDirectional, FlipDir);
        }
        public static void InsertRib(IModelDoc2Object IModelDoc2instance, Boolean Is2Sided, Boolean ReverseThicknessDir, Double Thickness, Int32 ReferenceEdgeIndex, Boolean ReverseMaterialDir, Boolean IsDrafted, Boolean DraftOutward, Double DraftAngle)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertRib(Is2Sided, ReverseThicknessDir, Thickness, ReferenceEdgeIndex, ReverseMaterialDir, IsDrafted, DraftOutward, DraftAngle);
        }
        public static Boolean AddRadialDimension(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddRadialDimension(X, Y, Z);
        }
        public static Boolean AddDiameterDimension(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddDiameterDimension(X, Y, Z);
        }
        public static Object GetModelViewNames(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetModelViewNames();
        }
        public static String IGetModelViewNames(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetModelViewNames();
        }
        public static Int32 GetModelViewCount(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetModelViewCount();
        }
        public static Double GetUserPreferenceDoubleValue(IModelDoc2Object IModelDoc2instance, Int32 UserPreferenceValue)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetUserPreferenceDoubleValue(UserPreferenceValue);
        }
        public static Boolean SetUserPreferenceDoubleValue(IModelDoc2Object IModelDoc2instance, Int32 UserPreferenceValue, Double Value)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetUserPreferenceDoubleValue(UserPreferenceValue, Value);
        }
        public static void ViewDisplayCurvature(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewDisplayCurvature();
        }
        public static void Scale(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Scale();
        }
        public static void AddIns(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.AddIns();
        }
        public static Boolean InsertCurveFile(IModelDoc2Object IModelDoc2instance, String FileName)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertCurveFile(FileName);
        }
        public static void InsertCurveFileBegin(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertCurveFileBegin();
        }
        public static Boolean InsertCurveFilePoint(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertCurveFilePoint(X, Y, Z);
        }
        public static Boolean InsertCurveFileEnd(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.InsertCurveFileEnd();
        }
        public static Boolean ChangeSketchPlane(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.ChangeSketchPlane();
        }
        public static void ViewOrientationUndo(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewOrientationUndo();
        }
        public static void PrintOut(IModelDoc2Object IModelDoc2instance, Int32 FromPage, Int32 ToPage, Int32 NumCopies, Boolean Collate, String Printer, Double Scale, Boolean PrintToFile)
        {
            IModelDoc2instance.IModelDoc2Instance.PrintOut(FromPage, ToPage, NumCopies, Collate, Printer, Scale, PrintToFile);
        }
        public static void SketchOffsetEntities(IModelDoc2Object IModelDoc2instance, Double Offset, Boolean Flip)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchOffsetEntities(Offset, Flip);
        }
        public static void InsertLibraryFeature(IModelDoc2Object IModelDoc2instance, String LibFeatPartNameIn)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertLibraryFeature(LibFeatPartNameIn);
        }
        public static void SketchModifyTranslate(IModelDoc2Object IModelDoc2instance, Double StartX, Double StartY, Double EndX, Double EndY)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchModifyTranslate(StartX, StartY, EndX, EndY);
        }
        public static void SketchModifyRotate(IModelDoc2Object IModelDoc2instance, Double CenterX, Double CenterY, Double Angle)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchModifyRotate(CenterX, CenterY, Angle);
        }
        public static void SketchModifyFlip(IModelDoc2Object IModelDoc2instance, Int32 AxisFlag)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchModifyFlip(AxisFlag);
        }
        public static Boolean SketchModifyScale(IModelDoc2Object IModelDoc2instance, Double ScaleFactor)
        {
            return IModelDoc2instance.IModelDoc2Instance.SketchModifyScale(ScaleFactor);
        }
        public static Object GetActiveConfiguration(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetActiveConfiguration();
        }
        public static IConfigurationObject IGetActiveConfiguration(IModelDoc2Object IModelDoc2instance)
        {
            return new IConfigurationObject(IModelDoc2instance.IModelDoc2Instance.IGetActiveConfiguration());
        }
        public static Boolean GetUserPreferenceToggle(IModelDoc2Object IModelDoc2instance, Int32 UserPreferenceToggle)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetUserPreferenceToggle(UserPreferenceToggle);
        }
        public static Boolean SetUserPreferenceToggle(IModelDoc2Object IModelDoc2instance, Int32 UserPreferenceValue, Boolean OnFlag)
        {
            return IModelDoc2instance.IModelDoc2Instance.SetUserPreferenceToggle(UserPreferenceValue, OnFlag);
        }
        public static void InsertSweepRefSurface(IModelDoc2Object IModelDoc2instance, Boolean Propagate, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSweepRefSurface(Propagate, TwistCtrlOption, KeepTangency, ForceNonRational);
        }
        public static void InsertLoftRefSurface(IModelDoc2Object IModelDoc2instance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertLoftRefSurface(Closed, KeepTangency, ForceNonRational);
        }
        public static void InsertProtrusionSwept2(IModelDoc2Object IModelDoc2instance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertProtrusionSwept2(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational);
        }
        public static void InsertProtrusionBlend2(IModelDoc2Object IModelDoc2instance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertProtrusionBlend2(Closed, KeepTangency, ForceNonRational);
        }
        public static void InsertCutSwept2(IModelDoc2Object IModelDoc2instance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertCutSwept2(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational);
        }
        public static void InsertCutBlend2(IModelDoc2Object IModelDoc2instance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertCutBlend2(Closed, KeepTangency, ForceNonRational);
        }
        public static Boolean IsEditingSelf(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.IsEditingSelf();
        }
        public static void ShowNamedView2(IModelDoc2Object IModelDoc2instance, String VName, Int32 ViewId)
        {
            IModelDoc2instance.IModelDoc2Instance.ShowNamedView2(VName, ViewId);
        }
        public static void InsertDome(IModelDoc2Object IModelDoc2instance, Double Height, Boolean ReverseDir, Boolean DoEllipticSurface)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertDome(Height, ReverseDir, DoEllipticSurface);
        }
        public static Int32 AddPropertyExtension(IModelDoc2Object IModelDoc2instance, Object PropertyExtension)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddPropertyExtension(PropertyExtension);
        }
        public static Object GetPropertyExtension(IModelDoc2Object IModelDoc2instance, Int32 ID)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetPropertyExtension(ID);
        }
        public static void ResetPropertyExtension(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ResetPropertyExtension();
        }
        public static Int32 GetUpdateStamp(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetUpdateStamp();
        }
        public static void ViewZoomTo2(IModelDoc2Object IModelDoc2instance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewZoomTo2(X1, Y1, Z1, X2, Y2, Z2);
        }
        public static void ScreenRotate(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ScreenRotate();
        }
        public static void UnblankSketch(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.UnblankSketch();
        }
        public static void EditSketchOrSingleSketchFeature(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.EditSketchOrSingleSketchFeature();
        }
        public static void DebugCheckIgesGeom(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.DebugCheckIgesGeom();
        }
        public static void BlankSketch(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.BlankSketch();
        }
        public static Double GetDefaultTextHeight(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetDefaultTextHeight();
        }
        public static Boolean IsActive(IModelDoc2Object IModelDoc2instance, String CompStr)
        {
            return IModelDoc2instance.IModelDoc2Instance.IsActive(CompStr);
        }
        public static Boolean CreateEllipse(IModelDoc2Object IModelDoc2instance, Object Center, Object Major, Object Minor)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateEllipse(Center, Major, Minor);
        }
        public static Boolean CreateEllipseVB(IModelDoc2Object IModelDoc2instance, Double CenterX, Double CenterY, Double CenterZ, Double MajorX, Double MajorY, Double MajorZ, Double MinorX, Double MinorY, Double MinorZ)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateEllipseVB(CenterX, CenterY, CenterZ, MajorX, MajorY, MajorZ, MinorX, MinorY, MinorZ);
        }
        public static Boolean CreateEllipticalArcByCenter(IModelDoc2Object IModelDoc2instance, Object Center, Object Major, Object Minor, Object Start, Object End)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateEllipticalArcByCenter(Center, Major, Minor, Start, End);
        }
        public static Boolean CreateEllipticalArcByCenterVB(IModelDoc2Object IModelDoc2instance, Double CenterX, Double CenterY, Double CenterZ, Double MajorX, Double MajorY, Double MajorZ, Double MinorX, Double MinorY, Double MinorZ, Double StartX, Double StartY, Double StartZ, Double EndX, Double EndY, Double EndZ)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateEllipticalArcByCenterVB(CenterX, CenterY, CenterZ, MajorX, MajorY, MajorZ, MinorX, MinorY, MinorZ, StartX, StartY, StartZ, EndX, EndY, EndZ);
        }
        public static Object GetActiveSketch(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetActiveSketch();
        }
        public static ISketchObject IGetActiveSketch(IModelDoc2Object IModelDoc2instance)
        {
            return new ISketchObject(IModelDoc2instance.IModelDoc2Instance.IGetActiveSketch());
        }
        public static Int32 GetTessellationQuality(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetTessellationQuality();
        }
        public static void SetTessellationQuality(IModelDoc2Object IModelDoc2instance, Int32 QualityNum)
        {
            IModelDoc2instance.IModelDoc2Instance.SetTessellationQuality(QualityNum);
        }
        public static Object Parameter(IModelDoc2Object IModelDoc2instance, String StringIn)
        {
            return IModelDoc2instance.IModelDoc2Instance.Parameter(StringIn);
        }
        public static IDimensionObject IParameter(IModelDoc2Object IModelDoc2instance, String StringIn)
        {
            return new IDimensionObject(IModelDoc2instance.IModelDoc2Instance.IParameter(StringIn));
        }
        public static Boolean SelectByID(IModelDoc2Object IModelDoc2instance, String SelID, String SelParams, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.SelectByID(SelID, SelParams, X, Y, Z);
        }
        public static Boolean AndSelectByID(IModelDoc2Object IModelDoc2instance, String SelID, String SelParams, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.AndSelectByID(SelID, SelParams, X, Y, Z);
        }
        public static void Insert3DSketch(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Insert3DSketch();
        }
        public static String GetLightSourceName(IModelDoc2Object IModelDoc2instance, Int32 ID)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetLightSourceName(ID);
        }
        public static Boolean AddLightSource(IModelDoc2Object IModelDoc2instance, String IdName, Int32 LTyp, String UserName)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddLightSource(IdName, LTyp, UserName);
        }
        public static Int32 AddLightSourceExtProperty(IModelDoc2Object IModelDoc2instance, Int32 ID, Object PropertyExtension)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddLightSourceExtProperty(ID, PropertyExtension);
        }
        public static void ResetLightSourceExtProperty(IModelDoc2Object IModelDoc2instance, Int32 ID)
        {
            IModelDoc2instance.IModelDoc2Instance.ResetLightSourceExtProperty(ID);
        }
        public static void DeleteLightSource(IModelDoc2Object IModelDoc2instance, Int32 ID)
        {
            IModelDoc2instance.IModelDoc2Instance.DeleteLightSource(ID);
        }
        public static Object GetLightSourceExtProperty(IModelDoc2Object IModelDoc2instance, Int32 ID, Int32 PropertyId)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetLightSourceExtProperty(ID, PropertyId);
        }
        public static Int32 AddLightToScene(IModelDoc2Object IModelDoc2instance, String LpszNewValue)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddLightToScene(LpszNewValue);
        }
        public static Int32 AddSceneExtProperty(IModelDoc2Object IModelDoc2instance, Object PropertyExtension)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddSceneExtProperty(PropertyExtension);
        }
        public static void ResetSceneExtProperty(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ResetSceneExtProperty();
        }
        public static Object GetSceneExtProperty(IModelDoc2Object IModelDoc2instance, Int32 PropertyId)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetSceneExtProperty(PropertyId);
        }
        public static void FileSummaryInfo(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.FileSummaryInfo();
        }
        public static Object GetGridSettings(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetGridSettings();
        }
        public static void ToolsSketchTranslate(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ToolsSketchTranslate();
        }
        public static void ToolsDistance(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ToolsDistance();
        }
        public static void SkToolsAutoConstr(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SkToolsAutoConstr();
        }
        public static void ToolsSketchScale(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ToolsSketchScale();
        }
        public static void Paste(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Paste();
        }
        public static void ToolsConfiguration(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ToolsConfiguration();
        }
        public static void EntityProperties(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.EntityProperties();
        }
        public static Boolean GetArcCentersDisplayed(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetArcCentersDisplayed();
        }
        public static void SetArcCentersDisplayed(IModelDoc2Object IModelDoc2instance, Boolean Setting)
        {
            IModelDoc2instance.IModelDoc2Instance.SetArcCentersDisplayed(Setting);
        }
        public static void AutoSolveToggle(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.AutoSolveToggle();
        }
        public static void Dummy7(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Dummy7();
        }
        public static Double IGetLines(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetLines();
        }
        public static Int32 GetLineCount(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetLineCount();
        }
        //public static void ICreateEllipse(IModelDoc2Object IModelDoc2instance, Double& Center, Double& Major, Double& Minor)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.ICreateEllipse(Center, Major, Minor);
        //}
        //public static void ICreateEllipticalArcByCenter(IModelDoc2Object IModelDoc2instance, Double& Center, Double& Major, Double& Minor, Double& Start, Double& End)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.ICreateEllipticalArcByCenter(Center, Major, Minor, Start, End);
        //}
        public static void InsertCutSwept(IModelDoc2Object IModelDoc2instance, Boolean Propagate, Boolean Alignment, Boolean KeepNormalConstant)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertCutSwept(Propagate, Alignment, KeepNormalConstant);
        }
        public static void InsertCutBlend(IModelDoc2Object IModelDoc2instance, Boolean Closed)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertCutBlend(Closed);
        }
        public static void InsertHelix(IModelDoc2Object IModelDoc2instance, Boolean Reversed, Boolean Clockwised, Boolean Tapered, Boolean Outward, Int32 Helixdef, Double Height, Double Pitch, Double Revolution, Double TaperAngle, Double Startangle)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertHelix(Reversed, Clockwised, Tapered, Outward, Helixdef, Height, Pitch, Revolution, TaperAngle, Startangle);
        }
        //public static void ICreateLine(IModelDoc2Object IModelDoc2instance, Double& P1, Double& P2)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.ICreateLine(P1, P2);
        //}
        //public static void ICreateCenterLine(IModelDoc2Object IModelDoc2instance, Double& P1, Double& P2)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.ICreateCenterLine(P1, P2);
        //}
        //public static void ICreateArc(IModelDoc2Object IModelDoc2instance, Double& P1, Double& P2, Double& P3, Int16 Dir)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.ICreateArc(P1, P2, P3, Dir);
        //}
        //public static void ICreateCircleByRadius(IModelDoc2Object IModelDoc2instance, Double& P1, Double Radius)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.ICreateCircleByRadius(P1, Radius);
        //}
        public static void GraphicsRedraw(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.GraphicsRedraw();
        }
        public static Boolean GetVisibilityOfConstructPlanes(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetVisibilityOfConstructPlanes();
        }
        public static Boolean GetDisplayWhenAdded(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetDisplayWhenAdded();
        }
        public static void SetDisplayWhenAdded(IModelDoc2Object IModelDoc2instance, Boolean Setting)
        {
            IModelDoc2instance.IModelDoc2Instance.SetDisplayWhenAdded(Setting);
        }
        public static Boolean GetAddToDB(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetAddToDB();
        }
        public static void SetAddToDB(IModelDoc2Object IModelDoc2instance, Boolean Setting)
        {
            IModelDoc2instance.IModelDoc2Instance.SetAddToDB(Setting);
        }
        public static Boolean DeSelectByID(IModelDoc2Object IModelDoc2instance, String SelID, String SelParams, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.DeSelectByID(SelID, SelParams, X, Y, Z);
        }
        public static void PrintDirect(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.PrintDirect();
        }
        public static void PrintPreview(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.PrintPreview();
        }
        public static void Quit(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Quit();
        }
        public static void CreatePlaneThru3Points(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.CreatePlaneThru3Points();
        }
        public static void ViewRotXPlusNinety(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewRotXPlusNinety();
        }
        public static Object GetUnits(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetUnits();
        }
        public static void SetAngularUnits(IModelDoc2Object IModelDoc2instance, Int16 UType, Int16 FractBase, Int16 FractDenom, Int16 SigDigits)
        {
            IModelDoc2instance.IModelDoc2Instance.SetAngularUnits(UType, FractBase, FractDenom, SigDigits);
        }
        public static Object GetAngularUnits(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetAngularUnits();
        }
        public static Int16 IGetUnits(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetUnits();
        }
        public static void ISetAngularUnits(IModelDoc2Object IModelDoc2instance, Int16 UType, Int16 FractBase, Int16 FractDenom, Int16 SigDigits)
        {
            IModelDoc2instance.IModelDoc2Instance.ISetAngularUnits(UType, FractBase, FractDenom, SigDigits);
        }
        public static Int16 IGetAngularUnits(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetAngularUnits();
        }
        public static void ShowConfiguration(IModelDoc2Object IModelDoc2instance, String ConfigurationName)
        {
            IModelDoc2instance.IModelDoc2Instance.ShowConfiguration(ConfigurationName);
        }
        public static void ResetConfiguration(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ResetConfiguration();
        }
        public static void AddConfiguration(IModelDoc2Object IModelDoc2instance, String Name, String Comment, String AlternateName, Boolean SuppressByDefault, Boolean HideByDefault, Boolean MinFeatureManager, Boolean InheritProperties, UInt32 Flags)
        {
            IModelDoc2instance.IModelDoc2Instance.AddConfiguration(Name, Comment, AlternateName, SuppressByDefault, HideByDefault, MinFeatureManager, InheritProperties, Flags);
        }
        public static void DeleteConfiguration(IModelDoc2Object IModelDoc2instance, String ConfigurationName)
        {
            IModelDoc2instance.IModelDoc2Instance.DeleteConfiguration(ConfigurationName);
        }
        public static void EditConfiguration(IModelDoc2Object IModelDoc2instance, String Name, String NewName, String Comment, String AlternateName, Boolean SuppressByDefault, Boolean HideByDefault, Boolean MinFeatureManager, Boolean InheritProperties, UInt32 Flags)
        {
            IModelDoc2instance.IModelDoc2Instance.EditConfiguration(Name, NewName, Comment, AlternateName, SuppressByDefault, HideByDefault, MinFeatureManager, InheritProperties, Flags);
        }
        public static void CreatePlanePerCurveAndPassPoint(IModelDoc2Object IModelDoc2instance, Boolean OrigAtCurve)
        {
            IModelDoc2instance.IModelDoc2Instance.CreatePlanePerCurveAndPassPoint(OrigAtCurve);
        }
        //public static Object CreateFeatureMgrView(IModelDoc2Object IModelDoc2instance, Int32& Bitmap)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.CreateFeatureMgrView(Bitmap);
        //}
        //public static Boolean AddFeatureMgrView(IModelDoc2Object IModelDoc2instance, Int32& Bitmap, Int32& AppView)
        //{
        //    return IModelDoc2instance.IModelDoc2Instance.AddFeatureMgrView(Bitmap, AppView);
        //}
        public static Object GetStandardViewRotation(IModelDoc2Object IModelDoc2instance, Int32 ViewId)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetStandardViewRotation(ViewId);
        }
        public static Double IGetStandardViewRotation(IModelDoc2Object IModelDoc2instance, Int32 ViewId)
        {
            return IModelDoc2instance.IModelDoc2Instance.IGetStandardViewRotation(ViewId);
        }
        public static Int32 GetType(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetType();
        }
        public static void InsertObject(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertObject();
        }
        public static void EditClearAll(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.EditClearAll();
        }
        public static void EditCopy(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.EditCopy();
        }
        public static void EditCut(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.EditCut();
        }
        public static void ObjectDisplayContent(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ObjectDisplayContent();
        }
        public static void ObjectDisplayAsIcon(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ObjectDisplayAsIcon();
        }
        public static void ObjectResetsize(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ObjectResetsize();
        }
        public static void WindowRedraw(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.WindowRedraw();
        }
        public static void Dummy3(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Dummy3();
        }
        public static void SetPickMode(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SetPickMode();
        }
        public static void ViewRotateminusx(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewRotateminusx();
        }
        public static void ViewRotateminusy(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewRotateminusy();
        }
        public static void ViewRotateminusz(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewRotateminusz();
        }
        public static void ViewRotateplusx(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewRotateplusx();
        }
        public static void ViewRotateplusy(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewRotateplusy();
        }
        public static void ViewRotateplusz(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewRotateplusz();
        }
        public static void ViewTranslateminusx(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewTranslateminusx();
        }
        public static void ViewTranslateminusy(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewTranslateminusy();
        }
        public static void ViewTranslateplusx(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewTranslateplusx();
        }
        public static void ViewTranslateplusy(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewTranslateplusy();
        }
        public static void ViewRotXMinusNinety(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewRotXMinusNinety();
        }
        public static void ViewRotYMinusNinety(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewRotYMinusNinety();
        }
        public static void ViewRotYPlusNinety(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewRotYPlusNinety();
        }
        public static void ViewZoomin(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewZoomin();
        }
        public static void ViewZoomout(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewZoomout();
        }
        public static void ViewDisplayHiddenremoved(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewDisplayHiddenremoved();
        }
        public static void ViewDisplayWireframe(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewDisplayWireframe();
        }
        public static void ViewDisplayShaded(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewDisplayShaded();
        }
        public static void ViewRwShading(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewRwShading();
        }
        public static void ViewOglShading(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewOglShading();
        }
        public static void ViewZoomtofit(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewZoomtofit();
        }
        public static void ViewRotate(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewRotate();
        }
        public static void ViewTranslate(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewTranslate();
        }
        public static void ViewZoomto(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewZoomto();
        }
        public static void ViewDisplayHiddengreyed(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewDisplayHiddengreyed();
        }
        public static void ViewDisplayFaceted(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewDisplayFaceted();
        }
        public static void ViewConstraint(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewConstraint();
        }
        public static void UserFavors(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.UserFavors();
        }
        public static void FeatureCirPattern(IModelDoc2Object IModelDoc2instance, Int32 Num, Double Spacing, Boolean FlipDir, String DName)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureCirPattern(Num, Spacing, FlipDir, DName);
        }
        public static void EditSketch(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.EditSketch();
        }
        public static void FeatEdit(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatEdit();
        }
        public static void FeatEditDef(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatEditDef();
        }
        public static void InsertPoint(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertPoint();
        }
        public static void InsertFamilyTableNew(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertFamilyTableNew();
        }
        public static void Dummy1(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Dummy1();
        }
        public static void InsertFamilyTableEdit(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertFamilyTableEdit();
        }
        public static void Dummy2(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Dummy2();
        }
        public static void ToolsMacro(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ToolsMacro();
        }
        public static void ToolsGrid(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ToolsGrid();
        }
        public static void SketchCenterline(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchCenterline();
        }
        public static void SketchAlign(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchAlign();
        }
        public static void SketchArc(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchArc();
        }
        public static void SketchTangentArc(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchTangentArc();
        }
        public static void SketchCircle(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchCircle();
        }
        public static void SketchUndo(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchUndo();
        }
        public static void UserPreferences(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.UserPreferences();
        }
        public static void Lights(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Lights();
        }
        public static void SketchConstrainCoincident(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchConstrainCoincident();
        }
        public static void SketchConstrainConcentric(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchConstrainConcentric();
        }
        public static void SketchConstrainPerp(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchConstrainPerp();
        }
        public static void SketchConstrainTangent(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchConstrainTangent();
        }
        public static void SketchConstrainParallel(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchConstrainParallel();
        }
        public static void SketchUseEdge(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchUseEdge();
        }
        public static void SketchUseEdgeCtrline(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchUseEdgeCtrline();
        }
        public static void SketchMirror(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchMirror();
        }
        public static void Save(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Save();
        }
        public static void Close(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Close();
        }
        public static void ViewDispRefaxes(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewDispRefaxes();
        }
        public static void ViewDispRefplanes(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ViewDispRefplanes();
        }
        public static void InsertSketch(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertSketch();
        }
        public static void InsertProtrusionSwept(IModelDoc2Object IModelDoc2instance, Boolean Propagate, Boolean Alignment, Boolean KeepNormalConstant)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertProtrusionSwept(Propagate, Alignment, KeepNormalConstant);
        }
        public static void InsertProtrusionBlend(IModelDoc2Object IModelDoc2instance, Boolean Closed)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertProtrusionBlend(Closed);
        }
        public static void ToolsMassProps(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ToolsMassProps();
        }
        public static void PropertySheet(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.PropertySheet();
        }
        public static void BlankRefGeom(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.BlankRefGeom();
        }
        public static void UnBlankRefGeom(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.UnBlankRefGeom();
        }
        public static void EditDelete(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.EditDelete();
        }
        public static void InsertProjectedSketch(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertProjectedSketch();
        }
        public static Boolean CreatePlaneFixed(IModelDoc2Object IModelDoc2instance, Object P1, Object P2, Object P3, Boolean UseGlobal)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePlaneFixed(P1, P2, P3, UseGlobal);
        }
        public static void Dummy5(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Dummy5();
        }
        public static void Dummy6(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Dummy6();
        }
        public static void DebugCheckBody(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.DebugCheckBody();
        }
        public static void Dummy8(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Dummy8();
        }
        public static void DimPreferences(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.DimPreferences();
        }
        public static void FeatureFillet(IModelDoc2Object IModelDoc2instance, Double R1, Boolean Propagate, Boolean Ftyp, Boolean VarRadTyp, Int32 OverflowType)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureFillet(R1, Propagate, Ftyp, VarRadTyp, OverflowType);
        }
        public static void GridOptions(IModelDoc2Object IModelDoc2instance, Boolean DispGrid, Double GridSpacing, Boolean Snap, Boolean DotStyle, Int16 NMajor, Int16 NMinor, Boolean Align2edge, Boolean AngleSnap, Double AngleUnit, Boolean MinorAuto)
        {
            IModelDoc2instance.IModelDoc2Instance.GridOptions(DispGrid, GridSpacing, Snap, DotStyle, NMajor, NMinor, Align2edge, AngleSnap, AngleUnit, MinorAuto);
        }
        public static void SetUnits(IModelDoc2Object IModelDoc2instance, Int16 UType, Int16 FractBase, Int16 FractDenom, Int16 SigDigits, Boolean RoundToFraction)
        {
            IModelDoc2instance.IModelDoc2Instance.SetUnits(UType, FractBase, FractDenom, SigDigits, RoundToFraction);
        }
        public static void LBDownAt(IModelDoc2Object IModelDoc2instance, Int32 Flags, Double X, Double Y, Double Z)
        {
            IModelDoc2instance.IModelDoc2Instance.LBDownAt(Flags, X, Y, Z);
        }
        public static void LBUpAt(IModelDoc2Object IModelDoc2instance, Int32 Flags, Double X, Double Y, Double Z)
        {
            IModelDoc2instance.IModelDoc2Instance.LBUpAt(Flags, X, Y, Z);
        }
        public static void DragTo(IModelDoc2Object IModelDoc2instance, Int32 Flags, Double X, Double Y, Double Z)
        {
            IModelDoc2instance.IModelDoc2Instance.DragTo(Flags, X, Y, Z);
        }
        public static void SelectAt(IModelDoc2Object IModelDoc2instance, Int32 Flags, Double X, Double Y, Double Z)
        {
            IModelDoc2instance.IModelDoc2Instance.SelectAt(Flags, X, Y, Z);
        }
        public static void CreateLineVB(IModelDoc2Object IModelDoc2instance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
        {
            IModelDoc2instance.IModelDoc2Instance.CreateLineVB(X1, Y1, Z1, X2, Y2, Z2);
        }
        public static Boolean CreateLine(IModelDoc2Object IModelDoc2instance, Object P1, Object P2)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateLine(P1, P2);
        }
        public static void CreateCenterLineVB(IModelDoc2Object IModelDoc2instance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2)
        {
            IModelDoc2instance.IModelDoc2Instance.CreateCenterLineVB(X1, Y1, Z1, X2, Y2, Z2);
        }
        public static Boolean CreateCenterLine(IModelDoc2Object IModelDoc2instance, Object P1, Object P2)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateCenterLine(P1, P2);
        }
        public static void CreateArcVB(IModelDoc2Object IModelDoc2instance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z, Double P3x, Double P3y, Double P3z, Int16 Dir)
        {
            IModelDoc2instance.IModelDoc2Instance.CreateArcVB(P1x, P1y, P1z, P2x, P2y, P2z, P3x, P3y, P3z, Dir);
        }
        public static Boolean CreateArc(IModelDoc2Object IModelDoc2instance, Object P1, Object P2, Object P3, Int16 Dir)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateArc(P1, P2, P3, Dir);
        }
        public static void CreateCircleVB(IModelDoc2Object IModelDoc2instance, Double P1x, Double P1y, Double P1z, Double Radius)
        {
            IModelDoc2instance.IModelDoc2Instance.CreateCircleVB(P1x, P1y, P1z, Radius);
        }
        public static Boolean CreateCircleByRadius(IModelDoc2Object IModelDoc2instance, Object P1, Double Radius)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateCircleByRadius(P1, Radius);
        }
        public static Object GetLines(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetLines();
        }
        public static void SketchTrim(IModelDoc2Object IModelDoc2instance, Int32 Op, Int32 SelEnd, Double X, Double Y)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchTrim(Op, SelEnd, X, Y);
        }
        public static void SketchOffsetEdges(IModelDoc2Object IModelDoc2instance, Double Val)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchOffsetEdges(Val);
        }
        public static void SketchRectangle(IModelDoc2Object IModelDoc2instance, Double Val1, Double Val2, Double Z1, Double Val3, Double Val4, Double Z2, Boolean Val5)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchRectangle(Val1, Val2, Z1, Val3, Val4, Z2, Val5);
        }
        public static void SketchPoint(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchPoint(X, Y, Z);
        }
        public static void FeatureCut(IModelDoc2Object IModelDoc2instance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureCut(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2);
        }
        public static void FeatureBoss(IModelDoc2Object IModelDoc2instance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureBoss(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2);
        }
        public static void SimpleHole(IModelDoc2Object IModelDoc2instance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2)
        {
            IModelDoc2instance.IModelDoc2Instance.SimpleHole(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2);
        }
        public static void FeatureLinearPattern(IModelDoc2Object IModelDoc2instance, Int32 Num1, Double Spacing1, Int32 Num2, Double Spacing2, Boolean FlipDir1, Boolean FlipDir2, String DName1, String DName2)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureLinearPattern(Num1, Spacing1, Num2, Spacing2, FlipDir1, FlipDir2, DName1, DName2);
        }
        public static void NameView(IModelDoc2Object IModelDoc2instance, String VName)
        {
            IModelDoc2instance.IModelDoc2Instance.NameView(VName);
        }
        public static void ShowNamedView(IModelDoc2Object IModelDoc2instance, String VName)
        {
            IModelDoc2instance.IModelDoc2Instance.ShowNamedView(VName);
        }
        public static void CreatePlaneAtOffset(IModelDoc2Object IModelDoc2instance, Double Val, Boolean FlipDir)
        {
            IModelDoc2instance.IModelDoc2Instance.CreatePlaneAtOffset(Val, FlipDir);
        }
        public static void Toolbars(IModelDoc2Object IModelDoc2instance, Boolean M, Boolean Vw, Boolean SkMain, Boolean Sk, Boolean Feat, Boolean Constr, Boolean Macro)
        {
            IModelDoc2instance.IModelDoc2Instance.Toolbars(M, Vw, SkMain, Sk, Feat, Constr, Macro);
        }
        public static void CreatePlaneAtAngle(IModelDoc2Object IModelDoc2instance, Double Val, Boolean FlipDir)
        {
            IModelDoc2instance.IModelDoc2Instance.CreatePlaneAtAngle(Val, FlipDir);
        }
        public static void SetParamValue(IModelDoc2Object IModelDoc2instance, Double Val)
        {
            IModelDoc2instance.IModelDoc2Instance.SetParamValue(Val);
        }
        public static void AddRelation(IModelDoc2Object IModelDoc2instance, String RelStr)
        {
            IModelDoc2instance.IModelDoc2Instance.AddRelation(RelStr);
        }
        public static void DeleteAllRelations(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.DeleteAllRelations();
        }
        public static void HoleWizard(IModelDoc2Object IModelDoc2instance, Double Depth, Int16 EndType, Boolean Flip, Boolean Dir, Int32 HType, Double D1, Double D2, Double D3, Double D4, Double D5, Double D6, Double D7, Double D8, Double D9, Double D10, Double D11, Double D12)
        {
            IModelDoc2instance.IModelDoc2Instance.HoleWizard(Depth, EndType, Flip, Dir, HType, D1, D2, D3, D4, D5, D6, D7, D8, D9, D10, D11, D12);
        }
        public static Boolean SaveAs(IModelDoc2Object IModelDoc2instance, String NewName)
        {
            return IModelDoc2instance.IModelDoc2Instance.SaveAs(NewName);
        }
        public static void ActivateSelectedFeature(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ActivateSelectedFeature();
        }
        public static void SelectByName(IModelDoc2Object IModelDoc2instance, Int32 Flags, String IdStr)
        {
            IModelDoc2instance.IModelDoc2Instance.SelectByName(Flags, IdStr);
        }
        public static void SketchAddConstraints(IModelDoc2Object IModelDoc2instance, String IdStr)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchAddConstraints(IdStr);
        }
        public static void SketchConstraintsDel(IModelDoc2Object IModelDoc2instance, Int32 ConstrInd, String IdStr)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchConstraintsDel(ConstrInd, IdStr);
        }
        public static void SketchConstraintsDelAll(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchConstraintsDelAll();
        }
        public static void Lock(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.Lock();
        }
        public static void UnLock(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.UnLock();
        }
        public static void InsertFeatureShell(IModelDoc2Object IModelDoc2instance, Double Thickness, Boolean Outward)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertFeatureShell(Thickness, Outward);
        }
        public static void SketchFillet(IModelDoc2Object IModelDoc2instance, Double Rad)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchFillet(Rad);
        }
        public static void FeatureChamfer(IModelDoc2Object IModelDoc2instance, Double Width, Double Angle, Boolean Flip)
        {
            IModelDoc2instance.IModelDoc2Instance.FeatureChamfer(Width, Angle, Flip);
        }
        public static void InsertMfDraft(IModelDoc2Object IModelDoc2instance, Double Angle, Boolean FlipDir, Boolean IsEdgeDraft, Int32 PropType)
        {
            IModelDoc2instance.IModelDoc2Instance.InsertMfDraft(Angle, FlipDir, IsEdgeDraft, PropType);
        }
        public static void ParentChildRelationship(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ParentChildRelationship();
        }
        public static void SketchSpline(IModelDoc2Object IModelDoc2instance, Int32 MorePts, Double X, Double Y, Double Z)
        {
            IModelDoc2instance.IModelDoc2Instance.SketchSpline(MorePts, X, Y, Z);
        }
        public static void SelectSketchPoint(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Int32 Incidence)
        {
            IModelDoc2instance.IModelDoc2Instance.SelectSketchPoint(X, Y, Incidence);
        }
        public static void SelectSketchLine(IModelDoc2Object IModelDoc2instance, Double X0, Double Y0, Int32 Inc0, Double X1, Double Y1, Int32 Inc1)
        {
            IModelDoc2instance.IModelDoc2Instance.SelectSketchLine(X0, Y0, Inc0, X1, Y1, Inc1);
        }
        public static void SelectSketchArc(IModelDoc2Object IModelDoc2instance, Double X0, Double Y0, Int32 Inc0, Double X1, Double Y1, Int32 Inc1, Double XC, Double YC, Int32 IncC, Int32 RotDir)
        {
            IModelDoc2instance.IModelDoc2Instance.SelectSketchArc(X0, Y0, Inc0, X1, Y1, Inc1, XC, YC, IncC, RotDir);
        }
        public static void SelectSketchSpline(IModelDoc2Object IModelDoc2instance, Int32 Size, Double X0, Double Y0, Int32 Inc0, Double X1, Double Y1, Int32 Inc1, Double XC, Double YC, Int32 IncC)
        {
            IModelDoc2instance.IModelDoc2Instance.SelectSketchSpline(Size, X0, Y0, Inc0, X1, Y1, Inc1, XC, YC, IncC);
        }
        public static Boolean CreateTangentArc(IModelDoc2Object IModelDoc2instance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateTangentArc(P1x, P1y, P1z, P2x, P2y, P2z);
        }
        public static Boolean Create3PointArc(IModelDoc2Object IModelDoc2instance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z, Double P3x, Double P3y, Double P3z)
        {
            return IModelDoc2instance.IModelDoc2Instance.Create3PointArc(P1x, P1y, P1z, P2x, P2y, P2z, P3x, P3y, P3z);
        }
        public static Boolean CreateArcByCenter(IModelDoc2Object IModelDoc2instance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z, Double P3x, Double P3y, Double P3z)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateArcByCenter(P1x, P1y, P1z, P2x, P2y, P2z, P3x, P3y, P3z);
        }
        public static Boolean CreateCircle(IModelDoc2Object IModelDoc2instance, Double P1x, Double P1y, Double P1z, Double P2x, Double P2y, Double P2z)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateCircle(P1x, P1y, P1z, P2x, P2y, P2z);
        }
        public static Boolean AddDimension(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddDimension(X, Y, Z);
        }
        public static Boolean AddHorizontalDimension(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddHorizontalDimension(X, Y, Z);
        }
        public static Boolean AddVerticalDimension(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.AddVerticalDimension(X, Y, Z);
        }
        public static Boolean SelectSketchItem(IModelDoc2Object IModelDoc2instance, Int32 SelOpt, String Name, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.SelectSketchItem(SelOpt, Name, X, Y, Z);
        }
        public static void ClearSelection(IModelDoc2Object IModelDoc2instance)
        {
            IModelDoc2instance.IModelDoc2Instance.ClearSelection();
        }
        public static void Select(IModelDoc2Object IModelDoc2instance, String SelID, String SelParams, Double X, Double Y, Double Z)
        {
            IModelDoc2instance.IModelDoc2Instance.Select(SelID, SelParams, X, Y, Z);
        }
        public static void AndSelect(IModelDoc2Object IModelDoc2instance, String SelID, String SelParams, Double X, Double Y, Double Z)
        {
            IModelDoc2instance.IModelDoc2Instance.AndSelect(SelID, SelParams, X, Y, Z);
        }
        public static Boolean CreatePoint(IModelDoc2Object IModelDoc2instance, Double PointX, Double PointY, Double PointZ)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePoint(PointX, PointY, PointZ);
        }
        public static Boolean CreateLineDB(IModelDoc2Object IModelDoc2instance, Double Sx, Double Sy, Double Sz, Double Ex, Double Ey, Double Ez)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateLineDB(Sx, Sy, Sz, Ex, Ey, Ez);
        }
        public static Boolean CreateArcDB(IModelDoc2Object IModelDoc2instance, Double X1, Double Y1, Double Z1, Double X2, Double Y2, Double Z2, Double X3, Double Y3, Double Z3, Int16 Dir)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateArcDB(X1, Y1, Z1, X2, Y2, Z2, X3, Y3, Z3, Dir);
        }
        public static Boolean CreateCircleDB(IModelDoc2Object IModelDoc2instance, Double Cx, Double Cy, Double Cz, Double Radius)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreateCircleDB(Cx, Cy, Cz, Radius);
        }
        public static Boolean CreatePointDB(IModelDoc2Object IModelDoc2instance, Double X, Double Y, Double Z)
        {
            return IModelDoc2instance.IModelDoc2Instance.CreatePointDB(X, Y, Z);
        }
        public static String GetTitle(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetTitle();
        }
        public static String GetPathName(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.GetPathName();
        }
        public static Object SelectionManager(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.SelectionManager;
        }
        public static ISelectionMgrObject ISelectionManager(IModelDoc2Object IModelDoc2instance)
        {
            return new ISelectionMgrObject(IModelDoc2instance.IModelDoc2Instance.ISelectionManager);
        }
        public static Object ActiveView(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.ActiveView;
        }
        public static IModelViewObject IActiveView(IModelDoc2Object IModelDoc2instance)
        {
            return new IModelViewObject(IModelDoc2instance.IModelDoc2Instance.IActiveView);
        }
        public static Int32 LengthUnit(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.LengthUnit;
        }
        public static String LightSourceUserName(IModelDoc2Object IModelDoc2instance, int ID)
        {
            return IModelDoc2instance.IModelDoc2Instance.LightSourceUserName[ID];
        }
        public static Object LightSourcePropertyValues(IModelDoc2Object IModelDoc2instance, int ID)
        {
            return IModelDoc2instance.IModelDoc2Instance.LightSourcePropertyValues[ID];
        }
        public static String SceneName(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.SceneName;
        }
        public static String SceneUserName(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.SceneUserName;
        }
        public static object ILightSourcePropertyValues(IModelDoc2Object IModelDoc2instance, int ID)
        {
            return IModelDoc2instance.IModelDoc2Instance.LightSourcePropertyValues[ID];
        }
        public static Boolean Visible(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.Visible;
        }
        public static String MaterialUserName(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.MaterialUserName;
        }
        public static String MaterialIdName(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.MaterialIdName;
        }
        public static Object MaterialPropertyValues(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.MaterialPropertyValues;
        }
        public static object IMaterialPropertyValues(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.MaterialPropertyValues;
        }
        public static Int16 PrintSetup(IModelDoc2Object IModelDoc2instance, int SetupType)
        {
            return IModelDoc2instance.IModelDoc2Instance.PrintSetup[SetupType];
        }
        public static String SceneBkgImageFileName(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.SceneBkgImageFileName;
        }
        public static String SummaryInfo(IModelDoc2Object IModelDoc2instance, int FieldID)
        {
            return IModelDoc2instance.IModelDoc2Instance.SummaryInfo[FieldID];
        }
        public static String CustomInfo(IModelDoc2Object IModelDoc2instance, string FieldName)
        {
            return IModelDoc2instance.IModelDoc2Instance.CustomInfo[FieldName];
        }
        public static String CustomInfo2(IModelDoc2Object IModelDoc2instance, string Configuration, string FieldName)
        {
            return IModelDoc2instance.IModelDoc2Instance.CustomInfo2[Configuration, FieldName];
        }
        public static Boolean ShowFeatureErrorDialog(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.ShowFeatureErrorDialog;
        }
        public static Double FeatureManagerSplitterPosition(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.FeatureManagerSplitterPosition;
        }
        public static String Printer(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.Printer;
        }
        public static Object PageSetup(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.PageSetup;
        }
        public static IPageSetupObject IPageSetup(IModelDoc2Object IModelDoc2instance)
        {
            return new IPageSetupObject(IModelDoc2instance.IModelDoc2Instance.IPageSetup);
        }
        public static Boolean LargeAssemblyMode(IModelDoc2Object IModelDoc2instance)
        {
            return IModelDoc2instance.IModelDoc2Instance.LargeAssemblyMode;
        }
        public static IFeatureManagerObject FeatureManager(IModelDoc2Object IModelDoc2instance)
        {
            return new IFeatureManagerObject(IModelDoc2instance.IModelDoc2Instance.FeatureManager);
        }
        public static IModelViewManagerObject ModelViewManager(IModelDoc2Object IModelDoc2instance)
        {
            return new IModelViewManagerObject(IModelDoc2instance.IModelDoc2Instance.ModelViewManager);
        }
        public static IModelDocExtensionObject Extension(IModelDoc2Object IModelDoc2instance)
        {
            return new IModelDocExtensionObject(IModelDoc2instance.IModelDoc2Instance.Extension);
        }
        public static IConfigurationManagerObject ConfigurationManager(IModelDoc2Object IModelDoc2instance)
        {
            return new IConfigurationManagerObject(IModelDoc2instance.IModelDoc2Instance.ConfigurationManager);
        }
        public static ISketchManagerObject SketchManager(IModelDoc2Object IModelDoc2instance)
        {
            return new ISketchManagerObject(IModelDoc2instance.IModelDoc2Instance.SketchManager);
        }
    }
}