using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchTextObject
    {
        public ISketchText ISketchTextInstance { get; set; }
        public ISketchTextObject(ISketchText ISketchTextinstance)
        {
            ISketchTextInstance = ISketchTextinstance;
        }
    }
    public static class ISketchTextInterface
    {
        public static Object GetEdges(ISketchTextObject ISketchTextinstance)
        {
            return ISketchTextinstance.ISketchTextInstance.GetEdges();
        }
        //public static IEnumEdgesObject EnumEdges(ISketchTextObject ISketchTextinstance)
        //{
        //    return new IEnumEdgesObject(ISketchTextinstance.ISketchTextInstance.EnumEdges());
        //}
        public static Object GetCoordinates(ISketchTextObject ISketchTextinstance)
        {
            return ISketchTextinstance.ISketchTextInstance.GetCoordinates();
        }
        public static Double IGetCoordinates(ISketchTextObject ISketchTextinstance)
        {
            return ISketchTextinstance.ISketchTextInstance.IGetCoordinates();
        }
        public static Boolean SetCoordinates(ISketchTextObject ISketchTextinstance, Double X, Double Y, Double Z)
        {
            return ISketchTextinstance.ISketchTextInstance.SetCoordinates(X, Y, Z);
        }
        public static Boolean GetUseDocTextFormat(ISketchTextObject ISketchTextinstance)
        {
            return ISketchTextinstance.ISketchTextInstance.GetUseDocTextFormat();
        }
        public static Object GetTextFormat(ISketchTextObject ISketchTextinstance)
        {
            return ISketchTextinstance.ISketchTextInstance.GetTextFormat();
        }
        public static ITextFormatObject IGetTextFormat(ISketchTextObject ISketchTextinstance)
        {
            return new ITextFormatObject(ISketchTextinstance.ISketchTextInstance.IGetTextFormat());
        }
        public static Boolean SetTextFormat(ISketchTextObject ISketchTextinstance, Boolean UseDoc, Object TextFormat)
        {
            return ISketchTextinstance.ISketchTextInstance.SetTextFormat(UseDoc, TextFormat);
        }
        public static Boolean ISetTextFormat(ISketchTextObject ISketchTextinstance, Boolean UseDoc, ITextFormatObject TextFormat)
        {
            return ISketchTextinstance.ISketchTextInstance.ISetTextFormat(UseDoc, TextFormat?.ITextFormatInstance?.CastObj<TextFormat>());
        }
        public static String Text(ISketchTextObject ISketchTextinstance)
        {
            return ISketchTextinstance.ISketchTextInstance.Text;
        }
    }
}