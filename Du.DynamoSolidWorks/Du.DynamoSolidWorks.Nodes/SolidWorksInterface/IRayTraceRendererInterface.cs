using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRayTraceRendererObject
    {
        public IRayTraceRenderer IRayTraceRendererInstance { get; set; }
        public IRayTraceRendererObject(IRayTraceRenderer IRayTraceRendererinstance)
        {
            IRayTraceRendererInstance = IRayTraceRendererinstance;
        }
    }
    public static class IRayTraceRendererInterface
    {
        public static Boolean RenderToFile(IRayTraceRendererObject IRayTraceRendererinstance, String ImageFileName, Int32 Width, Int32 Height)
        {
            return IRayTraceRendererinstance.IRayTraceRendererInstance.RenderToFile(ImageFileName, Width, Height);
        }
        public static Boolean CloseRayTraceRender(IRayTraceRendererObject IRayTraceRendererinstance)
        {
            return IRayTraceRendererinstance.IRayTraceRendererInstance.CloseRayTraceRender();
        }
        public static Boolean DisplayPreviewWindow(IRayTraceRendererObject IRayTraceRendererinstance)
        {
            return IRayTraceRendererinstance.IRayTraceRendererInstance.DisplayPreviewWindow();
        }
        public static Boolean InvokeFinalRender(IRayTraceRendererObject IRayTraceRendererinstance)
        {
            return IRayTraceRendererinstance.IRayTraceRendererInstance.InvokeFinalRender();
        }
        public static Boolean AbortFinalRender(IRayTraceRendererObject IRayTraceRendererinstance)
        {
            return IRayTraceRendererinstance.IRayTraceRendererInstance.AbortFinalRender();
        }
        public static Boolean CloseFinalRenderWindow(IRayTraceRendererObject IRayTraceRendererinstance)
        {
            return IRayTraceRendererinstance.IRayTraceRendererInstance.CloseFinalRenderWindow();
        }
        public static IRayTraceRendererOptionsObject RayTraceRendererOptions(IRayTraceRendererObject IRayTraceRendererinstance)
        {
            return new IRayTraceRendererOptionsObject(IRayTraceRendererinstance.IRayTraceRendererInstance.RayTraceRendererOptions);
        }
    }
}