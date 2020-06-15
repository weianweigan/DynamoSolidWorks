using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IConfigurationObject
    {
        public IConfiguration IConfigurationInstance { get; set; }
        public IConfigurationObject(IConfiguration IConfigurationinstance)
        {
            IConfigurationInstance = IConfigurationinstance;
        }
    }
    public static class IConfigurationInterface
    {
        //public static Object AddExplodeStep2(IConfigurationObject IConfigurationinstance, Double ExplDist, Int32 ExplDirIndex, Boolean ReverseDir, Double ExplAng, Int32 RotAxisIndex, Boolean ReverseAng, Boolean RotateAboutOrigin, Boolean AutoSpaceComponentsOnDrag, Int32& Error)
        //{
        //    return IConfigurationinstance.IConfigurationInstance.AddExplodeStep2(ExplDist, ExplDirIndex, ReverseDir, ExplAng, RotAxisIndex, ReverseAng, RotateAboutOrigin, AutoSpaceComponentsOnDrag, Error);
        //}
        //public static Object AddRadialExplodeStep(IConfigurationObject IConfigurationinstance, Double ExplDist, Double ExplAng, Boolean DivergeFromAxis, Int32& Error)
        //{
        //    return IConfigurationinstance.IConfigurationInstance.AddRadialExplodeStep(ExplDist, ExplAng, DivergeFromAxis, Error);
        //}
        public static Object GetRootComponent(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.GetRootComponent();
        }
        public static IComponentObject IGetRootComponent(IConfigurationObject IConfigurationinstance)
        {
            return new IComponentObject(IConfigurationinstance.IConfigurationInstance.IGetRootComponent());
        }
        public static Int32 GetNumberOfExplodeSteps(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.GetNumberOfExplodeSteps();
        }
        public static Object GetExplodeStep(IConfigurationObject IConfigurationinstance, Int32 ExplodeStepIndex)
        {
            return IConfigurationinstance.IConfigurationInstance.GetExplodeStep(ExplodeStepIndex);
        }
        public static IExplodeStepObject IGetExplodeStep(IConfigurationObject IConfigurationinstance, Int32 ExplodeStepIndex)
        {
            return new IExplodeStepObject(IConfigurationinstance.IConfigurationInstance.IGetExplodeStep(ExplodeStepIndex));
        }
        public static Object AddExplodeStep(IConfigurationObject IConfigurationinstance, Double ExplDist, Boolean ReverseDir, Boolean RigidSubassembly, Boolean ExplodeRelated)
        {
            return IConfigurationinstance.IConfigurationInstance.AddExplodeStep(ExplDist, ReverseDir, RigidSubassembly, ExplodeRelated);
        }
        public static IExplodeStepObject IAddExplodeStep(IConfigurationObject IConfigurationinstance, Double ExplDist, Boolean ReverseDir, Boolean RigidSubassembly, Boolean ExplodeRelated)
        {
            return new IExplodeStepObject(IConfigurationinstance.IConfigurationInstance.IAddExplodeStep(ExplDist, ReverseDir, RigidSubassembly, ExplodeRelated));
        }
        public static Boolean DeleteExplodeStep(IConfigurationObject IConfigurationinstance, String ExplodeStepName)
        {
            return IConfigurationinstance.IConfigurationInstance.DeleteExplodeStep(ExplodeStepName);
        }
        public static String GetStreamName(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.GetStreamName();
        }
        public static IComponent2Object IGetRootComponent2(IConfigurationObject IConfigurationinstance)
        {
            return new IComponent2Object(IConfigurationinstance.IConfigurationInstance.IGetRootComponent2());
        }
        public static Boolean GetComponentSuppressionState(IConfigurationObject IConfigurationinstance, String CompName)
        {
            return IConfigurationinstance.IConfigurationInstance.GetComponentSuppressionState(CompName);
        }
        public static String GetComponentConfigName(IConfigurationObject IConfigurationinstance, String CompName)
        {
            return IConfigurationinstance.IConfigurationInstance.GetComponentConfigName(CompName);
        }
        //public static Int32 GetCustomProperties(IConfigurationObject IConfigurationinstance, Object& PropNames, Object& PropValues, Object& PropTypes)
        //{
        //    return IConfigurationinstance.IConfigurationInstance.GetCustomProperties(PropNames, PropValues, PropTypes);
        //}
        public static Int32 GetCustomPropertiesCount(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.GetCustomPropertiesCount();
        }
        //public static void IGetCustomProperties(IConfigurationObject IConfigurationinstance, Int32 NumProps, String& PropNames, String& PropValues, Int32& PropTypes)
        //{
        //    return IConfigurationinstance.IConfigurationInstance.IGetCustomProperties(NumProps, PropNames, PropValues, PropTypes);
        //}
        public static Boolean SetColor(IConfigurationObject IConfigurationinstance, Int32 ColorIn)
        {
            return IConfigurationinstance.IConfigurationInstance.SetColor(ColorIn);
        }
        public static Boolean IsDerived(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.IsDerived();
        }
        public static IConfigurationObject GetParent(IConfigurationObject IConfigurationinstance)
        {
            return new IConfigurationObject(IConfigurationinstance.IConfigurationInstance.GetParent());
        }
        public static Object GetChildren(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.GetChildren();
        }
        public static Int32 GetChildrenCount(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.GetChildrenCount();
        }
        public static IConfigurationObject IGetChildren(IConfigurationObject IConfigurationinstance, Int32 NumChildren)
        {
            return new IConfigurationObject(IConfigurationinstance.IConfigurationInstance.IGetChildren(NumChildren));
        }
        public static Boolean Select(IConfigurationObject IConfigurationinstance, Boolean AppendFlag)
        {
            return IConfigurationinstance.IConfigurationInstance.Select(AppendFlag);
        }
        public static Int32 GetParameterCount(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.GetParameterCount();
        }
        //public static void GetParameters(IConfigurationObject IConfigurationinstance, Object& Params, Object& Values)
        //{
        //    return IConfigurationinstance.IConfigurationInstance.GetParameters(Params, Values);
        //}
        //public static void IGetParameters(IConfigurationObject IConfigurationinstance, Int32 NParamCount, String& Params, String& Values)
        //{
        //    return IConfigurationinstance.IConfigurationInstance.IGetParameters(NParamCount, Params, Values);
        //}
        //public static void SetParameters(IConfigurationObject IConfigurationinstance, Object& Params, Object& Values)
        //{
        //    return IConfigurationinstance.IConfigurationInstance.SetParameters(Params, Values);
        //}
        //public static void ISetParameters(IConfigurationObject IConfigurationinstance, Int32 NParamCount, String& Params, String& Values)
        //{
        //    return IConfigurationinstance.IConfigurationInstance.ISetParameters(NParamCount, Params, Values);
        //}
        //public static Boolean Select2(IConfigurationObject IConfigurationinstance, Boolean AppendFlag, SelectDataObject SelectData)
        //{
        //    return IConfigurationinstance.IConfigurationInstance.Select2(AppendFlag, SelectData);
        //}
        public static Object GetDisplayStates(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.GetDisplayStates();
        }
        public static Int32 GetDisplayStatesCount(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.GetDisplayStatesCount();
        }
        public static String IGetDisplayStates(IConfigurationObject IConfigurationinstance, Int32 Count)
        {
            return IConfigurationinstance.IConfigurationInstance.IGetDisplayStates(Count);
        }
        public static Boolean CreateDisplayState(IConfigurationObject IConfigurationinstance, String DisplayStateName)
        {
            return IConfigurationinstance.IConfigurationInstance.CreateDisplayState(DisplayStateName);
        }
        public static Boolean ApplyDisplayState(IConfigurationObject IConfigurationinstance, String DisplayStateName)
        {
            return IConfigurationinstance.IConfigurationInstance.ApplyDisplayState(DisplayStateName);
        }
        public static Boolean DeleteDisplayState(IConfigurationObject IConfigurationinstance, String DisplayStateName)
        {
            return IConfigurationinstance.IConfigurationInstance.DeleteDisplayState(DisplayStateName);
        }
        public static Boolean RenameDisplayState(IConfigurationObject IConfigurationinstance, String OldDisplayStateName, String NewDisplayStateName)
        {
            return IConfigurationinstance.IConfigurationInstance.RenameDisplayState(OldDisplayStateName, NewDisplayStateName);
        }
        public static Boolean CopyDisplayStateFromConfiguration(IConfigurationObject IConfigurationinstance, IConfigurationObject CopyFromConfig, String DisplayStateNameToCopy)
        {
            return IConfigurationinstance.IConfigurationInstance.CopyDisplayStateFromConfiguration(CopyFromConfig.IConfigurationInstance as Configuration, DisplayStateNameToCopy);
        }
        public static Boolean IsSpeedPak(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.IsSpeedPak();
        }
        public static Boolean UpdateSpeedPak(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.UpdateSpeedPak();
        }
        public static Boolean IsLoaded(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.IsLoaded();
        }
        public static Int32 GetID(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.GetID();
        }
        public static IComponent2Object GetRootComponent3(IConfigurationObject IConfigurationinstance, Boolean Resolve)
        {
            return new IComponent2Object(IConfigurationinstance.IConfigurationInstance.GetRootComponent3(Resolve));
        }
        public static Boolean IsDirty(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.IsDirty();
        }
        //public static ISWSceneObject GetScene(IConfigurationObject IConfigurationinstance)
        //{
        //    return new ISWSceneObject(IConfigurationinstance.IConfigurationInstance.GetScene());
        //}
        //public static Object GetDisplayStateFeatureProperties(IConfigurationObject IConfigurationinstance, String DisplayStateName, Object& Features)
        //{
        //    return IConfigurationinstance.IConfigurationInstance.GetDisplayStateFeatureProperties(DisplayStateName, Features);
        //}
        //public static Object GetDisplayStateBodyProperties(IConfigurationObject IConfigurationinstance, String DisplayStateName, Object& Bodies)
        //{
        //    return IConfigurationinstance.IConfigurationInstance.GetDisplayStateBodyProperties(DisplayStateName, Bodies);
        //}
        //public static Object GetDisplayStateFaceProperties(IConfigurationObject IConfigurationinstance, String DisplayStateName, Object& Faces)
        //{
        //    return IConfigurationinstance.IConfigurationInstance.GetDisplayStateFaceProperties(DisplayStateName, Faces);
        //}
        public static Object GetDisplayStateProperties(IConfigurationObject IConfigurationinstance, String DisplayStateName)
        {
            return IConfigurationinstance.IConfigurationInstance.GetDisplayStateProperties(DisplayStateName);
        }
        //public static Object GetDisplayStateComponentProperties(IConfigurationObject IConfigurationinstance, String DisplayStateName, Object& Components)
        //{
        //    return IConfigurationinstance.IConfigurationInstance.GetDisplayStateComponentProperties(DisplayStateName, Components);
        //}
        //public static Object GetDisplayStateComponentVisibility(IConfigurationObject IConfigurationinstance, String DisplayStateName, Boolean Onlyhidden, Boolean ToplevelOnly, Object& Components)
        //{
        //    return IConfigurationinstance.IConfigurationInstance.GetDisplayStateComponentVisibility(DisplayStateName, Onlyhidden, ToplevelOnly, Components);
        //}
        public static Boolean GetExpanded(IConfigurationObject IConfigurationinstance, Int32 WhichPane)
        {
            return IConfigurationinstance.IConfigurationInstance.GetExpanded(WhichPane);
        }
        public static void SetExpanded(IConfigurationObject IConfigurationinstance, Int32 WhichPane, Boolean Expanded)
        {
            IConfigurationinstance.IConfigurationInstance.SetExpanded(WhichPane, Expanded);
        }
        public static String Name(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.Name;
        }
        public static String Comment(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.Comment;
        }
        public static String AlternateName(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.AlternateName;
        }
        public static Boolean UseAlternateNameInBOM(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.UseAlternateNameInBOM;
        }
        public static Boolean SuppressNewFeatures(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.SuppressNewFeatures;
        }
        public static Boolean HideNewComponentModels(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.HideNewComponentModels;
        }
        public static Boolean SuppressNewComponentModels(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.SuppressNewComponentModels;
        }
        public static Boolean ShowChildComponentsInBOM(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.ShowChildComponentsInBOM;
        }
        public static Boolean Lock(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.Lock;
        }
        public static String Description(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.Description;
        }
        public static Int32 BOMPartNoSource(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.BOMPartNoSource;
        }
        public static ICustomPropertyManagerObject CustomPropertyManager(IConfigurationObject IConfigurationinstance)
        {
            return new ICustomPropertyManagerObject(IConfigurationinstance.IConfigurationInstance.CustomPropertyManager);
        }
        public static IDimXpertManagerObject DimXpertManager(IConfigurationObject IConfigurationinstance, bool CreateSchema)
        {
            return new IDimXpertManagerObject(IConfigurationinstance.IConfigurationInstance.DimXpertManager[CreateSchema]);
        }
        public static Boolean NeedsRebuild(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.NeedsRebuild;
        }
        public static Int32 Type(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.Type;
        }
        public static Boolean AddRebuildSaveMark(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.AddRebuildSaveMark;
        }
        public static Int32 ChildComponentDisplayInBOM(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.ChildComponentDisplayInBOM;
        }
        public static Boolean UseDescriptionInBOM(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.UseDescriptionInBOM;
        }
        public static Boolean LargeDesignReviewMark(IConfigurationObject IConfigurationinstance)
        {
            return IConfigurationinstance.IConfigurationInstance.LargeDesignReviewMark;
        }
    }
}