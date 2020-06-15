using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IFillSurfaceFeatureDataObject
    {
        public IFillSurfaceFeatureData IFillSurfaceFeatureDataInstance { get; set; }
        public IFillSurfaceFeatureDataObject(IFillSurfaceFeatureData IFillSurfaceFeatureDatainstance)
        {
            IFillSurfaceFeatureDataInstance = IFillSurfaceFeatureDatainstance;
        }
    }
    public static class IFillSurfaceFeatureDataInterface
    {
        //public static Object GetPatchBoundary(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance, Object& EntType)
        //{
        //    return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.GetPatchBoundary(EntType);
        //}
        public static Boolean SetPatchBoundary(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance, Object PatchVar)
        {
            return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.SetPatchBoundary(PatchVar);
        }
        public static Int32 GetPatchBoundaryCount(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance)
        {
            return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.GetPatchBoundaryCount();
        }
        //public static Object IGetPatchBoundary(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance, Int32 Count, Int32& EntType)
        //{
        //    return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.IGetPatchBoundary(Count, EntType);
        //}
        //public static Boolean ISetPatchBoundary(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance, Int32 Count, Object& DispArr)
        //{
        //    return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.ISetPatchBoundary(Count, DispArr);
        //}
        public static IFace2Object GetAlternateFace(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance)
        {
            return new IFace2Object(IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.GetAlternateFace());
        }
        public static IFace2Object ToggleAlternateFace(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance)
        {
            return new IFace2Object(IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.ToggleAlternateFace());
        }
        public static Int32 GetCurvatureControl(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance, Object EntityIn)
        {
            return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.GetCurvatureControl(EntityIn);
        }
        public static Boolean SetCurvatureControl(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance, Object EntityIn, Int32 ControlType, Boolean BAll)
        {
            return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.SetCurvatureControl(EntityIn, ControlType, BAll);
        }
        //public static Object GetConstraintCurves(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance, Object& TypeArr)
        //{
        //    return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.GetConstraintCurves(TypeArr);
        //}
        public static void SetConstraintCurves(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance, Object ConstraintVar)
        {
            IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.SetConstraintCurves(ConstraintVar);
        }
        public static Int32 GetConstraintCurvesCount(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance)
        {
            return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.GetConstraintCurvesCount();
        }
        //public static Object IGetConstraintCurves(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance, Int32 Count, Int32& TypeArr)
        //{
        //    return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.IGetConstraintCurves(Count, TypeArr);
        //}
        //public static void ISetConstraintCurves(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance, Int32 Count, Object& DispArr)
        //{
        //    return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.ISetConstraintCurves(Count, DispArr);
        //}
        public static Boolean AccessSelections(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static void ReleaseSelectionAccess(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance)
        {
            IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Boolean ReverseSurface(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance)
        {
            return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.ReverseSurface;
        }
        public static Boolean OptimizeSurface(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance)
        {
            return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.OptimizeSurface;
        }
        public static Int32 ResolutionControl(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance)
        {
            return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.ResolutionControl;
        }
        public static Boolean Merge(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance)
        {
            return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.Merge;
        }
        public static Boolean TryToFormSolid(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance)
        {
            return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.TryToFormSolid;
        }
        public static Boolean ReverseDirection(IFillSurfaceFeatureDataObject IFillSurfaceFeatureDatainstance)
        {
            return IFillSurfaceFeatureDatainstance.IFillSurfaceFeatureDataInstance.ReverseDirection;
        }
    }
}