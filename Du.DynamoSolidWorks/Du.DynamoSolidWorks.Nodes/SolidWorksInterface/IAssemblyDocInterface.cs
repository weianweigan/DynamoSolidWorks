using Autodesk.DesignScript.Runtime;
using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;

namespace DynamoSolidWorks
{
    public class IAssemblyDocObject
    {
        public IAssemblyDoc IAssemblyDocInstance { get; set; }
        public IAssemblyDocObject(IAssemblyDoc IAssemblyDocinstance)
        {
            IAssemblyDocInstance = IAssemblyDocinstance;
        }
    }
    public static class IAssemblyDocInterface
    {
        public static int EditMate4(IAssemblyDocObject IAssemblyDocinstance, Int32 MateTypeFromEnum, Int32 AlignFromEnum, Boolean Flip, Double Distance, Double DistanceAbsUpperLimit, Double DistanceAbsLowerLimit, Double GearRatioNumerator, Double GearRatioDenominator, Double Angle, Double AngleAbsUpperLimit, Double AngleAbsLowerLimit, Boolean ForPositioningOnly, Boolean LockRotation, Int32 WidthMateOption, Boolean RepairMatesWithSameMissingEntity)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.EditMate4(MateTypeFromEnum, AlignFromEnum, Flip, Distance, DistanceAbsUpperLimit, DistanceAbsLowerLimit, GearRatioNumerator, GearRatioDenominator, Angle, AngleAbsUpperLimit, AngleAbsLowerLimit, ForPositioningOnly, LockRotation, WidthMateOption, RepairMatesWithSameMissingEntity, out int ErrorStatus);
            return ErrorStatus;
        }
        public static Object GetComponentByID(IAssemblyDocObject IAssemblyDocinstance, Int32 ID)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetComponentByID(ID);
        }
        public static void TemporaryFixGroup(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.TemporaryFixGroup();
        }
        public static void TemporaryFixGroupExit(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.TemporaryFixGroupExit();
        }
        public static Boolean CopyWithMates2(IAssemblyDocObject IAssemblyDocinstance, Object ComponentsToCopy, Object Repeat, Object NewEnityToMateTo, Object Values, Object FlipAlignment, Object FlipDimension, Object LockRotation, Object Orientation)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.CopyWithMates2(ComponentsToCopy, Repeat, NewEnityToMateTo, Values, FlipAlignment, FlipDimension, LockRotation, Orientation);
        }
        public static Object MirrorComponents3(IAssemblyDocObject IAssemblyDocinstance, Object MirrorPlane, Object ComponentsToInstance, Object ComponentOrientations, Boolean OrientAboutCenterOfMass, Object ComponentsToMirror, Boolean CreateDerivedConfigurations, Object MirroredComponentFilenames, Int32 NameModifierType, String NameModifier, String MirroredComponentFileLocation, Int32 ImportOptions, Boolean BreakLinks, Boolean PreserveZAxis, Boolean SyncFlexibleSubAssemblies)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.MirrorComponents3(MirrorPlane, ComponentsToInstance, ComponentOrientations, OrientAboutCenterOfMass, ComponentsToMirror, CreateDerivedConfigurations, MirroredComponentFilenames, NameModifierType, NameModifier, MirroredComponentFileLocation, ImportOptions, BreakLinks, PreserveZAxis, SyncFlexibleSubAssemblies);
        }
        public static Object GetExplodedViewNames2(IAssemblyDocObject IAssemblyDocinstance, String ConfigurationName)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetExplodedViewNames2(ConfigurationName);
        }
        public static Int32 GetExplodedViewCount2(IAssemblyDocObject IAssemblyDocinstance, String ConfigurationName)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetExplodedViewCount2(ConfigurationName);
        }
        public static String GetExplodedViewConfigurationName(IAssemblyDocObject IAssemblyDocinstance, String ExplodedViewName)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetExplodedViewConfigurationName(ExplodedViewName);
        }
        public static Boolean DeleteSelections(IAssemblyDocObject IAssemblyDocinstance, Int32 DeleteOptions)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.DeleteSelections(DeleteOptions);
        }
        public static Boolean MakeIndependent(IAssemblyDocObject IAssemblyDocinstance, String FileName)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.MakeIndependent(FileName);
        }
        public static Boolean Isolate(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.Isolate();
        }
        public static Boolean ExitIsolate(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.ExitIsolate();
        }
        public static void SetIsolateVisibility(IAssemblyDocObject IAssemblyDocinstance, Int32 Option)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.SetIsolateVisibility(Option);
        }
        public static Boolean SaveIsolate(IAssemblyDocObject IAssemblyDocinstance, String Name)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.SaveIsolate(Name);
        }
        public static Boolean CompConfigProperties5(IAssemblyDocObject IAssemblyDocinstance, Int32 Suppression, Int32 Solving, Boolean Visibility, Boolean UseNamedRefConfig, String RefConfigName, Boolean ExcludeFromBOM, Boolean IsEnvelope)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.CompConfigProperties5(Suppression, Solving, Visibility, UseNamedRefConfig, RefConfigName, ExcludeFromBOM, IsEnvelope);
        }
        public static Boolean ReplaceComponents2(IAssemblyDocObject IAssemblyDocinstance, String FileName, String ConfigName, Boolean ReplaceAllInstance, Int32 UseConfigChoice, Boolean ReAttachMates)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.ReplaceComponents2(FileName, ConfigName, ReplaceAllInstance, UseConfigChoice, ReAttachMates);
        }
        public static Int32 UpdateToolboxComponent(IAssemblyDocObject IAssemblyDocinstance, Int32 AssemblyLevelToUpdate)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.UpdateToolboxComponent(AssemblyLevelToUpdate);
        }
        public static Boolean CreateSpeedPak(IAssemblyDocObject IAssemblyDocinstance, Int32 SpeedPakType)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.CreateSpeedPak(SpeedPakType);
        }
        public static Boolean UpdateSpeedPak(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.UpdateSpeedPak();
        }
        public static Boolean SetSpeedPakToParent(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.SetSpeedPakToParent();
        }
        public static Boolean UseSpeedPak(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.UseSpeedPak();
        }
        public static Boolean SetSpeedPakConfigurations(IAssemblyDocObject IAssemblyDocinstance, Int32 Config_opt, Object Config_names)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.SetSpeedPakConfigurations(Config_opt, Config_names);
        }
        public static Boolean UngroupComponents(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.UngroupComponents();
        }

        [MultiReturn(SWValueConst.MateObject, SWValueConst.ErrorStatus)]
        public static Dictionary<string, object> AddConcentricMateWithTolerance(IAssemblyDocObject IAssemblyDocinstance, Int32 AlignFromEnum, Int32 ConcentricPositionType, Boolean ConcentricToleranceCheck, Double ConcentricToleranceValue)
        {
            var obj = new IMate2Object(IAssemblyDocinstance.IAssemblyDocInstance.AddConcentricMateWithTolerance(AlignFromEnum, ConcentricPositionType, ConcentricToleranceCheck, ConcentricToleranceValue, out int ErrorStatus));
            return new Dictionary<string, object>() { { SWValueConst.MateObject, obj }, { SWValueConst.ErrorStatus, ErrorStatus } };
        }
        public static int EditConcentricMate(IAssemblyDocObject IAssemblyDocinstance, Int32 AlignFromEnum, Int32 ConcentricPositionType, Boolean ConcentricToleranceCheck, Double ConcentricToleranceValue)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.EditConcentricMate(AlignFromEnum, ConcentricPositionType, ConcentricToleranceCheck, ConcentricToleranceValue, out int ErrorStatus);
            return ErrorStatus;
        }

        [MultiReturn(SWValueConst.MateObject, SWValueConst.ErrorStatus)]
        public static Dictionary<string, object> AddDistanceMate(IAssemblyDocObject IAssemblyDocinstance, Int32 AlignFromEnum, Boolean Flip, Double Distance, Double DistanceAbsUpperLimit, Double DistanceAbsLowerLimit, Int32 FirstArcCondition, Int32 SecondArcCondition)
        {
            var obj = (IAssemblyDocinstance.IAssemblyDocInstance.AddDistanceMate(AlignFromEnum, Flip, Distance, DistanceAbsUpperLimit, DistanceAbsLowerLimit, FirstArcCondition, SecondArcCondition, out int ErrorStatus));

            return new Dictionary<string, object>() { { SWValueConst.MateObject, obj }, { SWValueConst.ErrorStatus, ErrorStatus } };
        }
        public static int EditDistanceMate(IAssemblyDocObject IAssemblyDocinstance, Int32 AlignFromEnum, Boolean Flip, Double Distance, Double DistanceAbsUpperLimit, Double DistanceAbsLowerLimit, Int32 FirstArcCondition, Int32 SecondArcCondition)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.EditDistanceMate(AlignFromEnum, Flip, Distance, DistanceAbsUpperLimit, DistanceAbsLowerLimit, FirstArcCondition, SecondArcCondition, out int ErrorStatus);
            return ErrorStatus;
        }
        public static Object CreateMateData(IAssemblyDocObject IAssemblyDocinstance, Int32 Type)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.CreateMateData(Type);
        }
        public static Object CreateMate(IAssemblyDocObject IAssemblyDocinstance, Object MateData)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.CreateMate(MateData);
        }
        public static Boolean ActivateGroundPlane(IAssemblyDocObject IAssemblyDocinstance, Int32 Config_opt, Object Config_names)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.ActivateGroundPlane(Config_opt, Config_names);
        }
        public static Object GetActiveGroundPlane(IAssemblyDocObject IAssemblyDocinstance, Int32 Config_opt, Object Config_names)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetActiveGroundPlane(Config_opt, Config_names);
        }
        public static Boolean SetComponentState(IAssemblyDocObject IAssemblyDocinstance, Int32 SuppressionState, Object CompArr, Int32 ConfigOption, String WhichConfig, Boolean SaveClosedDocs)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.SetComponentState(SuppressionState, CompArr, ConfigOption, WhichConfig, SaveClosedDocs);
        }

        //Ref²ÎÊý,ÔÝÎ´ÐÞ¸Ä
        public static Boolean ISetComponentState(IAssemblyDocObject IAssemblyDocinstance, Int32 SuppressionState, Int32 NumComps, Component2 CompArr, Int32 ConfigOption, String WhichConfig, Boolean SaveClosedDocs)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.ISetComponentState(SuppressionState, NumComps, CompArr, ConfigOption, WhichConfig, SaveClosedDocs);
        }
        public static Boolean ReplaceComponents(IAssemblyDocObject IAssemblyDocinstance, String FileName, String ConfigName, Boolean ReplaceAllInstance, Boolean ReAttachMates)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.ReplaceComponents(FileName, ConfigName, ReplaceAllInstance, ReAttachMates);
        }
        public static Object GetVisibleComponentsInView(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetVisibleComponentsInView();
        }
        public static Int32 GetVisibleComponentsInViewCount(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetVisibleComponentsInViewCount();
        }
        public static IComponent2Object IGetVisibleComponentsInView(IAssemblyDocObject IAssemblyDocinstance, Int32 Count)
        {
            return new IComponent2Object(IAssemblyDocinstance.IAssemblyDocInstance.IGetVisibleComponentsInView(Count));
        }
        public static void MakeLightWeight(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.MakeLightWeight();
        }
        public static Object GetBox(IAssemblyDocObject IAssemblyDocinstance, Int32 Options)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetBox(Options);
        }
        public static Double IGetBox(IAssemblyDocObject IAssemblyDocinstance, Int32 Options)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.IGetBox(Options);
        }
        public static Int32 GetFeatureScopeCount(IAssemblyDocObject IAssemblyDocinstance, IFeatureObject FeatureIn)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetFeatureScopeCount(FeatureIn.IFeatureInstance as Feature);
        }
        public static Object GetFeatureScope(IAssemblyDocObject IAssemblyDocinstance, IFeatureObject FeatureIn)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetFeatureScope(FeatureIn.IFeatureInstance as Feature);
        }
        public static IComponent2Object IGetFeatureScope(IAssemblyDocObject IAssemblyDocinstance, IFeatureObject FeatureIn, Int32 NumComponents)
        {
            return new IComponent2Object(IAssemblyDocinstance.IAssemblyDocInstance.IGetFeatureScope(FeatureIn.IFeatureInstance as Feature, NumComponents));
        }
        public static IComponent2Object AddComponent4(IAssemblyDocObject IAssemblyDocinstance, String CompName, String ConfigName, Double X, Double Y, Double Z)
        {
            return new IComponent2Object(IAssemblyDocinstance.IAssemblyDocInstance.AddComponent4(CompName, ConfigName, X, Y, Z));
        }
        public static Int32 InsertNewPart2(IAssemblyDocObject IAssemblyDocinstance, String FilePathIn, Object Face_or_Plane_to_select)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.InsertNewPart2(FilePathIn, Face_or_Plane_to_select);
        }

        [MultiReturn(SWValueConst.MateObject, SWValueConst.ErrorStatus)]
        public static Dictionary<string, object> AddMate2(IAssemblyDocObject IAssemblyDocinstance, Int32 MateTypeFromEnum, Int32 AlignFromEnum, Boolean Flip, Double Distance, Double DistanceAbsUpperLimit, Double DistanceAbsLowerLimit, Double GearRatioNumerator, Double GearRatioDenominator, Double Angle, Double AngleAbsUpperLimit, Double AngleAbsLowerLimit)
        {
            var obj = new IMate2Object(IAssemblyDocinstance.IAssemblyDocInstance.AddMate2(MateTypeFromEnum, AlignFromEnum, Flip, Distance, DistanceAbsUpperLimit, DistanceAbsLowerLimit, GearRatioNumerator, GearRatioDenominator, Angle, AngleAbsUpperLimit, AngleAbsLowerLimit, out int ErrorStatus));

            return new Dictionary<string, object>() { { SWValueConst.MateObject, obj }, { SWValueConst.ErrorStatus, ErrorStatus } };
        }


        public static int EditMate2(IAssemblyDocObject IAssemblyDocinstance, Int32 MateTypeFromEnum, Int32 AlignFromEnum, Boolean Flip, Double Distance, Double DistanceAbsUpperLimit, Double DistanceAbsLowerLimit, Double GearRatioNumerator, Double GearRatioDenominator, Double Angle, Double AngleAbsUpperLimit, Double AngleAbsLowerLimit)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.EditMate2(MateTypeFromEnum, AlignFromEnum, Flip, Distance, DistanceAbsUpperLimit, DistanceAbsLowerLimit, GearRatioNumerator, GearRatioDenominator, Angle, AngleAbsUpperLimit, AngleAbsLowerLimit, out int ErrorStatus);
            return ErrorStatus;
        }
        public static Boolean DissolveComponentPattern(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.DissolveComponentPattern();
        }
        //public static void GetPhysicalSimulationComponents(IAssemblyDocObject IAssemblyDocinstance, Double InDuration, Int32& OutCount, Object& OutComponents, Object& OutTransforms, Object& OutStepStartTimes, Object& OutStepDurations, Double& OutTotalPhysSimDuration)
        //{
        //    return IAssemblyDocinstance.IAssemblyDocInstance.GetPhysicalSimulationComponents(InDuration, OutCount, OutComponents, OutTransforms, OutStepStartTimes, OutStepDurations, OutTotalPhysSimDuration);
        //}

        public static void SetComponentVisibility(IAssemblyDocObject IAssemblyDocinstance, Boolean Visibility, Int32 Config_opt, Object Config_names)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.SetComponentVisibility(Visibility, Config_opt, Config_names);
        }
        public static string ISetComponentVisibility(IAssemblyDocObject IAssemblyDocinstance, Boolean Visibility, Int32 Config_opt, Int32 Config_count, string Config_names)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.ISetComponentVisibility(Visibility, Config_opt, Config_count, Config_names);
            return Config_names;
        }
        public static void ForceUpdateElectricalData(IAssemblyDocObject IAssemblyDocinstance, Int32 Stream)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.ForceUpdateElectricalData(Stream);
        }
        public static Boolean CompConfigProperties4(IAssemblyDocObject IAssemblyDocinstance, Int32 Suppression, Int32 Solving, Boolean Visibility, Boolean UseNamedRefConfig, String RefConfigName, Boolean ExcludeFromBOM)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.CompConfigProperties4(Suppression, Solving, Visibility, UseNamedRefConfig, RefConfigName, ExcludeFromBOM);
        }
        public static IConfigurationObject AddComponentConfiguration(IAssemblyDocObject IAssemblyDocinstance, String Name, String Comment, String AlternateName, Int32 Options)
        {
            return new IConfigurationObject(IAssemblyDocinstance.IAssemblyDocInstance.AddComponentConfiguration(Name, Comment, AlternateName, Options));
        }

        [MultiReturn(SWValueConst.MateObject, SWValueConst.ErrorStatus)]
        public static Dictionary<string, object> AddMate3(IAssemblyDocObject IAssemblyDocinstance, Int32 MateTypeFromEnum, Int32 AlignFromEnum, Boolean Flip, Double Distance, Double DistanceAbsUpperLimit, Double DistanceAbsLowerLimit, Double GearRatioNumerator, Double GearRatioDenominator, Double Angle, Double AngleAbsUpperLimit, Double AngleAbsLowerLimit, Boolean ForPositioningOnly)
        {
            var obj = new IMate2Object(IAssemblyDocinstance.IAssemblyDocInstance.AddMate3(MateTypeFromEnum, AlignFromEnum, Flip, Distance, DistanceAbsUpperLimit, DistanceAbsLowerLimit, GearRatioNumerator, GearRatioDenominator, Angle, AngleAbsUpperLimit, AngleAbsLowerLimit, ForPositioningOnly, out int ErrorStatus));
            return new Dictionary<string, object>() { { SWValueConst.MateObject, obj }, { SWValueConst.ErrorStatus, ErrorStatus } };
        }
        public static Object GetRouteManager(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetRouteManager();
        }
        //public static ISimulationObject GetSimulation(IAssemblyDocObject IAssemblyDocinstance)
        //{
        //    return new ISimulationObject(IAssemblyDocinstance.IAssemblyDocInstance.GetSimulation());
        //}
        public static IAdvancedSelectionCriteriaObject GetAdvancedSelection(IAssemblyDocObject IAssemblyDocinstance)
        {
            return new IAdvancedSelectionCriteriaObject(IAssemblyDocinstance.IAssemblyDocInstance.GetAdvancedSelection());
        }
        public static IComponent2Object GetEditTargetComponent(IAssemblyDocObject IAssemblyDocinstance)
        {
            return new IComponent2Object(IAssemblyDocinstance.IAssemblyDocInstance.GetEditTargetComponent());
        }
        public static Int32 ForceUpdateElectricalData2(IAssemblyDocObject IAssemblyDocinstance, Int32 Stream)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.ForceUpdateElectricalData2(Stream);
        }
        public static Int32 GetComponentCount(IAssemblyDocObject IAssemblyDocinstance, Boolean ToplevelOnly)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetComponentCount(ToplevelOnly);
        }
        public static Object GetComponents(IAssemblyDocObject IAssemblyDocinstance, Boolean ToplevelOnly)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetComponents(ToplevelOnly);
        }
        public static IComponent2Object IGetComponents(IAssemblyDocObject IAssemblyDocinstance, Boolean ToplevelOnly, Int32 Count)
        {
            return new IComponent2Object(IAssemblyDocinstance.IAssemblyDocInstance.IGetComponents(ToplevelOnly, Count));
        }
        public static Boolean ResolveOutOfDateLightWeightComponents(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.ResolveOutOfDateLightWeightComponents();
        }
        public static IComponent2Object InsertEnvelope(IAssemblyDocObject IAssemblyDocinstance, String CompName, String ConfigName, Double X, Double Y, Double Z)
        {
            return new IComponent2Object(IAssemblyDocinstance.IAssemblyDocInstance.InsertEnvelope(CompName, ConfigName, X, Y, Z));
        }
        public static IMateLoadReferenceObject InsertLoadReference(IAssemblyDocObject IAssemblyDocinstance, IMate2Object Mate)
        {
            return new IMateLoadReferenceObject(IAssemblyDocinstance.IAssemblyDocInstance.InsertLoadReference(Mate.IMate2Instance as Mate2));
        }
        public static Boolean ResolveAllLightweight(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.ResolveAllLightweight();
        }
        public static Boolean LightweightAllResolved(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.LightweightAllResolved();
        }
        public static Boolean SetComponentSuppression(IAssemblyDocObject IAssemblyDocinstance, Int32 State)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.SetComponentSuppression(State);
        }
        public static Boolean SetComponentTransparent(IAssemblyDocObject IAssemblyDocinstance, Boolean State)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.SetComponentTransparent(State);
        }
        public static Boolean CreateSmartComponent(IAssemblyDocObject IAssemblyDocinstance, IComponent2Object ComponentIn, Object RelatedComponents, Object RelatedFeatures, Boolean AutoSizeDiameter, IEntityObject LpMateReference, Object BoundingValues)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.CreateSmartComponent(ComponentIn.IComponent2Instance as Component2, RelatedComponents, RelatedFeatures, AutoSizeDiameter, LpMateReference.IEntityInstance as Entity, BoundingValues);
        }
        public static Boolean IsRouteAssembly(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.IsRouteAssembly();
        }
        public static Boolean SetForceResetConfigName(IAssemblyDocObject IAssemblyDocinstance, Boolean Set)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.SetForceResetConfigName(Set);
        }
        public static Boolean ReorderComponents(IAssemblyDocObject IAssemblyDocinstance, Object Source, Object Target, Int32 Where)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.ReorderComponents(Source, Target, Where);
        }
        //ref not solve
        public static Boolean IReorderComponents(IAssemblyDocObject IAssemblyDocinstance, Int32 Count, IComponent2Object Source, Object Target, Int32 Where)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.IReorderComponents(Count, Source.IComponent2Instance as Component2, Target, Where);
        }
        public static Object MirrorComponents(IAssemblyDocObject IAssemblyDocinstance, Object Plane, Object ComponentsToInstance, Object ComponentsToMirror, Object MirroredComponentFilenames, Boolean RecreateMates, Int32 ComponentModifier, String ComponentNameModifier, String MirroredFileLocation, Boolean CopyCustomProperties)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.MirrorComponents(Plane, ComponentsToInstance, ComponentsToMirror, MirroredComponentFilenames, RecreateMates, ComponentModifier, ComponentNameModifier, MirroredFileLocation, CopyCustomProperties);
        }

        //ref not solve
        public static IComponent2Object IMirrorComponents(IAssemblyDocObject IAssemblyDocinstance, Object Plane, Int32 InstanceCount, IComponent2Object ComponentsToInstance, Int32 MirrorCount, IComponent2Object ComponentsToMirror, Int32 NameCount, String MirroredComponentFilenames, Boolean RecreateMates, Int32 ComponentModifier, String ComponentNameModifier, String MirroredFileLocation, Boolean CopyCustomProperties)
        {
            return new IComponent2Object(IAssemblyDocinstance.IAssemblyDocInstance.IMirrorComponents(Plane, InstanceCount, ComponentsToInstance.IComponent2Instance as Component2, MirrorCount, ComponentsToMirror.IComponent2Instance as Component2, NameCount, MirroredComponentFilenames, RecreateMates, ComponentModifier, ComponentNameModifier, MirroredFileLocation, CopyCustomProperties));
        }
        public static Boolean SetDroppedFileFeatureName(IAssemblyDocObject IAssemblyDocinstance, String FeatureName)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.SetDroppedFileFeatureName(FeatureName);
        }
        public static Boolean HasUnloadedComponents(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.HasUnloadedComponents();
        }

        [MultiReturn(SWValueConst.Result, SWValueConst.UnloadedComponentPathNames, SWValueConst.UnloadedComponentReferencedConfigurationNames, SWValueConst.ReasonForUnloadingComponents, SWValueConst.DocTypes)]
        public static Dictionary<string, object> GetUnloadedComponentNames(IAssemblyDocObject IAssemblyDocinstance)
        {
            var obj = IAssemblyDocinstance.IAssemblyDocInstance.GetUnloadedComponentNames(out object UnloadedComponentPathNames, out object UnloadedComponentReferencedConfigurationNames, out object ReasonForUnloadingComponents, out object DocTypes);
            return new Dictionary<string, object>() { { SWValueConst.Result,obj},{ SWValueConst.UnloadedComponentPathNames,UnloadedComponentPathNames },
                { SWValueConst.UnloadedComponentReferencedConfigurationNames,UnloadedComponentReferencedConfigurationNames},{SWValueConst.ReasonForUnloadingComponents,ReasonForUnloadingComponents},{SWValueConst.DocTypes,DocTypes} };
        }
        public static Boolean ReorganizeComponents(IAssemblyDocObject IAssemblyDocinstance, Object Source, Object Target)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.ReorganizeComponents(Source, Target);
        }

        //ref not solve
        public static Boolean IReorganizeComponents(IAssemblyDocObject IAssemblyDocinstance, Int32 Count, IComponent2Object Source, Object Target)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.IReorganizeComponents(Count, Source.IComponent2Instance as Component2, Target);
        }
        public static IComponent2Object GetComponentByName(IAssemblyDocObject IAssemblyDocinstance, String CompName)
        {
            return new IComponent2Object(IAssemblyDocinstance.IAssemblyDocInstance.GetComponentByName(CompName));
        }
        public static Boolean MakeAssemblyFromSelectedComponents(IAssemblyDocObject IAssemblyDocinstance, String FileName)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.MakeAssemblyFromSelectedComponents(FileName);
        }

        [MultiReturn(SWValueConst.Result, SWValueConst.InsertedComponent)]
        public static Dictionary<string, object> InsertNewVirtualPart(IAssemblyDocObject IAssemblyDocinstance, Object FaceOrPlaneToSelect)
        {
            var result = IAssemblyDocinstance.IAssemblyDocInstance.InsertNewVirtualPart(FaceOrPlaneToSelect, out Component2 InsertedComponent);
            return new Dictionary<string, object>() { { SWValueConst.Result, result }, { SWValueConst.InsertedComponent, new IComponent2Object(InsertedComponent) } };
        }

        [MultiReturn(SWValueConst.Result, SWValueConst.InsertedComponent)]
        public static Dictionary<string, object> InsertNewVirtualAssembly(IAssemblyDocObject IAssemblyDocinstance)
        {
            var result = IAssemblyDocinstance.IAssemblyDocInstance.InsertNewVirtualAssembly(out Component2 InsertedComponent);
            return new Dictionary<string, object>() { { SWValueConst.Result, result }, { SWValueConst.InsertedComponent, new IComponent2Object(InsertedComponent) } };
        }
        public static IComponent2Object AddSmartComponent(IAssemblyDocObject IAssemblyDocinstance, String CompName, Double X, Double Y, Double Z)
        {
            return new IComponent2Object(IAssemblyDocinstance.IAssemblyDocInstance.AddSmartComponent(CompName, X, Y, Z));
        }
        public static IComponent2Object AddComponent5(IAssemblyDocObject IAssemblyDocinstance, String CompName, Int32 ConfigOption, String NewConfigName, Boolean UseConfigForPartReferences, String ExistingConfigName, Double X, Double Y, Double Z)
        {
            return new IComponent2Object(IAssemblyDocinstance.IAssemblyDocInstance.AddComponent5(CompName, ConfigOption, NewConfigName, UseConfigForPartReferences, ExistingConfigName, X, Y, Z));
        }
        public static void InsertWeld2(IAssemblyDocObject IAssemblyDocinstance, String Type, String Shape, Double TopDelta, Double BottomDelta, Double Radius, String Part, Object TopFaces, Object StopFace, Object ContactFaces)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.InsertWeld2(Type, Shape, TopDelta, BottomDelta, Radius, Part, TopFaces, StopFace, ContactFaces);
        }
        public static Boolean CopyWithMates(IAssemblyDocObject IAssemblyDocinstance, Object ComponentsToCopy, Object Repeat, Object NewEnityToMateTo, Object Values, Object FlipAlignment)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.CopyWithMates(ComponentsToCopy, Repeat, NewEnityToMateTo, Values, FlipAlignment);
        }
        public static Object AddComponents3(IAssemblyDocObject IAssemblyDocinstance, Object Names, Object Transforms, Object CoordinateSystemNames)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.AddComponents3(Names, Transforms, CoordinateSystemNames);
        }

        //ref not slove
        public static IComponent2Object IAddComponents3(IAssemblyDocObject IAssemblyDocinstance, Int32 Count, String Names, Double Transforms, Int32 CoordinateSystemNameCount, String CoordinateSystemNames)
        {
            return new IComponent2Object(IAssemblyDocinstance.IAssemblyDocInstance.IAddComponents3(Count, Names, Transforms, CoordinateSystemNameCount, CoordinateSystemNames));
        }
        public static Int32 InsertNewAssembly(IAssemblyDocObject IAssemblyDocinstance, String FileName)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.InsertNewAssembly(FileName);
        }
        public static Boolean SelectiveOpen(IAssemblyDocObject IAssemblyDocinstance, Boolean SelectedComponents, Boolean OpenLightWeight)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.SelectiveOpen(SelectedComponents, OpenLightWeight);
        }
        public static Boolean CreateExplodedView(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.CreateExplodedView();
        }
        public static Boolean ShowExploded2(IAssemblyDocObject IAssemblyDocinstance, Boolean ShowIt, String ExplodeViewName)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.ShowExploded2(ShowIt, ExplodeViewName);
        }
        public static Object GetExplodedViewNames(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetExplodedViewNames();
        }
        public static Int32 GetExplodedViewCount(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetExplodedViewCount();
        }
        public static String IGetExplodedViewNames(IAssemblyDocObject IAssemblyDocinstance, Int32 Count)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.IGetExplodedViewNames(Count);
        }
        public static Boolean SelectComponentsBySize(IAssemblyDocObject IAssemblyDocinstance, Double Percent)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.SelectComponentsBySize(Percent);
        }

        [MultiReturn(SWValueConst.MateObject, SWValueConst.ErrorStatus)]
        public static Dictionary<string, object> AddMate4(IAssemblyDocObject IAssemblyDocinstance, Int32 MateTypeFromEnum, Int32 AlignFromEnum, Boolean Flip, Double Distance, Double DistanceAbsUpperLimit, Double DistanceAbsLowerLimit, Double GearRatioNumerator, Double GearRatioDenominator, Double Angle, Double AngleAbsUpperLimit, Double AngleAbsLowerLimit, Boolean ForPositioningOnly, Boolean LockRotation)
        {
            var obj = new IMate2Object(IAssemblyDocinstance.IAssemblyDocInstance.AddMate4(MateTypeFromEnum, AlignFromEnum, Flip, Distance, DistanceAbsUpperLimit, DistanceAbsLowerLimit, GearRatioNumerator, GearRatioDenominator, Angle, AngleAbsUpperLimit, AngleAbsLowerLimit, ForPositioningOnly, LockRotation, out int ErrorStatus));
            return new Dictionary<string, object>() { { SWValueConst.MateObject, obj }, { SWValueConst.ErrorStatus, ErrorStatus } };
        }
        public static Object MirrorComponents2(IAssemblyDocObject IAssemblyDocinstance, Object MirrorPlane, Object ComponentsToInstance, Object ComponentOrientations, Boolean OrientAboutCenterOfMass, Object ComponentsToMirror, Boolean CreateDerivedConfigurations, Object MirroredComponentFilenames, Int32 NameModifierType, String NameModifier, String MirroredComponentFileLocation, Int32 ImportOptions, Boolean BreakLinks, Boolean PreserveZAxis)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.MirrorComponents2(MirrorPlane, ComponentsToInstance, ComponentOrientations, OrientAboutCenterOfMass, ComponentsToMirror, CreateDerivedConfigurations, MirroredComponentFilenames, NameModifierType, NameModifier, MirroredComponentFileLocation, ImportOptions, BreakLinks, PreserveZAxis);
        }

        [MultiReturn(SWValueConst.MateObject, SWValueConst.ErrorStatus)]
        public static Dictionary<string, object> AddMate5(IAssemblyDocObject IAssemblyDocinstance, Int32 MateTypeFromEnum, Int32 AlignFromEnum, Boolean Flip, Double Distance, Double DistanceAbsUpperLimit, Double DistanceAbsLowerLimit, Double GearRatioNumerator, Double GearRatioDenominator, Double Angle, Double AngleAbsUpperLimit, Double AngleAbsLowerLimit, Boolean ForPositioningOnly, Boolean LockRotation, Int32 WidthMateOption)
        {
            var obj = new IMate2Object(IAssemblyDocinstance.IAssemblyDocInstance.AddMate5(MateTypeFromEnum, AlignFromEnum, Flip, Distance, DistanceAbsUpperLimit, DistanceAbsLowerLimit, GearRatioNumerator, GearRatioDenominator, Angle, AngleAbsUpperLimit, AngleAbsLowerLimit, ForPositioningOnly, LockRotation, WidthMateOption, out int ErrorStatus));
            return new Dictionary<string, object>() { { SWValueConst.MateObject, obj }, { SWValueConst.ErrorStatus, ErrorStatus } };
        }
        public static int EditMate3(IAssemblyDocObject IAssemblyDocinstance, Int32 MateTypeFromEnum, Int32 AlignFromEnum, Boolean Flip, Double Distance, Double DistanceAbsUpperLimit, Double DistanceAbsLowerLimit, Double GearRatioNumerator, Double GearRatioDenominator, Double Angle, Double AngleAbsUpperLimit, Double AngleAbsLowerLimit, Boolean ForPositioningOnly, Boolean LockRotation, Int32 WidthMateOption)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.EditMate3(MateTypeFromEnum, AlignFromEnum, Flip, Distance, DistanceAbsUpperLimit, DistanceAbsLowerLimit, GearRatioNumerator, GearRatioDenominator, Angle, AngleAbsUpperLimit, AngleAbsLowerLimit, ForPositioningOnly, LockRotation, WidthMateOption, out int ErrorStatus);
            return ErrorStatus;
        }
        public static void AutoAngleAxis(IAssemblyDocObject IAssemblyDocinstance, Object Mate)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.AutoAngleAxis(Mate);
        }
        public static Boolean AddComponent(IAssemblyDocObject IAssemblyDocinstance, String CompName, Double X, Double Y, Double Z)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.AddComponent(CompName, X, Y, Z);
        }
        public static void Dummy2(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.Dummy2();
        }
        public static void FeatureExtrusion(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.FeatureExtrusion();
        }
        public static void EditRebuild(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.EditRebuild();
        }
        public static void Dummy3(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.Dummy3();
        }
        public static void Dummy4(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.Dummy4();
        }
        public static void ToolsCheckInterference(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.ToolsCheckInterference();
        }
        public static void Dummy5(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.Dummy5();
        }
        public static void Dummy6(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.Dummy6();
        }
        public static Object GetFirstMember(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetFirstMember();
        }
        public static Object GetSelectedMember(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetSelectedMember();
        }
        public static IMemberObject IGetFirstMember(IAssemblyDocObject IAssemblyDocinstance)
        {
            return new IMemberObject(IAssemblyDocinstance.IAssemblyDocInstance.IGetFirstMember());
        }
        public static IMemberObject IGetSelectedMember(IAssemblyDocObject IAssemblyDocinstance)
        {
            return new IMemberObject(IAssemblyDocinstance.IAssemblyDocInstance.IGetSelectedMember());
        }
        public static void Dummy7(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.Dummy7();
        }
        public static void ViewCollapseAssembly(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.ViewCollapseAssembly();
        }
        public static void ViewExplodeAssembly(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.ViewExplodeAssembly();
        }
        public static void TranslateComponent(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.TranslateComponent();
        }
        public static void InsertNewPart(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.InsertNewPart();
        }
        public static void Dummy1(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.Dummy1();
        }
        public static void RotateComponent(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.RotateComponent();
        }
        public static void FileDeriveComponentPart(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.FileDeriveComponentPart();
        }
        public static void InsertCavity(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.InsertCavity();
        }
        public static void HideComponent(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.HideComponent();
        }
        public static void ShowComponent(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.ShowComponent();
        }
        public static void FixComponent(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.FixComponent();
        }
        public static void UnfixComponent(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.UnfixComponent();
        }
        public static void EditAssembly(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.EditAssembly();
        }
        public static void EditPart(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.EditPart();
        }
        public static void OpenCompFile(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.OpenCompFile();
        }
        public static void UpdateFeatureScope(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.UpdateFeatureScope();
        }
        public static void AddMate(IAssemblyDocObject IAssemblyDocinstance, Int32 MateType, Int32 Align, Boolean Flip, Double Dist, Double Angle)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.AddMate(MateType, Align, Flip, Dist, Angle);
        }
        public static void CompConfigProperties(IAssemblyDocObject IAssemblyDocinstance, Boolean M_suppressed, Boolean M_show_component, Boolean M_fdetail)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.CompConfigProperties(M_suppressed, M_show_component, M_fdetail);
        }
        public static Boolean AddToFeatureScope(IAssemblyDocObject IAssemblyDocinstance, String CompName)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.AddToFeatureScope(CompName);
        }
        public static Boolean RemoveFromFeatureScope(IAssemblyDocObject IAssemblyDocinstance, String CompName)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.RemoveFromFeatureScope(CompName);
        }
        public static void EditExplodeParameters(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.EditExplodeParameters();
        }
        public static void RotateComponentAxis(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.RotateComponentAxis();
        }
        public static void ViewFeatureManagerByFeatures(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.ViewFeatureManagerByFeatures();
        }
        public static void ComponentReload(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.ComponentReload();
        }
        public static void ViewFeatureManagerByDependencies(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.ViewFeatureManagerByDependencies();
        }
        public static void AssemblyPartToggle(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.AssemblyPartToggle();
        }
        public static Object FeatureByName(IAssemblyDocObject IAssemblyDocinstance, String Name)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.FeatureByName(Name);
        }
        public static IFeatureObject IFeatureByName(IAssemblyDocObject IAssemblyDocinstance, String Name)
        {
            return new IFeatureObject(IAssemblyDocinstance.IAssemblyDocInstance.IFeatureByName(Name));
        }
        public static void InsertJoin(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.InsertJoin();
        }
        public static void UpdateBox(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.UpdateBox();
        }
        public static void InsertWeld(IAssemblyDocObject IAssemblyDocinstance, String Type, String Shape, Double TopDelta, Double BottomDelta, Double Radius, String Part)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.InsertWeld(Type, Shape, TopDelta, BottomDelta, Radius, Part);
        }
        public static void ForceRebuild(IAssemblyDocObject IAssemblyDocinstance)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.ForceRebuild();
        }
        public static Object GetEditTarget(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetEditTarget();
        }
        public static IModelDocObject IGetEditTarget(IAssemblyDocObject IAssemblyDocinstance)
        {
            return new IModelDocObject(IAssemblyDocinstance.IAssemblyDocInstance.IGetEditTarget());
        }
        public static void InsertCavity2(IAssemblyDocObject IAssemblyDocinstance, Double ScaleFactor, Int32 ScaleType)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.InsertCavity2(ScaleFactor, ScaleType);
        }
        public static Boolean AutoExplode(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.AutoExplode();
        }
        public static Boolean ShowExploded(IAssemblyDocObject IAssemblyDocinstance, Boolean ShowIt)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.ShowExploded(ShowIt);
        }
        public static Object AddComponent2(IAssemblyDocObject IAssemblyDocinstance, String CompName, Double X, Double Y, Double Z)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.AddComponent2(CompName, X, Y, Z);
        }
        public static IComponentObject IAddComponent2(IAssemblyDocObject IAssemblyDocinstance, String CompName, Double X, Double Y, Double Z)
        {
            return new IComponentObject(IAssemblyDocinstance.IAssemblyDocInstance.IAddComponent2(CompName, X, Y, Z));
        }
        public static void EditMate(IAssemblyDocObject IAssemblyDocinstance, Int32 MateType, Int32 Align, Boolean Flip, Double Dist, Double Angle)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.EditMate(MateType, Align, Flip, Dist, Angle);
        }
        public static Boolean InsertDerivedPattern(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.InsertDerivedPattern();
        }
        public static Int32 ResolveAllLightWeightComponents(IAssemblyDocObject IAssemblyDocinstance, Boolean WarnUser)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.ResolveAllLightWeightComponents(WarnUser);
        }
        public static Int32 GetLightWeightComponentCount(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetLightWeightComponentCount();
        }
        public static void InsertCavity3(IAssemblyDocObject IAssemblyDocinstance, Double ScaleFactor, Int32 ScaleType, Int32 KeepPieceIndex)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.InsertCavity3(ScaleFactor, ScaleType, KeepPieceIndex);
        }
        public static Int32 ComponentReload2(IAssemblyDocObject IAssemblyDocinstance, Object Component, Boolean ReadOnly, Int32 Options)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.ComponentReload2(Component, ReadOnly, Options);
        }
        public static Int32 IComponentReload2(IAssemblyDocObject IAssemblyDocinstance, IComponentObject Component, Boolean ReadOnly, Int32 Options)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.IComponentReload2(Component.IComponentInstance as Component, ReadOnly, Options);
        }
        public static Boolean CompConfigProperties2(IAssemblyDocObject IAssemblyDocinstance, Int32 Suppression, Boolean Visibility, Boolean FeatureDetails)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.CompConfigProperties2(Suppression, Visibility, FeatureDetails);
        }
        public static Int32 AddPipePenetration(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.AddPipePenetration();
        }
        public static Boolean AddPipingFitting(IAssemblyDocObject IAssemblyDocinstance, String PathName, String ConfigName, Int16 AlignmentIndex)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.AddPipingFitting(PathName, ConfigName, AlignmentIndex);
        }
        public static Boolean IsComponentTreeValid(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.IsComponentTreeValid();
        }
        public static void ForceRebuild2(IAssemblyDocObject IAssemblyDocinstance, Boolean TopOnly)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.ForceRebuild2(TopOnly);
        }
        public static Boolean SetDroppedFileConfigName(IAssemblyDocObject IAssemblyDocinstance, String ConfigName)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.SetDroppedFileConfigName(ConfigName);
        }
        public static Object AddComponents(IAssemblyDocObject IAssemblyDocinstance, Object Names, Object Transforms)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.AddComponents(Names, Transforms);
        }

        //ref not solve
        public static IComponentObject IAddComponents(IAssemblyDocObject IAssemblyDocinstance, Int32 Count, String Names, Double Transforms)
        {
            return new IComponentObject(IAssemblyDocinstance.IAssemblyDocInstance.IAddComponents(Count, Names, Transforms));
        }

        //ref not solve
        public static Int32 EditPart2(IAssemblyDocObject IAssemblyDocinstance, Boolean Silent, Boolean AllowReadOnly, Int32 Information)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.EditPart2(Silent, AllowReadOnly, Information);
        }
        public static void InsertCavity4(IAssemblyDocObject IAssemblyDocinstance, Double ScaleFactor_x, Double ScaleFactor_y, Double ScaleFactor_z, Boolean IsUniform, Int32 ScaleType, Int32 KeepPieceIndex)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.InsertCavity4(ScaleFactor_x, ScaleFactor_y, ScaleFactor_z, IsUniform, ScaleType, KeepPieceIndex);
        }

        [MultiReturn(SWValueConst.PComp, SWValueConst.PFace)]
        public static Dictionary<string, object> ToolsCheckInterference2(IAssemblyDocObject IAssemblyDocinstance, Int32 NumComponents, Object LpComponents, Boolean CoincidentInterference)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.ToolsCheckInterference2(NumComponents, LpComponents, CoincidentInterference, out object PComp, out object PFace);

            return new Dictionary<string, object>() { { SWValueConst.PComp, new IComponent2Object(PComp.CastObj<IComponent2>()) }, { SWValueConst.PFace, new IFace2Object(PFace.CastObj<IFace2>()) } };
        }

        [MultiReturn(SWValueConst.LpComponents, SWValueConst.PComp, SWValueConst.PFace)]
        public static Dictionary<string, object> IToolsCheckInterference2(IAssemblyDocObject IAssemblyDocinstance, Int32 NumComponents, IComponentObject LpComponents, Boolean CoincidentInterference)
        {
            var comp = LpComponents.IComponentInstance as Component;
            IAssemblyDocinstance.IAssemblyDocInstance.IToolsCheckInterference2(NumComponents, ref comp, CoincidentInterference, out object PComp, out object PFace);

            return new Dictionary<string, object>() { { SWValueConst.LpComponents, new IComponentObject(comp.CastObj<IComponent>()) }, { SWValueConst.PComp, new IComponent2Object(PComp.CastObj<IComponent2>()) }, { SWValueConst.PFace, new IFace2Object(PFace.CastObj<IFace2>()) } };
        }
        public static Object GetDroppedAtEntity(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetDroppedAtEntity();
        }
        public static Boolean CompConfigProperties3(IAssemblyDocObject IAssemblyDocinstance, Int32 Suppression, Int32 Solving, Boolean Visibility, Boolean FeatureDetails)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.CompConfigProperties3(Suppression, Solving, Visibility, FeatureDetails);
        }
        public static IModelDoc2Object IGetEditTarget2(IAssemblyDocObject IAssemblyDocinstance)
        {
            return new IModelDoc2Object(IAssemblyDocinstance.IAssemblyDocInstance.IGetEditTarget2());
        }
        public static IComponent2Object IAddComponent3(IAssemblyDocObject IAssemblyDocinstance, String CompName, Double X, Double Y, Double Z)
        {
            return new IComponent2Object(IAssemblyDocinstance.IAssemblyDocInstance.IAddComponent3(CompName, X, Y, Z));
        }
        public static Int32 IComponentReload3(IAssemblyDocObject IAssemblyDocinstance, IComponent2Object Component, Boolean ReadOnly, Int32 Options)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.IComponentReload3(Component.IComponent2Instance.CastObj<Component2>(), ReadOnly, Options);
        }

        //ref not solve
        public static IComponent2Object IAddComponents2(IAssemblyDocObject IAssemblyDocinstance, Int32 Count, String Names, Double Transforms)
        {
            return new IComponent2Object(IAssemblyDocinstance.IAssemblyDocInstance.IAddComponents2(ref Count, ref Names, Transforms));
        }

        [MultiReturn(SWValueConst.LpComponents, SWValueConst.PComp, SWValueConst.PFace)]
        public static Dictionary<string, object> IToolsCheckInterference3(IAssemblyDocObject IAssemblyDocinstance, Int32 NumComponents, IComponent2Object LpComponents, Boolean CoincidentInterference)
        {
            var comp2 = LpComponents.IComponent2Instance as Component2;
            IAssemblyDocinstance.IAssemblyDocInstance.IToolsCheckInterference3(NumComponents, comp2, CoincidentInterference, out object PComp, out object PFace);

            return new Dictionary<string, object>() { { SWValueConst.LpComponents, new IComponentObject(comp2.CastObj<IComponent>()) }, { SWValueConst.PComp, new IComponent2Object(PComp.CastObj<IComponent2>()) }, { SWValueConst.PFace, new IFace2Object(PFace.CastObj<IFace2>()) } };
        }
        public static Boolean SetDroppedFileName(IAssemblyDocObject IAssemblyDocinstance, String FileName)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.SetDroppedFileName(FileName);
        }
        public static Object GetDragOperator(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.GetDragOperator();
        }
        public static IDragOperatorObject IGetDragOperator(IAssemblyDocObject IAssemblyDocinstance)
        {
            return new IDragOperatorObject(IAssemblyDocinstance.IAssemblyDocInstance.IGetDragOperator());
        }
        public static void ViewFeatureManagerFeatureDetail(IAssemblyDocObject IAssemblyDocinstance, Boolean Detail)
        {
            IAssemblyDocinstance.IAssemblyDocInstance.ViewFeatureManagerFeatureDetail(Detail);
        }
        public static Boolean InsertJoin2(IAssemblyDocObject IAssemblyDocinstance, Boolean HideParts, Boolean ForceContact)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.InsertJoin2(HideParts, ForceContact);
        }
        public static Boolean DissolveSubAssembly(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.DissolveSubAssembly();
        }
        public static Boolean EnablePresentation(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.EnablePresentation;
        }
        public static Boolean EnableAssemblyRebuild(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.EnableAssemblyRebuild;
        }
        public static InterferenceDetectionMgrObject InterferenceDetectionManager(IAssemblyDocObject IAssemblyDocinstance)
        {
            return new InterferenceDetectionMgrObject(IAssemblyDocinstance.IAssemblyDocInstance.InterferenceDetectionManager);
        }
        public static Double LargeDesignReviewTransparencyLevel(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.LargeDesignReviewTransparencyLevel;
        }
        public static Boolean LargeDesignReviewTransparencyLevelDynamic(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.LargeDesignReviewTransparencyLevelDynamic;
        }
        public static Boolean LargeDesignReviewTransparencyLevelEnabled(IAssemblyDocObject IAssemblyDocinstance)
        {
            return IAssemblyDocinstance.IAssemblyDocInstance.LargeDesignReviewTransparencyLevelEnabled;
        }
    }
}