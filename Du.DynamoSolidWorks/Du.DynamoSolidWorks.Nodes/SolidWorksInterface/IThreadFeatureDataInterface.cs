using Du.SolidWorks.Extension;
using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IThreadFeatureDataObject
    {
        public IThreadFeatureData IThreadFeatureDataInstance { get; set; }
        public IThreadFeatureDataObject(IThreadFeatureData IThreadFeatureDatainstance)
        {
            IThreadFeatureDataInstance = IThreadFeatureDatainstance;
        }
    }
    public static class IThreadFeatureDataInterface
    {
        public static Boolean AccessSelections(IThreadFeatureDataObject IThreadFeatureDatainstance, IModelDocObject TopDoc, IComponentObject Component)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.AccessSelections(TopDoc.IModelDocInstance?.CastObj<ModelDoc>(), Component?.IComponentInstance?.CastObj<Component>());
        }
        public static void ReleaseSelectionAccess(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            IThreadFeatureDatainstance.IThreadFeatureDataInstance.ReleaseSelectionAccess();
        }
        public static Object GetEndConditionReference(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.GetEndConditionReference();
        }
        public static void SetEndConditionReference(IThreadFeatureDataObject IThreadFeatureDatainstance, Object Value)
        {
            IThreadFeatureDatainstance.IThreadFeatureDataInstance.SetEndConditionReference(Value);
        }
        public static void InitializeThreadData(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            IThreadFeatureDatainstance.IThreadFeatureDataInstance.InitializeThreadData();
        }
        public static IEdgeObject Edge(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return new IEdgeObject(IThreadFeatureDatainstance.IThreadFeatureDataInstance.Edge);
        }
        public static Object StartEntity(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.StartEntity;
        }
        public static Boolean Offset(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.Offset;
        }
        public static Boolean ReverseOffset(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.ReverseOffset;
        }
        public static Double OffsetDistance(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.OffsetDistance;
        }
        public static Double ThreadStartAngle(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.ThreadStartAngle;
        }
        public static Int32 EndCondition(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.EndCondition;
        }
        public static Boolean ReverseDirection(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.ReverseDirection;
        }
        public static Double BlindDepth(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.BlindDepth;
        }
        public static Boolean EndConditionOffset(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.EndConditionOffset;
        }
        public static Boolean EndConditionOffsetReverse(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.EndConditionOffsetReverse;
        }
        public static Double EndConditionOffsetDistance(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.EndConditionOffsetDistance;
        }
        public static Double Revolutions(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.Revolutions;
        }
        public static Boolean MaintainThreadLength(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.MaintainThreadLength;
        }
        public static String Type(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.Type;
        }
        public static String Size(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.Size;
        }
        public static Boolean DiameterOverride(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.DiameterOverride;
        }
        public static Double Diameter(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.Diameter;
        }
        public static Boolean PitchOverride(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.PitchOverride;
        }
        public static Double Pitch(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.Pitch;
        }
        public static Int32 ThreadMethod(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.ThreadMethod;
        }
        public static Boolean MirrorProfile(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.MirrorProfile;
        }
        public static Int32 MirrorType(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.MirrorType;
        }
        public static Double RotationAngle(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.RotationAngle;
        }
        public static Object ProfileLocation(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.ProfileLocation;
        }
        public static Boolean RightHanded(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.RightHanded;
        }
        public static Int32 NumberOfStarts(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.NumberOfStarts;
        }
        public static Boolean MultipleStart(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.MultipleStart;
        }
        public static Boolean TrimStartFace(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.TrimStartFace;
        }
        public static Boolean TrimEndFace(IThreadFeatureDataObject IThreadFeatureDatainstance)
        {
            return IThreadFeatureDatainstance.IThreadFeatureDataInstance.TrimEndFace;
        }
    }
}