using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IJogFeatureDataObject
    {
        public IJogFeatureData IJogFeatureDataInstance { get; set; }
        public IJogFeatureDataObject(IJogFeatureData IJogFeatureDatainstance)
        {
            IJogFeatureDataInstance = IJogFeatureDatainstance;
        }
    }
    public static class IJogFeatureDataInterface
    {
        public static Boolean AccessSelections(IJogFeatureDataObject IJogFeatureDatainstance, Object TopDoc, Object Component)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.AccessSelections(TopDoc, Component);
        }
        public static Boolean IAccessSelections(IJogFeatureDataObject IJogFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.IAccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            IJogFeatureDatainstance.IJogFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Double IGetFixedPoint(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.IGetFixedPoint();
        }
        //public static void ISetFixedPoint(IJogFeatureDataObject IJogFeatureDatainstance, Double& Point)
        //{
        //    return IJogFeatureDatainstance.IJogFeatureDataInstance.ISetFixedPoint(Point);
        //}
        public static Int32 GetOffsetReferenceType(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.GetOffsetReferenceType();
        }
        public static ICustomBendAllowanceObject GetCustomBendAllowance(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return new ICustomBendAllowanceObject(IJogFeatureDatainstance.IJogFeatureDataInstance.GetCustomBendAllowance());
        }
        public static void SetCustomBendAllowance(IJogFeatureDataObject IJogFeatureDatainstance, ICustomBendAllowanceObject PBendData)
        {
            IJogFeatureDatainstance.IJogFeatureDataInstance.SetCustomBendAllowance(PBendData?.ICustomBendAllowanceInstance?.CastObj<CustomBendAllowance>());
        }
        public static Object FixedFace(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.FixedFace;
        }
        public static Boolean UseDefaultBendRadius(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.UseDefaultBendRadius;
        }
        public static Double BendRadius(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.BendRadius;
        }
        public static Double JogAngle(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.JogAngle;
        }
        public static Int32 OffsetType(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.OffsetType;
        }
        public static Object OffsetReference(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.OffsetReference;
        }
        public static Boolean ReverseOffset(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.ReverseOffset;
        }
        public static Boolean ReverseDirection(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.ReverseDirection;
        }
        public static Double OffsetDistance(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.OffsetDistance;
        }
        public static Int32 DimensionPositionType(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.DimensionPositionType;
        }
        public static Boolean FixProjectedLength(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.FixProjectedLength;
        }
        public static Int32 JogPositionType(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.JogPositionType;
        }
        public static Object FixedPoint(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.FixedPoint;
        }
        public static Boolean UseDefaultBendAllowance(IJogFeatureDataObject IJogFeatureDatainstance)
        {
            return IJogFeatureDatainstance.IJogFeatureDataInstance.UseDefaultBendAllowance;
        }
    }
}