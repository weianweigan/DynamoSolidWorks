using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchSegmentObject
    {
        public ISketchSegment ISketchSegmentInstance { get; set; }
        public ISketchSegmentObject(ISketchSegment ISketchSegmentinstance)
        {
            ISketchSegmentInstance = ISketchSegmentinstance;
        }
    }
    public static class ISketchSegmentInterface
    {
        public static Int32 GetType(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.GetType();
        }
        public static Object GetID(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.GetID();
        }
        public static Int32 IGetID(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.IGetID();
        }
        public static Boolean Select(ISketchSegmentObject ISketchSegmentinstance, Boolean AppendFlag)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.Select(AppendFlag);
        }
        public static Boolean SelectByMark(ISketchSegmentObject ISketchSegmentinstance, Boolean AppendFlag, Int32 Mark)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.SelectByMark(AppendFlag, Mark);
        }
        public static Boolean DeSelect(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.DeSelect();
        }
        public static Object GetCurve(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.GetCurve();
        }
        public static ICurveObject IGetCurve(ISketchSegmentObject ISketchSegmentinstance)
        {
            return new ICurveObject(ISketchSegmentinstance.ISketchSegmentInstance.IGetCurve());
        }
        public static ISketchObject GetSketch(ISketchSegmentObject ISketchSegmentinstance)
        {
            return new ISketchObject(ISketchSegmentinstance.ISketchSegmentInstance.GetSketch());
        }
        public static Object GetConstraints(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.GetConstraints();
        }
        public static Int32 IGetConstraintsCount(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.IGetConstraintsCount();
        }
        public static String IGetConstraints(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.IGetConstraints();
        }
        public static Double GetLength(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.GetLength();
        }
        public static Boolean Select2(ISketchSegmentObject ISketchSegmentinstance, Boolean Append, Int32 Mark)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.Select2(Append, Mark);
        }
        public static Boolean Select3(ISketchSegmentObject ISketchSegmentinstance, Boolean Append, Int32 Mark, ICalloutObject Callout)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.Select3(Append, Mark, Callout?.ICalloutInstance?.CastObj<Callout>());
        }
        public static Object GetRelations(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.GetRelations();
        }
        public static Int32 GetRelationsCount(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.GetRelationsCount();
        }
        public static ISketchRelationObject IGetRelations(ISketchSegmentObject ISketchSegmentinstance, Int32 Count)
        {
            return new ISketchRelationObject(ISketchSegmentinstance.ISketchSegmentInstance.IGetRelations(Count));
        }
        public static Boolean Select4(ISketchSegmentObject ISketchSegmentinstance, Boolean Append, ISelectDataObject Data)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.Select4(Append, Data?.ISelectDataInstance?.CastObj<SelectData>());
        }
        public static IBody2Object CreateWireBody(ISketchSegmentObject ISketchSegmentinstance)
        {
            return new IBody2Object(ISketchSegmentinstance.ISketchSegmentInstance.CreateWireBody());
        }
        public static Object GetSketchPaths(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.GetSketchPaths();
        }
        public static ISketchPathObject IGetSketchPaths(ISketchSegmentObject ISketchSegmentinstance, Int32 Count)
        {
            return new ISketchPathObject(ISketchSegmentinstance.ISketchSegmentInstance.IGetSketchPaths(Count));
        }
        public static Int32 GetSketchPathCount(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.GetSketchPathCount();
        }
        public static void SplitEntity(ISketchSegmentObject ISketchSegmentinstance, Double X, Double Y, Double Z, Double ClosedX, Double ClosedY, Double ClosedZ)
        {
            ISketchSegmentinstance.ISketchSegmentInstance.SplitEntity(X, Y, Z, ClosedX, ClosedY, ClosedZ);
        }
        public static void JogLine(ISketchSegmentObject ISketchSegmentinstance, Double XOnLine, Double YOnLine, Double ZOnLine, Double XOnJog, Double YOnJog, Double ZOnJog)
        {
            ISketchSegmentinstance.ISketchSegmentInstance.JogLine(XOnLine, YOnLine, ZOnLine, XOnJog, YOnJog, ZOnJog);
        }
        public static ISketchSlotObject GetSketchSlot(ISketchSegmentObject ISketchSegmentinstance)
        {
            return new ISketchSlotObject(ISketchSegmentinstance.ISketchSegmentInstance.GetSketchSlot());
        }
        public static Boolean IsBendLine(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.IsBendLine();
        }
        public static Boolean SelectChain(ISketchSegmentObject ISketchSegmentinstance, Boolean Append, ISelectDataObject Data)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.SelectChain(Append, Data?.ISelectDataInstance.CastObj<SelectData>());
        }
        public static Boolean EqualSegment(ISketchSegmentObject ISketchSegmentinstance, Int32 SketchType, Int32 SegmentPoints)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.EqualSegment(SketchType, SegmentPoints);
        }
        public static String GetName(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.GetName();
        }
        public static String Layer(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.Layer;
        }
        public static Int32 LayerOverride(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.LayerOverride;
        }
        public static Int32 Color(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.Color;
        }
        public static Int32 Style(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.Style;
        }
        public static Int32 Width(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.Width;
        }
        public static Boolean ConstructionGeometry(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.ConstructionGeometry;
        }
        public static Int32 Status(ISketchSegmentObject ISketchSegmentinstance)
        {
            return ISketchSegmentinstance.ISketchSegmentInstance.Status;
        }
    }
}