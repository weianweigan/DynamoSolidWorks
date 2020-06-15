using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFeatureManagerObject
    {
        public IFeatureManager IFeatureManagerInstance { get; set; }
        public IFeatureManagerObject(IFeatureManager IFeatureManagerinstance)
        {
            IFeatureManagerInstance = IFeatureManagerinstance;
        }
    }
    public static class IFeatureManagerInterface
    {
        public static IFeatureObject InsertDeleteBody2(IFeatureManagerObject IFeatureManagerinstance, Boolean KeepBodies)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertDeleteBody2(KeepBodies));
        }
        public static IFeatureObject FeatureLinearPattern4(IFeatureManagerObject IFeatureManagerinstance, Int32 Num1, Double Spacing1, Int32 Num2, Double Spacing2, Boolean FlipDir1, Boolean FlipDir2, String DName1, String DName2, Boolean GeometryPattern, Boolean VaryInstance, Boolean HasOffset1, Boolean HasOffset2, Boolean CtrlByNum1, Boolean CtrlByNum2, Boolean FromCentroid1, Boolean FromCentroid2, Boolean RevOffset1, Boolean RevOffset2, Double Offset1, Double Offset2)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureLinearPattern4(Num1, Spacing1, Num2, Spacing2, FlipDir1, FlipDir2, DName1, DName2, GeometryPattern, VaryInstance, HasOffset1, HasOffset2, CtrlByNum1, CtrlByNum2, FromCentroid1, FromCentroid2, RevOffset1, RevOffset2, Offset1, Offset2));
        }
        public static IFeatureObject FeatureAdvancedTableDrivenPattern(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureAdvancedTableDrivenPattern());
        }
        public static IFeatureObject InsertSheetMetalGussetFeature3(IFeatureManagerObject IFeatureManagerinstance, Boolean BOffset, Double DOffset, Boolean BFlipOffsetSide, Int32 ProfDimType, Double DIndentDepth, Double DLength, Boolean BUseAngle, Double DHeight, Double DAngle, Boolean BFlipSides, Double DWidth, Double DThickness, Boolean BDraft, Double DDraftAngle, Boolean BInnerCornerFillet, Double DInnerCornerFilletRadius, Boolean BOuterCornerFillet, Double DOuterCornerFilletRadius, Int32 GussetType, Boolean BEdgeFillet, Double DEdgeFilletRadius, Boolean BOverrideDoc, Boolean BShowProfile, Boolean BShowCenter)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSheetMetalGussetFeature3(BOffset, DOffset, BFlipOffsetSide, ProfDimType, DIndentDepth, DLength, BUseAngle, DHeight, DAngle, BFlipSides, DWidth, DThickness, BDraft, DDraftAngle, BInnerCornerFillet, DInnerCornerFilletRadius, BOuterCornerFillet, DOuterCornerFilletRadius, GussetType, BEdgeFillet, DEdgeFilletRadius, BOverrideDoc, BShowProfile, BShowCenter));
        }
        public static IFeatureObject InsertFlattenSurface(IFeatureManagerObject IFeatureManagerinstance, Int32 AccuracyFactor)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertFlattenSurface(AccuracyFactor));
        }
        public static IFeatureObject InsertMoveFace3(IFeatureManagerObject IFeatureManagerinstance, Int32 MoveType, Boolean ReverseDir, Double Angle, Double Distance, Object TranslationParams, Object RotationParams, Int32 EndConditionType, Double OffsetDistance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMoveFace3(MoveType, ReverseDir, Angle, Distance, TranslationParams, RotationParams, EndConditionType, OffsetDistance));
        }
        public static Object InsertCosmeticWeldBead2(IFeatureManagerObject IFeatureManagerinstance, Int32 WeldMode, Object WeldFromFaceOrEdgeSet, Object WeldToFaceOrEdgeSet, Double WeldSize)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.InsertCosmeticWeldBead2(WeldMode, WeldFromFaceOrEdgeSet, WeldToFaceOrEdgeSet, WeldSize);
        }
        public static IFeatureObject InsertStructuralWeldment5(IFeatureManagerObject IFeatureManagerinstance, String Path, Int32 ConnectedSegmentsOption, Boolean AllowProtrusion, Object Groups, String ConfigurationName)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertStructuralWeldment5(Path, ConnectedSegmentsOption, AllowProtrusion, Groups, ConfigurationName));
        }
        public static IFeatureObject FeatureChainPattern(IFeatureManagerObject IFeatureManagerinstance, Int32 PitchMethod, Boolean FlipDirection, Boolean FillPath, Int32 Number, Double Spacing, Boolean GroupOneFlipPlane, Boolean GroupTwoChain, Boolean GroupTwoFlipPlane, Int32 AlignMethod, Int32 Options)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureChainPattern(PitchMethod, FlipDirection, FillPath, Number, Spacing, GroupOneFlipPlane, GroupTwoChain, GroupTwoFlipPlane, AlignMethod, Options));
        }
        public static IFeatureObject InsertNetBlend2(IFeatureManagerObject IFeatureManagerinstance, Int16 Type, Int16 NCurvesDir1, Int16 NCurvesDir2, Boolean HasCenterline, Double TessTolFactor, Boolean WantsSolid, Boolean MergeBody, Boolean FeatureScope, Boolean AutoSelect, Boolean Thin, Double Thickness1, Double Thickness2, Boolean ReverseThickness, Int16 ThinSolidType, Boolean UseSharedThickness, Boolean CapEnds, Double EndThickness, Boolean AutoFillet, Double FilletRadius, Boolean ForceNonRational, Boolean CreateSolid)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertNetBlend2(Type, NCurvesDir1, NCurvesDir2, HasCenterline, TessTolFactor, WantsSolid, MergeBody, FeatureScope, AutoSelect, Thin, Thickness1, Thickness2, ReverseThickness, ThinSolidType, UseSharedThickness, CapEnds, EndThickness, AutoFillet, FilletRadius, ForceNonRational, CreateSolid));
        }
        public static IFeatureObject InsertFlattenSurface2(IFeatureManagerObject IFeatureManagerinstance, Int32 AccuracyFactor, Boolean ShouldUseTears)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertFlattenSurface2(AccuracyFactor, ShouldUseTears));
        }
        public static Object PreIntersect2(IFeatureManagerObject IFeatureManagerinstance, Boolean CapPlanar, Int32 RegionType)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.PreIntersect2(CapPlanar, RegionType);
        }
        public static IFeatureObject InsertProtrusionSwept4(IFeatureManagerObject IFeatureManagerinstance, Boolean Propagate, Boolean Alignment, Int32 TwistCtrlOption, Boolean KeepTangency, Boolean BAdvancedSmoothing, Int32 StartMatchingType, Int32 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int32 ThinType, Int32 PathAlign, Boolean Merge, Boolean UseFeatScope, Boolean UseAutoSelect, Double TwistAngle, Boolean BMergeSmoothFaces, Boolean CircularProfile, Double CircularProfileDiameter, Int32 Direction)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertProtrusionSwept4(Propagate, Alignment, TwistCtrlOption, KeepTangency, BAdvancedSmoothing, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType, PathAlign, Merge, UseFeatScope, UseAutoSelect, TwistAngle, BMergeSmoothFaces, CircularProfile, CircularProfileDiameter, Direction));
        }
        public static IFeatureObject InsertCutSwept5(IFeatureManagerObject IFeatureManagerinstance, Boolean Propagate, Boolean Alignment, Int32 TwistCtrlOption, Boolean KeepTangency, Boolean BAdvancedSmoothing, Int32 StartMatchingType, Int32 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int32 ThinType, Int32 PathAlign, Boolean UseFeatScope, Boolean UseAutoSelect, Double TwistAngle, Boolean BMergeSmoothFaces, Boolean AssemblyFeatureScope, Boolean AutoSelectComponents, Boolean PropagateFeatureToParts, Boolean CircularProfile, Double CircularProfileDiameter, Int32 Direction)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCutSwept5(Propagate, Alignment, TwistCtrlOption, KeepTangency, BAdvancedSmoothing, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType, PathAlign, UseFeatScope, UseAutoSelect, TwistAngle, BMergeSmoothFaces, AssemblyFeatureScope, AutoSelectComponents, PropagateFeatureToParts, CircularProfile, CircularProfileDiameter, Direction));
        }
        public static IFeatureObject InsertSweepSurface3(IFeatureManagerObject IFeatureManagerinstance, Boolean Propagate, Int32 TwistCtrlOption, Boolean KeepTangency, Boolean BAdvancedSmoothing, Int32 StartMatchingType, Int32 EndMatchingType, Int32 PathAlign, Boolean UseFeatScope, Boolean UseAutoSelect, Double TwistAngle, Boolean BMergeSmoothFaces, Boolean CircularProfile, Double CircularProfileDiameter, Int32 Direction)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSweepSurface3(Propagate, TwistCtrlOption, KeepTangency, BAdvancedSmoothing, StartMatchingType, EndMatchingType, PathAlign, UseFeatScope, UseAutoSelect, TwistAngle, BMergeSmoothFaces, CircularProfile, CircularProfileDiameter, Direction));
        }
        public static Boolean ExpandFeature(IFeatureManagerObject IFeatureManagerinstance, Object Component, String FeatureName, Int32 WhichPane)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.ExpandFeature(Component, FeatureName, WhichPane);
        }
        public static IFeatureObject FeatureLinearPattern5(IFeatureManagerObject IFeatureManagerinstance, Int32 Num1, Double Spacing1, Int32 Num2, Double Spacing2, Boolean FlipDir1, Boolean FlipDir2, String DName1, String DName2, Boolean GeometryPattern, Boolean VaryInstance, Boolean HasOffset1, Boolean HasOffset2, Boolean CtrlByNum1, Boolean CtrlByNum2, Boolean FromCentroid1, Boolean FromCentroid2, Boolean RevOffset1, Boolean RevOffset2, Double Offset1, Double Offset2, Boolean D2PatternSeedOnly, Boolean SyncSubAssemblies)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureLinearPattern5(Num1, Spacing1, Num2, Spacing2, FlipDir1, FlipDir2, DName1, DName2, GeometryPattern, VaryInstance, HasOffset1, HasOffset2, CtrlByNum1, CtrlByNum2, FromCentroid1, FromCentroid2, RevOffset1, RevOffset2, Offset1, Offset2, D2PatternSeedOnly, SyncSubAssemblies));
        }
        public static IFeatureObject FeatureCircularPattern5(IFeatureManagerObject IFeatureManagerinstance, Int32 Number, Double Spacing, Boolean FlipDirection, String DName, Boolean GeometryPattern, Boolean EqualSpacing, Boolean VaryInstance, Boolean SyncSubAssemblies, Boolean BDir2, Boolean BSymmetric, Int32 Number2, Double Spacing2, String DName2, Boolean EqualSpacing2)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureCircularPattern5(Number, Spacing, FlipDirection, DName, GeometryPattern, EqualSpacing, VaryInstance, SyncSubAssemblies, BDir2, BSymmetric, Number2, Spacing2, DName2, EqualSpacing2));
        }
        public static IFeatureObject InsertTableDrivenPattern2(IFeatureManagerObject IFeatureManagerinstance, String FileName, Object PointVar, Boolean UseCentroid, Boolean GeomPattern, Boolean PropVisProps)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertTableDrivenPattern2(FileName, PointVar, UseCentroid, GeomPattern, PropVisProps));
        }
        public static void FeatureExtruRefSurface3(IFeatureManagerObject IFeatureManagerinstance, Boolean Sd, Boolean Dir, Int32 StartCond, Double OffsetVal, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean CapEnd1, Boolean CapEnd2, Boolean DeleteOriginalFace, Boolean KnitResult)
        {
            IFeatureManagerinstance.IFeatureManagerInstance.FeatureExtruRefSurface3(Sd, Dir, StartCond, OffsetVal, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, CapEnd1, CapEnd2, DeleteOriginalFace, KnitResult);
        }
        public static Object GetSelectionSetFolder(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.GetSelectionSetFolder();
        }
        public static IFeatureObject InsertDerivedPattern2(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertDerivedPattern2());
        }
        public static IFeatureObject FeatureCut4(IFeatureManagerObject IFeatureManagerinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean NormalCut, Boolean UseFeatScope, Boolean UseAutoSelect, Boolean AssemblyFeatureScope, Boolean AutoSelectComponents, Boolean PropagateFeatureToParts, Int32 T0, Double StartOffset, Boolean FlipStartOffset, Boolean OptimizeGeometry)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureCut4(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, NormalCut, UseFeatScope, UseAutoSelect, AssemblyFeatureScope, AutoSelectComponents, PropagateFeatureToParts, T0, StartOffset, FlipStartOffset, OptimizeGeometry));
        }
        public static IFeatureObject InsertWrapFeature2(IFeatureManagerObject IFeatureManagerinstance, Int32 Type, Double Thickness, Boolean ReverseDir, Int32 Method, Int32 MeshFactor)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertWrapFeature2(Type, Thickness, ReverseDir, Method, MeshFactor));
        }
        //public static IFeatureObject AdvancedHole(IFeatureManagerObject IFeatureManagerinstance, Object AdvancedHoleNearElementArray, Object AdvancedHoleFarElementArray, Boolean UseBaselineDimensions, Boolean IsCustomCallout, Object& ResultArray)
        //{
        //    return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.AdvancedHole(AdvancedHoleNearElementArray, AdvancedHoleFarElementArray, UseBaselineDimensions, IsCustomCallout, ResultArray));
        //}
        public static Object PostSplitBody2(IFeatureManagerObject IFeatureManagerinstance, Object BodiesToMark, Boolean ConsumeCut, Object Origins, Object SavePaths, String OverrideTemplateName)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.PostSplitBody2(BodiesToMark, ConsumeCut, Origins, SavePaths, OverrideTemplateName);
        }
        public static void AddSMNormalCutType(IFeatureManagerObject IFeatureManagerinstance, Boolean AutoPropagation, Boolean Optimize, Boolean BExtent)
        {
            IFeatureManagerinstance.IFeatureManagerInstance.AddSMNormalCutType(AutoPropagation, Optimize, BExtent);
        }
        public static Int32 AddSMNormalCut(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.AddSMNormalCut();
        }
        public static Object FinishSMNormalCut(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.FinishSMNormalCut();
        }
        public static IFeatureObject InsertGroundPlane(IFeatureManagerObject IFeatureManagerinstance, Boolean ReverseDirection)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertGroundPlane(ReverseDirection));
        }
        //public static Object InsertGlobalBoundingBox(IFeatureManagerObject IFeatureManagerinstance, Int32 BBoxType, Boolean IncludeHiddenBodies, Boolean IncludeSurfaceBodies, Int32& Status)
        //{
        //    return IFeatureManagerinstance.IFeatureManagerInstance.InsertGlobalBoundingBox(BBoxType, IncludeHiddenBodies, IncludeSurfaceBodies, Status);
        //}
        public static void InsertRib(IFeatureManagerObject IFeatureManagerinstance, Boolean Is2Sided, Boolean ReverseThicknessDir, Double Thickness, Int32 ReferenceEdgeIndex, Boolean ReverseMaterialDir, Boolean IsDrafted, Boolean DraftOutward, Double DraftAngle, Boolean IsNormToSketch, Boolean IsDraftedFromWall)
        {
            IFeatureManagerinstance.IFeatureManagerInstance.InsertRib(Is2Sided, ReverseThicknessDir, Thickness, ReferenceEdgeIndex, ReverseMaterialDir, IsDrafted, DraftOutward, DraftAngle, IsNormToSketch, IsDraftedFromWall);
        }
        public static Int16 GetPlasticsShellType(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.GetPlasticsShellType();
        }
        public static IFeatureObject InsertCoordinateSystem(IFeatureManagerObject IFeatureManagerinstance, Boolean XFlippedIn, Boolean YFlippedIn, Boolean ZFlippedIn)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCoordinateSystem(XFlippedIn, YFlippedIn, ZFlippedIn));
        }
        public static IFeatureObject CreateCoordinateSystem(IFeatureManagerObject IFeatureManagerinstance, Object OriginPointEntity, Object XAxisEntities, Object YAxisEntities, Object ZAxisEntities)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.CreateCoordinateSystem(OriginPointEntity, XAxisEntities, YAxisEntities, ZAxisEntities));
        }
        public static Boolean InsertConvertToSheetMetal(IFeatureManagerObject IFeatureManagerinstance, Double Thickness, Boolean ReverseThickDir, Boolean FindBends, Double Radius, Double Gap, Int32 ReliefType, Double ReliefRatio)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.InsertConvertToSheetMetal(Thickness, ReverseThickDir, FindBends, Radius, Gap, ReliefType, ReliefRatio);
        }
        public static Boolean InsertConnectionPoint(IFeatureManagerObject IFeatureManagerinstance, Int32 Type, Int32 SubType, Boolean ReverseDirection, Double Diameter, Double StubLength, Double MinimumStraight, Double EndLengthAdjustment, Double ConductorSplitLength, String SchematicPinID, Double CableWidth, Double CableThickness, Boolean SwitchPin1Position, String SpecificationFieldName, String SpecificationValue)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.InsertConnectionPoint(Type, SubType, ReverseDirection, Diameter, StubLength, MinimumStraight, EndLengthAdjustment, ConductorSplitLength, SchematicPinID, CableWidth, CableThickness, SwitchPin1Position, SpecificationFieldName, SpecificationValue);
        }
        public static IFeatureObject FeatureCut3(IFeatureManagerObject IFeatureManagerinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean NormalCut, Boolean UseFeatScope, Boolean UseAutoSelect, Boolean AssemblyFeatureScope, Boolean AutoSelectComponents, Boolean PropagateFeatureToParts, Int32 T0, Double StartOffset, Boolean FlipStartOffset)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureCut3(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, NormalCut, UseFeatScope, UseAutoSelect, AssemblyFeatureScope, AutoSelectComponents, PropagateFeatureToParts, T0, StartOffset, FlipStartOffset));
        }
        public static IFeatureObject FeatureCutThin2(IFeatureManagerObject IFeatureManagerinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Double Thk1, Double Thk2, Double EndThk, Int32 RevThinDir, Int32 CapEnds, Boolean AddBends, Double BendRad, Boolean UseFeatScope, Boolean UseAutoSelect, Int32 T0, Double StartOffset, Boolean FlipStartOffset)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureCutThin2(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, Thk1, Thk2, EndThk, RevThinDir, CapEnds, AddBends, BendRad, UseFeatScope, UseAutoSelect, T0, StartOffset, FlipStartOffset));
        }
        public static IFeatureObject InsertStructuralWeldment3(IFeatureManagerObject IFeatureManagerinstance, String Path, Int32 EndCond, Double Angle, Boolean Merge, Object Groups)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertStructuralWeldment3(Path, EndCond, Angle, Merge, Groups));
        }
        public static IStructuralMemberGroupObject CreateStructuralMemberGroup(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IStructuralMemberGroupObject(IFeatureManagerinstance.IFeatureManagerInstance.CreateStructuralMemberGroup());
        }
        //public static IFeatureObject InsertMateReference2(IFeatureManagerObject IFeatureManagerinstance, String BstrMateReferenceName, EntityObject PrimaryReferenceEntity, Int32 PrimaryReferenceType, Int32 PrimaryReferenceAlignment, Boolean PrimaryReferenceAlignAxes, EntityObject SecondaryReferenceEntity, Int32 SecondaryReferenceType, Int32 SecondaryReferenceAlignment, Boolean SecondaryReferenceAlignAxes, EntityObject TertiaryReferenceEntity, Int32 TertiaryReferenceType, Int32 TertiaryReferenceAlignment)
        //{
        //    return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMateReference2(BstrMateReferenceName, PrimaryReferenceEntity, PrimaryReferenceType, PrimaryReferenceAlignment, PrimaryReferenceAlignAxes, SecondaryReferenceEntity, SecondaryReferenceType, SecondaryReferenceAlignment, SecondaryReferenceAlignAxes, TertiaryReferenceEntity, TertiaryReferenceType, TertiaryReferenceAlignment));
        //}
        public static IFeatureObject InsertWeldmentCutList2(IFeatureManagerObject IFeatureManagerinstance, Object Bodies)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertWeldmentCutList2(Bodies));
        }
        public static IFeatureObject InsertGussetFeature2(IFeatureManagerObject IFeatureManagerinstance, Double Depth, Int16 DirType, Int16 LocType, Boolean BIsProfile, Double ProfileD1, Double ProfileD2, Double ProfileD3, Double ProfileAngle, Double ProfileD4, Boolean BOffset, Double DProfileOffset, Int32 CrvIndex, Boolean BReverseDir, Boolean BReverseFace, Boolean BUseLenDim, Object Faces)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertGussetFeature2(Depth, DirType, LocType, BIsProfile, ProfileD1, ProfileD2, ProfileD3, ProfileAngle, ProfileD4, BOffset, DProfileOffset, CrvIndex, BReverseDir, BReverseFace, BUseLenDim, Faces));
        }
        public static IFeatureObject InsertEndCapFeature2(IFeatureManagerObject IFeatureManagerinstance, Double Depth, Boolean BIsGivenOffset, Boolean BIsChamfer, Double OffsetValue, Double WallThicknessRatio, Double ChamferValue, Object Faces)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertEndCapFeature2(Depth, BIsGivenOffset, BIsChamfer, OffsetValue, WallThicknessRatio, ChamferValue, Faces));
        }
        public static IFeatureObject InsertWeldmentTrimFeature2(IFeatureManagerObject IFeatureManagerinstance, Int32 EndCond, Int32 Options, Double GapValue, Object BodiesToTrim, Object BodiesOrFaces)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertWeldmentTrimFeature2(EndCond, Options, GapValue, BodiesToTrim, BodiesOrFaces));
        }
        public static IFeatureObject InsertFilletBeadFeature3(IFeatureManagerObject IFeatureManagerinstance, Int16 Type1, Double Size1, Double Length1, Int16 PenetrationType1, Double PenetrationValue1, Double Pitch, Int16 Type2, Double Size2, Double Length2, Int16 PenetrationType2, Double PenetrationValue2, Int32 Flag, Int32 EdgeNum1, Object DeSelEdge1, Int32 EdgeNum2, Object DeSelEdge2, Object FaceSet1, Object FaceSet2)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertFilletBeadFeature3(Type1, Size1, Length1, PenetrationType1, PenetrationValue1, Pitch, Type2, Size2, Length2, PenetrationType2, PenetrationValue2, Flag, EdgeNum1, DeSelEdge1, EdgeNum2, DeSelEdge2, FaceSet1, FaceSet2));
        }
        public static IFeatureObject InsertSubWeldFolder2(IFeatureManagerObject IFeatureManagerinstance, Object BodyArray)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSubWeldFolder2(BodyArray));
        }
        public static IFeatureObject InsertSewRefSurface(IFeatureManagerObject IFeatureManagerinstance, Boolean UseGapFilters, Boolean TryToFormSolid, Boolean MergeEntities, Double KnitTolerance, Double MaxValueForGapRange)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSewRefSurface(UseGapFilters, TryToFormSolid, MergeEntities, KnitTolerance, MaxValueForGapRange));
        }
        //public static IFeatureObject InsertSheetMetalBaseFlange2(IFeatureManagerObject IFeatureManagerinstance, Double Thickness, Boolean ThickenDir, Double Radius, Double ExtrudeDist1, Double ExtrudeDist2, Boolean FlipExtruDir, Int32 EndCondition1, Int32 EndCondition2, Int32 DirToUse, CustomBendAllowanceObject PCBA, Boolean UseDefaultRelief, Int32 ReliefType, Double ReliefWidth, Double ReliefDepth, Double ReliefRatio, Boolean UseReliefRatio, Boolean Merge, Boolean UseFeatScope, Boolean UseAutoSelect)
        //{
        //    return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSheetMetalBaseFlange2(Thickness, ThickenDir, Radius, ExtrudeDist1, ExtrudeDist2, FlipExtruDir, EndCondition1, EndCondition2, DirToUse, PCBA, UseDefaultRelief, ReliefType, ReliefWidth, ReliefDepth, ReliefRatio, UseReliefRatio, Merge, UseFeatScope, UseAutoSelect));
        //}
        public static Object InsertRefPlane(IFeatureManagerObject IFeatureManagerinstance, Int32 FirstConstraint, Double FirstConstraintAngleOrDistance, Int32 SecondConstraint, Double SecondConstraintAngleOrDistance, Int32 ThirdConstraint, Double ThirdConstraintAngleOrDistance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.InsertRefPlane(FirstConstraint, FirstConstraintAngleOrDistance, SecondConstraint, SecondConstraintAngleOrDistance, ThirdConstraint, ThirdConstraintAngleOrDistance);
        }
        public static IFeatureObject HoleWizard4(IFeatureManagerObject IFeatureManagerinstance, Int32 GenericHoleType, Int32 StandardIndex, Int32 FastenerTypeIndex, String SSize, Int16 EndType, Double Diameter, Double Depth, Double Value1, Double Value2, Double Value3, Double Value4, Double Value5, Double Value6, Double Value7, Double Value8, Double Value9, Double Value10, Double Value11, Double Value12, String ThreadClass, Boolean RevDir, Boolean UseFeatScope, Boolean UseAutoSelect, Boolean AssemblyFeatureScope, Boolean AutoSelectComponents, Boolean PropagateFeatureToParts)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.HoleWizard4(GenericHoleType, StandardIndex, FastenerTypeIndex, SSize, EndType, Diameter, Depth, Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, ThreadClass, RevDir, UseFeatScope, UseAutoSelect, AssemblyFeatureScope, AutoSelectComponents, PropagateFeatureToParts));
        }
        public static IFeatureObject InsertMoveFace2(IFeatureManagerObject IFeatureManagerinstance, Int32 MoveType, Boolean ReverseDir, Double Angle, Double Distance, Object TranslationParams, Object RotationParams)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMoveFace2(MoveType, ReverseDir, Angle, Distance, TranslationParams, RotationParams));
        }
        //public static IFeatureObject IInsertMoveFace2(IFeatureManagerObject IFeatureManagerinstance, Int32 MoveType, Boolean ReverseDir, Double Angle, Double Distance, Double& TranslationParams, Double& RotationParams)
        //{
        //    return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.IInsertMoveFace2(MoveType, ReverseDir, Angle, Distance, TranslationParams, RotationParams));
        //}
        public static IFeatureObject InsertProtrusionBlend2(IFeatureManagerObject IFeatureManagerinstance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational, Double TessToleranceFactor, Int16 StartMatchingType, Int16 EndMatchingType, Double StartTangentLength, Double EndTangentLength, Boolean StartTangentDir, Boolean EndTangentDir, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType, Boolean Merge, Boolean UseFeatScope, Boolean UseAutoSelect, Int32 GuideCurveInfluence)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertProtrusionBlend2(Closed, KeepTangency, ForceNonRational, TessToleranceFactor, StartMatchingType, EndMatchingType, StartTangentLength, EndTangentLength, StartTangentDir, EndTangentDir, IsThinBody, Thickness1, Thickness2, ThinType, Merge, UseFeatScope, UseAutoSelect, GuideCurveInfluence));
        }
        public static Boolean InsertConvertToSheetMetal2(IFeatureManagerObject IFeatureManagerinstance, Double Thickness, Boolean ReverseThickDir, Boolean FindBends, Double Radius, Double Gap, Int32 ReliefType, Double ReliefRatio, Int32 OverlapType, Double OverlapRatio, Boolean KeepBody)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.InsertConvertToSheetMetal2(Thickness, ReverseThickDir, FindBends, Radius, Gap, ReliefType, ReliefRatio, OverlapType, OverlapRatio, KeepBody);
        }
        public static IFeatureObject InsertCutSwept4(IFeatureManagerObject IFeatureManagerinstance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean BAdvancedSmoothing, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType, Int16 PathAlign, Boolean UseFeatScope, Boolean UseAutoSelect, Double TwistAngle, Boolean BMergeSmoothFaces, Boolean AssemblyFeatureScope, Boolean AutoSelectComponents, Boolean PropagateFeatureToParts)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCutSwept4(Propagate, Alignment, TwistCtrlOption, KeepTangency, BAdvancedSmoothing, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType, PathAlign, UseFeatScope, UseAutoSelect, TwistAngle, BMergeSmoothFaces, AssemblyFeatureScope, AutoSelectComponents, PropagateFeatureToParts));
        }
        public static IFeatureObject InsertStructuralWeldment4(IFeatureManagerObject IFeatureManagerinstance, String Path, Int32 ConnectedSegmentsOption, Boolean AllowProtrusion, Object Groups)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertStructuralWeldment4(Path, ConnectedSegmentsOption, AllowProtrusion, Groups));
        }
        public static IFeatureObject InsertFeatureLock(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertFeatureLock());
        }
        public static IFeatureObject InsertGridFeature(IFeatureManagerObject IFeatureManagerinstance, Object HeightDoubles)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertGridFeature(HeightDoubles));
        }
        public static void FeatureExtruRefSurface(IFeatureManagerObject IFeatureManagerinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean CapEnd1, Boolean CapEnd2, Boolean DeleteOriginalFace, Boolean KnitResult)
        {
            IFeatureManagerinstance.IFeatureManagerInstance.FeatureExtruRefSurface(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, CapEnd1, CapEnd2, DeleteOriginalFace, KnitResult);
        }
        public static Boolean AddVariablePitchHelixFirstPitchAndDiameter(IFeatureManagerObject IFeatureManagerinstance, Double FirstPitch, Double FirstDiameter)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.AddVariablePitchHelixFirstPitchAndDiameter(FirstPitch, FirstDiameter);
        }
        public static IFeatureObject FeatureRevolve2(IFeatureManagerObject IFeatureManagerinstance, Boolean SingleDir, Boolean IsSolid, Boolean IsThin, Boolean IsCut, Boolean ReverseDir, Boolean BothDirectionUpToSameEntity, Int32 Dir1Type, Int32 Dir2Type, Double Dir1Angle, Double Dir2Angle, Boolean OffsetReverse1, Boolean OffsetReverse2, Double OffsetDistance1, Double OffsetDistance2, Int32 ThinType, Double ThinThickness1, Double ThinThickness2, Boolean Merge, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureRevolve2(SingleDir, IsSolid, IsThin, IsCut, ReverseDir, BothDirectionUpToSameEntity, Dir1Type, Dir2Type, Dir1Angle, Dir2Angle, OffsetReverse1, OffsetReverse2, OffsetDistance1, OffsetDistance2, ThinType, ThinThickness1, ThinThickness2, Merge, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject InsertDwgOrDxfFile2(IFeatureManagerObject IFeatureManagerinstance, String FileName, Object DxfDwgImportData)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertDwgOrDxfFile2(FileName, DxfDwgImportData));
        }
        public static IFeatureObject FeatureCircularPattern3(IFeatureManagerObject IFeatureManagerinstance, Int32 Number, Double Spacing, Boolean FlipDirection, String DName, Boolean GeometryPattern, Boolean EqualSpacing)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureCircularPattern3(Number, Spacing, FlipDirection, DName, GeometryPattern, EqualSpacing));
        }
        public static IFeatureObject InsertSheetMetalHem2(IFeatureManagerObject IFeatureManagerinstance, Int32 Type, Int32 Position, Boolean Reverse, Double DLength, Double DGap, Double DAngle, Double DRad, Double DMiterGap, ICustomBendAllowanceObject PCBA, Boolean UseDefaultRelief, Int32 ReliefType, Int32 ReliefTearTypes, Boolean UseReliefRatio, Double ReliefRatio, Double ReliefWidth, Double ReliefDepth)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSheetMetalHem2(Type, Position, Reverse, DLength, DGap, DAngle, DRad, DMiterGap, PCBA.ICustomBendAllowanceInstance as CustomBendAllowance, UseDefaultRelief, ReliefType, ReliefTearTypes, UseReliefRatio, ReliefRatio, ReliefWidth, ReliefDepth));
        }
        public static IFeatureObject InsertFormToolFeature(IFeatureManagerObject IFeatureManagerinstance, String Path, Boolean Flip, Double RotAngle, String Config, Boolean OverrideDoc, Boolean ShowPunch, Boolean ShowProfile, Boolean ShowCenter, Boolean LinkToPart)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertFormToolFeature(Path, Flip, RotAngle, Config, OverrideDoc, ShowPunch, ShowProfile, ShowCenter, LinkToPart));
        }
        public static IFeatureObject GetFreezeLocation(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.GetFreezeLocation());
        }
        public static Int32 EditFreeze(IFeatureManagerObject IFeatureManagerinstance, Int32 Location, String FeatureName, Boolean UpdateAllConfigs)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.EditFreeze(Location, FeatureName, UpdateAllConfigs);
        }
        public static void FeatureExtruRefSurface2(IFeatureManagerObject IFeatureManagerinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean CapEnd1, Boolean CapEnd2, Boolean DeleteOriginalFace, Boolean KnitResult)
        {
            IFeatureManagerinstance.IFeatureManagerInstance.FeatureExtruRefSurface2(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, CapEnd1, CapEnd2, DeleteOriginalFace, KnitResult);
        }
        public static ITreeControlItemObject GetFeatureTreeRootItem2(IFeatureManagerObject IFeatureManagerinstance, Int32 WhichPane)
        {
            return new ITreeControlItemObject(IFeatureManagerinstance.IFeatureManagerInstance.GetFeatureTreeRootItem2(WhichPane));
        }
        public static IFeatureObject InsertCosmeticWeldBead(IFeatureManagerObject IFeatureManagerinstance, Double WeldSize)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCosmeticWeldBead(WeldSize));
        }
        public static IFeatureObject CreateFormTool2(IFeatureManagerObject IFeatureManagerinstance, Double OriginX, Double OriginY)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.CreateFormTool2(OriginX, OriginY));
        }
        public static IFeatureObject FeatureLinearPattern3(IFeatureManagerObject IFeatureManagerinstance, Int32 Num1, Double Spacing1, Int32 Num2, Double Spacing2, Boolean FlipDir1, Boolean FlipDir2, String DName1, String DName2, Boolean GeometryPattern, Boolean VaryInstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureLinearPattern3(Num1, Spacing1, Num2, Spacing2, FlipDir1, FlipDir2, DName1, DName2, GeometryPattern, VaryInstance));
        }
        public static IFeatureObject FeatureCircularPattern4(IFeatureManagerObject IFeatureManagerinstance, Int32 Number, Double Spacing, Boolean FlipDirection, String DName, Boolean GeometryPattern, Boolean EqualSpacing, Boolean VaryInstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureCircularPattern4(Number, Spacing, FlipDirection, DName, GeometryPattern, EqualSpacing, VaryInstance));
        }
        public static Boolean InsertVaryInstanceIncrement(IFeatureManagerObject IFeatureManagerinstance, String DName, Int32 PatternType, Int32 IncrementType, Int32 Direction, Double IncrementValue)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.InsertVaryInstanceIncrement(DName, PatternType, IncrementType, Direction, IncrementValue);
        }
        public static Boolean InsertVaryInstanceOverride(IFeatureManagerObject IFeatureManagerinstance, String DName, Int32 PatternType, Int32 OverrideType, Int32 Direction, Int32 InstanceRowIndex, Int32 InstanceColumnIndex, Double OverrideValue)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.InsertVaryInstanceOverride(DName, PatternType, OverrideType, Direction, InstanceRowIndex, InstanceColumnIndex, OverrideValue);
        }
        public static IFeatureObject InsertCenterOfMass(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCenterOfMass());
        }
        public static IFeatureObject InsertCenterOfMassReferencePoint(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCenterOfMassReferencePoint());
        }
        //public static IFeatureObject InsertCutSurface(IFeatureManagerObject IFeatureManagerinstance, Boolean Flip, Int32 KeepPieceIndex, Boolean UseFeatScope, Boolean UseAutoSelect, Object Bodies, Int32& Error)
        //{
        //    return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCutSurface(Flip, KeepPieceIndex, UseFeatScope, UseAutoSelect, Bodies, Error));
        //}
        public static Object GetSheetMetalFolder(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.GetSheetMetalFolder();
        }
        public static Object GetFlatPatternFolder(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.GetFlatPatternFolder();
        }
        public static IFeatureObject FeatureFillPattern(IFeatureManagerObject IFeatureManagerinstance, Int32 PatternLayoutType, Int32 LayoutSpacingType, Double InstanceSpacing, Double StaggerAngle, Double Margins, Double LoopSpacing, Int32 NoOfInstances, Int32 PatternLayoutPolygonSides, Int32 FeaturesToPatternType, Int32 CreateSeedCutType, Double Diameter, Double Dimension, Double Rotation, Double Diagonal, Int32 CreateSeedCutPolygonSides, Double OuterRadius, Double InnerRadius, Boolean FlipShapeDirection, Boolean GeometryPattern)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureFillPattern(PatternLayoutType, LayoutSpacingType, InstanceSpacing, StaggerAngle, Margins, LoopSpacing, NoOfInstances, PatternLayoutPolygonSides, FeaturesToPatternType, CreateSeedCutType, Diameter, Dimension, Rotation, Diagonal, CreateSeedCutPolygonSides, OuterRadius, InnerRadius, FlipShapeDirection, GeometryPattern));
        }
        public static IFeatureObject FeatureDimensionPattern(IFeatureManagerObject IFeatureManagerinstance, Int32 Num1, Double Spacing1, Int32 Num2, Double Spacing2, Boolean DiagonalOnly, String DName1, String DName2, Boolean VaryInstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureDimensionPattern(Num1, Spacing1, Num2, Spacing2, DiagonalOnly, DName1, DName2, VaryInstance));
        }
        public static IFeatureObject InsertSheetMetalLoftedBend2(IFeatureManagerObject IFeatureManagerinstance, Int32 ThickDirType, Double Thickness, Boolean BFormed, Double DRadius, Boolean BReferToEndPoint, Int32 EFacetOption, Double DChordTol, Int32 INumBends, Double DSegLength, Double DSegAngle)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSheetMetalLoftedBend2(ThickDirType, Thickness, BFormed, DRadius, BReferToEndPoint, EFacetOption, DChordTol, INumBends, DSegLength, DSegAngle));
        }
        public static IFeatureObject HoleWizard5(IFeatureManagerObject IFeatureManagerinstance, Int32 GenericHoleType, Int32 StandardIndex, Int32 FastenerTypeIndex, String SSize, Int16 EndType, Double Diameter, Double Depth, Double Length, Double Value1, Double Value2, Double Value3, Double Value4, Double Value5, Double Value6, Double Value7, Double Value8, Double Value9, Double Value10, Double Value11, Double Value12, String ThreadClass, Boolean RevDir, Boolean FeatureScope, Boolean AutoSelect, Boolean AssemblyFeatureScope, Boolean AutoSelectComponents, Boolean PropagateFeatureToParts)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.HoleWizard5(GenericHoleType, StandardIndex, FastenerTypeIndex, SSize, EndType, Diameter, Depth, Length, Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, ThreadClass, RevDir, FeatureScope, AutoSelect, AssemblyFeatureScope, AutoSelectComponents, PropagateFeatureToParts));
        }
        public static IFeatureObject InsertSheetMetalGussetFeature(IFeatureManagerObject IFeatureManagerinstance, Boolean BOffset, Double DOffset, Boolean BFlipOffsetSide, Int32 ProfDimType, Double DIndentDepth, Double DLength, Boolean BUseAngle, Double DHeight, Double DAngle, Boolean BFlipSides, Double DWidth, Double DThickness, Boolean BDraft, Double DDraftAngle, Boolean BInnerCornerFillet, Double DInnerCornerFilletRadius, Boolean BOuterCornerFillet, Double DOuterCornerFilletRadius, Int32 GussetType, Boolean BEdgeFillet, Double DEdgeFilletRadius)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSheetMetalGussetFeature(BOffset, DOffset, BFlipOffsetSide, ProfDimType, DIndentDepth, DLength, BUseAngle, DHeight, DAngle, BFlipSides, DWidth, DThickness, BDraft, DDraftAngle, BInnerCornerFillet, DInnerCornerFilletRadius, BOuterCornerFillet, DOuterCornerFilletRadius, GussetType, BEdgeFillet, DEdgeFilletRadius));
        }
        public static IFeatureObject InsertSheetMetalGussetFeature2(IFeatureManagerObject IFeatureManagerinstance, Boolean BOffset, Double DOffset, Boolean BFlipOffsetSide, Int32 ProfDimType, Double DIndentDepth, Double DLength, Boolean BUseAngle, Double DHeight, Double DAngle, Boolean BFlipSides, Double DWidth, Double DThickness, Boolean BDraft, Double DDraftAngle, Boolean BInnerCornerFillet, Double DInnerCornerFilletRadius, Boolean BOuterCornerFillet, Double DOuterCornerFilletRadius, Int32 GussetType, Boolean BEdgeFillet, Double DEdgeFilletRadius, Object ArrayOfFaces, Object ArrayRefLines, Object ArrayRefPoints)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSheetMetalGussetFeature2(BOffset, DOffset, BFlipOffsetSide, ProfDimType, DIndentDepth, DLength, BUseAngle, DHeight, DAngle, BFlipSides, DWidth, DThickness, BDraft, DDraftAngle, BInnerCornerFillet, DInnerCornerFilletRadius, BOuterCornerFillet, DOuterCornerFilletRadius, GussetType, BEdgeFillet, DEdgeFilletRadius, ArrayOfFaces, ArrayRefLines, ArrayRefPoints));
        }
        public static IFeatureObject FeatureExtrusion3(IFeatureManagerObject IFeatureManagerinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean Merge, Boolean UseFeatScope, Boolean UseAutoSelect, Int32 T0, Double StartOffset, Boolean FlipStartOffset)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureExtrusion3(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, Merge, UseFeatScope, UseAutoSelect, T0, StartOffset, FlipStartOffset));
        }
        public static Object FeatureFillet2(IFeatureManagerObject IFeatureManagerinstance, Int32 Options, Double R1, Double Rho, Int32 Ftyp, Int32 OverflowType, Int32 ConicRhoType, Object Radii, Object RhoArr, Object SetBackDistances, Object PointRadiusArray, Object PointRhoArray)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.FeatureFillet2(Options, R1, Rho, Ftyp, OverflowType, ConicRhoType, Radii, RhoArr, SetBackDistances, PointRadiusArray, PointRhoArray);
        }
        //public static IFeatureObject IFeatureFillet2(IFeatureManagerObject IFeatureManagerinstance, Int32 Options, Double R1, Double Rho, Int32 Ftyp, Int32 OverflowType, Int32 ConicRhoType, Int32 NRadii, Double& Radii, Double& RhoArr, Int32 SetbackDistCount, Double& SetBackDistances, Int32 PointCount, Double& PointRadiusArray, Double& PointRhoArray)
        //{
        //    return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.IFeatureFillet2(Options, R1, Rho, Ftyp, OverflowType, ConicRhoType, NRadii, Radii, RhoArr, SetbackDistCount, SetBackDistances, PointCount, PointRadiusArray, PointRhoArray));
        //}
        public static Boolean AddCornerReliefType(IFeatureManagerObject IFeatureManagerinstance, Int32 CornerIndex, Int32 ReliefType, Double Length1, Double Length2, Double Length3, Boolean CenterOnBendLines, Boolean RatioToThickness, Boolean TangentToBend, Boolean AddFilletedCorners, Boolean NarrowCorner)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.AddCornerReliefType(CornerIndex, ReliefType, Length1, Length2, Length3, CenterOnBendLines, RatioToThickness, TangentToBend, AddFilletedCorners, NarrowCorner);
        }
        public static Int32 AddCornerReliefCorner(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.AddCornerReliefCorner();
        }
        public static IFeatureObject FinishCornerRelief(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FinishCornerRelief());
        }
        public static IFeatureObject InsertCosmeticThread3(IFeatureManagerObject IFeatureManagerinstance, Int32 Standard, String StandardType, String Size, Double Diameter, Int32 EndType, Double Depth, String Note)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCosmeticThread3(Standard, StandardType, Size, Diameter, EndType, Depth, Note));
        }
        public static Object PreIntersect(IFeatureManagerObject IFeatureManagerinstance, Boolean CapPlanar)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.PreIntersect(CapPlanar);
        }
        public static IFeatureObject PostIntersect(IFeatureManagerObject IFeatureManagerinstance, Object IntersectionsToExclude, Boolean Merge, Boolean Consume)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.PostIntersect(IntersectionsToExclude, Merge, Consume));
        }
        public static Object FeatureFillet3(IFeatureManagerObject IFeatureManagerinstance, Int32 Options, Double R1, Double R2, Double Rho, Int32 Ftyp, Int32 OverflowType, Int32 ConicRhoType, Object Radii, Object Dist2Arr, Object RhoArr, Object SetBackDistances, Object PointRadiusArray, Object PointDist2Array, Object PointRhoArray)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.FeatureFillet3(Options, R1, R2, Rho, Ftyp, OverflowType, ConicRhoType, Radii, Dist2Arr, RhoArr, SetBackDistances, PointRadiusArray, PointDist2Array, PointRhoArray);
        }
        public static IFeatureObject FeatureFolderLocation(IFeatureManagerObject IFeatureManagerinstance, IFeatureObject Feature)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureFolderLocation(Feature.IFeatureInstance as Feature));
        }
        public static Int32 EditFreeze2(IFeatureManagerObject IFeatureManagerinstance, Int32 Location, String FeatureName, Boolean UpdateAllConfigs, Boolean UnlockConfigs)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.EditFreeze2(Location, FeatureName, UpdateAllConfigs, UnlockConfigs);
        }
        public static IFeatureObject FeatureLocalCurveDrivenPattern(IFeatureManagerObject IFeatureManagerinstance, Boolean FlipDir1, Int32 Num1, Boolean EqualSpacing1, Double Spacing1, Int32 ReferencePoint, Int32 CurveMethod, Int32 AlignMethod, Boolean Direction2, Boolean FlipDir2, Int32 Num2, Boolean EqualSpacing2, Double Spacing2, Boolean PatternSeedOnly)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureLocalCurveDrivenPattern(FlipDir1, Num1, EqualSpacing1, Spacing1, ReferencePoint, CurveMethod, AlignMethod, Direction2, FlipDir2, Num2, EqualSpacing2, Spacing2, PatternSeedOnly));
        }
        public static IFeatureObject FeatureLocalSketchDrivenPattern(IFeatureManagerObject IFeatureManagerinstance, Int32 ReferencePoint)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureLocalSketchDrivenPattern(ReferencePoint));
        }
        public static Object PreSplitBody2(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.PreSplitBody2();
        }
        public static IFeatureObject InsertEndCapFeature3(IFeatureManagerObject IFeatureManagerinstance, Double Depth, Boolean BIsGivenOffset, Boolean BIsChamfer, Double OffsetValue, Double WallThicknessRatio, Double ChamferValue, Boolean BIsCornerTreatment, Double DepthOffset, Boolean BIsReverse, Int32 BIsEndCapInward)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertEndCapFeature3(Depth, BIsGivenOffset, BIsChamfer, OffsetValue, WallThicknessRatio, ChamferValue, BIsCornerTreatment, DepthOffset, BIsReverse, BIsEndCapInward));
        }
        public static IFeatureObject InsertGussetFeature3(IFeatureManagerObject IFeatureManagerinstance, Double Depth, Int16 DirType, Int16 LocType, Boolean BIsProfile, Double ProfileD1, Double ProfileD2, Double ProfileD3, Double ProfileAngle, Double ProfileD4, Boolean BOffset, Double DProfileOffset, Int32 CrvIndex, Boolean BReverseDir, Boolean BReverseFace, Boolean BUseLenDim, Double ProfileD5, Double ProfileD6, Double ProfileChamferAngle, Boolean BUseLenDimForChamfer, Boolean BNeedChamferInGusset)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertGussetFeature3(Depth, DirType, LocType, BIsProfile, ProfileD1, ProfileD2, ProfileD3, ProfileAngle, ProfileD4, BOffset, DProfileOffset, CrvIndex, BReverseDir, BReverseFace, BUseLenDim, ProfileD5, ProfileD6, ProfileChamferAngle, BUseLenDimForChamfer, BNeedChamferInGusset));
        }
        public static IFeatureObject InsertFeatureChamfer(IFeatureManagerObject IFeatureManagerinstance, Int32 Options, Int32 ChamferType, Double Width, Double Angle, Double OtherDist, Double VertexChamDist1, Double VertexChamDist2, Double VertexChamDist3)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertFeatureChamfer(Options, ChamferType, Width, Angle, OtherDist, VertexChamDist1, VertexChamDist2, VertexChamDist3));
        }
        public static Boolean MoveToFolder(IFeatureManagerObject IFeatureManagerinstance, String MoveToFeat, String MoveFromFeat, Boolean IsFolder)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.MoveToFolder(MoveToFeat, MoveFromFeat, IsFolder);
        }
        public static IFeatureObject InsertMateReference(IFeatureManagerObject IFeatureManagerinstance, String BstrMateReferenceName, IEntityObject PrimaryReferenceEntity, Int32 PrimaryReferenceType, Int32 PrimaryReferenceAlignment, IEntityObject SecondaryReferenceEntity, Int32 SecondaryReferenceType, Int32 SecondaryReferenceAlignment, IEntityObject TertiaryReferenceEntity, Int32 TertiaryReferenceType, Int32 TertiaryReferenceAlignment)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMateReference(BstrMateReferenceName, PrimaryReferenceEntity.IEntityInstance as Entity, PrimaryReferenceType, PrimaryReferenceAlignment, SecondaryReferenceEntity.IEntityInstance as Entity, SecondaryReferenceType, SecondaryReferenceAlignment, TertiaryReferenceEntity.IEntityInstance as Entity, TertiaryReferenceType, TertiaryReferenceAlignment));
        }
        public static Object FeatureFillet(IFeatureManagerObject IFeatureManagerinstance, Int32 Options, Double R1, Int32 Ftyp, Int32 OverflowType, Object Radii, Object SetBackDistances, Object PointRadiusArray)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.FeatureFillet(Options, R1, Ftyp, OverflowType, Radii, SetBackDistances, PointRadiusArray);
        }
        //public static IFeatureObject IFeatureFillet(IFeatureManagerObject IFeatureManagerinstance, Int32 Options, Double R1, Int32 Ftyp, Int32 OverflowType, Int32 NRadii, Double& Radii, Int32 SetbackDistCount, Double& SetBackDistances, Int32 PointCount, Double& PointRadiusArray)
        //{
        //    return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.IFeatureFillet(Options, R1, Ftyp, OverflowType, NRadii, Radii, SetbackDistCount, SetBackDistances, PointCount, PointRadiusArray));
        //}
        public static IFeatureObject InsertProtrusionSwept3(IFeatureManagerObject IFeatureManagerinstance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean BAdvancedSmoothing, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType, Int16 PathAlign, Boolean Merge, Boolean UseFeatScope, Boolean UseAutoSelect, Double TwistAngle, Boolean BMergeSmoothFaces)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertProtrusionSwept3(Propagate, Alignment, TwistCtrlOption, KeepTangency, BAdvancedSmoothing, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType, PathAlign, Merge, UseFeatScope, UseAutoSelect, TwistAngle, BMergeSmoothFaces));
        }
        public static IFeatureObject InsertCutSwept3(IFeatureManagerObject IFeatureManagerinstance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean BAdvancedSmoothing, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType, Int16 PathAlign, Boolean UseFeatScope, Boolean UseAutoSelect, Double TwistAngle, Boolean BMergeSmoothFaces)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCutSwept3(Propagate, Alignment, TwistCtrlOption, KeepTangency, BAdvancedSmoothing, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType, PathAlign, UseFeatScope, UseAutoSelect, TwistAngle, BMergeSmoothFaces));
        }
        public static IFeatureObject InsertSweepSurface2(IFeatureManagerObject IFeatureManagerinstance, Boolean Propagate, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean BAdvancedSmoothing, Int16 StartMatchingType, Int16 EndMatchingType, Int16 PathAlign, Boolean UseFeatScope, Boolean UseAutoSelect, Double TwistAngle, Boolean BMergeSmoothFaces)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSweepSurface2(Propagate, TwistCtrlOption, KeepTangency, BAdvancedSmoothing, StartMatchingType, EndMatchingType, PathAlign, UseFeatScope, UseAutoSelect, TwistAngle, BMergeSmoothFaces));
        }
        public static IFeatureObject InsertSheetMetalHem(IFeatureManagerObject IFeatureManagerinstance, Int32 Type, Int32 Position, Boolean Reverse, Double DLength, Double DGap, Double DAngle, Double DRad, Double DMiterGap, ICustomBendAllowanceObject PCBA)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSheetMetalHem(Type, Position, Reverse, DLength, DGap, DAngle, DRad, DMiterGap, PCBA.ICustomBendAllowanceInstance as CustomBendAllowance));
        }
        public static IFeatureObject InsertSheetMetalEdgeFlange(IFeatureManagerObject IFeatureManagerinstance, IEdgeObject FlangeEdge, IFeatureObject SketchFeat, Int32 BooleanOptions, Double DAngle, Double DRadius, Int32 BendPosition, Double DOffsetDist, Int32 ReliefType, Double DReliefRatio, Double DReliefWidth, Double DReliefDepth, Int32 FlangeSharpType, ICustomBendAllowanceObject PCBA)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSheetMetalEdgeFlange(FlangeEdge.IEdgeInstance as Edge, SketchFeat.IFeatureInstance as Feature, BooleanOptions, DAngle, DRadius, BendPosition, DOffsetDist, ReliefType, DReliefRatio, DReliefWidth, DReliefDepth, FlangeSharpType, PCBA.ICustomBendAllowanceInstance as CustomBendAllowance));
        }
        public static IFeatureObject InsertSheetMetal3dBend(IFeatureManagerObject IFeatureManagerinstance, Double Angle, Boolean BUseDefaultRadius, Double Radius, Boolean FlipDir, Int16 BendPos, ICustomBendAllowanceObject PCBA)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSheetMetal3dBend(Angle, BUseDefaultRadius, Radius, FlipDir, BendPos, PCBA.ICustomBendAllowanceInstance as CustomBendAllowance));
        }
        public static IFeatureObject InsertEdgeMerge(IFeatureManagerObject IFeatureManagerinstance, Double Angular_tolerance, Double Edge_length_tolerance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertEdgeMerge(Angular_tolerance, Edge_length_tolerance));
        }
        public static void MoldUndercutDetect2(IFeatureManagerObject IFeatureManagerinstance, Int32 ColUndercut1, Int32 ColUndercut2, Int32 ColOccluded, Int32 ColStraddle, Int32 ColBase, Boolean BCoordInput, Double Dx, Double Dy, Double Dz)
        {
            IFeatureManagerinstance.IFeatureManagerInstance.MoldUndercutDetect2(ColUndercut1, ColUndercut2, ColOccluded, ColStraddle, ColBase, BCoordInput, Dx, Dy, Dz);
        }
        public static IFeatureObject InsertIndent(IFeatureManagerObject IFeatureManagerinstance, Double Thickness, Double Clearance, Boolean Exclude, Boolean ClrDir, Boolean Cut, Boolean CutDir)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertIndent(Thickness, Clearance, Exclude, ClrDir, Cut, CutDir));
        }
        public static IFeatureObject FeatureLinearPattern2(IFeatureManagerObject IFeatureManagerinstance, Int32 Num1, Double Spacing1, Int32 Num2, Double Spacing2, Boolean FlipDir1, Boolean FlipDir2, String DName1, String DName2, Boolean GeometryPattern)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureLinearPattern2(Num1, Spacing1, Num2, Spacing2, FlipDir1, FlipDir2, DName1, DName2, GeometryPattern));
        }
        public static IFeatureObject FeatureCircularPattern2(IFeatureManagerObject IFeatureManagerinstance, Int32 Num, Double Spacing, Boolean FlipDir, String DName, Boolean GeometryPattern)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureCircularPattern2(Num, Spacing, FlipDir, DName, GeometryPattern));
        }
        public static IFeatureObject InsertSplitLineIntersect(IFeatureManagerObject IFeatureManagerinstance, Int32 CompleteOption)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSplitLineIntersect(CompleteOption));
        }
        public static IFeatureObject InsertFlexFeature(IFeatureManagerObject IFeatureManagerinstance, Double RotX, Double RotY, Double RotZ, Double TanX, Double TanY, Double TanZ, Double RadX, Double RadY, Double RadZ, Double Angle, Double PivotX, Double PivotY, Double PivotZ, Int32 Type, Double LeftTrim, Double RightTrim, Boolean HardEdges)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertFlexFeature(RotX, RotY, RotZ, TanX, TanY, TanZ, RadX, RadY, RadZ, Angle, PivotX, PivotY, PivotZ, Type, LeftTrim, RightTrim, HardEdges));
        }
        public static IFeatureObject FeatureExtrusion2(IFeatureManagerObject IFeatureManagerinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean Merge, Boolean UseFeatScope, Boolean UseAutoSelect, Int32 T0, Double StartOffset, Boolean FlipStartOffset)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureExtrusion2(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, Merge, UseFeatScope, UseAutoSelect, T0, StartOffset, FlipStartOffset));
        }
        public static IFeatureObject InsertMoveFace(IFeatureManagerObject IFeatureManagerinstance, Int32 MoveType, Boolean ReverseDir, Double Angle, Double Distance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMoveFace(MoveType, ReverseDir, Angle, Distance));
        }
        public static Boolean IsNameUsed(IFeatureManagerObject IFeatureManagerinstance, Int32 Type, String Name)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.IsNameUsed(Type, Name);
        }
        public static IFeatureObject HoleWizard2(IFeatureManagerObject IFeatureManagerinstance, Int32 GenericHoleType, Int32 StandardIndex, Int32 FastenerTypeIndex, String SSize, Int16 EndType, Double Diameter, Double Depth, Double Value1, Double Value2, Double Value3, Double Value4, Double Value5, Double Value6, Double Value7, Double Value8, Double Value9, Double Value10, Double Value11, Double Value12, String ThreadClass, Boolean RevDir, Boolean UseFeatScope, Boolean UseAutoSelect, Boolean AssemblyFeatureScope, Boolean AutoSelectComponents)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.HoleWizard2(GenericHoleType, StandardIndex, FastenerTypeIndex, SSize, EndType, Diameter, Depth, Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, ThreadClass, RevDir, UseFeatScope, UseAutoSelect, AssemblyFeatureScope, AutoSelectComponents));
        }
        public static Object CreateDefinition(IFeatureManagerObject IFeatureManagerinstance, Int32 Type)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.CreateDefinition(Type);
        }
        public static IFeatureObject CreateFeature(IFeatureManagerObject IFeatureManagerinstance, Object FeatureData)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.CreateFeature(FeatureData));
        }
        public static IFeatureObject CreateFormTool(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.CreateFormTool());
        }
        public static Boolean InsertVariablePitchHelix(IFeatureManagerObject IFeatureManagerinstance, Boolean Reversed, Boolean Clockwise, Int32 Helixdef, Double Startangle)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.InsertVariablePitchHelix(Reversed, Clockwise, Helixdef, Startangle);
        }
        public static Boolean AddVariablePitchHelixSegment(IFeatureManagerObject IFeatureManagerinstance, Double Height, Double Diameter, Double Pitch)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.AddVariablePitchHelixSegment(Height, Diameter, Pitch);
        }
        public static IFeatureObject EndVariablePitchHelix(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.EndVariablePitchHelix());
        }
        public static Int32 GetFeatureCount(IFeatureManagerObject IFeatureManagerinstance, Boolean ToplevelOnly)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.GetFeatureCount(ToplevelOnly);
        }
        public static Object GetFeatures(IFeatureManagerObject IFeatureManagerinstance, Boolean ToplevelOnly)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.GetFeatures(ToplevelOnly);
        }
        public static IFeatureObject IGetFeatures(IFeatureManagerObject IFeatureManagerinstance, Boolean ToplevelOnly, Int32 Count)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.IGetFeatures(ToplevelOnly, Count));
        }
        public static IFeatureObject FeatureExtrusionThin2(IFeatureManagerObject IFeatureManagerinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean Merge, Double Thk1, Double Thk2, Double EndThk, Int32 RevThinDir, Int32 CapEnds, Boolean AddBends, Double BendRad, Boolean UseFeatScope, Boolean UseAutoSelect, Int32 T0, Double StartOffset, Boolean FlipStartOffset)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureExtrusionThin2(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, Merge, Thk1, Thk2, EndThk, RevThinDir, CapEnds, AddBends, BendRad, UseFeatScope, UseAutoSelect, T0, StartOffset, FlipStartOffset));
        }
        public static INoteObject InsertSecurityNote(IFeatureManagerObject IFeatureManagerinstance, String Text, IFeatureObject FeatureOwner)
        {
            return new INoteObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSecurityNote(Text, FeatureOwner.IFeatureInstance as Feature));
        }
        public static Object PreSplitBody(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.PreSplitBody();
        }
        public static IFeatureObject PostSplitBody(IFeatureManagerObject IFeatureManagerinstance, Object BodiesToMark, Boolean ConsumeCut, Object Origins, Object SavePaths)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.PostSplitBody(BodiesToMark, ConsumeCut, Origins, SavePaths));
        }
        public static IFeatureObject InsertMacroFeature3(IFeatureManagerObject IFeatureManagerinstance, String BaseName, String ProgId, Object MacroMethods, Object ParamNames, Object ParamTypes, Object ParamValues, Object DimTypes, Object DimValues, Object EditBodies, Object IconFiles, Int32 Options)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMacroFeature3(BaseName, ProgId, MacroMethods, ParamNames, ParamTypes, ParamValues, DimTypes, DimValues, EditBodies, IconFiles, Options));
        }
        //public static IFeatureObject IInsertMacroFeature3(IFeatureManagerObject IFeatureManagerinstance, String BaseName, String ProgId, String& MacroMethods, Int32 ParamCount, String& ParamNames, Int32& ParamTypes, String& ParamValues, Int32 DimCount, Int32& DimTypes, Double& DimCountValues, Int32 BodyCount, Body2&Object EditBodies, Int32 IconCount, String& IconFiles, Int32 Options)
        //{
        //    return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.IInsertMacroFeature3(BaseName, ProgId, MacroMethods, ParamCount, ParamNames, ParamTypes, ParamValues, DimCount, DimTypes, DimCountValues, BodyCount, EditBodies, IconCount, IconFiles, Options));
        //}
        public static IFeatureObject InsertNetBlend(IFeatureManagerObject IFeatureManagerinstance, Int16 Type, Int16 NCurvesDir1, Int16 NCurvesDir2, Boolean HasCenterline, Double TessTolFactor, Boolean WantsSolid, Boolean MergeBody, Boolean FeatureScope, Boolean AutoSelect, Boolean Thin, Double Thickness1, Double Thickness2, Boolean ReverseThickness, Int16 ThinSolidType, Boolean UseSharedThickness, Boolean CapEnds, Double EndThickness, Boolean AutoFillet, Double FilletRadius, Boolean ForceNonRational)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertNetBlend(Type, NCurvesDir1, NCurvesDir2, HasCenterline, TessTolFactor, WantsSolid, MergeBody, FeatureScope, AutoSelect, Thin, Thickness1, Thickness2, ReverseThickness, ThinSolidType, UseSharedThickness, CapEnds, EndThickness, AutoFillet, FilletRadius, ForceNonRational));
        }
        public static IFeatureObject SetNetBlendCurveData(IFeatureManagerObject IFeatureManagerinstance, Int16 Direction, Int16 CurveIndex, Int16 TangentType, Double SignedDraftAngle, Double SignedTangentLength, Boolean TangentLengthApplyAll)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.SetNetBlendCurveData(Direction, CurveIndex, TangentType, SignedDraftAngle, SignedTangentLength, TangentLengthApplyAll));
        }
        public static IFeatureObject SetNetBlendDirectionData(IFeatureManagerObject IFeatureManagerinstance, Int16 Direction, Int16 InfluenceType, Int16 TrimCurves, Boolean BlendClosed, Boolean SplitSurfaces)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.SetNetBlendDirectionData(Direction, InfluenceType, TrimCurves, BlendClosed, SplitSurfaces));
        }
        public static IFeatureObject SetNetBlendCenterlineData(IFeatureManagerObject IFeatureManagerinstance, Boolean CombineWithDir2, Int16 TwistType, Int16 PathAlignmentType, Int16 TwistAngleType, Double TwistAngle)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.SetNetBlendCenterlineData(CombineWithDir2, TwistType, PathAlignmentType, TwistAngleType, TwistAngle));
        }
        public static IFeatureObject ConvertLoftOrSweepToNetBlend(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.ConvertLoftOrSweepToNetBlend());
        }
        public static IFeatureObject InsertSheetMetalEdgeFlange2(IFeatureManagerObject IFeatureManagerinstance, Object FlangeEdges, Object SketchFeats, Int32 BooleanOptions, Double FlangeAngle, Double FlangeRadius, Int32 BendPosition, Double FlangeOffsetDist, Int32 ReliefType, Double FlangeReliefRatio, Double FlangeReliefWidth, Double FlangeReliefDepth, Int32 FlangeSharpType, ICustomBendAllowanceObject CustomBendAllowance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSheetMetalEdgeFlange2(FlangeEdges, SketchFeats, BooleanOptions, FlangeAngle, FlangeRadius, BendPosition, FlangeOffsetDist, ReliefType, FlangeReliefRatio, FlangeReliefWidth, FlangeReliefDepth, FlangeSharpType, CustomBendAllowance.ICustomBendAllowanceInstance as CustomBendAllowance));
        }
        //public static IFeatureObject IInsertSheetMetalEdgeFlange2(IFeatureManagerObject IFeatureManagerinstance, Int32 EdgeCount, Edge&Object FlangeEdges, Int32 SketchFeatCount, Feature&Object SketchFeat, Int32 BooleanOptions, Double FlangeAngle, Double FlangeRadius, Int32 BendPosition, Double FlangeOffsetDist, Int32 ReliefType, Double FlangeReliefRatio, Double FlangeReliefWidth, Double FlangeReliefDepth, Int32 FlangeSharpType, CustomBendAllowanceObject CustomBendAllowance)
        //{
        //    return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.IInsertSheetMetalEdgeFlange2(EdgeCount, FlangeEdges, SketchFeatCount, SketchFeat, BooleanOptions, FlangeAngle, FlangeRadius, BendPosition, FlangeOffsetDist, ReliefType, FlangeReliefRatio, FlangeReliefWidth, FlangeReliefDepth, FlangeSharpType, CustomBendAllowance));
        //}
        public static IFeatureObject InsertFillSurface2(IFeatureManagerObject IFeatureManagerinstance, Int32 Resolutions, Int32 Options, Object VPatchBoundaries, Object VCurvatureControlType, Object VFaces, Object VConstraintCurves)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertFillSurface2(Resolutions, Options, VPatchBoundaries, VCurvatureControlType, VFaces, VConstraintCurves));
        }
        public static IFeatureObject InsertFreeform(IFeatureManagerObject IFeatureManagerinstance, Int16 Continuity0, Int16 Continuity1, Int16 Continuity2, Int16 Continuity3, Boolean Symmetric0, Boolean Symmetric1)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertFreeform(Continuity0, Continuity1, Continuity2, Continuity3, Symmetric0, Symmetric1));
        }
        public static void SetFreeformCurveData(IFeatureManagerObject IFeatureManagerinstance, Int16 Direction, Double CurveParameter, Double Tangent0X, Double Tangent0Y, Double Tangent0Z, Double Tangent1X, Double Tangent1Y, Double Tangent1Z)
        {
            IFeatureManagerinstance.IFeatureManagerInstance.SetFreeformCurveData(Direction, CurveParameter, Tangent0X, Tangent0Y, Tangent0Z, Tangent1X, Tangent1Y, Tangent1Z);
        }
        public static void SetFreeformPointData(IFeatureManagerObject IFeatureManagerinstance, Int16 Direction, Double CurveParameter, Double ParameterOnCurve, Double XOffset, Double YOffset, Double ZOffset)
        {
            IFeatureManagerinstance.IFeatureManagerInstance.SetFreeformPointData(Direction, CurveParameter, ParameterOnCurve, XOffset, YOffset, ZOffset);
        }
        public static IFeatureObject DraftXpertChange(IFeatureManagerObject IFeatureManagerinstance, Double Angle, Boolean FlipDir, Boolean EdgeDraft, Int32 PropType, Boolean IsStepDraft, Boolean IsBodyDraft)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.DraftXpertChange(Angle, FlipDir, EdgeDraft, PropType, IsStepDraft, IsBodyDraft));
        }
        public static IFeatureObject DraftXpertRemove(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.DraftXpertRemove());
        }
        public static IFeatureObject FilletXpertChange(IFeatureManagerObject IFeatureManagerinstance, Int32 Options, Double R1, Int32 Ftyp, Int32 OverflowType)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FilletXpertChange(Options, R1, Ftyp, OverflowType));
        }
        public static IFeatureObject FilletXpertRemove(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FilletXpertRemove());
        }
        public static IFeatureObject InsertRevolvedRefSurface(IFeatureManagerObject IFeatureManagerinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertRevolvedRefSurface(Angle, ReverseDir, Angle2, RevType));
        }
        public static Object GetPreTrimmedBodies(IFeatureManagerObject IFeatureManagerinstance, IBody2Object TargetSurface)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.GetPreTrimmedBodies(TargetSurface.IBody2Instance as Body2);
        }
        public static IFeatureObject FilletXpertMakeCorner(IFeatureManagerObject IFeatureManagerinstance, Int32 CornerType)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FilletXpertMakeCorner(CornerType));
        }
        public static IFeatureObject InsertMirrorFeature2(IFeatureManagerObject IFeatureManagerinstance, Boolean BMirrorBody, Boolean BGeometryPattern, Boolean BMerge, Boolean BKnit, Int32 ScopeOptions)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMirrorFeature2(BMirrorBody, BGeometryPattern, BMerge, BKnit, ScopeOptions));
        }
        public static IFeatureObject InsertFilletBeadFeature2(IFeatureManagerObject IFeatureManagerinstance, Int16 Type1, Double Size1, Double Length1, Int16 PenetrationType1, Double PenetrationValue1, Double Pitch, Int16 Type2, Double Size2, Double Length2, Int16 PenetrationType2, Double PenetrationValue2, Int32 Flag, Int32 EdgeNum1, Object DeSelEdge1, Int32 EdgeNum2, Object DeSelEdge2)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertFilletBeadFeature2(Type1, Size1, Length1, PenetrationType1, PenetrationValue1, Pitch, Type2, Size2, Length2, PenetrationType2, PenetrationValue2, Flag, EdgeNum1, DeSelEdge1, EdgeNum2, DeSelEdge2));
        }
        public static ITreeControlItemObject GetFeatureTreeRootItem(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new ITreeControlItemObject(IFeatureManagerinstance.IFeatureManagerInstance.GetFeatureTreeRootItem());
        }
        public static IFeatureObject SimpleFeatureBossExtrude(IFeatureManagerObject IFeatureManagerinstance, String SketchName, Double Depth, Boolean Direction)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.SimpleFeatureBossExtrude(SketchName, Depth, Direction));
        }
        public static Object InsertMidSurface(IFeatureManagerObject IFeatureManagerinstance, IBody2Object PBodyIn, IModelDoc2Object PPartDocIn, Double Placement, Boolean KnitFlag)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.InsertMidSurface(PBodyIn.IBody2Instance as Body2, PPartDocIn.IModelDoc2Instance as ModelDoc2, Placement, KnitFlag);
        }
        public static Object CreateSaveBodyFeature(IFeatureManagerObject IFeatureManagerinstance, Object Bodies, Object FilePaths, String AssemName, Boolean ConsumeBody, Boolean CopyCustomProperty)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.CreateSaveBodyFeature(Bodies, FilePaths, AssemName, ConsumeBody, CopyCustomProperty);
        }
        public static IFeatureObject HoleWizard3(IFeatureManagerObject IFeatureManagerinstance, Int32 GenericHoleType, Int32 StandardIndex, Int32 FastenerTypeIndex, String SSize, Int16 EndType, Double Diameter, Double Depth, Double Value1, Double Value2, Double Value3, Double Value4, Double Value5, Double Value6, Double Value7, Double Value8, Double Value9, Double Value10, Double Value11, Double Value12, String ThreadClass, Boolean RevDir, Boolean UseFeatScope, Boolean UseAutoSelect, Boolean AssemblyFeatureScope, Boolean AutoSelectComponents, Boolean PropagateFeatureToParts)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.HoleWizard3(GenericHoleType, StandardIndex, FastenerTypeIndex, SSize, EndType, Diameter, Depth, Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12, ThreadClass, RevDir, UseFeatScope, UseAutoSelect, AssemblyFeatureScope, AutoSelectComponents, PropagateFeatureToParts));
        }
        public static IFeatureObject SimpleHole2(IFeatureManagerObject IFeatureManagerinstance, Double Dia, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean UseFeatScope, Boolean UseAutoSelect, Boolean AssemblyFeatureScope, Boolean AutoSelectComponents, Boolean PropagateFeatureToParts)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.SimpleHole2(Dia, Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, UseFeatScope, UseAutoSelect, AssemblyFeatureScope, AutoSelectComponents, PropagateFeatureToParts));
        }
        public static IFeatureObject FeatureCut2(IFeatureManagerObject IFeatureManagerinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean NormalCut, Boolean UseFeatScope, Boolean UseAutoSelect, Boolean AssemblyFeatureScope, Boolean AutoSelectComponents, Boolean PropagateFeatureToParts)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureCut2(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, NormalCut, UseFeatScope, UseAutoSelect, AssemblyFeatureScope, AutoSelectComponents, PropagateFeatureToParts));
        }
        public static IFeatureObject FeatureRevolveCut2(IFeatureManagerObject IFeatureManagerinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType, Int32 Options, Boolean UseFeatScope, Boolean UseAutoSelect, Boolean AssemblyFeatureScope, Boolean AutoSelectComponents, Boolean PropagateFeatureToParts)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureRevolveCut2(Angle, ReverseDir, Angle2, RevType, Options, UseFeatScope, UseAutoSelect, AssemblyFeatureScope, AutoSelectComponents, PropagateFeatureToParts));
        }
        public static IFeatureObject InsertFreeform2(IFeatureManagerObject IFeatureManagerinstance, Boolean Nsided, Boolean Symmetric0, Boolean Symmetric1, Double Angle)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertFreeform2(Nsided, Symmetric0, Symmetric1, Angle));
        }
        public static void SetFreeformBoundaryContinuity(IFeatureManagerObject IFeatureManagerinstance, Int16 BoundaryIndex, Int16 Continuity)
        {
            IFeatureManagerinstance.IFeatureManagerInstance.SetFreeformBoundaryContinuity(BoundaryIndex, Continuity);
        }
        public static Boolean EditReferencePoint(IFeatureManagerObject IFeatureManagerinstance, Int32 NRefPointType, Int32 NRefPointAlongCurveType, Double DDistance_or_Percent, Int32 NumberOfRefPoints)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.EditReferencePoint(NRefPointType, NRefPointAlongCurveType, DDistance_or_Percent, NumberOfRefPoints);
        }
        public static Boolean EditDeleteFace(IFeatureManagerObject IFeatureManagerinstance, Int32 Refill)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.EditDeleteFace(Refill);
        }
        public static IFeatureObject InsertLiveSectionPlane(IFeatureManagerObject IFeatureManagerinstance, Int16 Type)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertLiveSectionPlane(Type));
        }
        public static Boolean MoveRotateLiveSectionPlane(IFeatureManagerObject IFeatureManagerinstance, String Feat, Int16 Type, Double XorDeltaX, Double YorDeltaY, Double ZorDeltaZ, Double Axisx, Double Axisy, Double Axisz, Double Angle)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.MoveRotateLiveSectionPlane(Feat, Type, XorDeltaX, YorDeltaY, ZorDeltaZ, Axisx, Axisy, Axisz, Angle);
        }
        public static IFeatureObject InsertCrossBreak(IFeatureManagerObject IFeatureManagerinstance, Double Angle, Double Radius)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCrossBreak(Angle, Radius));
        }
        public static ICustomBendAllowanceObject CreateCustomBendAllowance(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new ICustomBendAllowanceObject(IFeatureManagerinstance.IFeatureManagerInstance.CreateCustomBendAllowance());
        }
        public static IFeatureObject InsertSheetMetalBaseFlange(IFeatureManagerObject IFeatureManagerinstance, Double Thickness, Boolean ThickenDir, Double Radius, Double ExtrudeDist1, Double ExtrudeDist2, Boolean FlipExtruDir, Int32 EndCondition1, Int32 EndCondition2, Int32 DirToUse, ICustomBendAllowanceObject PCBA, Boolean UseDefaultRelief, Int32 ReliefType, Double ReliefWidth, Double ReliefDepth, Double ReliefRatio, Boolean UseReliefRatio)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSheetMetalBaseFlange(Thickness, ThickenDir, Radius, ExtrudeDist1, ExtrudeDist2, FlipExtruDir, EndCondition1, EndCondition2, DirToUse, PCBA.ICustomBendAllowanceInstance as CustomBendAllowance, UseDefaultRelief, ReliefType, ReliefWidth, ReliefDepth, ReliefRatio, UseReliefRatio));
        }
        public static IFeatureObject InsertDeleteBody(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertDeleteBody());
        }
        public static IFeatureObject FeatureExtrusion(IFeatureManagerObject IFeatureManagerinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean Merge, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureExtrusion(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, Merge, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject FeatureExtrusionThin(IFeatureManagerObject IFeatureManagerinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean Merge, Double Thk1, Double Thk2, Double EndThk, Int32 RevThinDir, Int32 CapEnds, Boolean AddBends, Double BendRad, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureExtrusionThin(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, Merge, Thk1, Thk2, EndThk, RevThinDir, CapEnds, AddBends, BendRad, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject FeatureCut(IFeatureManagerObject IFeatureManagerinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean NormalCut, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureCut(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, NormalCut, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject FeatureCutThin(IFeatureManagerObject IFeatureManagerinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Double Thk1, Double Thk2, Double EndThk, Int32 RevThinDir, Int32 CapEnds, Boolean AddBends, Double BendRad, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureCutThin(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, Thk1, Thk2, EndThk, RevThinDir, CapEnds, AddBends, BendRad, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject FeatureRevolve(IFeatureManagerObject IFeatureManagerinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType, Int32 Options, Boolean Merge, Boolean UseFeatScope, Boolean UseAutoSel)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureRevolve(Angle, ReverseDir, Angle2, RevType, Options, Merge, UseFeatScope, UseAutoSel));
        }
        public static IFeatureObject FeatureRevolveCut(IFeatureManagerObject IFeatureManagerinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType, Int32 Options, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureRevolveCut(Angle, ReverseDir, Angle2, RevType, Options, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject FeatureRevolveThin(IFeatureManagerObject IFeatureManagerinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType, Double Thickness1, Double Thickness2, Int32 ReverseThinDir, Boolean Merge, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureRevolveThin(Angle, ReverseDir, Angle2, RevType, Thickness1, Thickness2, ReverseThinDir, Merge, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject FeatureRevolveThinCut(IFeatureManagerObject IFeatureManagerinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType, Double Thickness1, Double Thickness2, Int32 ReverseThinDir, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureRevolveThinCut(Angle, ReverseDir, Angle2, RevType, Thickness1, Thickness2, ReverseThinDir, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject FeatureBossThicken(IFeatureManagerObject IFeatureManagerinstance, Double Thickness, Int32 Direction, Int32 FaceIndex, Boolean FillVolume, Boolean Merge, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureBossThicken(Thickness, Direction, FaceIndex, FillVolume, Merge, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject FeatureCutThicken(IFeatureManagerObject IFeatureManagerinstance, Double Thickness, Int32 Direction, Int32 FaceIndex, Boolean FillVolume, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureCutThicken(Thickness, Direction, FaceIndex, FillVolume, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject InsertProtrusionSwept(IFeatureManagerObject IFeatureManagerinstance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType, Boolean Merge, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertProtrusionSwept(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType, Merge, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject InsertCutSwept(IFeatureManagerObject IFeatureManagerinstance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCutSwept(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject InsertProtrusionBlend(IFeatureManagerObject IFeatureManagerinstance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational, Double TessToleranceFactor, Int16 StartMatchingType, Int16 EndMatchingType, Double StartTangentLength, Double EndTangentLength, Boolean StartTangentDir, Boolean EndTangentDir, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType, Boolean Merge, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertProtrusionBlend(Closed, KeepTangency, ForceNonRational, TessToleranceFactor, StartMatchingType, EndMatchingType, StartTangentLength, EndTangentLength, StartTangentDir, EndTangentDir, IsThinBody, Thickness1, Thickness2, ThinType, Merge, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject InsertCutBlend(IFeatureManagerObject IFeatureManagerinstance, Boolean Closed, Boolean KeepTangency, Boolean ForceNonRational, Double TessToleranceFactor, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCutBlend(Closed, KeepTangency, ForceNonRational, TessToleranceFactor, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject HoleWizard(IFeatureManagerObject IFeatureManagerinstance, Int32 GenericHoleType, Int32 StandardIndex, Int32 FastenerTypeIndex, String SSize, Int16 EndType, Double Diameter, Double Depth, Double Value1, Double Value2, Double Value3, Double Value4, Double Value5, Double Value6, Double Value7, Double Value8, Double Value9, Double Value10, Double Value11, Double Value12)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.HoleWizard(GenericHoleType, StandardIndex, FastenerTypeIndex, SSize, EndType, Diameter, Depth, Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12));
        }
        public static IFeatureObject InsertMacroFeature(IFeatureManagerObject IFeatureManagerinstance, String BaseName, String ProgId, Object MacroMethods, Object ParamNames, Object ParamTypes, Object ParamValues, IBody2Object EditBody, Int32 Options)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMacroFeature(BaseName, ProgId, MacroMethods, ParamNames, ParamTypes, ParamValues, EditBody.IBody2Instance as Body2, Options));
        }
        //public static IFeatureObject IInsertMacroFeature(IFeatureManagerObject IFeatureManagerinstance, String BaseName, String ProgId, String& MacroMethods, Int32 ParamCount, String& ParamNames, Int32& ParamTypes, String& ParamValues, Body2Object EditBody, Int32 Options)
        //{
        //    return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.IInsertMacroFeature(BaseName, ProgId, MacroMethods, ParamCount, ParamNames, ParamTypes, ParamValues, EditBody, Options));
        //}
        public static void UpdateFeatureTree(IFeatureManagerObject IFeatureManagerinstance)
        {
            IFeatureManagerinstance.IFeatureManagerInstance.UpdateFeatureTree();
        }
        public static Boolean InsertFeatureTreeFolder(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.InsertFeatureTreeFolder();
        }
        public static IFeatureObject InsertSheetMetalCornerTrim(IFeatureManagerObject IFeatureManagerinstance, Int32 InternalCornerFlag, Int32 BreakType, Double BreakDist, Int32 ReliefType, Double Param)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSheetMetalCornerTrim(InternalCornerFlag, BreakType, BreakDist, ReliefType, Param));
        }
        public static IFeatureObject InsertFillSurface(IFeatureManagerObject IFeatureManagerinstance, Int32 Resolution)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertFillSurface(Resolution));
        }
        public static Boolean EditRollback(IFeatureManagerObject IFeatureManagerinstance, Int32 Location, String Feature)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.EditRollback(Location, Feature);
        }
        public static IFeatureObject InsertSheetMetalLoftedBend(IFeatureManagerObject IFeatureManagerinstance, Int32 ThickDirType, Double Thickness)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSheetMetalLoftedBend(ThickDirType, Thickness));
        }
        public static void MakeStyledCurves(IFeatureManagerObject IFeatureManagerinstance, Double Tol, Int32 Mode)
        {
            IFeatureManagerinstance.IFeatureManagerInstance.MakeStyledCurves(Tol, Mode);
        }
        public static void HideBodies(IFeatureManagerObject IFeatureManagerinstance)
        {
            IFeatureManagerinstance.IFeatureManagerInstance.HideBodies();
        }
        public static void ShowBodies(IFeatureManagerObject IFeatureManagerinstance)
        {
            IFeatureManagerinstance.IFeatureManagerInstance.ShowBodies();
        }
        public static IFeatureObject InsertMirrorFeature(IFeatureManagerObject IFeatureManagerinstance, Boolean BMirrorBody, Boolean BGeometryPattern, Boolean BMerge, Boolean BKnit)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMirrorFeature(BMirrorBody, BGeometryPattern, BMerge, BKnit));
        }
        public static IFeatureObject InsertMoveCopyBody(IFeatureManagerObject IFeatureManagerinstance, Double TransX, Double TransY, Double TransZ, Double TransDist, Double RotPointX, Double RotPointY, Double RotPointZ, Double RotAngleX, Double RotAngleY, Double RotAngleZ, Boolean BCopy, Int32 NumCopies)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMoveCopyBody(TransX, TransY, TransZ, TransDist, RotPointX, RotPointY, RotPointZ, RotAngleX, RotAngleY, RotAngleZ, BCopy, NumCopies));
        }
        public static IFeatureObject InsertCombineFeature(IFeatureManagerObject IFeatureManagerinstance, Int32 OperationType, IBody2Object MainBody, Object ToolVar)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCombineFeature(OperationType, MainBody.IBody2Instance as Body2, ToolVar));
        }
        //public static IFeatureObject IInsertCombineFeature(IFeatureManagerObject IFeatureManagerinstance, Int32 OperationType, IBody2Object MainBody, Int32 ToolsCount, Body2&Object ToolsArr)
        //{
        //    return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.IInsertCombineFeature(OperationType, MainBody.IBody2Instance as Body2, ToolsCount, ToolsArr));
        //}
        public static IFeatureObject InsertDwgOrDxfFile(IFeatureManagerObject IFeatureManagerinstance, String FileName)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertDwgOrDxfFile(FileName));
        }
        public static IFeatureObject FeatureLinearPattern(IFeatureManagerObject IFeatureManagerinstance, Int32 Num1, Double Spacing1, Int32 Num2, Double Spacing2, Boolean FlipDir1, Boolean FlipDir2, String DName1, String DName2)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureLinearPattern(Num1, Spacing1, Num2, Spacing2, FlipDir1, FlipDir2, DName1, DName2));
        }
        public static IFeatureObject FeatureCircularPattern(IFeatureManagerObject IFeatureManagerinstance, Int32 Num, Double Spacing, Boolean FlipDir, String DName)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureCircularPattern(Num, Spacing, FlipDir, DName));
        }
        public static IFeatureObject InsertTableDrivenPattern(IFeatureManagerObject IFeatureManagerinstance, String FileName, Object PointVar, Boolean UseCentrod, Boolean GeomPatt)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertTableDrivenPattern(FileName, PointVar, UseCentrod, GeomPatt));
        }
        //public static IFeatureObject IInsertTableDrivenPattern(IFeatureManagerObject IFeatureManagerinstance, String FileName, Int32 Count, Double& PointArr, Boolean UseCentrod, Boolean GeomPatt)
        //{
        //    return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.IInsertTableDrivenPattern(FileName, Count, PointArr, UseCentrod, GeomPatt));
        //}
        public static String InsertCosmeticThread(IFeatureManagerObject IFeatureManagerinstance, Int16 Type, Double Depth, Double Length, String Note)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.InsertCosmeticThread(Type, Depth, Length, Note);
        }
        public static IFeatureObject InsertScale(IFeatureManagerObject IFeatureManagerinstance, Int16 Type, Boolean Uniform, Double Xscale, Double YScale, Double ZScale)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertScale(Type, Uniform, Xscale, YScale, ZScale));
        }
        public static IFeatureObject InsertFeatureTreeFolder2(IFeatureManagerObject IFeatureManagerinstance, Int32 Type)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertFeatureTreeFolder2(Type));
        }
        public static IFeatureObject InsertMoveCopyBody2(IFeatureManagerObject IFeatureManagerinstance, Double TransX, Double TransY, Double TransZ, Double TransDist, Double RotPointX, Double RotPointY, Double RotPointZ, Double RotAngleX, Double RotAngleY, Double RotAngleZ, Boolean BCopy, Int32 NumCopies)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMoveCopyBody2(TransX, TransY, TransZ, TransDist, RotPointX, RotPointY, RotPointZ, RotAngleX, RotAngleY, RotAngleZ, BCopy, NumCopies));
        }
        public static IFeatureObject FeatureSketchDrivenPattern(IFeatureManagerObject IFeatureManagerinstance, Boolean UseCentroid, Boolean BGeomPatt)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureSketchDrivenPattern(UseCentroid, BGeomPatt));
        }
        public static IFeatureObject InsertDerivedPattern(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertDerivedPattern());
        }
        public static IFeatureObject InsertGussetFeature(IFeatureManagerObject IFeatureManagerinstance, Double Depth, Int16 DirType, Int16 LocType, Boolean BIsProfile, Double ProfileD1, Double ProfileD2, Double ProfileD3, Double ProfileAngle, Double ProfileD4, Boolean BOffset, Double DProfileOffset, Int32 CrvIndex, Boolean BReverseDir, Boolean BReverseFace, Boolean BUseLenDim)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertGussetFeature(Depth, DirType, LocType, BIsProfile, ProfileD1, ProfileD2, ProfileD3, ProfileAngle, ProfileD4, BOffset, DProfileOffset, CrvIndex, BReverseDir, BReverseFace, BUseLenDim));
        }
        public static IFeatureObject InsertSubWeldFolder(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSubWeldFolder());
        }
        public static IFeatureObject InsertMoldPartingLine(IFeatureManagerObject IFeatureManagerinstance, Boolean BFlipDir)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMoldPartingLine(BFlipDir));
        }
        public static IFeatureObject InsertMoldShutOffSurface(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMoldShutOffSurface());
        }
        public static IFeatureObject InsertWeldmentFeature(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertWeldmentFeature());
        }
        public static IFeatureObject InsertMultiFaceDraft(IFeatureManagerObject IFeatureManagerinstance, Double Angle, Boolean FlipDir, Boolean EdgeDraft, Int32 PropType, Boolean IsStepDraft, Boolean IsBodyDraft)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMultiFaceDraft(Angle, FlipDir, EdgeDraft, PropType, IsStepDraft, IsBodyDraft));
        }
        public static IFeatureObject InsertRuledSurfaceFromEdge(IFeatureManagerObject IFeatureManagerinstance, Int32 Type, Double Length, Boolean FlipPullDir, Boolean FlipDir, Boolean TrimAndSew, Double Angle, Boolean CoordInput, Double X, Double Y, Double Z)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertRuledSurfaceFromEdge(Type, Length, FlipPullDir, FlipDir, TrimAndSew, Angle, CoordInput, X, Y, Z));
        }
        public static Boolean MakeStyledCurves2(IFeatureManagerObject IFeatureManagerinstance, Double Tolerance, Int32 Mode)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.MakeStyledCurves2(Tolerance, Mode);
        }
        public static Boolean InsertSaveOutBodies(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.InsertSaveOutBodies();
        }
        public static IFeatureObject InsertMoldCoreCavitySolids(IFeatureManagerObject IFeatureManagerinstance, Double Dist1, Double Dist2, Boolean Setback, Double Angle)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMoldCoreCavitySolids(Dist1, Dist2, Setback, Angle));
        }
        public static IFeatureObject InsertMacroFeature2(IFeatureManagerObject IFeatureManagerinstance, String BaseName, String ProgId, Object MacroMethods, Object ParamNames, Object ParamTypes, Object ParamValues, Object DimTypes, Object DimValues, IBody2Object EditBody, Object IconFiles, Int32 Options)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMacroFeature2(BaseName, ProgId, MacroMethods, ParamNames, ParamTypes, ParamValues, DimTypes, DimValues, EditBody.IBody2Instance as Body2, IconFiles, Options));
        }
        //public static IFeatureObject IInsertMacroFeature2(IFeatureManagerObject IFeatureManagerinstance, String BaseName, String ProgId, String& MacroMethods, Int32 ParamCount, String& ParamNames, Int32& ParamTypes, String& ParamValues, Int32 DimCount, Int32& DimTypes, Double& DimCountValues, Body2Object EditBody, Int32 IconCount, String& IconFiles, Int32 Options)
        //{
        //    return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.IInsertMacroFeature2(BaseName, ProgId, MacroMethods, ParamCount, ParamNames, ParamTypes, ParamValues, DimCount, DimTypes, DimCountValues, EditBody, IconCount, IconFiles, Options));
        //}
        public static void MoldUndercutDetect(IFeatureManagerObject IFeatureManagerinstance, Int32 ColUndercut, Int32 ColBase, Boolean BCoordInput, Double Dx, Double Dy, Double Dz)
        {
            IFeatureManagerinstance.IFeatureManagerInstance.MoldUndercutDetect(ColUndercut, ColBase, BCoordInput, Dx, Dy, Dz);
        }
        public static Boolean PreTrimSurface(IFeatureManagerObject IFeatureManagerinstance, Boolean BMutualTrimIn, Boolean BSplitSystemIn, Boolean BSplitLinearIn, Boolean BRemovePickedIn)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.PreTrimSurface(BMutualTrimIn, BSplitSystemIn, BSplitLinearIn, BRemovePickedIn);
        }
        public static IFeatureObject PostTrimSurface(IFeatureManagerObject IFeatureManagerinstance, Boolean BSewSurfaceIn)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.PostTrimSurface(BSewSurfaceIn));
        }
        public static IFeatureObject InsertStructuralWeldment(IFeatureManagerObject IFeatureManagerinstance, String Path, Int32 EndCond, Double Angle)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertStructuralWeldment(Path, EndCond, Angle));
        }
        public static IFeatureObject InsertWeldmentTrimFeature(IFeatureManagerObject IFeatureManagerinstance, Int32 EndCond)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertWeldmentTrimFeature(EndCond));
        }
        public static IFeatureObject InsertWrapFeature(IFeatureManagerObject IFeatureManagerinstance, Int32 Type, Double Thickness, Boolean ReverseDir)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertWrapFeature(Type, Thickness, ReverseDir));
        }
        public static IFeatureObject InsertFilletBeadFeature(IFeatureManagerObject IFeatureManagerinstance, Int16 Type1, Double Size1, Double Length1, Double Pitch, Int16 Type2, Double Size2, Double Length2, Int32 Flag, Int32 EdgeNum1, Object DeSelEdge1, Int32 EdgeNum2, Object DeSelEdge2)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertFilletBeadFeature(Type1, Size1, Length1, Pitch, Type2, Size2, Length2, Flag, EdgeNum1, DeSelEdge1, EdgeNum2, DeSelEdge2));
        }
        public static IFeatureObject InsertEndCapFeature(IFeatureManagerObject IFeatureManagerinstance, Double Depth, Boolean BIsGivenOffset, Boolean BIsChamfer, Double OffsetValue, Double WallThicknessRatio, Double ChamferValue)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertEndCapFeature(Depth, BIsGivenOffset, BIsChamfer, OffsetValue, WallThicknessRatio, ChamferValue));
        }
        public static Object InsertReferencePoint(IFeatureManagerObject IFeatureManagerinstance, Int32 NRefPointType, Int32 NRefPointAlongCurveType, Double DDistance_or_Percent, Int32 NumberOfRefPoints)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.InsertReferencePoint(NRefPointType, NRefPointAlongCurveType, DDistance_or_Percent, NumberOfRefPoints);
        }
        public static IFeatureObject IInsertReferencePoint(IFeatureManagerObject IFeatureManagerinstance, Int32 NRefPointType, Int32 NRefPointAlongCurveType, Double DDistance_or_Percent, Int32 NumberOfRefPoints)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.IInsertReferencePoint(NRefPointType, NRefPointAlongCurveType, DDistance_or_Percent, NumberOfRefPoints));
        }
        public static IFeatureObject InsertProtrusionSwept2(IFeatureManagerObject IFeatureManagerinstance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType, Int16 PathAlign, Boolean Merge, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertProtrusionSwept2(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType, PathAlign, Merge, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject InsertCutSwept2(IFeatureManagerObject IFeatureManagerinstance, Boolean Propagate, Boolean Alignment, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType, Boolean IsThinBody, Double Thickness1, Double Thickness2, Int16 ThinType, Int16 PathAlign, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCutSwept2(Propagate, Alignment, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType, IsThinBody, Thickness1, Thickness2, ThinType, PathAlign, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject InsertSweepSurface(IFeatureManagerObject IFeatureManagerinstance, Boolean Propagate, Int16 TwistCtrlOption, Boolean KeepTangency, Boolean ForceNonRational, Int16 StartMatchingType, Int16 EndMatchingType, Int16 PathAlign)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSweepSurface(Propagate, TwistCtrlOption, KeepTangency, ForceNonRational, StartMatchingType, EndMatchingType, PathAlign));
        }
        public static IFeatureObject SimpleHole(IFeatureManagerObject IFeatureManagerinstance, Double Dia, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean UseFeatScope, Boolean UseAutoSelect)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.SimpleHole(Dia, Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, UseFeatScope, UseAutoSelect));
        }
        public static IFeatureObject InsertMoldPartingSurface(IFeatureManagerObject IFeatureManagerinstance, Int32 Radiate, Boolean ReverseAlignment, Boolean ReverseOffset, Double OffsetDistance, Double Angle, Int32 Smooth, Double SmoothDistance, Boolean Knit)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertMoldPartingSurface(Radiate, ReverseAlignment, ReverseOffset, OffsetDistance, Angle, Smooth, SmoothDistance, Knit));
        }
        public static IFeatureObject InsertRuledSurfaceFromEdge2(IFeatureManagerObject IFeatureManagerinstance, Int32 Type, Double Length, Boolean FlipPullDir, Boolean FlipDir, Boolean TrimAndSew, Double Angle, Boolean CoordInput, Double X, Double Y, Double Z, Boolean BConnectSurface)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertRuledSurfaceFromEdge2(Type, Length, FlipPullDir, FlipDir, TrimAndSew, Angle, CoordInput, X, Y, Z, BConnectSurface));
        }
        public static IFeatureObject InsertWeldmentCutList(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertWeldmentCutList());
        }
        public static IFeatureObject InsertUntrimSurface(IFeatureManagerObject IFeatureManagerinstance, Int32 FaceUntrimType, Int32 EdgeUntrimType, Double Distance, Boolean BMerge)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertUntrimSurface(FaceUntrimType, EdgeUntrimType, Distance, BMerge));
        }
        public static IFeatureObject InsertCosmeticThread2(IFeatureManagerObject IFeatureManagerinstance, Int16 Type, Double Depth, Double Length, String Note)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertCosmeticThread2(Type, Depth, Length, Note));
        }
        public static IFeatureObject InsertStructuralWeldment2(IFeatureManagerObject IFeatureManagerinstance, String Path, Int32 EndCond, Double Angle, Boolean Merge)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertStructuralWeldment2(Path, EndCond, Angle, Merge));
        }
        public static IFeatureObject InsertSheetMetalMiterFlange(IFeatureManagerObject IFeatureManagerinstance, Boolean UseDefaultRadius, Double GlobalRadius, Double RipGap, Boolean UseDefaultRelief, Boolean UseReliefRatio, Double ReliefRatio, Double ReliefWidth, Double ReliefDepth, Int32 ReliefType, Boolean TrimSideBends, Int32 FlangePos, Double OffsetDist1, Double OffsetDist2, ICustomBendAllowanceObject PCBA)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSheetMetalMiterFlange(UseDefaultRadius, GlobalRadius, RipGap, UseDefaultRelief, UseReliefRatio, ReliefRatio, ReliefWidth, ReliefDepth, ReliefType, TrimSideBends, FlangePos, OffsetDist1, OffsetDist2, PCBA.ICustomBendAllowanceInstance as CustomBendAllowance));
        }
        public static IFeatureObject InsertSubFolder(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureObject(IFeatureManagerinstance.IFeatureManagerInstance.InsertSubFolder());
        }
        public static Boolean EnableFeatureTree(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.EnableFeatureTree;
        }
        public static Boolean ShowFeatureName(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.ShowFeatureName;
        }
        public static Boolean ShowFeatureDescription(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.ShowFeatureDescription;
        }
        public static IModelDoc2Object Document(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IModelDoc2Object(IFeatureManagerinstance.IFeatureManagerInstance.Document);
        }
        public static String FeatureName(IFeatureManagerObject IFeatureManagerinstance, int NameID)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.FeatureName[NameID];
        }
        public static Boolean EnableFeatureTreeWindow(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.EnableFeatureTreeWindow;
        }
        public static Boolean ShowComponentNames(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.ShowComponentNames;
        }
        public static Boolean ShowComponentDescriptions(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.ShowComponentDescriptions;
        }
        public static Boolean ShowComponentConfigurationNames(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.ShowComponentConfigurationNames;
        }
        public static Boolean ShowComponentConfigurationDescriptions(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.ShowComponentConfigurationDescriptions;
        }
        public static Boolean MoveSizeFeatures(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.MoveSizeFeatures;
        }
        public static IFeatureStatisticsObject FeatureStatistics(IFeatureManagerObject IFeatureManagerinstance)
        {
            return new IFeatureStatisticsObject(IFeatureManagerinstance.IFeatureManagerInstance.FeatureStatistics);
        }
        public static Boolean ViewDependencies(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.ViewDependencies;
        }
        public static Boolean ViewFeatures(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.ViewFeatures;
        }
        public static Boolean ShowHierarchyOnly(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.ShowHierarchyOnly;
        }
        public static Boolean ShowFeatureDetails(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.ShowFeatureDetails;
        }
        public static Boolean ShowDisplayStateNames(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.ShowDisplayStateNames;
        }
        public static Boolean SolidForTrim(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.SolidForTrim;
        }
        public static Boolean GroupComponentInstances(IFeatureManagerObject IFeatureManagerinstance)
        {
            return IFeatureManagerinstance.IFeatureManagerInstance.GroupComponentInstances;
        }
    }
}