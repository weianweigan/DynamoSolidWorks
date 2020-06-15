using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IImportDxfDwgDataObject
    {
        public IImportDxfDwgData IImportDxfDwgDataInstance { get; set; }
        public IImportDxfDwgDataObject(IImportDxfDwgData IImportDxfDwgDatainstance)
        {
            IImportDxfDwgDataInstance = IImportDxfDwgDatainstance;
        }
    }
    public static class IImportDxfDwgDataInterface
    {
        //public static Boolean SetPaperSize(IImportDxfDwgDataObject IImportDxfDwgDatainstance, String Sheet, Int32 Size, Double Height, Double Width)
        //{
        //    return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.SetPaperSize(Sheet, Size, Height, Width);
        //}
        //public static void GetSheetScale(IImportDxfDwgDataObject IImportDxfDwgDatainstance, String Sheet, Double& Numerator, Double& Denominator)
        //{
        //    return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.GetSheetScale(Sheet, Numerator, Denominator);
        //}
        public static Boolean SetSheetScale(IImportDxfDwgDataObject IImportDxfDwgDatainstance, String Sheet, Double Numerator, Double Denominator)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.SetSheetScale(Sheet, Numerator, Denominator);
        }
        public static Int32 GetImportLayerVisibility(IImportDxfDwgDataObject IImportDxfDwgDatainstance, String Layer)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.GetImportLayerVisibility(Layer);
        }
        public static Boolean SetImportLayerVisibility(IImportDxfDwgDataObject IImportDxfDwgDatainstance, Object Layers, Int32 Visibility)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.SetImportLayerVisibility(Layers, Visibility);
        }
        public static Boolean GetImportLayerToSheetFormat(IImportDxfDwgDataObject IImportDxfDwgDatainstance, String Layer)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.GetImportLayerToSheetFormat(Layer);
        }
        public static Boolean SetImportLayerToSheetFormat(IImportDxfDwgDataObject IImportDxfDwgDatainstance, Object Layers, Boolean SheetFormat)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.SetImportLayerToSheetFormat(Layers, SheetFormat);
        }
        //public static void GetPosition(IImportDxfDwgDataObject IImportDxfDwgDatainstance, String Sheet, Int32& Positioning, Double& X, Double& Y)
        //{
        //    return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.GetPosition(Sheet, Positioning, X, Y);
        //}
        public static Boolean SetPosition(IImportDxfDwgDataObject IImportDxfDwgDatainstance, String Sheet, Int32 Positioning, Double X, Double Y)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.SetPosition(Sheet, Positioning, X, Y);
        }
        public static Boolean GetMergePoints(IImportDxfDwgDataObject IImportDxfDwgDatainstance, String Sheet)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.GetMergePoints(Sheet);
        }
        public static Double GetMergeDistance(IImportDxfDwgDataObject IImportDxfDwgDatainstance, String Sheet)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.GetMergeDistance(Sheet);
        }
        public static Boolean SetMergePoints(IImportDxfDwgDataObject IImportDxfDwgDatainstance, String Sheet, Boolean Merge, Double Distance)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.SetMergePoints(Sheet, Merge, Distance);
        }
        public static Int32 ImportMethod(IImportDxfDwgDataObject IImportDxfDwgDatainstance, string Sheet)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.ImportMethod[Sheet];
        }
        public static Int32 LengthUnit(IImportDxfDwgDataObject IImportDxfDwgDatainstance, string Sheet)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.LengthUnit[Sheet];
        }
        public static String SheetName(IImportDxfDwgDataObject IImportDxfDwgDatainstance, string Sheet)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.SheetName[Sheet];
        }
        public static String DocumentTemplate(IImportDxfDwgDataObject IImportDxfDwgDatainstance)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.DocumentTemplate;
        }
        public static Boolean AddSketchConstraints(IImportDxfDwgDataObject IImportDxfDwgDatainstance, string Sheet)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.AddSketchConstraints[Sheet];
        }
        public static Boolean ImportDimensions(IImportDxfDwgDataObject IImportDxfDwgDatainstance, string Sheet)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.ImportDimensions[Sheet];
        }
        public static Boolean ImportHatch(IImportDxfDwgDataObject IImportDxfDwgDatainstance, string Sheet)
        {
            return IImportDxfDwgDatainstance.IImportDxfDwgDataInstance.ImportHatch[Sheet];
        }
    }
}