using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRayTraceRendererOptionsObject
    {
        public IRayTraceRendererOptions IRayTraceRendererOptionsInstance { get; set; }
        public IRayTraceRendererOptionsObject(IRayTraceRendererOptions IRayTraceRendererOptionsinstance)
        {
            IRayTraceRendererOptionsInstance = IRayTraceRendererOptionsinstance;
        }
    }
    public static class IRayTraceRendererOptionsInterface
    {
        public static void UpdateGraphics(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.UpdateGraphics();
        }
        public static Int32 ImageWidth(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.ImageWidth;
        }
        public static Int32 ImageHeight(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.ImageHeight;
        }
        public static Int32 ImageFormat(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.ImageFormat;
        }
        public static Int32 PreviewRenderQuality(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.PreviewRenderQuality;
        }
        public static Int32 FinalRenderQuality(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.FinalRenderQuality;
        }
        public static Boolean BloomEnabled(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.BloomEnabled;
        }
        public static Int32 BloomThreshold(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.BloomThreshold;
        }
        public static Int32 BloomRadius(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.BloomRadius;
        }
        public static Boolean ContourEnabled(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.ContourEnabled;
        }
        public static Boolean ShadedContour(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.ShadedContour;
        }
        public static Int32 ContourLineThickness(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.ContourLineThickness;
        }
        public static Int32 ContourLineColor(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.ContourLineColor;
        }
        public static Boolean UseSolidWorksViewAspectRatio(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.UseSolidWorksViewAspectRatio;
        }
        public static String DefaultImagePath(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.DefaultImagePath;
        }
        public static Boolean UseSceneBackgroundImageAspectRatio(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.UseSceneBackgroundImageAspectRatio;
        }
        public static Boolean OutputAmbientOcclusion(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.OutputAmbientOcclusion;
        }
        public static Boolean DirectCaustics(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.DirectCaustics;
        }
        public static Int32 CausticQuality(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.CausticQuality;
        }
        public static Double Gamma(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.Gamma;
        }
        public static Int32 NumberOfReflections(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.NumberOfReflections;
        }
        public static Int32 NumberOfRefractions(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.NumberOfRefractions;
        }
        public static Boolean NetworkRendering(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.NetworkRendering;
        }
        public static Int32 ClientWorkload(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.ClientWorkload;
        }
        public static Boolean SendDataForNetworkJob(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.SendDataForNetworkJob;
        }
        public static String NetworkSharedDirectory(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.NetworkSharedDirectory;
        }
        public static Int32 CausticAmount(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.CausticAmount;
        }
        public static Boolean CustomRenderSettings(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.CustomRenderSettings;
        }
        public static Boolean ContourCartoonRenderingEnabled(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.ContourCartoonRenderingEnabled;
        }
        public static Boolean HasCartoonEdges(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.HasCartoonEdges;
        }
        public static Boolean HasCartoonShading(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.HasCartoonShading;
        }
        public static Boolean IncludeAnnotationsInRendering(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.IncludeAnnotationsInRendering;
        }
        public static Int32 RenderType(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.RenderType;
        }
        public static Boolean RenderAnnotationsToSeparateImage(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.RenderAnnotationsToSeparateImage;
        }
        public static Boolean AlphaOutput(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.AlphaOutput;
        }
        public static Boolean OffloadedRendering(IRayTraceRendererOptionsObject IRayTraceRendererOptionsinstance)
        {
            return IRayTraceRendererOptionsinstance.IRayTraceRendererOptionsInstance.OffloadedRendering;
        }
    }
}