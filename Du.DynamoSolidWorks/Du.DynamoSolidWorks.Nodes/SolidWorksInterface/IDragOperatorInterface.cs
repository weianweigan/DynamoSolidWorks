using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDragOperatorObject
    {
        public IDragOperator IDragOperatorInstance { get; set; }
        public IDragOperatorObject(IDragOperator IDragOperatorinstance)
        {
            IDragOperatorInstance = IDragOperatorinstance;
        }
    }
    public static class IDragOperatorInterface
    {
        public static Boolean AddComponent(IDragOperatorObject IDragOperatorinstance, Object PDisp, Boolean AppendFlag)
        {
            return IDragOperatorinstance.IDragOperatorInstance.AddComponent(PDisp, AppendFlag);
        }
        public static Boolean IAddComponent(IDragOperatorObject IDragOperatorinstance, IComponent2Object PComp, Boolean AppendFlag)
        {
            return IDragOperatorinstance.IDragOperatorInstance.IAddComponent(PComp.IComponent2Instance as Component2, AppendFlag);
        }
        public static Boolean BeginDrag(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.BeginDrag();
        }
        public static Boolean EndDrag(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.EndDrag();
        }
        public static Boolean Drag(IDragOperatorObject IDragOperatorinstance, Object PXform)
        {
            return IDragOperatorinstance.IDragOperatorInstance.Drag(PXform);
        }
        public static Boolean IDrag(IDragOperatorObject IDragOperatorinstance, IMathTransformObject PXform)
        {
            return IDragOperatorinstance.IDragOperatorInstance.IDrag(PXform.IMathTransformInstance as MathTransform);
        }
        public static Int32 AddDynamicClearance(IDragOperatorObject IDragOperatorinstance, Object Comp1, Object Comp2, Double Value, Boolean AppendFlag, Boolean ShowDim)
        {
            return IDragOperatorinstance.IDragOperatorInstance.AddDynamicClearance(Comp1, Comp2, Value, AppendFlag, ShowDim);
        }
        public static Int32 IAddDynamicClearance(IDragOperatorObject IDragOperatorinstance, IComponent2Object Comp1, IComponent2Object Comp2, Double Value, Boolean AppendFlag, Boolean ShowDim)
        {
            return IDragOperatorinstance.IDragOperatorInstance.IAddDynamicClearance(Comp1.IComponent2Instance as Component2, Comp2.IComponent2Instance as Component2, Value, AppendFlag, ShowDim);
        }
        public static Boolean CollisionDetection(IDragOperatorObject IDragOperatorinstance, Object EntityArray, Boolean PartOnly, Boolean StopAt)
        {
            return IDragOperatorinstance.IDragOperatorInstance.CollisionDetection(EntityArray, PartOnly, StopAt);
        }
        //public static Boolean ICollisionDetection(IDragOperatorObject IDragOperatorinstance, Int32 Count, Component2&Object ComponentArray, Boolean PartOnly, Boolean StopAt)
        //{
        //    return IDragOperatorinstance.IDragOperatorInstance.ICollisionDetection(Count, ComponentArray, PartOnly, StopAt);
        //}
        //public static Boolean GetDragPoint(IDragOperatorObject IDragOperatorinstance, Object& Point)
        //{
        //    return IDragOperatorinstance.IDragOperatorInstance.GetDragPoint(Point);
        //}
        public static Boolean SetDragPoint(IDragOperatorObject IDragOperatorinstance, Object Point)
        {
            return IDragOperatorinstance.IDragOperatorInstance.SetDragPoint(Point);
        }
        //public static Boolean IGetDragPoint(IDragOperatorObject IDragOperatorinstance, Double& Point)
        //{
        //    return IDragOperatorinstance.IDragOperatorInstance.IGetDragPoint(Point);
        //}
        //public static Boolean ISetDragPoint(IDragOperatorObject IDragOperatorinstance, Double& Point)
        //{
        //    return IDragOperatorinstance.IDragOperatorInstance.ISetDragPoint(Point);
        //}
        //public static Boolean DragAsUI(IDragOperatorObject IDragOperatorinstance, MathTransformObject PXform)
        //{
        //    return IDragOperatorinstance.IDragOperatorInstance.DragAsUI(PXform);
        //}
        public static Boolean IsRelaxationEval(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.IsRelaxationEval;
        }
        public static Int16 DragMode(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.DragMode;
        }
        public static Boolean IsDragSpecific(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.IsDragSpecific;
        }
        public static Int16 TransformType(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.TransformType;
        }
        public static Boolean IsDragByRay(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.IsDragByRay;
        }
        public static Boolean CollisionDetectionEnabled(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.CollisionDetectionEnabled;
        }
        public static Boolean HighlightClashes(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.HighlightClashes;
        }
        public static Boolean HearClashes(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.HearClashes;
        }
        public static Boolean ApplyToThisConfiguration(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.ApplyToThisConfiguration;
        }
        public static Boolean IgnoreComplexSurfaces(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.IgnoreComplexSurfaces;
        }
        public static Boolean SmartMating(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.SmartMating;
        }
        public static Boolean DynamicClearanceEnabled(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.DynamicClearanceEnabled;
        }
        public static Double Clearance(IDragOperatorObject IDragOperatorinstance, int Index)
        {
            return IDragOperatorinstance.IDragOperatorInstance.Clearance[Index];
        }
        public static Boolean DragCorrected(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.DragCorrected;
        }
        public static Boolean UseAbsoluteTransform(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.UseAbsoluteTransform;
        }
        public static Boolean GraphicsRedrawEnabled(IDragOperatorObject IDragOperatorinstance)
        {
            return IDragOperatorinstance.IDragOperatorInstance.GraphicsRedrawEnabled;
        }
    }
}