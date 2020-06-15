using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IPartingSurfaceFeatureDataObject
    {
        public IPartingSurfaceFeatureData IPartingSurfaceFeatureDataInstance { get; set; }
        public IPartingSurfaceFeatureDataObject(IPartingSurfaceFeatureData IPartingSurfaceFeatureDatainstance)
        {
            IPartingSurfaceFeatureDataInstance = IPartingSurfaceFeatureDatainstance;
        }
    }
    public static class IPartingSurfaceFeatureDataInterface
    {
        public static Boolean AccessSelections(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance.CastObj<ModelDoc2>(), Component.IComponent2Instance.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance)
        {
            IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetPartingLinesType(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.GetPartingLinesType();
        }
        public static Int32 GetPartingLinesCount(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.GetPartingLinesCount();
        }
        public static Object IGetPartingLines(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance, Int32 Count)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.IGetPartingLines(Count);
        }
        //public static void ISetPartingLines(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance, Int32 Count, Object& EntIn)
        //{
        //    return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.ISetPartingLines(Count, EntIn);
        //}
        public static Object PullDirectionBase(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.PullDirectionBase;
        }
        public static Int32 PullDirectionType(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.PullDirectionType;
        }
        public static Boolean ReverseAlignment(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.ReverseAlignment;
        }
        public static Object PartingLines(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.PartingLines;
        }
        public static Int32 PartingType(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.PartingType;
        }
        public static Double OffsetDistance(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.OffsetDistance;
        }
        public static Boolean ReverseOffsetDirection(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.ReverseOffsetDirection;
        }
        public static Double OffsetAngle(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.OffsetAngle;
        }
        public static Int32 TransitionType(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.TransitionType;
        }
        public static Double TransitionDistance(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.TransitionDistance;
        }
        public static Boolean Knit(IPartingSurfaceFeatureDataObject IPartingSurfaceFeatureDatainstance)
        {
            return IPartingSurfaceFeatureDatainstance.IPartingSurfaceFeatureDataInstance.Knit;
        }
    }
}