using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFace2Object
    {
        public IFace2 IFace2Instance { get; set; }
        public IFace2Object(IFace2 IFace2instance)
        {
            IFace2Instance = IFace2instance;
        }
    }
    public static class IFace2Interface
    {
        public static IFeatureObject IGetPatternSeedFeature(IFace2Object IFace2instance)
        {
            return new IFeatureObject(IFace2instance.IFace2Instance.IGetPatternSeedFeature());
        }
        public static void SetMaterialPropertyValues2(IFace2Object IFace2instance, Object Material_values, Int32 Config_opt, Object Config_names)
        {
            IFace2instance.IFace2Instance.SetMaterialPropertyValues2(Material_values, Config_opt, Config_names);
        }
        //public static void ISetMaterialPropertyValues2(IFace2Object IFace2instance, Double& Material_values, Int32 Config_opt, Int32 Config_count, String& Config_names)
        //{
        //    return IFace2instance.IFace2Instance.ISetMaterialPropertyValues2(Material_values, Config_opt, Config_count, Config_names);
        //}
        public static Object GetMaterialPropertyValues2(IFace2Object IFace2instance, Int32 Config_opt, Object Config_names)
        {
            return IFace2instance.IFace2Instance.GetMaterialPropertyValues2(Config_opt, Config_names);
        }
        //public static Double IGetMaterialPropertyValues2(IFace2Object IFace2instance, Int32 Config_opt, Int32 Config_count, String& Config_names)
        //{
        //    return IFace2instance.IFace2Instance.IGetMaterialPropertyValues2(Config_opt, Config_count, Config_names);
        //}
        public static Single IGetTessTextures(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.IGetTessTextures();
        }
        public static Boolean RemoveMaterialProperty2(IFace2Object IFace2instance, Int32 Config_opt, Object Config_names)
        {
            return IFace2instance.IFace2Instance.RemoveMaterialProperty2(Config_opt, Config_names);
        }
        //public static Boolean IRemoveMaterialProperty2(IFace2Object IFace2instance, Int32 Config_opt, Int32 Config_count, String& Config_names)
        //{
        //    return IFace2instance.IFace2Instance.IRemoveMaterialProperty2(Config_opt, Config_count, Config_names);
        //}
        //public static void ImprintCurve(IFace2Object IFace2instance, Object Curve, Object& NewEdges, Object& NewFaces)
        //{
        //    return IFace2instance.IFace2Instance.ImprintCurve(Curve, NewEdges, NewFaces);
        //}
        //public static void ImprintCurveCount(IFace2Object IFace2instance, CurveObject Curve, Int32& NewEdgeCount, Int32& NewFaceCount)
        //{
        //    return IFace2instance.IFace2Instance.ImprintCurveCount(Curve, NewEdgeCount, NewFaceCount);
        //}
        //public static void IImprintCurve(IFace2Object IFace2instance, CurveObject Curve, Int32 NewEdgeCount, Edge&Object NewEdges, Int32 NewFaceCount, Face2&Object NewFaces)
        //{
        //    return IFace2instance.IFace2Instance.IImprintCurve(Curve, NewEdgeCount, NewEdges, NewFaceCount, NewFaces);
        //}
        public static Boolean AttachSurface(IFace2Object IFace2instance, ISurfaceObject SurfIn, Boolean SenseIn)
        {
            return IFace2instance.IFace2Instance.AttachSurface(SurfIn.ISurfaceInstance as Surface, SenseIn);
        }
        public static Boolean DetachSurface(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.DetachSurface();
        }
        public static ITextureObject GetTexture(IFace2Object IFace2instance, String Config_name)
        {
            return new ITextureObject(IFace2instance.IFace2Instance.GetTexture(Config_name));
        }
        public static Boolean SetTexture(IFace2Object IFace2instance, String Config_name, ITextureObject TextureIn)
        {
            return IFace2instance.IFace2Instance.SetTexture(Config_name, TextureIn.ITextureInstance as Texture);
        }
        public static Boolean RemoveTexture(IFace2Object IFace2instance, String Config_name)
        {
            return IFace2instance.IFace2Instance.RemoveTexture(Config_name);
        }
        public static Object GetTessTextures(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetTessTextures();
        }
        public static IMathPointObject GetProjectedPointOn(IFace2Object IFace2instance, IMathPointObject Point, IMathVectorObject Direction)
        {
            return new IMathPointObject(IFace2instance.IFace2Instance.GetProjectedPointOn(Point.IMathPointInstance as MathPoint, Direction.IMathVectorInstance as MathVector));
        }
        public static Int32 IsCoincident(IFace2Object IFace2instance, Object FaceIn, Double Tolerance)
        {
            return IFace2instance.IFace2Instance.IsCoincident(FaceIn, Tolerance);
        }
        public static Int32 IIsCoincident(IFace2Object IFace2instance, IFace2Object FaceIn, Double Tolerance)
        {
            return IFace2instance.IFace2Instance.IIsCoincident(FaceIn.IFace2Instance as Face2, Tolerance);
        }
        public static Int32 GetDecalsCount(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetDecalsCount();
        }
        public static Object GetAllDecalProperties(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetAllDecalProperties();
        }
        public static IFaceDecalPropertiesObject IGetAllDecalProperties(IFace2Object IFace2instance, Int32 Count)
        {
            return new IFaceDecalPropertiesObject(IFace2instance.IFace2Instance.IGetAllDecalProperties(Count));
        }
        //public static void IGetDecalProperties(IFace2Object IFace2instance, DecalObject PDecal, FaceDecalProperties&Object pFaceDecalProperties)
        //{
        //    return IFace2instance.IFace2Instance.IGetDecalProperties(PDecal, pFaceDecalProperties);
        //}
        public static IFeatureObject GetSeedFeature(IFace2Object IFace2instance)
        {
            return new IFeatureObject(IFace2instance.IFace2Instance.GetSeedFeature());
        }
        //public static Int32 GetTrackingIDs(IFace2Object IFace2instance, Int32 TrackingCookie, Object& TrackingIDs)
        //{
        //    return IFace2instance.IFace2Instance.GetTrackingIDs(TrackingCookie, TrackingIDs);
        //}
        public static Int32 SetTrackingID(IFace2Object IFace2instance, Int32 TrackingCookie, Int32 TrackingID)
        {
            return IFace2instance.IFace2Instance.SetTrackingID(TrackingCookie, TrackingID);
        }
        public static Int32 RemoveTrackingID(IFace2Object IFace2instance, Int32 TrackingCookie)
        {
            return IFace2instance.IFace2Instance.RemoveTrackingID(TrackingCookie);
        }
        public static Object GetLoops(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetLoops();
        }
        public static ILoop2Object IGetLoops(IFace2Object IFace2instance, Int32 NumberOfLoops)
        {
            return new ILoop2Object(IFace2instance.IFace2Instance.IGetLoops(NumberOfLoops));
        }
        public static Int32 GetTrackingIDsCount(IFace2Object IFace2instance, Int32 TrackingCookie)
        {
            return IFace2instance.IFace2Instance.GetTrackingIDsCount(TrackingCookie);
        }
        //public static Int32 IGetTrackingIDs(IFace2Object IFace2instance, Int32 TrackingCookie, Int32 Count, Int32& TrackingIDs)
        //{
        //    return IFace2instance.IFace2Instance.IGetTrackingIDs(TrackingCookie, Count, TrackingIDs);
        //}
        public static Object ReverseEvaluate(IFace2Object IFace2instance, Double PositionX, Double PositionY, Double PositionZ)
        {
            return IFace2instance.IFace2Instance.ReverseEvaluate(PositionX, PositionY, PositionZ);
        }
        public static Double IReverseEvaluate(IFace2Object IFace2instance, Double PositionX, Double PositionY, Double PositionZ)
        {
            return IFace2instance.IFace2Instance.IReverseEvaluate(PositionX, PositionY, PositionZ);
        }
        public static Boolean SetTextureByDisplayState(IFace2Object IFace2instance, String DisplayStateName, ITextureObject TextureIn)
        {
            return IFace2instance.IFace2Instance.SetTextureByDisplayState(DisplayStateName, TextureIn.ITextureInstance as Texture);
        }
        public static Boolean RemoveTextureByDisplayState(IFace2Object IFace2instance, String DisplayStateName)
        {
            return IFace2instance.IFace2Instance.RemoveTextureByDisplayState(DisplayStateName);
        }
        public static Boolean RemoveTexture2(IFace2Object IFace2instance, String Config_name)
        {
            return IFace2instance.IFace2Instance.RemoveTexture2(Config_name);
        }
        public static Boolean HasMaterialPropertyValues(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.HasMaterialPropertyValues();
        }
        public static Object GetNextFace(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetNextFace();
        }
        public static IFace2Object IGetNextFace(IFace2Object IFace2instance)
        {
            return new IFace2Object(IFace2instance.IFace2Instance.IGetNextFace());
        }
        public static Object GetSurface(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetSurface();
        }
        public static ISurfaceObject IGetSurface(IFace2Object IFace2instance)
        {
            return new ISurfaceObject(IFace2instance.IFace2Instance.IGetSurface());
        }
        public static Int32 GetEdgeCount(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetEdgeCount();
        }
        public static Object GetEdges(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetEdges();
        }
        public static IEdgeObject IGetEdges(IFace2Object IFace2instance)
        {
            return new IEdgeObject(IFace2instance.IFace2Instance.IGetEdges());
        }
        public static Object GetFeature(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetFeature();
        }
        public static IFeatureObject IGetFeature(IFace2Object IFace2instance)
        {
            return new IFeatureObject(IFace2instance.IFace2Instance.IGetFeature());
        }
        public static Int32 GetFeatureId(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetFeatureId();
        }
        public static Object GetTrimCurves(IFace2Object IFace2instance, Boolean WantCubic)
        {
            return IFace2instance.IFace2Instance.GetTrimCurves(WantCubic);
        }
        public static Object GetUVBounds(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetUVBounds();
        }
        public static Boolean FaceInSurfaceSense(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.FaceInSurfaceSense();
        }
        public static Int32 GetLoopCount(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetLoopCount();
        }
        public static Object GetFirstLoop(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetFirstLoop();
        }
        public static ILoop2Object IGetFirstLoop(IFace2Object IFace2instance)
        {
            return new ILoop2Object(IFace2instance.IFace2Instance.IGetFirstLoop());
        }
        public static Boolean IsSame(IFace2Object IFace2instance, Object FaceIn)
        {
            return IFace2instance.IFace2Instance.IsSame(FaceIn);
        }
        public static Boolean IIsSame(IFace2Object IFace2instance, IFace2Object FaceIn)
        {
            return IFace2instance.IFace2Instance.IIsSame(FaceIn.IFace2Instance as Face2);
        }
        public static Int32 AddPropertyExtension(IFace2Object IFace2instance, Object PropertyExtension)
        {
            return IFace2instance.IFace2Instance.AddPropertyExtension(PropertyExtension);
        }
        public static Object GetPropertyExtension(IFace2Object IFace2instance, Int32 ID)
        {
            return IFace2instance.IFace2Instance.GetPropertyExtension(ID);
        }
        public static void ResetPropertyExtension(IFace2Object IFace2instance)
        {
            IFace2instance.IFace2Instance.ResetPropertyExtension();
        }
        public static Object GetTessTriangles(IFace2Object IFace2instance, Boolean NoConversion)
        {
            return IFace2instance.IFace2Instance.GetTessTriangles(NoConversion);
        }
        public static Object GetTessNorms(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetTessNorms();
        }
        public static Object GetTessTriStrips(IFace2Object IFace2instance, Boolean NoConversion)
        {
            return IFace2instance.IFace2Instance.GetTessTriStrips(NoConversion);
        }
        public static Object GetTessTriStripNorms(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetTessTriStripNorms();
        }
        //public static IEnumLoops2Object EnumLoops(IFace2Object IFace2instance)
        //{
        //    return new IEnumLoops2Object(IFace2instance.IFace2Instance.EnumLoops());
        //}
        //public static IEnumEdgesObject EnumEdges(IFace2Object IFace2instance)
        //{
        //    return new IEnumEdgesObject(IFace2instance.IFace2Instance.EnumEdges());
        //}
        public static Object GetBody(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetBody();
        }
        public static IBody2Object IGetBody(IFace2Object IFace2instance)
        {
            return new IBody2Object(IFace2instance.IFace2Instance.IGetBody());
        }
        public static Single IGetTessTriangles(IFace2Object IFace2instance, Boolean NoConversion)
        {
            return IFace2instance.IFace2Instance.IGetTessTriangles(NoConversion);
        }
        public static Single IGetTessNorms(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.IGetTessNorms();
        }
        public static Int32 GetTessTriangleCount(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetTessTriangleCount();
        }
        public static Single IGetTessTriStrips(IFace2Object IFace2instance, Boolean NoConversion)
        {
            return IFace2instance.IFace2Instance.IGetTessTriStrips(NoConversion);
        }
        public static Single IGetTessTriStripNorms(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.IGetTessTriStripNorms();
        }
        public static Int32 GetTessTriStripSize(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetTessTriStripSize();
        }
        public static Double IGetUVBounds(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.IGetUVBounds();
        }
        public static Object GetClosestPointOn(IFace2Object IFace2instance, Double X, Double Y, Double Z)
        {
            return IFace2instance.IFace2Instance.GetClosestPointOn(X, Y, Z);
        }
        public static Double IGetClosestPointOn(IFace2Object IFace2instance, Double X, Double Y, Double Z)
        {
            return IFace2instance.IFace2Instance.IGetClosestPointOn(X, Y, Z);
        }
        public static void Highlight(IFace2Object IFace2instance, Boolean State)
        {
            IFace2instance.IFace2Instance.Highlight(State);
        }
        public static void IHighlight(IFace2Object IFace2instance, Boolean State)
        {
            IFace2instance.IFace2Instance.IHighlight(State);
        }
        public static Object GetTrimCurveTopology(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetTrimCurveTopology();
        }
        public static Object IGetTrimCurveTopology(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.IGetTrimCurveTopology();
        }
        public static Int32 GetTrimCurveTopologyCount(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetTrimCurveTopologyCount();
        }
        public static Object GetTrimCurveTopologyTypes(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetTrimCurveTopologyTypes();
        }
        public static Int32 IGetTrimCurveTopologyTypes(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.IGetTrimCurveTopologyTypes();
        }
        public static Boolean RemoveRedundantTopology(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.RemoveRedundantTopology();
        }
        public static Object CreateSheetBodyByFaceExtension(IFace2Object IFace2instance, Object BoxLowIn, Object BoxHighIn)
        {
            return IFace2instance.IFace2Instance.CreateSheetBodyByFaceExtension(BoxLowIn, BoxHighIn);
        }
        //public static IBody2Object ICreateSheetBodyByFaceExtension(IFace2Object IFace2instance, Double& BoxLowIn, Double& BoxHighIn)
        //{
        //    return new IBody2Object(IFace2instance.IFace2Instance.ICreateSheetBodyByFaceExtension(BoxLowIn, BoxHighIn));
        //}
        public static Double GetArea(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetArea();
        }
        public static Object GetBox(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetBox();
        }
        public static Double IGetBox(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.IGetBox();
        }
        public static Object RemoveInnerLoops(IFace2Object IFace2instance, Int32 NumOfLoops, Object InnerLoopsIn)
        {
            return IFace2instance.IFace2Instance.RemoveInnerLoops(NumOfLoops, InnerLoopsIn);
        }
        //public static IFace2Object IRemoveInnerLoops(IFace2Object IFace2instance, Int32 NumOfLoops, Loop2&Object InnerLoopsIn)
        //{
        //    return new IFace2Object(IFace2instance.IFace2Instance.IRemoveInnerLoops(NumOfLoops, InnerLoopsIn));
        //}
        public static Object CreateSheetBody(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.CreateSheetBody();
        }
        public static IBody2Object ICreateSheetBody(IFace2Object IFace2instance)
        {
            return new IBody2Object(IFace2instance.IFace2Instance.ICreateSheetBody());
        }
        //public static Object GetSilhoutteEdges(IFace2Object IFace2instance, Double& Root, Double& Normal)
        //{
        //    return IFace2instance.IFace2Instance.GetSilhoutteEdges(Root, Normal);
        //}
        //public static IEdgeObject IGetSilhoutteEdges(IFace2Object IFace2instance, Double& Root, Double& Normal)
        //{
        //    return new IEdgeObject(IFace2instance.IFace2Instance.IGetSilhoutteEdges(Root, Normal));
        //}
        //public static Int32 IGetSilhoutteEdgeCount(IFace2Object IFace2instance, Double& Root, Double& Normal)
        //{
        //    return IFace2instance.IFace2Instance.IGetSilhoutteEdgeCount(Root, Normal);
        //}
        public static Int32 IGetTrimCurveSize(IFace2Object IFace2instance, Boolean WantCubic)
        {
            return IFace2instance.IFace2Instance.IGetTrimCurveSize(WantCubic);
        }
        public static Double IGetTrimCurve(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.IGetTrimCurve();
        }
        public static Int32 GetFaceId(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetFaceId();
        }
        public static void SetFaceId(IFace2Object IFace2instance, Int32 IdIn)
        {
            IFace2instance.IFace2Instance.SetFaceId(IdIn);
        }
        public static Int32 IGetTrimCurveSize2(IFace2Object IFace2instance, Int32 WantCubic, Int32 WantNRational)
        {
            return IFace2instance.IFace2Instance.IGetTrimCurveSize2(WantCubic, WantNRational);
        }
        public static Object GetSilhoutteEdgesVB(IFace2Object IFace2instance, Double Xroot, Double Yroot, Double Zroot, Double Xnormal, Double Ynormal, Double Znormal)
        {
            return IFace2instance.IFace2Instance.GetSilhoutteEdgesVB(Xroot, Yroot, Zroot, Xnormal, Ynormal, Znormal);
        }
        public static void RemoveFaceId(IFace2Object IFace2instance, Int32 IdIn)
        {
            IFace2instance.IFace2Instance.RemoveFaceId(IdIn);
        }
        public static Object GetTrimCurves2(IFace2Object IFace2instance, Boolean WantCubic, Boolean WantNRational)
        {
            return IFace2instance.IFace2Instance.GetTrimCurves2(WantCubic, WantNRational);
        }
        public static Int32 GetShellType(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetShellType();
        }
        //public static void IGetFacetData(IFace2Object IFace2instance, Int32 FacetMesh, Int32& NFacets, Int32& NStrips, Int32& StripVertexNums, Single& VertexCoords, Single& NormalCoords)
        //{
        //    return IFace2instance.IFace2Instance.IGetFacetData(FacetMesh, NFacets, NStrips, StripVertexNums, VertexCoords, NormalCoords);
        //}
        public static Object GetTessTriStripEdges(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetTessTriStripEdges();
        }
        public static Int32 IGetTessTriStripEdges(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.IGetTessTriStripEdges();
        }
        public static Int32 IGetTessTriStripEdgeSize(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.IGetTessTriStripEdgeSize();
        }
        public static Boolean RemoveMaterialProperty(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.RemoveMaterialProperty();
        }
        public static Object GetPatternSeedFeature(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.GetPatternSeedFeature();
        }
        public static Object Normal(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.Normal;
        }
        public static String MaterialUserName(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.MaterialUserName;
        }
        public static String MaterialIdName(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.MaterialIdName;
        }
        public static Object MaterialPropertyValues(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.MaterialPropertyValues;
        }
        public static object INormal(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.Normal;
        }
        public static object IMaterialPropertyValues(IFace2Object IFace2instance)
        {
            return IFace2instance.IFace2Instance.MaterialPropertyValues;
        }
        public static IFaultEntityObject Check(IFace2Object IFace2instance)
        {
            return new IFaultEntityObject(IFace2instance.IFace2Instance.Check);
        }
    }
}