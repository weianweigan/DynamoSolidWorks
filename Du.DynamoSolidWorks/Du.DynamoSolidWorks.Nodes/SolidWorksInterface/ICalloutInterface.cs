using Autodesk.DesignScript.Runtime;
using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;

namespace DynamoSolidWorks
{
    public class ICalloutObject
    {
        public ICallout ICalloutInstance { get; set; }
        public ICalloutObject(ICallout ICalloutinstance)
        {
            ICalloutInstance = ICalloutinstance;
        }
    }
    public static class ICalloutInterface
    {
        [MultiReturn(SWValueConst.Outx, SWValueConst.Outy, SWValueConst.Outz)]
        public static Dictionary<string, double> GetTargetPoint(ICalloutObject ICalloutinstance, Int32 RowID)
        {
            ICalloutinstance.ICalloutInstance.GetTargetPoint(RowID, out double XPos, out double YPos, out double ZPos);

            return new Dictionary<string, double>() { { SWValueConst.Outx, XPos }, { SWValueConst.Outy, YPos }, { SWValueConst.Outz, ZPos } };
        }
        public static void SetTargetPoint(ICalloutObject ICalloutinstance, Int32 RowID, Double XPos, Double YPos, Double ZPos)
        {
            ICalloutinstance.ICalloutInstance.SetTargetPoint(RowID, XPos, YPos, ZPos);
        }
        public static void UpdatePosition(ICalloutObject ICalloutinstance, Double XPos, Double YPos, Double ZPos)
        {
            ICalloutinstance.ICalloutInstance.UpdatePosition(XPos, YPos, ZPos);
        }
        public static Boolean Display(ICalloutObject ICalloutinstance, Boolean Display)
        {
            return ICalloutinstance.ICalloutInstance.Display(Display);
        }

        //ref not solve
        public static Boolean GetLeader(ICalloutObject ICalloutinstance, Boolean Visible, Boolean Multiple)
        {
            return ICalloutinstance.ICalloutInstance.GetLeader(Visible, Multiple);
        }
        public static Boolean SetLeader(ICalloutObject ICalloutinstance, Boolean Visible, Boolean Multiple)
        {
            return ICalloutinstance.ICalloutInstance.SetLeader(Visible, Multiple);
        }
        public static String Label(ICalloutObject ICalloutinstance)
        {
            return ICalloutinstance.ICalloutInstance.Label;
        }
        public static Int32 TargetStyle(ICalloutObject ICalloutinstance)
        {
            return ICalloutinstance.ICalloutInstance.TargetStyle;
        }
        public static Boolean TextBox(ICalloutObject ICalloutinstance)
        {
            return ICalloutinstance.ICalloutInstance.TextBox;
        }
        public static String Label2(ICalloutObject ICalloutinstance, int RowID)
        {
            return ICalloutinstance.ICalloutInstance.Label2[RowID];
        }
        public static String Value(ICalloutObject ICalloutinstance, int RowID)
        {
            return ICalloutinstance.ICalloutInstance.Value[RowID];
        }
        public static Boolean ValueInactive(ICalloutObject ICalloutinstance, int RowID)
        {
            return ICalloutinstance.ICalloutInstance.ValueInactive[RowID];
        }
        public static Int32 OpaqueColor(ICalloutObject ICalloutinstance)
        {
            return ICalloutinstance.ICalloutInstance.OpaqueColor;
        }
        public static Int32 TextColor(ICalloutObject ICalloutinstance, int RowID)
        {
            return ICalloutinstance.ICalloutInstance.TextColor[RowID];
        }
        public static Boolean MultipleLeaders(ICalloutObject ICalloutinstance)
        {
            return ICalloutinstance.ICalloutInstance.MultipleLeaders;
        }
        public static IMathPointObject Position(ICalloutObject ICalloutinstance)
        {
            return new IMathPointObject(ICalloutinstance.ICalloutInstance.Position);
        }
        public static Boolean SkipColon(ICalloutObject ICalloutinstance)
        {
            return ICalloutinstance.ICalloutInstance.SkipColon;
        }
        public static Boolean IgnoreValue(ICalloutObject ICalloutinstance, int RowID)
        {
            return ICalloutinstance.ICalloutInstance.IgnoreValue[RowID];
        }
        public static ITextFormatObject TextFormat(ICalloutObject ICalloutinstance)
        {
            return new ITextFormatObject(ICalloutinstance.ICalloutInstance.TextFormat);
        }
        public static Int32 FontSize(ICalloutObject ICalloutinstance)
        {
            return ICalloutinstance.ICalloutInstance.FontSize;
        }
    }
}