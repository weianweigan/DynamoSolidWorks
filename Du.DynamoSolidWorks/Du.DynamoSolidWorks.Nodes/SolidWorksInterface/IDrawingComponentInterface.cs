using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDrawingComponentObject
    {
        public IDrawingComponent IDrawingComponentInstance { get; set; }
        public IDrawingComponentObject(IDrawingComponent IDrawingComponentinstance)
        {
            IDrawingComponentInstance = IDrawingComponentinstance;
        }
    }
    public static class IDrawingComponentInterface
    {
        public static Boolean IsRoot(IDrawingComponentObject IDrawingComponentinstance)
        {
            return IDrawingComponentinstance.IDrawingComponentInstance.IsRoot();
        }
        public static Int32 GetChildrenCount(IDrawingComponentObject IDrawingComponentinstance)
        {
            return IDrawingComponentinstance.IDrawingComponentInstance.GetChildrenCount();
        }
        public static Object GetChildren(IDrawingComponentObject IDrawingComponentinstance)
        {
            return IDrawingComponentinstance.IDrawingComponentInstance.GetChildren();
        }
        public static IDrawingComponentObject IGetChildren(IDrawingComponentObject IDrawingComponentinstance, Int32 Count)
        {
            return new IDrawingComponentObject(IDrawingComponentinstance.IDrawingComponentInstance.IGetChildren(Count));
        }
        public static Boolean Select(IDrawingComponentObject IDrawingComponentinstance, Boolean Append, ISelectDataObject Data)
        {
            return IDrawingComponentinstance.IDrawingComponentInstance.Select(Append, Data.ISelectDataInstance as SelectData);
        }
        public static Boolean DeSelect(IDrawingComponentObject IDrawingComponentinstance)
        {
            return IDrawingComponentinstance.IDrawingComponentInstance.DeSelect();
        }
        public static void SetLineStyle(IDrawingComponentObject IDrawingComponentinstance, Int32 LineFontOption, Int32 Style)
        {
            IDrawingComponentinstance.IDrawingComponentInstance.SetLineStyle(LineFontOption, Style);
        }
        public static Int32 GetLineStyle(IDrawingComponentObject IDrawingComponentinstance, Int32 LineFontOption)
        {
            return IDrawingComponentinstance.IDrawingComponentInstance.GetLineStyle(LineFontOption);
        }
        public static void SetLineThickness(IDrawingComponentObject IDrawingComponentinstance, Int32 LineFontOption, Int32 LineWeights, Double Thickness)
        {
            IDrawingComponentinstance.IDrawingComponentInstance.SetLineThickness(LineFontOption, LineWeights, Thickness);
        }
        //public static Int32 GetLineThickness(IDrawingComponentObject IDrawingComponentinstance, Int32 LineFontOption, Double& Thickness)
        //{
        //    return IDrawingComponentinstance.IDrawingComponentInstance.GetLineThickness(LineFontOption, Thickness);
        //}
        public static IViewObject View(IDrawingComponentObject IDrawingComponentinstance)
        {
            return new IViewObject(IDrawingComponentinstance.IDrawingComponentInstance.View);
        }
        public static IComponent2Object Component(IDrawingComponentObject IDrawingComponentinstance)
        {
            return new IComponent2Object(IDrawingComponentinstance.IDrawingComponentInstance.Component);
        }
        public static String Layer(IDrawingComponentObject IDrawingComponentinstance)
        {
            return IDrawingComponentinstance.IDrawingComponentInstance.Layer;
        }
        public static Int32 LayerOverride(IDrawingComponentObject IDrawingComponentinstance)
        {
            return IDrawingComponentinstance.IDrawingComponentInstance.LayerOverride;
        }
        public static Boolean Visible(IDrawingComponentObject IDrawingComponentinstance)
        {
            return IDrawingComponentinstance.IDrawingComponentInstance.Visible;
        }
        public static Int32 Style(IDrawingComponentObject IDrawingComponentinstance)
        {
            return IDrawingComponentinstance.IDrawingComponentInstance.Style;
        }
        public static Int32 Width(IDrawingComponentObject IDrawingComponentinstance)
        {
            return IDrawingComponentinstance.IDrawingComponentInstance.Width;
        }
        public static String Name(IDrawingComponentObject IDrawingComponentinstance)
        {
            return IDrawingComponentinstance.IDrawingComponentInstance.Name;
        }
        public static Boolean UseDocumentDefaults(IDrawingComponentObject IDrawingComponentinstance)
        {
            return IDrawingComponentinstance.IDrawingComponentInstance.UseDocumentDefaults;
        }
    }
}