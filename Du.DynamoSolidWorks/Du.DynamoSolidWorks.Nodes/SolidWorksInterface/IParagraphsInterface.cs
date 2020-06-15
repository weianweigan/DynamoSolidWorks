using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IParagraphsObject
    {
        public IParagraphs IParagraphsInstance { get; set; }
        public IParagraphsObject(IParagraphs IParagraphsinstance)
        {
            IParagraphsInstance = IParagraphsinstance;
        }
    }
    public static class IParagraphsInterface
    {
        //public static Boolean GetIndentation(IParagraphsObject IParagraphsinstance, Double& FirstlineIndent, Double& Indent, Double& IndentIncrement)
        //{
        //    return IParagraphsinstance.IParagraphsInstance.GetIndentation(FirstlineIndent, Indent, IndentIncrement);
        //}
        public static Boolean SetIndentation(IParagraphsObject IParagraphsinstance, Double FirstlineIndent, Double Indent, Double IndentIncrement)
        {
            return IParagraphsinstance.IParagraphsInstance.SetIndentation(FirstlineIndent, Indent, IndentIncrement);
        }
        //public static Boolean GetFormatting(IParagraphsObject IParagraphsinstance, Double& Paragraphspacing, Double& LineSpacing)
        //{
        //    return IParagraphsinstance.IParagraphsInstance.GetFormatting(Paragraphspacing, LineSpacing);
        //}
        public static Boolean SetFormatting(IParagraphsObject IParagraphsinstance, Double Paragraphspacing, Double LineSpacing)
        {
            return IParagraphsinstance.IParagraphsInstance.SetFormatting(Paragraphspacing, LineSpacing);
        }
        //public static Boolean GetBulletsAndNumbering(IParagraphsObject IParagraphsinstance, Int32& ParagraphType, Int32& NumberingType, Int32& StartAt, Int32& Type, Int32& Format)
        //{
        //    return IParagraphsinstance.IParagraphsInstance.GetBulletsAndNumbering(ParagraphType, NumberingType, StartAt, Type, Format);
        //}
        public static Boolean SetBulletsAndNumbering(IParagraphsObject IParagraphsinstance, Int32 ParagraphType, Int32 NumberingType, Int32 StartAt, Int32 Type, Int32 Format)
        {
            return IParagraphsinstance.IParagraphsInstance.SetBulletsAndNumbering(ParagraphType, NumberingType, StartAt, Type, Format);
        }
        public static Int32 GetTextSegmentCount(IParagraphsObject IParagraphsinstance)
        {
            return IParagraphsinstance.IParagraphsInstance.GetTextSegmentCount();
        }
        public static String GetTextSegmentText(IParagraphsObject IParagraphsinstance, Int32 Index)
        {
            return IParagraphsinstance.IParagraphsInstance.GetTextSegmentText(Index);
        }
        public static Object GetTextSegmentFormat(IParagraphsObject IParagraphsinstance, Int32 Index)
        {
            return IParagraphsinstance.IParagraphsInstance.GetTextSegmentFormat(Index);
        }
        public static String GetText(IParagraphsObject IParagraphsinstance, Boolean ShowWordWrap)
        {
            return IParagraphsinstance.IParagraphsInstance.GetText(ShowWordWrap);
        }
        public static Boolean SetTextSegmentFormat(IParagraphsObject IParagraphsinstance, Int32 Segment, Object Format)
        {
            return IParagraphsinstance.IParagraphsInstance.SetTextSegmentFormat(Segment, Format);
        }
        public static Boolean UpdateParagraph(IParagraphsObject IParagraphsinstance)
        {
            return IParagraphsinstance.IParagraphsInstance.UpdateParagraph();
        }
        public static Int32 CurrentParagraph(IParagraphsObject IParagraphsinstance)
        {
            return IParagraphsinstance.IParagraphsInstance.CurrentParagraph;
        }
        public static Int32 Count(IParagraphsObject IParagraphsinstance)
        {
            return IParagraphsinstance.IParagraphsInstance.Count;
        }
    }
}