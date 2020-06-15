using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchHatchObject
    {
        public ISketchHatch ISketchHatchInstance { get; set; }
        public ISketchHatchObject(ISketchHatch ISketchHatchinstance)
        {
            ISketchHatchInstance = ISketchHatchinstance;
        }
    }
    public static class ISketchHatchInterface
    {
        public static Object GetID(ISketchHatchObject ISketchHatchinstance)
        {
            return ISketchHatchinstance.ISketchHatchInstance.GetID();
        }
        public static Int32 IGetID(ISketchHatchObject ISketchHatchinstance)
        {
            return ISketchHatchinstance.ISketchHatchInstance.IGetID();
        }
        public static Boolean Select(ISketchHatchObject ISketchHatchinstance, Boolean AppendFlag)
        {
            return ISketchHatchinstance.ISketchHatchInstance.Select(AppendFlag);
        }
        public static Boolean SelectByMark(ISketchHatchObject ISketchHatchinstance, Boolean AppendFlag, Int32 Mark)
        {
            return ISketchHatchinstance.ISketchHatchInstance.SelectByMark(AppendFlag, Mark);
        }
        public static Boolean DeSelect(ISketchHatchObject ISketchHatchinstance)
        {
            return ISketchHatchinstance.ISketchHatchInstance.DeSelect();
        }
        public static Object GetFace(ISketchHatchObject ISketchHatchinstance)
        {
            return ISketchHatchinstance.ISketchHatchInstance.GetFace();
        }
        public static IFaceObject IGetFace(ISketchHatchObject ISketchHatchinstance)
        {
            return new IFaceObject(ISketchHatchinstance.ISketchHatchInstance.IGetFace());
        }
        public static ISketchObject GetSketch(ISketchHatchObject ISketchHatchinstance)
        {
            return new ISketchObject(ISketchHatchinstance.ISketchHatchInstance.GetSketch());
        }
        public static IFace2Object IGetFace2(ISketchHatchObject ISketchHatchinstance)
        {
            return new IFace2Object(ISketchHatchinstance.ISketchHatchInstance.IGetFace2());
        }
        public static Boolean Select2(ISketchHatchObject ISketchHatchinstance, Boolean Append, Int32 Mark)
        {
            return ISketchHatchinstance.ISketchHatchInstance.Select2(Append, Mark);
        }
        public static Boolean Select3(ISketchHatchObject ISketchHatchinstance, Boolean Append, Int32 Mark, ICalloutObject Callout)
        {
            return ISketchHatchinstance.ISketchHatchInstance.Select3(Append, Mark, Callout?.ICalloutInstance?.CastObj<Callout>());
        }
        public static Boolean Select4(ISketchHatchObject ISketchHatchinstance, Boolean Append, ISelectDataObject Data)
        {
            return ISketchHatchinstance.ISketchHatchInstance.Select4(Append, Data?.ISelectDataInstance?.CastObj<SelectData>());
        }
        public static String Layer(ISketchHatchObject ISketchHatchinstance)
        {
            return ISketchHatchinstance.ISketchHatchInstance.Layer;
        }
        public static Int32 LayerOverride(ISketchHatchObject ISketchHatchinstance)
        {
            return ISketchHatchinstance.ISketchHatchInstance.LayerOverride;
        }
        public static Int32 Color(ISketchHatchObject ISketchHatchinstance)
        {
            return ISketchHatchinstance.ISketchHatchInstance.Color;
        }
        public static String Pattern(ISketchHatchObject ISketchHatchinstance)
        {
            return ISketchHatchinstance.ISketchHatchInstance.Pattern;
        }
        public static Double Scale(ISketchHatchObject ISketchHatchinstance)
        {
            return ISketchHatchinstance.ISketchHatchInstance.Scale;
        }
        public static Double Angle(ISketchHatchObject ISketchHatchinstance)
        {
            return ISketchHatchinstance.ISketchHatchInstance.Angle;
        }
        public static Double Scale2(ISketchHatchObject ISketchHatchinstance)
        {
            return ISketchHatchinstance.ISketchHatchInstance.Scale2;
        }
        public static Boolean SolidFill(ISketchHatchObject ISketchHatchinstance)
        {
            return ISketchHatchinstance.ISketchHatchInstance.SolidFill;
        }
        public static Int32 PatternId(ISketchHatchObject ISketchHatchinstance)
        {
            return ISketchHatchinstance.ISketchHatchInstance.PatternId;
        }
    }
}