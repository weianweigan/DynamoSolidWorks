using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDisplayDimensionObject
    {
        public IDisplayDimension IDisplayDimensionInstance { get; set; }
        public IDisplayDimensionObject(IDisplayDimension IDisplayDimensioninstance)
        {
            IDisplayDimensionInstance = IDisplayDimensioninstance;
        }
    }
    public static class IDisplayDimensionInterface
    {
        public static Boolean SupplementaryAngle(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SupplementaryAngle();
        }
        //public static void GetOrdinateDimensionArrowSize(IDisplayDimensionObject IDisplayDimensioninstance, Boolean& UseDoc, Double& ArrowSize)
        //{
        //    return IDisplayDimensioninstance.IDisplayDimensionInstance.GetOrdinateDimensionArrowSize(UseDoc, ArrowSize);
        //}
        public static void SetOrdinateDimensionArrowSize(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc, Double ArrowSize)
        {
            IDisplayDimensioninstance.IDisplayDimensionInstance.SetOrdinateDimensionArrowSize(UseDoc, ArrowSize);
        }
        public static IDisplayDimensionObject GetNext4(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return new IDisplayDimensionObject(IDisplayDimensioninstance.IDisplayDimensionInstance.GetNext4());
        }
        public static String GetLinkedText(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetLinkedText();
        }
        public static Int32 SetLinkedText(IDisplayDimensionObject IDisplayDimensioninstance, String BstrLinkedText)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetLinkedText(BstrLinkedText);
        }
        public static Int32 Unlink(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.Unlink();
        }
        public static Int32 GetPrimaryPrecision2(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetPrimaryPrecision2();
        }
        public static Int32 GetAlternatePrecision2(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetAlternatePrecision2();
        }
        public static Int32 GetPrimaryTolPrecision2(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetPrimaryTolPrecision2();
        }
        public static Int32 GetAlternateTolPrecision2(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetAlternateTolPrecision2();
        }
        public static Int32 SetPrecision2(IDisplayDimensionObject IDisplayDimensioninstance, Int32 Primary, Int32 Dual, Int32 PrimaryTol, Int32 DualTol)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetPrecision2(Primary, Dual, PrimaryTol, DualTol);
        }
        public static Boolean GetUseDocBentLeaderLength(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetUseDocBentLeaderLength();
        }
        public static Double GetBentLeaderLength(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetBentLeaderLength();
        }
        public static Boolean SetBentLeaderLength(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc, Double Length)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetBentLeaderLength(UseDoc, Length);
        }
        public static IMathTransformObject GetDefinitionTransform(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return new IMathTransformObject(IDisplayDimensioninstance.IDisplayDimensionInstance.GetDefinitionTransform());
        }
        public static IDisplayDimensionObject GetNext5(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return new IDisplayDimensionObject(IDisplayDimensioninstance.IDisplayDimensionInstance.GetNext5());
        }
        public static Boolean GetOverride(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetOverride();
        }
        public static Double GetOverrideValue(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetOverrideValue();
        }
        public static Boolean SetOverride(IDisplayDimensionObject IDisplayDimensioninstance, Boolean Override, Double Value)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetOverride(Override, Value);
        }
        public static Boolean IsHoleCallout(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.IsHoleCallout();
        }
        //public static Boolean GetArrowHeadStyle2(IDisplayDimensionObject IDisplayDimensioninstance, Int32& Style1, Int32& Style2)
        //{
        //    return IDisplayDimensioninstance.IDisplayDimensionInstance.GetArrowHeadStyle2(Style1, Style2);
        //}
        public static Boolean SetArrowHeadStyle2(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc, Int32 Style1, Int32 Style2)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetArrowHeadStyle2(UseDoc, Style1, Style2);
        }
        public static IDimensionObject GetDimension2(IDisplayDimensionObject IDisplayDimensioninstance, Int32 Index)
        {
            return new IDimensionObject(IDisplayDimensioninstance.IDisplayDimensionInstance.GetDimension2(Index));
        }
        //public static Boolean GetJogParameters(IDisplayDimensionObject IDisplayDimensioninstance, Int16 WitnessIndex, Boolean& Jogged, Double& Offset1, Double& Offset2, Double& Offset1to2)
        //{
        //    return IDisplayDimensioninstance.IDisplayDimensionInstance.GetJogParameters(WitnessIndex, Jogged, Offset1, Offset2, Offset1to2);
        //}
        public static Boolean SetJogParameters(IDisplayDimensionObject IDisplayDimensioninstance, Int16 WitnessIndex, Boolean Jogged, Double Offset1, Double Offset2, Double Offset1to2)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetJogParameters(WitnessIndex, Jogged, Offset1, Offset2, Offset1to2);
        }
        //public static Boolean GetWitnessLineGap(IDisplayDimensionObject IDisplayDimensioninstance, Int16 WitnessIndex, Boolean& UseDoc, Double& Gap)
        //{
        //    return IDisplayDimensioninstance.IDisplayDimensionInstance.GetWitnessLineGap(WitnessIndex, UseDoc, Gap);
        //}
        public static Boolean SetWitnessLineGap(IDisplayDimensionObject IDisplayDimensioninstance, Int16 WitnessIndex, Boolean UseDoc, Double Gap)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetWitnessLineGap(WitnessIndex, UseDoc, Gap);
        }
        public static String GetNameForSelection(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetNameForSelection();
        }
        public static Boolean IsDimXpert(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.IsDimXpert();
        }
        //public static Boolean GetChamferUnits(IDisplayDimensionObject IDisplayDimensioninstance, Int32& LengthUnit, Int32& AngularUnit)
        //{
        //    return IDisplayDimensioninstance.IDisplayDimensionInstance.GetChamferUnits(LengthUnit, AngularUnit);
        //}
        //public static Int32 GetTextFormatItems(IDisplayDimensionObject IDisplayDimensioninstance, Int32 WhichText, Object& TokensDefinition, Object& TokensEvaluated)
        //{
        //    return IDisplayDimensioninstance.IDisplayDimensionInstance.GetTextFormatItems(WhichText, TokensDefinition, TokensEvaluated);
        //}
        public static Boolean GetSupportsGenericText(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetSupportsGenericText();
        }
        public static String GetLowerText(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetLowerText();
        }
        public static void SetLowerText(IDisplayDimensionObject IDisplayDimensioninstance, String Text)
        {
            IDisplayDimensioninstance.IDisplayDimensionInstance.SetLowerText(Text);
        }
        public static Boolean SetLineFontExtensionStyle(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc, Int32 Style)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetLineFontExtensionStyle(UseDoc, Style);
        }
        public static Boolean SetLineFontExtensionThickness(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc, Int32 Style)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetLineFontExtensionThickness(UseDoc, Style);
        }
        public static Boolean SetLineFontDimensionStyle(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc, Int32 Style)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetLineFontDimensionStyle(UseDoc, Style);
        }
        public static Boolean SetLineFontDimensionThickness(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc, Int32 Style)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetLineFontDimensionThickness(UseDoc, Style);
        }
        //public static Boolean GetExtensionLineAsCenterline(IDisplayDimensionObject IDisplayDimensioninstance, Int16 ExtIndex, Boolean& Centerline)
        //{
        //    return IDisplayDimensioninstance.IDisplayDimensionInstance.GetExtensionLineAsCenterline(ExtIndex, Centerline);
        //}
        public static Boolean SetExtensionLineAsCenterline(IDisplayDimensionObject IDisplayDimensioninstance, Int16 ExtIndex, Boolean Centerline)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetExtensionLineAsCenterline(ExtIndex, Centerline);
        }
        public static Boolean ResetExtensionLineStyle(IDisplayDimensionObject IDisplayDimensioninstance, Int16 ExtIndex)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ResetExtensionLineStyle(ExtIndex);
        }
        public static Int32 SetUnits2(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc, Int32 UType, Int32 FractBase, Int32 FractDenom, Boolean RoundToFraction, Int32 DecimalRounding)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetUnits2(UseDoc, UType, FractBase, FractDenom, RoundToFraction, DecimalRounding);
        }
        public static void SetDual2(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc, Boolean InwardRounding)
        {
            IDisplayDimensioninstance.IDisplayDimensionInstance.SetDual2(UseDoc, InwardRounding);
        }
        public static Boolean VerticallyOppositeAngle(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.VerticallyOppositeAngle();
        }
        public static Boolean ExplementaryAngle(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ExplementaryAngle();
        }
        public static Boolean IsReferenceDim(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.IsReferenceDim();
        }
        public static Object GetHoleCalloutVariables(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetHoleCalloutVariables();
        }
        public static Int32 SetPrecision3(IDisplayDimensionObject IDisplayDimensioninstance, Int32 Primary, Int32 Dual, Int32 PrimaryTol, Int32 DualTol)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetPrecision3(Primary, Dual, PrimaryTol, DualTol);
        }
        public static Object GetNext(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetNext();
        }
        public static IDisplayDimensionObject IGetNext(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return new IDisplayDimensionObject(IDisplayDimensioninstance.IDisplayDimensionInstance.IGetNext());
        }
        public static Object GetDisplayData(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetDisplayData();
        }
        public static IDisplayDataObject IGetDisplayData(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return new IDisplayDataObject(IDisplayDimensioninstance.IDisplayDimensionInstance.IGetDisplayData());
        }
        public static String GetText(IDisplayDimensionObject IDisplayDimensioninstance, Int32 WhichText)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetText(WhichText);
        }
        public static void SetText(IDisplayDimensionObject IDisplayDimensioninstance, Int32 WhichText, String Text)
        {
            IDisplayDimensioninstance.IDisplayDimensionInstance.SetText(WhichText, Text);
        }
        public static Object GetDimension(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetDimension();
        }
        public static IDimensionObject IGetDimension(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return new IDimensionObject(IDisplayDimensioninstance.IDisplayDimensionInstance.IGetDimension());
        }
        public static Boolean GetUseDocTextFormat(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetUseDocTextFormat();
        }
        public static Object GetTextFormat(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetTextFormat();
        }
        public static ITextFormatObject IGetTextFormat(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return new ITextFormatObject(IDisplayDimensioninstance.IDisplayDimensionInstance.IGetTextFormat());
        }
        public static Boolean SetTextFormat(IDisplayDimensionObject IDisplayDimensioninstance, Int32 TextFormatType, Object TextFormat)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetTextFormat(TextFormatType, TextFormat);
        }
        public static Boolean ISetTextFormat(IDisplayDimensionObject IDisplayDimensioninstance, Int32 TextFormatType, ITextFormatObject TextFormat)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ISetTextFormat(TextFormatType, TextFormat.ITextFormatInstance as TextFormat);
        }
        public static Object GetAnnotation(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetAnnotation();
        }
        public static IAnnotationObject IGetAnnotation(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return new IAnnotationObject(IDisplayDimensioninstance.IDisplayDimensionInstance.IGetAnnotation());
        }
        public static Boolean GetUseDocSecondArrow(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetUseDocSecondArrow();
        }
        public static Boolean GetSecondArrow(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetSecondArrow();
        }
        public static void SetSecondArrow(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc, Boolean SecondArrow)
        {
            IDisplayDimensioninstance.IDisplayDimensionInstance.SetSecondArrow(UseDoc, SecondArrow);
        }
        public static Boolean GetUseDocDual(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetUseDocDual();
        }
        public static void SetDual(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc)
        {
            IDisplayDimensioninstance.IDisplayDimensionInstance.SetDual(UseDoc);
        }
        public static Boolean GetUseDocArrowHeadStyle(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetUseDocArrowHeadStyle();
        }
        public static Int32 GetArrowHeadStyle(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetArrowHeadStyle();
        }
        public static void SetArrowHeadStyle(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc, Int32 ArrowHeadStyle)
        {
            IDisplayDimensioninstance.IDisplayDimensionInstance.SetArrowHeadStyle(UseDoc, ArrowHeadStyle);
        }
        public static Boolean GetUseDocPrecision(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetUseDocPrecision();
        }
        public static Int32 GetPrimaryPrecision(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetPrimaryPrecision();
        }
        public static Int32 GetAlternatePrecision(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetAlternatePrecision();
        }
        public static Int32 GetPrimaryTolPrecision(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetPrimaryTolPrecision();
        }
        public static Int32 GetAlternateTolPrecision(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetAlternateTolPrecision();
        }
        public static Int32 SetPrecision(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc, Int32 Primary, Int32 Alternate, Int32 PrimaryTol, Int32 AlternateTol)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetPrecision(UseDoc, Primary, Alternate, PrimaryTol, AlternateTol);
        }
        public static Boolean GetAutoArcLengthLeader(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetAutoArcLengthLeader();
        }
        public static Int32 GetArcLengthLeader(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetArcLengthLeader();
        }
        public static Int32 SetArcLengthLeader(IDisplayDimensionObject IDisplayDimensioninstance, Boolean AutoLeader, Int32 LeaderType)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetArcLengthLeader(AutoLeader, LeaderType);
        }
        public static Boolean GetUseDocUnits(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetUseDocUnits();
        }
        public static Int32 GetUnits(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetUnits();
        }
        public static Int32 GetFractionBase(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetFractionBase();
        }
        public static Int32 GetFractionValue(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetFractionValue();
        }
        public static Boolean GetRoundToFraction(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetRoundToFraction();
        }
        public static Int32 SetUnits(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc, Int32 UType, Int32 FractBase, Int32 FractDenom, Boolean RoundToFraction)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetUnits(UseDoc, UType, FractBase, FractDenom, RoundToFraction);
        }
        public static Boolean GetUseDocBrokenLeader(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetUseDocBrokenLeader();
        }
        public static Int32 GetBrokenLeader2(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetBrokenLeader2();
        }
        public static Int32 SetBrokenLeader2(IDisplayDimensionObject IDisplayDimensioninstance, Boolean UseDoc, Int32 Broken)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SetBrokenLeader2(UseDoc, Broken);
        }
        public static Object GetNext2(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetNext2();
        }
        public static IDisplayDimensionObject IGetNext2(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return new IDisplayDimensionObject(IDisplayDimensioninstance.IDisplayDimensionInstance.IGetNext2());
        }
        public static Int32 GetType(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetType();
        }
        public static Object GetNext3(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GetNext3();
        }
        public static IDisplayDimensionObject IGetNext3(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return new IDisplayDimensionObject(IDisplayDimensioninstance.IDisplayDimensionInstance.IGetNext3());
        }
        public static Boolean AddDisplayEnt(IDisplayDimensionObject IDisplayDimensioninstance, Int32 Type, Object Data)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.AddDisplayEnt(Type, Data);
        }
        //public static Boolean IAddDisplayEnt(IDisplayDimensionObject IDisplayDimensioninstance, Int32 Type, Double& Data)
        //{
        //    return IDisplayDimensioninstance.IDisplayDimensionInstance.IAddDisplayEnt(Type, Data);
        //}
        public static Boolean AddDisplayText(IDisplayDimensionObject IDisplayDimensioninstance, String Text, Object Position, Object Format, Int32 Attachment, Double WidthFactor)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.AddDisplayText(Text, Position, Format, Attachment, WidthFactor);
        }
        //public static Boolean IAddDisplayText(IDisplayDimensionObject IDisplayDimensioninstance, String Text, Double& Position, TextFormatObject Format, Int32 Attachment, Double WidthFactor)
        //{
        //    return IDisplayDimensioninstance.IDisplayDimensionInstance.IAddDisplayText(Text, Position, Format, Attachment, WidthFactor);
        //}
        public static Boolean AutoJogOrdinate(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.AutoJogOrdinate();
        }
        public static Int32 WitnessVisibility(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.WitnessVisibility;
        }
        public static Int32 LeaderVisibility(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.LeaderVisibility;
        }
        public static Boolean BrokenLeader(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.BrokenLeader;
        }
        public static Boolean SmartWitness(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SmartWitness;
        }
        public static Boolean ShowParenthesis(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ShowParenthesis;
        }
        public static Int32 ArrowSide(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ArrowSide;
        }
        public static Boolean ShowDimensionValue(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ShowDimensionValue;
        }
        public static Boolean SolidLeader(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.SolidLeader;
        }
        public static Boolean Diametric(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.Diametric;
        }
        public static Boolean DisplayAsLinear(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.DisplayAsLinear;
        }
        public static Boolean ShortenedRadius(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ShortenedRadius;
        }
        public static Boolean DimensionToInside(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.DimensionToInside;
        }
        public static Boolean CenterText(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.CenterText;
        }
        public static Boolean Inspection(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.Inspection;
        }
        public static Double Scale2(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.Scale2;
        }
        public static Boolean DisplayAsChain(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.DisplayAsChain;
        }
        public static Boolean Jogged(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.Jogged;
        }
        public static Boolean IsLinked(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.IsLinked;
        }
        public static Int32 HorizontalJustification(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.HorizontalJustification;
        }
        public static Int32 VerticalJustification(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.VerticalJustification;
        }
        public static Boolean MarkedForDrawing(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.MarkedForDrawing;
        }
        public static Int32 Type2(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.Type2;
        }
        public static Boolean ShowTolParenthesis(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ShowTolParenthesis;
        }
        public static Boolean OffsetText(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.OffsetText;
        }
        public static Double MaxWitnessLineLength(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.MaxWitnessLineLength;
        }
        public static Boolean GridBubble(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.GridBubble;
        }
        public static Boolean Elevation(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.Elevation;
        }
        public static Int32 EndSymbol(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.EndSymbol;
        }
        public static Int32 ChamferTextStyle(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ChamferTextStyle;
        }
        public static Int32 ChamferPrecision(IDisplayDimensionObject IDisplayDimensioninstance, int Index)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ChamferPrecision[Index];
        }
        public static Boolean Split(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.Split;
        }
        public static Boolean ShowLowerParenthesis(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ShowLowerParenthesis;
        }
        public static Boolean LowerInspection(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.LowerInspection;
        }
        public static Boolean RunBidirectionally(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.RunBidirectionally;
        }
        public static Boolean ExtensionLineExtendsFromCenterOfSet(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ExtensionLineExtendsFromCenterOfSet;
        }
        public static Boolean ExtensionLineSameAsLeaderStyle(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ExtensionLineSameAsLeaderStyle;
        }
        public static Boolean ExtensionLineUseDocumentDisplay(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ExtensionLineUseDocumentDisplay;
        }
        public static Boolean Foreshortened(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.Foreshortened;
        }
        public static Boolean ArcExtensionLineOrOppositeSide(IDisplayDimensionObject IDisplayDimensioninstance)
        {
            return IDisplayDimensioninstance.IDisplayDimensionInstance.ArcExtensionLineOrOppositeSide;
        }
    }
}