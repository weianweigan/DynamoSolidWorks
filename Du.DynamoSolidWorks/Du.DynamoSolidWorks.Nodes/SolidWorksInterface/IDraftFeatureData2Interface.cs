using SolidWorks.Interop.sldworks;
using System;

namespace DynamoSolidWorks
{
    public class IDraftFeatureData2Object
    {
        public IDraftFeatureData2 IDraftFeatureData2Instance { get; set; }
        public IDraftFeatureData2Object(IDraftFeatureData2 IDraftFeatureData2instance)
        {
            IDraftFeatureData2Instance = IDraftFeatureData2instance;
        }
    }
    public static class IDraftFeatureData2Interface
    {
        public static Boolean IAccessSelections(IDraftFeatureData2Object IDraftFeatureData2instance, IModelDoc2Object TopDoc, IComponent2Object Component)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.IAccessSelections(TopDoc.IModelDoc2Instance as ModelDoc2, Component.IComponent2Instance as Component2);
        }
        public static Boolean AccessSelections(IDraftFeatureData2Object IDraftFeatureData2instance, Object TopDoc, Object Component)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.AccessSelections(TopDoc, Component);
        }
        public static void ReleaseSelectionAccess(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            IDraftFeatureData2instance.IDraftFeatureData2Instance.ReleaseSelectionAccess();
        }
        public static Int16 GetFacesToDraftCount(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.GetFacesToDraftCount();
        }
        public static IFace2Object IGetFacesToDraft(IDraftFeatureData2Object IDraftFeatureData2instance, Int16 Count)
        {
            return new IFace2Object(IDraftFeatureData2instance.IDraftFeatureData2Instance.IGetFacesToDraft(Count));
        }
        //public static void ISetFacesToDraft(IDraftFeatureData2Object IDraftFeatureData2instance, Int16 Count, Face2&Object FaceArray)
        //{
        //    return IDraftFeatureData2instance.IDraftFeatureData2Instance.ISetFacesToDraft(Count, FaceArray);
        //}
        public static Int16 GetPartingLinesCount(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.GetPartingLinesCount();
        }
        public static IEdgeObject IGetPartingLines(IDraftFeatureData2Object IDraftFeatureData2instance, Int16 Count)
        {
            return new IEdgeObject(IDraftFeatureData2instance.IDraftFeatureData2Instance.IGetPartingLines(Count));
        }
        //public static void ISetPartingLines(IDraftFeatureData2Object IDraftFeatureData2instance, Int16 Count, Edge&Object LineArray)
        //{
        //    return IDraftFeatureData2instance.IDraftFeatureData2Instance.ISetPartingLines(Count, LineArray);
        //}
        public static Boolean GetOtherFacesFlagAtIndex(IDraftFeatureData2Object IDraftFeatureData2instance, Int16 Index)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.GetOtherFacesFlagAtIndex(Index);
        }
        public static void SetOtherFacesFlagAtIndex(IDraftFeatureData2Object IDraftFeatureData2instance, Int16 Index, Boolean Flag)
        {
            IDraftFeatureData2instance.IDraftFeatureData2Instance.SetOtherFacesFlagAtIndex(Index, Flag);
        }
        public static Int16 GetDraftedEntityCount(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.GetDraftedEntityCount();
        }
        public static IEntityObject IGetDraftedEntities(IDraftFeatureData2Object IDraftFeatureData2instance, Int16 Count)
        {
            return new IEntityObject(IDraftFeatureData2instance.IDraftFeatureData2Instance.IGetDraftedEntities(Count));
        }
        public static Object GetDraftedEntities(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.GetDraftedEntities();
        }
        public static Int32 Type(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.Type;
        }
        public static Double Angle(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.Angle;
        }
        public static Boolean ReverseDirection(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.ReverseDirection;
        }
        public static Object FacesToDraft(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.FacesToDraft;
        }
        public static Object PartingLines(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.PartingLines;
        }
        public static Object NeutralPlane(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.NeutralPlane;
        }
        public static Object DirectionPull(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.DirectionPull;
        }
        public static Int16 FacePropagation(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.FacePropagation;
        }
        public static Int16 StepType(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.StepType;
        }
        public static Boolean AllowReducedAngle(IDraftFeatureData2Object IDraftFeatureData2instance)
        {
            return IDraftFeatureData2instance.IDraftFeatureData2Instance.AllowReducedAngle;
        }
    }
}