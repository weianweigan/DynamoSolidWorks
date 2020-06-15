using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISheetObject
    {
        public ISheet ISheetInstance { get; set; }
        public ISheetObject(ISheet ISheetinstance)
        {
            ISheetInstance = ISheetinstance;
        }
    }
    public static class ISheetInterface
    {
        public static Object GetBomTable(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.GetBomTable();
        }
        public static IBomTableObject IGetBomTable(ISheetObject ISheetinstance)
        {
            return new IBomTableObject(ISheetinstance.ISheetInstance.IGetBomTable());
        }
        public static String GetName(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.GetName();
        }
        public static void SetName(ISheetObject ISheetinstance, String NameIn)
        {
            ISheetinstance.ISheetInstance.SetName(NameIn);
        }
        public static String GetTemplateName(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.GetTemplateName();
        }
        public static void SetTemplateName(ISheetObject ISheetinstance, String NameIn)
        {
            ISheetinstance.ISheetInstance.SetTemplateName(NameIn);
        }
        public static Object GetProperties(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.GetProperties();
        }
        public static Double IGetProperties(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.IGetProperties();
        }
        public static void SetProperties(ISheetObject ISheetinstance, Int32 PaperSz, Int32 Templ, Double Scale1, Double Scale2, Boolean FirstAngle, Double Width, Double Height)
        {
            ISheetinstance.ISheetInstance.SetProperties(PaperSz, Templ, Scale1, Scale2, FirstAngle, Width, Height);
        }
        public static Int32 GetCustomColorsCount(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.GetCustomColorsCount();
        }
        public static Int32 IGetCustomColors(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.IGetCustomColors();
        }
        public static Int32 GetOLEObjectCount(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.GetOLEObjectCount();
        }
        //public static Object GetOLEObjectSettings(ISheetObject ISheetinstance, Int32 Index, Int32& ByteCount, Int32& Aspect)
        //{
        //    return ISheetinstance.ISheetInstance.GetOLEObjectSettings(Index, ByteCount, Aspect);
        //}
        //public static Boolean IGetOLEObjectSettings(ISheetObject ISheetinstance, Int32 Index, Int32& ByteCount, Int32& Aspect, Double& Position)
        //{
        //    return ISheetinstance.ISheetInstance.IGetOLEObjectSettings(Index, ByteCount, Aspect, Position);
        //}
        public static Object GetOLEObjectData(ISheetObject ISheetinstance, Int32 Index)
        {
            return ISheetinstance.ISheetInstance.GetOLEObjectData(Index);
        }
        //public static Boolean IGetOLEObjectData(ISheetObject ISheetinstance, Int32 Index, Byte& Buffer)
        //{
        //    return ISheetinstance.ISheetInstance.IGetOLEObjectData(Index, Buffer);
        //}
        public static Boolean CreateOLEObject(ISheetObject ISheetinstance, Int32 Aspect, Object Position, Object Buffer)
        {
            return ISheetinstance.ISheetInstance.CreateOLEObject(Aspect, Position, Buffer);
        }
        //public static Boolean ICreateOLEObject(ISheetObject ISheetinstance, Int32 Aspect, Double& Position, Int32 ByteCount, Byte& Buffer)
        //{
        //    return ISheetinstance.ISheetInstance.ICreateOLEObject(Aspect, Position, ByteCount, Buffer);
        //}
        public static Boolean SetScale(ISheetObject ISheetinstance, Double Numerator, Double Denominator, Boolean ScaleAnnoPosition, Boolean ScaleAnnoTextHeight)
        {
            return ISheetinstance.ISheetInstance.SetScale(Numerator, Denominator, ScaleAnnoPosition, ScaleAnnoTextHeight);
        }
        public static IRevisionTableAnnotationObject InsertRevisionTable(ISheetObject ISheetinstance, Boolean UseAnchorPoint, Double X, Double Y, Int32 AnchorType, String TableTemplate)
        {
            return new IRevisionTableAnnotationObject(ISheetinstance.ISheetInstance.InsertRevisionTable(UseAnchorPoint, X, Y, AnchorType, TableTemplate));
        }
        public static ISketchObject GetTemplateSketch(ISheetObject ISheetinstance)
        {
            return new ISketchObject(ISheetinstance.ISheetInstance.GetTemplateSketch());
        }
        public static String GetSheetFormatName(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.GetSheetFormatName();
        }
        public static Boolean SetSheetFormatName(ISheetObject ISheetinstance, String Name)
        {
            return ISheetinstance.ISheetInstance.SetSheetFormatName(Name);
        }
        //public static Int32 GetSize(ISheetObject ISheetinstance, Double& Width, Double& Height)
        //{
        //    return ISheetinstance.ISheetInstance.GetSize(Width, Height);
        //}
        public static Boolean SetSize(ISheetObject ISheetinstance, Int32 Size, Double Width, Double Height)
        {
            return ISheetinstance.ISheetInstance.SetSize(Size, Width, Height);
        }
        public static Boolean SaveFormat(ISheetObject ISheetinstance, String FileName)
        {
            return ISheetinstance.ISheetInstance.SaveFormat(FileName);
        }
        public static Object GetViews(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.GetViews();
        }
        public static ITitleBlockObject InsertTitleBlock(ISheetObject ISheetinstance, Object Notes)
        {
            return new ITitleBlockObject(ISheetinstance.ISheetInstance.InsertTitleBlock(Notes));
        }
        public static Boolean IsLoaded(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.IsLoaded();
        }
        public static Int32 GetID(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.GetID();
        }
        public static IMagneticLineObject InsertMagneticLine(ISheetObject ISheetinstance, IMathPointObject StartPoint, IMathPointObject EndPoint)
        {
            return new IMagneticLineObject(ISheetinstance.ISheetInstance.InsertMagneticLine(StartPoint.IMathPointInstance.CastObj<MathPoint>(), EndPoint.IMathPointInstance as MathPoint));
        }
        public static Object GetMagneticLines(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.GetMagneticLines();
        }
        public static Int32 GetMagneticLinesCount(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.GetMagneticLinesCount();
        }
        public static IMagneticLineObject IGetMagneticLines(ISheetObject ISheetinstance, Int32 Count)
        {
            return new IMagneticLineObject(ISheetinstance.ISheetInstance.IGetMagneticLines(Count));
        }
        public static IRevisionTableAnnotationObject InsertRevisionTable2(ISheetObject ISheetinstance, Boolean UseAnchorPoint, Double X, Double Y, Int32 AnchorType, String TableTemplate, Int32 Shape, Boolean AutoUpdateZoomCells)
        {
            return new IRevisionTableAnnotationObject(ISheetinstance.ISheetInstance.InsertRevisionTable2(UseAnchorPoint, X, Y, AnchorType, TableTemplate, Shape, AutoUpdateZoomCells));
        }
        public static void SetProperties2(ISheetObject ISheetinstance, Int32 PaperSz, Int32 Templ, Double Scale1, Double Scale2, Boolean FirstAngle, Double Width, Double Height, Boolean SameCustomPropAsSheetInDocProp)
        {
            ISheetinstance.ISheetInstance.SetProperties2(PaperSz, Templ, Scale1, Scale2, FirstAngle, Width, Height, SameCustomPropAsSheetInDocProp);
        }
        public static Object GetProperties2(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.GetProperties2();
        }
        public static Int32 ReloadTemplate(ISheetObject ISheetinstance, Boolean KeepNoteChanges)
        {
            return ISheetinstance.ISheetInstance.ReloadTemplate(KeepNoteChanges);
        }
        public static String GetDrawingZone(ISheetObject ISheetinstance, Double X, Double Y)
        {
            return ISheetinstance.ISheetInstance.GetDrawingZone(X, Y);
        }
        public static Object SetAsTableAnchor(ISheetObject ISheetinstance, Int32 TableType)
        {
            return ISheetinstance.ISheetInstance.SetAsTableAnchor(TableType);
        }
        public static Object PageSetup(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.PageSetup;
        }
        public static IPageSetupObject IPageSetup(ISheetObject ISheetinstance)
        {
            return new IPageSetupObject(ISheetinstance.ISheetInstance.IPageSetup);
        }
        public static String CustomPropertyView(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.CustomPropertyView;
        }
        public static IRevisionTableAnnotationObject RevisionTable(ISheetObject ISheetinstance)
        {
            return new IRevisionTableAnnotationObject(ISheetinstance.ISheetInstance.RevisionTable);
        }
        public static Boolean SheetFormatVisible(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.SheetFormatVisible;
        }
        public static Boolean FocusLocked(ISheetObject ISheetinstance)
        {
            return ISheetinstance.ISheetInstance.FocusLocked;
        }
        public static ITableAnchorObject TableAnchor(ISheetObject ISheetinstance, int TableType)
        {
            return new ITableAnchorObject(ISheetinstance.ISheetInstance.TableAnchor[TableType]);
        }
        public static ITitleBlockObject TitleBlock(ISheetObject ISheetinstance)
        {
            return new ITitleBlockObject(ISheetinstance.ISheetInstance.TitleBlock);
        }
    }
}