using SolidWorks.Interop.sldworks;

namespace DynamoSolidWorks
{
    public class IFaceObject
    {
        public IFace IFaceInstance { get; set; }
        public IFaceObject(IFace IFaceinstance)
        {
            IFaceInstance = IFaceinstance;
        }
    }

    /*
     * not use IFaceInterface Now
     */

    //public static class IFaceInterface
    //{
    //    public static IFeatureObject IGetPatternSeedFeature(IFaceObject IFaceinstance)
    //    {
    //        return new IFeatureObject(IFaceinstance.IFaceInstance.IGetPatternSeedFeature());
    //    }
    //    public static Object GetNextFace(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetNextFace();
    //    }
    //    public static IFaceObject IGetNextFace(IFaceObject IFaceinstance)
    //    {
    //        return new IFaceObject(IFaceinstance.IFaceInstance.IGetNextFace());
    //    }
    //    public static Object GetSurface(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetSurface();
    //    }
    //    public static ISurfaceObject IGetSurface(IFaceObject IFaceinstance)
    //    {
    //        return new ISurfaceObject(IFaceinstance.IFaceInstance.IGetSurface());
    //    }
    //    public static Int32 GetEdgeCount(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetEdgeCount();
    //    }
    //    public static Object GetEdges(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetEdges();
    //    }
    //    public static IntPtr IGetEdges(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetEdges();
    //    }
    //    public static Object GetFeature(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetFeature();
    //    }
    //    public static IFeatureObject IGetFeature(IFaceObject IFaceinstance)
    //    {
    //        return new IFeatureObject(IFaceinstance.IFaceInstance.IGetFeature());
    //    }
    //    public static Int32 GetFeatureId(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetFeatureId();
    //    }
    //    public static Object GetTrimCurves(IFaceObject IFaceinstance, Boolean WantCubic)
    //    {
    //        return IFaceinstance.IFaceInstance.GetTrimCurves(WantCubic);
    //    }
    //    public static Object GetUVBounds(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetUVBounds();
    //    }
    //    public static Boolean FaceInSurfaceSense(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.FaceInSurfaceSense();
    //    }
    //    public static Int32 GetLoopCount(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetLoopCount();
    //    }
    //    public static Object GetFirstLoop(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetFirstLoop();
    //    }
    //    public static ILoopObject IGetFirstLoop(IFaceObject IFaceinstance)
    //    {
    //        return new ILoopObject(IFaceinstance.IFaceInstance.IGetFirstLoop());
    //    }
    //    public static Boolean IsSame(IFaceObject IFaceinstance, Object FaceIn)
    //    {
    //        return IFaceinstance.IFaceInstance.IsSame(FaceIn);
    //    }
    //    public static Boolean IIsSame(IFaceObject IFaceinstance, FaceObject FaceIn)
    //    {
    //        return IFaceinstance.IFaceInstance.IIsSame(FaceIn);
    //    }
    //    public static Int32 AddPropertyExtension(IFaceObject IFaceinstance, Object PropertyExtension)
    //    {
    //        return IFaceinstance.IFaceInstance.AddPropertyExtension(PropertyExtension);
    //    }
    //    public static Object GetPropertyExtension(IFaceObject IFaceinstance, Int32 ID)
    //    {
    //        return IFaceinstance.IFaceInstance.GetPropertyExtension(ID);
    //    }
    //    public static void ResetPropertyExtension(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.ResetPropertyExtension();
    //    }
    //    public static Object GetTessTriangles(IFaceObject IFaceinstance, Boolean NoConversion)
    //    {
    //        return IFaceinstance.IFaceInstance.GetTessTriangles(NoConversion);
    //    }
    //    public static Object GetTessNorms(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetTessNorms();
    //    }
    //    public static Object GetTessTriStrips(IFaceObject IFaceinstance, Boolean NoConversion)
    //    {
    //        return IFaceinstance.IFaceInstance.GetTessTriStrips(NoConversion);
    //    }
    //    public static Object GetTessTriStripNorms(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetTessTriStripNorms();
    //    }
    //    public static IEnumLoopsObject EnumLoops(IFaceObject IFaceinstance)
    //    {
    //        return new IEnumLoopsObject(IFaceinstance.IFaceInstance.EnumLoops());
    //    }
    //    public static IEnumEdgesObject EnumEdges(IFaceObject IFaceinstance)
    //    {
    //        return new IEnumEdgesObject(IFaceinstance.IFaceInstance.EnumEdges());
    //    }
    //    public static Object GetBody(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetBody();
    //    }
    //    public static IBodyObject IGetBody(IFaceObject IFaceinstance)
    //    {
    //        return new IBodyObject(IFaceinstance.IFaceInstance.IGetBody());
    //    }
    //    public static Single IGetTessTriangles(IFaceObject IFaceinstance, Boolean NoConversion)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetTessTriangles(NoConversion);
    //    }
    //    public static Single IGetTessNorms(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetTessNorms();
    //    }
    //    public static Int32 GetTessTriangleCount(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetTessTriangleCount();
    //    }
    //    public static Single IGetTessTriStrips(IFaceObject IFaceinstance, Boolean NoConversion)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetTessTriStrips(NoConversion);
    //    }
    //    public static Single IGetTessTriStripNorms(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetTessTriStripNorms();
    //    }
    //    public static Int32 GetTessTriStripSize(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetTessTriStripSize();
    //    }
    //    public static Double IGetUVBounds(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetUVBounds();
    //    }
    //    public static Object GetClosestPointOn(IFaceObject IFaceinstance, Double X, Double Y, Double Z)
    //    {
    //        return IFaceinstance.IFaceInstance.GetClosestPointOn(X, Y, Z);
    //    }
    //    public static Double IGetClosestPointOn(IFaceObject IFaceinstance, Double X, Double Y, Double Z)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetClosestPointOn(X, Y, Z);
    //    }
    //    public static void Highlight(IFaceObject IFaceinstance, Boolean State)
    //    {
    //        return IFaceinstance.IFaceInstance.Highlight(State);
    //    }
    //    public static void IHighlight(IFaceObject IFaceinstance, Boolean State)
    //    {
    //        return IFaceinstance.IFaceInstance.IHighlight(State);
    //    }
    //    public static Object GetTrimCurveTopology(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetTrimCurveTopology();
    //    }
    //    public static IntPtr IGetTrimCurveTopology(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetTrimCurveTopology();
    //    }
    //    public static Int32 GetTrimCurveTopologyCount(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetTrimCurveTopologyCount();
    //    }
    //    public static Object GetTrimCurveTopologyTypes(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetTrimCurveTopologyTypes();
    //    }
    //    public static Int32 IGetTrimCurveTopologyTypes(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetTrimCurveTopologyTypes();
    //    }
    //    public static Boolean RemoveRedundantTopology(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.RemoveRedundantTopology();
    //    }
    //    public static Object CreateSheetBodyByFaceExtension(IFaceObject IFaceinstance, Object BoxLowIn, Object BoxHighIn)
    //    {
    //        return IFaceinstance.IFaceInstance.CreateSheetBodyByFaceExtension(BoxLowIn, BoxHighIn);
    //    }
    //    public static IBodyObject ICreateSheetBodyByFaceExtension(IFaceObject IFaceinstance, Double& BoxLowIn, Double& BoxHighIn)
    //    {
    //        return new IBodyObject(IFaceinstance.IFaceInstance.ICreateSheetBodyByFaceExtension(BoxLowIn, BoxHighIn));
    //    }
    //    public static Double GetArea(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetArea();
    //    }
    //    public static Object GetBox(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetBox();
    //    }
    //    public static Double IGetBox(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetBox();
    //    }
    //    public static Object RemoveInnerLoops(IFaceObject IFaceinstance, Int32 NumOfLoops, Object InnerLoopsIn)
    //    {
    //        return IFaceinstance.IFaceInstance.RemoveInnerLoops(NumOfLoops, InnerLoopsIn);
    //    }
    //    public static IFaceObject IRemoveInnerLoops(IFaceObject IFaceinstance, Int32 NumOfLoops, Loop&Object InnerLoopsIn)
    //    {
    //        return new IFaceObject(IFaceinstance.IFaceInstance.IRemoveInnerLoops(NumOfLoops, InnerLoopsIn));
    //    }
    //    public static Object CreateSheetBody(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.CreateSheetBody();
    //    }
    //    public static IBodyObject ICreateSheetBody(IFaceObject IFaceinstance)
    //    {
    //        return new IBodyObject(IFaceinstance.IFaceInstance.ICreateSheetBody());
    //    }
    //    public static Object GetSilhoutteEdges(IFaceObject IFaceinstance, Double& Root, Double& Normal)
    //    {
    //        return IFaceinstance.IFaceInstance.GetSilhoutteEdges(Root, Normal);
    //    }
    //    public static IntPtr IGetSilhoutteEdges(IFaceObject IFaceinstance, Double& Root, Double& Normal)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetSilhoutteEdges(Root, Normal);
    //    }
    //    public static Int32 IGetSilhoutteEdgeCount(IFaceObject IFaceinstance, Double& Root, Double& Normal)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetSilhoutteEdgeCount(Root, Normal);
    //    }
    //    public static Int32 IGetTrimCurveSize(IFaceObject IFaceinstance, Boolean WantCubic)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetTrimCurveSize(WantCubic);
    //    }
    //    public static Double IGetTrimCurve(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetTrimCurve();
    //    }
    //    public static Int32 GetFaceId(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetFaceId();
    //    }
    //    public static void SetFaceId(IFaceObject IFaceinstance, Int32 IdIn)
    //    {
    //        return IFaceinstance.IFaceInstance.SetFaceId(IdIn);
    //    }
    //    public static Int32 IGetTrimCurveSize2(IFaceObject IFaceinstance, Int32 WantCubic, Int32 WantNRational)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetTrimCurveSize2(WantCubic, WantNRational);
    //    }
    //    public static Object GetSilhoutteEdgesVB(IFaceObject IFaceinstance, Double Xroot, Double Yroot, Double Zroot, Double Xnormal, Double Ynormal, Double Znormal)
    //    {
    //        return IFaceinstance.IFaceInstance.GetSilhoutteEdgesVB(Xroot, Yroot, Zroot, Xnormal, Ynormal, Znormal);
    //    }
    //    public static void RemoveFaceId(IFaceObject IFaceinstance, Int32 IdIn)
    //    {
    //        return IFaceinstance.IFaceInstance.RemoveFaceId(IdIn);
    //    }
    //    public static Object GetTrimCurves2(IFaceObject IFaceinstance, Boolean WantCubic, Boolean WantNRational)
    //    {
    //        return IFaceinstance.IFaceInstance.GetTrimCurves2(WantCubic, WantNRational);
    //    }
    //    public static Int32 GetShellType(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetShellType();
    //    }
    //    public static void IGetFacetData(IFaceObject IFaceinstance, Int32 FacetMesh, Int32& NFacets, Int32& NStrips, IntPtr StripVertexNums, IntPtr VertexCoords, IntPtr NormalCoords)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetFacetData(FacetMesh, NFacets, NStrips, StripVertexNums, VertexCoords, NormalCoords);
    //    }
    //    public static Object GetTessTriStripEdges(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetTessTriStripEdges();
    //    }
    //    public static Int32 IGetTessTriStripEdges(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetTessTriStripEdges();
    //    }
    //    public static Int32 IGetTessTriStripEdgeSize(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.IGetTessTriStripEdgeSize();
    //    }
    //    public static Boolean RemoveMaterialProperty(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.RemoveMaterialProperty();
    //    }
    //    public static Object GetPatternSeedFeature(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.GetPatternSeedFeature();
    //    }
    //    public static Object Normal(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.Normal;
    //    }
    //    public static String MaterialUserName(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.MaterialUserName;
    //    }
    //    public static String MaterialIdName(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.MaterialIdName;
    //    }
    //    public static Object MaterialPropertyValues(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.MaterialPropertyValues;
    //    }
    //    public static Double INormal(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.INormal;
    //    }
    //    public static Double IMaterialPropertyValues(IFaceObject IFaceinstance)
    //    {
    //        return IFaceinstance.IFaceInstance.IMaterialPropertyValues;
    //    }
    //}
}