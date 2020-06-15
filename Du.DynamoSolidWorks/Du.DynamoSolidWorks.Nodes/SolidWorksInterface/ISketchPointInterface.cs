using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class ISketchPointObject
    {
        public ISketchPoint ISketchPointInstance { get; set; }
        public ISketchPointObject(ISketchPoint ISketchPointinstance)
        {
            ISketchPointInstance = ISketchPointinstance;
        }
    }
    public static class ISketchPointInterface
    {
        public static Double GetCoords(ISketchPointObject ISketchPointinstance)
        {
            return ISketchPointinstance.ISketchPointInstance.GetCoords();
        }
        public static Object GetID(ISketchPointObject ISketchPointinstance)
        {
            return ISketchPointinstance.ISketchPointInstance.GetID();
        }
        public static Int32 IGetID(ISketchPointObject ISketchPointinstance)
        {
            return ISketchPointinstance.ISketchPointInstance.IGetID();
        }
        public static Boolean Select(ISketchPointObject ISketchPointinstance, Boolean AppendFlag)
        {
            return ISketchPointinstance.ISketchPointInstance.Select(AppendFlag);
        }
        public static Boolean SelectByMark(ISketchPointObject ISketchPointinstance, Boolean AppendFlag, Int32 Mark)
        {
            return ISketchPointinstance.ISketchPointInstance.SelectByMark(AppendFlag, Mark);
        }
        public static Boolean DeSelect(ISketchPointObject ISketchPointinstance)
        {
            return ISketchPointinstance.ISketchPointInstance.DeSelect();
        }
        public static Boolean SetCoords(ISketchPointObject ISketchPointinstance, Double Xx, Double Yy, Double Zz)
        {
            return ISketchPointinstance.ISketchPointInstance.SetCoords(Xx, Yy, Zz);
        }
        //public static Object GetFramePointTangent(ISketchPointObject ISketchPointinstance, Boolean& Status)
        //{
        //    return ISketchPointinstance.ISketchPointInstance.GetFramePointTangent(Status);
        //}
        //public static Double IGetFramePointTangent(ISketchPointObject ISketchPointinstance, Boolean& Status)
        //{
        //    return ISketchPointinstance.ISketchPointInstance.IGetFramePointTangent(Status);
        //}
        public static Boolean SetFramePointTangent(ISketchPointObject ISketchPointinstance, Object ToVector)
        {
            return ISketchPointinstance.ISketchPointInstance.SetFramePointTangent(ToVector);
        }
        //public static Boolean ISetFramePointTangent(ISketchPointObject ISketchPointinstance, Double& ToVector)
        //{
        //    return ISketchPointinstance.ISketchPointInstance.ISetFramePointTangent(ToVector);
        //}
        public static ISketchObject GetSketch(ISketchPointObject ISketchPointinstance)
        {
            return new ISketchObject(ISketchPointinstance.ISketchPointInstance.GetSketch());
        }
        public static Boolean Select2(ISketchPointObject ISketchPointinstance, Boolean Append, Int32 Mark)
        {
            return ISketchPointinstance.ISketchPointInstance.Select2(Append, Mark);
        }
        public static Boolean Select3(ISketchPointObject ISketchPointinstance, Boolean Append, Int32 Mark, ICalloutObject Callout)
        {
            return ISketchPointinstance.ISketchPointInstance.Select3(Append, Mark, Callout?.ICalloutInstance?.CastObj<Callout>());
        }
        public static Object GetRelations(ISketchPointObject ISketchPointinstance)
        {
            return ISketchPointinstance.ISketchPointInstance.GetRelations();
        }
        public static Int32 GetRelationsCount(ISketchPointObject ISketchPointinstance)
        {
            return ISketchPointinstance.ISketchPointInstance.GetRelationsCount();
        }
        public static ISketchRelationObject IGetRelations(ISketchPointObject ISketchPointinstance, Int32 Count)
        {
            return new ISketchRelationObject(ISketchPointinstance.ISketchPointInstance.IGetRelations(Count));
        }
        public static Boolean Select4(ISketchPointObject ISketchPointinstance, Boolean Append, ISelectDataObject Data)
        {
            return ISketchPointinstance.ISketchPointInstance.Select4(Append, Data?.ISelectDataInstance?.CastObj<SelectData>());
        }
        public static ISketchSlotObject GetSketchSlot(ISketchPointObject ISketchPointinstance)
        {
            return new ISketchSlotObject(ISketchPointinstance.ISketchPointInstance.GetSketchSlot());
        }
        public static Double X(ISketchPointObject ISketchPointinstance)
        {
            return ISketchPointinstance.ISketchPointInstance.X;
        }
        public static Double Y(ISketchPointObject ISketchPointinstance)
        {
            return ISketchPointinstance.ISketchPointInstance.Y;
        }
        public static Double Z(ISketchPointObject ISketchPointinstance)
        {
            return ISketchPointinstance.ISketchPointInstance.Z;
        }
        public static String Layer(ISketchPointObject ISketchPointinstance)
        {
            return ISketchPointinstance.ISketchPointInstance.Layer;
        }
        public static Int32 LayerOverride(ISketchPointObject ISketchPointinstance)
        {
            return ISketchPointinstance.ISketchPointInstance.LayerOverride;
        }
        public static Int32 Color(ISketchPointObject ISketchPointinstance)
        {
            return ISketchPointinstance.ISketchPointInstance.Color;
        }
        public static Int32 Status(ISketchPointObject ISketchPointinstance)
        {
            return ISketchPointinstance.ISketchPointInstance.Status;
        }
        public static Int32 Type(ISketchPointObject ISketchPointinstance)
        {
            return ISketchPointinstance.ISketchPointInstance.Type;
        }
    }
}