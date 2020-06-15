using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IStructuralMemberFeatureDataObject
    {
        public IStructuralMemberFeatureData IStructuralMemberFeatureDataInstance { get; set; }
        public IStructuralMemberFeatureDataObject(IStructuralMemberFeatureData IStructuralMemberFeatureDatainstance)
        {
            IStructuralMemberFeatureDataInstance = IStructuralMemberFeatureDatainstance;
        }
    }
    public static class IStructuralMemberFeatureDataInterface
    {
        public static Boolean AccessSelections(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.AccessSelections(TopDoc.IModelDoc2Instance?.CastObj<ModelDoc2>(), Component?.IComponent2Instance?.CastObj<Component2>());
        }
        public static void ReleaseSelectionAccess(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Int32 GetPathSegmentsCount(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.GetPathSegmentsCount();
        }
        public static ISketchSegmentObject IGetPathSegments(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance, Int32 Count)
        {
            return new ISketchSegmentObject(IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.IGetPathSegments(Count));
        }
        //public static void ISetPathSegments(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance, Int32 Count, SketchSegment&Object SegArr)
        //{
        //    return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.ISetPathSegments(Count, SegArr);
        //}
        public static Object GetConnectionPoints(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.GetConnectionPoints();
        }
        public static Int32 GetConnectionPointsCount(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.GetConnectionPointsCount();
        }
        public static ISketchPointObject IGetConnectionPoints(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance, Int32 Count)
        {
            return new ISketchPointObject(IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.IGetConnectionPoints(Count));
        }
        public static ISketchSegmentObject GetPathSegmentAt(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance, IBody2Object PBodyIn)
        {
            return new ISketchSegmentObject(IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.GetPathSegmentAt(PBodyIn?.IBody2Instance.CastObj<Body2>()));
        }
        public static Int32 GetGroupsCount(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.GetGroupsCount();
        }
        public static IStructuralMemberGroupObject IGetGroups(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance, Int32 Count)
        {
            return new IStructuralMemberGroupObject(IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.IGetGroups(Count));
        }
        //public static void ISetGroups(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance, Int32 Count, StructuralMemberGroup&Object SegGroups)
        //{
        //    return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.ISetGroups(Count, SegGroups);
        //}
        //public static Object GetSketchSegments(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance, Body2Object PBodyIn)
        //{
        //    return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.GetSketchSegments(PBodyIn);
        //}
        public static Object PathSegments(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.PathSegments;
        }
        public static Boolean ApplyCornerTreatment(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.ApplyCornerTreatment;
        }
        public static Int32 CornerTreatmentType(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.CornerTreatmentType;
        }
        public static Double RotationAngle(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.RotationAngle;
        }
        public static ISketchPointObject LocateProfilePoint(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return new ISketchPointObject(IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.LocateProfilePoint);
        }
        public static Int32 ConnectionType(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance, ISketchPointObject SketchPoint)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.ConnectionType[SketchPoint.ISketchPointInstance.CastObj<SketchPoint>()];
        }
        public static String WeldmentProfilePath(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.WeldmentProfilePath;
        }
        public static Object Groups(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.Groups;
        }
        public static Int32 ConnectedSegmentsOption(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.ConnectedSegmentsOption;
        }
        public static Boolean AllowProtrusion(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.AllowProtrusion;
        }
        public static String ConfigurationName(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.ConfigurationName;
        }
        public static Boolean TransferMaterial(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.TransferMaterial;
        }
        public static String LibraryProfileMaterial(IStructuralMemberFeatureDataObject IStructuralMemberFeatureDatainstance)
        {
            return IStructuralMemberFeatureDatainstance.IStructuralMemberFeatureDataInstance.LibraryProfileMaterial;
        }
    }
}