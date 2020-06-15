using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IRefPlaneFeatureDataObject
    {
        public IRefPlaneFeatureData IRefPlaneFeatureDataInstance { get; set; }
        public IRefPlaneFeatureDataObject(IRefPlaneFeatureData IRefPlaneFeatureDatainstance)
        {
            IRefPlaneFeatureDataInstance = IRefPlaneFeatureDatainstance;
        }
    }
    public static class IRefPlaneFeatureDataInterface
    {
        public static Boolean AccessSelections(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance)
        {
            IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetSelectionsCount(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.GetSelectionsCount();
        }
        public static Object IGetSelections(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance, Int32 Count)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.IGetSelections(Count);
        }
        //public static void ISetSelections(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance, Int32 Count, Object& Entities)
        //{
        //    return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.ISetSelections(Count, Entities);
        //}
        public static Int32 Type(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.Type;
        }
        public static Boolean AutoSize(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.AutoSize;
        }
        public static Double Angle(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.Angle;
        }
        public static Double Distance(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.Distance;
        }
        public static Boolean ReverseDirection(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.ReverseDirection;
        }
        public static Boolean OriginOnCurve(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.OriginOnCurve;
        }
        public static Object Selections(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.Selections;
        }
        public static Int32 ProjectionType(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.ProjectionType;
        }
        public static Boolean UseNormalPlane(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.UseNormalPlane;
        }
        public static Int32 SolutionIndex(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.SolutionIndex;
        }
        public static Object Reference(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance, int Index)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.Reference[Index];
        }
        public static Int32 Constraint(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance, int Index)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.Constraint[Index];
        }
        public static Double AngleOrDistance(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance, int Index)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.AngleOrDistance[Index];
        }
        public static Int32 Type2(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.Type2;
        }
        public static Boolean UpdatePlane(IRefPlaneFeatureDataObject IRefPlaneFeatureDatainstance)
        {
            return IRefPlaneFeatureDatainstance.IRefPlaneFeatureDataInstance.UpdatePlane;
        }
    }
}