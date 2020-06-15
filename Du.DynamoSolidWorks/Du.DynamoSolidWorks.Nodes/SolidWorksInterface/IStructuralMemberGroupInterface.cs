using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IStructuralMemberGroupObject
    {
        public IStructuralMemberGroup IStructuralMemberGroupInstance { get; set; }
        public IStructuralMemberGroupObject(IStructuralMemberGroup IStructuralMemberGroupinstance)
        {
            IStructuralMemberGroupInstance = IStructuralMemberGroupinstance;
        }
    }
    public static class IStructuralMemberGroupInterface
    {
        public static Int32 GetSegmentsCount(IStructuralMemberGroupObject IStructuralMemberGroupinstance)
        {
            return IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.GetSegmentsCount();
        }
        public static ISketchSegmentObject IGetSegments(IStructuralMemberGroupObject IStructuralMemberGroupinstance, Int32 Count)
        {
            return new ISketchSegmentObject(IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.IGetSegments(Count));
        }
        //public static void ISetSegments(IStructuralMemberGroupObject IStructuralMemberGroupinstance, Int32 Count, SketchSegment&Object SegArr)
        //{
        //    return IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.ISetSegments(Count, SegArr);
        //}
        public static Object Segments(IStructuralMemberGroupObject IStructuralMemberGroupinstance)
        {
            return IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.Segments;
        }
        public static Double Angle(IStructuralMemberGroupObject IStructuralMemberGroupinstance)
        {
            return IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.Angle;
        }
        public static Boolean ApplyCornerTreatment(IStructuralMemberGroupObject IStructuralMemberGroupinstance)
        {
            return IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.ApplyCornerTreatment;
        }
        public static Int32 CornerTreatmentType(IStructuralMemberGroupObject IStructuralMemberGroupinstance)
        {
            return IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.CornerTreatmentType;
        }
        public static ISketchPointObject LocateProfilePoint(IStructuralMemberGroupObject IStructuralMemberGroupinstance)
        {
            return new ISketchPointObject(IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.LocateProfilePoint);
        }
        public static Double GapWithinGroup(IStructuralMemberGroupObject IStructuralMemberGroupinstance)
        {
            return IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.GapWithinGroup;
        }
        public static Double GapForOtherGroups(IStructuralMemberGroupObject IStructuralMemberGroupinstance)
        {
            return IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.GapForOtherGroups;
        }
        public static Boolean MirrorProfile(IStructuralMemberGroupObject IStructuralMemberGroupinstance)
        {
            return IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.MirrorProfile;
        }
        public static Int32 MirrorProfileAxis(IStructuralMemberGroupObject IStructuralMemberGroupinstance)
        {
            return IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.MirrorProfileAxis;
        }
        public static Object AlignmentVector(IStructuralMemberGroupObject IStructuralMemberGroupinstance)
        {
            return IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.AlignmentVector;
        }
        public static Int32 AlignAxis(IStructuralMemberGroupObject IStructuralMemberGroupinstance)
        {
            return IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.AlignAxis;
        }
        public static Boolean MergeArcSegmentBodies(IStructuralMemberGroupObject IStructuralMemberGroupinstance)
        {
            return IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.MergeArcSegmentBodies;
        }
        public static Boolean MiterMergeCondition(IStructuralMemberGroupObject IStructuralMemberGroupinstance)
        {
            return IStructuralMemberGroupinstance.IStructuralMemberGroupInstance.MiterMergeCondition;
        }
    }
}