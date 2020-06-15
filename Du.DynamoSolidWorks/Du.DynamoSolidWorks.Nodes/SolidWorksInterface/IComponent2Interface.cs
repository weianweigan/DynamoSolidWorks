using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IComponent2Object
    {
        public IComponent2 IComponent2Instance { get; set; }
        public IComponent2Object(IComponent2 IComponent2instance)
        {
            IComponent2Instance = IComponent2instance;
        }
    }
    public static class IComponent2Interface
    {
        public static Boolean SetTransformAndSolve2(IComponent2Object IComponent2instance, IMathTransformObject XformIn)
        {
            return IComponent2instance.IComponent2Instance.SetTransformAndSolve2(XformIn.IMathTransformInstance as MathTransform);
        }
        public static Double IGetMaterialPropertyValuesForFace(IComponent2Object IComponent2instance, Object FaceIn)
        {
            return IComponent2instance.IComponent2Instance.IGetMaterialPropertyValuesForFace(FaceIn);
        }
        public static IDrawingComponentObject GetDrawingComponent(IComponent2Object IComponent2instance, IViewObject ViewIn)
        {
            return new IDrawingComponentObject(IComponent2instance.IComponent2Instance.GetDrawingComponent(ViewIn.IViewInstance as View));
        }
        public static void SetMaterialPropertyValues2(IComponent2Object IComponent2instance, Object Material_values, Int32 Config_opt, Object Config_names)
        {
            IComponent2instance.IComponent2Instance.SetMaterialPropertyValues2(Material_values, Config_opt, Config_names);
        }

        //ref not solve
        public static void ISetMaterialPropertyValues2(IComponent2Object IComponent2instance, Double Material_values, Int32 Config_opt, Int32 Config_count, String Config_names)
        {
            IComponent2instance.IComponent2Instance.ISetMaterialPropertyValues2(Material_values, Config_opt, Config_count, Config_names);
        }
        public static Object GetMaterialPropertyValues2(IComponent2Object IComponent2instance, Int32 Config_opt, Object Config_names)
        {
            return IComponent2instance.IComponent2Instance.GetMaterialPropertyValues2(Config_opt, Config_names);
        }

        //ref not solve
        public static Double IGetMaterialPropertyValues2(IComponent2Object IComponent2instance, Int32 Config_opt, Int32 Config_count, String Config_names)
        {
            return IComponent2instance.IComponent2Instance.IGetMaterialPropertyValues2(Config_opt, Config_count, Config_names);
        }
        public static void SetVisibility(IComponent2Object IComponent2instance, Int32 State, Int32 Config_opt, Object Config_names)
        {
            IComponent2instance.IComponent2Instance.SetVisibility(State, Config_opt, Config_names);
        }
        //ref not solve
        public static void ISetVisibility(IComponent2Object IComponent2instance, Int32 State, Int32 Config_opt, Int32 Config_count, ref String Config_names)
        {
            IComponent2instance.IComponent2Instance.ISetVisibility(State, Config_opt, Config_count, ref Config_names);
        }
        public static Object GetVisibility(IComponent2Object IComponent2instance, Int32 Config_opt, Object Config_names)
        {
            return IComponent2instance.IComponent2Instance.GetVisibility(Config_opt, Config_names);
        }
        //ref not solve
        public static Int32 IGetVisibility(IComponent2Object IComponent2instance, Int32 Config_opt, Int32 Config_count, String Config_names)
        {
            return IComponent2instance.IComponent2Instance.IGetVisibility(Config_opt, Config_count, Config_names);
        }
        public static IFeatureObject FeatureByName(IComponent2Object IComponent2instance, String Name)
        {
            return new IFeatureObject(IComponent2instance.IComponent2Instance.FeatureByName(Name));
        }
        public static Boolean RemoveMaterialProperty2(IComponent2Object IComponent2instance, Int32 Config_opt, Object Config_names)
        {
            return IComponent2instance.IComponent2Instance.RemoveMaterialProperty2(Config_opt, Config_names);
        }

        //ref not solve
        public static Boolean IRemoveMaterialProperty2(IComponent2Object IComponent2instance, Int32 Config_opt, Int32 Config_count, String Config_names)
        {
            return IComponent2instance.IComponent2Instance.IRemoveMaterialProperty2(Config_opt, Config_count, Config_names);
        }

        //ref not solve
        //public static void ListExternalFileReferences2(IComponent2Object IComponent2instance, Object& ModelPathName, Object& ComponentPathName, Object& Feature, Object& DataType, Object& Status, Object& RefEntity, Object& FeatCom, Int32& ConfigOption, String& ConfigName)
        //{
        //    return IComponent2instance.IComponent2Instance.ListExternalFileReferences2(ModelPathName, ComponentPathName, Feature, DataType, Status, RefEntity, FeatCom, ConfigOption, ConfigName);
        //}
        //public static void IListExternalFileReferences2(IComponent2Object IComponent2instance, Int32 NumRefs, String& ModelPathName, String& CompPathName, String& Feature, String& DataType, Int32& Status, String& RefEntity, String& FeatComp, Int32& ConfigOption, String& ConfigName)
        //{
        //    return IComponent2instance.IComponent2Instance.IListExternalFileReferences2(NumRefs, ModelPathName, CompPathName, Feature, DataType, Status, RefEntity, FeatComp, ConfigOption, ConfigName);
        //}
        public static void UpdateExternalFileReferences(IComponent2Object IComponent2instance, Int32 ConfigOption, String ConfigName, Int32 UpdateStatus)
        {
            IComponent2instance.IComponent2Instance.UpdateExternalFileReferences(ConfigOption, ConfigName, UpdateStatus);
        }
        public static Int32 SetSuppression2(IComponent2Object IComponent2instance, Int32 State)
        {
            return IComponent2instance.IComponent2Instance.SetSuppression2(State);
        }
        public static ITextureObject GetTexture(IComponent2Object IComponent2instance, String Config_name)
        {
            return new ITextureObject(IComponent2instance.IComponent2Instance.GetTexture(Config_name));
        }
        public static Boolean SetTexture(IComponent2Object IComponent2instance, String Config_name, ITextureObject TextureIn)
        {
            return IComponent2instance.IComponent2Instance.SetTexture(Config_name, TextureIn.ITextureInstance as Texture);
        }
        public static Boolean RemoveTexture(IComponent2Object IComponent2instance, String Config_name)
        {
            return IComponent2instance.IComponent2Instance.RemoveTexture(Config_name);
        }
        public static Object GetCorresponding(IComponent2Object IComponent2instance, Object InputObject)
        {
            return IComponent2instance.IComponent2Instance.GetCorresponding(InputObject);
        }
        public static Boolean Select3(IComponent2Object IComponent2instance, Boolean Append, ISelectDataObject Data)
        {
            return IComponent2instance.IComponent2Instance.Select3(Append, Data.ISelectDataInstance as SelectData);
        }
        //public static IEnumBodies2Object EnumBodies2(IComponent2Object IComponent2instance, Int32 BodyType)
        //{
        //    return new IEnumBodies2Object(IComponent2instance.IComponent2Instance.EnumBodies2(BodyType));
        //}
        public static Object GetBodies2(IComponent2Object IComponent2instance, Int32 BodyType)
        {
            return IComponent2instance.IComponent2Instance.GetBodies2(BodyType);
        }
        //public static Int32 GetRemainingDOFs(IComponent2Object IComponent2instance, Int32& Rpoint1_status, MathPoint&Object Rpoint1, Int32& Rdirection1_status, MathVector&Object Rdirection1, Int32& Rpoint2_status, MathPoint&Object Rpoint2, Int32& Rdirection2_status, MathVector&Object Rdirection2, Int32& Tdirection1_status, MathVector&Object Tdirection1, Int32& Tdirection2_status, MathVector&Object Tdirection2)
        //{
        //    return IComponent2instance.IComponent2Instance.GetRemainingDOFs(Rpoint1_status, Rpoint1, Rdirection1_status, Rdirection1, Rpoint2_status, Rpoint2, Rdirection2_status, Rdirection2, Tdirection1_status, Tdirection1, Tdirection2_status, Tdirection2);
        //}
        public static Boolean IsPatternInstance(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IsPatternInstance();
        }
        public static Int32 GetDecalsCount(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetDecalsCount();
        }
        public static Object GetDecals(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetDecals();
        }
        public static IDecalObject IGetDecals(IComponent2Object IComponent2instance, Int32 Count)
        {
            return new IDecalObject(IComponent2instance.IComponent2Instance.IGetDecals(Count));
        }
        public static Int32 GetRenderMaterialsCount(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetRenderMaterialsCount();
        }
        public static Object GetRenderMaterials(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetRenderMaterials();
        }
        public static IRenderMaterialObject IGetRenderMaterials(IComponent2Object IComponent2instance, Int32 Count)
        {
            return new IRenderMaterialObject(IComponent2instance.IComponent2Instance.IGetRenderMaterials(Count));
        }
        public static Boolean IsMirrored(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IsMirrored();
        }
        public static Boolean HasUnloadedComponents(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.HasUnloadedComponents();
        }
        //public static Object GetUnloadedComponentNames(IComponent2Object IComponent2instance, Object& UnloadedComponentPathNames, Object& UnloadedComponentReferencedConfigurationNames, Object& ReasonForUnloadingComponents, Object& DocTypes)
        //{
        //    return IComponent2instance.IComponent2Instance.GetUnloadedComponentNames(UnloadedComponentPathNames, UnloadedComponentReferencedConfigurationNames, ReasonForUnloadingComponents, DocTypes);
        //}
        public static Boolean SetCosmosWorksMaterial(IComponent2Object IComponent2instance, String ConfigName, Int32 Type)
        {
            return IComponent2instance.IComponent2Instance.SetCosmosWorksMaterial(ConfigName, Type);
        }
        public static Int32 GetHiddenUnloadedChildrenCount(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetHiddenUnloadedChildrenCount();
        }
        public static Boolean Select4(IComponent2Object IComponent2instance, Boolean Append, ISelectDataObject Data, Boolean ShowPopup)
        {
            return IComponent2instance.IComponent2Instance.Select4(Append, Data.ISelectDataInstance as SelectData, ShowPopup);
        }
        public static Boolean IsRoot(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IsRoot();
        }
        public static Object GetModelDoc2(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetModelDoc2();
        }
        public static Boolean IsLoaded(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IsLoaded();
        }
        public static Object GetBodies3(IComponent2Object IComponent2instance, Int32 BodyType, out Object BodiesInfo)
        {
            return IComponent2instance.IComponent2Instance.GetBodies3(BodyType, out BodiesInfo);
        }
        public static Object GetMates(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetMates();
        }
        public static String GetSelectByIDString(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetSelectByIDString();
        }
        public static Boolean SetTextureByDisplayState(IComponent2Object IComponent2instance, String DisplayStateName, ITextureObject TextureIn)
        {
            return IComponent2instance.IComponent2Instance.SetTextureByDisplayState(DisplayStateName, TextureIn.ITextureInstance as Texture);
        }
        public static Boolean RemoveTextureByDisplayState(IComponent2Object IComponent2instance, String DisplayStateName)
        {
            return IComponent2instance.IComponent2Instance.RemoveTextureByDisplayState(DisplayStateName);
        }
        public static Boolean SaveVirtualComponent(IComponent2Object IComponent2instance, String CompPathName)
        {
            return IComponent2instance.IComponent2Instance.SaveVirtualComponent(CompPathName);
        }
        public static Double IGetModelMaterialPropertyValues(IComponent2Object IComponent2instance, String ConfigName)
        {
            return IComponent2instance.IComponent2Instance.IGetModelMaterialPropertyValues(ConfigName);
        }
        public static Object GetModelMaterialPropertyValues(IComponent2Object IComponent2instance, String ConfigName)
        {
            return IComponent2instance.IComponent2Instance.GetModelMaterialPropertyValues(ConfigName);
        }
        public static ITextureObject GetModelTexture(IComponent2Object IComponent2instance, String ConfigName)
        {
            return new ITextureObject(IComponent2instance.IComponent2Instance.GetModelTexture(ConfigName));
        }
        public static Boolean IsSmartComponent(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IsSmartComponent();
        }
        //public static Boolean GetSmartComponentData(IComponent2Object IComponent2instance, Object& Features, Object& FeaturesSelected, Object& Components, Object& ComponentsSelected, Object& References)
        //{
        //    return IComponent2instance.IComponent2Instance.GetSmartComponentData(Features, FeaturesSelected, Components, ComponentsSelected, References);
        //}
        public static Boolean SetSmartComponentData(IComponent2Object IComponent2instance, Object FeaturesSelected, Object ComponentsSelected, Object References)
        {
            return IComponent2instance.IComponent2Instance.SetSmartComponentData(FeaturesSelected, ComponentsSelected, References);
        }
        public static Boolean MakeVirtual(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.MakeVirtual();
        }
        public static Int32 GetID(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetID();
        }
        public static Int32 GetRenderMaterialsCount2(IComponent2Object IComponent2instance, Int32 DisplayStateOption, Object DisplayStateNames)
        {
            return IComponent2instance.IComponent2Instance.GetRenderMaterialsCount2(DisplayStateOption, DisplayStateNames);
        }
        public static Object GetRenderMaterials2(IComponent2Object IComponent2instance, Int32 DisplayStateOption, Object DisplayStateNames)
        {
            return IComponent2instance.IComponent2Instance.GetRenderMaterials2(DisplayStateOption, DisplayStateNames);
        }
        public static Boolean HasMaterialPropertyValues(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.HasMaterialPropertyValues();
        }
        public static Boolean MakeVirtual2(IComponent2Object IComponent2instance, Boolean AlsoChildVirtual)
        {
            return IComponent2instance.IComponent2Instance.MakeVirtual2(AlsoChildVirtual);
        }
        //public static IEnumBodies2Object EnumBodies3(IComponent2Object IComponent2instance, Int32 BodyType, Boolean VisibleOnly)
        //{
        //    return new IEnumBodies2Object(IComponent2instance.IComponent2Instance.EnumBodies3(BodyType, VisibleOnly));
        //}
        public static Object GetSpecificTransform(IComponent2Object IComponent2instance, Boolean IgnoreExplode)
        {
            return IComponent2instance.IComponent2Instance.GetSpecificTransform(IgnoreExplode);
        }
        public static String GetImportedPath(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetImportedPath();
        }
        public static Boolean SetReferencedDisplayStates(IComponent2Object IComponent2instance, String ComponentDisplayStateName, Int32 Option, Object AssemblyDisplayStateNames)
        {
            return IComponent2instance.IComponent2Instance.SetReferencedDisplayStates(ComponentDisplayStateName, Option, AssemblyDisplayStateNames);
        }
        public static Boolean SetVisibilityInAsmDisplayStates(IComponent2Object IComponent2instance, Int32 HideComponent, Int32 Option, Object AssemblyDisplayStateNames)
        {
            return IComponent2instance.IComponent2Instance.SetVisibilityInAsmDisplayStates(HideComponent, Option, AssemblyDisplayStateNames);
        }
        public static Object GetReferencedDisplayStates(IComponent2Object IComponent2instance, Int32 AssemblyDisplayStateOption, Object AssemblyDisplayStateNames)
        {
            return IComponent2instance.IComponent2Instance.GetReferencedDisplayStates(AssemblyDisplayStateOption, AssemblyDisplayStateNames);
        }
        public static Object GetVisibilityInAsmDisplayStates(IComponent2Object IComponent2instance, Int32 AssemblyDisplayStateOption, Object AssemblyDisplayStateNames)
        {
            return IComponent2instance.IComponent2Instance.GetVisibilityInAsmDisplayStates(AssemblyDisplayStateOption, AssemblyDisplayStateNames);
        }
        public static Object GetChildren(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetChildren();
        }
        public static IComponent2Object IGetChildren(IComponent2Object IComponent2instance)
        {
            return new IComponent2Object(IComponent2instance.IComponent2Instance.IGetChildren());
        }
        public static Int32 IGetChildrenCount(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IGetChildrenCount();
        }
        public static Object GetXform(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetXform();
        }
        public static Double IGetXform(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IGetXform();
        }
        public static Object GetBody(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetBody();
        }
        public static IBody2Object IGetBody(IComponent2Object IComponent2instance)
        {
            return new IBody2Object(IComponent2instance.IComponent2Instance.IGetBody());
        }
        public static Int32 AddPropertyExtension(IComponent2Object IComponent2instance, Object PropertyExtension)
        {
            return IComponent2instance.IComponent2Instance.AddPropertyExtension(PropertyExtension);
        }
        public static Object GetPropertyExtension(IComponent2Object IComponent2instance, Int32 ID)
        {
            return IComponent2instance.IComponent2Instance.GetPropertyExtension(ID);
        }
        public static void ResetPropertyExtension(IComponent2Object IComponent2instance)
        {
            IComponent2instance.IComponent2Instance.ResetPropertyExtension();
        }
        public static String GetMaterialIdName(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetMaterialIdName();
        }
        public static Boolean SetMaterialIdName(IComponent2Object IComponent2instance, String Name)
        {
            return IComponent2instance.IComponent2Instance.SetMaterialIdName(Name);
        }
        public static String GetMaterialUserName(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetMaterialUserName();
        }
        public static Boolean SetMaterialUserName(IComponent2Object IComponent2instance, String Name)
        {
            return IComponent2instance.IComponent2Instance.SetMaterialUserName(Name);
        }
        public static Object GetSectionedBodies(IComponent2Object IComponent2instance, Object ViewIn)
        {
            return IComponent2instance.IComponent2Instance.GetSectionedBodies(ViewIn);
        }
        public static Object GetBox(IComponent2Object IComponent2instance, Boolean IncludeRefPlanes, Boolean IncludeSketches)
        {
            return IComponent2instance.IComponent2Instance.GetBox(IncludeRefPlanes, IncludeSketches);
        }
        public static Double IGetBox(IComponent2Object IComponent2instance, Boolean IncludeRefPlanes, Boolean IncludeSketches)
        {
            return IComponent2instance.IComponent2Instance.IGetBox(IncludeRefPlanes, IncludeSketches);
        }
        public static Boolean SetXform(IComponent2Object IComponent2instance, Object XformIn)
        {
            return IComponent2instance.IComponent2Instance.SetXform(XformIn);
        }
        //public static Boolean ISetXform(IComponent2Object IComponent2instance, Double XformIn)
        //{
        //    return IComponent2instance.IComponent2Instance.ISetXform(XformIn);
        //}
        public static Object GetModelDoc(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetModelDoc();
        }
        public static IModelDoc2Object IGetModelDoc(IComponent2Object IComponent2instance)
        {
            return new IModelDoc2Object(IComponent2instance.IComponent2Instance.IGetModelDoc());
        }
        public static Boolean IsFixed(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IsFixed();
        }
        //public static IEnumBodies2Object EnumRelatedBodies(IComponent2Object IComponent2instance)
        //{
        //    return new IEnumBodies2Object(IComponent2instance.IComponent2Instance.EnumRelatedBodies());
        //}
        public static Boolean IsSuppressed(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IsSuppressed();
        }
        //public static IEnumBodies2Object EnumSectionedBodies(IComponent2Object IComponent2instance, IModelViewObject ViewIn)
        //{
        //    return new IEnumBodies2Object(IComponent2instance.IComponent2Instance.EnumSectionedBodies(ViewIn.IModelViewInstance as ModelView));
        //}
        public static Boolean IsHidden(IComponent2Object IComponent2instance, Boolean ConsiderSuppressed)
        {
            return IComponent2instance.IComponent2Instance.IsHidden(ConsiderSuppressed);
        }
        public static Int32 GetSuppression(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetSuppression();
        }
        public static Int32 SetSuppression(IComponent2Object IComponent2instance, Int32 State)
        {
            return IComponent2instance.IComponent2Instance.SetSuppression(State);
        }
        public static String GetPathName(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetPathName();
        }
        public static Boolean SetXformAndSolve(IComponent2Object IComponent2instance, Object XformIn)
        {
            return IComponent2instance.IComponent2Instance.SetXformAndSolve(XformIn);
        }
        //public static Boolean ISetXformAndSolve(IComponent2Object IComponent2instance, Double& XformIn)
        //{
        //    return IComponent2instance.IComponent2Instance.ISetXformAndSolve(XformIn);
        //}
        public static Object GetTessTriangles(IComponent2Object IComponent2instance, Boolean NoConversion)
        {
            return IComponent2instance.IComponent2Instance.GetTessTriangles(NoConversion);
        }
        public static Single IGetTessTriangles(IComponent2Object IComponent2instance, Boolean NoConversion)
        {
            return IComponent2instance.IComponent2Instance.IGetTessTriangles(NoConversion);
        }
        public static Int32 IGetTessTriangleCount(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IGetTessTriangleCount();
        }
        public static Object GetTessNorms(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetTessNorms();
        }
        public static Single IGetTessNorms(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IGetTessNorms();
        }
        public static Object GetTessTriStrips(IComponent2Object IComponent2instance, Boolean NoConversion)
        {
            return IComponent2instance.IComponent2Instance.GetTessTriStrips(NoConversion);
        }
        public static Single IGetTessTriStrips(IComponent2Object IComponent2instance, Boolean NoConversion)
        {
            return IComponent2instance.IComponent2Instance.IGetTessTriStrips(NoConversion);
        }
        public static Int32 IGetTessTriStripSize(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IGetTessTriStripSize();
        }
        public static Object GetTessTriStripNorms(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetTessTriStripNorms();
        }
        public static Single IGetTessTriStripNorms(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IGetTessTriStripNorms();
        }
        public static Object GetTessTriStripEdges(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetTessTriStripEdges();
        }
        public static Int32 IGetTessTriStripEdges(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IGetTessTriStripEdges();
        }
        public static Int32 IGetTessTriStripEdgeSize(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IGetTessTriStripEdgeSize();
        }
        public static Int32 IsDisplayDataOutOfDate(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IsDisplayDataOutOfDate();
        }
        public static Int32 GetConstrainedStatus(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.GetConstrainedStatus();
        }
        public static Boolean RemoveMaterialProperty(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.RemoveMaterialProperty();
        }
        public static Int32 IGetTemporaryBodyID(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IGetTemporaryBodyID();
        }
        public static Object FindAttribute(IComponent2Object IComponent2instance, Object AttributeDef, Int32 WhichOne)
        {
            return IComponent2instance.IComponent2Instance.FindAttribute(AttributeDef, WhichOne);
        }
        public static IAttributeObject IFindAttribute(IComponent2Object IComponent2instance, IAttributeDefObject AttributeDef, Int32 WhichOne)
        {
            return new IAttributeObject(IComponent2instance.IComponent2Instance.IFindAttribute(AttributeDef.IAttributeDefInstance as AttributeDef, WhichOne));
        }
        public static Boolean Select(IComponent2Object IComponent2instance, Boolean AppendFlag)
        {
            return IComponent2instance.IComponent2Instance.Select(AppendFlag);
        }
        public static Boolean SelectByMark(IComponent2Object IComponent2instance, Boolean AppendFlag, Int32 Mark)
        {
            return IComponent2instance.IComponent2Instance.SelectByMark(AppendFlag, Mark);
        }
        public static Boolean DeSelect(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.DeSelect();
        }
        //public static void ListExternalFileReferences(IComponent2Object IComponent2instance, Object& ModelPathName, Object& ComponentPathName, Object& Feature, Object& DataType, Object& Status, Object& RefEntity, Object& FeatCom)
        //{
        //    return IComponent2instance.IComponent2Instance.ListExternalFileReferences(ModelPathName, ComponentPathName, Feature, DataType, Status, RefEntity, FeatCom);
        //}
        public static Int32 ListExternalFileReferencesCount(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.ListExternalFileReferencesCount();
        }
        //public static void IListExternalFileReferences(IComponent2Object IComponent2instance, Int32 NumRefs, String& ModelPathName, String& CompPathName, String& Feature, String& DataType, Int32& Status, String& RefEntity, String& FeatComp)
        //{
        //    return IComponent2instance.IComponent2Instance.IListExternalFileReferences(NumRefs, ModelPathName, CompPathName, Feature, DataType, Status, RefEntity, FeatComp);
        //}
        public static Int32 ReplaceReference(IComponent2Object IComponent2instance, String FileName)
        {
            return IComponent2instance.IComponent2Instance.ReplaceReference(FileName);
        }
        public static Boolean Select2(IComponent2Object IComponent2instance, Boolean Append, Int32 Mark)
        {
            return IComponent2instance.IComponent2Instance.Select2(Append, Mark);
        }
        public static Object GetCorrespondingEntity(IComponent2Object IComponent2instance, Object Entity)
        {
            return IComponent2instance.IComponent2Instance.GetCorrespondingEntity(Entity);
        }
        public static IEntityObject IGetCorrespondingEntity(IComponent2Object IComponent2instance, IEntityObject PEntity)
        {
            return new IEntityObject(IComponent2instance.IComponent2Instance.IGetCorrespondingEntity(PEntity.IEntityInstance as Entity));
        }
        public static Boolean IsEnvelope(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IsEnvelope();
        }
        public static Boolean SetTransformAndSolve(IComponent2Object IComponent2instance, IMathTransformObject XformIn)
        {
            return IComponent2instance.IComponent2Instance.SetTransformAndSolve(XformIn.IMathTransformInstance as MathTransform);
        }
        public static IComponent2Object GetParent(IComponent2Object IComponent2instance)
        {
            return new IComponent2Object(IComponent2instance.IComponent2Instance.GetParent());
        }
        public static IFeatureObject FirstFeature(IComponent2Object IComponent2instance)
        {
            return new IFeatureObject(IComponent2instance.IComponent2Instance.FirstFeature());
        }
        public static void RemovePresentationTransform(IComponent2Object IComponent2instance)
        {
            IComponent2instance.IComponent2Instance.RemovePresentationTransform();
        }
        //public static IEnumBodies2Object EnumBodies(IComponent2Object IComponent2instance, Int32 BodyType)
        //{
        //    return new IEnumBodies2Object(IComponent2instance.IComponent2Instance.EnumBodies(BodyType));
        //}
        public static Object GetBodies(IComponent2Object IComponent2instance, Int32 BodyType)
        {
            return IComponent2instance.IComponent2Instance.GetBodies(BodyType);
        }
        public static IMathTransformObject GetTotalTransform(IComponent2Object IComponent2instance, Boolean IncludePresentationXform)
        {
            return new IMathTransformObject(IComponent2instance.IComponent2Instance.GetTotalTransform(IncludePresentationXform));
        }
        public static Object MaterialPropertyValues(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.MaterialPropertyValues;
        }
        public static object IMaterialPropertyValues(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.MaterialPropertyValues;
        }
        public static String Name(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.Name;
        }
        public static String ReferencedConfiguration(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.ReferencedConfiguration;
        }
        public static Int32 Visible(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.Visible;
        }
        public static String Name2(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.Name2;
        }
        public static Int32 Solving(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.Solving;
        }
        public static IMathTransformObject Transform(IComponent2Object IComponent2instance)
        {
            return new IMathTransformObject(IComponent2instance.IComponent2Instance.Transform);
        }
        public static IMathTransformObject PresentationTransform(IComponent2Object IComponent2instance)
        {
            return new IMathTransformObject(IComponent2instance.IComponent2Instance.PresentationTransform);
        }
        public static IMathTransformObject Transform2(IComponent2Object IComponent2instance)
        {
            return new IMathTransformObject(IComponent2instance.IComponent2Instance.Transform2);
        }
        public static Boolean ExcludeFromBOM(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.ExcludeFromBOM;
        }
        public static Boolean UseNamedConfiguration(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.UseNamedConfiguration;
        }
        public static Boolean IsVirtual(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IsVirtual;
        }
        public static String ComponentReference(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.ComponentReference;
        }
        public static String ReferencedDisplayState(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.ReferencedDisplayState;
        }
        public static Boolean IsSpeedPak(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IsSpeedPak;
        }
        public static String ReferencedDisplayState2(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.ReferencedDisplayState2;
        }
        public static Boolean IsGraphicsOnly(IComponent2Object IComponent2instance)
        {
            return IComponent2instance.IComponent2Instance.IsGraphicsOnly;
        }
    }
}