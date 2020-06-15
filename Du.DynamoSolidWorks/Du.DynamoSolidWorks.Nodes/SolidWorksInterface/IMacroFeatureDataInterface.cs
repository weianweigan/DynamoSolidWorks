using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IMacroFeatureDataObject
    {
        public IMacroFeatureData IMacroFeatureDataInstance { get; set; }
        public IMacroFeatureDataObject(IMacroFeatureData IMacroFeatureDatainstance)
        {
            IMacroFeatureDataInstance = IMacroFeatureDatainstance;
        }
    }
    public static class IMacroFeatureDataInterface
    {
        //public static void ISetParents(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 ParentCount, Feature&Object PFeatures)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.ISetParents(ParentCount, PFeatures);
        //}
        public static void SetProgId(IMacroFeatureDataObject IMacroFeatureDatainstance, String ProgId)
        {
            IMacroFeatureDatainstance.IMacroFeatureDataInstance.SetProgId(ProgId);
        }
        public static Boolean EmbedMacroFile(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.EmbedMacroFile();
        }
        public static Int32 GetEditBodiesCount(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetEditBodiesCount();
        }
        //public static void IGetEditBodies(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 BodiesCount, Body2&Object PBodies)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IGetEditBodies(BodiesCount, PBodies);
        //}
        //public static void ISetEditBodies(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 BodiesCount, Body2&Object PBodies)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.ISetEditBodies(BodiesCount, PBodies);
        //}
        //public static void IAddDisplayDimensions(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 DimCount, Int32& DimTypes, Double& DimValues)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IAddDisplayDimensions(DimCount, DimTypes, DimValues);
        //}
        public static Boolean AccessSelections(IMacroFeatureDataObject IMacroFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        //public static Boolean IAccessSelections(IMacroFeatureDataObject IMacroFeatureDatainstance, ModelDoc2Object TopDoc, Component2Object Component)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IAccessSelections(TopDoc, Component);
        //}
        public static void ReleaseSelectionAccess(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            IMacroFeatureDatainstance.IMacroFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Object GetModuleNames(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetModuleNames();
        }
        public static Int32 GetModuleCount(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetModuleCount();
        }
        //public static void IGetModuleNames(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 ModuleCount, String& ModuleNames)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IGetModuleNames(ModuleCount, ModuleNames);
        //}
        public static Object GetProcedureNames(IMacroFeatureDataObject IMacroFeatureDatainstance, String ModuleName)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetProcedureNames(ModuleName);
        }
        public static Int32 GetProcedureCount(IMacroFeatureDataObject IMacroFeatureDatainstance, String ModuleName)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetProcedureCount(ModuleName);
        }
        //public static void IGetProcedureNames(IMacroFeatureDataObject IMacroFeatureDatainstance, String ModuleName, Int32 ProcedureCount, String& ProcedureNames)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IGetProcedureNames(ModuleName, ProcedureCount, ProcedureNames);
        //}
        public static Object GetPropertyManagerHandleModuleNames(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetPropertyManagerHandleModuleNames();
        }
        public static Int32 GetPropertyManagerHandleModuleCount(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetPropertyManagerHandleModuleCount();
        }
        //public static void IGetPropertyManagerHandleModuleNames(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 ModuleCount, String& ModuleNames)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IGetPropertyManagerHandleModuleNames(ModuleCount, ModuleNames);
        //}
        public static Object GetPropertyManagerHandleProcedureNames(IMacroFeatureDataObject IMacroFeatureDatainstance, String ModuleName)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetPropertyManagerHandleProcedureNames(ModuleName);
        }
        public static Int32 GetPropertyManagerHandleProcedureCount(IMacroFeatureDataObject IMacroFeatureDatainstance, String ModuleName)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetPropertyManagerHandleProcedureCount(ModuleName);
        }
        //public static void IGetPropertyManagerHandleProcedureNames(IMacroFeatureDataObject IMacroFeatureDatainstance, String ModuleName, Int32 ProcedureCount, String& ProcedureNames)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IGetPropertyManagerHandleProcedureNames(ModuleName, ProcedureCount, ProcedureNames);
        //}
        //public static void GetSelections(IMacroFeatureDataObject IMacroFeatureDatainstance, Object& Objects, Object& ObjectTypes, Object& SelMarks)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetSelections(Objects, ObjectTypes, SelMarks);
        //}
        public static void SetSelections(IMacroFeatureDataObject IMacroFeatureDatainstance, Object Objects, Object SelMarks)
        {
            IMacroFeatureDatainstance.IMacroFeatureDataInstance.SetSelections(Objects, SelMarks);
        }
        public static Int32 GetSelectionCount(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetSelectionCount();
        }
        //public static void IGetSelections(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 SelCount, Object& Objects, Int32& ObjectTypes, Int32& SelMarks)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IGetSelections(SelCount, Objects, ObjectTypes, SelMarks);
        //}
        //public static void ISetSelections(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 SelCount, Object& Objects, Int32& SelMarks)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.ISetSelections(SelCount, Objects, SelMarks);
        //}
        //public static void GetParameters(IMacroFeatureDataObject IMacroFeatureDatainstance, Object& ParamNames, Object& ParamTypes, Object& ParamValues)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetParameters(ParamNames, ParamTypes, ParamValues);
        //}
        public static void SetParameters(IMacroFeatureDataObject IMacroFeatureDatainstance, Object ParamNames, Object ParamTypes, Object ParamValues)
        {
            IMacroFeatureDatainstance.IMacroFeatureDataInstance.SetParameters(ParamNames, ParamTypes, ParamValues);
        }
        public static Int32 GetParameterCount(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetParameterCount();
        }
        //public static void IGetParameters(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 ParamCount, String& ParamNames, Int32& ParamTypes, String& ParamValues)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IGetParameters(ParamCount, ParamNames, ParamTypes, ParamValues);
        //}
        //public static void ISetParameters(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 ParamCount, String& ParamNames, Int32& ParamTypes, String& ParamValues)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.ISetParameters(ParamCount, ParamNames, ParamTypes, ParamValues);
        //}
        //public static void GetIntegerByName(IMacroFeatureDataObject IMacroFeatureDatainstance, String ParamName, Int32& ParamValue)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetIntegerByName(ParamName, ParamValue);
        //}
        public static void SetIntegerByName(IMacroFeatureDataObject IMacroFeatureDatainstance, String ParamName, Int32 ParamValue)
        {
            IMacroFeatureDatainstance.IMacroFeatureDataInstance.SetIntegerByName(ParamName, ParamValue);
        }
        //public static void GetDoubleByName(IMacroFeatureDataObject IMacroFeatureDatainstance, String ParamName, Double& ParamValue)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetDoubleByName(ParamName, ParamValue);
        //}
        public static void SetDoubleByName(IMacroFeatureDataObject IMacroFeatureDatainstance, String ParamName, Double ParamValue)
        {
            IMacroFeatureDatainstance.IMacroFeatureDataInstance.SetDoubleByName(ParamName, ParamValue);
        }
        //public static void GetStringByName(IMacroFeatureDataObject IMacroFeatureDatainstance, String ParamName, String& ParamValue)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetStringByName(ParamName, ParamValue);
        //}
        public static void SetStringByName(IMacroFeatureDataObject IMacroFeatureDatainstance, String ParamName, String ParamValue)
        {
            IMacroFeatureDatainstance.IMacroFeatureDataInstance.SetStringByName(ParamName, ParamValue);
        }
        //public static Boolean GetFaceUserId(IMacroFeatureDataObject IMacroFeatureDatainstance, Face2Object Face, Int32& Id1, Int32& Id2)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetFaceUserId(Face, Id1, Id2);
        //}
        //public static Boolean SetFaceUserId(IMacroFeatureDataObject IMacroFeatureDatainstance, Face2Object Face, Int32 Id1, Int32 Id2)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.SetFaceUserId(Face, Id1, Id2);
        //}
        //public static Boolean GetEdgeUserId(IMacroFeatureDataObject IMacroFeatureDatainstance, EdgeObject Edge, Int32& Id1, Int32& Id2)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetEdgeUserId(Edge, Id1, Id2);
        //}
        //public static Boolean SetEdgeUserId(IMacroFeatureDataObject IMacroFeatureDatainstance, EdgeObject Edge, Int32 Id1, Int32 Id2)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.SetEdgeUserId(Edge, Id1, Id2);
        //}
        //public static void GetSelections2(IMacroFeatureDataObject IMacroFeatureDatainstance, Object& Objects, Object& ObjectTypes, Object& SelMarks, Object& DrViews)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetSelections2(Objects, ObjectTypes, SelMarks, DrViews);
        //}
        public static void SetSelections2(IMacroFeatureDataObject IMacroFeatureDatainstance, Object Objects, Object SelMarks, Object DrViews)
        {
            IMacroFeatureDatainstance.IMacroFeatureDataInstance.SetSelections2(Objects, SelMarks, DrViews);
        }
        //public static void IGetSelections2(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 SelCount, Object& Objects, Int32& ObjectTypes, Int32& SelMarks, View&Object DrViews)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IGetSelections2(SelCount, Objects, ObjectTypes, SelMarks, DrViews);
        //}
        //public static void ISetSelections2(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 SelCount, Object& Objects, Int32& SelMarks, View&Object DrViews)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.ISetSelections2(SelCount, Objects, SelMarks, DrViews);
        //}
        //public static Int32 GetFaceIdType(IMacroFeatureDataObject IMacroFeatureDatainstance, Face2Object Face)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetFaceIdType(Face);
        //}
        //public static Int32 GetEdgeIdType(IMacroFeatureDataObject IMacroFeatureDatainstance, EdgeObject Edge)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetEdgeIdType(Edge);
        //}
        //public static void GetEntitiesNeedUserId(IMacroFeatureDataObject IMacroFeatureDatainstance, Object Body, Object& Faces, Object& Edges)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetEntitiesNeedUserId(Body, Faces, Edges);
        //}
        //public static void GetEntitiesNeedUserIdCount(IMacroFeatureDataObject IMacroFeatureDatainstance, Body2Object Body, Int32& FaceCount, Int32& EdgeCount)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetEntitiesNeedUserIdCount(Body, FaceCount, EdgeCount);
        //}
        //public static void IGetEntitiesNeedUserId(IMacroFeatureDataObject IMacroFeatureDatainstance, Body2Object Body, Int32 FaceCount, Face2&Object Faces, Int32 EdgeCount, Edge&Object Edges)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IGetEntitiesNeedUserId(Body, FaceCount, Faces, EdgeCount, Edges);
        //}
        public static Boolean IsCOMFeature(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IsCOMFeature();
        }
        public static String GetProgId(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetProgId();
        }
        public static String GetBaseName(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetBaseName();
        }
        public static Object GetDisplayDimensions(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetDisplayDimensions();
        }
        public static Int32 GetDisplayDimensionCount(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetDisplayDimensionCount();
        }
        //public static void IGetDisplayDimensions(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 DimCount, DisplayDimension&Object Dims)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IGetDisplayDimensions(DimCount, Dims);
        //}
        public static Int32 GetIconFileCount(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetIconFileCount();
        }
        //public static void IGetIconFiles(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 IconCount, String& IconFiles)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IGetIconFiles(IconCount, IconFiles);
        //}
        //public static void ISetIconFiles(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 IconCount, String& IconFiles)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.ISetIconFiles(IconCount, IconFiles);
        //}
        //public static void GetSelections3(IMacroFeatureDataObject IMacroFeatureDatainstance, Object& Objects, Object& ObjectTypes, Object& SelMarks, Object& DrViews, Object& ComponentXForms)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetSelections3(Objects, ObjectTypes, SelMarks, DrViews, ComponentXForms);
        //}
        //public static void IGetSelections3(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 SelCount, Object& Objects, Int32& ObjectTypes, Int32& SelMarks, View&Object DrViews, MathTransform&Object ComponentXForms)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IGetSelections3(SelCount, Objects, ObjectTypes, SelMarks, DrViews, ComponentXForms);
        //}
        public static IMathTransformObject GetEditTargetTransform(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return new IMathTransformObject(IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetEditTargetTransform());
        }
        public static Int32 GetParentsCount(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.GetParentsCount();
        }
        //public static void IGetParents(IMacroFeatureDataObject IMacroFeatureDatainstance, Int32 ParentCount, Feature&Object PFeatures)
        //{
        //    return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IGetParents(ParentCount, PFeatures);
        //}
        public static String MacroFileName(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.MacroFileName;
        }
        public static String ModuleName(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.ModuleName;
        }
        public static String ProcedureName(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.ProcedureName;
        }
        public static String PropertyManagerHandleMacroFileName(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.PropertyManagerHandleMacroFileName;
        }
        public static String PropertyManagerHandleModuleName(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.PropertyManagerHandleModuleName;
        }
        public static String PropertyManagerHandleProcedureName(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.PropertyManagerHandleProcedureName;
        }
        public static IBody2Object EditBody(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return new IBody2Object(IMacroFeatureDatainstance.IMacroFeatureDataInstance.EditBody);
        }
        public static String SecurityHandleMacroFileName(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.SecurityHandleMacroFileName;
        }
        public static String SecurityHandleModuleName(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.SecurityHandleModuleName;
        }
        public static String SecurityHandleProcedureName(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.SecurityHandleProcedureName;
        }
        public static Object IconFiles(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.IconFiles;
        }
        public static IMathTransformObject PatternTransform(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return new IMathTransformObject(IMacroFeatureDatainstance.IMacroFeatureDataInstance.PatternTransform);
        }
        public static IMathTransformObject FeatureTransform(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return new IMathTransformObject(IMacroFeatureDatainstance.IMacroFeatureDataInstance.FeatureTransform);
        }
        public static Object Parents(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.Parents;
        }
        public static IConfigurationObject CurrentConfiguration(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return new IConfigurationObject(IMacroFeatureDatainstance.IMacroFeatureDataInstance.CurrentConfiguration);
        }
        public static Boolean MacroFileEmbedded(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.MacroFileEmbedded;
        }
        public static Object EditBodies(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.EditBodies;
        }
        public static Boolean EnableMultiBodyConsume(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.EnableMultiBodyConsume;
        }
        public static String Provider(IMacroFeatureDataObject IMacroFeatureDatainstance)
        {
            return IMacroFeatureDatainstance.IMacroFeatureDataInstance.Provider;
        }
    }
}