using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFeatureObject
    {
        public IFeature IFeatureInstance { get; set; }
        public IFeatureObject(IFeature IFeatureinstance)
        {
            IFeatureInstance = IFeatureinstance;
        }
    }
    public static class IFeatureInterface
    {
        //public static Boolean IIsSuppressed2(IFeatureObject IFeatureinstance, Int32 Config_opt, Int32 Config_count, String& Config_names)
        //{
        //    return IFeatureinstance.IFeatureInstance.IIsSuppressed2(Config_opt, Config_count, Config_names);
        //}
        public static Boolean RemoveMaterialProperty2(IFeatureObject IFeatureinstance, Int32 Config_opt, Object Config_names)
        {
            return IFeatureinstance.IFeatureInstance.RemoveMaterialProperty2(Config_opt, Config_names);
        }
        //public static Boolean IRemoveMaterialProperty2(IFeatureObject IFeatureinstance, Int32 Config_opt, Int32 Config_count, String& Config_names)
        //{
        //    return IFeatureinstance.IFeatureInstance.IRemoveMaterialProperty2(Config_opt, Config_count, Config_names);
        //}
        //public static void ListExternalFileReferences2(IFeatureObject IFeatureinstance, Object& ModelPathName, Object& ComponentPathName, Object& Feature, Object& DataType, Object& Status, Object& RefEntity, Object& FeatCom, Int32& ConfigOption, String& ConfigName)
        //{
        //    return IFeatureinstance.IFeatureInstance.ListExternalFileReferences2(ModelPathName, ComponentPathName, Feature, DataType, Status, RefEntity, FeatCom, ConfigOption, ConfigName);
        //}
        //public static void IListExternalFileReferences2(IFeatureObject IFeatureinstance, Int32 NumRefs, String& ModelPathName, String& CompPathName, String& Feature, String& DataType, Int32& Status, String& RefEntity, String& FeatComp, Int32& ConfigOption, String& ConfigName)
        //{
        //    return IFeatureinstance.IFeatureInstance.IListExternalFileReferences2(NumRefs, ModelPathName, CompPathName, Feature, DataType, Status, RefEntity, FeatComp, ConfigOption, ConfigName);
        //}
        public static void UpdateExternalFileReferences(IFeatureObject IFeatureinstance, Int32 ConfigOption, String ConfigName, Int32 UpdateStatus)
        {
            IFeatureinstance.IFeatureInstance.UpdateExternalFileReferences(ConfigOption, ConfigName, UpdateStatus);
        }
        public static ITextureObject GetTexture(IFeatureObject IFeatureinstance, String Config_name)
        {
            return new ITextureObject(IFeatureinstance.IFeatureInstance.GetTexture(Config_name));
        }
        public static Boolean SetTexture(IFeatureObject IFeatureinstance, Boolean BAllConfig, String Config_name, ITextureObject TextureIn)
        {
            return IFeatureinstance.IFeatureInstance.SetTexture(BAllConfig, Config_name, TextureIn.ITextureInstance as Texture);
        }
        public static Boolean RemoveTexture(IFeatureObject IFeatureinstance, Boolean BAllConfig, String Config_name)
        {
            return IFeatureinstance.IFeatureInstance.RemoveTexture(BAllConfig, Config_name);
        }
        public static Int32 GetAffectedFaceCount(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetAffectedFaceCount();
        }
        public static Object GetAffectedFaces(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetAffectedFaces();
        }
        //public static IFace2Object IGetAffectedFaces(IFeatureObject IFeatureinstance, Int32& NCount)
        //{
        //    return new IFace2Object(IFeatureinstance.IFeatureInstance.IGetAffectedFaces(NCount));
        //}
        public static Int32 GetCreatedVersion(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetCreatedVersion();
        }
        public static Int32 GetModifiedVersion(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetModifiedVersion();
        }
        public static ICommentObject AddComment(IFeatureObject IFeatureinstance, String Text)
        {
            return new ICommentObject(IFeatureinstance.IFeatureInstance.AddComment(Text));
        }
        public static IFeatureObject GetOwnerFeature(IFeatureObject IFeatureinstance)
        {
            return new IFeatureObject(IFeatureinstance.IFeatureInstance.GetOwnerFeature());
        }
        public static void SetBodiesToKeep(IFeatureObject IFeatureinstance, Boolean AllBodies, Object BodiesToKeep, Int32 ConfigOption, Object ConfigNames)
        {
            IFeatureinstance.IFeatureInstance.SetBodiesToKeep(AllBodies, BodiesToKeep, ConfigOption, ConfigNames);
        }
        public static String GetTypeName2(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetTypeName2();
        }
        //public static Int32 GetErrorCode2(IFeatureObject IFeatureinstance, Boolean& IsWarning)
        //{
        //    return IFeatureinstance.IFeatureInstance.GetErrorCode2(IsWarning);
        //}
        public static Boolean IsDimXpertFeature(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.IsDimXpertFeature();
        }
        public static Boolean IsDimXpertAnnotation(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.IsDimXpertAnnotation();
        }
        public static Int32 GetEditStatus(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetEditStatus();
        }
        //public static String GetNameForSelection(IFeatureObject IFeatureinstance, String& Type)
        //{
        //    return IFeatureinstance.IFeatureInstance.GetNameForSelection(Type);
        //}
        public static Boolean SetTextureByDisplayState(IFeatureObject IFeatureinstance, String DisplayStateName, ITextureObject TextureIn)
        {
            return IFeatureinstance.IFeatureInstance.SetTextureByDisplayState(DisplayStateName, TextureIn.ITextureInstance as Texture);
        }
        public static Boolean RemoveTextureByDisplayState(IFeatureObject IFeatureinstance, String DisplayStateName)
        {
            return IFeatureinstance.IFeatureInstance.RemoveTextureByDisplayState(DisplayStateName);
        }
        public static Boolean IsFrozen(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.IsFrozen();
        }
        public static Boolean IsHiddenLock(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.IsHiddenLock();
        }
        public static Int32 MoveFreezeBarTo(IFeatureObject IFeatureinstance, Int32 Location, Boolean UpdateAllConfigs)
        {
            return IFeatureinstance.IFeatureInstance.MoveFreezeBarTo(Location, UpdateAllConfigs);
        }
        public static Boolean HasFrozenUpdatePending(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.HasFrozenUpdatePending();
        }
        public static Int32 GetID(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetID();
        }
        public static Int32 MoveFreezeBarTo2(IFeatureObject IFeatureinstance, Int32 Location, Boolean UpdateAllConfigs, Boolean UnlockConfigs)
        {
            return IFeatureinstance.IFeatureInstance.MoveFreezeBarTo2(Location, UpdateAllConfigs, UnlockConfigs);
        }
        public static Object GetDisplayDimension(IFeatureObject IFeatureinstance, Int32 Index)
        {
            return IFeatureinstance.IFeatureInstance.GetDisplayDimension(Index);
        }
        public static Boolean HasMaterialPropertyValues(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.HasMaterialPropertyValues();
        }
        public static Object Parameter(IFeatureObject IFeatureinstance, String Name)
        {
            return IFeatureinstance.IFeatureInstance.Parameter(Name);
        }
        public static IDimensionObject IParameter(IFeatureObject IFeatureinstance, String Name)
        {
            return new IDimensionObject(IFeatureinstance.IFeatureInstance.IParameter(Name));
        }
        public static Object GetNextFeature(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetNextFeature();
        }
        public static IFeatureObject IGetNextFeature(IFeatureObject IFeatureinstance)
        {
            return new IFeatureObject(IFeatureinstance.IFeatureInstance.IGetNextFeature());
        }
        public static String GetTypeName(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetTypeName();
        }
        public static Object GetSpecificFeature(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetSpecificFeature();
        }
        public static Object IGetSpecificFeature(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.IGetSpecificFeature();
        }
        public static Boolean GetUIState(IFeatureObject IFeatureinstance, Int32 StateType)
        {
            return IFeatureinstance.IFeatureInstance.GetUIState(StateType);
        }
        public static void SetUIState(IFeatureObject IFeatureinstance, Int32 StateType, Boolean Flag)
        {
            IFeatureinstance.IFeatureInstance.SetUIState(StateType, Flag);
        }
        public static String GetMaterialUserName(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetMaterialUserName();
        }
        public static Boolean SetMaterialUserName(IFeatureObject IFeatureinstance, String Name)
        {
            return IFeatureinstance.IFeatureInstance.SetMaterialUserName(Name);
        }
        public static String GetMaterialIdName(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetMaterialIdName();
        }
        public static Boolean SetMaterialIdName(IFeatureObject IFeatureinstance, String Name)
        {
            return IFeatureinstance.IFeatureInstance.SetMaterialIdName(Name);
        }
        public static Object GetMaterialPropertyValues(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetMaterialPropertyValues();
        }
        public static Boolean SetMaterialPropertyValues(IFeatureObject IFeatureinstance, Object MaterialPropertyValues)
        {
            return IFeatureinstance.IFeatureInstance.SetMaterialPropertyValues(MaterialPropertyValues);
        }
        public static Int32 AddPropertyExtension(IFeatureObject IFeatureinstance, Object PropertyExtension)
        {
            return IFeatureinstance.IFeatureInstance.AddPropertyExtension(PropertyExtension);
        }
        public static Object GetPropertyExtension(IFeatureObject IFeatureinstance, Int32 ID)
        {
            return IFeatureinstance.IFeatureInstance.GetPropertyExtension(ID);
        }
        public static void ResetPropertyExtension(IFeatureObject IFeatureinstance)
        {
            IFeatureinstance.IFeatureInstance.ResetPropertyExtension();
        }
        public static Object GetFirstSubFeature(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetFirstSubFeature();
        }
        public static IFeatureObject IGetFirstSubFeature(IFeatureObject IFeatureinstance)
        {
            return new IFeatureObject(IFeatureinstance.IFeatureInstance.IGetFirstSubFeature());
        }
        public static Object GetNextSubFeature(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetNextSubFeature();
        }
        public static IFeatureObject IGetNextSubFeature(IFeatureObject IFeatureinstance)
        {
            return new IFeatureObject(IFeatureinstance.IFeatureInstance.IGetNextSubFeature());
        }
        public static Double IGetMaterialPropertyValues(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.IGetMaterialPropertyValues();
        }
        //public static Boolean ISetMaterialPropertyValues(IFeatureObject IFeatureinstance, Double& MaterialPropertyValues)
        //{
        //    return IFeatureinstance.IFeatureInstance.ISetMaterialPropertyValues(MaterialPropertyValues);
        //}
        public static Boolean IsSuppressed(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.IsSuppressed();
        }
        public static Int32 GetUpdateStamp(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetUpdateStamp();
        }
        public static Boolean SetBody(IFeatureObject IFeatureinstance, Object BodyIn)
        {
            return IFeatureinstance.IFeatureInstance.SetBody(BodyIn);
        }
        public static Boolean ISetBody(IFeatureObject IFeatureinstance, IBodyObject BodyIn)
        {
            return IFeatureinstance.IFeatureInstance.ISetBody(BodyIn.IBodyInstance as Body);
        }
        public static Object GetBody(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetBody();
        }
        public static IBodyObject IGetBody(IFeatureObject IFeatureinstance)
        {
            return new IBodyObject(IFeatureinstance.IFeatureInstance.IGetBody());
        }
        //public static IEnumDisplayDimensionsObject EnumDisplayDimensions(IFeatureObject IFeatureinstance)
        //{
        //    return new IEnumDisplayDimensionsObject(IFeatureinstance.IFeatureInstance.EnumDisplayDimensions());
        //}
        public static Object GetDefinition(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetDefinition();
        }
        public static Object IGetDefinition(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.IGetDefinition();
        }
        public static Boolean ModifyDefinition(IFeatureObject IFeatureinstance, Object Data, Object TopDoc, Object Component)
        {
            return IFeatureinstance.IFeatureInstance.ModifyDefinition(Data, TopDoc, Component);
        }
        public static Boolean IModifyDefinition(IFeatureObject IFeatureinstance, Object Data, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IFeatureinstance.IFeatureInstance.IModifyDefinition(Data, TopDoc.IModelDocInstance as ModelDoc, Component.IComponentInstance as Component);
        }
        public static Int32 GetFaceCount(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetFaceCount();
        }
        public static Object GetFaces(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetFaces();
        }
        //public static IFaceObject IGetFaces(IFeatureObject IFeatureinstance, Int32& FaceCount)
        //{
        //    return new IFaceObject(IFeatureinstance.IFeatureInstance.IGetFaces(FaceCount));
        //}
        public static Object GetFirstDisplayDimension(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetFirstDisplayDimension();
        }
        public static Object GetNextDisplayDimension(IFeatureObject IFeatureinstance, Object DispIn)
        {
            return IFeatureinstance.IFeatureInstance.GetNextDisplayDimension(DispIn);
        }
        public static Int32 GetErrorCode(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetErrorCode();
        }
        public static Int32 IGetChildCount(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.IGetChildCount();
        }
        public static Object GetChildren(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetChildren();
        }
        public static IFeatureObject IGetChildren(IFeatureObject IFeatureinstance)
        {
            return new IFeatureObject(IFeatureinstance.IFeatureInstance.IGetChildren());
        }
        public static Int32 IGetParentCount(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.IGetParentCount();
        }
        public static Object GetParents(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetParents();
        }
        public static IFeatureObject IGetParents(IFeatureObject IFeatureinstance)
        {
            return new IFeatureObject(IFeatureinstance.IFeatureInstance.IGetParents());
        }
        public static Boolean SetBody2(IFeatureObject IFeatureinstance, Object BodyIn, Boolean ApplyUserIds)
        {
            return IFeatureinstance.IFeatureInstance.SetBody2(BodyIn, ApplyUserIds);
        }
        public static Boolean ISetBody2(IFeatureObject IFeatureinstance, IBodyObject BodyIn, Boolean ApplyUserIds)
        {
            return IFeatureinstance.IFeatureInstance.ISetBody2(BodyIn.IBodyInstance as Body, ApplyUserIds);
        }
        public static String GetImportedFileName(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetImportedFileName();
        }
        public static Boolean SetImportedFileName(IFeatureObject IFeatureinstance, String ImpName)
        {
            return IFeatureinstance.IFeatureInstance.SetImportedFileName(ImpName);
        }
        public static Boolean SetSuppression(IFeatureObject IFeatureinstance, Int32 SuppressState)
        {
            return IFeatureinstance.IFeatureInstance.SetSuppression(SuppressState);
        }
        public static Boolean RemoveMaterialProperty(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.RemoveMaterialProperty();
        }
        public static Boolean Select(IFeatureObject IFeatureinstance, Boolean AppendFlag)
        {
            return IFeatureinstance.IFeatureInstance.Select(AppendFlag);
        }
        public static Boolean SelectByMark(IFeatureObject IFeatureinstance, Boolean AppendFlag, Int32 Mark)
        {
            return IFeatureinstance.IFeatureInstance.SelectByMark(AppendFlag, Mark);
        }
        public static Boolean DeSelect(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.DeSelect();
        }
        //public static Boolean GetBox(IFeatureObject IFeatureinstance, Object& BBox)
        //{
        //    return IFeatureinstance.IFeatureInstance.GetBox(BBox);
        //}
        //public static Boolean IGetBox(IFeatureObject IFeatureinstance, Double& BBox)
        //{
        //    return IFeatureinstance.IFeatureInstance.IGetBox(BBox);
        //}
        public static Boolean IModifyDefinition2(IFeatureObject IFeatureinstance, Object Data, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IFeatureinstance.IFeatureInstance.IModifyDefinition2(Data, TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        //public static IFace2Object IGetFaces2(IFeatureObject IFeatureinstance, Int32& FaceCount)
        //{
        //    return new IFace2Object(IFeatureinstance.IFeatureInstance.IGetFaces2(FaceCount));
        //}
        public static IBody2Object IGetBody2(IFeatureObject IFeatureinstance)
        {
            return new IBody2Object(IFeatureinstance.IFeatureInstance.IGetBody2());
        }
        //public static Boolean ISetBody3(IFeatureObject IFeatureinstance, Body2Object BodyIn, Boolean ApplyUserIds)
        //{
        //    return IFeatureinstance.IFeatureInstance.ISetBody3(BodyIn, ApplyUserIds);
        //}
        //public static void ListExternalFileReferences(IFeatureObject IFeatureinstance, Object& ModelPathName, Object& ComponentPathName, Object& Feature, Object& DataType, Object& Status, Object& RefEntity, Object& FeatCom)
        //{
        //    return IFeatureinstance.IFeatureInstance.ListExternalFileReferences(ModelPathName, ComponentPathName, Feature, DataType, Status, RefEntity, FeatCom);
        //}
        public static Int32 ListExternalFileReferencesCount(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.ListExternalFileReferencesCount();
        }
        //public static void IListExternalFileReferences(IFeatureObject IFeatureinstance, Int32 NumRefs, String& ModelPathName, String& CompPathName, String& Feature, String& DataType, Int32& Status, String& RefEntity, String& FeatComp)
        //{
        //    return IFeatureinstance.IFeatureInstance.IListExternalFileReferences(NumRefs, ModelPathName, CompPathName, Feature, DataType, Status, RefEntity, FeatComp);
        //}
        public static Boolean Select2(IFeatureObject IFeatureinstance, Boolean Append, Int32 Mark)
        {
            return IFeatureinstance.IFeatureInstance.Select2(Append, Mark);
        }
        public static Boolean IsRolledBack(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.IsRolledBack();
        }
        public static Boolean IsBase(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.IsBase();
        }
        public static Boolean MakeSubFeature(IFeatureObject IFeatureinstance, IFeatureObject SubFeature)
        {
            return IFeatureinstance.IFeatureInstance.MakeSubFeature(SubFeature.IFeatureInstance as Feature);
        }
        public static Boolean IsBase2(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.IsBase2();
        }
        public static Object GetSpecificFeature2(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.GetSpecificFeature2();
        }
        public static void SetMaterialPropertyValues2(IFeatureObject IFeatureinstance, Object Material_values, Int32 Config_opt, Object Config_names)
        {
            IFeatureinstance.IFeatureInstance.SetMaterialPropertyValues2(Material_values, Config_opt, Config_names);
        }
        //public static void ISetMaterialPropertyValues2(IFeatureObject IFeatureinstance, Double& Material_values, Int32 Config_opt, Int32 Config_count, String& Config_names)
        //{
        //    return IFeatureinstance.IFeatureInstance.ISetMaterialPropertyValues2(Material_values, Config_opt, Config_count, Config_names);
        //}
        public static Object GetMaterialPropertyValues2(IFeatureObject IFeatureinstance, Int32 Config_opt, Object Config_names)
        {
            return IFeatureinstance.IFeatureInstance.GetMaterialPropertyValues2(Config_opt, Config_names);
        }
        //public static Double IGetMaterialPropertyValues2(IFeatureObject IFeatureinstance, Int32 Config_opt, Int32 Config_count, String& Config_names)
        //{
        //    return IFeatureinstance.IFeatureInstance.IGetMaterialPropertyValues2(Config_opt, Config_count, Config_names);
        //}
        public static Boolean SetSuppression2(IFeatureObject IFeatureinstance, Int32 SuppressionState, Int32 Config_opt, Object Config_names)
        {
            return IFeatureinstance.IFeatureInstance.SetSuppression2(SuppressionState, Config_opt, Config_names);
        }
        //public static Boolean ISetSuppression2(IFeatureObject IFeatureinstance, Int32 SuppressionState, Int32 Config_opt, Int32 Config_count, String& Config_names)
        //{
        //    return IFeatureinstance.IFeatureInstance.ISetSuppression2(SuppressionState, Config_opt, Config_count, Config_names);
        //}
        public static Object IsSuppressed2(IFeatureObject IFeatureinstance, Int32 Config_opt, Object Config_names)
        {
            return IFeatureinstance.IFeatureInstance.IsSuppressed2(Config_opt, Config_names);
        }
        public static String Name(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.Name;
        }
        public static String Description(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.Description;
        }
        public static String CreatedBy(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.CreatedBy;
        }
        public static String DateCreated(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.DateCreated;
        }
        public static String DateModified(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.DateModified;
        }
        public static ICustomPropertyManagerObject CustomPropertyManager(IFeatureObject IFeatureinstance)
        {
            return new ICustomPropertyManagerObject(IFeatureinstance.IFeatureInstance.CustomPropertyManager);
        }
        public static Int32 Visible(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.Visible;
        }
        public static Boolean ExcludeFromCutList(IFeatureObject IFeatureinstance)
        {
            return IFeatureinstance.IFeatureInstance.ExcludeFromCutList;
        }
    }
}