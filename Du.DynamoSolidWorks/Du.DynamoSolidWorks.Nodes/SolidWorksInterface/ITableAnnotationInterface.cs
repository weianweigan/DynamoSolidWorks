using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ITableAnnotationObject
    {
        public ITableAnnotation ITableAnnotationInstance { get; set; }
        public ITableAnnotationObject(ITableAnnotation ITableAnnotationinstance)
        {
            ITableAnnotationInstance = ITableAnnotationinstance;
        }
    }
    public static class ITableAnnotationInterface
    {
        public static Boolean SaveAsText2(ITableAnnotationObject ITableAnnotationinstance, String FileName, String Separator, Boolean IncludeHidden)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SaveAsText2(FileName, Separator, IncludeHidden);
        }
        public static Int32 GetColumnType2(ITableAnnotationObject ITableAnnotationinstance, Int32 Index, Boolean IncludeHidden)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GetColumnType2(Index, IncludeHidden);
        }
        public static Boolean SetColumnType2(ITableAnnotationObject ITableAnnotationinstance, Int32 Index, Int32 Type, Boolean IncludeHidden)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SetColumnType2(Index, Type, IncludeHidden);
        }
        public static String GetColumnTitle2(ITableAnnotationObject ITableAnnotationinstance, Int32 Index, Boolean IncludeHidden)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GetColumnTitle2(Index, IncludeHidden);
        }
        public static Boolean SetColumnTitle2(ITableAnnotationObject ITableAnnotationinstance, Int32 Index, String Title, Boolean IncludeHidden)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SetColumnTitle2(Index, Title, IncludeHidden);
        }
        public static Boolean DeleteRow2(ITableAnnotationObject ITableAnnotationinstance, Int32 Index, Boolean IncludeHidden)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.DeleteRow2(Index, IncludeHidden);
        }
        public static Boolean DeleteColumn2(ITableAnnotationObject ITableAnnotationinstance, Int32 Index, Boolean IncludeHidden)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.DeleteColumn2(Index, IncludeHidden);
        }
        public static ITableAnnotationObject GetNext(ITableAnnotationObject ITableAnnotationinstance)
        {
            return new ITableAnnotationObject(ITableAnnotationinstance.ITableAnnotationInstance.GetNext());
        }
        public static IAnnotationObject GetAnnotation(ITableAnnotationObject ITableAnnotationinstance)
        {
            return new IAnnotationObject(ITableAnnotationinstance.ITableAnnotationInstance.GetAnnotation());
        }
        public static Boolean GetUseDocTextFormat(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GetUseDocTextFormat();
        }
        public static ITextFormatObject GetTextFormat(ITableAnnotationObject ITableAnnotationinstance)
        {
            return new ITextFormatObject(ITableAnnotationinstance.ITableAnnotationInstance.GetTextFormat());
        }
        public static Boolean SetTextFormat(ITableAnnotationObject ITableAnnotationinstance, Boolean UseDoc, ITextFormatObject TextFormat)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SetTextFormat(UseDoc, TextFormat?.ITextFormatInstance.CastObj<TextFormat>());
        }
        public static Int32 GetHeaderStyle(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GetHeaderStyle();
        }
        public static Int32 GetHeaderCount(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GetHeaderCount();
        }
        public static Boolean SetHeader(ITableAnnotationObject ITableAnnotationinstance, Int32 Style, Int32 Count)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SetHeader(Style, Count);
        }
        //public static Int32 GetSplitInformation(ITableAnnotationObject ITableAnnotationinstance, Int32& Index, Int32& Count, Int32& RangeStart, Int32& RangeEnd)
        //{
        //    return ITableAnnotationinstance.ITableAnnotationInstance.GetSplitInformation(Index, Count, RangeStart, RangeEnd);
        //}
        public static ITableAnnotationObject Split(ITableAnnotationObject ITableAnnotationinstance, Int32 Where, Int32 Index)
        {
            return new ITableAnnotationObject(ITableAnnotationinstance.ITableAnnotationInstance.Split(Where, Index));
        }
        public static Boolean Merge(ITableAnnotationObject ITableAnnotationinstance, Int32 Where)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.Merge(Where);
        }
        public static Boolean InsertColumn(ITableAnnotationObject ITableAnnotationinstance, Int32 Where, Int32 Index, String Name)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.InsertColumn(Where, Index, Name);
        }
        public static Boolean InsertRow(ITableAnnotationObject ITableAnnotationinstance, Int32 Where, Int32 Index)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.InsertRow(Where, Index);
        }
        public static Boolean MoveColumn(ITableAnnotationObject ITableAnnotationinstance, Int32 Source, Int32 Where, Int32 Destination)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.MoveColumn(Source, Where, Destination);
        }
        public static Boolean MoveRow(ITableAnnotationObject ITableAnnotationinstance, Int32 Source, Int32 Where, Int32 Destination)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.MoveRow(Source, Where, Destination);
        }
        public static Boolean DeleteColumn(ITableAnnotationObject ITableAnnotationinstance, Int32 Index)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.DeleteColumn(Index);
        }
        public static Boolean DeleteRow(ITableAnnotationObject ITableAnnotationinstance, Int32 Index)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.DeleteRow(Index);
        }
        //public static void GetCellRange(ITableAnnotationObject ITableAnnotationinstance, Int32& FirstRow, Int32& LastRow, Int32& FirstColumn, Int32& LastColumn)
        //{
        //    return ITableAnnotationinstance.ITableAnnotationInstance.GetCellRange(FirstRow, LastRow, FirstColumn, LastColumn);
        //}
        public static void SetCellRange(ITableAnnotationObject ITableAnnotationinstance, Int32 FirstRow, Int32 LastRow, Int32 FirstColumn, Int32 LastColumn)
        {
            ITableAnnotationinstance.ITableAnnotationInstance.SetCellRange(FirstRow, LastRow, FirstColumn, LastColumn);
        }
        public static Double GetColumnWidth(ITableAnnotationObject ITableAnnotationinstance, Int32 Index)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GetColumnWidth(Index);
        }
        public static Double SetColumnWidth(ITableAnnotationObject ITableAnnotationinstance, Int32 Index, Double Width, Int32 Options)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SetColumnWidth(Index, Width, Options);
        }
        public static Double GetRowHeight(ITableAnnotationObject ITableAnnotationinstance, Int32 Index)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GetRowHeight(Index);
        }
        public static Double SetRowHeight(ITableAnnotationObject ITableAnnotationinstance, Int32 Index, Double Height, Int32 Options)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SetRowHeight(Index, Height, Options);
        }
        public static Int32 GetColumnType(ITableAnnotationObject ITableAnnotationinstance, Int32 Index)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GetColumnType(Index);
        }
        public static Boolean SetColumnType(ITableAnnotationObject ITableAnnotationinstance, Int32 Index, Int32 Type)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SetColumnType(Index, Type);
        }
        public static String GetColumnTitle(ITableAnnotationObject ITableAnnotationinstance, Int32 Index)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GetColumnTitle(Index);
        }
        public static Boolean SetColumnTitle(ITableAnnotationObject ITableAnnotationinstance, Int32 Index, String Title)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SetColumnTitle(Index, Title);
        }
        public static Boolean GetCellUseDocTextFormat(ITableAnnotationObject ITableAnnotationinstance, Int32 Row, Int32 Column)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GetCellUseDocTextFormat(Row, Column);
        }
        public static ITextFormatObject GetCellTextFormat(ITableAnnotationObject ITableAnnotationinstance, Int32 Row, Int32 Column)
        {
            return new ITextFormatObject(ITableAnnotationinstance.ITableAnnotationInstance.GetCellTextFormat(Row, Column));
        }
        public static Boolean SetCellTextFormat(ITableAnnotationObject ITableAnnotationinstance, Int32 Row, Int32 Column, Boolean UseDoc, ITextFormatObject TextFormat)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SetCellTextFormat(Row, Column, UseDoc, TextFormat?.ITextFormatInstance.CastObj<TextFormat>());
        }
        public static Boolean MergeCells(ITableAnnotationObject ITableAnnotationinstance, Int32 RowStart, Int32 ColumnStart, Int32 RowEnd, Int32 ColumnEnd)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.MergeCells(RowStart, ColumnStart, RowEnd, ColumnEnd);
        }
        public static Boolean UnmergeCells(ITableAnnotationObject ITableAnnotationinstance, Int32 Row, Int32 Column)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.UnmergeCells(Row, Column);
        }
        //public static Boolean IsCellMerged(ITableAnnotationObject ITableAnnotationinstance, Int32 Row, Int32 Column, Int32& WithRow, Int32& WithColumn)
        //{
        //    return ITableAnnotationinstance.ITableAnnotationInstance.IsCellMerged(Row, Column, WithRow, WithColumn);
        //}
        public static Boolean IsCellTextEditable(ITableAnnotationObject ITableAnnotationinstance, Int32 Row, Int32 Column)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.IsCellTextEditable(Row, Column);
        }
        public static Boolean SaveAsTemplate(ITableAnnotationObject ITableAnnotationinstance, String FileName)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SaveAsTemplate(FileName);
        }
        public static Boolean SaveAsText(ITableAnnotationObject ITableAnnotationinstance, String FileName, String Separator)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SaveAsText(FileName, Separator);
        }
        public static Double GetRowVerticalGap(ITableAnnotationObject ITableAnnotationinstance, Int32 Index)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GetRowVerticalGap(Index);
        }
        public static Boolean SetRowVerticalGap(ITableAnnotationObject ITableAnnotationinstance, Int32 Index, Double Gap)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SetRowVerticalGap(Index, Gap);
        }
        public static Boolean InsertColumn2(ITableAnnotationObject ITableAnnotationinstance, Int32 Where, Int32 Index, String Name, Int32 WidthStyle)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.InsertColumn2(Where, Index, Name, WidthStyle);
        }
        public static Boolean SaveAsPDF(ITableAnnotationObject ITableAnnotationinstance, String FileName)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SaveAsPDF(FileName);
        }
        public static Object HorizontalAutoSplit(ITableAnnotationObject ITableAnnotationinstance, Int32 MaxNumberOfRows, Int32 Apply, Int32 PlacementOfNewSplitTables)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.HorizontalAutoSplit(MaxNumberOfRows, Apply, PlacementOfNewSplitTables);
        }
        public static Boolean GetLockColumnWidth(ITableAnnotationObject ITableAnnotationinstance, Int32 Index)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GetLockColumnWidth(Index);
        }
        public static Boolean SetLockColumnWidth(ITableAnnotationObject ITableAnnotationinstance, Int32 Index, Boolean LockColumnWidth)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SetLockColumnWidth(Index, LockColumnWidth);
        }
        public static Boolean GetLockRowHeight(ITableAnnotationObject ITableAnnotationinstance, Int32 Index)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GetLockRowHeight(Index);
        }
        public static Boolean SetLockRowHeight(ITableAnnotationObject ITableAnnotationinstance, Int32 Index, Boolean LockRowHeight)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.SetLockRowHeight(Index, LockRowHeight);
        }
        public static Int32 Type(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.Type;
        }
        public static Int32 BorderLineWeight(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.BorderLineWeight;
        }
        public static Int32 GridLineWeight(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GridLineWeight;
        }
        public static Int32 AnchorType(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.AnchorType;
        }
        public static Int32 TextVerticalJustification(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.TextVerticalJustification;
        }
        public static Int32 TextHorizontalJustification(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.TextHorizontalJustification;
        }
        public static Int32 ColumnCount(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.ColumnCount;
        }
        public static Int32 RowCount(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.RowCount;
        }
        public static String Text(ITableAnnotationObject ITableAnnotationinstance, int Row, int Column)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.Text[Row, Column];
        }
        public static Int32 CellTextHorizontalJustification(ITableAnnotationObject ITableAnnotationinstance, int Row, int Column)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.CellTextHorizontalJustification[Row, Column];
        }
        public static Int32 CellTextVerticalJustification(ITableAnnotationObject ITableAnnotationinstance, int Row, int Column)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.CellTextVerticalJustification[Row, Column];
        }
        public static String Title(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.Title;
        }
        public static Boolean TitleVisible(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.TitleVisible;
        }
        public static Boolean Anchored(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.Anchored;
        }
        public static IGeneralTableFeatureObject GeneralTableFeature(ITableAnnotationObject ITableAnnotationinstance)
        {
            return new IGeneralTableFeatureObject(ITableAnnotationinstance.ITableAnnotationInstance.GeneralTableFeature);
        }
        public static String DisplayedText(ITableAnnotationObject ITableAnnotationinstance, int Row, int Column)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.DisplayedText[Row, Column];
        }
        public static Boolean RowHidden(ITableAnnotationObject ITableAnnotationinstance, int Index)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.RowHidden[Index];
        }
        public static Double BorderLineWeightCustom(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.BorderLineWeightCustom;
        }
        public static Double GridLineWeightCustom(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.GridLineWeightCustom;
        }
        public static Boolean ColumnHidden(ITableAnnotationObject ITableAnnotationinstance, int Index)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.ColumnHidden[Index];
        }
        public static Int32 TotalColumnCount(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.TotalColumnCount;
        }
        public static Int32 TotalRowCount(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.TotalRowCount;
        }
        public static Boolean StopAutoSplitting(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.StopAutoSplitting;
        }
        public static String Text2(ITableAnnotationObject ITableAnnotationinstance, int Row, int Cloumn, bool InclueHidden)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.Text2[Row, Cloumn, InclueHidden];
        }
        public static String DisplayedText2(ITableAnnotationObject ITableAnnotationinstance, int Row, int Cloumn, bool InclueHidden)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.DisplayedText2[Row, Cloumn, InclueHidden];
        }
        public static Int32 UpperCase(ITableAnnotationObject ITableAnnotationinstance)
        {
            return ITableAnnotationinstance.ITableAnnotationInstance.UpperCase;
        }
    }
}