using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IPartDocObject
    {
        public IPartDoc IPartDocInstance { get; set; }
        public IPartDocObject(IPartDoc IPartDocinstance)
        {
            IPartDocInstance = IPartDocinstance;
        }
    }
    public static class IPartDocInterface
    {
        public static void FeatureExtrusionThin(IPartDocObject IPartDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Double Thk1, Double Thk2, Double EndThk, Int32 RevThinDir, Int32 CapEnds, Boolean AddBends, Double BendRad)
        {
            IPartDocinstance.IPartDocInstance.FeatureExtrusionThin(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, Thk1, Thk2, EndThk, RevThinDir, CapEnds, AddBends, BendRad);
        }
        public static Boolean InsertBends(IPartDocObject IPartDocinstance, Double Radius, String UseBendTable, Double UseKfactor, Double UseBendAllowance, Boolean UseAutoRelief, Double OffsetRatio)
        {
            return IPartDocinstance.IPartDocInstance.InsertBends(Radius, UseBendTable, UseKfactor, UseBendAllowance, UseAutoRelief, OffsetRatio);
        }
        public static Object CreateFeatureFromBody(IPartDocObject IPartDocinstance, Object Body)
        {
            return IPartDocinstance.IPartDocInstance.CreateFeatureFromBody(Body);
        }
        public static IFeatureObject ICreateFeatureFromBody(IPartDocObject IPartDocinstance, IBodyObject Body)
        {
            return new IFeatureObject(IPartDocinstance.IPartDocInstance.ICreateFeatureFromBody(Body?.IBodyInstance.CastObj<Body>()));
        }
        public static Object CreateFeatureFromBody2(IPartDocObject IPartDocinstance, Object Body, Boolean MakeRefSurface)
        {
            return IPartDocinstance.IPartDocInstance.CreateFeatureFromBody2(Body, MakeRefSurface);
        }
        public static IFeatureObject ICreateFeatureFromBody2(IPartDocObject IPartDocinstance, IBodyObject Body, Boolean MakeRefSurface)
        {
            return new IFeatureObject(IPartDocinstance.IPartDocInstance.ICreateFeatureFromBody2(Body?.IBodyInstance?.CastObj<Body>(), MakeRefSurface));
        }
        public static Int32 ImportDiagnosis(IPartDocObject IPartDocinstance, Boolean CloseAllGaps, Boolean RemoveFaces, Boolean FixFaces, Int32 Options)
        {
            return IPartDocinstance.IPartDocInstance.ImportDiagnosis(CloseAllGaps, RemoveFaces, FixFaces, Options);
        }
        public static Boolean DeleteEntityName(IPartDocObject IPartDocinstance, Object Entity)
        {
            return IPartDocinstance.IPartDocInstance.DeleteEntityName(Entity);
        }
        public static Boolean IDeleteEntityName(IPartDocObject IPartDocinstance, IEntityObject Entity)
        {
            return IPartDocinstance.IPartDocInstance.IDeleteEntityName(Entity.IEntityInstance.CastObj<Entity>());
        }
        public static Object GetTessTriStripEdges(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.GetTessTriStripEdges();
        }
        public static Int32 IGetTessTriStripEdges(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.IGetTessTriStripEdges();
        }
        public static Int32 IGetTessTriStripEdgeSize(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.IGetTessTriStripEdgeSize();
        }
        //public static IEnumBodiesObject EnumBodies(IPartDocObject IPartDocinstance, Int32 BodyType)
        //{
        //    return new IEnumBodiesObject(IPartDocinstance.IPartDocInstance.EnumBodies(BodyType));
        //}
        public static Object GetBodies(IPartDocObject IPartDocinstance, Int32 BodyType)
        {
            return IPartDocinstance.IPartDocInstance.GetBodies(BodyType);
        }
        public static Object GetRelatedBodies(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.GetRelatedBodies();
        }
        public static Object GetRelatedSectionedBodies(IPartDocObject IPartDocinstance, Object ViewIn)
        {
            return IPartDocinstance.IPartDocInstance.GetRelatedSectionedBodies(ViewIn);
        }
        public static Boolean InsertBends2(IPartDocObject IPartDocinstance, Double Radius, String UseBendTable, Double UseKfactor, Double UseBendAllowance, Boolean UseAutoRelief, Double OffsetRatio, Boolean DoFlatten)
        {
            return IPartDocinstance.IPartDocInstance.InsertBends2(Radius, UseBendTable, UseKfactor, UseBendAllowance, UseAutoRelief, OffsetRatio, DoFlatten);
        }
        public static Object CreateFeatureFromBody3(IPartDocObject IPartDocinstance, Object Body, Boolean MakeRefSurface, Int32 Options)
        {
            return IPartDocinstance.IPartDocInstance.CreateFeatureFromBody3(Body, MakeRefSurface, Options);
        }
        public static IFeatureObject ICreateFeatureFromBody3(IPartDocObject IPartDocinstance, IBodyObject Body, Boolean MakeRefSurface, Int32 Options)
        {
            return new IFeatureObject(IPartDocinstance.IPartDocInstance.ICreateFeatureFromBody3(Body.IBodyInstance.CastObj<Body>(), MakeRefSurface, Options));
        }
        public static Object GetMateReferenceEntity(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.GetMateReferenceEntity();
        }
        public static void FeatureExtrusion2(IPartDocObject IPartDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean Merge)
        {
            IPartDocinstance.IPartDocInstance.FeatureExtrusion2(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, Merge);
        }
        public static void FeatureExtrusionThin2(IPartDocObject IPartDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean Merge, Double Thk1, Double Thk2, Double EndThk, Int32 RevThinDir, Int32 CapEnds, Boolean AddBends, Double BendRad)
        {
            IPartDocinstance.IPartDocInstance.FeatureExtrusionThin2(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, Merge, Thk1, Thk2, EndThk, RevThinDir, CapEnds, AddBends, BendRad);
        }
        public static Object CreateSurfaceFeatureFromBody(IPartDocObject IPartDocinstance, Object Body, Int32 Options)
        {
            return IPartDocinstance.IPartDocInstance.CreateSurfaceFeatureFromBody(Body, Options);
        }
        public static Int32 ICreateSurfaceFeatureFromBodyCount(IPartDocObject IPartDocinstance, IBodyObject Body, Int32 Options)
        {
            return IPartDocinstance.IPartDocInstance.ICreateSurfaceFeatureFromBodyCount(Body.IBodyInstance.CastObj<Body>(), Options);
        }
        public static IFeatureObject ICreateSurfaceFeatureFromBody(IPartDocObject IPartDocinstance)
        {
            return new IFeatureObject(IPartDocinstance.IPartDocInstance.ICreateSurfaceFeatureFromBody());
        }
        public static IBody2Object IBodyObject2(IPartDocObject IPartDocinstance)
        {
            return new IBody2Object(IPartDocinstance.IPartDocInstance.IBodyObject2());
        }
        public static IBody2Object IGetProcessedBody2(IPartDocObject IPartDocinstance)
        {
            return new IBody2Object(IPartDocinstance.IPartDocInstance.IGetProcessedBody2());
        }
        public static IBody2Object ICreateNewBody2(IPartDocObject IPartDocinstance)
        {
            return new IBody2Object(IPartDocinstance.IPartDocInstance.ICreateNewBody2());
        }
        public static IBody2Object IGetProcessedBodyWithSelFace2(IPartDocObject IPartDocinstance)
        {
            return new IBody2Object(IPartDocinstance.IPartDocInstance.IGetProcessedBodyWithSelFace2());
        }
        public static IBody2Object IGetSectionedBody2(IPartDocObject IPartDocinstance, IModelViewObject ViewIn)
        {
            return new IBody2Object(IPartDocinstance.IPartDocInstance.IGetSectionedBody2(ViewIn.IModelViewInstance.CastObj<ModelView>()));
        }
        public static IFeatureObject ICreateFeatureFromBody4(IPartDocObject IPartDocinstance, IBody2Object Body, Boolean MakeRefSurface, Int32 Options)
        {
            return new IFeatureObject(IPartDocinstance.IPartDocInstance.ICreateFeatureFromBody4(Body.IBody2Instance.CastObj<Body2>(), MakeRefSurface, Options));
        }
        public static Int32 ICreateSurfaceFeatureFromBodyCount2(IPartDocObject IPartDocinstance, IBody2Object Body, Int32 Options)
        {
            return IPartDocinstance.IPartDocInstance.ICreateSurfaceFeatureFromBodyCount2(Body.IBody2Instance.CastObj<Body2>(), Options);
        }
        //public static IEnumBodies2Object EnumRelatedBodies2(IPartDocObject IPartDocinstance)
        //{
        //    return new IEnumBodies2Object(IPartDocinstance.IPartDocInstance.EnumRelatedBodies2());
        //}
        //public static IEnumBodies2Object EnumRelatedSectionedBodies2(IPartDocObject IPartDocinstance, IModelViewObject ViewIn)
        //{
        //    return new IEnumBodies2Object(IPartDocinstance.IPartDocInstance.EnumRelatedSectionedBodies2(ViewIn.IModelViewInstance.CastObj<ModelView>()));
        //}
        //public static IEnumBodies2Object EnumBodies2(IPartDocObject IPartDocinstance, Int32 BodyType)
        //{
        //    return new IEnumBodies2Object(IPartDocinstance.IPartDocInstance.EnumBodies2(BodyType));
        //}
        public static Int32 GetNamedEntitiesCount(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.GetNamedEntitiesCount();
        }
        public static Object GetNamedEntities(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.GetNamedEntities();
        }
        public static IEntityObject IGetNamedEntities(IPartDocObject IPartDocinstance, Int32 Count)
        {
            return new IEntityObject(IPartDocinstance.IPartDocInstance.IGetNamedEntities(Count));
        }
        public static Object GetCorrespondingEntity(IPartDocObject IPartDocinstance, Object Entity)
        {
            return IPartDocinstance.IPartDocInstance.GetCorrespondingEntity(Entity);
        }
        public static IEntityObject IGetCorrespondingEntity(IPartDocObject IPartDocinstance, IEntityObject PEntity)
        {
            return new IEntityObject(IPartDocinstance.IPartDocInstance.IGetCorrespondingEntity(PEntity.IEntityInstance.CastObj<Entity>()));
        }
        public static Boolean InsertBasePart(IPartDocObject IPartDocinstance, String FileName)
        {
            return IPartDocinstance.IPartDocInstance.InsertBasePart(FileName);
        }
        public static void FeatureExtrusion3(IPartDocObject IPartDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean Merge)
        {
            IPartDocinstance.IPartDocInstance.FeatureExtrusion3(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, Merge);
        }
        public static void FeatureExtrusionThin3(IPartDocObject IPartDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2, Boolean TranslateSurface1, Boolean TranslateSurface2, Boolean Merge, Double Thk1, Double Thk2, Double EndThk, Int32 RevThinDir, Int32 CapEnds, Boolean AddBends, Double BendRad)
        {
            IPartDocinstance.IPartDocInstance.FeatureExtrusionThin3(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2, TranslateSurface1, TranslateSurface2, Merge, Thk1, Thk2, EndThk, RevThinDir, CapEnds, AddBends, BendRad);
        }
        public static Boolean InsertMirrorFeature(IPartDocObject IPartDocinstance, Boolean GeometryPattern)
        {
            return IPartDocinstance.IPartDocInstance.InsertMirrorFeature(GeometryPattern);
        }
        public static Boolean InsertMirrorAll(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.InsertMirrorAll();
        }
        public static void FeatureRevolve2(IPartDocObject IPartDocinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType, Boolean Merge)
        {
            IPartDocinstance.IPartDocInstance.FeatureRevolve2(Angle, ReverseDir, Angle2, RevType, Merge);
        }
        public static void FeatureRevolveThin2(IPartDocObject IPartDocinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType, Double Thickness1, Double Thickness2, Int32 ReverseThinDir, Boolean Merge)
        {
            IPartDocinstance.IPartDocInstance.FeatureRevolveThin2(Angle, ReverseDir, Angle2, RevType, Thickness1, Thickness2, ReverseThinDir, Merge);
        }
        public static Boolean InsertCombineFeature(IPartDocObject IPartDocinstance, Int32 OperationType, Object MainBody, Object ToolVar)
        {
            return IPartDocinstance.IPartDocInstance.InsertCombineFeature(OperationType, MainBody, ToolVar);
        }
        //public static Boolean IInsertCombineFeature(IPartDocObject IPartDocinstance, Int32 OperationType, Body2Object MainBody, Int32 ToolsCount, Body2&Object ToolsArr)
        //{
        //    return IPartDocinstance.IPartDocInstance.IInsertCombineFeature(OperationType, MainBody, ToolsCount, ToolsArr);
        //}
        //public static IEnumBodies2Object EnumBodies3(IPartDocObject IPartDocinstance, Int32 BodyType, Boolean BVisibleOnly)
        //{
        //    return new IEnumBodies2Object(IPartDocinstance.IPartDocInstance.EnumBodies3(BodyType, BVisibleOnly));
        //}
        public static Object GetBodies2(IPartDocObject IPartDocinstance, Int32 BodyType, Boolean BVisibleOnly)
        {
            return IPartDocinstance.IPartDocInstance.GetBodies2(BodyType, BVisibleOnly);
        }
        public static void SetLineStyle(IPartDocObject IPartDocinstance, String StyleName)
        {
            IPartDocinstance.IPartDocInstance.SetLineStyle(StyleName);
        }
        public static void SetLineWidth(IPartDocObject IPartDocinstance, Int32 Width)
        {
            IPartDocinstance.IPartDocInstance.SetLineWidth(Width);
        }
        public static void SetLineColor(IPartDocObject IPartDocinstance, Int32 Color)
        {
            IPartDocinstance.IPartDocInstance.SetLineColor(Color);
        }
        public static IFeatureObject InsertPart(IPartDocObject IPartDocinstance, String FileName, Boolean ImportPlane, Boolean ImportAxis, Boolean ImportCThread)
        {
            return new IFeatureObject(IPartDocinstance.IPartDocInstance.InsertPart(FileName, ImportPlane, ImportAxis, ImportCThread));
        }
        public static void SaveToFile(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.SaveToFile();
        }
        //public static String GetMaterialPropertyName(IPartDocObject IPartDocinstance, String& Database)
        //{
        //    return IPartDocinstance.IPartDocInstance.GetMaterialPropertyName(Database);
        //}
        public static void SetMaterialPropertyName(IPartDocObject IPartDocinstance, String Database, String Name)
        {
            IPartDocinstance.IPartDocInstance.SetMaterialPropertyName(Database, Name);
        }
        //public static Boolean SaveToFile2(IPartDocObject IPartDocinstance, String Name, Int32 Options, Int32& Errors, Int32& Warnings)
        //{
        //    return IPartDocinstance.IPartDocInstance.SaveToFile2(Name, Options, Errors, Warnings);
        //}
        //public static String GetMaterialPropertyName2(IPartDocObject IPartDocinstance, String ConfigName, String& Database)
        //{
        //    return IPartDocinstance.IPartDocInstance.GetMaterialPropertyName2(ConfigName, Database);
        //}
        public static void SetMaterialPropertyName2(IPartDocObject IPartDocinstance, String ConfigName, String Database, String Name)
        {
            IPartDocinstance.IPartDocInstance.SetMaterialPropertyName2(ConfigName, Database, Name);
        }
        public static Object GetCorresponding(IPartDocObject IPartDocinstance, Object InputObject)
        {
            return IPartDocinstance.IPartDocInstance.GetCorresponding(InputObject);
        }
        public static void ImportDiagnosisGapCloser(IPartDocObject IPartDocinstance, Double OldX, Double OldY, Double OldZ, Double NewX, Double NewY, Double NewZ, Boolean LastMove)
        {
            IPartDocinstance.IPartDocInstance.ImportDiagnosisGapCloser(OldX, OldY, OldZ, NewX, NewY, NewZ, LastMove);
        }
        public static Boolean IsWeldment(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.IsWeldment();
        }
        public static IMaterialVisualPropertiesDataObject GetMaterialVisualProperties(IPartDocObject IPartDocinstance)
        {
            return new IMaterialVisualPropertiesDataObject(IPartDocinstance.IPartDocInstance.GetMaterialVisualProperties());
        }
        public static Int32 SetMaterialVisualProperties(IPartDocObject IPartDocinstance, IMaterialVisualPropertiesDataObject Properties, Int32 ConfigOption, Object ConfigNames)
        {
            return IPartDocinstance.IPartDocInstance.SetMaterialVisualProperties(Properties.IMaterialVisualPropertiesDataInstance.CastObj<MaterialVisualPropertiesData>(), ConfigOption, ConfigNames);
        }
        public static void FeatureXpert(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.FeatureXpert();
        }
        public static IFeatureObject InsertPart2(IPartDocObject IPartDocinstance, String FileName, Int32 Options)
        {
            return new IFeatureObject(IPartDocinstance.IPartDocInstance.InsertPart2(FileName, Options));
        }
        public static Boolean ExportFlatPatternView(IPartDocObject IPartDocinstance, String FilePath, Int32 Options)
        {
            return IPartDocinstance.IPartDocInstance.ExportFlatPatternView(FilePath, Options);
        }
        public static Boolean IsMirrored(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.IsMirrored();
        }
        public static void SetCosmosWorksMaterial(IPartDocObject IPartDocinstance, String ConfigName, Int32 Type)
        {
            IPartDocinstance.IPartDocInstance.SetCosmosWorksMaterial(ConfigName, Type);
        }
        public static Boolean SetDroppedFileName(IPartDocObject IPartDocinstance, String FileName)
        {
            return IPartDocinstance.IPartDocInstance.SetDroppedFileName(FileName);
        }
        //public static Boolean IExportToDWG(IPartDocObject IPartDocinstance, String FilePath, String ModelName, Int32 Action, Boolean ExportToSingleFile, Double& Alignment, Boolean IsXDirFlipped, Boolean IsYDirFlipped, Int32 SheetMetalOptions, Int32 ViewsCount, String& Views)
        //{
        //    return IPartDocinstance.IPartDocInstance.IExportToDWG(FilePath, ModelName, Action, ExportToSingleFile, Alignment, IsXDirFlipped, IsYDirFlipped, SheetMetalOptions, ViewsCount, Views);
        //}
        public static Boolean ExportToDWG(IPartDocObject IPartDocinstance, String FilePath, String ModelName, Int32 Action, Boolean ExportToSingleFile, Object Alignment, Boolean IsXDirFlipped, Boolean IsYDirFlipped, Int32 SheetMetalOptions, Object Views)
        {
            return IPartDocinstance.IPartDocInstance.ExportToDWG(FilePath, ModelName, Action, ExportToSingleFile, Alignment, IsXDirFlipped, IsYDirFlipped, SheetMetalOptions, Views);
        }
        public static Boolean RemoveAllDisplayStates(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.RemoveAllDisplayStates();
        }
        //public static IFeatureObject MirrorPart2(IPartDocObject IPartDocinstance, Boolean BreakLink, Int32 Options, ModelDoc2&Object ResultPart)
        //{
        //    return new IFeatureObject(IPartDocinstance.IPartDocInstance.MirrorPart2(BreakLink, Options, ResultPart));
        //}
        //public static Boolean IExportToDWG2(IPartDocObject IPartDocinstance, String FilePath, String ModelName, Int32 Action, Boolean ExportToSingleFile, Double& Alignment, Boolean IsXDirFlipped, Boolean IsYDirFlipped, Int32 SheetMetalOptions, Int32 ViewsCount, String& Views)
        //{
        //    return IPartDocinstance.IPartDocInstance.IExportToDWG2(FilePath, ModelName, Action, ExportToSingleFile, Alignment, IsXDirFlipped, IsYDirFlipped, SheetMetalOptions, ViewsCount, Views);
        //}
        public static Boolean ExportToDWG2(IPartDocObject IPartDocinstance, String FilePath, String ModelName, Int32 Action, Boolean ExportToSingleFile, Object Alignment, Boolean IsXDirFlipped, Boolean IsYDirFlipped, Int32 SheetMetalOptions, Object Views)
        {
            return IPartDocinstance.IPartDocInstance.ExportToDWG2(FilePath, ModelName, Action, ExportToSingleFile, Alignment, IsXDirFlipped, IsYDirFlipped, SheetMetalOptions, Views);
        }
        //public static Boolean SaveToFile3(IPartDocObject IPartDocinstance, String Name, Int32 Options, Int32 CutListProps, Boolean OverrideTemplate, String TemplatePath, Int32& Errors, Int32& Warnings)
        //{
        //    return IPartDocinstance.IPartDocInstance.SaveToFile3(Name, Options, CutListProps, OverrideTemplate, TemplatePath, Errors, Warnings);
        //}
        public static void SetFaceMap(IPartDocObject IPartDocinstance, Int32 NumOfMatchingFaces, Object FaceList1, Object FaceList2, Object OriginalPart)
        {
            IPartDocinstance.IPartDocInstance.SetFaceMap(NumOfMatchingFaces, FaceList1, FaceList2, OriginalPart);
        }
        public static Object FirstFeature(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.FirstFeature();
        }
        public static IFeatureObject IFirstFeature(IPartDocObject IPartDocinstance)
        {
            return new IFeatureObject(IPartDocinstance.IPartDocInstance.IFirstFeature());
        }
        public static Object FeatureByName(IPartDocObject IPartDocinstance, String Name)
        {
            return IPartDocinstance.IPartDocInstance.FeatureByName(Name);
        }
        public static IFeatureObject IFeatureByName(IPartDocObject IPartDocinstance, String Name)
        {
            return new IFeatureObject(IPartDocinstance.IPartDocInstance.IFeatureByName(Name));
        }
        public static Object FeatureById(IPartDocObject IPartDocinstance, Int32 ID)
        {
            return IPartDocinstance.IPartDocInstance.FeatureById(ID);
        }
        public static IFeatureObject IFeatureById(IPartDocObject IPartDocinstance, Int32 ID)
        {
            return new IFeatureObject(IPartDocinstance.IPartDocInstance.IFeatureById(ID));
        }
        public static Object Body(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.Body();
        }
        public static IBodyObject IBodyObject(IPartDocObject IPartDocinstance)
        {
            return new IBodyObject(IPartDocinstance.IPartDocInstance.IBodyObject());
        }
        public static void Dummy18(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy18();
        }
        public static void FeatureExtrusion(IPartDocObject IPartDocinstance, Boolean Sd, Boolean Flip, Boolean Dir, Int32 T1, Int32 T2, Double D1, Double D2, Boolean Dchk1, Boolean Dchk2, Boolean Ddir1, Boolean Ddir2, Double Dang1, Double Dang2, Boolean OffsetReverse1, Boolean OffsetReverse2)
        {
            IPartDocinstance.IPartDocInstance.FeatureExtrusion(Sd, Flip, Dir, T1, T2, D1, D2, Dchk1, Dchk2, Ddir1, Ddir2, Dang1, Dang2, OffsetReverse1, OffsetReverse2);
        }
        public static void FeatureRevolve(IPartDocObject IPartDocinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType)
        {
            IPartDocinstance.IPartDocInstance.FeatureRevolve(Angle, ReverseDir, Angle2, RevType);
        }
        public static void FeatureRevolveCut(IPartDocObject IPartDocinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType)
        {
            IPartDocinstance.IPartDocInstance.FeatureRevolveCut(Angle, ReverseDir, Angle2, RevType);
        }
        public static Object GetTessTriangles(IPartDocObject IPartDocinstance, Boolean NoConversion)
        {
            return IPartDocinstance.IPartDocInstance.GetTessTriangles(NoConversion);
        }
        public static Object GetTessNorms(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.GetTessNorms();
        }
        public static Object GetProcessedBody(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.GetProcessedBody();
        }
        public static IBodyObject IGetProcessedBody(IPartDocObject IPartDocinstance)
        {
            return new IBodyObject(IPartDocinstance.IPartDocInstance.IGetProcessedBody());
        }
        public static Object GetPartBox(IPartDocObject IPartDocinstance, Boolean NoConversion)
        {
            return IPartDocinstance.IPartDocInstance.GetPartBox(NoConversion);
        }
        public static Object CreateNewBody(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.CreateNewBody();
        }
        public static IBodyObject ICreateNewBody(IPartDocObject IPartDocinstance)
        {
            return new IBodyObject(IPartDocinstance.IPartDocInstance.ICreateNewBody());
        }
        public static void EditRebuild(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.EditRebuild();
        }
        public static void Dummy17(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy17();
        }
        public static void Dummy19(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy19();
        }
        public static void ForceRebuild(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.ForceRebuild();
        }
        public static void EditUnsuppressDependent(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.EditUnsuppressDependent();
        }
        public static void EditRollforward(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.EditRollforward();
        }
        public static void InsertStockTurned(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.InsertStockTurned();
        }
        public static void EditUnsuppress(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.EditUnsuppress();
        }
        public static void MakeSection(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.MakeSection();
        }
        public static void Dumpfacets(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dumpfacets();
        }
        public static void FeatureStock(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.FeatureStock();
        }
        public static void EditRollback(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.EditRollback();
        }
        public static void EditSuppress(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.EditSuppress();
        }
        public static Int32 AddPropertyExtension(IPartDocObject IPartDocinstance, Object PropertyExtension)
        {
            return IPartDocinstance.IPartDocInstance.AddPropertyExtension(PropertyExtension);
        }
        public static Object GetPropertyExtension(IPartDocObject IPartDocinstance, Int32 ID)
        {
            return IPartDocinstance.IPartDocInstance.GetPropertyExtension(ID);
        }
        public static void MirrorFeature(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.MirrorFeature();
        }
        public static void ResetPropertyExtension(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.ResetPropertyExtension();
        }
        public static void Dummy1(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy1();
        }
        public static void Dummy2(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy2();
        }
        public static void Dummy3(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy3();
        }
        public static void Dummy4(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy4();
        }
        public static void Dummy5(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy5();
        }
        public static void Dummy6(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy6();
        }
        public static void Dummy7(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy7();
        }
        public static void Dummy8(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy8();
        }
        public static void Dummy9(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy9();
        }
        public static void Dummy10(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy10();
        }
        public static void Dummy11(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy11();
        }
        public static void Dummy12(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy12();
        }
        public static void Dummy13(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy13();
        }
        public static void Dummy14(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy14();
        }
        public static void Dummy15(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy15();
        }
        public static void Dummy16(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.Dummy16();
        }
        public static Object GetProcessedBodyWithSelFace(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.GetProcessedBodyWithSelFace();
        }
        public static IBodyObject IGetProcessedBodyWithSelFace(IPartDocObject IPartDocinstance)
        {
            return new IBodyObject(IPartDocinstance.IPartDocInstance.IGetProcessedBodyWithSelFace());
        }
        public static Object GetTessTriStrips(IPartDocObject IPartDocinstance, Boolean NoConversion)
        {
            return IPartDocinstance.IPartDocInstance.GetTessTriStrips(NoConversion);
        }
        public static Object GetTessTriStripNorms(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.GetTessTriStripNorms();
        }
        public static void MirrorPart(IPartDocObject IPartDocinstance)
        {
            IPartDocinstance.IPartDocInstance.MirrorPart();
        }
        public static Single IGetTessTriangles(IPartDocObject IPartDocinstance, Boolean NoConversion)
        {
            return IPartDocinstance.IPartDocInstance.IGetTessTriangles(NoConversion);
        }
        public static Single IGetTessNorms(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.IGetTessNorms();
        }
        public static Int32 GetTessTriangleCount(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.GetTessTriangleCount();
        }
        public static Double IGetPartBox(IPartDocObject IPartDocinstance, Boolean NoConversion)
        {
            return IPartDocinstance.IPartDocInstance.IGetPartBox(NoConversion);
        }
        public static Single IGetTessTriStrips(IPartDocObject IPartDocinstance, Boolean NoConversion)
        {
            return IPartDocinstance.IPartDocInstance.IGetTessTriStrips(NoConversion);
        }
        public static Single IGetTessTriStripNorms(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.IGetTessTriStripNorms();
        }
        public static Int32 GetTessTriStripSize(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.GetTessTriStripSize();
        }
        public static Object GetEntityByName(IPartDocObject IPartDocinstance, String Name, Int32 EntityType)
        {
            return IPartDocinstance.IPartDocInstance.GetEntityByName(Name, EntityType);
        }
        public static IEntityObject IGetEntityByName(IPartDocObject IPartDocinstance, String Name, Int32 EntityType)
        {
            return new IEntityObject(IPartDocinstance.IPartDocInstance.IGetEntityByName(Name, EntityType));
        }
        public static String GetEntityName(IPartDocObject IPartDocinstance, Object Entity)
        {
            return IPartDocinstance.IPartDocInstance.GetEntityName(Entity);
        }
        public static String IGetEntityName(IPartDocObject IPartDocinstance, IEntityObject Entity)
        {
            return IPartDocinstance.IPartDocInstance.IGetEntityName(Entity.IEntityInstance.CastObj<Entity>());
        }
        public static Boolean SetEntityName(IPartDocObject IPartDocinstance, Object Entity, String StringValue)
        {
            return IPartDocinstance.IPartDocInstance.SetEntityName(Entity, StringValue);
        }
        public static Boolean ISetEntityName(IPartDocObject IPartDocinstance, IEntityObject Entity, String StringValue)
        {
            return IPartDocinstance.IPartDocInstance.ISetEntityName(Entity.IEntityInstance.CastObj<Entity>(), StringValue);
        }
        public static Boolean ReorderFeature(IPartDocObject IPartDocinstance, String FeatureToMove, String MoveAfterFeature)
        {
            return IPartDocinstance.IPartDocInstance.ReorderFeature(FeatureToMove, MoveAfterFeature);
        }
        //public static IEnumBodiesObject EnumRelatedBodies(IPartDocObject IPartDocinstance)
        //{
        //    return new IEnumBodiesObject(IPartDocinstance.IPartDocInstance.EnumRelatedBodies());
        //}
        public static Object GetSectionedBody(IPartDocObject IPartDocinstance, Object ViewIn)
        {
            return IPartDocinstance.IPartDocInstance.GetSectionedBody(ViewIn);
        }
        public static IBodyObject IGetSectionedBody(IPartDocObject IPartDocinstance, IModelViewObject ViewIn)
        {
            return new IBodyObject(IPartDocinstance.IPartDocInstance.IGetSectionedBody(ViewIn.IModelViewInstance.CastObj<ModelView>()));
        }
        //public static IEnumBodiesObject EnumRelatedSectionedBodies(IPartDocObject IPartDocinstance, IModelViewObject ViewIn)
        //{
        //    return new IEnumBodiesObject(IPartDocinstance.IPartDocInstance.EnumRelatedSectionedBodies(ViewIn.IModelViewInstance.CastObj<ModelView>()));
        //}
        public static void FeatureRevolveThin(IPartDocObject IPartDocinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType, Double Thickness1, Double Thickness2, Int32 ReverseThinDir)
        {
            IPartDocinstance.IPartDocInstance.FeatureRevolveThin(Angle, ReverseDir, Angle2, RevType, Thickness1, Thickness2, ReverseThinDir);
        }
        public static void FeatureRevolveThinCut(IPartDocObject IPartDocinstance, Double Angle, Boolean ReverseDir, Double Angle2, Int32 RevType, Double Thickness1, Double Thickness2, Int32 ReverseThinDir)
        {
            IPartDocinstance.IPartDocInstance.FeatureRevolveThinCut(Angle, ReverseDir, Angle2, RevType, Thickness1, Thickness2, ReverseThinDir);
        }
        public static String MaterialUserName(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.MaterialUserName;
        }
        public static String MaterialIdName(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.MaterialIdName;
        }
        public static Object MaterialPropertyValues(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.MaterialPropertyValues;
        }
        public static object IMaterialPropertyValues(IPartDocObject IPartDocinstance)
        {
            return IPartDocinstance.IPartDocInstance.MaterialPropertyValues;
        }
    }
}